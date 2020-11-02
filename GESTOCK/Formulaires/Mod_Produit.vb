Public Class Frm_modProduit

    Private Sub Frm_modProduit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_numprod.Enabled = False
    End Sub

    Private Sub btn_produit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_produit.Click
        Liste_Produit.ShowDialog()
    End Sub

    Private Sub btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fermer.Click
        Me.Dispose()
    End Sub

    Private Sub btn_enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modifier.Click
        If (txt_numprod.Text = "" Or txt_designation.Text = "" Or txt_prixunit.Text = "") Then
            MsgBox("Veuillez saisir toutes les informations")
            Exit Sub
        End If

        instruction("UPDATE produit SET designation='" & Me.txt_designation.Text.Replace("'", "\'") & "', prixunit='" & Me.txt_prixunit.Text.Replace("'", "\'") & "' WHERE  numprod='" & Me.txt_numprod.Text & "'")

        txt_designation.Text = ""
        txt_prixunit.Text = ""


        cnx.Close()
    End Sub
End Class