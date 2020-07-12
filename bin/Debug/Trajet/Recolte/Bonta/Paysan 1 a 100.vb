Private Map, Direction As String

Dim Pods As Integer = 80

Sub Main()

    'Condition
    '1) Départ Banque Bonta
    '2) Avoir le métier Paysan
    '3) Avoir équipé la Faux

    'Si le métier n'existe pas, Je pars depuis la Banque d'Astrub pour apprendre le métier.
    If Boolean = MetierExist("Paysan") = False Then

        Call ApprendMetier()

    End If

    'Si je suis sur la map du Pnj pour apprendre le métier.
    If Boolean = Map("7613") = True Then

        'Si je n'est pas l'arme en inventaire je l'achète auprès du PNJ.
        If Boolean = ItemExist("Inventaire", "Faux du Paysan") = False Then

            Call PnjAcheteItem()

        End If

    End If

    'Si j'ai l'item sur moi, mais qu'elle n'est pas équipé.
    If Boolean = EquipementEquiper("Faux du Paysan") = False Then

        EquipeItem("Faux du Paysan")

    End If

    'Si j'ai l'item équiper et le métier, je pars faire mes récoltes.
    If Boolean = EquipementEquiper("Faux du Paysan") = True Then

        If Boolean = MetierExist("Paysan") = True Then

            If Integer = Pods("Actuelle") < 80 Then

                Select Case MetierNiveau("Paysan")

                    Case Integer < 10

                        Call Paysan_1_10() 'Blé

                    Case Integer < 20

                        Call Paysan_10_20() 'Orge

                    Case Integer < 30

                        Call Paysan_20_30() 'Avoine

                    Case Integer < 40

                        Call Paysan_30_40() 'Houblon

                    Case Integer < 50

                        Call Paysan_40_50()   'Lin

                    Case Integer < 60

                        Call Paysan_50_60()  'Seigle

                    Case Integer < 70

                        Call Paysan_60_70() 'Malt

                    Case Integer < 100

                        Call Paysan_70_100()  'Chanvre

                    Case Else

                End Select

            Else

                Call BanqueBonta()

            End If

        End If

    End If

    If Integer = Pods("Actuelle") > 80 Then

        Call BanqueBonta()

    End If

End Sub

#Region "Récolte Paysan"

Sub Paysan_1_10()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Droite")
    Map("[-28,-45]") : Direction("Droite")
    Map("[-27,-45]") : Direction("Droite")
    Map("[-26,-45]") : Direction("Droite")
    Map("[-25,-45]") : Direction("Droite")
    Map("[-24,-45]") : Direction("Droite")
    Map("[-23,-45]") : Recolte("Ble") : Direction("Haut")
    Map("[-23,-46]") : Recolte("Ble") : Direction("Haut")
    Map("[-23,-47]") : Recolte("Ble") : Direction("Haut")
    Map("[-23,-48]") : Recolte("Ble") : Direction("Haut")
    Map("[-23,-49]") : Recolte("Ble") : Direction("Droite")
    Map("[-22,-49]") : Recolte("Ble") : Direction("Bas")
    Map("[-22,-48]") : Recolte("Ble") : Direction("Bas")
    Map("[-22,-47]") : Recolte("Ble") : Direction("Bas")
    Map("[-22,-46]") : Recolte("Ble") : Direction("Bas")
    Map("[-22,-45]") : Recolte("Ble") : Direction("Droite")
    Map("[-21,-45]") : Recolte("Ble") : Direction("Haut")
    Map("[-21,-46]") : Recolte("Ble") : Direction("Haut")
    Map("[-21,-47]") : Recolte("Ble") : Direction("Haut")
    Map("[-21,-48]") : Recolte("Ble") : Direction("Haut")
    Map("[-21,-49]") : Recolte("Ble") : Direction("Haut")
    Map("[-21,-50]") : Recolte("Ble") : Direction("Droite")
    Map("[-20,-50]") : Recolte("Ble") : Direction("Bas")
    Map("[-20,-49]") : Recolte("Ble") : Direction("Bas")
    Map("[-20,-48]") : Recolte("Ble") : Direction("Droite")
    Map("[-19,-48]") : Recolte("Ble") : Direction("Bas")
    Map("[-19,-47]") : Recolte("Ble") : Direction("Gauche")
    Map("[-20,-47]") : Recolte("Ble") : Direction("Bas")
    Map("[-20,-46]") : Recolte("Ble") : Direction("Bas")
    Map("[-20,-45]") : Recolte("Ble") : Direction("Bas")
    Map("[-20,-44]") : Recolte("Ble") : Direction("Bas")
    Map("[-20,-43]") : Recolte("Ble") : Direction("Gauche")
    Map("[-21,-43]") : Recolte("Ble") : Direction("Haut")
    Map("[-21,-44]") : Recolte("Ble") : Direction("Gauche")
    Map("[-22,-44]") : Recolte("Ble") : Direction("Gauche")
    Map("[-23,-44]") : Recolte("Ble") : Direction("Haut")
