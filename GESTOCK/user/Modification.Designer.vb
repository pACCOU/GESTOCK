<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modification
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
        Me.txt_login = New System.Windows.Forms.TextBox
        Me.Btn_Enregistrer = New System.Windows.Forms.Button
        Me.gb_utilisateur = New System.Windows.Forms.GroupBox
        Me.Lbl_confirmPasse = New System.Windows.Forms.Label
        Me.txt_confirmpasse = New System.Windows.Forms.TextBox
        Me.Lbl_nouveau = New System.Windows.Forms.Label
        Me.txt_motpasse = New System.Windows.Forms.TextBox
        Me.Lbl_motpasse = New System.Windows.Forms.Label
        Me.txt_passenew = New System.Windows.Forms.TextBox
        Me.Lbl_modification = New System.Windows.Forms.Label
        Me.Btn_fermer = New System.Windows.Forms.Button
        Me.gb_utilisateur.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_login
        '
        Me.Lbl_login.AutoSize = True
        Me.Lbl_login.Location = New System.Drawing.Point(61, 40)
        Me.Lbl_login.Name = "Lbl_login"
        Me.Lbl_login.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_login.TabIndex = 0
        Me.Lbl_login.Text = "Login"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(214, 33)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(129, 20)
        Me.txt_login.TabIndex = 1
        '
        'Btn_Enregistrer
        '
        Me.Btn_Enregistrer.Location = New System.Drawing.Point(569, 146)
        Me.Btn_Enregistrer.Name = "Btn_Enregistrer"
        Me.Btn_Enregistrer.Size = New System.Drawing.Size(96, 41)
        Me.Btn_Enregistrer.TabIndex = 2
        Me.Btn_Enregistrer.Text = "Enregistrer"
        Me.Btn_Enregistrer.UseVisualStyleBackColor = True
        '
        'gb_utilisateur
        '
        Me.gb_utilisateur.Controls.Add(Me.Lbl_confirmPasse)
        Me.gb_utilisateur.Controls.Add(Me.txt_confirmpasse)
        Me.gb_utilisateur.Controls.Add(Me.Lbl_nouveau)
        Me.gb_utilisateur.Controls.Add(Me.txt_motpasse)
        Me.gb_utilisateur.Controls.Add(Me.Lbl_motpasse)
        Me.gb_utilisateur.Controls.Add(Me.txt_passenew)
        Me.gb_utilisateur.Controls.Add(Me.Lbl_login)
        Me.gb_utilisateur.Controls.Add(Me.txt_login)
        Me.gb_utilisateur.Location = New System.Drawing.Point(80, 77)
        Me.gb_utilisateur.Name = "gb_utilisateur"
        Me.gb_utilisateur.Size = New System.Drawing.Size(483, 200)
        Me.gb_utilisateur.TabIndex = 4
        Me.gb_utilisateur.TabStop = False
        Me.gb_utilisateur.Text = "Utilisateur"
        '
        'Lbl_confirmPasse
        '
        Me.Lbl_confirmPasse.AutoSize = True
        Me.Lbl_confirmPasse.Location = New System.Drawing.Point(61, 140)
        Me.Lbl_confirmPasse.Name = "Lbl_confirmPasse"
        Me.Lbl_confirmPasse.Size = New System.Drawing.Size(141, 13)
        Me.Lbl_confirmPasse.TabIndex = 6
        Me.Lbl_confirmPasse.Text = "Confirmer Mot de Passe"
        '
        'txt_confirmpasse
        '
        Me.txt_confirmpasse.Location = New System.Drawing.Point(214, 140)
        Me.txt_confirmpasse.Name = "txt_confirmpasse"
        Me.txt_confirmpasse.Size = New System.Drawing.Size(194, 20)
        Me.txt_confirmpasse.TabIndex = 7
        '
        'Lbl_nouveau
        '
        Me.Lbl_nouveau.AutoSize = True
        Me.Lbl_nouveau.Location = New System.Drawing.Point(61, 104)
        Me.Lbl_nouveau.Name = "Lbl_nouveau"
        Me.Lbl_nouveau.Size = New System.Drawing.Size(139, 13)
        Me.Lbl_nouveau.TabIndex = 4
        Me.Lbl_nouveau.Text = "Nouveau Mot de Passe"
        '
        'txt_motpasse
        '
        Me.txt_motpasse.Location = New System.Drawing.Point(214, 69)
        Me.txt_motpasse.Name = "txt_motpasse"
        Me.txt_motpasse.Size = New System.Drawing.Size(194, 20)
        Me.txt_motpasse.TabIndex = 5
        '
        'Lbl_motpasse
        '
        Me.Lbl_motpasse.AutoSize = True
        Me.Lbl_motpasse.Location = New System.Drawing.Point(61, 76)
        Me.Lbl_motpasse.Name = "Lbl_motpasse"
        Me.Lbl_motpasse.Size = New System.Drawing.Size(131, 13)
        Me.Lbl_motpasse.TabIndex = 2
        Me.Lbl_motpasse.Text = "Ancient Mot de Passe"
        '
        'txt_passenew
        '
        Me.txt_passenew.Location = New System.Drawing.Point(214, 104)
        Me.txt_passenew.Name = "txt_passenew"
        Me.txt_passenew.Size = New System.Drawing.Size(194, 20)
        Me.txt_passenew.TabIndex = 3
        '
        'Lbl_modification
        '
        Me.Lbl_modification.AutoSize = True
        Me.Lbl_modification.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_modification.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Lbl_modification.Location = New System.Drawing.Point(218, 27)
        Me.Lbl_modification.Name = "Lbl_modification"
        Me.Lbl_modification.Size = New System.Drawing.Size(270, 24)
        Me.Lbl_modification.TabIndex = 3
        Me.Lbl_modification.Text = "Modification d'un mot de passe"
        Me.Lbl_modification.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_fermer
        '
        Me.Btn_fermer.Location = New System.Drawing.Point(569, 196)
        Me.Btn_fermer.Name = "Btn_fermer"
        Me.Btn_fermer.Size = New System.Drawing.Size(96, 41)
        Me.Btn_fermer.TabIndex = 5
        Me.Btn_fermer.Text = "Fermer"
        Me.Btn_fermer.UseVisualStyleBackColor = True
        '
        'Modification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 316)
        Me.Controls.Add(Me.Btn_fermer)
        Me.Controls.Add(Me.gb_utilisateur)
        Me.Controls.Add(Me.Lbl_modification)
        Me.Controls.Add(Me.Btn_Enregistrer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Modification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modification"
        Me.gb_utilisateur.ResumeLayout(False)
        Me.gb_utilisateur.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_login As System.Windows.Forms.Label
    Friend WithEvents txt_login As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Enregistrer As System.Windows.Forms.Button
    Friend WithEvents gb_utilisateur As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_confirmPasse As System.Windows.Forms.Label
    Friend WithEvents txt_confirmpasse As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_nouveau As System.Windows.Forms.Label
    Friend WithEvents txt_motpasse As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_motpasse As System.Windows.Forms.Label
    Friend WithEvents txt_passenew As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_modification As System.Windows.Forms.Label
    Friend WithEvents Btn_fermer As System.Windows.Forms.Button
End Class
