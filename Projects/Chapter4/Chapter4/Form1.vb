' Naomi Crosby


Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close Form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear and reset defaults and focus 
        radPkgA.Checked = True
        radPkgB.Checked = False
        radPkgC.Checked = False

        chkNonprofitOrg.Checked = False
        txtNumHours.Text = String.Empty
        lblAmountDue.Text = String.Empty
        txtNumHours.Focus()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' Declare variables
        Const dblNonprofitDiscount As Double = 0.2
        ' package variables
        Const dblPackage_A As Double = 9.95      ' 10 hours max
        Const dblExtraHours_A As Double = 2.0
        Const intHourLimit_A As Integer = 10
        Const dblPackage_B As Double = 14.95     ' 20 hours max
        Const dblExtraHours_B As Double = 1.0
        Const intHourLimit_B As Integer = 20
        Const dblPackage_C As Double = 19.95     ' Unlimited hours

        Dim intHours As Integer = 0
        Dim intOverLimitHourCount As Integer = 0
        Dim dblSubtotal As Double = 0
        Dim dblTotal As Double = 0
        Dim dblTempAmount As Double = 0

        Try
            intHours = CInt(txtNumHours.Text) ' Hours used by organization cannot exceed 744
            If IsNumeric(txtNumHours.Text) Then         ' Making sure the input is numeric
                If CInt(txtNumHours.Text) > 745 Then    ' Making sure the hours are not above 744, van equal 744 though
                    MessageBox.Show("Hour total cannot exceed 744 per month.")
                    txtNumHours.Clear()
                    txtNumHours.Focus()
                Else
                    ' Since the Hours input has been validated, calculations can occur
                    ' Package A
                    If radPkgA.Checked = True Then
                        If intHours <= intHourLimit_A Then  ' determine if max hours have been reached
                            dblSubtotal = dblPackage_A
                        Else
                            intOverLimitHourCount = CInt(intHours - intHourLimit_A)     ' Figure out how many extra hours
                            dblSubtotal = dblPackage_A + (intOverLimitHourCount * dblExtraHours_A) ' Calculate those into price
                        End If
                    ElseIf radPkgB.Checked = True Then  ' Package B
                        If intHours <= intHourLimit_B Then  ' determine if max hours have been reached
                            dblSubtotal = dblPackage_B
                        Else
                            intOverLimitHourCount = CInt(intHours - intHourLimit_B) ' Figure out how many extra hours
                            dblSubtotal = dblPackage_B + (intOverLimitHourCount * dblExtraHours_B) ' Calculate those into price
                        End If
                    Else
                        dblSubtotal = dblPackage_C      ' Package C
                    End If

                    If chkNonprofitOrg.Checked = True Then ' If NON profit is checked
                        dblTempAmount = dblSubtotal * dblNonprofitDiscount
                        dblTotal = dblSubtotal - dblTempAmount
                    Else
                        dblTotal = dblSubtotal
                    End If

                    lblAmountDue.Text = dblTotal.ToString("c")  ' Add to the lbl for display

                End If
            Else
                MessageBox.Show("Please enter only numbers.")
                txtNumHours.Clear()
                txtNumHours.Focus()
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Please enter a number")
            txtNumHours.Clear()
            txtNumHours.Focus()
        End Try
    End Sub
End Class
