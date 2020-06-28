Imports System.Threading

Partial Class Player

    Public FrmGroupe As New Groupe
    Public TabPage As New TabPage
    Public FrmUser As New UserControlPersonnage



    'Les Sockets
    Public Socket_Authentification, Socket As All_CallBack
    Public Send As String

    'Personnage
    Public NomDeCompte As String
    Public MotDePasse As String
    Public NomDuPersonnage As String
    Public Serveur As String
    Public Classe As String
    Public Sexe As String
    Public ClasseSexe As String
    Public Couleur1 As String
    Public Couleur2 As String
    Public Couleur3 As String
    Public Alignement As String
    Public QuestionSecrete As String
    Public Index As Integer
    Public Ticket As String
    Public IdUnique As Integer

    'Caractéristique
    Public Regeneration As Integer
    Public Pods As Integer

    'Connexion
    Public Connecté As Boolean

    'Tchat
    Public TchatItem As New Dictionary(Of String, String)

    'Combat
    Public CombatMapSpectateur As Boolean
    Public EnCombat As Boolean

    'Recolte
    Public RecolteNumero As Integer
    Public EnRecolte As Boolean

    'Ami
    Public AmiAvertie As Boolean
    Public BloqueAmi As ManualResetEvent = New ManualResetEvent(False)

    'Map
    Public MapID As Integer
    Public MapPosition As String

    Public MapLargeur As Integer
    Public MapHauteur As Integer

    Public PathTotal As String

    Public MapHandler(1280) As Cell

    Public DirectionBas As Integer
    Public DirectionDroite As Integer
    Public DirectionGauche As Integer
    Public DirectionHaut As Integer

    Public CaseActuelle As Integer
    Public EnDeplacement As Boolean
    Public StopDeplacement As Boolean
    Public BloqueDeplacement As ManualResetEvent = New ManualResetEvent(False)

    'Guilde
    Public EnGuilde As Boolean
    Public GuildeInvitation As Boolean

    'Groupe
    Public EnGroupe As Boolean
    Public InvitationGroupe As Boolean
    Public GroupeIdChef As Integer
    Public BloqueGroupe As ManualResetEvent = New ManualResetEvent(False)
    Public DicoGroupe As New Dictionary(Of Integer, String())

    'Pnj
    Public EnDialogue As Boolean
    Public PnjAcheterVendre As Boolean
    Public ListePnjReponseDisponible As New List(Of Integer)
    Public DialogueReponse As Integer
    Public BloqueDialogue As ManualResetEvent = New ManualResetEvent(False)

    'Maison
    Public Maison As sMaison
    Public Coffre As New Dictionary(Of Integer, sCoffre)

    'Interraction
    Public EnInteraction As Boolean
    Public InteractionCellId As Integer
    Public BloqueInterraction As ManualResetEvent = New ManualResetEvent(False)

    'Craft
    Public ForgemagieListe As New List(Of String)
    Public ForgemagieListeJetBase As New List(Of String)
    Public ForgemagieExo As New List(Of String)
    Public ForgemagieRunePasser As Integer
    Public EnForgemagie As Boolean

    Public EnCraft As Boolean
    Public EnCraftInviter As Boolean

    'Echange
    Public EnEchange As Boolean
    Public EnDemandeEchange As Boolean
    Public EchangeIdNomLanceur(1) As String
    Public EchangeValiderLuiMoi(1) As Boolean
    Public EchangeKamasMoi, EchangeKamasLui As Integer
    Public BloqueEchange As ManualResetEvent = New ManualResetEvent(False)

    'Inventaire
    Public MonEquipement As New sEquipement
    Public BloqueItem As ManualResetEvent = New ManualResetEvent(False)

    'Banque
    Public EnBanque As Boolean



#Region "Structure"

    Structure sMaison

        Dim ID As Integer
        Dim Verouiller As Boolean
        Dim EnVente As Boolean
        Dim EnGuilde As Boolean
        Dim Code As Integer

    End Structure

    Structure sCoffre

        Dim MapId As Integer
        Dim Cellule As Integer
        Dim Verouiller As Boolean
        Dim Code As Integer

    End Structure

    Public Structure sEquipement

        Public Amulette As String()
        Dim Anneaux1 As String()
        Dim Anneaux2 As String()
        Dim Arme As String()
        Dim Familier As String()
        Dim Ceinture As String()
        Dim Botte As String()
        Dim Coiffe As String()
        Dim Cape As String()
        Dim Dofus1 As String()
        Dim Dofus2 As String()
        Dim Dofus3 As String()
        Dim Dofus4 As String()
        Dim Dofus5 As String()
        Dim Dofus6 As String()

    End Structure

#End Region


End Class
