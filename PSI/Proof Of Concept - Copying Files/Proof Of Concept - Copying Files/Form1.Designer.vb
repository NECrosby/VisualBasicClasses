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
        Me.TextBoxFileExtension = New System.Windows.Forms.TextBox
        Me.LabelFileExtension = New System.Windows.Forms.Label
        Me.TextBoxFileCreated = New System.Windows.Forms.TextBox
        Me.LabelFileCreated = New System.Windows.Forms.Label
        Me.TextBoxFileSize = New System.Windows.Forms.TextBox
        Me.LabelFileSize = New System.Windows.Forms.Label
        Me.ButtonSpecialFolders = New System.Windows.Forms.Button
        Me.ButtonFindFolders = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ButtonFindFiles = New System.Windows.Forms.Button
        Me.ButtonBrowse = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBoxFileExtension
        '
        Me.TextBoxFileExtension.Location = New System.Drawing.Point(101, 442)
        Me.TextBoxFileExtension.Name = "TextBoxFileExtension"
        Me.TextBoxFileExtension.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxFileExtension.TabIndex = 21
        '
        'LabelFileExtension
        '
        Me.LabelFileExtension.AutoSize = True
        Me.LabelFileExtension.Location = New System.Drawing.Point(26, 446)
        Me.LabelFileExtension.Name = "LabelFileExtension"
        Me.LabelFileExtension.Size = New System.Drawing.Size(72, 13)
        Me.LabelFileExtension.TabIndex = 20
        Me.LabelFileExtension.Text = "File Extension"
        '
        'TextBoxFileCreated
        '
        Me.TextBoxFileCreated.Location = New System.Drawing.Point(101, 416)
        Me.TextBoxFileCreated.Name = "TextBoxFileCreated"
        Me.TextBoxFileCreated.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxFileCreated.TabIndex = 19
        '
        'LabelFileCreated
        '
        Me.LabelFileCreated.AutoSize = True
        Me.LabelFileCreated.Location = New System.Drawing.Point(35, 419)
        Me.LabelFileCreated.Name = "LabelFileCreated"
        Me.LabelFileCreated.Size = New System.Drawing.Size(63, 13)
        Me.LabelFileCreated.TabIndex = 18
        Me.LabelFileCreated.Text = "File Created"
        '
        'TextBoxFileSize
        '
        Me.TextBoxFileSize.Location = New System.Drawing.Point(102, 391)
        Me.TextBoxFileSize.Name = "TextBoxFileSize"
        Me.TextBoxFileSize.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxFileSize.TabIndex = 17
        '
        'LabelFileSize
        '
        Me.LabelFileSize.AutoSize = True
        Me.LabelFileSize.Location = New System.Drawing.Point(53, 395)
        Me.LabelFileSize.Name = "LabelFileSize"
        Me.LabelFileSize.Size = New System.Drawing.Size(46, 13)
        Me.LabelFileSize.TabIndex = 16
        Me.LabelFileSize.Text = "File Size"
        '
        'ButtonSpecialFolders
        '
        Me.ButtonSpecialFolders.Location = New System.Drawing.Point(284, 12)
        Me.ButtonSpecialFolders.Name = "ButtonSpecialFolders"
        Me.ButtonSpecialFolders.Size = New System.Drawing.Size(88, 23)
        Me.ButtonSpecialFolders.TabIndex = 15
        Me.ButtonSpecialFolders.Text = "Special Folders"
        Me.ButtonSpecialFolders.UseVisualStyleBackColor = True
        '
        'ButtonFindFolders
        '
        Me.ButtonFindFolders.Location = New System.Drawing.Point(194, 12)
        Me.ButtonFindFolders.Name = "ButtonFindFolders"
        Me.ButtonFindFolders.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFindFolders.TabIndex = 14
        Me.ButtonFindFolders.Text = "Find Folders"
        Me.ButtonFindFolders.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(514, 316)
        Me.ListBox1.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All files (*.*) | *.*"
        '
        'ButtonFindFiles
        '
        Me.ButtonFindFiles.Location = New System.Drawing.Point(101, 12)
        Me.ButtonFindFiles.Name = "ButtonFindFiles"
        Me.ButtonFindFiles.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFindFiles.TabIndex = 12
        Me.ButtonFindFiles.Text = "Find Files"
        Me.ButtonFindFiles.UseVisualStyleBackColor = True
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(12, 12)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 11
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 503)
        Me.Controls.Add(Me.TextBoxFileExtension)
        Me.Controls.Add(Me.LabelFileExtension)
        Me.Controls.Add(Me.TextBoxFileCreated)
        Me.Controls.Add(Me.LabelFileCreated)
        Me.Controls.Add(Me.TextBoxFileSize)
        Me.Controls.Add(Me.LabelFileSize)
        Me.Controls.Add(Me.ButtonSpecialFolders)
        Me.Controls.Add(Me.ButtonFindFolders)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonFindFiles)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proof of Concept: Copying Files to New Directory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxFileExtension As System.Windows.Forms.TextBox
    Friend WithEvents LabelFileExtension As System.Windows.Forms.Label
    Friend WithEvents TextBoxFileCreated As System.Windows.Forms.TextBox
    Friend WithEvents LabelFileCreated As System.Windows.Forms.Label
    Friend WithEvents TextBoxFileSize As System.Windows.Forms.TextBox
    Friend WithEvents LabelFileSize As System.Windows.Forms.Label
    Friend WithEvents ButtonSpecialFolders As System.Windows.Forms.Button
    Friend WithEvents ButtonFindFolders As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonFindFiles As System.Windows.Forms.Button
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button

End Class
