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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.website = New System.Windows.Forms.LinkLabel()
        Me.notification = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.fswWatcher = New System.IO.FileSystemWatcher()
        CType(Me.fswWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Drop images to upload"
        '
        'website
        '
        Me.website.AutoSize = True
        Me.website.Location = New System.Drawing.Point(64, 48)
        Me.website.Name = "website"
        Me.website.Size = New System.Drawing.Size(94, 13)
        Me.website.TabIndex = 1
        Me.website.TabStop = True
        Me.website.Text = "View online gallery"
        '
        'notification
        '
        Me.notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notification.Icon = CType(resources.GetObject("notification.Icon"), System.Drawing.Icon)
        '
        'fswWatcher
        '
        Me.fswWatcher.EnableRaisingEvents = True
        Me.fswWatcher.Path = "C:\Users\Erik\Desktop\Test"
        Me.fswWatcher.SynchronizingObject = Me
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 70)
        Me.Controls.Add(Me.website)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FTP Uploader"
        Me.TopMost = True
        CType(Me.fswWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents website As System.Windows.Forms.LinkLabel
    Friend WithEvents notification As System.Windows.Forms.NotifyIcon
    Friend WithEvents fswWatcher As System.IO.FileSystemWatcher

End Class