End Sub

Sub Paysan_10_20()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Droite")
    Map("[-28,-45]") : Direction("Droite")
    Map("[-27,-45]") : Direction("Droite")
    Map("[-26,-45]") : Direction("Droite")
    Map("[-25,-45]") : Direction("Droite")
    Map("[-24,-45]") : Direction("Droite")
    Map("[-23,-45]") : Direction("Bas")
    Map("[-23,-44]") : Direction("Bas")
    Map("[-23,-43]") : Direction("Bas")
    Map("[-23,-42]") : Direction("Droite")
    Map("[-22,-42]") : Direction("Droite")
    Map("[-21,-42]") : Direction("Droite")
    Map("[-20,-42]") : Recolte("Ble|Orge") : Direction("Droite")
    Map("[-19,-42]") : Recolte("Ble|Orge") : Direction("Droite")
    Map("[-18,-42]") : Recolte("Ble|Orge") : Direction("Bas")
    Map("[-18,-41]") : Recolte("Ble|Orge") : Direction("Gauche")
    Map("[-19,-41]") : Recolte("Ble|Orge") : Direction("Bas")
    Map("[-19,-40]") : Recolte("Ble|Orge") : Direction("Gauche")
    Map("[-20,-40]") : Recolte("Ble|Orge") : Direction("Haut")
    Map("[-20,-41]") : Recolte("Ble|Orge") : Direction("Haut")

End Sub

Sub Paysan_20_30()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Droite")
    Map("[-28,-45]") : Direction("Droite")
    Map("[-27,-45]") : Direction("Droite")
    Map("[-26,-45]") : Direction("Droite")
    Map("[-25,-45]") : Direction("Droite")
    Map("[-24,-45]") : Direction("Droite")
    Map("[-23,-45]") : Direction("Bas")
    Map("[-23,-44]") : Direction("Bas")
    Map("[-23,-43]") : Direction("Droite")
    Map("[-22,-43]") : Recolte("Avoine") : Direction("Bas")
    Map("[-22,-42]") : Recolte("Avoine") : Direction("Bas")
    Map("[-22,-41]") : Recolte("Avoine") : Direction("Bas")
    Map("[-22,-40]") : Recolte("Avoine") : Direction("Gauche")
    Map("[-23,-40]") : Recolte("Avoine") : Direction("Haut")
    Map("[-23,-41]") : Recolte("Avoine") : Direction("Haut")
    Map("[-23,-42]") : Recolte("Avoine") : Direction("Haut")
    Map("[-23,-43]") : Recolte("Avoine") : Direction("Gauche")
    Map("[-24,-43]") : Recolte("Avoine") : Direction("Bas")
    Map("[-24,-42]") : Recolte("Avoine") : Direction("Bas")
    Map("[-24,-41]") : Recolte("Avoine") : Direction("Gauche")
    Map("[-25,-41]") : Recolte("Avoine") : Direction("Haut")
    Map("[-25,-42]") : Recolte("Avoine") : Direction("Haut")
    Map("[-25,-43]") : Recolte("Avoine") : Direction("Haut")
    Map("[-25,-44]") : Direction("Haut")

