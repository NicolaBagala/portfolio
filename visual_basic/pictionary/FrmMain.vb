Imports System.Linq
Public Class FrmMain

    Private ReadOnly database As New Database
    Private ReadOnly loader As New FrmLoader
    Private game As Game

    Private ReadOnly categoryButtons As New Dictionary(Of Integer, Button)
    Private ReadOnly categoryImages As New Dictionary(Of Game.Category, Image)

    Private wordsAreVisible As Boolean

    Private gameTimerIsRunning As Boolean = False
    Private gameTimerIsPaused As Boolean = False
    Private skipConfirmOnExit As Boolean = False



#Region "New game"
    Private Sub StartNewGame() Handles btnNewGame.Click

        ' We need to decide whether a new game can be started. As we might need to ask for confirmation, 
        ' we use a dialog result in any case. By default, the answer is no.
        Dim startNewGame As DialogResult = vbNo

        If game Is Nothing Then
            startNewGame = vbYes
        ElseIf game.IsRunning = True Then
            startNewGame = MessageBox.Show(My.Resources.ConfirmReload, My.Application.Info.Title, MessageBoxButtons.YesNo)
        Else
            startNewGame = vbYes
        End If

        If startNewGame = vbYes Then SetUpNewGame()

    End Sub

    Private Sub ToggleTimedGame() Handles chkTimedGame.Click

        ' Whether a game is timed can be changed at any point after a new game has been created.
        game.IsTimed = chkTimedGame.Checked

        pnlTimeSelection.Enabled = game.IsTimed
        pnlTimeControls.Visible = game.IsTimed

    End Sub

    Private Sub MinuteOrMinutes() Handles updMinutes.ValueChanged

        If updMinutes.Value = 1 Then
            lblMinutes.Text = "minute"
        Else
            lblMinutes.Text = "minutes"
        End If

    End Sub

#End Region

#Region "Category selection"
    Private Sub SelectClassic() Handles btnClassic.Click

        SetCategory(Game.Category.Classic)

    End Sub

    Private Sub SelectDirectADraw() Handles btnDirectADraw.Click

        SetCategory(Game.Category.DirectADraw)

    End Sub

    Private Sub SelectDrawback() Handles btnDrawback.Click

        SetCategory(Game.Category.Drawback)

    End Sub

    Private Sub SelectShuteye() Handles btnShuteye.Click

        SetCategory(Game.Category.Shuteye)

    End Sub

    Private Sub SelectPeoplePutty() Handles btnPeoplePutty.Click

        SetCategory(Game.Category.PeoplePutty)

    End Sub

    Private Sub SelectAllInTheWrist() Handles btnWrist.Click

        SetCategory(Game.Category.AllInTheWrist)

    End Sub

    Private Sub SelectRandomCategory() Handles btnRandom.Click

        Dim random As New Random
        Dim randomCategory As Game.Category
        Dim keyIndex As Integer

        ' Pick a random category, and make sure it didn't ran out of words already.
        Do
            keyIndex = random.Next(0, database.Categories.Keys.Count)
            randomCategory = database.Categories.Keys(keyIndex)
        Loop Until database.Categories(randomCategory).Count > 0

        SetCategory(randomCategory)

    End Sub

    Private Sub SetCategory(ByVal c As Game.Category)

        game.CurrentCategory = c
        picCategory.Image = categoryImages(c)

        ' When we change category, automatically choose a word from that category.
        PickNextWord()

    End Sub
#End Region

#Region "Next word"
    Private Sub PickNextWord() Handles btnNextWord.Click

        Dim nextWord() As String = database.GetNextWord(game.CurrentCategory)

        If database.Categories(game.CurrentCategory).Count = 0 Then
            categoryButtons(game.CurrentCategory).Enabled = False
            btnNextWord.Enabled = False

            'Check if all categories are empty (can only happen if the current one is!), and if so, 
            'let the user know.
            If database.IsEmpty = True Then
                grbNextCategory.Enabled = False
                MessageBox.Show(My.Resources.LastWordWarning, My.Application.Info.Title, MessageBoxButtons.OK)
            End If

        End If

        lblItaWord.Text = nextWord(0).ToUpper
        lblEngWord.Text = nextWord(1).ToUpper
        lblFinWord.Text = nextWord(2).ToUpper

        SetWordVisibility(True)
        ' Can pick a random category only if at least two are still available.
        btnRandom.Enabled = database.AtLeastTwoCategoriesLeft()

        ' Once a word is picked, we enable the button to start the timer, even if the game isn't timed. In that
        ' case it's hidden anyway.
        btnToggleGameTimer.Enabled = True
        btnToggleWordVisibility.Enabled = True
    End Sub

    Private Sub ToggleWordVisibility() Handles btnToggleWordVisibility.Click

        SetWordVisibility(Not wordsAreVisible)

    End Sub

