Imports System.Web.UI

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

            .FrmGroupe.DicoTrajet.Clear()
            .FrmGroupe.ReturnBanque = False
            .FrmGroupe.PodsGroupe = 80
            .FrmGroupe.GrpSupprime.Clear()
            .FrmGroupe.FamilierList.Clear()

            For i = 0 To ligne.Count - 1

                If ligne(i).StartsWith("</") Then

                    balise = ""

                ElseIf ligne(i).StartsWith("<") Then

                    balise = ligne(i).Replace("<", "").Replace(">", "").ToLower

                Else

                    If ligne(i) <> "" Then

                        Select Case balise


                            Case "forgemagie"

                                .ForgemagieListe.Add(ligne(i))

                            Case "forgemagie jet base"

                                .ForgemagieListeJetBase.Add(ligne(i))

                            Case "forgemagie exotique"

                                .ForgemagieExo.Add(ligne(i))

                            Case "suppression"

                                Dim newSupprime As New Groupe.sSupprime

                                Dim separate As String() = Split(ligne(i), " = ")

                                With newSupprime

                                    .IdNom = separate(0) ' Id on nom
                                    .Quantité = separate(1) ' Max ou X
                                    .Caractéristique = separate(2) ' Vitalité : 0 a 15 , Sagesse : 5 a 41  ou Nothing

                                End With

                                .FrmGroupe.GrpSupprime.Add(newSupprime)

                            Case "familier"

                                Dim separate As String() = Split(ligne(i), " = ")

                                .FrmGroupe.FamilierList.Add(separate(0), separate(1))

                            Case Else

                                If Not .FrmGroupe.DicoTrajet.ContainsKey(balise) Then

                                    .FrmGroupe.DicoTrajet.Add(balise, New List(Of String) From {ligne(i)})

                                Else

                                    .FrmGroupe.DicoTrajet(balise).Add(ligne(i))

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

                If .FrmGroupe.ReturnBanque Then

                    Suppression(index)

                    ' Si mes bots sont toujours au dessus de la limite après la suppression.
                    If .FrmGroupe.ReturnBanque Then

                        TrajetEnCours(index, "banque", 1)

                    End If

                Else

                    TrajetEnCours(index, .FrmGroupe.DicoTrajet.Keys(0))

                End If

            End While

        End With

    End Sub

    Public Sub TrajetEnCours(ByVal index As Integer, ByVal balise As String, Optional ByVal Banque As Integer = 0)

        With Comptes(index)

            For Each Pair As String In .FrmGroupe.DicoTrajet(balise)

                Dim separate As String() = Split(Pair, " | ")

                For a = 0 To separate.Count - 1

                    'Vérification des pods.
                    If Banque = 0 AndAlso .FrmGroupe.ReturnBanque Then Return

                    Dim separateAction As String() = Split(separate(a), " = ")

                    Select Case separateAction(0).ToLower ' Exemple : "Map"

                        Case "map"

                            If separateAction(1) <> returnmap(index) Then Exit For

                        Case "mapid" ' Map = 7515 

                            If .MapID <> CInt(separateAction(1)) Then Exit For

                        Case "direction", "cellule" ' Move = Direction ou Cellule

                            SeDeplace(index, separateAction(1))

                        Case "interaction" ' interaction

                            InteractionEnJeu(index, separateAction(1), separateAction(2))

                        Case "itemdepose"

                            ItemDepose(index, separateAction(1), separateAction(2), separateAction(3))

                        Case "pnjparler"

                            PnjParler(index, separateAction(1))

                            Task.Delay(1000).Wait()

                        Case "pnjreponse"

                            PnjReponse(index, separateAction(1))

                            Task.Delay(1000).Wait()

                        Case "pnjquittedialogue"

                            PnjQuitteDialogue(index)

                        Case "equipe"

                            Dim separateEquipement As String() = Split(separateAction(1), " > ")

                            ItemEquipe(index, separateEquipement(0), separateEquipement(1))

                        Case "recolte"

                            RecolteRessource(index, separateAction(1), separateAction(2))

                        Case "balise"

                            TrajetEnCours(index, separateAction(1).ToLower)

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

                        Case "familier" 'Familier = Nourrir = 

                            Select Case separateAction(1).ToLower

                                Case "nourrir"

                                    FamilierDépose(index)

                                Case "reconnexion"

                                    Dim tempsReconnexion As Integer = FamilierReconnexion(index)

                                    Task.Run(Sub() Reconnexion(index, tempsReconnexion))

                                    If .FrmGroupe.ThreadTrajet IsNot Nothing AndAlso .FrmGroupe.ThreadTrajet.IsAlive Then .FrmGroupe.ThreadTrajet.Abort()

                            End Select

                    End Select

                    Task.Delay(10).Wait()

                Next

            Next

        End With

    End Sub

    Private Delegate Function dlgf()
    Private Function returnmap(ByVal index As Integer)

        With Comptes(index)

            If .FrmUser.InvokeRequired Then

                Return .FrmUser.Invoke(New dlgf(Function() returnmap(index)))

            Else

                Return .FrmUser.LabelMap.Text

            End If

        End With

    End Function

    Private Sub Reconnexion(ByVal index As Integer, ByVal tempsReconnexion As Integer)

        With Comptes(index)

            If .Connecté Then

                .Socket.Connexion_Game(False)

            End If

            Task.Delay(tempsReconnexion).Wait()

            .Socket.Connexion_Game(True)

            Task.Delay(30000).Wait()

            .FrmGroupe.ThreadTrajet = New Threading.Thread(Sub() MyTrajet(index)) With {.IsBackground = True}
            .FrmGroupe.ThreadTrajet.Start()

        End With

    End Sub

End Module
