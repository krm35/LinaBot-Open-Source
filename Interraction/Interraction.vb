Module Interraction

    ' refonte à faire

    Public Sub InteractionEnJeu(ByVal index As Integer, ByVal interaction As String, ByVal action As String)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewDivers).Rows

                If Pair.Cells(2).Value.ToUpper = interaction.ToUpper Then

                    For Each PairValue As KeyValuePair(Of String, Integer) In DicoDivers(Pair.Cells(0).Value).DicoInterraction

                        If PairValue.Key.ToUpper = action.ToUpper Then

                            EcritureMessage(index, "[Intérraction]", "Le bot interagit avec '" & Pair.Cells(2).Value & "' et effectue l'action : " & action, Color.Orange)

                            SeDeplace(index, Pair.Cells(1).Value)

                            .Socket.Envoyer("GA500" & Pair.Cells(1).Value & ";" & PairValue.Value, True)

                            Return

                        End If

                    Next

                End If

            Next

        End With

    End Sub

    Public Sub InteractionQuitte(ByVal index As Integer)

        With Comptes(index)

            If .EnInteraction Then

                .Socket.Envoyer("EV", True)

            End If

        End With

    End Sub

End Module
