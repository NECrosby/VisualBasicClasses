Public Class Form1
    Private Sub ButtonCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalculate.Click
        Dim runner1 As Double
        Dim runner2 As Double
        Dim runner3 As Double
        Dim avgTime As Double

        runner1 = System.Convert.ToDouble(TextBoxRunner1.Text)
        runner2 = System.Convert.ToDouble(TextBoxRunner2.Text)
        runner3 = System.Convert.ToDouble(TextBoxRunner3.Text)

        avgTime = (runner1 + runner2 + runner3) / 3

        LabelAvgTime.Text = avgTime.ToString("n1")
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        TextBoxRunner1.Clear()
        TextBoxRunner2.Clear()
        TextBoxRunner3.Clear()
        TextBoxRunner1.Focus()
    End Sub
End Class
