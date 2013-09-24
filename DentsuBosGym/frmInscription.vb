
Public Class frmInscription

    Private Sub frmInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSplash.ShowDialog()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Close()
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        txtNomClient.Text = ""
        optIndividuel.Select()
        optDuree3Mois.Select()
        chkChoixChest.Checked = False
        chkChoixBras.Checked = False
    End Sub
    Private Sub btnTarifs_Click(sender As Object, e As EventArgs) Handles btnTarifs.Click
        frmTarifs.ShowDialog()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        frmFacture.ShowDialog()
    End Sub

    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click

    End Sub
End Class
