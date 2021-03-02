<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnclient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnclient))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblclient1 = New System.Windows.Forms.Label()
        Me.pctbox1 = New System.Windows.Forms.PictureBox()
        Me.pctbox2 = New System.Windows.Forms.PictureBox()
        Me.pctbox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVClient = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Marque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prixdelocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vitesse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etatdedisponibilite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtquantiteclient = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtrechercheclient = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuPictureBox4 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblclient1)
        Me.Panel1.Controls.Add(Me.pctbox1)
        Me.Panel1.Controls.Add(Me.pctbox2)
        Me.Panel1.Controls.Add(Me.pctbox3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-19, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 569)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(66, 368)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(61, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 424)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Historique des commandes"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(54, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "__________________"
        '
        'lblclient1
        '
        Me.lblclient1.BackColor = System.Drawing.Color.White
        Me.lblclient1.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclient1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblclient1.Location = New System.Drawing.Point(18, 111)
        Me.lblclient1.Name = "lblclient1"
        Me.lblclient1.Size = New System.Drawing.Size(180, 23)
        Me.lblclient1.TabIndex = 11
        Me.lblclient1.Text = "Client"
        Me.lblclient1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctbox1
        '
        Me.pctbox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pctbox1.Image = CType(resources.GetObject("pctbox1.Image"), System.Drawing.Image)
        Me.pctbox1.Location = New System.Drawing.Point(69, 163)
        Me.pctbox1.Name = "pctbox1"
        Me.pctbox1.Size = New System.Drawing.Size(61, 42)
        Me.pctbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbox1.TabIndex = 11
        Me.pctbox1.TabStop = False
        '
        'pctbox2
        '
        Me.pctbox2.Image = CType(resources.GetObject("pctbox2.Image"), System.Drawing.Image)
        Me.pctbox2.Location = New System.Drawing.Point(66, 265)
        Me.pctbox2.Name = "pctbox2"
        Me.pctbox2.Size = New System.Drawing.Size(61, 48)
        Me.pctbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbox2.TabIndex = 11
        Me.pctbox2.TabStop = False
        '
        'pctbox3
        '
        Me.pctbox3.Image = CType(resources.GetObject("pctbox3.Image"), System.Drawing.Image)
        Me.pctbox3.Location = New System.Drawing.Point(66, 473)
        Me.pctbox3.Name = "pctbox3"
        Me.pctbox3.Size = New System.Drawing.Size(61, 46)
        Me.pctbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbox3.TabIndex = 11
        Me.pctbox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(54, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "__________________"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "__________________"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 522)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Deconnexion"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Voiture Disponible"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lister les Voitures"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.DGVClient)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtquantiteclient)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(185, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(969, 505)
        Me.Panel3.TabIndex = 1
        '
        'DGVClient
        '
        Me.DGVClient.AllowCustomTheming = False
        Me.DGVClient.AllowUserToDeleteRows = False
        Me.DGVClient.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGVClient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClient.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DGVClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGVClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVClient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVClient.ColumnHeadersHeight = 40
        Me.DGVClient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marque, Me.Prixdelocation, Me.Vitesse, Me.Etatdedisponibilite, Me.Description, Me.Quantite})
        Me.DGVClient.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DGVClient.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVClient.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVClient.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DGVClient.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVClient.CurrentTheme.BackColor = System.Drawing.Color.Teal
        Me.DGVClient.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVClient.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.DGVClient.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DGVClient.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVClient.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DGVClient.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVClient.CurrentTheme.Name = Nothing
        Me.DGVClient.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DGVClient.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVClient.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVClient.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DGVClient.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVClient.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVClient.EnableHeadersVisualStyles = False
        Me.DGVClient.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DGVClient.HeaderBackColor = System.Drawing.Color.Teal
        Me.DGVClient.HeaderBgColor = System.Drawing.Color.Empty
        Me.DGVClient.HeaderForeColor = System.Drawing.Color.White
        Me.DGVClient.Location = New System.Drawing.Point(4, 41)
        Me.DGVClient.Name = "DGVClient"
        Me.DGVClient.ReadOnly = True
        Me.DGVClient.RowHeadersVisible = False
        Me.DGVClient.RowTemplate.Height = 40
        Me.DGVClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClient.Size = New System.Drawing.Size(960, 454)
        Me.DGVClient.TabIndex = 17
        Me.DGVClient.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal
        '
        'Marque
        '
        Me.Marque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Marque.HeaderText = "Marque"
        Me.Marque.Name = "Marque"
        Me.Marque.ReadOnly = True
        '
        'Prixdelocation
        '
        Me.Prixdelocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Prixdelocation.HeaderText = "Prix de location ($)"
        Me.Prixdelocation.Name = "Prixdelocation"
        Me.Prixdelocation.ReadOnly = True
        '
        'Vitesse
        '
        Me.Vitesse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Vitesse.HeaderText = "Vitesse (Km/h)"
        Me.Vitesse.Name = "Vitesse"
        Me.Vitesse.ReadOnly = True
        '
        'Etatdedisponibilite
        '
        Me.Etatdedisponibilite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Etatdedisponibilite.HeaderText = "Etat de disponibilité"
        Me.Etatdedisponibilite.Name = "Etatdedisponibilite"
        Me.Etatdedisponibilite.ReadOnly = True
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Quantite
        '
        Me.Quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quantite.HeaderText = "Quantite en stock"
        Me.Quantite.Name = "Quantite"
        Me.Quantite.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("High Tower Text", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(66, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Location Voiture"
        '
        'txtquantiteclient
        '
        Me.txtquantiteclient.AcceptsReturn = False
        Me.txtquantiteclient.AcceptsTab = False
        Me.txtquantiteclient.AnimationSpeed = 200
        Me.txtquantiteclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtquantiteclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtquantiteclient.BackColor = System.Drawing.Color.White
        Me.txtquantiteclient.BackgroundImage = CType(resources.GetObject("txtquantiteclient.BackgroundImage"), System.Drawing.Image)
        Me.txtquantiteclient.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtquantiteclient.BorderColorDisabled = System.Drawing.Color.White
        Me.txtquantiteclient.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtquantiteclient.BorderColorIdle = System.Drawing.Color.DarkSlateGray
        Me.txtquantiteclient.BorderRadius = 20
        Me.txtquantiteclient.BorderThickness = 1
        Me.txtquantiteclient.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtquantiteclient.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtquantiteclient.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtquantiteclient.DefaultText = ""
        Me.txtquantiteclient.FillColor = System.Drawing.Color.White
        Me.txtquantiteclient.HideSelection = True
        Me.txtquantiteclient.IconLeft = Nothing
        Me.txtquantiteclient.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtquantiteclient.IconPadding = 10
        Me.txtquantiteclient.IconRight = Nothing
        Me.txtquantiteclient.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtquantiteclient.Lines = New String(-1) {}
        Me.txtquantiteclient.Location = New System.Drawing.Point(784, 11)
        Me.txtquantiteclient.MaxLength = 32767
        Me.txtquantiteclient.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtquantiteclient.Modified = False
        Me.txtquantiteclient.Multiline = False
        Me.txtquantiteclient.Name = "txtquantiteclient"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtquantiteclient.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.White
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtquantiteclient.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtquantiteclient.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.DarkSlateGray
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtquantiteclient.OnIdleState = StateProperties4
        Me.txtquantiteclient.Padding = New System.Windows.Forms.Padding(3)
        Me.txtquantiteclient.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtquantiteclient.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtquantiteclient.PlaceholderText = "Quantite"
        Me.txtquantiteclient.ReadOnly = False
        Me.txtquantiteclient.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtquantiteclient.SelectedText = ""
        Me.txtquantiteclient.SelectionLength = 0
        Me.txtquantiteclient.SelectionStart = 0
        Me.txtquantiteclient.ShortcutsEnabled = True
        Me.txtquantiteclient.Size = New System.Drawing.Size(97, 24)
        Me.txtquantiteclient.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtquantiteclient.TabIndex = 12
        Me.txtquantiteclient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtquantiteclient.TextMarginBottom = 0
        Me.txtquantiteclient.TextMarginLeft = 3
        Me.txtquantiteclient.TextMarginTop = 0
        Me.txtquantiteclient.TextPlaceholder = "Quantite"
        Me.txtquantiteclient.UseSystemPasswordChar = False
        Me.txtquantiteclient.WordWrap = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(887, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Louer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1127, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'txtrechercheclient
        '
        Me.txtrechercheclient.AcceptsReturn = False
        Me.txtrechercheclient.AcceptsTab = False
        Me.txtrechercheclient.AnimationSpeed = 200
        Me.txtrechercheclient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtrechercheclient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtrechercheclient.BackColor = System.Drawing.Color.White
        Me.txtrechercheclient.BackgroundImage = CType(resources.GetObject("txtrechercheclient.BackgroundImage"), System.Drawing.Image)
        Me.txtrechercheclient.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtrechercheclient.BorderColorDisabled = System.Drawing.Color.White
        Me.txtrechercheclient.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrechercheclient.BorderColorIdle = System.Drawing.Color.DarkSlateGray
        Me.txtrechercheclient.BorderRadius = 20
        Me.txtrechercheclient.BorderThickness = 1
        Me.txtrechercheclient.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtrechercheclient.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrechercheclient.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtrechercheclient.DefaultText = ""
        Me.txtrechercheclient.FillColor = System.Drawing.Color.White
        Me.txtrechercheclient.HideSelection = True
        Me.txtrechercheclient.IconLeft = Nothing
        Me.txtrechercheclient.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrechercheclient.IconPadding = 10
        Me.txtrechercheclient.IconRight = Nothing
        Me.txtrechercheclient.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrechercheclient.Lines = New String(-1) {}
        Me.txtrechercheclient.Location = New System.Drawing.Point(861, 12)
        Me.txtrechercheclient.MaxLength = 32767
        Me.txtrechercheclient.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtrechercheclient.Modified = False
        Me.txtrechercheclient.Multiline = False
        Me.txtrechercheclient.Name = "txtrechercheclient"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtrechercheclient.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.White
        StateProperties6.FillColor = System.Drawing.Color.White
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtrechercheclient.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtrechercheclient.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.DarkSlateGray
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtrechercheclient.OnIdleState = StateProperties8
        Me.txtrechercheclient.Padding = New System.Windows.Forms.Padding(3)
        Me.txtrechercheclient.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrechercheclient.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtrechercheclient.PlaceholderText = "Rechercher une voiture"
        Me.txtrechercheclient.ReadOnly = False
        Me.txtrechercheclient.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrechercheclient.SelectedText = ""
        Me.txtrechercheclient.SelectionLength = 0
        Me.txtrechercheclient.SelectionStart = 0
        Me.txtrechercheclient.ShortcutsEnabled = True
        Me.txtrechercheclient.Size = New System.Drawing.Size(260, 24)
        Me.txtrechercheclient.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtrechercheclient.TabIndex = 11
        Me.txtrechercheclient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtrechercheclient.TextMarginBottom = 0
        Me.txtrechercheclient.TextMarginLeft = 3
        Me.txtrechercheclient.TextMarginTop = 0
        Me.txtrechercheclient.TextPlaceholder = "Rechercher une voiture"
        Me.txtrechercheclient.UseSystemPasswordChar = False
        Me.txtrechercheclient.WordWrap = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Harlow Solid Italic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(185, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Société MB"
        '
        'BunifuPictureBox4
        '
        Me.BunifuPictureBox4.AllowFocused = False
        Me.BunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox4.AutoSizeHeight = True
        Me.BunifuPictureBox4.BackColor = System.Drawing.Color.White
        Me.BunifuPictureBox4.BorderRadius = 21
        Me.BunifuPictureBox4.Image = CType(resources.GetObject("BunifuPictureBox4.Image"), System.Drawing.Image)
        Me.BunifuPictureBox4.IsCircle = True
        Me.BunifuPictureBox4.Location = New System.Drawing.Point(278, 12)
        Me.BunifuPictureBox4.Name = "BunifuPictureBox4"
        Me.BunifuPictureBox4.Size = New System.Drawing.Size(42, 42)
        Me.BunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox4.TabIndex = 14
        Me.BunifuPictureBox4.TabStop = False
        Me.BunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'frnclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1160, 550)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtrechercheclient)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuPictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frnclient"
        Me.Text = "Client"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pctbox1 As PictureBox
    Friend WithEvents pctbox2 As PictureBox
    Friend WithEvents pctbox3 As PictureBox
    Friend WithEvents lblclient1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtrechercheclient As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents txtquantiteclient As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuPictureBox4 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents DGVClient As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Marque As DataGridViewTextBoxColumn
    Friend WithEvents Prixdelocation As DataGridViewTextBoxColumn
    Friend WithEvents Vitesse As DataGridViewTextBoxColumn
    Friend WithEvents Etatdedisponibilite As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Quantite As DataGridViewTextBoxColumn
End Class
