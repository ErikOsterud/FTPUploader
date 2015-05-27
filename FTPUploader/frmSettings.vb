Public Class frmSettings

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            My.Settings.Username = txtUsername.Text
            My.Settings.Password = txtPassword.Text
            My.Settings.FTPHost = txtFTPHostAndPath.Text
            My.Settings.Domain = txtDomain.Text
            My.Settings.Save()
            MsgBox("Settings saved.", MsgBoxStyle.OkOnly)
            frmMain.Show()
            Me.Hide()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error saving settings. " & ex.ToString)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = My.Settings.Username
        txtPassword.Text = My.Settings.Password
        txtFTPHostAndPath.Text = My.Settings.FTPHost
        txtDomain.Text = My.Settings.Domain
    End Sub
End Class