End Sub

Sub Paysan_30_40()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Droite")
    Map("[-28,-45]") : Direction("Droite")
    Map("[-27,-45]") : Direction("Bas")
    Map("[-27,-44]") : Direction("Bas")
    Map("[-27,-43]") : Direction("Bas")
    Map("[-27,-42]") : Direction("Bas")
    Map("[-27,-41]") : Direction("Bas")
    Map("[-27,-40]") : Direction("Bas")
    Map("[-27,-39]") : Recolte("Houblon") : Direction("Bas")
    Map("[-27,-38]") : Recolte("Houblon") : Direction("Bas")
    Map("[-27,-37]") : Recolte("Houblon") : Direction("Bas")
    Map("[-27,-36]") : Recolte("Houblon") : Direction("Gauche")
    Map("[-28,-36]") : Recolte("Houblon") : Direction("Haut")
    Map("[-28,-37]") : Recolte("Houblon") : Direction("Haut")
    Map("[-28,-38]") : Recolte("Houblon") : Direction("Haut")
    Map("[-28,-39]") : Recolte("Houblon") : Direction("Droite")

End Sub

Sub Paysan_40_50()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Droite")
    Map("[-28,-45]") : Direction("Droite")
    Map("[-27,-45]") : Direction("Droite")
    Map("[-26,-45]") : Direction("Droite")
    Map("[-25,-45]") : Direction("Droite")
    Map("[-24,-45]") : Direction("Droite")
    Map("[-23,-45]") : Recolte("Lin") : Direction("Haut")
    Map("[-23,-46]") : Recolte("Lin") : Direction("Haut")
    Map("[-23,-47]") : Recolte("Lin") : Direction("Haut")
    Map("[-23,-48]") : Recolte("Lin") : Direction("Haut")
    Map("[-23,-49]") : Recolte("Lin") : Direction("Droite")
    Map("[-22,-49]") : Recolte("Lin") : Direction("Bas")
    Map("[-22,-48]") : Recolte("Lin") : Direction("Bas")
    Map("[-22,-47]") : Recolte("Lin") : Direction("Bas")
    Map("[-22,-46]") : Recolte("Lin") : Direction("Bas")
    Map("[-22,-45]") : Recolte("Lin") : Direction("Droite")
    Map("[-21,-45]") : Recolte("Lin") : Direction("Haut")
    Map("[-21,-46]") : Recolte("Lin") : Direction("Haut")
    Map("[-21,-47]") : Recolte("Lin") : Direction("Haut")
    Map("[-21,-48]") : Recolte("Lin") : Direction("Haut")
    Map("[-21,-49]") : Recolte("Lin") : Direction("Haut")
    Map("[-21,-50]") : Recolte("Lin") : Direction("Droite")
    Map("[-20,-50]") : Recolte("Lin") : Direction("Bas")
    Map("[-20,-49]") : Recolte("Lin") : Direction("Bas")
    Map("[-20,-48]") : Recolte("Lin") : Direction("Droite")
    Map("[-19,-48]") : Recolte("Lin") : Direction("Bas")
    Map("[-19,-47]") : Recolte("Lin") : Direction("Gauche")
    Map("[-20,-47]") : Recolte("Lin") : Direction("Bas")
    Map("[-20,-46]") : Recolte("Lin") : Direction("Bas")
    Map("[-20,-45]") : Recolte("Lin") : Direction("Bas")
    Map("[-20,-44]") : Recolte("Lin") : Direction("Bas")
    Map("[-20,-43]") : Recolte("Lin") : Direction("Gauche")
    Map("[-21,-43]") : Recolte("Lin") : Direction("Haut")
    Map("[-21,-44]") : Recolte("Lin") : Direction("Gauche")
    Map("[-22,-44]") : Recolte("Lin") : Direction("Gauche")
    Map("[-23,-44]") : Recolte("Lin") : Direction("Haut")
