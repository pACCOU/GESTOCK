Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_EngClient
    'creer un objet connexion et définir ses propriétés
    'Dim cnx As New SqlConnection("Data Source=WHANNOU;Initial Catalog=GESTOCK;Integrated Security=True")

    '

    Private Sub Frm_EngClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ouvrir la connexion
        se_connecter(chemin)
        txt_numcli.Enabled = False
        txt_numcli.Text = NumeroAutoFac("client", "numcli", "C")
    End Sub

    Private Sub btn_enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enregistrer.Click
        If (txt_numcli.Text = "" Or txt_nomcli.Text = "" Or txt_prenomcli.Text = "" Or txt_telcli.Text = "" Or txt_adrcli.Text = "" Or txt_emailcli.Text = "") Then
            MsgBox("Veuillez saisir toutes les informations")
            Exit Sub
        End If
        If (dtp_datenais.Text > Now.Date) Then
            MsgBox("Veuillez selectionner une date convenable")
            Exit Sub
        End If
        'cnx.Open()

        'Dim requete As String = "insert into clients values ('" & txt_numcli.Text & "','" & txt_nomcli.Text & "','" & txt_prenomcli.Text & "','" & txt_telcli.Text & "','" & txt_adrcli.Text & "','" & txt_emailcli.Text & "','" & dtp_datenais.Text & "') "
        'Dim command As SqlCommand = New SqlCommand(requete, cnx)
        'command.ExecuteNonQuery()

        'ObjetCommand.CommandText = req
        'ObjetCommand.ExecuteNonQuery()

        instruction("insert into client values ('" & txt_numcli.Text & "','" & txt_nomcli.Text & "','" & txt_prenomcli.Text & "','" & txt_telcli.Text & "','" & txt_adrcli.Text & "','" & txt_emailcli.Text & "','" & dtp_datenais.Text & "' )", EN)
        txt_numcli.Text = NumeroAutoFac("client", "numcli", "C")
        txt_nomcli.Text = ""
        txt_prenomcli.Text = ""
        txt_telcli.Text = ""
        txt_adrcli.Text = ""
        txt_emailcli.Text = ""

        cnx.Close()
    End Sub

    Private Sub btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fermer.Click
        Me.Dispose()
    End Sub
End Class