Public Class Caractéristique

    Public Function Pods(ByVal index As Integer, ByVal choix As String) As String

        With Comptes(index)

            Return .Pods

        End With

    End Function

    Public Function maproàgresbbar(ByVal index As Integer, ByVal choix As String) As String

        With Comptes(index)

            Return ReturnProgressBar(index, .FrmUser.ProgressBarPods, choix)

        End With

    End Function

End Class
