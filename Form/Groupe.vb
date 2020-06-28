Public Class Groupe

    'Banque + Pods
    Public PodsGroupe As Integer = 80
    Public ReturnBanque As Boolean

    'Suppression
    Public GrpSupprime As New List(Of sSupprime)

    'Familier
    Public FamilierList As New Dictionary(Of String, String)

    'Echange
    Public EchangeListeIdNom As New List(Of String)

    Public DicoTrajet As New Dictionary(Of String, List(Of String))
    Public VarStringTrajet As New Dictionary(Of String, String)
    Public VarListeTrajet As New Dictionary(Of String, String())

    Public ListIndex As New List(Of Integer)

    Public ThreadTrajet As Threading.Thread

    Dim myResizer As New Resizer

#Region "Structure"

    Structure sSupprime

        Dim IdNom As String
        Dim Quantité As String
        Dim Caractéristique As String

    End Structure

    Private Sub Groupe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   myResizer.FindAllControls(Me)
    End Sub

    Private Sub Groupe_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        For Each C As Control In Me.TabControlGroupe.Controls

            If TypeOf C Is TabPage Then

                Dim cUser As TabPage = DirectCast(C, TabPage)

                For Each cUsercontrol As Control In cUser.Controls

                    If TypeOf cUsercontrol Is UserControlPersonnage Then

                        cUsercontrol.Size = New Size(Me.TabControlGroupe.Size.Width - 10, Me.TabControlGroupe.Size.Height - 30)

                    End If

                Next

            End If

        Next

    End Sub







#End Region

End Class