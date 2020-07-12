Imports System.Windows.Interop
Imports Discord
Imports Discord.WebSocket

Public Class LinaBot

    Dim WithEvents DiscordBot As New DiscordSocketClient

    Public CompteurCompte As Integer

#Region "Panel"

    Private Sub DiscordBotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscordBotToolStripMenuItem.Click
        FrmDiscord.Show()
    End Sub

    Private Sub PanelAddCompte_Click(sender As Object, e As EventArgs) Handles PanelAddCompte.Click
        Ajouter_un_compte.Show()
    End Sub

    Private Sub PanelLoadCompte_Click(sender As Object, e As EventArgs) Handles PanelLoadCompte.Click
        Charger_un_compte.Show()
    End Sub

    Private Sub PanelDeleteCompte_Click(sender As Object, e As EventArgs) Handles PanelDeleteCompte.Click
        Supprimer_un_compte.Show()
    End Sub

#End Region

#Region "Load"

    Private Sub LinaBot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadScript()

        LoadServeur()

        LoadPersonnage()

        LoadItems()

        LoadSort()

        LoadMaps()

        LoadDivers()

        LoadMobs()

        LoadPNJ()

        LoadMaison()

        LoadPNJReponse()

        LoadMetier()

        LoadFamilier()

        DiscordBot = New DiscordSocketClient
        startup()
    End Sub



#End Region

#Region "Discord"

    Public Async Sub startup()

        ''this is the function that login the bot and start it
        If DiscordBot.LoginState() = 2 Then
            Await DiscordBot.LogoutAsync()
        End If



        DiscordBot = New DiscordSocketClient()


        Try
            ' Label3.ForeColor = Color.Red
            '  Label3.Text = "Status: login in"
            Try
                Await DiscordBot.LoginAsync(tokenType:=Discord.TokenType.Bot, My.Settings.Token)
            Catch ex As Exception
                Dim ErrorValue = DirectCast(ex, Discord.Net.HttpException).HttpCode
                If ErrorValue = 401 Then
                    '  Label3.ForeColor = Color.Red
                    '  Label3.Text = "Status: Invalid Token"
                    Return
                End If

            End Try

            '  Label3.ForeColor = Color.Orange
            '  Label3.Text = "Status: starting bot"
            Await DiscordBot.StartAsync()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Function onMsg(msg As SocketMessage) As Task Handles DiscordBot.MessageReceived

        Dim monchannel As String = msg.Channel.Name

        '  sendMsg("tghqdfhqdfh")

    End Function

    Public Sub sendMsg(ByVal monmessage As String)

        Try
            Dim channel1 As Discord.IMessageChannel = DiscordBot.GetChannel("")
            channel1.SendMessageAsync(monmessage)

        Catch ex As Exception
            '  MsgBox("you must select a channel ID in the box")
        End Try
    End Sub
#End Region

End Class
