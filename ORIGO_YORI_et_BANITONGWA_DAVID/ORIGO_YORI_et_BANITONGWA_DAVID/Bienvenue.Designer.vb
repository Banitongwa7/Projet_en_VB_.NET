<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frnbienvenue
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frnbienvenue))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.linkbienvenue = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.txtmotdepasseconnexion = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.txtemailconnexion = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.lblbienvenue = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuPictureBox4 = New Bunifu.UI.WinForms.BunifuPictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'linkbienvenue
        '
        Me.linkbienvenue.AutoSize = True
        Me.linkbienvenue.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkbienvenue.LinkColor = System.Drawing.Color.MidnightBlue
        Me.linkbienvenue.Location = New System.Drawing.Point(179, 479)
        Me.linkbienvenue.Name = "linkbienvenue"
        Me.linkbienvenue.Size = New System.Drawing.Size(115, 19)
        Me.linkbienvenue.TabIndex = 6
        Me.linkbienvenue.TabStop = True
        Me.linkbienvenue.Text = "Créer un compte"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(494, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 593)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BunifuPictureBox3)
        Me.Panel2.Controls.Add(Me.BunifuPictureBox2)
        Me.Panel2.Controls.Add(Me.BunifuPictureBox1)
        Me.Panel2.Controls.Add(Me.txtmotdepasseconnexion)
        Me.Panel2.Controls.Add(Me.txtemailconnexion)
        Me.Panel2.Controls.Add(Me.BunifuLabel1)
        Me.Panel2.Controls.Add(Me.BunifuButton1)
        Me.Panel2.Controls.Add(Me.lblbienvenue)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.linkbienvenue)
        Me.Panel2.Location = New System.Drawing.Point(-6, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(515, 593)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Uighur", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(15, 561)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Admin"
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox3.AutoSizeHeight = True
        Me.BunifuPictureBox3.BorderRadius = 22
        Me.BunifuPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuPictureBox3.Image = CType(resources.GetObject("BunifuPictureBox3.Image"), System.Drawing.Image)
        Me.BunifuPictureBox3.IsCircle = True
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(15, 527)
        Me.BunifuPictureBox3.Name = "BunifuPictureBox3"
        Me.BunifuPictureBox3.Size = New System.Drawing.Size(44, 44)
        Me.BunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox3.TabIndex = 16
        Me.BunifuPictureBox3.TabStop = False
        Me.BunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuPictureBox2
        '
        Me.BunifuPictureBox2.AllowFocused = False
        Me.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox2.AutoSizeHeight = True
        Me.BunifuPictureBox2.BorderRadius = 12
        Me.BunifuPictureBox2.Image = CType(resources.GetObject("BunifuPictureBox2.Image"), System.Drawing.Image)
        Me.BunifuPictureBox2.IsCircle = True
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(97, 288)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox2.TabIndex = 15
        Me.BunifuPictureBox2.TabStop = False
        Me.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 12
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(96, 337)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox1.TabIndex = 14
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'txtmotdepasseconnexion
        '
        Me.txtmotdepasseconnexion.AcceptsReturn = False
        Me.txtmotdepasseconnexion.AcceptsTab = False
        Me.txtmotdepasseconnexion.AnimationSpeed = 200
        Me.txtmotdepasseconnexion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtmotdepasseconnexion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtmotdepasseconnexion.BackColor = System.Drawing.Color.White
        Me.txtmotdepasseconnexion.BackgroundImage = CType(resources.GetObject("txtmotdepasseconnexion.BackgroundImage"), System.Drawing.Image)
        Me.txtmotdepasseconnexion.BorderColorActive = System.Drawing.Color.Crimson
        Me.txtmotdepasseconnexion.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtmotdepasseconnexion.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmotdepasseconnexion.BorderColorIdle = System.Drawing.Color.DarkSlateGray
        Me.txtmotdepasseconnexion.BorderRadius = 5
        Me.txtmotdepasseconnexion.BorderThickness = 1
        Me.txtmotdepasseconnexion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtmotdepasseconnexion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmotdepasseconnexion.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtmotdepasseconnexion.DefaultText = ""
        Me.txtmotdepasseconnexion.FillColor = System.Drawing.Color.White
        Me.txtmotdepasseconnexion.HideSelection = True
        Me.txtmotdepasseconnexion.IconLeft = Nothing
        Me.txtmotdepasseconnexion.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmotdepasseconnexion.IconPadding = 10
        Me.txtmotdepasseconnexion.IconRight = Nothing
        Me.txtmotdepasseconnexion.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmotdepasseconnexion.Lines = New String(-1) {}
        Me.txtmotdepasseconnexion.Location = New System.Drawing.Point(136, 337)
        Me.txtmotdepasseconnexion.MaxLength = 32767
        Me.txtmotdepasseconnexion.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtmotdepasseconnexion.Modified = False
        Me.txtmotdepasseconnexion.Multiline = False
        Me.txtmotdepasseconnexion.Name = "txtmotdepasseconnexion"
        StateProperties1.BorderColor = System.Drawing.Color.Crimson
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtmotdepasseconnexion.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtmotdepasseconnexion.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtmotdepasseconnexion.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.DarkSlateGray
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.Color.Empty
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtmotdepasseconnexion.OnIdleState = StateProperties4
        Me.txtmotdepasseconnexion.Padding = New System.Windows.Forms.Padding(3)
        Me.txtmotdepasseconnexion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtmotdepasseconnexion.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtmotdepasseconnexion.PlaceholderText = "Mot de passe"
        Me.txtmotdepasseconnexion.ReadOnly = False
        Me.txtmotdepasseconnexion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtmotdepasseconnexion.SelectedText = ""
        Me.txtmotdepasseconnexion.SelectionLength = 0
        Me.txtmotdepasseconnexion.SelectionStart = 0
        Me.txtmotdepasseconnexion.ShortcutsEnabled = True
        Me.txtmotdepasseconnexion.Size = New System.Drawing.Size(260, 24)
        Me.txtmotdepasseconnexion.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtmotdepasseconnexion.TabIndex = 13
        Me.txtmotdepasseconnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtmotdepasseconnexion.TextMarginBottom = 0
        Me.txtmotdepasseconnexion.TextMarginLeft = 3
        Me.txtmotdepasseconnexion.TextMarginTop = 0
        Me.txtmotdepasseconnexion.TextPlaceholder = "Mot de passe"
        Me.txtmotdepasseconnexion.UseSystemPasswordChar = True
        Me.txtmotdepasseconnexion.WordWrap = True
        '
        'txtemailconnexion
        '
        Me.txtemailconnexion.AcceptsReturn = False
        Me.txtemailconnexion.AcceptsTab = False
        Me.txtemailconnexion.AnimationSpeed = 200
        Me.txtemailconnexion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtemailconnexion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtemailconnexion.BackColor = System.Drawing.Color.White
        Me.txtemailconnexion.BackgroundImage = CType(resources.GetObject("txtemailconnexion.BackgroundImage"), System.Drawing.Image)
        Me.txtemailconnexion.BorderColorActive = System.Drawing.Color.Crimson
        Me.txtemailconnexion.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtemailconnexion.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemailconnexion.BorderColorIdle = System.Drawing.Color.DarkSlateGray
        Me.txtemailconnexion.BorderRadius = 5
        Me.txtemailconnexion.BorderThickness = 1
        Me.txtemailconnexion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtemailconnexion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemailconnexion.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtemailconnexion.DefaultText = ""
        Me.txtemailconnexion.FillColor = System.Drawing.Color.White
        Me.txtemailconnexion.HideSelection = True
        Me.txtemailconnexion.IconLeft = Nothing
        Me.txtemailconnexion.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemailconnexion.IconPadding = 10
        Me.txtemailconnexion.IconRight = Nothing
        Me.txtemailconnexion.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemailconnexion.Lines = New String(-1) {}
        Me.txtemailconnexion.Location = New System.Drawing.Point(136, 288)
        Me.txtemailconnexion.MaxLength = 32767
        Me.txtemailconnexion.MinimumSize = New System.Drawing.Size(1, 1)
        Me.txtemailconnexion.Modified = False
        Me.txtemailconnexion.Multiline = False
        Me.txtemailconnexion.Name = "txtemailconnexion"
        StateProperties5.BorderColor = System.Drawing.Color.Crimson
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtemailconnexion.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtemailconnexion.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtemailconnexion.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.DarkSlateGray
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.Color.Empty
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtemailconnexion.OnIdleState = StateProperties8
        Me.txtemailconnexion.Padding = New System.Windows.Forms.Padding(3)
        Me.txtemailconnexion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemailconnexion.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtemailconnexion.PlaceholderText = "Email"
        Me.txtemailconnexion.ReadOnly = False
        Me.txtemailconnexion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtemailconnexion.SelectedText = ""
        Me.txtemailconnexion.SelectionLength = 0
        Me.txtemailconnexion.SelectionStart = 0
        Me.txtemailconnexion.ShortcutsEnabled = True
        Me.txtemailconnexion.Size = New System.Drawing.Size(260, 24)
        Me.txtemailconnexion.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.txtemailconnexion.TabIndex = 12
        Me.txtemailconnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtemailconnexion.TextMarginBottom = 0
        Me.txtemailconnexion.TextMarginLeft = 3
        Me.txtemailconnexion.TextMarginTop = 0
        Me.txtemailconnexion.TextPlaceholder = "Email"
        Me.txtemailconnexion.UseSystemPasswordChar = False
        Me.txtemailconnexion.WordWrap = True
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.BunifuLabel1.Location = New System.Drawing.Point(194, 217)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(85, 18)
        Me.BunifuLabel1.TabIndex = 11
        Me.BunifuLabel1.Text = "Connexion"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.DarkCyan
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "Se connecter"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.Cyan
        Me.BunifuButton1.IdleBorderRadius = 30
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.DarkCyan
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(147, 425)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 30
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.BorderRadius = 30
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Cyan
        Me.BunifuButton1.OnIdleState.BorderRadius = 30
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DarkCyan
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 30
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(184, 39)
        Me.BunifuButton1.TabIndex = 10
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'lblbienvenue
        '
        Me.lblbienvenue.AutoSize = True
        Me.lblbienvenue.Location = New System.Drawing.Point(357, 379)
        Me.lblbienvenue.Name = "lblbienvenue"
        Me.lblbienvenue.Size = New System.Drawing.Size(39, 13)
        Me.lblbienvenue.TabIndex = 2
        Me.lblbienvenue.Text = "Label3"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(198, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Font = New System.Drawing.Font("Harlow Solid Italic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(581, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Société MB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(715, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Location Voiture"
        '
        'BunifuPictureBox4
        '
        Me.BunifuPictureBox4.AllowFocused = False
        Me.BunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox4.AutoSizeHeight = True
        Me.BunifuPictureBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuPictureBox4.BorderRadius = 44
        Me.BunifuPictureBox4.Image = CType(resources.GetObject("BunifuPictureBox4.Image"), System.Drawing.Image)
        Me.BunifuPictureBox4.IsCircle = True
        Me.BunifuPictureBox4.Location = New System.Drawing.Point(744, 34)
        Me.BunifuPictureBox4.Name = "BunifuPictureBox4"
        Me.BunifuPictureBox4.Size = New System.Drawing.Size(88, 88)
        Me.BunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox4.TabIndex = 7
        Me.BunifuPictureBox4.TabStop = False
        Me.BunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'frnbienvenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 591)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuPictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frnbienvenue"
        Me.Text = "Connexion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents linkbienvenue As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblbienvenue As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtemailconnexion As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtmotdepasseconnexion As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox4 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Label2 As Label
End Class
