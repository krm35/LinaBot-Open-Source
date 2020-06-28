Public Class DiversFunction

    Public Function PauseSeconde(ByVal index As Integer, ByVal temps As Integer)

        With Comptes(index)

            Task.Delay(temps * 1000).Wait()

            Return True

        End With

    End Function

    Public Function PauseMinute(ByVal index As Integer, ByVal temps As Integer)

        With Comptes(index)

            Task.Delay(temps * 60000).Wait()

            Return True

        End With

    End Function

    Public Function PauseHeure(ByVal index As Integer, ByVal temps As Integer)

        With Comptes(index)

            Task.Delay(temps * 3600000).Wait()

            Return True

        End With

    End Function
End Class
