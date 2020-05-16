Module Load

    ' refonte à faire total

    Public Sub LoadServeur()

        'J'ouvre et je lis le fichier.
        Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Data/Serveur.txt")
        Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        swLecture.Close()

        For i = 0 To ligne.Count - 1

            If ligne(i) <> "" Then

                Dim separate() As String = Split(ligne(i).Replace(" ", ""), "|")

                'Je vérifie d'abord que le dico ne contient pas déjà le serveur en question
                If Not DicoServeur.ContainsKey(separate(0)) Then

                    Dim varServeur As New sServeur

                    With varServeur

                        .NomServeur = separate(0)
                        .IP = separate(1)
                        .Port = separate(2)
                        .IdServeur = separate(3)

                    End With

                    DicoServeur.Add(separate(0), varServeur)

                End If

            End If

        Next

    End Sub

    Public Sub LoadPersonnage()

        'J'ouvre et je lis le fichier.
        Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Data/Personnage.txt")
        Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        swLecture.Close()

        For i = 0 To ligne.Count - 1

            If ligne(i) <> "" Then

                Dim separate() As String = Split(ligne(i), "|")

                If Not DicoPersonnage.ContainsKey(separate(0)) Then

                    Dim varPersonnage As New sPersonnage

                    With varPersonnage

                        .ID = separate(0)
                        .NomClasse = separate(1)
                        .Sexe = separate(2)

                    End With

                    DicoPersonnage.Add(separate(0), varPersonnage)

                End If

            End If

        Next

    End Sub

    Public Sub LoadItems()

        'J'ouvre et je lis le fichier.
        Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Data/Objets.txt")
        Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        swLecture.Close()

        For i = 0 To ligne.Count - 1

            If ligne(i) <> "" Then

                Dim separate As String() = Split(ligne(i), "|")

                If Not DicoItems.ContainsKey(separate(0)) Then

                    Dim varItems As New sItems

                    With varItems

                        .ID = separate(0)
                        .NomItem = separate(1)
                        .Catégorie = separate(2)
                        .Pods = separate(3)

                    End With

                    DicoItems.Add(separate(0), varItems)

                End If

            End If

        Next

    End Sub

    Public Sub LoadSort()

        ' Try
        'Si le fichier sort éxiste.
        If IO.File.Exists("Data\Sorts.txt") Then
            '    hdjkhdgkdghk
            'Je l'ouvre.
            Dim monStreamReader As New IO.StreamReader("Data\Sorts.txt")

            'Puis je regarde chaque ligne jusqu'à la fin du fichier.
            Do Until monStreamReader.EndOfStream

                'Je met la ligne dans une variable string.
                Dim ligne As String = monStreamReader.ReadLine

                'Si elle n'est pas vide alors.
                If ligne <> "" Then

                    'Je sépare les informations.
                    Dim Separation() As String = Split(ligne, "|")
                    '161|1|Flèche Magique|1-7|4|0-0|2|0-0|O|O|N|N|N|0-0|N|1|Classe
                    'ID Sort | Level | Nom | PO min max | PA | Nombre de lancer par tour | Nombre de lancer par tour par joueur | Nombre de tour entre 2 lancé | PO Modifiable | Ligne de vue
                    '| Lancer en ligne | Cellule Libre | Echec fini tour | Zone du sort | Champ d'action 'X/L/Z/N" | Next level

                    Dim varSort As New SSort

                    With varSort

                        .IDSort = Separation(0)
                        .Level = Separation(1)
                        .Nom = Separation(2)
                        .POMin = Split(Separation(3), "-")(0)
                        .POMax = Split(Separation(3), "-")(1)
                        .PA = Separation(4)
                        .NbrLancerTour = If(Separation(5).Contains("-"), Split(Separation(5), "-")(1), Separation(5))
                        .NbrLancerTourJoueur = Separation(6)
                        .NbrLancerEntreTour = If(Separation(7).Contains("-"), Split(Separation(7), "-")(1), Separation(7))
                        .POModifiable = CBool(Separation(8))
                        .LigneDeVue = CBool(Separation(9))
                        .LancerEnLigne = CBool(Separation(10))
                        .CelluleLibre = CBool(Separation(11))
                        .ECFiniTour = CBool(Separation(12))
                        .ZoneMin = Split(Separation(13), "-")(0)
                        .ZoneMax = Split(Separation(13), "-")(1)
                        .ChampAction = Separation(14)
                        .CoûtUp = Separation(15)
                        .SortClasse = Separation(16)
                        .Définition = Separation(17)

                    End With


                    If DicoSort.ContainsKey(Separation(0)) Then

                        DicoSort(Separation(0)).Add(Separation(1), varSort)

                    Else

                        DicoSort.Add(Separation(0), New Dictionary(Of Integer, SSort) From
                                     {{
                                     Separation(1), varSort
                                     }})



                    End If

                End If

            Loop

            'Je ferme mon fichier.
            monStreamReader.Close()

        End If

        ' Catch ex As Exception

        ' ErreurFichier("Load_Sorts_Classe", ex.Message)

        ' End Try

    End Sub

    Public Sub LoadMaps()

        Try

            Dim monStreamReader As New IO.StreamReader("Data/Maps.txt")

            Do Until monStreamReader.EndOfStream

                Dim Ligne As String = monStreamReader.ReadLine

                If Ligne <> "" Then

                    Dim Separation() As String = Split(Ligne, ":")

                    ListOfMap(Separation(0)) = Separation(1)

                End If

            Loop

            monStreamReader.Close()

        Catch ex As Exception

            ErreurFichier(0, "Unknow", "LoadMaps", ex.Message)

        End Try

    End Sub

    Public Sub LoadDivers()

        '  Try

        DicoDivers.Clear()

        Dim monStreamReader As New IO.StreamReader("Data/Divers.txt")

        Do Until monStreamReader.EndOfStream

            Dim Ligne As String = monStreamReader.ReadLine

            If Ligne <> "" Then

                Dim Separation() As String = Split(Ligne, "|")

                Dim varInterraction As New sInterraction

                With varInterraction

                    .IdSprite = Separation(0)
                    .Nom = Separation(1)
                    .DicoInterraction = New Dictionary(Of String, Integer)


                    Dim separateNomInterraction As String() = Split(Separation(2), ":")
                    Dim separateIDInterraction As String() = Split(Separation(3), ":")

                    For i = 0 To separateNomInterraction.Count - 1
                        .DicoInterraction.Add(separateNomInterraction(i), separateIDInterraction(i))
                    Next

                End With

                DicoDivers.Add(Separation(0), varInterraction)

            End If
        Loop

        monStreamReader.Close()

        '  Catch ex As Exception

        'ErreurFichier("LoadMetier", ex.Message)

        ' End Try

    End Sub

    Public Sub LoadMobs()

        'J'ouvre et je lis le fichier.
        Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Data/Mobs.txt")
        Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        swLecture.Close()

        For i = 0 To ligne.Count - 1

            If ligne(i) <> "" Then

                Dim separate As String() = Split(ligne(i), "|") '31|Larve Bleue|Level:2:Résistance:1:5:5:-9:-9:5:3|Next level

                Dim idMobs As Integer = separate(0)
                Dim nameMobs As String = separate(1)

                For a = 2 To separate.Count - 1 ' Level:2:Résistance:1:5:5:-9:-9:5:3

                    Dim separateInfo As String() = Split(separate(a), ":")

                    Dim varMobs As New sMobs

                    With varMobs

                        .ID = separate(0)
                        .NomMobs = separate(1)

                        .Level = separateInfo(1)
                        .RésistanceNeutre = separateInfo(3)
                        .RésistanceTerre = separateInfo(4)
                        .RésistanceFeu = separateInfo(5)
                        .RésistanceEau = separateInfo(6)
                        .RésistanceAir = separateInfo(7)

                        .EsquivePA = separateInfo(8)
                        .EsquivePA = separateInfo(9)

                    End With

                    If DicoMobs.ContainsKey(idMobs) Then

                        DicoMobs(idMobs).Add(a - 2, varMobs)

                    Else

                        DicoMobs.Add(idMobs, New Dictionary(Of Integer, sMobs) From
                                 {{
                                 a - 2,
                                 varMobs
                                 }})

                    End If

                Next

            End If

        Next

    End Sub

    Public Sub LoadPNJ()

        DicoPNJ.Clear()

        'J'ouvre et je lis le fichier.
        Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Data/PNJ.txt")
        Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        swLecture.Close()

        For i = 0 To ligne.Count - 1

            If ligne(i) <> "" Then

                Dim separate() As String = Split(ligne(i), "|")

                If Not DicoPNJ.ContainsKey(separate(0)) Then

                    DicoPNJ.Add(separate(0), separate(1)) ' ID + Nom

                End If

            End If

        Next

    End Sub

    Public Sub LoadMaison()

        'J'ouvre et je lis le fichier.
        Dim swLecture As New IO.StreamReader(Application.StartupPath + "\Data/Maison.txt")
        Dim ligne() As String = Split(swLecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        swLecture.Close()

        DicoMaison.Clear()

        For i = 0 To ligne.Count - 1

            If ligne(i) <> "" Then

                Dim separate As String() = Split(ligne(i), " | ")

                Dim hP As String = Split(separate(0), " : ")(1)
                Dim CellulePorte As String = Split(separate(1), " : ")(1)
                Dim Map As String = Split(separate(2), " : ")(1)
                Dim MapId As String = Split(separate(3), " : ")(1)
                Dim Nom As String = Split(separate(4), " : ")(1)

                If Not DicoMaison.ContainsKey(hP) Then

                    Dim varMaison As New sMaison

                    With varMaison

                        .Nom = Nom
                        .Map = Map
                        .CellulePorte = CellulePorte
                        .MapId = MapId

                    End With

                    DicoMaison.Add(hP, varMaison)

                End If

            End If

        Next

    End Sub

    Public Sub LoadPNJReponse()

        Dim monStreamReader As New IO.StreamReader("Data/PNJ-Réponse.txt")

        Do Until monStreamReader.EndOfStream

            Dim Ligne As String = monStreamReader.ReadLine

            If Ligne <> "" Then

                Dim Separation() As String = Split(Ligne, "=")

                DicoPnjReponse.Add(Separation(0), Separation(1))

            End If

        Loop

        monStreamReader.Close()

    End Sub

    Public Sub LoadMetier()

        '  Try

        DicoMétier.Clear()

        Dim monStreamReader As New IO.StreamReader("Data/Métiers.txt")

        Do Until monStreamReader.EndOfStream

            Dim Ligne As String = monStreamReader.ReadLine

            If Ligne <> "" Then

                Dim Separation() As String = Split(Ligne, "|")

                Dim varMétier As New sMetier

                With varMétier

                    .IdMetier = Separation(0)
                    .NomMetier = Separation(1)
                    .Atelier = New Dictionary(Of Integer, String())

                    For i = 2 To Separation.Count - 1

                        Dim separateAtelier As String() = Split(Separation(i), ":")

                        .Atelier.Add(separateAtelier(0), {separateAtelier(1), separateAtelier(2)})

                    Next

                End With

                DicoMétier.Add(Separation(0), varMétier)

            End If
        Loop

        monStreamReader.Close()

        '  Catch ex As Exception

        'ErreurFichier("LoadMetier", ex.Message)

        ' End Try

    End Sub

End Module
