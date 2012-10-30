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
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DrawSquarePictureBox = New System.Windows.Forms.PictureBox
        Me.DrawSquareButton = New System.Windows.Forms.Button
        Me.AddSquareBtn = New System.Windows.Forms.Button
        Me.LengthTextBox = New System.Windows.Forms.TextBox
        Me.WidthTextBox = New System.Windows.Forms.TextBox
        Me.Length = New System.Windows.Forms.Label
        Me.sqWidth = New System.Windows.Forms.Label
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.ButtonSquareColor = New System.Windows.Forms.Button
        Me.LabelxPosition = New System.Windows.Forms.Label
        Me.TextBoxXPosition = New System.Windows.Forms.TextBox
        Me.TextBoxYPosition = New System.Windows.Forms.TextBox
        Me.LabelyPosition = New System.Windows.Forms.Label
        Me.LabelsquareCount = New System.Windows.Forms.Label
        CType(Me.DrawSquarePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(67, 450)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(105, 59)
        Me.ButtonExit.TabIndex = 7
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Drawing Squares and Adding Squares to a Collection Object"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DrawSquarePictureBox
        '
        Me.DrawSquarePictureBox.BackColor = System.Drawing.Color.White
        Me.DrawSquarePictureBox.Location = New System.Drawing.Point(206, 59)
        Me.DrawSquarePictureBox.Name = "DrawSquarePictureBox"
        Me.DrawSquarePictureBox.Size = New System.Drawing.Size(450, 450)
        Me.DrawSquarePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.DrawSquarePictureBox.TabIndex = 19
        Me.DrawSquarePictureBox.TabStop = False
        '
        'DrawSquareButton
        '
        Me.DrawSquareButton.Location = New System.Drawing.Point(67, 385)
        Me.DrawSquareButton.Name = "DrawSquareButton"
        Me.DrawSquareButton.Size = New System.Drawing.Size(105, 59)
        Me.DrawSquareButton.TabIndex = 6
        Me.DrawSquareButton.Text = "Draw Square"
        Me.DrawSquareButton.UseVisualStyleBackColor = True
        '
        'AddSquareBtn
        '
        Me.AddSquareBtn.Location = New System.Drawing.Point(67, 320)
        Me.AddSquareBtn.Name = "AddSquareBtn"
        Me.AddSquareBtn.Size = New System.Drawing.Size(105, 59)
        Me.AddSquareBtn.TabIndex = 5
        Me.AddSquareBtn.Text = "Add Square to Collection"
        Me.AddSquareBtn.UseVisualStyleBackColor = True
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(72, 85)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LengthTextBox.TabIndex = 1
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(72, 59)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WidthTextBox.TabIndex = 0
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.Location = New System.Drawing.Point(30, 89)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(40, 13)
        Me.Length.TabIndex = 12
        Me.Length.Text = "Length"
        '
        'sqWidth
        '
        Me.sqWidth.AutoSize = True
        Me.sqWidth.Location = New System.Drawing.Point(35, 63)
        Me.sqWidth.Name = "sqWidth"
        Me.sqWidth.Size = New System.Drawing.Size(35, 13)
        Me.sqWidth.TabIndex = 1
        Me.sqWidth.Text = "Width"
        '
        'ButtonSquareColor
        '
        Me.ButtonSquareColor.Location = New System.Drawing.Point(67, 255)
        Me.ButtonSquareColor.Name = "ButtonSquareColor"
        Me.ButtonSquareColor.Size = New System.Drawing.Size(105, 59)
        Me.ButtonSquareColor.TabIndex = 4
        Me.ButtonSquareColor.Text = "Color"
        Me.ButtonSquareColor.UseVisualStyleBackColor = True
        '
        'LabelxPosition
        '
        Me.LabelxPosition.AutoSize = True
        Me.LabelxPosition.Location = New System.Drawing.Point(16, 115)
        Me.LabelxPosition.Name = "LabelxPosition"
        Me.LabelxPosition.Size = New System.Drawing.Size(54, 13)
        Me.LabelxPosition.TabIndex = 20
        Me.LabelxPosition.Text = "X Position"
        '
        'TextBoxXPosition
        '
        Me.TextBoxXPosition.Location = New System.Drawing.Point(72, 111)
        Me.TextBoxXPosition.Name = "TextBoxXPosition"
        Me.TextBoxXPosition.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxXPosition.TabIndex = 2
        '
        'TextBoxYPosition
        '
        Me.TextBoxYPosition.Location = New System.Drawing.Point(72, 137)
        Me.TextBoxYPosition.Name = "TextBoxYPosition"
        Me.TextBoxYPosition.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxYPosition.TabIndex = 3
        '
        'LabelyPosition
        '
        Me.LabelyPosition.AutoSize = True
        Me.LabelyPosition.Location = New System.Drawing.Point(16, 141)
        Me.LabelyPosition.Name = "LabelyPosition"
        Me.LabelyPosition.Size = New System.Drawing.Size(54, 13)
        Me.LabelyPosition.TabIndex = 22
        Me.LabelyPosition.Text = "Y Position"
        '
        'LabelsquareCount
        '
        Me.LabelsquareCount.AutoSize = True
        Me.LabelsquareCount.Location = New System.Drawing.Point(16, 171)
        Me.LabelsquareCount.Name = "LabelsquareCount"
        Me.LabelsquareCount.Size = New System.Drawing.Size(112, 13)
        Me.LabelsquareCount.TabIndex = 23
        Me.LabelsquareCount.Text = "Squares in Collection: "
        '
        'FormSquares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 525)
        Me.Controls.Add(Me.LabelsquareCount)
        Me.Controls.Add(Me.TextBoxYPosition)
        Me.Controls.Add(Me.LabelyPosition)
        Me.Controls.Add(Me.TextBoxXPosition)
        Me.Controls.Add(Me.LabelxPosition)
        Me.Controls.Add(Me.ButtonSquareColor)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DrawSquarePictureBox)
        Me.Controls.Add(Me.DrawSquareButton)
        Me.Controls.Add(Me.AddSquareBtn)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.Length)
        Me.Controls.Add(Me.sqWidth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormSquares"
        Me.Text = "Form Squares"
        CType(Me.DrawSquarePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrawSquarePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DrawSquareButton As System.Windows.Forms.Button
    Friend WithEvents AddSquareBtn As System.Windows.Forms.Button
    Friend WithEvents LengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WidthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Length As System.Windows.Forms.Label
    Friend WithEvents sqWidth As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ButtonSquareColor As System.Windows.Forms.Button
    Friend WithEvents LabelxPosition As System.Windows.Forms.Label
    Friend WithEvents TextBoxXPosition As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxYPosition As System.Windows.Forms.TextBox
    Friend WithEvents LabelyPosition As System.Windows.Forms.Label
    Friend WithEvents LabelsquareCount As System.Windows.Forms.Label

End Class
