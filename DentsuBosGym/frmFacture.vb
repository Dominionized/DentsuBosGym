Imports System.Environment
Public Class frmFacture

    Private Sub frmFacture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim typeAbonnement As String
        Dim activitesChoisies As String = ""

        If isFamilial Then
            typeAbonnement = "Familial"
        Else
            typeAbonnement = "Individuel"
        End If

        If isCardio Then
            activitesChoisies = activitesChoisies + "Cardio "
        End If

        If isMuscu Then
            activitesChoisies = activitesChoisies + "Muscu "
        End If

        If isKick Then
            activitesChoisies = activitesChoisies + "Kick "
        End If

        txtFacture.Text = ("Nom: " & nom & NewLine & _
                           "Abonnement: " & typeAbonnement & NewLine & _
                           "Activités: " & activitesChoisies & NewLine & _
                           "Durée: " & moisAbonnement & " mois" & NewLine & _
                           "Coût des activités: " & Format(prixBrut, "currrency") & NewLine & _
                           "Rabais activités: " & Format(rabaisAct, "currency") & NewLine & _
                           "Sous total: " & Format(sousTotal, "currency") & NewLine & _
                           "Rabais Durée: " & Format(rabaisMois, "currency") & _
                           "Total de l'abonnement: " & Format(prixFinal, "currency") & NewLine & NewLine & _
                           "TPS: " & )
    End Sub
End Class