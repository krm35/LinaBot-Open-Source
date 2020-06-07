Module Divers

    ' refonte à faire et pas qu'un peu

    Private Delegate Sub dlgDivers()
    Private Delegate Function dlgFDivers()
    Public Sub ErreurFichier(ByVal index As Integer, ByVal nomJoueur As String, ByVal nomErreur As String, ByVal erreur As String)

        Try

            EcritureMessage(index, "[Erreur]", "Une erreur est survenue, veuillez envoyez les fichiers qui se trouve dans le dossier 'Erreur' à l'administrateur.", Color.Red)

            'Si le dossier erreur n'existe pas, alors je le créer
            If Not IO.Directory.Exists(Application.StartupPath & "\Erreur") Then IO.Directory.CreateDirectory(Application.StartupPath & "\Erreur")

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim swEcriture As New IO.StreamWriter(Application.StartupPath + "\Erreur/" & nomJoueur & "_" & nomErreur & ".txt")

            swEcriture.WriteLine(erreur)

            'Puis je le ferme.
            swEcriture.Close()

        Catch ex As Exception

            MsgBox("erreur fichier, impossible de créer le fichier erreur : " & nomErreur & vbCrLf & ex.ToString)

        End Try

    End Sub

    Public Sub EcritureMessage(ByVal Index As Integer, ByVal Indice As String, ByVal Message As String, ByVal Couleur As Color)

        With Comptes(Index).FrmUser

            Try

                If .InvokeRequired Then

                    .Invoke(New dlgDivers(Sub() EcritureMessage(Index, Indice, Message, Couleur)))

                Else

                    .RichTextBoxTchat.SelectionColor = Couleur

                    .RichTextBoxTchat.AppendText("[" & TimeOfDay & "] " & Indice & " " & Message & vbCrLf)

                    .RichTextBoxTchat.ScrollToCaret()

                End If

            Catch ex As Exception

            End Try

        End With

    End Sub

#Region "Initialise"

    Public Sub Initialiser(ByVal index As Integer, ByVal frmGroupe As Groupe)

        With Comptes(index)

            'Je nomme le Tab_Page par le nom du personnage.
            .TabPage.Text = .NomDuPersonnage

            'J'ajoute à la form "groupe", dans le tabcontrol, le tab_page.
            frmGroupe.TabControlGroupe.Controls.Add(.TabPage)

            'Je donne l'index aussi dans le Panel_utilisateur
            .FrmUser.SetIndexPanelPersonnage = index '  .FrmUser.Index = compteur

            'Dans le Tab_Page j'ajoute "Page_Initial"
            .TabPage.Controls.Add(.FrmUser)

            'Permet d'avoir uen scrollbar
            .TabPage.AutoScroll = True

            'Charger les options ici.
            frmGroupe.ListIndex.Add(index)

        End With

    End Sub

#End Region

    Public Function PassEnc(ByVal pwd As String, ByVal key As String) As String
        Dim l1, l2, l3, l4, l5 As Integer, l7 As String = "#1"
        Dim hash() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "_"}
        Dim v1, v2 As String
        For l1 = 1 To Len(pwd)
            l2 = Asc(Mid(pwd, l1, 1))
            l3 = Asc(Mid(key, l1, 1))
            l5 = Fix(l2 / 16)
            l4 = l2 Mod 16
            v1 = hash(((l5 + l3) Mod (UBound(hash) + 1)) Mod (UBound(hash) + 1))
            v2 = hash(((l4 + l3) Mod (UBound(hash) + 1)) Mod (UBound(hash) + 1))
            l7 = l7 + v1 + v2
        Next
        Return l7
    End Function  ' Fonction du cryptage du mot de passe   'Provient de Maxoubot
    Public Function AsciiDecoder(ByVal msg As String) As String
        Dim msgFinal As String = ""
        Dim iMax As Integer = msg.Length
        Dim i As Integer = 0
        While (i < iMax)
            Dim caractC As Char = msg(i)
            Dim caractI As Integer = Asc(caractC)
            Dim nbLettreCode As Integer = 1
            If (caractI And 128) = 0 Then
                msgFinal &= ChrW(caractI)
            Else
                Dim temp As Integer = 64
                Dim codecPremLettre As Integer = 63
                While (caractI And temp)
                    temp >>= 1
                    codecPremLettre = codecPremLettre Xor temp
                    nbLettreCode += 1
                End While
                codecPremLettre = codecPremLettre And 255
                Dim caractIFinal As Integer = caractI And codecPremLettre
                nbLettreCode -= 1
                i += 1
                While (nbLettreCode <> 0)
                    caractC = msg(i)
                    caractI = Asc(caractC)
                    caractIFinal <<= 6
                    caractIFinal = caractIFinal Or (caractI And 63)
                    nbLettreCode -= 1
                    i += 1
                End While
                msgFinal &= ChrW(caractIFinal)
            End If
            i += nbLettreCode
        End While
        Return msgFinal.Replace("%27", "'").Replace("%C3%A9", "é").Replace("%2C", ",").Replace("%3F", "?").Replace("%C3%A8", "é")
    End Function 'Provient de Maxoubot.

