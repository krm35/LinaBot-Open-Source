Module Variable

    ' refonte à faire / Non fini

    Public Comptes As New List(Of Player)

    Public DicoServeur As New Dictionary(Of String, sServeur)
    Public DicoPersonnage As New Dictionary(Of String, sPersonnage)
    Public DicoItems As New Dictionary(Of Integer, sItems)
    Public DicoSort As New Dictionary(Of Integer, Dictionary(Of Integer, sSort)) 'ID sort puis Level fini par les infos sort.
    Public DicoDivers As New Dictionary(Of Integer, sInterraction)
    Public DicoMobs As New Dictionary(Of Integer, Dictionary(Of Integer, sMobs))
    Public DicoPNJ As New Dictionary(Of Integer, String)
    Public DicoMaison As New Dictionary(Of Integer, sMaison)
    Public DicoPnjReponse As New Dictionary(Of Integer, String)
    Public DicoMétier As New Dictionary(Of Integer, sMetier)
    Public DicoDragodindeId As New Dictionary(Of Integer, String) From
        {
        {3, "Ebene"},
        {10, "Rousse"},
        {15, "Turquoise"},
        {17, "Indigo"},
        {18, "Doree"},
        {19, "Pourpre"},
        {20, "Amande"},
        {21, "Emeraude"},
        {22, "Orchidee"},
        {23, "Prune"},
        {46, "Doree et Rousse"},
        {55, "Emeraude et Indigo"}
        }

    Public DicoFamilier As New Dictionary(Of Integer, Dictionary(Of String, sFamilier))

    Public cases(2500) As String
    Public ListOfMap(13000) As String



#Region "Structure"

    Structure sServeur

        Dim NomServeur As String
        Dim IP As String
        Dim Port As Integer
        Dim IdServeur As String

    End Structure

    Structure sPersonnage

        Dim ID As Integer
        Dim NomClasse As String
        Dim Sexe As String

    End Structure

    Structure sItems

        Dim ID As Integer
        Dim NomItem As String
        Dim Catégorie As Integer
        Dim Pods As Integer

    End Structure

    Structure sSort

        Dim IDSort As Integer
        Dim Level As Integer
        Dim Nom As String
        Dim POMin As Integer
        Dim POMax As Integer
        Dim PA As Integer
        Dim NbrLancerTour As Integer
        Dim NbrLancerTourJoueur As Integer
        Dim NbrLancerEntreTour As Integer
        Dim POModifiable As Boolean
        Dim LigneDeVue As Boolean
        Dim LancerEnLigne As Boolean
        Dim CelluleLibre As Boolean
        Dim ECFiniTour As Boolean
        Dim ZoneMin As Integer
        Dim ZoneMax As Integer
        Dim ChampAction As String
        Dim CoûtUp As Integer
        Dim SortClasse As String
        Dim Définition As String

    End Structure

    Structure sInterraction

        Dim IdSprite As Integer
        Dim Nom As String
        Dim DicoInterraction As Dictionary(Of String, Integer)

    End Structure

    Structure sMobs

        Dim ID As Integer
        Dim NomMobs As String
        Dim Level As Integer
        Dim RésistanceNeutre As Integer
        Dim RésistanceTerre As Integer
        Dim RésistanceFeu As Integer
        Dim RésistanceEau As Integer
        Dim RésistanceAir As Integer
        Dim EsquivePA As Integer
        Dim EsquivePM As Integer

    End Structure

    Structure sMaison

        Dim Nom As String
        Dim Map As String
        Dim CellulePorte As String
        Dim MapId As String

    End Structure

    Structure sMetier

        Dim IdMetier As Integer
        Dim NomMetier As String
        Dim Atelier As Dictionary(Of Integer, String())

    End Structure

    Structure sFamilier

        Dim Nourriture As List(Of Integer)
        Dim IntervaleRepasMin As Integer
        Dim IntervaleRepasMax As Integer
        Dim CapacitéNormal As Integer
        Dim CapacitéMax As Integer

    End Structure



#End Region

End Module
