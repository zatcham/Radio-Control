<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCheck
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrentVersion = New System.Windows.Forms.Label()
        Me.lblLatestVersion = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 59)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Check for Updates"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 59)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Version : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 59)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Latest Version : "
        '
        'lblCurrentVersion
        '
        Me.lblCurrentVersion.AutoSize = True
        Me.lblCurrentVersion.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentVersion.Location = New System.Drawing.Point(415, 119)
        Me.lblCurrentVersion.Name = "lblCurrentVersion"
        Me.lblCurrentVersion.Size = New System.Drawing.Size(47, 59)
        Me.lblCurrentVersion.TabIndex = 7
        Me.lblCurrentVersion.Text = "0"
        '
        'lblLatestVersion
        '
        Me.lblLatestVersion.AutoSize = True
        Me.lblLatestVersion.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatestVersion.Location = New System.Drawing.Point(415, 204)
        Me.lblLatestVersion.Name = "lblLatestVersion"
        Me.lblLatestVersion.Size = New System.Drawing.Size(0, 59)
        Me.lblLatestVersion.TabIndex = 8
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(373, 297)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(264, 59)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = "Downloading"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInfo.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(149, 400)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(723, 36)
        Me.ProgressBar1.TabIndex = 10
        Me.ProgressBar1.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Font = New System.Drawing.Font("Segoe UI Light", 10.125!)
        Me.lblProgress.Location = New System.Drawing.Point(142, 452)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(23, 37)
        Me.lblProgress.TabIndex = 11
        Me.lblProgress.Text = "."
        Me.lblProgress.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(291, 48)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Check for Updates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UpdateCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 550)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblLatestVersion)
        Me.Controls.Add(Me.lblCurrentVersion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UpdateCheck"
        Me.Text = "UpdateCheck"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCurrentVersion As Label
    Friend WithEvents lblLatestVersion As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblProgress As Label
    Friend WithEvents Button1 As Button
End Class
