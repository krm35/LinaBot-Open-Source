Public Class LinaBot

    Public CompteurCompte As Integer

#Region "Panel"

    Private Sub PanelAddCompte_Click(sender As Object, e As EventArgs) Handles PanelAddCompte.Click
        Ajouter_un_compte.Show()
    End Sub

    Private Sub PanelLoadCompte_Click(sender As Object, e As EventArgs) Handles PanelLoadCompte.Click
        Charger_un_compte.Show()
    End Sub

    Private Sub PanelDeleteCompte_Click(sender As Object, e As EventArgs) Handles PanelDeleteCompte.Click
        Supprimer_un_compte.Show()
    End Sub

#End Region

#Region "Load"

    Private Sub LinaBot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadScript()

        LoadServeur()

        LoadPersonnage()

        LoadItems()

        LoadSort()

        LoadMaps()

        LoadDivers()

        LoadMobs()

        LoadPNJ()

        LoadMaison()

        LoadPNJReponse()

        LoadMetier()

        LoadFamilier()

    End Sub

#End Region

End Class
