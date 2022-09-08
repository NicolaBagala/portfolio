<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.chkExit = New System.Windows.Forms.CheckBox()
        Me.chkGong = New System.Windows.Forms.CheckBox()
        Me.chkTick = New System.Windows.Forms.CheckBox()
        Me.chkStart = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkExit
        '
        Me.chkExit.AutoSize = True
        Me.chkExit.BackColor = System.Drawing.Color.Transparent
        Me.chkExit.Checked = True
        Me.chkExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExit.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExit.ForeColor = System.Drawing.Color.White
        Me.chkExit.Location = New System.Drawing.Point(12, 15)
        Me.chkExit.Name = "chkExit"
        Me.chkExit.Size = New System.Drawing.Size(142, 27)
        Me.chkExit.TabIndex = 0
        Me.chkExit.Text = "Confirm on exit"
        Me.chkExit.UseVisualStyleBackColor = False
        '
        'chkGong
        '
        Me.chkGong.AutoSize = True
        Me.chkGong.BackColor = System.Drawing.Color.Transparent
        Me.chkGong.Checked = True
        Me.chkGong.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGong.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGong.ForeColor = System.Drawing.Color.White
        Me.chkGong.Location = New System.Drawing.Point(12, 84)
        Me.chkGong.Name = "chkGong"
        Me.chkGong.Size = New System.Drawing.Size(141, 27)
        Me.chkGong.TabIndex = 1
        Me.chkGong.Text = "Play gong sound"
        Me.chkGong.UseVisualStyleBackColor = False
        '
        'chkTick
        '
        Me.chkTick.AutoSize = True
        Me.chkTick.BackColor = System.Drawing.Color.Transparent
        Me.chkTick.Checked = True
        Me.chkTick.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTick.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTick.ForeColor = System.Drawing.Color.White
        Me.chkTick.Location = New System.Drawing.Point(12, 61)
        Me.chkTick.Name = "chkTick"
        Me.chkTick.Size = New System.Drawing.Size(143, 27)
        Me.chkTick.TabIndex = 2
        Me.chkTick.Text = "Play clock ticks"
        Me.chkTick.UseVisualStyleBackColor = False
        '
        'chkStart
        '
        Me.chkStart.AutoSize = True
        Me.chkStart.BackColor = System.Drawing.Color.Transparent
        Me.chkStart.Checked = True
        Me.chkStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStart.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkStart.ForeColor = System.Drawing.Color.White
        Me.chkStart.Location = New System.Drawing.Point(12, 38)
        Me.chkStart.Name = "chkStart"
        Me.chkStart.Size = New System.Drawing.Size(146, 27)
        Me.chkStart.TabIndex = 3
        Me.chkStart.Text = "Play start sound"
        Me.chkStart.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(106, 139)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(56, 25)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(168, 139)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 25)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PMPE.My.Resources.Resources.settings_background
        Me.ClientSize = New System.Drawing.Size(239, 176)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkStart)
        Me.Controls.Add(Me.chkTick)
        Me.Controls.Add(Me.chkGong)
        Me.Controls.Add(Me.chkExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkExit As System.Windows.Forms.CheckBox
    Friend WithEvents chkGong As System.Windows.Forms.CheckBox
    Friend WithEvents chkTick As System.Windows.Forms.CheckBox
    Friend WithEvents chkStart As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
