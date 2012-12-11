Public Class Person

    Private strLastName As String
    Private strFirstName As String
    Private strAddress As String
    Private strCity As String
    Private strState As String
    Private strZip As String
    Private strPhone As String

    Public Sub New()
        Debug.WriteLine("New Person being created.")
        strLastName = "(unknown)"
        strFirstName = "(unknown)"
        strAddress = "(unknown)"
        strCity = "(unknown)"
        strState = "(XX)"
        strZip = "(XXXXX)"
        strPhone = "(XXX)XXX-XXXX"
    End Sub

    Public Property LastName() As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return strCity
        End Get
        Set(ByVal value As String)
            strCity = value
        End Set
    End Property
    Public Property State() As String
        Get
            Return strState
        End Get
        Set(ByVal value As String)
            strState = value
        End Set
    End Property
    Public Property Zip() As String
        Get
            Return strZip
        End Get
        Set(ByVal value As String)
            strZip = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return strPhone
        End Get
        Set(ByVal value As String)
            strPhone = value
        End Set
    End Property
End Class
