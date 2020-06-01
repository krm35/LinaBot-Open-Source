Partial Module Trajet_Information

    Private Sub Suppression(ByVal index As Integer)

        With Comptes(index)

            For Each Pair As Integer In .FrmGroupe.ListIndex

                For Each PairItem As Groupe.sSupprime In .FrmGroupe.GrpSupprime

                    ItemSupprime(Pair,
                                 PairItem.IdNom,
                                 If(PairItem.Quantité.ToLower = "max", 99999, PairItem.Quantité),
                                 PairItem.Caractéristique)

                Next

            Next

        End With

    End Sub

End Module
