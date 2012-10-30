Public Class FormEquipmentHistory
    Dim _EquipHistory As New EquipHistoryCollection

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me._EquipHistory = EquipHistoryCollection.QueryDatabase()
        Me.DataGridViewEquipHistory.DataSource = Me._EquipHistory
        Me.LabelCount.Text = String.Format("Record Count: {0}", Me._EquipHistory.Count)

    End Sub

End Class