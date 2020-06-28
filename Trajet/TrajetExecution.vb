﻿Imports System.Web.UI

Module TrajetExecution

    Public Sub TrajetLecture(ByVal index As Integer, ByVal balise As String)

        With Comptes(index)

            Dim nextLine As Boolean = True
            Dim whileLine As Integer = 0

            For a = 0 To .FrmGroupe.DicoTrajet(balise).Count - 1

                With .FrmGroupe.DicoTrajet(balise)

                    If .Item(a) <> "" AndAlso Mid(.Item(a), 1, 1) <> "'" Then

                        Dim separateAction As String() = Split(.Item(a), " : ")

                        For i = 0 To separateAction.Count - 1

                            Dim separatePair As String() = Split(separateAction(i), " ")

                            Select Case separatePair(0)

                                Case "If"

                                    nextLine = IfReturn(index, .Item(a))

                                Case "ElseIf"

                                    nextLine = IfReturn(index, .Item(a))

                                Case "Else"

                                    If nextLine Then nextLine = False

                                Case "End"

                                    Select Case separatePair(1)

                                        Case "If"

                                            nextLine = True

                                        Case "While"

                                            If nextLine Then

                                                a = whileLine - 1

                                            Else

                                                nextLine = True
                                                whileLine = 0

                                            End If

                                        Case "Sub"

                                    End Select

                                Case "While"

                                    If WhileReturn(index, .Item(a)) Then

                                        nextLine = True
                                        whileLine = a

                                    Else

                                        nextLine = False
                                        whileLine = 0

                                    End If

                                Case "Call"

                                    If nextLine Then TrajetLecture(index, separatePair(1))

                                Case Else

                                    If nextLine Then

                                        separatePair = Split(separateAction(i), "(")

                                        Select Case separatePair(0)

                                            Case "Map"

                                                If CallFunction(index, separateAction(i)) = "False" Then

                                                    Exit For

                                                End If

                                            Case "MsgBox"

                                                MsgBox(Split(separateAction(i), "Msgbox = ")(1).Replace("""", ""))

                                            Case "Direction"

                                                If CallFunction(index, separateAction(i)) = "False" Then

                                                    EcritureMessage(index, "(Bot - Trajet)", " Le bot n'arrive pas à aller dans la direction voulu, ligne de l'erreur : " & .Item(a), Color.Red)

                                                    Exit For

                                                End If

                                            Case "PnjParler"

                                                CallFunction(index, separateAction(i))

                                            Case "PnjReponse"

                                                CallFunction(index, separateAction(i))

                                            Case "PnjQuitteDialogue"

                                                CallFunction(index, separateAction(i))

                                            Case "Recolte"

                                                CallFunction(index, separateAction(i))

                                            Case "EquipeItem"

                                                CallFunction(index, separateAction(i))

                                            Case "PauseSeconde", "PauseMinute", "PauseHeure"

                                                CallFunction(index, separateAction(i))

                                            Case "ItemDepose"

                                                CallFunction(index, separateAction(i))

                                            Case "BanqueQuitte"

                                                CallFunction(index, separateAction(i))

                                            Case "Interaction"

                                                CallFunction(index, separateAction(i))

                                        End Select

                                        If separatePair(0) <> "Map" Then

                                            Task.Delay(1000).Wait()

                                        End If

                                    End If

                            End Select

                        Next

                    End If

                End With

            Next

        End With

    End Sub

    Private Function WhileReturn(ByVal index As Integer, ByVal laLigne As String) As Boolean

        With Comptes(index)

            Dim separate As String() = Split(laLigne, " ")

            Dim nomFunction As String = ReturnNomFunction(laLigne)
            Dim ParametreFunction As String() = ReturnParametreFunction(index, laLigne)

            Dim resultat1 As String = LuaScript.GetFunction(nomFunction).Call(ParametreFunction).First

            Select Case separate(1)

                Case "Integer"

                    Select Case separate(4)

                        Case "<"

                            If CInt(resultat1) <= CInt(separate(5)) Then

                                Return True

                            Else

                                Return False

                            End If

                        Case ">"

                            If CInt(resultat1) >= CInt(separate(5)) Then

                                Return True

                            Else

                                Return False

                            End If

                        Case "="

                            If CInt(resultat1) = CInt(separate(5)) Then

                                Return True

                            Else

                                Return False

                            End If

                    End Select

            End Select

            Return False

        End With

    End Function

    Private Function CallFunction(ByVal index As Integer, ByVal laLigne As String)

        With Comptes(index)

            Dim nomFunction As String = ReturnNomFunction(laLigne)
            Dim ParametreFunction As String() = ReturnParametreFunction(index, laLigne)

            Return LuaScript.GetFunction(nomFunction).Call(ParametreFunction).First

        End With

    End Function

    Private Function IfReturn(ByVal index As Integer, ByVal laLigne As String) As Boolean

        With Comptes(index)

            Dim separateLigne As String() = Split(laLigne, " ")

            Dim nomFunction As String = ReturnNomFunction(laLigne)
            Dim ParametreFunction As String() = ReturnParametreFunction(index, laLigne)

            Dim resultat1 As String = LuaScript.GetFunction(nomFunction).Call(ParametreFunction).First

            Select Case separateLigne(1)

                Case "Integer"

                    Select Case separateLigne(4)

                        Case "<"

                            If CInt(resultat1) <= CInt(separateLigne(5)) Then

                                Return True

                            Else

                                Return False

                            End If

                        Case ">"

                            If CInt(resultat1) >= CInt(separateLigne(5)) Then

                                Return True

                            Else

                                Return False

                            End If

                        Case "="

                            If CInt(resultat1) = CInt(separateLigne(5)) Then

                                Return True

                            Else

                                Return False

                            End If

                    End Select

                Case "String"

                Case "Boolean"

                    If resultat1 = Split(laLigne, " = ")(2).Split(" ")(0) Then

                        Return True

                    Else

                        Return False

                    End If

            End Select

            Return False

        End With

    End Function

    Private Function ReturnNomFunction(ByVal laligne As String) As String

        Dim separate As String()

        If laligne.Contains(" = ") Then

            separate = Split(laligne, " = ")
            separate = Split(separate(1), "(")

        Else

            separate = Split(laligne, "(")

        End If


        Return separate(0)

    End Function

    Private Function ReturnParametreFunction(ByVal index As Integer, ByVal laligne As String)

        Dim separateFunctionParamétre As String()

        If laligne.Contains(" = ") Then

            separateFunctionParamétre = Split(laligne, " = ")

            If separateFunctionParamétre(1).Contains("(") Then

                separateFunctionParamétre = Split(separateFunctionParamétre(1).Replace("""", ""), "(")
                separateFunctionParamétre = Split(separateFunctionParamétre(1), ")")
                separateFunctionParamétre = Split(separateFunctionParamétre(0), ", ")

            Else

                separateFunctionParamétre = Nothing

            End If

        Else

            If laligne.Contains("(") Then

                If laligne.Contains("""") Then

                    separateFunctionParamétre = Split(laligne.Replace("""", ""), "(")
                    separateFunctionParamétre = Split(separateFunctionParamétre(1), ")")
                    separateFunctionParamétre = Split(separateFunctionParamétre(0), ", ")

                Else

                    separateFunctionParamétre = Nothing

                End If

            Else

                    separateFunctionParamétre = Nothing

            End If

        End If

        Dim functionParamétre(If(separateFunctionParamétre Is Nothing, 0, separateFunctionParamétre.Count)) As String
        functionParamétre(0) = index

        If Not separateFunctionParamétre Is Nothing Then

            For i = 0 To separateFunctionParamétre.Count - 1

                functionParamétre(i + 1) = separateFunctionParamétre(i)

            Next

        End If

        Return functionParamétre

    End Function

End Module
