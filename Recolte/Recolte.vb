Imports System.Net.Sockets

Module Recolte

    'Code non fini, pouvant être amélioré, test en cours sur les récoltes + agro

    Public Sub RecolteRessource(ByVal index As Integer, ByVal laRecolte As String, ByVal action As String)

        With Comptes(index)

            While .EnRecolte = False

                If .Pods >= .FrmGroupe.PodsGroupe Then Return

                Dim cellule As Integer = RecolteCherche(index, laRecolte)

                If cellule > 0 Then

                    .InteractionCellId = cellule

                    .Send = "GA500" & cellule & ";" & ReturnAction(laRecolte, action)

                    SeDeplace(index, cellule)

                    Task.Delay(2000).Wait()

                    While .EnRecolte

                        Task.Delay(1000).Wait()

                    End While

                    Task.Delay(1000).Wait()

                    While .EnCombat

                        Task.Delay(1000).Wait()

                    End While

                Else

                    Exit While

                End If

            End While

        End With

    End Sub

    Private Function RecolteCherche(ByVal index As Integer, ByVal nomRecolte As String) As Integer

        With Comptes(index)

            Dim distance As Integer = 999
            Dim cellRecolte As Integer = 0

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewDivers).Rows

                If Pair.Cells(1).Value <> .CaseActuelle Then

                    'Exemple : Faucher = Faucher ET l'ID correspond à celle voulu par l'utilisateur
                    If nomRecolte.ToUpper = Pair.Cells(2).Value.ToString.ToUpper Then

                        If Pair.Cells(3).Value = "Disponible" Then

                            Dim distanceMoiCell As Integer = goalDistance(.CaseActuelle, Pair.Cells(1).Value, index)

                            If distanceMoiCell < distance AndAlso distanceMoiCell > 0 Then

                                'Je vérifie qu'aucun mobs ne bloque pour la récolte
                                If RecolteMonstre(index, Pair.Cells(1).Value) Then

                                    distance = distanceMoiCell

                                    cellRecolte = Pair.Cells(1).Value

                                End If

                            End If

                        End If

                    End If

                End If

            Next

            Return cellRecolte

        End With

    End Function

    Private Function RecolteMonstre(ByVal index As Integer, ByVal cell As String) As Boolean

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                If Pair.Cells(0).Value = cell Then

                    EcritureMessage(index, "[Récolte]", "Un ou des mobs gangbang la ressource en '" & cell & "', elle ne peut être récolté.", Color.Red)

                    Return False

                End If

            Next

            Return True

        End With

    End Function

    Private Function ReturnAction(ByVal nomRecolte As String, ByVal action As String) As Integer

        For Each Pair As KeyValuePair(Of Integer, sInterraction) In DicoDivers

            If Pair.Value.Nom.ToString.ToUpper = nomRecolte.ToUpper Then

                Return Pair.Value.DicoInterraction(action)

            End If

        Next

        Return 0

    End Function

End Module
