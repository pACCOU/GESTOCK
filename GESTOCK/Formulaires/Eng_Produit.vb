Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_EngProduit

    Private Sub Eng_Produit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ouvrir la connexion
        'se_connecter(chemin)
        txt_numprod.Enabled = False
        txt_numprod.Text = NumeroAutoFac("produit", "numprod", "P")
    End Sub

    Private Sub btn_enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enregistrer.Click
        If (txt_numprod.Text = "" Or txt_designation.Text = "" Or txt_prixunit.Text = "") Then
            MsgBox("Veuillez saisir toutes les informations")
            Exit Sub
        End If
        instruction("insert into produit values ('" & txt_numprod.Text & "','" & txt_designation.Text & "','" & txt_prixunit.Text & "')", EN)
        txt_numprod.Text = NumeroAutoFac("produit", "numprod", "P")
        txt_designation.Text = ""
        txt_prixunit.Text = ""
        'cnx.Close()
    End Sub

    Private Sub btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fermer.Click
        Me.Dispose()
    End Sub
End Class