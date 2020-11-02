<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
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
        Me.Lbl_login = New System.Windows.Forms.Label
        Me.Lbl_motpasse = New System.Windows.Forms.Label
        Me.Lbl_nom = New System.Windows.Forms.Label
        Me.Lbl_prenom = New System.Windows.Forms.Label
        Me.txt_login = New System.Windows.Forms.TextBox
        Me.txt_motpasse = New System.Windows.Forms.TextBox
        Me.txt_nom = New System.Windows.Forms.TextBox
        Me.txt_prenom = New System.Windows.Forms.TextBox
        Me.Gb_inscription = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cbx_status = New System.Windows.Forms.ComboBox
        Me.Lbl_status = New System.Windows.Forms.Label
        Me.Lbl_repMotpasse = New System.Windows.Forms.Label
        Me.txt_mtpasseR = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Lbl_titre = New System.Windows.Forms.Label
        Me.btn_enregistrer = New System.Windows.Forms.Button
        Me.Gb_inscription.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_login
        '
        Me.Lbl_login.AutoSize = True
        Me.Lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_login.Location = New System.Drawing.Point(41, 36)
        Me.Lbl_login.Name = "Lbl_login"
        Me.Lbl_login.Size = New System.Drawing.Size(41, 16)
        Me.Lbl_login.TabIndex = 0
        Me.Lbl_login.Text = "Login"
        '
        'Lbl_motpasse
        '
        Me.Lbl_motpasse.AutoSize = True
        Me.Lbl_motpasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_motpasse.Location = New System.Drawing.Point(41, 62)
        Me.Lbl_motpasse.Name = "Lbl_motpasse"
        Me.Lbl_motpasse.Size = New System.Drawing.Size(90, 16)
        Me.Lbl_motpasse.TabIndex = 1
        Me.Lbl_motpasse.Text = "Mot de passe"
        '
        'Lbl_nom
        '
        Me.Lbl_nom.AutoSize = True
        Me.Lbl_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nom.Location = New System.Drawing.Point(41, 37)
        Me.Lbl_nom.Name = "Lbl_nom"
        Me.Lbl_nom.Size = New System.Drawing.Size(37, 16)
        Me.Lbl_nom.TabIndex = 2
        Me.Lbl_nom.Text = "Nom"
        '
        'Lbl_prenom
        '
        Me.Lbl_prenom.AutoSize = True
        Me.Lbl_prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_prenom.Location = New System.Drawing.Point(41, 60)
        Me.Lbl_prenom.Name = "Lbl_prenom"
        Me.Lbl_prenom.Size = New System.Drawing.Size(55, 16)
        Me.Lbl_prenom.TabIndex = 3
        Me.Lbl_prenom.Text = "Prénom"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(195, 32)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(121, 20)
        Me.txt_login.TabIndex = 5
        '
        'txt_motpasse
        '
        Me.txt_motpasse.Location = New System.Drawing.Point(195, 58)
        Me.txt_motpasse.Name = "txt_motpasse"
        Me.txt_motpasse.Size = New System.Drawing.Size(121, 20)
        Me.txt_motpasse.TabIndex = 6
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(144, 33)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(121, 20)
        Me.txt_nom.TabIndex = 7
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(144, 60)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(245, 20)
        Me.txt_prenom.TabIndex = 8
        '
        'Gb_inscription
        '
        Me.Gb_inscription.Controls.Add(Me.txt_prenom)
        Me.Gb_inscription.Controls.Add(Me.txt_nom)
        Me.Gb_inscription.Controls.Add(Me.Lbl_prenom)
        Me.Gb_inscription.Controls.Add(Me.Lbl_nom)
        Me.Gb_inscription.Location = New System.Drawing.Point(70, 79)
        Me.Gb_inscription.Name = "Gb_inscription"
        Me.Gb_inscription.Size = New System.Drawing.Size(419, 114)
        Me.Gb_inscription.TabIndex = 0
        Me.Gb_inscription.TabStop = False
        Me.Gb_inscription.Text = "Enregistrement"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cbx_status)
        Me.GroupBox1.Controls.Add(Me.Lbl_status)
        Me.GroupBox1.Controls.Add(Me.Lbl_repMotpasse)
        Me.GroupBox1.Controls.Add(Me.txt_mtpasseR)
        Me.GroupBox1.Controls.Add(Me.Lbl_login)
        Me.GroupBox1.Controls.Add(Me.Lbl_motpasse)
        Me.GroupBox1.Controls.Add(Me.txt_login)
        Me.GroupBox1.Controls.Add(Me.txt_motpasse)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sécurité"
        '
        'Cbx_status
        '
        Me.Cbx_status.FormattingEnabled = True
        Me.Cbx_status.Items.AddRange(New Object() {"", "1", "2"})
        Me.Cbx_status.Location = New System.Drawing.Point(195, 114)
        Me.Cbx_status.Name = "Cbx_status"
        Me.Cbx_status.Size = New System.Drawing.Size(121, 21)
        Me.Cbx_status.TabIndex = 10
        '
        'Lbl_status
        '
        Me.Lbl_status.AutoSize = True
        Me.Lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_status.Location = New System.Drawing.Point(41, 119)
        Me.Lbl_status.Name = "Lbl_status"
        Me.Lbl_status.Size = New System.Drawing.Size(45, 16)
        Me.Lbl_status.TabIndex = 9
        Me.Lbl_status.Text = "Status"
        '
        'Lbl_repMotpasse
        '
        Me.Lbl_repMotpasse.AutoSize = True
        Me.Lbl_repMotpasse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_repMotpasse.Location = New System.Drawing.Point(41, 88)
        Me.Lbl_repMotpasse.Name = "Lbl_repMotpasse"
        Me.Lbl_repMotpasse.Size = New System.Drawing.Size(146, 16)
        Me.Lbl_repMotpasse.TabIndex = 7
        Me.Lbl_repMotpasse.Text = "Réecrire Mot de Passe"
        '
        'txt_mtpasseR
        '
        Me.txt_mtpasseR.Location = New System.Drawing.Point(195, 84)
        Me.txt_mtpasseR.Name = "txt_mtpasseR"
        Me.txt_mtpasseR.Size = New System.Drawing.Size(121, 20)
        Me.txt_mtpasseR.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Lbl_titre)
        Me.Panel1.Location = New System.Drawing.Point(162, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 61)
        Me.Panel1.TabIndex = 2
        '
        'Lbl_titre
        '
        Me.Lbl_titre.AutoSize = True
        Me.Lbl_titre.Font = New System.Drawing.Font("Miriam Transparent", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_titre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Lbl_titre.Location = New System.Drawing.Point(11, 16)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(297, 23)
        Me.Lbl_titre.TabIndex = 0
        Me.Lbl_titre.Text = "Enregistrement d'un  utilisateur"
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Location = New System.Drawing.Point(214, 405)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(138, 28)
        Me.btn_enregistrer.TabIndex = 3
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(654, 471)
        Me.Controls.Add(Me.btn_enregistrer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gb_inscription)
        Me.MaximizeBox = False
        Me.Name = "Inscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscription"
        Me.Gb_inscription.ResumeLayout(False)
        Me.Gb_inscription.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_login As System.Windows.Forms.Label
    Friend WithEvents Lbl_motpasse As System.Windows.Forms.Label
    Friend WithEvents Lbl_nom As System.Windows.Forms.Label
    Friend WithEvents Lbl_prenom As System.Windows.Forms.Label
    Friend WithEvents txt_login As System.Windows.Forms.TextBox
    Friend WithEvents txt_motpasse As System.Windows.Forms.TextBox
    Friend WithEvents txt_nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_prenom As System.Windows.Forms.TextBox
    Friend WithEvents Gb_inscription As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_repMotpasse As System.Windows.Forms.Label
    Friend WithEvents txt_mtpasseR As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_status As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_titre As System.Windows.Forms.Label
    Friend WithEvents Cbx_status As System.Windows.Forms.ComboBox
    Friend WithEvents btn_enregistrer As System.Windows.Forms.Button
End Class
