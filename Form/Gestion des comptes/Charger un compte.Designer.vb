<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charger_un_compte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Charger_un_compte))
        Me.ListBoxCompte = New System.Windows.Forms.ListBox()
        Me.ButtonLoadCompte = New System.Windows.Forms.Button()
        Me.TextBoxGroupeNom = New System.Windows.Forms.TextBox()
        Me.LabelNomGroupe = New System.Windows.Forms.Label()
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
        Me.ListBoxCompte.Size = New System.Drawing.Size(274, 236)
        Me.ListBoxCompte.TabIndex = 4
        '
        'ButtonLoadCompte
        '
        Me.ButtonLoadCompte.Location = New System.Drawing.Point(15, 298)
        Me.ButtonLoadCompte.Name = "ButtonLoadCompte"
        Me.ButtonLoadCompte.Size = New System.Drawing.Size(274, 50)
        Me.ButtonLoadCompte.TabIndex = 5
        Me.ButtonLoadCompte.Text = "Charger le(s) compte(s)"
        Me.ButtonLoadCompte.UseVisualStyleBackColor = True
        '
        'TextBoxGroupeNom
        '
        Me.TextBoxGroupeNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TextBoxGroupeNom.ForeColor = System.Drawing.Color.White
        Me.TextBoxGroupeNom.Location = New System.Drawing.Point(98, 263)
        Me.TextBoxGroupeNom.Name = "TextBoxGroupeNom"
        Me.TextBoxGroupeNom.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxGroupeNom.TabIndex = 6
        Me.TextBoxGroupeNom.Text = "Groupe"
        Me.TextBoxGroupeNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelNomGroupe
        '
        Me.LabelNomGroupe.AutoSize = True
        Me.LabelNomGroupe.ForeColor = System.Drawing.Color.White
        Me.LabelNomGroupe.Location = New System.Drawing.Point(12, 266)
        Me.LabelNomGroupe.Name = "LabelNomGroupe"
        Me.LabelNomGroupe.Size = New System.Drawing.Size(80, 13)
        Me.LabelNomGroupe.TabIndex = 7
        Me.LabelNomGroupe.Text = "Nom du groupe"
        '
        'Charger_un_compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(298, 358)
        Me.Controls.Add(Me.LabelNomGroupe)
        Me.Controls.Add(Me.TextBoxGroupeNom)
        Me.Controls.Add(Me.ButtonLoadCompte)
        Me.Controls.Add(Me.ListBoxCompte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Charger_un_compte"
        Me.Text = "Charger un compte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxCompte As ListBox
    Friend WithEvents ButtonLoadCompte As Button
    Friend WithEvents TextBoxGroupeNom As TextBox
    Friend WithEvents LabelNomGroupe As Label
End Class
