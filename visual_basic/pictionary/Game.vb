Friend Class Game

    Friend Enum Category As Integer
        Classic = 0
        DirectADraw = 1
        Drawback = 2
        Shuteye = 3
        PeoplePutty = 4
        AllInTheWrist = 5
        Random = 6
        None = -1
    End Enum

    Private _currentCategory As Category
    Private ReadOnly _dbInstance As Database
    Private _timedGame As Boolean
    Private _timeLeft As TimeSpan
    Private _oneSecond As TimeSpan


#Region "Properties"

    Friend Sub New(database As Database)

        _dbInstance = database
        _currentCategory = Category.None
        _timedGame = True
        _oneSecond = New TimeSpan(0, 0, 1)

    End Sub

    Friend Property CurrentCategory As Category
        Get
            Return _currentCategory
        End Get
        Set(value As Category)
            _currentCategory = value
        End Set
    End Property

    Friend Property IsTimed As Boolean
        Get
            Return _timedGame
        End Get
        Set(value As Boolean)
            _timedGame = value
        End Set
    End Property

    Friend ReadOnly Property IsRunning As Boolean
        Get
            ' The game is running if we have used some, but not all, words.
            Return (_dbInstance.WordsLeft < _dbInstance.TotalWords) And (_dbInstance.IsEmpty = False)
        End Get
    End Property

    Friend ReadOnly Property TimeLeft As TimeSpan
        Get
            Return _timeLeft
        End Get
    End Property

#End Region

#Region "Methods"

    Friend Sub DecreaseTimeLeft()
        _timeLeft = _timeLeft.Subtract(_oneSecond)
    End Sub

    Friend Sub SetTime(ByVal time As TimeSpan)
        _timeLeft = time
    End Sub

#End Region

End Class