#End Region

#Region "Timers"

    Private Sub ToggleGameTimer() Handles btnToggleGameTimer.Click

        ' This routine is called whenever the Start/Stop button is clicked. If it's called with
        ' gameTimerIsRunning = False, the game timer is about to be started, and it's about to be stopped if gameTimerIsRunning = True.
        ' For this reason, the Enabled property of a number of controls takes the same value as gameTimerIsRunning 
        ' (e.g., gameTimerIsRunning = False -> The game timer will start soon -> You can't pick a new category now -> 
        ' -> grbNextCategory must be disabled -> grbNextCategory.Enabled = False = gameTimerIsRunning).

        ' Same for the SetWordVisibility sub: if gameTimerIsRunning = False, the game timer will start soon, so words need to be hidden,
        ' and hence SetWordVisibilty must be called with False = gameTimerIsRunning -> SetWordVisibility(gameTimerIsRunning).

        ' First we deal with all such properties and subs.

        SetWordVisibility(gameTimerIsRunning)

        btnNewGame.Enabled = gameTimerIsRunning
        chkTimedGame.Enabled = gameTimerIsRunning
        pnlTimeSelection.Enabled = gameTimerIsRunning

        grbNextCategory.Enabled = gameTimerIsRunning

        btnNextWord.Enabled = gameTimerIsRunning

        btnToggleGameTimer.Enabled = gameTimerIsRunning

        btnSettings.Enabled = gameTimerIsRunning
        btnAbout.Enabled = gameTimerIsRunning
        Me.MinimizeBox = gameTimerIsRunning


        ' If a timed game is starting, words are hidden automatically and can't be shown unless the timer is paused.
        ' If a timed game is being stopped, words are shown automatically and there's no reason to hide them until
        ' next round. Either way, the show/hide words button is always disabled.
        btnToggleWordVisibility.Enabled = False

        ' Whether the timer is being started or stopped, the time is displayed in green, because
        ' either there's still time left, or time didn't run out - it was manually stopped.
        lblTime.ForeColor = Color.Lime

        ' To change properties of other controls, we need to check the value of gameTimerIsRunning separately.
        If gameTimerIsRunning = True Then
            ' The timer is running, so the button needs to work as a stop button.

            'Stop the timer and play the gong sound if required.
            If My.Settings.PlayGongSound = True Then My.Computer.Audio.Play(My.Resources.gong_sound, AudioPlayMode.Background)
            tmrCountDown.Stop()

            ' Set up timer display and controls.
            lblTime.Text = "00:00"
            btnToggleGameTimer.Text = "Start"
            btnPauseGameTimer.Enabled = False
            lblPause.Visible = False

            ' We can pick the next word from the current category only if there are words left in it.
            btnNextWord.Enabled = database.Categories(game.CurrentCategory).Count > 0

            ' We just stopped the timer, so we can't restart it for this specific word.
            btnToggleGameTimer.Enabled = False

        Else
            ' The timer is not running. The button needs to work as a start button.

            ' TEST time interval: turns minutes into seconds, so that we don't have to wait too long.
            ' game.SetGameTime(New TimeSpan(0, 0, updMinutes.Value))

            ' PRODUCTION time interval
            game.SetTime(New TimeSpan(0, updMinutes.Value, 0))

            ' Set up timer display and controls.
            lblTime.Text = "0" & updMinutes.Value & ":00"
            btnToggleGameTimer.Text = "Stop"
            btnPauseGameTimer.Text = "Pause"

            btnNextWord.Enabled = False

            ' Enable the timer that displays the three-step start message.
            tmrReadySetGo.Enabled = True

        End If

        ' Update the timer running status accordingly.
        gameTimerIsRunning = Not gameTimerIsRunning

    End Sub

    Private Sub PauseGameTimer() Handles btnPauseGameTimer.Click

        ' gameTimerIsPaused = False by default, because the game never starts paused. The value of gameTimerIsPaused is flipped every time
        ' at the end of this routine. So, to correctly pause/unpause the timer, its Enabled property should always be
        ' assigned value gameTimerIsPaused.
        tmrCountDown.Enabled = gameTimerIsPaused

        ' The three controls below are visible/enabled when the timer is paused, and vice-versa. When we click the pause/unpause
        ' button, the timer's status will be flipped, hence the Nots.
        btnToggleWordVisibility.Enabled = Not gameTimerIsPaused
        lblPause.Visible = Not gameTimerIsPaused
        Me.MinimizeBox = Not gameTimerIsPaused

        If gameTimerIsPaused = True Then
            ' The game timer will be unpaused. Hide the words, and set up the timer controls and display appropriately.
            SetWordVisibility(False)

            btnPauseGameTimer.Text = "Pause"

            ' When the timer is paused, the display goes white. When it's unpaused, we need to decide if
            ' it's going to be yellow or lime.
            If game.TimeLeft.Seconds <= 15 Then
                lblTime.ForeColor = Color.Yellow
            Else
                lblTime.ForeColor = Color.Lime
            End If

        Else
            ' The game timer will be paused. Set up timer control/display elements accordingly.
            lblTime.ForeColor = Color.White
            btnPauseGameTimer.Text = "Resume"

        End If

        gameTimerIsPaused = Not gameTimerIsPaused

    End Sub

    Private Sub CountDown() Handles tmrCountDown.Tick

        game.DecreaseTimeLeft()
        ' The string would normally be in HH:MM:SS format. We only care about the MM:SS part, hence Substring().
        lblTime.Text = game.TimeLeft.ToString().Substring(3)


        If game.TimeLeft.Seconds > 0 And game.TimeLeft.Seconds <= 15 And game.TimeLeft.Minutes = 0 Then
            'In the last 15 seconds of the countdown, the clock goes yellow, and the tick sound is different.
            lblTime.ForeColor = Color.Yellow
            If My.Settings.PlayTickSound = True Then My.Computer.Audio.Play(My.Resources.blip_sound, AudioPlayMode.Background)

        ElseIf game.TimeLeft.Seconds = 0 And game.TimeLeft.Minutes = 0 Then
            'If the time is up, stop the countdown, and prepare the form for a new round.
            tmrCountDown.Stop()

            If My.Settings.PlayGongSound = True Then My.Computer.Audio.Play(My.Resources.gong_sound, AudioPlayMode.Background)

            SetWordVisibility(True)

            lblTime.Text = "00:00"
            lblTime.ForeColor = Color.Red

            btnToggleGameTimer.Text = "Start"
            btnToggleGameTimer.Enabled = False

            btnPauseGameTimer.Text = "Pause"
            btnPauseGameTimer.Enabled = False

            If database.Categories(game.CurrentCategory).Count > 0 Then btnNextWord.Enabled = True

            btnNewGame.Enabled = True
            grbNextCategory.Enabled = True

            btnSettings.Enabled = True
            btnAbout.Enabled = True

            chkTimedGame.Enabled = True
            pnlTimeSelection.Enabled = True

        Else
            'At any point except the last 15 seconds, just play the regular tick sound.
            If My.Settings.PlayTickSound = True Then My.Computer.Audio.Play(My.Resources.tick_sound, AudioPlayMode.Background)

        End If

    End Sub

    Private Sub ReadySetGoMessage() Handles tmrReadySetGo.Tick

        ' The words "READY", "SET", and "GO!" need to be displayed one after another, depending on 
        ' which one is already displayed. This is timed with the start sound. (If enabled in the settings.)

        Select Case lblReadySetGo.Text
            Case ""
                If My.Settings.PlayStartSound = True Then My.Computer.Audio.Play(My.Resources.start_sound, AudioPlayMode.Background)

                lblReadySetGo.Visible = True
                lblReadySetGo.Text = "READY"
            Case "READY"
                lblReadySetGo.ForeColor = Color.Yellow
                lblReadySetGo.Text = "SET"
            Case "SET"
                lblReadySetGo.Text = "GO!"
                lblReadySetGo.ForeColor = Color.Lime
            Case "GO!"
                tmrCountDown.Enabled = True

                lblReadySetGo.Visible = False
                lblReadySetGo.ForeColor = Color.Red

                btnPauseGameTimer.Enabled = True
                btnToggleGameTimer.Enabled = True
                btnToggleWordVisibility.Enabled = False

                lblReadySetGo.Text = ""
                tmrReadySetGo.Enabled = False
        End Select

    End Sub
