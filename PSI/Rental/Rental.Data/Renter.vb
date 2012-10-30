Public Class Renter
    '-------------------------------------------------------------
    ' Class Variables
    '-------------------------------------------------------------
    Private _ID As Integer = -1
    Private _FirstName As String = String.Empty
    Private _MI As String = String.Empty
    Private _LastName As String = String.Empty
    Private _PermanentAddress As String = String.Empty
    Private _PermanentCity As String = String.Empty
    Private _PermanentState As String = String.Empty
    Private _PermanentZip As String = String.Empty
    Private _Phone As String = String.Empty
    Private _Email As String = String.Empty
    Private _isCurrentlyRenting As Boolean = False
    Private _EmergencyContactName As String = String.Empty
    Private _EmergencyContactPhone As String = String.Empty

    '-------------------------------------------------------------
    ' Constructors
    '-------------------------------------------------------------
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal firstName As String, ByVal MI As String, ByVal lastName As String, ByVal permanentAddress As String, ByVal permanentCity As String, _
                   ByVal permanentState As String, ByVal permanentZip As String, ByVal phone As String, ByVal email As String, ByVal isCurrentlyRenting As Boolean, _
                   ByVal emergencyContactName As String, ByVal emergencyContactPhone As String)
        Me._ID = ID
        Me._FirstName = firstName
        Me._MI = MI
        Me._LastName = lastName
        Me._PermanentAddress = permanentAddress
        Me._PermanentCity = permanentCity
        Me._PermanentState = permanentState
        Me._PermanentZip = permanentZip
        Me._Phone = phone
        Me._Email = email
        Me._isCurrentlyRenting = isCurrentlyRenting
        Me._EmergencyContactName = emergencyContactName
        Me._EmergencyContactPhone = emergencyContactPhone
    End Sub
    '-------------------------------------------------------------
    ' Properties
    '-------------------------------------------------------------
    Public ReadOnly Property ID() As Integer
        Get
            Return Me._ID
        End Get
    End Property
    Public Property FirstName() As String
        Get
            Return Me._FirstName
        End Get
        Set(ByVal value As String)
            Me._FirstName = value
        End Set
    End Property
    Public Property MI() As String
        Get
            Return Me._MI
        End Get
        Set(ByVal value As String)
            Me._MI = value
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
    Public Property PermanentAddress() As String
        Get
            Return Me._PermanentAddress
        End Get
        Set(ByVal value As String)
            Me._PermanentAddress = value
        End Set
    End Property
    Public Property PermanentCity() As String
        Get
            Return Me._PermanentCity
        End Get
        Set(ByVal value As String)
            Me._PermanentCity = value
        End Set
    End Property
    Public Property PermanentState() As String
        Get
            Return Me._PermanentState
        End Get
        Set(ByVal value As String)
            Me._PermanentState = value
        End Set
    End Property
    Public Property PermanentZip() As String
        Get
            Return Me._PermanentZip
        End Get
        Set(ByVal value As String)
            Me._PermanentZip = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return Me._Phone
        End Get
        Set(ByVal value As String)
            Me._Phone = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return Me._Email
        End Get
        Set(ByVal value As String)
            Me._Email = value
        End Set
    End Property
    Public Property isCurrentlyRenting() As Boolean
        Get
            Return Me._isCurrentlyRenting
        End Get
        Set(ByVal value As Boolean)
            Me._isCurrentlyRenting = value
        End Set
    End Property
    Public Property EmergencyContactName() As String
        Get
            Return Me._EmergencyContactName
        End Get
        Set(ByVal value As String)
            Me._EmergencyContactName = value
        End Set
    End Property
    Public Property EmergencyContactPhone() As String
        Get
            Return Me._EmergencyContactPhone
        End Get
        Set(ByVal value As String)
            Me._EmergencyContactPhone = value
        End Set
    End Property
    '-------------------------------------------------------------
    ' Functions  -- Overrides Equals & ToString
    '-------------------------------------------------------------
    Public Overrides Function ToString() As String
        Dim returnString As String = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}, {1} {2}.", Me._LastName, Me._FirstName, Me.MI)
        Return returnString
    End Function
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim returnValue As Boolean
        If obj IsNot Nothing Then
            If TypeOf obj Is Rental.Data.Renter Then
                Dim tempRenter As Rental.Data.Renter
                tempRenter = DirectCast(obj, Rental.Data.Renter)
                returnValue = tempRenter.ID = Me._ID
            End If
        End If
        Return returnValue
    End Function

    'Public Overrides Function GetHashCode() As Integer
    '    Return MyBase.GetHashCode()
    'End Function
End Class
