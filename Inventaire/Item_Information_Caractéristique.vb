Module Item_Information_Caractéristique

    ' refonte à faire

    Public Function ItemCaractéristique(ByVal caracteristique As String) As String

        ' 76 # a      # 0      # 0      # 0d0+1  , next
        ' 7b # 1      # 0      # 0      # 0d0+1  , next
        ' ID # Divers # Divers # Divers # Aléatoire (exemple CAC) , Caractéristique suivante

        '1d3+5 = Un chiffre alétoire entre 1 à 3, puis rajoute à ça +5

        Dim resultat As String = ""

        If caracteristique <> "" Then

            Dim separateCaracteristique As String() = Split(caracteristique, ",") ' 76#a#0#0,7b#1#0#0#0d0+1

            For i = 0 To separateCaracteristique.Count - 1 ' 76#a#0#0

                If separateCaracteristique(i) <> "" Then

                    Dim separate As String() = Split(separateCaracteristique(i), "#")

                    Dim choixCaractéristique As Integer = If(separate(0) <> "-1", Convert.ToInt64(separate(0), 16), separate(0)) ' 76

                    Dim valeur1 As Integer = Convert.ToInt64(separate(1), 16)
                    Dim valeur2 As Integer
                    Dim valeur3 As Integer = Convert.ToInt64(separate(3), 16)

                    Select Case choixCaractéristique

                        Case -1

                        Case 93

                            resultat &= "Vole : " & valeur1 & " a " & Convert.ToInt64(separate(2), 16) & " PDV (air)" & vbCrLf

                        Case 96

                            resultat &= "Dommages : " & valeur1 & " a " & Convert.ToInt64(separate(2), 16) & " (eau)" & vbCrLf

                        Case 97

                            resultat &= "Dommages : " & valeur1 & " a " & Convert.ToInt64(separate(2), 16) & " (terre)" & vbCrLf

                        Case 98 'Dégât air

                            resultat &= "Dommages : " & valeur1 & " a " & Convert.ToInt64(separate(2), 16) & " (air)" & vbCrLf

                        Case 99

                            resultat &= "Dommages : " & valeur1 & " a " & Convert.ToInt64(separate(2), 16) & " (feu)" & vbCrLf

                        Case 100 ' 64 = Dommage neutre ?

                            resultat &= "Dommages : " & valeur1 & " a " & Convert.ToInt64(separate(2), 16) & " (neutre)" & vbCrLf

                        Case 101 ' 65 = PA -

                            resultat &= "PA : " & -valeur1 & vbCrLf

                        Case 110

                            resultat &= "Point de vie : " & valeur1 & vbCrLf

                        Case 118 ' 76 = Force +

                            resultat &= "Force : " & valeur1 & vbCrLf

                        Case 157 ' 9d = Force -

                            resultat &= "Force : " & -valeur1 & vbCrLf

                        Case 125 ' 7d = Vitalité +

                            resultat &= "Vitalite : " & valeur1 & vbCrLf

                        Case 153 ' 99 = Vitalité -

                            resultat &= "Vitalite : " & -valeur1 & vbCrLf

                        Case 124 ' 7c = Sagesse +

                            resultat &= "Sagesse : " & valeur1 & vbCrLf

                        Case 156 ' 9c = Sagesse -

                            resultat &= "Sagesse : " & -valeur1 & vbCrLf

                        Case 126 ' 7e = Intelligence +

                            resultat &= "Intelligence : " & valeur1 & vbCrLf

                        Case 155 ' 9b = Intelligence -

                            resultat &= "Intelligence : " & -valeur1 & vbCrLf

                        Case 123 ' 7b = Chance +

                            resultat &= "Chance : " & valeur1 & vbCrLf

                        Case 152 ' 98 = Chance -

                            resultat &= "Chance : " & -valeur1 & vbCrLf

                        Case 119 ' 77 = Agilité +

                            resultat &= "Agilite : " & valeur1 & vbCrLf

                        Case 154 ' 9a = Agilité -

                            resultat &= "Agilite : " & -valeur1 & vbCrLf

                        Case 111 ' 6f = PA +

                            resultat &= "PA : " & valeur1 & vbCrLf


                        Case 128 ' 80 = PM +

                            resultat &= "PM : " & valeur1 & vbCrLf

                        Case 127 ' 7f = PM -

                            resultat &= "PM : " & -valeur1 & vbCrLf

                        Case 117 ' 75 = PO +

                            resultat &= "PO : " & valeur1 & vbCrLf

                        Case 116 ' 74 = PO -

                            resultat &= "PO : " & -valeur1 & vbCrLf

                        Case 182 ' b6 = Invocation +

                            resultat &= "Invocation : " & valeur1 & vbCrLf

                        Case 174 ' ae = Initiative +

                            resultat &= "Initiative : " & valeur1 & vbCrLf

                        Case 175 ' af = Initiative -

                            resultat &= "Initiative : " & -valeur1 & vbCrLf

                        Case 176 ' b0 = Prospection +

                            resultat &= "Prospection : " & valeur1 & vbCrLf

                        Case 177 ' b1 = Prospection -

                            resultat &= "Prospection : " & -valeur1 & vbCrLf

                        Case 158 ' 9e = Pods +

                            resultat &= "Pods : " & valeur1 & vbCrLf

                        Case 115 ' 73 = Coups Critiques +   

                            resultat &= "Coups Critiques : " & valeur1 & vbCrLf

                        Case 112 ' 70 = Dommage +

                            resultat &= "Dommage : " & valeur1 & vbCrLf

                        Case 138 ' 8a = %Dommage +

                            resultat &= "Pc Dommage : " & valeur1 & vbCrLf

                        Case 225 ' e1 = Dommage Piège +

                            resultat &= "Dommage Piege : " & valeur1 & vbCrLf

                        Case 226 ' e2 = %Dommage Piège +

                            resultat &= "Pc Dommage Piege : " & valeur1 & vbCrLf

                        Case 178 ' b2 = Soin +

                            resultat &= "Soin : " & valeur1 & vbCrLf

                        Case 110 ' 6e = Régénération +

                              '  résultat &= "Regeneration : " & valeur1 & vbCrLf

                        Case 193

                            resultat &= "Effet : " & DicoItems(valeur3).NomItem & vbCrLf

                        Case 240 ' f0 = Résistance Terre +

                            resultat &= "Resistance Terre : " & valeur1 & vbCrLf

                        Case 241 ' f1 = Résistance Eau +

                            resultat &= "Resistance Eau : " & valeur1 & vbCrLf

                        Case 242 ' f2 = Résistance Air +

                            resultat &= "Resistance Air : " & valeur1 & vbCrLf

                        Case 243 ' f3 = Résistance Feu +

                            resultat &= "Resistance Feu : " & valeur1 & vbCrLf

                        Case 244 ' f4 = Résistance Neutre +

                            resultat &= "Resistance Neutre : " & valeur1 & vbCrLf

                        Case 210 ' d2 = %Résistance Terre +

                            resultat &= "Pc Resistance Terre : " & valeur1 & vbCrLf

                        Case 215 ' d7 = %Résistance Terre -

                            resultat &= "Pc Resistance Terre : " & -valeur1 & vbCrLf

                        Case 211 ' d3 = %Résistance Eau +

                            resultat &= "Pc Resistance Eau : " & valeur1 & vbCrLf

                        Case 216 ' d8 = %Résistance Eau -

                            resultat &= "Pc Resistance Eau : " & -valeur1 & vbCrLf

                        Case 212 ' d4 = %Résistance Air  +

                            resultat &= "Pc Resistance Air : " & valeur1 & vbCrLf

                        Case 217 ' d9 = %Résistance Air  -

                            resultat &= "Pc Resistance Air : " & -valeur1 & vbCrLf

                        Case 213 ' d5 = %Résistance Feu +

                            resultat &= "Pc Resistance Feu : " & valeur1 & vbCrLf

                        Case 218 ' da = %Résistance Feu -

                            resultat &= "Pc Resistance Feu : " & -valeur1 & vbCrLf

                        Case 214 ' d6 = %Résistance Neutre +

                            resultat &= "Pc Resistance Neutre : " & valeur1 & vbCrLf

                        Case 219 ' db = %Résistance Neutre -

                            resultat &= "Pc Resistance Neutre : " & -valeur1 & vbCrLf

                        Case 100 '64 = Corps à Corps +

                            resultat &= "Cac : " & separate(4)

                        Case 101 ' 65 = PA perdus à la cible : X à Y

                               ' résultat &= "Pa perdus a la cible : " & valeur1 & vbCrLf & " a " & Convert.ToInt64(separate(2), 16) & vbCrLf

                        Case 108 ' 6c = PDV rendus : X à Y

                               ' résultat &= "Pdv rendus : " & valeur1 & vbCrLf & " a " & Convert.ToInt64(separate(2), 16) & vbCrLf

                        Case 600

                            resultat &= "Potion de : Rappel" & vbCrLf

                        Case 601 ' 259

                            resultat &= "Potion de cite : "

                            Select Case Convert.ToInt64(separate(2), 16)

                                Case 6167

                                    resultat &= "Brakmar" & vbCrLf

                                Case 6159

                                    resultat &= "Bonta" & vbCrLf

                                Case Else

                                    ErreurFichier(0, "Unknow", "ItemsCharacteristics", caracteristique & vbCrLf & separateCaracteristique(i))

                            End Select

                        Case 605 ' 25d

                                ' 1# 
                                ' 3e8# = 1000
                                ' 0#
                                ' 1d1000+0

                             '   résultat &= "Xp gagnee : " & Convert.ToInt64(separate(1), 16) & " a " & Convert.ToInt64(separate(2), 16) & vbCrLf

                        Case 614

                            resultat &= "+ " & valeur3 & "d'XP dans le métier " & DicoMétier(Convert.ToInt64(separate(2), 16)).NomMetier

                        Case 622

                            '26e#0#0#0
                            resultat &= "Potion de : Foyer" & vbCrLf


                        Case 623 '26f = Pierre d'âme 

                            '26f#0#0#93,26f#0#0#94,26f#0#0#94,26f#0#0#94,26f#0#0#65,26f#0#0#65,26f#0#0#65,26f#0#0#65;
                            resultat &= "Pierre ame : " & valeur3 & vbCrLf

                        Case 699

                            resultat &= "Lier son métier : " & DicoMétier(valeur1).NomMetier & vbCrLf

                        Case 701

                            resultat &= "Puissance : " & valeur1 & vbCrLf

                        Case 795

                            resultat &= "Arme de chasse" & vbCrLf

                        Case 800 '320 = Point de vie +

                            '320 #5      #48     #7
                            resultat &= "Point de Vie : " & valeur3 & vbCrLf

                        Case 806 ' 326 = 'Repas et Corpulence 

                            ' 326#1#0#1ab

                            valeur2 = Convert.ToInt64(separate(2), 16)

                            If valeur3 >= 7 Then

                                valeur3 = If(valeur3 > 100, 100, valeur3)

                                resultat &= "Repas : " & -valeur3 & vbCrLf
                                resultat &= "Corpulence : Maigrichon" & vbCrLf

                            ElseIf valeur2 >= 7 Then

                                resultat &= "Repas : " & valeur3 & vbCrLf
                                resultat &= "Corpulence : Obese" & vbCrLf

                            Else
                                resultat &= "Repas : 0" & vbCrLf
                                resultat &= "Corpulence : Normal" & vbCrLf

                            End If

                        Case 807 ' 327 = Dernier Repas (objet utilisé)

                            '327#0#0#734

                            Select Case valeur3

                                Case 2114

                                    resultat &= "Dernier repas : Aliment inconnu" & vbCrLf

                                Case "0"

                                    resultat &= "Dernier repas : Aucun" & vbCrLf

                                Case Else

                                    resultat &= "Dernier repas : " & DicoItems(valeur3).NomItem & vbCrLf

                            End Select

                        Case 808 '"328" 'Date / Heure  

                            ' 328 # 28a   # cc          # 398   = A mangé le : 04/03/650 9:20
                            ' 328 # Année # Mois + Jour # Heure

                            valeur2 = Convert.ToInt64(separate(2), 16)

                            Dim Année As Integer = valeur1 + 1370

                            Dim Mois As Integer = If(valeur2 < 100, 1, Mid(valeur2, 1, valeur2.ToString.Length - 2) + 1)
                            Dim Jour As Integer = If(valeur2 < 100, valeur2, Mid(valeur2, valeur2.ToString.Length - 1, 2))

                            Dim Heure As String = valeur3.ToString.Insert(valeur3.ToString.Length - 2, ":")
                            If Heure.Length = 3 Then Heure = "00" & Heure

                            resultat &= "Date : " & Jour & "/" & Mois & "/" & Année & " " & Heure & vbCrLf

                        Case 812

                            resultat &= "Resistance : " & valeur1 & "/" & valeur3 & vbCrLf

                        Case 830

                            resultat &= "Potion de : "

                            Select Case valeur3

                                Case 1

                                    resultat &= "Foyer de guilde" & vbCrLf

                                Case 2

                                    resultat &= "Enclos de guilde" & vbCrLf

                            End Select

                        Case 940 '"3ac" 'Capacité accrue Familier

                            '3ac#0#0#a
                            ' a = 10, donc le familier peut avoir +10 en caract, etc... selon le familier.
                            resultat &= "Capacite accrue : Oui" & vbCrLf

                        Case 948

                            resultat &= "Objet pour enclos" & vbCrLf

                        Case 970

                            resultat &= "Apparence : " & DicoItems(valeur3).NomItem & vbCrLf

                        Case 971

                            '3cb#0#0#0
                            'Aucune idée, mais Objivevan

                        Case 972

                            resultat &= "Niveau : " & valeur3 & vbCrLf

                        Case 973

                            '3cd#0#0#10
                            'Indique la forme à afficher (sprite)
                            '10 = le forme (sprite) à afficher

                        Case 974

                            '3ce#0#0#17c
                            'Info Objivevan inconnu

                        Case 985

                            resultat &= "Modifie par : " & separate(4) & vbCrLf

                        Case 988

                            resultat &= "Fabrique par : " & separate(4) & vbCrLf

                        Case 994 ' 3e2

                            resultat &= "Date : " & TimeOfDay & vbCrLf

                        Case 995 '3e3 = ID de la dragodinde pour avoir les caractéristiques (quand elle se trouve dans l'inventaire)
                            '3e3#c0a#1710bbb0c60#0

                            resultat &= "Id : Rd" & valeur1 & vbCrLf & "|" & separate(2) & vbCrLf

                        Case 996 ' 3e4 = Nom du joueur qui posséde la dragodinde.
                            '3e4#0#0#0#Linaculer

                            resultat &= "Possesseur : " & separate(4) & vbCrLf

                        Case 997 '3e5 = Nom de la dragodinde
                            '3e5#15#0#0#Linaculeur

                            resultat &= "Nom : " & separate(4) & vbCrLf

                        Case 998 '"3e6" ' Jour/ heure / minute restant.
                            '3e6#13#17#3b

                            resultat &= "Date : " & DateAdd(DateInterval.Day, valeur1, Date.Today).ToString & " " & Convert.ToInt64(separate(2), 16) & ":" & valeur3

                        Case 805 '"325" 'Divers

                            resultat &= "Divers : Certificat Dopeul" & vbCrLf


                        Case Else

                            ErreurFichier(0, "Unknow", "ItemsCharacteristics", caracteristique & vbCrLf & separateCaracteristique(i))

                    End Select

                End If

            Next

        End If

        Return resultat

    End Function

    Public Function ComparateurCaractéristiqueObjets(ByVal Item As String, ByVal Voulu As String) As Boolean

        Dim caractéristiqueItem As String() = Split(Item, vbCrLf)

        Dim caractéristiqueVoulu As String() = Split(Voulu, " , ")

        For i = 0 To caractéristiqueVoulu.Count - 1

            ' J'obtient le nom de la caractéristique
            Dim separateSearch As String() = Split(caractéristiqueVoulu(i), " : ") 'Vitalité : 0 a 15 

            For a = 0 To caractéristiqueItem.Count - 1

                Dim separateItem As String() = Split(caractéristiqueItem(a), " : ") 'Vitalité : 55 

                If separateSearch(0).ToUpper = separateItem(0).ToUpper Then ' Vitalité = Vitalité

                    Dim min As Integer = Split(separateSearch(1), " a ")(0) ' 0 à 15 
                    Dim max As Integer = Split(separateSearch(1), " a ")(1) ' 0 à 15 

                    If CInt(separateItem(1)) < min OrElse CInt(separateItem(1)) > max Then

                        Return False

                    End If

                End If

            Next

        Next

        Return True

    End Function

    Public Sub GaItemModifieCaractéristique(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' OCO 4a239fd  ~ 1f40    ~ 1        ~ 8                 ~ 320#5#48#9,328#28a#1f5#466,326#0#0#48,327#0#0#18a,9e#2da#0#0#0d0+730 ; 
            ' OCO idUnique ~ IdObjet ~ Quantité ~ Numéro Equipement ~ Caractéristique                                                      ; Next item

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, ";")

            For i = 0 To separateData.Count - 1

                Dim separateItem As String() = Split(separateData(i), "~")

                Dim IdUnique As String = Convert.ToInt64(separateItem(0), 16)

                For Each Pair As DataGridViewRow In .FrmUser.DataGridViewInventaire.Rows

                    If Pair.Cells(1).Value = IdUnique Then

                        'Quantité
                        Pair.Cells(3).Value = Convert.ToInt64(separateItem(2), 16)

                        'Caractéristique
                        Pair.Cells(4).Value = ItemCaractéristique(separateItem(4))

                        Pair.Cells(4).ToolTipText = separateItem(4)

                        If separateItem(3) <> "" Then

                            Pair.DefaultCellStyle.BackColor = Color.Lime

                            Pair.Cells(4).Value &= "Equipement : " & Convert.ToInt64(separateItem(3), 16)

                        ElseIf DicoItems(Convert.ToInt64(separateItem(1), 16)).Catégorie = "24" Then

                            Pair.DefaultCellStyle.BackColor = Color.Orange

                        Else

                            Pair.DefaultCellStyle.BackColor = Color.White

                        End If

                        .BloqueItem.Set()

                        Return

                    End If

                Next

            Next

        End With

    End Sub

End Module
