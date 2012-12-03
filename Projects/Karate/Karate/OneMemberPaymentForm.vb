Public Class OneMemberPaymentForm

    Private Sub mnuFileClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub OneMemberPaymentForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OneMemberPaymentsDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.OneMemberPaymentsDataSet.Members)

    End Sub

    Private Sub lstNames_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstNames.SelectedIndexChanged
        Dim shtId As Short = Convert.ToSByte(lstNames.SelectedValue)
        dgvOneMemberPayments.DataSource = PaymentsTableAdapter.PaymentsByMember(shtId)
    End Sub
End Class