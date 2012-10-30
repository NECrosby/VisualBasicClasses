Public Class Square
    '---------------------------------------------------
    '   Class Variables
    '---------------------------------------------------
    Private _width As Integer = 0
    Private _height As Integer = 0
    Private _color As Color = Drawing.Color.Black
    Private _startXposition As Integer = 0
    Private _startYposition As Integer = 0
    Private _endXposition As Integer = 0
    Private _endYposition As Integer = 0
    Private _originalX As Integer = 0
    Private _originalY As Integer = 0
    Private _speed As Integer = 0
    '---------------------------------------------------
    '   Constructor
    '---------------------------------------------------
    Public Sub New()

    End Sub
    Public Sub New(ByVal squareWidth As Integer, ByVal squareHeight As Integer, ByVal squareSpeed As Integer, ByVal squareColor As Color)
        Me._width = squareWidth
        Me._height = squareHeight
        Me._speed = squareSpeed
        Me._color = squareColor
    End Sub
    '---------------------------------------------------
    '   Properties
    '---------------------------------------------------
    Public Property Width() As Integer
        Get
            Return Me._width
        End Get
        Set(ByVal value As Integer)
            Me._width = value
        End Set
    End Property

    Public Property Height() As Integer
        Get
            Return Me._height
        End Get
        Set(ByVal value As Integer)
            Me._height = value
        End Set
    End Property

    Public Property Color() As Color
        Get
            Return Me._color
        End Get
        Set(ByVal value As Color)
            Me._color = value
        End Set
    End Property

    Public Property StartXposition() As Integer
        Get
            Return Me._startXposition
        End Get
        Set(ByVal value As Integer)
            Me._startXposition = value
        End Set
    End Property

    Public Property StartYposition() As Integer
        Get
            Return Me._startYposition
        End Get
        Set(ByVal value As Integer)
            Me._startYposition = value
        End Set
    End Property

    Public Property EndXposition() As Integer
        Get
            Return Me._endXposition
        End Get
        Set(ByVal value As Integer)
            Me._endXposition = value
        End Set
    End Property

    Public Property EndYposition() As Integer
        Get
            Return Me._endYposition
        End Get
        Set(ByVal value As Integer)
            Me._endYposition = value
        End Set
    End Property

    Public ReadOnly Property Perimeter() As Integer
        Get
            Dim perimeterValue As Double
            perimeterValue = (Me._width * 2) + (Me._height * 2)
            Return perimeterValue
        End Get

    End Property

    Public ReadOnly Property Area() As Integer
        Get
            Dim areaValue As Integer
            areaValue = Me._width * Me._height
            Return areaValue
        End Get

    End Property
    Public Property Speed() As Integer
        Get
            Return Me._speed
        End Get
        Set(ByVal value As Integer)
            Me._speed = value
        End Set
    End Property
    Public Property OriginalX() As Integer
        Get
            Return Me._originalX
        End Get
        Set(ByVal value As Integer)
            Me._originalX = value
        End Set
    End Property
    Public Property OriginalY() As Integer
        Get
            Return Me._originalY
        End Get
        Set(ByVal value As Integer)
            Me._originalY = value
        End Set
    End Property
    '---------------------------------------------------
    '   Functions & Subs
    '---------------------------------------------------
    Public Sub Move()
        Dim currentX As Integer = Me.StartXposition
        Dim currentY As Integer = Me.StartYposition

        'yellow square -- testing
        If (Me.OriginalX > Me.EndXposition) And (Me.OriginalY > Me.EndYposition) Then
            If (Me.StartXposition > Me.EndXposition) And (Me.StartYposition > Me.EndYposition) Then
                currentX -= Me._speed
                currentY -= Me._speed
            ElseIf (Me.EndXposition - Me.StartXposition) < Me._speed Then
                currentX = Me.EndXposition
                If (Me.EndYposition - Me.StartYposition) < Me._speed Then
                    currentY = Me.EndYposition
                End If
            End If

            ' orange square -- testing
        ElseIf (Me.OriginalX > Me.EndXposition) And (Me.OriginalY < Me.EndYposition) Then
            If (Me.StartXposition > Me.EndXposition) And (Me.StartYposition < Me.EndYposition) Then
                currentX -= Me._speed
                currentY += Me._speed
            ElseIf (Me.EndXposition - Me.StartXposition) < Me._speed Then
                currentX = Me.EndXposition
                If (Me.EndYposition - Me.StartYposition) < Me._speed Then
                    currentY = Me.EndYposition
                End If
            End If


            ' red square -- testing
        ElseIf (Me.OriginalX < Me.EndXposition) And (Me.OriginalY < Me.EndYposition) Then
            If (Me.StartXposition < Me.EndXposition) And (Me.StartYposition < Me.EndYposition) Then
                currentX += Me._speed
                currentY += Me._speed
            ElseIf (Me.EndXposition - Me.StartXposition) < Me._speed Then
                currentX = Me.EndXposition
                If (Me.EndYposition - Me.StartYposition) < Me._speed Then
                    currentY = Me.EndYposition
                End If
            End If


            ' green square --  testing
        ElseIf (Me.OriginalX < Me.EndXposition) And (Me.OriginalY > Me.EndYposition) Then
            If (Me.StartXposition < Me.EndXposition) And (Me.StartYposition > Me.EndYposition) Then
                currentX += Me._speed
                currentY -= Me._speed
            ElseIf (Me.EndXposition - Me.StartXposition) < Me._speed Then
                currentX = Me.EndXposition
                If (Me.EndYposition - Me.StartYposition) < Me._speed Then
                    currentY = Me.EndYposition
                End If
            End If
        End If

        '-----------------------------------
        Me.StartXposition = currentX        
        Me.StartYposition = currentY
        '-----------------------------------
    End Sub

    Public Sub ResetStartPosition(ByVal x, ByVal y)
        Dim resetDone As Boolean = True
        If resetDone Then
            Me._startXposition = Me._originalX
            Me._startYposition = Me._originalY
            resetDone = False
        End If

    End Sub
End Class
