<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSquares
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
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DrawSquarePictureBox = New System.Windows.Forms.PictureBox
        Me.DrawSquareButton = New System.Windows.Forms.Button
        Me.AddSquareBtn = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.ButtonSquareColor = New System.Windows.Forms.Button
        Me.LabelsquareCount = New System.Windows.Forms.Label
        Me.TimerMoveSquare = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxEndPositionY = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxEndPositionX = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBoxStartPosition = New System.Windows.Forms.GroupBox
        Me.TextBoxPositionStartY = New System.Windows.Forms.TextBox
        Me.LabelyPosition = New System.Windows.Forms.Label
        Me.TextBoxPositionStartX = New System.Windows.Forms.TextBox
        Me.LabelxPosition = New System.Windows.Forms.Label
        Me.GroupBoxEndPosition = New System.Windows.Forms.GroupBox
        Me.GroupBoxSquareDimensions = New System.Windows.Forms.GroupBox
        Me.LengthTextBox = New System.Windows.Forms.TextBox
        Me.WidthTextBox = New System.Windows.Forms.TextBox
        Me.Length = New System.Windows.Forms.Label
        Me.sqWidth = New System.Windows.Forms.Label
        Me.TextBoxSpeed = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.DrawSquarePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxStartPosition.SuspendLayout()
        Me.GroupBoxEndPosition.SuspendLayout()
        Me.GroupBoxSquareDimensions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(118, 464)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(85, 45)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Drawing Squares and Adding Squares to a Collection Object"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DrawSquarePictureBox
        '
        Me.DrawSquarePictureBox.BackColor = System.Drawing.Color.White
        Me.DrawSquarePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DrawSquarePictureBox.Location = New System.Drawing.Point(215, 59)
        Me.DrawSquarePictureBox.Name = "DrawSquarePictureBox"
        Me.DrawSquarePictureBox.Size = New System.Drawing.Size(450, 450)
        Me.DrawSquarePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DrawSquarePictureBox.TabIndex = 19
        Me.DrawSquarePictureBox.TabStop = False
        '
        'DrawSquareButton
        '
        Me.DrawSquareButton.Location = New System.Drawing.Point(21, 464)
        Me.DrawSquareButton.Name = "DrawSquareButton"
        Me.DrawSquareButton.Size = New System.Drawing.Size(85, 45)
        Me.DrawSquareButton.TabIndex = 5
        Me.DrawSquareButton.Text = "Reset" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Squares"
        Me.DrawSquareButton.UseVisualStyleBackColor = True
        '
        'AddSquareBtn
        '
        Me.AddSquareBtn.Location = New System.Drawing.Point(118, 411)
        Me.AddSquareBtn.Name = "AddSquareBtn"
        Me.AddSquareBtn.Size = New System.Drawing.Size(85, 45)
        Me.AddSquareBtn.TabIndex = 4
        Me.AddSquareBtn.Text = "Add Square"
        Me.AddSquareBtn.UseVisualStyleBackColor = True
        '
        'ButtonSquareColor
        '
        Me.ButtonSquareColor.Location = New System.Drawing.Point(21, 411)
        Me.ButtonSquareColor.Name = "ButtonSquareColor"
        Me.ButtonSquareColor.Size = New System.Drawing.Size(85, 45)
        Me.ButtonSquareColor.TabIndex = 3
        Me.ButtonSquareColor.Text = "Color"
        Me.ButtonSquareColor.UseVisualStyleBackColor = True
        '
        'LabelsquareCount
        '
        Me.LabelsquareCount.AutoSize = True
        Me.LabelsquareCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelsquareCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelsquareCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelsquareCount.Location = New System.Drawing.Point(21, 58)
        Me.LabelsquareCount.MinimumSize = New System.Drawing.Size(182, 0)
        Me.LabelsquareCount.Name = "LabelsquareCount"
        Me.LabelsquareCount.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelsquareCount.Size = New System.Drawing.Size(182, 25)
        Me.LabelsquareCount.TabIndex = 23
        Me.LabelsquareCount.Text = "Squares in Collection: "
        '
        'TimerMoveSquare
        '
        Me.TimerMoveSquare.Enabled = True
        Me.TimerMoveSquare.Interval = 1000
        '
        'TextBoxEndPositionY
        '
        Me.TextBoxEndPositionY.Location = New System.Drawing.Point(67, 47)
        Me.TextBoxEndPositionY.Name = "TextBoxEndPositionY"
        Me.TextBoxEndPositionY.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEndPositionY.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Y Position"
        '
        'TextBoxEndPositionX
        '
        Me.TextBoxEndPositionX.Location = New System.Drawing.Point(67, 21)
        Me.TextBoxEndPositionX.Name = "TextBoxEndPositionX"
        Me.TextBoxEndPositionX.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEndPositionX.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "X Position"
        '
        'GroupBoxStartPosition
        '
        Me.GroupBoxStartPosition.Controls.Add(Me.TextBoxPositionStartY)
        Me.GroupBoxStartPosition.Controls.Add(Me.LabelyPosition)
        Me.GroupBoxStartPosition.Controls.Add(Me.TextBoxPositionStartX)
        Me.GroupBoxStartPosition.Controls.Add(Me.LabelxPosition)
        Me.GroupBoxStartPosition.Location = New System.Drawing.Point(21, 221)
        Me.GroupBoxStartPosition.Name = "GroupBoxStartPosition"
        Me.GroupBoxStartPosition.Size = New System.Drawing.Size(182, 81)
        Me.GroupBoxStartPosition.TabIndex = 1
        Me.GroupBoxStartPosition.TabStop = False
        Me.GroupBoxStartPosition.Text = "Start Position"
        '
        'TextBoxPositionStartY
        '
        Me.TextBoxPositionStartY.Location = New System.Drawing.Point(67, 48)
        Me.TextBoxPositionStartY.Name = "TextBoxPositionStartY"
        Me.TextBoxPositionStartY.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPositionStartY.TabIndex = 1
        '
        'LabelyPosition
        '
        Me.LabelyPosition.AutoSize = True
        Me.LabelyPosition.Location = New System.Drawing.Point(11, 52)
        Me.LabelyPosition.Name = "LabelyPosition"
        Me.LabelyPosition.Size = New System.Drawing.Size(54, 13)
        Me.LabelyPosition.TabIndex = 26
        Me.LabelyPosition.Text = "Y Position"
        '
        'TextBoxPositionStartX
        '
        Me.TextBoxPositionStartX.Location = New System.Drawing.Point(67, 22)
        Me.TextBoxPositionStartX.Name = "TextBoxPositionStartX"
        Me.TextBoxPositionStartX.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPositionStartX.TabIndex = 0
        '
        'LabelxPosition
        '
        Me.LabelxPosition.AutoSize = True
        Me.LabelxPosition.Location = New System.Drawing.Point(11, 26)
        Me.LabelxPosition.Name = "LabelxPosition"
        Me.LabelxPosition.Size = New System.Drawing.Size(54, 13)
        Me.LabelxPosition.TabIndex = 25
        Me.LabelxPosition.Text = "X Position"
        '
        'GroupBoxEndPosition
        '
        Me.GroupBoxEndPosition.Controls.Add(Me.TextBoxEndPositionY)
        Me.GroupBoxEndPosition.Controls.Add(Me.Label3)
        Me.GroupBoxEndPosition.Controls.Add(Me.TextBoxEndPositionX)
        Me.GroupBoxEndPosition.Controls.Add(Me.Label2)
        Me.GroupBoxEndPosition.Location = New System.Drawing.Point(21, 314)
        Me.GroupBoxEndPosition.Name = "GroupBoxEndPosition"
        Me.GroupBoxEndPosition.Size = New System.Drawing.Size(182, 80)
        Me.GroupBoxEndPosition.TabIndex = 2
        Me.GroupBoxEndPosition.TabStop = False
        Me.GroupBoxEndPosition.Text = "End Position"
        '
        'GroupBoxSquareDimensions
        '
        Me.GroupBoxSquareDimensions.Controls.Add(Me.TextBoxSpeed)
        Me.GroupBoxSquareDimensions.Controls.Add(Me.Label4)
        Me.GroupBoxSquareDimensions.Controls.Add(Me.LengthTextBox)
        Me.GroupBoxSquareDimensions.Controls.Add(Me.WidthTextBox)
        Me.GroupBoxSquareDimensions.Controls.Add(Me.Length)
        Me.GroupBoxSquareDimensions.Controls.Add(Me.sqWidth)
        Me.GroupBoxSquareDimensions.Location = New System.Drawing.Point(21, 93)
        Me.GroupBoxSquareDimensions.Name = "GroupBoxSquareDimensions"
        Me.GroupBoxSquareDimensions.Size = New System.Drawing.Size(182, 116)
        Me.GroupBoxSquareDimensions.TabIndex = 0
        Me.GroupBoxSquareDimensions.TabStop = False
        Me.GroupBoxSquareDimensions.Text = "Square Information"
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(67, 51)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LengthTextBox.TabIndex = 1
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(67, 25)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WidthTextBox.TabIndex = 0
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.Location = New System.Drawing.Point(25, 55)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(40, 13)
        Me.Length.TabIndex = 16
        Me.Length.Text = "Length"
        '
        'sqWidth
        '
        Me.sqWidth.AutoSize = True
        Me.sqWidth.Location = New System.Drawing.Point(30, 29)
        Me.sqWidth.Name = "sqWidth"
        Me.sqWidth.Size = New System.Drawing.Size(35, 13)
        Me.sqWidth.TabIndex = 14
        Me.sqWidth.Text = "Width"
        '
        'TextBoxSpeed
        '
        Me.TextBoxSpeed.Location = New System.Drawing.Point(67, 77)
        Me.TextBoxSpeed.Name = "TextBoxSpeed"
        Me.TextBoxSpeed.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSpeed.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Speed"
        '
        'FormSquares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 535)
        Me.Controls.Add(Me.GroupBoxSquareDimensions)
        Me.Controls.Add(Me.GroupBoxEndPosition)
        Me.Controls.Add(Me.GroupBoxStartPosition)
        Me.Controls.Add(Me.LabelsquareCount)
        Me.Controls.Add(Me.ButtonSquareColor)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DrawSquarePictureBox)
        Me.Controls.Add(Me.DrawSquareButton)
        Me.Controls.Add(Me.AddSquareBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormSquares"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fun with Squares"
        CType(Me.DrawSquarePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxStartPosition.ResumeLayout(False)
        Me.GroupBoxStartPosition.PerformLayout()
        Me.GroupBoxEndPosition.ResumeLayout(False)
        Me.GroupBoxEndPosition.PerformLayout()
        Me.GroupBoxSquareDimensions.ResumeLayout(False)
        Me.GroupBoxSquareDimensions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrawSquarePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DrawSquareButton As System.Windows.Forms.Button
    Friend WithEvents AddSquareBtn As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ButtonSquareColor As System.Windows.Forms.Button
    Friend WithEvents LabelsquareCount As System.Windows.Forms.Label
    Friend WithEvents TimerMoveSquare As System.Windows.Forms.Timer
    Friend WithEvents TextBoxEndPositionY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEndPositionX As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxStartPosition As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPositionStartY As System.Windows.Forms.TextBox
    Friend WithEvents LabelyPosition As System.Windows.Forms.Label
    Friend WithEvents TextBoxPositionStartX As System.Windows.Forms.TextBox
    Friend WithEvents LabelxPosition As System.Windows.Forms.Label
    Friend WithEvents GroupBoxEndPosition As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxSquareDimensions As System.Windows.Forms.GroupBox
    Friend WithEvents LengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WidthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Length As System.Windows.Forms.Label
    Friend WithEvents sqWidth As System.Windows.Forms.Label
    Friend WithEvents TextBoxSpeed As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
