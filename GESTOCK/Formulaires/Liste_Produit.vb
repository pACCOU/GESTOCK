Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Liste_Produit
    'creer un objet connexion et définir ses propriétés
    'Dim cnx As New SqlConnection("Data Source=WHANNOU;Initial Catalog=GESTOCK;Integrated Security=True")
    Private Sub Liste_Produit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ouvrir la connexion
        'se_connecter(chemin)
        remplir_table("")
    End Sub

    Sub remplir_table(ByVal j As String)
        Try

            Dim req As String = ""

            req = "select numprod, designation, prixunit from produit "
            Dim Cmd As SqlCommand = New SqlCommand(req, cnx)
            Dim Adap As New SqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            TB_produit.DataSource = tblCla
            'MAJ.CacheColonnes(grille, True, "3")
            TB_produit.Columns("numprod").HeaderText = "Numéro"
            TB_produit.Columns("designation").HeaderText = "Désignation"
            TB_produit.Columns("prixunit").HeaderText = " Prix Unitaire"
            

            TB_produit.RowsDefaultCellStyle.BackColor = Color.White
            TB_produit.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
            TB_produit.Columns(0).Width = 50
            TB_produit.Columns(1).Width = 200
            TB_produit.Columns(2).Width = 200


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    
    Private Sub TB_produit_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TB_produit.CellContentClick

    End Sub

    Private Sub TB_produit_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TB_produit.CellDoubleClick
        If TB_produit.RowCount = 0 Then
            Beep()
            MsgBox("ERREUR")
            Exit Sub
        Else

            Frm_modProduit.txt_numprod.Text = TB_produit.CurrentRow.Cells(0).Value
            Frm_modProduit.txt_designation.Text = TB_produit.CurrentRow.Cells(1).Value
            Frm_modProduit.txt_prixunit.Text = TB_produit.CurrentRow.Cells(2).Value

            frm_mouvement.txt_numprod.Text = TB_produit.CurrentRow.Cells(0).Value
            frm_mouvement.txt_designation.Text = TB_produit.CurrentRow.Cells(1).Value
            frm_mouvement.txt_pu.Text = TB_produit.CurrentRow.Cells(2).Value

            'Frm_modProduit.ShowDialog()

            Me.Close()

        End If
    End Sub

    Private Sub btn_nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nouveau.Click

        Frm_EngProduit.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btn_supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_supprimer.Click
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous réellement supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (confirmation = Windows.Forms.DialogResult.Yes) Then
            If (TB_produit.RowCount > 0) Then
                If (TB_produit.CurrentRow.Index >= 0) Then

                    Dim codes As String = TB_produit.CurrentRow.Cells(0).Value.ToString
                    instruction("delete from produit where numprod = '" & codes & "'", SU)
                    remplirGridvide(MonDataSet, MonDataAdapteur, "client", TB_produit, "select numprod, designation, prixunit from produit")

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

        req = "Select * from produit where CONCAT(numprod, designation, prixunit) like '%" & Text_recherche.Text & "%'"
        Dim Cmd As SqlCommand = New SqlCommand(req, cnx)
        Dim Adap As New SqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCla As New DataTable
        Adap.Fill(tblCla)
        TB_produit.DataSource = tblCla
    End Sub
End Class