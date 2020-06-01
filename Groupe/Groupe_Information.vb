Module Groupe_Information

    Public Sub GaGroupeReçoitInvitation(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PIK Linaculer | Syrius
            ' PIK Inviteur  | Invité

            .InvitationGroupe = True

            data = Mid(data, 4)

            Dim separate As String() = Split(data, "|")

            If separate(0) <> .NomDuPersonnage Then

                EcritureMessage(index, "[Dofus]", separate(0) & " vous invite à rejoindre son groupe." & vbCrLf & "Acceptez-vous ?", Color.Green)

            Else

                EcritureMessage(index, "[Dofus]", "Tu invites " & separate(1) & " à rejoindre ton groupe...", Color.Green)

            End If

            .BloqueGroupe.Set()

        End With

    End Sub

    Public Sub GaGroupeRejoint(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PCK Linaculer
            ' PCK Nom Chef

            .InvitationGroupe = False
            .EnGroupe = True
            .BloqueGroupe.Set()

            If Mid(data, 4) <> .NomDuPersonnage Then

                EcritureMessage(index, "[Dofus]", "Tu viens de rejoindre le groupe de " & Mid(data, 4), Color.Green)

            End If

            .FrmUser.LabelGroupeChef.Text = If(Mid(data, 4) = .NomDuPersonnage, "Chef", "Esclave")

        End With

    End Sub

    Public Sub GaGroupeChefId(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PL 1234567
            ' PL id Chef

            .GroupeIdChef = Mid(data, 3)

            If Mid(data, 3) = .IdUnique Then

                EcritureMessage(index, "[Dofus]", "Je suis le chef du groupe.", Color.Green)

            End If

        End With

    End Sub

    Public Sub GaGroupeAddJoueur(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PM+ 1234567   ; Linaculer ; 91         ; -1       ; -1       ; -1       ;     , 9aa    , 9a9  ,          ,          ; 111        , 111     ; 4      ; 203          ; 104         ; 0 |Next
            ' PM+ Id Unique ; Nom       ; Id Classe  ; Couleur1 ; Couleur2 ; Couleur3 ; Cac , Coiffe , Cape , Familier , Bouclier ; Pdv actuel , Pdv Max ; Niveau ; Initiative   ; Prospection ; ? |

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            For i = 0 To separateData.Count - 1

                Dim separate As String() = Split(separateData(i), ";")

                Dim separateInfo As String() = Split(separate(6), ",")

                If Not .DicoGroupe.ContainsKey(separate(0)) Then

                    .DicoGroupe.Add(separate(0), {"IdUnique", "Nom", "IdClasse", "Couleur1", "Couleur2", "Couleur3", "Cac", "Coiffe", "Cape", "Familier", "Bouclier", "Pdv actuel", "Pdv Max", "Niveau", "Initiative", "Prospection"})

                    With .DicoGroupe(separate(0))

                        .SetValue(separate(0), 0) ' IdUnique
                        .SetValue(separate(1), 1) ' Nom
                        .SetValue(separate(2), 2) ' IdClasse
                        .SetValue("&H" & separate(3), 3) ' Couleur1
                        .SetValue("&H" & separate(4), 4) ' Couleur2
                        .SetValue("&H" & separate(5), 5) ' Couleur3
                        .SetValue(If(separateInfo(0) <> Nothing, Convert.ToInt64(separateInfo(0), 16).ToString, ""), 6) ' Cac
                        .SetValue(If(separateInfo(1) <> Nothing, Convert.ToInt64(separateInfo(1), 16).ToString, ""), 7) ' Coiffe
                        .SetValue(If(separateInfo(2) <> Nothing, Convert.ToInt64(separateInfo(2), 16).ToString, ""), 8) ' Cape
                        .SetValue(If(separateInfo(3) <> Nothing, Convert.ToInt64(separateInfo(3), 16).ToString, ""), 9) ' Familier
                        .SetValue(If(separateInfo(4) <> Nothing, Convert.ToInt64(separateInfo(4), 16).ToString, ""), 10) ' Bouclier

                        separateInfo = Split(separate(7), ",")

                        .SetValue(separateInfo(0), 11) ' Pdv actuel
                        .SetValue(separateInfo(1), 12) ' Pdv Max
                        .SetValue(separate(8), 13) ' Niveau
                        .SetValue(separate(9), 14) ' Initiative
                        .SetValue(separate(10), 15) ' Prospection
                    End With

                End If

            Next

        End With

    End Sub

    Public Sub GaGroupeDeleteJoueur(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PM- 01234567
            ' PM- Id Unique

            data = Mid(data, 4)

            EcritureMessage(index, "[Groupe]", "Le joueur " & .DicoGroupe(data).GetValue(1) & " a quitté le groupe.", Color.Red)

            If .DicoGroupe.ContainsKey(data) Then Task.Run(Sub() GroupeQuitte(index))

        End With

    End Sub

    Public Sub GaGroupeModifieInformation(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PM~ 1234567   ; Linaculer ; 91         ; -1       ; -1       ; -1       ;     , 9aa    , 9a9  ,          ,          ; 107        , 111     ; 4      ; 195        ; 104         ; 0 
            ' PM~ Id Unique ; Nom       ; Id Classe  ; Couleur1 ; Couleur2 ; Couleur3 ; Cac , Coiffe , Cape , Familier , Bouclier ; Pdv actuel , Pdv Max ; Niveau ; Initiative ; Prospection ; ? 

            data = Mid(data, 4)

            Dim separate As String() = Split(data, ";")

            Dim separateInfo As String() = Split(separate(6), ",")

            If .DicoGroupe.ContainsKey(separate(0)) Then

                With .DicoGroupe(separate(0))

                    .SetValue(separate(0), 0) ' IdUnique
                    .SetValue(separate(1), 1) ' Nom
                    .SetValue(separate(2), 2) ' IdClasse
                    .SetValue("&H" & separate(3), 3) ' Couleur1
                    .SetValue("&H" & separate(4), 4) ' Couleur2
                    .SetValue("&H" & separate(5), 5) ' Couleur3
                    .SetValue(If(separateInfo(0) <> Nothing, Convert.ToInt64(separateInfo(0), 16).ToString, ""), 6) ' Cac
                    .SetValue(If(separateInfo(1) <> Nothing, Convert.ToInt64(separateInfo(1), 16).ToString, ""), 7) ' Coiffe
                    .SetValue(If(separateInfo(2) <> Nothing, Convert.ToInt64(separateInfo(2), 16).ToString, ""), 8) ' Cape
                    .SetValue(If(separateInfo(3) <> Nothing, Convert.ToInt64(separateInfo(3), 16).ToString, ""), 9) ' Familier
                    .SetValue(If(separateInfo(4) <> Nothing, Convert.ToInt64(separateInfo(4), 16).ToString, ""), 10) ' Bouclier

                    separateInfo = Split(separate(7), ",")

                    .SetValue(separateInfo(0), 11) ' Pdv actuel
                    .SetValue(separateInfo(1), 12) ' Pdv Max
                    .SetValue(separate(8), 13) ' Niveau
                    .SetValue(separate(9), 14) ' Initiative
                    .SetValue(separate(10), 15) ' Prospection

                End With

            End If

        End With

    End Sub

    Public Sub GaGroupeQuitte(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PV 3038202 

            If data = "PV" Then

                EcritureMessage(index, "[Dofus]", "Tu as quitté ton groupe.", Color.Green)

            Else

                EcritureMessage(index, "[Dofus]", .DicoGroupe(Mid(data, 3)).GetValue(1) & " vient de t'exclure du groupe.", Color.Green)

            End If

            .EnGroupe = False
            .DicoGroupe.Clear()
            .BloqueGroupe.Set()

        End With

    End Sub

    Public Sub GaGroupeRefuse(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PR
            .InvitationGroupe = False
            .BloqueGroupe.Set()

        End With

    End Sub

    Public Sub GaGroupeSuivezMoiLeTous(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' PFK 1234567
            ' PFK id Unique

            'Donne l'ID de la personne qui est suivi
            'si personne seulement PFK

            If data = "PFK" Then

                .GroupeIdChef = 0

            Else

                .GroupeIdChef = Mid(data, 4)

            End If

            .BloqueGroupe.Set()

        End With

    End Sub

    Public Sub GaGroupePositionSuivre(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' IC
            ' IC -23|34|2|3039571 
            ' IC  Map | Map | ? | Id Unique Suivi
            ' Map = [-23,34]

            If data <> "IC" Then

                data = Mid(data, 3)

                Dim separate As String() = Split(data, "|")

                If .DicoGroupe.ContainsKey(separate(3)) Then

                    EcritureMessage(index, "[Groupe]", .DicoGroupe(separate(3)).GetValue(1) & " se trouve sur la map [" & separate(0) & "," & separate(1) & "].", Color.Cyan)

                End If

            End If

        End With

    End Sub

End Module
