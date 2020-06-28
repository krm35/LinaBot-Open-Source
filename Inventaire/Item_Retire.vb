Module Item_Retire

    Public Sub ItemRetire(ByVal index As Integer, ByVal item As String, ByVal quantité As Integer, ByVal caractéristique As String)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMoi).Rows

                If Pair.Cells(0).Value = item OrElse Pair.Cells(2).Value.ToUpper = item.ToUpper OrElse item.ToUpper = "ALL" Then

                    If Pair.DefaultCellStyle.BackColor <> Color.Lime AndAlso Pair.DefaultCellStyle.BackColor <> Color.Orange Then

                        If caractéristique.ToUpper = "NOTHING" OrElse ComparateurCaractéristiqueObjets(Pair.Cells(4).Value, caractéristique) Then

                            If quantité > CInt(Pair.Cells(3).Value) Then quantité = Pair.Cells(3).Value

                            EcritureMessage(index, "(Bot)", "Retire l'item " & Pair.Cells(2).Value & " x " & quantité, Color.Gray)

                            .BloqueItem.Reset()

                            .Socket.Envoyer("EMO-" & Pair.Cells(1).Value & "|" & quantité, True)

                            .BloqueItem.WaitOne(15000)

                        End If

                    End If

                End If

            Next

        End With

    End Sub

End Module
