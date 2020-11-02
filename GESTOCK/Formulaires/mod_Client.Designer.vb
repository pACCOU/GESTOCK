<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_modClient
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
        Me.btn_fermer = New System.Windows.Forms.Button
        Me.btn_modifier = New System.Windows.Forms.Button
        Me.btn_client = New System.Windows.Forms.Button
        Me.dtp_datenais = New System.Windows.Forms.DateTimePicker
        Me.txt_emailcli = New System.Windows.Forms.TextBox
        Me.txt_adrcli = New System.Windows.Forms.TextBox
        Me.txt_telcli = New System.Windows.Forms.TextBox
        Me.txt_prenomcli = New System.Windows.Forms.TextBox
        Me.txt_nomcli = New System.Windows.Forms.TextBox
        Me.txt_numcli = New System.Windows.Forms.TextBox
        Me.Lbl_datenaiss = New System.Windows.Forms.Label
        Me.Lbl_email = New System.Windows.Forms.Label
        Me.Lbl_adrcli = New System.Windows.Forms.Label
        Me.Lbl_telcli = New System.Windows.Forms.Label
        Me.Lbl_prenomcli = New System.Windows.Forms.Label
        Me.Lbl_nomcli = New System.Windows.Forms.Label
        Me.Lbl_numcli = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Location = New System.Drawing.Point(789, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 102)
        Me.Panel1.TabIndex = 29
        '
        'btn_fermer
        '
        Me.btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fermer.Location = New System.Drawing.Point(44, 62)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(108, 23)
        Me.btn_fermer.TabIndex = 1
        Me.btn_fermer.Text = "Fermer"
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.Location = New System.Drawing.Point(44, 20)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(108, 27)
        Me.btn_modifier.TabIndex = 0
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_client
        '
        Me.btn_client.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_client.Location = New System.Drawing.Point(367, 72)
        Me.btn_client.Name = "btn_client"
        Me.btn_client.Size = New System.Drawing.Size(34, 23)
        Me.btn_client.TabIndex = 3
        Me.btn_client.Text = "v"
        Me.btn_client.UseVisualStyleBackColor = True
        '
        'dtp_datenais
        '
        Me.dtp_datenais.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datenais.Location = New System.Drawing.Point(245, 301)
        Me.dtp_datenais.Name = "dtp_datenais"
        Me.dtp_datenais.Size = New System.Drawing.Size(116, 20)
        Me.dtp_datenais.TabIndex = 28
        '
        'txt_emailcli
        '
        Me.txt_emailcli.Location = New System.Drawing.Point(245, 260)
        Me.txt_emailcli.Name = "txt_emailcli"
        Me.txt_emailcli.Size = New System.Drawing.Size(306, 20)
        Me.txt_emailcli.TabIndex = 27
        '
        'txt_adrcli
        '
        Me.txt_adrcli.Location = New System.Drawing.Point(245, 219)
        Me.txt_adrcli.Name = "txt_adrcli"
        Me.txt_adrcli.Size = New System.Drawing.Size(233, 20)
        Me.txt_adrcli.TabIndex = 26
        '
        'txt_telcli
        '
        Me.txt_telcli.Location = New System.Drawing.Point(245, 181)
        Me.txt_telcli.Name = "txt_telcli"
        Me.txt_telcli.Size = New System.Drawing.Size(193, 20)
        Me.txt_telcli.TabIndex = 25
        '
        'txt_prenomcli
        '
        Me.txt_prenomcli.Location = New System.Drawing.Point(245, 146)
        Me.txt_prenomcli.Name = "txt_prenomcli"
        Me.txt_prenomcli.Size = New System.Drawing.Size(306, 20)
        Me.txt_prenomcli.TabIndex = 24
        '
        'txt_nomcli
        '
        Me.txt_nomcli.Location = New System.Drawing.Point(245, 109)
        Me.txt_nomcli.Name = "txt_nomcli"
        Me.txt_nomcli.Size = New System.Drawing.Size(233, 20)
        Me.txt_nomcli.TabIndex = 23
        '
        'txt_numcli
        '
        Me.txt_numcli.Location = New System.Drawing.Point(245, 74)
        Me.txt_numcli.Name = "txt_numcli"
        Me.txt_numcli.Size = New System.Drawing.Size(116, 20)
        Me.txt_numcli.TabIndex = 22
        '
        'Lbl_datenaiss
        '
        Me.Lbl_datenaiss.AutoSize = True
        Me.Lbl_datenaiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_datenaiss.Location = New System.Drawing.Point(96, 305)
        Me.Lbl_datenaiss.Name = "Lbl_datenaiss"
        Me.Lbl_datenaiss.Size = New System.Drawing.Size(108, 16)
        Me.Lbl_datenaiss.TabIndex = 21
        Me.Lbl_datenaiss.Text = "Date Naissance "
        '
        'Lbl_email
        '
        Me.Lbl_email.AutoSize = True
        Me.Lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_email.Location = New System.Drawing.Point(96, 260)
        Me.Lbl_email.Name = "Lbl_email"
        Me.Lbl_email.Size = New System.Drawing.Size(45, 16)
        Me.Lbl_email.TabIndex = 20
        Me.Lbl_email.Text = "Email "
        '
        'Lbl_adrcli
        '
        Me.Lbl_adrcli.AutoSize = True
        Me.Lbl_adrcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_adrcli.Location = New System.Drawing.Point(96, 219)
        Me.Lbl_adrcli.Name = "Lbl_adrcli"
        Me.Lbl_adrcli.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_adrcli.TabIndex = 19
        Me.Lbl_adrcli.Text = "Adresse"
        '
        'Lbl_telcli
        '
        Me.Lbl_telcli.AutoSize = True
        Me.Lbl_telcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_telcli.Location = New System.Drawing.Point(96, 181)
        Me.Lbl_telcli.Name = "Lbl_telcli"
        Me.Lbl_telcli.Size = New System.Drawing.Size(74, 16)
        Me.Lbl_telcli.TabIndex = 18
        Me.Lbl_telcli.Text = "Téléphone"
        '
        'Lbl_prenomcli
        '
        Me.Lbl_prenomcli.AutoSize = True
        Me.Lbl_prenomcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_prenomcli.Location = New System.Drawing.Point(96, 146)
        Me.Lbl_prenomcli.Name = "Lbl_prenomcli"
        Me.Lbl_prenomcli.Size = New System.Drawing.Size(62, 16)
        Me.Lbl_prenomcli.TabIndex = 17
        Me.Lbl_prenomcli.Text = "Prénoms"
        '
        'Lbl_nomcli
        '
        Me.Lbl_nomcli.AutoSize = True
        Me.Lbl_nomcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nomcli.Location = New System.Drawing.Point(96, 109)
        Me.Lbl_nomcli.Name = "Lbl_nomcli"
        Me.Lbl_nomcli.Size = New System.Drawing.Size(37, 16)
        Me.Lbl_nomcli.TabIndex = 16
        Me.Lbl_nomcli.Text = "Nom"
        '
        'Lbl_numcli
        '
        Me.Lbl_numcli.AutoSize = True
        Me.Lbl_numcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_numcli.Location = New System.Drawing.Point(96, 74)
        Me.Lbl_numcli.Name = "Lbl_numcli"
        Me.Lbl_numcli.Size = New System.Drawing.Size(92, 16)
        Me.Lbl_numcli.TabIndex = 15
        Me.Lbl_numcli.Text = "Numéro Client"
        '
        'Frm_modClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1073, 478)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtp_datenais)
        Me.Controls.Add(Me.btn_client)
        Me.Controls.Add(Me.txt_emailcli)
        Me.Controls.Add(Me.txt_adrcli)
        Me.Controls.Add(Me.txt_telcli)
        Me.Controls.Add(Me.txt_prenomcli)
        Me.Controls.Add(Me.txt_nomcli)
        Me.Controls.Add(Me.txt_numcli)
        Me.Controls.Add(Me.Lbl_datenaiss)
        Me.Controls.Add(Me.Lbl_email)
        Me.Controls.Add(Me.Lbl_adrcli)
        Me.Controls.Add(Me.Lbl_telcli)
        Me.Controls.Add(Me.Lbl_prenomcli)
        Me.Controls.Add(Me.Lbl_nomcli)
        Me.Controls.Add(Me.Lbl_numcli)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Frm_modClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mod_Client"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_modifier As System.Windows.Forms.Button
    Friend WithEvents dtp_datenais As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_emailcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_adrcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_telcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_prenomcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_numcli As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_datenaiss As System.Windows.Forms.Label
    Friend WithEvents Lbl_email As System.Windows.Forms.Label
    Friend WithEvents Lbl_adrcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_telcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_prenomcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_nomcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_numcli As System.Windows.Forms.Label
    Friend WithEvents btn_client As System.Windows.Forms.Button
End Class
