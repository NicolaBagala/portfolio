USE StackOverflow2010;

-- Declare and initialise variables that we are going to need.
DECLARE @QuestionId AS INT, @UpvoteId AS INT, @DownVoteId AS INT, @FavoriteId AS INT
SELECT @QuestionId = Id FROM PostTypes WHERE Type = 'Question'
SELECT @UpvoteId = Id FROM VoteTypes WHERE VoteTypes.Name = 'UpMod'
SELECT @DownVoteId = Id FROM VoteTypes WHERE VoteTypes.Name = 'DownMod'
SELECT @FavoriteId = Id FROM VoteTypes WHERE VoteTypes.Name = 'Favorite';

-- Select the Id and CreationDate of question posts only into a temporary table, for convenience.
SELECT 
	Id AS id, 
	CreationDate AS creation_date
INTO #questions
FROM Posts 
WHERE PostTypeId = @QuestionId

-- The database I downloaded is missing the Tags and PostTags tables that the original should have. Let's
-- create and populate them as temporary tables, since we won't need them anymore after the script is run.

-- Extract tags from every question post, together with the post ID, and make them into a temporary table.
-- Tags are contained in the Tags column as a single string, e.g. <tag1><tag2>. We use > as a separator and then eliminate <.
-- All SO questions must have at least one tag, so there's no need to check for posts with no tags.
-- Note that some posts are tagged with 'nan' or 'null', which results in 'nan' being written in tag_name. As this could be interpreted as actual NaN during analysis, let's 
-- change them by appending the ' (tag)' suffix.
SELECT
	CASE 
		WHEN TRIM('<' FROM value) = 'nan' THEN 'nan (tag)'
		WHEN TRIM('<' FROM value) = 'null' THEN 'null (tag)'
		ELSE TRIM('<' FROM value)
	END AS tag_name,	
	Id AS post_id
