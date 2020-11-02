<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facture_d_une_période
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
        Me.btn_afficher = New System.Windows.Forms.Button
        Me.cmb_datemvt = New System.Windows.Forms.ComboBox
        Me.lbl_datemvt = New System.Windows.Forms.Label
        Me.cmb_numcli = New System.Windows.Forms.ComboBox
        Me.lbl_numcli = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_afficher
        '
        Me.btn_afficher.Location = New System.Drawing.Point(449, 146)
        Me.btn_afficher.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_afficher.Name = "btn_afficher"
        Me.btn_afficher.Size = New System.Drawing.Size(100, 28)
        Me.btn_afficher.TabIndex = 9
        Me.btn_afficher.Text = "Afficher"
        Me.btn_afficher.UseVisualStyleBackColor = True
        '
        'cmb_datemvt
        '
        Me.cmb_datemvt.FormattingEnabled = True
        Me.cmb_datemvt.Items.AddRange(New Object() {"Cadet", "Junior"})
        Me.cmb_datemvt.Location = New System.Drawing.Point(375, 93)
        Me.cmb_datemvt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_datemvt.Name = "cmb_datemvt"
        Me.cmb_datemvt.Size = New System.Drawing.Size(173, 21)
        Me.cmb_datemvt.TabIndex = 8
        '
        'lbl_datemvt
        '
        Me.lbl_datemvt.AutoSize = True
        Me.lbl_datemvt.Location = New System.Drawing.Point(331, 96)
        Me.lbl_datemvt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_datemvt.Name = "lbl_datemvt"
        Me.lbl_datemvt.Size = New System.Drawing.Size(36, 13)
        Me.lbl_datemvt.TabIndex = 7
        Me.lbl_datemvt.Text = "Date :"
        '
        'cmb_numcli
        '
        Me.cmb_numcli.FormattingEnabled = True
        Me.cmb_numcli.Items.AddRange(New Object() {"Cadet", "Junior"})
        Me.cmb_numcli.Location = New System.Drawing.Point(127, 93)
        Me.cmb_numcli.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_numcli.Name = "cmb_numcli"
        Me.cmb_numcli.Size = New System.Drawing.Size(160, 21)
        Me.cmb_numcli.TabIndex = 6
        '
        'lbl_numcli
        '
        Me.lbl_numcli.AutoSize = True
        Me.lbl_numcli.Location = New System.Drawing.Point(26, 96)
        Me.lbl_numcli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_numcli.Name = "lbl_numcli"
        Me.lbl_numcli.Size = New System.Drawing.Size(93, 13)
        Me.lbl_numcli.TabIndex = 5
        Me.lbl_numcli.Text = "Numéro du client :"
        '
        'Facture_d_une_période
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(590, 266)
        Me.Controls.Add(Me.btn_afficher)
        Me.Controls.Add(Me.cmb_datemvt)
        Me.Controls.Add(Me.lbl_datemvt)
        Me.Controls.Add(Me.cmb_numcli)
        Me.Controls.Add(Me.lbl_numcli)
        Me.MaximizeBox = False
        Me.Name = "Facture_d_une_période"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facture_d_une_période"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_afficher As System.Windows.Forms.Button
    Friend WithEvents cmb_datemvt As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_datemvt As System.Windows.Forms.Label
    Friend WithEvents cmb_numcli As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_numcli As System.Windows.Forms.Label
End Class
