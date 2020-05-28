Imports System.Net

Public Class UpdateCheck
    Dim UpdatePath = (Form1.Update_SRV & ":" & My.Settings.SRV_Port & "/" & My.Settings.Update_ID & "/")
    Dim CurrentVersion As String = My.Application.Info.Version.ToString
    Public LatestVersion As String
    Dim FilePath As String = (Environment.CurrentDirectory)
    Dim WithEvents Client As New Net.WebClient

    ' Button is used for start, not used
    Private Sub UpdateCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentVersion.Text = CurrentVersion
        lblInfo.Visible = True
        lblInfo.Text = "Ready"
    End Sub

    ' UpdateMagic code - v1.0
    ' Checks for Update
    Function checkUpdate()
        Try
            Dim Request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(UpdatePath & "version.bzx")
            Console.WriteLine("Path is : " & UpdatePath & "version.bzx")
            Dim Response As System.Net.HttpWebResponse = Request.GetResponse()
            Dim Reader As System.IO.StreamReader = New System.IO.StreamReader(Response.GetResponseStream())
            Dim latest As String = Reader.ReadToEnd()
            LatestVersion = latest
            If latest.ToString > CurrentVersion.ToString Then
                Return True
            Else
                Return False
            End If
        Catch ex As WebException
            MsgBox(ex.ToString)
        End Try

    End Function

    ' Downloads update
    Public Sub downloadUpdate()
        Form1.lblInfo.Visible = True
        Form1.lblInfo.Text = "Downloading"
        Form1.lblUpdateProgress.Visible = True
        Form1.MaterialProgressBar1.Visible = True
        Dim URL As String = (UpdatePath & LatestVersion & ".exe")
        Dim Path As String = (FilePath & "/" & LatestVersion & ".exe")

        Client.DownloadFileAsync(New Uri(URL), Path)
        Shell("cmd.exe /k cscript UpdateHelper.vbs /version: " & LatestVersion)
    End Sub

    ' Increases progress bar
    Private Sub Client_DownloadProgressChanged(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs) Handles Client.DownloadProgressChanged
        Form1.MaterialProgressBar1.Value = e.ProgressPercentage
        Form1.lblUpdateProgress.Text = (e.BytesReceived & " / " * e.TotalBytesToReceive)
    End Sub

    ' Not used as Form1 has button on, probably should move to sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblInfo.Text = "Checking for Updates"
        Form1.sleep(2)
        If checkUpdate() = True Then
            Button1.Visible = False
            lblInfo.Visible = True
            lblInfo.Text = "Update Available"
            lblLatestVersion.Text = LatestVersion
            MsgBox("New update available", MsgBoxStyle.Information, "Updater")
            downloadUpdate()
        Else
            lblLatestVersion.Text = LatestVersion
            lblInfo.Visible = True
            lblInfo.Text = "Up to date"
        End If
    End Sub

    ' Checks update exists before downloading
    Function checkUpdateExists()
        Try
            ' Checks for 404
            Dim Request As Net.HttpWebRequest = DirectCast(Net.WebRequest.Create(UpdatePath & LatestVersion & ".exe"), Net.HttpWebRequest)
            Request.KeepAlive = True
            Dim Response As Net.HttpWebResponse = DirectCast(Request.GetResponse(), Net.HttpWebResponse)

            ' Checks file size - probably not needed
            If Response.StatusCode = Net.HttpStatusCode.OK Then
                Dim WebReq As Net.WebRequest
                Dim FileSize As Long
                WebReq = Net.WebRequest.Create(UpdatePath & LatestVersion & ".exe")
                WebReq.Method = ("HEAD")
                Dim WebResp = WebReq.GetResponse()
                FileSize = WebResp.ContentLength()
                If FileSize > 0 Then
                    Return True
                ElseIf FileSize = 0 Then
                    Return False
                End If
            Else
                Console.WriteLine("Page is 404")
                Return False
            End If
        Catch ex As WebException    ' To handle 404s
            Return False
        End Try
        Return False
    End Function
End Class