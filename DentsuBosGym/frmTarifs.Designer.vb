<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifs
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
        Me.lblTitreTarifs = New System.Windows.Forms.Label()
        Me.tblTarifs = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRabaisDuree12MoisFamilial = New System.Windows.Forms.Label()
        Me.lblTarifFamilial = New System.Windows.Forms.Label()
        Me.lblTarifIndividuel = New System.Windows.Forms.Label()
        Me.lblTarifsTrimestriels = New System.Windows.Forms.Label()
        Me.lblChest = New System.Windows.Forms.Label()
        Me.lblBras = New System.Windows.Forms.Label()
        Me.lblDos = New System.Windows.Forms.Label()
        Me.lblRabaisActivites = New System.Windows.Forms.Label()
        Me.lblRabais2ActivitesTitre = New System.Windows.Forms.Label()
        Me.lblRabais3ActivitesTitre = New System.Windows.Forms.Label()
        Me.lblRabaisDuree = New System.Windows.Forms.Label()
        Me.lblRabaisDuree9MoisTitre = New System.Windows.Forms.Label()
        Me.lblRabaisDuree12MoisTitre = New System.Windows.Forms.Label()
        Me.lblPrixActiviteChestIndividuel = New System.Windows.Forms.Label()
        Me.lblPrixActiviteBrasIndividuel = New System.Windows.Forms.Label()
        Me.lblPrixActiviteDosIndividuel = New System.Windows.Forms.Label()
        Me.lblPrixActiviteChestFamilial = New System.Windows.Forms.Label()
        Me.lblPrixActiviteBrasFamilial = New System.Windows.Forms.Label()
        Me.lblPrixActiviteDosFamilial = New System.Windows.Forms.Label()
        Me.lblRabais2ActivitesIndividuel = New System.Windows.Forms.Label()
        Me.lblRabais3ActivitesIndividuel = New System.Windows.Forms.Label()
        Me.lblRabais2ActivitesFamilial = New System.Windows.Forms.Label()
        Me.lblRabais3ActivitesFamilial = New System.Windows.Forms.Label()
        Me.lblRabaisDuree9MoisIndividuel = New System.Windows.Forms.Label()
        Me.lblRabaisDuree12MoisIndividuel = New System.Windows.Forms.Label()
        Me.lblRabaisDuree9MoisFamilial = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.tblTarifs.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitreTarifs
        '
        Me.lblTitreTarifs.AutoSize = True
        Me.lblTitreTarifs.Location = New System.Drawing.Point(4, 1)
        Me.lblTitreTarifs.Name = "lblTitreTarifs"
        Me.lblTitreTarifs.Size = New System.Drawing.Size(33, 13)
        Me.lblTitreTarifs.TabIndex = 0
        Me.lblTitreTarifs.Text = "Tarifs"
        '
        'tblTarifs
        '
        Me.tblTarifs.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblTarifs.ColumnCount = 3
        Me.tblTarifs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83818!))
        Me.tblTarifs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.53722!))
        Me.tblTarifs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.6246!))
        Me.tblTarifs.Controls.Add(Me.lblTarifFamilial, 2, 0)
        Me.tblTarifs.Controls.Add(Me.lblTitreTarifs, 0, 0)
        Me.tblTarifs.Controls.Add(Me.lblTarifIndividuel, 1, 0)
        Me.tblTarifs.Controls.Add(Me.lblTarifsTrimestriels, 0, 1)
        Me.tblTarifs.Controls.Add(Me.lblChest, 0, 2)
        Me.tblTarifs.Controls.Add(Me.lblBras, 0, 3)
        Me.tblTarifs.Controls.Add(Me.lblDos, 0, 4)
        Me.tblTarifs.Controls.Add(Me.lblRabaisActivites, 0, 5)
        Me.tblTarifs.Controls.Add(Me.lblRabais2ActivitesTitre, 0, 6)
        Me.tblTarifs.Controls.Add(Me.lblRabais3ActivitesTitre, 0, 7)
        Me.tblTarifs.Controls.Add(Me.lblRabaisDuree, 0, 8)
        Me.tblTarifs.Controls.Add(Me.lblRabaisDuree9MoisTitre, 0, 9)
        Me.tblTarifs.Controls.Add(Me.lblRabaisDuree12MoisTitre, 0, 10)
        Me.tblTarifs.Controls.Add(Me.lblPrixActiviteChestIndividuel, 1, 2)
        Me.tblTarifs.Controls.Add(Me.lblPrixActiviteBrasIndividuel, 1, 3)
        Me.tblTarifs.Controls.Add(Me.lblPrixActiviteDosIndividuel, 1, 4)
        Me.tblTarifs.Controls.Add(Me.lblPrixActiviteChestFamilial, 2, 2)
        Me.tblTarifs.Controls.Add(Me.lblPrixActiviteBrasFamilial, 2, 3)
        Me.tblTarifs.Controls.Add(Me.lblPrixActiviteDosFamilial, 2, 4)
        Me.tblTarifs.Controls.Add(Me.lblRabais2ActivitesIndividuel, 1, 6)
        Me.tblTarifs.Controls.Add(Me.lblRabais3ActivitesIndividuel, 1, 7)
        Me.tblTarifs.Controls.Add(Me.lblRabais2ActivitesFamilial, 2, 6)
        Me.tblTarifs.Controls.Add(Me.lblRabais3ActivitesFamilial, 2, 7)
        Me.tblTarifs.Controls.Add(Me.lblRabaisDuree9MoisIndividuel, 1, 9)
        Me.tblTarifs.Controls.Add(Me.lblRabaisDuree12MoisIndividuel, 1, 10)
        Me.tblTarifs.Controls.Add(Me.lblRabaisDuree9MoisFamilial, 2, 9)
        Me.tblTarifs.Controls.Add(Me.lblRabaisDuree12MoisFamilial, 2, 10)
        Me.tblTarifs.Location = New System.Drawing.Point(12, 12)
        Me.tblTarifs.Name = "tblTarifs"
        Me.tblTarifs.RowCount = 11
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.tblTarifs.Size = New System.Drawing.Size(310, 279)
        Me.tblTarifs.TabIndex = 1
        '
        'lblRabaisDuree12MoisFamilial
        '
        Me.lblRabaisDuree12MoisFamilial.AutoSize = True
        Me.lblRabaisDuree12MoisFamilial.Location = New System.Drawing.Point(239, 251)
        Me.lblRabaisDuree12MoisFamilial.Name = "lblRabaisDuree12MoisFamilial"
        Me.lblRabaisDuree12MoisFamilial.Size = New System.Drawing.Size(45, 13)
        Me.lblRabaisDuree12MoisFamilial.TabIndex = 26
        Me.lblRabaisDuree12MoisFamilial.Text = "Label14"
        '
        'lblTarifFamilial
        '
        Me.lblTarifFamilial.AutoSize = True
        Me.lblTarifFamilial.Location = New System.Drawing.Point(239, 1)
        Me.lblTarifFamilial.Name = "lblTarifFamilial"
        Me.lblTarifFamilial.Size = New System.Drawing.Size(41, 13)
        Me.lblTarifFamilial.TabIndex = 2
        Me.lblTarifFamilial.Text = "Familial"
        '
        'lblTarifIndividuel
        '
        Me.lblTarifIndividuel.AutoSize = True
        Me.lblTarifIndividuel.Location = New System.Drawing.Point(157, 1)
        Me.lblTarifIndividuel.Name = "lblTarifIndividuel"
        Me.lblTarifIndividuel.Size = New System.Drawing.Size(52, 13)
        Me.lblTarifIndividuel.TabIndex = 1
        Me.lblTarifIndividuel.Text = "Individuel"
        '
        'lblTarifsTrimestriels
        '
        Me.lblTarifsTrimestriels.AutoSize = True
        Me.lblTarifsTrimestriels.Location = New System.Drawing.Point(4, 26)
        Me.lblTarifsTrimestriels.Name = "lblTarifsTrimestriels"
        Me.lblTarifsTrimestriels.Size = New System.Drawing.Size(146, 13)
        Me.lblTarifsTrimestriels.TabIndex = 3
        Me.lblTarifsTrimestriels.Text = "Tarifs trimestriels des activités"
        '
        'lblChest
        '
        Me.lblChest.AutoSize = True
        Me.lblChest.Location = New System.Drawing.Point(4, 51)
        Me.lblChest.Name = "lblChest"
        Me.lblChest.Size = New System.Drawing.Size(34, 13)
        Me.lblChest.TabIndex = 4
        Me.lblChest.Text = "Chest"
        '
        'lblBras
        '
        Me.lblBras.AutoSize = True
        Me.lblBras.Location = New System.Drawing.Point(4, 76)
        Me.lblBras.Name = "lblBras"
        Me.lblBras.Size = New System.Drawing.Size(28, 13)
        Me.lblBras.TabIndex = 5
        Me.lblBras.Text = "Bras"
        '
        'lblDos
        '
        Me.lblDos.AutoSize = True
        Me.lblDos.Location = New System.Drawing.Point(4, 101)
        Me.lblDos.Name = "lblDos"
        Me.lblDos.Size = New System.Drawing.Size(26, 13)
        Me.lblDos.TabIndex = 6
        Me.lblDos.Text = "Dos"
        '
        'lblRabaisActivites
        '
        Me.lblRabaisActivites.AutoSize = True
        Me.lblRabaisActivites.Location = New System.Drawing.Point(4, 126)
        Me.lblRabaisActivites.Name = "lblRabaisActivites"
        Me.lblRabaisActivites.Size = New System.Drawing.Size(115, 13)
        Me.lblRabaisActivites.TabIndex = 7
        Me.lblRabaisActivites.Text = "Rabais sur les activités"
        '
        'lblRabais2ActivitesTitre
        '
        Me.lblRabais2ActivitesTitre.AutoSize = True
        Me.lblRabais2ActivitesTitre.Location = New System.Drawing.Point(4, 151)
        Me.lblRabais2ActivitesTitre.Name = "lblRabais2ActivitesTitre"
        Me.lblRabais2ActivitesTitre.Size = New System.Drawing.Size(55, 13)
        Me.lblRabais2ActivitesTitre.TabIndex = 8
        Me.lblRabais2ActivitesTitre.Text = "2 activités"
        '
        'lblRabais3ActivitesTitre
        '
        Me.lblRabais3ActivitesTitre.AutoSize = True
        Me.lblRabais3ActivitesTitre.Location = New System.Drawing.Point(4, 176)
        Me.lblRabais3ActivitesTitre.Name = "lblRabais3ActivitesTitre"
        Me.lblRabais3ActivitesTitre.Size = New System.Drawing.Size(55, 13)
        Me.lblRabais3ActivitesTitre.TabIndex = 9
        Me.lblRabais3ActivitesTitre.Text = "3 activités"
        '
        'lblRabaisDuree
        '
        Me.lblRabaisDuree.AutoSize = True
        Me.lblRabaisDuree.Location = New System.Drawing.Point(4, 201)
        Me.lblRabaisDuree.Name = "lblRabaisDuree"
        Me.lblRabaisDuree.Size = New System.Drawing.Size(98, 13)
        Me.lblRabaisDuree.TabIndex = 10
        Me.lblRabaisDuree.Text = "Rabais sur la durée"
        '
        'lblRabaisDuree9MoisTitre
        '
        Me.lblRabaisDuree9MoisTitre.AutoSize = True
        Me.lblRabaisDuree9MoisTitre.Location = New System.Drawing.Point(4, 226)
        Me.lblRabaisDuree9MoisTitre.Name = "lblRabaisDuree9MoisTitre"
        Me.lblRabaisDuree9MoisTitre.Size = New System.Drawing.Size(37, 13)
        Me.lblRabaisDuree9MoisTitre.TabIndex = 11
        Me.lblRabaisDuree9MoisTitre.Text = "9 mois"
        '
        'lblRabaisDuree12MoisTitre
        '
        Me.lblRabaisDuree12MoisTitre.AutoSize = True
        Me.lblRabaisDuree12MoisTitre.Location = New System.Drawing.Point(4, 251)
        Me.lblRabaisDuree12MoisTitre.Name = "lblRabaisDuree12MoisTitre"
        Me.lblRabaisDuree12MoisTitre.Size = New System.Drawing.Size(43, 13)
        Me.lblRabaisDuree12MoisTitre.TabIndex = 12
        Me.lblRabaisDuree12MoisTitre.Text = "12 mois"
        '
        'lblPrixActiviteChestIndividuel
        '
        Me.lblPrixActiviteChestIndividuel.AutoSize = True
        Me.lblPrixActiviteChestIndividuel.Location = New System.Drawing.Point(157, 51)
        Me.lblPrixActiviteChestIndividuel.Name = "lblPrixActiviteChestIndividuel"
        Me.lblPrixActiviteChestIndividuel.Size = New System.Drawing.Size(39, 13)
        Me.lblPrixActiviteChestIndividuel.TabIndex = 13
        Me.lblPrixActiviteChestIndividuel.Text = "Label1"
        '
        'lblPrixActiviteBrasIndividuel
        '
        Me.lblPrixActiviteBrasIndividuel.AutoSize = True
        Me.lblPrixActiviteBrasIndividuel.Location = New System.Drawing.Point(157, 76)
        Me.lblPrixActiviteBrasIndividuel.Name = "lblPrixActiviteBrasIndividuel"
        Me.lblPrixActiviteBrasIndividuel.Size = New System.Drawing.Size(39, 13)
        Me.lblPrixActiviteBrasIndividuel.TabIndex = 14
        Me.lblPrixActiviteBrasIndividuel.Text = "Label2"
        '
        'lblPrixActiviteDosIndividuel
        '
        Me.lblPrixActiviteDosIndividuel.AutoSize = True
        Me.lblPrixActiviteDosIndividuel.Location = New System.Drawing.Point(157, 101)
        Me.lblPrixActiviteDosIndividuel.Name = "lblPrixActiviteDosIndividuel"
        Me.lblPrixActiviteDosIndividuel.Size = New System.Drawing.Size(39, 13)
        Me.lblPrixActiviteDosIndividuel.TabIndex = 15
        Me.lblPrixActiviteDosIndividuel.Text = "Label3"
        '
        'lblPrixActiviteChestFamilial
        '
        Me.lblPrixActiviteChestFamilial.AutoSize = True
        Me.lblPrixActiviteChestFamilial.Location = New System.Drawing.Point(239, 51)
        Me.lblPrixActiviteChestFamilial.Name = "lblPrixActiviteChestFamilial"
        Me.lblPrixActiviteChestFamilial.Size = New System.Drawing.Size(39, 13)
        Me.lblPrixActiviteChestFamilial.TabIndex = 16
        Me.lblPrixActiviteChestFamilial.Text = "Label4"
        '
        'lblPrixActiviteBrasFamilial
        '
        Me.lblPrixActiviteBrasFamilial.AutoSize = True
        Me.lblPrixActiviteBrasFamilial.Location = New System.Drawing.Point(239, 76)
        Me.lblPrixActiviteBrasFamilial.Name = "lblPrixActiviteBrasFamilial"
        Me.lblPrixActiviteBrasFamilial.Size = New System.Drawing.Size(39, 13)
        Me.lblPrixActiviteBrasFamilial.TabIndex = 17
        Me.lblPrixActiviteBrasFamilial.Text = "Label5"
        '
        'lblPrixActiviteDosFamilial
        '
        Me.lblPrixActiviteDosFamilial.AutoSize = True
        Me.lblPrixActiviteDosFamilial.Location = New System.Drawing.Point(239, 101)
        Me.lblPrixActiviteDosFamilial.Name = "lblPrixActiviteDosFamilial"
        Me.lblPrixActiviteDosFamilial.Size = New System.Drawing.Size(39, 13)
        Me.lblPrixActiviteDosFamilial.TabIndex = 18
        Me.lblPrixActiviteDosFamilial.Text = "Label6"
        '
        'lblRabais2ActivitesIndividuel
        '
        Me.lblRabais2ActivitesIndividuel.AutoSize = True
        Me.lblRabais2ActivitesIndividuel.Location = New System.Drawing.Point(157, 151)
        Me.lblRabais2ActivitesIndividuel.Name = "lblRabais2ActivitesIndividuel"
        Me.lblRabais2ActivitesIndividuel.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais2ActivitesIndividuel.TabIndex = 19
        Me.lblRabais2ActivitesIndividuel.Text = "Label7"
        '
        'lblRabais3ActivitesIndividuel
        '
        Me.lblRabais3ActivitesIndividuel.AutoSize = True
        Me.lblRabais3ActivitesIndividuel.Location = New System.Drawing.Point(157, 176)
        Me.lblRabais3ActivitesIndividuel.Name = "lblRabais3ActivitesIndividuel"
        Me.lblRabais3ActivitesIndividuel.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais3ActivitesIndividuel.TabIndex = 20
        Me.lblRabais3ActivitesIndividuel.Text = "Label8"
        '
        'lblRabais2ActivitesFamilial
        '
        Me.lblRabais2ActivitesFamilial.AutoSize = True
        Me.lblRabais2ActivitesFamilial.Location = New System.Drawing.Point(239, 151)
        Me.lblRabais2ActivitesFamilial.Name = "lblRabais2ActivitesFamilial"
        Me.lblRabais2ActivitesFamilial.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais2ActivitesFamilial.TabIndex = 21
        Me.lblRabais2ActivitesFamilial.Text = "Label9"
        '
        'lblRabais3ActivitesFamilial
        '
        Me.lblRabais3ActivitesFamilial.AutoSize = True
        Me.lblRabais3ActivitesFamilial.Location = New System.Drawing.Point(239, 176)
        Me.lblRabais3ActivitesFamilial.Name = "lblRabais3ActivitesFamilial"
        Me.lblRabais3ActivitesFamilial.Size = New System.Drawing.Size(45, 13)
        Me.lblRabais3ActivitesFamilial.TabIndex = 22
        Me.lblRabais3ActivitesFamilial.Text = "Label10"
        '
        'lblRabaisDuree9MoisIndividuel
        '
        Me.lblRabaisDuree9MoisIndividuel.AutoSize = True
        Me.lblRabaisDuree9MoisIndividuel.Location = New System.Drawing.Point(157, 226)
        Me.lblRabaisDuree9MoisIndividuel.Name = "lblRabaisDuree9MoisIndividuel"
        Me.lblRabaisDuree9MoisIndividuel.Size = New System.Drawing.Size(45, 13)
        Me.lblRabaisDuree9MoisIndividuel.TabIndex = 23
        Me.lblRabaisDuree9MoisIndividuel.Text = "Label11"
        '
        'lblRabaisDuree12MoisIndividuel
        '
        Me.lblRabaisDuree12MoisIndividuel.AutoSize = True
        Me.lblRabaisDuree12MoisIndividuel.Location = New System.Drawing.Point(157, 251)
        Me.lblRabaisDuree12MoisIndividuel.Name = "lblRabaisDuree12MoisIndividuel"
        Me.lblRabaisDuree12MoisIndividuel.Size = New System.Drawing.Size(45, 13)
        Me.lblRabaisDuree12MoisIndividuel.TabIndex = 24
        Me.lblRabaisDuree12MoisIndividuel.Text = "Label12"
        '
        'lblRabaisDuree9MoisFamilial
        '
        Me.lblRabaisDuree9MoisFamilial.AutoSize = True
        Me.lblRabaisDuree9MoisFamilial.Location = New System.Drawing.Point(239, 226)
        Me.lblRabaisDuree9MoisFamilial.Name = "lblRabaisDuree9MoisFamilial"
        Me.lblRabaisDuree9MoisFamilial.Size = New System.Drawing.Size(45, 13)
        Me.lblRabaisDuree9MoisFamilial.TabIndex = 25
        Me.lblRabaisDuree9MoisFamilial.Text = "Label13"
        '
        'btnFermer
        '
        Me.btnFermer.Location = New System.Drawing.Point(246, 301)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(75, 23)
        Me.btnFermer.TabIndex = 2
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'frmTarifs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 336)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.tblTarifs)
        Me.Name = "frmTarifs"
        Me.Text = "Tarification"
        Me.tblTarifs.ResumeLayout(False)
        Me.tblTarifs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitreTarifs As System.Windows.Forms.Label
    Friend WithEvents tblTarifs As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTarifFamilial As System.Windows.Forms.Label
    Friend WithEvents lblTarifIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblTarifsTrimestriels As System.Windows.Forms.Label
    Friend WithEvents lblChest As System.Windows.Forms.Label
    Friend WithEvents lblBras As System.Windows.Forms.Label
    Friend WithEvents lblDos As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree12MoisFamilial As System.Windows.Forms.Label
    Friend WithEvents lblRabaisActivites As System.Windows.Forms.Label
    Friend WithEvents lblRabais2ActivitesTitre As System.Windows.Forms.Label
    Friend WithEvents lblRabais3ActivitesTitre As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree9MoisTitre As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree12MoisTitre As System.Windows.Forms.Label
    Friend WithEvents lblPrixActiviteChestIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblPrixActiviteBrasIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblPrixActiviteDosIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblPrixActiviteChestFamilial As System.Windows.Forms.Label
    Friend WithEvents lblPrixActiviteBrasFamilial As System.Windows.Forms.Label
    Friend WithEvents lblPrixActiviteDosFamilial As System.Windows.Forms.Label
    Friend WithEvents lblRabais2ActivitesIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblRabais3ActivitesIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblRabais2ActivitesFamilial As System.Windows.Forms.Label
    Friend WithEvents lblRabais3ActivitesFamilial As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree9MoisIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree12MoisIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree9MoisFamilial As System.Windows.Forms.Label
    Friend WithEvents btnFermer As System.Windows.Forms.Button
End Class
