<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CLIENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnregistrementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRODUITSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnregistrementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeProduitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OPERATIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeMouvementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.APROPOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AProposToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfilsUtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnreistrementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SuppressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AIDEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.ConnectedUser = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_d = New System.Windows.Forms.Label
        Me.lbl_h = New System.Windows.Forms.Label
        Me.Lb_heure = New System.Windows.Forms.Label
        Me.Lb_date = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.MenuStrip1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 33)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1056, 40)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTSToolStripMenuItem, Me.PRODUITSToolStripMenuItem, Me.OPERATIONSToolStripMenuItem, Me.APROPOSToolStripMenuItem, Me.AIDEToolStripMenuItem, Me.FermerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CLIENTSToolStripMenuItem
        '
        Me.CLIENTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrementsToolStripMenuItem, Me.ModificationToolStripMenuItem, Me.ListeClientsToolStripMenuItem})
        Me.CLIENTSToolStripMenuItem.Name = "CLIENTSToolStripMenuItem"
        Me.CLIENTSToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CLIENTSToolStripMenuItem.Text = "CLIENTS"
        '
        'EnregistrementsToolStripMenuItem
        '
        Me.EnregistrementsToolStripMenuItem.Name = "EnregistrementsToolStripMenuItem"
        Me.EnregistrementsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EnregistrementsToolStripMenuItem.Text = "Enregistrements"
        '
        'ModificationToolStripMenuItem
        '
        Me.ModificationToolStripMenuItem.Name = "ModificationToolStripMenuItem"
        Me.ModificationToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ModificationToolStripMenuItem.Text = "Modification"
        '
        'ListeClientsToolStripMenuItem
        '
        Me.ListeClientsToolStripMenuItem.Name = "ListeClientsToolStripMenuItem"
        Me.ListeClientsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ListeClientsToolStripMenuItem.Text = "Liste Clients"
        '
        'PRODUITSToolStripMenuItem
        '
        Me.PRODUITSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrementToolStripMenuItem, Me.ModificationsToolStripMenuItem, Me.ListeProduitsToolStripMenuItem})
        Me.PRODUITSToolStripMenuItem.Name = "PRODUITSToolStripMenuItem"
        Me.PRODUITSToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PRODUITSToolStripMenuItem.Text = "PRODUITS"
        '
        'EnregistrementToolStripMenuItem
        '
        Me.EnregistrementToolStripMenuItem.Name = "EnregistrementToolStripMenuItem"
        Me.EnregistrementToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EnregistrementToolStripMenuItem.Text = "Enregistrements"
        '
        'ModificationsToolStripMenuItem
        '
        Me.ModificationsToolStripMenuItem.Name = "ModificationsToolStripMenuItem"
        Me.ModificationsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ModificationsToolStripMenuItem.Text = "Modifications"
        '
        'ListeProduitsToolStripMenuItem
        '
        Me.ListeProduitsToolStripMenuItem.Name = "ListeProduitsToolStripMenuItem"
        Me.ListeProduitsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ListeProduitsToolStripMenuItem.Text = "Liste Produits"
        '
        'OPERATIONSToolStripMenuItem
        '
        Me.OPERATIONSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ListeMouvementsToolStripMenuItem})
        Me.OPERATIONSToolStripMenuItem.Name = "OPERATIONSToolStripMenuItem"
        Me.OPERATIONSToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.OPERATIONSToolStripMenuItem.Text = "OPERATIONS"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
        Me.ToolStripMenuItem1.Text = "Enregistrement mouvement"
        '
        'ListeMouvementsToolStripMenuItem
        '
        Me.ListeMouvementsToolStripMenuItem.Name = "ListeMouvementsToolStripMenuItem"
        Me.ListeMouvementsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ListeMouvementsToolStripMenuItem.Text = "Liste des produits par client"
        '
        'APROPOSToolStripMenuItem
        '
        Me.APROPOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AProposToolStripMenuItem1, Me.ProfilsUtilisateursToolStripMenuItem})
        Me.APROPOSToolStripMenuItem.Name = "APROPOSToolStripMenuItem"
        Me.APROPOSToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.APROPOSToolStripMenuItem.Text = "OUTILS"
        '
        'AProposToolStripMenuItem1
        '
        Me.AProposToolStripMenuItem1.Name = "AProposToolStripMenuItem1"
        Me.AProposToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.AProposToolStripMenuItem1.Text = "A propos"
        '
        'ProfilsUtilisateursToolStripMenuItem
        '
        Me.ProfilsUtilisateursToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnreistrementToolStripMenuItem, Me.ModificationToolStripMenuItem1, Me.SuppressionToolStripMenuItem})
        Me.ProfilsUtilisateursToolStripMenuItem.Name = "ProfilsUtilisateursToolStripMenuItem"
        Me.ProfilsUtilisateursToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ProfilsUtilisateursToolStripMenuItem.Text = "Profils Utilisateurs"
        '
        'EnreistrementToolStripMenuItem
        '
        Me.EnreistrementToolStripMenuItem.Name = "EnreistrementToolStripMenuItem"
        Me.EnreistrementToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EnreistrementToolStripMenuItem.Text = "Enreistrement"
        '
        'ModificationToolStripMenuItem1
        '
        Me.ModificationToolStripMenuItem1.Name = "ModificationToolStripMenuItem1"
        Me.ModificationToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ModificationToolStripMenuItem1.Text = "Modification"
        '
        'SuppressionToolStripMenuItem
        '
        Me.SuppressionToolStripMenuItem.Name = "SuppressionToolStripMenuItem"
        Me.SuppressionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuppressionToolStripMenuItem.Text = "Suppression"
        '
        'AIDEToolStripMenuItem
        '
        Me.AIDEToolStripMenuItem.Name = "AIDEToolStripMenuItem"
        Me.AIDEToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AIDEToolStripMenuItem.Text = "AIDE"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ConnectedUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_d)
        Me.Panel1.Controls.Add(Me.lbl_h)
        Me.Panel1.Controls.Add(Me.Lb_heure)
        Me.Panel1.Controls.Add(Me.Lb_date)
        Me.Panel1.Location = New System.Drawing.Point(1, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1056, 53)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "B"
        '
        'ConnectedUser
        '
        Me.ConnectedUser.AutoSize = True
        Me.ConnectedUser.Location = New System.Drawing.Point(143, 10)
        Me.ConnectedUser.Name = "ConnectedUser"
        Me.ConnectedUser.Size = New System.Drawing.Size(14, 13)
        Me.ConnectedUser.TabIndex = 6
        Me.ConnectedUser.Text = "A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "UTILISATEUR :"
        '
        'lbl_d
        '
        Me.lbl_d.AutoSize = True
        Me.lbl_d.Location = New System.Drawing.Point(819, 33)
        Me.lbl_d.Name = "lbl_d"
        Me.lbl_d.Size = New System.Drawing.Size(0, 13)
        Me.lbl_d.TabIndex = 4
        '
        'lbl_h
        '
        Me.lbl_h.AutoSize = True
        Me.lbl_h.Location = New System.Drawing.Point(819, 10)
        Me.lbl_h.Name = "lbl_h"
        Me.lbl_h.Size = New System.Drawing.Size(0, 13)
        Me.lbl_h.TabIndex = 3
        '
        'Lb_heure
        '
        Me.Lb_heure.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_heure.AutoSize = True
        Me.Lb_heure.Location = New System.Drawing.Point(757, 10)
        Me.Lb_heure.Name = "Lb_heure"
        Me.Lb_heure.Size = New System.Drawing.Size(51, 13)
        Me.Lb_heure.TabIndex = 2
        Me.Lb_heure.Text = "HEURE :"
        '
        'Lb_date
        '
        Me.Lb_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_date.AutoSize = True
        Me.Lb_date.Location = New System.Drawing.Point(757, 33)
        Me.Lb_date.Name = "Lb_date"
        Me.Lb_date.Size = New System.Drawing.Size(42, 13)
        Me.Lb_date.TabIndex = 1
        Me.Lb_date.Text = "DATE :"
        '
        'Timer1
        '
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 520)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_menu"
        Me.Text = "GESTOCK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CLIENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUITSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeProduitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPERATIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AIDEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APROPOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeMouvementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AProposToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfilsUtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnreistrementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ConnectedUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_d As System.Windows.Forms.Label
    Friend WithEvents lbl_h As System.Windows.Forms.Label
    Friend WithEvents Lb_heure As System.Windows.Forms.Label
    Friend WithEvents Lb_date As System.Windows.Forms.Label
End Class
