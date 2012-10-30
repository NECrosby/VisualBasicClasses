Public Class Square
    Private _width As Integer = 0
    Private _length As Integer = 0
    Private _color As Color = Drawing.Color.Black
    Private _xPosition As Integer = 0
    Private _yPosition As Integer = 0

    Public Sub New()

    End Sub

    Public Sub New(ByVal squareWidth As Integer, ByVal squareLength As Integer, ByVal squareColor As Color)
        Me._width = squareWidth
        Me._length = squareLength
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

    Public Property Length() As Integer
        Get
            Return Me._length
        End Get
        Set(ByVal value As Integer)
            Me._length = value
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

    Public Property Xposition() As Integer
        Get
            Return Me._xPosition
        End Get
        Set(ByVal value As Integer)
            Me._xPosition = value
        End Set
    End Property

    Public Property Yposition() As Integer
        Get
            Return Me._yPosition
        End Get
        Set(ByVal value As Integer)
            Me._yPosition = value
        End Set
    End Property

    Public ReadOnly Property Perimeter() As Integer
        Get
            Dim perimeterValue As Double
            perimeterValue = (Me._width * 2) + (Me._length * 2)
            Return perimeterValue
        End Get

    End Property

    Public ReadOnly Property Area() As Integer
        Get
            Dim areaValue As Integer
            areaValue = Me._width * Me._length
            Return areaValue
        End Get

    End Property
End Class
