﻿Module Item_Depose

    ' refonte à faire

    Public Sub ItemDepose(ByVal index As Integer, ByVal item As String, ByVal quantité As Integer, ByVal caractéristique As String)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If Pair.Cells(0).Value = item OrElse Pair.Cells(2).Value.ToUpper = item.ToUpper OrElse item.ToUpper = "ALL" Then

                    If Pair.DefaultCellStyle.BackColor <> Color.Lime AndAlso Pair.DefaultCellStyle.BackColor <> Color.Orange Then

                        If caractéristique.ToUpper = "NOTHING" OrElse ComparateurCaractéristiqueObjets(Pair.Cells(4).Value, caractéristique) Then

                            If quantité > CInt(Pair.Cells(3).Value) Then quantité = Pair.Cells(3).Value

                            EcritureMessage(index, "(Bot)", "Dépose l'item " & Pair.Cells(2).Value & " x " & quantité, Color.Gray)

                            .Socket.Envoyer("EMO+" & Pair.Cells(1).Value & "|" & quantité, True)

                            If .EnCraft AndAlso .EnForgemagie AndAlso DicoItems(Pair.Cells(0).Value).Catégorie <> "78" Then ForgemagieMajCaractéristique(index, Pair.Cells(4).Value)

                        End If

                    End If

                End If

            Next

        End With

    End Sub

End Module
