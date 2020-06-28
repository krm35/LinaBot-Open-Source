Public Class Banque

    Public Sub BanqueQuitte(ByVal index As Integer)

        With Comptes(index)

            If .EnBanque Then

                .BloqueInterraction.Reset()

                .Socket.Envoyer("EV")

                .BloqueInterraction.WaitOne(15000)

            End If

        End With

    End Sub

End Class
