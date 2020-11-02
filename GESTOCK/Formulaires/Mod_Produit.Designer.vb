<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_modProduit
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
        Me.btn_produit = New System.Windows.Forms.Button
        Me.txt_prixunit = New System.Windows.Forms.TextBox
        Me.txt_designation = New System.Windows.Forms.TextBox
        Me.txt_numprod = New System.Windows.Forms.TextBox
        Me.lbl_pu = New System.Windows.Forms.Label
        Me.lbl_designation = New System.Windows.Forms.Label
        Me.lbl_numprod = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Location = New System.Drawing.Point(595, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 118)
        Me.Panel1.TabIndex = 13
        '
        'btn_fermer
        '
        Me.btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fermer.Location = New System.Drawing.Point(29, 61)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(89, 34)
        Me.btn_fermer.TabIndex = 1
        Me.btn_fermer.Text = "Fermer"
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.Location = New System.Drawing.Point(29, 17)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(89, 32)
        Me.btn_modifier.TabIndex = 0
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_produit
        '
        Me.btn_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produit.Location = New System.Drawing.Point(299, 102)
        Me.btn_produit.Name = "btn_produit"
        Me.btn_produit.Size = New System.Drawing.Size(31, 23)
        Me.btn_produit.TabIndex = 3
        Me.btn_produit.Text = "v"
        Me.btn_produit.UseVisualStyleBackColor = True
        '
        'txt_prixunit
        '
        Me.txt_prixunit.Location = New System.Drawing.Point(193, 159)
        Me.txt_prixunit.Name = "txt_prixunit"
        Me.txt_prixunit.Size = New System.Drawing.Size(100, 20)
        Me.txt_prixunit.TabIndex = 12
        '
        'txt_designation
        '
        Me.txt_designation.Location = New System.Drawing.Point(193, 131)
        Me.txt_designation.Name = "txt_designation"
        Me.txt_designation.Size = New System.Drawing.Size(250, 20)
        Me.txt_designation.TabIndex = 11
        '
        'txt_numprod
        '
        Me.txt_numprod.Location = New System.Drawing.Point(193, 104)
        Me.txt_numprod.Name = "txt_numprod"
        Me.txt_numprod.Size = New System.Drawing.Size(100, 20)
        Me.txt_numprod.TabIndex = 10
        '
        'lbl_pu
        '
        Me.lbl_pu.AutoSize = True
        Me.lbl_pu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pu.Location = New System.Drawing.Point(71, 159)
        Me.lbl_pu.Name = "lbl_pu"
        Me.lbl_pu.Size = New System.Drawing.Size(79, 16)
        Me.lbl_pu.TabIndex = 9
        Me.lbl_pu.Text = "Prix Unitaire"
        '
        'lbl_designation
        '
        Me.lbl_designation.AutoSize = True
        Me.lbl_designation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_designation.Location = New System.Drawing.Point(71, 131)
        Me.lbl_designation.Name = "lbl_designation"
        Me.lbl_designation.Size = New System.Drawing.Size(80, 16)
        Me.lbl_designation.TabIndex = 8
        Me.lbl_designation.Text = "Désignation"
        '
        'lbl_numprod
        '
        Me.lbl_numprod.AutoSize = True
        Me.lbl_numprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numprod.Location = New System.Drawing.Point(71, 104)
        Me.lbl_numprod.Name = "lbl_numprod"
        Me.lbl_numprod.Size = New System.Drawing.Size(101, 16)
        Me.lbl_numprod.TabIndex = 7
        Me.lbl_numprod.Text = "Numéro Produit"
        '
        'Frm_modProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(789, 297)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_prixunit)
        Me.Controls.Add(Me.btn_produit)
        Me.Controls.Add(Me.txt_designation)
        Me.Controls.Add(Me.txt_numprod)
        Me.Controls.Add(Me.lbl_pu)
        Me.Controls.Add(Me.lbl_designation)
        Me.Controls.Add(Me.lbl_numprod)
        Me.MaximizeBox = False
        Me.Name = "Frm_modProduit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mod_Produit"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_produit As System.Windows.Forms.Button
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_modifier As System.Windows.Forms.Button
    Friend WithEvents txt_prixunit As System.Windows.Forms.TextBox
    Friend WithEvents txt_designation As System.Windows.Forms.TextBox
    Friend WithEvents txt_numprod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pu As System.Windows.Forms.Label
    Friend WithEvents lbl_designation As System.Windows.Forms.Label
    Friend WithEvents lbl_numprod As System.Windows.Forms.Label
End Class
