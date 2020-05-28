<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblPython = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Radio Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 59)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Version: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 59)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "By Zach Matcham"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(321, 136)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(47, 59)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 59)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Build:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(303, 59)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Python Version:"
        '
        'lblBuild
        '
        Me.lblBuild.AutoSize = True
        Me.lblBuild.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuild.Location = New System.Drawing.Point(321, 225)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(47, 59)
        Me.lblBuild.TabIndex = 7
        Me.lblBuild.Text = "0"
        '
        'lblPython
        '
        Me.lblPython.AutoSize = True
        Me.lblPython.Font = New System.Drawing.Font("Segoe UI Light", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPython.Location = New System.Drawing.Point(321, 313)
        Me.lblPython.Name = "lblPython"
        Me.lblPython.Size = New System.Drawing.Size(47, 59)
        Me.lblPython.TabIndex = 8
        Me.lblPython.Text = "0"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 526)
        Me.Controls.Add(Me.lblPython)
        Me.Controls.Add(Me.lblBuild)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBuild As Label
    Friend WithEvents lblPython As Label
End Class