#Region "Cryptage/Décryptage"
    'Idem a refaire en comm
    'Maxoubot
    Public Function DécryptIP(ByVal IP_Crypt As String) As String

        ' Fonction de cryptage serveur      

        Dim i As Long = 0
        Dim fois As Long = 0
        Dim ipServeurJeu As String = ""

        While (i < 8)

            i = i + 1
            fois = fois + 1

            Dim dat1 As Integer = Asc(Mid(IP_Crypt, i, 1)) - 48

            i = i + 1

            Dim dat2 As Integer = Asc(Mid(IP_Crypt, i, 1)) - 48
            Dim Dat3 As String = Str((dat1 And 15) << 4 Or dat2 And 15)

            If fois > 1 Then
                ipServeurJeu = ipServeurJeu + Mid(Dat3, 2)
            Else
                ipServeurJeu = ipServeurJeu + Dat3
            End If

            If i < 8 Then
                ipServeurJeu = ipServeurJeu + "."
            End If

        End While

        Return ipServeurJeu.Replace(" ", "")

    End Function
    'Idem a refaire en comm

    'Salesprendes
    Dim caracteres_array As Char() = New Char() {"a"c, "b"c, "c"c, "d"c, "e"c, "f"c, "g"c, "h"c, "i"c, "j"c, "k"c, "l"c, "m"c, "n"c, "o"c, "p"c, "q"c, "r"c, "s"c, "t"c, "u"c, "v"c, "w"c, "x"c, "y"c, "z"c, "A"c, "B"c, "C"c, "D"c, "E"c, "F"c, "G"c, "H"c, "I"c, "J"c, "K"c, "L"c, "M"c, "N"c, "O"c, "P"c, "Q"c, "R"c, "S"c, "T"c, "U"c, "V"c, "W"c, "X"c, "Y"c, "Z"c, "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "-"c, "_"c}

    Public Function DécryptPort(ByVal chars As Char()) As Integer

        If chars.Length <> 3 Then Throw New ArgumentOutOfRangeException("Le port doit contenir au minimum 3 caractéres.")

        Dim port As Integer = 0

        For i As Integer = 0 To 2 - 1
            port += CInt((Math.Pow(64, 2 - i) * get_Hash(chars(i))))
        Next

        port += get_Hash(chars(2))

        Return port
    End Function
    Public Function get_Hash(ByVal ch As Char) As Short

        For i As Short = 0 To caracteres_array.Length - 1

            If caracteres_array(i) = ch Then Return i

        Next

    End Function

#End Region



    Public Function ReplaceInformation(ByVal information As String, ByVal Chercher As String, ByVal Remplace As String) As String

        Dim separateInformation As String() = Split(information, vbCrLf)

        Dim résultat As String = ""

        For i = 0 To separateInformation.Count - 1

            Dim separate As String() = Split(separateInformation(i), " : ")

            If separate(0) = Chercher Then

                If Remplace <> "" Then

                    résultat &= Remplace & vbCrLf

                End If

            Else

                résultat &= separateInformation(i) & vbCrLf

            End If

        Next

        Return résultat

    End Function

    Public Function RenvoieInformation(ByVal information As String, ByVal Chercher As String) As String

        Dim separateInformation As String() = Split(information, vbCrLf)

        For i = 0 To separateInformation.Count - 1

            Dim separate As String() = Split(separateInformation(i), " : ")

            If separate(0) = Chercher Then

                Return separate(1)

            End If

        Next

        Return ""

    End Function

    Public Function CopyDatagridView(ByVal Index As Integer, ByVal row As DataGridView) As DataGridView

        With Comptes(Index)

            If .FrmUser.InvokeRequired Then

                Return .FrmUser.Invoke(New dlgFDivers(Function() CopyDatagridView(Index, row)))

            Else

                Dim Data As New DataGridView With {.AllowUserToAddRows = False}

                For Each Col As DataGridViewColumn In row.Columns
                    Data.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
                Next

                For rowIndex As Integer = 0 To (row.Rows.Count - 1)

                    Data.Rows.Add(row.Rows(rowIndex).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)

                    For cellIndex As Integer = 0 To row.Rows(rowIndex).Cells.Count - 1
                        Data.Rows(rowIndex).Cells(cellIndex).ToolTipText = row.Rows(rowIndex).Cells(cellIndex).ToolTipText

                    Next

                    Data.Rows(rowIndex).DefaultCellStyle.BackColor = row.Rows(rowIndex).DefaultCellStyle.BackColor

                Next

                Return Data

            End If

        End With

        Return Nothing

    End Function

    Public Function CopyListView(ByVal Index As Integer, ByVal La_Listview As ListView) As ListView
        'Je met une listview u lieu d'un arraylist pour les utilisateurs qui débute, 
        'il sera plus simple pour eux de comprendre le code s'ils ont toujours une listview.

        With Comptes(Index)

            If .FrmUser.InvokeRequired Then

                'Ne pas oublier de "return" l'invoke, sinon il retourne du vide !
                Return .FrmUser.Invoke(New dlgFDivers(Function() CopyListView(Index, La_Listview)))

            Else

                Dim New_Liste As New ListView With {.CheckBoxes = True}

                For Each Line As ListViewItem In La_Listview.Items

                    With New_Liste

                        .Items.Add(Line.SubItems(0).Text)

                        With .Items(.Items.Count - 1)

                            For i = 1 To Line.SubItems.Count - 1

                                .SubItems.Add(Line.SubItems(i).Text)

                            Next

                            .BackColor = Line.BackColor

                        End With

                    End With

                Next

                Return New_Liste

            End If

        End With

    End Function


End Module
