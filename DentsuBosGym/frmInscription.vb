
Public Class frmInscription

    Const CARDIO_IND As Integer = 120
    Const CARDIO_FAM As Integer = 160
    Const MUSCU_IND As Integer = 110
    Const MUSCU_FAM As Integer = 140
    Const KICK_IND As Integer = 100
    Const KICK_FAM As Integer = 130
    Const RABAIS_2_ACT_IND As Double = 0.1
    Const RABAIS_2_ACT_FAM As Double = 0
    Const RABAIS_3_ACT_IND As Double = 0.15
    Const RABAIS_3_ACT_FAM As Double = 0.1
    Const RABAIS_9_MOIS_IND As Double = 0.1
    Const RABAIS_9_MOIS_FAM As Double = 0.15
    Const RABAIS_12_MOIS_IND As Double = 0.15
    Const RABAIS_12_MOIS_FAM As Double = 0.2
    Const TAX_TPS As Double = 0.05
    Const TAX_TVQ As Double = 0.0975

    Dim nom As String
    Dim isFamilial As Boolean
    Dim isCardio As Boolean
    Dim isMuscu As Boolean
    Dim isKick As Boolean
    Dim moisAbonnement As Integer
    Dim nbAct As Integer

    Dim isCardioInteger As Integer
    Dim isMuscuInteger As Integer
    Dim isKickInteger As Integer
    Dim prixBrut As Double
    Dim rabaisAct As Double
    Dim rabaisMois As Double
    Dim sousTotal As Double
    Dim prixRabais As Double
    Dim tps As Double
    Dim tvq As Double
    Dim prixFinal As Double
    Dim type As String = "Individuel"

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
