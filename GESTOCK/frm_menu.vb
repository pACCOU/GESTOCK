Public Class frm_menu

    Private Sub frm_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()

        'If (recuperateur_de_statut = "1") Then
        '    ProfilsUtilisateursToolStripMenuItem.Enabled = True
        '    ProfilsUtilisateursToolStripMenuItem.BackColor = Color.Green
        'Else
        '    ProfilsUtilisateursToolStripMenuItem.Enabled = False
        '    ProfilsUtilisateursToolStripMenuItem.BackColor = Color.Red

        'End If
        'ConnectedUser.Text = tblActifUser.Rows(1)("nom").ToString() + "    " + tblActifUser.Rows(1)("prenom").ToString()
        'Label2.Text = tblActifUser.Rows(0)("Login").ToString()
        'If tblActifUser.Rows(0)("Admin") = False Then
        'UsersToolStripMenuItem.Visible = False
        'End If
    End Sub

    Private Sub EnreistrementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnreistrementToolStripMenuItem.Click
        Inscription.ShowDialog()
    End Sub

    Private Sub ModificationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationToolStripMenuItem1.Click
        Modification.ShowDialog()
    End Sub

    Private Sub SuppressionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppressionToolStripMenuItem.Click
        Suppression.ShowDialog()
    End Sub

    Private Sub FermerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EnregistrementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrementsToolStripMenuItem.Click
        Frm_EngClient.ShowDialog()
    End Sub

    Private Sub ModificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationToolStripMenuItem.Click
        Frm_modClient.ShowDialog()
    End Sub

    Private Sub ListeClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeClientsToolStripMenuItem.Click
        Liste_Client.ShowDialog()
    End Sub

    Private Sub EnregistrementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrementToolStripMenuItem.Click
        Frm_EngProduit.ShowDialog()
    End Sub

    Private Sub ModificationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationsToolStripMenuItem.Click
        Frm_modProduit.ShowDialog()
    End Sub

    Private Sub ListeProduitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeProduitsToolStripMenuItem.Click
        Liste_Produit.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frm_mouvement.ShowDialog()
    End Sub

   
    


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_h.Text = Now.ToLongTimeString
        lbl_d.Text = Now.Date
    End Sub

    Private Sub ListeMouvementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeMouvementsToolStripMenuItem.Click
        frm_listeproduitparclient.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lbl_u_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim req As String = ""
        'req = "select nom from utilisateur "
        'Dim Cmd As SqlCommand = New SqlCommand(req, cnx)
        'Dim Adap As New SqlDataAdapter
        'Adap.SelectCommand = Cmd
        'lbl_u.Text = recup(req)
    End Sub

    Private Sub ToolStripContainer1_TopToolStripPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProfilsUtilisateursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfilsUtilisateursToolStripMenuItem.Click

    End Sub
End Class