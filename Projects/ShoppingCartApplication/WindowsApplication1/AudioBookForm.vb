Public Class AudioBookForm

    Private Sub btnCloseAudioForm_Click(sender As System.Object, e As System.EventArgs) Handles btnCloseAudioForm.Click
        Me.Close()
    End Sub

    Private Sub btnAddAudioBook_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAudioBook.Click
        ' Get select item and add to the main form list box.
        _selectedItem = lstAudioBooks.SelectedItem.ToString
        Me.Close()
    End Sub

    Private Sub AudioBookForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        loadSelectedBook(_selectedItem)
    End Sub
End Class