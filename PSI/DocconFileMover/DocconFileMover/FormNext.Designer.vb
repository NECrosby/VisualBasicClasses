<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNext
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNext))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstCompletedDocuments = New System.Windows.Forms.CheckedListBox
        Me.lblDocumentType = New System.Windows.Forms.Label
        Me.lblNewRevision = New System.Windows.Forms.Label
        Me.lblOldRevision = New System.Windows.Forms.Label
        Me.lblDocumentGroup = New System.Windows.Forms.Label
        Me.lblDocumentNumber = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lstFormDocuments = New System.Windows.Forms.CheckedListBox
        Me.lstPDFDocuments = New System.Windows.Forms.CheckedListBox
        Me.lstSourceDocuments = New System.Windows.Forms.CheckedListBox
        Me.btnClearAll = New System.Windows.Forms.Button
        Me.btnCheckAllSourcePDFs = New System.Windows.Forms.Button
        Me.lblFormFiles = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstCompletedDocuments)
        Me.GroupBox1.Controls.Add(Me.lblDocumentType)
        Me.GroupBox1.Controls.Add(Me.lblNewRevision)
        Me.GroupBox1.Controls.Add(Me.lblOldRevision)
        Me.GroupBox1.Controls.Add(Me.lblDocumentGroup)
        Me.GroupBox1.Controls.Add(Me.lblDocumentNumber)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 19)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Completed Document Details"
        '
        'lstCompletedDocuments
        '
        Me.lstCompletedDocuments.CheckOnClick = True
        Me.lstCompletedDocuments.FormattingEnabled = True
        Me.lstCompletedDocuments.Location = New System.Drawing.Point(31, 63)
        Me.lstCompletedDocuments.Margin = New System.Windows.Forms.Padding(7)
        Me.lstCompletedDocuments.MinimumSize = New System.Drawing.Size(189, 134)
        Me.lstCompletedDocuments.Name = "lstCompletedDocuments"
        Me.lstCompletedDocuments.Size = New System.Drawing.Size(189, 139)
        Me.lstCompletedDocuments.TabIndex = 27
        '
        'lblDocumentType
        '
        Me.lblDocumentType.AutoSize = True
        Me.lblDocumentType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDocumentType.Location = New System.Drawing.Point(384, 177)
        Me.lblDocumentType.MinimumSize = New System.Drawing.Size(225, 20)
        Me.lblDocumentType.Name = "lblDocumentType"
        Me.lblDocumentType.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lblDocumentType.Size = New System.Drawing.Size(225, 20)
        Me.lblDocumentType.TabIndex = 26
        Me.lblDocumentType.Text = "Document Type"
        '
        'lblNewRevision
        '
        Me.lblNewRevision.AutoSize = True
        Me.lblNewRevision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNewRevision.Location = New System.Drawing.Point(384, 150)
        Me.lblNewRevision.MinimumSize = New System.Drawing.Size(225, 20)
        Me.lblNewRevision.Name = "lblNewRevision"
        Me.lblNewRevision.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lblNewRevision.Size = New System.Drawing.Size(225, 20)
        Me.lblNewRevision.TabIndex = 25
        Me.lblNewRevision.Text = "New Revision"
        '
        'lblOldRevision
        '
        Me.lblOldRevision.AutoSize = True
        Me.lblOldRevision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOldRevision.Location = New System.Drawing.Point(384, 121)
        Me.lblOldRevision.MinimumSize = New System.Drawing.Size(225, 20)
        Me.lblOldRevision.Name = "lblOldRevision"
        Me.lblOldRevision.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lblOldRevision.Size = New System.Drawing.Size(225, 20)
        Me.lblOldRevision.TabIndex = 24
        Me.lblOldRevision.Text = "Old Revision"
        '
        'lblDocumentGroup
        '
        Me.lblDocumentGroup.AutoSize = True
        Me.lblDocumentGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDocumentGroup.Location = New System.Drawing.Point(384, 92)
        Me.lblDocumentGroup.MinimumSize = New System.Drawing.Size(225, 20)
        Me.lblDocumentGroup.Name = "lblDocumentGroup"
        Me.lblDocumentGroup.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lblDocumentGroup.Size = New System.Drawing.Size(225, 20)
        Me.lblDocumentGroup.TabIndex = 23
        Me.lblDocumentGroup.Text = "Document Group"
        '
        'lblDocumentNumber
        '
        Me.lblDocumentNumber.AutoSize = True
        Me.lblDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDocumentNumber.Location = New System.Drawing.Point(384, 63)
        Me.lblDocumentNumber.MinimumSize = New System.Drawing.Size(225, 20)
        Me.lblDocumentNumber.Name = "lblDocumentNumber"
        Me.lblDocumentNumber.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lblDocumentNumber.Size = New System.Drawing.Size(225, 20)
        Me.lblDocumentNumber.TabIndex = 22
        Me.lblDocumentNumber.Text = "Document Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 179)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Document Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "New Revision"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Old Revision"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Document Group"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Document #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Completed Documents"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstFormDocuments)
        Me.GroupBox2.Controls.Add(Me.lstPDFDocuments)
        Me.GroupBox2.Controls.Add(Me.lstSourceDocuments)
        Me.GroupBox2.Controls.Add(Me.btnClearAll)
        Me.GroupBox2.Controls.Add(Me.btnCheckAllSourcePDFs)
        Me.GroupBox2.Controls.Add(Me.lblFormFiles)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 260)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 276)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Moved Document Details"
        '
        'lstFormDocuments
        '
        Me.lstFormDocuments.CheckOnClick = True
        Me.lstFormDocuments.FormattingEnabled = True
        Me.lstFormDocuments.Location = New System.Drawing.Point(444, 57)
        Me.lstFormDocuments.Margin = New System.Windows.Forms.Padding(7)
        Me.lstFormDocuments.MinimumSize = New System.Drawing.Size(189, 160)
        Me.lstFormDocuments.Name = "lstFormDocuments"
        Me.lstFormDocuments.Size = New System.Drawing.Size(189, 154)
        Me.lstFormDocuments.TabIndex = 13
        '
        'lstPDFDocuments
        '
        Me.lstPDFDocuments.CheckOnClick = True
        Me.lstPDFDocuments.FormattingEnabled = True
        Me.lstPDFDocuments.Location = New System.Drawing.Point(238, 57)
        Me.lstPDFDocuments.Margin = New System.Windows.Forms.Padding(7)
        Me.lstPDFDocuments.MinimumSize = New System.Drawing.Size(189, 160)
        Me.lstPDFDocuments.Name = "lstPDFDocuments"
        Me.lstPDFDocuments.Size = New System.Drawing.Size(189, 154)
        Me.lstPDFDocuments.TabIndex = 12
        '
        'lstSourceDocuments
        '
        Me.lstSourceDocuments.CheckOnClick = True
        Me.lstSourceDocuments.FormattingEnabled = True
        Me.lstSourceDocuments.Location = New System.Drawing.Point(31, 57)
        Me.lstSourceDocuments.Margin = New System.Windows.Forms.Padding(7)
        Me.lstSourceDocuments.MinimumSize = New System.Drawing.Size(189, 160)
        Me.lstSourceDocuments.Name = "lstSourceDocuments"
        Me.lstSourceDocuments.Size = New System.Drawing.Size(189, 154)
        Me.lstSourceDocuments.TabIndex = 11
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(238, 228)
        Me.btnClearAll.Margin = New System.Windows.Forms.Padding(10)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(189, 35)
        Me.btnClearAll.TabIndex = 9
        Me.btnClearAll.Text = "Clear All Source/PDF Files"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnCheckAllSourcePDFs
        '
        Me.btnCheckAllSourcePDFs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllSourcePDFs.Location = New System.Drawing.Point(31, 228)
        Me.btnCheckAllSourcePDFs.Margin = New System.Windows.Forms.Padding(10)
        Me.btnCheckAllSourcePDFs.Name = "btnCheckAllSourcePDFs"
        Me.btnCheckAllSourcePDFs.Size = New System.Drawing.Size(189, 35)
        Me.btnCheckAllSourcePDFs.TabIndex = 8
        Me.btnCheckAllSourcePDFs.Text = "Check All Source/PDF Files"
        Me.btnCheckAllSourcePDFs.UseVisualStyleBackColor = True
        '
        'lblFormFiles
        '
        Me.lblFormFiles.AutoSize = True
        Me.lblFormFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormFiles.Location = New System.Drawing.Point(449, 35)
        Me.lblFormFiles.Margin = New System.Windows.Forms.Padding(7)
        Me.lblFormFiles.Name = "lblFormFiles"
        Me.lblFormFiles.Size = New System.Drawing.Size(64, 13)
        Me.lblFormFiles.TabIndex = 6
        Me.lblFormFiles.Text = "Form Files"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(243, 35)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PDF Files"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 35)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Source Documents"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(589, 556)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 35)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(469, 556)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(10)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 35)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'FormNext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 613)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormNext"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNext"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDocumentGroup As System.Windows.Forms.Label
    Friend WithEvents lblDocumentNumber As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDocumentType As System.Windows.Forms.Label
    Friend WithEvents lblNewRevision As System.Windows.Forms.Label
    Friend WithEvents lblOldRevision As System.Windows.Forms.Label
    Friend WithEvents lblFormFiles As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnCheckAllSourcePDFs As System.Windows.Forms.Button
    Friend WithEvents lstCompletedDocuments As System.Windows.Forms.CheckedListBox
    Friend WithEvents lstFormDocuments As System.Windows.Forms.CheckedListBox
    Friend WithEvents lstPDFDocuments As System.Windows.Forms.CheckedListBox
    Friend WithEvents lstSourceDocuments As System.Windows.Forms.CheckedListBox
End Class
