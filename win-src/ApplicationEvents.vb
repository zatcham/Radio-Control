Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub AppStart(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveAssemblies

        End Sub

        Private Function ResolveAssemblies(sender As Object, e As System.ResolveEventArgs) As Reflection.Assembly
            Dim desiredAssembly = New Reflection.AssemblyName(e.Name)
            If desiredAssembly.Name = "MaterialSkin" Then
                Return Reflection.Assembly.Load(My.Resources.MaterialSkin) 'replace with your assembly's resource name
            ElseIf desiredAssembly.Name = "NAudio" Then
                Return Reflection.Assembly.Load(My.Resources.NAudio)
            ElseIf desiredAssembly.Name = "Newtonsoft.Json" Then
                Return Reflection.Assembly.Load(My.Resources.Newtonsoft_Json)
            ElseIf desiredAssembly.Name = "Vlc.DotNet.Core" Then
                Return Reflection.Assembly.Load(My.Resources.Vlc_DotNet_Core)
            ElseIf desiredAssembly.Name = "Vlc.DotNet.Core.Interops" Then
                Return Reflection.Assembly.Load(My.Resources.Vlc_DotNet_Core_Interops)
            ElseIf desiredAssembly.Name = "Vlc.DotNet.Forms" Then
                Return Reflection.Assembly.Load(My.Resources.Vlc_DotNet_Forms)
            ElseIf desiredAssembly.Name = "Vlc.DotNet" Then
                Return Reflection.Assembly.Load(My.Resources.Vlc_DotNet_Forms)
            Else
                Return Nothing
            End If
        End Function
    End Class


End Namespace
