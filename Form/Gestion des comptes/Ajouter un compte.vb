Public Class Ajouter_un_compte
    ' refonte à faire
#Region "Couleur"

    Private Sub ButtonCouleur1_Click(sender As Object, e As EventArgs) Handles ButtonCouleur1.Click, ButtonCouleur2.Click, ButtonCouleur3.Click

        Dim MyDialog As New ColorDialog()

        MyDialog.ShowDialog()

        sender.BackColor = MyDialog.Color ' Donne la couleur

        sender.Name = Math.Abs(MyDialog.Color.ToArgb) 'Donne la couleur en chiffre.

    End Sub

#End Region

#Region "Nom du personnage Aléatoire"

    Private Sub CheckBoxNomAléatoire_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNomAléatoire.CheckedChanged

        Select Case CheckBoxNomAléatoire.Checked

            Case True

                TextBoxNomPersonnage.Text = "Aléatoire"

            Case False

                TextBoxNomPersonnage.Text = "Nom du personnage"

        End Select

    End Sub

#End Region

#Region "TextBox"

    Private Sub TextBox_Nom_De_Compte_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNomDeCompte.Click, TextBoxMotDePasse.Click, TextBoxNomPersonnage.Click

        sender.Text = ""

    End Sub

#End Region

#Region "Button"

    Private Sub ButtonAddCompte_Click() Handles ButtonAddCompte.Click

        Try

            'Je lis le fichier.
            Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Compte/Accounts.txt")

            Dim ligneFinal As String = ""

            Do Until swLecture.EndOfStream

                Dim Ligne As String = swLecture.ReadLine

                If Ligne <> "" Then

                    ligneFinal &= Ligne & vbCrLf

                End If

            Loop

            'Puis je ferme le fichier.
            swLecture.Close()

            Dim monCompte As String

            monCompte = "Nom de compte : " & TextBoxNomDeCompte.Text & " | "
            monCompte &= "Mot de passe : " & TextBoxMotDePasse.Text & " | "
            monCompte &= "Nom du personnage : " & TextBoxNomPersonnage.Text & " | "
            monCompte &= "Serveur : " & ComboBoxChoixServeur.Text & " | "
            monCompte &= "Id Classe : " & ComboBoxChoixPersonnage.SelectedIndex & " | "
            monCompte &= "Id Sexe : " & ComboBoxChoixSexe.SelectedIndex & " | "
            monCompte &= "Couleur 1 : " & If(IsNumeric(ButtonCouleur1.Name), ButtonCouleur1.Name, "-1") & " | "
            monCompte &= "Couleur 2 : " & If(IsNumeric(ButtonCouleur2.Name), ButtonCouleur1.Name, "-1") & " | "
            monCompte &= "Couleur 3 : " & If(IsNumeric(ButtonCouleur3.Name), ButtonCouleur1.Name, "-1")

            ligneFinal &= monCompte

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim swEcriture As New IO.StreamWriter(Application.StartupPath + "\Compte/Accounts.txt")

            swEcriture.Write(ligneFinal)

            'Puis je le ferme.
            swEcriture.Close()

            CréationOption(TextBoxNomDeCompte.Text, TextBoxNomPersonnage.Text)

            'Je mets les informations de base pour que se soit visible directement par l'utilisateur.
            TextBoxNomDeCompte.Text = "Nom de compte"
            TextBoxMotDePasse.Text = "Mot de passe"
            TextBoxNomPersonnage.Text = "Nom du personnage"

        Catch ex As Exception

            ErreurFichier(0, "Unknow", "ButtonAddCompte", ex.Message)

        End Try

    End Sub

    Private Sub CréationOption(ByVal nomDeCompte As String, ByVal nomDuPersonnage As String)

        Dim myOption As String = ""

        'J'ouvre le fichier pour y écrire se que je souhaite
        Dim swEcriture As New IO.StreamWriter(Application.StartupPath + "\Compte\Options/" & nomDeCompte & "_" & nomDuPersonnage & ".txt")

        swEcriture.WriteLine(myOption)

        swEcriture.Close()

    End Sub

#End Region

#Region "Load"

    Private Sub Ajouter_un_compte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxChoixServeur.Items.Clear()

        For Each pair As KeyValuePair(Of String, sServeur) In DicoServeur

            ComboBoxChoixServeur.Items.Add(pair.Key)

        Next

        ComboBoxChoixPersonnage.SelectedIndex = 0
        ComboBoxChoixServeur.SelectedIndex = 0
        ComboBoxChoixSexe.SelectedIndex = 0

    End Sub

#End Region

End Class