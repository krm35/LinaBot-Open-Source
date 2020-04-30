﻿Imports System.Net.Sockets, System.Text, System.Net
Imports System.Threading

Public Class Socket_EventArgs

    Inherits EventArgs

    Public ReadOnly Property Message() As String   ' Message = Seulement en lecture
    Public ReadOnly Property LaSocket() As Socket  ' Socket = seulement en lecture

    Public Sub New(ByVal LaSocket As Socket)
        MyClass.New("", LaSocket)
    End Sub
    Public Sub New(ByVal Message As String)
        MyClass.New(Message, Nothing)
    End Sub
    Public Sub New(ByVal Message As String, ByVal LaSocket As Socket)
        Me.Message = Message
        Me.LaSocket = LaSocket
    End Sub
End Class


Public Class All_CallBack
    Implements IDisposable

    Public Delegate Sub D_All_CallBack(ByVal Sender As Object, ByVal Message As Socket_EventArgs)

    ' Evenement des différentes actions de la classe
    Public Event Connexion(ByVal Sender As Object, ByVal Message As Socket_EventArgs)
    Public Event Deconnexion(ByVal Sender As Object, ByVal Message As Socket_EventArgs)
    Public Event Reception(ByVal Sender As Object, ByVal Message As Socket_EventArgs)
    Public Event Envoie(ByVal Sender As Object, ByVal Message As Socket_EventArgs)

    Public ReadOnly Property LaSocket() As Socket
    Public Property Hote() As String
    Public Property Port() As Integer
    Private _Buffer(65536) As Byte

    Dim Bloqueur As ManualResetEventSlim = New ManualResetEventSlim(False)


    Public ReadOnly Property Connecter() As Boolean
        Get
            Return LaSocket.Connected
        End Get
    End Property

    Public Async Function Envoyer(ByVal message As String) As Task

        Try

            Bloqueur.Reset()

            If Await Task.Run(Function() EnvoieMessage(message)) = False Then

                RaiseEvent Deconnexion(Me, New Socket_EventArgs("Bot non connecté !", LaSocket))
                Bloqueur.Set()

            End If

        Catch ex As Exception

            RaiseEvent Deconnexion(Me, New Socket_EventArgs(ex.Message, Nothing))
            Bloqueur.Set()

        End Try

    End Function

    Public Function EnvoieMessage(ByVal Message As String) As Boolean

        Message = Message & Chr(10) & Chr(0)

        Try
            If (LaSocket.Connected) Then
                Dim ByteBuffer As Byte() = Encoding.UTF8.GetBytes(Message)
                LaSocket.BeginSend(ByteBuffer, 0, ByteBuffer.Length, SocketFlags.None, AddressOf CallBackSender, LaSocket)
                RaiseEvent Envoie(Me, New Socket_EventArgs(Message, LaSocket))
                Return Bloqueur.Wait(15000) = False
            Else
                RaiseEvent Deconnexion(Me, New Socket_EventArgs("Bot non connecté !", LaSocket))
                Bloqueur.Set()
            End If
        Catch ex As Exception

            RaiseEvent Deconnexion(Me, New Socket_EventArgs(ex.Message, Nothing))
            Bloqueur.Set()

        End Try
    End Function


    ''' <summary>
    ''' Se connecte / Se deconnecte
    ''' </summary>
    ''' <param name="Active">Active ou desactive la socket</param>
    ''' <remarks>METHODE A REVOIR</remarks>
    Public Sub Connexion_Game(ByVal Active As Boolean)

        If (Active) Then
            LaSocket.BeginConnect(New IPEndPoint(IPAddress.Parse(Hote), Port), New AsyncCallback(AddressOf CallBackConnect), LaSocket)
        Else
            Try
                LaSocket.Shutdown(SocketShutdown.Both)
                CallBackDisconnect(LaSocket)

            Catch

                RaiseEvent Deconnexion(Me, New Socket_EventArgs("Déconnexion", LaSocket))
            End Try
        End If

    End Sub

#Region "Callbacks"

    ''' <summary>
    ''' Callback de connexion vers le serveur
    ''' </summary>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Private Sub CallBackConnect(ByVal async As IAsyncResult)

        Dim LaSocket As Socket = CType(async.AsyncState, Socket)

        Try
            LaSocket.EndConnect(async)
        Catch ex As Exception

            RaiseEvent Deconnexion(Me, New Socket_EventArgs("Erreur de connexion au serveur"))
        End Try

        RaiseEvent Connexion(Me, New Socket_EventArgs("Connexion d'un client", LaSocket))

        Try  ' Active la reception des messages
            LaSocket.BeginReceive(_Buffer, 0, _Buffer.Length, SocketFlags.None, New AsyncCallback(AddressOf CallBackReceive), LaSocket)
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error : Socket.vb --> Connect()")
        End Try

    End Sub 'Provient de Maxoubot, non modifié

    ''' <summary>
    ''' Callback declenché à la deconnexion
    ''' </summary>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Private Sub CallBackDisconnect(ByVal async As IAsyncResult)

        Dim LaSocket As Socket = CType(async.AsyncState, Socket)

        LaSocket.EndDisconnect(async)

        RaiseEvent Deconnexion(Me, New Socket_EventArgs("Deconnexion", LaSocket))

    End Sub 'Provient de Maxoubot, non modifié


    Dim sb As New StringBuilder()
    Private Sub CallBackReceive(ByVal async As IAsyncResult)

        Dim Client As Socket = CType(async.AsyncState, Socket)
        Dim bytesRead As Integer = Client.EndReceive(async)

        If bytesRead > 0 Then
            Bloqueur.Set()
            For i = 0 To bytesRead - 1
                If (_Buffer(i) = 0) Then
                    RaiseEvent Reception(Me, New Socket_EventArgs(sb.ToString(), LaSocket))
                    sb.Clear()
                Else
                    sb.Append(ChrW(_Buffer(i)))
                End If
            Next
            Try
                Client.BeginReceive(_Buffer, 0, _Buffer.Length, 0, New AsyncCallback(AddressOf CallBackReceive), Client)
            Catch ex As Exception
            End Try

        End If
    End Sub



    ''' <summary>
    ''' Callback d'envoi des données
    ''' </summary>
    ''' <param name="async"></param>
    ''' <remarks></remarks>
    Private Sub CallBackSender(ByVal async As IAsyncResult)

        Try

            Dim LaSocket As Socket = CType(async.AsyncState, Socket)
            Dim bytesSent As Integer = LaSocket.EndSend(async)

        Catch e As Exception

            RaiseEvent Deconnexion(Me, New Socket_EventArgs(e.Message))
        End Try
    End Sub

