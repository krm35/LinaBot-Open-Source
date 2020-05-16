Public Class FrmMétier
#Region "Variable"

    Public WriteOnly Property SetIndexPanelPersonnage As Integer
        Set(value As Integer)
            Index = value
        End Set
    End Property

    Dim Index As Integer

    Private Sub FrmMétier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBoxMetier.Text = "" Then ComboBoxMetier.Text = 2
    End Sub


#End Region
End Class
