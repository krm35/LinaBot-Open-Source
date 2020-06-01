Module Tchat_Information

    Public Sub GaCanauxDofus(ByVal index As Integer, ByVal data As String)

        With Comptes(index).FrmUser

            'cC +                *#%!$:?pi^
            'cC Active/Désactive Les canaux

            Try

                'Le "+" ou le "-" indique si les canaux suivant l'opérateur sont activé ou non.
                Dim checked As Boolean = If(Mid(data, 3, 1) = "+", True, False)

                'Puis je tcheck lettre par lettre les infos après le "+" ou le "-".
                For i = 3 To data.Length - 1

                    Select Case data(i)

                        Case "i" 'Information

                            .CheckBox_Canal_Information_0.Checked = checked

                        Case "*" 'Communs/Défaut

                            .CheckBox_Canal_Communs_1.Checked = checked

                        Case "#" ', "$", "p" 'groupe/privée/équipe

                            .CheckBox_Canal_Groupe_2.Checked = checked

                        Case "%" 'guilde

                            .CheckBox_Canal_Guilde_3.Checked = checked

                        Case "!" 'alignement

                            .CheckBox_Canal_Alignement_4.Checked = checked

                        Case "?" 'recrutement

                            .CheckBox_Canal_Recrutement_5.Checked = checked

                        Case ":" 'Commerce

                            .CheckBox_Canal_Commerce_6.Checked = checked

                    End Select

                Next

            Catch ex As Exception

                ErreurFichier(index, Comptes(index).NomDuPersonnage, "Gestion_Canaux_Dofus", ex.Message)

            End Try

        End With

    End Sub

    Public Sub GaTchat(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' cMK F      | 1234567   | Linaculer | Yo      | 972!7c#1d#0#0#0d0+29,!972!7c#26#0#0#0d0+38,
            ' cMK Canaux | Id Unique | Nom       | Message | tchatItem

            'cMK:|3061114|Gigilamoroso|Â°0 +29 Â°1 +38 .. vendre mp prix !|972     ! 7c#1d#0#0#0d0+29 , ! 972    ! 7c#26#0#0#0d0+38, 
            '                                                             | tchatItem 1 ! Caract           , ! tchatItem 2 ! caract

            Dim separateData As String() = Split(data, "|")

            Dim separateMsg As String() = Split(separateData(3))

            Dim couleur As Color = Color.White

            Select Case Mid(separateData(0), 4, separateData(0).Length)

                Case "F" ' Message privée

                    couleur = Color.DodgerBlue

                Case "T" ' Message privée

                    couleur = Color.DodgerBlue

                Case "$" ' Groupe

                    couleur = Color.Cyan

                Case "#" ' Equipe

                    couleur = Color.DeepSkyBlue

                Case "%" ' Guilde

                    couleur = Color.Violet

                Case "!" ' Alignement

                    couleur = Color.Orange

                Case "?" ' Recrutement

                    couleur = Color.Gray

                Case ":" ' Commerce

                    couleur = Color.Sienna

                Case Else ' Commun

                    couleur = Color.White

            End Select

            With .FrmUser.RichTextBoxTchat

                .SelectionColor = couleur

                .AppendText("[" & TimeOfDay & "] " & "(" & separateData(1) & ") [" & separateData(2) & "] ")

            End With

            For i = 0 To separateMsg.Count - 1

                If separateMsg(i).StartsWith("Â°") Then

                    Dim numéro As Integer = CInt(Mid(separateMsg(i), 3, 1))
                    Dim idItem As String = DicoItems(Split(separateData(4), "!")(numéro + numéro)).NomItem
                    Dim Caractéristique As String = ItemCaractéristique(Split(separateData(4), "!")((numéro + numéro) + 1))

                    .TchatItem.Add("n°" & .TchatItem.Count + 1 & " = " & idItem, Caractéristique)

                    .FrmUser.RichTextBoxTchat.SelectionColor = couleur
                    .FrmUser.RichTextBoxTchat.SelectionFont = New Font(FontFamily.GenericSansSerif, 9.25, FontStyle.Bold)
                    .FrmUser.RichTextBoxTchat.AppendText("[" & "n°" & .TchatItem.Count & " = " & idItem & "] ")

                Else

                    With .FrmUser.RichTextBoxTchat

                        .SelectionColor = couleur
                        .SelectionFont = New Font(FontFamily.GenericSansSerif, 9.25, FontStyle.Regular)
                        .AppendText(AsciiDecoder(separateMsg(i)) & " ")

                    End With

                End If

            Next

            With .FrmUser.RichTextBoxTchat

                .AppendText(vbCrLf)

                .ScrollToCaret()

            End With

        End With

    End Sub

    Public Sub Smiley(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'cS 01234567  | 1
            'cS ID tchatJoueur | Numéro smiley

            data = Mid(data, 3)

            'Je sépare les informations
            Dim separateData() As String = Split(data, "|") ' 01234567|1

            'Je cherche l'image associé au numéro.
            Dim smileyCaractére() As String = {"(^_^)", "è_é", "é_è", ":p", "`_´", ":'D", "'^_^", ">_<", "X_X", "O_o", "<3", "T_T", "-_-", "XoX", "\(^o^)/"}

            ' For Each Pair As ListViewItem In .FrmUser.ListViewMap.Items

            'If Pair.SubItems(1).Text = separateData(0) Then

            '.FrmUser.RichTextBox_Tchat.SelectionColor = Color.White

            'Je mets les infos de base (nom, id etc....)
            '.FrmUser.RichTextBox_Tchat.AppendText("[" & TimeOfDay & "] [" & separateData(0) & "] " & Pair.SubItems(2).Text & " : " & smileyCaractére(separateData(1)) & vbCrLf)

            'Je baisse le scroll au max.
            '.FrmUser.RichTextBox_Tchat.ScrollToCaret()

            'End If

           ' Next

        End With

    End Sub

    Public Sub GaDofusInformation(ByVal Index As Integer, ByVal Information As String)

        With Comptes(Index)

            'Im 1165
            'Im Numéro du texte a affiché

            Try

                'Je prend toutes les informations après le "Im"
                Information = Mid(Information, 3)

                'Je sélectionne selon si y'a une information à afficher ou non via le signe ";"
                If Information.Contains(";") Then

                    Dim Separation() As String = Split(Information, ";")

                    Select Case Separation(0)

                        Case "1202" 'Im1201;[Seydlex] 

                            EcritureMessage(Index, "[Modérateur]", "Attention un modérateur vous surveille : " & Separation(1) & ".", Color.Red)

                            'Modérateur_Ban(Index)

                        Case "1184" 'Im1184;Linaculer

                            EcritureMessage(Index, "[Combat]", Separation(1) & " vient de se reconnecter en combat.", Color.Red)
                          '  .InFight = True

                        Case "1170" 'Im1170;0~4

                            'Je sépare les informations via ce signe "~"
                            Separation = Split(Separation(1), "~")
                            EcritureMessage(Index, "[Combat]", "Vous avez '" & Separation(0) & "' PA, hors il vous en faut minimum '" & Separation(1) & "' PA pour lancer ce sort.", Color.Red)

                        Case "1168" 'Im1168;1

                            EcritureMessage(Index, "[Dofus]", "Vous ne pouvez pas poser plus de " & Separation(1) & " percepteur(s) par zone.", Color.Red)

                        Case "1167" 'Im1167;54

                            EcritureMessage(Index, "[Dofus]", "Vous ne pouvez pas poser de percepteur ici avant " & Separation(1) & " minutes.", Color.Red)

                        Case "1139" 'Im1139;5

                            EcritureMessage(Index, "[Percepteur]", "Attention, la fenêtre d'échange se fermera automatiquement dans " & Separation(1) & " minutes.", Color.Red)

                        Case "1111" 'Im1111;3

                            EcritureMessage(Index, "[Dragodinde]", "A peine entrée dans l'étable, votre monture s'accroupit et commence à mettre bas. Après quelques instants, vous pouvez constater que tout s'est bien passé. Vous voilà responsable de " & Separation(1) & " nouvelle(s) monture(s).", Color.Violet)

                        Case "0188" '"Im0188;player"

                            EcritureMessage(Index, "(dofus)", "Et comme d'habitude, c'est à " & Separation(1) & " que l'on doit cet exploit...", Color.Maroon)

                        Case "0157" ' Im0157;6

                            EcritureMessage(Index, "[Dofus]", "Ce canal n'est accessible en diffusion aux abonnés qu'à partir du niveau " & Separation(1), Color.Green)

                        Case "0153" 'Im0153;xx.xxx.xx.xx

                            EcritureMessage(Index, "[Dofus]", "Votre adresse IP actuelle est : " & Separation(1) & ".", Color.Green)

                        Case "0152"

                            'Im0152; 2019  ~ 06   ~ 27   ~ 7     ~ 19     ~ xx.xxx.xx.xx
                            'Im0152; Année ~ Mois ~ Jour ~ Heure ~ Minute ~ IP

                            'Je sépare les informations qui se trouve dans la separation(1) par ce signe "~"
                            Separation = Split(Separation(1), "~")

                            EcritureMessage(Index, "[Dofus]", "Précédente connexion sur votre compte effectuée le : " &
                                                Separation(2) & "/" & Separation(1) & "/" & Separation(0) & " à " & Separation(3) & ":" & Separation(4) &
                                                " via l'adresse IP  : " & Separation(5), Color.Green)

                        Case "0143" ' Im0143;Linaculer (<b><a href="asfunction:onHref,ShowPlayerPopupMenu,Linacular">Linaculeur</a></b>) 

                            Separation = Split(Separation(1), " (<b><a href=""""asfunction: onHref, ShowPlayerPopupMenu, Linacular"""">")
                            Dim V_Nom_De_Compte As String = Separation(0)
                            Separation = Split(Separation(1), "</a></b>)")
                            EcritureMessage(Index, "[Dofus]", "Le joueur : " & V_Nom_De_Compte & "(" & Separation(0) & ") vient de se connecter.", Color.Green)

                        Case "0115"

                            EcritureMessage(Index, "[Dofus]", "Ce canal est restreint pour améliorer sa lisibilité. Vous pourrez envoyer un nouveau message dans " & Separation(1) & " secondes. Ceci ne vous autorise cependant pas pour autant à surcharger ce canal.", Color.Red)

                        Case "128" 'Im128;Linaculer

                            EcritureMessage(Index, "[Combat]", "En attente du joueur " & Separation(1) & "...", Color.Red)

                        Case "116" 'Im116;[Seydlex]~Bot tchatJoueur

                            'Je sépare les informations via ce signe "~"
                            Separation = Split(Separation(1), "~")

                            EcritureMessage(Index, "[Modérateur]", "Vous avez été banni par " & Separation(0) & ". Motif : " & Separation(2), Color.Red)
                            'Modérateur_Ban(Index)

                        Case "115"

                            ' Im115;16 heures, 43 minutes, 43 secondes
                            EcritureMessage(Index, "(Dofus)", "Pour des raisons de maintenances, le serveur va être redémarré dans " & Separation(1), Color.Red)


                        Case "092" 'Im092;50

                            EcritureMessage(Index, "[Dofus]", "Vous avez récupéré " & Separation(1) & " points d'énergie en vous reposant.", Color.Green)

                        Case "065"

                            'Im065; 300         ~ 2598     ~ 2598     ~ 1
                            'Im065; Kamas gagné ~ ID Objet ~ ID Objet ~ Quantité

                            'Je sépare les informations via ce signe "~"
                            Separation = Split(Separation(1), "~")

                            EcritureMessage(Index, "[Dofus]", "Votre compte en banque a été crédité de " & Separation(0) & " kamas suite à la vente de '" & DicoItems(Separation(1)).NomItem & "' (x " & Separation(3) & ").", Color.Green)

                        Case "053" 'Im053;Linaculer

                            EcritureMessage(Index, "[Groupe]", Separation(1) & " ne suit plus votre déplacement.", Color.Green)

                        Case "052" 'Im052;Linaculer

                            EcritureMessage(Index, "[Groupe]", Separation(1) & " suit votre déplacement.", Color.Green)

                        Case "045" ' Im045;50

                            EcritureMessage(Index, "[Dofus]", "Tu as gagné " & Separation(1) & " kamas.", Color.Green)

                        Case "036" 'Im036;Linaculer

                            EcritureMessage(Index, "[Dofus]", Separation(1) & " vient de rejoindre le combat en spectateur.", Color.Green) '/away

                        Case "034" 'Im034;60 

                            EcritureMessage(Index, "[Familier]", "Tu as perdu " & Separation(1) & " points d'énergie.", Color.Red)

                        Case "022" 'Im022;1~1568

                            'Je sépare les informations via ce signe "~"
                            Separation = Split(Separation(1), "~")

                            EcritureMessage(Index, "[Dofus]", "Tu as perdu " & Separation(0) & " '" & DicoItems(Separation(1)).NomItem & "'.", Color.Red)

                        Case "020" ' Im022;481

                            EcritureMessage(Index, "[Dofus]", "Tu as dû donner " & Separation(1) & " kamas pour pouvoir accéder à ce coffre.", Color.Lime)

                        Case "08" 'Im08;17293

                            EcritureMessage(Index, "[Dofus]", "Tu as gagné " & Separation(1) & " points d'expérience.", Color.Green)

                        Case "01" 'Im01;100

                            EcritureMessage(Index, "[Dofus]", "Tu as récupéré " & Separation(1) & " points de vie.", Color.Green)

                        Case Else

                            '  InformationInconnu(Comptes(Index).NomPersonnage, "Message_Dofus", Information)


                    End Select

                Else

                    Select Case Information

                        Case "1183"

                            EcritureMessage(Index, "[Dofus]", "La zone 'Incarnam' fonctionne sur plusieurs instances, pour éviter qu'un trop grand nombre de joueurs soient présent dans cette zone de petite taille. Ceci signifie qu'il existe plusieurs 'Incarnam' en parallèle, afin qu'il n'y ait pas plus d'un certain nombre de joueurs dans la même instance. Vous pouvez donc ne pas être dans le même 'Incarnam' que vos amis, pour les rejoindre, vous pouvez utiliser la liste d'amis, et vous retrouver instantanément à leurs côtés, à conditions qu'ils soient eux aussi dans Incarnam en dehors des grottes et donjons.", Color.Red)

                        Case "1182"

                        Case "1177"

                            EcritureMessage(Index, "[Dofus]", "Vous avez trop d'objets dans votre inventaire, vous ne pouvez pas les voir tous. (1000 objets maximum)", Color.Red)

                        Case "1175"

                            EcritureMessage(Index, "[Combat]", "Impossible de lancer ce sort actuellement.", Color.Red)

                        Case "1174"

                            EcritureMessage(Index, "[Combat]", "Un obstacle géne le passage.", Color.Red)

                        Case "1165"

                            EcritureMessage(Index, "[Dofus]", "La sauvegarde du serveur est terminée. L'accès au serveur est de nouveau possible. Merci de votre compréhension.", Color.Red)

                        Case "1164"

                            EcritureMessage(Index, "[Dofus]", "Une sauvegarde du serveur est en cours... Vous pouvez continuer de jouer, mais l'accès au serveur est temporairement bloqué. La connexion sera de nouveau possible d'ici quelques instants. Merci de votre patience.", Color.Red)

                        Case "1159"

                            EcritureMessage(Index, "[Dofus]", "Vous êtes à court de potion d'enclos de guilde.", Color.Red)

                        Case "1127"

                            EcritureMessage(Index, "[Dofus]", "Incarnam ne vous est plus accessible désormais, votre expérience fait de vous un aventurier apte à parcourir le monde sans continuer dans cette zone...", Color.Red)

                        Case "1120"

                            EcritureMessage(Index, "[Dofus]", "Impossible d'interagir avec votre percepteur sur la carte même où vous vous êtes connecté.", Color.Red)

                        Case "1117"

                            EcritureMessage(Index, "[Dofus]", "Impossible d'être sur une monture à l'intérieur d'une maison.", Color.Red)

                        Case "1105"

                            EcritureMessage(Index, "[Dragodinde]", "L'étable est pleine. Vous ne pouvez conserver que 100 montures maximum.", Color.Violet)

                        Case "1104"

                            EcritureMessage(Index, "[Dragodinde]", "Monture désignée invalide, trop de monture dans l'étable", Color.Violet)

                        Case "1102"

                            EcritureMessage(Index, "[Dragodinde]", "Cellule cible invalide", Color.Violet)

                        Case "0194"

                            EcritureMessage(Index, "[Forgemagie]", "La magie n'a pas parfaitement fonctionné, une des caractéristiques de l'objet a baissé en puissance.", Color.Red)

                        Case "0183"

                            EcritureMessage(Index, "[Forgemagie]", "Malgré vos talents, la magie n'opère pas et vous sentez l'échec de la transformation.", Color.Red)

                        Case "0144"

                            EcritureMessage(Index, "[Récolte]", "Votre inventaire est plein. Votre récolte est perdue...", Color.Red)

                        Case "0143"

                            EcritureMessage(Index, "[Dofus]", "Le joueur : " & Information & " vient de se connecter.", Color.Green)

                        Case "0118"

                            EcritureMessage(Index, "[Craft]", "Vous n'arrivez pas à assembler correctement les ingrédients, et vous n'arrivez pas à concevoir quoi que ce soit d'utilisable cette fois.", Color.Red)

                        Case "0117"

                            EcritureMessage(Index, "[Forgemagie]", "Malgré vos talents, la magie n'opère pas et vous sentez l'échec de la transformation, ainsi que la diminution de la puissance de l'objet..", Color.Red)

                        Case "0106" ' Im0106

                            EcritureMessage(Index, "[Dofus]", "Pour utiliser le canal d'alignement vous devez développer vos ailes à 3 ou plus, ou encore avoir choisi une spécialisation par les quêtes d'alignement (niveau de quêtes à partir de 20)", Color.Red)

                        Case "189"

                            EcritureMessage(Index, "[Dofus]", "Bienvenue sur Dofus, dans le Monde des douze !" & vbCrLf &
                            "Rappel : prenez garde, il est interdit de transmettre votre identifiant de connexion ainsi que votre mot de passe.", Color.Red)

                        Case "172"

                            EcritureMessage(Index, "[Hôtel de Vente]", "Cet objet n'est plus disponible à ce prix. Quelqu'un a été plus rapide...", Color.Red)

                        Case "167"

                            EcritureMessage(Index, "[Hôtel de Vente]", "Vous ne pouvez pas mettre plus d'objets en vente actuellement...", Color.Red)

                        Case "165"

                            EcritureMessage(Index, "[Hôtel de vente]", "Vous ne disposez pas d'assez de kamas pour acquitter la taxe de mise en vente...", Color.Red)

                        Case "120"

                            EcritureMessage(Index, "[Maison]", "Cet emplacement de stockage est déjà utilisé.", Color.Red)

                        Case "118" 'Im188

                            EcritureMessage(Index, "[Dofus]", "Votre familier ne peut vous suivre tant que vous êtes sur votre monture...", Color.Red)

                        Case "113" ' Im113

                            EcritureMessage(Index, "[Dofus]", "Cette action n'est pas autorisée sur cette carte.", Color.Red)

                           ' .BloqueAmi.Set()

                        Case "112"

                            EcritureMessage(Index, "[Dofus]", "Vous êtes trop chargé. Jetez quelques objets afin de pouvoir bouger.", Color.Red)

                        Case "095"

                            '  ._Combat_Cadenas_Bloqué = True
                            EcritureMessage(Index, "[Combat]", "L'équipe n'accepte plus de personnages supplémentaires.", Color.Red)

                        Case "093"

                            '  ._Combat_Groupe_Bloqué = True
                            EcritureMessage(Index, "[Combat]", "Léquipe n'accepte désormais que les membres du groupe du personnage principal.", Color.Red)

                        Case "073"

                        Case "068"

                            EcritureMessage(Index, "[Dofus]", "Lot acheté.", Color.Green)

                        Case "040"

                            '  ._Combat_Spectateur_Bloqué = True
                            EcritureMessage(Index, "[Combat]", "Le mode 'Spectateur' est désactivé.", Color.Red)

                        Case "037"

                            EcritureMessage(Index, "[Dofus]", "Vous êtes désormais considéré comme absent.", Color.Red) '/away
                             'FAMILIER

                        Case "032"

                            EcritureMessage(Index, "[Familier]", "Votre familier apprécie le repas.", Color.Green)
                            .BloqueItem.Set()

                        Case "031"

                            EcritureMessage(Index, "[Familier]", "Vous donnez à manger à votre familier famélique qui traînait comme un zombi. Il se force à manger mais la nourriture qu'il avale fait 3 fois son estomac et il se tord de douleur. Au moins il a mangé.", Color.Red)
                            .BloqueItem.Set()

                        Case "029"

                            EcritureMessage(Index, "[Familier]", "Vous donnez à manger à votre familier. Il semble qu'il avait très faim.", Color.Green)
                            .BloqueItem.Set()

                        Case "027"

                            EcritureMessage(Index, "[Familier]", "Vous donnez à manger à répétition à votre familier déjà obèse. Il avale quand même la ressource et fait une indigestion.", Color.Red)
                            .BloqueItem.Set()

                        Case "026"

                            EcritureMessage(Index, "[Familier]", "Vous donnez à manger à votre familier alors qu'il n'avait plus faim. Il se force pour vous faire plaisir.", Color.Red)
                            .BloqueItem.Set()

                        Case "025"

                            EcritureMessage(Index, "[Familier]", "Votre familier vous fait la fête !", Color.Green)

                        Case "153"

                            EcritureMessage(Index, "[Familier]", "Votre familier prend la ressource, la renifle un peu, ne semble pas convaincu et vous la rend.", Color.Red)
                            .BloqueItem.Set()

                        Case "024"

                            EcritureMessage(Index, "[Dofus]", "Tu viens de mémoriser un nouveau zaap.", Color.Green)

                        Case "06"

                            EcritureMessage(Index, "[Dofus]", "Position sauvegardée.", Color.Green)

                        Case Else

                            'InformationInconnu(Comptes(Index).NomPersonnage, "Message_Dofus", Information)

                    End Select

                End If

            Catch ex As Exception

                '  ErreurFichier(Comptes(Index).NomPersonnage, "GaDofusInformation", Information)

            End Try

        End With

    End Sub

End Module
