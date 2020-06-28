Class PNJ

    'Code à améliorer.

#Region "Action"

    Public Function PnjExist(ByVal index As Integer, ByVal idNamePnj As String) As String

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                If Pair.DefaultCellStyle.BackColor = Color.Pink Then

                    If ReturnSearch(Pair.Cells(3).Value, "Id Race") = idNamePnj OrElse Pair.Cells(2).Value.ToUpper = idNamePnj.ToUpper Then

                        Return True

                    End If

                End If

            Next

            Return False

        End With

    End Function

    Public Sub PnjParler(ByVal index As Integer, ByVal idNamePnj As String)

        With Comptes(index)

            If .EnDialogue = False Then

                For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                    If Pair.DefaultCellStyle.BackColor = Color.Pink Then

                        If ReturnSearch(Pair.Cells(3).Value, "Id Race") = idNamePnj OrElse Pair.Cells(2).Value.ToUpper = idNamePnj.ToUpper Then

                            .BloqueDialogue.Reset()

                            .Socket.Envoyer("DC" & Pair.Cells(1).Value, True)

                            .BloqueDialogue.WaitOne(30000)

                            Return

                        End If

                    End If

                Next

            End If

        End With

    End Sub

    Public Sub PnjReponse(ByVal index As Integer, ByVal reponse As String)

        With Comptes(index)

            If .EnDialogue Then

                If .ListePnjReponseDisponible.Count > 0 Then

                    For i = 0 To .ListePnjReponseDisponible.Count - 1

                        If reponse.ToUpper = DicoPnjReponse(.ListePnjReponseDisponible(i)).ToUpper OrElse reponse = .ListePnjReponseDisponible(i).ToString Then

                            EcritureMessage(index, "(Bot)", "Réponse : " & DicoPnjReponse(.ListePnjReponseDisponible(i)), Color.Orange)

                            .BloqueDialogue.Reset()

                            .Socket.Envoyer("DR" & .DialogueReponse & "|" & .ListePnjReponseDisponible(i), True)

                            .BloqueDialogue.WaitOne(30000)

                            Return

                        End If

                    Next

                Else

                    PnjQuitteDialogue(index)

                End If

            End If

        End With

    End Sub

    Public Sub PnjQuitteDialogue(ByVal index As Integer)

        With Comptes(index)

            If .EnDialogue Then

                .BloqueDialogue.Reset()

                .Socket.Envoyer("DV", True)

                .BloqueDialogue.WaitOne(30000)

            End If

        End With

    End Sub

    Public Sub PnjAcheterVendre(ByVal index As Integer, ByVal idNamePnj As String)

        With Comptes(index)

            With Comptes(index)

                If .PnjAcheterVendre = False Then

                    For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                        If Pair.DefaultCellStyle.BackColor = Color.Pink Then

                            If ReturnSearch(Pair.Cells(3).Value, "Id Race") = idNamePnj OrElse Pair.Cells(2).Value.ToUpper = idNamePnj.ToUpper Then

                                .BloqueDialogue.Reset()

                                .Socket.Envoyer("ER0|" & Pair.Cells(1).Value, True)

                                .BloqueDialogue.WaitOne(30000)

                                Return

                            End If

                        End If

                    Next

                End If

            End With

        End With

    End Sub

    Public Sub PnjAcheterVendreItem(ByVal index As Integer, ByVal item As String, ByVal quantité As Integer, ByVal caractéristique As String)

        With Comptes(index)

            If .PnjAcheterVendre Then

                For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewLui).Rows

                    If Pair.Cells(0).Value = item OrElse Pair.Cells(2).Value.ToString.ToLower = item.ToLower Then

                        If caractéristique.ToLower = "nothing" OrElse ComparateurCaractéristiqueObjets(Pair.Cells(4).Value, caractéristique) Then

                            .BloqueDialogue.Reset()

                            .Socket.Envoyer("EB" & Pair.Cells(0).Value & "|" & quantité)

                            .BloqueDialogue.WaitOne(15000)

                        End If

                    End If

                Next

            End If

        End With

    End Sub

    Public Sub PnjAcheterVendreQuitte(ByVal index As Integer)

        With Comptes(index)

            If .PnjAcheterVendre Then

                .BloqueDialogue.Reset()

                .Socket.Envoyer("EV")

                .BloqueDialogue.WaitOne(15000)

            End If

        End With

    End Sub

#End Region

End Class
