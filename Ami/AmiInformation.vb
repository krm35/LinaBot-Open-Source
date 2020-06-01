Module AmiInformation

    Public Sub GaAmiReçoitListe(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'FL | Leroienculeurné ; 1      ; Linaculers   ; 1     ; 0           ; 7         ; 1    ; 71 
            'FL | Pseudo          ; en ami ; Nom          ; Level ; alignement  ; id classe ; Sexe ; classe + sexe

            Dim separateData As String() = Split(data, "|")

            .FrmUser.ListViewAmi.Items.Clear()

            If separateData.Length > 1 Then

                For i = 1 To separateData.Count - 1

                    Dim separate As String() = Split(separateData(i), ";")

                    With .FrmUser.ListViewAmi

                        .Items.Add(separate(0))

                        With .Items(.Items.Count - 1)

                            If separate.Length > 1 Then

                                ' En Ami
                                .SubItems.Add(If(separate(1) = "?", "Non", "Oui"))

                                ' Nom
                                .SubItems.Add(separate(2))

                                ' Niveau
                                .SubItems.Add(separate(3))

                                ' Alignement
                                Select Case separate(4)

                                    Case "0"

                                        .SubItems.Add("Neutre")

                                    Case "1"

                                        .SubItems.Add("Bontarien")

                                    Case "2"

                                        .SubItems.Add("Brakmarien")

                                    Case Else

                                        .SubItems.Add("Inconnu")

                                End Select

                                ' Classe
                                Select Case separate(5)
                                    Case "1"
                                        .SubItems.Add("Feca")
                                    Case "2"
                                        .SubItems.Add("Osamodas")
                                    Case "3"
                                        .SubItems.Add("Enutrof")
                                    Case "4"
                                        .SubItems.Add("Sram")
                                    Case "5"
                                        .SubItems.Add("Xelor")
                                    Case "6"
                                        .SubItems.Add("Ecaflip")
                                    Case "7"
                                        .SubItems.Add("Eniripsa")
                                    Case "8"
                                        .SubItems.Add("Iop")
                                    Case "9"
                                        .SubItems.Add("Crâ")
                                    Case "10"
                                        .SubItems.Add("Sadida")
                                    Case "11"
                                        .SubItems.Add("Sacrieur")
                                    Case "12"
                                        .SubItems.Add("Pandawa")
                                End Select

                                ' Sexe
                                Select Case separate(6)
                                    Case "0"
                                        .SubItems.Add("Male")
                                    Case "1"
                                        .SubItems.Add("Femelle")
                                End Select

                                ' Classe + Sexe
                                .SubItems.Add(separate(5) & separate(6))

                                If .SubItems(1).Text = "Oui" Then

                                    .BackColor = Color.Lime

                                End If

                            Else

                                For a = 1 To 7

                                    .SubItems.Add("")

                                Next

                                .BackColor = Color.Red

                            End If

                        End With

                    End With

                Next

            End If

            .BloqueAmi.Set()

        End With

    End Sub

    Public Sub GaAmiAjoutRéussi(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' FAK Linacu ; 2 ; Linaculer ; 99     ; 9      ; 0    ; 90 
            ' FAK Pseudo ; ? ; Nom       ; Niveau ; Classe ; Sexe ; Classe + Sexe

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, ";")

            EcritureMessage(index, "[Dofus]", "(" & separateData(0) & ") " & separateData(2) & " a été ajouté à votre liste d'ami.", Color.Green)

        End With

    End Sub

    Public Sub GaEnnemiReçoitListe(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            'iL | Leroienculeurné ; 1      ; Linaculers   ; 1     ; 0           ; 7         ; 1    ; 71 
            'iL | Pseudo          ; en ami ; Nom          ; Level ; alignement  ; id classe ; Sexe ; classe + sexe

            Dim separateData As String() = Split(data, "|")

            .FrmUser.ListViewAmi.Items.Clear()

            If separateData.Length > 1 Then

                For i = 1 To separateData.Count - 1

                    Dim separate As String() = Split(separateData(i), ";")

                    With .FrmUser.ListViewAmi

                        .Items.Add(separate(0))

                        With .Items(.Items.Count - 1)

                            If separate.Length > 1 Then

                                ' En Ami
                                .SubItems.Add(If(separate(1) = "?", "Non", "Oui"))

                                ' Nom
                                .SubItems.Add(separate(2))

                                ' Niveau
                                .SubItems.Add(separate(3))

                                ' Alignement
                                Select Case separate(4)

                                    Case "0"

                                        .SubItems.Add("Neutre")

                                    Case "1"

                                        .SubItems.Add("Bontarien")

                                    Case "2"

                                        .SubItems.Add("Brakmarien")

                                    Case Else

                                        .SubItems.Add("Inconnu")

                                End Select

                                ' Classe
                                Select Case separate(5)
                                    Case "1"
                                        .SubItems.Add("Feca")
                                    Case "2"
                                        .SubItems.Add("Osamodas")
                                    Case "3"
                                        .SubItems.Add("Enutrof")
                                    Case "4"
                                        .SubItems.Add("Sram")
                                    Case "5"
                                        .SubItems.Add("Xelor")
                                    Case "6"
                                        .SubItems.Add("Ecaflip")
                                    Case "7"
                                        .SubItems.Add("Eniripsa")
                                    Case "8"
                                        .SubItems.Add("Iop")
                                    Case "9"
                                        .SubItems.Add("Crâ")
                                    Case "10"
                                        .SubItems.Add("Sadida")
                                    Case "11"
                                        .SubItems.Add("Sacrieur")
                                    Case "12"
                                        .SubItems.Add("Pandawa")
                                End Select

                                ' Sexe
                                Select Case separate(6)
                                    Case "0"
                                        .SubItems.Add("Male")
                                    Case "1"
                                        .SubItems.Add("Femelle")
                                End Select

                                ' Classe + Sexe
                                .SubItems.Add(separate(5) & separate(6))

                                If .SubItems(1).Text = "Oui" Then

                                    .BackColor = Color.Lime

                                End If

                            Else

                                For a = 1 To 7

                                    .SubItems.Add("")

                                Next

                                .BackColor = Color.Red

                            End If

                        End With

                    End With

                Next

            End If

            .BloqueAmi.Set()

        End With

    End Sub

    Public Sub GaEnnemiAjoutRéussi(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' iAK Linacu ; 2 ; Linaculer ; 99     ; 9      ; 0    ; 90 
            ' iAK Pseudo ; ? ; Nom       ; Niveau ; Classe ; Sexe ; Classe + Sexe

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, ";")

            EcritureMessage(index, "[Dofus]", "(" & separateData(0) & ") " & separateData(2) & " a été ajouté à votre liste d'ennemi.", Color.Green)

        End With

    End Sub

    Public Sub GaAmiEnnemiInformation(ByVal index As Integer, ByVal data As String)

        With Comptes(index)

            ' BWK Linaculer | 1 | Lenculé | 7
            ' BWK Pseudo    | ? | Nom     | Zone

            data = Mid(data, 4)

            Dim separateData As String() = Split(data, "|")

            Dim phrase As String = separateData(2) & " (" & separateData(1) & ") se trouve en "

            Select Case separateData(3)

                Case "-1"

                    phrase &= "zone inconnue."

                Case "7"

                    phrase &= "bonta."

            End Select

            EcritureMessage(index, "[Dofus]", phrase, Color.Green)

            .BloqueAmi.Set()

        End With

    End Sub

End Module
