Module Métier_Information

    ' A modifier/améliorer.

    Public Sub GaMétierInformation(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' JS | 17        ; 142                   ~ 2                    ~ 0                    ~ 0 ~ 70                  , next info métier actuel | Nex métier
            ' JS | ID_Métier ; ID_Atelier/ressources ~ Nbr_Case/Récolte min ~ Nbr_Case/Récolte max ~ ? ~ %_Réussite ou temps ,                         |

            Dim separateData As String() = Split(data, "|")

            For i = 1 To separateData.Count - 1

                Dim separateInfo As String() = Split(separateData(i), ";")

                Dim idMetier As Integer = separateInfo(0)

                If MétierExistInformation(index, idMetier, separateInfo(1)) = False Then

                    separateInfo = Split(separateInfo(1), ",")

                    Dim frmMetier As New FrmMétier

                    With frmMetier

                        .SetIndexPanelPersonnage = index

                        .Name = idMetier

                        .PictureBoxMetier.Image = New Bitmap(Application.StartupPath & "\Image/" & DicoMétier(idMetier).NomMetier & ".png")

                        For a = 0 To separateInfo.Count - 1

                            Dim separate As String() = Split(separateInfo(a), "~")

                            With .ListViewMétier

                                .Items.Add(DicoMétier(idMetier).Atelier(separate(0)).GetValue(0))

                                With .Items(.Items.Count - 1)

                                    .SubItems.Add(DicoMétier(idMetier).Atelier(separate(0)).GetValue(1))

                                    .SubItems.Add(separate(1))

                                    If separate(2) <> "0" Then

                                        .SubItems.Add(separate(2))

                                    Else

                                        .SubItems.Add(separate(4))

                                    End If

                                End With

                            End With

                        Next

                    End With

                    .FrmUser.FlowLayoutPanelMetier.Controls.Add(frmMetier)

                End If

            Next

        End With

    End Sub

    Private Function MétierExistInformation(ByVal index As Integer, ByVal idMetier As String, ByVal information As String)

        With Comptes(index)

            For Each C As Control In .FrmUser.FlowLayoutPanelMetier.Controls

                If TypeOf C Is FrmMétier Then

                    Dim cMetier As FrmMétier = DirectCast(C, FrmMétier)

                    If cMetier.Name = idMetier Then

                        cMetier.ListViewMétier.Items.Clear()

                        Dim separateInfo As String() = Split(information, ",")

                        For a = 0 To separateInfo.Count - 1

                            Dim separate As String() = Split(separateInfo(a), "~")

                            With cMetier.ListViewMétier

                                .Items.Add(DicoMétier(idMetier).Atelier(separate(0)).GetValue(0))

                                With .Items(.Items.Count - 1)

                                    .SubItems.Add(DicoMétier(idMetier).Atelier(separate(0)).GetValue(1))

                                    .SubItems.Add(separate(1))

                                    If separate(2) <> "0" Then

                                        .SubItems.Add(separate(2))

                                    Else

                                        .SubItems.Add(separate(4))

                                    End If

                                End With

                            End With

                        Next

                        Return True

                    End If

                End If

            Next

            Return False

        End With

    End Function

    Public Sub GaMetierUp(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'JN 28        | 73
            'JN ID Métier | Level

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            For Each C As Control In .FrmUser.FlowLayoutPanelMetier.Controls

                If TypeOf C Is FrmMétier Then

                    Dim cMetier As FrmMétier = DirectCast(C, FrmMétier)

                    If cMetier.Name = separateData(0) Then

                        cMetier.LabelMétier.Text = "Niveau : " & separateData(1)

                        Exit For

                    End If

                End If

            Next
            EcritureMessage(index, "(Dofus)", "Ton métier " & DicoMétier(separateData(0)).NomMetier & " passe niveau " & separateData(1) & ".", Color.Green)

        End With

    End Sub

    Public Sub GaMetierNiveauXp(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' JX | 17         ; 42     ; 41044   ; 43205      ; 43378   ; ? |
            ' JX | ID_Métiers ; Niveau ; Exp_Min ; Exp_actuel ; Exp_Max ;   | Métier_Suivant

            Dim separateData As String() = Split(data, "|")

            For i = 1 To separateData.Count - 1

                Dim separate As String() = Split(separateData(i), ";")

                If separate(4) < 0 Then separate(4) = separate(3)

                For Each C As Control In .FrmUser.FlowLayoutPanelMetier.Controls

                    If TypeOf C Is FrmMétier Then

                        Dim cMetier As FrmMétier = DirectCast(C, FrmMétier)

                        If cMetier.Name = separate(0) Then

                            With cMetier

                                .LabelMétier.Text = "Niveau : " & separate(1)

                                With .ProgressBarMétier

                                    .Minimum = separate(2)
                                    .Maximum = separate(4)
                                    .Value = separate(3)

                                End With

                            End With

                            .FrmUser.ToolTip1.SetToolTip(cMetier.ProgressBarMétier, separate(3) & "/" & separate(4))

                            Exit For

                        End If

                    End If

                Next

            Next

        End With

    End Sub

    Public Sub GaMetierOption(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'JO 0             | 4                      | 5
            'JO Numéro_Métier | Nombre_Pour_Check_Case | 5 

            data = Mid(data, 3)

            Dim separateData As String() = Split(data, "|")

            For i = 0 To .FrmUser.FlowLayoutPanelMetier.Controls.Count - 1

                If i = CInt(separateData(0)) Then

                    If TypeOf .FrmUser.FlowLayoutPanelMetier.Controls.Item(i) Is FrmMétier Then

                        Dim cMetier As FrmMétier = DirectCast(.FrmUser.FlowLayoutPanelMetier.Controls.Item(i), FrmMétier)

                        With cMetier

                            .CheckBoxRessource.Checked = False
                            .CheckBoxGratuit.Checked = False
                            .CheckBoxPayant.Checked = False
                            .ComboBoxMetier.Text = separateData(2)

                            While CInt(separateData(1)) > 0

                                Select Case separateData(1)

                                    Case >= 4 'Ne Fournit aucune ressource

                                        .CheckBoxRessource.Checked = True
                                        separateData(1) = CInt(separateData(1)) - 4

                                    Case >= 2 'Gratuit sur échec

                                        .CheckBoxGratuit.Checked = True
                                        separateData(1) = CInt(separateData(1)) - 2

                                    Case >= 1 'Payant

                                        .CheckBoxPayant.Checked = True
                                        separateData(1) = CInt(separateData(1)) - 1

                                End Select

                            End While

                        End With

                    End If

                    Exit For

                End If

            Next

        End With

    End Sub

    Public Sub GaMetierSupprime(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            data = Mid(data, 3)

            For Each C As Control In .FrmUser.FlowLayoutPanelMetier.Controls

                If TypeOf C Is FrmMétier Then

                    Dim cMetier As FrmMétier = DirectCast(C, FrmMétier)

                    If cMetier.Name = data Then

                        .FrmUser.FlowLayoutPanelMetier.Controls.Remove(cMetier)

                        Exit For

                    End If

                End If

            Next

            EcritureMessage(index, "[Dofus]", "Tu as désappris le métier " & DicoMétier(data).NomMetier & ".", Color.Green)

        End With

    End Sub

End Module
