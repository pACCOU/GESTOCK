<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppression
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
        Me.gb_utilisateur = New System.Windows.Forms.GroupBox
        Me.Dat1 = New System.Windows.Forms.DataGridView
        Me.Btn_supprimer = New System.Windows.Forms.Button
        Me.Btn_fermer = New System.Windows.Forms.Button
        Me.gb_utilisateur.SuspendLayout()
        CType(Me.Dat1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(267, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suppression d'un Utilisateur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gb_utilisateur
        '
        Me.gb_utilisateur.Controls.Add(Me.Dat1)
        Me.gb_utilisateur.Location = New System.Drawing.Point(23, 59)
        Me.gb_utilisateur.Name = "gb_utilisateur"
        Me.gb_utilisateur.Size = New System.Drawing.Size(719, 256)
        Me.gb_utilisateur.TabIndex = 1
        Me.gb_utilisateur.TabStop = False
        Me.gb_utilisateur.Text = "Utilisateur"
        '
        'Dat1
        '
        Me.Dat1.AllowUserToAddRows = False
        Me.Dat1.AllowUserToDeleteRows = False
        Me.Dat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dat1.Location = New System.Drawing.Point(6, 19)
        Me.Dat1.Name = "Dat1"
        Me.Dat1.ReadOnly = True
        Me.Dat1.Size = New System.Drawing.Size(707, 231)
        Me.Dat1.TabIndex = 0
        '
        'Btn_supprimer
        '
        Me.Btn_supprimer.Location = New System.Drawing.Point(766, 131)
        Me.Btn_supprimer.Name = "Btn_supprimer"
        Me.Btn_supprimer.Size = New System.Drawing.Size(75, 23)
        Me.Btn_supprimer.TabIndex = 2
        Me.Btn_supprimer.Text = "Supprimer"
        Me.Btn_supprimer.UseVisualStyleBackColor = True
        '
        'Btn_fermer
        '
        Me.Btn_fermer.Location = New System.Drawing.Point(766, 170)
        Me.Btn_fermer.Name = "Btn_fermer"
        Me.Btn_fermer.Size = New System.Drawing.Size(75, 23)
        Me.Btn_fermer.TabIndex = 3
        Me.Btn_fermer.Text = "Fermer"
        Me.Btn_fermer.UseVisualStyleBackColor = True
        '
        'Suppression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 327)
        Me.Controls.Add(Me.Btn_fermer)
        Me.Controls.Add(Me.Btn_supprimer)
        Me.Controls.Add(Me.gb_utilisateur)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Suppression"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suppression"
        Me.gb_utilisateur.ResumeLayout(False)
        CType(Me.Dat1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_utilisateur As System.Windows.Forms.GroupBox
    Friend WithEvents Dat1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_supprimer As System.Windows.Forms.Button
    Friend WithEvents Btn_fermer As System.Windows.Forms.Button
End Class
