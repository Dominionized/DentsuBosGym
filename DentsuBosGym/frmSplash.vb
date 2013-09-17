Public Class frmSplash

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSplash.Start()
    End Sub

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
        Me.Close()
    End Sub

    Private Sub lblSplashTitre_Click(sender As Object, e As EventArgs) Handles lblSplashTitre.Click

    End Sub
End Class