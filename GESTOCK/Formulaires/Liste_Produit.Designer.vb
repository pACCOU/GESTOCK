<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Produit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_fermer = New System.Windows.Forms.Button
        Me.btn_supprimer = New System.Windows.Forms.Button
        Me.btn_nouveau = New System.Windows.Forms.Button
        Me.TB_produit = New System.Windows.Forms.DataGridView
        Me.Lbl_listeproduit = New System.Windows.Forms.Label
        Me.Btn_recherche = New System.Windows.Forms.Button
        Me.Text_recherche = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.TB_produit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_nouveau)
        Me.Panel1.Location = New System.Drawing.Point(43, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 56)
        Me.Panel1.TabIndex = 3
        '
        'btn_fermer
        '
        Me.btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fermer.Location = New System.Drawing.Point(382, 18)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(82, 23)
        Me.btn_fermer.TabIndex = 3
        Me.btn_fermer.Text = "Fermer"
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(22, 18)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(82, 23)
        Me.btn_supprimer.TabIndex = 2
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'btn_nouveau
        '
        Me.btn_nouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nouveau.Location = New System.Drawing.Point(22, 18)
        Me.btn_nouveau.Name = "btn_nouveau"
        Me.btn_nouveau.Size = New System.Drawing.Size(82, 23)
        Me.btn_nouveau.TabIndex = 0
        Me.btn_nouveau.Text = "Nouveau"
        Me.btn_nouveau.UseVisualStyleBackColor = True
        Me.btn_nouveau.Visible = False
        '
        'TB_produit
        '
        Me.TB_produit.AllowUserToAddRows = False
        Me.TB_produit.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TB_produit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TB_produit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TB_produit.DefaultCellStyle = DataGridViewCellStyle2
        Me.TB_produit.Location = New System.Drawing.Point(43, 67)
        Me.TB_produit.Name = "TB_produit"
        Me.TB_produit.ReadOnly = True
        Me.TB_produit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TB_produit.Size = New System.Drawing.Size(489, 270)
        Me.TB_produit.TabIndex = 4
        '
        'Lbl_listeproduit
        '
        Me.Lbl_listeproduit.AutoSize = True
        Me.Lbl_listeproduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_listeproduit.Location = New System.Drawing.Point(209, 27)
        Me.Lbl_listeproduit.Name = "Lbl_listeproduit"
        Me.Lbl_listeproduit.Size = New System.Drawing.Size(122, 15)
        Me.Lbl_listeproduit.TabIndex = 5
        Me.Lbl_listeproduit.Text = "Liste des Produits"
        '
        'Btn_recherche
        '
        Me.Btn_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_recherche.Location = New System.Drawing.Point(423, 369)
        Me.Btn_recherche.Name = "Btn_recherche"
        Me.Btn_recherche.Size = New System.Drawing.Size(105, 23)
        Me.Btn_recherche.TabIndex = 11
        Me.Btn_recherche.Text = "Rechercher"
        Me.Btn_recherche.UseVisualStyleBackColor = True
        '
        'Text_recherche
        '
        Me.Text_recherche.Location = New System.Drawing.Point(254, 369)
        Me.Text_recherche.Name = "Text_recherche"
        Me.Text_recherche.Size = New System.Drawing.Size(149, 20)
        Me.Text_recherche.TabIndex = 10
        '
        'Liste_Produit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(619, 523)
        Me.Controls.Add(Me.Btn_recherche)
        Me.Controls.Add(Me.Text_recherche)
        Me.Controls.Add(Me.Lbl_listeproduit)
        Me.Controls.Add(Me.TB_produit)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Liste_Produit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste_Produit"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TB_produit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_supprimer As System.Windows.Forms.Button
    Friend WithEvents btn_nouveau As System.Windows.Forms.Button
    Friend WithEvents TB_produit As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_listeproduit As System.Windows.Forms.Label
    Friend WithEvents Btn_recherche As System.Windows.Forms.Button
    Friend WithEvents Text_recherche As System.Windows.Forms.TextBox
End Class
