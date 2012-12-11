Public Class Customer
    Inherits Person

    Private intCustomerNumber As Integer
    Private boolMailingList As Boolean
    Private strComments As String

    Public Sub New()

    End Sub

    Public ReadOnly Property CustomerNumber() As Integer
        ' READ ONLY PROPERTY - unique number 
        Get
            Return intCustomerNumber
        End Get
    End Property
    Public Property MailingList() As Boolean
        Get
            Return boolMailingList
        End Get
        Set(ByVal value As Boolean)
            boolMailingList = value
        End Set
    End Property
    Public Property Comments() As String
        Get
            Return strComments
        End Get
        Set(ByVal value As String)
            strComments = value
        End Set
    End Property

End Class