#End Region

#Region "Constructeurs"

    ''' <summary>
    ''' Constructeur par defaut
    ''' </summary>
    ''' <param name="Hote"></param>
    ''' <param name="Port"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Hote As String, ByVal Port As Integer)
        LaSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP)
        Try
            LaSocket.BeginConnect(New IPEndPoint(IPAddress.Parse(Hote), Port), New AsyncCallback(AddressOf CallBackConnect), LaSocket)
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RaiseEvent Deconnexion(Me, New Socket_EventArgs(ex.Message))
        End Try
    End Sub

#End Region


    ' Pour détecter les appels redondants
    Private disposedValue As Boolean = False

    ''' <summary>
    ''' IDisposable
    ''' </summary>
    ''' <param name="disposing"></param>
    ''' <remarks></remarks>
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)

        If (Not Me.disposedValue) Then

        End If

        ' Destruction de la socket d'ecoute
        If Me.LaSocket.Connected Then Me.LaSocket.Shutdown(SocketShutdown.Both)
        Me.LaSocket.Close()

        Me.disposedValue = True

        Bloqueur.Set()

    End Sub

    ' Ce code a été ajouté par Visual Basic pour permettre l'implémentation correcte du modèle pouvant être supprimé.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Ne modifiez pas ce code. Ajoutez du code de nettoyage dans Dispose(ByVal disposing As Boolean) ci-dessus.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

End Class
