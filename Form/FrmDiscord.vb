Imports System.Windows.Interop

Public Class FrmDiscord

    Private Sub FrmDiscord_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        My.Settings.Token = TextBox_TokenDiscord.Text
        My.Settings.Save()

    End Sub

    Private Sub FrmDiscord_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class