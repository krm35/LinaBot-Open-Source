
Imports System.Windows.Media.Animation

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
        EnRecolte = False
        EnCombat = False

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


                                Case "g" 'Ag

                                    Select Case e.Message(2)

                                        Case " " ' Ag 

                                            Select Case e.Message(3)

                                                Case "1" ' Ag 1

                                                    'Ag1|1234567  |Pousse+de+Tanfouguite|L%27existence+de+cette+plante+est+aussi+myst%C3%A9rieuse+et+improbable+que+son+nom.+A+la+fois+ici+et+ici%2C+mais+pas+maintenant%2C+heureusement+qu%27elle+n%27est+pas+ailleurs%2C+on+n%27y+comprendrait+plus+rien.+Amenez-la+au+temple+Xelor+d%27Amakna+%28coordonn%C3%A9es+3%2C1%29+%2C+seuls+des+illumin%C3%A9s+comme+eux+peuvent+tenter+d%27y+comprendre+quelque+chose.||13ce1     ~ 2596     ~ 1        ~   ~ 3d7#258#1#64    ; 
                                                    'Ag1|ID Unique| Nom Item            |Description                                                                                                                                                                                                                                                                                                                                                               ||ID_Unique ~ ID Objet ~ Quantité ~ ? ~ Caractéristique ;? (id_unique à la fin indique le contenue visible quand on voit les personnages et qu'on atribut les cadeaux)

                                                    Dim Separation() As String = Split(e.Message, "|")

                                                    'Créer le sub pour ajouter le contenue à un personnage.

                                                    'Je remplace les "+" par des espaces.
                                                    EcritureMessage(Index, "(Dofus)", "Contenue : " & Separation(2).Replace("+", " ") & ". Description : " & AsciiDecoder(Separation(3).Replace("+", " ")), Color.Green)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ag ", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ag", e.Message)

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

                                Case "m", "M" ' Am

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

                                Case "S"

                                    Select Case e.Message(2)

                                        Case "4" 'BS4

                                            Socket.Envoyer("cS" & IdUnique & "|" & Mid(e.Message, 3, 1))

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "BS", e.Message)

                                    End Select

                                Case "T" ' BT

                                    ' Inconnu
                                    ' BT1584274548177

                                Case "X" ' BX

                                    Select Case e.Message(2)

                                        Case ";" ' BX;

                                            Select Case e.Message(3)

                                                Case "1" ' BX;1

                                                    Select Case e.Message(4)

                                                        Case ";" ' BX;1;

                                                            'BX;1;-1;aeDdfh

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "BX;1", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BX;", e.Message)

                                            End Select


                                        Case "|" ' BX|

                                            Select Case e.Message(3)

                                                Case "+" 'BX|+Cellule;?;?;ID_Joueur;Nom_Personnage;Level;Classe;?;?,?,?,ID_Autre_Joueur;Couleur1;Couleur2;Couleur3;Cac,Coiffe,Cape,Familier,?;?;?;?;?;?;?;?;

                                                Case "-" 'BX|-ID_Joueur

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BX|", e.Message)

                                            End Select

                                        Case "0" ' BX0

                                            Select Case e.Message(3)

                                                Case ";"

                                                    Select Case e.Message(4)

                                                        Case "5"

                                                            Select Case e.Message(5)
                                                                Case "0"
                                                                    Select Case e.Message(6)
                                                                        Case "1"
                                                                            Select Case e.Message(7)
                                                                                Case ";"
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "BX0;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "BX0;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "BX0;5", e.Message)
                                                            End Select

                                                        Case "1"

                                                            Select Case e.Message(5)

                                                                Case ";"

                                                                    'BX0;1;ID_Joueur;Path
                                                                    Socket.Envoyer("BZ" & IdUnique)

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "BX0;1", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "BX0;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BX0", e.Message)

                                            End Select

                                        Case "1"

                                            Select Case e.Message(3)

                                                Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"

                                                    'BX1 ID_Joueur
                                                    Socket.Envoyer("BZ" & IdUnique)

                                                Case ";"

                                                    Select Case e.Message(4)
                                                        Case "5"
                                                            Select Case e.Message(5)
                                                                Case "0"
                                                                    Select Case e.Message(6)
                                                                        Case "1"
                                                                            Select Case e.Message(7)
                                                                                Case ";"
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "BX1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "BX1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "BX1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "BX1;", e.Message)
                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BX1", e.Message)

                                            End Select

                                        Case "F" ' BXF

                                            Select Case e.Message(3)

                                                Case "|" ' BXF|

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BXF", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "BX", e.Message)

                                    End Select

                                Case "Z" ' BZ

                                    Select Case e.Message(2)

                                        Case ";" ' BZ;

                                            Select Case e.Message(3)

                                                Case "1" ' BZ;1

                                                    Select Case e.Message(4)

                                                        Case ";" ' BZ;1;

                                                            'BZ;1;-1;aeDdfh

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "BZ;1", e.Message)

                                                    End Select

                                                Case "9" 'BZ;903;ID_Joueur;t

                                                    Socket.Envoyer("BZ" & Split(e.Message, ";")(2))

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BZ;", e.Message)

                                            End Select

                                        Case "|"

                                            Select Case e.Message(3)

                                                Case "+" 'BZ|+Cellule;?;?;ID_Joueur;Nom_Personnage;Level;Classe;?;?,?,?,ID_Autre_Joueur;Couleur1;Couleur2;Couleur3;Cac,Coiffe,Cape,Familier,?;?;?;?;?;?;?;?;

                                                Case "-" 'BZ|-ID_Joueur

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BZ|", e.Message)

                                            End Select

                                        Case "0" 'BZ0;1;ID_Joueur;Path

                                            Select Case Mid(e.Message, 4, 1)

                                                Case ";" 'IA0;1;ID_Joueur;Path 

                                                    Socket.Envoyer("BZ" & Split(e.Message, ";")(2))

                                                Case "1" 'BZ0188;Nom_Personnage

                                                    Socket.Envoyer("BZ" & IdUnique)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BZ0", e.Message)

                                            End Select

                                        Case "1"

                                            Select Case e.Message(3)
                                                Case ";"
                                                    Select Case e.Message(4)
                                                        Case "5"
                                                            Select Case e.Message(5)
                                                                Case "0"
                                                                    Select Case e.Message(6)
                                                                        Case "1"
                                                                            Select Case e.Message(7)
                                                                                Case ";"
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "BZ1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "BZ1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "BZ1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "BZ1;", e.Message)
                                                    End Select
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "BZ1", e.Message)
                                            End Select

                                        Case "E" ' BZE

                                            Select Case e.Message(3)

                                                Case "|" ' BZE|

                                                    'BZE|418;3;0

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BZE", e.Message)

                                            End Select

                                        Case "F" ' BZF

                                            Select Case e.Message(3)

                                                Case "|" ' BZF|

                                                    'BZF|418;3;0

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "BZF", e.Message)

                                            End Select

                                        Case "K" 'BZK|1|Nom_Personnage

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "BZ", e.Message)

                                    End Select

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

                                Case "A" ' EA

                                    If EnCraft Then

                                        EcritureMessage(Index, "[Craft]", "Craft Restant : " & Mid(e.Message, 3), Color.Orange)

                                    End If

                                Case "a" ' Ea

                                    Select Case Mid(e.Message, 3)

                                        Case "1" ' Ea1

                                            EcritureMessage(Index, "[Craft]", "Tous les objets ont été fabriqués !", Color.YellowGreen)

                                        Case "2" ' Ea2

                                            EcritureMessage(Index, "[Craft]", "La fabrication d'objets a été interrompue.", Color.Red)

                                        Case "4" ' Ea4

                                            EcritureMessage(Index, "[Craft]", "Votre recette ne donnait rien, la fabrication d'objets a été interrompue.", Color.Red)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ea", e.Message)

                                    End Select

                                Case "b" ' Eb

                                    Select Case e.Message(2)

                                        Case "|"

                                            Select Case e.Message(3)

                                                Case "+" 'Eb|+Cellule;?;?;ID_Joueur;Nom_Personnage;Level;Classe;?;?,?,?,ID_Autre_Joueur;Couleur1;Couleur2;Couleur3;Cac,Coiffe,Cape,Familier,?;?;?;?;?;?;?;?;

                                                Case "-" 'Eb|-ID_Joueur

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Eb|", e.Message)

                                            End Select

                                        Case ";" ' Eb;

                                            Select Case e.Message(3)

                                                Case "1" ' Eb;1

                                                    Select Case e.Message(4)

                                                        Case ";" ' Eb;1;

                                                            'Eb;1;-1;aftbga

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Eb;1", e.Message)

                                                    End Select

                                                Case "2" ' Eb;2

                                                    Select Case e.Message(4)

                                                        Case ";" ' Eb;2;

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Eb;2", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Eb;", e.Message)

                                            End Select

                                        Case "0" ' Eb0

                                            Select Case e.Message(3)

                                                Case ";" ' Eb0;

                                                    Select Case e.Message(4)

                                                        Case "1" ' Eb0;1

                                                            Select Case e.Message(5)

                                                                Case ";" ' Eb0;1;

                                                                    Socket.Envoyer("Eb" & CInt(Split(e.Message, ";")(2)) - 352)

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Eb0;1", e.Message)

                                                            End Select

                                                        Case "5" ' Eb0;5

                                                            Select Case e.Message(5)
                                                                Case "0" ' Eb0;50
                                                                    Select Case e.Message(6)
                                                                        Case "1" ' Eb0;501
                                                                            Select Case e.Message(7)
                                                                                Case ";" ' Eb0;501;
                                                                                    'Eb0;501;1234567;88,11900
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "Eb0;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "Eb0;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "Eb0;5", e.Message)
                                                            End Select

                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "Eb0;", e.Message)
                                                    End Select

                                                Case "1" ' Eb01

                                                    'Eb0188;Nom_Personnage
                                                    Socket.Envoyer("Eb" & IdUnique)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Eb0", e.Message)

                                            End Select

                                        Case "1" ' Eb1

                                            Select Case e.Message(3)

                                                Case ";"
                                                    Select Case e.Message(4)
                                                        Case "5"
                                                            Select Case e.Message(5)
                                                                Case "0"
                                                                    Select Case e.Message(6)
                                                                        Case "1"
                                                                            Select Case e.Message(7)
                                                                                Case ";"
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "Eb1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "Eb1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "Eb1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "Eb1;", e.Message)
                                                    End Select
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Eb1", e.Message)
                                            End Select

                                        Case "6" ' Eb6

                                            Select Case e.Message(3)

                                                Case "5" ' Eb65

                                                    Select Case e.Message(4)

                                                        Case "0" ' Eb650

                                                            Select Case e.Message(5)

                                                                Case "|" ' Eb650|

                                                                    'Eb650|6|11

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Eb650", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Eb65", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Eb6", e.Message)

                                            End Select

                                        Case "7"

                                            Select Case e.Message(3)

                                                Case "4"

                                                    'Eb74|Spilonzy;0;Asobo;8,9zldr,e,9ws8w

                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Eb1", e.Message)
                                            End Select

                                        Case "F" ' EbF

                                            Select Case e.Message(3)
                                                Case "|" ' EbF|
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "EbF", e.Message)
                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Eb", e.Message)

                                    End Select

                                Case "C" 'faire les eck3 ETC.... pour la fm etc....

                                    Select Case e.Message(2)

                                        Case "K" ' ECK

                                            Select Case e.Message(3)

                                                Case "0" ' ECK0

                                                    'ECK0|-1

                                                    PnjAcheterVendre = True
                                                    BloqueDialogue.Set()

                                                Case "1" ' ECK1

                                                    EcritureMessage(Index, "(Bot)", "Vous êtes en échange.", Color.Green)

                                                    EnDemandeEchange = False
                                                    EnEchange = True

                                                    BloqueEchange.Set()

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

                                                Case "I"

                                                    EcritureMessage(Index, "[Craft]", "Cette recette ne donne rien !", Color.Red)
                                                    Socket.Envoyer("EMr")

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

                                Case "e" ' Ee

                                    Select Case e.Message(2)

                                        Case "+" ' Ee+

                                         '   Dragodinde_Information_All(Mon_ID, e.Message, "Etable")

                                        Case "-" ' Ee-

                                                   ' Dragodinde_Retire(Mon_ID, Mid(e.Message, 4))

                                        Case "~" ' Ee~

                                           ' Dragodinde_Information_All(Mon_ID, e.Message, "Etable")

                                        Case "E" ' EeE

                                            EcritureMessage(Index, "[Dragodinde]", "Impossible de déposer la monture en etable", Color.Red)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ee", e.Message)

                                    End Select

                                Case "f"

                                    Select Case e.Message(2)

                                        Case "+"

                                         '   Dragodinde_Information_All(Mon_ID, e.Message, "Enclo")

                                        Case "-"

                                            ' Dragodinde_Retire(Mon_ID, Mid(e.Message, 4))

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ef", e.Message)

                                    End Select

                                Case "H"

                                    Select Case e.Message(2)

                                        Case "l" 'EHlID_Objet|ID_Unique;Caractéristique;Prix*1;Prix*10;Prix*100|Next Item

                                          '  HDV_Information_Item_Achat(Mon_ID, Split(Mid(e.Message, 4), "|"))

                                        Case "L" 'EHL26|ID_Objet;ID_Objet;ID_Objet;ID_Objet; etc... 

                                         '   HDV_Information_Catégorie(Mon_ID, Split(Split(e.Message, "|")(1), ";"))

                                        Case "P" 'EHPID_Objet|Prix Moyen 

                                          '  Separation = Split(e.Message, "|")

                                         '   EcritureMessage(Mon_ID, "[Hôtel de vente]", "Item actuellement sélectionné : " & Liste_Des_Objets(Mid(Separation(0), 4)).GetValue(1), Color.Green)
                                         '   EcritureMessage(Mon_ID, "[Hôtel de vente]", "Prix moyen constaté dans cet hôtel : " & Separation(1) & " kamas/u.", Color.Green)
                                         '   HDV_Prix_Moyen = Separation(1)

                                         '   Bloque_Thread.Set()

                                        Case "m"

                                            Select Case e.Message(3)

                                                Case "+" 'EHm+207814|304||25|497|1400

                                                  '  Ajoute_Item(Mon_ID, Split(e.Message, "|"), "[HDV - Achat]")

                                                Case "-" 'EHm-207814

                                                    '   Item_Supprime(Mon_ID, Mid(e.Message, 5))

                                                Case Else

                                                    '   Information_Inconnu(Mon_ID, "Unknow", e.Message)

                                            End Select

                                        Case "M" 'EHM-2588

                                        Case "S"

                                            Select Case e.Message(3)

                                                Case "E" 'EHSE

                                                    'TabUtilisateur.ListView_Hotel_De_Vente.Items.Clear()
                                                    ' Bloque_Thread.Set()
                                                  '  EcritureMessage(Mon_ID, "[Hotel de vente]", "L'objet recherché n'est pas en vente dans cet hôtel des ventes.", Color.Red)

                                                Case "K" 'EHSK  y'a l'objet voulu

                                                Case Else

                                                    ' Information_Inconnu(Mon_ID, "Unknow", e.Message)

                                            End Select

                                        Case Else

                                            '   Information_Inconnu(Mon_ID, "Unknow", e.Message)

                                    End Select

                                Case "K" ' EK

                                    Select Case e.Message(2)

                                        Case "0" ' EK0

                                            GaEchangeInvalider(Index, e.Message)

                                        Case "1" ' EK1

                                            GaEchangeValider(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "EK", e.Message)

                                    End Select

                                Case "k" ' Ek

                                    Select Case e.Message(2)

                                        Case "|"

                                            Select Case Mid(e.Message, 4, 1)

                                                Case "+" 'Ek|+132;1;0;ID_Joueur;Linaculer;9;91^100;1;0,0,0,ID_Joueur;-1;-1;-1;551,3d0,3b9,,;0;;;;;0;;

                                                Case "-" 'Ek|-ID_Joueur

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ek|", e.Message)

                                            End Select

                                        Case "0" 'Ek0;1;ID_Joueur;aaKbbrcdIde2

                                            Select Case Mid(e.Message, 4, 1)

                                                Case ";" 'Ek0;1;ID_Joueur;aaKbbrcdIde2

                                                    Socket.Envoyer("Ek" & CInt(Split(e.Message, ";")(2)) * 2)

                                                Case "1" 'Ek0188;Linaculer

                                                    Socket.Envoyer("Ek" & IdUnique)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ek0", e.Message)

                                            End Select

                                        Case "1" ' Ek1

                                            Select Case e.Message(3)
                                                Case ";" ' Ek1;
                                                    Select Case e.Message(4)
                                                        Case "5" ' Ek1;5
                                                            Select Case e.Message(5)
                                                                Case "0" ' Ek1;50
                                                                    Select Case e.Message(6)
                                                                        Case "1" ' Ek1;501
                                                                            Select Case e.Message(7)
                                                                                Case ";" ' Ek1;501;
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "Ek1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "Ek1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "Ek1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "Ek1;", e.Message)
                                                    End Select
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Ek1", e.Message)
                                            End Select

                                        Case "6"

                                            Socket.Envoyer("Ek" & IdUnique)

                                        Case "F" ' EkF

                                            Select Case e.Message(3)
                                                Case "|" ' EkF|
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "EkF", e.Message)
                                            End Select

                                        Case "M" ' EkM

                                            Select Case e.Message(3)

                                                Case "|" ' EkM|

                                                    'EkM|-1;0;40;6;2;108;;40|1234567;0;141;6;3;365;;151

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EkM", e.Message)

                                            End Select

                                        Case "R" 'EkRID_Joueur

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ek", e.Message)

                                    End Select

                                Case "L" ' EL

                                    If e.Message <> "EL" Then

                                        Select Case e.Message(2)

                                            Case "O" ' ELO 

                                                If EnBanque Then

                                                    FrmUser.DataGridViewLui.Rows.Clear()

                                                    GaItemsAjoute(Index, e.Message.Replace("EL", "").Replace("O", ""), FrmUser.DataGridViewLui)

                                                End If

                                            Case Else

                                                If PnjAcheterVendre Then

                                                    FrmUser.DataGridViewLui.Rows.Clear()

                                                    GaPnjAcheterVendre(Index, e.Message)

                                                Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EL", e.Message)

                                                End If

                                        End Select

                                    Else

                                        If EnBanque Then

                                            FrmUser.DataGridViewLui.Rows.Clear()

                                            GaItemsAjoute(Index, e.Message.Replace("EL", "").Replace("O", ""), FrmUser.DataGridViewLui)

                                        End If

                                    End If

                                Case "M" ' EM

                                    Select Case e.Message(2)

                                        Case "K" ' EMK

                                            Select Case e.Message(3)

                                                Case "G" ' EMKG

                                                    GaEchangeKamasPoserMoi(Index, e.Message)

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

                                                Case "G" ' EmKG

                                                    GaEchangeKamasPoserLui(Index, e.Message)

                                                Case "O" ' EmKO

                                                    Select Case e.Message(4)

                                                        Case "+" ' EmKO+

                                                            GaItemsAjouteLui(Index, e.Message, FrmUser.DataGridViewLui)

                                                        Case "-" ' EmKO-

                                                            GaItemsSupprimeLui(Index, e.Message, FrmUser.DataGridViewLui)

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "EmKO", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "E", e.Message)

                                    End Select

                                Case "R" ' ER

                                    Select Case e.Message(2)

                                        Case "K" ' ERK

                                            GaEchangeDemandeRecu(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "ER", e.Message)

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

                                        ElseIf EnDemandeEchange OrElse EnEchange Then

                                            If EnEchange Then

                                                EcritureMessage(Index, "[Dofus]", "Echange annulé.", Color.Green)

                                            End If

                                            EnDemandeEchange = False
                                            EnEchange = False
                                            EchangeIdNomLanceur(0) = ""
                                            EchangeIdNomLanceur(1) = ""
                                            FrmUser.DataGridViewLui.Rows.Clear()
                                            FrmUser.DataGridViewMoi.Rows.Clear()
                                            BloqueEchange.Set()

                                        ElseIf PnjAcheterVendre Then

                                            PnjAcheterVendre = False
                                            FrmUser.DataGridViewLui.Rows.Clear()
                                            BloqueDialogue.Set()

                                        End If

                                    Else

                                        If e.Message = "EVa" Then

                                            If EnEchange Then

                                                EcritureMessage(Index, "[Dofus]", "Echange effectué.", Color.Green)

                                                EnDemandeEchange = False
                                                EnEchange = False
                                                EchangeIdNomLanceur(0) = ""
                                                EchangeIdNomLanceur(1) = ""
                                                FrmUser.DataGridViewLui.Rows.Clear()
                                                FrmUser.DataGridViewMoi.Rows.Clear()
                                                BloqueEchange.Set()

                                            End If

                                        Else

                                            ErreurFichier(Index, NomDuPersonnage, "EV", e.Message)

                                        End If

                                    End If

                                Case "v" ' Ev

                                    Select Case e.Message(2)

                                        Case "|"

                                            Select Case e.Message(3)

                                                Case "+" 'Ev|+132;1;0;ID_Joueur;Linaculer;9;91^100;1;0,0,0,ID_Joueur;-1;-1;-1;551,3d0,3b9,,;0;;;;;0;;

                                                Case "-" 'Ev|-ID_Joueur

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ev|", e.Message)

                                            End Select

                                        Case ";" 'Ev;1;-2;aeJfeu 

                                            Socket.Envoyer("Ev" & IdUnique)

                                        Case "0" ' Ev0

                                            Socket.Envoyer("Ev" & (IdUnique + 1))

                                        Case "1" ' Ev1

                                            Select Case e.Message(3)

                                                Case ";" 'Ev1;

                                                    Select Case e.Message(4)

                                                        Case "5" ' Ev1;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' Ev1;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' Ev1;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' Ev1;501;

                                                                                    'Ev1;501;1234567;328,9900

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "Ev1;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "Ev1;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Ev1;5", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Ev1;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ev1", e.Message)

                                            End Select

                                        Case "6" ' Ev6

                                            Select Case e.Message(3)

                                                Case "5" ' Ev65

                                                    Select Case e.Message(4)

                                                        Case "0" ' Ev650

                                                            Select Case e.Message(5)

                                                                Case "|" ' Ev650|

                                                                    'Ev650|6|12

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Ev650", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Ev65", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ev6", e.Message)

                                            End Select

                                        Case "F" ' EvF

                                            Select Case e.Message(3)

                                                Case "|" ' EvF|

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EvF", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ev", e.Message)

                                    End Select

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

                                                        Case "0" ' GA;10

                                                            Select Case e.Message(5)

                                                                Case "0" ' GA;100

                                                                    Select Case Mid(e.Message, 7, 1)

                                                                        Case ";" ' GA;100;

                                                                            GfRetirePdv(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;100", e.Message)

                                                                    End Select

                                                                Case "2" ' GA;102

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' GA;102;

                                                                            GaCombatPaUtilisé(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;102", e.Message)

                                                                    End Select

                                                                Case "3" ' GA;103

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' GA;103;

                                                                            GaMortJoueurMobs(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;103", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA;10", e.Message)

                                                            End Select

                                                        Case "2" ' GA;12

                                                            Select Case e.Message(5)

                                                                Case "9" ' GA;129

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' GA;129;

                                                                            GaCombatPmUtilisé(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;129", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA;12", e.Message)

                                                            End Select

                                                        Case "3" ' GA,13

                                                            Select Case e.Message(5)

                                                                Case "2" ' GA,132

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' GA,132;

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;132", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA;13", e.Message)

                                                            End Select

                                                        Case ";" ' GA;1;

                                                            GaMapMoveEntity(Index, e.Message)

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GA;1", e.Message)

                                                    End Select

                                                Case "2" 'GA;2;1234567;

                                                    'Inconnu


                                                Case "3" ' GA;3

                                                    Select Case e.Message(4)

                                                        Case "0" ' GA;30

                                                            Select Case e.Message(5)

                                                                Case "0" ' GA;300

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' GA;300;

                                                                            GaCombatCoupNormal(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;300", e.Message)

                                                                    End Select

                                                                Case "1" ' GA;301

                                                                    Select Case Mid(e.Message, 7, 1)

                                                                        Case ";" ' GA;301;

                                                                            ' GaCombatCoupCritique(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;301", e.Message)

                                                                    End Select

                                                                Case "2" ' GA;302

                                                                    Select Case Mid(e.Message, 7, 1)

                                                                        Case ";" ' GA;302;

                                                                            ' GaCombatEchecCritique(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;302", e.Message)

                                                                    End Select

                                                                Case "8" ' GA;308

                                                                    Select Case Mid(e.Message, 7, 1)

                                                                        Case ";" ' GA;308;

                                                                            ' GaCombatPaEsquivé(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;308", e.Message)

                                                                    End Select

                                                                Case "9" ' GA;309

                                                                    Select Case Mid(e.Message, 7, 1)

                                                                        Case ";" ' GA;309;

                                                                            ' GaCombatPmEsquivé(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;309", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA;30", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GA;3", e.Message)

                                                    End Select

                                                Case "9" ' GA;9

                                                    Select Case e.Message(4)

                                                        Case "0" ' GA;90

                                                            Select Case e.Message(5)

                                                                Case "5" ' GA;905

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' GA;905;

                                                                            GaLanceurEntrerCombat(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;905", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA;90", e.Message)

                                                            End Select

                                                        Case "5" ' GA;95

                                                            Select Case e.Message(5)

                                                                Case "0" ' GA;950

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' GA;950;

                                                                            CombatEtat(Index, e.Message)

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GA;950", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GA;95", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GA;9", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GA;", e.Message)

                                            End Select

                                        Case "F" ' GAF

                                            Select Case e.Message(3)

                                                Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" ' GAF 0123456789

                                                    Task.Run(Sub() GaCombatAction(Index, e.Message))

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GA", e.Message)

                                            End Select

                                        Case "S" ' GAS

                                            'GAS 1234567
                                            'GAS id unique
                                            ' ?

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GA", e.Message)

                                    End Select

                                Case "a" ' Ga

                                    Select Case e.Message(2)

                                        Case "0" ' Ga0

                                            Select Case e.Message(3)

                                                Case ";" ' Ga0;

                                                    Select Case e.Message(4)

                                                        Case "5" ' Ga0;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' Ga0;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' Ga0;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' Ga0;501;

                                                                                    'Ga0;501;01234567;378,9400

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "Ga0;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "Ga0;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Ga0;5", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Ga0;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ga0", e.Message)

                                            End Select

                                        Case ";" ' Ga;

                                            Select Case e.Message(3)

                                                Case "1" ' Ga;1

                                                    Select Case e.Message(4)

                                                        Case ";" ' Ga;1;

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Ga;1", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ga;", e.Message)

                                            End Select

                                        Case "F" ' GaF

                                            Select Case e.Message(3)
                                                Case "|" ' GaF|
                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GaF", e.Message)
                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ga", e.Message)

                                    End Select

                                Case "B" ' GB

                                    Select Case e.Message(2)

                                        Case "|" ' GB|

                                            Select Case e.Message(3)
                                                Case "+" ' GB|+
                                                Case "-" ' GB|-
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "GB|", e.Message)
                                            End Select

                                        Case ";" ' GB;

                                            Select Case e.Message(3)
                                                Case "1" ' GB;1
                                                    Select Case e.Message(4)
                                                        Case ";" ' GB;1;
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "GB;1", e.Message)
                                                    End Select

                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "GB;", e.Message)
                                            End Select

                                        Case "0" ' GB0

                                            Select Case e.Message(3)

                                                Case ";" ' GB0;

                                                    Select Case e.Message(4)

                                                        Case "1" ' GB0;1

                                                            Select Case e.Message(5)

                                                                Case ";" ' GB0;1;

                                                                    'GB0;1;-1;afGdf8

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GB0;1", e.Message)

                                                            End Select

                                                        Case "5" ' GB0;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' GB0;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' GB0;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' GB0;501;

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "GB0;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "GB0;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "GB0;5", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "GB0;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GB0", e.Message)

                                            End Select

                                        Case "1" ' GB1

                                            Select Case e.Message(3)
                                                Case ";" ' GB1;
                                                    Select Case e.Message(4)
                                                        Case "5" ' GB1;5
                                                            Select Case e.Message(5)
                                                                Case "0" ' GB1;50
                                                                    Select Case e.Message(6)
                                                                        Case "1" ' GB1;501
                                                                            Select Case e.Message(7)
                                                                                Case ";" ' GB1;501;
                                                                                    'GB1;501;1234567;328,11900
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "GB1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "GB1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "GB1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "GB1;", e.Message)
                                                    End Select
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "GB1", e.Message)
                                            End Select

                                        Case "F" ' GBF

                                            Select Case e.Message(3)

                                                Case "|" ' GBF|

                                                    'GBF|418;3;0

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GBF", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GB", e.Message)

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

                                Case "c" ' Gc

                                    Select Case e.Message(2)

                                        Case "+" ' Gc+

                                            GaAjouteCombatMap(Index, e.Message)

                                        Case "-" ' Gc-

                                            GaSupprimeCombatMap(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Gc", e.Message)

                                    End Select

                                Case "D" ' GD

                                    If e.Message = "GD" Then

                                        Socket.Envoyer("GD" & IdUnique)

                                    Else

                                        Select Case e.Message(2)

                                            Case "C" ' GDC

                                                ' GDC272;aaaaaaaaaa801;0| = ?

                                            Case "E" ' GDE

                                                Select Case e.Message(3)

                                                    Case "|" ' GDE|

                                                        'GDE|237;2

                                                    Case Else

                                                        ErreurFichier(Index, NomDuPersonnage, "GDE", e.Message)

                                                End Select

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

                                Case "d" ' Gd

                                    Select Case e.Message(2)

                                        Case "K" ' GdK

                                            Select Case e.Message(3)

                                                Case "O" ' GdKO

                                                    GaCombatChallengeRaté(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GdK", e.Message)

                                            End Select

                                        Case "O" ' GdO

                                            Select Case e.Message(3)

                                                Case "K" ' GdOK

                                                    GaCombatChallengeRéussi(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GdO", e.Message)

                                            End Select

                                        Case "2" ' Gd2

                                            GaCombatChallengeReçu(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Gd", e.Message)

                                    End Select

                                Case "E" ' GE

                                    GaCombatFin(Index, e.Message)

                                Case "I" ' GI

                                    Select Case e.Message(2)

                                        Case "C"

                                            Select Case e.Message(3)

                                                Case "|"

                                                    CombatChangePlacement(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GIC", e.Message)

                                            End Select

                                        Case "E" ' GIE

                                            GaCombatBooste(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GI", e.Message)

                                    End Select

                                Case "J" ' GJ

                                    Select Case e.Message(2)

                                        Case "K" ' GJK

                                            Select Case e.Message(3)

                                                Case "2" ' GJK2

                                                    GaTempsPreparation(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GJK", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GJ", e.Message)

                                    End Select

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

                                Case "o" ' Go

                                    Select Case e.Message(2)

                                        Case "+" ' Go+

                                            Select Case e.Message(3)

                                                Case "A", "H", "S", "P" ' Go+ A H S P

                                                    GaOptionCombat(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Go+", e.Message)

                                            End Select

                                        Case "-"

                                            Select Case e.Message(3)

                                                Case "A", "H", "S", "P" ' Go- A H S P

                                                    GaOptionCombat(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Go-", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Go", e.Message)

                                    End Select

                                Case "P" ' GP

                                    GaCellulePlacementEquipe(Index, e.Message)

                                Case "T" ' GT

                                    Select Case e.Message(2)

                                        Case "F"

                                        Case "L"

                                            Select Case e.Message(3)

                                                Case "|" ' GTL|

                                                    GaCombatOrdre(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GTL", e.Message)

                                            End Select

                                        Case "M" ' GTM

                                            Select Case e.Message(3)

                                                Case "|" ' GTM|

                                                    GaCombatInformationTour(Index, e.Message)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "GTM", e.Message)

                                            End Select

                                        Case "R"

                                            Socket.Envoyer("GT")

                                        Case "S" ' GTS

                                            GaCombatTourActuel(Index, e.Message)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "GT", e.Message)

                                    End Select

                                Case "t" ' Gt

                                    GaAjouteEntiterCombat(Index, e.Message)

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

                                Case "A" ' IA

                                    Select Case e.Message(2)

                                        Case "0" ' IA0

                                            Select Case e.Message(3)

                                                Case ";" ' IA0;

                                                    Select Case e.Message(4)

                                                        Case "1" ' IA0;1

                                                            Select Case e.Message(5)

                                                                Case ";" ' IA0;1;

                                                                    Socket.Envoyer("IA" & Split(e.Message, ";")(2))

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "IA0;1", e.Message)

                                                            End Select

                                                        Case "5" ' IA0;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' IA0;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' IA0;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' IA0;501;

                                                                                    'IA0;501;1234567;328,9900

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "IA0;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "IA0;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "IA0;5", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "IA0;", e.Message)

                                                    End Select

                                                Case "1" 'IA0188;Linaculer

                                                    Socket.Envoyer("IA" & IdUnique)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "IA0", e.Message)

                                            End Select

                                        Case "1" ' IA1

                                            Select Case e.Message(3)

                                                Case ";" ' IA1;

                                                    Select Case e.Message(4)
                                                        Case "5" ' IA1;5
                                                            Select Case e.Message(5)
                                                                Case "0" ' IA1;50
                                                                    Select Case e.Message(6)
                                                                        Case "1" ' IA1;501
                                                                            Select Case e.Message(7)
                                                                                Case ";" ' IA1;501;
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "IA1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "IA1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "IA1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "IA1;", e.Message)
                                                    End Select

                                                Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"

                                                    Socket.Envoyer("IA" & IdUnique)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "IA1", e.Message)

                                            End Select

                                        Case ";"

                                            Select Case Mid(e.Message, 4, 1)

                                                Case "1" 'IA;102;1234567;1234567,-3

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "IA;", e.Message)

                                            End Select

                                        Case "|" ' IA|

                                            Select Case e.Message(3)

                                                Case "+" ' IA|+

                                                    'IA|+36;1;0;1234567;Linaculer;9;90^100;0;0,0,0,12345687;497fa;fb000d;f7000d;241,9aa,9a9,,;0;;;;;0;;

                                                Case "-" ' IA|-

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "IA|", e.Message)

                                            End Select

                                        Case "E" ' IAE

                                            Select Case e.Message(3)

                                                Case "9" ' IAE9

                                                    Select Case e.Message(4)

                                                        Case "5" ' IAE95

                                                            Select Case e.Message(5)

                                                                Case ";" ' IAE95;

                                                                    'IAE95;1234567;1;;;;1;995

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "IAE95", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "IAE9", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "IAE", e.Message)

                                            End Select

                                        Case "F" ' IAF

                                            Select Case e.Message(3)

                                                Case "|" ' IAF|

                                                    'IAF|418;3;0

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "IAF", e.Message)

                                            End Select

                                        Case "S" ' IAS

                                            Socket.Envoyer("IA" & IdUnique)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "IA", e.Message)

                                    End Select

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

                                        Case "E" ' OAE

                                            Select Case e.Message(3)

                                                Case "F"

                                                    EcritureMessage(Index, "[Inventaire]", "Ton Inventaire est plein.", Color.Red)

                                                Case "A"

                                                    EcritureMessage(Index, "[Dofus]", "Déjà équipé !.", Color.Red)

                                                Case "L"

                                                    EcritureMessage(Index, "[Equipement]", "Ton niveau est trop faible pour equiper cet objet.", Color.Red)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "OAE", e.Message)

                                            End Select

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

                                Case "k" ' Ok

                                    Select Case e.Message(2)

                                        Case "F" ' OkF

                                            Select Case e.Message(3)
                                                Case "|" ' OkF|
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "OkF", e.Message)
                                            End Select

                                        Case "M" ' OkM

                                            Select Case e.Message(3)

                                                Case "|" ' OkM|

                                                    'OkM|-1;0;27;6;2;45;;39|01234567;0;144;5;3;19;;151

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "OkM", e.Message)

                                            End Select

                                        Case "S"

                                            Socket.Envoyer("Ok" & (IdUnique + 21))

                                        Case "0" ' Ok0

                                            Select Case e.Message(3)

                                                Case ";" ' Ok0;

                                                    Select Case e.Message(4)

                                                        Case "1" ' Ok0;1

                                                            Select Case e.Message(5)

                                                                Case ";" ' Ok0;1;

                                                                    Socket.Envoyer("Ok" & Split(e.Message, ";")(2))

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Ok0;1", e.Message)

                                                            End Select

                                                        Case "5" ' Ok0;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' Ok0;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' Ok0;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' Ok0;501;

                                                                                    'Ok0;501;1234567;239,11100

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "Ok0;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "Ok0;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Ok0;5", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Ok0;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ok0", e.Message)

                                            End Select

                                        Case "1"

                                            Select Case e.Message(3)
                                                Case ";"
                                                    Select Case e.Message(4)
                                                        Case "5"
                                                            Select Case e.Message(5)
                                                                Case "0"
                                                                    Select Case e.Message(6)
                                                                        Case "1"
                                                                            Select Case e.Message(7)
                                                                                Case ";"
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "Ok1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "Ok1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "Ok1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "Ok1;", e.Message)
                                                    End Select
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Ok1", e.Message)
                                            End Select

                                        Case "|"

                                            Select Case e.Message(3)

                                                Case "+" 'Ok|+48;1;0;ID_Joueur;Linaculer;9;90^100;0;0,0,0,ID_Joueur;-1;-1;-1;1b0c,3d0,3b9,1e17,;0;;;;;0;;

                                                Case "-"

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Ok|", e.Message)

                                            End Select

                                        Case ";" 'Ok;1;-2;aeJdeX 

                                            Socket.Envoyer("Ok" & IdUnique)

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Ok", e.Message)

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

                                Case "a" ' Pa

                                    Select Case e.Message(2)

                                        Case ";" ' Pa;

                                            Select Case e.Message(3)

                                                Case "1" ' Pa;1

                                                    Select Case e.Message(4)

                                                        Case ";" ' Pa;1;

                                                        Case "0" ' Pa;10

                                                            Select Case e.Message(5)

                                                                Case "2" ' Pa;102

                                                                    Select Case e.Message(6)

                                                                        Case ";" ' Pa;102;

                                                                            'Pa;102;-1;-1,-1

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "Pa;102", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Pa;10", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Pa;1", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Pa;", e.Message)

                                            End Select

                                        Case "|"

                                            Select Case e.Message(3)

                                                Case "+" 'Pa|+306;1;0;ID_Joueur;Linaculer;9;91^100;1;0,0,0,ID_Joueur;-1;-1;-1;1b0c,3d0,3b9,,;0;;;;;0;;

                                                Case "-" 'Pa|-ID_Joueur

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Pa|", e.Message)

                                            End Select

                                        Case "0"

                                            Select Case e.Message(3)

                                                Case ";" 'Sl0;1;ID_Joueur;ab8bcl

                                                    Socket.Envoyer("Pa" & Split(e.Message, ";")(2))

                                                Case "1" 'Pa0188;Linaculer

                                                    Socket.Envoyer("Pa" & IdUnique)

                                            End Select

                                        Case "1" ' Pa1

                                            Select Case e.Message(3)
                                                Case ";" ' Pa1;
                                                    Select Case e.Message(4)
                                                        Case "5" ' Pa1;5
                                                            Select Case e.Message(5)
                                                                Case "0" ' Pa1;50
                                                                    Select Case e.Message(6)
                                                                        Case "1" ' Pa1;501
                                                                            Select Case e.Message(7)
                                                                                Case ";" ' Pa1;501;
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "Pa1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "Pa1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "Pa1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "Pa1;", e.Message)
                                                    End Select
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Pa1", e.Message)
                                            End Select

                                        Case "F" ' PaF

                                            Select Case e.Message(3)

                                                Case "|" ' PaF|

                                                    'PaF|351;3;0

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "PaF", e.Message)

                                            End Select

                                        Case "M" ' PaM

                                            Select Case e.Message(3)

                                                Case "|" ' PaM|

                                                    'PaM|-1;0;40;6;2;108;;40|1234567;0;141;6;3;365;;151

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "EkM", e.Message)

                                            End Select

                                        Case "S" 'PaSID_Joueur|29000 

                                            Socket.Envoyer("Pa" & (IdUnique + 126)) 'ou 124 ou choix

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Pa", e.Message)

                                    End Select

                                Case "B" ' PB

                                    Select Case e.Message(2)

                                        Case "|" ' PB|

                                            Select Case e.Message(3)
                                                Case "+" ' PB|+
                                                Case "-" ' PB|-
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "PB|", e.Message)
                                            End Select

                                        Case ";" 'PB;1;-1;adRhdD 

                                            Socket.Envoyer("PB" & (IdUnique + 12)) 'ou 10

                                        Case "0" ' PB0

                                            Select Case e.Message(3)

                                                Case ";" ' PB0;

                                                    Select Case e.Message(4)

                                                        Case "1" ' PB0;1

                                                            Select Case e.Message(5)

                                                                Case ";" ' PB0;1;

                                                                    'PB0;1;1234567;al0gi7fiOeiJfglgfMfeTgeihaE

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "PB0;1", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "PB0;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "PB0", e.Message)

                                            End Select

                                        Case "1" ' PB1

                                            Select Case e.Message(3)

                                                Case ";" ' PB1;

                                                    Select Case e.Message(4)

                                                        Case "5" ' PB1;5

                                                            Select Case e.Message(5)

                                                                Case "0" ' PB1;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' PB1;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' PB1;501;

                                                                                    'PB1;501;01234567;281,9600

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "PB1;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "PB1;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "PB1;5", e.Message)

                                                            End Select

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "PB1;", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "PB1", e.Message)

                                            End Select

                                        Case "8" ' PB8

                                            Select Case e.Message(3)

                                                Case "3"

                                                    'PB83|Mr-phoqui;0

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "PB8", e.Message)

                                            End Select

                                        Case "F" 'PBFID_Joueur

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "PB", e.Message)

                                    End Select

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

                                Case "l" ' Sl

                                    Select Case e.Message(2)

                                        Case ";" ' Sl;

                                            Select Case e.Message(3)

                                                Case "1" ' Sl;1

                                                    Select Case e.Message(4)

                                                        Case ";" ' Sl;1;

                                                            'Sl;1;-1;adobdD

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Sl;0", e.Message)

                                                    End Select

                                                Case "2" ' Sl;2

                                                    Select Case e.Message(4)

                                                        Case ";" ' Sl;2;

                                                            'Sl;2;1234567;

                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Sl;2", e.Message)

                                                    End Select

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Sl;", e.Message)

                                            End Select

                                        Case "|" ' Sl|

                                            Select Case e.Message(3)
                                                Case "-" ' Sl|+
                                                Case "+" ' Sl|-
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Sl|", e.Message)
                                            End Select

                                        Case "0" ' Sl0

                                            Select Case e.Message(3)

                                                Case ";" ' Sl0;

                                                    Select Case e.Message(4)

                                                        Case "1" ' Sl0;1

                                                            Select Case e.Message(5)

                                                                Case ";" ' Sl0;1;

                                                                    Socket.Envoyer("Sl" & CInt(Split(e.Message, ";")(2)) + 1)

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Sl0;1", e.Message)

                                                            End Select

                                                        Case "5"

                                                            Select Case e.Message(5)

                                                                Case "0" ' Sl0;50

                                                                    Select Case e.Message(6)

                                                                        Case "1" ' Sl0;501

                                                                            Select Case e.Message(7)

                                                                                Case ";" ' Sl0;501;

                                                                                    'Sl0;501;1234567;239,11100

                                                                                Case Else

                                                                                    ErreurFichier(Index, NomDuPersonnage, "Sl0;501", e.Message)

                                                                            End Select

                                                                        Case Else

                                                                            ErreurFichier(Index, NomDuPersonnage, "Sl0;50", e.Message)

                                                                    End Select

                                                                Case Else

                                                                    ErreurFichier(Index, NomDuPersonnage, "Sl0;5", e.Message)

                                                            End Select


                                                        Case Else

                                                            ErreurFichier(Index, NomDuPersonnage, "Sl0;", e.Message)

                                                    End Select

                                                Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"

                                                    Socket.Envoyer("Sl" & IdUnique)

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "Sl0", e.Message)

                                            End Select

                                        Case "1" ' Sl1

                                            Select Case e.Message(3)
                                                Case ";"
                                                    Select Case e.Message(4)
                                                        Case "5"
                                                            Select Case e.Message(5)
                                                                Case "0"
                                                                    Select Case e.Message(6)
                                                                        Case "1"
                                                                            Select Case e.Message(7)
                                                                                Case ";"
                                                                                Case Else
                                                                                    ErreurFichier(Index, NomDuPersonnage, "Sl1;501", e.Message)
                                                                            End Select
                                                                        Case Else
                                                                            ErreurFichier(Index, NomDuPersonnage, "Sl1;50", e.Message)
                                                                    End Select
                                                                Case Else
                                                                    ErreurFichier(Index, NomDuPersonnage, "Sl1;5", e.Message)
                                                            End Select
                                                        Case Else
                                                            ErreurFichier(Index, NomDuPersonnage, "Sl1;", e.Message)
                                                    End Select
                                                Case Else
                                                    ErreurFichier(Index, NomDuPersonnage, "Sl1", e.Message)
                                            End Select

                                        Case "F" ' SlF

                                            Select Case e.Message(3)

                                                Case "|" ' SlF|

                                                    'SlF|418;3;0

                                                Case Else

                                                    ErreurFichier(Index, NomDuPersonnage, "SlF", e.Message)

                                            End Select

                                        Case Else

                                            ErreurFichier(Index, NomDuPersonnage, "Sl", e.Message)

                                    End Select

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

                                        Case "1" ' ZS1

                                            'Inconnu, j'étais Bontarien à ce moment là et dans une zone bontarienne

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
