Imports System.IO
Imports System.Net.NetworkInformation
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports MaterialSkin.MaterialSkinManager
Imports NAudio.CoreAudioApi
Imports Vlc.DotNet
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Globalization
Imports System.Net.Sockets

Public Class Form1

    ' Radio Control v0.5 -- Zach Matcham 2020
    ' 64 bit only (for now)

    ' Every fucking time the designer changes, you need to add this
    ' AddHandler VlcControl1.VlcLibDirectoryNeeded, AddressOf LibNeeded  to Form1.Designer under VlcControl1

    Public Python_Name = ("Radio-Backend")
    Public FilePath = (Environment.CurrentDirectory)
    Public Update_SRV = (My.Settings.Update_SRV)
    Public Volume_Main As Integer
    Public Mute_State As Boolean
    Public Selected_Station As Integer
    Public Stations_Array(10) As String
    Protected Web_PrevStation As String
    Protected Web_PrevVolume


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sets material design skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE)
        cboConfigColour.SelectedItem = "Green"

        ' Tray icon
        NotifyIcon1.BalloonTipText = "Radio Control started"
        NotifyIcon1.Text = "Radio Control"
        NotifyIcon1.ShowBalloonTip(5000)
        Dim contextMenu As New ContextMenu
        Dim menuItem As New MenuItem("Exit")
        contextMenu.MenuItems.Add(menuItem)
        NotifyIcon1.ContextMenu = contextMenu
        AddHandler menuItem.Click, AddressOf menuItem_Click


        ' About page
        Dim Build As String = "02/05/2020"
        Dim PythonVer As String = 1.0
        lblBuildDate.Text = Build
        lblVersion.Text = Application.ProductVersion
        lblPythonVer.Text = PythonVer

        ' Update Page   - More code in btnUpdateCheck
        Dim CurrentVersion As String = My.Application.Info.Version.ToString
        lblCurrentVersion.Text = CurrentVersion
        lblInfo.Visible = False
        MaterialProgressBar1.Visible = False
        btnUpdateDL.Visible = False
        lblUpdateProgress.Visible = False

        ' Settings Page
        swtConfigDark.Checked = True
        lblConfigAudDevice.Text = getDefaultAudio()

        ' Home Page
        swtHomeNet.Checked = False      ' Network
        swtHomePlayer.Checked = False   ' Media Player
        swtHomePython.Checked = False   ' Backend

        lblHomeVol.Text = getVolume()   ' Volume slider config
        trbVolume.Value = getVolume()
        If isMuted() = True Then
            cbHomeMute.Checked = True
        Else
            cbHomeMute.Checked = False
        End If
        cbHomeMute.Checked = Mute_State

        Dim imgList As ImageList = New ImageList()  ' Image settings for tabs
        Dim ResourceSet = My.Resources.ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, True, False)
        If ResourceSet IsNot Nothing Then
            imgList.Images.Add("home", My.Resources.home)   ' Gets files from Resources
            imgList.Images.Add("about", My.Resources.about)
            imgList.Images.Add("update", My.Resources.update)
            imgList.Images.Add("settings", My.Resources.settings)
            MaterialTabControl1.ImageList = imgList
            TabPage1.ImageKey = "home"
            TabPage2.ImageKey = "update"
            TabPage3.ImageKey = "settings"
            TabPage4.ImageKey = "about"
        End If

        ' Check for updates
        If UpdateCheck.checkUpdate() = True Then
            btnUpdateDL.Visible = True
            btnCheckUpdates.Visible = False
            lblInfo.Visible = True
            lblInfo.Text = "Update Available"
            lblLatestVer.Text = UpdateCheck.LatestVersion
            MaterialMessageBox.Show("New update available", "Updater")
        End If

        ' Check if Python program is running
        If checkProcess(Python_Name) = True Then

        Else
            Dim Python_Dir = (FilePath + "\backend.py")
            'openProcess("python " & Python_Dir)

        End If

        ' Check connection?
        ' Waiting for Tom

        ' Check network connection and sets display
        If checkInternet() = True Then
            swtHomeNet.Checked = True
            Console.WriteLine("Network connectivity ok")
        End If

        ' Checks VLC, sets display
        Dim VLCPathCheck
        If Environment.Is64BitOperatingSystem Then
            'aP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "VideoLAN\VLC")
            VLCPathCheck = Path.Combine(FilePath, "libvlc/win-x64")
        Else
            'aP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "VideoLAN\VLC")
            VLCPathCheck = Path.Combine(FilePath, "libvlc/win-x86")
        End If
        If Not File.Exists(Path.Combine(VLCPathCheck, "libvlc.dll")) Then

        Else
            swtHomePlayer.Checked = True
        End If

        ' Read radio json
        readJSON()

        ' Web UI Communication




    End Sub

    ' Reads JSON file with radio stations
    Private Sub readJSON()
        cboHomeStation.Items.Clear()

        ' Write to file for web UI
        System.IO.File.WriteAllText((FilePath + "\web\comms\stations.rxc"), "")

        ' Json reading
        Dim JsonReader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(FilePath & "\RadioSettings.Json")
        Dim JsonResp As String = JsonReader.ReadToEnd()
        Dim JsonOpen = JsonConvert.DeserializeObject(Of ArrayList)(JsonResp)
        Dim Token As JToken
        Dim St_URL
        Dim St_Name
        Dim St_ID As Integer
        Dim CurrentID As Integer = 0

        For Each Value As Object In JsonOpen
            Console.WriteLine(FilePath + "\web\comms\stations.rxc")
            Token = JObject.Parse(Value.ToString())
            St_Name = Token.SelectToken("name")
            St_URL = Token.SelectToken("url")
            'St_ID = CInt(Token.SelectToken("id"))
            CurrentID = CurrentID + 1
            St_ID = CurrentID
            Console.WriteLine("{0} {1} {2}", St_ID, St_Name, St_URL)
            If St_Name Is Nothing Then

            Else
                cboHomeStation.Items.Add(St_Name)
                Stations_Array(St_ID) = St_URL
                Using FileWriter As New StreamWriter((FilePath + "\web\stations.rxc"), True)
                    FileWriter.WriteLine(St_Name)
                End Using
                'File.WriteAllLines((FilePath + "\web\stations.rxc"), St_Name & vbNewLine)
            End If
        Next Value
    End Sub

    ' Controls VLC
    Private Sub PlayMedia(url)
        VlcControl1.SetMedia(url)
        VlcControl1.Play()
        lblHomePlaying.Text = cboHomeStation.SelectedItem
        Console.WriteLine("Currently playing : " & cboHomeStation.SelectedItem)
    End Sub

    ' Checks internet connection
    Function checkInternet()
        If My.Computer.Network.IsAvailable = True Then
            Try
                Return My.Computer.Network.Ping("1.1.1.1")
            Catch
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    ' More efficient sleep function
    Public Sub sleep(ByVal seconds As Single)
        Static s As Single
        s = Microsoft.VisualBasic.Timer()
        Do While Microsoft.VisualBasic.Timer() < s + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

    ' Used to handle shell commands
    Private Sub openProcess(ByVal command As String)
        Shell("cmd.exe /k " + command)
        Console.WriteLine("Shell command is : cmd.exe /k " + command)
    End Sub

    ' Checks if process is running
    Function checkProcess(ByVal ProcessName As String)
        Dim PList() As Process
        Try
            PList = Process.GetProcesses()

            For Each p As Process In PList
                If (ProcessName = p.ProcessName) Then
                    Return True
                Else
                    Return False
                End If
            Next p
            Return False
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    ' Exits Program
    Private Sub btnHomeExit_Click(sender As Object, e As EventArgs) Handles btnHomeExit.Click
        Application.Exit()
    End Sub

    ' Opens notepad 
    Private Sub btnConfigEdit_Click(sender As Object, e As EventArgs) Handles btnConfigEdit.Click
        openProcess("notepad " & "RadioSettings.json")
    End Sub

    ' Handles switch for dark/light mode
    Private Sub swtConfigDark_CheckedChanged(sender As Object, e As EventArgs) Handles swtConfigDark.CheckedChanged
        If swtConfigDark.Checked = False Then
            cboConfigColour.SelectedItem = "Blue"
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue400, TextShade.WHITE)
        Else
            cboConfigColour.SelectedItem = "Green"
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE)
        End If
    End Sub

    ' Combo box for Colour scheme on settings page
    Private Sub cboConfigColour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConfigColour.SelectedIndexChanged
        If cboConfigColour.SelectedItem = "Blue" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue400, TextShade.WHITE)
        ElseIf cboConfigColour.SelectedItem = "Green" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE)
        End If
    End Sub

    ' Checks for updates, UpdateMagic code
    Private Sub btnCheckUpdates_Click(sender As Object, e As EventArgs) Handles btnCheckUpdates.Click
        lblInfo.Text = "Checking for Updates"
        sleep(2)
        If UpdateCheck.checkUpdate() = True Then
            btnUpdateDL.Visible = True
            btnCheckUpdates.Visible = False
            lblInfo.Visible = True
            lblInfo.Text = "Update Available"
            lblLatestVer.Text = UpdateCheck.LatestVersion
            MaterialMessageBox.Show("New update available", "Updater")
        Else
            lblLatestVer.Text = UpdateCheck.LatestVersion
            lblInfo.Visible = True
            lblInfo.Text = "Up to date"
        End If
    End Sub

    ' Open webpage button
    Private Sub btnAboutSite_Click(sender As Object, e As EventArgs) Handles btnAboutSite.Click
        Dim webAddress As String = "http://zachmatcham.co.uk:8080"
        Process.Start(webAddress)
    End Sub

    ' Download update, only enabled if update available
    Private Sub btnUpdateDL_Click(sender As Object, e As EventArgs) Handles btnUpdateDL.Click
        If UpdateCheck.checkUpdateExists() = True Then
            UpdateCheck.downloadUpdate()
        Else
            MsgBox("Update not found on server", MsgBoxStyle.Exclamation, "Updater")
        End If
    End Sub

    ' Audio Control Code
    ' Gets current volume
    Function getVolume() As Integer
        Dim Minimum As Integer = 0
        Dim DeviceEnum As New MMDeviceEnumerator()
        Dim Device As MMDevice = DeviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Dim Volume As Integer
        With Device.AudioEndpointVolume
            Volume = CInt(.MasterVolumeLevelScalar * 100)
            If Volume < Minimum Then
                Volume = Minimum / 100.0F
            End If
        End With
        Return Volume
    End Function

    ' Gets Default Audio Device
    Function getDefaultAudio() As String
        Dim DeviceEnum As New MMDeviceEnumerator()
        Dim Device As MMDevice = DeviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Return Device.ToString
    End Function

    ' Checks whether default audio device is muted
    Function isMuted() As Boolean
        Dim DeviceEnum As New MMDeviceEnumerator()
        Dim Device As MMDevice = DeviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        If Device.AudioEndpointVolume.Mute = True Then
            Mute_State = True
            Return True
        Else
            Mute_State = False
            Return False
        End If
    End Function

    ' Sets mute on default audio device
    Private Sub setMute(ByVal State As Boolean)
        Dim DeviceEnum As New MMDeviceEnumerator()
        Dim Device As MMDevice = DeviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        If State = True Then
            Device.AudioEndpointVolume.Mute = True
        ElseIf State = False Then
            Device.AudioEndpointVolume.Mute = False
        End If
    End Sub

    ' Sets volume level on audio device
    Private Sub setVolume(ByVal Svol As Integer)
        Dim DeviceEnum As New MMDeviceEnumerator()
        Dim Device As MMDevice = DeviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        Mute_State = False
        cbHomeMute.Checked = False
        setMute(False)
        Device.AudioEndpointVolume.MasterVolumeLevelScalar = Svol / 100.0F
        Volume_Main = Svol
    End Sub

    ' Timer handles volume / mute controls
    Private Sub tmrVolume_Tick(sender As Object, e As EventArgs) Handles tmrVolume.Tick
        Dim DeviceEnum As New MMDeviceEnumerator()
        Dim Device As MMDevice = DeviceEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)

        ' If Volume is greater/lesser than trackbar, change volume
        If Volume_Main > trbVolume.Value Then
            lblHomeVol.Text = trbVolume.Value.ToString
            setVolume(trbVolume.Value)
            Volume_Main = trbVolume.Value
        ElseIf Volume_Main < trbVolume.Value Then
            lblHomeVol.Text = trbVolume.Value.ToString
            setVolume(trbVolume.Value)
            Volume_Main = trbVolume.Value
        End If

        ' Updates web UI
        Using MuteFile As New System.IO.StreamWriter(FilePath + "\web\comms\mute.rxc", False)
            MuteFile.Write(cbHomeMute.Checked)
        End Using

        Using VolumeFile As New System.IO.StreamWriter(FilePath + "\web\comms\volume.rxc", False)
            VolumeFile.Write(Volume_Main)
        End Using

        ' Check Web UI RX

        ' If Volume is greater/lesser than trackbar, change label and trackbar
        If Volume_Main > getVolume() Then
            lblHomeVol.Text = getVolume()
            trbVolume.Value = getVolume()
        ElseIf Volume_Main < getVolume() Then
            lblHomeVol.Text = getVolume()
            trbVolume.Value = getVolume()
        End If
        isMuted()

        ' Mute control is taken away from PC, poss. bug?
        If cbHomeMute.Checked = Mute_State Then
        Else
            If cbHomeMute.Checked = True Then
                setMute(True)
            ElseIf cbHomeMute.Checked = False Then
                setMute(False)
            End If
        End If

        ' Shows equaliser
        Dim LeftVol = Math.Round((Device.AudioMeterInformation.PeakValues(0) * 100))
        Dim RightVol = Math.Round((Device.AudioMeterInformation.PeakValues(1) * 100))
        progHomeLVol.Value = LeftVol
        progHomeRVol.Value = RightVol



    End Sub

    ' Refreshes text with current default audio device
    Private Sub btnConfigAudRef_Click(sender As Object, e As EventArgs) Handles btnConfigAudRef.Click
        lblConfigAudDevice.Text = getDefaultAudio()
    End Sub

    ' Play button
    Private Sub btnHomePlay_Click(sender As Object, e As EventArgs) Handles btnHomePlay.Click
        Dim url As String = (Stations_Array(Selected_Station + 1))      ' +1 cause it starts from 0 instead of 1
        Console.WriteLine("Selected URL is : " & url)
        PlayMedia(url)
    End Sub

    ' Combo box for station selection
    Private Sub cboHomeStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHomeStation.SelectedIndexChanged
        Selected_Station = cboHomeStation.SelectedIndex
        Console.WriteLine("Selected Item : " & Selected_Station)
        Console.WriteLine(cboHomeStation.SelectedItem)
    End Sub

    ' Stops playback
    Private Sub btnHomeStop_Click(sender As Object, e As EventArgs) Handles btnHomeStop.Click
        VlcControl1.Stop()
    End Sub

    ' Refreshes list with stations
    Private Sub btnHomeRefresh_Click(sender As Object, e As EventArgs) Handles btnHomeRefresh.Click
        readJSON()
    End Sub

    ' Notify Icon menu click
    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    ' Web Control Code
    ' Recieve input
    Private Sub webStationSelect(ByVal id As Integer)   ' Timer will call this
        If Selected_Station = id Then
        Else
            Selected_Station = id
            My.Computer.FileSystem.DeleteFile("web/station.txc")
            Dim url As String = (Stations_Array(Selected_Station + 1))      ' +1 cause it starts from 0 instead of 1
            Console.WriteLine("Selected URL is : " & url)
            PlayMedia(url)
        End If

    End Sub

    ' Timer checking file
    Private Sub tmrWebUI_Tick(sender As Object, e As EventArgs) Handles tmrWebUI.Tick
        checkPlayback()

    End Sub

    Private Sub checkStation()

    End Sub

    Private Sub checkPlayback()
        Dim Previous As String
        If My.Computer.FileSystem.FileExists(FilePath & "\web\comms\playback.txc") Then
            Dim Reader = My.Computer.FileSystem.ReadAllText(FilePath & "\web\comms\playback.txc")
            If Reader IsNot Previous Then
                If Reader = "True" Then

                    'Dim url As String = (Stations_Array(Selected_Station + 1))      ' +1 cause it starts from 0 instead of 1
                    Dim url As String = ("https://ibgrpremiumweb.streaming-pro.com:6115/ibgr.mp3")
                    Console.WriteLine("Selected URL is : " & url)
                    PlayMedia(url)
                    Console.WriteLine("True")
                    Previous = Reader
                ElseIf Reader = "False" Then
                    VlcControl1.Stop()
                    Previous = Reader
                End If
            End If
        End If
    End Sub

End Class

