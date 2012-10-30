Public Class Form1

    Private Sub ButtonDisplayDirections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDisplayDirections.Click
        LabelDirections.Visible = True
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonHideDirections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHideDirections.Click
        LabelDirections.Visible = False
    End Sub
End Class
