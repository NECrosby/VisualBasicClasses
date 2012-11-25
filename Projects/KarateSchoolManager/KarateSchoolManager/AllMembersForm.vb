Public Class AllMembersForm

    Private Sub AllMembersForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MembersTableAdapter.Fill(Me.AllMembersDataSet.Members)
    End Sub

    Private Sub mnuFileClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub mnuFileSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileSave.Click
        Me.MembersTableAdapter.Update(Me.AllMembersDataSet.Members)
    End Sub
End Class