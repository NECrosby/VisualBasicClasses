Public Class MainForm
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ' Clear all answers & reset focus to Question 1
        ClearAnswerBoxes()
    End Sub

    Private Sub btnScoreExam_Click(sender As System.Object, e As System.EventArgs) Handles btnScoreExam.Click
        ' Show Results form after all questions have been answered
        For intCount = 0 To intMAX_SUBSCRIPT
            For Each control As Control In gbxAnswers.Controls
                If TypeOf control Is TextBox Then
                    If control.TabIndex = intCount Then
                        charExam(intCount) = control.Text
                    End If
                End If
            Next
        Next
        'InputValidation()
        frmResults.ShowDialog()
    End Sub

    Sub ClearAnswerBoxes()
        For intCount = 0 To gbxAnswers.Controls.Count - 1
            For Each control As Control In gbxAnswers.Controls
                If TypeOf control Is TextBox Then
                    control.Text = String.Empty
                End If
            Next
        Next
        txtAnswer0.Focus()
    End Sub

    Private Sub txtAnswer0_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtAnswer0.KeyDown
        If Not System.Windows.Forms.Keys.A And Not _
            System.Windows.Forms.Keys.B And Not _
            System.Windows.Forms.Keys.C And Not _
            System.Windows.Forms.Keys.D And Not _
            System.Windows.Forms.Keys.Back And Not _
            System.Windows.Forms.Keys.Delete Then
            MessageBox.Show("A, B, C, or D are the only valid answers")
            txtAnswer0.Text = String.Empty
            txtAnswer0.Focus()
        End If
    End Sub

    'Sub InputValidation()
    '    Dim control As Control
    '    If control.Text <> ((control.Text <> "A") Or ((control.Text <> "B") Or ((control.Text <> "C") Or (control.Text <> "D")))) Then
    '        MessageBox.Show("A, B, C, or D are the only valid answers")
    '        control.Focus()
    '    End If

    '    'For intCount = 0 To intMAX_SUBSCRIPT
    '    '    For Each control As Control In gbxAnswers.Controls
    '    '        If TypeOf control Is TextBox Then
    '    '            If control.TabIndex = intCount And ((control.Text <> "A") Or ((control.Text <> "B") Or ((control.Text <> "C") Or (control.Text <> "D")))) Then
    '    '                MessageBox.Show("A, B, C, or D are the only valid answers")
    '    '                control.Focus()
    '    '            End If
    '    '        End If
    '    '    Next
    '    'Next

    'End Sub
End Class


' Testing Purposes
' Dim myCharExam As String = String.Empty
' For count = 0 To intMAX_SUBSCRIPT
' myCharExam += charExam(count) + " "
' Next
' MessageBox.Show(myCharExam)
