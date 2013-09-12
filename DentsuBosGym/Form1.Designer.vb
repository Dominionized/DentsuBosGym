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
        Me.picCoin = New System.Windows.Forms.PictureBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTestCommit = New System.Windows.Forms.Label()
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCoin
        '
        Me.picCoin.Image = Global.DentsuBosGym.My.Resources.Resources.ImageCoin
        Me.picCoin.Location = New System.Drawing.Point(211, 12)
        Me.picCoin.Name = "picCoin"
        Me.picCoin.Size = New System.Drawing.Size(88, 88)
        Me.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picCoin.TabIndex = 0
        Me.picCoin.TabStop = False
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(13, 13)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(191, 29)
        Me.lblTitre.TabIndex = 1
        Me.lblTitre.Text = "DentsuBosGym"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTestCommit
        '
        Me.lblTestCommit.AutoSize = True
        Me.lblTestCommit.Location = New System.Drawing.Point(92, 297)
        Me.lblTestCommit.Name = "lblTestCommit"
        Me.lblTestCommit.Size = New System.Drawing.Size(176, 13)
        Me.lblTestCommit.TabIndex = 3
        Me.lblTestCommit.Text = "Ceci est un label pour le commit test"
        '
        'frmInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 408)
        Me.Controls.Add(Me.lblTestCommit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.picCoin)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTestCommit As System.Windows.Forms.Label

End Class
