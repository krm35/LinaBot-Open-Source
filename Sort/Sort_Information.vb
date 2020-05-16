Module Sort_Information

    Public Sub GaSortActuel(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'SL 179     ~ 5     ~ b                    ; Next Sort
            'SL Id Sort ~ Level ~ Position Bar de sort ; 

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, ";")

            For i = 0 To separateData.Count - 2

                Dim separate As String() = Split(separateData(i), "~")

                With .FrmUser.DataGridViewSort

                    .Rows.Add(separate(0)) ' ID

                    With .Rows(.Rows.Count - 1)

                        .Cells(1).Value = DicoSort(separate(0))(separate(1)).Nom ' Nom
                        .Cells(2).Value = separate(1) ' Level

                        .Cells(3).Value = "Po Min : " & DicoSort(separate(0))(separate(1)).POMin & vbCrLf &
                                          "PO Max : " & DicoSort(separate(0))(separate(1)).POMax & vbCrLf &
                                          "PA : " & DicoSort(separate(0))(separate(1)).PA & vbCrLf &
                                          "Nombre de lancer par tour : " & DicoSort(separate(0))(separate(1)).NbrLancerTour & vbCrLf &
                                          "Nombre de lancer par tour par joueur : " & DicoSort(separate(0))(separate(1)).NbrLancerTourJoueur & vbCrLf &
                                          "Nombre de tour entre chaque lancer : 0/" & DicoSort(separate(0))(separate(1)).NbrLancerEntreTour & vbCrLf &
                                          "PO Modifiable : " & DicoSort(separate(0))(separate(1)).POModifiable & vbCrLf &
                                          "Ligne de Vue : " & DicoSort(separate(0))(separate(1)).LigneDeVue & vbCrLf &
                                          "Lancer en Ligne : " & DicoSort(separate(0))(separate(1)).LancerEnLigne & vbCrLf &
                                          "Cellule Libre : " & DicoSort(separate(0))(separate(1)).CelluleLibre & vbCrLf &
                                          "Echec fini le tour : " & DicoSort(separate(0))(separate(1)).ECFiniTour & vbCrLf &
                                          "Zone Min : " & DicoSort(separate(0))(separate(1)).ZoneMin & vbCrLf &
                                          "Zone Max : " & DicoSort(separate(0))(separate(1)).ZoneMax & vbCrLf &
                                          "Champ Action : " & DicoSort(separate(0))(separate(1)).ChampAction & vbCrLf &
                                          "Barre de sort : " & separate(2) & vbCrLf &
                                          "Coût pour Up : " & DicoSort(separate(0))(separate(1)).CoûtUp & vbCrLf &
                                          "Sort de classe : " & DicoSort(separate(0))(separate(1)).SortClasse

                        .Cells(4).Value = DicoSort(separate(0))(separate(1)).Définition

                    End With

                End With

            Next

            .FrmUser.DataGridViewSort.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .FrmUser.DataGridViewSort.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

        End With

    End Sub

End Module
