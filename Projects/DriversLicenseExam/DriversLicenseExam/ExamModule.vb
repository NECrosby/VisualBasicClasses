Module ExamModule
    Public frmResults As New ResultForm

    Public _intCorrectCount As Integer = 0
    Public Const intMAX_SUBSCRIPT As Integer = 19
    Public charExam(intMAX_SUBSCRIPT) As Char
    Public charResultScores(intMAX_SUBSCRIPT) As Char
    Public boolIsCorrect(intMAX_SUBSCRIPT) As Boolean
    Public charAnswerKey() As Char = {"B", "D", "A", "A", "C", _
                                       "A", "B", "A", "C", "D", _
                                       "B", "C", "D", "A", "D", _
                                       "C", "C", "B", "D", "A"}

    Sub ClearAnswerBoxes()
        For intCount = 0 To MainForm.gbxAnswers.Controls.Count - 1
            For Each control As Control In MainForm.gbxAnswers.Controls
                If TypeOf control Is TextBox Then
                    control.Text = String.Empty
                End If
            Next
        Next
        MainForm.txtAnswer0.Focus()
    End Sub
End Module
