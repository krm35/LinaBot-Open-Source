Module Trajet_Lina

    Public Sub TrajetLoad(ByVal index As Integer, ByVal chemin As String)

        With Comptes(index)

            .FrmGroupe.DicoTrajet.Clear()
            .FrmGroupe.VarStringTrajet.Clear()
            .FrmGroupe.VarListeTrajet.Clear()

            Dim swLecture As IO.StreamReader = New IO.StreamReader(chemin, System.Text.Encoding.Default)

            Dim Balise As String = ""

            Do Until swLecture.EndOfStream

                Dim ligneActuel As String = swLecture.ReadLine

                While ligneActuel.Contains("  ")
                    ligneActuel = ligneActuel.Replace("  ", " ")
                End While

                While ligneActuel.StartsWith(" ")
                    ligneActuel = Mid(ligneActuel, 2, ligneActuel.Length)
                End While

                Dim separateLecture As String() = Split(ligneActuel, " ")

                Select Case separateLecture(0)

                    Case "Dim" 'Indique une Variable

                        loadVariable(index, ligneActuel)

                    Case "Sub"

                        Balise = separateLecture(1)

                    Case "Function"

                        Balise = separateLecture(1)

                    Case "End Sub", "End Function"

                        Balise = ""

                    Case Else

                        If Balise <> "" Then

                            If Not .FrmGroupe.DicoTrajet.ContainsKey(Balise) Then

                                .FrmGroupe.DicoTrajet.Add(Balise, New List(Of String) From {ligneActuel})

                            Else

                                .FrmGroupe.DicoTrajet(Balise).Add(ligneActuel)

                            End If

                        End If

                End Select

            Loop

            swLecture.Close()

            TrajetLecture(index, "Main()")

        End With

    End Sub

    Private Sub loadVariable(ByVal index As Integer, ByVal ligne As String)

        With Comptes(index)

            'Exemple : Dim maVar As String = "Salut, ça va ?"
            'Exemple : Dim maVar As List = "Salut, ça va ?"
            Dim separate As String() = Split(ligne, " ")

            Select Case separate(3)

                Case "String"

                    .FrmGroupe.VarStringTrajet.Add(separate(1), Split(ligne, " = ")(1))

                Case "String()"

                    'Je fais ma liste
                    Dim nomVar As String = separate(1)

                    separate = Split(ligne.Replace("""", ""), "{")
                    separate = Split(separate(1), "}")
                    separate = Split(separate(0), ", ")

                    .FrmGroupe.VarListeTrajet.Add(nomVar, separate)

            End Select

        End With

    End Sub



End Module