End Sub

Sub Paysan_50_60()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Droite")
    Map("[-28,-45]") : Direction("Droite")
    Map("[-27,-45]") : Direction("Droite")
    Map("[-26,-45]") : Direction("Droite")
    Map("[-25,-45]") : Direction("Bas")
    Map("[-25,-44]") : Direction("Bas")
    Map("[-25,-43]") : Recolte("Seigle") : Direction("Bas")
    Map("[-25,-42]") : Recolte("Seigle") : Direction("Bas")
    Map("[-25,-41]") : Recolte("Seigle") : Direction("Bas")
    Map("[-25,-40]") : Recolte("Seigle") : Direction("Gauche")
    Map("[-26,-40]") : Recolte("Seigle") : Direction("Haut")
    Map("[-26,-41]") : Recolte("Seigle") : Direction("Haut")
    Map("[-26,-42]") : Recolte("Seigle") : Direction("Haut")
    Map("[-26,-43]") : Recolte("Seigle") : Direction("Gauche")
    Map("[-27,-43]") : Recolte("Seigle") : Direction("Bas")
    Map("[-27,-42]") : Recolte("Seigle") : Direction("Bas")
    Map("[-27,-41]") : Recolte("Seigle") : Direction("Bas")
    Map("[-27,-40]") : Recolte("Seigle") : Direction("Gauche")
    Map("[-28,-40]") : Recolte("Seigle") : Direction("Gauche")
    Map("[-29,-40]") : Recolte("Seigle") : Direction("Haut")
    Map("[-29,-41]") : Recolte("Seigle") : Direction("Droite")
    Map("[-28,-41]") : Recolte("Seigle") : Direction("Haut")
    Map("[-28,-42]") : Recolte("Seigle") : Direction("Gauche")
    Map("[-29,-42]") : Recolte("Seigle") : Direction("Haut")
    Map("[-29,-43]") : Recolte("Seigle") : Direction("Droite")
    Map("[-28,-43]") : Recolte("Seigle") : Direction("Droite")
    Map("[-27,-43]") : Recolte("Seigle") : Direction("Droite")
    Map("[-26,-43]") : Recolte("Seigle") : Direction("Droite")
End Sub

Sub Paysan_60_70()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Bas")
    Map("[-29,-44]") : Direction("Bas")
    Map("[-29,-43]") : Direction("Bas")
    Map("[-29,-42]") : Direction("Bas")
    Map("[-29,-41]") : Direction("Bas")
    Map("[-29,-40]") : Direction("Bas")
    Map("[-29,-39]") : Recolte("Malt") : Direction("Bas")
    Map("[-29,-38]") : Recolte("Malt") : Direction("Bas")
    Map("[-29,-37]") : Recolte("Malt") : Direction("Gauche")
    Map("[-30,-37]") : Recolte("Malt") : Direction("Haut")
    Map("[-30,-38]") : Recolte("Malt") : Direction("Haut")
    Map("[-30,-39]") : Recolte("Malt") : Direction("Gauche")
    Map("[-31,-39]") : Recolte("Malt") : Direction("Gauche")
    Map("[-32,-39]") : Recolte("Malt") : Direction("Bas")
    Map("[-32,-38]") : Recolte("Malt") : Direction("Droite")
    Map("[-31,-38]") : Recolte("Malt") : Direction("Bas")
    Map("[-31,-37]") : Recolte("Malt") : Direction("Droite")
    Map("[-30,-37]") : Recolte("Malt") : Direction("Droite")
    Map("[-29,-37]") : Recolte("Malt") : Direction("Haut")
    Map("[-29,-38]") : Recolte("Malt") : Direction("Haut")

