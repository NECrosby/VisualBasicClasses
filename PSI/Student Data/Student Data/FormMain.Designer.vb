<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.GroupBoxStudentData = New System.Windows.Forms.GroupBox
        Me.ListBoxIDNumbers = New System.Windows.Forms.ListBox
        Me.LabelLastNameValue = New System.Windows.Forms.Label
        Me.LabelFirstNameValue = New System.Windows.Forms.Label
        Me.LabelIDNumberValue = New System.Windows.Forms.Label
        Me.LabelTestGradeValue = New System.Windows.Forms.Label
        Me.LabelTestAverageValue = New System.Windows.Forms.Label
        Me.LabelTestGrade = New System.Windows.Forms.Label
        Me.LabelTestAverage = New System.Windows.Forms.Label
        Me.LabelIDNumber = New System.Windows.Forms.Label
        Me.LabelFirstName = New System.Windows.Forms.Label
        Me.LabelLastName = New System.Windows.Forms.Label
        Me.ButtonAddStudent = New System.Windows.Forms.Button
        Me.ButtonRemoveStudent = New System.Windows.Forms.Button
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.GroupBoxStudentData.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxStudentData
        '
        Me.GroupBoxStudentData.Controls.Add(Me.ListBoxIDNumbers)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelLastNameValue)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelFirstNameValue)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelIDNumberValue)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelTestGradeValue)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelTestAverageValue)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelTestGrade)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelTestAverage)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelIDNumber)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelFirstName)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelLastName)
        Me.GroupBoxStudentData.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxStudentData.Name = "GroupBoxStudentData"
        Me.GroupBoxStudentData.Size = New System.Drawing.Size(463, 267)
        Me.GroupBoxStudentData.TabIndex = 3
        Me.GroupBoxStudentData.TabStop = False
        Me.GroupBoxStudentData.Text = "Students"
        '
        'ListBoxIDNumbers
        '
        Me.ListBoxIDNumbers.FormattingEnabled = True
        Me.ListBoxIDNumbers.Location = New System.Drawing.Point(25, 30)
        Me.ListBoxIDNumbers.Margin = New System.Windows.Forms.Padding(10)
        Me.ListBoxIDNumbers.Name = "ListBoxIDNumbers"
        Me.ListBoxIDNumbers.Size = New System.Drawing.Size(146, 212)
        Me.ListBoxIDNumbers.TabIndex = 14
        '
        'LabelLastNameValue
        '
        Me.LabelLastNameValue.AutoSize = True
        Me.LabelLastNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLastNameValue.Location = New System.Drawing.Point(285, 36)
        Me.LabelLastNameValue.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelLastNameValue.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LabelLastNameValue.Name = "LabelLastNameValue"
        Me.LabelLastNameValue.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelLastNameValue.Size = New System.Drawing.Size(150, 23)
        Me.LabelLastNameValue.TabIndex = 13
        '
        'LabelFirstNameValue
        '
        Me.LabelFirstNameValue.AutoSize = True
        Me.LabelFirstNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFirstNameValue.Location = New System.Drawing.Point(285, 79)
        Me.LabelFirstNameValue.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelFirstNameValue.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LabelFirstNameValue.Name = "LabelFirstNameValue"
        Me.LabelFirstNameValue.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelFirstNameValue.Size = New System.Drawing.Size(150, 23)
        Me.LabelFirstNameValue.TabIndex = 12
        '
        'LabelIDNumberValue
        '
        Me.LabelIDNumberValue.AutoSize = True
        Me.LabelIDNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelIDNumberValue.Location = New System.Drawing.Point(285, 122)
        Me.LabelIDNumberValue.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelIDNumberValue.MinimumSize = New System.Drawing.Size(150, 0)
        Me.LabelIDNumberValue.Name = "LabelIDNumberValue"
        Me.LabelIDNumberValue.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelIDNumberValue.Size = New System.Drawing.Size(150, 23)
        Me.LabelIDNumberValue.TabIndex = 11
        '
        'LabelTestGradeValue
        '
        Me.LabelTestGradeValue.AutoSize = True
        Me.LabelTestGradeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTestGradeValue.Location = New System.Drawing.Point(285, 208)
        Me.LabelTestGradeValue.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelTestGradeValue.MinimumSize = New System.Drawing.Size(40, 0)
        Me.LabelTestGradeValue.Name = "LabelTestGradeValue"
        Me.LabelTestGradeValue.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelTestGradeValue.Size = New System.Drawing.Size(40, 23)
        Me.LabelTestGradeValue.TabIndex = 10
        '
        'LabelTestAverageValue
        '
        Me.LabelTestAverageValue.AutoSize = True
        Me.LabelTestAverageValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTestAverageValue.Location = New System.Drawing.Point(285, 165)
        Me.LabelTestAverageValue.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelTestAverageValue.MinimumSize = New System.Drawing.Size(40, 0)
        Me.LabelTestAverageValue.Name = "LabelTestAverageValue"
        Me.LabelTestAverageValue.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelTestAverageValue.Size = New System.Drawing.Size(40, 23)
        Me.LabelTestAverageValue.TabIndex = 9
        '
        'LabelTestGrade
        '
        Me.LabelTestGrade.AutoSize = True
        Me.LabelTestGrade.Location = New System.Drawing.Point(209, 213)
        Me.LabelTestGrade.Name = "LabelTestGrade"
        Me.LabelTestGrade.Size = New System.Drawing.Size(63, 13)
        Me.LabelTestGrade.TabIndex = 8
        Me.LabelTestGrade.Text = "Test Grade:"
        '
        'LabelTestAverage
        '
        Me.LabelTestAverage.AutoSize = True
        Me.LabelTestAverage.Location = New System.Drawing.Point(198, 169)
        Me.LabelTestAverage.Name = "LabelTestAverage"
        Me.LabelTestAverage.Size = New System.Drawing.Size(74, 13)
        Me.LabelTestAverage.TabIndex = 6
        Me.LabelTestAverage.Text = "Test Average:"
        '
        'LabelIDNumber
        '
        Me.LabelIDNumber.AutoSize = True
        Me.LabelIDNumber.Location = New System.Drawing.Point(211, 127)
        Me.LabelIDNumber.Name = "LabelIDNumber"
        Me.LabelIDNumber.Size = New System.Drawing.Size(61, 13)
        Me.LabelIDNumber.TabIndex = 4
        Me.LabelIDNumber.Text = "ID Number:"
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(212, 83)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(60, 13)
        Me.LabelFirstName.TabIndex = 2
        Me.LabelFirstName.Text = "First Name:"
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Location = New System.Drawing.Point(211, 41)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(61, 13)
        Me.LabelLastName.TabIndex = 0
        Me.LabelLastName.Text = "Last Name:"
        '
        'ButtonAddStudent
        '
        Me.ButtonAddStudent.Location = New System.Drawing.Point(19, 292)
        Me.ButtonAddStudent.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonAddStudent.Name = "ButtonAddStudent"
        Me.ButtonAddStudent.Size = New System.Drawing.Size(100, 23)
        Me.ButtonAddStudent.TabIndex = 4
        Me.ButtonAddStudent.Text = "Add Student"
        Me.ButtonAddStudent.UseVisualStyleBackColor = True
        '
        'ButtonRemoveStudent
        '
        Me.ButtonRemoveStudent.Location = New System.Drawing.Point(139, 292)
        Me.ButtonRemoveStudent.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonRemoveStudent.Name = "ButtonRemoveStudent"
        Me.ButtonRemoveStudent.Size = New System.Drawing.Size(100, 23)
        Me.ButtonRemoveStudent.TabIndex = 5
        Me.ButtonRemoveStudent.Text = "Remove"
        Me.ButtonRemoveStudent.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(375, 292)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(100, 23)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 334)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.GroupBoxStudentData)
        Me.Controls.Add(Me.ButtonAddStudent)
        Me.Controls.Add(Me.ButtonRemoveStudent)
        Me.Name = "FormMain"
        Me.Text = "Student Collection"
        Me.GroupBoxStudentData.ResumeLayout(False)
        Me.GroupBoxStudentData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxStudentData As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTestAverageValue As System.Windows.Forms.Label
    Friend WithEvents LabelTestGrade As System.Windows.Forms.Label
    Friend WithEvents LabelTestAverage As System.Windows.Forms.Label
    Friend WithEvents LabelIDNumber As System.Windows.Forms.Label
    Friend WithEvents LabelFirstName As System.Windows.Forms.Label
    Friend WithEvents LabelLastName As System.Windows.Forms.Label
    Friend WithEvents ButtonAddStudent As System.Windows.Forms.Button
    Friend WithEvents ButtonRemoveStudent As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents LabelTestGradeValue As System.Windows.Forms.Label
    Friend WithEvents LabelLastNameValue As System.Windows.Forms.Label
    Friend WithEvents LabelFirstNameValue As System.Windows.Forms.Label
    Friend WithEvents LabelIDNumberValue As System.Windows.Forms.Label
    Friend WithEvents ListBoxIDNumbers As System.Windows.Forms.ListBox
End Class
