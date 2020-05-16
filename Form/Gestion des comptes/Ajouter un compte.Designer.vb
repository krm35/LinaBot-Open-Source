<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajouter_un_compte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajouter_un_compte))
        Me.TextBoxNomDeCompte = New System.Windows.Forms.TextBox()
        Me.TextBoxMotDePasse = New System.Windows.Forms.TextBox()
        Me.TextBoxNomPersonnage = New System.Windows.Forms.TextBox()
        Me.CheckBoxNomAléatoire = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxChoixServeur = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxChoixSexe = New System.Windows.Forms.ComboBox()
        Me.ComboBoxChoixPersonnage = New System.Windows.Forms.ComboBox()
        Me.ButtonCouleur3 = New System.Windows.Forms.Button()
        Me.ButtonCouleur2 = New System.Windows.Forms.Button()
        Me.ButtonCouleur1 = New System.Windows.Forms.Button()
        Me.ButtonAddCompte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxNomDeCompte
        '
        Me.TextBoxNomDeCompte.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBoxNomDeCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomDeCompte.ForeColor = System.Drawing.Color.White
        Me.TextBoxNomDeCompte.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxNomDeCompte.Multiline = True
        Me.TextBoxNomDeCompte.Name = "TextBoxNomDeCompte"
        Me.TextBoxNomDeCompte.Size = New System.Drawing.Size(259, 30)
        Me.TextBoxNomDeCompte.TabIndex = 2
        Me.TextBoxNomDeCompte.Text = "Nom de compte"
        Me.TextBoxNomDeCompte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMotDePasse
        '
        Me.TextBoxMotDePasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBoxMotDePasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMotDePasse.ForeColor = System.Drawing.Color.White
        Me.TextBoxMotDePasse.Location = New System.Drawing.Point(12, 48)
        Me.TextBoxMotDePasse.Multiline = True
        Me.TextBoxMotDePasse.Name = "TextBoxMotDePasse"
        Me.TextBoxMotDePasse.Size = New System.Drawing.Size(259, 30)
        Me.TextBoxMotDePasse.TabIndex = 3
        Me.TextBoxMotDePasse.Text = "Mot de passe"
        Me.TextBoxMotDePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNomPersonnage
        '
        Me.TextBoxNomPersonnage.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBoxNomPersonnage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomPersonnage.ForeColor = System.Drawing.Color.White
        Me.TextBoxNomPersonnage.Location = New System.Drawing.Point(85, 84)
        Me.TextBoxNomPersonnage.Multiline = True
        Me.TextBoxNomPersonnage.Name = "TextBoxNomPersonnage"
        Me.TextBoxNomPersonnage.Size = New System.Drawing.Size(186, 30)
        Me.TextBoxNomPersonnage.TabIndex = 4
        Me.TextBoxNomPersonnage.Text = "Nom du personnage"
        Me.TextBoxNomPersonnage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBoxNomAléatoire
        '
        Me.CheckBoxNomAléatoire.AutoSize = True
        Me.CheckBoxNomAléatoire.ForeColor = System.Drawing.Color.White
        Me.CheckBoxNomAléatoire.Location = New System.Drawing.Point(12, 90)
        Me.CheckBoxNomAléatoire.Name = "CheckBoxNomAléatoire"
        Me.CheckBoxNomAléatoire.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxNomAléatoire.TabIndex = 17
        Me.CheckBoxNomAléatoire.Text = "Aléatoire"
        Me.CheckBoxNomAléatoire.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Serveur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Sexe"
        '
        'ComboBoxChoixServeur
        '
        Me.ComboBoxChoixServeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxChoixServeur.FormattingEnabled = True
        Me.ComboBoxChoixServeur.Items.AddRange(New Object() {"Algathe", "Arty", "Ayuto", "Bilby", "Clustus", "Droupik", "Eratz", "Henual", "Hogmeiser", "Issering", "Nabur"})
        Me.ComboBoxChoixServeur.Location = New System.Drawing.Point(56, 174)
        Me.ComboBoxChoixServeur.Name = "ComboBoxChoixServeur"
        Me.ComboBoxChoixServeur.Size = New System.Drawing.Size(215, 21)
        Me.ComboBoxChoixServeur.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Classe"
        '
        'ComboBoxChoixSexe
        '
        Me.ComboBoxChoixSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxChoixSexe.FormattingEnabled = True
        Me.ComboBoxChoixSexe.Items.AddRange(New Object() {"Male", "Femelle"})
        Me.ComboBoxChoixSexe.Location = New System.Drawing.Point(56, 147)
        Me.ComboBoxChoixSexe.Name = "ComboBoxChoixSexe"
        Me.ComboBoxChoixSexe.Size = New System.Drawing.Size(215, 21)
        Me.ComboBoxChoixSexe.TabIndex = 19
        '
        'ComboBoxChoixPersonnage
        '
        Me.ComboBoxChoixPersonnage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxChoixPersonnage.FormattingEnabled = True
        Me.ComboBoxChoixPersonnage.Items.AddRange(New Object() {"Feca", "Osamodas", "Enutrof", "Sram", "Xelor", "Ecaflip", "Eniripsa", "Iop", "Cra", "Sadida", "Sacrieur", "Pandawa"})
        Me.ComboBoxChoixPersonnage.Location = New System.Drawing.Point(56, 120)
        Me.ComboBoxChoixPersonnage.Name = "ComboBoxChoixPersonnage"
        Me.ComboBoxChoixPersonnage.Size = New System.Drawing.Size(215, 21)
        Me.ComboBoxChoixPersonnage.TabIndex = 18
        '
        'ButtonCouleur3
        '
        Me.ButtonCouleur3.BackColor = System.Drawing.Color.Black
        Me.ButtonCouleur3.ForeColor = System.Drawing.Color.White
        Me.ButtonCouleur3.Location = New System.Drawing.Point(196, 211)
        Me.ButtonCouleur3.Name = "ButtonCouleur3"
        Me.ButtonCouleur3.Size = New System.Drawing.Size(75, 36)
        Me.ButtonCouleur3.TabIndex = 26
        Me.ButtonCouleur3.Text = "Couleur 3"
        Me.ButtonCouleur3.UseVisualStyleBackColor = False
        '
        'ButtonCouleur2
        '
        Me.ButtonCouleur2.BackColor = System.Drawing.Color.Black
        Me.ButtonCouleur2.ForeColor = System.Drawing.Color.White
        Me.ButtonCouleur2.Location = New System.Drawing.Point(104, 211)
        Me.ButtonCouleur2.Name = "ButtonCouleur2"
        Me.ButtonCouleur2.Size = New System.Drawing.Size(75, 36)
        Me.ButtonCouleur2.TabIndex = 25
        Me.ButtonCouleur2.Text = "Couleur 2"
        Me.ButtonCouleur2.UseVisualStyleBackColor = False
        '
        'ButtonCouleur1
        '
        Me.ButtonCouleur1.BackColor = System.Drawing.Color.Black
        Me.ButtonCouleur1.ForeColor = System.Drawing.Color.White
        Me.ButtonCouleur1.Location = New System.Drawing.Point(12, 211)
        Me.ButtonCouleur1.Name = "ButtonCouleur1"
        Me.ButtonCouleur1.Size = New System.Drawing.Size(75, 36)
        Me.ButtonCouleur1.TabIndex = 24
        Me.ButtonCouleur1.Text = "Couleur 1"
        Me.ButtonCouleur1.UseVisualStyleBackColor = False
        '
        'ButtonAddCompte
        '
        Me.ButtonAddCompte.Location = New System.Drawing.Point(12, 264)
        Me.ButtonAddCompte.Name = "ButtonAddCompte"
        Me.ButtonAddCompte.Size = New System.Drawing.Size(259, 52)
        Me.ButtonAddCompte.TabIndex = 27
        Me.ButtonAddCompte.Text = "Ajouter le(s) compte(s)"
        Me.ButtonAddCompte.UseVisualStyleBackColor = True
        '
        'Ajouter_un_compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(283, 326)
        Me.Controls.Add(Me.ButtonAddCompte)
        Me.Controls.Add(Me.ButtonCouleur3)
        Me.Controls.Add(Me.ButtonCouleur2)
        Me.Controls.Add(Me.ButtonCouleur1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxChoixServeur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxChoixSexe)
        Me.Controls.Add(Me.ComboBoxChoixPersonnage)
        Me.Controls.Add(Me.CheckBoxNomAléatoire)
        Me.Controls.Add(Me.TextBoxNomPersonnage)
        Me.Controls.Add(Me.TextBoxMotDePasse)
        Me.Controls.Add(Me.TextBoxNomDeCompte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Ajouter_un_compte"
        Me.Text = "Ajouter un compte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNomDeCompte As TextBox
    Friend WithEvents TextBoxMotDePasse As TextBox
    Friend WithEvents TextBoxNomPersonnage As TextBox
    Friend WithEvents CheckBoxNomAléatoire As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxChoixServeur As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxChoixSexe As ComboBox
    Friend WithEvents ComboBoxChoixPersonnage As ComboBox
    Friend WithEvents ButtonCouleur3 As Button
    Friend WithEvents ButtonCouleur2 As Button
    Friend WithEvents ButtonCouleur1 As Button
    Friend WithEvents ButtonAddCompte As Button
End Class
