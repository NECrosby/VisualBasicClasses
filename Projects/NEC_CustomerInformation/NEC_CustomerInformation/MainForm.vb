' Naomi Crosby
' Chapter 12 assignment

Imports System.IO

Public Class MainForm
    ' Exit Button
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' Clear Button
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    ' Save Customer Button
    Private Sub btnSaveCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCustomer.Click
        ' Create an instance of the PrefCustomer Class
        Dim objPreferredCustomer As New PreferredCustomer

        ' Display Total Purchases
        txtDiscountLevel.Text = objPreferredCustomer.GetTotalPurchases.ToString
        ' Display Discount Level
        txtDiscountLevel.Text = objPreferredCustomer.GetDiscountLevel.ToString
        ' Display Discount Details
        lblPreferredStatusInfo.Text = objPreferredCustomer.ToString

        ' Get Data from the form
        GetData(objPreferredCustomer)

        ' Add PrefCustomer to the Collection
        AddPrefCustomer(objPreferredCustomer)
        ' Confirm PrefCustomer Saved
        MessageBox.Show("Customer saved")

        ' Clear the form for next PrefCustomer
        ClearForm()
    End Sub

    ' Find Customer Button
    Private Sub btnFindCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnFindCustomer.Click
        Try
            Dim myCustomer As PreferredCustomer
            myCustomer = GetCustomer()
            DisplayData(myCustomer)
        Catch ex As Exception
            MessageBox.Show("No customer with that number exists")
        End Try
    End Sub

    ' Remove Customer Button
    Private Sub btnRemoveCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveCustomer.Click
        Dim strCustomerToRemove As String
        strCustomerToRemove = InputBox("Enter Preferred Customer Number you would like to remove")
        Dim myCustomer As PreferredCustomer
        myCustomer = GetCustomer()
        If preferredCustCollection.Contains(strCustomerToRemove) Then
            DisplayData(myCustomer)
            preferredCustCollection.Remove(strCustomerToRemove)
        End If

        ' Confirm PrefCustomer Saved
        MessageBox.Show("Customer removed")
        ClearForm()

    End Sub

    ' Get Data assigns values from the form to the Customer Object
    Private Sub GetData(ByVal objPrefCustomer As PreferredCustomer)
        Try
            ' objPrefCustomer.CustomerNumber = objPrefCustomer.CustomerNumber ' <-- READ ONLY
            objPrefCustomer.LastName = txtLastName.Text
            objPrefCustomer.FirstName = txtFirstName.Text
            objPrefCustomer.Address = txtStreetAddress.Text
            objPrefCustomer.City = txtCity.Text
            objPrefCustomer.State = txtState.Text
            objPrefCustomer.Zip = txtZip.Text
            objPrefCustomer.Phone = txtPhone.Text
            objPrefCustomer.MailingList = chkMailingList.Checked
            objPrefCustomer.Comments = txtComments.Text
            objPrefCustomer.PurchaseAmount = Convert.ToDecimal(txtCurrentPurchase.Text)

        Catch ex As Exception
            MessageBox.Show("Enter numeric values as needed.")
        End Try
    End Sub

    ' Clear Form
    Private Sub ClearForm()
        txtCustomerNumber.Text = String.Empty
        txtLastName.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtStreetAddress.Text = String.Empty
        txtCity.Text = String.Empty
        txtState.Text = String.Empty
        txtZip.Text = String.Empty
        txtPhone.Text = String.Empty
        chkMailingList.Checked = True
        txtComments.Text = String.Empty
        txtCurrentPurchase.Text = String.Empty
        txtTotalPurchases.Text = String.Empty
        txtDiscountLevel.Text = String.Empty
        lblPreferredStatusInfo.Text = String.Empty

        txtFirstName.Focus()
    End Sub

    ' Display Data after search provided by the parameter
    Private Sub DisplayData(ByVal prefCustomer As PreferredCustomer)
        txtCustomerNumber.Text = prefCustomer.CustomerNumber.ToString
        txtLastName.Text = prefCustomer.LastName
        txtFirstName.Text = prefCustomer.FirstName
        txtStreetAddress.Text = prefCustomer.Address
        txtCity.Text = prefCustomer.City
        txtState.Text = prefCustomer.State
        txtZip.Text = prefCustomer.Zip
        txtPhone.Text = prefCustomer.Phone
        chkMailingList.Checked = prefCustomer.MailingList
        txtComments.Text = prefCustomer.Comments
        txtCurrentPurchase.Text = String.Empty
        txtTotalPurchases.Text = prefCustomer.GetTotalPurchases.ToString("c")
        txtDiscountLevel.Text = prefCustomer.GetDiscountLevel.ToString("p")
        lblPreferredStatusInfo.Text = prefCustomer.ToString
    End Sub

    ' Allow for Console Debugging
    Private Sub MainForm_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Debug.Listeners.Add(New ConsoleTraceListener())
    End Sub

    ' Get Customer Function
    Private Function GetCustomer() As PreferredCustomer
        Dim myCustomer As PreferredCustomer
        Dim myCustomerNumber As String
        myCustomerNumber = InputBox("Enter Preferred Customer Number")
        myCustomer = CType(preferredCustCollection.Item(myCustomerNumber), PreferredCustomer)
        Return myCustomer
    End Function
End Class
