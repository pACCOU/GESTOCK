<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mouvement
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btn_fermer = New System.Windows.Forms.Button
        Me.Btn_enregistrer = New System.Windows.Forms.Button
        Me.txt_idmvt = New System.Windows.Forms.TextBox
        Me.txt_nomcli = New System.Windows.Forms.TextBox
        Me.txt_designation = New System.Windows.Forms.TextBox
        Me.Btn_numprod = New System.Windows.Forms.Button
        Me.Btn_numcli = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Dtp_datemvt = New System.Windows.Forms.DateTimePicker
        Me.Cbx_typemvt = New System.Windows.Forms.ComboBox
        Me.txt_numprod = New System.Windows.Forms.TextBox
        Me.txt_numcli = New System.Windows.Forms.TextBox
        Me.txt_monttva = New System.Windows.Forms.TextBox
        Me.txt_tva = New System.Windows.Forms.TextBox
        Me.txt_mont = New System.Windows.Forms.TextBox
        Me.txt_pu = New System.Windows.Forms.TextBox
        Me.txt_qte = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_fermer)
        Me.Panel2.Controls.Add(Me.Btn_enregistrer)
        Me.Panel2.Location = New System.Drawing.Point(486, 182)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 76)
        Me.Panel2.TabIndex = 29
        '
        'Btn_fermer
        '
        Me.Btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_fermer.Location = New System.Drawing.Point(207, 24)
        Me.Btn_fermer.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_fermer.Name = "Btn_fermer"
        Me.Btn_fermer.Size = New System.Drawing.Size(124, 28)
        Me.Btn_fermer.TabIndex = 1
        Me.Btn_fermer.Text = "Fermer"
        Me.Btn_fermer.UseVisualStyleBackColor = True
        '
        'Btn_enregistrer
        '
        Me.Btn_enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_enregistrer.Location = New System.Drawing.Point(39, 22)
        Me.Btn_enregistrer.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_enregistrer.Name = "Btn_enregistrer"
        Me.Btn_enregistrer.Size = New System.Drawing.Size(124, 33)
        Me.Btn_enregistrer.TabIndex = 0
        Me.Btn_enregistrer.Text = "Enregistrer"
        Me.Btn_enregistrer.UseVisualStyleBackColor = True
        '
        'txt_idmvt
        '
        Me.txt_idmvt.Location = New System.Drawing.Point(80, 27)
        Me.txt_idmvt.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_idmvt.Name = "txt_idmvt"
        Me.txt_idmvt.Size = New System.Drawing.Size(121, 22)
        Me.txt_idmvt.TabIndex = 86
        Me.txt_idmvt.Visible = False
        '
        'txt_nomcli
        '
        Me.txt_nomcli.Location = New System.Drawing.Point(580, 66)
        Me.txt_nomcli.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomcli.Name = "txt_nomcli"
        Me.txt_nomcli.Size = New System.Drawing.Size(201, 22)
        Me.txt_nomcli.TabIndex = 85
        '
        'txt_designation
        '
        Me.txt_designation.Location = New System.Drawing.Point(580, 107)
        Me.txt_designation.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_designation.Name = "txt_designation"
        Me.txt_designation.Size = New System.Drawing.Size(201, 22)
        Me.txt_designation.TabIndex = 84
        '
        'Btn_numprod
        '
        Me.Btn_numprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_numprod.Location = New System.Drawing.Point(432, 101)
        Me.Btn_numprod.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_numprod.Name = "Btn_numprod"
        Me.Btn_numprod.Size = New System.Drawing.Size(33, 22)
        Me.Btn_numprod.TabIndex = 83
        Me.Btn_numprod.Text = "v"
        Me.Btn_numprod.UseVisualStyleBackColor = True
        '
        'Btn_numcli
        '
        Me.Btn_numcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_numcli.Location = New System.Drawing.Point(432, 66)
        Me.Btn_numcli.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_numcli.Name = "Btn_numcli"
        Me.Btn_numcli.Size = New System.Drawing.Size(33, 22)
        Me.Btn_numcli.TabIndex = 82
        Me.Btn_numcli.Text = "v"
        Me.Btn_numcli.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Numéro Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Numéro Produit"
        '
        'Dtp_datemvt
        '
        Me.Dtp_datemvt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_datemvt.Location = New System.Drawing.Point(317, 182)
        Me.Dtp_datemvt.Margin = New System.Windows.Forms.Padding(4)
        Me.Dtp_datemvt.Name = "Dtp_datemvt"
        Me.Dtp_datemvt.Size = New System.Drawing.Size(107, 22)
        Me.Dtp_datemvt.TabIndex = 79
        Me.Dtp_datemvt.Value = New Date(2018, 7, 4, 0, 0, 0, 0)
        '
        'Cbx_typemvt
        '
        Me.Cbx_typemvt.FormattingEnabled = True
        Me.Cbx_typemvt.Items.AddRange(New Object() {"", "Achat", "Vente"})
        Me.Cbx_typemvt.Location = New System.Drawing.Point(317, 139)
        Me.Cbx_typemvt.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbx_typemvt.Name = "Cbx_typemvt"
        Me.Cbx_typemvt.Size = New System.Drawing.Size(107, 24)
        Me.Cbx_typemvt.TabIndex = 78
        '
        'txt_numprod
        '
        Me.txt_numprod.Location = New System.Drawing.Point(317, 98)
        Me.txt_numprod.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numprod.Name = "txt_numprod"
        Me.txt_numprod.Size = New System.Drawing.Size(107, 22)
        Me.txt_numprod.TabIndex = 77
        '
        'txt_numcli
        '
        Me.txt_numcli.Location = New System.Drawing.Point(317, 66)
        Me.txt_numcli.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_numcli.Name = "txt_numcli"
        Me.txt_numcli.Size = New System.Drawing.Size(107, 22)
        Me.txt_numcli.TabIndex = 76
        '
        'txt_monttva
        '
        Me.txt_monttva.Location = New System.Drawing.Point(317, 350)
        Me.txt_monttva.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_monttva.Name = "txt_monttva"
        Me.txt_monttva.Size = New System.Drawing.Size(107, 22)
        Me.txt_monttva.TabIndex = 75
        '
        'txt_tva
        '
        Me.txt_tva.Location = New System.Drawing.Point(761, 333)
        Me.txt_tva.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tva.Name = "txt_tva"
        Me.txt_tva.Size = New System.Drawing.Size(107, 22)
        Me.txt_tva.TabIndex = 74
        Me.txt_tva.Visible = False
        '
        'txt_mont
        '
        Me.txt_mont.Enabled = False
        Me.txt_mont.Location = New System.Drawing.Point(317, 302)
        Me.txt_mont.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_mont.Name = "txt_mont"
        Me.txt_mont.Size = New System.Drawing.Size(107, 22)
        Me.txt_mont.TabIndex = 73
        '
        'txt_pu
        '
        Me.txt_pu.Location = New System.Drawing.Point(317, 261)
        Me.txt_pu.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pu.Name = "txt_pu"
        Me.txt_pu.Size = New System.Drawing.Size(107, 22)
        Me.txt_pu.TabIndex = 72
        '
        'txt_qte
        '
        Me.txt_qte.Location = New System.Drawing.Point(317, 222)
        Me.txt_qte.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_qte.Name = "txt_qte"
        Me.txt_qte.Size = New System.Drawing.Size(107, 22)
        Me.txt_qte.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Prix Unité"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Quantité"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(77, 359)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Montant TVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(521, 336)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Taux TVA"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 305)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Montant Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(494, 66)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Nom Client"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(494, 110)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Désignation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 143)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Type Mouvement"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(77, 182)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 16)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Date Mouvement"
        '
        'frm_mouvement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(900, 662)
        Me.Controls.Add(Me.txt_idmvt)
        Me.Controls.Add(Me.txt_nomcli)
        Me.Controls.Add(Me.txt_designation)
        Me.Controls.Add(Me.Btn_numprod)
        Me.Controls.Add(Me.Btn_numcli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dtp_datemvt)
        Me.Controls.Add(Me.Cbx_typemvt)
        Me.Controls.Add(Me.txt_numprod)
        Me.Controls.Add(Me.txt_numcli)
        Me.Controls.Add(Me.txt_monttva)
        Me.Controls.Add(Me.txt_tva)
        Me.Controls.Add(Me.txt_mont)
        Me.Controls.Add(Me.txt_pu)
        Me.Controls.Add(Me.txt_qte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frm_mouvement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mouvement"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btn_fermer As System.Windows.Forms.Button
    Friend WithEvents Btn_enregistrer As System.Windows.Forms.Button
    Friend WithEvents txt_idmvt As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_designation As System.Windows.Forms.TextBox
    Friend WithEvents Btn_numprod As System.Windows.Forms.Button
    Friend WithEvents Btn_numcli As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dtp_datemvt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbx_typemvt As System.Windows.Forms.ComboBox
    Friend WithEvents txt_numprod As System.Windows.Forms.TextBox
    Friend WithEvents txt_numcli As System.Windows.Forms.TextBox
    Friend WithEvents txt_monttva As System.Windows.Forms.TextBox
    Friend WithEvents txt_tva As System.Windows.Forms.TextBox
    Friend WithEvents txt_mont As System.Windows.Forms.TextBox
    Friend WithEvents txt_pu As System.Windows.Forms.TextBox
    Friend WithEvents txt_qte As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
