Partial Module Familier

    Private Function FamilierDéposeStats(ByVal index As Integer, ByVal idFamilier As Integer, ByVal idUnique As Integer, ByVal caractéristique As String) As Boolean

        With Comptes(index)

            Dim depose As Boolean = False

            Dim separate As String() = Split(caractéristique, vbCrLf)

            For i = 0 To separate.Count - 1

                Dim separateCaractéristique As String() = Split(separate(i), " : ")

                Select Case separateCaractéristique(0)

                    Case "Vitalite"

                        Select Case idFamilier

                            Case 1728, 2074, 2075, 2076, 2077 '80,90

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "90", "80") Then

                                    depose = True

                                End If

                            Case 7518 '150,165

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "165", "150") Then

                                    depose = True

                                End If

                            Case 6978 '400,440

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "440", "400") Then

                                    depose = True

                                End If

                        End Select

                    Case "Sagesse", "Pc Dommage"

                        Select Case idFamilier

                            Case 1748 '27

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "30", "27") Then

                                    depose = True

                                End If

                            Case 7519, 7911, 7415, 7522, 7524, 7704, 7705, 7892, 8211, 8561, 9617, 9623 '50,55

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "55", "50") Then

                                    depose = True

                                End If

                        End Select

                    Case "Chance", "Intelligence", "Agilite", "Force"

                        Select Case idFamilier

                            Case 1728, 1748, 2075, 7708, 2074, 7711, 2076, 7891, 7709, 2077, 7712 '80,90

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "90", "80") Then

                                    depose = True

                                End If

                        End Select

                    Case "Dommage", "Soin"

                        Select Case idFamilier

                            Case 7714, 7706, 7713, 8677, 7710, 7714 '10,11

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "11", "10") Then

                                    depose = True

                                End If

                        End Select

                    Case "Resistance Air", "Resistance Feu", "Resistance Terre", "Resistance Eau", "Resistance Neutre"

                        Select Case idFamilier

                            Case 1728, 2074, 2075, 2076, 2077 '20

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "22", "20") Then

                                    depose = True

                                End If

                            Case 7520 '20 croum

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "26", "20") Then

                                    depose = True

                                End If

                        End Select

                    Case "Prospection"

                        Select Case idFamilier

                            Case 7703 '40

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "45", "40") Then

                                    depose = True

                                End If

                            Case 6716

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "85", "80") Then

                                    depose = True

                                End If

                        End Select

                    Case "Initiative"

                        Select Case idFamilier

                            Case 7414 '800

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "880", "800") Then

                                    depose = True

                                End If

                        End Select

                    Case "Pods"

                        Select Case idFamilier

                            Case 8000 ' 1000

                                If separateCaractéristique(1) = If(caractéristique.Contains("Capacite accrue : Oui"), "1100", "1000") Then

                                    depose = True

                                End If

                        End Select

                End Select

            Next

            If depose = True Then

                .BloqueItem.Reset()

                .Socket.Envoyer("EMO+" & idUnique & "|1", True)

                .BloqueItem.WaitOne(15000)

            End If

            Return depose

        End With

    End Function

    Private Function FamilierReturnStats(ByVal index As Integer, ByVal idUnique As Integer) As Integer

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewInventaire).Rows

                If Pair.Cells(1).Value = idUnique Then

                    Dim separate As String() = Split(Pair.Cells(4).Value, vbCrLf)

                    For i = 0 To separate.Count - 1

                        Dim separateCaractéristique As String() = Split(separate(i), " : ")

                        Select Case separateCaractéristique(0)

                            Case "Vitalite", "Sagesse", "Pc Dommage", "Chance", "Intelligence", "Agilite", "Force", "Dommage", "Soin",
                                 "Resistance Air", "Resistance Feu", "Resistance Terre", "Resistance Eau", "Resistance Neutre", "Prospection",
                                 "Initiative", "Pods"

                                Return separateCaractéristique(1)

                        End Select

                    Next

                End If

            Next

            Return 0

        End With

    End Function


End Module
