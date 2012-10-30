Imports System.IO

Public Class Form1
    Dim _FileNameToCopy As String

    Private Sub ButtonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBrowse.Click
        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()
        Dim substring As String
        Dim serverPath As String

        openFileDialog1.InitialDirectory = "c:\Access"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()
            If Not (myStream Is Nothing) Then
                Me._FileNameToCopy = openFileDialog1.FileName
                Dim i As Integer
                i = Me._FileNameToCopy.LastIndexOf("\")
                substring = Me._FileNameToCopy.Substring(i + 1)
                serverPath = "C:\Naomi\"

                If System.IO.File.Exists(Me._FileNameToCopy) = True Then
                    MessageBox.Show("File exists already")
                    'Append an integer to the file name so that it does not overwrite data.
                    'Dim j As Int32
                    'Me._FileNameToCopy = String.Format(Globalization.CultureInfo.InvariantCulture, "{0}" & j, Me._FileNameToCopy)
                    'j += 1
                    'File.Copy(Me._FileNameToCopy, serverPath & substring)
                    SaveFileDialog1.FileName = openFileDialog1.FileName
                    SaveFileDialog1.ShowDialog()
                Else
                    File.Copy(Me._FileNameToCopy, serverPath & substring)
                    MessageBox.Show("File has been saved. ")
                    myStream.Close()
                End If
            End If
        End If
    End Sub

    Public Function AppendVersionToFileName() As String
        Dim stringLength As Integer = System.Convert.ToInt32(Me._FileNameToCopy.Length)
        Dim newFileNameToCopy As String = String.Empty

        If IsNumeric(Me._FileNameToCopy.IndexOf((stringLength - 1).ToString)) Then
            Dim currentFileName As String = Me._FileNameToCopy
            Dim lastCharacter As Char = System.Convert.ToChar(Me._FileNameToCopy.IndexOf((stringLength - 1).ToString))
            newFileNameToCopy = currentFileName.TrimEnd(lastCharacter)
            ' At this point the FileName should be the Original (naomi.txt as example)
            ' need to add the new version number on
            Dim valueLastCharacter As Integer = System.Convert.ToInt32(currentFileName.Substring(stringLength - 1))
            valueLastCharacter += 1

            'newFileNameToCopy = Me._FileNameToCopy.Concat(

        End If


        Return newFileNameToCopy
    End Function

    'Public Function CopyDirectory(ByVal Src As String, ByVal Dest As String, Optional ByVal bQuiet As Boolean = False) As Boolean
    '    If Not Directory.Exists(Src) Then
    '        Throw New DirectoryNotFoundException("The directory " & Src & " does not exists")
    '    End If
    '    If Directory.Exists(Dest) AndAlso Not bQuiet Then
    '        If MessageBox.Show("directory " & Dest & " already exists." & vbCrLf & _
    '        "If you continue, any files with the same name will be overwritten", _
    '        "Continue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, _
    '        MessageBoxDefaultButton.Button2) = DialogResult.Cancel Then Exit Function
    '    End If

    '    'add Directory Seperator Character (\) for the string concatenation shown later
    '    If Dest.Substring(Dest.Length - 1, 1) <> Path.DirectorySeparatorChar Then
    '        Dest += Path.DirectorySeparatorChar
    '    End If
    '    If Not Directory.Exists(Dest) Then Directory.CreateDirectory(Dest)
    '    Dim Files As String()
    '    Files = Directory.GetFileSystemEntries(Src)
    '    Dim element As String
    '    For Each element In Files
    '        If Directory.Exists(element) Then
    '            'if the current FileSystemEntry is a directory,
    '            'call this function recursively
    '            CopyDirectory(element, Dest & Path.GetFileName(element), True)
    '        Else
    '            'the current FileSystemEntry is a file so just copy it
    '            File.Copy(element, Dest & Path.GetFileName(element), True)
    '        End If
    '    Next
    '    Return True
    'End Function

    'Example usage:
    'Private Sub cmdCopyDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopyDir.Click
    '    If CopyDirectory("D:\somePath", "C:\someOtherPath") Then
    '        MessageBox.Show("Success copying directory")
    '    Else
    '        MessageBox.Show("Error copying directory")
    '    End If
    'End Sub

    Private Sub ButtonFindFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFindFiles.Click
        Me.TextBoxFileSize.Enabled = False
        Me.TextBoxFileCreated.Enabled = False
        Me.TextBoxFileExtension.Enabled = False
        Dim theFiles() As String
        'change the path to a path that exists in your machine
        theFiles = Directory.GetFiles("C:\Access")
        Me.ListBox1.DataSource = theFiles
    End Sub

    Private Sub ButtonFindFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFindFolders.Click
        Me.TextBoxFileSize.Enabled = False
        Me.TextBoxFileCreated.Enabled = False
        Me.TextBoxFileExtension.Enabled = False
        Dim thefolders() As String
        thefolders = Directory.GetDirectories("C:\")
        Me.ListBox1.DataSource = thefolders
    End Sub

    Private Sub ButtonSpecialFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecialFolders.Click
        Me.TextBoxFileSize.Enabled = False
        Me.TextBoxFileCreated.Enabled = False
        Me.TextBoxFileExtension.Enabled = False
        Dim thefiles() As String
        Dim specialfolder As String
        specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        thefiles = Directory.GetFiles(specialfolder)
        Me.ListBox1.DataSource = thefiles
    End Sub

    'Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    '    Dim theselectedfile As String
    '    theselectedfile = Me.ListBox1.SelectedItem.ToString
    '    Dim myfile As New FileInfo(theselectedfile)
    '    Me.TextBoxFileSize.Text = myfile.Length.ToString()
    '    Me.TextBoxFileCreated.Text = myfile.CreationTime.ToString()
    '    Me.TextBoxFileExtension.Text = myfile.Extension.ToString()

    'End Sub

    Public Sub CopyFiles(ByVal sourcePath As String, ByVal DestinationPath As String)
        If (Directory.Exists(sourcePath)) Then
            For Each fName As String In Directory.GetFiles(sourcePath)
                If File.Exists(fName) Then
                    Dim dFile As String = String.Empty
                    dFile = Path.GetFileName(fName)
                    Dim dFilePath As String = String.Empty
                    dFilePath = DestinationPath + dFile
                    File.Copy(fName, dFilePath, True)
                End If
            Next
        End If
    End Sub
End Class
