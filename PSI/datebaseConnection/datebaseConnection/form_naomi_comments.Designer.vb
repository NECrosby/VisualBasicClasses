<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NaomiPractice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridViewMoveData = New System.Windows.Forms.DataGridView
        Me.BitmapDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.MovedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovedMachineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovedLotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovedEmpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovedStatus1CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovedCommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovedDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonEquipmentHistory = New System.Windows.Forms.Button
        Me.LabelCount = New System.Windows.Forms.Label
        CType(Me.DataGridViewMoveData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovedDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Query"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewMoveData
        '
        Me.DataGridViewMoveData.AutoGenerateColumns = False
        Me.DataGridViewMoveData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMoveData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BitmapDataGridViewImageColumn, Me.MovedDateTimeDataGridViewTextBoxColumn, Me.MovedMachineDataGridViewTextBoxColumn, Me.MovedLotDataGridViewTextBoxColumn, Me.MovedEmpidDataGridViewTextBoxColumn, Me.MovedStatus1CodeDataGridViewTextBoxColumn, Me.MovedCommentsDataGridViewTextBoxColumn})
        Me.DataGridViewMoveData.DataSource = Me.MovedDataBindingSource
        Me.DataGridViewMoveData.Location = New System.Drawing.Point(59, 53)
        Me.DataGridViewMoveData.Name = "DataGridViewMoveData"
        Me.DataGridViewMoveData.Size = New System.Drawing.Size(860, 409)
        Me.DataGridViewMoveData.TabIndex = 1
        '
        'BitmapDataGridViewImageColumn
        '
        Me.BitmapDataGridViewImageColumn.DataPropertyName = "Bitmap"
        Me.BitmapDataGridViewImageColumn.HeaderText = "Bitmap"
        Me.BitmapDataGridViewImageColumn.Name = "BitmapDataGridViewImageColumn"
        '
        'MovedDateTimeDataGridViewTextBoxColumn
        '
        Me.MovedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "MovedDateTime"
        Me.MovedDateTimeDataGridViewTextBoxColumn.HeaderText = "MovedDateTime"
        Me.MovedDateTimeDataGridViewTextBoxColumn.Name = "MovedDateTimeDataGridViewTextBoxColumn"
        '
        'MovedMachineDataGridViewTextBoxColumn
        '
        Me.MovedMachineDataGridViewTextBoxColumn.DataPropertyName = "MovedMachine"
        Me.MovedMachineDataGridViewTextBoxColumn.HeaderText = "MovedMachine"
        Me.MovedMachineDataGridViewTextBoxColumn.Name = "MovedMachineDataGridViewTextBoxColumn"
        '
        'MovedLotDataGridViewTextBoxColumn
        '
        Me.MovedLotDataGridViewTextBoxColumn.DataPropertyName = "MovedLot"
        Me.MovedLotDataGridViewTextBoxColumn.HeaderText = "MovedLot"
        Me.MovedLotDataGridViewTextBoxColumn.Name = "MovedLotDataGridViewTextBoxColumn"
        '
        'MovedEmpidDataGridViewTextBoxColumn
        '
        Me.MovedEmpidDataGridViewTextBoxColumn.DataPropertyName = "MovedEmpid"
        Me.MovedEmpidDataGridViewTextBoxColumn.HeaderText = "MovedEmpid"
        Me.MovedEmpidDataGridViewTextBoxColumn.Name = "MovedEmpidDataGridViewTextBoxColumn"
        '
        'MovedStatus1CodeDataGridViewTextBoxColumn
        '
        Me.MovedStatus1CodeDataGridViewTextBoxColumn.DataPropertyName = "MovedStatus1Code"
        Me.MovedStatus1CodeDataGridViewTextBoxColumn.HeaderText = "MovedStatus1Code"
        Me.MovedStatus1CodeDataGridViewTextBoxColumn.Name = "MovedStatus1CodeDataGridViewTextBoxColumn"
        '
        'MovedCommentsDataGridViewTextBoxColumn
        '
        Me.MovedCommentsDataGridViewTextBoxColumn.DataPropertyName = "MovedComments"
        Me.MovedCommentsDataGridViewTextBoxColumn.HeaderText = "MovedComments"
        Me.MovedCommentsDataGridViewTextBoxColumn.Name = "MovedCommentsDataGridViewTextBoxColumn"
        '
        'MovedDataBindingSource
        '
        Me.MovedDataBindingSource.DataSource = GetType(datebaseConnection.movedData)
        '
        'ButtonEquipmentHistory
        '
        Me.ButtonEquipmentHistory.Location = New System.Drawing.Point(140, 12)
        Me.ButtonEquipmentHistory.Name = "ButtonEquipmentHistory"
        Me.ButtonEquipmentHistory.Size = New System.Drawing.Size(117, 23)
        Me.ButtonEquipmentHistory.TabIndex = 3
        Me.ButtonEquipmentHistory.Text = "Equip History"
        Me.ButtonEquipmentHistory.UseVisualStyleBackColor = True
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(263, 17)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(79, 13)
        Me.LabelCount.TabIndex = 4
        Me.LabelCount.Text = "Record Count: "
        '
        'NaomiPractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 490)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.ButtonEquipmentHistory)
        Me.Controls.Add(Me.DataGridViewMoveData)
        Me.Controls.Add(Me.Button1)
        Me.Name = "NaomiPractice"
        Me.Text = "Naomi's Practice"
        CType(Me.DataGridViewMoveData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovedDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewMoveData As System.Windows.Forms.DataGridView
    Friend WithEvents BitmapDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MovedDateTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovedMachineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovedLotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovedEmpidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovedStatus1CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovedCommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovedDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonEquipmentHistory As System.Windows.Forms.Button
    Friend WithEvents LabelCount As System.Windows.Forms.Label

End Class
