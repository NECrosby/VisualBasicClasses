' Naomi Crosby
' VB Chapter 2 Assignment Due 9/17 - Programming Challenge #6

Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picOne.Click
        MessageBox.Show("One")
    End Sub

    Private Sub picTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTwo.Click
        MessageBox.Show("Two")
    End Sub

    Private Sub picThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picThree.Click
        MessageBox.Show("Three")
    End Sub

    Private Sub picFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFour.Click
        MessageBox.Show("Four")
    End Sub

    Private Sub picFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFive.Click
        MessageBox.Show("Five")
    End Sub
End Class
