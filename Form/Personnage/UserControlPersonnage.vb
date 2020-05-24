
' refonte à faire En cours de DEV 

Public Class UserControlPersonnage

#Region "Variable"

    Public WriteOnly Property SetIndexPanelPersonnage As Integer
        Set(value As Integer)
            Index = value
        End Set
    End Property

    Dim Index As Integer
    Dim NbrLigneTchat, NbrLigneSocket As Integer

#End Region

#Region "Button"

    Private Sub ButtonConnexion_Click(sender As Object, e As EventArgs) Handles ButtonConnexion.Click

        With Comptes(Index)

            Select Case sender.Text

                Case "Connexion"

                    .CreateSocketAuthentification(DicoServeur("Authentification").IP, DicoServeur("Authentification").Port)

                Case "Déconnexion"

                    Select Case .Connecté

                        Case True

                            .Socket.Connexion_Game(False)

                        Case False

                            .Socket_Authentification.Connexion_Game(False)

                    End Select

            End Select

        End With

    End Sub

#End Region

#Region "Load"

    Private Sub UserControlPersonnage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxTchat.SelectedIndex = 0

    End Sub

#End Region

#Region "RichTextBox"

    Private Sub RichTextBoxSocket_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxSocket.TextChanged

        If NbrLigneSocket > 1000 Then

            RichTextBoxSocket.Text = ""

            NbrLigneSocket = 0

        Else

            NbrLigneSocket += 1

        End If

    End Sub

    Private Sub RichTextBoxTchat_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxTchat.TextChanged

        If NbrLigneTchat > 100 Then

            RichTextBoxTchat.Text = ""

            Comptes(Index).TchatItem.Clear()

            NbrLigneTchat = 0

        Else

            NbrLigneTchat += 1

        End If

    End Sub

    Dim PositionInterne As Long
    Dim PositionStart As Integer
    Private Sub RichTextBoxTchat_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBoxTchat.Click

        With Comptes(Index)

            If RichTextBoxTchat.SelectionFont.Bold Then

                PositionInterne = RichTextBoxTchat.SelectionStart
                PositionStart = RichTextBoxTchat.SelectionStart

                RichTextBoxTchat.SelectionStart = RechercheArriere()
                RichTextBoxTchat.SelectionLength = RechercheAvant() - RichTextBoxTchat.SelectionStart - 1

                If RichTextBoxTchat.SelectionStart > 0 AndAlso RichTextBoxTchat.SelectionLength > 0 Then

                    If .TchatItem.ContainsKey(RichTextBoxTchat.SelectedText) Then

                        MsgBox(.TchatItem(RichTextBoxTchat.SelectedText))

                        RichTextBoxTchat.SelectedText = RichTextBoxTchat.SelectedText

                    End If

                End If

            End If

        End With

    End Sub

    Private Function RechercheArriere() As Integer

        For PositionInterne = PositionStart - 1 To 0 Step -1
            If PositionInterne = 0 Then Exit For
            If Mid(RichTextBoxTchat.Text, PositionInterne, Len("[")) = "[" Then
                Return PositionInterne
            End If
        Next

        Return 0

    End Function

    Private Function RechercheAvant() As Integer

        For PositionInterne = PositionInterne To RichTextBoxTchat.Text.Length
            If PositionInterne = 0 Then Exit For
            If Mid(RichTextBoxTchat.Text, PositionInterne, Len("]")) = "]" Then
                Return PositionInterne
            End If
        Next

        Return 0

    End Function

#End Region

#Region "Timer"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerStatut.Tick

        With Comptes(Index)

            If .Connecté Then

                If 0 = 1 Then

                Else

                    LabelStatut.Text = "En Attente"
                    LabelStatut.ForeColor = Color.White

                End If

            End If

        End With

    End Sub

    Private Sub TimerRegeneration_Tick(sender As Object, e As EventArgs) Handles TimerRegeneration.Tick

        With Comptes(Index)

            If .EnCombat = False AndAlso .Connecté Then

                If ProgressBarVitalite.Value < ProgressBarVitalite.Maximum Then

                    ProgressBarVitalite.Value += 1

                End If

            End If

        End With

    End Sub