INTO #extracted_tags
FROM Posts
-- Since the separator > is at the end of every tag string, we need to remove it, or STRING_SPLIT will always yield a trailing empty tag.
CROSS APPLY STRING_SPLIT(TRIM('>' FROM Tags), '>')
WHERE Id IN (SELECT id FROM #questions)

-- Populate the #tags table, counting how many times each tag appears in all the questions.
SELECT 
	IDENTITY(int, 1, 1) AS id,
	tag_name, 
	COUNT(tag_name) as TagCount
INTO #tags
FROM #extracted_tags
GROUP BY tag_name
ORDER BY tag_name


-- Populate the #post_tags table.
SELECT 
	post_id,
	#tags.Id AS tag_id
INTO #post_tags
FROM #extracted_tags
LEFT JOIN #tags
  ON #extracted_tags.tag_name = #tags.tag_name;

-- Creation of the #question_calendar table
-- Posts in the database were created in the date range July 2008 to December 2012. We need a #question_calendar table that associates
-- every question post to every year-month pair in that range that is not older than the question's creation date.
-- E.g., if a question was created in May 2009, in the #question_calendar table it will be associated to the pairs
-- 2009-5, 2009-6, ..., 2010-12.
WITH
date_range -- Generates a table with all possible year/month pairs from July 2008 to December 2010.
AS (
	SELECT * 
	FROM (SELECT DISTINCT YEAR(CreationDate) AS years FROM Votes) as y
	  CROSS JOIN (SELECT DISTINCT MONTH(CreationDate) AS months FROM Votes) as m
	  CROSS JOIN (SELECT 1 AS days) as d
	  ORDER BY years ASC, months ASC
	  OFFSET 6 ROWS -- The first year-month pair we care about is 2008-7!
)

SELECT -- Create the #question_calendar table proper.
	id,
	#questions.creation_date,
	date_range.years AS 'year',
	date_range.months AS 'month'
INTO #question_calendar
FROM #questions
  LEFT JOIN date_range
  ON DATEFROMPARTS(date_range.years, date_range.months, 1) >= DATEFROMPARTS(YEAR(#questions.creation_date), MONTH(#questions.creation_date), 1);


-- Creation of the #vote_breakdown table
-- We need a #vote_breakdown table listing how many upvotes and downvotes each question has received in a given year and month
-- within the range of interest, as well as how many times each question has been marked as favorite during that time.
-- If a question didn't receive upvotes, downvotes, or wasn't "favorited" during a given month, the relevant column
-- of #vote_breakdown will display zero. However, if a question didn't receive ANY votes during a given month, the
-- row for that month for that question will simply not appear. We will fix this later, by adding an all-zero row 
-- in such cases.

WITH
-- We only care about upvotes, downvotes, and favorites.
relevant_votes 
AS (SELECT 
		Id AS vote_id, 
		PostId AS question_id, 
		VoteTypeId, 
		CreationDate
	FROM Votes 
	WHERE VoteTypeId IN (@UpvoteId, @DownVoteId, @FavoriteId)
),

-- Table listing all relevant votes, along with vote creation date, for each question in the database.
questions_with_vote_type 
AS (
	SELECT 
		#questions.Id AS question_id, 
		YEAR(relevant_votes.CreationDate) AS vote_year,
		MONTH(relevant_votes.CreationDate) AS vote_month,
		VoteTypeId
	FROM #questions
	  INNER JOIN relevant_votes
	  ON #questions.Id = relevant_votes.question_id
)

-- #vote_breakdown proper. For every year-month when a question received an up/downvote or was favorited, there is a row
-- in the table with the vote count for that question during that time.
SELECT 
	question_id,
	vote_year,
	vote_month,
	COUNT(CASE VoteTypeId WHEN @UpvoteId THEN 1 ELSE NULL END) AS upvotes, --CASE and NULL are so that upvotes are counted (NULLs are ignored). Similarly for the two rows below.
	COUNT(CASE VoteTypeId WHEN @DownVoteId THEN 1 ELSE NULL END) AS downvotes,
	COUNT(CASE VoteTypeId WHEN @FavoriteId THEN 1 ELSE NULL END) AS favorites
INTO  #vote_breakdown
FROM questions_with_vote_type
GROUP BY question_id, vote_year, vote_month;

-- Creation of the #full_breakdown table
-- The #full_breakdown table is like #vote_breakdown, except it includes rows where upvote, downvote, and favorite
-- counts are all zero. E.g., if question 43 did not receive ANY vote in May 2009, this table contains a row like this:
-- 
-- question_id    year    month    upvotes    downvotes   favorites
--     43         2009      5         0           0          0
-- 
-- Rows like that are NOT present in #vote_breakdown, but we need them to correctly compute the averages we want. 
SELECT 
	Id AS question_id, 
	#question_calendar.year AS 'year',
	#question_calendar.month AS 'month',
	IIF(upvotes IS NOT NULL, upvotes, 0) AS upvotes,
	IIF(downvotes IS NOT NULL, downvotes, 0) AS downvotes,
	IIF(favorites IS NOT NULL, favorites, 0) AS favorites	
INTO #full_breakdown
FROM #question_calendar 
  LEFT JOIN #vote_breakdown
  ON #question_calendar.Id = #vote_breakdown.question_id AND
  #question_calendar.year = #vote_breakdown.vote_year AND
  #question_calendar.month = #vote_breakdown.vote_month;

-- Creation of the #tagged_questions table
-- We need a table where each question is associated with each tag it has received. 
-- E.g., if question 5 received tags A, B, and C, there will be three rows for it in #tagged_questions, 
-- namely A 5, B 5, and C 5.
-- Note that the PostTags table only contains ids of questions, so there's no need to filter anything.
SELECT 
	tag_name, 
	post_id AS question_id
INTO #tagged_questions
FROM #tags
	LEFT JOIN #post_tags
	ON #tags.id = #post_tags.tag_id

-- Creation of the tag_breakdown table
-- This table contains the average number of upvotes, downvotes and "favorited's" that all questions with a given tag
-- have received during a specific month in our date range. 

-- Create the tag_breakdown table.
CREATE TABLE tag_breakdown (
	id int IDENTITY(1, 1) PRIMARY KEY,
	tag_name VARCHAR(255) NOT NULL,
	year INT NOT NULL,
	month INT NOT NULL,
	average_upvotes FLOAT NOT NULL,
	average_downvotes FLOAT NOT NULL,
	average_favorited FLOAT NOT NULL
)

-- Populate the tag_breakdown table.
INSERT INTO tag_breakdown
SELECT 
	tag_name,		
	#full_breakdown.year,
	#full_breakdown.month,
	ROUND(AVG(CAST(#full_breakdown.upvotes AS float)), 4) AS average_upvotes,
	ROUND(AVG(CAST(#full_breakdown.downvotes AS float)), 4) AS average_downvotes,
	ROUND(AVG(CAST(#full_breakdown.favorites AS float)), 4) AS average_favorites		
FROM #tagged_questions
	INNER JOIN #full_breakdown
	ON #tagged_questions.question_id = #full_breakdown.question_id
GROUP BY tag_name, #full_breakdown.year, #full_breakdown.month


-- Creation of the tag_count_by_date table
-- This table counts how many posts with a given tag were created each month in 
-- the whole range of dates in the database.
CREATE TABLE tag_count_by_date (
	id int IDENTITY(1, 1) PRIMARY KEY,
	tag_name VARCHAR(255) NOT NULL,
	year INT NOT NULL,
	month INT NOT NULL,
	occurrences INT NOT NULL	
);


-- Populate the tag_count_by_date_table
WITH 
-- Associates each post with each tag it was tagged with, and to its own creation date.
tags_with_post_creation_date
AS (
	SELECT
		tag_name,
		YEAR(Posts.CreationDate) AS post_year,
		MONTH(Posts.CreationDate) AS post_month
	FROM #tagged_questions
      LEFT JOIN Posts
	  ON #tagged_questions.question_id = Posts.Id	
)

-- Actually populates the tag_count_by_date with the number of posts with each given tag created every month in range.
INSERT INTO tag_count_by_date
SELECT
	tag_name,
	post_year,
	post_month,	
	COUNT(*)
FROM tags_with_post_creation_date
GROUP BY tag_name, post_year, post_month
ORDER BY tag_name, post_year, post_month