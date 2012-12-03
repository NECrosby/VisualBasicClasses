Public Class FindMemberForm

    Private Sub mnuFileClose_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        ' Perform wildcard search for member last name
        Me.MembersTableAdapter.Fill(Me.FindMemberDataSet.Members, txtLastName.Text)
    End Sub
End Class