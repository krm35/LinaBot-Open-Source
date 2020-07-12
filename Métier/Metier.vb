Class Metier

    Private Delegate Function DlgF()

    Public Function MetierExist(ByVal index As Integer, ByVal metier As String) As Boolean

        With Comptes(index)

            If .FrmUser.InvokeRequired Then

                Return .FrmUser.Invoke(New DlgF(Function() MetierExist(index, metier)))

            Else

                For Each C As Control In .FrmUser.FlowLayoutPanelMetier.Controls

                    If TypeOf C Is FrmMétier Then

                        Dim cMetier As FrmMétier = DirectCast(C, FrmMétier)

                        If DicoMétier(cMetier.Name).NomMetier.ToLower = metier.ToLower Then

                            Return True

                        End If

                    End If

                Next

                Return False

            End If

        End With

    End Function

    Public Function MetierNiveau(ByVal index As Integer, ByVal metier As String) As String

        With Comptes(index)

            If .FrmUser.InvokeRequired Then

                Return .FrmUser.Invoke(New DlgF(Function() MetierNiveau(index, metier)))

            Else

                For Each C As Control In .FrmUser.FlowLayoutPanelMetier.Controls

                    If TypeOf C Is FrmMétier Then

                        Dim cMetier As FrmMétier = DirectCast(C, FrmMétier)

                        If DicoMétier(cMetier.Name).NomMetier.ToLower = metier.ToLower Then

                            Return Split(cMetier.LabelMétier.Text, " : ")(1)

                        End If

                    End If

                Next

                Return False

            End If

        End With

    End Function

End Class
