Module Equipement_Information

    Public Sub GaJoueurChangeEquipement(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Oa 1234567   | 553 , 2412~16~1 , 2411~17~1 ,          , 2509
            ' Oa ID Unique | Cac , Coiffe    , Cape      , Familier , Bouclier

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|") '1234567 | 553,2412~16~1,2411~17~1,,2509

            Dim idUnique As String = separateData(0) '1234567

            separateData = Split(separateData(1), ",") '553,2412~16~1,2411~17~1,,2509

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = idUnique Then

                    If separateData(1).Contains("~") Then

                        Dim separateObvijevan As String() = Split(separateData(1), "~")

                        Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Coiffe", "Coiffe : " & DicoItems(Convert.ToInt64(separateObvijevan(0), 16)).NomItem)

                        Dim coiffeLv As String = Convert.ToInt64(separateObvijevan(1), 16)
                        Dim coiffeForme As String = Convert.ToInt64(separateObvijevan(2), 16)

                    Else

                        If separateData(1) <> Nothing Then

                            Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Coiffe", "Coiffe : " & DicoItems(Convert.ToInt64(separateData(1), 16)).NomItem)

                        Else

                            Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Coiffe", "")

                        End If

                    End If

                    If separateData(2).Contains("~") Then

                        Dim separateObvijevan As String() = Split(separateData(2), "~")

                        Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Cape", "Cape : " & DicoItems(Convert.ToInt64(separateObvijevan(0), 16)).NomItem)

                        Dim capeLv As String = Convert.ToInt64(separateObvijevan(1), 16)
                        Dim capeForm As String = Convert.ToInt64(separateObvijevan(2), 16)

                    Else

                        If separateData(2) <> Nothing Then

                            Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Coiffe", "Coiffe : " & DicoItems(Convert.ToInt64(separateData(2), 16)).NomItem)

                        Else

                            Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Coiffe", "")

                        End If

                    End If

                    Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Cac", If(separateData(0) <> Nothing, "Cac : " & DicoItems(Convert.ToInt64(separateData(0), 16)).NomItem, ""))
                    Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Familier", If(separateData(0) <> Nothing, "Familier : " & DicoItems(Convert.ToInt64(separateData(0), 16)).NomItem, ""))
                    Pair.Cells(3).Value = ReplaceInformation(Pair.Cells(3).Value, "Bouclier", If(separateData(0) <> Nothing, "Bouclier : " & DicoItems(Convert.ToInt64(separateData(0), 16)).NomItem, ""))

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub GaBonusPanoplieAdd(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' OS+ 5               | 2476     ; 2478    | 76#a#0#0,7d#a#0#0,77#a#0#0,7b#a#0#0,7c#a#0#0,7e#a#0#0
            ' OS+ Numéro_Panoplie | ID_Objet ; ID_Objet| Caractéristique

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            If BonusPanoplieExist(index, separateData(0), separateData(1), separateData(2)) = False Then

                With .FrmUser.DataGridView_BonusPanoplie

                    .Rows.Add(separateData(0))

                    With .Rows(.Rows.Count - 1)

                        Dim separateId As String() = Split(separateData(1), ";")

                        For i = 0 To separateId.Count - 1

                            .Cells(1).Value &= DicoItems(separateId(i)).NomItem & vbCrLf

                        Next

                        .Cells(2).Value = ItemCaractéristique(separateData(2))

                    End With

                End With

            End If

        End With

    End Sub

    Private Function BonusPanoplieExist(ByVal index As Integer, ByVal idPanoplie As String, ByVal idObjet As String, ByVal caracteristique As String) As Boolean

        With Comptes(index)

            For Each Pair As DataGridViewRow In .FrmUser.DataGridView_BonusPanoplie.Rows

                If Pair.Cells(0).Value = idPanoplie Then

                    Dim separateId As String() = Split(idObjet, ";")

                    For i = 0 To separateId.Count - 1

                        Pair.Cells(1).Value &= DicoItems(separateId(i)).NomItem & vbCrLf

                    Next

                    Pair.Cells(2).Value = ItemCaractéristique(caracteristique)

                    Return True

                End If

            Next

            Return False

        End With

    End Function

    Public Sub GaBonusPanoplieDelete(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' OS- 5               
            ' OS- Numéro_Panoplie 

            data = Mid(data, 4) ' OS-5 

            For Each Pair As DataGridViewRow In .FrmUser.DataGridView_BonusPanoplie.Rows

                If Pair.Cells(0).Value = data Then

                    .FrmUser.DataGridView_BonusPanoplie.Rows.RemoveAt(Pair.Index)

                    Return

                End If

            Next


        End With

    End Sub

    Public Sub GaEquipement(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' OM 123515576 | 7
            ' OM id unique | Numéro équipement

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewInventaire.Rows

                If Pair.Cells(1).Value = separateData(0) Then

                    If separateData(1) <> Nothing Then

                        EquipementChange(index, separateData(1), DicoItems(Pair.Cells(0).Value).Catégorie, "")

                        Pair.Cells(4).Value &= "Equipement : " & separateData(1)

                        Pair.DefaultCellStyle.BackColor = Color.Lime

                    Else

                        EquipementChange(index, "", DicoItems(Pair.Cells(0).Value).Catégorie, Pair.Cells(4).Value)

                        Pair.Cells(4).Value = ReplaceInformation(Pair.Cells(4).Value, "Equipement", "")

                        Pair.DefaultCellStyle.BackColor = Color.White

                    End If

                    Return

                End If

            Next

        End With

    End Sub

    Private Sub EquipementChange(ByVal index As Integer, ByVal numero As String, ByVal categorie As String, ByVal information As String)

        With Comptes(index)

            Dim varEquipement As Player.sEquipement = .MonEquipement

            Select Case categorie

                Case 1 'Amulette

                    varEquipement.Amulette = numero

                Case 5, 19, 8, 22, 7, 3, 4, 6, 20, 21, 83 'Arme

                    varEquipement.Arme = numero

                Case 18 'Familier 

                    varEquipement.Familier = numero

                Case 10 'Ceinture 

                    varEquipement.Ceinture = numero

                Case 11 'Botte  

                    varEquipement.Botte = numero

                Case 16 'Coiffe 

                    varEquipement.Coiffe = numero

                Case 17, 81 'Cape/Sac

                    varEquipement.Cape = numero

                Case 9 'Anneaux

                    Select Case numero

                        Case "2"

                            varEquipement.Anneaux1 = numero

                        Case "4"

                            varEquipement.Anneaux2 = numero

                        Case Else

                            Dim separate As String() = Split(information, vbCrLf)

                            For i = 0 To separate.Count - 1

                                If Split(separate(i), " : ")(0) = "Equipement" Then

                                    If Split(separate(i), " : ")(1) = "2" Then

                                        varEquipement.Anneaux1 = numero

                                    Else

                                        varEquipement.Anneaux2 = numero

                                    End If

                                    Return

                                End If

                            Next

                    End Select


                Case 23 'Dofus

                    Select Case numero

                        Case "9"

                            varEquipement.Dofus1 = numero

                        Case "10"

                            varEquipement.Dofus2 = numero

                        Case "11"

                            varEquipement.Dofus3 = numero

                        Case "12"

                            varEquipement.Dofus4 = numero

                        Case "13"

                            varEquipement.Dofus5 = numero

                        Case "14"

                            varEquipement.Dofus6 = numero

                        Case Else

                            Dim separate As String() = Split(information, vbCrLf)

                            For i = 0 To separate.Count - 1

                                If Split(separate(i), " : ")(0) = "Equipement" Then

                                    Dim equipementnumero As String = Split(separate(i), " : ")(1)

                                    Select Case equipementnumero

                                        Case "9"

                                            varEquipement.Dofus1 = numero

                                        Case "10"

                                            varEquipement.Dofus2 = numero

                                        Case "11"

                                            varEquipement.Dofus3 = numero

                                        Case "12"

                                            varEquipement.Dofus4 = numero

                                        Case "13"

                                            varEquipement.Dofus5 = numero

                                        Case "14"

                                            varEquipement.Dofus6 = numero

                                    End Select

                                    Return

                                End If

                            Next

                    End Select

            End Select

            .MonEquipement = varEquipement

        End With

    End Sub

End Module
