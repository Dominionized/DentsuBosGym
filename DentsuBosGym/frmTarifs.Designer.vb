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
        Me.lblTarifIndividuel = New System.Windows.Forms.Label()
        Me.lblTarifFamilial = New System.Windows.Forms.Label()
        Me.tblTarifs.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitreTarifs
        '
        Me.lblTitreTarifs.AutoSize = True
        Me.lblTitreTarifs.Location = New System.Drawing.Point(3, 0)
        Me.lblTitreTarifs.Name = "lblTitreTarifs"
        Me.lblTitreTarifs.Size = New System.Drawing.Size(33, 13)
        Me.lblTitreTarifs.TabIndex = 0
        Me.lblTitreTarifs.Text = "Tarifs"
        '
        'tblTarifs
        '
        Me.tblTarifs.ColumnCount = 3
        Me.tblTarifs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblTarifs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblTarifs.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblTarifs.Controls.Add(Me.lblTarifFamilial, 2, 0)
        Me.tblTarifs.Controls.Add(Me.lblTitreTarifs, 0, 0)
        Me.tblTarifs.Controls.Add(Me.lblTarifIndividuel, 1, 0)
        Me.tblTarifs.Location = New System.Drawing.Point(12, 12)
        Me.tblTarifs.Name = "tblTarifs"
        Me.tblTarifs.RowCount = 3
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.407665!))
        Me.tblTarifs.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.27526!))
        Me.tblTarifs.Size = New System.Drawing.Size(310, 287)
        Me.tblTarifs.TabIndex = 1
        '
        'lblTarifIndividuel
        '
        Me.lblTarifIndividuel.AutoSize = True
        Me.lblTarifIndividuel.Location = New System.Drawing.Point(106, 0)
        Me.lblTarifIndividuel.Name = "lblTarifIndividuel"
        Me.lblTarifIndividuel.Size = New System.Drawing.Size(52, 13)
        Me.lblTarifIndividuel.TabIndex = 1
        Me.lblTarifIndividuel.Text = "Individuel"
        '
        'lblTarifFamilial
        '
        Me.lblTarifFamilial.AutoSize = True
        Me.lblTarifFamilial.Location = New System.Drawing.Point(209, 0)
        Me.lblTarifFamilial.Name = "lblTarifFamilial"
        Me.lblTarifFamilial.Size = New System.Drawing.Size(41, 13)
        Me.lblTarifFamilial.TabIndex = 2
        Me.lblTarifFamilial.Text = "Familial"
        '
        'frmTarifs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
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
End Class
