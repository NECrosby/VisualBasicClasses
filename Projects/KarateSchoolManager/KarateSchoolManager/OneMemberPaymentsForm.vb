Public Class OneMemberPaymentsForm

    Private Sub OneMemberPaymentsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OneMemberPaymentsDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.OneMemberPaymentsDataSet.Members)

    End Sub

    Private Sub lstFullNames_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstFullNames.SelectedIndexChanged
        Dim shtId As Short = Convert.ToSByte(lstFullNames.SelectedValue)
        dgvPayments.DataSource = PaymentsTableAdapter.PaymentsByMember(shtId)
    End Sub
End Class