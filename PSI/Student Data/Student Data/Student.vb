Public Class Student
    Private _LastName As String
    Private _FirstName As String
    Private _ID As String
    Private _TestAverage As Double

    ' Constructor
    Public Sub New()
        Debug.WriteLine("Student object being created.")
        _FirstName = "(unknown)"
        _LastName = "(unknown)"
        _ID = "(unknown)"
        _TestAverage = 0.0
    End Sub

    ' Properties
    Public Property LastName() As String
        Get
            Return Me._LastName
        End Get
        Set(ByVal value As String)
            Me._LastName = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return Me._FirstName
        End Get
        Set(ByVal value As String)
            Me._FirstName = value
        End Set
    End Property
    Public Property ID() As String
        Get
            Return Me._ID
        End Get
        Set(ByVal value As String)
            Me._ID = value
        End Set
    End Property
    Public Property TestAverage() As Double
        Get
            Return Me._TestAverage
        End Get
        Set(ByVal value As Double)
            Me._TestAverage = value
        End Set
    End Property
    Public ReadOnly Property Grade() As String
        Get
            Dim studentGrade As String

            If Me._TestAverage >= 90.0 Then
                studentGrade = "A"
            ElseIf Me._TestAverage >= 80.0 Then
                studentGrade = "B"
            ElseIf Me._TestAverage >= 70.0 Then
                studentGrade = "C"
            ElseIf Me._TestAverage >= 60.0 Then
                studentGrade = "D"
            Else
                studentGrade = "F"
            End If

            Return studentGrade
        End Get
    End Property
    'Protected Overrides Sub Finalize()
    '    MyBase.Finalize()
    '    Debug.WriteLine("Student object destroyed.")
    'End Sub

End Class
