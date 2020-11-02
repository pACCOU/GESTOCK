Public Class Facture_d_une_période

    Private Sub Facture_d_une_période_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Combo("select numcli from client", cmb_numcli)
        Combo("select datemvt from mouvement", cmb_datemvt)

    End Sub

    Private Sub btn_afficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_afficher.Click
        If cmb_numcli.Text = "" Or cmb_datemvt.Text = "" Then
            MsgBox("Veuillez remplir toutes les informations ")
            Exit Sub
        End If

        Dim Cmd As SqlCommand = cnx.CreateCommand
        Dim ds As New DataSet1
        Cmd.CommandText = "SELECT numcli,nomcli,numprod,desination,qte,prixunit,monttotal,tva,monttva sum(monttotal) as total  from mouvement,d_mouvement where mouvement.idmvt=d_mouvement.idmvt  group by numcli,nomcli,numprod,desination,qte,prixunit,monttotal,tva,monttva "
        ds.Tables("fact").Load(Cmd.ExecuteReader())
        If ds.Tables("fact").Rows.Count <= 0 Then
            MsgBox("Aucun enregistrement", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim cr As New CrystalReport1
        cr.SetDataSource(ds.Tables("fact"))
        Etat_mouvement.CrystalReportViewer1.ReportSource = cr
        Etat_mouvement.ShowDialog()
    End Sub

    Private Sub cmb_datemvt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_datemvt.SelectedIndexChanged

    End Sub
End Class