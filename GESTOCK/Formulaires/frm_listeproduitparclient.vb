Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frm_listeproduitparclient

    Private Sub frm_listeproduitparclient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ouvrir la connexion
        'se_connecter(chemin)
        remplir_table("")
    End Sub




    Sub remplir_table(ByVal j As String)
        Try

            Dim req As String = ""
            'req = "select * from mouvement"
            req = "select  mouvement.idmvt, mouvement.numcli, d_mouvement.numprod,typemvt, produit.designation, d_mouvement.qte, d_mouvement.prixunit,monttotal,mouvement.monttva , datemvt from mouvement, d_mouvement, produit, client where mouvement.idmvt = d_mouvement.idmvt and d_mouvement.numprod = produit.numprod group by mouvement.idmvt, mouvement.numcli, d_mouvement.numprod,typemvt, produit.designation, d_mouvement.qte, d_mouvement.prixunit, mouvement.monttva , datemvt,monttotal "
            Dim Cmd As SqlCommand = New SqlCommand(req, cnx)
            Dim Adap As New SqlDataAdapter
            Adap.SelectCommand = Cmd
            Dim tblCla As New DataTable
            Adap.Fill(tblCla)
            TB_mvt.DataSource = tblCla
            'MAJ.CacheColonnes(grille, True, "3")
            TB_mvt.Columns("idmvt").HeaderText = "ID du mouvement"
            TB_mvt.Columns("numcli").HeaderText = "Numéro client"
            TB_mvt.Columns("typemvt").HeaderText = "Type Mouvement"
            TB_mvt.Columns("designation").HeaderText = " designation"
            TB_mvt.Columns("qte").HeaderText = " Quantité"
            TB_mvt.Columns("monttotal").HeaderText = " Montant HT"
            TB_mvt.Columns("monttva").HeaderText = " Montant TTC"
            TB_mvt.Columns("datemvt").HeaderText = " Date Mouvement"

            TB_mvt.RowsDefaultCellStyle.BackColor = Color.White
            TB_mvt.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine
            TB_mvt.Columns(0).Width = 50
            TB_mvt.Columns(1).Width = 200
            TB_mvt.Columns(2).Width = 100
            TB_mvt.Columns(4).Width = 150

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        cnx.Close()
    End Sub

    Private Sub btn_supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_supprimer.Click
        Dim confirmation As DialogResult = MessageBox.Show("Voulez-vous réellement supprimer cet enregistrement?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (confirmation = Windows.Forms.DialogResult.Yes) Then
            If (TB_mvt.RowCount > 0) Then
                If (TB_mvt.CurrentRow.Index >= 0) Then

                    Dim codes As String = TB_mvt.CurrentRow.Cells(0).Value.ToString
                    'instruction("delete from d_mouvement  where d_mouvement.idmvt '" & codes & "'")
                    instruction("delete from mouvement  where mouvement.idmvt = '" & codes & "'", SU)
                    'remplirGridvide(MonDataSet, MonDataAdapteur, "mouvement", TB_mvt, "select mouvement.idmvt, mouvement.numcli, d_mouvement.numprod, produit.designation, d_mouvement.qte, d_mouvement.prixunit, mouvement.monttva , datemvt, mouvement.idmvt from mouvement, d_mouvement, produit, client where mouvement.idmvt = d_mouvement.idmvt and d_mouvement.numprod = produit.numprod")

                    btn_nouveau.Enabled = True
                    'btn_supprimer.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fermer.Click
        Me.Dispose()
    End Sub

    Private Sub btn_nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nouveau.Click
        frm_mouvement.ShowDialog()
    End Sub

    Private Sub Btn_actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_actualiser.Click
        Dim req As String = ""
        'req = "select * from mouvement"
        req = "select  mouvement.idmvt, mouvement.numcli, d_mouvement.numprod,typemvt, produit.designation, d_mouvement.qte, d_mouvement.prixunit,monttotal,mouvement.monttva , datemvt from mouvement, d_mouvement, produit, client where mouvement.idmvt = d_mouvement.idmvt and d_mouvement.numprod = produit.numprod group by mouvement.idmvt, mouvement.numcli, d_mouvement.numprod,typemvt, produit.designation, d_mouvement.qte, d_mouvement.prixunit, mouvement.monttva , datemvt,monttotal "
        Dim Cmd As SqlCommand = New SqlCommand(req, cnx)
        Dim Adap As New SqlDataAdapter
        Adap.SelectCommand = Cmd
        Dim tblCla As New DataTable
        Adap.Fill(tblCla)
        TB_mvt.DataSource = tblCla
    End Sub

End Class