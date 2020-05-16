Module Dragodinde_Information
    ' refonte à faire
    Public Sub GaEncloMap(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' Rp 12345    ; 0 ; 2 ; 2 ; Lenculer de bot ; i      , 5      , a      , 7ryjs
            ' Rp id enclo ; ? ; ? ; ? ; Guilde          ; Blason , Blason , Blason , Blason

            ' A TRAITER

        End With

    End Sub

    Public Sub GaDragodindeEncloEtableEquipé(ByVal index As Integer, ByVal data As String, ByVal dgv As DataGridView)

        With Comptes(index)

            Try

                ' Re+ 1200859   : 46 : 10,3,10,15,22,10,10,15,46,23,18,3,22,10 :           ,            :     : 0    :  7587      , 7250   , 9250   : 7      : 1        : 185 : 0 : 2249      , 10000         : 2000     , 2000         : 206     , 1205        : -10000       , -10000    , 10000  : 2500  , 10000     : -1          : 0 : 7d#7#0#0 , 7c#1#0#0 : 0       , 240         : 5     , 20
                ' Re+ Id unique : Id : Arbre généalogique                      : Capacité1 , Capacité 2 : Nom : Sexe :  Xp actuel , Xp Min , Xp Max : Niveau : Montable : ?   : ? : Endurance , Endurance Max : Maturité , Méturité max : Energie , Energie max :  Agressivité , Equilibré , Serein : Amour , Amour max : Fécondation : ? : +7 vita  , +1 sag   : Fatigue , Fatigue max : Repro , Repro max
                Dim sexe As String() = {"Mâle", "Femelle"}
                Dim capacité As String() = {"Infatigable", "Porteuse", "Reproductrice", "Sage", "Endurante", "Amoureuse", "Précoce", "Prédisposée Génétique", "Caméléone"}

                'Replace
                data = data.Replace("Rd", "").Replace("Re+", "").Replace("Ee+", "").Replace("Ef+", "").Replace("Ee~", "")

                Dim separateData As String() = Split(data, ";")

                For i = 0 To separateData.Count - 1

                    Dim separate As String() = Split(separateData(i), ":")

                    With dgv

                        ' Id Unique
                        .Rows.Add(separate(0))

                        With .Rows(.Rows.Count - 1)

                            'Nom Dragodinde
                            .Cells(1).Value = "Dragodinde " & If(DicoDragodindeId.ContainsKey(separate(1)), DicoDragodindeId(separate(1)), separate(1))

                            'Arbre Généalogique
                            .Cells(2).Value = separate(2)

                            'Nom
                            .Cells(3).Value = If(separate(4) = Nothing, "SansNom", separate(4))

                            'Sexe
                            .Cells(4).Value = sexe(separate(5))

                            'Niveau
                            .Cells(5).Value = separate(7)

                            'Expérience
                            .Cells(6).Value = "Minimum : " & Split(separate(6), ",")(1) & vbCrLf &
                                              "Actuelle : " & Split(separate(6), ",")(0) & vbCrLf &
                                              "Maximum : " & Split(separate(6), ",")(2)

                            'Montable
                            .Cells(7).Value = If(separate(8) = "0", "Non", "Oui")

                            'Endurance
                            .Cells(8).Value = separate(11).Replace(",", "/")

                            'Maturité
                            .Cells(9).Value = separate(12).Replace(",", "/")

                            'Amour
                            .Cells(10).Value = separate(15).Replace(",", "/")

                            'Etat
                            .Cells(11).Value = separate(14).Replace(",", "/")

                            'Energie
                            .Cells(12).Value = separate(13).Replace(",", "/")

                            'Fatigue
                            .Cells(13).Value = separate(19).Replace(",", "/")

                            'Capacité

                            .Cells(14).Value = ""

                            If Split(separate(3), ",")(0) <> Nothing Then
                                .Cells(14).Value = capacité(Split(separate(3), ",")(0))
                            End If

                            If Split(separate(3), ",")(1) <> Nothing Then
                                .Cells(14).Value &= vbCrLf & capacité(Split(separate(3), ",")(1))
                            End If

                            'Caractéristique
                            If separate(18) <> Nothing Then

                                .Cells(15).Value = ItemCaractéristique(separate(18))

                            Else

                                .Cells(15).Value = ""

                            End If

                            'Fécondation
                            If CInt(separate(16)) > 0 Then

                                .Cells(16).Value = separate(16)

                            ElseIf (CInt(Split(separate(11), ",")(0)) >= 7500) AndAlso (CInt(Split(separate(15), ",")(0)) >= 7500) AndAlso CInt(Split(separate(12), ",")(0) = Split(separate(12), ",")(1)) AndAlso (CInt(separate(7)) >= 5) Then

                                .Cells(16).Value = "Fecondable"

                            Else

                                .Cells(16).Value = "Non Fecondable"

                            End If

                            'Reproduction
                            .Cells(17).Value = separate(20).Replace(",", "/")

                        End With

                    End With

                Next

            Catch ex As Exception

                ErreurFichier(index, .NomDuPersonnage, "Dragodinde_Information", data & vbCrLf & ex.Message)

            End Try

            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True

        End With

    End Sub



End Module
