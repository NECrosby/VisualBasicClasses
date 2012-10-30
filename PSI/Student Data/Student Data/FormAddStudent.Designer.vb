<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddStudent
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
        Me.LabelGrade = New System.Windows.Forms.Label
        Me.LabelTestGrade = New System.Windows.Forms.Label
        Me.TextBoxTestAverage = New System.Windows.Forms.TextBox
        Me.LabelTestAverage = New System.Windows.Forms.Label
        Me.TextBoxIDNumber = New System.Windows.Forms.TextBox
        Me.LabelIDNumber = New System.Windows.Forms.Label
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox
        Me.LabelFirstName = New System.Windows.Forms.Label
        Me.TextBoxLastName = New System.Windows.Forms.TextBox
        Me.LabelLastName = New System.Windows.Forms.Label
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.GroupBoxStudentData.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxStudentData
        '
        Me.GroupBoxStudentData.Controls.Add(Me.LabelGrade)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelTestGrade)
        Me.GroupBoxStudentData.Controls.Add(Me.TextBoxTestAverage)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelTestAverage)
        Me.GroupBoxStudentData.Controls.Add(Me.TextBoxIDNumber)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelIDNumber)
        Me.GroupBoxStudentData.Controls.Add(Me.TextBoxFirstName)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelFirstName)
        Me.GroupBoxStudentData.Controls.Add(Me.TextBoxLastName)
        Me.GroupBoxStudentData.Controls.Add(Me.LabelLastName)
        Me.GroupBoxStudentData.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxStudentData.Name = "GroupBoxStudentData"
        Me.GroupBoxStudentData.Size = New System.Drawing.Size(290, 193)
        Me.GroupBoxStudentData.TabIndex = 0
        Me.GroupBoxStudentData.TabStop = False
        Me.GroupBoxStudentData.Text = "Student Data"
        '
        'LabelGrade
        '
        Me.LabelGrade.AutoSize = True
        Me.LabelGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelGrade.Location = New System.Drawing.Point(102, 137)
        Me.LabelGrade.MinimumSize = New System.Drawing.Size(40, 0)
        Me.LabelGrade.Name = "LabelGrade"
        Me.LabelGrade.Padding = New System.Windows.Forms.Padding(4)
        Me.LabelGrade.Size = New System.Drawing.Size(40, 23)
        Me.LabelGrade.TabIndex = 9
        '
        'LabelTestGrade
        '
        Me.LabelTestGrade.AutoSize = True
        Me.LabelTestGrade.Location = New System.Drawing.Point(37, 142)
        Me.LabelTestGrade.Name = "LabelTestGrade"
        Me.LabelTestGrade.Size = New System.Drawing.Size(63, 13)
        Me.LabelTestGrade.TabIndex = 8
        Me.LabelTestGrade.Text = "Test Grade:"
        '
        'TextBoxTestAverage
        '
        Me.TextBoxTestAverage.Location = New System.Drawing.Point(102, 108)
        Me.TextBoxTestAverage.Name = "TextBoxTestAverage"
        Me.TextBoxTestAverage.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxTestAverage.TabIndex = 7
        '
        'LabelTestAverage
        '
        Me.LabelTestAverage.AutoSize = True
        Me.LabelTestAverage.Location = New System.Drawing.Point(26, 111)
        Me.LabelTestAverage.Name = "LabelTestAverage"
        Me.LabelTestAverage.Size = New System.Drawing.Size(74, 13)
        Me.LabelTestAverage.TabIndex = 6
        Me.LabelTestAverage.Text = "Test Average:"
        '
        'TextBoxIDNumber
        '
        Me.TextBoxIDNumber.Location = New System.Drawing.Point(102, 82)
        Me.TextBoxIDNumber.Name = "TextBoxIDNumber"
        Me.TextBoxIDNumber.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxIDNumber.TabIndex = 5
        '
        'LabelIDNumber
        '
        Me.LabelIDNumber.AutoSize = True
        Me.LabelIDNumber.Location = New System.Drawing.Point(39, 85)
        Me.LabelIDNumber.Name = "LabelIDNumber"
        Me.LabelIDNumber.Size = New System.Drawing.Size(61, 13)
        Me.LabelIDNumber.TabIndex = 4
        Me.LabelIDNumber.Text = "ID Number:"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(102, 56)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxFirstName.TabIndex = 3
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(40, 59)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(60, 13)
        Me.LabelFirstName.TabIndex = 2
        Me.LabelFirstName.Text = "First Name:"
        '
        'TextBoxLastName
        '
        Me.TextBoxLastName.Location = New System.Drawing.Point(102, 30)
        Me.TextBoxLastName.Name = "TextBoxLastName"
        Me.TextBoxLastName.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxLastName.TabIndex = 1
        '
        'LabelLastName
        '
        Me.LabelLastName.AutoSize = True
        Me.LabelLastName.Location = New System.Drawing.Point(39, 33)
        Me.LabelLastName.Name = "LabelLastName"
        Me.LabelLastName.Size = New System.Drawing.Size(61, 13)
        Me.LabelLastName.TabIndex = 0
        Me.LabelLastName.Text = "Last Name:"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(79, 223)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(171, 223)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 266)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.GroupBoxStudentData)
        Me.Name = "FormAddStudent"
        Me.Text = "Add Student"
        Me.GroupBoxStudentData.ResumeLayout(False)
        Me.GroupBoxStudentData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxStudentData As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxLastName As System.Windows.Forms.TextBox
    Friend WithEvents LabelLastName As System.Windows.Forms.Label
    Friend WithEvents LabelTestGrade As System.Windows.Forms.Label
    Friend WithEvents TextBoxTestAverage As System.Windows.Forms.TextBox
    Friend WithEvents LabelTestAverage As System.Windows.Forms.Label
    Friend WithEvents TextBoxIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents LabelIDNumber As System.Windows.Forms.Label
    Friend WithEvents TextBoxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents LabelFirstName As System.Windows.Forms.Label
    Friend WithEvents LabelGrade As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button

End Class
