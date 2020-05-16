Module Trajet_Information

    'VERSION DE TEST trajet

    Public Sub TrajetLoad(ByVal index As Integer, ByVal path As String)

        With Comptes(index)

            'J'ouvre et je lis le fichier.
            Dim swLecture As New IO.StreamReader(path)
            Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)
            Dim balise As String = ""

            'Puis je ferme le fichier.
            swLecture.Close()

            For i = 0 To ligne.Count - 1

                If ligne(i).StartsWith("</") Then

                    balise = ""

                ElseIf ligne(i).StartsWith("<") Then

                    balise = ligne(i).Replace("<", "").Replace(">", "")

                Else

                    If ligne(i) <> "" Then

                        Select Case balise.ToLower


                            Case "forgemagie"

                                .ForgemagieListe.Add(ligne(i))

                            Case "forgemagie jet base"

                                .ForgemagieListeJetBase.Add(ligne(i))

                            Case "forgemagie exotique"

                                .ForgemagieExo.Add(ligne(i))

                            Case Else

                                If Not .DicoTrajet.ContainsKey(balise) Then

                                    .DicoTrajet.Add(balise, New List(Of String) From {ligne(i)})

                                Else

                                    .DicoTrajet(balise).Add(ligne(i))

                                End If

                        End Select

                    End If

                End If

            Next

            .FrmGroupe.ThreadTrajet = New Threading.Thread(Sub() MyTrajet(index)) With {.IsBackground = True}
            .FrmGroupe.ThreadTrajet.Start()

        End With

    End Sub

    Private Sub MyTrajet(ByVal index As Integer)

        With Comptes(index)

            While True

                TrajetEnCours(index, .FrmGroupe.DicoTrajet.Keys(0))

            End While

        End With

    End Sub

    Public Sub TrajetEnCours(ByVal index As Integer, ByVal balise As String, Optional ByVal banque As Integer = 0)

        With Comptes(index)

            For Each Pair As String In .FrmGroupe.DicoTrajet(balise)

                Dim separate As String() = Split(Pair, " | ")

                For a = 0 To separate.Count - 1

                    Dim separateAction As String() = Split(separate(a), " = ")

                    Select Case separateAction(0).ToLower ' Exemple : "Map"

                        Case "mapid" ' Map = 7515 

                            If .MapID <> CInt(separateAction(1)) Then Exit For

                        Case "move" ' Move = Direction ou Cellule

                            SeDeplace(index, separateAction(1))

                        Case "interaction" ' interaction

                            InteractionEnJeu(index, separateAction(1), separateAction(2))

                        Case "itemdepose"

                            ItemDepose(index, separateAction(1), separateAction(2), separateAction(3))

                        Case "pnjparler"

                            PnjParler(index, separateAction(1))

                        Case "pnjreponse"

                            PnjReponse(index, separateAction(1))

                        Case "recolte"

                            RecolteRessource(index, separateAction(1), separateAction(2))

                        Case "condition"

                            Select Case separateAction(1).ToLower

                                Case "equipement"

                                    Dim separateEquipement As String() = Split(separateAction(3), " > ")

                                    Select Case separateAction(2).ToLower

                                        Case "equiper"

                                            If EquipementEquiper(index, separateEquipement(0), separateEquipement(1)) <> CBool(separateAction(4)) Then

                                                Exit For

                                            End If

                                        Case "desequiper"


                                    End Select

                                Case "metier"

                                    If MétierExiste(index, separateAction(2)) <> CBool(separateAction(3)) Then

                                        Exit For

                                    End If

                            End Select

                    End Select

                    Task.Delay(10).Wait()

                Next

            Next

        End With

    End Sub


End Module
