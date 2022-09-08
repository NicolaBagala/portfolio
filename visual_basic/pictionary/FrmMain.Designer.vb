<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.tmrCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.btnDrawback = New System.Windows.Forms.Button()
        Me.btnDirectADraw = New System.Windows.Forms.Button()
        Me.btnWrist = New System.Windows.Forms.Button()
        Me.btnShuteye = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnPeoplePutty = New System.Windows.Forms.Button()
        Me.grbNextCategory = New System.Windows.Forms.GroupBox()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.chkTimedGame = New System.Windows.Forms.CheckBox()
        Me.btnToggleWordVisibility = New System.Windows.Forms.Button()
        Me.btnNextWord = New System.Windows.Forms.Button()
        Me.picCategory = New System.Windows.Forms.PictureBox()
        Me.grbNextWord = New System.Windows.Forms.GroupBox()
        Me.pnlTimeControls = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnPauseGameTimer = New System.Windows.Forms.Button()
        Me.btnToggleGameTimer = New System.Windows.Forms.Button()
        Me.lblReadySetGo = New System.Windows.Forms.Label()
        Me.pnlWords = New System.Windows.Forms.Panel()
        Me.picFin = New System.Windows.Forms.PictureBox()
        Me.picEng = New System.Windows.Forms.PictureBox()
        Me.picIta = New System.Windows.Forms.PictureBox()
        Me.lblFinWord = New System.Windows.Forms.Label()
        Me.lblItaWord = New System.Windows.Forms.Label()
        Me.lblEngWord = New System.Windows.Forms.Label()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.tmrReadySetGo = New System.Windows.Forms.Timer(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.pnlTimeSelection = New System.Windows.Forms.Panel()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.updMinutes = New System.Windows.Forms.NumericUpDown()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.grbNextCategory.SuspendLayout()
        CType(Me.picCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNextWord.SuspendLayout()
        Me.pnlTimeControls.SuspendLayout()
        Me.pnlWords.SuspendLayout()
        CType(Me.picFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTimeSelection.SuspendLayout()
        CType(Me.updMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrCountDown
        '
        Me.tmrCountDown.Interval = 1000
        '
        'btnClassic
        '
        Me.btnClassic.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassic.ForeColor = System.Drawing.Color.Black
        Me.btnClassic.Location = New System.Drawing.Point(18, 24)
        Me.btnClassic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Size = New System.Drawing.Size(106, 28)
        Me.btnClassic.TabIndex = 5
        Me.btnClassic.Text = "Classic game"
        Me.btnClassic.UseVisualStyleBackColor = True
        '
        'btnDrawback
        '
        Me.btnDrawback.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawback.ForeColor = System.Drawing.Color.Black
        Me.btnDrawback.Location = New System.Drawing.Point(18, 92)
        Me.btnDrawback.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDrawback.Name = "btnDrawback"
        Me.btnDrawback.Size = New System.Drawing.Size(106, 28)
        Me.btnDrawback.TabIndex = 7
        Me.btnDrawback.Text = "Drawback"
        Me.btnDrawback.UseVisualStyleBackColor = True
        '
        'btnDirectADraw
        '
        Me.btnDirectADraw.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDirectADraw.ForeColor = System.Drawing.Color.Black
        Me.btnDirectADraw.Location = New System.Drawing.Point(18, 58)
        Me.btnDirectADraw.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnDirectADraw.Name = "btnDirectADraw"
        Me.btnDirectADraw.Size = New System.Drawing.Size(106, 28)
        Me.btnDirectADraw.TabIndex = 6
        Me.btnDirectADraw.Text = "Direct-a-draw"
        Me.btnDirectADraw.UseVisualStyleBackColor = True
        '
        'btnWrist
        '
        Me.btnWrist.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrist.ForeColor = System.Drawing.Color.Black
        Me.btnWrist.Location = New System.Drawing.Point(18, 195)
        Me.btnWrist.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnWrist.Name = "btnWrist"
        Me.btnWrist.Size = New System.Drawing.Size(106, 28)
        Me.btnWrist.TabIndex = 10
        Me.btnWrist.Text = "All in the wrist"
        Me.btnWrist.UseVisualStyleBackColor = True
        '
        'btnShuteye
        '
        Me.btnShuteye.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShuteye.ForeColor = System.Drawing.Color.Black
        Me.btnShuteye.Location = New System.Drawing.Point(18, 126)
        Me.btnShuteye.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnShuteye.Name = "btnShuteye"
        Me.btnShuteye.Size = New System.Drawing.Size(106, 28)
        Me.btnShuteye.TabIndex = 8
        Me.btnShuteye.Text = "Shut-eye"
        Me.btnShuteye.UseVisualStyleBackColor = True
        '
        'btnRandom
        '
        Me.btnRandom.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandom.ForeColor = System.Drawing.Color.Black
        Me.btnRandom.Location = New System.Drawing.Point(18, 229)
        Me.btnRandom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(106, 28)
        Me.btnRandom.TabIndex = 11
        Me.btnRandom.Text = "Random"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btnPeoplePutty
        '
        Me.btnPeoplePutty.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeoplePutty.ForeColor = System.Drawing.Color.Black
        Me.btnPeoplePutty.Location = New System.Drawing.Point(18, 161)
        Me.btnPeoplePutty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPeoplePutty.Name = "btnPeoplePutty"
        Me.btnPeoplePutty.Size = New System.Drawing.Size(106, 28)
        Me.btnPeoplePutty.TabIndex = 9
        Me.btnPeoplePutty.Text = "People putty"
        Me.btnPeoplePutty.UseVisualStyleBackColor = True
        '
        'grbNextCategory
        '
        Me.grbNextCategory.BackColor = System.Drawing.Color.Transparent
        Me.grbNextCategory.Controls.Add(Me.btnPeoplePutty)
        Me.grbNextCategory.Controls.Add(Me.btnRandom)
        Me.grbNextCategory.Controls.Add(Me.btnShuteye)
        Me.grbNextCategory.Controls.Add(Me.btnWrist)
        Me.grbNextCategory.Controls.Add(Me.btnDirectADraw)
        Me.grbNextCategory.Controls.Add(Me.btnDrawback)
        Me.grbNextCategory.Controls.Add(Me.btnClassic)
        Me.grbNextCategory.Enabled = False
        Me.grbNextCategory.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNextCategory.ForeColor = System.Drawing.Color.White
        Me.grbNextCategory.Location = New System.Drawing.Point(578, 234)
        Me.grbNextCategory.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grbNextCategory.Name = "grbNextCategory"
        Me.grbNextCategory.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grbNextCategory.Size = New System.Drawing.Size(144, 263)
        Me.grbNextCategory.TabIndex = 4
        Me.grbNextCategory.TabStop = False
        Me.grbNextCategory.Text = "Next category"
        '
        'btnNewGame
        '
        Me.btnNewGame.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.Location = New System.Drawing.Point(598, 141)
        Me.btnNewGame.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(106, 28)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.Text = "New game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'chkTimedGame
        '
        Me.chkTimedGame.AutoSize = True
        Me.chkTimedGame.BackColor = System.Drawing.Color.Transparent
        Me.chkTimedGame.Checked = True
        Me.chkTimedGame.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTimedGame.Enabled = False
        Me.chkTimedGame.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTimedGame.ForeColor = System.Drawing.Color.White
        Me.chkTimedGame.Location = New System.Drawing.Point(598, 176)
        Me.chkTimedGame.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkTimedGame.Name = "chkTimedGame"
        Me.chkTimedGame.Size = New System.Drawing.Size(103, 23)
        Me.chkTimedGame.TabIndex = 1
        Me.chkTimedGame.Text = "Timed game"
        Me.chkTimedGame.UseVisualStyleBackColor = False
        '
        'btnToggleWordVisibility
        '
        Me.btnToggleWordVisibility.Enabled = False
        Me.btnToggleWordVisibility.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleWordVisibility.ForeColor = System.Drawing.Color.Black
        Me.btnToggleWordVisibility.Location = New System.Drawing.Point(108, 87)
        Me.btnToggleWordVisibility.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnToggleWordVisibility.Name = "btnToggleWordVisibility"
        Me.btnToggleWordVisibility.Size = New System.Drawing.Size(86, 28)
        Me.btnToggleWordVisibility.TabIndex = 13
        Me.btnToggleWordVisibility.Text = "Hide words"
        Me.btnToggleWordVisibility.UseVisualStyleBackColor = True
        '
        'btnNextWord
        '
        Me.btnNextWord.Enabled = False
        Me.btnNextWord.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextWord.ForeColor = System.Drawing.Color.Black
        Me.btnNextWord.Location = New System.Drawing.Point(16, 87)
        Me.btnNextWord.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNextWord.Name = "btnNextWord"
        Me.btnNextWord.Size = New System.Drawing.Size(86, 28)
        Me.btnNextWord.TabIndex = 12
        Me.btnNextWord.Text = "Next word"
        Me.btnNextWord.UseVisualStyleBackColor = True
        '
        'picCategory
        '
        Me.picCategory.BackColor = System.Drawing.Color.Transparent
        Me.picCategory.InitialImage = Nothing
        Me.picCategory.Location = New System.Drawing.Point(16, 30)
        Me.picCategory.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picCategory.Name = "picCategory"
        Me.picCategory.Size = New System.Drawing.Size(252, 55)
        Me.picCategory.TabIndex = 12
        Me.picCategory.TabStop = False
        Me.picCategory.WaitOnLoad = True
        '
        'grbNextWord
        '
        Me.grbNextWord.BackColor = System.Drawing.Color.Transparent
        Me.grbNextWord.Controls.Add(Me.pnlTimeControls)
        Me.grbNextWord.Controls.Add(Me.lblReadySetGo)
        Me.grbNextWord.Controls.Add(Me.picCategory)
        Me.grbNextWord.Controls.Add(Me.btnNextWord)
        Me.grbNextWord.Controls.Add(Me.btnToggleWordVisibility)
        Me.grbNextWord.Controls.Add(Me.pnlWords)
        Me.grbNextWord.Controls.Add(Me.lblPause)
        Me.grbNextWord.Enabled = False
        Me.grbNextWord.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNextWord.ForeColor = System.Drawing.SystemColors.Window
        Me.grbNextWord.Location = New System.Drawing.Point(12, 141)
        Me.grbNextWord.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grbNextWord.Name = "grbNextWord"
        Me.grbNextWord.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grbNextWord.Size = New System.Drawing.Size(545, 323)
        Me.grbNextWord.TabIndex = 18
        Me.grbNextWord.TabStop = False
        Me.grbNextWord.Text = "Next word"
        '
        'pnlTimeControls
        '
        Me.pnlTimeControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlTimeControls.Controls.Add(Me.lblTime)
        Me.pnlTimeControls.Controls.Add(Me.btnPauseGameTimer)
        Me.pnlTimeControls.Controls.Add(Me.btnToggleGameTimer)
        Me.pnlTimeControls.Location = New System.Drawing.Point(365, 25)
        Me.pnlTimeControls.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlTimeControls.Name = "pnlTimeControls"
        Me.pnlTimeControls.Size = New System.Drawing.Size(166, 104)
        Me.pnlTimeControls.TabIndex = 10
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Lime
        Me.lblTime.Location = New System.Drawing.Point(18, -7)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(142, 69)
        Me.lblTime.TabIndex = 20
        Me.lblTime.Text = "00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPauseGameTimer
        '
        Me.btnPauseGameTimer.Enabled = False
        Me.btnPauseGameTimer.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseGameTimer.ForeColor = System.Drawing.Color.Black
        Me.btnPauseGameTimer.Location = New System.Drawing.Point(94, 73)
        Me.btnPauseGameTimer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnPauseGameTimer.Name = "btnPauseGameTimer"
        Me.btnPauseGameTimer.Size = New System.Drawing.Size(65, 28)
        Me.btnPauseGameTimer.TabIndex = 15
        Me.btnPauseGameTimer.Text = "Pause"
        Me.btnPauseGameTimer.UseVisualStyleBackColor = True
        '
        'btnToggleGameTimer
        '
        Me.btnToggleGameTimer.Enabled = False
        Me.btnToggleGameTimer.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleGameTimer.ForeColor = System.Drawing.Color.Black
        Me.btnToggleGameTimer.Location = New System.Drawing.Point(17, 73)
        Me.btnToggleGameTimer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnToggleGameTimer.Name = "btnToggleGameTimer"
        Me.btnToggleGameTimer.Size = New System.Drawing.Size(65, 28)
        Me.btnToggleGameTimer.TabIndex = 14
        Me.btnToggleGameTimer.Text = "Start"
        Me.btnToggleGameTimer.UseVisualStyleBackColor = True
        '
        'lblReadySetGo
        '
        Me.lblReadySetGo.BackColor = System.Drawing.Color.Transparent
        Me.lblReadySetGo.Font = New System.Drawing.Font("Comic Sans MS", 54.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadySetGo.ForeColor = System.Drawing.Color.Red
        Me.lblReadySetGo.Location = New System.Drawing.Point(114, 145)
        Me.lblReadySetGo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReadySetGo.Name = "lblReadySetGo"
        Me.lblReadySetGo.Size = New System.Drawing.Size(313, 114)
        Me.lblReadySetGo.TabIndex = 26
        Me.lblReadySetGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReadySetGo.Visible = False
        '
        'pnlWords
        '
        Me.pnlWords.BackColor = System.Drawing.Color.Transparent
        Me.pnlWords.Controls.Add(Me.picFin)
        Me.pnlWords.Controls.Add(Me.picEng)
        Me.pnlWords.Controls.Add(Me.picIta)
        Me.pnlWords.Controls.Add(Me.lblFinWord)
        Me.pnlWords.Controls.Add(Me.lblItaWord)
        Me.pnlWords.Controls.Add(Me.lblEngWord)
        Me.pnlWords.Location = New System.Drawing.Point(16, 121)
        Me.pnlWords.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlWords.Name = "pnlWords"
        Me.pnlWords.Size = New System.Drawing.Size(518, 196)
        Me.pnlWords.TabIndex = 10
        '
        'picFin
        '
        Me.picFin.BackColor = System.Drawing.Color.Black
        Me.picFin.BackgroundImage = Global.PMPE.My.Resources.Resources.fin_flag
        Me.picFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFin.InitialImage = Nothing
        Me.picFin.Location = New System.Drawing.Point(11, 162)
        Me.picFin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picFin.Name = "picFin"
        Me.picFin.Size = New System.Drawing.Size(28, 22)
        Me.picFin.TabIndex = 33
        Me.picFin.TabStop = False
        Me.picFin.WaitOnLoad = True
        '
        'picEng
        '
        Me.picEng.BackColor = System.Drawing.Color.Black
        Me.picEng.BackgroundImage = Global.PMPE.My.Resources.Resources.eng_flag
        Me.picEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picEng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEng.Location = New System.Drawing.Point(11, 97)
        Me.picEng.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picEng.Name = "picEng"
        Me.picEng.Size = New System.Drawing.Size(28, 24)
        Me.picEng.TabIndex = 32
        Me.picEng.TabStop = False
        Me.picEng.WaitOnLoad = True
        '
        'picIta
        '
        Me.picIta.BackColor = System.Drawing.Color.Black
        Me.picIta.BackgroundImage = Global.PMPE.My.Resources.Resources.ita_flag
        Me.picIta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picIta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIta.Location = New System.Drawing.Point(11, 31)
        Me.picIta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picIta.Name = "picIta"
        Me.picIta.Size = New System.Drawing.Size(28, 24)
        Me.picIta.TabIndex = 31
        Me.picIta.TabStop = False
        Me.picIta.WaitOnLoad = True
        '
        'lblFinWord
        '
        Me.lblFinWord.BackColor = System.Drawing.Color.Black
        Me.lblFinWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinWord.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinWord.Location = New System.Drawing.Point(47, 155)
        Me.lblFinWord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFinWord.Name = "lblFinWord"
        Me.lblFinWord.Size = New System.Drawing.Size(460, 37)
        Me.lblFinWord.TabIndex = 25
        Me.lblFinWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinWord.UseCompatibleTextRendering = True
        '
        'lblItaWord
        '
        Me.lblItaWord.BackColor = System.Drawing.Color.Black
        Me.lblItaWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblItaWord.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItaWord.Location = New System.Drawing.Point(47, 24)
        Me.lblItaWord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItaWord.Name = "lblItaWord"
        Me.lblItaWord.Size = New System.Drawing.Size(460, 37)
        Me.lblItaWord.TabIndex = 22
        Me.lblItaWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblItaWord.UseCompatibleTextRendering = True
        '
        'lblEngWord
        '
        Me.lblEngWord.BackColor = System.Drawing.Color.Black
        Me.lblEngWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEngWord.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEngWord.Location = New System.Drawing.Point(47, 90)
        Me.lblEngWord.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEngWord.Name = "lblEngWord"
        Me.lblEngWord.Size = New System.Drawing.Size(460, 37)
        Me.lblEngWord.TabIndex = 25
        Me.lblEngWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEngWord.UseCompatibleTextRendering = True
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPause.Font = New System.Drawing.Font("Comic Sans MS", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.Color.Black
        Me.lblPause.Location = New System.Drawing.Point(264, 25)
        Me.lblPause.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(107, 64)
        Me.lblPause.TabIndex = 19
        Me.lblPause.Text = " GAME " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PAUSED"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPause.Visible = False
        '
        'tmrReadySetGo
        '
        Me.tmrReadySetGo.Interval = 800
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(469, 473)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(88, 28)
        Me.btnSettings.TabIndex = 16
        Me.btnSettings.Text = "Settings..."
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'pnlTimeSelection
        '
        Me.pnlTimeSelection.BackColor = System.Drawing.Color.Transparent
        Me.pnlTimeSelection.Controls.Add(Me.lblMinutes)
        Me.pnlTimeSelection.Controls.Add(Me.updMinutes)
        Me.pnlTimeSelection.Enabled = False
        Me.pnlTimeSelection.Location = New System.Drawing.Point(588, 202)
        Me.pnlTimeSelection.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlTimeSelection.Name = "pnlTimeSelection"
        Me.pnlTimeSelection.Size = New System.Drawing.Size(113, 32)
        Me.pnlTimeSelection.TabIndex = 10
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.BackColor = System.Drawing.Color.Transparent
        Me.lblMinutes.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.Color.White
        Me.lblMinutes.Location = New System.Drawing.Point(62, 6)
        Me.lblMinutes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(50, 19)
        Me.lblMinutes.TabIndex = 3
        Me.lblMinutes.Text = "minute"
        '
        'updMinutes
        '
        Me.updMinutes.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updMinutes.Location = New System.Drawing.Point(10, 3)
        Me.updMinutes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.updMinutes.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.updMinutes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.updMinutes.Name = "updMinutes"
        Me.updMinutes.ReadOnly = True
        Me.updMinutes.Size = New System.Drawing.Size(44, 26)
        Me.updMinutes.TabIndex = 2
        Me.updMinutes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(12, 474)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(73, 28)
        Me.btnAbout.TabIndex = 17
        Me.btnAbout.Text = "About..."
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PMPE.My.Resources.Resources.app_background
        Me.ClientSize = New System.Drawing.Size(740, 510)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.pnlTimeSelection)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.chkTimedGame)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.grbNextCategory)
        Me.Controls.Add(Me.grbNextWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pictionary Mania! Portable Edition"
        Me.grbNextCategory.ResumeLayout(False)
        CType(Me.picCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNextWord.ResumeLayout(False)
        Me.grbNextWord.PerformLayout()
        Me.pnlTimeControls.ResumeLayout(False)
        Me.pnlWords.ResumeLayout(False)
        CType(Me.picFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTimeSelection.ResumeLayout(False)
        Me.pnlTimeSelection.PerformLayout()
        CType(Me.updMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrCountDown As System.Windows.Forms.Timer
    Friend WithEvents btnClassic As System.Windows.Forms.Button
    Friend WithEvents btnDrawback As System.Windows.Forms.Button
    Friend WithEvents btnDirectADraw As System.Windows.Forms.Button
    Friend WithEvents btnWrist As System.Windows.Forms.Button
    Friend WithEvents btnShuteye As System.Windows.Forms.Button
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents btnPeoplePutty As System.Windows.Forms.Button
    Friend WithEvents grbNextCategory As System.Windows.Forms.GroupBox
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents chkTimedGame As System.Windows.Forms.CheckBox
    Friend WithEvents btnToggleWordVisibility As System.Windows.Forms.Button
    Friend WithEvents btnNextWord As System.Windows.Forms.Button
    Friend WithEvents picCategory As System.Windows.Forms.PictureBox
    Friend WithEvents grbNextWord As System.Windows.Forms.GroupBox
    Friend WithEvents tmrReadySetGo As System.Windows.Forms.Timer
    Friend WithEvents lblReadySetGo As System.Windows.Forms.Label
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents pnlWords As Panel
    Friend WithEvents picFin As PictureBox
    Friend WithEvents picEng As PictureBox
    Friend WithEvents picIta As PictureBox
    Friend WithEvents lblFinWord As Label
    Friend WithEvents lblItaWord As Label
    Friend WithEvents lblEngWord As Label
    Friend WithEvents pnlTimeControls As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents btnPauseGameTimer As Button
    Friend WithEvents btnToggleGameTimer As Button
    Friend WithEvents pnlTimeSelection As Panel
    Friend WithEvents lblMinutes As Label
    Friend WithEvents updMinutes As NumericUpDown
    Friend WithEvents btnAbout As Button
End Class
