<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_EngProduit
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
        Me.lbl_numprod = New System.Windows.Forms.Label
        Me.lbl_designation = New System.Windows.Forms.Label
        Me.lbl_pu = New System.Windows.Forms.Label
        Me.txt_numprod = New System.Windows.Forms.TextBox
        Me.txt_designation = New System.Windows.Forms.TextBox
        Me.txt_prixunit = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_fermer = New System.Windows.Forms.Button
        Me.btn_enregistrer = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_numprod
        '
        Me.lbl_numprod.AutoSize = True
        Me.lbl_numprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numprod.Location = New System.Drawing.Point(77, 107)
        Me.lbl_numprod.Name = "lbl_numprod"
        Me.lbl_numprod.Size = New System.Drawing.Size(92, 16)
        Me.lbl_numprod.TabIndex = 0
        Me.lbl_numprod.Text = "Numéro_Prod"
        '
        'lbl_designation
        '
        Me.lbl_designation.AutoSize = True
        Me.lbl_designation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_designation.Location = New System.Drawing.Point(77, 134)
        Me.lbl_designation.Name = "lbl_designation"
        Me.lbl_designation.Size = New System.Drawing.Size(80, 16)
        Me.lbl_designation.TabIndex = 1
        Me.lbl_designation.Text = "Désignation"
        '
        'lbl_pu
        '
        Me.lbl_pu.AutoSize = True
        Me.lbl_pu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pu.Location = New System.Drawing.Point(77, 162)
        Me.lbl_pu.Name = "lbl_pu"
        Me.lbl_pu.Size = New System.Drawing.Size(79, 16)
        Me.lbl_pu.TabIndex = 2
        Me.lbl_pu.Text = "Prix Unitaire"
        '
        'txt_numprod
        '
        Me.txt_numprod.Location = New System.Drawing.Point(199, 107)
        Me.txt_numprod.Name = "txt_numprod"
        Me.txt_numprod.Size = New System.Drawing.Size(100, 20)
        Me.txt_numprod.TabIndex = 3
        '
        'txt_designation
        '
        Me.txt_designation.Location = New System.Drawing.Point(199, 134)
        Me.txt_designation.Name = "txt_designation"
        Me.txt_designation.Size = New System.Drawing.Size(250, 20)
        Me.txt_designation.TabIndex = 4
        '
        'txt_prixunit
        '
        Me.txt_prixunit.Location = New System.Drawing.Point(199, 162)
        Me.txt_prixunit.Name = "txt_prixunit"
        Me.txt_prixunit.Size = New System.Drawing.Size(100, 20)
        Me.txt_prixunit.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_enregistrer)
        Me.Panel1.Location = New System.Drawing.Point(587, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(137, 90)
        Me.Panel1.TabIndex = 6
        '
        'btn_fermer
        '
        Me.btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fermer.Location = New System.Drawing.Point(30, 52)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(79, 23)
        Me.btn_fermer.TabIndex = 1
        Me.btn_fermer.Text = "Fermer"
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enregistrer.Location = New System.Drawing.Point(30, 11)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(89, 23)
        Me.btn_enregistrer.TabIndex = 0
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'Frm_EngProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(816, 294)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_prixunit)
        Me.Controls.Add(Me.txt_designation)
        Me.Controls.Add(Me.txt_numprod)
        Me.Controls.Add(Me.lbl_pu)
        Me.Controls.Add(Me.lbl_designation)
        Me.Controls.Add(Me.lbl_numprod)
        Me.MaximizeBox = False
        Me.Name = "Frm_EngProduit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eng_Produit"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_numprod As System.Windows.Forms.Label
    Friend WithEvents lbl_designation As System.Windows.Forms.Label
    Friend WithEvents lbl_pu As System.Windows.Forms.Label
    Friend WithEvents txt_numprod As System.Windows.Forms.TextBox
    Friend WithEvents txt_designation As System.Windows.Forms.TextBox
    Friend WithEvents txt_prixunit As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_enregistrer As System.Windows.Forms.Button
End Class
