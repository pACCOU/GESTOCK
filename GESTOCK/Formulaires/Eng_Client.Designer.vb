<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EngClient
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
        Me.btn_fermer = New System.Windows.Forms.Button
        Me.btn_enregistrer = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Lbl_numcli = New System.Windows.Forms.Label
        Me.Lbl_nomcli = New System.Windows.Forms.Label
        Me.Lbl_prenomcli = New System.Windows.Forms.Label
        Me.Lbl_telcli = New System.Windows.Forms.Label
        Me.Lbl_adrcli = New System.Windows.Forms.Label
        Me.Lbl_email = New System.Windows.Forms.Label
        Me.Lbl_datenaiss = New System.Windows.Forms.Label
        Me.txt_numcli = New System.Windows.Forms.TextBox
        Me.txt_nomcli = New System.Windows.Forms.TextBox
        Me.txt_prenomcli = New System.Windows.Forms.TextBox
        Me.txt_telcli = New System.Windows.Forms.TextBox
        Me.txt_adrcli = New System.Windows.Forms.TextBox
        Me.txt_emailcli = New System.Windows.Forms.TextBox
        Me.dtp_datenais = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_fermer
        '
        Me.btn_fermer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fermer.Location = New System.Drawing.Point(162, 19)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(93, 23)
        Me.btn_fermer.TabIndex = 1
        Me.btn_fermer.Text = "Fermer"
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enregistrer.Location = New System.Drawing.Point(38, 19)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(93, 27)
        Me.btn_enregistrer.TabIndex = 0
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_enregistrer)
        Me.Panel1.Location = New System.Drawing.Point(466, 331)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 69)
        Me.Panel1.TabIndex = 30
        '
        'Lbl_numcli
        '
        Me.Lbl_numcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_numcli.AutoSize = True
        Me.Lbl_numcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_numcli.Location = New System.Drawing.Point(50, 60)
        Me.Lbl_numcli.Name = "Lbl_numcli"
        Me.Lbl_numcli.Size = New System.Drawing.Size(92, 16)
        Me.Lbl_numcli.TabIndex = 16
        Me.Lbl_numcli.Text = "Numéro Client"
        '
        'Lbl_nomcli
        '
        Me.Lbl_nomcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_nomcli.AutoSize = True
        Me.Lbl_nomcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nomcli.Location = New System.Drawing.Point(50, 95)
        Me.Lbl_nomcli.Name = "Lbl_nomcli"
        Me.Lbl_nomcli.Size = New System.Drawing.Size(37, 16)
        Me.Lbl_nomcli.TabIndex = 17
        Me.Lbl_nomcli.Text = "Nom"
        '
        'Lbl_prenomcli
        '
        Me.Lbl_prenomcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_prenomcli.AutoSize = True
        Me.Lbl_prenomcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_prenomcli.Location = New System.Drawing.Point(50, 132)
        Me.Lbl_prenomcli.Name = "Lbl_prenomcli"
        Me.Lbl_prenomcli.Size = New System.Drawing.Size(62, 16)
        Me.Lbl_prenomcli.TabIndex = 18
        Me.Lbl_prenomcli.Text = "Prénoms"
        '
        'Lbl_telcli
        '
        Me.Lbl_telcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_telcli.AutoSize = True
        Me.Lbl_telcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_telcli.Location = New System.Drawing.Point(50, 167)
        Me.Lbl_telcli.Name = "Lbl_telcli"
        Me.Lbl_telcli.Size = New System.Drawing.Size(74, 16)
        Me.Lbl_telcli.TabIndex = 19
        Me.Lbl_telcli.Text = "Téléphone"
        '
        'Lbl_adrcli
        '
        Me.Lbl_adrcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_adrcli.AutoSize = True
        Me.Lbl_adrcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_adrcli.Location = New System.Drawing.Point(50, 205)
        Me.Lbl_adrcli.Name = "Lbl_adrcli"
        Me.Lbl_adrcli.Size = New System.Drawing.Size(59, 16)
        Me.Lbl_adrcli.TabIndex = 20
        Me.Lbl_adrcli.Text = "Adresse"
        '
        'Lbl_email
        '
        Me.Lbl_email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_email.AutoSize = True
        Me.Lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_email.Location = New System.Drawing.Point(50, 246)
        Me.Lbl_email.Name = "Lbl_email"
        Me.Lbl_email.Size = New System.Drawing.Size(45, 16)
        Me.Lbl_email.TabIndex = 21
        Me.Lbl_email.Text = "Email "
        '
        'Lbl_datenaiss
        '
        Me.Lbl_datenaiss.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_datenaiss.AutoSize = True
        Me.Lbl_datenaiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_datenaiss.Location = New System.Drawing.Point(50, 291)
        Me.Lbl_datenaiss.Name = "Lbl_datenaiss"
        Me.Lbl_datenaiss.Size = New System.Drawing.Size(108, 16)
        Me.Lbl_datenaiss.TabIndex = 22
        Me.Lbl_datenaiss.Text = "Date Naissance "
        '
        'txt_numcli
        '
        Me.txt_numcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_numcli.BackColor = System.Drawing.Color.White
        Me.txt_numcli.Location = New System.Drawing.Point(178, 60)
        Me.txt_numcli.Name = "txt_numcli"
        Me.txt_numcli.Size = New System.Drawing.Size(100, 20)
        Me.txt_numcli.TabIndex = 23
        '
        'txt_nomcli
        '
        Me.txt_nomcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nomcli.BackColor = System.Drawing.SystemColors.Window
        Me.txt_nomcli.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_nomcli.Location = New System.Drawing.Point(178, 95)
        Me.txt_nomcli.Name = "txt_nomcli"
        Me.txt_nomcli.Size = New System.Drawing.Size(200, 20)
        Me.txt_nomcli.TabIndex = 24
        '
        'txt_prenomcli
        '
        Me.txt_prenomcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_prenomcli.BackColor = System.Drawing.SystemColors.Window
        Me.txt_prenomcli.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_prenomcli.Location = New System.Drawing.Point(178, 132)
        Me.txt_prenomcli.Name = "txt_prenomcli"
        Me.txt_prenomcli.Size = New System.Drawing.Size(263, 20)
        Me.txt_prenomcli.TabIndex = 25
        '
        'txt_telcli
        '
        Me.txt_telcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telcli.BackColor = System.Drawing.SystemColors.Window
        Me.txt_telcli.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_telcli.Location = New System.Drawing.Point(178, 167)
        Me.txt_telcli.Name = "txt_telcli"
        Me.txt_telcli.Size = New System.Drawing.Size(166, 20)
        Me.txt_telcli.TabIndex = 26
        '
        'txt_adrcli
        '
        Me.txt_adrcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_adrcli.BackColor = System.Drawing.SystemColors.Window
        Me.txt_adrcli.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_adrcli.Location = New System.Drawing.Point(178, 205)
        Me.txt_adrcli.Name = "txt_adrcli"
        Me.txt_adrcli.Size = New System.Drawing.Size(200, 20)
        Me.txt_adrcli.TabIndex = 27
        '
        'txt_emailcli
        '
        Me.txt_emailcli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_emailcli.BackColor = System.Drawing.SystemColors.Window
        Me.txt_emailcli.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_emailcli.Location = New System.Drawing.Point(178, 246)
        Me.txt_emailcli.Name = "txt_emailcli"
        Me.txt_emailcli.Size = New System.Drawing.Size(263, 20)
        Me.txt_emailcli.TabIndex = 28
        '
        'dtp_datenais
        '
        Me.dtp_datenais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_datenais.CalendarMonthBackground = System.Drawing.SystemColors.WindowText
        Me.dtp_datenais.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datenais.Location = New System.Drawing.Point(178, 287)
        Me.dtp_datenais.Name = "dtp_datenais"
        Me.dtp_datenais.Size = New System.Drawing.Size(100, 20)
        Me.dtp_datenais.TabIndex = 29
        Me.dtp_datenais.Value = New Date(2018, 7, 4, 0, 0, 0, 0)
        '
        'Frm_EngClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 412)
        Me.Controls.Add(Me.dtp_datenais)
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
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Frm_EngClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eng_Client"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_enregistrer As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_numcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_nomcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_prenomcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_telcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_adrcli As System.Windows.Forms.Label
    Friend WithEvents Lbl_email As System.Windows.Forms.Label
    Friend WithEvents Lbl_datenaiss As System.Windows.Forms.Label
    Friend WithEvents txt_numcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_prenomcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_telcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_adrcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_emailcli As System.Windows.Forms.TextBox
    Friend WithEvents dtp_datenais As System.Windows.Forms.DateTimePicker
End Class
