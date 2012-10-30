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
        Me.chkLubeJob = New System.Windows.Forms.CheckBox()
        Me.chkOilChange = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTransmissionFlush = New System.Windows.Forms.CheckBox()
        Me.chkRadiatorFlush = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.chkReplaceMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblSummaryList = New System.Windows.Forms.Label()
        Me.lblServicesPerformed = New System.Windows.Forms.Label()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblServicesLabor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkLubeJob)
        Me.GroupBox1.Controls.Add(Me.chkOilChange)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil && Lube"
        '
        'chkLubeJob
        '
        Me.chkLubeJob.AutoSize = True
        Me.chkLubeJob.Location = New System.Drawing.Point(16, 60)
        Me.chkLubeJob.Name = "chkLubeJob"
        Me.chkLubeJob.Size = New System.Drawing.Size(112, 17)
        Me.chkLubeJob.TabIndex = 1
        Me.chkLubeJob.Text = "Lube &Job ($18.00)"
        Me.chkLubeJob.UseVisualStyleBackColor = True
        '
        'chkOilChange
        '
        Me.chkOilChange.AutoSize = True
        Me.chkOilChange.Location = New System.Drawing.Point(16, 28)
        Me.chkOilChange.Name = "chkOilChange"
        Me.chkOilChange.Size = New System.Drawing.Size(120, 17)
        Me.chkOilChange.TabIndex = 0
        Me.chkOilChange.Text = "&Oil Change ($26.00)"
        Me.chkOilChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTransmissionFlush)
        Me.GroupBox2.Controls.Add(Me.chkRadiatorFlush)
        Me.GroupBox2.Location = New System.Drawing.Point(223, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 98)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'chkTransmissionFlush
        '
        Me.chkTransmissionFlush.AutoSize = True
        Me.chkTransmissionFlush.Location = New System.Drawing.Point(16, 60)
        Me.chkTransmissionFlush.Name = "chkTransmissionFlush"
        Me.chkTransmissionFlush.Size = New System.Drawing.Size(157, 17)
        Me.chkTransmissionFlush.TabIndex = 1
        Me.chkTransmissionFlush.Text = "Transmission &Flush ($80.00)"
        Me.chkTransmissionFlush.UseVisualStyleBackColor = True
        '
        'chkRadiatorFlush
        '
        Me.chkRadiatorFlush.AutoSize = True
        Me.chkRadiatorFlush.Location = New System.Drawing.Point(16, 28)
        Me.chkRadiatorFlush.Name = "chkRadiatorFlush"
        Me.chkRadiatorFlush.Size = New System.Drawing.Size(136, 17)
        Me.chkRadiatorFlush.TabIndex = 0
        Me.chkRadiatorFlush.Text = "&Radiator Flush ($30.00)"
        Me.chkRadiatorFlush.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLabor)
        Me.GroupBox3.Controls.Add(Me.txtParts)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(223, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 122)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parts and Labor"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(100, 76)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 20)
        Me.txtLabor.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtLabor, "Enter the NUMBER of hours worked. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The rate is $20 per hour. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Full hours only a" & _
        "re billed.")
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(100, 36)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtParts, "Enter the retail price of parts here.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "La&bor ($20/hour)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Parts"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkTireRotation)
        Me.GroupBox4.Controls.Add(Me.chkReplaceMuffler)
        Me.GroupBox4.Controls.Add(Me.chkInspection)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 124)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(193, 122)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Misc"
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(16, 82)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(129, 17)
        Me.chkTireRotation.TabIndex = 2
        Me.chkTireRotation.Text = "Tire R&otation ($20.00)"
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'chkReplaceMuffler
        '
        Me.chkReplaceMuffler.AutoSize = True
        Me.chkReplaceMuffler.Location = New System.Drawing.Point(16, 54)
        Me.chkReplaceMuffler.Name = "chkReplaceMuffler"
        Me.chkReplaceMuffler.Size = New System.Drawing.Size(149, 17)
        Me.chkReplaceMuffler.TabIndex = 1
        Me.chkReplaceMuffler.Text = "Replace &Muffler ($100.00)"
        Me.chkReplaceMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(16, 26)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(117, 17)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "&Inspection ($15.00)"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblSummaryList)
        Me.GroupBox5.Controls.Add(Me.lblServicesPerformed)
        Me.GroupBox5.Controls.Add(Me.lblTotalFees)
        Me.GroupBox5.Controls.Add(Me.lblTax)
        Me.GroupBox5.Controls.Add(Me.lblParts)
        Me.GroupBox5.Controls.Add(Me.lblServicesLabor)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(431, 217)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'lblSummaryList
        '
        Me.lblSummaryList.AutoSize = True
        Me.lblSummaryList.Location = New System.Drawing.Point(255, 49)
        Me.lblSummaryList.Name = "lblSummaryList"
        Me.lblSummaryList.Size = New System.Drawing.Size(0, 13)
        Me.lblSummaryList.TabIndex = 7
        Me.lblSummaryList.Visible = False
        '
        'lblServicesPerformed
        '
        Me.lblServicesPerformed.AutoSize = True
        Me.lblServicesPerformed.Location = New System.Drawing.Point(253, 20)
        Me.lblServicesPerformed.Name = "lblServicesPerformed"
        Me.lblServicesPerformed.Size = New System.Drawing.Size(172, 26)
        Me.lblServicesPerformed.TabIndex = 6
        Me.lblServicesPerformed.Text = "Services Performed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------"
        Me.lblServicesPerformed.Visible = False
        '
        'lblTotalFees
        '
        Me.lblTotalFees.AutoSize = True
        Me.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFees.Location = New System.Drawing.Point(130, 135)
        Me.lblTotalFees.MinimumSize = New System.Drawing.Size(100, 22)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(100, 22)
        Me.lblTotalFees.TabIndex = 3
        Me.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(130, 107)
        Me.lblTax.MinimumSize = New System.Drawing.Size(100, 22)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 22)
        Me.lblTax.TabIndex = 2
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParts.Location = New System.Drawing.Point(130, 75)
        Me.lblParts.MinimumSize = New System.Drawing.Size(100, 22)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(100, 22)
        Me.lblParts.TabIndex = 1
        Me.lblParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblServicesLabor
        '
        Me.lblServicesLabor.AutoSize = True
        Me.lblServicesLabor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServicesLabor.Location = New System.Drawing.Point(130, 43)
        Me.lblServicesLabor.MinimumSize = New System.Drawing.Size(100, 22)
        Me.lblServicesLabor.Name = "lblServicesLabor"
        Me.lblServicesLabor.Size = New System.Drawing.Size(100, 22)
        Me.lblServicesLabor.TabIndex = 0
        Me.lblServicesLabor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Fees"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tax (on parts)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Parts"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Services && Labor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(50, 486)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(98, 33)
        Me.btnCalculateTotal.TabIndex = 5
        Me.btnCalculateTotal.Text = "&Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(174, 486)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 33)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 486)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 33)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Joe's Automotive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLubeJob As System.Windows.Forms.CheckBox
    Friend WithEvents chkOilChange As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTransmissionFlush As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadiatorFlush As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTireRotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkReplaceMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents lblServicesLabor As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents lblSummaryList As System.Windows.Forms.Label
    Friend WithEvents lblServicesPerformed As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
