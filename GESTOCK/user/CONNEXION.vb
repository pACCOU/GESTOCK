Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class CONNEXION
    Dim s As Integer = 0
    Private Sub CONNEXION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        se_connecter(chemin)
        Me.txt_login.Focus()

    End Sub

    Private Sub Btn_connectio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_connectio.Click
        If txt_login.Text = "" Then
            MsgBox("Veuillez saisir votre identifiant", MsgBoxStyle.Information, " Attention !")
            txt_login.Focus()
            Exit Sub
        ElseIf txt_password.Text = "" Then
            MsgBox("Veuillez saisir votre mot de passe", MsgBoxStyle.Information, " Attention !")
            txt_password.Focus()
            Exit Sub
        End If
        
        Dim i As Boolean = False
        Dim mondataset As New DataSet

        Try

            Dim command As SqlCommand = New SqlCommand("select utilisateur.* from utilisateur", cnx)
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(mondataset, "user")
            Dim nomview As New DataView(mondataset.Tables("user"))

            For Each ligne As DataRow In mondataset.Tables("user").Rows()
                If (recup(txt_login.Text) = ligne("login") And CalculMD5Hash(txt_password.Text) = ligne("motpasse")) Then
                    i = True
                    Fr_Menu.ConnectedUser.Text = ligne("nom")
                    Fr_Menu.Label2.Text = ligne("prenom")
                    If (ligne("idprofil") = 1) Then
                        Fr_Menu.UtilisateursToolStripMenuItem.Enabled = True
                        Fr_Menu.UtilisateursToolStripMenuItem.BackColor = Color.Green
                    Else
                        Fr_Menu.UtilisateursToolStripMenuItem.Enabled = False
                        Fr_Menu.UtilisateursToolStripMenuItem.BackColor = Color.Red

                    End If
                    'FrmMenu.Label1.Text = ligne("compte") & "  est  connecté  à  " & TimeOfDay

                End If

            Next

            If (i = True) Then
                MsgBox("AUTHENTIFICATION REUSSIE  !", MsgBoxStyle.Information, "INFORMATION")

                Fr_Menu.Show()
                Me.Visible = False

            Else
                s = s + 1
                If s < 3 Then
                    MsgBox("Nom d'utilisateur ou mot de passe incorrect", MsgBoxStyle.Critical, " Attention !")
                    Exit Sub
                Else
                    MsgBox("Vous avez atteint le nombre d'essai autorisé", MsgBoxStyle.Critical, " Attention !")
                    End
                End If

            End If
            'Me.txt_motpass.Focus()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cnx.Close()
        'parcourir("select idprofil from utilisateur where login ='" & recup(txt_login.Text) & "' and (motpasse)='" & CalculMD5Hash(txt_password.Text) & "'")
        '' se_connecter(chemin)
        'dr = cmd.ExecuteReader


        'If dr.Read Then
        '    recuperateur_de_statut = dr.GetInt32(0)
        '    dr.Close()

        '    ' Menu_General.Show()
        '    frm_menu.Show()
        '    Me.Visible = False
        'Else
        '    s = s + 1
        '    If s < 3 Then
        '        MsgBox("Nom d'utilisateur ou mot de passe incorrect", MsgBoxStyle.Critical, " Attention !")
        '        dr.Close()
        '    Else
        '        MsgBox("Vous avez atteint le nombre d'essai autorisé", MsgBoxStyle.Critical, " Attention !")
        '        End
        '    End If
        'End If
        'cnx.Close()
        txt_login.Text = ""
        txt_password.Text = ""
    End Sub

    
    Private Sub Btn_fermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_fermer.Click
        Me.Dispose()
    End Sub

    Private Sub txt_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown
        'If e.KeyData = Keys.Space Then
        '    Beep()
        '    MsgBox("attention à l'espace")

        'End If
    End Sub



    Private Sub Motpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        SaisirToutSanEspace(e)
        'Select Case e.KeyChar
        '    Case ChrW(Asc("A")) To ChrW(Asc("Z"))
        '    Case ChrW(Asc("a")) To ChrW(Asc("z"))
        '    Case ChrW(Asc("é"))
        '    Case ChrW(Asc("è"))
        '    Case ChrW(Asc("-"))
        '    Case ChrW(Asc(" "))
        '    Case ChrW(Asc("0")) To ChrW(Asc("9"))
        '    Case ChrW(13), ChrW(8)
        '    Case Else
        '        e.KeyChar = ""
        'End Select
    End Sub

    Private Sub login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_login.KeyPress
        SaisirToutSanEspace(e)
        'Select Case e.KeyChar
        '    Case ChrW(Asc("A")) To ChrW(Asc("Z"))
        '    Case ChrW(Asc("a")) To ChrW(Asc("z"))
        '    Case ChrW(Asc("é"))
        '    Case ChrW(Asc("è"))
        '    Case ChrW(Asc("-"))
        '    Case ChrW(Asc(" "))
        '    Case ChrW(Asc("0")) To ChrW(Asc("9"))
        '    Case ChrW(13), ChrW(8)
        '    Case Else
        '        e.KeyChar = ""
        'End Select
    End Sub
   
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class