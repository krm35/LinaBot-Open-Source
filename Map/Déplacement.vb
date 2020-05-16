Module Déplacement

    'Modification à faire.

    Public Sub SeDeplace(ByVal index As Integer, ByVal direction As String)

        With Comptes(index)

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

                    End If

                End If

            End If

        End With

    End Sub

End Module
