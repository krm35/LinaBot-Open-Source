Module Tchat

    'Code pouvant être amélioré, il s'agit d'un test d'objet en canal.

    Public Sub TchatCanal(ByVal index As Integer, ByVal canal As String, ByVal message As String, ByVal joueur As String, ByVal item As String)

        With Comptes(index)

            Dim messageEnvoye As String = "BM"

            Select Case canal.ToLower

                Case "commun"

                    messageEnvoye &= "*|"

                Case "message privee", "message privée"

                    messageEnvoye &= joueur & "|"

                Case "groupe"

                    messageEnvoye &= "$|"

                Case "equipe"

                    messageEnvoye &= "#|"

                Case "guilde"

                    messageEnvoye &= "%|"

                Case "alignement"

                    messageEnvoye &= "!|"

                Case "recrutement"

                    messageEnvoye &= "?|"

                Case "commerce"

                    messageEnvoye &= ":|"

            End Select

            If item <> "" Then

                Dim compteur As Integer = 0
                Dim ajouteMot As Boolean = True
                Dim separateMessage As String() = Split(message, " ")

                For i = 0 To separateMessage.Count - 1

                    If separateMessage(i).Contains("[") Then

                        messageEnvoye &= "°" & compteur & " "
                        compteur += 1
                        ajouteMot = False

                    ElseIf separateMessage(i).Contains("]") Then

                        ajouteMot = True

                    Else

                        If ajouteMot AndAlso separateMessage(i) <> Nothing Then messageEnvoye &= separateMessage(i) & " "

                    End If

                Next

            Else

                messageEnvoye &= message

            End If

            If Mid(messageEnvoye, messageEnvoye.Length, 1) = " " Then

                messageEnvoye = Mid(messageEnvoye, 1, messageEnvoye.Length - 1)

            End If

            .Socket.Envoyer(messageEnvoye & "|" & item, True)

        End With

    End Sub

End Module
