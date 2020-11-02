<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listeproduitparclient
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
        Me.TB_mvt = New System.Windows.Forms.DataGridView
        Me.lbl_listemvt = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btn_actualiser = New System.Windows.Forms.Button
        Me.btn_fermer = New System.Windows.Forms.Button
        Me.btn_supprimer = New System.Windows.Forms.Button
        Me.btn_nouveau = New System.Windows.Forms.Button
        CType(Me.TB_mvt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_mvt
        '
        Me.TB_mvt.AllowUserToAddRows = False
        Me.TB_mvt.AllowUserToDeleteRows = False
        Me.TB_mvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TB_mvt.Location = New System.Drawing.Point(129, 63)
        Me.TB_mvt.Name = "TB_mvt"
        Me.TB_mvt.ReadOnly = True
        Me.TB_mvt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TB_mvt.Size = New System.Drawing.Size(826, 339)
        Me.TB_mvt.TabIndex = 4
        '
        'lbl_listemvt
        '
        Me.lbl_listemvt.AutoSize = True
        Me.lbl_listemvt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_listemvt.Location = New System.Drawing.Point(435, 23)
        Me.lbl_listemvt.Name = "lbl_listemvt"
        Me.lbl_listemvt.Size = New System.Drawing.Size(199, 16)
        Me.lbl_listemvt.TabIndex = 3
        Me.lbl_listemvt.Text = "Liste des produits par client"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_actualiser)
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_nouveau)
        Me.Panel1.Location = New System.Drawing.Point(129, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 56)
        Me.Panel1.TabIndex = 5
        '
        'Btn_actualiser
        '
        Me.Btn_actualiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_actualiser.Location = New System.Drawing.Point(372, 17)
        Me.Btn_actualiser.Name = "Btn_actualiser"
        Me.Btn_actualiser.Size = New System.Drawing.Size(82, 23)
        Me.Btn_actualiser.TabIndex = 4
        Me.Btn_actualiser.Text = "Actualiser"
        Me.Btn_actualiser.UseVisualStyleBackColor = True
        Me.Btn_actualiser.Visible = False
        '
        'btn_fermer
        '
        Me.btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fermer.Location = New System.Drawing.Point(649, 20)
        Me.btn_fermer.Name = "btn_fermer"
        Me.btn_fermer.Size = New System.Drawing.Size(82, 23)
        Me.btn_fermer.TabIndex = 3
        Me.btn_fermer.Text = "Fermer"
        Me.btn_fermer.UseVisualStyleBackColor = True
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(24, 20)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(82, 23)
        Me.btn_supprimer.TabIndex = 2
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'btn_nouveau
        '
        Me.btn_nouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nouveau.Location = New System.Drawing.Point(24, 20)
        Me.btn_nouveau.Name = "btn_nouveau"
        Me.btn_nouveau.Size = New System.Drawing.Size(82, 23)
        Me.btn_nouveau.TabIndex = 0
        Me.btn_nouveau.Text = "Nouveau"
        Me.btn_nouveau.UseVisualStyleBackColor = True
        Me.btn_nouveau.Visible = False
        '
        'frm_listeproduitparclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1137, 542)
        Me.Controls.Add(Me.TB_mvt)
        Me.Controls.Add(Me.lbl_listemvt)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frm_listeproduitparclient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_listeproduitparclient"
        CType(Me.TB_mvt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_mvt As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_listemvt As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_supprimer As System.Windows.Forms.Button
    Friend WithEvents btn_nouveau As System.Windows.Forms.Button
    Friend WithEvents Btn_actualiser As System.Windows.Forms.Button
End Class
