<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioBookForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstAudioBooks = New System.Windows.Forms.ListBox()
        Me.btnAddAudioBook = New System.Windows.Forms.Button()
        Me.btnCloseAudioForm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstAudioBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an Audio Book"
        '
        'lstAudioBooks
        '
        Me.lstAudioBooks.FormattingEnabled = True
        Me.lstAudioBooks.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)"})
        Me.lstAudioBooks.Location = New System.Drawing.Point(20, 30)
        Me.lstAudioBooks.Name = "lstAudioBooks"
        Me.lstAudioBooks.Size = New System.Drawing.Size(227, 82)
        Me.lstAudioBooks.TabIndex = 0
        '
        'btnAddAudioBook
        '
        Me.btnAddAudioBook.Location = New System.Drawing.Point(19, 157)
        Me.btnAddAudioBook.Name = "btnAddAudioBook"
        Me.btnAddAudioBook.Size = New System.Drawing.Size(120, 30)
        Me.btnAddAudioBook.TabIndex = 1
        Me.btnAddAudioBook.Text = "Add Book to Cart"
        Me.btnAddAudioBook.UseVisualStyleBackColor = True
        '
        'btnCloseAudioForm
        '
        Me.btnCloseAudioForm.Location = New System.Drawing.Point(150, 157)
        Me.btnCloseAudioForm.Name = "btnCloseAudioForm"
        Me.btnCloseAudioForm.Size = New System.Drawing.Size(120, 30)
        Me.btnCloseAudioForm.TabIndex = 2
        Me.btnCloseAudioForm.Text = "Close"
        Me.btnCloseAudioForm.UseVisualStyleBackColor = True
        '
        'AudioBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 202)
        Me.Controls.Add(Me.btnCloseAudioForm)
        Me.Controls.Add(Me.btnAddAudioBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AudioBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Audio Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstAudioBooks As System.Windows.Forms.ListBox
    Friend WithEvents btnAddAudioBook As System.Windows.Forms.Button
    Friend WithEvents btnCloseAudioForm As System.Windows.Forms.Button
End Class
