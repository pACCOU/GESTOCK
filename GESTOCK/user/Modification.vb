Public Class Modification

    
    Private Sub Modification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_login.Text = ""
        Me.txt_motpasse.Text = ""
        Me.txt_passenew.Text = ""
        Me.txt_confirmpasse.Text = ""
        Me.txt_login.Focus()
    End Sub

    Private Sub initialiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txt_login.Text = ""
        Me.txt_motpasse.Text = ""
        Me.txt_passenew.Text = ""
        Me.txt_login.Text = ""
        Me.txt_confirmpasse.Text = ""
        Me.txt_login.Focus()
    End Sub
    Private Sub fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub initialiser_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txt_login.Text = ""
        Me.txt_motpasse.Text = ""
        Me.txt_passenew.Text = ""
        Me.txt_confirmpasse.Text = ""
        Me.txt_login.Focus()
    End Sub
    Private Sub txt_login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_login.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(Asc("à"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub txt_motpasse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_motpasse.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub txt_passenew_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_passenew.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub txt_confirmpasse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_confirmpasse.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(Asc("à"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If txt_login.Text = "" Then
            MsgBox(" Veuillez saisir l'identifiant ")
            Exit Sub
        End If
        If txt_motpasse.Text = "" Then
            MsgBox(" Veuillez saisir l'ancien mot de passe ")
            Exit Sub
        End If
        If txt_passenew.Text <> txt_confirmpasse.Text Then
            MsgBox("Confirmation du mot de passe non conforme")
            txt_confirmpasse.Focus()
        ElseIf txt_passenew.Text = "" Or txt_confirmpasse.Text = "" Then
            MsgBox("Veuillez saisir et confirmer le mot de passe")
        Else
            parcourir("select * from utilisateur where login ='" & txt_login.Text & "' and motpasse='" & txt_motpasse.Text & "'")
            dr = cmd.ExecuteReader
            If dr.Read Then
                dr.Close()
                instruction("update utilisateur set motpasse='" & CalculMD5Hash(txt_passenew.Text) & "' where login ='" & txt_login.Text & "' and motpasse='" & CalculMD5Hash(txt_motpasse.Text) & "'", MO)
                Me.txt_login.Text = ""
                Me.txt_motpasse.Text = ""
                Me.txt_passenew.Text = ""
                Me.txt_login.Text = ""
                Me.txt_confirmpasse.Text = ""
                Me.txt_login.Focus()
            Else
                MsgBox(" Identifiant ou l'ancien mot de passe incorrect", MsgBoxStyle.Exclamation)
                txt_login.Focus()
            End If
        End If
    End Sub

    Private Sub Btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_fermer.Click
        Me.Dispose()
    End Sub
End Class