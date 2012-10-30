Public Class RentalProperty
    '-------------------------------------------------------------
    ' Class Variables
    '-------------------------------------------------------------
    Private _ID As Integer = -1                         ' defaulting to -1 because the Db will never return this value, used to determine if the property is brand new 
    Private _UnitNumber As String = String.Empty
    Private _MaxTenantCapacity As Integer = 0
    Private _Address As String = String.Empty
    Private _City As String = String.Empty
    Private _State As String = String.Empty
    Private _Zip As String = String.Empty
    Private _LeaseAmount As Decimal = 0
    Private _isVacant As Boolean = False
    Private _DamageDepositAmount As Decimal = 0
    Private _hasParking As Boolean = True

    '-------------------------------------------------------------
    ' Constructors
    '-------------------------------------------------------------
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As Integer, ByVal unitNumber As String, ByVal maxTenantCapacity As Integer, ByVal address As String, _
                   ByVal city As String, ByVal state As String, ByVal zip As String, ByVal leaseAmount As Decimal, _
                   ByVal isVacant As Boolean, ByVal damageDepositAmount As Decimal, ByVal hasParking As Boolean)
        Me._ID = ID
        Me._UnitNumber = unitNumber
        Me._MaxTenantCapacity = maxTenantCapacity
        Me._Address = address
        Me._City = city
        Me._State = state
        Me._Zip = zip
        Me._LeaseAmount = leaseAmount
        Me._isVacant = isVacant
        Me._DamageDepositAmount = damageDepositAmount
        Me._hasParking = hasParking
    End Sub
    '-------------------------------------------------------------
    ' Properties
    '-------------------------------------------------------------
    Public ReadOnly Property ID() As Integer
        Get
            Return Me._ID
        End Get
    End Property
    Public Property UnitNumber() As String
        Get
            Return Me._UnitNumber
        End Get
        Set(ByVal value As String)
            Me._UnitNumber = value
        End Set
    End Property
    Public Property MaxTenantCapacity() As Integer
        Get
            Return Me._MaxTenantCapacity
        End Get
        Set(ByVal value As Integer)
            Me._MaxTenantCapacity = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return Me._Address
        End Get
        Set(ByVal value As String)
            Me._Address = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return Me._City
        End Get
        Set(ByVal value As String)
            Me._City = value
        End Set
    End Property
    Public Property State() As String
        Get
            Return Me._State
        End Get
        Set(ByVal value As String)
            Me._State = value
        End Set
    End Property
    Public Property Zip() As String
        Get
            Return Me._Zip
        End Get
        Set(ByVal value As String)
            Me._Zip = value
        End Set
    End Property
    Public Property LeaseAmount() As Decimal
        Get
            Return Me._LeaseAmount
        End Get
        Set(ByVal value As Decimal)
            Me._LeaseAmount = value
        End Set
    End Property
    Public Property isVacant() As Boolean
        Get
            Return Me._isVacant
        End Get
        Set(ByVal value As Boolean)
            Me._isVacant = value
        End Set
    End Property
    Public Property DamageDepositAmount() As Decimal
        Get
            Return Me._DamageDepositAmount
        End Get
        Set(ByVal value As Decimal)
            Me._DamageDepositAmount = value
        End Set
    End Property
    Public Property hasParking() As Boolean
        Get
            Return Me._hasParking
        End Get
        Set(ByVal value As Boolean)
            Me._hasParking = value
        End Set
    End Property
    '-------------------------------------------------------------
    ' Functions -- ToString & Equals
    '-------------------------------------------------------------
    Public Overrides Function ToString() As String
        Dim returnProperty As String = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} Unit {1}", Me._Address, Me._UnitNumber)
        Return returnProperty
    End Function
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        ' function used by the Combobox to compare select items with the actual object.
        ' Overriding the default equals function
        Dim returnValue As Boolean
        ' first test to make sure that there is an object selected
        If obj IsNot Nothing Then
            ' then make sure that the object is a rental property object
            If TypeOf obj Is Rental.Data.RentalProperty Then
                'create a temp variable for comparision 
                Dim tempRentalProperty As Rental.Data.RentalProperty
                ' casting the Obj to an rental property object in order to obtain a property to use for comparison
                tempRentalProperty = DirectCast(obj, Rental.Data.RentalProperty)
                ' comparing the temp object's ID to the selected object's ID
                ' if they are the same returnValue will be equal to true 
                ' if not then returnValue will be equal to false
                returnValue = tempRentalProperty.ID = Me._ID
            End If
        End If
        Return returnValue
    End Function

    'Public Overrides Function GetHashCode() As Integer
    '    Return MyBase.GetHashCode()

    'End Function
End Class

