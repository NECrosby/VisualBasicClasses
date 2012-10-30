Public Class Form1
    Private _Student As Student

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim testAverage As Double
        If Double.TryParse(txtTestAverage.Text, testAverage) Then
            Me._Student = New Student(txtID.Text, txtLastName.Text, testAverage)
            Me.lblStudent.Text = "(Student information saved)"
        Else
            Me.lblStudent.Text = "Test average is not a valid number"
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.lblStudent.Text = Me._Student.ToString
    End Sub
End Class
