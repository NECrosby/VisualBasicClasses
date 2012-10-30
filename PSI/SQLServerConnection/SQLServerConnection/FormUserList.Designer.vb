<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserList
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
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.DataGridViewEmployees = New System.Windows.Forms.DataGridView
        Me.LabelCount = New System.Windows.Forms.Label
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.ButtonCalculatePDO = New System.Windows.Forms.Button
        CType(Me.DataGridViewEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(12, 12)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuery.TabIndex = 0
        Me.ButtonQuery.Text = "Query Users"
        Me.ButtonQuery.UseVisualStyleBackColor = True
        '
        'DataGridViewEmployees
        '
        Me.DataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmployees.Location = New System.Drawing.Point(12, 41)
        Me.DataGridViewEmployees.Name = "DataGridViewEmployees"
        Me.DataGridViewEmployees.Size = New System.Drawing.Size(1476, 716)
        Me.DataGridViewEmployees.TabIndex = 1
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.BackColor = System.Drawing.Color.White
        Me.LabelCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelCount.Location = New System.Drawing.Point(93, 14)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Padding = New System.Windows.Forms.Padding(2)
        Me.LabelCount.Size = New System.Drawing.Size(127, 19)
        Me.LabelCount.TabIndex = 3
        Me.LabelCount.Text = "Record Count:               "
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(1413, 777)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonCalculatePDO
        '
        Me.ButtonCalculatePDO.Location = New System.Drawing.Point(243, 12)
        Me.ButtonCalculatePDO.Name = "ButtonCalculatePDO"
        Me.ButtonCalculatePDO.Size = New System.Drawing.Size(92, 23)
        Me.ButtonCalculatePDO.TabIndex = 5
        Me.ButtonCalculatePDO.Text = "Calculate PDO"
        Me.ButtonCalculatePDO.UseVisualStyleBackColor = True
        '
        'FormUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1500, 822)
        Me.Controls.Add(Me.ButtonCalculatePDO)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.DataGridViewEmployees)
        Me.Controls.Add(Me.ButtonQuery)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormUserList"
        Me.Text = "SQL Server Connection: User List"
        CType(Me.DataGridViewEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents DataGridViewEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonCalculatePDO As System.Windows.Forms.Button

End Class
