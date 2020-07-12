Public Class Combat

    Public Sub LanceCombat(ByVal index As Integer)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                'vérifie les ids/noms des mods pour savoir si je dois les attaquers.

                ' S'il s'agit d'un monstre.
                If CInt(Pair.Cells(1).Value) < 0 Then

                    .BloqueCombat.Reset()

                    Dim newDeplacement As New FunctionMap

                    newDeplacement.SeDeplace(index, Pair.Cells(0).Value)

                    If .BloqueCombat.WaitOne(15000) = False Then

                        EcritureMessage(index, "[Combat]", "Le bot n'a pas réussie à attaquer le mob.", Color.Red)

                    End If

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub CombatMontrerCellule(ByVal index As Integer, ByVal IdNomCellule As String)

        With Comptes(index)

            .BloqueCombat.Reset()

            If IsNumeric(IdNomCellule) Then

                .Socket.Envoyer("Gf" & IdNomCellule)

            Else

                For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                    'vérifie les ids/noms des mods pour savoir si je dois les attaquers.

                    ' S'il s'agit d'un monstre.
                    If Pair.Cells(1).Value.ToString = IdNomCellule OrElse Pair.Cells(2).Value.ToString.ToLower = IdNomCellule.ToLower Then

                        .Socket.Envoyer("Gf" & Pair.Cells(0).Value)

                        Exit For

                    End If

                Next

            End If

            .BloqueCombat.WaitOne(15000)

        End With

    End Sub

    Public Sub CombatAide(ByVal index As Integer, ByVal Activer As Boolean)

        With Comptes(index)

            If .DicoCombatLancer.ContainsKey(.IdUnique) Then

                Select Case Activer

                    Case True

                        If .DicoCombatLancer(.IdUnique).Aide = False Then

                            .Socket.Envoyer("fH")

                        End If

                    Case False

                        If .DicoCombatLancer(.IdUnique).Aide = True Then

                            .Socket.Envoyer("fH")

                        End If

                End Select

            End If

        End With

    End Sub

    Public Sub CombatSpectateur(ByVal index As Integer, ByVal Activer As Boolean)

        With Comptes(index)

            If .DicoCombatLancer.ContainsKey(.IdUnique) Then

                Select Case Activer

                    Case True

                        If .DicoCombatLancer(.IdUnique).Spectateur = False Then

                            .Socket.Envoyer("fS")

                        End If

                    Case False

                        If .DicoCombatLancer(.IdUnique).Spectateur Then

                            .Socket.Envoyer("fS")

                        End If

                End Select

            End If

        End With

    End Sub

    Public Sub CombatCadenas(ByVal index As Integer, ByVal Activer As Boolean)

        With Comptes(index)

            If .DicoCombatLancer.ContainsKey(.IdUnique) Then

                Select Case Activer

                    Case True

                        If .DicoCombatLancer(.IdUnique).Cadenas = False Then

                            .Socket.Envoyer("fN")

                        End If

                    Case False

                        If .DicoCombatLancer(.IdUnique).Cadenas Then

                            .Socket.Envoyer("fN")

                        End If

                End Select

            End If

        End With

    End Sub

    Public Sub CombatGroupe(ByVal index As Integer, ByVal Activer As Boolean)

        With Comptes(index)

            If .DicoCombatLancer.ContainsKey(.IdUnique) Then

                Select Case Activer

                    Case True

                        If .DicoCombatLancer(.IdUnique).Groupe = False Then

                            .Socket.Envoyer("fP")

                        End If

                    Case False

                        If .DicoCombatLancer(.IdUnique).Groupe Then

                            .Socket.Envoyer("fP")

                        End If

                End Select

            End If

        End With

    End Sub

End Class
