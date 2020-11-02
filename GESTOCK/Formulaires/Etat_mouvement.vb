Public Class Etat_mouvement

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        'cnx = New SqlConnection()
        'cnx.Open()
        se_connecter(chemin)
        Dim cmd As SqlCommand = cnx.CreateCommand
        Dim ds As New DataSet1
        cmd.CommandText = "SELECT numcli,nomcli,numprod,desination,qte,prixunit,monttotal,tva,monttva sum(monttotal) as total  from mouvement,d_mouvement where mouvement.idmvt=d_mouvement.idmvt  group by numcli,nomcli,numprod,desination,qte,prixunit,monttotal,tva,monttva "
        ds.Tables("fact").Load(cmd.ExecuteReader())

        If ds.Tables("fact").Rows.Count <= 0 Then
            MsgBox("Aucune donnée .")
            Me.Close() : Exit Sub
        End If
        Dim cr As New CrystalReport1

        cr.SetDataSource(ds.Tables("fact"))
        Me.CrystalReportViewer1.ReportSource = cr
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Etat_mouvement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class