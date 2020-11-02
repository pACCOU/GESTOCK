Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frm_mouvement
    'declaration de variable et cste
    Dim montant As String
    Dim taux As Double = 0.18

    'Dim cumul As Double
    'Dim I As Integer
    'Dim totalbenefice As Double
    'Dim cumulbenefice As Double

    'creer un objet connexion et définir ses propriétés
    'Dim cnx As New SqlConnection("Data Source=WHANNOU;Initial Catalog=GESTOCK1;Integrated Security=True")
    Private Sub frm_mouvement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ouvrir la connexion

        se_connecter(chemin)
        txt_numcli.Enabled = False
        txt_numprod.Enabled = False
        txt_nomcli.Enabled = False
        txt_designation.Enabled = False
        txt_pu.Enabled = False
        txt_idmvt.Text = NumeroAutoFac("mouvement", "idmvt", "0")

        'txt_mont.Text = (txt_pu.Text * txt_qte.Text)
        'txt_mont.Text = " recup(txt_mont.Text) "
        'txt_monttva.Text = (txt_mont.Text + (txt_mont.Text * txt_tva.Text))
        'txt_monttva.Text = " recup(txt_monttva.Text)"

    End Sub

    Private Sub btn_enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_enregistrer.Click

        If (txt_numcli.Text = "" Or txt_numprod.Text = "" Or txt_nomcli.Text = "" Or txt_designation.Text = "" Or Cbx_typemvt.Text = "" Or Dtp_datemvt.Text = "" Or txt_qte.Text = "" Or txt_pu.Text = "" Or txt_mont.Text = "" Or txt_monttva.Text = "") Then
            MsgBox("Veuillez saisir toutes les informations")
            Exit Sub
        End If
        If (Dtp_datemvt.Text > Now.Date) Then
            MsgBox("Veuillez selectionner une date convenable")
            Exit Sub
        End If
        If CInt(txt_qte.Text) = 0 Then
            MsgBox("Veuillez revoir la quantité")
            Exit Sub
        End If

        instruction("insert into mouvement(idmvt, datemvt, typemvt, monttotal, tva, monttva, numcli)  values ('" & txt_idmvt.Text & "', '" & Dtp_datemvt.Text & "', '" & Cbx_typemvt.Text & "', '" & txt_mont.Text & "', '" & taux & "', '" & txt_monttva.Text & "', '" & txt_numcli.Text & "' )")
        instruction("insert into d_mouvement (idmvt, numprod, qte, prixunit)values('" & txt_idmvt.Text & "', '" & txt_numprod.Text & "','" & txt_qte.Text & "','" & txt_pu.Text & "' ) ", EN)
        txt_idmvt.Text = NumeroAutoFac("mouvement", "idmvt", "0")
        txt_numcli.Text = ""
        txt_nomcli.Text = ""
        txt_numprod.Text = ""
        txt_designation.Text = ""
        Cbx_typemvt.Text = ""
        'Dtp_datemvt.Text = ""
        txt_qte.Text = ""
        txt_pu.Text = ""
        txt_mont.Text = ""
        txt_monttva.Text = ""

        cnx.Close()
    End Sub

    Private Sub btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_fermer.Click
        Me.Dispose()
    End Sub

    Private Sub txt_mont_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_monttva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_numcli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_numcli.Click
        Liste_Client.ShowDialog()
    End Sub

    Private Sub Btn_numprod_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_numprod.Click
        Liste_Produit.ShowDialog()
    End Sub

    Private Sub txt_qte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_qte.KeyPress

    End Sub

    Private Sub txt_qte_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qte.TextChanged
        IIf(txt_qte.Text = "", 0, txt_qte.Text)
        txt_mont.Text = CInt(CInt(Val(txt_pu.Text)) * CInt(Val(txt_qte.Text)))
        txt_monttva.Text = CDbl((txt_mont.Text)) + CDbl((CInt(Val(txt_mont.Text)) * 0.18))
    End Sub
End Class