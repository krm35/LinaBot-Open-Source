Module ModGroupe

    Public Sub GroupeAccepte(ByVal index As Integer)

        With Comptes(index)

            If .InvitationGroupe Then

                .BloqueGroupe.Reset()

                .Socket.Envoyer("PA")

                .BloqueGroupe.WaitOne(30000)

            End If

        End With

    End Sub

    Public Sub GroupeQuitte(ByVal index As Integer)

        With Comptes(index)

            If .EnGroupe Then

                .BloqueGroupe.Reset()

                .Socket.Envoyer("PV")

                .BloqueGroupe.WaitOne(30000)

            End If

        End With

    End Sub

    Public Sub GroupeRefuse(ByVal index As Integer)

        With Comptes(index)

            If .InvitationGroupe Then

                .Socket.Envoyer("PR")

                .InvitationGroupe = False

            End If

        End With

    End Sub

    Public Sub GroupeInvitation(ByVal index As Integer, ByVal nom As String)

        With Comptes(index)

            If .InvitationGroupe = False Then

                .BloqueGroupe.Reset()

                .Socket.Envoyer("PI" & nom)

                .BloqueGroupe.WaitOne(30000)

            End If

        End With

    End Sub

    Public Sub GroupeSuivezMoiLeTous(ByVal index As Integer, ByVal idName As String)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                If Pair.Cells(1).Value = idName OrElse Pair.Cells(2).Value.ToString.ToUpper = idName.ToUpper Then

                    .BloqueGroupe.Reset()

                    .Socket.Envoyer("PG+" & Pair.Cells(1).Value)

                    .BloqueGroupe.WaitOne(15000)

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub GroupeArrêtezTousDeMeLeSuivre(ByVal index As Integer, ByVal idName As String)

        With Comptes(index)

            If .GroupeIdChef > 0 Then

                .BloqueGroupe.Reset()

                .Socket.Envoyer("PG-" & .GroupeIdChef)

                .BloqueGroupe.WaitOne(15000)

            End If

        End With

    End Sub

    Public Sub GroupeSuivreLeDéplacement(ByVal index As Integer, ByVal idName As String)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                If Pair.Cells(1).Value = idName OrElse Pair.Cells(2).Value.ToString.ToUpper = idName.ToUpper Then

                    .BloqueGroupe.Reset()

                    .Socket.Envoyer("PF+" & Pair.Cells(1).Value)

                    .BloqueGroupe.WaitOne(15000)

                    Return

                End If

            Next

        End With

    End Sub

    Public Sub GroupeNePlusSuivreLeDéplacement(ByVal index As Integer)

        With Comptes(index)

            If .GroupeIdChef > 0 Then

                .BloqueGroupe.Reset()

                .Socket.Envoyer("PF-" & .GroupeIdChef)

                .BloqueGroupe.WaitOne(15000)

            End If

        End With

    End Sub

End Module
