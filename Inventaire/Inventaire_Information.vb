Module Inventaire_Information

    ' refonte à faire

    Public Sub GaInventaire(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' ASK | 1234567   | Linaculer  | 99    | 9         | 0       | 90            | -1       | -1       | -1       | 262c1bc        ~ 241      ~ 1         ~ 1                 ~ 64#2#4#0#1d3+1  , 7d#1#0#0#0d0+1 ; Next Item
            ' ASK | ID Joueur | Nom Joueur | Level | Id Classe | Id Sexe | Classe + Sexe | Couleur1 | Couleur2 | Couleur3 | Id Unique Item ~ Id Objet ~ Quantity  ~ Number equipment  ~ Caractéristique , Caract Next    ; Item suivent

            Try

                Dim separateData As String() = Split(data, "|")

                ' Information
                .IdUnique = separateData(1)
                Dim nom As String = separateData(2)
                Dim niveau As String = separateData(3)
                Dim classe As String = separateData(4)
                Dim sexe As String = separateData(5)
                Dim classeSexe As String = separateData(6)
                Dim couleur1 As String = "&H" & separateData(7)
                Dim couleur2 As String = "&H" & separateData(8)
                Dim couleur3 As String = "&H" & separateData(9)
                ' /Information

                EcritureMessage(index, "[Dofus]", "Connecté au personnage '" & nom & "' (Niveau : " & niveau & ")", Color.Green)

                .FrmUser.LabelNiveau.Text = "Niveau : " & niveau

                EcritureMessage(index, "(Dofus)", "Réception de l'inventaire.", Color.Green)

                .FrmUser.DataGridViewInventaire.Rows.Clear()

                'Equipement
                Dim varEquipement As New Player.sEquipement

                With varEquipement

                    .Amulette = {"", ""}
                    .Anneaux1 = {"", ""}
                    .Anneaux2 = {"", ""}
                    .Arme = {"", ""}
                    .Botte = {"", ""}
                    .Cape = {"", ""}
                    .Ceinture = {"", ""}
                    .Coiffe = {"", ""}
                    .Dofus1 = {"", ""}
                    .Dofus2 = {"", ""}
                    .Dofus3 = {"", ""}
                    .Dofus4 = {"", ""}
                    .Dofus5 = {"", ""}
                    .Dofus6 = {"", ""}
                    .Familier = {"", ""}

                End With

                .MonEquipement = varEquipement

                GaItemsAjoute(index, separateData(10), .FrmUser.DataGridViewInventaire)

                .FrmUser.DataGridViewInventaire.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .FrmUser.DataGridViewInventaire.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

                EcritureMessage(index, "[Dofus]", "Connecté.", Color.Green)

            Catch ex As Exception

                ErreurFichier(index, .NomDuPersonnage, "GaInventaire", data & vbCrLf & ex.Message)

            End Try

        End With

    End Sub

End Module
