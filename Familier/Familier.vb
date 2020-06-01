Imports System.Runtime.CompilerServices

Module Familier

'Non fini, à refaire + modif, version alpha

    Public Sub FamilierDépose(ByVal index As Integer)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If DicoItems(Pair.Cells(0).Value).Catégorie <> 18 AndAlso
                    Pair.DefaultCellStyle.BackColor <> Color.Lime AndAlso Pair.DefaultCellStyle.BackColor <> Color.Orange Then

                    ItemDepose(index, Pair.Cells(0).Value, Pair.Cells(3).Value, "Nothing")

                    'Je vérifie s'il à atteint la capacité max.
                ElseIf DicoItems(Pair.Cells(0).Value).Catégorie = 18 Then

                    'Si je ne dépose pas le familier, je vais alors retiré X quantité de la ressource pour le nourrir.
                    If FamilierDéposeStats(index, Pair.Cells(0).Value, Pair.Cells(1).Value, Pair.Cells(4).Value) = False Then

                        FamilierRécupèreNourriture(index, Pair.Cells(0).Value, Pair.Cells(4).Value)

                        Task.Delay(1000).Wait()

                    End If

                End If

            Next

            If .EnBanque Then

                .BloqueInterraction.Reset()

                .Socket.Envoyer("EV", True)

                .BloqueInterraction.WaitOne(15000)

                Task.Delay(1000).Wait()

                FamilierGestion(index)

                Task.Delay(1000).Wait()

                If .MonEquipement.Familier(0) <> "" Then

                    .BloqueItem.Reset()

                    .Socket.Envoyer("OM" & .MonEquipement.Familier(1) & "|-1")

                    .BloqueItem.WaitOne(15000)

                    Task.Delay(1000).Wait()

                End If

            End If

        End With

    End Sub

    Public Sub FamilierRécupèreNourriture(ByVal index As Integer, ByVal idFamilier As Integer, ByVal caractéristique As String)

        With Comptes(index)

            Dim repasPrendre As Integer = Split(caractéristique, "Repas : ")(1).Split(vbCrLf)(0)

            repasPrendre = Math.Abs(repasPrendre)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewLui).Rows

                If DicoFamilier(idFamilier)(.FrmGroupe.FamilierList(idFamilier)).Nourriture.Contains(Pair.Cells(0).Value) Then

                    Dim quantité As Integer = repasPrendre

                    If quantité = 0 Then quantité = 2

                    If CInt(Pair.Cells(3).Value) < quantité Then

                        quantité = Pair.Cells(3).Value

                    End If

                    repasPrendre -= quantité

                    .BloqueItem.Reset()

                    .Socket.Envoyer("EMO-" & Pair.Cells(1).Value & "|" & Math.Abs(quantité), True)

                    .BloqueItem.WaitOne(15000)

                    If repasPrendre = 0 Then Return

                End If

            Next

            If repasPrendre > 0 Then

                EcritureMessage(index, "(Bot)", "Il manque des ressource pour nourrir complétement le familier : " & DicoItems(idFamilier).NomItem, Color.Red)

            End If

        End With

    End Sub

    Public Sub FamilierGestion(ByVal index As Integer)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                'S'il s'agit d'un familier
                If DicoItems(Pair.Cells(0).Value).Catégorie = 18 Then

                    'Je vérifie d'abord s'il est obése
                    Dim corpulence As String = Split(Pair.Cells(4).Value, "Corpulence : ")(1).Split(vbCrLf)(0)

                    Dim repas As Integer = Split(Pair.Cells(4).Value, "Repas : ")(1).Split(vbCrLf)(0)

                    Dim statsactuelle As Integer = FamilierReturnStats(index, Pair.Cells(1).Value)

                    Dim dateFamilier As Date = Split(Pair.Cells(4).Value, "Date : ")(1).Split(vbCrLf)(0)

                    Dim dateNourrir As Date = dateFamilier.AddHours(DicoFamilier(Pair.Cells(0).Value).Values(0).IntervaleRepasMin)

                    If dateFamilier > dateNourrir Then

                        Select Case corpulence.ToLower

                            Case "maigrichon"

                                FamilierEquipe(index, Pair.Cells(1).Value)

                                FamilierNourrit(index, Pair.Cells(0).Value, Pair.Cells(1).Value, repas, corpulence, statsactuelle)

                            Case "normal"

                                FamilierEquipe(index, Pair.Cells(1).Value)

                                FamilierNourrit(index, Pair.Cells(0).Value, Pair.Cells(1).Value, 1, corpulence, statsactuelle)

                            Case "obese"

                                EcritureMessage(index, "(Bot)", "Le familier est obése, il ne sera pas nourrit", Color.Gold)

                        End Select

                    End If

                End If

            Next

        End With

    End Sub

    Private Sub FamilierEquipe(ByVal index As Integer, ByVal idUnique As Integer)

        With Comptes(index)

            If .MonEquipement.Familier(0) <> "" Then

                .BloqueItem.Reset()

                .Socket.Envoyer("OM" & .MonEquipement.Familier(1) & "|-1", True)

                .BloqueItem.WaitOne(15000)

                Task.Delay(1000).Wait()

            End If

            .BloqueItem.Reset()

            .Socket.Envoyer("OM" & idUnique & "|8", True)

            .BloqueItem.WaitOne(15000)

        End With

    End Sub

    Private Sub FamilierNourrit(ByVal index As Integer, ByVal idFamilier As Integer, ByVal idUniqueFamilier As Integer, ByVal nbrRepas As Integer, ByVal corpulence As String, ByVal statsActuelle As Integer)

        With Comptes(index)

            nbrRepas = Math.Abs(nbrRepas)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If DicoFamilier(idFamilier)(.FrmGroupe.FamilierList(idFamilier)).Nourriture.Contains(Pair.Cells(0).Value) Then

                    For i = 0 To CInt(Pair.Cells(3).Value) - 1

                        If nbrRepas <= 0 Then Return

                        .BloqueItem.Reset()

                        .Socket.Envoyer("OM" & Pair.Cells(1).Value & "|8")

                        .BloqueItem.WaitOne(15000)

                        nbrRepas -= 1

                        Task.Delay(1000).Wait()

                        If corpulence.ToLower = "normal" AndAlso statsActuelle <> FamilierReturnStats(index, idUniqueFamilier) Then

                            .BloqueItem.Reset()

                            .Socket.Envoyer("OM" & Pair.Cells(1).Value & "|8", True)

                            .BloqueItem.WaitOne(15000)

                            Task.Delay(1000).Wait()

                            Return

                        End If

                    Next

                End If

            Next

        End With

    End Sub

    Public Function FamilierReconnexion(ByVal index As Integer) As Integer

        With Comptes(index)

            Dim Reconnexion As Integer = 262800000 ' 73 heures
            Dim meilleurDate As Date = Date.Now

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If DicoItems(Pair.Cells(0).Value).Catégorie = 18 Then

                    Dim dateFamilier As Date = Split(Pair.Cells(4).Value, "Date : ")(1).Split(vbCrLf)(0)

                    Dim maDate As Date = dateFamilier.AddHours(DicoFamilier(Pair.Cells(0).Value).Values(0).IntervaleRepasMin)

                    If dateFamilier < maDate Then

                        Dim résultat As Integer = Math.Abs(DateDiff(DateInterval.Second, maDate, CDate(dateFamilier)) * 1000)

                        If résultat < Reconnexion Then

                            Reconnexion = résultat

                            meilleurDate = dateFamilier

                        End If

                    End If

                End If

            Next

            If Reconnexion < 1000 Then

                Reconnexion = 60000

            Else

                Reconnexion += 60000

            End If

            EcritureMessage(index, "[Reconnexion]", "Reconnexion > " & DateAdd("s", Reconnexion \ 1000, meilleurDate), Color.Green)
            Task.Delay(Reconnexion).Wait()

        End With

    End Function

End Module
