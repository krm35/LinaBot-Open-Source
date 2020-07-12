Public Class VariableFunction

    Public Function EnDialogue(ByVal index As Integer) As String

        With Comptes(index)

            Return .EnDialogue

        End With

    End Function

    Public Function EnBanque(ByVal index As Integer) As String

        With Comptes(index)

            Return .EnBanque

        End With

    End Function

    Public Function PnjEnAchatVente(ByVal index As Integer) As String

        With Comptes(index)

            Return .PnjAcheterVendre

        End With

    End Function
End Class
