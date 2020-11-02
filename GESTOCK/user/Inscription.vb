Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class Inscription
    Private Sub nom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nom.KeyPress
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
    Private Sub prenom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_prenom.KeyPress
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
    Private Sub id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_login.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub mp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_motpasse.KeyPress
        Select Case e.KeyChar
            Case ChrW(Asc("A")) To ChrW(Asc("Z"))
            Case ChrW(Asc("a")) To ChrW(Asc("z"))
            Case ChrW(Asc("é"))
            Case ChrW(Asc("è"))
            Case ChrW(Asc("-"))
            Case ChrW(Asc("à"))
            Case ChrW(Asc(" "))
            Case ChrW(Asc("ï"))
            Case ChrW(Asc("ô"))
            Case ChrW(Asc("â"))
            Case ChrW(13), ChrW(8)
            Case ChrW(Asc("0")) To ChrW(Asc("9"))
            Case ChrW(13), ChrW(8)
            Case Else
                e.KeyChar = ""
        End Select
    End Sub
    Private Sub cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mtpasseR.KeyPress
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
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gb_inscription.Enter

    End Sub

    Private Sub stat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbx_status.KeyPress
        e.KeyChar = ""
    End Sub

    

    Private Sub Inscription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se_connecter(chemin)

        Me.txt_nom.Text = ""
        Me.txt_prenom.Text = ""
        Me.txt_login.Text = ""
        Me.txt_motpasse.Text = ""
        Me.txt_mtpasseR.Text = ""
        Me.txt_nom.Focus()

    End Sub



    Private Sub Cbx_status_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Cbx_status.SelectedIndexChanged

    End Sub

    Private Sub btn_enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enregistrer.Click
        If (Me.txt_nom.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Nom")
            Me.txt_nom.Focus()
            Exit Sub
        End If
        If (Me.txt_prenom.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Prénom")
            Me.txt_prenom.Focus()
            Exit Sub
        End If

        If (Me.txt_login.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Identifiant")
            Me.txt_login.Focus()
            Exit Sub
        End If
        If (Me.txt_motpasse.Text = "") Then
            MessageBox.Show("Veuillez remplir le champ Mot de passe")
            Me.txt_motpasse.Focus()
            Exit Sub
        End If
        If (Me.txt_mtpasseR.Text = "") Then
            MessageBox.Show("Veuillez confirmer le mot de passe")
            Me.txt_mtpasseR.Focus()
            Exit Sub
        ElseIf (Me.Cbx_status.Text = "") Then
            MessageBox.Show("Veuillez choisir un statut")
            Exit Sub
        End If

        If txt_motpasse.Text <> txt_mtpasseR.Text Then
            MsgBox("les deux mots de passes ne correspondent pas..", MsgBoxStyle.Critical)
            Me.txt_motpasse.Text = ""
            Me.txt_mtpasseR.Text = ""
            Me.txt_motpasse.Focus()
            Exit Sub
        End If
        Dim rep As DialogResult = MessageBox.Show("Confirmez vous cet enregistrement ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (rep = Windows.Forms.DialogResult.Yes) Then
            instruction("insert into utilisateur values('" & txt_login.Text & "','" & CalculMD5Hash(txt_motpasse.Text) & "','" & txt_nom.Text & "','" & txt_prenom.Text & "','" & Cbx_status.Text & "')", EN)

            Me.txt_nom.Text = ""
            Me.txt_prenom.Text = ""
            Me.txt_login.Text = ""
            Me.txt_motpasse.Text = ""
            Me.txt_mtpasseR.Text = ""
            Me.txt_nom.Focus()
        End If

    End Sub
    
End Class