#End Region

#Region "Tchat"

#Region "Textbox"

    Dim tchatItem As String
    Dim tchatJoueur As String

    Private Sub TextBoxTchatJoueur_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTchatJoueur.Click

        TextBoxTchatJoueur.Text = ""

    End Sub

    Private Sub TextBoxTchat_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxTchat.KeyDown

        If e.KeyCode = 13 Then

            Dim canal As String = ComboBoxTchat.Text
            Dim text As String = TextBoxTchat.Text
            Dim item As String = tchatItem
            Dim joueur As String = tchatJoueur

            Task.Run(Sub() TchatCanal(Index, canal, text, joueur, item))

            tchatItem = ""
            tchatJoueur = ""
            TextBoxTchat.Text = ""
            TextBoxTchatJoueur.Text = "Nom Joueur"

        End If

    End Sub


#End Region

#Region "ToolStripMenuItem"

    Private Sub MettreLitemDansLeTchatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MettreLitemDansLeTchatToolStripMenuItem.Click

        'Faire un boucle qui regarde chaque caractér si [ le bot attend d'arrive a ] pour continuer a mettre dans tchatmsgfinal
        'et quand il et sur le [ il met le numéro de l'item °0 etc....

        TextBoxTchat.Text &= " [" & DataGridViewInventaire.CurrentRow.Cells(2).Value & "] "

        If tchatItem <> "" Then

            tchatItem &= "!" & DataGridViewInventaire.CurrentRow.Cells(0).Value & "!" & DataGridViewInventaire.CurrentRow.Cells(4).ToolTipText.ToString

        Else

            tchatItem = DataGridViewInventaire.CurrentRow.Cells(0).Value & "!" & DataGridViewInventaire.CurrentRow.Cells(4).ToolTipText.ToString

        End If

    End Sub

#End Region

#Region "Button"

    Private Sub Button_Tchat_Envoyer_Click(sender As Object, e As EventArgs) Handles Button_Tchat_Envoyer.Click

        Dim canal As String = ComboBoxTchat.Text
        Dim text As String = TextBoxTchat.Text
        Dim item As String = tchatItem
        Dim joueur As String = tchatJoueur

        Task.Run(Sub() TchatCanal(Index, canal, text, joueur, item))

        tchatItem = ""
        tchatJoueur = ""
        TextBoxTchat.Text = ""
        TextBoxTchatJoueur.Text = "Nom Joueur"

    End Sub



#End Region

#Region "ComboBox"

    Private Sub ComboBoxTchat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTchat.SelectedIndexChanged

        Select Case ComboBoxTchat.Text

            Case "Commun"

                TextBoxTchat.ForeColor = Color.White

            Case "Message privée"

                TextBoxTchat.ForeColor = Color.DodgerBlue

                tchatJoueur = TextBoxTchatJoueur.Text

            Case "Groupe"

                TextBoxTchat.ForeColor = Color.Cyan

            Case "Equipe"

                TextBoxTchat.ForeColor = Color.DeepSkyBlue

            Case "Guilde"

                TextBoxTchat.ForeColor = Color.Violet

            Case "Alignement"

                TextBoxTchat.ForeColor = Color.Orange

            Case "Recrutement"

                TextBoxTchat.ForeColor = Color.Gray

            Case "Commerce"

                TextBoxTchat.ForeColor = Color.Sienna

        End Select

    End Sub

#End Region

#End Region

