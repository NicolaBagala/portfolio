# StackOverflow Tag Statistics

_**Tech used:** MS SQL Server, Tableau_

<p align="justify">This was mostly an exercise to (re-)familiarise with SQL server and practise querying larger databases. I downloaded a <a href="https://www.brentozar.com/archive/2015/10/how-to-download-the-stack-overflow-database-via-bittorrent/">version of StackOverflow's database</a> containing data from the website's creation until the end of 2010. The database size is about 10 GBs and the size of its tables reaches up to several millions of rows, depending on the tables.</p>

<p>The goal of this exercise was to calculate three things for each tag ever used:</p>
<ul>
    <li>the number of questions with that tag created every month,</li>
    <li>the average number of upvotes and downvotes received by questions with that tag every month, and</li>
    <li>the average number of times a question with that tag was marked as "favourite" every month.</li>
</ul>

<p align="justify">According to the database's <a href="https://meta.stackexchange.com/questions/2677/database-schema-documentation-for-the-public-data-dump-and-sede/2678#2678">documentation</a> and <a href="https://meta.stackexchange.com/questions/2677/database-schema-documentation-for-the-public-data-dump-and-sede/326361#326361">schema</a>, the database should have contained two tables among others:</p>

<ul>
    <li>a <code>Tags</code> table, containing data about all tags ever used, and</li>
    <li>a <code>PostTags</code> table, relating each tag to every post it was ever used on.</li>
</ul>

<p align="justify">For some reason, these tables were not there in the database, and given they were pretty much indispensable for what I wanted to do, I had to create them myself before I could proceed. Broadly speaking, I followed these steps (in the following, only posts that are questions are ever considered):</p>

<ul>
    <li>Extract all tags from the <code>Posts</code> table;</li>
    <li>Insert each unique tag, along with the number of times it was ever used, into a temp table <code>#tags</code>;</li>
    <li>Associate each unique tag to every question it was used on, by means of a temp table <code>#post_tags</code>;</li>
    <li>Create a table where each tag is associated to each question it was ever used on, and each question is associated to all year-month pairs between the question's creation date and Dec 31, 2010, as well as the number of upvotes, downvotes, and "favorited's" it received each month;</li>
    <li>Use the table above to calculate the desired averages, grouping by tag, year, and month.</li>    
</ul>

<p align="justify">Nearly all the above steps had other steps in between that I did not mention for brevity, but you can see them all in my thoroughly commented <a href="https://github.com/NicolaBagala/portfolio/blob/master/stack_overflow/script.sql">code.</a> The whole procedure, from start to finish, winds up manipulating well over 11 million rows (probably closer to 20); it execution time varies from 45 seconds to around 1 minute and 10 seconds. Its final result are two tables, <code>tag_breakdown</code> and <code>tag_count_by_date</code>, which I exported to CSV and built a simple <a href="https://public.tableau.com/app/profile/nicola.bagal./viz/StackOverflow_16558943509010/SOdashboard">Tableau visualisation</a> with.




