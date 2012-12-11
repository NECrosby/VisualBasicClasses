Public Class PreferredCustomer
    Inherits Customer

    Private decPurchaseAmount As Decimal
    Private decTotalPurchases As Decimal
    Private sngDiscountLevel As Single

    Public Sub New()

    End Sub

    Public Property PurchaseAmount() As Decimal
        Get
            Return decPurchaseAmount
        End Get
        Set(ByVal value As Decimal)
            decPurchaseAmount = value
        End Set
    End Property
    Public ReadOnly Property TotalPurchases() As Decimal
        Get
            Return decTotalPurchases
        End Get
    End Property
    Public Property DiscountLevel() As Single
        Get
            Return sngDiscountLevel
        End Get
        Set(ByVal value As Single)
            sngDiscountLevel = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Dim discountInfo As String
        discountInfo = "Discount level is " & sngDiscountLevel & ". "
        ' $ 500 -  $999 =  5% discount
        ' $1000 - $1499 =  6% discount
        ' $1500 - $1999 =  7% discount
        ' $2000 +       = 10% discount
        Return discountInfo
    End Function
End Class
