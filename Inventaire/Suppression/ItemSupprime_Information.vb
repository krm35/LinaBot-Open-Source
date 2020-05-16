Module ItemSupprime_Information

    Public Sub GaItemSupprimeInventaire(ByVal index As Integer, ByVal data As String)

        With Comptes(index).FrmUser.DataGridViewInventaire

            ' OR 55156977
            ' OR id Unique

            data = Mid(data, 3)

            For Each Pair As DataGridViewRow In .Rows

                If Pair.Cells(1).Value = data Then

                    .Rows.RemoveAt(Pair.Index)

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub GaItemsSupprimeMoi(ByVal index As Integer, ByVal data As String, ByVal dgv As DataGridView)

        With Comptes(index)

            ' EMKO- 40420233
            ' EMKO- Id Unique

            data = Mid(data, 6)

            For Each Pair As DataGridViewRow In dgv.Rows

                If Pair.Cells(1).Value = data Then

                    dgv.Rows.RemoveAt(Pair.Index)

                    Return

                End If

            Next

        End With

    End Sub

End Module
