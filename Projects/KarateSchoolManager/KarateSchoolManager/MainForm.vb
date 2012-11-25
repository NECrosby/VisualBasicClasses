Public Class MainForm

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMembershipListall_Click(sender As System.Object, e As System.EventArgs) Handles mnuMembershipListall.Click
        Dim frmAllMembers As New AllMembersForm
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub mnuMembershipAddmember_Click(sender As System.Object, e As System.EventArgs) Handles mnuMembershipAddmember.Click
        Dim frmAddMember As New AddMemberForm
        frmAddMember.ShowDialog()
    End Sub

    Private Sub mnuMembershipFindMember_Click(sender As System.Object, e As System.EventArgs) Handles mnuMembershipFindMember.Click
        Dim frmFindMember As New FindMemberForm
        frmFindMember.ShowDialog()
    End Sub

    Private Sub mnuPaymentsAllmembers_Click(sender As System.Object, e As System.EventArgs) Handles mnuPaymentsAllmembers.Click
        Dim frmPaymentsAll As New AllPaymentsForm
        frmPaymentsAll.ShowDialog()
    End Sub
End Class
