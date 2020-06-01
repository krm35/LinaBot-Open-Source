Module Ami

    Public Sub AmiOuvreListe(ByVal index As Integer)

        With Comptes(index)

            .BloqueAmi.Reset()

            .Socket.Envoyer("FL")

            .BloqueAmi.WaitOne(30000)

        End With

    End Sub

    Public Sub AmiSupprime(ByVal index As Integer, ByVal pseudoNom As String)

        With Comptes(index)

            For Each Pair As ListViewItem In CopyListView(index, .FrmUser.ListViewAmi).Items

                If Pair.SubItems(0).Text.ToLower = pseudoNom.ToLower OrElse Pair.SubItems(2).Text.ToLower = pseudoNom.ToLower Then

                    .BloqueAmi.Reset()

                    .Socket.Envoyer("FD*" & Pair.SubItems(0).Text)

                    .BloqueAmi.WaitOne(30000)

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub AmiAjoute(ByVal index As Integer, ByVal nom As String)

        With Comptes(index)

            .BloqueAmi.Reset()

            .Socket.Envoyer("FA" & nom)

            .BloqueAmi.WaitOne(30000)

        End With

    End Sub

    Public Sub EnnemiOuvreListe(ByVal index As Integer)

        With Comptes(index)

            .BloqueAmi.Reset()

            .Socket.Envoyer("iL")

            .BloqueAmi.WaitOne(30000)

        End With

    End Sub

    Public Sub EnnemiAjoute(ByVal index As Integer, ByVal nom As String)

        With Comptes(index)

            .BloqueAmi.Reset()

            .Socket.Envoyer("iA%" & nom)

            .Socket.Envoyer("iL")

            .BloqueAmi.WaitOne(30000)

        End With

    End Sub

    Public Sub EnnemiSupprime(ByVal index As Integer, ByVal pseudoNom As String)

        With Comptes(index)

            For Each Pair As ListViewItem In CopyListView(index, .FrmUser.ListViewAmi).Items

                If Pair.SubItems(0).Text.ToLower = pseudoNom.ToLower OrElse Pair.SubItems(2).Text.ToLower = pseudoNom.ToLower Then

                    .BloqueAmi.Reset()

                    .Socket.Envoyer("iD*" & Pair.SubItems(0).Text)

                    .BloqueAmi.WaitOne(30000)

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub AmiEnnemiInformation(ByVal index As Integer, ByVal pseudoNom As String)

        With Comptes(index)

            For Each Pair As ListViewItem In CopyListView(index, .FrmUser.ListViewAmi).Items

                If Pair.SubItems(0).Text.ToLower = pseudoNom.ToLower OrElse Pair.SubItems(2).Text.ToLower = pseudoNom.ToLower Then

                    .BloqueAmi.Reset()

                    .Socket.Envoyer("BW" & Pair.SubItems(2).Text)

                    .BloqueAmi.WaitOne(30000)

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub AmiEnnemiRejoindre(ByVal index As Integer, ByVal nom As String)

        With Comptes(index)

            .BloqueAmi.Reset()

            .Socket.Envoyer("FJF" & nom)

            .BloqueAmi.WaitOne(30000)

        End With

    End Sub

    Public Sub AmiAvertirConnexion(ByVal index As Integer, ByVal ouiNon As Boolean)

        With Comptes(index)

            Select Case ouiNon

                Case True

                    .Socket.Envoyer("FO+")

                Case False

                    .Socket.Envoyer("FO-")

            End Select

        End With

    End Sub

End Module
