Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the form
        lstData.Items.Clear()
        cboStartNumber.SelectedIndex = -1
        cboStartNumber.Text = String.Empty
        cboNumberDaysToMultiply.SelectedIndex = -1
        cboNumberDaysToMultiply.Text = String.Empty
        txtDailyIncrease.Text = String.Empty
        cboStartNumber.Focus()
    End Sub

    Private Sub btnDisplayTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayTable.Click
        ' Add TOOL TIPS where necessary
        Try
            ' Perform calculations
            Dim dblStartNumber As Double = 0.0
            Dim dblDailyIncrease As Double = 0.0
            Dim intNumberOfDays As Integer = 0
            Dim dblOrganismCount As Double = 0.0

            lstData.Items.Clear() ' Clear the listbox everytime display table button is clicked.
            ' Validation of user input
            Select Case Convert.ToInt16(cboStartNumber.Text)
                Case 2, 4, 6, 8, 10
                    dblStartNumber = Convert.ToDouble(cboStartNumber.Text)
                Case Else
                    MessageBox.Show("Please select a starting number of ""Organzism"" from the ComboBox")
                    cboStartNumber.SelectedIndex = -1
                    cboStartNumber.Text = String.Empty
                    cboStartNumber.Focus()
            End Select

            If Double.TryParse(txtDailyIncrease.Text, dblDailyIncrease) Then
                dblDailyIncrease = (dblDailyIncrease / 100) + 1.0
            Else
                txtDailyIncrease.Text = String.Empty
                txtDailyIncrease.Focus()
            End If

            Select Case Convert.ToInt32(cboNumberDaysToMultiply.Text)
                Case 10, 20, 40, 60, 80, 100
                    intNumberOfDays = Convert.ToInt32(cboNumberDaysToMultiply.Text)
                Case Else
                    MessageBox.Show("Please select a starting number of ""Days to Multiply"" from the ComboBox")
                    cboNumberDaysToMultiply.SelectedIndex = -1
                    cboNumberDaysToMultiply.Text = String.Empty
                    cboStartNumber.Focus()
            End Select

            ' Load the Header info then the first day into the listBox
            lstData.Items.Add("Day" & ControlChars.Tab & "Approximate Population")
            lstData.Items.Add(1 & ControlChars.Tab & dblStartNumber.ToString("n3"))

            ' Perform calculations
            ' Now loop through the rest of the days as selected by user
            For intCount = 2 To intNumberOfDays
                dblOrganismCount = (dblStartNumber * dblDailyIncrease)
                lstData.Items.Add(intCount.ToString("D") & ControlChars.Tab & dblOrganismCount.ToString("n3"))
                dblStartNumber = dblOrganismCount
            Next
        Catch ex As System.FormatException
            MessageBox.Show("Please enter a value.")
        End Try
    End Sub
End Class
