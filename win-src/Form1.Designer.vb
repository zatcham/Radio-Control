Imports System.IO
Imports Vlc.DotNet.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.VlcControl1 = New Vlc.DotNet.Forms.VlcControl()
        Me.MaterialCard10 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel23 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel22 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel21 = New MaterialSkin.Controls.MaterialLabel()
        Me.progHomeRVol = New MaterialSkin.Controls.MaterialProgressBar()
        Me.progHomeLVol = New MaterialSkin.Controls.MaterialProgressBar()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.lblHomePlaying = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.cbHomeMute = New MaterialSkin.Controls.MaterialCheckbox()
        Me.lblHomeVol = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.cboHomeStation = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnHomeExit = New MaterialSkin.Controls.MaterialButton()
        Me.trbVolume = New System.Windows.Forms.TrackBar()
        Me.btnHomeStop = New MaterialSkin.Controls.MaterialButton()
        Me.btnHomeRefresh = New MaterialSkin.Controls.MaterialButton()
        Me.btnHomePlay = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.swtHomePython = New MaterialSkin.Controls.MaterialSwitch()
        Me.swtHomePlayer = New MaterialSkin.Controls.MaterialSwitch()
        Me.swtHomeNet = New MaterialSkin.Controls.MaterialSwitch()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MaterialCard11 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel27 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel26 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnConfigAudRef = New MaterialSkin.Controls.MaterialButton()
        Me.lblConfigAudDevice = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel25 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel24 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard9 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel18 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnConfigEdit = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel17 = New MaterialSkin.Controls.MaterialLabel()
        Me.cboConfigColour = New MaterialSkin.Controls.MaterialComboBox()
        Me.swtConfigDark = New MaterialSkin.Controls.MaterialSwitch()
        Me.MaterialLabel16 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.btnUpdateDL = New MaterialSkin.Controls.MaterialButton()
        Me.lblUpdateProgress = New MaterialSkin.Controls.MaterialLabel()
        Me.lblLatestVer = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCurrentVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialProgressBar1 = New MaterialSkin.Controls.MaterialProgressBar()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.btnCheckUpdates = New MaterialSkin.Controls.MaterialButton()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel19 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnAboutSite = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel14 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel15 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel20 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        Me.lblPythonVer = New MaterialSkin.Controls.MaterialLabel()
        Me.lblBuildDate = New MaterialSkin.Controls.MaterialLabel()
        Me.lblVersion = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.tmrVolume = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWebUI = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard10.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.trbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.MaterialCard11.SuspendLayout()
        Me.MaterialCard9.SuspendLayout()
        Me.MaterialCard8.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MaterialCard7.SuspendLayout()
        Me.MaterialCard6.SuspendLayout()
        Me.MaterialCard5.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Radio Control"
        Me.NotifyIcon1.Visible = True
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 131)
        Me.MaterialTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.ShowToolTips = True
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1648, 863)
        Me.MaterialTabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.VlcControl1)
        Me.TabPage1.Controls.Add(Me.MaterialCard10)
        Me.TabPage1.Controls.Add(Me.MaterialCard3)
        Me.TabPage1.Controls.Add(Me.MaterialCard2)
        Me.TabPage1.Controls.Add(Me.MaterialCard1)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1632, 816)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'VlcControl1
        '
        Me.VlcControl1.BackColor = System.Drawing.Color.Black
        Me.VlcControl1.Location = New System.Drawing.Point(14, 342)
        Me.VlcControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.VlcControl1.Name = "VlcControl1"
        Me.VlcControl1.Size = New System.Drawing.Size(20, 19)
        Me.VlcControl1.Spu = -1
        Me.VlcControl1.TabIndex = 19
        Me.VlcControl1.Text = "VlcControl1"
        Me.VlcControl1.VlcLibDirectory = Nothing
        Me.VlcControl1.VlcMediaplayerOptions = Nothing
        AddHandler VlcControl1.VlcLibDirectoryNeeded, AddressOf LibNeeded
        '
        'MaterialCard10
        '
        Me.MaterialCard10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard10.Controls.Add(Me.MaterialLabel23)
        Me.MaterialCard10.Controls.Add(Me.MaterialLabel22)
        Me.MaterialCard10.Controls.Add(Me.MaterialLabel21)
        Me.MaterialCard10.Controls.Add(Me.progHomeRVol)
        Me.MaterialCard10.Controls.Add(Me.progHomeLVol)
        Me.MaterialCard10.Depth = 0
        Me.MaterialCard10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard10.Location = New System.Drawing.Point(14, 158)
        Me.MaterialCard10.Margin = New System.Windows.Forms.Padding(28, 27, 28, 27)
        Me.MaterialCard10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard10.Name = "MaterialCard10"
        Me.MaterialCard10.Padding = New System.Windows.Forms.Padding(28, 27, 28, 27)
        Me.MaterialCard10.Size = New System.Drawing.Size(900, 163)
        Me.MaterialCard10.TabIndex = 18
        '
        'MaterialLabel23
        '
        Me.MaterialLabel23.AutoSize = True
        Me.MaterialLabel23.Depth = 0
        Me.MaterialLabel23.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel23.Location = New System.Drawing.Point(18, 27)
        Me.MaterialLabel23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel23.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel23.Name = "MaterialLabel23"
        Me.MaterialLabel23.Size = New System.Drawing.Size(1, 0)
        Me.MaterialLabel23.TabIndex = 21
        '
        'MaterialLabel22
        '
        Me.MaterialLabel22.AutoSize = True
        Me.MaterialLabel22.Depth = 0
        Me.MaterialLabel22.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel22.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel22.Location = New System.Drawing.Point(34, 92)
        Me.MaterialLabel22.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel22.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel22.Name = "MaterialLabel22"
        Me.MaterialLabel22.Size = New System.Drawing.Size(13, 24)
        Me.MaterialLabel22.TabIndex = 3
        Me.MaterialLabel22.Text = "R"
        '
        'MaterialLabel21
        '
        Me.MaterialLabel21.AutoSize = True
        Me.MaterialLabel21.Depth = 0
        Me.MaterialLabel21.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel21.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel21.Location = New System.Drawing.Point(34, 8)
        Me.MaterialLabel21.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel21.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel21.Name = "MaterialLabel21"
        Me.MaterialLabel21.Size = New System.Drawing.Size(12, 24)
        Me.MaterialLabel21.TabIndex = 2
        Me.MaterialLabel21.Text = "L"
        '
        'progHomeRVol
        '
        Me.progHomeRVol.Depth = 0
        Me.progHomeRVol.Location = New System.Drawing.Point(100, 112)
        Me.progHomeRVol.Margin = New System.Windows.Forms.Padding(6)
        Me.progHomeRVol.MouseState = MaterialSkin.MouseState.HOVER
        Me.progHomeRVol.Name = "progHomeRVol"
        Me.progHomeRVol.Size = New System.Drawing.Size(766, 5)
        Me.progHomeRVol.TabIndex = 1
        '
        'progHomeLVol
        '
        Me.progHomeLVol.Depth = 0
        Me.progHomeLVol.Location = New System.Drawing.Point(100, 27)
        Me.progHomeLVol.Margin = New System.Windows.Forms.Padding(6)
        Me.progHomeLVol.MouseState = MaterialSkin.MouseState.HOVER
        Me.progHomeLVol.Name = "progHomeLVol"
        Me.progHomeLVol.Size = New System.Drawing.Size(766, 5)
        Me.progHomeLVol.TabIndex = 0
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.lblHomePlaying)
        Me.MaterialCard3.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(14, 17)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard3.Size = New System.Drawing.Size(900, 100)
        Me.MaterialCard3.TabIndex = 17
        '
        'lblHomePlaying
        '
        Me.lblHomePlaying.AutoSize = True
        Me.lblHomePlaying.Depth = 0
        Me.lblHomePlaying.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHomePlaying.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.lblHomePlaying.Location = New System.Drawing.Point(422, 13)
        Me.lblHomePlaying.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHomePlaying.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHomePlaying.Name = "lblHomePlaying"
        Me.lblHomePlaying.Size = New System.Drawing.Size(100, 29)
        Me.lblHomePlaying.TabIndex = 16
        Me.lblHomePlaying.Text = "Unknown"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel1.Location = New System.Drawing.Point(16, 13)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(186, 29)
        Me.MaterialLabel1.TabIndex = 15
        Me.MaterialLabel1.Text = "Currently Playing:"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.cbHomeMute)
        Me.MaterialCard2.Controls.Add(Me.lblHomeVol)
        Me.MaterialCard2.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard2.Controls.Add(Me.cboHomeStation)
        Me.MaterialCard2.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard2.Controls.Add(Me.btnHomeExit)
        Me.MaterialCard2.Controls.Add(Me.trbVolume)
        Me.MaterialCard2.Controls.Add(Me.btnHomeStop)
        Me.MaterialCard2.Controls.Add(Me.btnHomeRefresh)
        Me.MaterialCard2.Controls.Add(Me.btnHomePlay)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(942, 17)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard2.Size = New System.Drawing.Size(672, 500)
        Me.MaterialCard2.TabIndex = 16
        '
        'cbHomeMute
        '
        Me.cbHomeMute.AutoSize = True
        Me.cbHomeMute.Depth = 0
        Me.cbHomeMute.Location = New System.Drawing.Point(22, 298)
        Me.cbHomeMute.Margin = New System.Windows.Forms.Padding(0)
        Me.cbHomeMute.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cbHomeMute.MouseState = MaterialSkin.MouseState.HOVER
        Me.cbHomeMute.Name = "cbHomeMute"
        Me.cbHomeMute.Ripple = True
        Me.cbHomeMute.Size = New System.Drawing.Size(71, 37)
        Me.cbHomeMute.TabIndex = 20
        Me.cbHomeMute.Text = "Mute"
        Me.cbHomeMute.UseVisualStyleBackColor = True
        '
        'lblHomeVol
        '
        Me.lblHomeVol.AutoSize = True
        Me.lblHomeVol.Depth = 0
        Me.lblHomeVol.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHomeVol.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.lblHomeVol.Location = New System.Drawing.Point(480, 233)
        Me.lblHomeVol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHomeVol.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHomeVol.Name = "lblHomeVol"
        Me.lblHomeVol.Size = New System.Drawing.Size(8, 14)
        Me.lblHomeVol.TabIndex = 19
        Me.lblHomeVol.Text = "0"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel4.Location = New System.Drawing.Point(10, 179)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(74, 24)
        Me.MaterialLabel4.TabIndex = 18
        Me.MaterialLabel4.Text = "Volume:"
        '
        'cboHomeStation
        '
        Me.cboHomeStation.AutoResize = False
        Me.cboHomeStation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboHomeStation.Depth = 0
        Me.cboHomeStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboHomeStation.DropDownHeight = 174
        Me.cboHomeStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHomeStation.DropDownWidth = 121
        Me.cboHomeStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboHomeStation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboHomeStation.FormattingEnabled = True
        Me.cboHomeStation.IntegralHeight = False
        Me.cboHomeStation.ItemHeight = 43
        Me.cboHomeStation.Location = New System.Drawing.Point(18, 63)
        Me.cboHomeStation.Margin = New System.Windows.Forms.Padding(4)
        Me.cboHomeStation.MaxDropDownItems = 4
        Me.cboHomeStation.MouseState = MaterialSkin.MouseState.OUT
        Me.cboHomeStation.Name = "cboHomeStation"
        Me.cboHomeStation.Size = New System.Drawing.Size(598, 49)
        Me.cboHomeStation.TabIndex = 12
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel3.Location = New System.Drawing.Point(14, 13)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(142, 24)
        Me.MaterialLabel3.TabIndex = 17
        Me.MaterialLabel3.Text = "Choose Station:"
        '
        'btnHomeExit
        '
        Me.btnHomeExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHomeExit.Depth = 0
        Me.btnHomeExit.DrawShadows = True
        Me.btnHomeExit.HighEmphasis = True
        Me.btnHomeExit.Icon = Nothing
        Me.btnHomeExit.Location = New System.Drawing.Point(374, 412)
        Me.btnHomeExit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHomeExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHomeExit.Name = "btnHomeExit"
        Me.btnHomeExit.Size = New System.Drawing.Size(52, 36)
        Me.btnHomeExit.TabIndex = 17
        Me.btnHomeExit.Text = "Exit"
        Me.btnHomeExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnHomeExit.UseAccentColor = False
        Me.btnHomeExit.UseVisualStyleBackColor = True
        '
        'trbVolume
        '
        Me.trbVolume.AutoSize = False
        Me.trbVolume.LargeChange = 10
        Me.trbVolume.Location = New System.Drawing.Point(18, 225)
        Me.trbVolume.Margin = New System.Windows.Forms.Padding(4)
        Me.trbVolume.Maximum = 100
        Me.trbVolume.Name = "trbVolume"
        Me.trbVolume.Size = New System.Drawing.Size(412, 48)
        Me.trbVolume.SmallChange = 10
        Me.trbVolume.TabIndex = 13
        Me.trbVolume.TickFrequency = 10
        '
        'btnHomeStop
        '
        Me.btnHomeStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHomeStop.Depth = 0
        Me.btnHomeStop.DrawShadows = True
        Me.btnHomeStop.HighEmphasis = True
        Me.btnHomeStop.Icon = Nothing
        Me.btnHomeStop.Location = New System.Drawing.Point(142, 412)
        Me.btnHomeStop.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHomeStop.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHomeStop.Name = "btnHomeStop"
        Me.btnHomeStop.Size = New System.Drawing.Size(58, 36)
        Me.btnHomeStop.TabIndex = 16
        Me.btnHomeStop.Text = "Stop"
        Me.btnHomeStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnHomeStop.UseAccentColor = False
        Me.btnHomeStop.UseVisualStyleBackColor = True
        '
        'btnHomeRefresh
        '
        Me.btnHomeRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHomeRefresh.Depth = 0
        Me.btnHomeRefresh.DrawShadows = True
        Me.btnHomeRefresh.HighEmphasis = True
        Me.btnHomeRefresh.Icon = Nothing
        Me.btnHomeRefresh.Location = New System.Drawing.Point(486, 412)
        Me.btnHomeRefresh.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHomeRefresh.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHomeRefresh.Name = "btnHomeRefresh"
        Me.btnHomeRefresh.Size = New System.Drawing.Size(84, 36)
        Me.btnHomeRefresh.TabIndex = 15
        Me.btnHomeRefresh.Text = "Refresh"
        Me.btnHomeRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnHomeRefresh.UseAccentColor = False
        Me.btnHomeRefresh.UseVisualStyleBackColor = True
        '
        'btnHomePlay
        '
        Me.btnHomePlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHomePlay.Depth = 0
        Me.btnHomePlay.DrawShadows = True
        Me.btnHomePlay.HighEmphasis = True
        Me.btnHomePlay.Icon = Nothing
        Me.btnHomePlay.Location = New System.Drawing.Point(18, 412)
        Me.btnHomePlay.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHomePlay.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHomePlay.Name = "btnHomePlay"
        Me.btnHomePlay.Size = New System.Drawing.Size(57, 36)
        Me.btnHomePlay.TabIndex = 12
        Me.btnHomePlay.Text = "Play"
        Me.btnHomePlay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnHomePlay.UseAccentColor = False
        Me.btnHomePlay.UseVisualStyleBackColor = True
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel7)
        Me.MaterialCard1.Controls.Add(Me.swtHomePython)
        Me.MaterialCard1.Controls.Add(Me.swtHomePlayer)
        Me.MaterialCard1.Controls.Add(Me.swtHomeNet)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel6)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(942, 544)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard1.Size = New System.Drawing.Size(672, 252)
        Me.MaterialCard1.TabIndex = 15
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel7.Location = New System.Drawing.Point(10, 163)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(83, 24)
        Me.MaterialLabel7.TabIndex = 20
        Me.MaterialLabel7.Text = "Backend:"
        '
        'swtHomePython
        '
        Me.swtHomePython.AutoSize = True
        Me.swtHomePython.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.swtHomePython.Checked = True
        Me.swtHomePython.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.swtHomePython.Depth = 0
        Me.swtHomePython.Enabled = False
        Me.swtHomePython.Location = New System.Drawing.Point(542, 163)
        Me.swtHomePython.Margin = New System.Windows.Forms.Padding(0)
        Me.swtHomePython.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtHomePython.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtHomePython.Name = "swtHomePython"
        Me.swtHomePython.Ripple = True
        Me.swtHomePython.Size = New System.Drawing.Size(58, 37)
        Me.swtHomePython.TabIndex = 10
        Me.swtHomePython.UseVisualStyleBackColor = True
        '
        'swtHomePlayer
        '
        Me.swtHomePlayer.AutoSize = True
        Me.swtHomePlayer.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.swtHomePlayer.Checked = True
        Me.swtHomePlayer.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.swtHomePlayer.Depth = 0
        Me.swtHomePlayer.Enabled = False
        Me.swtHomePlayer.Location = New System.Drawing.Point(542, 92)
        Me.swtHomePlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.swtHomePlayer.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtHomePlayer.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtHomePlayer.Name = "swtHomePlayer"
        Me.swtHomePlayer.Ripple = True
        Me.swtHomePlayer.Size = New System.Drawing.Size(58, 37)
        Me.swtHomePlayer.TabIndex = 9
        Me.swtHomePlayer.UseVisualStyleBackColor = True
        '
        'swtHomeNet
        '
        Me.swtHomeNet.AutoSize = True
        Me.swtHomeNet.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.swtHomeNet.Checked = True
        Me.swtHomeNet.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.swtHomeNet.Depth = 0
        Me.swtHomeNet.Enabled = False
        Me.swtHomeNet.Location = New System.Drawing.Point(542, 21)
        Me.swtHomeNet.Margin = New System.Windows.Forms.Padding(0)
        Me.swtHomeNet.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtHomeNet.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtHomeNet.Name = "swtHomeNet"
        Me.swtHomeNet.Ripple = True
        Me.swtHomeNet.Size = New System.Drawing.Size(58, 37)
        Me.swtHomeNet.TabIndex = 8
        Me.swtHomeNet.UseVisualStyleBackColor = True
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel6.Location = New System.Drawing.Point(10, 92)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(124, 24)
        Me.MaterialLabel6.TabIndex = 19
        Me.MaterialLabel6.Text = "Media Player:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel5.Location = New System.Drawing.Point(10, 21)
        Me.MaterialLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(81, 24)
        Me.MaterialLabel5.TabIndex = 18
        Me.MaterialLabel5.Text = "Network:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MaterialCard11)
        Me.TabPage3.Controls.Add(Me.MaterialCard9)
        Me.TabPage3.Controls.Add(Me.MaterialCard8)
        Me.TabPage3.Location = New System.Drawing.Point(8, 39)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1632, 816)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MaterialCard11
        '
        Me.MaterialCard11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard11.Controls.Add(Me.MaterialLabel27)
        Me.MaterialCard11.Controls.Add(Me.MaterialLabel26)
        Me.MaterialCard11.Controls.Add(Me.btnConfigAudRef)
        Me.MaterialCard11.Controls.Add(Me.lblConfigAudDevice)
        Me.MaterialCard11.Controls.Add(Me.MaterialLabel25)
        Me.MaterialCard11.Controls.Add(Me.MaterialLabel24)
        Me.MaterialCard11.Depth = 0
        Me.MaterialCard11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard11.Location = New System.Drawing.Point(4, 462)
        Me.MaterialCard11.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard11.Name = "MaterialCard11"
        Me.MaterialCard11.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard11.Size = New System.Drawing.Size(1154, 298)
        Me.MaterialCard11.TabIndex = 5
        '
        'MaterialLabel27
        '
        Me.MaterialLabel27.AutoSize = True
        Me.MaterialLabel27.Depth = 0
        Me.MaterialLabel27.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel27.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel27.Location = New System.Drawing.Point(330, 156)
        Me.MaterialLabel27.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel27.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel27.Name = "MaterialLabel27"
        Me.MaterialLabel27.Size = New System.Drawing.Size(30, 19)
        Me.MaterialLabel27.TabIndex = 9
        Me.MaterialLabel27.Text = "VLC"
        '
        'MaterialLabel26
        '
        Me.MaterialLabel26.AutoSize = True
        Me.MaterialLabel26.Depth = 0
        Me.MaterialLabel26.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel26.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel26.Location = New System.Drawing.Point(12, 156)
        Me.MaterialLabel26.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel26.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel26.Name = "MaterialLabel26"
        Me.MaterialLabel26.Size = New System.Drawing.Size(97, 19)
        Me.MaterialLabel26.TabIndex = 8
        Me.MaterialLabel26.Text = "Media Player:"
        '
        'btnConfigAudRef
        '
        Me.btnConfigAudRef.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConfigAudRef.Depth = 0
        Me.btnConfigAudRef.DrawShadows = True
        Me.btnConfigAudRef.HighEmphasis = True
        Me.btnConfigAudRef.Icon = Nothing
        Me.btnConfigAudRef.Location = New System.Drawing.Point(22, 204)
        Me.btnConfigAudRef.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        Me.btnConfigAudRef.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfigAudRef.Name = "btnConfigAudRef"
        Me.btnConfigAudRef.Size = New System.Drawing.Size(84, 36)
        Me.btnConfigAudRef.TabIndex = 7
        Me.btnConfigAudRef.Text = "Refresh"
        Me.btnConfigAudRef.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnConfigAudRef.UseAccentColor = False
        Me.btnConfigAudRef.UseVisualStyleBackColor = True
        '
        'lblConfigAudDevice
        '
        Me.lblConfigAudDevice.AutoSize = True
        Me.lblConfigAudDevice.Depth = 0
        Me.lblConfigAudDevice.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblConfigAudDevice.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.lblConfigAudDevice.Location = New System.Drawing.Point(330, 94)
        Me.lblConfigAudDevice.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblConfigAudDevice.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblConfigAudDevice.Name = "lblConfigAudDevice"
        Me.lblConfigAudDevice.Size = New System.Drawing.Size(67, 19)
        Me.lblConfigAudDevice.TabIndex = 6
        Me.lblConfigAudDevice.Text = "Unknown"
        '
        'MaterialLabel25
        '
        Me.MaterialLabel25.AutoSize = True
        Me.MaterialLabel25.Depth = 0
        Me.MaterialLabel25.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel25.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel25.Location = New System.Drawing.Point(12, 94)
        Me.MaterialLabel25.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel25.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel25.Name = "MaterialLabel25"
        Me.MaterialLabel25.Size = New System.Drawing.Size(152, 19)
        Me.MaterialLabel25.TabIndex = 5
        Me.MaterialLabel25.Text = "Current Audio Device:"
        '
        'MaterialLabel24
        '
        Me.MaterialLabel24.AutoSize = True
        Me.MaterialLabel24.Depth = 0
        Me.MaterialLabel24.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel24.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel24.Location = New System.Drawing.Point(18, 13)
        Me.MaterialLabel24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel24.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel24.Name = "MaterialLabel24"
        Me.MaterialLabel24.Size = New System.Drawing.Size(70, 29)
        Me.MaterialLabel24.TabIndex = 4
        Me.MaterialLabel24.Text = "Audio:"
        '
        'MaterialCard9
        '
        Me.MaterialCard9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard9.Controls.Add(Me.MaterialLabel18)
        Me.MaterialCard9.Controls.Add(Me.btnConfigEdit)
        Me.MaterialCard9.Depth = 0
        Me.MaterialCard9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard9.Location = New System.Drawing.Point(984, 4)
        Me.MaterialCard9.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard9.Name = "MaterialCard9"
        Me.MaterialCard9.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard9.Size = New System.Drawing.Size(634, 431)
        Me.MaterialCard9.TabIndex = 2
        '
        'MaterialLabel18
        '
        Me.MaterialLabel18.AutoSize = True
        Me.MaterialLabel18.Depth = 0
        Me.MaterialLabel18.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel18.Location = New System.Drawing.Point(18, 13)
        Me.MaterialLabel18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel18.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel18.Name = "MaterialLabel18"
        Me.MaterialLabel18.Size = New System.Drawing.Size(69, 29)
        Me.MaterialLabel18.TabIndex = 4
        Me.MaterialLabel18.Text = "Radio:"
        '
        'btnConfigEdit
        '
        Me.btnConfigEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConfigEdit.Depth = 0
        Me.btnConfigEdit.DrawShadows = True
        Me.btnConfigEdit.HighEmphasis = True
        Me.btnConfigEdit.Icon = Nothing
        Me.btnConfigEdit.Location = New System.Drawing.Point(18, 98)
        Me.btnConfigEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnConfigEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConfigEdit.Name = "btnConfigEdit"
        Me.btnConfigEdit.Size = New System.Drawing.Size(142, 36)
        Me.btnConfigEdit.TabIndex = 0
        Me.btnConfigEdit.Text = "Edit Config File"
        Me.btnConfigEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnConfigEdit.UseAccentColor = False
        Me.btnConfigEdit.UseVisualStyleBackColor = True
        '
        'MaterialCard8
        '
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel17)
        Me.MaterialCard8.Controls.Add(Me.cboConfigColour)
        Me.MaterialCard8.Controls.Add(Me.swtConfigDark)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel16)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(4, 4)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard8.Size = New System.Drawing.Size(644, 431)
        Me.MaterialCard8.TabIndex = 1
        '
        'MaterialLabel17
        '
        Me.MaterialLabel17.AutoSize = True
        Me.MaterialLabel17.Depth = 0
        Me.MaterialLabel17.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel17.Location = New System.Drawing.Point(20, 240)
        Me.MaterialLabel17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel17.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel17.Name = "MaterialLabel17"
        Me.MaterialLabel17.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel17.TabIndex = 3
        Me.MaterialLabel17.Text = "Colour Scheme:"
        '
        'cboConfigColour
        '
        Me.cboConfigColour.AutoResize = False
        Me.cboConfigColour.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboConfigColour.Depth = 0
        Me.cboConfigColour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboConfigColour.DropDownHeight = 174
        Me.cboConfigColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConfigColour.DropDownWidth = 121
        Me.cboConfigColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboConfigColour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboConfigColour.FormattingEnabled = True
        Me.cboConfigColour.IntegralHeight = False
        Me.cboConfigColour.ItemHeight = 43
        Me.cboConfigColour.Items.AddRange(New Object() {"Blue", "Green"})
        Me.cboConfigColour.Location = New System.Drawing.Point(286, 208)
        Me.cboConfigColour.Margin = New System.Windows.Forms.Padding(4)
        Me.cboConfigColour.MaxDropDownItems = 4
        Me.cboConfigColour.MouseState = MaterialSkin.MouseState.OUT
        Me.cboConfigColour.Name = "cboConfigColour"
        Me.cboConfigColour.Size = New System.Drawing.Size(336, 49)
        Me.cboConfigColour.TabIndex = 2
        '
        'swtConfigDark
        '
        Me.swtConfigDark.AutoSize = True
        Me.swtConfigDark.Depth = 0
        Me.swtConfigDark.Location = New System.Drawing.Point(18, 94)
        Me.swtConfigDark.Margin = New System.Windows.Forms.Padding(0)
        Me.swtConfigDark.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.swtConfigDark.MouseState = MaterialSkin.MouseState.HOVER
        Me.swtConfigDark.Name = "swtConfigDark"
        Me.swtConfigDark.Ripple = True
        Me.swtConfigDark.Size = New System.Drawing.Size(135, 37)
        Me.swtConfigDark.TabIndex = 1
        Me.swtConfigDark.Text = "Dark Mode"
        Me.swtConfigDark.UseVisualStyleBackColor = True
        '
        'MaterialLabel16
        '
        Me.MaterialLabel16.AutoSize = True
        Me.MaterialLabel16.Depth = 0
        Me.MaterialLabel16.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel16.Location = New System.Drawing.Point(18, 13)
        Me.MaterialLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel16.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel16.Name = "MaterialLabel16"
        Me.MaterialLabel16.Size = New System.Drawing.Size(84, 29)
        Me.MaterialLabel16.TabIndex = 0
        Me.MaterialLabel16.Text = "Display:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MaterialCard4)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1632, 816)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check for Updates"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.btnUpdateDL)
        Me.MaterialCard4.Controls.Add(Me.lblUpdateProgress)
        Me.MaterialCard4.Controls.Add(Me.lblLatestVer)
        Me.MaterialCard4.Controls.Add(Me.lblCurrentVersion)
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel10)
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard4.Controls.Add(Me.MaterialProgressBar1)
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel8)
        Me.MaterialCard4.Controls.Add(Me.lblInfo)
        Me.MaterialCard4.Controls.Add(Me.btnCheckUpdates)
        Me.MaterialCard4.Controls.Add(Me.lblProgress)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(16, 17)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard4.Size = New System.Drawing.Size(1572, 590)
        Me.MaterialCard4.TabIndex = 1
        '
        'btnUpdateDL
        '
        Me.btnUpdateDL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdateDL.Depth = 0
        Me.btnUpdateDL.DrawShadows = True
        Me.btnUpdateDL.HighEmphasis = True
        Me.btnUpdateDL.Icon = Nothing
        Me.btnUpdateDL.Location = New System.Drawing.Point(1218, 100)
        Me.btnUpdateDL.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdateDL.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdateDL.Name = "btnUpdateDL"
        Me.btnUpdateDL.Size = New System.Drawing.Size(102, 36)
        Me.btnUpdateDL.TabIndex = 30
        Me.btnUpdateDL.Text = "Download"
        Me.btnUpdateDL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUpdateDL.UseAccentColor = False
        Me.btnUpdateDL.UseVisualStyleBackColor = True
        '
        'lblUpdateProgress
        '
        Me.lblUpdateProgress.AutoSize = True
        Me.lblUpdateProgress.Depth = 0
        Me.lblUpdateProgress.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblUpdateProgress.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.lblUpdateProgress.Location = New System.Drawing.Point(454, 458)
        Me.lblUpdateProgress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpdateProgress.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblUpdateProgress.Name = "lblUpdateProgress"
        Me.lblUpdateProgress.Size = New System.Drawing.Size(57, 17)
        Me.lblUpdateProgress.TabIndex = 29
        Me.lblUpdateProgress.Text = "Progress"
        '
        'lblLatestVer
        '
        Me.lblLatestVer.AutoSize = True
        Me.lblLatestVer.Depth = 0
        Me.lblLatestVer.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblLatestVer.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.lblLatestVer.Location = New System.Drawing.Point(396, 210)
        Me.lblLatestVer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLatestVer.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLatestVer.Name = "lblLatestVer"
        Me.lblLatestVer.Size = New System.Drawing.Size(12, 24)
        Me.lblLatestVer.TabIndex = 28
        Me.lblLatestVer.Text = "0"
        '
        'lblCurrentVersion
        '
        Me.lblCurrentVersion.AutoSize = True
        Me.lblCurrentVersion.Depth = 0
        Me.lblCurrentVersion.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCurrentVersion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.lblCurrentVersion.Location = New System.Drawing.Point(396, 123)
        Me.lblCurrentVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCurrentVersion.Name = "lblCurrentVersion"
        Me.lblCurrentVersion.Size = New System.Drawing.Size(12, 24)
        Me.lblCurrentVersion.TabIndex = 27
        Me.lblCurrentVersion.Text = "0"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel10.Location = New System.Drawing.Point(16, 210)
        Me.MaterialLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(136, 24)
        Me.MaterialLabel10.TabIndex = 26
        Me.MaterialLabel10.Text = "Latest Version:"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel9.Location = New System.Drawing.Point(16, 123)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(146, 24)
        Me.MaterialLabel9.TabIndex = 25
        Me.MaterialLabel9.Text = "Current Version:"
        '
        'MaterialProgressBar1
        '
        Me.MaterialProgressBar1.Depth = 0
        Me.MaterialProgressBar1.Location = New System.Drawing.Point(164, 429)
        Me.MaterialProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialProgressBar1.Name = "MaterialProgressBar1"
        Me.MaterialProgressBar1.Size = New System.Drawing.Size(724, 5)
        Me.MaterialProgressBar1.TabIndex = 24
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel8.Location = New System.Drawing.Point(16, 13)
        Me.MaterialLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(199, 29)
        Me.MaterialLabel8.TabIndex = 23
        Me.MaterialLabel8.Text = "Check for Updates"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Depth = 0
        Me.lblInfo.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblInfo.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.lblInfo.Location = New System.Drawing.Point(1218, 210)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(116, 24)
        Me.lblInfo.TabIndex = 22
        Me.lblInfo.Text = "Downloading"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckUpdates
        '
        Me.btnCheckUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCheckUpdates.Depth = 0
        Me.btnCheckUpdates.DrawShadows = True
        Me.btnCheckUpdates.HighEmphasis = True
        Me.btnCheckUpdates.Icon = Nothing
        Me.btnCheckUpdates.Location = New System.Drawing.Point(1218, 13)
        Me.btnCheckUpdates.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCheckUpdates.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCheckUpdates.Name = "btnCheckUpdates"
        Me.btnCheckUpdates.Size = New System.Drawing.Size(168, 36)
        Me.btnCheckUpdates.TabIndex = 21
        Me.btnCheckUpdates.Text = "Check for Updates"
        Me.btnCheckUpdates.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCheckUpdates.UseAccentColor = False
        Me.btnCheckUpdates.UseVisualStyleBackColor = True
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI Light", 10.125!)
        Me.lblProgress.Location = New System.Drawing.Point(148, 458)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(23, 37)
        Me.lblProgress.TabIndex = 19
        Me.lblProgress.Text = "."
        Me.lblProgress.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.MaterialCard7)
        Me.TabPage4.Controls.Add(Me.MaterialCard6)
        Me.TabPage4.Controls.Add(Me.MaterialCard5)
        Me.TabPage4.Location = New System.Drawing.Point(8, 39)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1632, 816)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "About"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'MaterialCard7
        '
        Me.MaterialCard7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard7.Controls.Add(Me.MaterialLabel19)
        Me.MaterialCard7.Controls.Add(Me.btnAboutSite)
        Me.MaterialCard7.Controls.Add(Me.MaterialLabel14)
        Me.MaterialCard7.Controls.Add(Me.MaterialLabel15)
        Me.MaterialCard7.Depth = 0
        Me.MaterialCard7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard7.Location = New System.Drawing.Point(36, 533)
        Me.MaterialCard7.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard7.Name = "MaterialCard7"
        Me.MaterialCard7.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard7.Size = New System.Drawing.Size(1562, 210)
        Me.MaterialCard7.TabIndex = 2
        '
        'MaterialLabel19
        '
        Me.MaterialLabel19.AutoSize = True
        Me.MaterialLabel19.Depth = 0
        Me.MaterialLabel19.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel19.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel19.Location = New System.Drawing.Point(16, 144)
        Me.MaterialLabel19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel19.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel19.Name = "MaterialLabel19"
        Me.MaterialLabel19.Size = New System.Drawing.Size(256, 24)
        Me.MaterialLabel19.TabIndex = 9
        Me.MaterialLabel19.Text = "Web Controls: Tom Sangster"
        '
        'btnAboutSite
        '
        Me.btnAboutSite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAboutSite.Depth = 0
        Me.btnAboutSite.DrawShadows = True
        Me.btnAboutSite.HighEmphasis = True
        Me.btnAboutSite.Icon = Nothing
        Me.btnAboutSite.Location = New System.Drawing.Point(1348, 121)
        Me.btnAboutSite.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAboutSite.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAboutSite.Name = "btnAboutSite"
        Me.btnAboutSite.Size = New System.Drawing.Size(98, 36)
        Me.btnAboutSite.TabIndex = 8
        Me.btnAboutSite.Text = "Go to Site"
        Me.btnAboutSite.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAboutSite.UseAccentColor = False
        Me.btnAboutSite.UseVisualStyleBackColor = True
        '
        'MaterialLabel14
        '
        Me.MaterialLabel14.AutoSize = True
        Me.MaterialLabel14.Depth = 0
        Me.MaterialLabel14.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel14.Location = New System.Drawing.Point(1068, 13)
        Me.MaterialLabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel14.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel14.Name = "MaterialLabel14"
        Me.MaterialLabel14.Size = New System.Drawing.Size(238, 24)
        Me.MaterialLabel14.TabIndex = 7
        Me.MaterialLabel14.Text = "http://zachmatcham.co.uk"
        '
        'MaterialLabel15
        '
        Me.MaterialLabel15.AutoSize = True
        Me.MaterialLabel15.Depth = 0
        Me.MaterialLabel15.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel15.Location = New System.Drawing.Point(18, 13)
        Me.MaterialLabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel15.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel15.Name = "MaterialLabel15"
        Me.MaterialLabel15.Size = New System.Drawing.Size(163, 24)
        Me.MaterialLabel15.TabIndex = 6
        Me.MaterialLabel15.Text = "By Zach Matcham"
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.MaterialLabel20)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(976, 13)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard6.Size = New System.Drawing.Size(622, 423)
        Me.MaterialCard6.TabIndex = 1
        '
        'MaterialLabel20
        '
        Me.MaterialLabel20.AllowDrop = True
        Me.MaterialLabel20.Depth = 0
        Me.MaterialLabel20.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel20.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.MaterialLabel20.Location = New System.Drawing.Point(22, 21)
        Me.MaterialLabel20.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MaterialLabel20.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel20.Name = "MaterialLabel20"
        Me.MaterialLabel20.Size = New System.Drawing.Size(582, 363)
        Me.MaterialLabel20.TabIndex = 0
        Me.MaterialLabel20.Text = resources.GetString("MaterialLabel20.Text")
        '
        'MaterialCard5
        '
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.lblPythonVer)
        Me.MaterialCard5.Controls.Add(Me.lblBuildDate)
        Me.MaterialCard5.Controls.Add(Me.lblVersion)
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel13)
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel12)
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel11)
        Me.MaterialCard5.Depth = 0
        Me.MaterialCard5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard5.Location = New System.Drawing.Point(36, 13)
        Me.MaterialCard5.Margin = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard5.Name = "MaterialCard5"
        Me.MaterialCard5.Padding = New System.Windows.Forms.Padding(14, 13, 14, 13)
        Me.MaterialCard5.Size = New System.Drawing.Size(622, 423)
        Me.MaterialCard5.TabIndex = 0
        '
        'lblPythonVer
        '
        Me.lblPythonVer.AutoSize = True
        Me.lblPythonVer.Depth = 0
        Me.lblPythonVer.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblPythonVer.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.lblPythonVer.Location = New System.Drawing.Point(346, 338)
        Me.lblPythonVer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPythonVer.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPythonVer.Name = "lblPythonVer"
        Me.lblPythonVer.Size = New System.Drawing.Size(12, 24)
        Me.lblPythonVer.TabIndex = 5
        Me.lblPythonVer.Text = "0"
        '
        'lblBuildDate
        '
        Me.lblBuildDate.AutoSize = True
        Me.lblBuildDate.Depth = 0
        Me.lblBuildDate.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBuildDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.lblBuildDate.Location = New System.Drawing.Point(346, 167)
        Me.lblBuildDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuildDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBuildDate.Name = "lblBuildDate"
        Me.lblBuildDate.Size = New System.Drawing.Size(12, 24)
        Me.lblBuildDate.TabIndex = 4
        Me.lblBuildDate.Text = "0"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Depth = 0
        Me.lblVersion.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblVersion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.lblVersion.Location = New System.Drawing.Point(346, 13)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(12, 24)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "0"
        '
        'MaterialLabel13
        '
        Me.MaterialLabel13.AutoSize = True
        Me.MaterialLabel13.Depth = 0
        Me.MaterialLabel13.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel13.Location = New System.Drawing.Point(16, 338)
        Me.MaterialLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel13.Name = "MaterialLabel13"
        Me.MaterialLabel13.Size = New System.Drawing.Size(156, 24)
        Me.MaterialLabel13.TabIndex = 2
        Me.MaterialLabel13.Text = "Backend Version:"
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel12.Location = New System.Drawing.Point(16, 167)
        Me.MaterialLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(98, 24)
        Me.MaterialLabel12.TabIndex = 1
        Me.MaterialLabel12.Text = "Build Date:"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel11.Location = New System.Drawing.Point(16, 13)
        Me.MaterialLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(74, 24)
        Me.MaterialLabel11.TabIndex = 0
        Me.MaterialLabel11.Text = "Version:"
        '
        'tmrVolume
        '
        Me.tmrVolume.Enabled = True
        Me.tmrVolume.Interval = 50
        '
        'tmrWebUI
        '
        Me.tmrWebUI.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1678, 933)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard10.ResumeLayout(False)
        Me.MaterialCard10.PerformLayout()
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        CType(Me.trbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.MaterialCard11.ResumeLayout(False)
        Me.MaterialCard11.PerformLayout()
        Me.MaterialCard9.ResumeLayout(False)
        Me.MaterialCard9.PerformLayout()
        Me.MaterialCard8.ResumeLayout(False)
        Me.MaterialCard8.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.MaterialCard7.ResumeLayout(False)
        Me.MaterialCard7.PerformLayout()
        Me.MaterialCard6.ResumeLayout(False)
        Me.MaterialCard5.ResumeLayout(False)
        Me.MaterialCard5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public Sub LibNeeded(ByVal Sender As Object, ByVal e As VlcLibDirectoryNeededEventArgs)
        Dim aP As String
        If Environment.Is64BitOperatingSystem Then
            'aP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "VideoLAN\VLC")
            aP = Path.Combine(FilePath, "libvlc/win-x64")
        Else
            'aP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "VideoLAN\VLC")
            aP = Path.Combine(FilePath, "libvlc/win-x86")
        End If
        If Not File.Exists(Path.Combine(aP, "libvlc.dll")) Then
            Using fbdDialog As New FolderBrowserDialog()
                fbdDialog.Description = "Select VLC Path"
                fbdDialog.SelectedPath = Path.Combine(aP, "VideoLAN\VLC")
                If fbdDialog.ShowDialog() = DialogResult.OK Then
                    e.VlcLibDirectory = New DirectoryInfo(fbdDialog.SelectedPath)
                End If
            End Using
        Else
            e.VlcLibDirectory = New DirectoryInfo(aP)
        End If
    End Sub


    Friend WithEvents Label1 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblHomePlaying As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cboHomeStation As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnHomeExit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents trbVolume As TrackBar
    Friend WithEvents btnHomeStop As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnHomeRefresh As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnHomePlay As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents swtHomePython As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents swtHomePlayer As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents swtHomeNet As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblProgress As Label
    Friend WithEvents btnConfigEdit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCheckUpdates As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialProgressBar1 As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents lblLatestVer As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCurrentVersion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel15 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblPythonVer As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblBuildDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblVersion As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnAboutSite As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel14 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents swtConfigDark As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents MaterialLabel16 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel17 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cboConfigColour As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialCard9 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel18 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblUpdateProgress As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel19 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel20 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnUpdateDL As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblHomeVol As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tmrVolume As Timer
    Friend WithEvents cbHomeMute As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCard10 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents progHomeLVol As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents progHomeRVol As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents MaterialLabel22 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel21 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel23 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard11 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btnConfigAudRef As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblConfigAudDevice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel25 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel24 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel27 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel26 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents VlcControl1 As Vlc.DotNet.Forms.VlcControl
    Friend WithEvents tmrWebUI As Timer
End Class
