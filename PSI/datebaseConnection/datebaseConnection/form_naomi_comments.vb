Public Class NaomiPractice 'this is the title of the window and/or the Class title. 
    Dim _MoveDatas As New movedDataCollection  'Collection Object

    '---------------------------------------------------
    ' Query Button Event Handler for Button Click                         
    '---------------------------------------------------

    'This is the event handler Button1 is the button on the window to click, if the button is clicked execute the QueryDatabase function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me._MoveDatas = movedDataCollection.QueryDatabase()
        Me.DataGridViewMoveData.DataSource = Me._MoveDatas
        Me.LabelCount.Text = String.Format("Record Count: {0}", Me._MoveDatas.Count)
        'With DataGridViewMoveData
        '    '.Columns("type").Visible = False
        '    .Columns("BitmapDataGridViewImageColumn").DisplayIndex = 0
        '    .Columns("MovedDateTimeDataGridViewTextBoxColumn").DisplayIndex = 1
        '    .Columns("MovedMachineDataGridViewTextBoxColumn").DisplayIndex = 2
        '    .Columns("MovedLotDataGridViewTextBoxColumn").DisplayIndex = 3
        '    .Columns("MovedEmpidDataGridViewTextBoxColumn").DisplayIndex = 4
        '    .Columns("MovedStatus1CodeDataGridViewTextBoxColumn").DisplayIndex = 5
        '    .Columns("MovedCommentsDataGridViewTextBoxColumn").DisplayIndex = 6
        'End With
    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    '---------------------------------------------------
    ' Equip History Button Event Handler for Button Click                         
    '---------------------------------------------------
    Private Sub ButtonEquipmentHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEquipmentHistory.Click
        Dim frmEquipHistory As New FormEquipmentHistory
        frmEquipHistory.Show()

    End Sub

End Class

