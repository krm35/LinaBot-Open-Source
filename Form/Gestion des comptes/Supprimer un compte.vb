Public Class Supprimer_un_compte

#Region "Load"

    Private Sub Supprimer_un_compte_Load() Handles MyBase.Load

        Try

            'J'ouvre et je lis le fichier.
            Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Compte/Accounts.txt")
            Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

            'Puis je ferme le fichier.
            swLecture.Close()

            'Je supprime tout se qui se trouve dans la listbox
            ListBoxCompte.Items.Clear()

            'Puis je les mets dans la listbox
            For i As Integer = 0 To ligne.Count - 1

                If ligne(i) <> "" Then

                    'Nom de compte : Linaculer | etc....
                    Dim separate() As String = Split(ligne(i), " | ")

                    Dim nomDeCompte As String = Split(separate(0), " : ")(1)
                    Dim nomDuPersonnage As String = Split(separate(2), " : ")(1)

                    ListBoxCompte.Items.Add(nomDeCompte & " (" & nomDuPersonnage & ")") 'Nom de compte + Nom du personnage

                End If

            Next

        Catch ex As Exception

            ErreurFichier(0, "Unknow", "ButtonDeleteCompte", ex.Message)

        End Try

    End Sub

#End Region

#Region "Button"

    Private Sub ButtonDeleteCompte_Click() Handles ButtonDeleteCompte.Click

        Try

            'J'ouvre et je lis le fichier.
            Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Compte/Accounts.txt")
            Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

            'Puis je ferme le fichier.
            swLecture.Close()

            'Puis je réecrit le fichier sans le(s) compte(s) sélectionné(s)
            Dim swEcriture As New IO.StreamWriter(Application.StartupPath + "\Compte/Accounts.txt")

            For i = 0 To ligne.Count - 1

                If ligne(i) <> "" Then

                    Dim separate() As String = Split(ligne(i), " | ")

                    Dim nomDeCompte As String = Split(separate(0), " : ")(1)
                    Dim nomDuPersonnage As String = Split(separate(2), " : ")(1)

                    'Si le compte n'est pas sélectionné, ça indique qu'il ne doit pas être supprimé, donc je le re écrit dans le fichier.
                    If Not ListBoxCompte.SelectedItems.Contains(nomDeCompte & " (" & nomDuPersonnage & ")") Then

                        swEcriture.WriteLine(ligne(i))

                    Else

                        'Vue qu'il est sélectionné, donc il doit être supprimé, je ne le re écrit pas dans le fichier et je supprime aussi le fichier "option" du compte.
                        If IO.File.Exists(Application.StartupPath + "\Compte\Options\" & nomDeCompte & "_" & nomDuPersonnage & ".txt") Then
                            My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\Compte\Options\" & nomDeCompte & "_" & nomDuPersonnage & ".txt")
                        End If

                    End If

                End If

            Next

            swEcriture.Close()

            Supprimer_un_compte_Load()

        Catch ex As Exception

            ErreurFichier(0, "Unknow", "ButtonDeleteCompte", ex.Message)

        End Try

    End Sub

#End Region

End Class