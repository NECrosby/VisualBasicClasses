' Naomi Crosby
' VB Chapter 2 Assignment Due 9/17 - Programming Challenge #5

Public Class Form1

    Private Sub btnSinister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinister.Click
        lblTranslation.Text = "Left"
        lblTranslation.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub btnDexter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDexter.Click
        lblTranslation.Text = "Right"
        lblTranslation.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub btnMedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedium.Click
        lblTranslation.Text = "Center"
        lblTranslation.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
