<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.


    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
                Me._AppConfig.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnDone = New System.Windows.Forms.Button
        Me.lblVersion = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbFormTemplate = New System.Windows.Forms.RadioButton
        Me.rbDocument = New System.Windows.Forms.RadioButton
        Me.txtNewRevision = New System.Windows.Forms.TextBox
        Me.txtOldRevision = New System.Windows.Forms.TextBox
        Me.cboDocumentGroup = New System.Windows.Forms.ComboBox
        Me.txtDocumentNumber = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(204, 254)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(10)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 35)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(324, 254)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(10)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(100, 35)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(15, 303)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(10)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(61, 16)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "Version"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txtNewRevision)
        Me.GroupBox2.Controls.Add(Me.txtOldRevision)
        Me.GroupBox2.Controls.Add(Me.cboDocumentGroup)
        Me.GroupBox2.Controls.Add(Me.txtDocumentNumber)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 224)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Document to be moved"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFormTemplate)
        Me.GroupBox1.Controls.Add(Me.rbDocument)
        Me.GroupBox1.Location = New System.Drawing.Point(215, 104)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 97)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Document Type"
        '
        'rbFormTemplate
        '
        Me.rbFormTemplate.AutoSize = True
        Me.rbFormTemplate.Location = New System.Drawing.Point(37, 56)
        Me.rbFormTemplate.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.rbFormTemplate.Name = "rbFormTemplate"
        Me.rbFormTemplate.Size = New System.Drawing.Size(97, 17)
        Me.rbFormTemplate.TabIndex = 1
        Me.rbFormTemplate.Text = "&Form/Template"
        Me.rbFormTemplate.UseVisualStyleBackColor = True
        '
        'rbDocument
        '
        Me.rbDocument.AutoSize = True
        Me.rbDocument.Checked = True
        Me.rbDocument.Location = New System.Drawing.Point(37, 27)
        Me.rbDocument.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.rbDocument.Name = "rbDocument"
        Me.rbDocument.Size = New System.Drawing.Size(74, 17)
        Me.rbDocument.TabIndex = 0
        Me.rbDocument.TabStop = True
        Me.rbDocument.Text = "&Document"
        Me.rbDocument.UseVisualStyleBackColor = True
        '
        'txtNewRevision
        '
        Me.txtNewRevision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewRevision.Location = New System.Drawing.Point(122, 133)
        Me.txtNewRevision.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.txtNewRevision.Name = "txtNewRevision"
        Me.txtNewRevision.Size = New System.Drawing.Size(73, 20)
        Me.txtNewRevision.TabIndex = 4
        '
        'txtOldRevision
        '
        Me.txtOldRevision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOldRevision.Location = New System.Drawing.Point(122, 104)
        Me.txtOldRevision.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.txtOldRevision.Name = "txtOldRevision"
        Me.txtOldRevision.Size = New System.Drawing.Size(73, 20)
        Me.txtOldRevision.TabIndex = 3
        '
        'cboDocumentGroup
        '
        Me.cboDocumentGroup.FormattingEnabled = True
        Me.cboDocumentGroup.Location = New System.Drawing.Point(122, 63)
        Me.cboDocumentGroup.Margin = New System.Windows.Forms.Padding(10)
        Me.cboDocumentGroup.Name = "cboDocumentGroup"
        Me.cboDocumentGroup.Size = New System.Drawing.Size(264, 21)
        Me.cboDocumentGroup.TabIndex = 2
        '
        'txtDocumentNumber
        '
        Me.txtDocumentNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumentNumber.Location = New System.Drawing.Point(122, 23)
        Me.txtDocumentNumber.Margin = New System.Windows.Forms.Padding(10)
        Me.txtDocumentNumber.Name = "txtDocumentNumber"
        Me.txtDocumentNumber.Size = New System.Drawing.Size(264, 20)
        Me.txtDocumentNumber.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "New Revision"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Old Revision"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Document Group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Document #"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 335)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnNext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFormTemplate As System.Windows.Forms.RadioButton
    Friend WithEvents rbDocument As System.Windows.Forms.RadioButton
    Friend WithEvents txtNewRevision As System.Windows.Forms.TextBox
    Friend WithEvents txtOldRevision As System.Windows.Forms.TextBox
    Friend WithEvents cboDocumentGroup As System.Windows.Forms.ComboBox
    Friend WithEvents txtDocumentNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
