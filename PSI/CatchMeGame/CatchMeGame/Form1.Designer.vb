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
        Me.ButtonCatchMe = New System.Windows.Forms.Button
        Me.TimerGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonCatchMe
        '
        Me.ButtonCatchMe.Location = New System.Drawing.Point(252, 210)
        Me.ButtonCatchMe.Name = "ButtonCatchMe"
        Me.ButtonCatchMe.Size = New System.Drawing.Size(75, 25)
        Me.ButtonCatchMe.TabIndex = 0
        Me.ButtonCatchMe.Text = "Catch Me!"
        Me.ButtonCatchMe.UseVisualStyleBackColor = True
        '
        'TimerGameTimer
        '
        Me.TimerGameTimer.Enabled = True
        Me.TimerGameTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 446)
        Me.Controls.Add(Me.ButtonCatchMe)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catch Me!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCatchMe As System.Windows.Forms.Button
    Friend WithEvents TimerGameTimer As System.Windows.Forms.Timer

End Class
