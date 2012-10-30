Public Class Square
    Private _width As Integer = 0
    Private _height As Integer = 0
    Private _color As Color = Drawing.Color.Black
    Private _startXposition As Integer = 0
    Private _startYposition As Integer = 0
    Private _endXposition As Integer = 0
    Private _endYposition As Integer = 0

    Public Sub New()

    End Sub

    Public Sub New(ByVal squareWidth As Integer, ByVal squareHeight As Integer, ByVal squareColor As Color)
        Me._width = squareWidth
        Me._height = squareHeight
        Me._color = squareColor
    End Sub

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
End Class
