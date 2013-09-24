<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.lblSplashTitre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrSplash
        '
        Me.tmrSplash.Interval = 1
        '
        'lblSplashTitre
        '
        Me.lblSplashTitre.AutoSize = True
        Me.lblSplashTitre.BackColor = System.Drawing.Color.Transparent
        Me.lblSplashTitre.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplashTitre.ForeColor = System.Drawing.Color.White
        Me.lblSplashTitre.Location = New System.Drawing.Point(1, 292)
        Me.lblSplashTitre.Name = "lblSplashTitre"
        Me.lblSplashTitre.Size = New System.Drawing.Size(296, 43)
        Me.lblSplashTitre.TabIndex = 0
        Me.lblSplashTitre.Text = "DentsuBosGym !"
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DentsuBosGym.My.Resources.Resources.ImageTitre
        Me.ClientSize = New System.Drawing.Size(584, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSplashTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrSplash As System.Windows.Forms.Timer
    Friend WithEvents lblSplashTitre As System.Windows.Forms.Label
End Class
