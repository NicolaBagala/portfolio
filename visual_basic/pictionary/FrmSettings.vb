Public Class FrmSettings

    Private Sub LoadSettingsForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkExit.Checked = My.Settings.ConfirmOnExit
        chkStart.Checked = My.Settings.PlayStartSound
        chkTick.Checked = My.Settings.PlayTickSound
        chkGong.Checked = My.Settings.PlayGongSound

    End Sub

    Private Sub SaveSettingsAndClose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        My.Settings.ConfirmOnExit = chkExit.Checked
        My.Settings.PlayStartSound = chkStart.Checked
        My.Settings.PlayTickSound = chkTick.Checked
        My.Settings.PlayGongSound = chkGong.Checked

        My.Settings.Save()

    End Sub

End Class