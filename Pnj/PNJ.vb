Module PNJ

    'Code à améliorer.

#Region "Action"

    Public Sub PnjParler(ByVal index As Integer, ByVal idNamePnj As String)

        With Comptes(index)

            If .EnDialogue = False Then

                For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                    If Pair.DefaultCellStyle.BackColor = Color.Pink Then

                        If RenvoieInformation(Pair.Cells(3).Value, "Id Race") = idNamePnj OrElse Pair.Cells(2).Value.ToUpper = idNamePnj.ToUpper Then

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

#End Region

End Module
