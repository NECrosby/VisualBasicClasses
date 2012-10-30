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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDailyIncrease = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboNumberDaysToMultiply = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboStartNumber = New System.Windows.Forms.ComboBox()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnDisplayTable = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lstData)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 314)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Organism Population Data"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtDailyIncrease)
        Me.GroupBox4.Location = New System.Drawing.Point(321, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(175, 87)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Average Daily Increase"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "%"
        '
        'txtDailyIncrease
        '
        Me.txtDailyIncrease.Location = New System.Drawing.Point(59, 37)
        Me.txtDailyIncrease.Name = "txtDailyIncrease"
        Me.txtDailyIncrease.Size = New System.Drawing.Size(55, 20)
        Me.txtDailyIncrease.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtDailyIncrease, "Please enter a number to represent the value of the daily increase of Organisms.")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboNumberDaysToMultiply)
        Me.GroupBox3.Location = New System.Drawing.Point(321, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 87)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Number of Days to Multiply"
        '
        'cboNumberDaysToMultiply
        '
        Me.cboNumberDaysToMultiply.FormattingEnabled = True
        Me.cboNumberDaysToMultiply.Items.AddRange(New Object() {"10", "20", "40", "60", "80", "100"})
        Me.cboNumberDaysToMultiply.Location = New System.Drawing.Point(59, 38)
        Me.cboNumberDaysToMultiply.Name = "cboNumberDaysToMultiply"
        Me.cboNumberDaysToMultiply.Size = New System.Drawing.Size(55, 21)
        Me.cboNumberDaysToMultiply.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cboNumberDaysToMultiply, "Please choose a value from the Number of Days to Multiply combo box.")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboStartNumber)
        Me.GroupBox2.Location = New System.Drawing.Point(321, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Starting Number of Organisms"
        '
        'cboStartNumber
        '
        Me.cboStartNumber.FormattingEnabled = True
        Me.cboStartNumber.Items.AddRange(New Object() {"2", "4", "6", "8", "10"})
        Me.cboStartNumber.Location = New System.Drawing.Point(59, 35)
        Me.cboStartNumber.Name = "cboStartNumber"
        Me.cboStartNumber.Size = New System.Drawing.Size(55, 21)
        Me.cboStartNumber.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cboStartNumber, "Please choose a value from the Starting Number of Organisms combo box.")
        '
        'lstData
        '
        Me.lstData.ColumnWidth = 151
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(10, 19)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(301, 277)
        Me.lstData.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lstData, "After selecting and enter data, clicking 'Display Table' your data estimate table" & _
        " will populate here.")
        '
        'btnDisplayTable
        '
        Me.btnDisplayTable.Location = New System.Drawing.Point(24, 342)
        Me.btnDisplayTable.Name = "btnDisplayTable"
        Me.btnDisplayTable.Size = New System.Drawing.Size(90, 31)
        Me.btnDisplayTable.TabIndex = 4
        Me.btnDisplayTable.Text = "Display Table"
        Me.ToolTip1.SetToolTip(Me.btnDisplayTable, "After you have entered input, click here.")
        Me.btnDisplayTable.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(128, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 31)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "To clear the form click here.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 342)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 31)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "To close the form and exit the program, click here.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 386)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayTable)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Population Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDailyIncrease As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboNumberDaysToMultiply As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboStartNumber As System.Windows.Forms.ComboBox
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplayTable As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
