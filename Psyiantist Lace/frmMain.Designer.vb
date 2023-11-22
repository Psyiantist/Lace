<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMain))
        Panel1 = New Panel()
        btnShowExtra = New Button()
        btnAbout = New Button()
        btnSettings = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        lvHistory = New ListView()
        prompthistory = New ColumnHeader()
        responsehistory = New ColumnHeader()
        GroupBox1 = New GroupBox()
        lblTrained = New Label()
        lblParamCount = New Label()
        lblModelType = New Label()
        lblModelName = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnStreamline = New Button()
        lblProgress = New Label()
        barProgress = New ProgressBar()
        lblLoading = New Label()
        Label16 = New Label()
        txtboxResp = New RichTextBox()
        Panel3 = New Panel()
        btnCancel = New Button()
        btnSend = New Button()
        txtboxMsg = New TextBox()
        Label5 = New Label()
        lblPing = New Label()
        pinger = New Timer(components)
        pnlSettings = New Panel()
        lblOpac = New Label()
        trackbarOpacity = New TrackBar()
        Label13 = New Label()
        cmbShowP = New ComboBox()
        cmbTypeAni = New ComboBox()
        cmbModel = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        pnlAbout = New Panel()
        scrollAbout = New VScrollBar()
        pnlScrollableAbout = New Panel()
        PictureBox2 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        Label18 = New Label()
        Label9 = New Label()
        Label15 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label14 = New Label()
        pnlWait = New Panel()
        Label12 = New Label()
        pnlExtra = New Panel()
        Button3 = New Button()
        btnTextColorWhite = New Button()
        btnTextColorGray = New Button()
        btnFontChange = New Button()
        btnTextColorBlack = New Button()
        btnBackColorChange = New Button()
        lblTFS = New Label()
        lblTC = New Label()
        lblBC = New Label()
        Label17 = New Label()
        cldBackC = New ColorDialog()
        FontDialog1 = New FontDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        pnlSettings.SuspendLayout()
        CType(trackbarOpacity, ComponentModel.ISupportInitialize).BeginInit()
        pnlAbout.SuspendLayout()
        pnlScrollableAbout.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlWait.SuspendLayout()
        pnlExtra.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnShowExtra)
        Panel1.Controls.Add(btnAbout)
        Panel1.Controls.Add(btnSettings)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-7, -3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(811, 35)
        Panel1.TabIndex = 0
        ' 
        ' btnShowExtra
        ' 
        btnShowExtra.FlatAppearance.BorderSize = 0
        btnShowExtra.FlatStyle = FlatStyle.Flat
        btnShowExtra.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnShowExtra.ForeColor = Color.LightGray
        btnShowExtra.Location = New Point(789, 0)
        btnShowExtra.Name = "btnShowExtra"
        btnShowExtra.Size = New Size(18, 36)
        btnShowExtra.TabIndex = 5
        btnShowExtra.Text = "✎"
        btnShowExtra.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.FlatAppearance.BorderSize = 0
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.ForeColor = Color.White
        btnAbout.Location = New Point(100, 6)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(57, 25)
        btnAbout.TabIndex = 4
        btnAbout.Text = "About"
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnSettings
        ' 
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.White
        btnSettings.Location = New Point(41, 6)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(59, 25)
        btnSettings.TabIndex = 3
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.LightGray
        Button2.Location = New Point(677, -19)
        Button2.Name = "Button2"
        Button2.Size = New Size(56, 55)
        Button2.TabIndex = 2
        Button2.Text = "_"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.LightGray
        Button1.Location = New Point(733, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(56, 32)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.clrico
        PictureBox1.Location = New Point(12, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 25)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lvHistory
        ' 
        lvHistory.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        lvHistory.Columns.AddRange(New ColumnHeader() {prompthistory, responsehistory})
        lvHistory.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lvHistory.ForeColor = Color.White
        lvHistory.FullRowSelect = True
        lvHistory.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lvHistory.Location = New Point(12, 46)
        lvHistory.MultiSelect = False
        lvHistory.Name = "lvHistory"
        lvHistory.Size = New Size(302, 392)
        lvHistory.TabIndex = 1
        lvHistory.UseCompatibleStateImageBehavior = False
        lvHistory.View = View.Details
        ' 
        ' prompthistory
        ' 
        prompthistory.Text = "Prompt History"
        prompthistory.Width = 150
        ' 
        ' responsehistory
        ' 
        responsehistory.Text = "Response History"
        responsehistory.Width = 150
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblTrained)
        GroupBox1.Controls.Add(lblParamCount)
        GroupBox1.Controls.Add(lblModelType)
        GroupBox1.Controls.Add(lblModelName)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(322, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(466, 90)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Model Information"
        ' 
        ' lblTrained
        ' 
        lblTrained.AutoSize = True
        lblTrained.Location = New Point(304, 55)
        lblTrained.Name = "lblTrained"
        lblTrained.Size = New Size(0, 15)
        lblTrained.TabIndex = 7
        ' 
        ' lblParamCount
        ' 
        lblParamCount.AutoSize = True
        lblParamCount.Location = New Point(117, 55)
        lblParamCount.Name = "lblParamCount"
        lblParamCount.Size = New Size(0, 15)
        lblParamCount.TabIndex = 6
        ' 
        ' lblModelType
        ' 
        lblModelType.AutoSize = True
        lblModelType.Location = New Point(327, 24)
        lblModelType.Name = "lblModelType"
        lblModelType.Size = New Size(0, 15)
        lblModelType.TabIndex = 5
        ' 
        ' lblModelName
        ' 
        lblModelName.AutoSize = True
        lblModelName.Location = New Point(96, 24)
        lblModelName.Name = "lblModelName"
        lblModelName.Size = New Size(0, 15)
        lblModelName.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(250, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 3
        Label4.Text = "Trained:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(250, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 2
        Label3.Text = "Model Type:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(11, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 1
        Label2.Text = "Parameter Count:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(11, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 15)
        Label1.TabIndex = 0
        Label1.Text = "Model Name:"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btnStreamline)
        Panel2.Controls.Add(lblProgress)
        Panel2.Controls.Add(barProgress)
        Panel2.Controls.Add(lblLoading)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(txtboxResp)
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(321, 136)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(467, 266)
        Panel2.TabIndex = 3
        ' 
        ' btnStreamline
        ' 
        btnStreamline.BackColor = Color.Transparent
        btnStreamline.FlatAppearance.BorderSize = 2
        btnStreamline.FlatStyle = FlatStyle.Popup
        btnStreamline.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnStreamline.ForeColor = Color.White
        btnStreamline.Location = New Point(360, 227)
        btnStreamline.Name = "btnStreamline"
        btnStreamline.Size = New Size(98, 31)
        btnStreamline.TabIndex = 18
        btnStreamline.Text = "Streamline"
        btnStreamline.UseVisualStyleBackColor = False
        btnStreamline.Visible = False
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Location = New Point(275, 4)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(60, 15)
        lblProgress.TabIndex = 16
        lblProgress.Text = "0000/0000"
        lblProgress.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' barProgress
        ' 
        barProgress.ForeColor = Color.Black
        barProgress.Location = New Point(347, 4)
        barProgress.Name = "barProgress"
        barProgress.Size = New Size(112, 14)
        barProgress.Style = ProgressBarStyle.Continuous
        barProgress.TabIndex = 15
        ' 
        ' lblLoading
        ' 
        lblLoading.AutoSize = True
        lblLoading.Location = New Point(202, 124)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(59, 15)
        lblLoading.TabIndex = 7
        lblLoading.Text = "Loading..."
        lblLoading.Visible = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(5, 4)
        Label16.Name = "Label16"
        Label16.Size = New Size(98, 15)
        Label16.TabIndex = 1
        Label16.Text = "Model Response"
        ' 
        ' txtboxResp
        ' 
        txtboxResp.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        txtboxResp.ForeColor = Color.White
        txtboxResp.Location = New Point(-2, 24)
        txtboxResp.Name = "txtboxResp"
        txtboxResp.ReadOnly = True
        txtboxResp.ScrollBars = RichTextBoxScrollBars.ForcedBoth
        txtboxResp.Size = New Size(467, 240)
        txtboxResp.TabIndex = 5
        txtboxResp.Text = ""
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnCancel)
        Panel3.Controls.Add(btnSend)
        Panel3.Controls.Add(txtboxMsg)
        Panel3.Location = New Point(321, 408)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(467, 30)
        Panel3.TabIndex = 4
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DarkRed
        btnCancel.FlatAppearance.BorderColor = Color.White
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(397, -2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(69, 31)
        btnCancel.TabIndex = 17
        btnCancel.Text = "Stop"
        btnCancel.UseVisualStyleBackColor = False
        btnCancel.Visible = False
        ' 
        ' btnSend
        ' 
        btnSend.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSend.ForeColor = Color.Black
        btnSend.Location = New Point(397, -1)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(69, 30)
        btnSend.TabIndex = 1
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' txtboxMsg
        ' 
        txtboxMsg.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        txtboxMsg.BorderStyle = BorderStyle.None
        txtboxMsg.ForeColor = Color.White
        txtboxMsg.Location = New Point(6, 5)
        txtboxMsg.Name = "txtboxMsg"
        txtboxMsg.PlaceholderText = "Type a message"
        txtboxMsg.Size = New Size(385, 16)
        txtboxMsg.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 444)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 5
        Label5.Text = "Ping:"
        ' 
        ' lblPing
        ' 
        lblPing.AutoSize = True
        lblPing.Location = New Point(47, 444)
        lblPing.Name = "lblPing"
        lblPing.Size = New Size(0, 15)
        lblPing.TabIndex = 6
        ' 
        ' pinger
        ' 
        pinger.Enabled = True
        pinger.Interval = 1000
        ' 
        ' pnlSettings
        ' 
        pnlSettings.BorderStyle = BorderStyle.Fixed3D
        pnlSettings.Controls.Add(lblOpac)
        pnlSettings.Controls.Add(trackbarOpacity)
        pnlSettings.Controls.Add(Label13)
        pnlSettings.Controls.Add(cmbShowP)
        pnlSettings.Controls.Add(cmbTypeAni)
        pnlSettings.Controls.Add(cmbModel)
        pnlSettings.Controls.Add(Label8)
        pnlSettings.Controls.Add(Label7)
        pnlSettings.Controls.Add(Label6)
        pnlSettings.Location = New Point(34, 27)
        pnlSettings.Name = "pnlSettings"
        pnlSettings.Size = New Size(350, 204)
        pnlSettings.TabIndex = 7
        pnlSettings.Visible = False
        ' 
        ' lblOpac
        ' 
        lblOpac.AutoSize = True
        lblOpac.Location = New Point(283, 152)
        lblOpac.Name = "lblOpac"
        lblOpac.Size = New Size(35, 15)
        lblOpac.TabIndex = 9
        lblOpac.Text = "100%"
        lblOpac.TextAlign = ContentAlignment.TopRight
        ' 
        ' trackbarOpacity
        ' 
        trackbarOpacity.LargeChange = 10
        trackbarOpacity.Location = New Point(130, 139)
        trackbarOpacity.Maximum = 100
        trackbarOpacity.Minimum = 30
        trackbarOpacity.Name = "trackbarOpacity"
        trackbarOpacity.Size = New Size(154, 45)
        trackbarOpacity.TabIndex = 7
        trackbarOpacity.TickStyle = TickStyle.Both
        trackbarOpacity.Value = 100
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(26, 152)
        Label13.Name = "Label13"
        Label13.Size = New Size(98, 15)
        Label13.TabIndex = 6
        Label13.Text = "Window Opacity"
        ' 
        ' cmbShowP
        ' 
        cmbShowP.DropDownStyle = ComboBoxStyle.DropDownList
        cmbShowP.FlatStyle = FlatStyle.Flat
        cmbShowP.FormattingEnabled = True
        cmbShowP.Items.AddRange(New Object() {"Enabled", "Disabled"})
        cmbShowP.Location = New Point(139, 104)
        cmbShowP.Name = "cmbShowP"
        cmbShowP.Size = New Size(179, 23)
        cmbShowP.TabIndex = 5
        ' 
        ' cmbTypeAni
        ' 
        cmbTypeAni.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTypeAni.FlatStyle = FlatStyle.Flat
        cmbTypeAni.FormattingEnabled = True
        cmbTypeAni.Items.AddRange(New Object() {"Enabled", "Disabled"})
        cmbTypeAni.Location = New Point(139, 64)
        cmbTypeAni.Name = "cmbTypeAni"
        cmbTypeAni.Size = New Size(179, 23)
        cmbTypeAni.TabIndex = 4
        ' 
        ' cmbModel
        ' 
        cmbModel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbModel.FlatStyle = FlatStyle.Flat
        cmbModel.FormattingEnabled = True
        cmbModel.Items.AddRange(New Object() {"LLaMa-2-70B-chat", "LLaMa-13B", "LLaMa-2-7B"})
        cmbModel.Location = New Point(139, 24)
        cmbModel.Name = "cmbModel"
        cmbModel.Size = New Size(179, 23)
        cmbModel.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(26, 107)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 15)
        Label8.TabIndex = 2
        Label8.Text = "Show ping"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(26, 67)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 15)
        Label7.TabIndex = 1
        Label7.Text = "Typing animation"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(26, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 0
        Label6.Text = "Model"
        ' 
        ' pnlAbout
        ' 
        pnlAbout.BorderStyle = BorderStyle.Fixed3D
        pnlAbout.Controls.Add(scrollAbout)
        pnlAbout.Controls.Add(pnlScrollableAbout)
        pnlAbout.Location = New Point(93, 27)
        pnlAbout.Name = "pnlAbout"
        pnlAbout.Size = New Size(362, 217)
        pnlAbout.TabIndex = 8
        pnlAbout.Visible = False
        ' 
        ' scrollAbout
        ' 
        scrollAbout.Dock = DockStyle.Right
        scrollAbout.Location = New Point(341, 0)
        scrollAbout.Maximum = 200
        scrollAbout.Minimum = 2
        scrollAbout.Name = "scrollAbout"
        scrollAbout.Size = New Size(17, 213)
        scrollAbout.TabIndex = 4
        scrollAbout.Value = 2
        ' 
        ' pnlScrollableAbout
        ' 
        pnlScrollableAbout.Controls.Add(PictureBox2)
        pnlScrollableAbout.Controls.Add(LinkLabel1)
        pnlScrollableAbout.Controls.Add(Label18)
        pnlScrollableAbout.Controls.Add(Label9)
        pnlScrollableAbout.Controls.Add(Label15)
        pnlScrollableAbout.Controls.Add(Label10)
        pnlScrollableAbout.Controls.Add(Label11)
        pnlScrollableAbout.Location = New Point(3, 2)
        pnlScrollableAbout.Name = "pnlScrollableAbout"
        pnlScrollableAbout.Size = New Size(335, 399)
        pnlScrollableAbout.TabIndex = 16
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.clrico
        PictureBox2.Location = New Point(306, 369)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 25)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(11, 358)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(130, 30)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "github.com/Psyiantist" & vbCrLf & "replit.com/@MattFawn"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(9, 227)
        Label18.Name = "Label18"
        Label18.Size = New Size(301, 45)
        Label18.TabIndex = 4
        Label18.Text = "Created with Microsoft Visual Studio 2022. Any forms of" & vbCrLf & "Illegal Copyright or Distribution of this product will" & vbCrLf & "violate the license. The Unlicensed. (2023)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(12, 13)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 15)
        Label9.TabIndex = 0
        Label9.Text = "App Creator:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(8, 180)
        Label15.Name = "Label15"
        Label15.Size = New Size(236, 15)
        Label15.TabIndex = 3
        Label15.Text = "Large Artificial Cognitive Ensemble (Lace)"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(95, 13)
        Label10.Name = "Label10"
        Label10.Size = New Size(154, 15)
        Label10.TabIndex = 1
        Label10.Text = " Matt Castaneda (Psyiantist)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(8, 71)
        Label11.Name = "Label11"
        Label11.Size = New Size(322, 90)
        Label11.TabIndex = 2
        Label11.Text = resources.GetString("Label11.Text")
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(677, 444)
        Label14.Name = "Label14"
        Label14.Size = New Size(111, 15)
        Label14.TabIndex = 12
        Label14.Text = "Psyiantist Lace 2023"
        ' 
        ' pnlWait
        ' 
        pnlWait.Controls.Add(Label12)
        pnlWait.Location = New Point(289, 440)
        pnlWait.Name = "pnlWait"
        pnlWait.Size = New Size(222, 23)
        pnlWait.TabIndex = 14
        pnlWait.Visible = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(51, 6)
        Label12.Name = "Label12"
        Label12.Size = New Size(121, 15)
        Label12.TabIndex = 9
        Label12.Text = "Waiting for network..."
        ' 
        ' pnlExtra
        ' 
        pnlExtra.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        pnlExtra.Controls.Add(Button3)
        pnlExtra.Controls.Add(btnTextColorWhite)
        pnlExtra.Controls.Add(btnTextColorGray)
        pnlExtra.Controls.Add(btnFontChange)
        pnlExtra.Controls.Add(btnTextColorBlack)
        pnlExtra.Controls.Add(btnBackColorChange)
        pnlExtra.Controls.Add(lblTFS)
        pnlExtra.Controls.Add(lblTC)
        pnlExtra.Controls.Add(lblBC)
        pnlExtra.Controls.Add(Label17)
        pnlExtra.Location = New Point(800, -3)
        pnlExtra.Name = "pnlExtra"
        pnlExtra.Size = New Size(253, 474)
        pnlExtra.TabIndex = 15
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(31, 429)
        Button3.Name = "Button3"
        Button3.Size = New Size(190, 29)
        Button3.TabIndex = 10
        Button3.Text = "Reset to default"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnTextColorWhite
        ' 
        btnTextColorWhite.FlatAppearance.BorderColor = Color.White
        btnTextColorWhite.FlatAppearance.BorderSize = 2
        btnTextColorWhite.FlatStyle = FlatStyle.Flat
        btnTextColorWhite.Location = New Point(160, 211)
        btnTextColorWhite.Name = "btnTextColorWhite"
        btnTextColorWhite.Size = New Size(61, 29)
        btnTextColorWhite.TabIndex = 9
        btnTextColorWhite.Text = "White"
        btnTextColorWhite.UseVisualStyleBackColor = True
        ' 
        ' btnTextColorGray
        ' 
        btnTextColorGray.FlatAppearance.BorderColor = Color.Gray
        btnTextColorGray.FlatAppearance.BorderSize = 2
        btnTextColorGray.FlatStyle = FlatStyle.Flat
        btnTextColorGray.Location = New Point(95, 211)
        btnTextColorGray.Name = "btnTextColorGray"
        btnTextColorGray.Size = New Size(61, 29)
        btnTextColorGray.TabIndex = 8
        btnTextColorGray.Text = "Gray"
        btnTextColorGray.UseVisualStyleBackColor = True
        ' 
        ' btnFontChange
        ' 
        btnFontChange.FlatStyle = FlatStyle.Flat
        btnFontChange.Location = New Point(31, 322)
        btnFontChange.Name = "btnFontChange"
        btnFontChange.Size = New Size(190, 29)
        btnFontChange.TabIndex = 7
        btnFontChange.Text = "Change"
        btnFontChange.UseVisualStyleBackColor = True
        ' 
        ' btnTextColorBlack
        ' 
        btnTextColorBlack.FlatAppearance.BorderColor = Color.Black
        btnTextColorBlack.FlatAppearance.BorderSize = 2
        btnTextColorBlack.FlatStyle = FlatStyle.Flat
        btnTextColorBlack.Location = New Point(31, 211)
        btnTextColorBlack.Name = "btnTextColorBlack"
        btnTextColorBlack.Size = New Size(61, 29)
        btnTextColorBlack.TabIndex = 6
        btnTextColorBlack.Text = "Black"
        btnTextColorBlack.UseVisualStyleBackColor = True
        ' 
        ' btnBackColorChange
        ' 
        btnBackColorChange.FlatStyle = FlatStyle.Flat
        btnBackColorChange.Location = New Point(31, 90)
        btnBackColorChange.Name = "btnBackColorChange"
        btnBackColorChange.Size = New Size(190, 29)
        btnBackColorChange.TabIndex = 5
        btnBackColorChange.Text = "Change"
        btnBackColorChange.UseVisualStyleBackColor = True
        ' 
        ' lblTFS
        ' 
        lblTFS.AutoSize = True
        lblTFS.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTFS.Location = New Point(16, 297)
        lblTFS.Name = "lblTFS"
        lblTFS.Size = New Size(148, 15)
        lblTFS.TabIndex = 3
        lblTFS.Text = "Text Font Style: Segoe UI"
        ' 
        ' lblTC
        ' 
        lblTC.AutoSize = True
        lblTC.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTC.Location = New Point(16, 185)
        lblTC.Name = "lblTC"
        lblTC.Size = New Size(104, 15)
        lblTC.TabIndex = 2
        lblTC.Text = "Text Color: White"
        ' 
        ' lblBC
        ' 
        lblBC.AutoSize = True
        lblBC.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblBC.Location = New Point(16, 62)
        lblBC.Name = "lblBC"
        lblBC.Size = New Size(173, 15)
        lblBC.TabIndex = 1
        lblBC.Text = "Background Color: #191919FF"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(-2, 8)
        Label17.Name = "Label17"
        Label17.Size = New Size(169, 20)
        Label17.TabIndex = 0
        Label17.Text = "Customize Appearance"
        ' 
        ' cldBackC
        ' 
        cldBackC.AllowFullOpen = False
        cldBackC.AnyColor = True
        cldBackC.Color = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        cldBackC.ShowHelp = True
        ' 
        ' FontDialog1
        ' 
        FontDialog1.AllowVectorFonts = False
        FontDialog1.AllowVerticalFonts = False
        FontDialog1.FontMustExist = True
        FontDialog1.ShowEffects = False
        FontDialog1.ShowHelp = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        ClientSize = New Size(800, 467)
        Controls.Add(pnlExtra)
        Controls.Add(pnlWait)
        Controls.Add(Label14)
        Controls.Add(pnlAbout)
        Controls.Add(pnlSettings)
        Controls.Add(lblPing)
        Controls.Add(Label5)
        Controls.Add(Panel3)
        Controls.Add(lvHistory)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(GroupBox1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Psyiantist Lace"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        pnlSettings.ResumeLayout(False)
        pnlSettings.PerformLayout()
        CType(trackbarOpacity, ComponentModel.ISupportInitialize).EndInit()
        pnlAbout.ResumeLayout(False)
        pnlScrollableAbout.ResumeLayout(False)
        pnlScrollableAbout.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlWait.ResumeLayout(False)
        pnlWait.PerformLayout()
        pnlExtra.ResumeLayout(False)
        pnlExtra.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lvHistory As ListView
    Friend WithEvents prompthistory As ColumnHeader
    Friend WithEvents btnSettings As Button
    Friend WithEvents responsehistory As ColumnHeader
    Friend WithEvents btnAbout As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSend As Button
    Friend WithEvents txtboxMsg As TextBox
    Friend WithEvents lblModelName As Label
    Friend WithEvents lblTrained As Label
    Friend WithEvents lblParamCount As Label
    Friend WithEvents lblModelType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPing As Label
    Friend WithEvents pinger As Timer
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbShowP As ComboBox
    Friend WithEvents cmbTypeAni As ComboBox
    Friend WithEvents pnlAbout As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents trackbarOpacity As TrackBar
    Friend WithEvents Label13 As Label
    Friend WithEvents lblOpac As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtboxResp As RichTextBox
    Friend WithEvents lblLoading As Label
    Friend WithEvents barProgress As ProgressBar
    Friend WithEvents pnlWait As Panel
    Friend WithEvents lblProgress As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnShowExtra As Button
    Friend WithEvents pnlExtra As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents lblBC As Label
    Friend WithEvents lblTFS As Label
    Friend WithEvents lblTC As Label
    Friend WithEvents cldBackC As ColorDialog
    Friend WithEvents btnFontChange As Button
    Friend WithEvents btnTextColorBlack As Button
    Friend WithEvents btnBackColorChange As Button
    Friend WithEvents btnTextColorWhite As Button
    Friend WithEvents btnTextColorGray As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents btnStreamline As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents scrollAbout As VScrollBar
    Friend WithEvents pnlScrollableAbout As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
