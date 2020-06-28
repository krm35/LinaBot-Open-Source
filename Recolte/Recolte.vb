
Class Recolte

    'Code non fini, pouvant être amélioré, test en cours sur les récoltes + agro

    Public Function RecolteRessource(ByVal index As Integer, ByVal idNomRecolte As String)

        With Comptes(index)

            Dim separateRecolte As String() = Split(idNomRecolte, "|")
            Dim lesRecoltes As New List(Of String)

            For i = 0 To separateRecolte.Count - 1
                lesRecoltes.Add(separateRecolte(i).ToLower)
            Next

            While .EnRecolte = False

                If .Pods >= .FrmGroupe.PodsGroupe Then Return False

                Dim cellule As Integer = RecolteCherche(index, lesRecoltes)

                If cellule > 0 Then

                    .InteractionCellId = cellule

                    .Send = "GA500" & cellule & ";" & ReturnAction(lesRecoltes, .MonEquipement.Arme(2))

                    Dim move As New FunctionMap

                    move.SeDeplace(index, cellule)

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

            Return True

        End With

    End Function

    Private Function RecolteCherche(ByVal index As Integer, ByVal nomRecolte As List(Of String)) As Integer

        With Comptes(index)

            Dim distance As Integer = 999
            Dim cellRecolte As Integer = 0

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewDivers).Rows

                If Pair.Cells(1).Value <> .CaseActuelle Then

                    'Exemple : Faucher = Faucher ET l'ID correspond à celle voulu par l'utilisateur
                    If nomRecolte.Contains(Pair.Cells(2).Value.ToString.ToLower) Then

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

    Private Function ReturnAction(ByVal nomRecolte As List(Of String), ByVal arme As String) As Integer

        For Each Pair As KeyValuePair(Of Integer, sInterraction) In DicoDivers

            If nomRecolte.Contains(Pair.Value.Nom.ToString.ToLower) Then

                If arme = 22 Then

                    Return Pair.Value.DicoInterraction("Faucher")

                ElseIf arme = 20 Then

                    Return Pair.Value.DicoInterraction("Cueillir")

                Else

                    Return Pair.Value.DicoInterraction.Item(0)

                End If

            End If

        Next

        Return 0

    End Function

End Class
