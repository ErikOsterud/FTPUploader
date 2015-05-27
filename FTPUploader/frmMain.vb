'Erik Osterud
'FTPU
'2015

Public Class frmMain

    Private Sub frmMain_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragEnter 'Drag and drop handler
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub frmMain_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles Me.DragDrop 'Drag and drop handler
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim filePaths As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each fileLoc As String In filePaths
                Dim fileName As String = System.IO.Path.GetFileName(fileLoc)
                Dim fileExt As String = System.IO.Path.GetExtension(fileLoc)
                Dim tempName = Guid.NewGuid.ToString & fileExt 'Create temporary file name
                renameImage(fileLoc, fileName, fileExt, tempName)
            Next fileLoc
        End If
    End Sub

    Private Sub website_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles website.LinkClicked
        System.Diagnostics.Process.Start(My.Settings.Domain)
    End Sub

    Private Sub renameImage(ByVal fileLoc As String, ByVal fileName As String, ByVal fileExt As String, ByVal tempName As String)
        My.Computer.FileSystem.CopyFile(fileLoc, tempName)
        uploadFiles(fileLoc, tempName)
        My.Computer.FileSystem.DeleteFile(tempName)
    End Sub

    Private Sub uploadFiles(ByVal filePath As String, ByVal fileName As String) 'Upload files to the FTP server
        Dim userName As String = My.Settings.Username
        Dim password As String = My.Settings.Password
        Dim ftpServer As String = My.Settings.FTPHost & fileName
        setClipboardText(fileName)
        Me.Cursor = Cursors.WaitCursor
        My.Computer.Network.UploadFile(filePath, ftpServer, userName, password, True, 500)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub setClipboardText(ByVal fileName As String)
        Dim text As String = My.Settings.Domain & "/img/" & fileName
        Clipboard.SetText(text)
        notification.Visible = True
        notification.ShowBalloonTip(3000, "Copied to clipboard...", text, ToolTipIcon.Info)
    End Sub

    Private Sub fswWatcher_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles fswWatcher.Changed
        'TODO 
        'Add automated upload (hot folder) based on new images
        'MsgBox("File- " & e.FullPath.ToString & " modified at: " & System.DateTime.Now)
    End Sub

    Private Sub btnAddFromCB_Click(sender As Object, e As EventArgs) Handles btnAddFromCB.Click
        If Not System.Windows.Forms.Clipboard.GetDataObject() Is Nothing Then
            Dim oDataObj As IDataObject = System.Windows.Forms.Clipboard.GetDataObject()
            If oDataObj.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap) Then
                Dim oImgObj As System.Drawing.Image = oDataObj.GetData(DataFormats.Bitmap, True)
                Dim tempName As String = Guid.NewGuid.ToString & ".jpg"
                oImgObj.Save(tempName, System.Drawing.Imaging.ImageFormat.Jpeg)
                uploadFiles(tempName, tempName)
                My.Computer.FileSystem.DeleteFile(tempName)
            End If
        End If
    End Sub

    Public Sub frmMain_FormClosing(ByVal send As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Close()
    End Sub

    Private Sub tsmiSettings_Click(sender As Object, e As EventArgs) Handles tsmiSettings.Click
        frmSettings.Show()
        Me.Hide()
    End Sub

End Class