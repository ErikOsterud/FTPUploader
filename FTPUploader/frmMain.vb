Public Class frmMain

    Private Sub uploadFiles(ByVal filePath As String, ByVal fileName As String) 'Upload files to the FTP server
        Dim userName As String = My.Settings.Username
        Dim password As String = My.Settings.Password
        Dim ftpServer As String = My.Settings.FTPHost & fileName
        Me.Cursor = Cursors.WaitCursor
        My.Computer.Network.UploadFile(filePath, ftpServer, userName, password, True, 500)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmMain_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub frmMain_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each fileLoc As String In filePaths
                Dim fileName As String = System.IO.Path.GetFileName(fileLoc)
                Dim fileExt As String = System.IO.Path.GetExtension(fileLoc)
                Dim tempName = Guid.NewGuid.ToString & fileExt 'Create temporary file name
                My.Computer.FileSystem.CopyFile(fileLoc, tempName)
                uploadFiles(fileLoc, tempName)
                setClipboardText(tempName)
                My.Computer.FileSystem.DeleteFile(tempName)
            Next fileLoc
        End If
    End Sub

    Private Sub website_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles website.LinkClicked
        System.Diagnostics.Process.Start(My.Settings.Domain)
    End Sub

    Private Sub setClipboardText(ByVal fileName As String)
        Dim text As String = My.Settings.Domain & "/img/" & fileName
        Clipboard.SetText(text)
        notification.Visible = True
        notification.ShowBalloonTip(3000, "Copied to clipboard...", text, ToolTipIcon.Info)
    End Sub

End Class