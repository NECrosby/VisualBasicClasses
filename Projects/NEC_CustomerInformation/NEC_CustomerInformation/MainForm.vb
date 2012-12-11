' Naomi Crosby
' Chapter 12 assignment

Imports System.IO

Public Class MainForm

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnSaveCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCustomer.Click
        Dim objCustomer As New PreferredCustomer

        MessageBox.Show("Customer saved")
    End Sub

    Private Sub btnFindCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnFindCustomer.Click

    End Sub

    Private Sub btnRemoveCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveCustomer.Click

    End Sub

    Private Sub GetData(ByVal objPerson As Person)
        Try
            objPerson.LastName = txtLastName.Text
            objPerson.FirstName = txtFirstName.Text
            objPerson.Address = txtStreetAddress.Text
            objPerson.City = txtCity.Text
            objPerson.State = txtState.Text
            objPerson.Zip = txtZip.Text
            objPerson.Phone = txtPhone.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
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
End Class
