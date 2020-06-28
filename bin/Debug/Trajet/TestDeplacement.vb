Private Map, Direction As String

Sub Main()

    'Départ depuis la banque d'astrub
    Map("7549") : Direction("381")
    Map("7414") : Direction("Gauche")
    Map("[3,-16]") : Interaction("Statue de classe", "Se rendre a Incarnam")

    'Départ depuis Incarnam
    Map("10292") : Direction("392")
    Map("10326") : Direction("334")
    Map("10273") : Direction("459")
    Map("10337") : Direction("447")
    Map("10258") : Direction("463")
    Map("10295") : Direction("405")
    Map("10297") : Direction("289")
    Map("10301") : Direction("260")

    If Boolean = Map("10302") = True Then

        If Boolean = MetierExist("Paysan") = False Then

            Call ApprendMetier()

        Else

            If Boolean = EquipementEquiper("Faux du Paysan") = False Then

                Call EquipeItemPaysan()

            End If

        End If

    End If

    Map("10302") : Direction("376")

    If Integer = Pods("Actuelle") < 80 Then

        If Boolean = MetierExist("Paysan") = True Then

            Call RecolteBle()

        End If

    End If

    If Integer = Pods("Actuelle") > 80 Then

        Call BanqueAstrub()

    End If

End Sub

Sub RecolteBle()

    Map("[4,3]") : Recolte("Ble") : Direction("Haut")
    Map("[4,2]") : Recolte("Ble") : Direction("Haut")
    Map("[4,1]") : Recolte("Ble") : Direction("Haut")
    Map("[4,0]") : Recolte("Ble") : Direction("Droite")
    Map("[5,0]") : Recolte("Ble") : Direction("Bas")
    Map("[5,1]") : Recolte("Ble") : Direction("Droite")
    Map("[6,1]") : Recolte("Ble") : Direction("Bas")
    Map("[6,2]") : Recolte("Ble") : Direction("Gauche")
    Map("[5,2]") : Recolte("Ble") : Direction("Bas")
    Map("[5,3]") : Recolte("Ble") : Direction("Gauche")

End Sub

Sub ApprendMetier()

    If Boolean = PnjExist("Contremaitre Ikul") = True Then

        If Boolean = EnDialogue = False Then

            PnjParler("Contremaitre Ikul")

        End If

        If Boolean = EnDialogue = True Then

            PnjReponse("Je cherche a apprendre un metier.")
            PnjReponse("Dites moi comment devenir paysan.")
            PnjReponse("Je retrousse mes manches et on y va !")
            PnjReponse("Terminer la discussion.")

            If Boolean = EnDialogue = True Then

                PnjQuitteDialogue()

            End If

        End If

    End If

End Sub

Sub EquipeItemPaysan()

    EquipeItem("Faux du Paysan")

End Sub

Sub BanqueAstrub()

    While Integer = Pods("Actuelle") > 80

        Map("[4,3]") : Direction("Droite")
        Map("[4,2]") : Direction("Droite")
        Map("[4,1]") : Direction("Droite")
        Map("[4,0]") : Direction("Droite")
        Map("[5,0]") : Direction("Bas")
        Map("[5,1]") : Direction("Bas")
        Map("[6,1]") : Direction("Bas")
        Map("[6,2]") : Direction("Bas")
        Map("[6,3]") : Direction("Bas")
        Map("[5,2]") : Direction("Bas")
        Map("[5,3]") : Direction("Droite")
        Map("[6,4]") : Direction("Droite")
        Map("[6,5]") : Call DialogueAvauleGanymede()
        Map("[2,-20]") : Direction("Droite")
        Map("[3,-20]") : Direction("Droite")
        Map("[4,-20]") : Direction("Bas")
        Map("[4,-19]") : Direction("Bas")
        Map("[4,-18]") : Direction("Bas")
        Map("[4,-17]") : Direction("Bas")
        Map("7414") : Direction("142")
        Map("7549") : Call DialogueBanquierAstrub()

    End While

End Sub

Sub DialogueAvauleGanymede()

    If Boolean = PnjExist("Avaule Ganymede") = True Then

        If Boolean = EnDialogue = False Then

            PnjParler("Avaule Ganymede")

        End If

        If Boolean = EnDialogue = True Then

            PnjReponse("Oui ! Je veux me rendre a Astrub.")

            If Boolean = EnDialogue = True Then

                PnjQuitteDialogue()

            End If

        End If

    End If

End Sub

Sub DialogueBanquierAstrub()

    If Boolean = PnjExist("Al Etsop") = True Then

        If Boolean = EnDialogue = False Then

            PnjParler("Al Etsop")

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