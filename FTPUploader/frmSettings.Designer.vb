<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFTPHostAndPath = New System.Windows.Forms.TextBox()
        Me.txtDomain = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblFTPHostAndPath = New System.Windows.Forms.Label()
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(153, 34)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(179, 20)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(153, 60)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(179, 20)
        Me.txtPassword.TabIndex = 1
        '
        'txtFTPHostAndPath
        '
        Me.txtFTPHostAndPath.Location = New System.Drawing.Point(153, 86)
        Me.txtFTPHostAndPath.Name = "txtFTPHostAndPath"
        Me.txtFTPHostAndPath.Size = New System.Drawing.Size(179, 20)
        Me.txtFTPHostAndPath.TabIndex = 2
        '
        'txtDomain
        '
        Me.txtDomain.Location = New System.Drawing.Point(153, 112)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(179, 20)
        Me.txtDomain.TabIndex = 3
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(93, 37)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username:"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(95, 63)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        '
        'lblFTPHostAndPath
        '
        Me.lblFTPHostAndPath.AutoSize = True
        Me.lblFTPHostAndPath.Location = New System.Drawing.Point(50, 89)
        Me.lblFTPHostAndPath.Name = "lblFTPHostAndPath"
        Me.lblFTPHostAndPath.Size = New System.Drawing.Size(101, 13)
        Me.lblFTPHostAndPath.TabIndex = 6
        Me.lblFTPHostAndPath.Text = "FTP Host and Path:"
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Location = New System.Drawing.Point(105, 115)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(46, 13)
        Me.lblDomain.TabIndex = 7
        Me.lblDomain.Text = "Domain:"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(326, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 28)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(257, 148)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(63, 28)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "S&ave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(401, 177)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblDomain)
        Me.Controls.Add(Me.lblFTPHostAndPath)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtDomain)
        Me.Controls.Add(Me.txtFTPHostAndPath)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "FTP Uploader Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtFTPHostAndPath As System.Windows.Forms.TextBox
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblFTPHostAndPath As System.Windows.Forms.Label
    Friend WithEvents lblDomain As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
