
Public Class frmInscription

    Const PRIX_CARDIO_INDIVIDUEL As Single = 120
    Const PRIX_CARDIO_FAMILIAL As Single = 160
    Const PRIX_MUSCULATION_INDIVIDUEL As Single = 110
    Const PRIX_MUSCULATION_FAMILIAL As Single = 140
    Const PRIX_KICK_BOXING_INDIVIDUEL As Single = 100
    Const PRIX_KICK_BOXING_FAMILIAL As Single = 130

    Const RABAIS_2_ACTIVITES_INDIVIDUEL As Single = 0.1
    Const RABAIS_2_ACTIVITES_FAMILIAL As Single = 0
    Const RABAIS_3_ACTIVITES_INDIVIDUEL As Single = 0.15
    Const RABAIS_3_ACTIVITES_FAMILIAL As Single = 0.1

    Const RABAIS_DUREE_9_INDIVIDUEL As Single = 0.1
    Const RABAIS_DUREE_9_FAMILIAL As Single = 0.15
    Const RABAIS_DUREE_12_INDIVIDUEL As Single = 0.15
    Const RABAIS_DUREE_12_FAMILIAL As Single = 0.2



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
End Class
