Module Map_Information

    'A modifier + simplification + amélioration.

#Region "Chargement Map"

    Public Sub GaMapData(ByVal Index As Integer, ByVal Information As String)

        With Comptes(Index)

            'GDM | 534    | 0706131721 | 755220465939692F276671264132675c756345246c4b463b43427a3a4d38556e3c722a356362224e343d3423333e722c3f3a7a4e23553555672c733d602062454e3d474b20633c6335763e63682c43554937222f79333f253235346863387a287039474d4070302532357d586327675668752a3b6a24622962426e78787373512c5853515626536239367320643c53 
            'GDM | ID Map | Indice     | Clef

            With .FrmUser

                .DataGridViewMap.Rows.Clear()
                .DataGridViewDivers.Rows.Clear()

            End With

            Dim Separation As String() = Split(Information, "|")

            ' Je donne l'ID de la map.
            .MapID = Separation(1)

            LoadMapInGame(Index, Separation(1), Separation(2), Separation(3))

            .Socket.Envoyer("GI")

            .EnDeplacement = False
            .Send = ""
            .StopDeplacement = False
            .BloqueDeplacement.Set()

        End With

    End Sub

    Private Sub LoadMapInGame(ByVal Index As Integer, ByVal idMap As String, ByVal indice As String, ByVal clef As String)

        With Comptes(Index)

            Try

                .DirectionBas = Nothing
                .DirectionDroite = Nothing
                .DirectionGauche = Nothing
                .DirectionHaut = Nothing

                'Si le dossier map n'existe pas, alors je le créer
                If Not IO.Directory.Exists("Maps") Then IO.Directory.CreateDirectory("Maps")

                'Si le fichier de la map n'existe pas alors je le créer et ajoute les infos dedans.
                If Not IO.File.Exists("Maps/" & idMap & "_" & indice & "X.txt") Then
                    Dim Unpacker As New SwfUnpacker
                    Unpacker.SwfUnpack(idMap & "_" & indice & "X.swf")
                End If

                'Je lis le fichier voulu. 
                Dim mapReader As New IO.StreamReader("Maps/" & idMap & "_" & indice & "X.txt")
                Dim mapData As String() = Split(mapReader.ReadLine, "|")
                mapReader.Close()

                .MapLargeur = mapData(2)
                .MapHauteur = mapData(3)

                'Je prépare le nécessaire pour décrypt la map et connaitre se qu'il se trouve dessus.
                Dim preparedKey As String = prepareKey(clef)
                .MapHandler = uncompressMap(decypherData(mapData(1), preparedKey, Convert.ToInt64(checksum(preparedKey), 16) * 2))
                .FrmUser.LabelMap.Text = ListOfMap(idMap)
                .MapPosition = ListOfMap(idMap)
                .FrmUser.ToolTip1.SetToolTip(.FrmUser.LabelMap, idMap)
                Dim count As Integer = .MapHandler.Count - 1
                Dim num As Integer = 0

                'J'obtient les cellules qui me permet de changer de map via les soleils.
                For i As Integer = 1 To .MapHandler.Length - 1
                    If (.MapHandler(i).movement > 0) Then
                        If (.MapHandler(i).layerObject1Num = 1030) OrElse (.MapHandler(i).layerObject2Num = 1030) OrElse (.MapHandler(i).layerObject2Num = 4088) OrElse (.MapHandler(i).layerObject1Num = 4088) Then
                            Dim x As Integer = getX(i, Index)
                            Dim y As Integer = getY(i, Index)
                            If If(x - 1 = y, True, x - 2 = y) Then
                                If .DirectionGauche = Nothing Then
                                    .DirectionGauche = i 'Gauche
                                End If
                            ElseIf If(x - (.MapLargeur + .MapHauteur) + 5 = y, True, x - (.MapLargeur + .MapHauteur) + 5 = y - 1) Then
                                If .DirectionDroite = Nothing Then
                                    .DirectionDroite = i 'Droite
                                End If
                            ElseIf If(y + x = (.MapLargeur + .MapHauteur) - 1, True, y + x = (.MapLargeur + .MapHauteur) - 2) OrElse (y + x = (.MapLargeur + .MapHauteur)) Then
                                If .DirectionBas = Nothing Then
                                    .DirectionBas = i 'Bas
                                End If
                            ElseIf y < 0 Then
                                y = Math.Abs(y)
                                If x - y < 3 Then
                                    If .DirectionHaut = Nothing Then
                                        .DirectionHaut = i 'Haut
                                    End If
                                End If
                            End If
                        End If
                    End If
                Next

            Catch ex As Exception

                ErreurFichier(Index, .NomDuPersonnage, "Map_Information_LoadMapInGame", ex.Message)

            End Try

            LoadDiversInGame(Index, .MapHandler)

        End With

    End Sub

    Private Sub LoadDiversInGame(ByVal Index As Integer, ByVal spritesHandler() As Cell)

        With Comptes(Index).FrmUser.DataGridViewDivers

            ' id sprite | nom action | nom item , id action

            For i As Integer = 1 To 1000

                If DicoDivers.ContainsKey(spritesHandler(i).layerObject2Num) Then

                    .Rows.Add(spritesHandler(i).layerObject2Num.ToString)

                    With .Rows(.Rows.Count - 1)

                        .Cells(1).Value = i.ToString

                        .Cells(2).Value = DicoDivers(spritesHandler(i).layerObject2Num).Nom

                        .Cells(3).Value = "Disponible"

                    End With

                    .DefaultCellStyle.BackColor = Color.Lime

                End If

            Next

        End With

    End Sub

