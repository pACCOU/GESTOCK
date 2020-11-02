Public Class Suppression

    Private Sub Suppression_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        remplirGridvide(MonDataSet, MonDataAdapteur, "utilisateur", Dat1, "select login, motpasse,nom,prenom,idprofil  from utilisateur")
    End Sub

    Private Sub Btn_supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_supprimer.Click
        Dim rep As DialogResult = MessageBox.Show("Confirmez vous cette suppression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (rep = Windows.Forms.DialogResult.Yes) Then
            instruction("Delete from utilisateur  where login ='" & Me.Dat1.CurrentRow.Cells(0).Value & "' and motpasse='" & Me.Dat1.CurrentRow.Cells(1).Value & "'", SU)
            remplirGridvide(MonDataSet, MonDataAdapteur, "utilisateur", Dat1, "select login, motpasse,nom,prenom,idprofil  from utilisateur")
        End If
    End Sub
End Class