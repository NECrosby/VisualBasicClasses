
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnConfirm_Click(sender As Object, e As System.EventArgs) Handles btnConfirm.Click
        lblMessage.Text = "Thank you for signing up for the " &
            "picnic, " & txtFirst.Text & " " & txtLAst.Text & "."
        If chkVegetarian.Checked = True Then
            lblMessage.Text &= " You will be receiving a Vegetarian meal."
        End If
    End Sub
End Class
