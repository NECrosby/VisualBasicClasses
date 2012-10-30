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
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picFive = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click an image to show a message box."
        '
        'picOne
        '
        Me.picOne.Image = CType(resources.GetObject("picOne.Image"), System.Drawing.Image)
        Me.picOne.Location = New System.Drawing.Point(12, 89)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(83, 103)
        Me.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOne.TabIndex = 1
        Me.picOne.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Image = CType(resources.GetObject("picTwo.Image"), System.Drawing.Image)
        Me.picTwo.Location = New System.Drawing.Point(109, 89)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(83, 103)
        Me.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTwo.TabIndex = 2
        Me.picTwo.TabStop = False
        '
        'picThree
        '
        Me.picThree.Image = CType(resources.GetObject("picThree.Image"), System.Drawing.Image)
        Me.picThree.Location = New System.Drawing.Point(206, 89)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(83, 103)
        Me.picThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picThree.TabIndex = 3
        Me.picThree.TabStop = False
        '
        'picFour
        '
        Me.picFour.Image = CType(resources.GetObject("picFour.Image"), System.Drawing.Image)
        Me.picFour.Location = New System.Drawing.Point(303, 89)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(83, 103)
        Me.picFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFour.TabIndex = 4
        Me.picFour.TabStop = False
        '
        'picFive
        '
        Me.picFive.Image = CType(resources.GetObject("picFive.Image"), System.Drawing.Image)
        Me.picFive.Location = New System.Drawing.Point(400, 89)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(83, 103)
        Me.picFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFive.TabIndex = 5
        Me.picFive.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(210, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Clickable Images"
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picOne As System.Windows.Forms.PictureBox
    Friend WithEvents picTwo As System.Windows.Forms.PictureBox
    Friend WithEvents picThree As System.Windows.Forms.PictureBox
    Friend WithEvents picFour As System.Windows.Forms.PictureBox
    Friend WithEvents picFive As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
