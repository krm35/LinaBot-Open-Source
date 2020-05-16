Module Item_Quantité

    Public Sub GaItemModifieQuantiteInventaire(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' OQ 55259212  | 699
            ' OQ Id Unique | Quantité

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewInventaire.Rows

                If Pair.Cells(1).Value = separateData(0) Then

                    Pair.Cells(3).Value = separateData(1)

                    Return

                End If

            Next

        End With

    End Sub

End Module
