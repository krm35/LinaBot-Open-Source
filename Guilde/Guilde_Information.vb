Module Guilde_Information

    Public Sub GaGuildeIntégrer(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' gS LinaculerBot | a | 0 | i | 4erdr | 0
            ' gS Nom Guilde   | ? | ? | ? | ?     | ?

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            .EnGuilde = True

            If .GuildeInvitation Then

                EcritureMessage(index, "[Guilde]", "Tu viens d'intégrer la guilde " & separateData(0), Color.DarkViolet)

            Else

                EcritureMessage(index, "[Guilde]", "Votre guilde est : " & separateData(0), Color.DarkViolet)

            End If

        End With

    End Sub

    Public Sub GaGuildeBanni(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'gKK Linaculer  | Simeth
            'gKK Bannisseur | Banni

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            If separateData(0) = .NomDuPersonnage Then

                EcritureMessage(index, "[Dofus]", "Tu as banni " & separateData(1) & " de ta guilde.", Color.Green)

            Else

                .EnGuilde = False

                EcritureMessage(index, "[Dofus]", separateData(0) & " t'a banni de la guilde", Color.Green)

            End If

        End With

    End Sub

End Module
