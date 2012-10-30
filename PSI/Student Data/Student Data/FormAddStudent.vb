Imports System.IO

Public Class FormAddStudent
    Private Sub GetData(ByVal student As Student)
        Try
            student.LastName = TextBoxLastName.Text
            student.FirstName = TextBoxFirstName.Text
            student.ID = TextBoxIDNumber.Text
            student.TestAverage = System.Convert.ToDouble(TextBoxTestAverage.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub SaveRecord(ByVal student As Student)
    '    Dim writer As StreamWriter

    '    Try
    '        writer = File.AppendText("Students.txt")

    '        writer.WriteLine(student.ID)
    '        writer.WriteLine(student.FirstName)
    '        writer.WriteLine(student.LastName)
    '        writer.WriteLine(student.TestAverage.ToString)
    '        writer.WriteLine(student.Grade)

    '        writer.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub ClearForm()
        TextBoxFirstName.Text = String.Empty
        TextBoxLastName.Text = String.Empty
        TextBoxIDNumber.Text = String.Empty
        TextBoxTestAverage.Text = String.Empty
        LabelGrade.Text = String.Empty
        TextBoxLastName.Focus()
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Dim myStudent As New Student
        GetData(myStudent)
        LabelGrade.Text = myStudent.Grade
        AddRecord(myStudent)
        MessageBox.Show("Student record added.")
        ClearForm()

    End Sub


    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    'Private Sub form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Debug.Listeners.Add(New ConsoleTraceListener)
    'End Sub
End Class
