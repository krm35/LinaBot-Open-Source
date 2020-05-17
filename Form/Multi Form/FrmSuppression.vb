Public Class FrmSuppression

    Public Index As Integer
    Public Item As String

    Private Sub ButtonSuppression_Click(sender As Object, e As EventArgs) Handles ButtonSuppression.Click

        Comptes(Index).Socket.Envoyer(Item & TextBox1.Text)

        Close()

    End Sub

End Class