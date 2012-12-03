Public Class AllMembersForm

    Private Sub AllMembersForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MembersDataSet.Members)

    End Sub

    Private Sub mnuFileClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub mnuFileSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileSave.Click
        Me.MembersTableAdapter.Update(Me.MembersDataSet.Members)
    End Sub
End Class