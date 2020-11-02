Public Class Frm_modClient

    Private Sub btn_client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_client.Click
        Liste_Client.ShowDialog()
    End Sub

    Private Sub Frm_modClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_numcli.Enabled = False
    End Sub

    Private Sub btn_enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modifier.Click
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

        instruction("UPDATE client SET nomcli='" & Me.txt_nomcli.Text.Replace("'", "\'") & "', prenomcli='" & Me.txt_prenomcli.Text.Replace("'", "\'") & "', telcli='" & Me.txt_telcli.Text.Replace("'", "\'") & "', adrcli='" & Me.txt_adrcli.Text.Replace("'", "\'") & "', emailcli='" & Me.txt_emailcli.Text.Replace("'", "\'") & "', datenais='" & Me.dtp_datenais.Text.Replace("'", "\'") & "' WHERE  numcli='" & Me.txt_numcli.Text & "'")

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