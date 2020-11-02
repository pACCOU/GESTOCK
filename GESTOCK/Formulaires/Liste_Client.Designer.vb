<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Client
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TB_client = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_fermer = New System.Windows.Forms.Button
        Me.btn_supprimer = New System.Windows.Forms.Button
        Me.btn_nouveau = New System.Windows.Forms.Button
        Me.Btn_recherche = New System.Windows.Forms.Button
        Me.Text_recherche = New System.Windows.Forms.TextBox
        CType(Me.TB_client, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Liste de Clients"
        '
        'TB_client
        '
        Me.TB_client.AllowUserToAddRows = False
        Me.TB_client.AllowUserToDeleteRows = False
        Me.TB_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TB_client.Location = New System.Drawing.Point(50, 40)
        Me.TB_client.Name = "TB_client"
        Me.TB_client.ReadOnly = True
        Me.TB_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TB_client.Size = New System.Drawing.Size(826, 339)
        Me.TB_client.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_fermer)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_nouveau)
        Me.Panel1.Location = New System.Drawing.Point(50, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 56)
        Me.Panel1.TabIndex = 2
        '
        'btn_fermer
        '
        Me.btn_fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fermer.Location = New System.Drawing.Point(715, 18)
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
        'Btn_recherche
        '
        Me.Btn_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_recherche.Location = New System.Drawing.Point(447, 409)
        Me.Btn_recherche.Name = "Btn_recherche"
        Me.Btn_recherche.Size = New System.Drawing.Size(105, 23)
        Me.Btn_recherche.TabIndex = 9
        Me.Btn_recherche.Text = "Rechercher"
        Me.Btn_recherche.UseVisualStyleBackColor = True
        '
        'Text_recherche
        '
        Me.Text_recherche.Location = New System.Drawing.Point(278, 409)
        Me.Text_recherche.Name = "Text_recherche"
        Me.Text_recherche.Size = New System.Drawing.Size(149, 20)
        Me.Text_recherche.TabIndex = 8
        '
        'Liste_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(951, 525)
        Me.Controls.Add(Me.Btn_recherche)
        Me.Controls.Add(Me.Text_recherche)
        Me.Controls.Add(Me.TB_client)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Liste_Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste_Client"
        CType(Me.TB_client, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_client As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_fermer As System.Windows.Forms.Button
    Friend WithEvents btn_supprimer As System.Windows.Forms.Button
    Friend WithEvents btn_nouveau As System.Windows.Forms.Button
    Friend WithEvents Btn_recherche As System.Windows.Forms.Button
    Friend WithEvents Text_recherche As System.Windows.Forms.TextBox
End Class
