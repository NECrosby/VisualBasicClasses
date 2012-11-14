Public Class ResultForm

    Private Sub btnResultClose_Click(sender As System.Object, e As System.EventArgs) Handles btnResultClose.Click
        Me.Close()
    End Sub

    Private Sub ResultForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ClearAnswerBoxes()
        MainForm.txtAnswer0.Focus()
    End Sub

    Private Sub ResultForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Load the txtResults from Results Array
        ' Change Status label to read Pass/Fail and Test Score XX/20 Correct.
        CompareExamToAnswerKey()
        FillResultForm()
        If _intCorrectCount > 14 Then
            lblResultStatus.Text = "Exam Passed: " & _intCorrectCount & " correct / 20 Questions"
            lblFailedWarning.Hide()
        Else
            lblResultStatus.Text = "Exam Failed: " & _intCorrectCount & " correct / 20 Questions"
            lblFailedWarning.Show()
            lblFailedWarning.Enabled = True
        End If
        btnResultClose.Focus()

    End Sub

    Sub CompareExamToAnswerKey()
        ' Compare Answers(Exam) to AnswerKey 
        ' If Answer Is Correct Then increment Correct Counter & Copy answer element into Results
        ' If Answer is INcorrect then copy answerKey element into Results & change text color to red.
        For intCount = 0 To intMAX_SUBSCRIPT
            If charExam(intCount).Equals(charAnswerKey(intCount)) Then
                charResultScores(intCount) = charExam(intCount)
                boolIsCorrect(intCount) = True
                _intCorrectCount += 1
            Else
                charResultScores(intCount) = charAnswerKey(intCount)
                boolIsCorrect(intCount) = False
            End If
        Next
    End Sub
    Sub FillResultForm()
        For intCount = 0 To intMAX_SUBSCRIPT
            For Each control As Control In gbxResults.Controls
                If TypeOf control Is TextBox Then
                    If control.TabIndex = intCount Then
                        control.Text = charResultScores(intCount)
                        If boolIsCorrect(intCount) = False Then
                            control.ForeColor = Color.Red
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    ' Testing Purposes
    'Dim myCharExam As String = String.Empty
    'For count = 0 To intMAX_SUBSCRIPT
    '    myCharExam += charResultScores(count) + " "
    'Next
    'MessageBox.Show(myCharExam)

End Class