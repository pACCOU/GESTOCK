<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Menu
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.CLIENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnregistrementClieintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeDesClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRODUITSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnregistrementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeDesProduitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MOUVEMENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeDesMouvementsEffectuésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OUTILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnregisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SuppressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FERMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_d = New System.Windows.Forms.Label
        Me.lbl_h = New System.Windows.Forms.Label
        Me.Lb_heure = New System.Windows.Forms.Label
        Me.Lb_date = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.ConnectedUser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTSToolStripMenuItem, Me.PRODUITSToolStripMenuItem, Me.MOUVEMENTSToolStripMenuItem, Me.OUTILSToolStripMenuItem, Me.FERMERToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CLIENTSToolStripMenuItem
        '
        Me.CLIENTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrementClieintsToolStripMenuItem, Me.MoToolStripMenuItem, Me.ListeDesClientsToolStripMenuItem})
        Me.CLIENTSToolStripMenuItem.Name = "CLIENTSToolStripMenuItem"
        Me.CLIENTSToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CLIENTSToolStripMenuItem.Text = "CLIENTS"
        '
        'EnregistrementClieintsToolStripMenuItem
        '
        Me.EnregistrementClieintsToolStripMenuItem.Name = "EnregistrementClieintsToolStripMenuItem"
        Me.EnregistrementClieintsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EnregistrementClieintsToolStripMenuItem.Text = "Enregistrement "
        '
        'MoToolStripMenuItem
        '
        Me.MoToolStripMenuItem.Name = "MoToolStripMenuItem"
        Me.MoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MoToolStripMenuItem.Text = "Modification"
        '
        'ListeDesClientsToolStripMenuItem
        '
        Me.ListeDesClientsToolStripMenuItem.Name = "ListeDesClientsToolStripMenuItem"
        Me.ListeDesClientsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ListeDesClientsToolStripMenuItem.Text = "Liste des clients"
        '
        'PRODUITSToolStripMenuItem
        '
        Me.PRODUITSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrementToolStripMenuItem, Me.ModificationToolStripMenuItem, Me.ListeDesProduitsToolStripMenuItem})
        Me.PRODUITSToolStripMenuItem.Name = "PRODUITSToolStripMenuItem"
        Me.PRODUITSToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PRODUITSToolStripMenuItem.Text = "PRODUITS"
        '
        'EnregistrementToolStripMenuItem
        '
        Me.EnregistrementToolStripMenuItem.Name = "EnregistrementToolStripMenuItem"
        Me.EnregistrementToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EnregistrementToolStripMenuItem.Text = "Enregistrement"
        '
        'ModificationToolStripMenuItem
        '
        Me.ModificationToolStripMenuItem.Name = "ModificationToolStripMenuItem"
        Me.ModificationToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ModificationToolStripMenuItem.Text = "Modification"
        '
        'ListeDesProduitsToolStripMenuItem
        '
        Me.ListeDesProduitsToolStripMenuItem.Name = "ListeDesProduitsToolStripMenuItem"
        Me.ListeDesProduitsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ListeDesProduitsToolStripMenuItem.Text = "Liste des produits"
        '
        'MOUVEMENTSToolStripMenuItem
        '
        Me.MOUVEMENTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EToolStripMenuItem, Me.ListeDesMouvementsEffectuésToolStripMenuItem})
        Me.MOUVEMENTSToolStripMenuItem.Name = "MOUVEMENTSToolStripMenuItem"
        Me.MOUVEMENTSToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MOUVEMENTSToolStripMenuItem.Text = "OPERATIONS"
        '
        'EToolStripMenuItem
        '
        Me.EToolStripMenuItem.Name = "EToolStripMenuItem"
        Me.EToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.EToolStripMenuItem.Text = "Enregistrement Mouvements"
        '
        'ListeDesMouvementsEffectuésToolStripMenuItem
        '
        Me.ListeDesMouvementsEffectuésToolStripMenuItem.Name = "ListeDesMouvementsEffectuésToolStripMenuItem"
        Me.ListeDesMouvementsEffectuésToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ListeDesMouvementsEffectuésToolStripMenuItem.Text = "Liste des mouvements effectués"
        '
        'OUTILSToolStripMenuItem
        '
        Me.OUTILSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem, Me.UtilisateursToolStripMenuItem})
        Me.OUTILSToolStripMenuItem.Name = "OUTILSToolStripMenuItem"
        Me.OUTILSToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.OUTILSToolStripMenuItem.Text = "OUTILS"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AProposToolStripMenuItem.Text = "A Propos"
        '
        'UtilisateursToolStripMenuItem
        '
        Me.UtilisateursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregisToolStripMenuItem, Me.ModificationToolStripMenuItem1, Me.SuppressionToolStripMenuItem})
        Me.UtilisateursToolStripMenuItem.Name = "UtilisateursToolStripMenuItem"
        Me.UtilisateursToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.UtilisateursToolStripMenuItem.Text = "Utilisateurs"
        '
        'EnregisToolStripMenuItem
        '
        Me.EnregisToolStripMenuItem.Name = "EnregisToolStripMenuItem"
        Me.EnregisToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EnregisToolStripMenuItem.Text = "Enregistrement"
        '
        'ModificationToolStripMenuItem1
        '
        Me.ModificationToolStripMenuItem1.Name = "ModificationToolStripMenuItem1"
        Me.ModificationToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ModificationToolStripMenuItem1.Text = "Modification"
        '
        'SuppressionToolStripMenuItem
        '
        Me.SuppressionToolStripMenuItem.Name = "SuppressionToolStripMenuItem"
        Me.SuppressionToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SuppressionToolStripMenuItem.Text = "Suppression"
        '
        'FERMERToolStripMenuItem
        '
        Me.FERMERToolStripMenuItem.Name = "FERMERToolStripMenuItem"
        Me.FERMERToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.FERMERToolStripMenuItem.Text = "FERMER"
        '
        'lbl_d
        '
        Me.lbl_d.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_d.AutoSize = True
        Me.lbl_d.Location = New System.Drawing.Point(523, 41)
        Me.lbl_d.Name = "lbl_d"
        Me.lbl_d.Size = New System.Drawing.Size(0, 13)
        Me.lbl_d.TabIndex = 12
        '
        'lbl_h
        '
        Me.lbl_h.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_h.AutoSize = True
        Me.lbl_h.Location = New System.Drawing.Point(523, 18)
        Me.lbl_h.Name = "lbl_h"
        Me.lbl_h.Size = New System.Drawing.Size(0, 13)
        Me.lbl_h.TabIndex = 11
        '
        'Lb_heure
        '
        Me.Lb_heure.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_heure.AutoSize = True
        Me.Lb_heure.Location = New System.Drawing.Point(461, 18)
        Me.Lb_heure.Name = "Lb_heure"
        Me.Lb_heure.Size = New System.Drawing.Size(51, 13)
        Me.Lb_heure.TabIndex = 10
        Me.Lb_heure.Text = "HEURE :"
        '
        'Lb_date
        '
        Me.Lb_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_date.AutoSize = True
        Me.Lb_date.Location = New System.Drawing.Point(461, 41)
        Me.Lb_date.Name = "Lb_date"
        Me.Lb_date.Size = New System.Drawing.Size(42, 13)
        Me.Lb_date.TabIndex = 9
        Me.Lb_date.Text = "DATE :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ConnectedUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lb_heure)
        Me.Panel1.Controls.Add(Me.lbl_d)
        Me.Panel1.Controls.Add(Me.Lb_date)
        Me.Panel1.Controls.Add(Me.lbl_h)
        Me.Panel1.Location = New System.Drawing.Point(0, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 64)
        Me.Panel1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "B"
        '
        'ConnectedUser
        '
        Me.ConnectedUser.AutoSize = True
        Me.ConnectedUser.Location = New System.Drawing.Point(129, 26)
        Me.ConnectedUser.Name = "ConnectedUser"
        Me.ConnectedUser.Size = New System.Drawing.Size(14, 13)
        Me.ConnectedUser.TabIndex = 14
        Me.ConnectedUser.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "UTILISATEUR :"
        '
        'Timer1
        '
        '
        'Fr_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Fr_Menu"
        Me.Text = "Fr_Menu"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CLIENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrementClieintsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUITSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesProduitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOUVEMENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesMouvementsEffectuésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OUTILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FERMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_d As System.Windows.Forms.Label
    Friend WithEvents lbl_h As System.Windows.Forms.Label
    Friend WithEvents Lb_heure As System.Windows.Forms.Label
    Friend WithEvents Lb_date As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConnectedUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
