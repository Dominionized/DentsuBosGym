﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.picCoin = New System.Windows.Forms.PictureBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(85, 12)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(181, 27)
        Me.lblTitre.TabIndex = 1
        Me.lblTitre.Text = "DentsuBosGym"
        '
        'frmInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.picCoin)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInscription"
        Me.Text = "DentsuBosGym - Inscription"
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCoin As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitre As System.Windows.Forms.Label

End Class
