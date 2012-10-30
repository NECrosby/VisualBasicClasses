Public Class RentalAgreement
    '-------------------------------------------------------------
    ' Class Variables
    '-------------------------------------------------------------
    Private _AgreementID As Integer = -1
    Private _PropertyID As Integer = 0
    Private _RenterID As Integer = 0
    Private _AgreementDate As DateTime
    Private _Amount As Decimal
    Private _StartDate As DateTime
    Private _EndDate As DateTime
    Private _hasPaidDamageDeposit As Boolean
    Private _RentalProperty As Rental.Data.RentalProperty
    Private _Renter As Rental.Data.Renter

    '-------------------------------------------------------------
    ' Constructors
    '-------------------------------------------------------------
    Public Sub New()

    End Sub

    ' This is the consumer of the DLL 
    Public Sub New(ByVal agreementID As Integer, ByVal rentalPropertyValue As RentalProperty, ByVal renterValue As Renter, _
                   ByVal agreementDate As DateTime, ByVal amount As Decimal, ByVal startDate As DateTime, _
                   ByVal endDate As DateTime, ByVal hasPaidDamageDeposit As Boolean)
        Me._AgreementID = agreementID
        Me._PropertyID = rentalPropertyValue.ID
        Me._RentalProperty = rentalPropertyValue
        Me._RenterID = renterValue.ID
        Me._Renter = renterValue
        Me._AgreementDate = agreementDate
        Me._Amount = amount
        Me._StartDate = startDate
        Me._EndDate = endDate
        Me._hasPaidDamageDeposit = hasPaidDamageDeposit
    End Sub

    'This is the constructor used by the collection 
    Friend Sub New(ByVal agreementID As Integer, ByVal propertyID As Integer, ByVal renterID As Integer, _
                   ByVal agreementDate As DateTime, ByVal amount As Decimal, ByVal startDate As DateTime, _
                   ByVal endDate As DateTime, ByVal hasPaidDamageDeposit As Boolean)
        Me._AgreementID = agreementID
        Me._PropertyID = propertyID
        Me._RenterID = renterID
        Me._AgreementDate = agreementDate
        Me._Amount = amount
        Me._StartDate = startDate
        Me._EndDate = endDate
        Me._hasPaidDamageDeposit = hasPaidDamageDeposit
    End Sub
    '-------------------------------------------------------------
    ' Properties
    '-------------------------------------------------------------
    Public ReadOnly Property AgreementID() As Integer
        Get
            Return Me._AgreementID
        End Get
    End Property
    ' This is an Object
    Public Property RentalProperty() As RentalProperty
        Get
            If Me._RentalProperty Is Nothing Then
                Me._RentalProperty = Rental.Data.RentalPropertyCollection.GetPropertyByID(_PropertyID)
            End If
            Return Me._RentalProperty
        End Get
        Set(ByVal value As RentalProperty)
            Me._RentalProperty = value
            Me._PropertyID = value.ID
        End Set
    End Property
    ' This is an Object
    Public Property Renter() As Renter
        Get
            If Me._Renter Is Nothing Then
                Me._Renter = Rental.Data.RenterCollection.GetRenterByID(_RenterID)
            End If
            Return Me._Renter
        End Get
        Set(ByVal value As Renter)
            Me._Renter = value
            Me._RenterID = value.ID
        End Set
    End Property
    Friend ReadOnly Property PropertyID() As Integer
        Get
            Return Me._PropertyID
        End Get
    End Property
    Friend ReadOnly Property RenterID() As Integer
        Get
            Return Me._RenterID
        End Get
    End Property
    Public Property AgreementDate() As DateTime
        Get
            Return Me._AgreementDate
        End Get
        Set(ByVal value As DateTime)
            Me._AgreementDate = value
        End Set
    End Property
    Public Property Amount() As Decimal
        Get
            Return Me._Amount
        End Get
        Set(ByVal value As Decimal)
            Me._Amount = value
        End Set
    End Property
    Public Property StartDate() As DateTime
        Get
            Return Me._StartDate
        End Get
        Set(ByVal value As DateTime)
            Me._StartDate = value
        End Set
    End Property
    Public Property EndDate() As DateTime
        Get
            Return Me._EndDate
        End Get
        Set(ByVal value As DateTime)
            Me._EndDate = value
        End Set
    End Property
    Public Property hasPaidDamageDeposit() As Boolean
        Get
            Return Me._hasPaidDamageDeposit
        End Get
        Set(ByVal value As Boolean)
            Me._hasPaidDamageDeposit = value
        End Set
    End Property
    '-------------------------------------------------------------
    ' Functions  -- Overrides Equals
    '-------------------------------------------------------------
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim returnValue As Boolean
        If obj IsNot Nothing Then
            If TypeOf obj Is Rental.Data.RentalAgreement Then
                Dim tempAgreement As Rental.Data.RentalAgreement
                tempAgreement = DirectCast(obj, Rental.Data.RentalAgreement)
                returnValue = tempAgreement.AgreementID = Me._AgreementID
            End If
        End If
        Return returnValue
    End Function
    'Public Overrides Function GetHashCode() As Integer
    '    Return MyBase.GetHashCode()
    'End Function
End Class
