Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim annualSalary As Decimal
        Dim numOfPayPeriods As Integer
        Dim salaryPerPeroid As Decimal

        Try
            annualSalary = System.Convert.ToDecimal(TextBoxSalaryValue.Text)
            numOfPayPeriods = System.Convert.ToInt32(TextBoxPayPeriodValue.Text)
            salaryPerPeroid = annualSalary / numOfPayPeriods

            Me.LabelSalaryPerPeriod.Text = salaryPerPeroid.ToString("c")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            TextBoxSalaryValue.Clear()
            TextBoxSalaryValue.Focus()
        End Try



    End Sub
End Class
