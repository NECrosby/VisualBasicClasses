Public Class Student
    Public _IDnumber As String
    Public _LastName As String
    Private _TestAverage As Double

    Public Sub New()

    End Sub
    Public Sub New(ByVal ID As String, ByVal lastName As String, ByVal testAverage As Double)
        Me._IDnumber = ID
        Me._LastName = lastName
        Me._TestAverage = testAverage
    End Sub

    Public Property IDnumber() As String
        Get
            Return Me._IDnumber
        End Get
        Set(ByVal value As String)
            Me._IDnumber = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return Me._LastName
        End Get
        Set(ByVal value As String)
            Me._LastName = value
        End Set
    End Property
    Public Property TestAverage() As Double
        Get
            Return Me._TestAverage
        End Get
        Set(ByVal value As Double)
            If value >= 0.0 And value <= 100.0 Then
                Me._TestAverage = value
            Else
                MessageBox.Show("Invalid test average.", "Error")
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Me.IDnumber & ", " & Me.LastName & ", Test Average = " & Me.TestAverage
    End Function
End Class
