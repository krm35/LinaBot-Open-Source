
Module Echange_Information

    Public Sub GaEchangeDemandeRecu(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' ERK 1234567   | 7654321    | 1
            ' ERK IdLanceur | iDReceveur | ?

            .EnDemandeEchange = True

            data = Mid(data, 4)

            Dim separate As String() = Split(data, "|")
            Dim nomLanceur, nomReceveur As New String("")

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = separate(0) Then

                    nomLanceur = Pair.Cells(2).Value

                ElseIf Pair.Cells(1).Value = separate(1) Then

                    nomReceveur = Pair.Cells(2).Value

                End If

            Next

            .EchangeIdNomLanceur(0) = separate(0)
            .EchangeIdNomLanceur(1) = nomLanceur

            If separate(0) = .IdUnique Then

                EcritureMessage(index, "[Dofus]", "En attente de la réponse de " & nomReceveur & " pour un échange...", Color.Orange)

            Else

                EcritureMessage(index, "[Dofus]", nomLanceur & " vous propose de faire un échange." & vbCrLf & "Acceptez-vous ? Oui/Non", Color.Orange)

            End If

            .BloqueEchange.Set()

        End With

    End Sub

    Public Sub GaEchangeValider(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' EK1 1234567
            ' EK1 IdJoueur

            data = Mid(data, 4)

            If data = .IdUnique Then

                EcritureMessage(index, "(Bot)", "Vous avez accepté l'échange.", Color.Orange)

                .EchangeValiderLuiMoi(1) = True

            Else

                EcritureMessage(index, "(Bot)", .EchangeIdNomLanceur(1) & " a accepté l'échange.", Color.Orange)

                .EchangeValiderLuiMoi(0) = True

            End If

            .BloqueEchange.Set()

        End With

    End Sub

    Public Sub GaEchangeInvalider(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' EK0 1234567
            ' EK0 IdJoueur

            data = Mid(data, 4)

            EcritureMessage(index, "(Bot)", "Un changement a eu lieu dans l'échange, vous pouvez de nouveau valider l'échange.", Color.Orange)

            If data = .IdUnique Then

                .EchangeValiderLuiMoi(1) = False

            Else

                .EchangeValiderLuiMoi(0) = False

            End If

            .BloqueEchange.Set()

        End With

    End Sub

    Public Sub GaEchangeKamasPoserMoi(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' EMKG 1000
            ' EMKG Kamas

            data = Mid(data, 5)

            .EchangeKamasMoi = data

            EcritureMessage(index, "[Dofus]", "Vous avez déposé " & data & " kamas.", Color.Orange)

            .BloqueEchange.Set()

        End With

    End Sub

    Public Sub GaEchangeKamasPoserLui(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' EmKG 1000
            ' EmKG Kamas

            data = Mid(data, 5)

            .EchangeKamasLui = data

            EcritureMessage(index, "[Dofus]", "Il a déposé " & data & " kamas.", Color.Orange)

        End With

    End Sub

End Module
