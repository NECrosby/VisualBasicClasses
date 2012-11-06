Public Class MainForm
    Private Shared _subtotal As Double = 0.0
    Private Shared _tax As Double = 0.0
    Private Shared _shipping As Double = 0.0
    Private Shared _total As Double = 0.0

    Private Sub mnuFileReset_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileReset.Click
        resetForm()
        clearValuesInVariables()
    End Sub

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuProductsPrint_Click(sender As System.Object, e As System.EventArgs) Handles mnuProductsPrint.Click
        frmPrintBooks.ShowDialog()
        runningAmountsForLabels()
    End Sub

    Private Sub mnuProductsAudio_Click(sender As System.Object, e As System.EventArgs) Handles mnuProductsAudio.Click
        frmAudioBooks.ShowDialog()
        runningAmountsForLabels()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Shopping Cart System: Version 1.0", "About")
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        'lstSelectedBooks.SelectedItems.Remove(lstSelectedBooks.SelectedItem)
        ' strSelectedBooksNames   ' Need to remove element from the selected array 
        ' runningAmountsForLabels() ' Re-calculate the labels, etc.
        'lstSelectedBooks.Items.Clear()
        'For Each count As Integer In strSelectedBooksNames
        'lstSelectedBooks.Items.Add(strSelectedBooksNames(count))
        'Next
    End Sub
    
    Public Sub clearValuesInVariables()
        _subtotal = 0.0
        _tax = 0.0
        _shipping = 0.0
        _total = 0.0
    End Sub

    Public Sub runningAmountsForLabels()
        Dim intCount As Integer = 0
        If (lstSelectedBooks.Items.Count > 0) Then
            For intCount = 0 To (dblSelectedBooksPrices.Length - 1)
                _subtotal = _subtotal + getSubTotal()
                _tax = _dblTAX_RATE * _subtotal
                _shipping += _dblSHIPPING_COST
                _total = _tax + _subtotal + _shipping
            Next
        End If

        lblSubtotal.Text = _subtotal.ToString("c")
        lblTax.Text = _tax.ToString("c")
        lblShipping.Text = _shipping.ToString("c")
        lblTotal.Text = _total.ToString("c")
    End Sub

    ' ----- Procedures for LABELS on MAIN Form -----
    ' Get costs of items in list box (Subtotal)
    Public Function getSubTotal() As Double
        Dim subtotalValue As Double
        Dim intCount As Integer

        For intCount = 0 To (dblSelectedBooksPrices.Length - 1)
            subtotalValue += dblSelectedBooksPrices(intCount)
        Next
        Return subtotalValue
    End Function

    ' Calculate Tax on items (Tax label)
    Public Function getTax(ByRef subt As Double) As Double
        Dim taxValue As Double
        Dim subtotal As Double = subt
        taxValue = subtotal * _dblTAX_RATE
        Return taxValue
    End Function

    ' Get number of items in list - count of items (# * ShippingConst = Shipping)
    Public Function getShippingCosts() As Double
        Dim shippingCostValue As Double
        shippingCostValue = lstSelectedBooks.Items.Count * _dblSHIPPING_COST
        Return shippingCostValue
    End Function

    ' Total = Subtotal + Tax + Shipping
    Public Function getTotal(ByRef subt As Double, ByRef taxValue As Double, ByVal shipValue As Double) As Double
        Dim totalValue As Double
        Dim subtotal As Double = subt
        Dim tax As Double = taxValue
        Dim shipping As Double = shipValue
        totalValue = subtotal + tax + shipping
        Return totalValue
    End Function
End Class
