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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxSalaryValue = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBoxPayPeriodValue = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LabelSalaryPerPeriod = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Annual salary: "
        '
        'TextBoxSalaryValue
        '
        Me.TextBoxSalaryValue.Location = New System.Drawing.Point(158, 27)
        Me.TextBoxSalaryValue.Name = "TextBoxSalaryValue"
        Me.TextBoxSalaryValue.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxSalaryValue.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxPayPeriodValue
        '
        Me.TextBoxPayPeriodValue.Location = New System.Drawing.Point(158, 53)
        Me.TextBoxPayPeriodValue.Name = "TextBoxPayPeriodValue"
        Me.TextBoxPayPeriodValue.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxPayPeriodValue.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of pay periods: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number of pay periods: "
        '
        'LabelSalaryPerPeriod
        '
        Me.LabelSalaryPerPeriod.AutoSize = True
        Me.LabelSalaryPerPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSalaryPerPeriod.Location = New System.Drawing.Point(158, 89)
        Me.LabelSalaryPerPeriod.MinimumSize = New System.Drawing.Size(228, 0)
        Me.LabelSalaryPerPeriod.Name = "LabelSalaryPerPeriod"
        Me.LabelSalaryPerPeriod.Padding = New System.Windows.Forms.Padding(6)
        Me.LabelSalaryPerPeriod.Size = New System.Drawing.Size(228, 27)
        Me.LabelSalaryPerPeriod.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 317)
        Me.Controls.Add(Me.LabelSalaryPerPeriod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPayPeriodValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxSalaryValue)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Exception Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSalaryValue As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxPayPeriodValue As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelSalaryPerPeriod As System.Windows.Forms.Label

End Class