End Sub

Sub Paysan_70_100()

    Map("10215") : Direction("351")
    Map("5703") : Direction("351")
    Map("10214") : Direction("351")
    Map("4308") : Direction("767")
    Map("[-29,-57]") : Direction("Bas")
    Map("[-29,-56]") : Direction("Bas")
    Map("[-29,-55]") : Direction("Bas")
    Map("[-29,-54]") : Direction("Bas")
    Map("[-29,-53]") : Direction("Bas")
    Map("[-29,-52]") : Direction("Bas")
    Map("[-29,-51]") : Direction("Bas")
    Map("[-29,-50]") : Direction("Bas")
    Map("[-29,-49]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-29,-45]") : Direction("Gauche")
    Map("[-30,-45]") : Recolte("Chanvre") : Direction("Gauche")
    Map("[-31,-45]") : Recolte("Chanvre") : Direction("Bas")
    Map("[-31,-44]") : Recolte("Chanvre") : Direction("Droite")
    Map("[-30,-44]") : Recolte("Chanvre") : Direction("Bas")
    Map("[-30,-43]") : Direction("Gauche")
    Map("[-31,-43]") : Recolte("Chanvre") : Direction("Gauche")
    Map("[-32,-43]") : Recolte("Chanvre") : Direction("Bas")
    Map("[-32,-42]") : Recolte("Chanvre") : Direction("Droite")
    Map("[-31,-42]") : Recolte("Chanvre") : Direction("Bas")
    Map("[-31,-41]") : Recolte("Chanvre") : Direction("Gauche")
    Map("[-32,-41]") : Recolte("Chanvre") : Direction("Bas")
    Map("[-32,-40]") : Recolte("Chanvre") : Direction("Droite")
    Map("[-31,-40]") : Recolte("Chanvre") : Direction("Droite")
    Map("[-30,-40]") : Recolte("Chanvre") : Direction("Droite")
    Map("[-29,-40]") : Direction("Haut")
    Map("[-29,-41]") : Direction("Haut")
    Map("[-29,-42]") : Direction("Haut")
    Map("[-29,-43]") : Direction("Haut")
    Map("[-29,-44]") : Direction("Haut")

End Sub

#End Region

