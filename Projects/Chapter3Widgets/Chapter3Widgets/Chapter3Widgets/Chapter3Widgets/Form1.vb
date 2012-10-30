' Naomi Crosby

Public Class Form1
    ' class level variables
    Const dblWidgetWeight As Double = 9.2
    Dim dblPalletWeight As Double = 0
    Dim dblTotalWeight As Double = 0
    Dim intWidgetCount As Integer = 0

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close Form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' clear user input boxes and reset label to empty
        txtPalletWght.Clear()
        txtPalletWidgetWght.Clear()
        lblNumberWidgets.Text = String.Empty
        ' Reset Focus to first input box
        txtPalletWght.Focus()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            ' Setting uer input
            dblPalletWeight = CDbl(txtPalletWght.Text)
            dblTotalWeight = CDbl(txtPalletWidgetWght.Text)
            ' This calculates the widget count
            intWidgetCount = CInt((dblTotalWeight - dblPalletWeight) / dblWidgetWeight)
            lblNumberWidgets.Text = intWidgetCount.ToString("n0")
        Catch ex As InvalidCastException
            ' An invalid value has been entered
            MessageBox.Show("Error: Input must be numeric.")
        Catch ex As DivideByZeroException
            ' 0 was entered for an amount
            MessageBox.Show("Error: Enter nonzero values, please.")
        End Try
    End Sub
End Class
