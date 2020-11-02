<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONNEXION
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_fermer = New System.Windows.Forms.Button
        Me.txt_password = New System.Windows.Forms.TextBox
        Me.Lbl_motpasse = New System.Windows.Forms.Label
        Me.Lbl_login = New System.Windows.Forms.Label
        Me.txt_login = New System.Windows.Forms.TextBox
        Me.Btn_connectio = New System.Windows.Forms.Button
        Me.Llb_titre = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Llb_titre)
        Me.Panel1.Controls.Add(Me.Btn_fermer)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.Lbl_motpasse)
        Me.Panel1.Controls.Add(Me.Lbl_login)
        Me.Panel1.Controls.Add(Me.txt_login)
        Me.Panel1.Controls.Add(Me.Btn_connectio)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 357)
        Me.Panel1.TabIndex = 0
        '
        'Btn_fermer
        '
        Me.Btn_fermer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_fermer.Location = New System.Drawing.Point(221, 260)
        Me.Btn_fermer.Name = "Btn_fermer"
        Me.Btn_fermer.Size = New System.Drawing.Size(138, 36)
        Me.Btn_fermer.TabIndex = 5
        Me.Btn_fermer.Text = "Fermer"
        Me.Btn_fermer.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_password.Location = New System.Drawing.Point(161, 172)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(155, 20)
        Me.txt_password.TabIndex = 4
        '
        'Lbl_motpasse
        '
        Me.Lbl_motpasse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_motpasse.AutoSize = True
        Me.Lbl_motpasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_motpasse.Location = New System.Drawing.Point(56, 179)
        Me.Lbl_motpasse.Name = "Lbl_motpasse"
        Me.Lbl_motpasse.Size = New System.Drawing.Size(68, 16)
        Me.Lbl_motpasse.TabIndex = 3
        Me.Lbl_motpasse.Text = "Password"
        '
        'Lbl_login
        '
        Me.Lbl_login.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_login.AutoSize = True
        Me.Lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_login.Location = New System.Drawing.Point(56, 142)
        Me.Lbl_login.Name = "Lbl_login"
        Me.Lbl_login.Size = New System.Drawing.Size(41, 16)
        Me.Lbl_login.TabIndex = 2
        Me.Lbl_login.Text = "Login"
        '
        'txt_login
        '
        Me.txt_login.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_login.Location = New System.Drawing.Point(161, 138)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(155, 20)
        Me.txt_login.TabIndex = 1
        '
        'Btn_connectio
        '
        Me.Btn_connectio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_connectio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_connectio.Location = New System.Drawing.Point(59, 260)
        Me.Btn_connectio.Name = "Btn_connectio"
        Me.Btn_connectio.Size = New System.Drawing.Size(131, 36)
        Me.Btn_connectio.TabIndex = 0
        Me.Btn_connectio.Text = "Se connecter"
        Me.Btn_connectio.UseVisualStyleBackColor = True
        '
        'Llb_titre
        '
        Me.Llb_titre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Llb_titre.AutoSize = True
        Me.Llb_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llb_titre.Location = New System.Drawing.Point(132, 73)
        Me.Llb_titre.Name = "Llb_titre"
        Me.Llb_titre.Size = New System.Drawing.Size(80, 13)
        Me.Llb_titre.TabIndex = 1
        Me.Llb_titre.Text = "CONNEXION"
        '
        'CONNEXION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(405, 359)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CONNEXION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONNEXION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_login As System.Windows.Forms.TextBox
    Friend WithEvents Btn_connectio As System.Windows.Forms.Button
    Friend WithEvents Llb_titre As System.Windows.Forms.Label
    Friend WithEvents Lbl_motpasse As System.Windows.Forms.Label
    Friend WithEvents Lbl_login As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Btn_fermer As System.Windows.Forms.Button
End Class