#End Region

#Region "App"

    Private Sub ShowSettings() Handles btnSettings.Click

        FrmSettings.ShowDialog()

    End Sub

    Private Sub ShowAbout() Handles btnAbout.Click

        MessageBox.Show(My.Resources.AboutNotice, My.Application.Info.Title)

    End Sub

    Private Sub ClosingForm(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' Don't exit if the game timer is running.
        If tmrCountDown.Enabled = True Then
            e.Cancel = True
            Exit Sub
        End If

        ' If no game has ever been created, just exit.
        If game Is Nothing Then Exit Sub

        ' If a game has been created, exit only if the user confirms it, if we're not mid-game, or if we're skipping the confirmation because no database is available.
        If (My.Settings.ConfirmOnExit = True Or game.IsRunning = True) And skipConfirmOnExit = False Then
            Select Case MessageBox.Show(My.Resources.AbandonGame, My.Application.Info.Title, MessageBoxButtons.YesNo)
                Case Windows.Forms.DialogResult.Yes
                    e.Cancel = False
                Case Windows.Forms.DialogResult.No
                    e.Cancel = True
            End Select
        End If

    End Sub

    Private Sub InitializeApp() Handles MyBase.Load

        loader.Database = database

        ' Dictionary of all category buttons, for ease of access/reference.
        categoryButtons.Add(Game.Category.Classic, btnClassic)
        categoryButtons.Add(Game.Category.DirectADraw, btnDirectADraw)
        categoryButtons.Add(Game.Category.Drawback, btnDrawback)
        categoryButtons.Add(Game.Category.Shuteye, btnShuteye)
        categoryButtons.Add(Game.Category.PeoplePutty, btnPeoplePutty)
        categoryButtons.Add(Game.Category.AllInTheWrist, btnWrist)
        categoryButtons.Add(Game.Category.Random, btnRandom)

        ' Dictionary of all category images, for ease of access/reference.
        categoryImages.Add(Game.Category.Classic, My.Resources.classic_img)
        categoryImages.Add(Game.Category.DirectADraw, My.Resources.directadraw_img)
        categoryImages.Add(Game.Category.Drawback, My.Resources.drawback_img)
        categoryImages.Add(Game.Category.Shuteye, My.Resources.shuteye_img)
        categoryImages.Add(Game.Category.PeoplePutty, My.Resources.peopleputty_img)
        categoryImages.Add(Game.Category.AllInTheWrist, My.Resources.allinthewrist_img)

        ' If we can't open the database (because there are no database files available), then exit without
        ' asking any confirm. (The user has already been warned.)
        If database.Open() = False Then
            skipConfirmOnExit = True
            Me.Close()
        End If

    End Sub

    Private Sub SetWordVisibility(ByVal visibility As Boolean)

        pnlWords.Visible = visibility

        If visibility = True Then
            btnToggleWordVisibility.Text = "Hide words"

            'We can pick another word only if there's one in the category, and if we're not in a timed game that's been paused.
            If database.Categories(game.CurrentCategory).Count > 0 And gameTimerIsPaused = False Then
                btnNextWord.Enabled = True
            End If
        Else
            btnToggleWordVisibility.Text = "Show words"
            btnNextWord.Enabled = False
        End If

        wordsAreVisible = visibility

    End Sub

    Private Sub SetUpNewGame()

        loader.ShowDialog()
        game = New Game(database)

        ' Prepare the board for a new game.
        For c As Game.Category = 0 To 5 Step 1
            categoryButtons(c).Enabled = database.Categories.ContainsKey(c)
        Next

        grbNextCategory.Enabled = True
        btnRandom.Enabled = database.Categories.Keys.Count >= 2

        grbNextWord.Enabled = True

        btnNextWord.Enabled = False
        btnToggleWordVisibility.Enabled = False

        btnToggleGameTimer.Enabled = False
        btnPauseGameTimer.Enabled = False

        picCategory.Image = Nothing
        lblItaWord.Text = ""
        lblEngWord.Text = ""
        lblFinWord.Text = ""

        chkTimedGame.Enabled = True
        pnlTimeSelection.Enabled = True

    End Sub

#End Region


End Class