#End Region

#Region "Information"

    Public Sub GaMapAjouteEntiter(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            Dim separateData As String() = Split(data, "|+")

            For i = 1 To separateData.Count - 1

                Dim separate As String() = Split(separateData(i), ";")

                If Présent(index, separate(3)) = False Then

                    With .FrmUser.DataGridViewMap

                        'Cellule
                        .Rows.Add(separate(0))

                        With .Rows(.Rows.Count - 1)

                            'Id Unique
                            .Cells(1).Value = separate(3)

                            Select Case separate(5)

                                Case -1 ' Mobs (en combat)

                        ' nom = NameMobs(separate(4))
                       ' level = DicoMobs(separate(4))(separate(7)).Level

                                Case -2

                                    ' GM|+ 369     ; 1 ; 0 ; -1        ; 149     ; -2 ; 1571^95 ; 2          ; -1 ; -1 ; -1 ; 0 , 0 , 0 , 0 ; 18       ; 5  ; 3  ; 1 
                                    ' GM|+ Cellule ; ? ; ? ; id Unique ; Id Mobs ; ?  ; ?       ; Level mobs ; ?  ; ?  ; ?  ; ? , ? , ? , ? ; Vitalité ; PA ; PM ; ? 

                                    .Cells(2).Value = DicoMobs(separate(4))(CInt(separate(7) - 1)).NomMobs ' Nom
                                    .Cells(3).Value = "Niveau : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).Level & vbCrLf &
                                                      "Id Race : " & separate(4) & vbCrLf &
                                                      "Vitalite : " & separate(12) & vbCrLf &
                                                      "PA : " & separate(13) & vbCrLf &
                                                      "PM : " & separate(13) & vbCrLf &
                                                      "Resistance Neutre : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).RésistanceNeutre & vbCrLf &
                                                      "Resistance Terre : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).RésistanceTerre & vbCrLf &
                                                      "Resistance Feu : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).RésistanceFeu & vbCrLf &
                                                      "Resistance Eau : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).RésistanceEau & vbCrLf &
                                                      "Resistance Air : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).RésistanceAir & vbCrLf &
                                                      "Esquive PA : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).EsquivePA & vbCrLf &
                                                      "Esquive PM : " & DicoMobs(separate(4))(CInt(separate(7) - 1)).EsquivePM

                                    .DefaultCellStyle.BackColor = Color.Red

                                Case -3 ' Mobs (Hors combat)

                                    ' GM|+ 439     ; 5 ; 21      ; -2     ; 198     , 241     ; -3     ;1135^110,1138^100 ; 36 , 32 ; -1       , -1       , -1       ;0,0,0,0;-1,-1,-1;0,0,0,0; 
                                    ' GM|+ Cellule ; ? ; Etoile% ; ID Map ; ID Mobs , Id Mobs ; Entité ;                  ; Lv , Lv ; Couleur1 , Couleur2 , Couleur3 ;?,?,?,?;Couleur1,etc... 
                                    .Cells(2).Value = NameLevelMobs(separate(4), separate(7)) ' Nom
                                    .Cells(3).Value = "Niveau : " & LevelMobs(separate(7)) & vbCrLf &
                                                      "Id Race : " & separate(4) & vbCrLf &
                                                      "Etoile : " & separate(2)


                                    .DefaultCellStyle.BackColor = Color.Red

                                    '
                                    Dim separateMobs As String() = Split(separate(4), ",")

                                    For a = 0 To separateMobs.Count - 1

                                        If Liste_Archimonstre.Contains(separateMobs(a)) Then
                                            LinaBot.sendMsg("```Serveur : " & Comptes(index).Serveur & vbCrLf &
                                                            "Archimonstre : " & DicoMobs(separateMobs(a))(0).NomMobs & vbCrLf &
                                                            "Position : " & Comptes(index).MapPosition & vbCrLf &
                                                            "MapID : " & Comptes(index).MapID & vbCrLf &
                                                            "Vue le : " & Date.Now & "```")
                                        End If

                                    Next


                                    '

                                Case -4 ' PNJ 

                                    ' GM|+ 152     ; 3 ; 0        ;-1      ; 100    ; -4     ; 9048^100 ; 0  ; -1 ; -1 ; e7b317 ;   ,   ,   ,   ,   ;   ; 0 |
                                    ' GM|+ Cellule ; ? ; Etoiles% ; ID Map ; ID PNJ ; Entité ; ?        ; Lv ; ?  ; ?  ; ?      ; ? , ? , ? , ? , ? ; ? ; ? | Next PNJ

                                    .Cells(2).Value = DicoPNJ(separate(4)) ' Nom
                                    .Cells(3).Value = "Niveau : " & separate(7) & vbCrLf &
                                        "Id Race : " & separate(4) & vbCrLf &
                                        "Etoile : " & separate(2)

                                    .DefaultCellStyle.BackColor = Color.Pink

                                Case -5 ' Mode marchand

                                    ' GM|+ 412     ; 3 ; 0       ; -82    ; Blackarne ; -5     ; 60^100        ; 0  ; 0 ; -1 ; 22e4 , 27c7   , 22ac , 1cf7     , 27c6     ; Awesomes   ; c , 77f73 , 1m , 5w3r4 ; 0
                                    ' GM|+ Cellule ; ? ; Etoiles ; ID Map ; Nom       ; Entité ; Classe + sexe ; Lv ; ? ; ?  ; Cac  , Coiffe , Cape , Familier , Bouclier ; Nom guilde ; ? , ?     , ?  , ?     ; ID Sprite Sac du mode marchand

                                    'ID Sprite Sac (se que le marchand vend) 
                                    ' 0 = Tout
                                    ' 1 = Equipement
                                    ' 2 = Divers
                                    ' 3 = Ressource

                                    Dim separateEquipement As String() = Split(separate(10), ",")

                                    .Cells(2).Value = separate(4)  ' Nom
                                    .Cells(3).Value = "Classe : " & ClasseJoueur(separate(6)) & vbCrLf &
                                        "Sexe : " & SexeJoueur(separate(6)) & vbCrLf

                                    If separateEquipement(1).Contains("~") Then

                                        Dim separateObvijevan As String() = Split(separateEquipement(1), "~")

                                        .Cells(3).Value &= "Coiffe : " & DicoItems(Convert.ToInt64(separateObvijevan(0), 16)).NomItem & vbCrLf
                                        Dim coiffeLv As String = Convert.ToInt64(separateObvijevan(1), 16)
                                        Dim coiffeForme As String = Convert.ToInt64(separateObvijevan(2), 16)

                                    ElseIf separateEquipement(1) <> Nothing Then

                                        .Cells(3).Value &= "Coiffe : " & DicoItems(Convert.ToInt64(separateEquipement(1), 16)).NomItem & vbCrLf

                                    End If ' Coiffe
                                    If separateEquipement(2).Contains("~") Then

                                        Dim separateObvijevan As String() = Split(separateEquipement(2), "~")

                                        .Cells(3).Value &= "Cape : " & DicoItems(Convert.ToInt64(separateObvijevan(0), 16)).NomItem & vbCrLf
                                        Dim capeLv As String = Convert.ToInt64(separateObvijevan(1), 16)
                                        Dim capeForm As String = Convert.ToInt64(separateObvijevan(2), 16)

                                    ElseIf separateEquipement(2) <> Nothing Then

                                        .Cells(3).Value &= "Cape : " & DicoItems(Convert.ToInt64(separateEquipement(2), 16)).NomItem & vbCrLf

                                    End If ' Cape
                                    If separateEquipement(0) <> Nothing Then
                                        .Cells(3).Value &= "Cac : " & DicoItems(Convert.ToInt64(separateEquipement(0), 16)).NomItem & vbCrLf
                                    End If ' Cac
                                    If separateEquipement(3) <> Nothing Then
                                        .Cells(3).Value &= "Familier : " & DicoItems(Convert.ToInt64(separateEquipement(3), 16)).NomItem & vbCrLf
                                    End If ' Familier
                                    If separateEquipement(4) <> Nothing Then
                                        .Cells(3).Value &= "Bouclier : " & DicoItems(Convert.ToInt64(separateEquipement(4), 16)).NomItem & vbCrLf
                                    End If ' Bouclier

                                    .Cells(3).Value &= "Guilde : " & separate(11) & vbCrLf &
                                        "Mode Marchand : Oui"

                                    .DefaultCellStyle.BackColor = Color.DarkCyan

                                Case -6 ' Percepteur

                                    ' GM|+ 383     ; 1 ; 0      ; -14    ; 2l , 3d ; -6     ; 6000^110 ; 66 ; The Chosen Few ; 8 , n2bh , 1 , 9zldr
                                    ' GM|+ Cellule ; ? ; Etoile ; ID Map ; Nom     ; Entité ; Sprite   ; Lv ; Nom Guilde     ; ? , ?    , ? , ?

                                    .Cells(2).Value = separate(4) ' Nom
                                    .Cells(3).Value = "Niveau : " & separate(7) & vbCrLf &
                                        "Guilde : " & separate(8)

                                    .DefaultCellStyle.BackColor = Color.YellowGreen

                                Case -9 ' Dragodinde

                                    '252;1;-1;-9;M;-9;7002^100;Yoshimi;7;43;100

                                    .Cells(2).Value = separate(4)
                                    .Cells(3).Value = "Monture de : " & separate(7) & vbCrLf &
                                        "Niveau : " & separate(8) & vbCrLf &
                                        "Dragodinde " & DicoDragodindeId(separate(9))



                                Case -10 ' Prisme

                                    ' GM|+ 256     ; 1 ; 0      ; -4     ; 1111 ; -10    ; 8101^90 ; 2 ; 4 ; 1
                                    ' GM|+ Cellule ; ? ; Etoile ; ID Map ; Nom  ; Entité ; Sprite  ; ? ; ? ; ?

                                    .Cells(2).Value = If(separate(4) = 1111, "Prisme Bontârien", "Prise Brâkmarien") ' Nom
                                    .Cells(3).Value = "Niveau : " & separate(7) & vbCrLf &
                                        "Etoile : " & separate(2)

                                    .DefaultCellStyle.BackColor = Color.Gray

                                Case > 0 ' tchatJoueur

                                    ' Hors Combat
                                    ' GM|+ 156     ; 7 ; 0 ; 0123456   ; Linaculer ; 9       ; 90^100      ; 0                          ; 0          , 0 , 0 , 1234567           ; -1       ; -1       ; -1       ;     , 2412~16~7                  , 2411~17~15               ,          ,          ; 0   ;   ;   ;           ;                 ; 0 ;    ;   | Next tchatJoueur
                                    ' GM|~ 300     ; 1 ; 0 ; 0123456   ; linaculer ; 9       ; 90^100      ; 0                          ; 0          , 0 , 0 , 1234567           ; 0        ; 1eeb13   ; 0        ; b4  , 2412~16~18                 , 2411~17~19               ,          ,          ; 1   ;   ;   ; Chernobil ; f,9zldr,x,6k26u ; 0 ; 88 ;
                                    ' GM|+ Cellule ; ? ; ? ; Id Unique ; Nom       ; ID Race ; Classe+sexe ; Combat (Equipe bleu/rouge) ; Alignement , ? , ? , ID Unique + Level ; Couleur1 ; Couleur2 ; Couleur3 ; Cac , Coiffe (ID Objet~Lv~Forme) , Cape (ID Objet~Lv~Forme) , Familier , Bouclier ; ?   ; ? ; ? ; Guilde    ; ?               ; ? ; ?  ; ?  
                                    ' En combat 
                                    ' GM|+ 105     ; 1 ; 0 ; 0123456   ; Linaculer ; 9       ; 90^100      ; 0                          ; 99 ; 0          , 0 , 0 , 1234567           ; -1       ; -1       ; -1       ; 241 , 1bea                       , 6ab                      ,          ,          ; 672      ; 7  ; 3  ; 0           ; 1          ; 0        ; 2         ; 0        ; 77         ; 77         ; 0 ;   ;                         
                                    ' GM|+ Cellule ; ? ; ? ; Id Unique ; Nom       ; ID Race ; Classe+sexe ; Combat (Equipe bleu/rouge) ; Lv ; Alignement , ? , ? , ID Unique + Level ; Couleur1 ; Couleur2 ; Couleur3 ; Cac , Coiffe (ID Objet~Lv~Forme) , Cape (ID Objet~Lv~Forme) , Familier , Bouclier ; Vitalité ; PA ; PM ; %Rés neutre ; %Rés Terre ; %Rés feu ; %Rés Eau  ; %Res air ; Esquive PA ; Esquive PM ; ? ; ? ; ? 
                                    '~ = Sur une dragodinde

                                    Dim separateEquipement As String()
                                    Dim calculLevel As String()

                                    If Comptes(index).EnCombat Then

                                        separateEquipement = Split(separate(13), ",")
                                        calculLevel = Split(separate(9), ",")

                                    Else

                                        separateEquipement = Split(separate(12), ",")
                                        calculLevel = Split(separate(8), ",")

                                    End If

                                    .Cells(2).Value = separate(4)  ' Nom

                                    If separateEquipement(1).Contains("~") Then

                                        Dim separateObvijevan As String() = Split(separateEquipement(1), "~")

                                        .Cells(3).Value &= "Coiffe : " & DicoItems(Convert.ToInt64(separateObvijevan(0), 16)).NomItem & vbCrLf
                                        Dim coiffeLv As String = Convert.ToInt64(separateObvijevan(1), 16)
                                        Dim coiffeForme As String = Convert.ToInt64(separateObvijevan(2), 16)

                                    ElseIf separateEquipement(1) <> Nothing Then

                                        .Cells(3).Value &= "Coiffe : " & DicoItems(Convert.ToInt64(separateEquipement(1), 16)).NomItem & vbCrLf

                                    End If ' Coiffe
                                    If separateEquipement(2).Contains("~") Then

                                        Dim separateObvijevan As String() = Split(separateEquipement(2), "~")

                                        .Cells(3).Value &= "Cape : " & DicoItems(Convert.ToInt64(separateObvijevan(0), 16)).NomItem & vbCrLf
                                        Dim capeLv As String = Convert.ToInt64(separateObvijevan(1), 16)
                                        Dim capeForm As String = Convert.ToInt64(separateObvijevan(2), 16)

                                    ElseIf separateEquipement(2) <> Nothing Then

                                        .Cells(3).Value &= "Cape : " & DicoItems(Convert.ToInt64(separateEquipement(2), 16)).NomItem & vbCrLf

                                    End If ' Cape
                                    If separateEquipement(0) <> Nothing Then
                                        .Cells(3).Value &= "Cac : " & DicoItems(Convert.ToInt64(separateEquipement(0), 16)).NomItem & vbCrLf
                                    End If ' Cac
                                    If separateEquipement(3) <> Nothing Then
                                        .Cells(3).Value &= "Familier : " & DicoItems(Convert.ToInt64(separateEquipement(3), 16)).NomItem & vbCrLf
                                    End If ' Familier
                                    If separateEquipement(4) <> Nothing Then
                                        .Cells(3).Value &= "Bouclier : " & DicoItems(Convert.ToInt64(separateEquipement(4), 16)).NomItem & vbCrLf
                                    End If ' Bouclier

                                    .Cells(3).Value &= "Mode Marchand : Non" & vbCrLf &
                                                        "Alignement : " & AlignementJoueur(calculLevel(0)) & vbCrLf &
                                                        "Sexe : " & SexeJoueur(separate(6)) & vbCrLf &
                                                        "Classe : " & ClasseJoueur(separate(6)) & vbCrLf

                                    'Si en combat
                                    If Comptes(index).EnCombat Then

                                        .Cells(3).Value &= "Couleur1 : " & separate(10) & vbCrLf &
                                                           "Couleur2 : " & separate(11) & vbCrLf &
                                                           "Couleur3 : " & separate(12) & vbCrLf &
                                                           "Vitalite : " & separate(14) & vbCrLf &
                                                           "PA : " & separate(15) & vbCrLf &
                                                           "PM : " & separate(16) & vbCrLf &
                                                           "Resistance Neutre : " & separate(17) & vbCrLf &
                                                           "Resistance Terre : " & separate(18) & vbCrLf &
                                                           "Resistance Feu : " & separate(19) & vbCrLf &
                                                           "Resistance Eau : " & separate(20) & vbCrLf &
                                                           "Resistance Air : " & separate(21) & vbCrLf &
                                                           "Esquive PA : " & separate(22) & vbCrLf &
                                                           "Esquive PM : " & separate(23) & vbCrLf &
                                                           "Niveau : " & separate(8)
                                    Else

                                        .Cells(3).Value &= "Couleur1 : " & separate(9) & vbCrLf &
                                                           "Couleur2 : " & separate(10) & vbCrLf &
                                                           "Couleur3 : " & separate(11) & vbCrLf &
                                                           "Guilde : " & separate(16) & vbCrLf &
                                                           "Niveau : " & CInt(calculLevel(3)) - CInt(separate(3))

                                    End If

                                    .DefaultCellStyle.BackColor = Color.Cyan

                                    If separate(3) = Comptes(index).IdUnique Then

                                        With Comptes(index)

                                            .CaseActuelle = separate(0)
                                            .EnDeplacement = False

                                        End With

                                    End If

                                Case Else

                                    ErreurFichier(index, Comptes(index).NomDuPersonnage, "GaMapAjouteEntiter", separateData(i))

                            End Select

                        End With

                    End With

                End If

            Next

            .FrmUser.DataGridViewMap.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .FrmUser.DataGridViewMap.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

        End With

    End Sub

    Public Sub GaMapSupprimeEntiter(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GM|- 1234567
            ' GM|- Id Unique

            Dim idUnique As String = Mid(data, 5)

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = idUnique Then

                    .FrmUser.DataGridViewMap.Rows.RemoveAt(Pair.Index)

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub GaMapMoveEntity(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GA  ; 1 ; -1     ; adxfcB
            ' GA0 ; 1 ; -1     ; adxfcB
            ' GA  ; ? ; ID Map ; Path

            Dim separate As String() = Split(data, ";")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = separate(2) Then

                    Pair.Cells(0).Value = ReturnLastCell(Mid(separate(3), separate(3).Length - 1, 2))

                    If separate(2) = .IdUnique Then

                        .CaseActuelle = Pair.Cells(0).Value

                        Task.Run(Sub() PauseDéplacement(index))

                    End If

                    Return

                End If

            Next

        End With

    End Sub

    Private Async Sub PauseDéplacement(ByVal index As Integer)

        With Comptes(index)

            Dim changeur As Boolean = False
            .EnDeplacement = True
            .BloqueDeplacement.Reset()

            If (.MapHandler(.CaseActuelle).layerObject1Num = 1030) OrElse (.MapHandler(.CaseActuelle).layerObject2Num = 1030) OrElse
               (.MapHandler(.CaseActuelle).layerObject1Num = 4088) OrElse (.MapHandler(.CaseActuelle).layerObject2Num = 4088) Then

                changeur = True

            End If

            If .Send <> "" Then

                .Socket.Envoyer(.Send)

                .Send = ""

            End If

            If .PathTotal.Length > 3 Then

                For i = 0 To .PathTotal.Length Step 3

                    If .StopDeplacement Then

                        .Socket.Envoyer("GKE0|" & ReturnLastCell(Mid(.PathTotal, i + 2, 2)))

                        .StopDeplacement = False
                        .EnDeplacement = False
                        .Send = ""
                        .BloqueDeplacement.Set()

                        Return

                    Else

                        If .PathTotal.Length < 9 Then

                            Await Task.Delay(180 * 3)

                        Else

                            Await Task.Delay(80 * 3)

                        End If

                    End If

                Next

            Else

                Await Task.Delay(180 * 3)

            End If

            .Socket.Envoyer("GKK0")

            If changeur = False Then

                .EnDeplacement = False
                .BloqueDeplacement.Set()
                .StopDeplacement = False
                .Send = ""

            End If

        End With

    End Sub

    Public Sub GaMapDéplacementEscalier(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'GA1 ; 4 ; 01234567  ; 76543210 , 342
            'GA1 ; ? ; ID Joueur ; ID_Cible , Cellule

            Dim separateData As String() = Split(data, ";")

            Dim separate As String() = Split(separateData(3), ",")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = separate(0) Then

                    Pair.Cells(0).Value = separate(1)

                    If separate(0) = .IdUnique Then

                        .CaseActuelle = separate(1)
                        .Socket.Envoyer("GKK1")
                        .EnDeplacement = False
                        .BloqueDeplacement.Set()

                    End If

                    Return

                End If

            Next

        End With

    End Sub 'Sufokia > escalié

    Public Sub GaMapObjetSolAjoute(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GDO+ 358     ; 7596     ; 1                          ; 1500              ; 1500           |
            ' GDO+ Cellule ; Id Objet ; Information supplémentaire ; Résistance actuel ; Résistance Max | Next

            data = Mid(data, 5)

            Dim separateData As String() = Split(data, "|")

            For i = 0 To separateData.Count - 1

                Dim separate As String() = Split(data, ";")

                With .FrmUser.DataGridViewMapSol

                    ' Cellule
                    .Rows.Add(separate(0))

                    With .Rows(.Rows.Count - 1)

                        ' Id Objet
                        .Cells(1).Value = separate(1)

                        ' Nom
                        .Cells(2).Value = DicoItems(separate(1)).NomItem

                        If separate(2) = "1" Then

                            .Cells(3).Value = "Résistance : " & separate(3) & "/" & separate(4)

                        End If

                    End With

                End With

            Next

        End With

    End Sub

    Public Sub GaMapObjetSolSupprime(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' GDO- 123 
            ' GDO- Cellule

            data = Mid(data, 5)

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMapSol.Rows

                If Pair.Cells(0).Value = data Then

                    .FrmUser.DataGridViewMapSol.Rows.RemoveAt(Pair.Index)

                End If

            Next

        End With

    End Sub


#End Region

#Region "Function"

    Private Function Présent(ByVal index As Integer, ByVal idUnique As String) As Boolean

        With Comptes(index)

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If idUnique = Pair.Cells(1).Value Then Return True

            Next

            Return False

        End With

    End Function

    Private Function NameLevelMobs(ByVal name As String, ByVal level As String) As String

        Dim separateName As String() = Split(name, ",")
        Dim separateLevel As String() = Split(level, ",")

        Dim resultat As String = ""

        For i = 0 To separateName.Count - 1

            resultat &= DicoMobs(separateName(i))(0).NomMobs & " : " & separateLevel(i) & vbCrLf

        Next

        Return resultat

    End Function

    Private Function LevelMobs(ByVal Information As String) As Integer

        Dim levelTotal As Integer

        Dim level As String() = Split(Information, ",")

        For i = 0 To level.Count - 1

            levelTotal += level(i)

        Next

        Return levelTotal

    End Function

    Private Function ClasseJoueur(ByVal Information As String) As String

        Dim Classe As String() = {"Feca", "Osamodas", "Enutrof", "Sram", "Xelor", "Ecaflip", "Eniripsa", "Iop", "Crâ", "Sadida", "Sacrieur", "Pandawa"}
        Dim separate As String() = Split(Information, "^") ' 90^100
        Dim Résultat As Integer = Mid(separate(0), 1, Len(separate(0)) - 1) ' 90

        If Résultat < 12 Then

            Return Classe(Résultat - 1)

        Else

            Return "Inconnu"

        End If

    End Function

    Private Function SexeJoueur(ByVal Information As String) As String

        Dim sexe As String() = {"Homme", "Femme"}
        Dim separate As String() = Split(Information, "^") ' 90^100

        Dim number As Integer = Mid(separate(0), Len(separate(0)), Len(separate(0)) - 1)

        Return If(number > 1, "Inconnu", sexe(number))

    End Function

    Private Function AlignementJoueur(ByVal numéro As String) As String

        Dim Alignement() As String = {"Neutre", "Bontarien", "Brâkmarien"}

        Return Alignement(numéro)

    End Function

#End Region

End Module