Sub BanqueBonta()

    Map("[-18,-36]") : Direction("Haut")
    Map("[-18,-37]") : Direction("Haut")
    Map("[-18,-38]") : Direction("Haut")
    Map("[-18,-39]") : Direction("Haut")
    Map("[-18,-40]") : Direction("Haut")
    Map("[-18,-41]") : Direction("Haut")
    Map("[-18,-42]") : Direction("Haut")
    Map("[-18,-43]") : Direction("Haut")
    Map("[-18,-44]") : Direction("Haut")
    Map("[-19,-36]") : Direction("Haut")
    Map("[-19,-37]") : Direction("Haut")
    Map("[-19,-38]") : Direction("Haut")
    Map("[-19,-39]") : Direction("Haut")
    Map("[-19,-40]") : Direction("Haut")
    Map("[-19,-41]") : Direction("Haut")
    Map("[-19,-42]") : Direction("Haut")
    Map("[-19,-43]") : Direction("Haut")
    Map("[-19,-44]") : Direction("Haut")
    Map("[-20,-36]") : Direction("Haut")
    Map("[-20,-37]") : Direction("Haut")
    Map("[-20,-38]") : Direction("Haut")
    Map("[-20,-39]") : Direction("Haut")
    Map("[-20,-40]") : Direction("Haut")
    Map("[-20,-41]") : Direction("Haut")
    Map("[-20,-42]") : Direction("Haut")
    Map("[-20,-43]") : Direction("Haut")
    Map("[-20,-44]") : Direction("Haut")
    Map("[-21,-36]") : Direction("Haut")
    Map("[-21,-37]") : Direction("Haut")
    Map("[-21,-38]") : Direction("Haut")
    Map("[-21,-39]") : Direction("Haut")
    Map("[-21,-40]") : Direction("Haut")
    Map("[-21,-41]") : Direction("Haut")
    Map("[-21,-42]") : Direction("Haut")
    Map("[-21,-43]") : Direction("Haut")
    Map("[-21,-44]") : Direction("Haut")
    Map("[-22,-36]") : Direction("Haut")
    Map("[-22,-37]") : Direction("Haut")
    Map("[-22,-38]") : Direction("Haut")
    Map("[-22,-39]") : Direction("Haut")
    Map("[-22,-40]") : Direction("Haut")
    Map("[-22,-41]") : Direction("Haut")
    Map("[-22,-42]") : Direction("Haut")
    Map("[-22,-43]") : Direction("Haut")
    Map("[-22,-44]") : Direction("Haut")
    Map("[-23,-36]") : Direction("Haut")
    Map("[-23,-37]") : Direction("Haut")
    Map("[-23,-38]") : Direction("Haut")
    Map("[-23,-39]") : Direction("Haut")
    Map("[-23,-40]") : Direction("Haut")
    Map("[-23,-41]") : Direction("Haut")
    Map("[-23,-42]") : Direction("Haut")
    Map("[-23,-43]") : Direction("Haut")
    Map("[-23,-44]") : Direction("Haut")
    Map("[-24,-36]") : Direction("Haut")
    Map("[-24,-37]") : Direction("Haut")
    Map("[-24,-38]") : Direction("Haut")
    Map("[-24,-39]") : Direction("Haut")
    Map("[-24,-40]") : Direction("Haut")
    Map("[-24,-41]") : Direction("Haut")
    Map("[-24,-42]") : Direction("Haut")
    Map("[-24,-43]") : Direction("Haut")
    Map("[-24,-44]") : Direction("Haut")
    Map("[-25,-36]") : Direction("Haut")
    Map("[-25,-37]") : Direction("Haut")
    Map("[-25,-38]") : Direction("Haut")
    Map("[-25,-39]") : Direction("Haut")
    Map("[-25,-40]") : Direction("Haut")
    Map("[-25,-41]") : Direction("Haut")
    Map("[-25,-42]") : Direction("Haut")
    Map("[-25,-43]") : Direction("Haut")
    Map("[-25,-44]") : Direction("Haut")
    Map("[-26,-36]") : Direction("Haut")
    Map("[-26,-37]") : Direction("Haut")
    Map("[-26,-38]") : Direction("Haut")
    Map("[-26,-39]") : Direction("Haut")
    Map("[-26,-40]") : Direction("Haut")
    Map("[-26,-41]") : Direction("Haut")
    Map("[-26,-42]") : Direction("Haut")
    Map("[-26,-43]") : Direction("Haut")
    Map("[-26,-44]") : Direction("Haut")
    Map("[-27,-36]") : Direction("Haut")
    Map("[-27,-37]") : Direction("Haut")
    Map("[-27,-38]") : Direction("Haut")
    Map("[-27,-39]") : Direction("Haut")
    Map("[-27,-40]") : Direction("Haut")
    Map("[-27,-41]") : Direction("Haut")
    Map("[-27,-42]") : Direction("Haut")
    Map("[-27,-43]") : Direction("Haut")
    Map("[-27,-44]") : Direction("Haut")
    Map("[-28,-36]") : Direction("Haut")
    Map("[-28,-37]") : Direction("Haut")
    Map("[-28,-38]") : Direction("Haut")
    Map("[-28,-39]") : Direction("Haut")
    Map("[-28,-40]") : Direction("Haut")
    Map("[-28,-41]") : Direction("Haut")
    Map("[-28,-42]") : Direction("Haut")
    Map("[-28,-43]") : Direction("Haut")
    Map("[-28,-44]") : Direction("Haut")
    Map("[-29,-36]") : Direction("Haut")
    Map("[-29,-37]") : Direction("Haut")
    Map("[-29,-38]") : Direction("Haut")
    Map("[-29,-39]") : Direction("Haut")
    Map("[-29,-40]") : Direction("Haut")
    Map("[-29,-41]") : Direction("Haut")
    Map("[-29,-42]") : Direction("Haut")
    Map("[-29,-43]") : Direction("Haut")
    Map("[-29,-44]") : Direction("Haut")
    Map("[-30,-36]") : Direction("Haut")
    Map("[-30,-37]") : Direction("Haut")
    Map("[-30,-38]") : Direction("Haut")
    Map("[-30,-39]") : Direction("Haut")
    Map("[-30,-40]") : Direction("Haut")
    Map("[-30,-41]") : Direction("Haut")
    Map("[-30,-42]") : Direction("Haut")
    Map("[-30,-43]") : Direction("Haut")
    Map("[-30,-44]") : Direction("Haut")
    Map("[-31,-36]") : Direction("Haut")
    Map("[-31,-37]") : Direction("Haut")
    Map("[-31,-38]") : Direction("Haut")
    Map("[-31,-39]") : Direction("Haut")
    Map("[-31,-40]") : Direction("Haut")
    Map("[-31,-41]") : Direction("Haut")
    Map("[-31,-42]") : Direction("Haut")
    Map("[-31,-43]") : Direction("Haut")
    Map("[-31,-44]") : Direction("Haut")
    Map("[-32,-36]") : Direction("Haut")
    Map("[-32,-37]") : Direction("Haut")
    Map("[-32,-38]") : Direction("Haut")
    Map("[-32,-39]") : Direction("Haut")
    Map("[-32,-40]") : Direction("Haut")
    Map("[-32,-41]") : Direction("Haut")
    Map("[-32,-42]") : Direction("Haut")
    Map("[-32,-43]") : Direction("Haut")
    Map("[-32,-44]") : Direction("Haut")
    Map("[-24,-51]") : Direction("Bas")
    Map("[-24,-50]") : Direction("Bas")
    Map("[-24,-49]") : Direction("Bas")
    Map("[-24,-48]") : Direction("Bas")
    Map("[-24,-47]") : Direction("Bas")
    Map("[-24,-46]") : Direction("Bas")
    Map("[-23,-51]") : Direction("Bas")
    Map("[-23,-50]") : Direction("Bas")
    Map("[-23,-49]") : Direction("Bas")
    Map("[-23,-48]") : Direction("Bas")
    Map("[-23,-47]") : Direction("Bas")
    Map("[-23,-46]") : Direction("Bas")
    Map("[-22,-51]") : Direction("Bas")
    Map("[-22,-50]") : Direction("Bas")
    Map("[-22,-49]") : Direction("Bas")
    Map("[-22,-48]") : Direction("Bas")
    Map("[-22,-47]") : Direction("Bas")
    Map("[-22,-46]") : Direction("Bas")
    Map("[-21,-51]") : Direction("Bas")
    Map("[-21,-50]") : Direction("Bas")
    Map("[-21,-49]") : Direction("Bas")
    Map("[-21,-48]") : Direction("Bas")
    Map("[-21,-47]") : Direction("Bas")
    Map("[-21,-46]") : Direction("Bas")
    Map("[-20,-51]") : Direction("Bas")
    Map("[-20,-50]") : Direction("Bas")
    Map("[-20,-49]") : Direction("Bas")
    Map("[-20,-48]") : Direction("Bas")
    Map("[-20,-47]") : Direction("Bas")
    Map("[-20,-46]") : Direction("Bas")
    Map("[-19,-51]") : Direction("Bas")
    Map("[-19,-50]") : Direction("Bas")
    Map("[-19,-49]") : Direction("Bas")
    Map("[-19,-48]") : Direction("Bas")
    Map("[-19,-47]") : Direction("Bas")
    Map("[-19,-46]") : Direction("Bas")
    Map("[-18,-51]") : Direction("Bas")
    Map("[-18,-50]") : Direction("Bas")
    Map("[-18,-49]") : Direction("Bas")
    Map("[-18,-48]") : Direction("Bas")
    Map("[-18,-47]") : Direction("Bas")
    Map("[-18,-46]") : Direction("Bas")
    Map("[-25,-48]") : Direction("Bas")
    Map("[-25,-47]") : Direction("Bas")
    Map("[-25,-46]") : Direction("Bas")
    Map("[-26,-48]") : Direction("Bas")
    Map("[-26,-47]") : Direction("Bas")
    Map("[-26,-46]") : Direction("Bas")
    Map("[-27,-48]") : Direction("Bas")
    Map("[-27,-47]") : Direction("Bas")
    Map("[-27,-46]") : Direction("Bas")
    Map("[-28,-48]") : Direction("Bas")
    Map("[-28,-47]") : Direction("Bas")
    Map("[-28,-46]") : Direction("Bas")
    Map("[-29,-48]") : Direction("Bas")
    Map("[-29,-47]") : Direction("Bas")
    Map("[-29,-46]") : Direction("Bas")
    Map("[-30,-48]") : Direction("Bas")
    Map("[-30,-47]") : Direction("Bas")
    Map("[-30,-46]") : Direction("Bas")
    Map("[-31,-48]") : Direction("Bas")
    Map("[-31,-47]") : Direction("Bas")
    Map("[-31,-46]") : Direction("Bas")
    Map("[-32,-48]") : Direction("Bas")
    Map("[-32,-47]") : Direction("Bas")
    Map("[-32,-46]") : Direction("Bas")
    Map("[-32,-45]") : Direction("Droite")
    Map("[-31,-45]") : Direction("Droite")
    Map("[-30,-45]") : Direction("Droite")
    Map("[-18,-45]") : Direction("Gauche")
    Map("[-19,-45]") : Direction("Gauche")
    Map("[-20,-45]") : Direction("Gauche")
    Map("[-21,-45]") : Direction("Gauche")
    Map("[-22,-45]") : Direction("Gauche")
    Map("[-23,-45]") : Direction("Gauche")
    Map("[-24,-45]") : Direction("Gauche")
    Map("[-25,-45]") : Direction("Gauche")
    Map("[-26,-45]") : Direction("Gauche")
    Map("[-27,-45]") : Direction("Gauche")
    Map("[-28,-45]") : Direction("Gauche")
    Map("[-29,-45]") : Direction("Haut")
    Map("[-29,-46]") : Direction("Haut")
    Map("[-29,-47]") : Direction("Haut")
    Map("[-29,-48]") : Direction("Haut")
    Map("[-29,-49]") : Direction("Haut")
    Map("[-29,-50]") : Direction("Haut")
    Map("[-29,-51]") : Direction("Haut")
    Map("[-29,-52]") : Direction("Haut")
    Map("[-29,-53]") : Direction("Haut")
    Map("[-29,-54]") : Direction("Haut")
    Map("[-29,-55]") : Direction("Haut")
    Map("[-29,-56]") : Direction("Haut")
    Map("[-29,-57]") : Direction("Haut")
    Map("4308") : Direction("363")
    Map("10215") : Call DialogueBanquierBonta()

End Sub

Sub DialogueBanquierBonta()

    If Boolean = PnjExist("Banquier") = True Then

        If Boolean = EnDialogue = False Then

            PnjParler("Banquier")

        End If

        If Boolean = EnDialogue = True Then

            PnjReponse("Consulter son coffre personnel")

            If Boolean = EnBanque = True Then

                ItemDepose("All", "999999")

            End If

            If Boolean = EnDialogue = True Then

                PnjQuitteDialogue()

            End If

            If Boolean = EnBanque = True Then

                BanqueQuitte()

            End If

        End If

    End If

End Sub