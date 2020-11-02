Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Liste_Client
    'creer un objet connexion et définir ses propriétés
    'Dim cnx As New SqlConnection("Data Source=WHANNOU;Initial Catalog=GESTOCK;Integrated Security=True")
    Private Sub Liste_Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ouvrir la connexion
        'se_connecter(chemin)
        remplir_table("")
    End Sub
    Sub remplir_table(ByVal j As String)
        Try

            Dim req As String = ""

            req = "select numcli, nomcli, prenomcli, telcli, adrcli,emailcli, datenais from client "
            Dim Cmd As SqlCommand = New SqlCommand(req, cnx)
            Dim Adap As New SqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            TB_client.DataSource = tblCla
            'MAJ.CacheColonnes(grille, True, "3")
            TB_client.Columns("numcli").HeaderText = "Numéro"
            TB_client.Columns("nomcli").HeaderText = "Nom"
            TB_client.Columns("prenomcli").HeaderText = " Prénoms"
            TB_client.Columns("telcli").HeaderText = "Téléphone"
            TB_client.Columns("adrcli").HeaderText = "Adresse"
            TB_client.Columns("emailcli").HeaderText = " Email"
            TB_client.Columns("datenais").HeaderText = " Date Naissance"

            TB_client.RowsDefaultCellStyle.BackColor = Color.White
            TB_client.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
            TB_client.Columns(0).Width = 50
            TB_client.Columns(1).Width = 200
            TB_client.Columns(2).Width = 100
            TB_client.Columns(4).Width = 150

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TB_client_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TB_client.CellContentClick

    End Sub

    Private Sub TB_client_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TB_client.CellDoubleClick


        If TB_client.RowCount = 0 Then
            Beep()
            MsgBox("ERREUR")
            Exit Sub
        Else

            Frm_modClient.txt_numcli.Text = TB_client.CurrentRow.Cells(0).Value.ToString()
            Frm_modClient.txt_nomcli.Text = TB_client.CurrentRow.Cells(1).Value
            Frm_modClient.txt_prenomcli.Text = TB_client.CurrentRow.Cells(2).Value
            Frm_modClient.txt_telcli.Text = TB_client.CurrentRow.Cells(3).Value
            Frm_modClient.txt_adrcli.Text = TB_client.CurrentRow.Cells(4).Value
            Frm_modClient.txt_emailcli.Text = TB_client.CurrentRow.Cells(5).Value
            Frm_modClient.dtp_datenais.Text = TB_client.CurrentRow.Cells(6).Value

            frm_mouvement.txt_numcli.Text = TB_client.CurrentRow.Cells(0).Value
            frm_mouvement.txt_nomcli.Text = TB_client.CurrentRow.Cells(1).Value
            
            'Frm_modClient.ShowDialog()
            Me.Close()

        End If
    End Sub

    Private Sub btn_nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nouveau.Click
        Frm_EngClient.ShowDialog()
    End Sub


    
    Private Sub btn_supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_supprimer.Click
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous réellement supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (confirmation = Windows.Forms.DialogResult.Yes) Then
            If (TB_client.RowCount > 0) Then
                If (TB_client.CurrentRow.Index >= 0) Then

                    Dim codes As String = TB_client.CurrentRow.Cells(0).Value.ToString
                    instruction("delete from client where numcli = '" & codes & "'", SU)
                    remplirGridvide(MonDataSet, MonDataAdapteur, "client", TB_client, "select numcli, nomcli, prenomcli, telcli, adrcli,emailcli, datenais from client")
                    
                    btn_nouveau.Enabled = True
                    btn_supprimer.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fermer.Click
        Me.Dispose()
    End Sub




    Private Sub Btn_recherche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_recherche.Click
        Dim req As String = ""

        req = "Select * from client where CONCAT(numcli, nomcli, prenomcli, telcli, adrcli,emailcli,datenais) like '%" & Text_recherche.Text & "%'"
        Dim Cmd As SqlCommand = New SqlCommand(req, cnx)
        Dim Adap As New SqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCla As New DataTable
        Adap.Fill(tblCla)
        TB_client.DataSource = tblCla
    End Sub
End Class