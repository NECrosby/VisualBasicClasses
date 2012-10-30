<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBoxTypeOfMembership = New System.Windows.Forms.GroupBox
        Me.RadioButtonChild = New System.Windows.Forms.RadioButton
        Me.RadioButtonStudent = New System.Windows.Forms.RadioButton
        Me.RadioButtonSenior = New System.Windows.Forms.RadioButton
        Me.RadioButtonAdult = New System.Windows.Forms.RadioButton
        Me.GroupBoxOptions = New System.Windows.Forms.GroupBox
        Me.CheckBoxYoga = New System.Windows.Forms.CheckBox
        Me.CheckBoxKarate = New System.Windows.Forms.CheckBox
        Me.CheckBoxPersonalTrainer = New System.Windows.Forms.CheckBox
        Me.GroupBoxMembershipLength = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxMonths = New System.Windows.Forms.TextBox
        Me.GroupBoxFees = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxMonthlyFee = New System.Windows.Forms.TextBox
        Me.TextBoxTotalFee = New System.Windows.Forms.TextBox
        Me.ButtonCalculate = New System.Windows.Forms.Button
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.GroupBoxTypeOfMembership.SuspendLayout()
        Me.GroupBoxOptions.SuspendLayout()
        Me.GroupBoxMembershipLength.SuspendLayout()
        Me.GroupBoxFees.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTypeOfMembership
        '
        Me.GroupBoxTypeOfMembership.Controls.Add(Me.RadioButtonAdult)
        Me.GroupBoxTypeOfMembership.Controls.Add(Me.RadioButtonSenior)
        Me.GroupBoxTypeOfMembership.Controls.Add(Me.RadioButtonStudent)
        Me.GroupBoxTypeOfMembership.Controls.Add(Me.RadioButtonChild)
        Me.GroupBoxTypeOfMembership.Location = New System.Drawing.Point(26, 23)
        Me.GroupBoxTypeOfMembership.Name = "GroupBoxTypeOfMembership"
        Me.GroupBoxTypeOfMembership.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBoxTypeOfMembership.Size = New System.Drawing.Size(200, 150)
        Me.GroupBoxTypeOfMembership.TabIndex = 0
        Me.GroupBoxTypeOfMembership.TabStop = False
        Me.GroupBoxTypeOfMembership.Text = "Type of Membership"
        '
        'RadioButtonChild
        '
        Me.RadioButtonChild.AutoSize = True
        Me.RadioButtonChild.Location = New System.Drawing.Point(39, 52)
        Me.RadioButtonChild.Name = "RadioButtonChild"
        Me.RadioButtonChild.Size = New System.Drawing.Size(108, 17)
        Me.RadioButtonChild.TabIndex = 0
        Me.RadioButtonChild.TabStop = True
        Me.RadioButtonChild.Text = "Chil&d (12 && under)"
        Me.RadioButtonChild.UseVisualStyleBackColor = True
        '
        'RadioButtonStudent
        '
        Me.RadioButtonStudent.AutoSize = True
        Me.RadioButtonStudent.Location = New System.Drawing.Point(39, 75)
        Me.RadioButtonStudent.Name = "RadioButtonStudent"
        Me.RadioButtonStudent.Size = New System.Drawing.Size(62, 17)
        Me.RadioButtonStudent.TabIndex = 1
        Me.RadioButtonStudent.TabStop = True
        Me.RadioButtonStudent.Text = "&Student"
        Me.RadioButtonStudent.UseVisualStyleBackColor = True
        '
        'RadioButtonSenior
        '
        Me.RadioButtonSenior.AutoSize = True
        Me.RadioButtonSenior.Location = New System.Drawing.Point(39, 98)
        Me.RadioButtonSenior.Name = "RadioButtonSenior"
        Me.RadioButtonSenior.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonSenior.TabIndex = 2
        Me.RadioButtonSenior.TabStop = True
        Me.RadioButtonSenior.Text = "S&enior Citizen"
        Me.RadioButtonSenior.UseVisualStyleBackColor = True
        '
        'RadioButtonAdult
        '
        Me.RadioButtonAdult.AutoSize = True
        Me.RadioButtonAdult.Location = New System.Drawing.Point(39, 29)
        Me.RadioButtonAdult.Name = "RadioButtonAdult"
        Me.RadioButtonAdult.Size = New System.Drawing.Size(95, 17)
        Me.RadioButtonAdult.TabIndex = 3
        Me.RadioButtonAdult.TabStop = True
        Me.RadioButtonAdult.Text = "Standard &Adult"
        Me.RadioButtonAdult.UseVisualStyleBackColor = True
        '
        'GroupBoxOptions
        '
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxPersonalTrainer)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxKarate)
        Me.GroupBoxOptions.Controls.Add(Me.CheckBoxYoga)
        Me.GroupBoxOptions.Location = New System.Drawing.Point(254, 23)
        Me.GroupBoxOptions.Name = "GroupBoxOptions"
        Me.GroupBoxOptions.Size = New System.Drawing.Size(200, 150)
        Me.GroupBoxOptions.TabIndex = 1
        Me.GroupBoxOptions.TabStop = False
        Me.GroupBoxOptions.Text = "Options"
        '
        'CheckBoxYoga
        '
        Me.CheckBoxYoga.AutoSize = True
        Me.CheckBoxYoga.Location = New System.Drawing.Point(43, 29)
        Me.CheckBoxYoga.Name = "CheckBoxYoga"
        Me.CheckBoxYoga.Size = New System.Drawing.Size(51, 17)
        Me.CheckBoxYoga.TabIndex = 0
        Me.CheckBoxYoga.Text = "&Yoga"
        Me.CheckBoxYoga.UseVisualStyleBackColor = True
        '
        'CheckBoxKarate
        '
        Me.CheckBoxKarate.AutoSize = True
        Me.CheckBoxKarate.Location = New System.Drawing.Point(43, 53)
        Me.CheckBoxKarate.Name = "CheckBoxKarate"
        Me.CheckBoxKarate.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxKarate.TabIndex = 1
        Me.CheckBoxKarate.Text = "&Karate"
        Me.CheckBoxKarate.UseVisualStyleBackColor = True
        '
        'CheckBoxPersonalTrainer
        '
        Me.CheckBoxPersonalTrainer.AutoSize = True
        Me.CheckBoxPersonalTrainer.Location = New System.Drawing.Point(43, 75)
        Me.CheckBoxPersonalTrainer.Name = "CheckBoxPersonalTrainer"
        Me.CheckBoxPersonalTrainer.Size = New System.Drawing.Size(100, 17)
        Me.CheckBoxPersonalTrainer.TabIndex = 2
        Me.CheckBoxPersonalTrainer.Text = "&PersonalTrainer"
        Me.CheckBoxPersonalTrainer.UseVisualStyleBackColor = True
        '
        'GroupBoxMembershipLength
        '
        Me.GroupBoxMembershipLength.Controls.Add(Me.TextBoxMonths)
        Me.GroupBoxMembershipLength.Controls.Add(Me.Label1)
        Me.GroupBoxMembershipLength.Location = New System.Drawing.Point(26, 210)
        Me.GroupBoxMembershipLength.Name = "GroupBoxMembershipLength"
        Me.GroupBoxMembershipLength.Size = New System.Drawing.Size(200, 130)
        Me.GroupBoxMembershipLength.TabIndex = 2
        Me.GroupBoxMembershipLength.TabStop = False
        Me.GroupBoxMembershipLength.Text = "Membership Length"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Number of Months:"
        '
        'TextBoxMonths
        '
        Me.TextBoxMonths.Location = New System.Drawing.Point(25, 79)
        Me.TextBoxMonths.Name = "TextBoxMonths"
        Me.TextBoxMonths.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxMonths.TabIndex = 1
        '
        'GroupBoxFees
        '
        Me.GroupBoxFees.Controls.Add(Me.TextBoxTotalFee)
        Me.GroupBoxFees.Controls.Add(Me.TextBoxMonthlyFee)
        Me.GroupBoxFees.Controls.Add(Me.Label3)
        Me.GroupBoxFees.Controls.Add(Me.Label2)
        Me.GroupBoxFees.Location = New System.Drawing.Point(254, 210)
        Me.GroupBoxFees.Name = "GroupBoxFees"
        Me.GroupBoxFees.Size = New System.Drawing.Size(200, 130)
        Me.GroupBoxFees.TabIndex = 3
        Me.GroupBoxFees.TabStop = False
        Me.GroupBoxFees.Text = "Membership Fees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monthly Fee:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total:"
        '
        'TextBoxMonthlyFee
        '
        Me.TextBoxMonthlyFee.Location = New System.Drawing.Point(81, 42)
        Me.TextBoxMonthlyFee.Name = "TextBoxMonthlyFee"
        Me.TextBoxMonthlyFee.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMonthlyFee.TabIndex = 2
        '
        'TextBoxTotalFee
        '
        Me.TextBoxTotalFee.Location = New System.Drawing.Point(81, 76)
        Me.TextBoxTotalFee.Name = "TextBoxTotalFee"
        Me.TextBoxTotalFee.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotalFee.TabIndex = 3
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(120, 378)
        Me.ButtonCalculate.Margin = New System.Windows.Forms.Padding(15)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(75, 35)
        Me.ButtonCalculate.TabIndex = 4
        Me.ButtonCalculate.Text = "&Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(213, 378)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 35)
        Me.ButtonClear.TabIndex = 5
        Me.ButtonClear.Text = "Clea&r"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(307, 378)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 35)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "E&xit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 437)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.GroupBoxFees)
        Me.Controls.Add(Me.GroupBoxMembershipLength)
        Me.Controls.Add(Me.GroupBoxOptions)
        Me.Controls.Add(Me.GroupBoxTypeOfMembership)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Membership Fee Calculator"
        Me.GroupBoxTypeOfMembership.ResumeLayout(False)
        Me.GroupBoxTypeOfMembership.PerformLayout()
        Me.GroupBoxOptions.ResumeLayout(False)
        Me.GroupBoxOptions.PerformLayout()
        Me.GroupBoxMembershipLength.ResumeLayout(False)
        Me.GroupBoxMembershipLength.PerformLayout()
        Me.GroupBoxFees.ResumeLayout(False)
        Me.GroupBoxFees.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxTypeOfMembership As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonSenior As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonStudent As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonChild As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAdult As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxOptions As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxKarate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxYoga As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPersonalTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxMembershipLength As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMonths As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxFees As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTotalFee As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMonthlyFee As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonCalculate As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button

End Class
