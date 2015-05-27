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
        Me.btnAddFromCB = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.msToolbar = New System.Windows.Forms.MenuStrip()
        Me.tstmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiQuit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.fswWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Drop images to upload"
        '
        'website
        '
        Me.website.AutoSize = True
        Me.website.Location = New System.Drawing.Point(64, 80)
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
        Me.notification.Visible = True
        '
        'fswWatcher
        '
        Me.fswWatcher.EnableRaisingEvents = True
        Me.fswWatcher.Path = "C:\Users\Erik\Desktop\Test"
        Me.fswWatcher.SynchronizingObject = Me
        '
        'btnAddFromCB
        '
        Me.btnAddFromCB.Location = New System.Drawing.Point(58, 35)
        Me.btnAddFromCB.Name = "btnAddFromCB"
        Me.btnAddFromCB.Size = New System.Drawing.Size(110, 23)
        Me.btnAddFromCB.TabIndex = 2
        Me.btnAddFromCB.Text = "&Add from clipboard"
        Me.btnAddFromCB.UseVisualStyleBackColor = True
        '
        'msToolbar
        '
        Me.msToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstmiFile})
        Me.msToolbar.Location = New System.Drawing.Point(0, 0)
        Me.msToolbar.Name = "msToolbar"
        Me.msToolbar.Size = New System.Drawing.Size(235, 24)
        Me.msToolbar.TabIndex = 3
        Me.msToolbar.Text = "MenuStrip1"
        '
        'tstmiFile
        '
        Me.tstmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSettings, Me.tsmiQuit})
        Me.tstmiFile.Name = "tstmiFile"
        Me.tstmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tstmiFile.Text = "&File"
        '
        'tsmiSettings
        '
        Me.tsmiSettings.Name = "tsmiSettings"
        Me.tsmiSettings.Size = New System.Drawing.Size(152, 22)
        Me.tsmiSettings.Text = "&Settings"
        '
        'tsmiQuit
        '
        Me.tsmiQuit.Name = "tsmiQuit"
        Me.tsmiQuit.Size = New System.Drawing.Size(152, 22)
        Me.tsmiQuit.Text = "&Quit"
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 120)
        Me.Controls.Add(Me.btnAddFromCB)
        Me.Controls.Add(Me.website)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msToolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.MainMenuStrip = Me.msToolbar
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FTP Uploader"
        Me.TopMost = True
        CType(Me.fswWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msToolbar.ResumeLayout(False)
        Me.msToolbar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents website As System.Windows.Forms.LinkLabel
    Friend WithEvents notification As System.Windows.Forms.NotifyIcon
    Friend WithEvents fswWatcher As System.IO.FileSystemWatcher
    Friend WithEvents btnAddFromCB As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents msToolbar As System.Windows.Forms.MenuStrip
    Friend WithEvents tstmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiQuit As System.Windows.Forms.ToolStripMenuItem

End Class
