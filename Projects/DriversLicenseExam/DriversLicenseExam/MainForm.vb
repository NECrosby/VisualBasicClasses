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
        frmResults.ShowDialog()
    End Sub
    ' I decided so that I could turn this in NOW and get going on Chapter 9 to do it the "easy" way but this is majorly
    ' annoying. To loop through the controls or be able to ask the Group Box Control what control is the sender would be 
    ' much cleaner. I will try that at some point though because NOW I want to KNOW! 
    Private Sub txtAnswer0_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer0.KeyPress
        ' 65-68 : (A to D) Or (a to d) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer1.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer2.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer3.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer4.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer5.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer6.KeyPress
       ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer7.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer8.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer9.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer10.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer11.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer12.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer13.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer14.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer15.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer16.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer17_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer17.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer18_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer18.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAnswer19_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer19.KeyPress
        ' 65-68 : (A to D) allowed
        ' Or backspace(8) or spacebar(32) or enter(13)
        If (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 68) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 100) Or _
            Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAnswer0_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer0.TextChanged
        If txtAnswer0.TextLength = txtAnswer0.MaxLength Then
            txtAnswer1.Focus()
        End If
    End Sub
    Private Sub txtAnswer1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer1.TextChanged
        If txtAnswer1.TextLength = txtAnswer1.MaxLength Then
            txtAnswer2.Focus()
        End If
    End Sub
    Private Sub txtAnswer2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer2.TextChanged
        If txtAnswer2.TextLength = txtAnswer2.MaxLength Then
            txtAnswer3.Focus()
        End If
    End Sub
    Private Sub txtAnswer3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer3.TextChanged
        If txtAnswer3.TextLength = txtAnswer3.MaxLength Then
            txtAnswer4.Focus()
        End If
    End Sub
    Private Sub txtAnswer4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer4.TextChanged
        If txtAnswer4.TextLength = txtAnswer4.MaxLength Then
            txtAnswer5.Focus()
        End If
    End Sub
    Private Sub txtAnswer5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer5.TextChanged
        If txtAnswer5.TextLength = txtAnswer5.MaxLength Then
            txtAnswer6.Focus()
        End If
    End Sub
    Private Sub txtAnswer6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer6.TextChanged
        If txtAnswer6.TextLength = txtAnswer6.MaxLength Then
            txtAnswer7.Focus()
        End If
    End Sub
    Private Sub txtAnswer7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer7.TextChanged
        If txtAnswer7.TextLength = txtAnswer7.MaxLength Then
            txtAnswer8.Focus()
        End If
    End Sub
    Private Sub txtAnswer8_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer8.TextChanged
        If txtAnswer8.TextLength = txtAnswer8.MaxLength Then
            txtAnswer9.Focus()
        End If
    End Sub
    Private Sub txtAnswer9_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer9.TextChanged
        If txtAnswer9.TextLength = txtAnswer9.MaxLength Then
            txtAnswer10.Focus()
        End If
    End Sub
    Private Sub txtAnswer10_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer10.TextChanged
        If txtAnswer10.TextLength = txtAnswer10.MaxLength Then
            txtAnswer11.Focus()
        End If
    End Sub
    Private Sub txtAnswer11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer11.TextChanged
        If txtAnswer11.TextLength = txtAnswer11.MaxLength Then
            txtAnswer12.Focus()
        End If
    End Sub
    Private Sub txtAnswer12_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer12.TextChanged
        If txtAnswer12.TextLength = txtAnswer12.MaxLength Then
            txtAnswer13.Focus()
        End If
    End Sub
    Private Sub txtAnswer13_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer13.TextChanged
        If txtAnswer13.TextLength = txtAnswer13.MaxLength Then
            txtAnswer14.Focus()
        End If
    End Sub
    Private Sub txtAnswer14_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer14.TextChanged
        If txtAnswer14.TextLength = txtAnswer14.MaxLength Then
            txtAnswer15.Focus()
        End If
    End Sub
    Private Sub txtAnswer15_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer15.TextChanged
        If txtAnswer15.TextLength = txtAnswer15.MaxLength Then
            txtAnswer16.Focus()
        End If
    End Sub
    Private Sub txtAnswer16_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer16.TextChanged
        If txtAnswer16.TextLength = txtAnswer16.MaxLength Then
            txtAnswer17.Focus()
        End If
    End Sub
    Private Sub txtAnswer17_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer17.TextChanged
        If txtAnswer17.TextLength = txtAnswer17.MaxLength Then
            txtAnswer18.Focus()
        End If
    End Sub
    Private Sub txtAnswer18_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer18.TextChanged
        If txtAnswer18.TextLength = txtAnswer18.MaxLength Then
            txtAnswer19.Focus()
        End If
    End Sub
    Private Sub txtAnswer19_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer19.TextChanged
        If txtAnswer19.TextLength = txtAnswer19.MaxLength Then
            btnScoreExam.Focus()
        End If
    End Sub
End Class

' Testing Control Use for Validation
' -----------------------------------------------------------------------------------------------------------------------
'Sub InputValidation()
'    Dim control As Control
'    If control.Text <> ((control.Text <> "A") Or ((control.Text <> "B") Or ((control.Text <> "C") Or (control.Text <> "D")))) Then
'        MessageBox.Show("A, B, C, or D are the only valid answers")
'        control.Focus()
'    End If
'End Sub
' -----------------------------------------------------------------------------------------------------------------------
'Private Sub gbxAnswers_TextChanged(sender As Object, e As System.EventArgs) Handles gbxAnswers.TextChanged
'    'If gbxAnswers.Controls.OfType(TextBox Then

'    'End If

'    ' within the groupbox determine which sender is causing the event to valid input
'    ' sender.name <-- 
'    'gbxAnswers.Controls.
'    sender.ReferenceEquals(TextBox)

' The below was located in the "Sub InputValidation()"
'For intCount = 0 To intMAX_SUBSCRIPT
'    For Each control As Control In gbxAnswers.Controls
'        If TypeOf control Is TextBox Then
'            If control.TabIndex = intCount And ((control.Text <> "A") Or ((control.Text <> "B") Or ((control.Text <> "C") Or (control.Text <> "D")))) Then
'                MessageBox.Show("A, B, C, or D are the only valid answers")
'                control.Focus()
'            End If
'        End If
'    Next
'Next

'End Sub
' -----------------------------------------------------------------------------------------------------------------------
'Private Sub txtAnswer0_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnswer0.TextChanged
'    If Not System.Windows.Forms.Keys.A And Not _
'        System.Windows.Forms.Keys.B And Not _
'        System.Windows.Forms.Keys.C And Not _
'        System.Windows.Forms.Keys.D And Not _
'        System.Windows.Forms.Keys.Back And Not _
'        System.Windows.Forms.Keys.Delete Then
'        MessageBox.Show("A, B, C, or D are the only valid answers")
'        '   txtAnswer0.Text = String.Empty
'        '  txtAnswer0.Focus()
'        txtAnswer0.SelectAll()

'    End If
'End Sub
' -----------------------------------------------------------------------------------------------------------------------
' Testing Purposes
' Dim myCharExam As String = String.Empty
' For count = 0 To intMAX_SUBSCRIPT
' myCharExam += charExam(count) + " "
' Next
' MessageBox.Show(myCharExam)
