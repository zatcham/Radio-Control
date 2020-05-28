Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Build As String = "02052020"
        Dim PythonVer As String = 1.0
        lblBuild.Text = Build
        lblVersion.Text = Application.ProductVersion
        lblPython.Text = PythonVer
    End Sub
End Class