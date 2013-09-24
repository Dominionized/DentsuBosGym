<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacture
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
        Me.txtFacture = New System.Windows.Forms.TextBox()
        Me.btnFermerFacture = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFacture
        '
        Me.txtFacture.Location = New System.Drawing.Point(13, 13)
        Me.txtFacture.Multiline = True
        Me.txtFacture.Name = "txtFacture"
        Me.txtFacture.ReadOnly = True
        Me.txtFacture.Size = New System.Drawing.Size(259, 207)
        Me.txtFacture.TabIndex = 0
        '
        'btnFermerFacture
        '
        Me.btnFermerFacture.Location = New System.Drawing.Point(197, 226)
        Me.btnFermerFacture.Name = "btnFermerFacture"
        Me.btnFermerFacture.Size = New System.Drawing.Size(75, 23)
        Me.btnFermerFacture.TabIndex = 1
        Me.btnFermerFacture.Text = "Fermer"
        Me.btnFermerFacture.UseVisualStyleBackColor = True
        '
        'frmFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFermerFacture)
        Me.Controls.Add(Me.txtFacture)
        Me.Name = "frmFacture"
        Me.Text = "frmFacture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFacture As System.Windows.Forms.TextBox
    Friend WithEvents btnFermerFacture As System.Windows.Forms.Button
End Class
