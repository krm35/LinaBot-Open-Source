Module Recolte_Information

    'Code pouvant être amélioré, modifié, ajouté.

    Public Sub GARecolteEnCours(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            Try

                ' GA0 ; 501     ; 0123456   ; 35         , 18800
                ' GA0 ; Récolte ; ID Joueur ; Cellule ID , Temps en milliseconde

                Dim separateData As String() = Split(data, ";")

                Dim idPlayer As Integer = separateData(2) ' 0123456

                Dim send As String = Mid(separateData(0), 3) ' GA0

                separateData = Split(separateData(3), ",") ' 35,18800

                If idPlayer = .IdUnique Then

                    .EnRecolte = True

                    .InteractionCellId = separateData(0)
                    .RecolteNumero += 1

                    EcritureMessage(index, "[Récolte]", "Temps de récolte : " & If(separateData(1).Length = 4, Mid(separateData(1), 1, 1), Mid(separateData(1), 1, 2)) & " Seconde(s)", Color.Green)
                    EcritureMessage(index, "[Récolte]", "Récolte n° " & .RecolteNumero, Color.Green)

                    RecoltePause(index, separateData(1), "GKK" & send)

                End If

            Catch ex As Exception

                ErreurFichier(index, .NomDuPersonnage, "GARecolteEnCours", ex.Message)

            End Try

        End With

    End Sub

    Private Async Sub RecoltePause(ByVal index As Integer, ByVal pause As Integer, ByVal envoie As String)

        With Comptes(index)

            Try

                Await Task.Delay(pause)

                .Socket.Envoyer(envoie)

            Catch ex As Exception

            End Try

        End With

    End Sub

    Public Sub HarvestDrop(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'IQ 1234567   | 2
            'IQ ID Joueur | Quantité

            data = Mid(data, 3)

            Dim separate As String() = Split(data, "|")

            If separate(0) = .IdUnique Then



            End If

        End With

    End Sub

End Module
