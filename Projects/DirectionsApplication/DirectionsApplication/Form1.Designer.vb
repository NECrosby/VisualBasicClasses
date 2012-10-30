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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelDirections = New System.Windows.Forms.Label()
        Me.ButtonDisplayDirections = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonHideDirections = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(380, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Directions to the Highlander Hotel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 252)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabelDirections
        '
        Me.LabelDirections.AutoSize = True
        Me.LabelDirections.BackColor = System.Drawing.Color.White
        Me.LabelDirections.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelDirections.Location = New System.Drawing.Point(80, 316)
        Me.LabelDirections.Name = "LabelDirections"
        Me.LabelDirections.Padding = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.LabelDirections.Size = New System.Drawing.Size(321, 45)
        Me.LabelDirections.TabIndex = 2
        Me.LabelDirections.Text = "Traveling on I-89, take exit 125 South. The hotel is on the left." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Traveling on H" & _
            "ighway 101 North, the hotel is on the right," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "just before the I-89 intersection." & _
            ""
        Me.LabelDirections.Visible = False
        '
        'ButtonDisplayDirections
        '
        Me.ButtonDisplayDirections.Location = New System.Drawing.Point(92, 371)
        Me.ButtonDisplayDirections.Name = "ButtonDisplayDirections"
        Me.ButtonDisplayDirections.Size = New System.Drawing.Size(75, 35)
        Me.ButtonDisplayDirections.TabIndex = 3
        Me.ButtonDisplayDirections.Text = "Display Directions"
        Me.ButtonDisplayDirections.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(313, 371)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 35)
        Me.ButtonExit.TabIndex = 4
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonHideDirections
        '
        Me.ButtonHideDirections.Location = New System.Drawing.Point(197, 371)
        Me.ButtonHideDirections.Name = "ButtonHideDirections"
        Me.ButtonHideDirections.Size = New System.Drawing.Size(75, 35)
        Me.ButtonHideDirections.TabIndex = 5
        Me.ButtonHideDirections.Text = "Hide Directions"
        Me.ButtonHideDirections.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 418)
        Me.Controls.Add(Me.ButtonHideDirections)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonDisplayDirections)
        Me.Controls.Add(Me.LabelDirections)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Directions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelDirections As System.Windows.Forms.Label
    Friend WithEvents ButtonDisplayDirections As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonHideDirections As System.Windows.Forms.Button

End Class
