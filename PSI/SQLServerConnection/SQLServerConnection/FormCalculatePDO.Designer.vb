<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculatePDO
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
        Me.ButtonCalculatePDO = New System.Windows.Forms.Button
        Me.LabelEmpID = New System.Windows.Forms.Label
        Me.LabelAmountOfPDO = New System.Windows.Forms.Label
        Me.LabelAmountOfYearsOfService = New System.Windows.Forms.Label
        Me.LabelEmployeeFullName = New System.Windows.Forms.Label
        Me.LabelEmployeeHireDate = New System.Windows.Forms.Label
        Me.LabelTermDate = New System.Windows.Forms.Label
        Me.GroupBoxEmployeeInfo = New System.Windows.Forms.GroupBox
        Me.TextBoxTerminationDate = New System.Windows.Forms.TextBox
        Me.TextBoxHireDate = New System.Windows.Forms.TextBox
        Me.TextBoxEmployeeFullName = New System.Windows.Forms.TextBox
        Me.TextBoxEmployeeID = New System.Windows.Forms.TextBox
        Me.ButtonExitCalculate = New System.Windows.Forms.Button
        Me.ButtonGetEmployeeInfo = New System.Windows.Forms.Button
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.GroupBoxEmployeeInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCalculatePDO
        '
        Me.ButtonCalculatePDO.Location = New System.Drawing.Point(109, 275)
        Me.ButtonCalculatePDO.Name = "ButtonCalculatePDO"
        Me.ButtonCalculatePDO.Size = New System.Drawing.Size(75, 38)
        Me.ButtonCalculatePDO.TabIndex = 0
        Me.ButtonCalculatePDO.Text = "Calculate Paid Days Off"
        Me.ButtonCalculatePDO.UseVisualStyleBackColor = True
        '
        'LabelEmpID
        '
        Me.LabelEmpID.AutoSize = True
        Me.LabelEmpID.Location = New System.Drawing.Point(18, 27)
        Me.LabelEmpID.Name = "LabelEmpID"
        Me.LabelEmpID.Size = New System.Drawing.Size(99, 13)
        Me.LabelEmpID.TabIndex = 1
        Me.LabelEmpID.Text = "Employee Number: "
        '
        'LabelAmountOfPDO
        '
        Me.LabelAmountOfPDO.AutoSize = True
        Me.LabelAmountOfPDO.Location = New System.Drawing.Point(28, 240)
        Me.LabelAmountOfPDO.Name = "LabelAmountOfPDO"
        Me.LabelAmountOfPDO.Size = New System.Drawing.Size(190, 13)
        Me.LabelAmountOfPDO.TabIndex = 2
        Me.LabelAmountOfPDO.Text = "You will earn __ days of PDO this year."
        Me.LabelAmountOfPDO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelAmountOfPDO.Visible = False
        '
        'LabelAmountOfYearsOfService
        '
        Me.LabelAmountOfYearsOfService.AutoSize = True
        Me.LabelAmountOfYearsOfService.Location = New System.Drawing.Point(28, 199)
        Me.LabelAmountOfYearsOfService.Name = "LabelAmountOfYearsOfService"
        Me.LabelAmountOfYearsOfService.Size = New System.Drawing.Size(243, 13)
        Me.LabelAmountOfYearsOfService.TabIndex = 3
        Me.LabelAmountOfYearsOfService.Text = "You have served __ years of service.  Thank you."
        Me.LabelAmountOfYearsOfService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelAmountOfYearsOfService.Visible = False
        '
        'LabelEmployeeFullName
        '
        Me.LabelEmployeeFullName.AutoSize = True
        Me.LabelEmployeeFullName.Location = New System.Drawing.Point(29, 57)
        Me.LabelEmployeeFullName.Name = "LabelEmployeeFullName"
        Me.LabelEmployeeFullName.Size = New System.Drawing.Size(90, 13)
        Me.LabelEmployeeFullName.TabIndex = 4
        Me.LabelEmployeeFullName.Text = "Employee Name: "
        Me.LabelEmployeeFullName.Visible = False
        '
        'LabelEmployeeHireDate
        '
        Me.LabelEmployeeHireDate.AutoSize = True
        Me.LabelEmployeeHireDate.Location = New System.Drawing.Point(61, 87)
        Me.LabelEmployeeHireDate.Name = "LabelEmployeeHireDate"
        Me.LabelEmployeeHireDate.Size = New System.Drawing.Size(58, 13)
        Me.LabelEmployeeHireDate.TabIndex = 5
        Me.LabelEmployeeHireDate.Text = "Hire Date: "
        Me.LabelEmployeeHireDate.Visible = False
        '
        'LabelTermDate
        '
        Me.LabelTermDate.AutoSize = True
        Me.LabelTermDate.Location = New System.Drawing.Point(25, 116)
        Me.LabelTermDate.Name = "LabelTermDate"
        Me.LabelTermDate.Size = New System.Drawing.Size(94, 13)
        Me.LabelTermDate.TabIndex = 6
        Me.LabelTermDate.Text = "Termination Date: "
        Me.LabelTermDate.Visible = False
        '
        'GroupBoxEmployeeInfo
        '
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.TextBoxTerminationDate)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.TextBoxHireDate)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.TextBoxEmployeeFullName)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.TextBoxEmployeeID)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.LabelEmpID)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.LabelTermDate)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.LabelEmployeeFullName)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.LabelEmployeeHireDate)
        Me.GroupBoxEmployeeInfo.Location = New System.Drawing.Point(22, 24)
        Me.GroupBoxEmployeeInfo.Name = "GroupBoxEmployeeInfo"
        Me.GroupBoxEmployeeInfo.Size = New System.Drawing.Size(395, 151)
        Me.GroupBoxEmployeeInfo.TabIndex = 7
        Me.GroupBoxEmployeeInfo.TabStop = False
        Me.GroupBoxEmployeeInfo.Text = "Employee Data"
        '
        'TextBoxTerminationDate
        '
        Me.TextBoxTerminationDate.Location = New System.Drawing.Point(119, 113)
        Me.TextBoxTerminationDate.Name = "TextBoxTerminationDate"
        Me.TextBoxTerminationDate.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxTerminationDate.TabIndex = 10
        Me.TextBoxTerminationDate.Visible = False
        '
        'TextBoxHireDate
        '
        Me.TextBoxHireDate.Location = New System.Drawing.Point(119, 84)
        Me.TextBoxHireDate.Name = "TextBoxHireDate"
        Me.TextBoxHireDate.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxHireDate.TabIndex = 9
        Me.TextBoxHireDate.Visible = False
        '
        'TextBoxEmployeeFullName
        '
        Me.TextBoxEmployeeFullName.Location = New System.Drawing.Point(119, 54)
        Me.TextBoxEmployeeFullName.Name = "TextBoxEmployeeFullName"
        Me.TextBoxEmployeeFullName.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxEmployeeFullName.TabIndex = 8
        Me.TextBoxEmployeeFullName.Visible = False
        '
        'TextBoxEmployeeID
        '
        Me.TextBoxEmployeeID.Location = New System.Drawing.Point(119, 24)
        Me.TextBoxEmployeeID.Name = "TextBoxEmployeeID"
        Me.TextBoxEmployeeID.Size = New System.Drawing.Size(233, 20)
        Me.TextBoxEmployeeID.TabIndex = 7
        '
        'ButtonExitCalculate
        '
        Me.ButtonExitCalculate.Location = New System.Drawing.Point(299, 275)
        Me.ButtonExitCalculate.Name = "ButtonExitCalculate"
        Me.ButtonExitCalculate.Size = New System.Drawing.Size(75, 38)
        Me.ButtonExitCalculate.TabIndex = 8
        Me.ButtonExitCalculate.Text = "Exit"
        Me.ButtonExitCalculate.UseVisualStyleBackColor = True
        '
        'ButtonGetEmployeeInfo
        '
        Me.ButtonGetEmployeeInfo.Location = New System.Drawing.Point(22, 275)
        Me.ButtonGetEmployeeInfo.Name = "ButtonGetEmployeeInfo"
        Me.ButtonGetEmployeeInfo.Size = New System.Drawing.Size(75, 38)
        Me.ButtonGetEmployeeInfo.TabIndex = 9
        Me.ButtonGetEmployeeInfo.Text = "Find Employee"
        Me.ButtonGetEmployeeInfo.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(206, 275)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 38)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'FormCalculatePDO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 325)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonGetEmployeeInfo)
        Me.Controls.Add(Me.ButtonExitCalculate)
        Me.Controls.Add(Me.GroupBoxEmployeeInfo)
        Me.Controls.Add(Me.LabelAmountOfYearsOfService)
        Me.Controls.Add(Me.LabelAmountOfPDO)
        Me.Controls.Add(Me.ButtonCalculatePDO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormCalculatePDO"
        Me.Text = "Calculate Earned Paid Days Off"
        Me.GroupBoxEmployeeInfo.ResumeLayout(False)
        Me.GroupBoxEmployeeInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCalculatePDO As System.Windows.Forms.Button
    Friend WithEvents LabelEmpID As System.Windows.Forms.Label
    Friend WithEvents LabelAmountOfPDO As System.Windows.Forms.Label
    Friend WithEvents LabelAmountOfYearsOfService As System.Windows.Forms.Label
    Friend WithEvents LabelEmployeeFullName As System.Windows.Forms.Label
    Friend WithEvents LabelEmployeeHireDate As System.Windows.Forms.Label
    Friend WithEvents LabelTermDate As System.Windows.Forms.Label
    Friend WithEvents GroupBoxEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTerminationDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHireDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmployeeFullName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents ButtonExitCalculate As System.Windows.Forms.Button
    Friend WithEvents ButtonGetEmployeeInfo As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
End Class
