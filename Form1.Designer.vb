<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnStream = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCaptureScreenshot = New Guna.UI2.WinForms.Guna2Button()
        Me.txtStreamURL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.picSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.pnlSettings = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.picEdit = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtChannel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtIPAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblChannel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblIPaddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblUsername = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tmrStopStatus = New System.Windows.Forms.Timer(Me.components)
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblFolderpath = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettings.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(1, 43)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(849, 12)
        Me.Guna2Separator1.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BorderRadius = 10
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(795, 5)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(46, 38)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BorderRadius = 10
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(743, 5)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.BorderRadius = 15
        Me.Guna2ControlBox2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(46, 38)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(53, 9)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(161, 32)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "<font color=#0F518C>RTSP</font>  <font color=#ED0049>Streaming</font>"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(17, 13)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox1.TabIndex = 4
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnStream
        '
        Me.btnStream.Animated = True
        Me.btnStream.BorderRadius = 15
        Me.btnStream.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnStream.CheckedState.Parent = Me.btnStream
        Me.btnStream.CustomImages.Parent = Me.btnStream
        Me.btnStream.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnStream.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStream.ForeColor = System.Drawing.Color.White
        Me.btnStream.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnStream.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnStream.HoverState.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStream.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnStream.HoverState.Image = CType(resources.GetObject("btnStream.HoverState.Image"), System.Drawing.Image)
        Me.btnStream.HoverState.Parent = Me.btnStream
        Me.btnStream.Image = CType(resources.GetObject("btnStream.Image"), System.Drawing.Image)
        Me.btnStream.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.btnStream.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnStream.Location = New System.Drawing.Point(12, 80)
        Me.btnStream.Name = "btnStream"
        Me.btnStream.ShadowDecoration.Parent = Me.btnStream
        Me.btnStream.Size = New System.Drawing.Size(101, 45)
        Me.btnStream.TabIndex = 5
        Me.btnStream.Text = "Stream"
        '
        'btnCaptureScreenshot
        '
        Me.btnCaptureScreenshot.Animated = True
        Me.btnCaptureScreenshot.BorderRadius = 15
        Me.btnCaptureScreenshot.CheckedState.Parent = Me.btnCaptureScreenshot
        Me.btnCaptureScreenshot.CustomImages.Parent = Me.btnCaptureScreenshot
        Me.btnCaptureScreenshot.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnCaptureScreenshot.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaptureScreenshot.ForeColor = System.Drawing.Color.White
        Me.btnCaptureScreenshot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCaptureScreenshot.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCaptureScreenshot.HoverState.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaptureScreenshot.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnCaptureScreenshot.HoverState.Image = CType(resources.GetObject("btnCaptureScreenshot.HoverState.Image"), System.Drawing.Image)
        Me.btnCaptureScreenshot.HoverState.Parent = Me.btnCaptureScreenshot
        Me.btnCaptureScreenshot.Image = CType(resources.GetObject("btnCaptureScreenshot.Image"), System.Drawing.Image)
        Me.btnCaptureScreenshot.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.btnCaptureScreenshot.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnCaptureScreenshot.Location = New System.Drawing.Point(118, 80)
        Me.btnCaptureScreenshot.Name = "btnCaptureScreenshot"
        Me.btnCaptureScreenshot.ShadowDecoration.Parent = Me.btnCaptureScreenshot
        Me.btnCaptureScreenshot.Size = New System.Drawing.Size(107, 45)
        Me.btnCaptureScreenshot.TabIndex = 6
        Me.btnCaptureScreenshot.Text = "Capture"
        '
        'txtStreamURL
        '
        Me.txtStreamURL.Animated = True
        Me.txtStreamURL.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtStreamURL.BorderRadius = 5
        Me.txtStreamURL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStreamURL.DefaultText = ""
        Me.txtStreamURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStreamURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStreamURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreamURL.DisabledState.Parent = Me.txtStreamURL
        Me.txtStreamURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreamURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreamURL.FocusedState.Parent = Me.txtStreamURL
        Me.txtStreamURL.ForeColor = System.Drawing.Color.Black
        Me.txtStreamURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreamURL.HoverState.Parent = Me.txtStreamURL
        Me.txtStreamURL.Location = New System.Drawing.Point(294, 83)
        Me.txtStreamURL.Name = "txtStreamURL"
        Me.txtStreamURL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreamURL.PlaceholderForeColor = System.Drawing.Color.SteelBlue
        Me.txtStreamURL.PlaceholderText = "Status"
        Me.txtStreamURL.SelectedText = ""
        Me.txtStreamURL.ShadowDecoration.Parent = Me.txtStreamURL
        Me.txtStreamURL.Size = New System.Drawing.Size(479, 36)
        Me.txtStreamURL.TabIndex = 7
        '
        'picSettings
        '
        Me.picSettings.Animated = True
        Me.picSettings.AutoRoundedCorners = True
        Me.picSettings.BorderRadius = 22
        Me.picSettings.CheckedState.Parent = Me.picSettings
        Me.picSettings.CustomImages.Parent = Me.picSettings
        Me.picSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.picSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.picSettings.ForeColor = System.Drawing.Color.White
        Me.picSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.picSettings.HoverState.Image = CType(resources.GetObject("picSettings.HoverState.Image"), System.Drawing.Image)
        Me.picSettings.HoverState.Parent = Me.picSettings
        Me.picSettings.Image = CType(resources.GetObject("picSettings.Image"), System.Drawing.Image)
        Me.picSettings.ImageSize = New System.Drawing.Size(24, 24)
        Me.picSettings.Location = New System.Drawing.Point(780, 75)
        Me.picSettings.Name = "picSettings"
        Me.picSettings.ShadowDecoration.Parent = Me.picSettings
        Me.picSettings.Size = New System.Drawing.Size(56, 46)
        Me.picSettings.TabIndex = 8
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(12, 173)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(828, 567)
        Me.AxVLCPlugin21.TabIndex = 9
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.pnlSettings.BorderColor = System.Drawing.Color.Black
        Me.pnlSettings.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnlSettings.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnlSettings.Controls.Add(Me.btnSave)
        Me.pnlSettings.Controls.Add(Me.picEdit)
        Me.pnlSettings.Controls.Add(Me.txtChannel)
        Me.pnlSettings.Controls.Add(Me.txtIPAddress)
        Me.pnlSettings.Controls.Add(Me.txtPassword)
        Me.pnlSettings.Controls.Add(Me.txtUsername)
        Me.pnlSettings.Controls.Add(Me.lblChannel)
        Me.pnlSettings.Controls.Add(Me.lblIPaddress)
        Me.pnlSettings.Controls.Add(Me.lblPassword)
        Me.pnlSettings.Controls.Add(Me.lblUsername)
        Me.pnlSettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.pnlSettings.Location = New System.Drawing.Point(142, 222)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.ShadowDecoration.BorderRadius = 0
        Me.pnlSettings.ShadowDecoration.Parent = Me.pnlSettings
        Me.pnlSettings.Size = New System.Drawing.Size(543, 430)
        Me.pnlSettings.TabIndex = 10
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(63, 383)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(409, 19)
        Me.Guna2HtmlLabel3.TabIndex = 16
        Me.Guna2HtmlLabel3.Text = "<font color=#0F518C><b>Geovision<b></font>  = <font color=#ED0049> rtsp://usernam" &
    "e:password@ipaddress:8554/CH001.sdp</font>"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(63, 350)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(354, 19)
        Me.Guna2HtmlLabel2.TabIndex = 15
        Me.Guna2HtmlLabel2.Text = "<font color=#0F518C>HikVision</font>  = <font color=#ED0049> rtsp://username:pass" &
    "word@ipaddress:554/101</font>"
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnSave.BorderRadius = 15
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.FillColor = System.Drawing.Color.Green
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.HoverState.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.HoverState.Image = CType(resources.GetObject("btnSave.HoverState.Image"), System.Drawing.Image)
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.btnSave.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnSave.Location = New System.Drawing.Point(224, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(88, 46)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        '
        'picEdit
        '
        Me.picEdit.Animated = True
        Me.picEdit.CheckedState.Parent = Me.picEdit
        Me.picEdit.CustomImages.Parent = Me.picEdit
        Me.picEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.picEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.picEdit.ForeColor = System.Drawing.Color.White
        Me.picEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.picEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.picEdit.HoverState.Image = CType(resources.GetObject("picEdit.HoverState.Image"), System.Drawing.Image)
        Me.picEdit.HoverState.Parent = Me.picEdit
        Me.picEdit.Image = CType(resources.GetObject("picEdit.Image"), System.Drawing.Image)
        Me.picEdit.ImageSize = New System.Drawing.Size(32, 32)
        Me.picEdit.Location = New System.Drawing.Point(451, 82)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picEdit.ShadowDecoration.Parent = Me.picEdit
        Me.picEdit.Size = New System.Drawing.Size(58, 55)
        Me.picEdit.TabIndex = 13
        '
        'txtChannel
        '
        Me.txtChannel.Animated = True
        Me.txtChannel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtChannel.BorderRadius = 15
        Me.txtChannel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChannel.DefaultText = ""
        Me.txtChannel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChannel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChannel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChannel.DisabledState.Parent = Me.txtChannel
        Me.txtChannel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChannel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChannel.FocusedState.Parent = Me.txtChannel
        Me.txtChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtChannel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChannel.HoverState.Parent = Me.txtChannel
        Me.txtChannel.Location = New System.Drawing.Point(170, 193)
        Me.txtChannel.Name = "txtChannel"
        Me.txtChannel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChannel.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtChannel.PlaceholderText = "Channel"
        Me.txtChannel.SelectedText = ""
        Me.txtChannel.ShadowDecoration.Parent = Me.txtChannel
        Me.txtChannel.Size = New System.Drawing.Size(98, 36)
        Me.txtChannel.TabIndex = 11
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Animated = True
        Me.txtIPAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtIPAddress.BorderRadius = 15
        Me.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIPAddress.DefaultText = ""
        Me.txtIPAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIPAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIPAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIPAddress.DisabledState.Parent = Me.txtIPAddress
        Me.txtIPAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIPAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIPAddress.FocusedState.Parent = Me.txtIPAddress
        Me.txtIPAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtIPAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIPAddress.HoverState.Parent = Me.txtIPAddress
        Me.txtIPAddress.Location = New System.Drawing.Point(170, 142)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIPAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtIPAddress.PlaceholderText = "IP Address"
        Me.txtIPAddress.SelectedText = ""
        Me.txtIPAddress.ShadowDecoration.Parent = Me.txtIPAddress
        Me.txtIPAddress.Size = New System.Drawing.Size(231, 36)
        Me.txtIPAddress.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtPassword.BorderRadius = 15
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(170, 92)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(231, 36)
        Me.txtPassword.TabIndex = 9
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtUsername.BorderRadius = 15
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(170, 40)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(231, 36)
        Me.txtUsername.TabIndex = 8
        '
        'lblChannel
        '
        Me.lblChannel.BackColor = System.Drawing.Color.Transparent
        Me.lblChannel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblChannel.Location = New System.Drawing.Point(63, 200)
        Me.lblChannel.Name = "lblChannel"
        Me.lblChannel.Size = New System.Drawing.Size(56, 22)
        Me.lblChannel.TabIndex = 3
        Me.lblChannel.Text = "Channel"
        '
        'lblIPaddress
        '
        Me.lblIPaddress.BackColor = System.Drawing.Color.Transparent
        Me.lblIPaddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIPaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblIPaddress.Location = New System.Drawing.Point(63, 149)
        Me.lblIPaddress.Name = "lblIPaddress"
        Me.lblIPaddress.Size = New System.Drawing.Size(72, 22)
        Me.lblIPaddress.TabIndex = 2
        Me.lblIPaddress.Text = "IP Address"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(63, 99)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 22)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(66, 47)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(69, 22)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'tmrStopStatus
        '
        Me.tmrStopStatus.Interval = 5000
        '
        'btnRefresh
        '
        Me.btnRefresh.Animated = True
        Me.btnRefresh.CheckedState.Parent = Me.btnRefresh
        Me.btnRefresh.CustomImages.Parent = Me.btnRefresh
        Me.btnRefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnRefresh.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnRefresh.HoverState.Image = CType(resources.GetObject("btnRefresh.HoverState.Image"), System.Drawing.Image)
        Me.btnRefresh.HoverState.Parent = Me.btnRefresh
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnRefresh.Location = New System.Drawing.Point(231, 78)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnRefresh.ShadowDecoration.Parent = Me.btnRefresh
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(698, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(795, 135)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'lblFolderpath
        '
        Me.lblFolderpath.AutoSize = True
        Me.lblFolderpath.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolderpath.ForeColor = System.Drawing.Color.White
        Me.lblFolderpath.Location = New System.Drawing.Point(19, 142)
        Me.lblFolderpath.Name = "lblFolderpath"
        Me.lblFolderpath.Size = New System.Drawing.Size(0, 17)
        Me.lblFolderpath.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 750)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblFolderpath)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.Controls.Add(Me.picSettings)
        Me.Controls.Add(Me.txtStreamURL)
        Me.Controls.Add(Me.btnCaptureScreenshot)
        Me.Controls.Add(Me.btnStream)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnStream As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCaptureScreenshot As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtStreamURL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSettings As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picEdit As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtChannel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtIPAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblChannel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblIPaddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblUsername As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tmrStopStatus As Timer
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblFolderpath As Label
End Class
