Module ShoppingCartModule
    Public frmMain As New MainForm
    Public frmAudioBooks As New AudioBookForm
    Public frmPrintBooks As New PrintBookForm

    ' ----- Global Constants -----
    ' PRINT BOOKS
    Public Const _dblDID_IT_YOUR_WAY_PRINT As Double = 11.95
    Public Const _dblHISTORY_OF_SCOTLAND_PRINT As Double = 14.5
    Public Const _dblLEARN_CALCULUS_PRINT As Double = 29.95
    Public Const _dblFEEL_THE_STRESS_PRINT As Double = 18.5
    ' AUDIO BOOKS
    Public Const _dblLEARN_CALCULUS_AUDIO As Double = 29.95
    Public Const _dblHISTORY_OF_SCOTLAND_AUDIO As Double = 14.5
    Public Const _dblSCIENCE_BODY_LANGUAGE_AUDIO As Double = 12.95
    Public Const _dblRELAXATION_TECHNIQUES_AUDIO As Double = 11.5
    ' Tax Rate
    Public Const _dblTAX_RATE As Double = 0.06
    ' Shipping cost / book
    Public Const _dblSHIPPING_COST As Double = 2.0
    ' Will hold the selected item from the Sub Forms
    Public _selectedItem As String = String.Empty

    ' Parallel Arrays to Hold Book names & Prices
    ' Array for all book names
    Public intMax_Subscript As Integer = 0
    Public strBookNames() As String = {"I Did It Your Way (Print)",
                                    "The History of Scotland (Print)",
                                    "Learn Calculus in One Day (Print)",
                                    "Feel the Stress (Print)",
                                    "Learn Calculus in One Day (Audio)",
                                    "Relaxation Techniques (Audio)",
                                    "The History of Scotland (Audio)",
                                    "The Science of Body Language (Audio)"}
    ' Array for all book prices
    Public dblBookPrices() As Double = {_dblDID_IT_YOUR_WAY_PRINT,
                                     _dblHISTORY_OF_SCOTLAND_PRINT,
                                     _dblLEARN_CALCULUS_PRINT,
                                     _dblFEEL_THE_STRESS_PRINT,
                                     _dblLEARN_CALCULUS_AUDIO,
                                     _dblRELAXATION_TECHNIQUES_AUDIO,
                                     _dblHISTORY_OF_SCOTLAND_AUDIO,
                                     _dblSCIENCE_BODY_LANGUAGE_AUDIO}
    ' Array for selected book & prices
    Public strSelectedBooksNames(intMax_Subscript) As String
    Public dblSelectedBooksPrices(intMax_Subscript) As Double

    ' ----- Procedures -----
    Public Sub loadSelectedBook(ByVal _selectedItem As String)
        Dim subscript As Integer = strSelectedBooksNames.Length - 1 ' This tells me how many elements are in the array
        Dim selection As String = _selectedItem

        ReDim Preserve strSelectedBooksNames(subscript)     ' Resizing the array if needed
        ReDim Preserve dblSelectedBooksPrices(subscript)    ' Resizing the array if needed

        If selection = strBookNames(0) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(0)
            strSelectedBooksNames(subscript) = strBookNames(0)
        ElseIf selection = strBookNames(1) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(1)
            strSelectedBooksNames(subscript) = strBookNames(1)
        ElseIf selection = strBookNames(2) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(2)
            strSelectedBooksNames(subscript) = strBookNames(2)
        ElseIf selection = strBookNames(3) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(3)
            strSelectedBooksNames(subscript) = strBookNames(3)
        ElseIf selection = strBookNames(4) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(4)
            strSelectedBooksNames(subscript) = strBookNames(4)
        ElseIf selection = strBookNames(5) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(5)
            strSelectedBooksNames(subscript) = strBookNames(5)
        ElseIf selection = strBookNames(6) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(6)
            strSelectedBooksNames(subscript) = strBookNames(6)
        ElseIf selection = strBookNames(7) Then
            dblSelectedBooksPrices(subscript) = dblBookPrices(7)
            strSelectedBooksNames(subscript) = strBookNames(7)
        End If

        If Not (selection = Nothing) Then
            MainForm.lstSelectedBooks.Items.Add(selection)      ' Adding to the list box on main form
            MessageBox.Show(strSelectedBooksNames(subscript).ToString & ": " & dblSelectedBooksPrices(subscript).ToString("c"))
        End If

    End Sub
    ' Reset Form Procedure
    Public Sub resetForm()
        MainForm.lstSelectedBooks.Items.Clear()
        MainForm.lblSubtotal.Text = String.Empty
        MainForm.lblTax.Text = String.Empty
        MainForm.lblShipping.Text = String.Empty
        MainForm.lblTotal.Text = String.Empty
    End Sub
    ' Setting the text into the labels on the main form
    ' ByVal subValue As Double, taxValue As Double, shipValue As Double, totalValue As Double

    'Public Sub setLabelText(ByVal subValue As Double, taxValue As Double, shipValue As Double, totalValue As Double)
    '    Dim subtotal As Double = subValue
    '    Dim tax As Double = taxValue
    '    Dim shipping As Double = shipValue
    '    Dim total As Double = totalValue
    '    MainForm.lblSubtotal.Text = subtotal.ToString("c")
    '    MainForm.lblTax.Text = tax.ToString("c")
    '    MainForm.lblShipping.Text = shipping.ToString("c")
    '    MainForm.lblTotal.Text = total.ToString("c")
    'End Sub

    '' ----- Procedures for LABELS on MAIN Form -----
    '' Get costs of items in list box (Subtotal)
    'Public Function getSubTotal() As Double
    '    Dim subtotalValue As Double
    '    Dim intCount As Integer

    '    For intCount = 0 To (dblSelectedBooksPrices.Length - 1)
    '        subtotalValue += dblSelectedBooksPrices(intCount)
    '    Next
    '    Return subtotalValue
    'End Function

    '' Calculate Tax on items (Tax label)
    'Public Function getTax(ByVal subt As Double) As Double
    '    Dim taxValue As Double
    '    Dim subtotal As Double = subt
    '    taxValue = subtotal * _dblTAX_RATE
    '    Return taxValue
    'End Function

    '' Get number of items in list - count of items (# * ShippingConst = Shipping)
    'Public Function getShippingCosts() As Double
    '    Dim shippingCostValue As Double
    '    shippingCostValue = MainForm.lstSelectedBooks.Items.Count * _dblSHIPPING_COST
    '    Return shippingCostValue
    'End Function

    '' Total = Subtotal + Tax + Shipping
    'Public Function getTotal(ByVal subt As Double, ByVal taxValue As Double) As Double
    '    Dim totalValue As Double
    '    Dim subtotal As Double = subt
    '    Dim tax As Double = taxValue
    '    totalValue = subtotal + tax + dblShipping
    '    Return totalValue
    'End Function
End Module
