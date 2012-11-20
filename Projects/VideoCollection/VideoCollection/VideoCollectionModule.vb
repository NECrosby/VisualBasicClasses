Imports System.IO
Module VideoCollectionModule

    Private _strVideoCollection As String
    Private strFileName As String = "VideoCollectionData.txt"
    Private videoCollectionFileWriter As StreamWriter
    Private videoCollectionFileReader As StreamReader

    Public Sub SaveDocument()
        Try
            If File.Exists(strFileName) Then
                videoCollectionFileWriter = File.AppendText("VideoCollectionData.txt")    ' Open the file or create it
            Else
                videoCollectionFileWriter = File.CreateText("VideoCollectionData.txt")    ' Open the file or create it
            End If

            videoCollectionFileWriter.WriteLine(MainForm.txtVideoName.Text)           ' Get text from Video Name,  Main form
            videoCollectionFileWriter.WriteLine(MainForm.txtYearProduced.Text)        ' Get text from Year Produced, Main form
            videoCollectionFileWriter.WriteLine(MainForm.txtRunningTime.Text)         ' Get text from running time,  Main form
            videoCollectionFileWriter.WriteLine(MainForm.txtRating.Text)              ' Get text from Rating, Main form
            videoCollectionFileWriter.Close()

        Catch ex As Exception
            MessageBox.Show("Error: File cannot be created.")
        End Try

    End Sub
    Public Sub SearchVideoName()
        Dim strVideoName As String      ' Video Name
        strVideoName = InputBox("Enter a video name:", "Search for Video by Name")
        OpenDocument(strVideoName)
    End Sub
    Public Sub OpenDocument(ByVal video As String)
        Dim strUserInput As String = video
        Dim strVideoName As String      ' Video Name
        Try
            videoCollectionFileReader = File.OpenText(strFileName)
            Do Until videoCollectionFileReader.Peek = -1
                strVideoName = videoCollectionFileReader.ReadLine()
                If strVideoName.Equals(strUserInput) Then
                    MainForm.txtVideoName.Text = strVideoName
                    MainForm.txtYearProduced.Text = videoCollectionFileReader.ReadLine()
                    MainForm.txtRunningTime.Text = videoCollectionFileReader.ReadLine()
                    MainForm.txtRating.Text = videoCollectionFileReader.ReadLine()
                End If
            Loop
            videoCollectionFileReader.Close()
        Catch ex As Exception
            MessageBox.Show(strFileName & " cannot be opened at this time.")
        End Try
    End Sub
    Public Sub ClearTextBoxes()
        MainForm.txtVideoName.Text = String.Empty
        MainForm.txtYearProduced.Text = String.Empty
        MainForm.txtRunningTime.Text = String.Empty
        MainForm.txtRating.Text = String.Empty
        MainForm.txtVideoName.Focus()
    End Sub

End Module
