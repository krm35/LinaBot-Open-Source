<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Groupe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Groupe))
        Me.TabControlGroupe = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'TabControlGroupe
        '
        Me.TabControlGroupe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlGroupe.Location = New System.Drawing.Point(12, 12)
        Me.TabControlGroupe.Name = "TabControlGroupe"
        Me.TabControlGroupe.SelectedIndex = 0
        Me.TabControlGroupe.Size = New System.Drawing.Size(1250, 686)
        Me.TabControlGroupe.TabIndex = 0
        '
        'Groupe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1274, 710)
        Me.Controls.Add(Me.TabControlGroupe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Groupe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Groupe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlGroupe As TabControl
End Class
