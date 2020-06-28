Module Echange

    Public Sub EchangeDemande(ByVal index As Integer, ByVal idNom As String)

        With Comptes(index)

            For Each Pair As DataGridViewRow In CopyDatagridView(index, .FrmUser.DataGridViewMap).Rows

                If Pair.Cells(1).Value = idNom OrElse Pair.Cells(2).Value.ToString.ToLower = idNom.ToLower Then

                    If .EnEchange = False AndAlso .EnDemandeEchange = False Then

                        .BloqueEchange.Reset()

                        .Socket.Envoyer("ER1|" & Pair.Cells(1).Value)

                        .BloqueEchange.WaitOne(15000)

                    End If

                End If

            Next

        End With

    End Sub

    Public Sub EchangeAccepte(ByVal index As Integer)

        With Comptes(index)

            If .EnDemandeEchange Then

                If .FrmGroupe.EchangeListeIdNom.Contains(.EchangeIdNomLanceur(0).ToLower) OrElse
                   .FrmGroupe.EchangeListeIdNom.Contains(.EchangeIdNomLanceur(1).ToLower) OrElse
                   .FrmGroupe.EchangeListeIdNom.Contains("all") Then

                    .BloqueEchange.Reset()

                    .Socket.Envoyer("EA")

                    .BloqueEchange.WaitOne(15000)

                End If

            End If

        End With

    End Sub

    Public Sub EchangeValider(ByVal index As Integer)

        With Comptes(index)

            If .EnEchange AndAlso .EchangeValiderLuiMoi(1) = False Then

                .BloqueEchange.Reset()

                .Socket.Envoyer("EK")

                .BloqueEchange.WaitOne(15000)

            End If

        End With

    End Sub

    Public Sub EchangeRefuse(ByVal index As Integer)

        With Comptes(index)

            If .EnDemandeEchange Then

                .BloqueEchange.Reset()

                .Socket.Envoyer("EV")

                .BloqueEchange.WaitOne(15000)

            End If

        End With

    End Sub

    Public Sub EchangeDeposeKamas(ByVal index As Integer, ByVal kamas As String)

        With Comptes(index)

            If .EnEchange Then

                .BloqueEchange.Reset()

                .Socket.Envoyer("EMG" & If(kamas > ReturnLabelText(index, .FrmUser.LabelKamas), ReturnLabelText(index, .FrmUser.LabelKamas), kamas))

                .BloqueEchange.WaitOne(15000)

            End If

        End With

    End Sub

End Module
