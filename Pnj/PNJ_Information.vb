Module PNJ_Information

    Public Sub GaPnjDialogue(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' DCK -2  
            ' DCK ID sur la map

            .EnDialogue = True

            'J'affiche le nom du PNJ auquel je parle.

            Dim idUnique As String = Mid(data, 4)

            For Each Pair As DataGridViewRow In .FrmUser.DataGridViewMap.Rows

                If Pair.Cells(1).Value = idUnique Then

                    EcritureMessage(index, "[Dofus]", "Je parle actuellement avec " & Pair.Cells(2).Value, Color.Orange)

                    Exit For

                End If

            Next

        End With

    End Sub

    Public Sub GaPnjQuestionReponse(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' DQ 318        ; 449                                           |   259     ;    329    ;
            ' DQ ID Réponse ; Information à mettre dans le dialogue de base | Réponse 1 ; Réponse 2 ; etc....

            .ListePnjReponseDisponible.Clear()
            .DialogueReponse = 0

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            .DialogueReponse = Split(separateData(0), ";")(0)

            If data.Contains("|") Then

                separateData = Split(separateData(1), ";")

                For i = 0 To separateData.Count - 1

                    .ListePnjReponseDisponible.Add(separateData(i))

                    EcritureMessage(index, "[Dofus - Réponse]", i + 1 & ") " & DicoPnjReponse(separateData(i)), Color.Green)

                Next

            Else

                EcritureMessage(index, "(Bot)", "Il n'y a plus aucune réponse disponible pour ce Pnj.", Color.Green)

            End If

        End With

    End Sub

End Module
