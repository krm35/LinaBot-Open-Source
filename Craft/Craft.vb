Module Craft
    ' refonte à faire / en cours de dév
    Public Sub CraftAtelier(ByVal index As Integer, ByVal choix As String)

        With Comptes(index)

            Select Case choix.ToLower

                Case "craft"

                Case "forgemagie"

            End Select

        End With

    End Sub

    Public Function CraftDeposeItemVoulu(ByVal index As Integer, ByVal idNameObjet As String, ByVal quantité As String, ByVal caracteristique As String) As Boolean

        With Comptes(index)

            Dim newitemdepose As New Item_Depose
            newitemdepose.ItemDepose(index, idNameObjet, quantité, caracteristique)

            'Je vérifie que l'item se trouve bien dans la datagridview
            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMoi).Rows

                If Pair.Cells(0).Value = idNameObjet OrElse Pair.Cells(2).Value.ToString.ToLower = idNameObjet.ToLower Then

                    Return True

                End If

            Next

            Return False

        End With

    End Function

End Module