#Region "Inventaire"

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click

        With Comptes(Index)

            If .Connecté Then

                Dim supprime As New FrmSuppression

                supprime.Index = Index

                supprime.Item = "Od" & DataGridViewInventaire.CurrentRow.Cells(1).Value & "|"

                supprime.TextBox1.Text = DataGridViewInventaire.CurrentRow.Cells(3).Value

                supprime.Show()

            End If

        End With

    End Sub

    Private Sub EquipéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipéToolStripMenuItem.Click

        With Comptes(Index)

            If .Connecté Then

                .Socket.Envoyer("OM" & DataGridViewInventaire.CurrentRow.Cells(1).Value & "|" & ReturnNuméroEquipement(Index, DicoItems(DataGridViewInventaire.CurrentRow.Cells(0).Value).Catégorie))

            End If

        End With

    End Sub

    Private Sub DéséquiperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéséquiperToolStripMenuItem.Click

        With Comptes(Index)

            If .Connecté Then

                .Socket.Envoyer("OM" & DataGridViewInventaire.CurrentRow.Cells(1).Value & "|-1")

            End If

        End With

    End Sub

    Private Sub UtiliserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtiliserToolStripMenuItem.Click

        With Comptes(Index)

            If .Connecté Then

                .Socket.Envoyer("OU" & DataGridViewInventaire.CurrentRow.Cells(1).Value & "|")

            End If

        End With

    End Sub



#End Region

    Private Sub DataGridViewDragodindeEquipé_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDragodindeEquipé.CellContentDoubleClick, DataGridViewDragodindeEnclo.CellContentDoubleClick, DataGridViewDragodindeEtable.CellContentDoubleClick

        If e.ColumnIndex = 2 Then

            Dim DragoArbre As New FrmDragodindeArbreGénéalogique

            With DragoArbre

                Dim Picture As PictureBox() = { .PictureBox10, .PictureBox11, .PictureBox9, .PictureBox5, .PictureBox6, .PictureBox12,
                                                .PictureBox8, .PictureBox4, .PictureBox2, .PictureBox0, .PictureBox1, .PictureBox3,
                                                .PictureBox7, .PictureBox13}

                Dim separate As String() = Split(sender.Rows(e.RowIndex).Cells(2).value, ",")

                For i = 0 To separate.Count - 1

                    If CInt(separate(i)) > 0 Then

                        If IO.File.Exists(Application.StartupPath & "\Image\Dragodinde/" & separate(i) & ".png") Then

                            Picture(i).Image = New Bitmap(Application.StartupPath & "\Image\Dragodinde/" & separate(i) & ".png")

                            .ToolTip1.SetToolTip(Picture(i), "Dragodinde " & DicoDragodindeId(separate(i)))

                        Else

                            Picture(i).Image = New Bitmap(Application.StartupPath & "\Image\Dragodinde/What.png")

                            .ToolTip1.SetToolTip(Picture(i), "Mais quel est ce pokémon ?")

                        End If

                    End If

                Next

                .PictureBox14.Image = New Bitmap(Application.StartupPath & "\Image\Dragodinde/You.gif")
                .ToolTip1.SetToolTip(.PictureBox14, "Votre dragodinde.")

            End With

            DragoArbre.Show()

        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Comptes(Index)
            If .FrmGroupe.ThreadTrajet IsNot Nothing AndAlso .FrmGroupe.ThreadTrajet.IsAlive Then .FrmGroupe.ThreadTrajet.Abort()

            Select Case Button1.Text

                Case "Charger un trajet"

                    Dim Ouverture_Fichier As New OpenFileDialog

                    If Ouverture_Fichier.ShowDialog = 1 Then

                        TrajetLoad(Index, Ouverture_Fichier.FileName)

                        Button1.Text = "Trajet chargé"
                        Button1.ForeColor = Color.Lime

                    Else

                        Button1.Text = "Charger un trajet"
                        Button1.ForeColor = Color.Red

                    End If

                Case Else

                    Button1.Text = "Charger un trajet"
                    Button1.ForeColor = Color.Red

            End Select
        End With
    End Sub

End Class
