Public Class Groupe

    'Banque + Pods
    Public PodsGroupe As Integer = 80
    Public ReturnBanque As Boolean

    'Suppression
    Public GrpSupprime As New List(Of sSupprime)

    'Familier
    Public FamilierList As New Dictionary(Of String, String)

    Public DicoTrajet As New Dictionary(Of String, List(Of String))

    Public ListIndex As New List(Of Integer)

    Public ThreadTrajet As Threading.Thread

#Region "Structure"

    Structure sSupprime

        Dim IdNom As String
        Dim Quantité As String
        Dim Caractéristique As String

    End Structure

#End Region

End Class