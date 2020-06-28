Class Metier

    Public Function MetierExist(ByVal index As Integer, ByVal metier As String) As Boolean

        With Comptes(index)

            For Each C As Control In .FrmUser.FlowLayoutPanelMetier.Controls

                If TypeOf C Is FrmMétier Then

                    Dim cMetier As FrmMétier = DirectCast(C, FrmMétier)

                    If DicoMétier(cMetier.Name).NomMetier.ToLower = metier.ToLower Then

                        Return True

                    End If

                End If

            Next

            Return False

        End With

    End Function

End Class
