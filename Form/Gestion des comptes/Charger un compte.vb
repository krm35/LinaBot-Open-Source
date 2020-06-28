Imports System.Text.RegularExpressions

Public Class Charger_un_compte
    ' refonte à faire
#Region "Load"

    Private Sub Charger_un_compte_Load() Handles MyBase.Load

        Try

            'Je supprime tout se qui se trouve dans la listbox
            ListBoxCompte.Items.Clear()

            'J'ouvre et je lis le fichier.
            Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Compte/Accounts.txt")

            Do Until swLecture.EndOfStream

                Dim Ligne As String = swLecture.ReadLine

                If Ligne <> "" Then

                    'Nom de compte : Linaculer | etc....
                    Dim separate() As String = Split(Ligne, " | ")

                    Dim nomDeCompte As String = Split(separate(0), " : ")(1)
                    Dim nomDuPersonnage As String = Split(separate(2), " : ")(1)

                    ListBoxCompte.Items.Add(nomDeCompte & " (" & nomDuPersonnage & ")") 'Nom de compte + Nom du personnage

                End If

            Loop

            'Puis je ferme le fichier.
            swLecture.Close()

        Catch ex As Exception

            ErreurFichier(0, "Unknow", "LoadCompte", ex.Message)

        End Try


    End Sub

#End Region

#Region "Button"

    Private Sub ButtonLoadCompte_Click() Handles ButtonLoadCompte.Click

        Dim frmGroupe As New Groupe
        frmGroupe.Text = TextBoxGroupeNom.Text
        frmGroupe.MdiParent = LinaBot
        frmGroupe.Show()

        'Je lis le fichier pour obtenir les comptes.
        Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Compte/Accounts.txt")

        Do Until swLecture.EndOfStream

            Dim Ligne As String = swLecture.ReadLine

            If Ligne <> "" Then

                Dim separate() As String = Split(Ligne, " | ")

                'Je regarde si l'une des sélections correspond à la ligne actuel.
                If ListBoxCompte.SelectedItems.Contains(Split(separate(0), " : ")(1) & " (" & Split(separate(2), " : ")(1) & ")") Then 'Nom de compte + Nom du personnage

                    'J'ajoute alors aux comptes la class Player.
                    Comptes.Add(New Player)

                    'Puis pour le comptes actuel je met les informations nécessaire.
                    With Comptes(Comptes.Count - 1)

                        For a = 0 To separate.Count - 1

                            Dim separateInfo As String() = Split(separate(a), " : ")

                            Select Case separateInfo(0)

                                Case "Nom de compte"

                                    .NomDeCompte = separateInfo(1)

                                Case "Mot de passe"

                                    .MotDePasse = separateInfo(1)

                                Case "Nom du personnage"

                                    .NomDuPersonnage = separateInfo(1)

                                Case "Serveur"

                                    .Serveur = separateInfo(1)

                                Case "Id Classe"

                                    .Classe = separateInfo(1)

                                Case "Id Sexe"

                                    .Sexe = separateInfo(1)

                                Case "Couleur 1"

                                    .Couleur1 = separateInfo(1)

                                Case "Couleur 2"

                                    .Couleur2 = separateInfo(1)

                                Case "Couleur 3"

                                    .Couleur3 = separateInfo(1)

                            End Select

                        Next

                        .Index = LinaBot.CompteurCompte

                        .FrmGroupe = frmGroupe

                        Initialiser(LinaBot.CompteurCompte, frmGroupe)

                        LinaBot.CompteurCompte += 1

                    End With

                End If

            End If

        Loop

        swLecture.Close()

        Close()

    End Sub

#End Region

#Region "Textbox"

    Private Sub TextBoxGroupeNom_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGroupeNom.Click

        sender.Text = ""

    End Sub

#End Region

End Class