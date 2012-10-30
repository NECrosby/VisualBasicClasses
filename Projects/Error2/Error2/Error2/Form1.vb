Public Class Form1
    ' The variables need to be class level in order to share their values throughout the program.
    Dim sum As Double = 0
    Dim average As Double = 0

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        'Dim sum As Double

        sum = CDbl(txtNum1.Text) + CDbl(txtNum2.Text) + CDbl(txtNum3.Text)
        lblSum.Text = sum.ToString
    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        'Dim average As Double

        'Note: sum is not declared
        average = sum / 3

        lblAverage.Text = average.ToString
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
