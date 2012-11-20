Imports System.IO

Public Class MainForm
    Private videoCollectionFileReader As StreamReader
    Private strFileName As String = "VideoCollectionData.txt"

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileSave.Click
        Dim input As String
        While (txtVideoName.Text.Length = 0 Or txtYearProduced.Text.Length = 0 Or _
               txtRunningTime.Text.Length = 0 Or txtRating.Text.Length = 0)
            Input = InputBox("Please enter a name in order to save")
            txtVideoName.Text = input
            input = InputBox("Please enter a year produced")
            txtYearProduced.Text = input
            input = InputBox("Please enter a running time")
            txtRunningTime.Text = input
            input = InputBox("Please enter a rating")
            txtRating.Text = input
        End While
        SaveDocument()
        ClearTextBoxes()     
    End Sub

    Private Sub mnuSearch_Click(sender As System.Object, e As System.EventArgs) Handles mnuSearch.Click
        ' Open a Dialog with Search as Title, Enter the name of video, OK & Cancel
        SearchVideoName()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Video Collection Version 1.0")
    End Sub
    
    Private Sub pdPrint_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim intX As Integer = 10
        Dim intY As Integer = 10
        Try
            videoCollectionFileReader = File.OpenText(strFileName)
            Do While videoCollectionFileReader.Peek <> -1
                e.Graphics.DrawString(videoCollectionFileReader.ReadLine(), _
                                      New Font("Arial", 11, FontStyle.Regular), _
                                      Brushes.Black, intX, intY)
                intY += 12
            Loop
            videoCollectionFileReader.Close()
        Catch ex As Exception
            MessageBox.Show(strFileName & " cannot be opened at this time.")
        End Try
    End Sub

    Private Sub mnuReport_Click(sender As System.Object, e As System.EventArgs) Handles mnuReport.Click
        ppdPrint.Document = pdPrint
        ppdPrint.ShowDialog()
    End Sub
End Class
