Public Class PreferredCustomer
    Inherits Customer

    Private Const int_LEVEL_10 As Integer = 2000
    Private Const int_LEVEL_7 As Integer = 1500
    Private Const int_LEVEL_6 As Integer = 1000
    Private Const int_LEVEL_5 As Integer = 500

    Private decPurchaseAmount As Decimal
    Protected decTotalPurchases As Decimal
    Private sngDiscountLevel As Single

    Public Sub New()
        Debug.WriteLine("New PreferredCustomer being created.")
        decPurchaseAmount = 0
        decTotalPurchases = 0
        sngDiscountLevel = 0
    End Sub

    ' Update Total Purchases for customer
    Public Sub UpdateTotalPurchases()
        ' This is will add the new purchase to the current total purchase
        ' then return the new value, holds a running total
        decTotalPurchases = decTotalPurchases + decPurchaseAmount
    End Sub

    Public Property PurchaseAmount() As Decimal
        Get
            Return decPurchaseAmount
        End Get
        Set(ByVal value As Decimal)
            decPurchaseAmount = value
            UpdateTotalPurchases()
        End Set
    End Property
    ' GetDiscountLevel property (READ ONLY)
    Public ReadOnly Property GetDiscountLevel() As Single
        Get
            Dim sngDiscountLevel As Single

            If decTotalPurchases >= int_LEVEL_10 Then
                sngDiscountLevel = 10
            ElseIf decTotalPurchases >= int_LEVEL_7 Then
                sngDiscountLevel = 7
            ElseIf decTotalPurchases >= int_LEVEL_6 Then
                sngDiscountLevel = 6
            ElseIf decTotalPurchases >= int_LEVEL_5 Then
                sngDiscountLevel = 5
            Else
                sngDiscountLevel = 0
            End If

            Return sngDiscountLevel
        End Get
    End Property
    ' GetTotalPurchases property (READ ONLY)
    Public ReadOnly Property GetTotalPurchases() As Decimal
        Get
            Return decTotalPurchases
        End Get
    End Property

    Protected Function GetAmountNeeded() As Decimal
        Dim decAmountNeeded As Decimal = 0

        If Me.GetTotalPurchases >= int_LEVEL_10 Then
            decAmountNeeded = 0
        Else
            If Me.GetDiscountLevel = 7 Then
                decAmountNeeded = Convert.ToDecimal(int_LEVEL_10) - Me.GetTotalPurchases
            ElseIf Me.GetDiscountLevel = 6 Then
                decAmountNeeded = Convert.ToDecimal(int_LEVEL_7) - Me.GetTotalPurchases
            ElseIf Me.GetDiscountLevel = 5 Then
                decAmountNeeded = Convert.ToDecimal(int_LEVEL_6) - Me.GetTotalPurchases
            Else
                decAmountNeeded = Convert.ToDecimal(int_LEVEL_5) - Me.GetTotalPurchases
            End If
        End If

        Return decAmountNeeded
    End Function
    ' This will be used in the Discount Details Text Area on the MainForm
    Public Overrides Function ToString() As String
        Dim strValue As String = String.Empty

        strValue = "Your current discount level is " & Me.sngDiscountLevel & "%. " & vbCrLf & _
            "Your total purchases are $" & Me.decTotalPurchases & ". " & vbCrLf & _
            "$" & Me.GetAmountNeeded & " to get to the next discount level. " & vbCrLf & _
            "Discount levels: " & vbCrLf & _
            " 5% is $500 - $999 in total purchases. " & vbCrLf & _
            " 6% is $1,000 - $1499 in total purchases. " & vbCrLf & _
            " 7% is $1,500 - $1999 in total purchases. " & vbCrLf & _
            "10% is $2,000+ in total purchases. "
        Return strValue
    End Function
End Class
