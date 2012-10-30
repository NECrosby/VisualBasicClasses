Option Strict On
Option Explicit On

Public Class FormUserList
    Dim _employees As EmployeeCollection

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._employees = New EmployeeCollection
    End Sub

    Private Sub ButtonQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuery.Click
        Me._employees = EmployeeCollection.QueryDatabase()
        Me.DataGridViewEmployees.DataSource = Me._employees
        Me.LabelCount.Text = String.Format("Record Count: {0}", Me._employees.Count)
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonCalculatePDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalculatePDO.Click
        Dim formCalculatePDO As New FormCalculatePDO(_employees)
        formCalculatePDO.Show()
    End Sub
End Class
