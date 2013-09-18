<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.picCoin = New System.Windows.Forms.PictureBox()
        Me.lblNomClient = New System.Windows.Forms.Label()
        Me.grbAbonnement = New System.Windows.Forms.GroupBox()
        Me.grbDuree = New System.Windows.Forms.GroupBox()
        Me.grbActivites = New System.Windows.Forms.GroupBox()
        Me.grbTarification = New System.Windows.Forms.GroupBox()
        Me.txtNomClient = New System.Windows.Forms.TextBox()
        Me.optIndividuel = New System.Windows.Forms.RadioButton()
        Me.optFamilial = New System.Windows.Forms.RadioButton()
        Me.optDuree9Mois = New System.Windows.Forms.RadioButton()
        Me.optDuree6Mois = New System.Windows.Forms.RadioButton()
        Me.optDuree3Mois = New System.Windows.Forms.RadioButton()
        Me.chkChoixChest = New System.Windows.Forms.CheckBox()
        Me.chkChoixBras = New System.Windows.Forms.CheckBox()
        Me.chkChoixDos = New System.Windows.Forms.CheckBox()
        Me.optDuree12Mois = New System.Windows.Forms.RadioButton()
        Me.lblTitrePrixTotal = New System.Windows.Forms.Label()
        Me.lblPrixTotal = New System.Windows.Forms.Label()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnTarifs = New System.Windows.Forms.Button()
        Me.lblSousTitre = New System.Windows.Forms.Label()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAbonnement.SuspendLayout()
        Me.grbDuree.SuspendLayout()
        Me.grbActivites.SuspendLayout()
        Me.grbTarification.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(29, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(237, 36)
        Me.lblTitre.TabIndex = 1
        Me.lblTitre.Text = "DentsuBosGym"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picCoin
        '
        Me.picCoin.Image = Global.DentsuBosGym.My.Resources.Resources.ImageCoin
        Me.picCoin.Location = New System.Drawing.Point(272, 12)
        Me.picCoin.Name = "picCoin"
        Me.picCoin.Size = New System.Drawing.Size(100, 100)
        Me.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCoin.TabIndex = 0
        Me.picCoin.TabStop = False
        '
        'lblNomClient
        '
        Me.lblNomClient.AutoSize = True
        Me.lblNomClient.Location = New System.Drawing.Point(12, 131)
        Me.lblNomClient.Name = "lblNomClient"
        Me.lblNomClient.Size = New System.Drawing.Size(78, 13)
        Me.lblNomClient.TabIndex = 2
        Me.lblNomClient.Text = "Nom du client :"
        '
        'grbAbonnement
        '
        Me.grbAbonnement.Controls.Add(Me.optFamilial)
        Me.grbAbonnement.Controls.Add(Me.optIndividuel)
        Me.grbAbonnement.Location = New System.Drawing.Point(12, 173)
        Me.grbAbonnement.Name = "grbAbonnement"
        Me.grbAbonnement.Size = New System.Drawing.Size(102, 115)
        Me.grbAbonnement.TabIndex = 3
        Me.grbAbonnement.TabStop = False
        Me.grbAbonnement.Text = "Abonnement"
        '
        'grbDuree
        '
        Me.grbDuree.Controls.Add(Me.optDuree12Mois)
        Me.grbDuree.Controls.Add(Me.optDuree3Mois)
        Me.grbDuree.Controls.Add(Me.optDuree6Mois)
        Me.grbDuree.Controls.Add(Me.optDuree9Mois)
        Me.grbDuree.Location = New System.Drawing.Point(120, 173)
        Me.grbDuree.Name = "grbDuree"
        Me.grbDuree.Size = New System.Drawing.Size(105, 115)
        Me.grbDuree.TabIndex = 4
        Me.grbDuree.TabStop = False
        Me.grbDuree.Text = "Durée"
        '
        'grbActivites
        '
        Me.grbActivites.Controls.Add(Me.chkChoixDos)
        Me.grbActivites.Controls.Add(Me.chkChoixBras)
        Me.grbActivites.Controls.Add(Me.chkChoixChest)
        Me.grbActivites.Location = New System.Drawing.Point(231, 175)
        Me.grbActivites.Name = "grbActivites"
        Me.grbActivites.Size = New System.Drawing.Size(141, 113)
        Me.grbActivites.TabIndex = 5
        Me.grbActivites.TabStop = False
        Me.grbActivites.Text = "Activités"
        '
        'grbTarification
        '
        Me.grbTarification.Controls.Add(Me.btnTarifs)
        Me.grbTarification.Controls.Add(Me.btnDetails)
        Me.grbTarification.Controls.Add(Me.lblPrixTotal)
        Me.grbTarification.Controls.Add(Me.lblTitrePrixTotal)
        Me.grbTarification.Location = New System.Drawing.Point(12, 303)
        Me.grbTarification.Name = "grbTarification"
        Me.grbTarification.Size = New System.Drawing.Size(360, 75)
        Me.grbTarification.TabIndex = 6
        Me.grbTarification.TabStop = False
        Me.grbTarification.Text = "Tarification"
        '
        'txtNomClient
        '
        Me.txtNomClient.Location = New System.Drawing.Point(90, 128)
        Me.txtNomClient.Name = "txtNomClient"
        Me.txtNomClient.ReadOnly = True
        Me.txtNomClient.Size = New System.Drawing.Size(282, 20)
        Me.txtNomClient.TabIndex = 7
        Me.txtNomClient.Tag = ""
        '
        'optIndividuel
        '
        Me.optIndividuel.AutoSize = True
        Me.optIndividuel.Location = New System.Drawing.Point(6, 35)
        Me.optIndividuel.Name = "optIndividuel"
        Me.optIndividuel.Size = New System.Drawing.Size(70, 17)
        Me.optIndividuel.TabIndex = 0
        Me.optIndividuel.TabStop = True
        Me.optIndividuel.Text = "Individuel"
        Me.optIndividuel.UseVisualStyleBackColor = True
        '
        'optFamilial
        '
        Me.optFamilial.AutoSize = True
        Me.optFamilial.Location = New System.Drawing.Point(6, 59)
        Me.optFamilial.Name = "optFamilial"
        Me.optFamilial.Size = New System.Drawing.Size(59, 17)
        Me.optFamilial.TabIndex = 1
        Me.optFamilial.TabStop = True
        Me.optFamilial.Text = "Familial"
        Me.optFamilial.UseVisualStyleBackColor = True
        '
        'optDuree9Mois
        '
        Me.optDuree9Mois.AutoSize = True
        Me.optDuree9Mois.Location = New System.Drawing.Point(6, 66)
        Me.optDuree9Mois.Name = "optDuree9Mois"
        Me.optDuree9Mois.Size = New System.Drawing.Size(55, 17)
        Me.optDuree9Mois.TabIndex = 0
        Me.optDuree9Mois.TabStop = True
        Me.optDuree9Mois.Text = "9 mois"
        Me.optDuree9Mois.UseVisualStyleBackColor = True
        '
        'optDuree6Mois
        '
        Me.optDuree6Mois.AutoSize = True
        Me.optDuree6Mois.Location = New System.Drawing.Point(6, 43)
        Me.optDuree6Mois.Name = "optDuree6Mois"
        Me.optDuree6Mois.Size = New System.Drawing.Size(55, 17)
        Me.optDuree6Mois.TabIndex = 1
        Me.optDuree6Mois.TabStop = True
        Me.optDuree6Mois.Text = "6 mois"
        Me.optDuree6Mois.UseVisualStyleBackColor = True
        '
        'optDuree3Mois
        '
        Me.optDuree3Mois.AutoSize = True
        Me.optDuree3Mois.Location = New System.Drawing.Point(6, 19)
        Me.optDuree3Mois.Name = "optDuree3Mois"
        Me.optDuree3Mois.Size = New System.Drawing.Size(55, 17)
        Me.optDuree3Mois.TabIndex = 2
        Me.optDuree3Mois.TabStop = True
        Me.optDuree3Mois.Text = "3 mois"
        Me.optDuree3Mois.UseVisualStyleBackColor = True
        '
        'chkChoixChest
        '
        Me.chkChoixChest.AutoSize = True
        Me.chkChoixChest.Location = New System.Drawing.Point(6, 19)
        Me.chkChoixChest.Name = "chkChoixChest"
        Me.chkChoixChest.Size = New System.Drawing.Size(53, 17)
        Me.chkChoixChest.TabIndex = 0
        Me.chkChoixChest.Text = "Chest"
        Me.chkChoixChest.UseVisualStyleBackColor = True
        '
        'chkChoixBras
        '
        Me.chkChoixBras.AutoSize = True
        Me.chkChoixBras.Location = New System.Drawing.Point(6, 52)
        Me.chkChoixBras.Name = "chkChoixBras"
        Me.chkChoixBras.Size = New System.Drawing.Size(47, 17)
        Me.chkChoixBras.TabIndex = 1
        Me.chkChoixBras.Text = "Bras"
        Me.chkChoixBras.UseVisualStyleBackColor = True
        '
        'chkChoixDos
        '
        Me.chkChoixDos.AutoSize = True
        Me.chkChoixDos.Location = New System.Drawing.Point(6, 87)
        Me.chkChoixDos.Name = "chkChoixDos"
        Me.chkChoixDos.Size = New System.Drawing.Size(45, 17)
        Me.chkChoixDos.TabIndex = 2
        Me.chkChoixDos.Text = "Dos"
        Me.chkChoixDos.UseVisualStyleBackColor = True
        '
        'optDuree12Mois
        '
        Me.optDuree12Mois.AutoSize = True
        Me.optDuree12Mois.Location = New System.Drawing.Point(6, 89)
        Me.optDuree12Mois.Name = "optDuree12Mois"
        Me.optDuree12Mois.Size = New System.Drawing.Size(61, 17)
        Me.optDuree12Mois.TabIndex = 4
        Me.optDuree12Mois.TabStop = True
        Me.optDuree12Mois.Text = "12 mois"
        Me.optDuree12Mois.UseVisualStyleBackColor = True
        '
        'lblTitrePrixTotal
        '
        Me.lblTitrePrixTotal.AutoSize = True
        Me.lblTitrePrixTotal.Location = New System.Drawing.Point(7, 30)
        Me.lblTitrePrixTotal.Name = "lblTitrePrixTotal"
        Me.lblTitrePrixTotal.Size = New System.Drawing.Size(57, 13)
        Me.lblTitrePrixTotal.TabIndex = 0
        Me.lblTitrePrixTotal.Text = "Prix Total :"
        '
        'lblPrixTotal
        '
        Me.lblPrixTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrixTotal.Location = New System.Drawing.Point(70, 16)
        Me.lblPrixTotal.Name = "lblPrixTotal"
        Me.lblPrixTotal.Size = New System.Drawing.Size(127, 43)
        Me.lblPrixTotal.TabIndex = 1
        Me.lblPrixTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(204, 16)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(68, 43)
        Me.btnDetails.TabIndex = 2
        Me.btnDetails.Text = "Détails"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnTarifs
        '
        Me.btnTarifs.Location = New System.Drawing.Point(278, 16)
        Me.btnTarifs.Name = "btnTarifs"
        Me.btnTarifs.Size = New System.Drawing.Size(76, 43)
        Me.btnTarifs.TabIndex = 3
        Me.btnTarifs.Text = "Tarifs"
        Me.btnTarifs.UseVisualStyleBackColor = True
        '
        'lblSousTitre
        '
        Me.lblSousTitre.AutoSize = True
        Me.lblSousTitre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSousTitre.Location = New System.Drawing.Point(107, 45)
        Me.lblSousTitre.Name = "lblSousTitre"
        Me.lblSousTitre.Size = New System.Drawing.Size(159, 18)
        Me.lblSousTitre.TabIndex = 8
        Me.lblSousTitre.Text = "Le Gym des Hommes"
        Me.lblSousTitre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculer
        '
        Me.btnCalculer.Location = New System.Drawing.Point(12, 385)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(78, 38)
        Me.btnCalculer.TabIndex = 9
        Me.btnCalculer.Text = "Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(96, 385)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(78, 38)
        Me.btnAnnuler.TabIndex = 10
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(294, 385)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(78, 38)
        Me.btnQuitter.TabIndex = 11
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'frmInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(384, 435)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.lblSousTitre)
        Me.Controls.Add(Me.txtNomClient)
        Me.Controls.Add(Me.grbTarification)
        Me.Controls.Add(Me.grbActivites)
        Me.Controls.Add(Me.grbDuree)
        Me.Controls.Add(Me.grbAbonnement)
        Me.Controls.Add(Me.lblNomClient)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.picCoin)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInscription"
        Me.Text = "DentsuBosGym - Inscription"
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAbonnement.ResumeLayout(False)
        Me.grbAbonnement.PerformLayout()
        Me.grbDuree.ResumeLayout(False)
        Me.grbDuree.PerformLayout()
        Me.grbActivites.ResumeLayout(False)
        Me.grbActivites.PerformLayout()
        Me.grbTarification.ResumeLayout(False)
        Me.grbTarification.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCoin As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblNomClient As System.Windows.Forms.Label
    Friend WithEvents grbAbonnement As System.Windows.Forms.GroupBox
    Friend WithEvents grbDuree As System.Windows.Forms.GroupBox
    Friend WithEvents grbActivites As System.Windows.Forms.GroupBox
    Friend WithEvents grbTarification As System.Windows.Forms.GroupBox
    Friend WithEvents txtNomClient As System.Windows.Forms.TextBox
    Friend WithEvents optFamilial As System.Windows.Forms.RadioButton
    Friend WithEvents optIndividuel As System.Windows.Forms.RadioButton
    Friend WithEvents optDuree12Mois As System.Windows.Forms.RadioButton
    Friend WithEvents optDuree3Mois As System.Windows.Forms.RadioButton
    Friend WithEvents optDuree6Mois As System.Windows.Forms.RadioButton
    Friend WithEvents optDuree9Mois As System.Windows.Forms.RadioButton
    Friend WithEvents chkChoixDos As System.Windows.Forms.CheckBox
    Friend WithEvents chkChoixBras As System.Windows.Forms.CheckBox
    Friend WithEvents chkChoixChest As System.Windows.Forms.CheckBox
    Friend WithEvents btnTarifs As System.Windows.Forms.Button
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents lblPrixTotal As System.Windows.Forms.Label
    Friend WithEvents lblTitrePrixTotal As System.Windows.Forms.Label
    Friend WithEvents lblSousTitre As System.Windows.Forms.Label
    Friend WithEvents btnCalculer As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button

End Class
