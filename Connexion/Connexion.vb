
Module Connexion

    ' refonte à faire

    Public Sub GaConnexionServeurAuthentification(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'HC trkzqijwpzvunfezdxdhhlmmgxxgsbqm 
            'HC Clef Crypt Mdp 

            EcritureMessage(index, "(Info)", "Connecté au serveur d'authentification.", Color.Green)

            Dim clefCrypt As String = Mid(data, 3)

            'J'indique la version actuel du jeu dofus.
            .Socket_Authentification.Envoyer(DicoServeur("Authentification").IdServeur)
            .Socket_Authentification.Envoyer(.NomDeCompte & Chr(10) & PassEnc(.MotDePasse, clefCrypt))
            .Socket_Authentification.Envoyer("Af")

        End With

    End Sub

    Public Sub GaConnexionServeurJeu(ByVal index As Integer)

        With Comptes(index)

            EcritureMessage(index, "(Dofus)", "Connecté au serveur de jeu, envoie du ticket.", Color.Green)
            .Socket.Envoyer("AT" & .Ticket)

        End With

    End Sub

    Public Sub GaServeurIpPortTicket(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'AXK 98752:98 gr5   32tr9f
            'AXK IP       Port  Ticket 

            ' AYK eratz.ankama-games.com ; 0123f45
            ' AYK Ip et Port             ; Ticket

            EcritureMessage(index, "(Info)", "Récuperation de l'IP, Port et du Ticket.", Color.Green)

            Select Case Mid(data, 1, 3)

                Case "AXK"

                    .Ticket = Mid(data, 15)

                    Dim ip As String = DécryptIP(Mid(data, 4, 8))
                    Dim port As Integer = DécryptPort(Mid(data, 12, 3))

                    If ip <> DicoServeur(.Serveur).IP OrElse port <> DicoServeur(.Serveur).Port Then

                        ReplaceIpPort(index, .Serveur, ip, port)

                    End If

                    'Je me connecte au serveur de jeu.
                    .CreateSocketServeurJeu(ip, port)

                Case "AYK"

                    data = Mid(data, 4)

                    Dim separateData As String() = Split(data, ";")

                    If data.Contains(".com") Then

                        Dim ip As String = HostNameIP(separateData(0))
                        Dim port As String = DicoServeur(.Serveur).Port

                        If ip <> DicoServeur(.Serveur).IP Then

                            ReplaceIpPort(index, .Serveur, ip, DicoServeur(.Serveur).Port)

                        End If

                        .CreateSocketServeurJeu(ip, port)

                    Else

                        .CreateSocketServeurJeu(separateData(0), DicoServeur(.Serveur).Port)

                    End If

            End Select

        End With

    End Sub

    Private Function HostNameIP(ByVal hostname As String) As String
        Dim hostname2 As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(hostname)
        Dim ip As System.Net.IPAddress() = hostname2.AddressList
        Return ip(0).ToString()
    End Function

    Private Sub ReplaceIpPort(ByVal index As Integer, ByVal serveur As String, ByVal ip As String, ByVal port As String)

        With Comptes(index)

            'Je lis le fichier.
            Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Data/Serveur.txt")
            Dim ligne As String = swLecture.ReadToEnd

            'Puis je ferme le fichier.
            swLecture.Close()

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim swEcriture As New IO.StreamWriter(Application.StartupPath + "\Data/Serveur.txt")
            Dim newLigne As String = ""

            Dim separateLigne As String() = Split(ligne, vbCrLf)

            For i = 0 To separateLigne.Count - 1

                If separateLigne(i) <> "" Then

                    Dim separate As String() = Split(separateLigne(i), "|")

                    If separate(0) = serveur Then

                        newLigne &= serveur & "|" & ip & "|" & port & "|" & DicoServeur(serveur).IdServeur & vbCrLf

                    Else

                        newLigne &= separateLigne(i) & vbCrLf

                    End If

                End If

            Next

            swEcriture.WriteLine(newLigne)

            swEcriture.Close()

            LoadServeur()

        End With

    End Sub

    Public Async Sub GaPersonnageNomAléatoire(ByVal index As Integer)

        With Comptes(index)

            Await Task.Delay(1500)

            .Socket.Envoyer("AP", True)

        End With

    End Sub

    Public Sub GaPersonnageModifieNom(ByVal index As Integer)

        With Comptes(index)

            'Je lis le fichier.
            Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Compte/Accounts.txt")
            Dim ligne As String = swLecture.ReadToEnd

            'Puis je ferme le fichier.
            swLecture.Close()

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim swEcriture As New IO.StreamWriter(Application.StartupPath + "\Compte/Accounts.txt")

            ligne = ligne.Replace("Nom de compte : " & .NomDeCompte & " | " &
                                  "Mot de passe: " & .MotDePasse & " | " &
                                  "Nom du personnage : Aléatoire" & " | " &
                                  "Serveur : " & .Serveur & " | " &
                                  "Id Classe : " & .Classe & " | " &
                                  "Id Sexe : " & .Sexe & " | " &
                                  "Couleur 1 : " & .Couleur1 & " | " &
                                  "Couleur 2 : " & .Couleur2 & " | " &
                                  "Couleur 3 : " & .Couleur3,
                                    "Nom de compte : " & .NomDeCompte & " | " &
                                    "Mot de passe: " & .MotDePasse & " | " &
                                    "Nom du personnage : " & .NomDuPersonnage & " | " &
                                    "Serveur : " & .Serveur & " | " &
                                    "Id Classe : " & .Classe & " | " &
                                    "Id Sexe : " & .Sexe & " | " &
                                    "Couleur 1 : " & .Couleur1 & " | " &
                                    "Couleur 2 : " & .Couleur2 & " | " &
                                    "Couleur 3 : " & .Couleur3)

            swEcriture.WriteLine(ligne)

            swEcriture.Close()

        End With

    End Sub

    Public Sub GaPseudo(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Ad Linaculer
            ' Ad Pseudo du compte

            Dim pseudo As String = Mid(data, 3)

            .FrmUser.ToolTip1.SetToolTip(.FrmUser.LabelAbonnement, pseudo)

        End With

    End Sub

    Public Async Sub GaFileAttenteAuthentification(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Af 82              | 272            | 0 |   | -1 
            ' Af Position actuel | sur X personne | ? | ? | ?

            data = Mid(data, 3)

            Dim separate As String() = Split(data, "|")

            'Si la file d'attente est supérieur à 1, je refresh la file d'attente. toutes les 5 secondes.

            If CInt(separate(0)) > 1 Then
                EcritureMessage(index, "[Dofus]", "En attente de connexion sur le serveur..." &
                                                  "Position dans la file d'attente : " & separate(0), Color.Green)

                Await Task.Delay(5000)

                If .Socket_Authentification.Connecter Then .Socket_Authentification.Envoyer("Af")

            End If

        End With

    End Sub

    Public Async Sub GaFileAttenteJeu(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'Aq 1
            'Aq Position dans la queu.

            Dim position As Integer = Mid(data, 3)

            EcritureMessage(index, "(Dofus)", "Connexion au serveur... ( Position dans la file d'attente : " & position & " )", Color.Green)

            'Si la file d'attente est supérieur à 1, je refresh la file d'attente. toutes les 5 secondes.
            If position > 1 Then

                Await Task.Delay(5000)

                .Socket.Envoyer("Af", True)

            End If

        End With

    End Sub

    Public Async Sub GaReçoisServer(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            Try

                'AH 601        ; 1            ; 75      ; 1       | 602;1;75;1
                'AH ID_Serveur ; Etat_Serveur ; Inconnu ; Inconnu | Next

                data = Mid(data, 3) 'Je prend les infos seulement après le "AH"

                Dim separateData As String() = Split(data, "|") ' 601;1;75;1|602;1;75;1

                For i = 0 To separateData.Count - 1 ' 601;1;75;1

                    Dim separate As String() = Split(separateData(i), ";")

                    If separate(0) = DicoServeur(.Serveur).IdServeur Then ' ID = ID

                        Select Case separate(1)

                            Case "1"

                            Case "2" ' En sauvegarde

                                EcritureMessage(index, "(Dofus)", "Serveur en sauvegarde !", Color.Red)

                                Await Task.Delay(10000)

                                ' Refresh la demande des serveurs  
                                .Socket_Authentification.Envoyer("Ax", True)

                                Return

                            Case Else

                                ErreurFichier(index, .NomDuPersonnage, "GaReçoitServer", data)

                        End Select

                    End If

                Next

            Catch ex As Exception

                ErreurFichier(index, .NomDuPersonnage, "GaReçoitServer", data & vbCrLf & ex.Message)

            End Try

        End With

    End Sub

    Public Sub GaReceptionPersonnage(ByVal index As Integer, ByVal data As String)

        With Comptes(index)


            'ALK 25487456210      | 4              | 1234567       ; Linaculer      ; 101    ; 90     ; -1       ; -1       ; -1       ; 48a , 1bea   , 1b0f , 1f40     , Bouclier ; 0 ; 601        ;   ;   ;   | Next personnage
            'ALK Abonnement_Dofus | Nbr_Personnage | ID_Personnage ; Nom_Personnage ; Niveau ; Classe ; Couleur1 ; Couleur2 ; Couleur3 ; Cac , Coiffe , Cape , Familier , Bouclier ; ? ; ID_Serveur ; ? ; ? ; ? | Next

            Try

                Dim separateData As String() = Split(data, "|")

                'Abonnement
                Dim abonnement As Date = DateAdd("s", Mid(separateData(0), 4, separateData(0).Length) \ 1000, Date.Now) 's = seconde

                .FrmUser.LabelAbonnement.Text = abonnement

                If separateData(1) <> "0" Then

                    EcritureMessage(index, "(Info)", "Réception des personnages. (" & separateData(1) & ")", Color.Green)

                    For i = 2 To separateData.Count - 1

                        Dim separate() As String = Split(separateData(i), ";")

                        'Je regarde si le nom du personnage correspond à celui voulu par l'utilisateur. (Je mets en majuscule par sécurité, si la personne oublie une majuscule ou autre)
                        If separate(1).ToUpper = .NomDuPersonnage.ToUpper Then

                            'Si oui, je prend alors l'ID unique du personnage.
                            .IdUnique = separate(0) '1234567

                            Dim nomPersonnage As String = separate(1)

                            Dim level As Integer = separate(2)

                            Dim idClasse As Integer = separate(3)

                            'Pour obtenir la couleur sur une var 'Color' = ColorTranslator.FromOle(.Couleur1)
                            .Couleur1 = "&H" & separate(4)
                            .Couleur2 = "&H" & separate(5)
                            .Couleur3 = "&H" & separate(6)

                            Dim separateItem As String() = Split(separate(7), ",")

                            If separate(7) <> "null" Then

                                Dim idCaC As Integer = If(separateItem(0) = "", 0, Convert.ToInt64(separateItem(0), 16))
                                Dim idCoiffe, coiffeLv, coiffeForme As Integer
                                Dim idCape, capeLv, capeForm As Integer

                                If separateItem(1).Contains("~") Then

                                    Dim separateObvijevan As String() = Split(separateItem(1), "~")

                                    idCoiffe = Convert.ToInt64(separateObvijevan(0), 16)
                                    coiffeLv = Convert.ToInt64(separateObvijevan(1), 16)
                                    coiffeForme = Convert.ToInt64(separateObvijevan(2), 16)

                                Else

                                    If separateItem(1) <> Nothing Then

                                        idCoiffe = Convert.ToInt64(separateItem(1), 16)

                                    End If

                                End If

                                If separateItem(2).Contains("~") Then

                                    Dim separateObvijevan As String() = Split(separateItem(2), "~")

                                    idCape = Convert.ToInt64(separateObvijevan(0), 16)
                                    capeLv = Convert.ToInt64(separateObvijevan(1), 16)
                                    capeForm = Convert.ToInt64(separateObvijevan(2), 16)

                                Else

                                    If separateItem(2) <> Nothing Then

                                        idCape = Convert.ToInt64(separateItem(2), 16)

                                    End If

                                End If

                                Dim idFamilier As Integer = If(separateItem(3) = "", 0, Convert.ToInt64(separateItem(3), 16))
                                Dim idBouclier As Integer = If(separateItem(4) = "", 0, Convert.ToInt64(separateItem(4), 16))

                            End If

                            Dim idServer As Integer = separate(9)

                            EcritureMessage(index, "(Info)", "Connexion au personnage : " & nomPersonnage &
                                                             " (Classe = " & DicoPersonnage(idClasse).NomClasse & " - " & DicoPersonnage(idClasse).Sexe & ") (Niveau = " & level & ").", Color.Green)

                            'J'envoie l'ID du personnage sur lequel je souhaite me connecter.
                            .Socket.Envoyer("AS" & .IdUnique)
                            .Socket.Envoyer("Af")

                            Exit For

                        End If

                    Next

                Else

                    If .NomDuPersonnage = "Aléatoire" Then

                        .Socket.Envoyer("AP")

                    Else

                        .Socket.Envoyer("AA" & .NomDuPersonnage & "|" & .Classe & "|" & .Sexe & "|" & .Couleur1 & "|" & .Couleur2 & "|" & .Couleur3)

                    End If

                End If

            Catch ex As Exception

                ErreurFichier(index, .NomDuPersonnage, "GaReceptionPersonnage", data)

            End Try

        End With

    End Sub

    Public Sub GaNomPersonnageAléatoire(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' APK Linaculer
            ' APK Nom

            .NomDuPersonnage = Mid(data, 4)

            .Socket.Envoyer("AA" & .NomDuPersonnage & "|" & .Classe & "|" & .Sexe & "|" & .Couleur1 & "|" & .Couleur2 & "|" & .Couleur3, True)

        End With

    End Sub

    Public Sub GaSecretQuestion(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            Try

                ' AQ Quel+est+mon+mod%C3%A8le+de+voiture+pr%C3%A9f%C3%A9r%C3%A9+%3F
                ' AQ Question secréte

                'Je prend tout se qui se trouve après le "AQ"
                data = Mid(data, 3)

                'Je remplace les "+" par un espace.
                data = data.Replace("+", " ")

                .QuestionSecrete = AsciiDecoder(data)

                If data.Length > 2 Then

                    EcritureMessage(index, "(Dofus)", "Question secréte : " & .QuestionSecrete, Color.Green)

                End If

            Catch ex As Exception

                ErreurFichier(index, .NomDuPersonnage, "GaSecretQuestion", data & vbCrLf & ex.Message)

            End Try

        End With

    End Sub

    Public Sub GaServeurSelection(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' AxK 758257142                  | 601        , 5                    |
            ' AxK Abonnement en milliseconde | Id Serveur , Nombre de personnage | Next

            ' Je prend tout se qui se trouve après le "AxK"
            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            Dim abonnement As Date = DateAdd("s", separateData(0) \ 1000, Date.Now) 's = seconde

            .FrmUser.LabelAbonnement.Text = abonnement

            If separateData.Length > 1 Then

                Dim listeServeur As New List(Of String) 'Evite d'afficher plusieurs fois l'information.

                For i = 1 To separateData.Count - 1

                    'Pour éviter d'afficher plusieurs fois le même message, je le compare avec l'information juste avant.
                    If Not listeServeur.Contains(separateData(i)) Then

                        listeServeur.Add(separateData(i))

                        Dim separateServeur As String() = Split(separateData(i), ",")

                        For Each pair As KeyValuePair(Of String, sServeur) In DicoServeur

                            If pair.Value.IdServeur = separateServeur(0) Then

                                EcritureMessage(index, "(Dofus)", "Vous avez sur le serveur '" & pair.Value.NomServeur & "' " & separateServeur(1) & " personnage(s).", Color.Green)

                                Exit For

                            End If

                        Next

                    End If

                Next

                EcritureMessage(index, "[Dofus]", "Connexion au serveur : " & .Serveur, Color.Green)

                'J'envoie l'information sur le serveur où je souhaite me connecter (Il s'agit du code de connexion).
                .Socket_Authentification.Envoyer("AX" & DicoServeur(.Serveur).IdServeur)

            Else

                EcritureMessage(index, "[Dofus]", "Aucun serveur détecté.", Color.Green)

                .Socket_Authentification.Connexion_Game(False)

            End If

        End With

    End Sub

    Public Sub GaVersion(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' AlEv 1.30.1 
            ' AlEv Version

            'Mise à jour de la version automatiquement (celui du fichier)
            Dim SW_Lecture As New IO.StreamReader(Application.StartupPath & "\Data/Serveur.txt")
            Dim ligne As String = SW_Lecture.ReadToEnd

            'Puis je ferme le fichier.
            SW_Lecture.Close()

            'Je remplace la version actuel par la nouvelle.
            ligne = ligne.Replace(DicoServeur("Authentification").IdServeur, Mid(data, 5) & "e")

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim Sw_Ecriture As New IO.StreamWriter(Application.StartupPath + "\Data/Serveur.txt")

            'J'écris dedans avant de le fermer.
            Sw_Ecriture.WriteLine(ligne)

            'Puis je le ferme.
            Sw_Ecriture.Close()

            LoadServeur()

        End With

    End Sub

    Public Sub GaProblemeConnexion(ByVal index As Integer, ByVal erreur As String, Optional ByVal data As String = "")

        With Comptes(index)

            Select Case erreur

                Case "M01"

                    EcritureMessage(index, "(Dofus)", "Connexion interrompue avec le serveur." & vbCrLf &
                                                      "Tu es resté trop longtemps inactif.", Color.Red)

                Case "M018"

                    ' M018 | [Toblik]  ; Bot Joueur
                    ' M018 | NomJoueur ; Message

                    Dim separate As String() = Split(data, "|")
                    separate = Split(separate(1), ";")
                    EcritureMessage(index, "[Modérateur]", separate(0) & " : " & separate(1), Color.Red)


                Case "M013"

                    EcritureMessage(index, "(Dofus)", "Connexion interrompue avec le serveur." & vbCrLf &
                                                      "Le serveur est actuellement en maintenance, Merci de votre compréhension." & vbCrLf &
                                                      "Profitez-en pour découvrir les différents jeux Linabots, tel que 'Agrandir la taille de son chibre' ou encore 'Le caca c'est trop génial !'", Color.Red)

                Case "M030"

                    EcritureMessage(index, "[Dofus]", "Déconnecté, Connexion trop lente, vérifiez qu'un logiciel,
                                                       le streaming ou autre ne prenne pas toute votre connexion.", Color.Red)

                Case "M132"

                    .EnCombat = True

                    EcritureMessage(index, "[Combat]", "Afin de ne pas gêner les autres joueurs, veuillez attendre " &
                                                       Mid(data, 5) & " secondes avant de vous reconnectez.", Color.Red)

                    Return

            End Select

            .Socket.Connexion_Game(False)

        End With

    End Sub


End Module
