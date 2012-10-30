Public Class FormMain
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ClearForm()
        LabelFirstNameValue.Text = String.Empty
        LabelLastNameValue.Text = String.Empty
        LabelIDNumberValue.Text = String.Empty
        LabelTestAverageValue.Text = String.Empty
        LabelTestGradeValue.Text = String.Empty
    End Sub

    Private Sub UpdateListBox()
        ListBoxIDNumbers.Items.Clear()
        Dim myStudent As Student
        For Each myStudent In studentCollection
            ListBoxIDNumbers.Items.Add(myStudent.ID)
        Next

        If ListBoxIDNumbers.SelectedIndex > 0 Then
            ListBoxIDNumbers.SelectedIndex = 0
        Else
            ClearForm()
        End If
    End Sub

    Private Sub DisplayData(ByVal myStudent As Student)
        LabelLastNameValue.Text = myStudent.LastName
        LabelFirstNameValue.Text = myStudent.FirstName
        LabelIDNumberValue.Text = myStudent.ID
        LabelTestAverageValue.Text = myStudent.TestAverage.ToString
        LabelTestGradeValue.Text = myStudent.Grade
    End Sub

    Private Sub ButtonAddStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddStudent.Click
        Dim frmAddStudent As New FormAddStudent
        frmAddStudent.ShowDialog()
        UpdateListBox()
    End Sub

    Private Sub ButtonRemoveStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemoveStudent.Click
        Dim index As Integer

        If ListBoxIDNumbers.SelectedIndex <> -1 Then
            If MessageBox.Show("Are you sure?", "Confirm Deletion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                index = ListBoxIDNumbers.SelectedIndex
                Try
                    studentCollection.Remove(ListBoxIDNumbers.SelectedItem.ToString)
                    UpdateListBox()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ListBoxIDNumbers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxIDNumbers.SelectedIndexChanged
        Dim myStudent As Student
        If ListBoxIDNumbers.SelectedIndex <> -1 Then
            Try
                myStudent = DirectCast(studentCollection.Item(ListBoxIDNumbers.SelectedItem), Student)
                DisplayData(myStudent)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class