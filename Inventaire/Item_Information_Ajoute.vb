Module Item_Information_Ajoute

    ' refonte à faire

    Public Sub GaItemsAjoute(ByVal index As Integer, ByVal data As String, ByVal dgv As DataGridView)

        With Comptes(index)

            ' 262c1bc   ~ 241      ~ 5        ~ 1                 ~ 64#2#4#0#1d3+1  ,
            ' Id unique ~ Id Objet ~ Quantité ~ Numéro Equipement ~ Caractéristique , etc... ; tchatItem Suivant

            If data <> "" Then

                Dim separateData As String() = Split(data, ";")

                For i = 0 To separateData.Count - 2

                    Dim separateItem As String() = Split(separateData(i), "~")

                    With dgv

                        'Id Objet
                        .Rows.Add(Convert.ToInt64(separateItem(1), 16))

                        With .Rows(.Rows.Count - 1)

                            'Id Unique
                            .Cells(1).Value = Convert.ToInt64(separateItem(0), 16)

                            'Nom
                            .Cells(2).Value = DicoItems(Convert.ToInt64(separateItem(1), 16)).NomItem

                            'Quantité
                            .Cells(3).Value = Convert.ToInt64(separateItem(2), 16)

                            'Caractéristique
                            .Cells(4).Value = ItemCaractéristique(separateItem(4))

                            .Cells(4).ToolTipText = separateItem(4)

                            If separateItem(3) <> "" Then

                                .DefaultCellStyle.BackColor = Color.Lime

                                .Cells(4).Value &= "Equipement : " & Convert.ToInt64(separateItem(3), 16)

                                EquipementChange(index, separateItem(3), DicoItems(Convert.ToInt64(separateItem(1), 16)).Catégorie, "", Convert.ToInt64(separateItem(0), 16))

                            ElseIf DicoItems(Convert.ToInt64(separateItem(1), 16)).Catégorie = "24" Then

                                .DefaultCellStyle.BackColor = Color.Orange

                            Else

                                .DefaultCellStyle.BackColor = Color.White

                            End If

                            If Comptes(index).EnForgemagie Then

                                ForgemagieMajCaractéristique(index, .Cells(4).Value)

                            End If

                        End With

                    End With

                Next

                dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

                .BloqueItem.Set()

            End If

        End With

    End Sub

    Public Sub GaItemsAjouteMoi(ByVal index As Integer, ByVal data As String, ByVal dgv As DataGridView)

        With Comptes(index)

            ' EMKO+ 40420233  | 20 
            ' EMKO+ Id Unique | Quantité

            data = Mid(data, 6)

            Dim separateData As String() = Split(data, "|")

            If ItemAjouteVérification(index, separateData(0), separateData(1), dgv) = False Then

                For Each Pair As DataGridViewRow In .FrmUser.DataGridViewInventaire.Rows

                    If Pair.Cells(1).Value = separateData(0) Then

                        With dgv

                            .Rows.Add(Pair.Cells(0).Value)

                            With .Rows(.Rows.Count - 1)

                                .Cells(1).Value = Pair.Cells(1).Value
                                .Cells(2).Value = Pair.Cells(2).Value
                                .Cells(3).Value = separateData(1)
                                .Cells(4).Value = Pair.Cells(4).Value

                            End With

                        End With

                        Exit For

                    End If

                Next

            End If

            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

        End With

    End Sub

    Public Sub GaItemsAjouteLui(ByVal index As Integer, ByVal data As String, ByVal dgv As DataGridView)

        With Comptes(index)

            ' EmKO+ 40514824  | 1        | 7659     |
            ' EmKO+ Id Unique | Quantité | Id Objet | Caractéristique

            data = Mid(data, 6)

            Dim separateData As String() = Split(data, "|")

            If ItemAjouteVérification(index, separateData(0), separateData(1), dgv) = False Then

                With dgv

                    'Id Objets
                    .Rows.Add(separateData(2))

                    With .Rows(.Rows.Count - 1)

                        'Id Unique
                        .Cells(1).Value = separateData(0)

                        'Nom
                        .Cells(2).Value = DicoItems(separateData(2)).NomItem

                        'Quantité
                        .Cells(3).Value = separateData(1)

                        'Information
                        .Cells(4).Value = ItemCaractéristique(separateData(3))

                    End With

                End With

                Return

            End If

            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

            .BloqueItem.Set()

        End With

    End Sub

    Private Function ItemAjouteVérification(ByVal index As Integer, ByVal idUnique As String, ByVal quantité As String, ByVal dgv As DataGridView) As Boolean

        With Comptes(index)

            For Each Pair As DataGridViewRow In dgv.Rows

                If Pair.Cells(1).Value = idUnique Then

                    Pair.Cells(3).Value = quantité

                    Return True

                End If

            Next

            Return False

        End With

    End Function

End Module
