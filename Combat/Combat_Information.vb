Module Combat_Information

    Public Sub GaAjouteCombatMap(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Gc+ 1234567    ; 4 | 1234567   ; 157          ; 0 ; -1 | -3          ; 128     ; 1 ; -1
            ' Gc+ ID Lanceur ; ? | Id Joueur ; Cellule Epée ; ? ; ?  | ID Map Mobs ; Cellule ; ? ; ?

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            Dim idLanceur As String = Split(separateData(0), ";")(0) ' 1234567

            For i = 1 To separateData.Count - 1

                Dim separate As String() = Split(separateData(i), ";")

                Dim newCombatLancer As New Player.sCombatLancer

                With newCombatLancer

                    .IdUnique = separate(0)
                    .Cellule = separate(1)
                    .Cadenas = False
                    .Groupe = False
                    .Spectateur = False
                    .Aide = False
                    .Info = New Dictionary(Of Integer, Player.SCombatLancerInfo)

                End With

                If .DicoCombatLancer.ContainsKey(separate(0)) Then

                    .DicoCombatLancer(separate(0)) = newCombatLancer

                Else

                    .DicoCombatLancer.Add(separate(0), newCombatLancer)

                End If

            Next

        End With

    End Sub

    Public Sub GaSupprimeCombatMap(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Gc- 1234567
            ' Gc- ID Lanceur

            Dim idUnique As Integer = Mid(data, 4)

            If .DicoCombatLancer.ContainsKey(idUnique) Then .DicoCombatLancer.Remove(idUnique)

        End With

    End Sub

    Public Sub GaAjouteEntiterCombat(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Gt 30165936 | + 30165936         ; Za-gamer ; 4
            ' Gt -1       | + -1               ; 52       ; 1     | next mobs
            ' Gt id map   | + id unique combat ; ID Mobs  ; Level | Next mobs/joueur

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|+")

            If .DicoCombatLancer.ContainsKey(separateData(0)) Then

                For i = 1 To separateData.Count - 1 ' -1;52;1

                    Dim separate As String() = Split(separateData(i), ";") ' -1;52;1

                    Dim newCombatLancerInfo As New Player.SCombatLancerInfo

                    With newCombatLancerInfo

                        .IdUnique = separate(0)
                        .Nom = If(IsNumeric(separate(1)), DicoMobs(separate(1))(0).NomMobs, separate(1))
                        .Niveau = separate(2)

                    End With

                    If .DicoCombatLancer(separateData(0)).Info.ContainsKey(separate(0)) Then

                        .DicoCombatLancer(separateData(0)).Info(separate(0)) = newCombatLancerInfo

                    Else

                        .DicoCombatLancer(separateData(0)).Info.Add(separate(0), newCombatLancerInfo)

                    End If

                Next

            End If

        End With

    End Sub

    Public Sub GaLanceurEntrerCombat(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA ; 905 ; 1234567   ; 
            ' GA ; ID  ; ID Unique ; ?

            Dim separateData As String() = Split(data, ";")

            If .IdUnique = CInt(separateData(2)) Then

                .EnCombat = True

                .BloqueCombat.Set()

                EcritureMessage(index, "[Combat]", "Vous êtes entré en combat.", Color.Sienna)

                Prêt(index)

            End If

        End With

    End Sub

    Public Sub GaTempsPreparation(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GJK2 | 0 | 1 | 0 | 30000                                      | 4 
            ' GJK2 | ? | ? | ? | Temps restant avant que le combat se lance | ?

            .EnCombat = True

            With .FrmUser

                .DataGridViewMap.Rows.Clear()
                .DataGridViewMapSol.Rows.Clear()

            End With

            .DicoCombatLancer.Clear()
            '  .DicoCombatChallenge.Clear()
            '  .DicoCombatListeCellule.Clear()
            .CombatPause = 0
            .CombatEquipe = 0
            .CombatTour = 0

            Dim separateData As String() = Split(data, "|")

            EcritureMessage(index, "[Combat]", "Il reste " & separateData(4) & " millisecondes avant que le combat se lance automatiquement.", Color.Sienna)

        End With

    End Sub

    Public Sub GaCellulePlacementEquipe(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GP bfbubBbPbYcbcfct  | fBfPfXf1f_gdgOg2  | 0 
            ' GP Cellules Equipe 1 | Cellules equipé 2 | Indique l'équipe dans laquel vous êtes

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            .DicoCombatListeCellule.Clear()
            .CombatEquipe = separateData(2)
            .CombatPhasePlacement = True

            For i = 0 To 1

                For a = 1 To separateData(i).Length Step 2

                    If .DicoCombatListeCellule.ContainsKey(i) Then

                        .DicoCombatListeCellule(i).Add(ReturnLastCell(Mid(separateData(separateData(2)), a, 2)))

                    Else

                        .DicoCombatListeCellule.Add(i, New List(Of Integer)(ReturnLastCell(Mid(separateData(separateData(2)), a, 2))))

                    End If

                Next

            Next

        End With

    End Sub

    Public Sub GaOptionCombat(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'Go+A1234567 = cadenas
            'Go+H1234567 = demande aiode
            'Go+S1234567 = spectateur
            'Go+S - 1 = spectateur 

            Dim IdUnique As String = Mid(data, 5)

            If .DicoCombatLancer.ContainsKey(IdUnique) Then

                Dim newCombatLancer As Player.sCombatLancer = .DicoCombatLancer(IdUnique)

                With newCombatLancer

                    Select Case Mid(data, 4, 1)

                        Case "A"

                            .Cadenas = If(Mid(data, 3, 1) = "+", True, False)

                        Case "H"

                            .Aide = If(Mid(data, 3, 1) = "+", True, False)

                        Case "P"
                            .Groupe = If(Mid(data, 3, 1) = "+", True, False)

                        Case "S"

                            .Spectateur = If(Mid(data, 3, 1) = "+", True, False)

                        Case Else

                            ErreurFichier(index, Comptes(index).NomDuPersonnage, "GaOptionCombat", data)

                    End Select

                End With

                .DicoCombatLancer(IdUnique) = newCombatLancer

            End If

        End With

    End Sub

    Public Sub GaMortJoueurMobs(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA ; 103     ; 01234567 ; -5 
            ' GA ; ID Info ; ID Tueur ; ID Tué

            .CombatPause += 1800

            Dim separateData As String() = Split(data, ";")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = separateData(3) Then

                    EcritureMessage(index, "[Combat]", Pair.Cells(2).Value & " est mort.", Color.Sienna)

                    .FrmUser.DataGridViewMap.Rows.RemoveAt(Pair.Index)

                    Return

                End If

            Next

        End With

    End Sub

    Public Async Sub GaCombatAction(ByVal index As Integer, ByVal data As String)

        With Comptes(index)  'GAF0|01234567 ou GAF14|01234567 etc...

            Dim separateData() As String = Split(data, "|")

            Await Task.Delay(.CombatPause)

            .CombatPause = 0

            .Socket.Envoyer("GKK" & Mid(separateData(0), 4))

            If separateData(1) = .IdUnique Then .BloqueCombat.Set()

        End With

    End Sub

    Public Sub GaCombatFin(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'GE28815|3065723|0|2;3065723;Ancelladys;11;0;25200;28619;32600;657;;;;9|0;-1;981;9;1;;;;;;;;
            .EnCombat = False
            .Socket.Envoyer("GC1")
            .BloqueCombat.Set()
            .CombatTour = 0
            .CombatEquipe = 0
            .CombatPause = 0

            .DicoCombatLancer.Clear()
            '  .DicoCombatChallenge.Clear()
            .DicoCombatListeCellule.Clear()

            '  If .ThreadIA IsNot Nothing AndAlso .ThreadIA.IsAlive Then .ThreadIA.Abort()

            '  SortReset(index)

        End With

    End Sub

    Public Sub GaCombatTourActuel(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GTS 1234567   | 29000 
            ' GTS Id Unique | Temps restant

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            If .IdUnique = separateData(0) Then

                .CombatTour += 1



                If .ThreadIA IsNot Nothing AndAlso .ThreadIA.IsAlive Then .ThreadIA.Abort()
                .ThreadIA = New Threading.Thread(Sub() IntelligenceArtificielle(index)) With {.IsBackground = True}
                .ThreadIA.Start()

            End If

        End With

    End Sub

    Public Sub GaCombatCoupNormal(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA ; 300       ; 1234567    ; 172     , 354     , 904 , 1 , 10 , 1 , 1 
            ' GA ; Id action ; Id Lanceur ; Id sort , Cellule , ?   , ? , ?  , ? , ?

            Dim separateData As String() = Split(data, ";")
            Dim separate As String() = Split(separateData(3), ",")

            If CInt(separateData(2)) > 0 Then

                For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                    If Pair.Cells(1).Value = separateData(2) Then

                        EcritureMessage(index, "[Combat]", Pair.Cells(2).Value & " lance le sort " & DicoSort(separate(0))(1).Nom, Color.Sienna)

                        If separateData(2) = .IdUnique Then

                            ' SortUtilisé(index, separate(0))

                        End If

                        Return

                    End If

                Next


            End If

        End With

    End Sub

    Public Sub GaCombatPaUtilisé(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA ; 102       ; 1234567    ; 1234567  , -3
            ' GA ; Id action ; Id Lanceur ; Id Cible , Nbr pa perdu

            Dim separateData As String() = Split(data, ";")
            Dim separate As String() = Split(separateData(3), ",")

            If separate(0) = .IdUnique Then

                .FrmUser.ListViewCaractéristique.Items(2).SubItems(4).Text = CInt(.FrmUser.ListViewCaractéristique.Items(2).SubItems(4).Text) + CInt(separate(1))

            End If

        End With

    End Sub

    Public Sub GaCombatBooste(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GIE 117       ; 3065723  ; 1        ;   ;   ;   ; 3        ; 172 
            ' GIE Id action ; Id Cible ; Quantité ; ? ; ? ; ? ; Nbr tour ; ID Sort
            'GIE101;-1;2;;;;1;163 = PAperdu
            'Je m'occupe déjà des boostes ailleurs, exemple : GA;117;etc....
            'Utile pour afficher les infos
            'Petit Tournesol Sauvage : -1 à la portée (1 tour)
        End With

    End Sub

    Public Sub GaCombatInformationTour(ByVal index As Integer, data As String)

        With Comptes(index).FrmUser.DataGridViewMap

            ' GTM |-1         ; 0               ; 45         ; 5  ; 3  ; 330     ;   ; 45      | 1234567;0;145;6;3;309;;145  
            ' GTM | ID Unique ; Vivant=0/Mort=1 ; Pdv actuel ; PA ; PM ; Cellule ; ? ; Pdv Max | Next

            Dim separateData As String() = Split(data, "|")

            For i = 1 To separateData.Count - 1

                Dim separate As String() = Split(separateData(i), ";")

                For Each Pair As DataGridViewRow In .Rows

                    If Pair.Cells(1).Value = separate(0) Then

                        Select Case separate(1)

                            Case 0 ' Vivant

                             '   Pair.Cells(0).Value = separate(5)
                             '   Pair.Cells(15).Value = separate(2)
                             '   Pair.Cells(16).Value = separate(3)
                             '   Pair.Cells(17).Value = separate(4)
                                'separate(7) = pdv max

                            Case 1 ' Mort

                                '   Comptes(index).FrmUser.ListViewMap.Items.RemoveAt(Pair.Index)

                        End Select

                        Exit For

                    End If

                Next

            Next

        End With

    End Sub

    Public Sub GaCombatPmUtilisé(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA ; 129       ; 1234567    ; 1234567  , -3
            ' GA ; Id action ; Id Lanceur ; Id Cible , Nbr pm perdu

            Dim separateData As String() = Split(data, ";")
            Dim separate As String() = Split(separateData(3), ",")

            If separate(0) = .IdUnique Then

                .FrmUser.ListViewCaractéristique.Items(3).SubItems(5).Text = CInt(.FrmUser.ListViewCaractéristique.Items(3).SubItems(5).Text) + CInt(separate(1))

            End If

        End With

    End Sub
    Public Sub CombatEtat(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA ; 950      ; 01234567   ; 01234567 , 3    , 0 
            ' GA ; IDAction ; ID Lanceur ; ID Cible , Etat , Nbr tour

            Dim separateData As String() = Split(data, ";")
            Dim separate As String() = Split(separateData(3), ",")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = separate(0) Then

                    Select Case separate(1)

                        Case "3"

                        Case "7" ' Pesanteur

                            EcritureMessage(index, "[Combat]", Pair.Cells(2).Value & " entre dans l'état Pesanteur.", Color.Sienna)

                        Case "8"

                    End Select

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub GfRetirePdv(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA ; 100     ; 1234567    ; -5       , Quantité
            ' GA ; ID Info ; Id Lanceur ; ID Cible , Quantité

            Dim separateData() As String = Split(data, ";")

            Dim separateCible As String() = Split(separateData(3), ",")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = separateCible(0) Then

                    If separateCible(1) <> "0" Then

                        EcritureMessage(index, "[Combat]", Pair.Cells(2).Value & " perd " & separateCible(1) & " points de vie.", Color.Sienna)

                        If separateCible(0) = .IdUnique Then

                            .FrmUser.ProgressBarVitalite.Value = .FrmUser.ProgressBarVitalite.Value + CInt(separateCible(1))

                        End If

                    Else

                        EcritureMessage(index, "[Combat]", Pair.Cells(2).Value & " n'a rien subi.", Color.Sienna)

                    End If

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub CombatChangePlacement(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GIC | 3065723   ; 309     ; 1 |
            ' GIC | Id Unique ; Cellule ; ? | Next Entity

            data = Mid(data, 5)

            Dim separateData As String() = Split(data, "|")

            For i = 1 To separateData.Count - 1

                Dim separate As String() = Split(separateData(i), ";")

                For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                    If Pair.Cells(1).Value = separate(0) Then

                        Pair.Cells(0).Value = separate(1)

                        Exit For

                    End If

                Next

            Next

        End With

    End Sub

    Public Sub GaCombatOrdre(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GTL | 1234567   | -1 
            ' GTL | Id Unique | Next

            Dim separateData As String() = Split(data, "|")

            For i = 1 To separateData.Count - 1

                If separateData(i) = .IdUnique Then

                    '   .CombatOrdre = i

                    Return

                End If

            Next

        End With

    End Sub


#Region "Challenge"

    Public Sub GaCombatChallengeReçu(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Gd 2            ; 0 ;   ; 25 ; 5         ; 25    ; 5 
            ' Gd ID Challenge ; ? ; ? ; Xp ; Xp Groupe ; Butin ; Butin Groupe

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, ";")

            Dim newChallenge As New Player.SChallenge

            With newChallenge

                Select Case separateData(0)

                    Case "2"

                        .Nom = "Statue"

                    Case "24"

                        .Nom = "Borné"

                    Case "38"

                        .Nom = "Blitzkrieg"

                    Case Else

                        .Nom = "Inconnu"

                End Select

                .Raté = False
                .Xp = separateData(3)
                .XpGroupe = separateData(4)
                .Butin = separateData(5)
                .ButinGroupe = separateData(6)

            End With

            If .DicoCombatChallenge.ContainsKey(separateData(0)) Then

                .DicoCombatChallenge.Add(separateData(0), newChallenge)

            Else

                .DicoCombatChallenge(separateData(0)) = newChallenge

            End If

        End With

    End Sub

    Public Sub GaCombatChallengeRéussi(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GdOK 24
            ' GdOK id challenge

            data = Mid(data, 5)

            If .DicoCombatChallenge.ContainsKey(data) Then

                EcritureMessage(index, "[Combat]", "Challenge réussi : " & .DicoCombatChallenge(data).Nom, Color.Sienna)

            End If

        End With

    End Sub

    Public Sub GaCombatChallengeRaté(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GdKO 2
            ' GdKO id challenge

            data = Mid(data, 5)

            If .DicoCombatChallenge.ContainsKey(data) Then

                Dim newChallenge As Player.SChallenge = .DicoCombatChallenge(data)

                newChallenge.Raté = True

                .DicoCombatChallenge(data) = newChallenge

                EcritureMessage(index, "[Combat]", "Challenge raté : " & .DicoCombatChallenge(data).Nom, Color.Sienna)

            End If

        End With

    End Sub
#End Region















#Region "A delete une fois refait"

    Private Sub Prêt(ByVal index As Integer)

        Comptes(index).Socket.Envoyer("GR1")

    End Sub
    Private Sub IntelligenceArtificielle(ByVal index As Integer)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                If CInt(Pair.Cells(1).Value) < 0 Then

                    Dim newDeplacement As New FunctionMap
                    newDeplacement.SeDeplace(index, Pair.Cells(0).Value)

                    .Socket.Envoyer("GA300" & .sortalancer & ";" & Pair.Cells(0).Value)

                    Exit For

                End If

            Next

            If .EnCombat Then
                .Socket.Envoyer("Gt")
                .Socket.Envoyer("GT")
            End If

        End With

    End Sub
#End Region


End Module