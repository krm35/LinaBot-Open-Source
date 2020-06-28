Module Maison_Information

    ' refaire/modification/amélioration.

    Public Sub GaMaisonMap(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' hP 444 | Linacu ; 0            ; Lenculeur lourd ; a     , 0    ,i     ,9drge
            ' hP Id  | Pseudo ; pas en vente ; Nom guilde      ; blason,blason,blason,blason

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            Dim id As Integer = separateData(0)

            separateData = Split(separateData(1), ";")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewDivers.Rows

                If Not DicoMaison.ContainsKey(id) Then

                    MaisonAjouteInformation(index, id)

                End If

                If Pair.Cells(1).Value = DicoMaison(id).CellulePorte Then

                    Pair.Cells(3).Value &= vbCrLf & "En vente : " & If(separateData(1) = "0", "Non", "Oui") & vbCrLf &
                            "Chez : " & separateData(0)

                    If separateData.Length > 2 Then

                        Pair.Cells(3).Value &= vbCrLf & "Guilde : " & separateData(2)

                    End If

                    If DicoMaison(id).Map = "[X,Y]" OrElse DicoMaison(id).MapId = "0" Then

                        MaisonChangeInformation(index, id)

                    End If

                    Exit For

                End If

            Next

            .FrmUser.DataGridViewDivers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .FrmUser.DataGridViewDivers.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

        End With

    End Sub

    Private Sub MaisonChangeInformation(ByVal index As Integer, ByVal id As String)

        With Comptes(index)

            'Mise à jour de la version automatiquement (celui du fichier)
            Dim swLecture As New IO.StreamReader(Application.StartupPath & "\Data/Maison.txt")

            Dim ligneFinal As String = ""

            Do Until swLecture.EndOfStream

                Dim Ligne As String = swLecture.ReadLine

                If Ligne <> "" Then

                    Dim separate As String() = Split(Ligne, " | ")

                    If separate(0) = "hP : " & id Then

                        ligneFinal &= "hP : " & id & " | Porte : " & DicoMaison(id).CellulePorte & " | Map : " & .FrmUser.LabelMap.Text & " | Mapid : " & .MapID & " | Nom : " & DicoMaison(id).Nom & vbCrLf

                    Else

                        ligneFinal &= Ligne & vbCrLf

                    End If

                End If

            Loop

            'Puis je ferme le fichier.
            swLecture.Close()

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim Sw_Ecriture As New IO.StreamWriter(Application.StartupPath + "\Data/Maison.txt")

            'J'écris dedans avant de le fermer.
            Sw_Ecriture.Write(ligneFinal)

            'Puis je le ferme.
            Sw_Ecriture.Close()

            LoadMaison()

        End With

    End Sub

    Private Sub MaisonAjouteInformation(ByVal index As Integer, ByVal id As String)

        With Comptes(index)

            'Mise à jour de la version automatiquement (celui du fichier)
            Dim swLecture As New IO.StreamReader(Application.StartupPath & "\Data/Maison.txt")

            Dim ligneFinal As String = ""

            Do Until swLecture.EndOfStream

                Dim ligne As String = swLecture.ReadLine

                If ligne <> "" Then

                    ligneFinal &= ligne & vbCrLf

                End If

            Loop

            'Puis je ferme le fichier.
            swLecture.Close()

            ligneFinal &= "hP : " & id & " | Porte : 0 | Map : " & .FrmUser.LabelMap.Text & " | Mapid : " & .MapID & " | Nom : Maison"

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim Sw_Ecriture As New IO.StreamWriter(Application.StartupPath + "\Data/Maison.txt")

            'J'écris dedans avant de le fermer.
            Sw_Ecriture.Write(ligneFinal)

            'Puis je le ferme.
            Sw_Ecriture.Close()

            LoadMaison()

        End With

    End Sub

    Public Sub GaMaMaison(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' hL + 123       ; 1          ; 0        ; 0
            ' hL + Id Maison ; Verouiller ; En Vente ; En Guilde

            data = Mid(data, 4)

            Dim separate As String() = Split(data, ";")

            Dim varMaison As New Player.sMaison

            With varMaison

                .ID = separate(0)
                .Verouiller = separate(1)
                .EnVente = separate(2)
                .EnGuilde = separate(3)
                .Code = Nothing

            End With

            .Maison = varMaison

        End With

    End Sub

    Public Sub GaMesCoffres(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' sL + 9999   _ 999     ; 1          | Next
            ' sL + Id Map _ Cellule ; Verouiller | Next

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            For i = 0 To separateData.Count - 1

                Dim separate As String() = Split(separateData(i), ";")

                Dim Verouiller As Boolean = separate(1)

                separate = Split(separate(0), "_")

                Dim varCoffre As New Player.sCoffre

                With varCoffre

                    .MapId = separate(0)
                    .Cellule = separate(1)
                    .Verouiller = Verouiller
                    .Code = Nothing

                End With

                .Coffre.Add(separate(0), varCoffre)

            Next

        End With

    End Sub

End Module
