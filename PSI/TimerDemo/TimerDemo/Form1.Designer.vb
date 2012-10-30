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
        Me.components = New System.ComponentModel.Container
        Me.ButtonToggleTimer = New System.Windows.Forms.Button
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelSecondsCount = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonReset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ButtonToggleTimer
        '
        Me.ButtonToggleTimer.Location = New System.Drawing.Point(110, 203)
        Me.ButtonToggleTimer.Name = "ButtonToggleTimer"
        Me.ButtonToggleTimer.Size = New System.Drawing.Size(75, 50)
        Me.ButtonToggleTimer.TabIndex = 0
        Me.ButtonToggleTimer.Text = "&Stop Timer"
        Me.ButtonToggleTimer.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(205, 203)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 50)
        Me.ButtonExit.TabIndex = 1
        Me.ButtonExit.Text = "E&xit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seconds Counter"
        '
        'LabelSecondsCount
        '
        Me.LabelSecondsCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSecondsCount.AutoSize = True
        Me.LabelSecondsCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSecondsCount.Location = New System.Drawing.Point(133, 111)
        Me.LabelSecondsCount.Name = "LabelSecondsCount"
        Me.LabelSecondsCount.Size = New System.Drawing.Size(17, 18)
        Me.LabelSecondsCount.TabIndex = 3
        Me.LabelSecondsCount.Text = "0"
        Me.LabelSecondsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(12, 203)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 50)
        Me.ButtonReset.TabIndex = 4
        Me.ButtonReset.Text = "&Reset Timer"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.LabelSecondsCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonToggleTimer)
        Me.Name = "Form1"
        Me.Text = "Timer Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonToggleTimer As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelSecondsCount As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonReset As System.Windows.Forms.Button

End Class
