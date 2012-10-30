Public Class EquipHistory
    Private _dateTime As DateTime = DateTime.MinValue
    Private _machine As String = String.Empty
    Private _empid As String = String.Empty
    Private _status1Code As String = String.Empty
    Private _comments As String = String.Empty
    Private _additionalComments As String = String.Empty


    Public Sub New(ByVal eqHisDateTime As DateTime, ByVal eqHisMachine As String, ByVal eqHisEmpid As String, ByVal eqHisStatusCode As String, ByVal eqHisComments As String, ByVal eqHisAdditionalComments As String)
        Me._dateTime = eqHisDateTime
        Me._machine = eqHisMachine
        Me._empid = eqHisEmpid
        Me._status1Code = eqHisStatusCode
        Me._comments = eqHisComments
        Me._additionalComments = eqHisAdditionalComments

    End Sub

    Public Property EquipHistoryDateTime() As DateTime
        Get
            Return Me._dateTime
        End Get
        Set(ByVal value As DateTime)
            Me._dateTime = value
        End Set
    End Property

    Public Property EquipHistoryMachine() As String
        Get
            Return Me._machine
        End Get
        Set(ByVal value As String)
            Me._machine = value
        End Set
    End Property

    Public Property EquipHistoryEmpid() As String
        Get
            Return Me._empid
        End Get
        Set(ByVal value As String)
            Me._empid = value
        End Set
    End Property

    Public Property EquipHistoryStatusCode() As String
        Get
            Return Me._status1Code
        End Get
        Set(ByVal value As String)
            Me._status1Code = value
        End Set
    End Property

    Public Property EquipHistoryComments() As String
        Get
            Return Me._comments
        End Get
        Set(ByVal value As String)
            Me._comments = value
        End Set
    End Property

    Public ReadOnly Property EquipHistoryAdditionalComments() As String
        Get
            Return Me._additionalComments
        End Get
    End Property



End Class
