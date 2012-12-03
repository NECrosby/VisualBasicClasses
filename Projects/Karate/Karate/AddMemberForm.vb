Public Class AddMemberForm

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MembersDataSet)

    End Sub

    Private Sub AddMemberForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MembersBindingSource.AddNew()
        Date_JoinedDateTimePicker.Value = Today()
    End Sub

    Private Sub mnuFileSaveclose_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileSaveclose.Click
        Try
            Me.MembersBindingSource.EndEdit()
            Me.MembersTableAdapter.Update(MembersDataSet.Members)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub mnuFileCloseNoSave_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileCloseNoSave.Click
        Me.MembersBindingSource.CancelEdit()
        Me.Close()
    End Sub
End Class