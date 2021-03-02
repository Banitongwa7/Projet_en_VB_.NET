<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnhistoriquecommandeclient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnhistoriquecommandeclient))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuPictureBox4 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.DGVCO = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.IDClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVoiture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatCommande = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantiteCommande = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCommande = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(357, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Historique des Commandes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("High Tower Text", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(133, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Location Voiture"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(70, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Société MB"
        '
        'BunifuPictureBox4
        '
        Me.BunifuPictureBox4.AllowFocused = False
        Me.BunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox4.AutoSizeHeight = True
        Me.BunifuPictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuPictureBox4.BorderRadius = 21
        Me.BunifuPictureBox4.Image = CType(resources.GetObject("BunifuPictureBox4.Image"), System.Drawing.Image)
        Me.BunifuPictureBox4.IsCircle = True
        Me.BunifuPictureBox4.Location = New System.Drawing.Point(165, 4)
        Me.BunifuPictureBox4.Name = "BunifuPictureBox4"
        Me.BunifuPictureBox4.Size = New System.Drawing.Size(42, 42)
        Me.BunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox4.TabIndex = 17
        Me.BunifuPictureBox4.TabStop = False
        Me.BunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'DGVCO
        '
        Me.DGVCO.AllowCustomTheming = False
        Me.DGVCO.AllowUserToDeleteRows = False
        Me.DGVCO.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGVCO.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCO.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGVCO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGVCO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCO.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVCO.ColumnHeadersHeight = 40
        Me.DGVCO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClient, Me.IDVoiture, Me.EtatCommande, Me.QuantiteCommande, Me.DateCommande})
        Me.DGVCO.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGVCO.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVCO.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVCO.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DGVCO.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVCO.CurrentTheme.BackColor = System.Drawing.Color.Teal
        Me.DGVCO.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVCO.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.DGVCO.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DGVCO.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVCO.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DGVCO.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVCO.CurrentTheme.Name = Nothing
        Me.DGVCO.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGVCO.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVCO.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVCO.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DGVCO.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCO.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVCO.EnableHeadersVisualStyles = False
        Me.DGVCO.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVCO.HeaderBackColor = System.Drawing.Color.Teal
        Me.DGVCO.HeaderBgColor = System.Drawing.Color.Empty
        Me.DGVCO.HeaderForeColor = System.Drawing.Color.White
        Me.DGVCO.Location = New System.Drawing.Point(12, 108)
        Me.DGVCO.Name = "DGVCO"
        Me.DGVCO.ReadOnly = True
        Me.DGVCO.RowHeadersVisible = False
        Me.DGVCO.RowTemplate.Height = 40
        Me.DGVCO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCO.Size = New System.Drawing.Size(960, 409)
        Me.DGVCO.TabIndex = 18
        Me.DGVCO.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal
        '
        'IDClient
        '
        Me.IDClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDClient.HeaderText = "ID Client"
        Me.IDClient.Name = "IDClient"
        Me.IDClient.ReadOnly = True
        '
        'IDVoiture
        '
        Me.IDVoiture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDVoiture.HeaderText = "ID Voiture"
        Me.IDVoiture.Name = "IDVoiture"
        Me.IDVoiture.ReadOnly = True
        '
        'EtatCommande
        '
        Me.EtatCommande.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EtatCommande.HeaderText = "Etat de la commande"
        Me.EtatCommande.Name = "EtatCommande"
        Me.EtatCommande.ReadOnly = True
        '
        'QuantiteCommande
        '
        Me.QuantiteCommande.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuantiteCommande.HeaderText = "Quantite"
        Me.QuantiteCommande.Name = "QuantiteCommande"
        Me.QuantiteCommande.ReadOnly = True
        '
        'DateCommande
        '
        Me.DateCommande.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateCommande.HeaderText = "Date de la commande"
        Me.DateCommande.Name = "DateCommande"
        Me.DateCommande.ReadOnly = True
        '
        'frnhistoriquecommandeclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 529)
        Me.Controls.Add(Me.DGVCO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BunifuPictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frnhistoriquecommandeclient"
        Me.Text = "Historique_commande_client"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuPictureBox4 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents DGVCO As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents IDClient As DataGridViewTextBoxColumn
    Friend WithEvents IDVoiture As DataGridViewTextBoxColumn
    Friend WithEvents EtatCommande As DataGridViewTextBoxColumn
    Friend WithEvents QuantiteCommande As DataGridViewTextBoxColumn
    Friend WithEvents DateCommande As DataGridViewTextBoxColumn
End Class
