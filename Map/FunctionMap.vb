Public Class FunctionMap
    Public Function Map(ByVal index As String, ByVal laMap As String) As String

        With Comptes(index)

            If IsNumeric(laMap) Then

                If .MapID = laMap Then

                    Return True

                End If

            Else
                Dim eug = .MapPosition
                If laMap = .MapPosition Then

                    Return True

                End If

            End If

            Return False

        End With

    End Function

    Public Function SeDeplace(ByVal index As Integer, ByVal direction As String) As String

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

                        Return .BloqueDeplacement.WaitOne(30000)

                    End If

                End If

            End If

            Return False

        End With

    End Function

End Class
