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
        Dim mySquare As New Square                                          ' Instantiating a new square
        '---------------------------------------------------------------
        ' Dim intTemp As Integer
        If WidthTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a number into the Width text box.")
            WidthTextBox.Focus()
        ElseIf Not IsNumeric(WidthTextBox.Text) Then
            MessageBox.Show("Please enter a number into the Width text box.")
            WidthTextBox.Clear()
            WidthTextBox.Focus()
        Else
            mySquare.Width = CInt(WidthTextBox.Text)                        ' Getting the width from the width input box
        End If

        '---------------------------------------------------------------
        If LengthTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a number into the Length text box.")
            LengthTextBox.Focus()
        ElseIf Not IsNumeric(LengthTextBox.Text) Then
            MessageBox.Show("Please enter a number into the Length text box.")
            LengthTextBox.Clear()
            LengthTextBox.Focus()
        Else
            mySquare.Length = CInt(LengthTextBox.Text)                        ' Getting the length from the length input box
        End If
        '---------------------------------------------------------------

        If TextBoxXPosition.Text = String.Empty Then
            MessageBox.Show("Please enter a number into the X position text box.")
            TextBoxXPosition.Focus()
        ElseIf Not IsNumeric(TextBoxXPosition.Text) Then
            MessageBox.Show("Please enter a number into the X position text box.")
            TextBoxXPosition.Clear()
            TextBoxXPosition.Focus()
        Else
            mySquare.Xposition = CInt(TextBoxXPosition.Text)                    ' Getting the X position from the text box
        End If
        '---------------------------------------------------------------
        If TextBoxYPosition.Text = String.Empty Then
            MessageBox.Show("Please enter a number into the Y position text box.")
            TextBoxYPosition.Focus()
        ElseIf Not IsNumeric(TextBoxYPosition.Text) Then
            MessageBox.Show("Please enter a number into the Y position text box.")
            TextBoxYPosition.Clear()
            TextBoxYPosition.Focus()
        Else
            mySquare.Yposition = CInt(TextBoxYPosition.Text)                    ' Getting the Y position from the text box
        End If
        '---------------------------------------------------------------
        mySquare.Color = Me.ButtonSquareColor.BackColor                       ' Getting the color from the color button
        '---------------------------------------------------------------
        Me._squares.Add(mySquare)                                       ' Adding the square to the collection object
        Me.LabelsquareCount.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "Squares in Collection: {0}", Me._squares.Count)
    End Sub
    '---------------------------------------------------
    ' Draw Square Button
    '---------------------------------------------------
    Private Sub DrawSquareButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrawSquareButton.Click
        ' below - create a canvas to draw the image on (get size from picture box)
        Dim picture As Bitmap = New Bitmap(DrawSquarePictureBox.Width, DrawSquarePictureBox.Height, Imaging.PixelFormat.Format16bppRgb555)
        Dim drawingSurface As Graphics = Graphics.FromImage(picture)    ' Declare a graphics drawing surface
        Dim Blank As Color = Color.FromArgb(255, 255, 255, 255)         ' Declare a color user to erase the drawing surface
        Dim Brush As New SolidBrush(Color.White)                        ' Declare a brush to draw with and a default color
        Dim LinePen As New Pen(Color.Black, 0.24)                       ' Declare a pin to write with (used for drawing outline)
        drawingSurface.Clear(Blank)                                     ' Clear off the drawing surface

        For Each tempSquare As Square In _squares                       ' For Each variable As type In instantiatedObject
            Brush.Color = tempSquare.Color                              ' The brush to draw with
            drawingSurface.FillRectangle(Brush, tempSquare.Xposition, tempSquare.Yposition, tempSquare.Width, tempSquare.Length)         ' Draw the rectangle on the graphics (x, y is the starting location) 
            drawingSurface.DrawRectangle(LinePen, tempSquare.Xposition, tempSquare.Yposition, tempSquare.Width, tempSquare.Length)       ' Draw an outline around the rectangle (x, y is the starting location)
        Next

        Me.DrawSquarePictureBox.Image = picture                         ' Set the image on the DrawSquarePictureBox
        WidthTextBox.Clear()                                            ' Clearing the input box for next object
        LengthTextBox.Clear()                                           ' Clearing the input box for next object
        TextBoxXPosition.Clear()
        TextBoxYPosition.Clear()
        WidthTextBox.Focus()
    End Sub
    '---------------------------------------------------
    '   Exit button
    '---------------------------------------------------
    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()                                                      ' Closes the application
    End Sub

    'Private Sub AddSquareBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSquareBtn.Click
    '    Dim mySquare As New Square                                          ' Instantiating a new square

    '    If Not IsNumeric(WidthTextBox.Text) Then
    '        If Not IsNumeric(LengthTextBox.Text) Then
    '            If Not IsNumeric(TextBoxXPosition.Text) Then
    '                If Not IsNumeric(TextBoxYPosition.Text) Then
    '                    MessageBox.Show("Please enter a number into the Y position text box.")
    '                    TextBoxYPosition.Clear()
    '                    TextBoxYPosition.Focus()
    '                Else
    '                    mySquare.Yposition = CInt(TextBoxYPosition.Text)                    ' Getting the Y position from the text box
    '                End If
    '                MessageBox.Show("Please enter a number into the X position text box.")
    '                TextBoxXPosition.Clear()
    '                TextBoxXPosition.Focus()
    '            Else
    '                mySquare.Xposition = CInt(TextBoxXPosition.Text)                    ' Getting the X position from the text box
    '            End If
    '            MessageBox.Show("Please enter a number into the Length text box.")
    '            LengthTextBox.Clear()
    '            LengthTextBox.Focus()
    '        Else
    '            mySquare.Length = CInt(LengthTextBox.Text)                        ' Getting the length from the length input box
    '        End If
    '        MessageBox.Show("Please enter a number into the Width text box.")
    '        WidthTextBox.Clear()
    '        WidthTextBox.Focus()
    '    Else
    '        mySquare.Width = CInt(WidthTextBox.Text)                        ' Getting the width from the width input box
    '    End If

    '    mySquare.Color = Me.ButtonSquareColor.BackColor                       ' Getting the color from the color button
    '    '---------------------------------------------------------------
    '    Me._squares.Add(mySquare)                                       ' Adding the square to the collection object
    '    Me.LabelsquareCount.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "Squares in Collection: {0}", Me._squares.Count)
    'End Sub
End Class

