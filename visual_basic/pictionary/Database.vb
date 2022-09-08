Imports System.IO
Friend Class Database

    Private _Categories As Dictionary(Of Game.Category, ArrayList)
    Private ReadOnly _CategoryStreamReaders As New Dictionary(Of Game.Category, IO.StreamReader)
    Private _totalWords As Integer
    Private _wordsLeft As Integer

#Region "Properties"

    Friend ReadOnly Property AtLeastTwoCategoriesLeft() As Boolean
        Get
            Dim nonEmptycategories As Integer = 0
            For Each key As Game.Category In _Categories.Keys
                If _Categories(key).Count > 0 Then nonEmptycategories += 1
            Next

            Return nonEmptycategories >= 2
        End Get
    End Property

    Friend ReadOnly Property Categories As Dictionary(Of Game.Category, ArrayList)
        Get
            Return _Categories
        End Get
    End Property

    Friend ReadOnly Property IsEmpty() As Boolean
        Get
            Dim wordsLeft As Integer = 0
            For Each key As Game.Category In _Categories.Keys
                wordsLeft += _Categories(key).Count
                If wordsLeft > 0 Then Return False
            Next

            Return True
        End Get
    End Property

    Friend ReadOnly Property TotalWords() As Integer
        Get
            Return _totalWords
        End Get
    End Property

    Friend ReadOnly Property WordsLeft() As Integer
        Get
            Return _wordsLeft
        End Get
    End Property

#End Region

#Region "Methods"

    Friend Function GetNextWord(ByVal c As Game.Category) As String()

        Dim random As New Random
        Dim index As Integer
        index = random.Next(0, _Categories(c).Count)

        Dim nextWord() As String = _Categories(c).Item(index)
        _Categories(c).RemoveAt(index)

        ' Remove any extra spaces or new line characters in the word triplets.
        For i As Integer = 0 To nextWord.Length - 1
            nextWord(i) = nextWord(i).Trim(" ")
            nextWord(i) = nextWord(i).Trim(vbCrLf)
            nextWord(i) = nextWord(i).Trim(vbLf)
            nextWord(i) = nextWord(i).Trim(vbCr)
        Next

        _wordsLeft -= 1
        Return nextWord

    End Function

    Friend Sub Load(ByVal loader As FrmLoader)

        _totalWords = 0

        Dim categories As New Dictionary(Of Game.Category, ArrayList)

        For c As Game.Category = 0 To 5 Step 1
            Try
                Dim categoryContents = _CategoryStreamReaders(c).ReadToEnd()

                ' Reset the StreamReaders to the initial position, so that they can be read again
                ' when starting a new game, all without closing (and thus unlocking!) the database files.
                _CategoryStreamReaders(c).DiscardBufferedData()
                _CategoryStreamReaders(c).BaseStream.Seek(0, SeekOrigin.Begin)

                Dim wordTriplets() As String = Split(categoryContents, vbCr)
                Dim validatedWordTriplets As New ArrayList

                loader.InitializeProgressBar(wordTriplets.GetLength(0) - 1)

                For i As Integer = 0 To wordTriplets.GetLength(0) - 1

                    Dim singleWordTriplet() As String = Split(wordTriplets(i), ";")
                    ' Let's make sure each word triplet is indeed a triplet, so that we don't get
                    ' any index-out-of-bound errors later on.
                    If singleWordTriplet.GetLength(0) = 3 Then
                        validatedWordTriplets.Add(singleWordTriplet)
                    End If

                    loader.IncrementProgressBar()
                Next

                categories.Add(c, validatedWordTriplets)
                _totalWords += validatedWordTriplets.Count
            Catch ex As Exception
                ' The exception that is likely to happen here is missing dictionary key, if any file is missing. It doesn't
                ' need special handling: the user is alerted at start up if any database files are missing, and if they are, 
                ' the corresponding category buttons are disabled anyway.
            End Try
        Next

        _wordsLeft = _totalWords
        _Categories = categories

        ' The form that loads the data can be closed now.
        loader.DialogResult = DialogResult.OK

    End Sub
    Friend Function Open()

        Dim file As IO.StreamReader
        Dim missingFiles As Integer = 0
        Dim dbStatusMessage, missingFileNames As New System.Text.StringBuilder
        Dim databaseExists As Boolean = True

        For c As Game.Category = 0 To 5 Step 1
            Dim fileName As String = c.ToString().ToLower() & ".txt"
            Dim filePath As String = My.Application.Info.DirectoryPath & "\databases\" & fileName
            Try
                file = New IO.StreamReader(filePath, System.Text.Encoding.UTF8)
                _CategoryStreamReaders.Add(c, file)
            Catch ex As Exception
                ' The only exception that might happen here is if any of the files is missing.
                missingFileNames.Append("- " & fileName & vbCrLf)
                missingFiles += 1
            End Try
        Next

        If missingFiles > 0 Then
            dbStatusMessage.Append(My.Resources.MissingDatabaseStub)
            dbStatusMessage.Append(missingFileNames.ToString())

            If missingFiles < 6 Then
                dbStatusMessage.Append(My.Resources.MissingDatabaseSome)
            ElseIf missingFiles = 6 Then
                dbStatusMessage.Append(My.Resources.MissingDatabaseAll)
                databaseExists = False
            End If

            MessageBox.Show(dbStatusMessage.ToString(), My.Application.Info.Title, MessageBoxButtons.OK)

        End If

        Return databaseExists

    End Function

#End Region
End Class
