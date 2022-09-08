Public Class FrmLoader

    Private _dbInstance As Database

    Friend WriteOnly Property Database
        Set(value)
            _dbInstance = value
        End Set
    End Property

    Private Sub CenterLoader() Handles MyBase.Load

        ' Center the loader form with respect to the main game form.
        Me.Left = FrmMain.Left + (FrmMain.Width / 2) - (Me.Width / 2)
        Me.Top = FrmMain.Top + (FrmMain.Height / 2) - (Me.Height / 2)
    End Sub

    Friend Sub IncrementProgressBar()
        pgbLoading.PerformStep()
        pgbLoading.Refresh()
    End Sub

    Friend Sub InitializeProgressBar(ByVal maxValue As Integer)

        pgbLoading.Maximum = maxValue
        pgbLoading.Value = 0

    End Sub

    Private Sub LoadDatabase() Handles Me.Shown

        _dbInstance.Load(Me)

    End Sub

    Private Sub CenterLoader(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class