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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkNonprofitOrg = New System.Windows.Forms.CheckBox()
        Me.radPkgC = New System.Windows.Forms.RadioButton()
        Me.radPkgB = New System.Windows.Forms.RadioButton()
        Me.radPkgA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.txtNumHours = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(27, 198)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 35)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(123, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(219, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.radPkgC)
        Me.GroupBox1.Controls.Add(Me.radPkgB)
        Me.GroupBox1.Controls.Add(Me.radPkgA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Subscription Package"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkNonprofitOrg)
        Me.GroupBox2.Location = New System.Drawing.Point(127, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 55)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a Discount"
        '
        'chkNonprofitOrg
        '
        Me.chkNonprofitOrg.AutoSize = True
        Me.chkNonprofitOrg.Location = New System.Drawing.Point(33, 23)
        Me.chkNonprofitOrg.Name = "chkNonprofitOrg"
        Me.chkNonprofitOrg.Size = New System.Drawing.Size(131, 17)
        Me.chkNonprofitOrg.TabIndex = 5
        Me.chkNonprofitOrg.Text = "&Nonprofit Organization"
        Me.chkNonprofitOrg.UseVisualStyleBackColor = True
        '
        'radPkgC
        '
        Me.radPkgC.AutoSize = True
        Me.radPkgC.Location = New System.Drawing.Point(15, 74)
        Me.radPkgC.Name = "radPkgC"
        Me.radPkgC.Size = New System.Drawing.Size(78, 17)
        Me.radPkgC.TabIndex = 3
        Me.radPkgC.Text = "Package &C"
        Me.radPkgC.UseVisualStyleBackColor = True
        '
        'radPkgB
        '
        Me.radPkgB.AutoSize = True
        Me.radPkgB.Location = New System.Drawing.Point(15, 50)
        Me.radPkgB.Name = "radPkgB"
        Me.radPkgB.Size = New System.Drawing.Size(78, 17)
        Me.radPkgB.TabIndex = 2
        Me.radPkgB.Text = "Package &B"
        Me.radPkgB.UseVisualStyleBackColor = True
        '
        'radPkgA
        '
        Me.radPkgA.AutoSize = True
        Me.radPkgA.Checked = True
        Me.radPkgA.Location = New System.Drawing.Point(15, 26)
        Me.radPkgA.Name = "radPkgA"
        Me.radPkgA.Size = New System.Drawing.Size(78, 17)
        Me.radPkgA.TabIndex = 1
        Me.radPkgA.TabStop = True
        Me.radPkgA.Text = "Package &A"
        Me.radPkgA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the Number of Hours Used: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Amount Due: "
        '
        'lblAmountDue
        '
        Me.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountDue.Location = New System.Drawing.Point(209, 161)
        Me.lblAmountDue.MinimumSize = New System.Drawing.Size(100, 20)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(100, 23)
        Me.lblAmountDue.TabIndex = 6
        Me.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumHours
        '
        Me.txtNumHours.Location = New System.Drawing.Point(209, 132)
        Me.txtNumHours.Name = "txtNumHours"
        Me.txtNumHours.Size = New System.Drawing.Size(100, 20)
        Me.txtNumHours.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 251)
        Me.Controls.Add(Me.txtNumHours)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Internet Service Provider, Part 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkNonprofitOrg As System.Windows.Forms.CheckBox
    Friend WithEvents radPkgC As System.Windows.Forms.RadioButton
    Friend WithEvents radPkgB As System.Windows.Forms.RadioButton
    Friend WithEvents radPkgA As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents txtNumHours As System.Windows.Forms.TextBox

End Class
