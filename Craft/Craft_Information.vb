Module Craft_Information

    Public Sub GaCraftInfoBulleItem(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'Montre l'item dans une infobulle quand un autre joueur craft/fm un objets.

            ' IO 1234567   | -           2423
            ' IO id Joueur | Reussi/Raté IdObjet
            ' IO1234567|-  = recette donne rien
            data = Mid(data, 3)

            Dim separate As String() = Split(data, "|")

            'Inutile pour le bot.

        End With

    End Sub

    Public Sub GaCraftObjetCréer(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' EcK; 7659
            ' EcK; Id Objet

            ' EcK ; 2539     ; B Linaculer    ; 2be#1#3#0#1d3+0 
            ' EcK ; Id Objet ; ? Nom Créateur ; Caractéristique

            .FrmUser.DataGridViewLui.Rows.Clear()
            .FrmUser.DataGridViewMoi.Rows.Clear()

            Dim separateData As String() = Split(data, ";")

            If separateData.Length > 2 Then

                EcritureMessage(index, "[Dofus]", Mid(separateData(2), 2, separateData(2).Length) & " t'a créé l'objet [" & DicoItems(separateData(1)).NomItem & "] !", Color.Green)

            Else

                EcritureMessage(index, "[Dofus]", "Vous avez créé l'objet '" & DicoItems(separateData(1)).NomItem & "' !", Color.Green)

            End If

        End With

    End Sub

End Module
