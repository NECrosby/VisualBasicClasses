Public Class movedData
    Private _dateTime As DateTime = DateTime.MinValue 'Holds the date and time of event
    Private _machine As String = String.Empty         'Holds the machine name
    Private _empid As String = String.Empty           'Holds the employee ID
    Private _comments As String = String.Empty        'Holds any comments
    Private _status1Code As String = String.Empty     'Holds the status code of the lot
    Private _type As String = String.Empty            'Holds event type either Inline Move or Machine Status
    Private _lot As String = String.Empty             'Holds the lot number
    Private _bitmap As Image                          'Holds image 

    Public Sub New(ByVal moveDateTime As DateTime, ByVal moveMachine As String, ByVal moveEmpid As String, ByVal moveComments As String, ByVal moveStatus1_code As String, ByVal moveType As String, ByVal moveLot As String)
        Me._dateTime = moveDateTime
        Me._machine = moveMachine
        Me._empid = moveEmpid
        Me._lot = moveLot
        Me._status1Code = moveStatus1_code
        Me._type = moveType
        If Me._type.ToLower = "inline move" Then
            Me._bitmap = My.Resources.Resource1.Lot
        Else
            Me._bitmap = My.Resources.Resource1.BaseMachine
        End If
        Me._comments = moveComments
    End Sub

    Public Property MovedDateTime() As DateTime
        Get
            Return Me._dateTime
        End Get
        Set(ByVal value As DateTime)
            Me._dateTime = value
        End Set
    End Property

    Public Property MovedMachine() As String
        Get
            Return Me._machine
        End Get
        Set(ByVal value As String)
            Me._machine = value
        End Set
    End Property

    Public Property MovedEmpid() As String
        Get
            Return Me._empid
        End Get
        Set(ByVal value As String)
            Me._empid = value
        End Set
    End Property

    Public Property MovedComments() As String
        Get
            Return Me._comments
        End Get
        Set(ByVal value As String)
            Me._comments = value
        End Set
    End Property

    Public Property MovedStatus1Code() As String
        Get
            Return Me._status1Code
        End Get
        Set(ByVal value As String)
            Me._status1Code = value
        End Set
    End Property

    Public Property MovedType() As String
        Get
            Return Me._type
        End Get
        Set(ByVal value As String)
            Me._type = value
        End Set
    End Property

    Public Property MovedLot() As String
        Get
            Return Me._lot
        End Get
        Set(ByVal value As String)
            Me._lot = value
        End Set
    End Property

    Public Property Bitmap() As Image
        Get
            Return Me._bitmap
        End Get
        Set(ByVal value As Image)
            Me._bitmap = value
        End Set
    End Property


End Class
