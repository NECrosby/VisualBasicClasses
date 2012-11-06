<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintBookForm
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
        Me.btnAddAudioBook = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstPrintBooks = New System.Windows.Forms.ListBox()
        Me.btnCloseAudioForm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddAudioBook
        '
        Me.btnAddAudioBook.Location = New System.Drawing.Point(19, 157)
        Me.btnAddAudioBook.Name = "btnAddAudioBook"
        Me.btnAddAudioBook.Size = New System.Drawing.Size(120, 30)
        Me.btnAddAudioBook.TabIndex = 4
        Me.btnAddAudioBook.Text = "Add Book to Cart"
        Me.btnAddAudioBook.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstPrintBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 135)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Print Book"
        '
        'lstPrintBooks
        '
        Me.lstPrintBooks.FormattingEnabled = True
        Me.lstPrintBooks.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstPrintBooks.Location = New System.Drawing.Point(20, 30)
        Me.lstPrintBooks.Name = "lstPrintBooks"
        Me.lstPrintBooks.Size = New System.Drawing.Size(227, 82)
        Me.lstPrintBooks.TabIndex = 0
        '
        'btnCloseAudioForm
        '
        Me.btnCloseAudioForm.Location = New System.Drawing.Point(150, 157)
        Me.btnCloseAudioForm.Name = "btnCloseAudioForm"
        Me.btnCloseAudioForm.Size = New System.Drawing.Size(120, 30)
        Me.btnCloseAudioForm.TabIndex = 5
        Me.btnCloseAudioForm.Text = "Close"
        Me.btnCloseAudioForm.UseVisualStyleBackColor = True
        '
        'PrintBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 192)
        Me.Controls.Add(Me.btnAddAudioBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCloseAudioForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "PrintBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PrintBooks"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddAudioBook As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstPrintBooks As System.Windows.Forms.ListBox
    Friend WithEvents btnCloseAudioForm As System.Windows.Forms.Button
End Class
