
' UpdateHelper v1.0.0
' Relies on UpdateMagic code in program
' Zach Matcham 2020

Set colArgs = WScript.Arguments.Named
Dim ScriptPath 
ScriptPath = CreateObject("Scripting.FileSystemObject").GetParentFolderName(WScript.ScriptFullName)
Dim FilePath 
FilePath = (ScriptPath & "\" & colArgs.Item("version") & ".exe")
Dim StdOut : Set StdOut = CreateObject("Scripting.FileSystemObject").GetStandardStream(1)
Wscript.Stdout.WriteLine "Test"
Wscript.Echo (FilePath)
Dim NewPath 
NewPath = ("RadioVB.exe")
Dim oShell : Set oShell = CreateObject("WScript.Shell")
Dim Fso : Set Fso = WScript.CreateObject("Scripting.FileSystemObject")
oShell.Run "taskkill /im RadioVB.exe", , True
Fso.MoveFile NewPath, (NewPath & ".old")
Fso.MoveFile FilePath, NewPath

Wscript.Echo ("Done!")