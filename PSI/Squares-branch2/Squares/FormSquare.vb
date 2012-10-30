Option Strict On
Option Explicit On

Public Class FormSquares
    Dim _squares As SquareCollection


    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me._squares = New SquareCollection
    End Sub
    '---------------------------------------------------
    '   Color button
    '---------------------------------------------------
    Private Sub ButtonSquareColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSquareColor.Click
        Dim myColorDialog As New ColorDialog                            ' Creating a color dialog box instantiation
        myColorDialog.ShowDialog()                                      ' Showing the color dialog box when the Color button is clicked 
        Me.ButtonSquareColor.BackColor = myColorDialog.Color            ' Assigning the selected color to the Color button/object color
    End Sub

    '---------------------------------------------------
    ' Add Square to Collection Button
    '---------------------------------------------------
    Private Sub AddSquareBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSquareBtn.Click
        Dim mySquare As New Square  ' Instantiating a new square
        ' Variables to use for the TryParse function
        Dim intWidth As Integer
        Dim intLength As Integer
        Dim intXstart As Integer
        Dim intYstart As Integer
        Dim intXend As Integer
        Dim intYend As Integer

        If Integer.TryParse(WidthTextBox.Text, intWidth) Then
            If Integer.TryParse(LengthTextBox.Text, intLength) Then
                If Integer.TryParse(TextBoxPositionStartX.Text, intXstart) Then
                    If Integer.TryParse(TextBoxPositionStartY.Text, intYstart) Then
                        If Integer.TryParse(TextBoxEndPositionX.Text, intXend) Then
                            If Integer.TryParse(TextBoxEndPositionY.Text, intYend) Then
                                mySquare.Width = System.Convert.ToInt32(WidthTextBox.Text)                      ' Getting the width from the width input box
                                mySquare.Height = System.Convert.ToInt32(LengthTextBox.Text)                    ' Getting the length from the length input box
                                mySquare.StartXposition = System.Convert.ToInt32(TextBoxPositionStartX.Text)    ' Getting the X position from the text box
                                mySquare.StartYposition = System.Convert.ToInt32(TextBoxPositionStartY.Text)    ' Getting the Y position from the text box
                                mySquare.EndXposition = System.Convert.ToInt32(TextBoxEndPositionX.Text)
                                mySquare.EndYposition = System.Convert.ToInt32(TextBoxEndPositionY.Text)
                                mySquare.Color = Me.ButtonSquareColor.BackColor                                 ' Getting the color from the color button
                                '---------------------------------------------------------------
                                Me._squares.Add(mySquare)   ' Adding the square to the collection object
                                Me.LabelsquareCount.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "Squares in Collection: {0}", Me._squares.Count)
                            Else
                                MessageBox.Show("Please enter an Integer into the End Y position text box.")
                                TextBoxEndPositionY.Clear()
                                TextBoxEndPositionY.Focus()
                            End If
                        Else
                            MessageBox.Show("Please enter an Integer into the End X position text box.")
                            TextBoxEndPositionX.Clear()
                            TextBoxEndPositionX.Focus()
                        End If
                    Else
                        MessageBox.Show("Please enter an Integer into the Start Y position text box.")
                        TextBoxPositionStartY.Clear()
                        TextBoxPositionStartY.Focus()
                    End If
                Else
                    MessageBox.Show("Please enter an Integer into the Start X position text box.")
                    TextBoxPositionStartX.Clear()
                    TextBoxPositionStartX.Focus()
                End If
            Else
                MessageBox.Show("Please enter an Integer into the Length text box.")
                LengthTextBox.Clear()
                LengthTextBox.Focus()
            End If
        Else
            MessageBox.Show("Please enter an Integer into the Width text box.")
            WidthTextBox.Clear()
            WidthTextBox.Focus()
        End If
    End Sub
    '---------------------------------------------------
    ' Move Squares
    '---------------------------------------------------
    Public Sub MoveSquares(ByVal _squares As SquareCollection)
        Dim picture As Bitmap = New Bitmap(DrawSquarePictureBox.Width, DrawSquarePictureBox.Height, Imaging.PixelFormat.Format16bppRgb555)
        Dim drawingSurface As Graphics = Graphics.FromImage(picture)    ' Declare a graphics drawing surface
        Dim Blank As Color = Color.FromArgb(255, 255, 255, 255)         ' Declare a color user to erase the drawing surface
        Dim Brush As New SolidBrush(Color.White)                        ' Declare a brush to draw with and a default color
        Dim LinePen As New Pen(Color.Black, 0.24)                       ' Declare a pin to write with (used for drawing outline)

        drawingSurface.Clear(Blank)                                     ' Clear off the drawing surface

        For Each tempSquare As Square In Me._squares
            Dim currentX As Integer = tempSquare.StartXposition
            Dim currentY As Integer = tempSquare.StartYposition

            If (tempSquare.StartXposition > tempSquare.EndXposition) And (tempSquare.StartYposition > tempSquare.EndYposition) Then
                currentX -= 1
                currentY -= 1
                Me.DrawSquarePictureBox.Refresh()

            ElseIf (tempSquare.StartXposition > tempSquare.EndXposition) And (tempSquare.StartYposition < tempSquare.EndYposition) Then
                currentX -= 1
                currentY += 1
                Me.DrawSquarePictureBox.Refresh()

            ElseIf (tempSquare.StartXposition < tempSquare.EndXposition) And (tempSquare.StartYposition < tempSquare.EndYposition) Then
                currentX += 1
                currentY += 1
                Me.DrawSquarePictureBox.Refresh()

            ElseIf (tempSquare.StartXposition < tempSquare.EndXposition) And (tempSquare.StartYposition > tempSquare.EndYposition) Then
                currentX += 1
                currentY -= 1
                Me.DrawSquarePictureBox.Refresh()

            End If

            Brush.Color = tempSquare.Color                              ' The brush to draw with
            drawingSurface.FillRectangle(Brush, tempSquare.StartXposition, tempSquare.StartYposition, tempSquare.Width, tempSquare.Height)         ' Draw the rectangle on the graphics (x, y is the starting location) 
            drawingSurface.DrawRectangle(LinePen, tempSquare.StartXposition, tempSquare.StartYposition, tempSquare.Width, tempSquare.Height)       ' Draw an outline around the rectangle (x, y is the starting location)


            Me.DrawSquarePictureBox.Image = picture
            tempSquare.StartXposition = currentX
            tempSquare.StartYposition = currentY

        Next
    End Sub
    '---------------------------------------------------
    ' Draw Square Button
    '---------------------------------------------------
    Private Sub DrawSquareButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrawSquareButton.Click
        ' below - create a canvas to draw the image on (get size from picture box)
        'Dim picture As Bitmap = New Bitmap(DrawSquarePictureBox.Width, DrawSquarePictureBox.Height, Imaging.PixelFormat.Format16bppRgb555)
        'Dim drawingSurface As Graphics = Graphics.FromImage(picture)    ' Declare a graphics drawing surface
        'Dim Blank As Color = Color.FromArgb(255, 255, 255, 255)         ' Declare a color user to erase the drawing surface
        'Dim Brush As New SolidBrush(Color.White)                        ' Declare a brush to draw with and a default color
        'Dim LinePen As New Pen(Color.Black, 0.24)                       ' Declare a pin to write with (used for drawing outline)

        'drawingSurface.Clear(Blank)                                     ' Clear off the drawing surface

        '' For Each variable As type In instantiated Object
        'For Each tempSquare As Square In Me._squares
        '    Brush.Color = tempSquare.Color                              ' The brush to draw with
        '    drawingSurface.FillRectangle(Brush, tempSquare.StartXposition, tempSquare.StartYposition, tempSquare.Width, tempSquare.Height)         ' Draw the rectangle on the graphics (x, y is the starting location) 
        '    drawingSurface.DrawRectangle(LinePen, tempSquare.StartXposition, tempSquare.StartYposition, tempSquare.Width, tempSquare.Height)       ' Draw an outline around the rectangle (x, y is the starting location)
        'Next

        'Me.DrawSquarePictureBox.Image = picture                         ' Set the image on the DrawSquarePictureBox

        '----------------------------------------------------------------------------
        ' -- Testing --
        'For Each tempSquare As Square In Me._squares
        '    Dim currentX As Integer = tempSquare.StartXposition
        '    Dim currentY As Integer = tempSquare.StartYposition

        '    While (currentX = tempSquare.EndXposition) And (currentY = tempSquare.EndYposition)
        '        If (tempSquare.StartXposition > tempSquare.EndXposition) And (tempSquare.StartYposition > tempSquare.EndYposition) Then
        '            currentX -= 1
        '            currentY -= 1
        '            Me.DrawSquarePictureBox.Refresh()
        '        ElseIf (tempSquare.StartXposition > tempSquare.EndXposition) And (tempSquare.StartYposition > tempSquare.EndYposition) Then
        '            currentX -= 1
        '            currentY += 1
        '            Me.DrawSquarePictureBox.Refresh()
        '        ElseIf (tempSquare.StartXposition > tempSquare.EndXposition) And (tempSquare.StartYposition > tempSquare.EndYposition) Then
        '            currentX += 1
        '            currentY += 1
        '            Me.DrawSquarePictureBox.Refresh()
        '        ElseIf (tempSquare.StartXposition > tempSquare.EndXposition) And (tempSquare.StartYposition > tempSquare.EndYposition) Then
        '            currentX += 1
        '            currentY -= 1
        '            Me.DrawSquarePictureBox.Refresh()
        '        End If
        '    End While
        'Next
        '-----------------------------------------------------------------------------

        ClearTextBoxes()

    End Sub
    '---------------------------------------------------
    '   Clear Text Boxes Sub
    '---------------------------------------------------
    Private Sub ClearTextBoxes()
        WidthTextBox.Clear()                                            ' Clearing the input box for next object
        LengthTextBox.Clear()                                           ' Clearing the input box for next object
        TextBoxPositionStartX.Clear()
        TextBoxPositionStartY.Clear()
        TextBoxEndPositionX.Clear()
        TextBoxEndPositionY.Clear()
        WidthTextBox.Focus()
    End Sub
    '---------------------------------------------------
    '   Animate squares
    '---------------------------------------------------
    Private Sub TimerMoveSquare_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMoveSquare.Tick

        MoveSquares(Me._squares)


        '=============================================================================================================
        ' -- Playing with Random Numbers -- 

        'Dim random As New Random
        'Dim stopXposition, stopYposition As Integer

        'For Each tempSquare As Square In Me._squares
        '    stopXposition = random.Next(Me.DrawSquarePictureBox.Width - tempSquare.Width)    ' Getting a random number to be used for the stop x & Y positions
        '    stopYposition = random.Next(Me.DrawSquarePictureBox.Height - tempSquare.Height)
        '    tempSquare.Xposition = stopXposition
        '    tempSquare.Yposition = stopYposition
        'Next

        'DrawSquarePictureBox.Refresh()

        'While (startXPosition <> stopXPostion) And (startYPosition <> stopYPosition)
        'mySquare.xPosition += 25
        'mySquare.yPosition += 25
        'DrawSquarePictureBox.Refresh()
        'End While
        '=============================================================================================================
    End Sub

    '---------------------------------------------------
    '   Exit button
    '---------------------------------------------------
    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()                                                      ' Closes the application
    End Sub
End Class

