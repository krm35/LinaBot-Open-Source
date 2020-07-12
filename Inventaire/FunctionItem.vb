Public Class FunctionItem

    Public Function ItemExist(ByVal index As Integer, ByVal choix As String, ByVal idNom As String, Optional ByVal caracteristique As String = "nothing") As String

        With Comptes(index)

            Dim dgv As New DataGridView

            Select Case choix.ToLower

                Case "inventaire"

                    dgv = CopyDatagridView(index, .FrmUser.DataGridViewInventaire)

                Case "lui"

                    dgv = CopyDatagridView(index, .FrmUser.DataGridViewLui)

                Case "moi", "banque"

                    dgv = CopyDatagridView(index, .FrmUser.DataGridViewMoi)

            End Select

            For Each Pair As DataGridViewRow In dgv.Rows

                If Pair.Cells(0).Value.ToString = idNom OrElse Pair.Cells(2).Value.ToUpper = idNom.ToUpper Then

                    If caracteristique.ToLower = "nothing" OrElse ComparateurCaractéristiqueObjets(Pair.Cells(4).Value, caracteristique) Then

                        Return True

                    End If

                End If

            Next

            Return False

        End With

    End Function

End Class
