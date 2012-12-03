' Naomi Crosby - Chapter 10 assignment
' I figured out the issue with SQL Server, it started to do it again when I downloaded the new ones.
' I tried them both and they both gave me problems.
' Now I need to try the solve on my virtual machine to see if that is the real issue, 
' which would be user error on my part.

Public Class MainForm

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMembershipListall_Click(sender As System.Object, e As System.EventArgs) Handles mnuMembershipListall.Click
        Dim frmAllMembers As New AllMembersForm
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub mnuMembershipFindmember_Click(sender As System.Object, e As System.EventArgs) Handles mnuMembershipFindmember.Click
        Dim frmFindMember As New FindMemberForm
        frmFindMember.ShowDialog()
    End Sub

    Private Sub mnuMembershipAddnewmember_Click(sender As System.Object, e As System.EventArgs) Handles mnuMembershipAddnewmember.Click
        Dim frmAddMember As New AddMemberForm
        frmAddMember.ShowDialog()
    End Sub

    Private Sub mnuPaymentsAllmembers_Click(sender As System.Object, e As System.EventArgs) Handles mnuPaymentsAllmembers.Click
        Dim frmAllPayments As New AllPaymentsForm
        frmAllPayments.ShowDialog()
    End Sub

    Private Sub PaymentsByOneMemberToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PaymentsByOneMemberToolStripMenuItem.Click
        Dim frmOneMemberPayments As New OneMemberPaymentForm
        frmOneMemberPayments.ShowDialog()
    End Sub

    Private Sub mnuMembershipMemberdates_Click(sender As System.Object, e As System.EventArgs) Handles mnuMembershipMemberdates.Click
        Dim frmMembersDate As New MembersDateForm
        frmMembersDate.ShowDialog()
    End Sub
End Class
