<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supprimer_un_compte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supprimer_un_compte))
        Me.ListBoxCompte = New System.Windows.Forms.ListBox()
        Me.ButtonDeleteCompte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxCompte
        '
        Me.ListBoxCompte.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ListBoxCompte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBoxCompte.ForeColor = System.Drawing.Color.White
        Me.ListBoxCompte.FormattingEnabled = True
        Me.ListBoxCompte.HorizontalScrollbar = True
        Me.ListBoxCompte.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxCompte.Name = "ListBoxCompte"
        Me.ListBoxCompte.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxCompte.Size = New System.Drawing.Size(273, 236)
        Me.ListBoxCompte.TabIndex = 3
        '
        'ButtonDeleteCompte
        '
        Me.ButtonDeleteCompte.Location = New System.Drawing.Point(12, 263)
        Me.ButtonDeleteCompte.Name = "ButtonDeleteCompte"
        Me.ButtonDeleteCompte.Size = New System.Drawing.Size(273, 45)
        Me.ButtonDeleteCompte.TabIndex = 4
        Me.ButtonDeleteCompte.Text = "Supprimer le(s) compte(s)"
        Me.ButtonDeleteCompte.UseVisualStyleBackColor = True
        '
        'Supprimer_un_compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 320)
        Me.Controls.Add(Me.ButtonDeleteCompte)
        Me.Controls.Add(Me.ListBoxCompte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Supprimer_un_compte"
        Me.Text = "Supprimer un compte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxCompte As ListBox
    Friend WithEvents ButtonDeleteCompte As Button
End Class
