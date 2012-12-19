Public Class Customer
    Inherits Person

    Private Shared intCustomerCount As Integer = 0
    Protected intCustomerNumber As Integer
    Private boolMailingList As Boolean
    Private strComments As String

    Public Sub New()
        Debug.WriteLine("New Customer being created.")
        UpdateCustomerCount()
        intCustomerNumber = 0
        boolMailingList = True
        strComments = String.Empty
    End Sub
    ' Update Customer Number inorder to keep unique
    Public Sub UpdateCustomerCount()
        intCustomerCount = intCustomerCount + 1
        ' intCustomerNumber = intCustomerCount
    End Sub
    ' READ ONLY PROPERTY - unique number 
    Public ReadOnly Property CustomerNumber() As Integer
        ' This should be static and every time a new 
        ' Customer is add increment the count.
        Get
            Return intCustomerCount
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
