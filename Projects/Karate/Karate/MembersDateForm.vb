Public Class MembersDateForm

    Private Sub mnuFileClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub
    ' I think I would prefer this to work differently, like have an accept button, ENTER KEY PRESS
    Private Sub Date_JoinedDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Date_JoinedDateTimePicker.ValueChanged
        Dim selectedDate As Date = Date_JoinedDateTimePicker.Value
        dgvMembersBefore.DataSource = MembersTableAdapter.MembersBefore(selectedDate)
    End Sub
End Class