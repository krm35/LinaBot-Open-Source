Module Déplacement

    Public Sub SeDeplace(ByVal index As Integer, ByVal direction As String, Optional ByVal send As String = "")

        With Comptes(index)

            If .EnDeplacement Then

                .StopDeplacement = True

                While .EnDeplacement

                    Task.Delay(1000).Wait()

                End While

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

                        .BloqueDeplacement.Reset()

                        .Socket.Envoyer("GA001" & path, True)

                        .BloqueDeplacement.WaitOne(30000)

                    End If

                End If

            End If

        End With

    End Sub

End Module
