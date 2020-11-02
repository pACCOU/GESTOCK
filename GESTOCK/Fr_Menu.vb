Imports System.Windows.Forms

Public Class Fr_Menu

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Créez une nouvelle instance du formulaire enfant.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Fenêtre " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO : ajoutez le code ici pour ouvrir le fichier.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO : ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilisez My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData pour extraire les informations du Presse-papiers.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub StatusStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Fr_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub EnregistrementClieintsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrementClieintsToolStripMenuItem.Click
        Frm_EngClient.ShowDialog()
    End Sub

    Private Sub MoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoToolStripMenuItem.Click
        Frm_modClient.ShowDialog()
    End Sub

    Private Sub ListeDesClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeDesClientsToolStripMenuItem.Click
        Liste_Client.ShowDialog()
    End Sub

    Private Sub EnregistrementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrementToolStripMenuItem.Click
        Frm_EngProduit.ShowDialog()
    End Sub

    Private Sub ModificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationToolStripMenuItem.Click
        Frm_modProduit.ShowDialog()
    End Sub

    Private Sub ListeDesProduitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeDesProduitsToolStripMenuItem.Click
        Liste_Produit.ShowDialog()
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EToolStripMenuItem.Click
        frm_mouvement.ShowDialog()
    End Sub

    Private Sub ListeDesMouvementsEffectuésToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeDesMouvementsEffectuésToolStripMenuItem.Click
        frm_listeproduitparclient.ShowDialog()
    End Sub

    Private Sub UtilisateursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilisateursToolStripMenuItem.Click

    End Sub

    Private Sub EnregisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregisToolStripMenuItem.Click
        Inscription.ShowDialog()
    End Sub

    Private Sub ModificationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationToolStripMenuItem1.Click
        Modification.ShowDialog()
    End Sub

    Private Sub SuppressionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppressionToolStripMenuItem.Click
        Suppression.ShowDialog()
    End Sub

    Private Sub FERMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FERMERToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_h.Text = Now.ToLongTimeString
        lbl_d.Text = Now.Date
    End Sub
End Class
