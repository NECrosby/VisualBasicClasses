Public Class PrintBookForm
  
    Private Sub btnCloseAudioForm_Click(sender As System.Object, e As System.EventArgs) Handles btnCloseAudioForm.Click
        Me.Close()
    End Sub

    Private Sub btnAddAudioBook_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAudioBook.Click
        ' Get select item and add to the main form list box.
        _selectedItem = lstPrintBooks.SelectedItem.ToString
        Me.Close()
    End Sub

    Private Sub frmPrintBooks_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' get the dollar values and set into the labels
        loadSelectedBook(_selectedItem)
    End Sub
End Class