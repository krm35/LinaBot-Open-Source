Module Equipement

    ' refonte à faire

    Public Sub ItemEquipe(ByVal index As Integer, ByVal item As String, Optional ByVal caractéristique As String = "")

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If Pair.Cells(0).Value.ToString = item OrElse Pair.Cells(2).Value.ToString.ToUpper = item.ToUpper Then

                    If caractéristique = Nothing OrElse ComparateurCaractéristiqueObjets(caractéristique, Pair.Cells(4).Value) Then

                        If Pair.DefaultCellStyle.BackColor <> Color.Lime AndAlso Pair.DefaultCellStyle.BackColor <> Color.Orange Then

                            If EquipementEquipe(index, DicoItems(Pair.Cells(0).Value).Catégorie) Then

                                EcritureMessage(index, "(Bot)", "Equipement de l'item " & Pair.Cells(2).Value, Color.Gray)

                                .Socket.Envoyer("OM" & Pair.Cells(1).Value & "|" & ReturnNuméroEquipement(index, DicoItems(Pair.Cells(0).Value).Catégorie), True)

                            Else

                                EcritureMessage(index, "(Bot)", "Veuillez d'abord retirer l'item actuellement equipé avant d'equiper un autre item.", Color.Red)

                            End If

                            Return

                        End If

                    End If

                End If

            Next

        End With

    End Sub

    Private Function EquipementEquipe(ByVal index As Integer, ByVal categorie As String)

        With Comptes(index)

            Select Case categorie

                Case 1 'Amulette

                    If .MonEquipement.Amulette(0) = "" Then Return True

                Case 5, 19, 8, 22, 7, 3, 4, 6, 20, 21, 83 'Arme

                    If .MonEquipement.Arme(0) = "" Then Return True

                Case 18 'Familier 

                    If .MonEquipement.Familier(0) = "" Then Return True

                Case 10 'Ceinture 

                    If .MonEquipement.Ceinture(0) = "" Then Return True

                Case 11 'Botte  

                    If .MonEquipement.Botte(0) = "" Then Return True

                Case 16 'Coiffe 

                    If .MonEquipement.Coiffe(0) = "" Then Return True

                Case 17, 81 'Cape/Sac

                    If .MonEquipement.Cape(0) = "" Then Return True

                Case 9 'Anneaux

                    If .MonEquipement.Anneaux1(0) = "" OrElse .MonEquipement.Anneaux2(0) = "" Then Return True

                Case 23 'Dofus

                    If .MonEquipement.Dofus1(0) = "" OrElse .MonEquipement.Dofus2(0) = "" OrElse .MonEquipement.Dofus3(0) = "" OrElse
                        .MonEquipement.Dofus4(0) = "" OrElse .MonEquipement.Dofus5(0) = "" OrElse .MonEquipement.Dofus6(0) = "" Then

                        Return True

                    End If

            End Select

            Return False

        End With

    End Function

    Public Function ReturnNuméroEquipement(ByVal index As Integer, ByVal catégorie As Integer) As Integer

        With Comptes(index)

            Select Case catégorie

                Case 1 'Amulette

                    Return 0

                Case 5, 19, 8, 22, 7, 3, 4, 6, 20, 21, 83 'Arme

                    Return 1

                Case 18 'Familier 

                    Return 8

                Case 10 'Ceinture 

                    Return 3

                Case 11 'Botte  

                    Return 5

                Case 16 'Coiffe 

                    Return 6

                Case 17, 81 'Cape/Sac

                    Return 7

                Case 9 'Anneaux

                    If .MonEquipement.Anneaux1(0) <> "" Then
                        Return 2
                    ElseIf .MonEquipement.Anneaux2(0) <> "" Then
                        Return 4
                    End If

                Case 23 'Dofus

                    If .MonEquipement.Dofus1(0) <> "" Then
                        Return 9
                    ElseIf .MonEquipement.Dofus2(0) <> "" Then
                        Return 10
                    ElseIf .MonEquipement.Dofus3(0) <> "" Then
                        Return 11
                    ElseIf .MonEquipement.Dofus4(0) <> "" Then
                        Return 12
                    ElseIf .MonEquipement.Dofus5(0) <> "" Then
                        Return 13
                    ElseIf .MonEquipement.Dofus6(0) <> "" Then
                        Return 14
                    End If

            End Select

            Return 0

        End With

    End Function

    Public Sub ItemDéséquipe(ByVal index As Integer, ByVal item As String, Optional ByVal caractéristique As String = "")

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If Pair.Cells(0).Value = item OrElse Pair.Cells(2).Value.ToString.ToUpper = item.ToUpper Then

                    If caractéristique = Nothing OrElse ComparateurCaractéristiqueObjets(caractéristique, Pair.Cells(4).Value) Then

                        If Pair.DefaultCellStyle.BackColor = Color.Lime Then

                            EcritureMessage(index, "(Bot)", "Déséquipement de l'item " & Pair.Cells(1).Value, Color.Gray)

                            .Socket.Envoyer("OM" & Pair.Cells(1).Value & "|-1", True)

                            Return

                        End If

                    End If

                End If

            Next

        End With

    End Sub

    Public Function EquipementEquiper(ByVal index As Integer, ByVal item As String, ByVal caracteristique As String) As Boolean

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If Pair.Cells(0).Value.ToString = item OrElse Pair.Cells(2).Value.ToString.ToLower = item.ToLower Then

                    If caracteristique.ToLower = "nothing" OrElse ComparateurCaractéristiqueObjets(Pair.Cells(4).Value, caracteristique) Then

                        If Pair.DefaultCellStyle.BackColor = Color.Lime Then

                            Return True

                        Else

                            Return False

                        End If

                    End If

                End If

            Next

            Return False

        End With

    End Function

End Module
