Module Interraction_Information
    ' refonte à faire
    Public Sub GaInterractionEnJeu(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'GDF | 206     ; 3    ; 0
            'GDF | Cellule ; Etat ; Utilisation                

            ' I separate the data by this sign "|"
            Dim separateData As String() = Split(data, "|")

            For i = 1 To separateData.Count - 1

                ' I separate the data by this sign ";"
                Dim separate As String() = Split(separateData(i), ";")

                For Each Pair As DataGridViewRow In .FrmUser.DataGridViewDivers.Rows

                    If Pair.Cells(1).Value = separate(0) Then

                        Select Case separate(2)

                            Case "0" ' Utilisation une personne

                                Select Case separate(1) 'State now

                                    Case 2 'In Cut

                                        Pair.Cells(3).Value = Pair.Cells(3).Value.ToString.Replace("Disponible", "En Utilisation")

                                        Pair.DefaultCellStyle.BackColor = Color.Orange

                                    Case 3, 4 'Cut

                                        Pair.Cells(3).Value = Pair.Cells(3).Value.ToString.Replace("En Utilisation", "Indisponible")

                                        Pair.DefaultCellStyle.BackColor = Color.Red

                                        If separate(0) = .InteractionCellId Then .EnRecolte = False

                                End Select

                            Case "1" 'Utilisation possible

                                Pair.Cells(3).Value = Pair.Cells(3).Value.ToString.Replace("Indisponible", "Disponible")

                                Pair.DefaultCellStyle.BackColor = Color.Lime

                            Case Else

                                EcritureMessage(index, "[Récolte]", "L'état de la ressource '" & Pair.Cells(2).Value & "' est inconnu, cellid : " & separate(0) & " Etat : " & separate(2), Color.Red)

                        End Select

                    End If

                Next

            Next

        End With

    End Sub

End Module
