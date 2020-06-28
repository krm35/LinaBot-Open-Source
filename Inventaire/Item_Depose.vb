Class Item_Depose

    ' refonte à faire

    Public Sub ItemDepose(ByVal index As Integer, ByVal item As String, Optional ByVal quantité As String = "999999", Optional ByVal caractéristique As String = "NOTHING")

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If Pair.Cells(0).Value.ToString = item OrElse Pair.Cells(2).Value.ToUpper = item.ToUpper OrElse item.ToUpper = "ALL" Then

                    If Pair.DefaultCellStyle.BackColor <> Color.Lime AndAlso Pair.DefaultCellStyle.BackColor <> Color.Orange Then

                        If caractéristique.ToUpper = "NOTHING" OrElse ComparateurCaractéristiqueObjets(Pair.Cells(4).Value, caractéristique) Then

                            If quantité > CInt(Pair.Cells(3).Value) Then quantité = Pair.Cells(3).Value

                            EcritureMessage(index, "(Bot)", "Dépose l'item " & Pair.Cells(2).Value & " x " & quantité, Color.Gray)

                            .BloqueItem.Reset()

                            .Socket.Envoyer("EMO+" & Pair.Cells(1).Value & "|" & quantité, True)

                            .BloqueItem.WaitOne(15000)

                            If .EnCraft AndAlso .EnForgemagie AndAlso DicoItems(Pair.Cells(0).Value).Catégorie <> "78" Then ForgemagieMajCaractéristique(index, Pair.Cells(4).Value)

                            If item.ToUpper = "ALL" Then quantité = "999999"

                        End If

                    End If

                End If

            Next

        End With

    End Sub

End Class
