Module Déplacement

    Public Sub SeDeplace(ByVal index As Integer, ByVal direction As String, Optional ByVal send As String = "")

        With Comptes(index)

            If .EnDeplacement Then

                .StopDeplacement = True

                Task.Delay(1000).Wait()

                .StopDeplacement = False

            End If

            Select Case direction.ToLower

                Case "haut"

                    direction = .DirectionHaut

                Case "bas"

                    direction = .DirectionBas

                Case "gauche"

                    direction = .DirectionGauche

                Case "droite"

                    direction = .DirectionDroite

            End Select

            If CInt(direction) > 0 Then

                If .EnDeplacement = False Then

                    Dim pather As New Pathfinding
                    Dim path As String = pather.pathing(index, direction)

                    If path <> "" Then

                        .Socket.Envoyer("GA001" & path, True)

                        If send <> "" Then

                            .Socket.Envoyer(send)

                        End If

                        If .PathTotal.Length > 3 Then

                            For i = 0 To .PathTotal.Length Step 3

                                If .StopDeplacement Then

                                    .Socket.Envoyer("GKE0|" & ReturnLastCell(Mid(.PathTotal, i + 2, 2)))

                                    .StopDeplacement = False

                                    Return

                                Else

                                    If .PathTotal.Length < 9 Then

                                        Task.Delay(180 * 3).Wait()

                                    Else

                                        Task.Delay(80 * 3).Wait()

                                    End If

                                End If

                            Next

                        End If

                        .Socket.Envoyer("GKK0")

                        .EnDeplacement = False

                    End If

                End If

            End If

        End With

    End Sub

End Module
