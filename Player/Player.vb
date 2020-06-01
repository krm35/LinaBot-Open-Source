
Public Class Player

    'En dév

#Region "Création de la socket"

    Public Sub CreateSocketAuthentification(ByVal IP As String, ByVal Port As String)

        Socket_Authentification = New All_CallBack(IP, Port)
        AddHandler Socket_Authentification.Connexion, AddressOf e_Connexion
        AddHandler Socket_Authentification.Deconnexion, AddressOf e_Deconnexion
        AddHandler Socket_Authentification.Envoie, AddressOf e_Envoi
        AddHandler Socket_Authentification.Reception, AddressOf E_Reception
    End Sub

    Public Sub CreateSocketServeurJeu(ByVal IP As String, ByVal Port As String)

        Socket = New All_CallBack(IP, Port)
        AddHandler Socket.Deconnexion, AddressOf e_Deconnexion
        AddHandler Socket.Envoie, AddressOf e_Envoi
        AddHandler Socket.Reception, AddressOf E_Reception

    End Sub

#End Region

#Region "Gestion des évenements"

    Public Sub e_Connexion(ByVal Sender As Object, ByVal e As Socket_EventArgs)

        Try

            With FrmUser

                If .InvokeRequired Then

                    .Invoke(New All_CallBack.D_All_CallBack(AddressOf e_Connexion), Sender, e)

                Else

                    'Button Connexion
                    .ButtonConnexion.Text = "Déconnexion"

                    .LabelStatut.Text = "En connexion"
                    .LabelStatut.ForeColor = Color.Orange

                End If

            End With

        Catch ex As Exception


        End Try

    End Sub

    Public Sub e_Deconnexion(ByVal Sender As Object, ByVal e As Socket_EventArgs)

        Try

            With FrmUser

                ' Si on est déconnnecté
                If .InvokeRequired Then

                    .Invoke(New All_CallBack.D_All_CallBack(AddressOf e_Deconnexion), Sender, e)

                Else

                    ' Button Connexion
                    .ButtonConnexion.Text = "Connexion"

                    .LabelStatut.Text = "Déconnecté"
                    .LabelStatut.ForeColor = Color.Red

                    ResetVariable()

                End If

            End With

        Catch ex As Exception



        End Try

    End Sub

    Private Sub ResetVariable()

        Connecté = False

    End Sub

    Public Sub e_Envoi(ByVal Sender As Object, ByVal e As Socket_EventArgs)

        ' Si on envoie quelque chose
        Try

            With FrmUser

                If .InvokeRequired Then

                    .Invoke(New All_CallBack.D_All_CallBack(AddressOf e_Envoi), Sender, e)

                Else  'Loger

                    .RichTextBoxSocket.SelectionColor = Color.Red
                    .RichTextBoxSocket.AppendText("[" & TimeOfDay & "] " & "Send : " & e.Message.Replace(Chr(10), "").Replace(Chr(0), "") & vbCrLf)
                    .RichTextBoxSocket.ScrollToCaret()

                End If

            End With

        Catch ex As Exception

            ErreurFichier(Index, Comptes(Index).NomDuPersonnage, "e_Envoi", ex.Message)

        End Try

    End Sub

    Public Sub E_Reception(ByVal Message As Object, ByVal e As Socket_EventArgs)

        If e.Message <> Nothing Then

            Try

                If FrmUser.InvokeRequired Then

                    FrmUser.Invoke(New All_CallBack.D_All_CallBack(AddressOf E_Reception), Message, e)

                Else

                    'Loger
                    FrmUser.RichTextBoxSocket.SelectionColor = Color.Cyan
                    FrmUser.RichTextBoxSocket.AppendText("[" & TimeOfDay & "] " & "Recv : " & e.Message & vbCrLf)
                    FrmUser.RichTextBoxSocket.ScrollToCaret()

                    'Selection des infos
                    Select Case e.Message(0)

                        Case "A"

                            Select Case e.Message(1)

                                Case "A" ' AA

                                    Select Case e.Message(2)

                                        Case "E" ' AAE

                                            Select Case e.Message(3)

                                                Case "a" ' AAEa

                                                    EcritureMessage(Index, "[Dofus]", "Ce nom n'est pas disponible.", Color.Red)

                                                    GaPersonnageNomAléatoire(Index)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "AAE", e.Message)

                                            End Select

                                        Case "K" ' AAK

                                            If e.Message = "AAK" Then

                                                GaPersonnageModifieNom(Index)

                                            Else

                                                ErreurFichier(Index, NomDuPersonnage, "AA", e.Message)

                                            End If

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AA", e.Message)

                                    End Select

                                Case "B" ' AB

                                    Select Case e.Message(2)

                                        Case "E" ' ABE

                                            EcritureMessage(Index, "[Dofus]", "Impossible de up la caractéristique.", Color.Red)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AB", e.Message)

                                    End Select

                                Case "c" ' Ac

                                    Select Case e.Message(2)

                                        Case "0" ' Ac0

                                            ' Utilisation inconnu

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ac", e.Message)

                                    End Select

                                Case "d" ' Ad

                                    GaPseudo(Index, e.Message)

                                Case "f" ' Af

                                    Select Case e.Message(2) 'Af0

                                        Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-"

                                            GaFileAttenteAuthentification(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Af", e.Message)

                                    End Select

                                Case "H" ' AH

                                    GaReçoisServer(Index, e.Message)

                                Case "L" ' AL

                                    Select Case e.Message(2)

                                        Case "K" 'ALK

                                            GaReceptionPersonnage(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AL", e.Message)

                                    End Select

                                Case "l" ' Al

                                    Select Case e.Message(2)

                                        Case "E" 'AlE

                                            'Je déconnecte le bot.
                                            Socket_Authentification.Connexion_Game(False)

                                            Select Case e.Message(3)

                                                Case "a" 'AlEa
                                                    EcritureMessage(Index, "[Dofus]", "Déjà en connexion.", Color.Red)

                                                Case "b" 'AlEb
                                                    EcritureMessage(Index, "[Dofus]", "Votre compte à été banni.", Color.Red)

                                                Case "c" 'AlEc
                                                    EcritureMessage(Index, "[Dofus]", "Vous êtes déjà connécté au serveur du jeu.", Color.Red)

                                                Case "d" 'AlEd
                                                    EcritureMessage(Index, "[Dofus]", "Vous avez déconnecté une personne utilisant le compte.", Color.Red)

                                                Case "f" 'AlEf
                                                    EcritureMessage(Index, "[Dofus]", "Mauvais mot de passe.", Color.Red)

                                                Case "k" 'AlEk
                                                    'AlEk Jour | Heure | Minute

                                                    Dim Separation() As String = Split(Mid(e.Message, 5), "|")

                                                    'Le like me permet de regarde si le résultat correspond à chaque séparation.
                                                    If "1" = Separation(0) Like (Separation(1) Like Separation(2)) Then
                                                        EcritureMessage(Index, "[Dofus]", "Compte invalide, si vous avez 1j 1h 1m, il s'agît d'une IP bannie définitivement" & vbCrLf & "il vous suffit de changer d'IP pour régler le problème.", Color.Red)
                                                    Else
                                                        EcritureMessage(Index, "[Dofus]", "Ton compte est invalide pendant " & Separation(0) & " Jour(s) " & Separation(1) & " Heure(s) " & Separation(2) & " Minute(s)'.", Color.Red)
                                                    End If

                                                Case "n" 'AlEn
                                                    EcritureMessage(Index, "[Dofus]", "La connexion ne sait pas faite corréctement.", Color.Red)

                                                Case "p" 'AlEp
                                                    EcritureMessage(Index, "[Dofus]", "Votre compte n'est pas valide.", Color.Red)

                                                Case "s" 'AlEs
                                                    EcritureMessage(Index, "[Dofus]", "Le Pseudo est déjà utilisé, veuillez en choisir un autre.", Color.Red)

                                                Case "v" 'AlEv1.30.1

                                                    EcritureMessage(Index, "[Dofus]", "La version de DOFUS installée est invalide pour ce serveur. Pour accéder au jeu, la version '" & Mid(e.Message, 5) & "' est nécessaire.", Color.Red)

                                                    GaVersion(Index, e.Message)

                                                Case "w" 'AlEw
                                                    EcritureMessage(Index, "[Dofus]", "Le serveur est complet. (Vous n'étes donc plus abonnée)", Color.Red)

                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Unknow", e.Message)

                                            End Select

                                        Case "K" ' AlK

                                            Select Case e.Message(3)

                                                Case "0" ' AlK0

                                                    Socket_Authentification.Envoyer("Ax")

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "AlK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Al", e.Message)

                                    End Select

                                Case "M", "m"

                                'aM21|1
                                'am118|1|1
                                'Inconnu

                                Case "N"

                                    GaNiveauUp(Index, e.Message)

                                Case "P" ' AP

                                    Select Case e.Message(2)

                                        Case "K" ' APK

                                            GaNomPersonnageAléatoire(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AP", e.Message)

                                    End Select

                                Case "Q" ' AQ

                                    GaSecretQuestion(Index, e.Message)

                                Case "q" ' Aq

                                    GaFileAttenteJeu(Index, e.Message)

                                Case "R" ' AR

                                    'AR 6bk 
                                    'AR 6bk (ou autre) = les droits du personnage, genre échanger, défi, agresser etc.
                                    'Utile pour connaître les droits en fantôme/transformation etc.
                                    '(NON FINI)
                                   ' Statut_Information_Peronnage_Autorisation(iIndex, Base36ToDec(Mid(e.Message, 3)))

                                Case "S" ' AS

                                    Select Case e.Message(2)

                                        Case "K" ' ASK

                                            Socket.Envoyer("GC1")

                                            Connecté = True

                                            GaInventaire(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AS", e.Message)

                                    End Select

                                Case "s" ' As

                                    GaCaracteristique(Index, e.Message)

                                Case "T" ' AT

                                    Select Case e.Message(2)

                                        Case "E" 'ATE  co trop lente

                                            EcritureMessage(Index, "(Dofus)", "Connexion interrompue avec le serveur." & vbCrLf &
                                                                              "Votre connexion est trop lente ou instable.", Color.Red)

                                            'Je déconnecte le bot.
                                            Socket_Authentification.Connexion_Game(False)


                                        Case "K" 'ATK

                                            Select Case e.Message(3)

                                                Case "0" 'ATK0

                                                    Socket.Envoyer("Ak0")
                                                    Socket.Envoyer("AV")

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "ATK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AT", e.Message)

                                    End Select

                                Case "V" ' AV -- Manque une information

                                    Select Case e.Message(2)

                                        Case "0" 'AV0

                                            Socket.Envoyer("Agfr")
                                            'Socket.Envoyer("AiCode") = ? 
                                            Socket.Envoyer("AL")
                                            Socket.Envoyer("Af")

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Av", e.Message)

                                    End Select

                                Case "X" ' AX

                                    Select Case e.Message(2)

                                        Case "E" ' AXE  

                                            Select Case e.Message(3)

                                                Case "d"

                                                    EcritureMessage(Index, "[Dofus]", "Serveur : En sauvegarde.", Color.Red)

                                                Case "f" ' AXEf

                                                    EcritureMessage(Index, "[Dofus]",
                                                        "Serveur : COMPLET" & vbCrLf &
                                                        "Nombre maximum de joueurs atteint." & vbCrLf & vbCrLf &
                                                        "Pour bénéficier d'un accès prioritaire aux serveurs, nous vous invitons à vous abonner.
                                                         Vous pouvez également tenter de vous connecter sur un autre serveur. Vous pouvez également 
                                                         télécharger et vous connecter sur les serveurs Dofus 2.0, qui proposent un plus grand nombre
                                                         de place pour accueillir les joueurs !", Color.Red)

                                                    Socket_Authentification.Connexion_Game(False)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "AXE", e.Message)

                                            End Select

                                        Case "K" ' AXK

                                            GaServeurIpPortTicket(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AX", e.Message)

                                    End Select

                                Case "x" ' Ax

                                    Select Case e.Message(2)

                                        Case "K" ' AxK

                                            GaServeurSelection(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ax", e.Message)

                                    End Select

                                Case "Y" ' AY

                                    Select Case e.Message(2)

                                        Case "K" ' AYK

                                            GaServeurIpPortTicket(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "AY", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "A", e.Message)

                            End Select

                        Case "a"

                            Select Case e.Message(1)

                                Case "l" ' al

                                    ' al|270;0|49;1|etc....
                                    ' Inconnu

                                Case "m" ' Am

                                    ' Inconnu
                                    ' am12|0|1

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "a", e.Message)

                            End Select

                        Case "B"

                            Select Case e.Message(1)

                                Case "D" 'BD

                                    'BD650|2|15 = La date, exemple : 15/03/2020

                                Case "N" ' BN

                                    If e.Message.Length > 2 Then

                                        ErreurFichier(Index, NomDuPersonnage, "BN", e.Message)

                                    End If

                                Case "p" ' Bp

                                    'Inconnu

                                Case "T" ' BT

                                    ' Inconnu
                                    ' BT1584274548177

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "B", e.Message)

                            End Select

                        Case "b"

                            ErreurFichier(Index, NomDuPersonnage, "b", e.Message)

                        Case "C"

                            ErreurFichier(Index, NomDuPersonnage, "C", e.Message)

                        Case "c"

                            Select Case e.Message(1)

                                Case "C" ' cC

                                    Select Case e.Message(2)

                                        Case "+" ' cC+

                                            GaCanauxDofus(Index, e.Message)

                                        Case "-" ' cC-

                                            GaCanauxDofus(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "cC", e.Message)

                                    End Select

                                Case "M" ' cM

                                    Select Case e.Message(2)

                                        Case "E" ' cME

                                            Select Case e.Message(3)

                                                Case "A" ' cMEA

                                                    If e.Message = "cMEA" Then

                                                        EcritureMessage(Index, "[Dofus]", "Il vous est impossible de parler dans le canal Alignement.", Color.Red)

                                                    Else

                                                        ErreurFichier(Index, NomDuPersonnage, "cMEA", e.Message)

                                                    End If

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "cME", e.Message)

                                            End Select

                                        Case "K" ' cMK

                                            Select Case e.Message(3)

                                                Case "F", "T", "$", "#", "*", "%", "!", "?", ":", "|" ' cMKF

                                                    GaTchat(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "cMK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "cM", e.Message)

                                    End Select

                                Case "S" ' cS

                                    Smiley(Index, e.Message)

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "c", e.Message)

                            End Select

                        Case "D"

                            Select Case e.Message(1)

                                Case "C" ' DC

                                    Select Case e.Message(2)

                                        Case "K" ' DCK

                                            GaPnjDialogue(Index, e.Message)

                                        Case "E"

                                            EnDialogue = True
                                            EcritureMessage(Index, "[Dofus]", "Vous êtes déjà en dialogue.", Color.Red)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "DC", e.Message)

                                    End Select

                                Case "Q" ' DQ

                                    GaPnjQuestionReponse(Index, e.Message)

                                Case "V" ' DV

                                    EnDialogue = False
                                    ListePnjReponseDisponible.Clear()
                                    DialogueReponse = 0
                                    BloqueDialogue.Set()

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "D", e.Message)

                            End Select

                        Case "d"

                            ErreurFichier(Index, NomDuPersonnage, "d", e.Message)

                        Case "E"

                            Select Case e.Message(1)

                                Case "C" 'faire les eck3 ETC.... pour la fm etc....

                                    Select Case e.Message(2)

                                        Case "K" ' ECK

                                            Select Case e.Message(3)

                                                Case "0" ' ECK0

                                                    '  EnAcheterVendre = True
                                                  '  BloquePnj.Set()

                                                Case "1" ' ECK1

                                                ' FrmUser.Label_Statut.Text = "En Echange (Joueur)"
                                               ' FrmUser.Label_Statut.ForeColor = Color.Cyan

                                                Case "2" ' ECK2

                                                ' FrmUser.Label_Statut.Text = "En Echange (PNJ)"
                                               ' FrmUser.Label_Statut.ForeColor = Color.Cyan

                                                Case "3" ' ECK3

                                                    EnCraft = True

                                                    Dim separate As String() = Split(e.Message, ";")

                                                    Select Case separate(1)

                                                        Case "1"

                                                            EnForgemagie = True
                                                      '  FrmUser.Label_Statut.Text = "Forgemage (Reforger une Dague)"

                                                        Case "11"

                                                       ' FrmUser.Label_Statut.Text = "Bijoutier (Anneau)"

                                                        Case "12"

                                                        'FrmUser.Label_Statut.Text = "Bijoutier (Amulette)"

                                                        Case "13"

                                                      '  FrmUser.Label_Statut.Text = "Cordonnier (Botte)"

                                                        Case "14"

                                                       ' FrmUser.Label_Statut.Text = "Cordonnier (Ceinture)"

                                                        Case "15"

                                                       ' FrmUser.Label_Statut.Text = "Sculpteur (Sculpter un Arc)"

                                                        Case "17"

                                                       ' FrmUser.Label_Statut.Text = "Sculpteur (Sculpter un Bâton)"

                                                        Case "16"

                                                       ' FrmUser.Label_Statut.Text = "Sculpteur (Sculpter une Baguette)"

                                                        Case "18"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Forger une Dague)"

                                                        Case "19"

                                                        'FrmUser.Label_Statut.Text = "Forgeron (Forger un Marteau)"

                                                        Case "20"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Forger une Epée)"

                                                        Case "21"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Forger une Pelle)"

                                                        Case "23"

                                                      '  FrmUser.Label_Statut.Text = "Alchimiste (Preparer une Potion)"

                                                        Case "27"

                                                       ' FrmUser.Label_Statut.Text = "Boulanger (Cuir du pain)"

                                                        Case "32"

                                                       ' FrmUser.Label_Statut.Text = "Mineur (Fondre)"

                                                        Case "47"

                                                       ' FrmUser.Label_Statut.Text = "Paysan (Moudre)"

                                                        Case "48"

                                                       ' FrmUser.Label_Statut.Text = "Mineur (Polir une Pierre)"

                                                        Case "63"

                                                      '  FrmUser.Label_Statut.Text = "Tailleur (Chapeau)"

                                                        Case "64"

                                                       ' FrmUser.Label_Statut.Text = "Tailleur (Cape)"

                                                        Case "65"

                                                     '   FrmUser.Label_Statut.Text = "Forgeron (Forger une Hache)"

                                                        Case "66"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Forger une Faux)"

                                                        Case "67"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Forger une Pioche)"

                                                        Case "101"

                                                       ' FrmUser.Label_Statut.Text = "Bûcheron (Scier)"

                                                        Case "109"

                                                       ' FrmUser.Label_Statut.Text = "Boulanger (Faire des bonbons)"

                                                        Case "113"

                                                            EnForgemagie = True
                                                       ' FrmUser.Label_Statut.Text = "Forgemage (Reforger une Epée)"

                                                        Case "115"

                                                            EnForgemagie = True
                                                      '  FrmUser.Label_Statut.Text = "Forgemage (Reforger une Hache)"

                                                        Case "116"

                                                            EnForgemagie = True
                                                       ' FrmUser.Label_Statut.Text = "Forgemage (Reforger un Marteau)"

                                                        Case "117"

                                                            EnForgemagie = True
                                                      '  FrmUser.Label_Statut.Text = "Forgemage (Reforger une Pelle)"

                                                        Case "118"

                                                            EnForgemagie = True
                                                      '  FrmUser.Label_Statut.Text = "Sculptemage (Resculpter un Arc)"

                                                        Case "119"

                                                            EnForgemagie = True
                                                      '  FrmUser.Label_Statut.Text = "Sculptemage (Resculpter une Baguette)"

                                                        Case "120"

                                                            EnForgemagie = True
                                                      '  FrmUser.Label_Statut.Text = "Sculptemage (Resculpter un Bâton)"

                                                        Case "122"

                                                       ' FrmUser.Label_Statut.Text = "Paysan (Egrener)"

                                                        Case "123"

                                                       ' FrmUser.Label_Statut.Text = "Tailleur (Sac)"

                                                        Case "132"

                                                       ' FrmUser.Label_Statut.Text = "Chasseur (Préparer)"

                                                        Case "133"

                                                       ' FrmUser.Label_Statut.Text = "Pêcheur (Vider un poisson)"

                                                        Case "134"

                                                      '  FrmUser.Label_Statut.Text = "Boucher (Préparer une viande)"

                                                        Case "135"

                                                       ' FrmUser.Label_Statut.Text = "Poissonnier (Préparer un poisson)"

                                                        Case "142"

                                                      '  FrmUser.Label_Statut.Text = "Forgeron (Réparer une Dague)"

                                                        Case "143"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Réparer une Hache)"

                                                        Case "144"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Réparer un Marteau)"

                                                        Case "145"

                                                       ' FrmUser.Label_Statut.Text = "Forgeron (Réparer une Epée)"

                                                        Case "146"

                                                      '  FrmUser.Label_Statut.Text = "Forgeron (Réparer une Pelle)"

                                                        Case "147"

                                                       ' FrmUser.Label_Statut.Text = "Sculpteur (Réparer un Bâton)"

                                                        Case "148"

                                                    '    FrmUser.Label_Statut.Text = "Sculpteur (Réparer une Baguette)"

                                                        Case "149"

                                                      '  FrmUser.Label_Statut.Text = "Sculpteur (Réparer un Arc)"

                                                        Case "163"

                                                            EnForgemagie = True
                                                      '  FrmUser.Label_Statut.Text = "Cordomage (Améliorer des Bottes)"

                                                        Case "164"

                                                            EnForgemagie = True
                                                     '   FrmUser.Label_Statut.Text = "Cordomage (Améliorer une Ceinture)"

                                                        Case "165"

                                                            EnForgemagie = True
                                                       ' FrmUser.Label_Statut.Text = "Costumage (Améliorer une Cape)"

                                                        Case "166"

                                                            EnForgemagie = True
                                                       ' FrmUser.Label_Statut.Text = "Costumage (Améliorer un Chapeau)"

                                                        Case "167"

                                                            EnForgemagie = True
                                                       ' FrmUser.Label_Statut.Text = "Costumage (Améliorer un Sac)"

                                                        Case "168"

                                                            EnForgemagie = True
                                                       ' FrmUser.Label_Statut.Text = "Joillomage (Améliorer un Anneau)"

                                                        Case "169"

                                                            EnForgemagie = True
                                                       ' FrmUser.Label_Statut.Text = "Joillomage (Améliorer une Amulette)"

                                                        Case "171"

                                                       ' FrmUser.Label_Statut.Text = "Bricoleur (Bricoler)"

                                                        Case "182"

                                                            ' FrmUser.Label_Statut.Text = "Bricoleur (Confectionner une clef)"

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "ECK", e.Message)

                                                    End Select

                                                    'FrmUser.LabelStatut.ForeColor = Color.Orange

                                                    ' bInCraft = True

                                                 '   BloqueInterraction.Set()

                                                Case "5" ' ECK5

                                                    EnBanque = True

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "ECK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "EC", e.Message)

                                    End Select

                                Case "c" ' Ec

                                    Select Case e.Message(2)

                                        Case "E" ' EcE

                                            Select Case e.Message(3)

                                                Case "F" ' EcEF

                                                    FrmUser.DataGridViewMoi.Rows.Clear()
                                                    FrmUser.DataGridViewLui.Rows.Clear()

                                                    EcritureMessage(Index, "[Dofus]", "La recette est bonne mais a échoué !", Color.Green)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EcE", e.Message)

                                            End Select

                                        Case "K" ' EcK

                                            Select Case e.Message(3)

                                                Case ";" ' EcK;

                                                    GaCraftObjetCréer(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EcK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ec", e.Message)

                                    End Select

                                Case "L" ' EL

                                    Select Case e.Message(2)

                                        Case "O" ' ELO 

                                            If EnBanque Then

                                                GaItemsAjoute(Index, e.Message.Replace("EL", "").Replace("O", ""), FrmUser.DataGridViewLui)

                                            End If

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "EL", e.Message)

                                    End Select

                                Case "M" ' EM

                                    Select Case e.Message(2)

                                        Case "K" ' EMK

                                            Select Case e.Message(3)

                                                Case "O" ' EMKO

                                                    Select Case e.Message(4)

                                                        Case "+" ' EMKO+

                                                            GaItemsAjouteMoi(Index, e.Message, FrmUser.DataGridViewMoi)

                                                        Case "-" ' EMKO-

                                                            GaItemsSupprimeMoi(Index, e.Message, FrmUser.DataGridViewMoi)

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "EMKO", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EMK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "EM", e.Message)

                                    End Select

                                Case "m" ' Em

                                    Select Case e.Message(2)

                                        Case "K" ' EmK

                                            Select Case e.Message(3)

                                                Case "O" ' EmKO

                                                    Select Case e.Message(4)

                                                        Case "+" ' EmKO+

                                                            GaItemsAjouteLui(Index, e.Message, FrmUser.DataGridViewLui)

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "EmKO", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "E", e.Message)

                                    End Select

                                Case "s" ' Es

                                    Select Case e.Message(2)

                                        Case "K" ' EsK

                                            Select Case e.Message(3)

                                                Case "O" ' EsKO

                                                    Select Case e.Message(4)

                                                        Case "+" ' EsKO+

                                                            GaItemsAjouteLui(Index, e.Message, FrmUser.DataGridViewLui)

                                                        Case "-" ' EsKO-

                                                            GaItemsSupprimeLui(Index, e.Message, FrmUser.DataGridViewLui)

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "EsKO", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EsK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Es", e.Message)

                                    End Select

                                Case "V" ' EV

                                    If e.Message = "EV" Then

                                        If EnBanque Then

                                            EnDialogue = False
                                            ListePnjReponseDisponible.Clear()
                                            DialogueReponse = 0
                                            BloqueDialogue.Set()
                                            BloqueInterraction.Set()
                                            EnBanque = False

                                        End If

                                    Else

                                        ErreurFichier(Index, NomDuPersonnage, "EV", e.Message)

                                    End If

                                Case "W" ' EW

                                    Select Case e.Message(2)

                                        Case "+" ' EW+

                                            If e.Message.Length > 3 Then

                                                ' EW+ 0123456   |
                                                ' EW+ ID tchatJoueur |
                                                'Inconnu
                                            Else

                                                ' JobActivateDeactivate(Index, e.Message)

                                            End If

                                        Case "-" ' EW-

                                            If e.Message.Length > 3 Then



                                            Else

                                                '  JobActivateDeactivate(Index, e.Message)

                                            End If

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "EW", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "E", e.Message)

                            End Select

                        Case "e"

                            Select Case e.Message(1)

                                Case "L" ' eL

                                    'eL7808|0 = Inconnu

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "e", e.Message)

                            End Select

                        Case "F"

                            Select Case e.Message(1)

                                Case "O" ' FO

                                    Select Case e.Message(2)

                                        Case "-" ' FO- 

                                            AmiAvertie = False

                                            EcritureMessage(Index, "[Dofus]", "Vous serai pas avertie lors de la connexion d'un ami.", Color.Green)

                                        Case "+" ' FO+

                                            AmiAvertie = True

                                            EcritureMessage(Index, "[Dofus]", "Vous serai avertie lors de la connexion d'un ami.", Color.Green)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "FO", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "F", e.Message)

                            End Select

                        Case "f"

                            Select Case e.Message(1)

                                Case "C" ' fC

                                    Select Case CInt(e.Message(2).ToString)

                                        Case "0" ' fC0

                                            EcritureMessage(Index, "[Dofus]", "Il n'y a aucun combat en cours actuellement sur la map.", Color.Green)

                                            CombatMapSpectateur = False

                                        Case > 0 ' fC1

                                            EcritureMessage(Index, "[Dofus]", "Il y a des combats en cours actuellement sur la map.", Color.Green)

                                            CombatMapSpectateur = True

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "fC", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "f", e.Message)

                            End Select

                        Case "G"

                            Select Case e.Message(1)

                                Case "A" ' GA

                                    Select Case e.Message(2)

                                        Case "0" ' GA0

                                            Select Case e.Message(3)

                                                Case ";" ' GA0;

                                                    Select Case e.Message(4)

                                                        Case "1" ' GA0;1

                                                            Select Case e.Message(5)

                                                                Case ";" ' GA0;1;

                                                                    GaMapMoveEntity(Index, e.Message)

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA0;1", e.Message)

                                                            End Select

                                                        Case "5" ' GA0;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' GA0;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' GA0;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' GA0;501;

                                                                                    GARecolteEnCours(Index, e.Message)

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "GA0;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA0;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA0;5", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GA0;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GA0", e.Message)

                                            End Select

                                        Case "1" ' GA1

                                            Select Case e.Message(3)

                                                Case ";" ' GA1;

                                                    Select Case e.Message(4)

                                                        Case "4" ' GA1;4

                                                            Select Case e.Message(5)

                                                                Case ";" ' GA1;4;

                                                                    GaMapDéplacementEscalier(Index, e.Message)

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA1;4", e.Message)

                                                            End Select

                                                        Case "5" ' GA1;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' GA1;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' GA1;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' GA1;501;

                                                                                    GARecolteEnCours(Index, e.Message)

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "GA1;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA1;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA1;5", e.Message)

                                                            End Select


                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GA1;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GA1", e.Message)

                                            End Select


                                        Case ";" ' GA;

                                            Select Case e.Message(3)

                                                Case "0" ' GA;0

                                                    EnDeplacement = False
                                                    PathTotal = ""
                                                    BloqueDeplacement.Set()

                                                    If Send <> "" Then

                                                        Socket.Envoyer(Send)

                                                        Send = ""

                                                    End If

                                                Case "1" ' GA;1

                                                    Select Case e.Message(4)

                                                        Case ";" ' GA;1;

                                                            GaMapMoveEntity(Index, e.Message)

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GA;1", e.Message)

                                                    End Select

                                                Case "2" 'GA;2;1234567;

                                                    'Inconnu

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GA;", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GA", e.Message)

                                    End Select

                                Case "C" ' GC

                                    Select Case e.Message(2)

                                        Case "K" ' GCK

                                            Select Case e.Message(3)

                                                Case "|" ' GCK|

                                                    Select Case e.Message(4)

                                                        Case "1" ' GCK|1

                                                            Select Case e.Message(5)

                                                                Case "|" ' GCK|1|

                                                                    'Utilité inconnu : GCK|1|Linaculer

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GCK|1", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GCK|", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GCK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GCK", e.Message)

                                    End Select

                                Case "D" ' GD

                                    If e.Message = "GD" Then

                                        Socket.Envoyer("GD" & IdUnique)

                                    Else

                                        Select Case e.Message(2)

                                            Case "F" ' GDF

                                                GaInterractionEnJeu(Index, e.Message)

                                            Case "K" ' GDK

                                                If e.Message = "GDK" Then

                                                    ' Inconnu

                                                Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GD", e.Message)

                                                End If

                                            Case "M" ' GDM

                                                Select Case e.Message(3)

                                                    Case "|" ' GDM|

                                                        GaMapData(Index, e.Message)

                                                    Case Else

                                                        ErreurFichier(Index, NomDuPersonnage, "GDM", e.Message)

                                                End Select

                                            Case "O" ' GDO

                                                Select Case e.Message(3)

                                                    Case "+" ' GDO+

                                                        GaMapObjetSolAjoute(Index, e.Message)

                                                    Case "-" ' GDO-

                                                        GaMapObjetSolSupprime(Index, e.Message)

                                                    Case Else

                                                        ErreurFichier(Index, NomDuPersonnage, "GDO", e.Message)

                                                End Select

                                            Case Else

                                                ErreurFichier(Index, NomDuPersonnage, "GD", e.Message)

                                        End Select

                                    End If

                                Case "M" ' GM

                                    Select Case e.Message(2)

                                        Case "|" ' GM|

                                            Select Case e.Message(3)

                                                Case "+" ' GM|+

                                                    GaMapAjouteEntiter(Index, e.Message)

                                                Case "-" ' GM|-

                                                    GaMapSupprimeEntiter(Index, e.Message)

                                                Case "~" ' GM|~ = Dragodinde (monté)

                                                    GaMapAjouteEntiter(Index, e.Message.Replace("|~", "|+"))

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GM|", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GM", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "G", e.Message)

                            End Select

                        Case "g"

                            Select Case e.Message(1)

                                Case "K" 'gK

                                    Select Case e.Message(2)

                                        Case "K" ' gKK

                                            GaGuildeBanni(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "gK", e.Message)

                                    End Select

                                Case "S" ' gS

                                    GaGuildeIntégrer(Index, e.Message)

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "g", e.Message)

                            End Select

                        Case "H"

                            Select Case e.Message(1)

                                Case "C" ' HC

                                    GaConnexionServeurAuthentification(Index, e.Message)

                                Case "G" ' HG

                                    GaConnexionServeurJeu(Index)

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "H", e.Message)

                            End Select

                        Case "h"

                            Select Case e.Message(1)

                                Case "L" ' hL

                                    Select Case e.Message(2)

                                        Case "+" ' hL+

                                            GaMaMaison(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "hL", e.Message)

                                    End Select

                                Case "P" ' hP

                                    GaMaisonMap(Index, e.Message)

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "h", e.Message)

                            End Select

                        Case "I"

                            Select Case e.Message(1)

                                Case "C" ' IC

                                    GaGroupePositionSuivre(Index, e.Message)

                                Case "L" ' IL

                                    Select Case e.Message(2)

                                        Case "F" ' ILF

                                            GaPointDeVieRecuperer(Index, e.Message)

                                        Case "S" ' ILS

                                            GaRegenerationSeconde(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "IL", e.Message)

                                    End Select

                                Case "m" ' Im

                                    GaDofusInformation(Index, e.Message)

                                Case "O" ' IO

                                    GaCraftInfoBulleItem(Index, e.Message)

                                Case "Q" ' IQ

                                    HarvestDrop(Index, e.Message)

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "I", e.Message)

                            End Select

                        Case "i"

                            ErreurFichier(Index, NomDuPersonnage, "i", e.Message)

                        Case "J"

                            Select Case e.Message(1)

                                Case "N" ' JN

                                    GaMetierUp(Index, e.Message)

                                Case "O" ' JO

                                    GaMetierOption(Index, e.Message)

                                Case "R" ' JR

                                    GaMetierSupprime(Index, e.Message)

                                Case "S" ' JS

                                    Select Case e.Message(2)

                                        Case "|" ' JS|

                                            GaMétierInformation(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "J", e.Message)

                                    End Select

                                Case "X" ' JX

                                    Select Case e.Message(2)

                                        Case "|" ' JX|

                                            GaMetierNiveauXp(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "J", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "J", e.Message)

                            End Select

                        Case "j"

                            ErreurFichier(Index, NomDuPersonnage, "j", e.Message)

                        Case "K"

                            ErreurFichier(Index, NomDuPersonnage, "K", e.Message)

                        Case "k"

                            ErreurFichier(Index, NomDuPersonnage, "k", e.Message)

                        Case "L"

                            ErreurFichier(Index, NomDuPersonnage, "L", e.Message)

                        Case "l"

                            ErreurFichier(Index, NomDuPersonnage, "l", e.Message)

                        Case "M"

                            Select Case e.Message(1)

                                Case "0" ' M0

                                    Select Case e.Message(2)

                                        Case "1" ' M01

                                            If e.Message.Length > 3 Then

                                                Select Case e.Message(3)

                                                    Case "3" ' M013

                                                        GaProblemeConnexion(Index, "M013", e.Message)

                                                    Case "8" ' M018

                                                        GaProblemeConnexion(Index, "M018", e.Message)

                                                    Case Else

                                                        ErreurFichier(Index, NomDuPersonnage, "M01", e.Message)

                                                End Select

                                            Else

                                                If e.Message = "M01" Then

                                                    GaProblemeConnexion(Index, e.Message)

                                                Else

                                                    ErreurFichier(Index, NomDuPersonnage, "M01", e.Message)

                                                End If

                                            End If

                                        Case "3" ' M03

                                            Select Case e.Message(3)

                                                Case "0" ' M030

                                                    GaProblemeConnexion(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "M03", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "M0", e.Message)

                                    End Select

                                Case "1" ' M1

                                    Select Case e.Message(2)

                                        Case "1"

                                            Select Case e.Message(3)

                                                Case "0" ' M110
                                                    'M110|542

                                                    EcritureMessage(Index, "(Bot - Banque)", "Il vous faut au moins " & Split(e.Message, "|")(1) & " kamas pour accéder à votre coffre.", Color.Red)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "M1", e.Message)

                                            End Select

                                        Case "3" ' M13

                                            Select Case e.Message(3)

                                                Case "2" ' M132

                                                    GaProblemeConnexion(Index, "M132")

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "M13", e.Message)

                                            End Select

                                        Case "6"

                                            If e.Message <> "M16" Then

                                                ErreurFichier(Index, NomDuPersonnage, "M16", e.Message)

                                            Else

                                                EcritureMessage(Index, "[Dofus]", "Le nombre maximum d'objets pour cet inventaire est déjà atteint.", Color.Red)

                                            End If

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "M", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "M", e.Message)

                            End Select

                        Case "m"

                            ErreurFichier(Index, NomDuPersonnage, "m", e.Message)

                        Case "N"

                            ErreurFichier(Index, NomDuPersonnage, "N", e.Message)

                        Case "n"

                            ErreurFichier(Index, NomDuPersonnage, "n", e.Message)

                        Case "O"

                            Select Case e.Message(1)

                                Case "A" ' OA

                                    Select Case e.Message(2)

                                        Case "K" ' OAK

                                            Select Case e.Message(3)

                                                Case "O" ' OAKO

                                                    GaItemsAjoute(Index, e.Message.Replace("OAKO", ""), FrmUser.DataGridViewInventaire)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "OAK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "OA", e.Message)

                                    End Select

                                Case "a" ' Oa

                                    GaJoueurChangeEquipement(Index, e.Message)

                                Case "C" ' OC

                                    Select Case e.Message(2)

                                        Case "O" ' OCO

                                            GaItemModifieCaractéristique(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "OC", e.Message)

                                    End Select

                                Case "M" ' OM

                                    GaEquipement(Index, e.Message)

                                Case "Q"

                                    GaItemModifieQuantiteInventaire(Index, e.Message)

                                Case "R" ' OR

                                    GaItemSupprimeInventaire(Index, e.Message)

                                Case "S" ' OS

                                    Select Case e.Message(2)

                                        Case "+" ' OS+

                                            GaBonusPanoplieAdd(Index, e.Message)

                                        Case "-" ' OS-

                                            GaBonusPanoplieDelete(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "OS", e.Message)

                                    End Select

                                Case "T"

                                    'OT62 = Inconnu

                                Case "w" ' Ow

                                    GaPods(Index, e.Message)

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "O", e.Message)

                            End Select

                        Case "o"

                            ErreurFichier(Index, NomDuPersonnage, "o", e.Message)

                        Case "P"

                            Select Case e.Message(1)

                                Case "C" ' PC

                                    Select Case e.Message(2)

                                        Case "K" ' PCK

                                            GaGroupeRejoint(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "PC", e.Message)

                                    End Select

                                Case "F" ' PF

                                    Select Case e.Message(2)

                                        Case "K" ' PK

                                            GaGroupeSuivezMoiLeTous(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "PF", e.Message)

                                    End Select

                                Case "I" ' PI

                                    Select Case e.Message(2)

                                        Case "K" ' PIK

                                            GaGroupeReçoitInvitation(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "PI", e.Message)

                                    End Select

                                Case "L" ' PL

                                    GaGroupeChefId(Index, e.Message)

                                Case "M" ' PM

                                    Select Case e.Message(2)

                                        Case "+" ' PM+

                                            GaGroupeAddJoueur(Index, e.Message)

                                        Case "-" ' PM-

                                            GaGroupeDeleteJoueur(Index, e.Message)

                                        Case "~" ' PM~

                                            GaGroupeModifieInformation(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "P", e.Message)

                                    End Select

                                Case "R" ' PR

                                    GaGroupeRefuse(Index, e.Message)

                                Case "V" ' PV


                                    GaGroupeQuitte(Index, e.Message)

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "P", e.Message)

                            End Select

                        Case "p"

                            ErreurFichier(Index, NomDuPersonnage, "p", e.Message)

                        Case "Q"

                            ErreurFichier(Index, NomDuPersonnage, "Q", e.Message)

                        Case "q"

                            ErreurFichier(Index, NomDuPersonnage, "q", e.Message)

                        Case "R"

                            Select Case e.Message(1)

                                Case "p" ' Rp

                                    GaEncloMap(Index, e.Message)

                                Case "e" ' Re

                                    Select Case e.Message(2)

                                        Case "+" ' Re+

                                            FrmUser.DataGridViewDragodindeEquipé.Rows.Clear()

                                            GaDragodindeEncloEtableEquipé(Index, e.Message, FrmUser.DataGridViewDragodindeEquipé)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Re", e.Message)

                                    End Select

                                Case "x" ' Rx

                                    Select Case e.Message(2)

                                        Case "0" ' Rx0

                                            'Utilité Inconnu

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Rx", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "R", e.Message)

                            End Select

                        Case "r"

                            ErreurFichier(Index, NomDuPersonnage, "r", e.Message)

                        Case "S"

                            Select Case e.Message(1)

                                Case "L" ' SL

                                    Select Case e.Message(2).ToString

                                        Case "o" ' SLo

                                            Select Case e.Message(3)

                                                Case "+" ' SLo+

                                                    'Inconnu
                                                    ' SLo+

                                                Case "-"

                                                    FrmUser.DataGridViewSort.Rows.Clear()

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "SLo", e.Message)

                                            End Select

                                        Case > 0

                                            GaSortActuel(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "SL", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "S", e.Message)

                            End Select

                        Case "s"

                            Select Case e.Message(1)

                                Case "L" ' sL

                                    Select Case e.Message(2)

                                        Case "+" ' sL+

                                            GaMesCoffres(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "sL", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "s", e.Message)

                            End Select

                        Case "T"

                            Select Case e.Message(1)

                                Case "T" ' TT

                                    Select Case e.Message(2).ToString

                                        Case > 0 ' TT32

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "TT", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "T", e.Message)

                            End Select

                        Case "t"

                            ErreurFichier(Index, NomDuPersonnage, "t", e.Message)

                        Case "U"

                            ErreurFichier(Index, NomDuPersonnage, "U", e.Message)

                        Case "u"

                            ErreurFichier(Index, NomDuPersonnage, "u", e.Message)

                        Case "V"

                            ErreurFichier(Index, NomDuPersonnage, "V", e.Message)

                        Case "v"

                            ErreurFichier(Index, NomDuPersonnage, "v", e.Message)

                        Case "W"

                            ErreurFichier(Index, NomDuPersonnage, "W", e.Message)

                        Case "w"

                            ErreurFichier(Index, NomDuPersonnage, "w", e.Message)

                        Case "X"

                            ErreurFichier(Index, NomDuPersonnage, "X", e.Message)

                        Case "x"

                            ErreurFichier(Index, NomDuPersonnage, "x", e.Message)

                        Case "Y"

                            ErreurFichier(Index, NomDuPersonnage, "Y", e.Message)

                        Case "y"

                            ErreurFichier(Index, NomDuPersonnage, "y", e.Message)

                        Case "Z"

                            Select Case e.Message(1)

                                Case "C" ' ZC

                                    Select Case e.Message(2)

                                        Case "0" ' ZC0

                                            Alignement = "Neutre"

                                        Case "1" ' ZC1

                                            Alignement = "Bontarien"

                                        Case "2" ' ZC2

                                            Alignement = "Brakmarien"

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "ZC", e.Message)

                                    End Select

                                Case "S" ' ZS

                                    Select Case e.Message(2)

                                        Case "0" ' ZS0

                                            'Inconnu

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "ZS", e.Message)

                                    End Select

                                Case Else

                                    ErreurFichier(Index, NomDuPersonnage, "Z", e.Message)

                            End Select

                        Case "z"

                            ErreurFichier(Index, NomDuPersonnage, "z", e.Message)

                        Case Else

                            ErreurFichier(Index, NomDuPersonnage, "Unknow", e.Message)

                    End Select


                End If

            Catch ex As Exception

                ErreurFichier(Index, NomDuPersonnage, "Unknow", e.Message)

            End Try

        End If

    End Sub


#End Region

End Class
