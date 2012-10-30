Public Class FormRentalAgreement
    '---------------------------------------------------
    ' Class variables                         
    '---------------------------------------------------
    Dim _RentalAgreement As Rental.Data.RentalAgreement
    Dim _Sender As System.Windows.Forms.Form
    Dim _RentalProperties As Rental.Data.RentalPropertyCollection
    Dim _Renters As Rental.Data.RenterCollection

    '---------------------------------------------------
    ' Constructor                         
    '---------------------------------------------------
    Public Sub New(ByVal sender As System.Windows.Forms.Form, ByVal agreementValue As Rental.Data.RentalAgreement)
        InitializeComponent()
        Me._RentalAgreement = agreementValue
        Me._Sender = sender
        Me._RentalProperties = New Rental.Data.RentalPropertyCollection(True)
        Me._Renters = New Rental.Data.RenterCollection(True)

        Me.ComboBoxPropertyAddress.DataSource = Me._RentalProperties
        Me.ComboBoxRenterName.DataSource = Me._Renters

        If Me._RentalAgreement IsNot Nothing Then
            TextBoxAgreementID.Text = Me._RentalAgreement.AgreementID.ToString
            ComboBoxPropertyAddress.SelectedItem = Me._RentalAgreement.RentalProperty
            ComboBoxRenterName.SelectedItem = Me._RentalAgreement.Renter
            DateTimePickerAgreementDate.Value = Me._RentalAgreement.AgreementDate
            TextBoxLeaseAmountValue.Text = Me._RentalAgreement.Amount.ToString
            DateTimePickerLeaseStartDate.Value = Me._RentalAgreement.StartDate
            DateTimePickerLeaseEndDate.Value = Me._RentalAgreement.EndDate
            LabelDamageDepsoitAmountValue.Text = Me._RentalAgreement.RentalProperty.DamageDepositAmount.ToString
            CheckBoxDamageDepositPaid.Checked = Me._RentalAgreement.hasPaidDamageDeposit
        Else
            Me.ComboBoxPropertyAddress.SelectedItem = Nothing
            Me.ComboBoxRenterName.SelectedItem = Nothing
            Me.LabelDamageDepsoitAmountValue.Text = String.Empty
            Me.TextBoxLeaseAmountValue.Text = String.Empty
        End If
        ' MessageBox.Show(ComboBoxPropertyAddress.SelectedItem.ToString) -- used for testing/debugging.
    End Sub
    '---------------------------------------------------
    ' Save Button                          
    '---------------------------------------------------
    Private Sub ButtonSaveInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveInsert.Click
        ' myRenter and myProperty are OBJECTS which bring all of their properties with them
        Dim myRenter As Rental.Data.Renter
        Dim myProperty As Rental.Data.RentalProperty

        ' If there is a renter name continue
        If Me.ComboBoxRenterName.SelectedItem IsNot Nothing Then
            ' make sure the name of Renter object
            If TypeOf Me.ComboBoxRenterName.SelectedItem Is Rental.Data.Renter Then
                ' if there is a property selected continue
                If Me.ComboBoxPropertyAddress.SelectedItem IsNot Nothing Then
                    ' make sure the property of Rental Property object
                    If TypeOf Me.ComboBoxPropertyAddress.SelectedItem Is Rental.Data.RentalProperty Then
                        ' assigning the selected text string name from the combo box to the object variable
                        myRenter = DirectCast(Me.ComboBoxRenterName.SelectedItem, Rental.Data.Renter)
                        ' assigning the selected text string property from the combo box to the object variable
                        myProperty = DirectCast(Me.ComboBoxPropertyAddress.SelectedItem, Rental.Data.RentalProperty)
                        ' call the save agreement sub routine and pass the renter and property object to the routine
                        SaveAgreement(myRenter, myProperty) '<------------------------------------------------------------- Calling Save Subroutine
                        ' disable the save button so that the agreement number will increment after the form is closed
                        Rental.Form1.DataGridView1.DataSource = Nothing
                        Rental.Form1.DataGridView1.DataSource = Rental.Data.RentalAgreementCollection.QueryDatabase(Nothing)
                    End If
                Else
                    MessageBox.Show("Please select a Property.")
                End If
            End If
        Else
            MessageBox.Show("Please select a Renter.")
        End If
    End Sub
    '---------------------------------------------------
    ' Save Sub Routine                          
    '---------------------------------------------------
    Private Sub SaveAgreement(ByVal renterValue As Rental.Data.Renter, ByVal propertyValue As Rental.Data.RentalProperty)
        ' renterValue and propertyValue are passed as parameters to this Sub routine
        If Me._RentalAgreement Is Nothing Then  ' if the rental property does not exist yet create a new rental property
            Me._RentalAgreement = New Rental.Data.RentalAgreement
        End If

        ' creating a new agreemnt use the input from the textboxes & checkboxes on the add form
        Me._RentalAgreement.Renter = renterValue
        Me._RentalAgreement.RentalProperty = propertyValue
        Me._RentalAgreement.AgreementDate = DateTimePickerAgreementDate.Value
        ' Gets the LeaseAmount value and inputs as a "suggestion" but can be changed by inputting a different amount

        ' This value should be the same as the RentalProperty.LeaseAmount  but if the lease amount was negoitated it may be lower.
        Me._RentalAgreement.Amount = System.Convert.ToDecimal(TextBoxLeaseAmountValue.Text)
        Me._RentalAgreement.StartDate = DateTimePickerLeaseStartDate.Value
        Me._RentalAgreement.EndDate = DateTimePickerLeaseEndDate.Value
        Me._RentalAgreement.hasPaidDamageDeposit = CheckBoxDamageDepositPaid.Checked

        ' if ID is -1 means that the default is used and it is a new object and needs to be inserted to the DB
        If Me._RentalAgreement.AgreementID = -1 Then
            ' calling the insert into DB function passing the newly created object.
            Rental.Data.RentalAgreementCollection.InsertIntoDatabase(Me._RentalAgreement)
            MessageBox.Show("The new agreement has been saved.")
        Else
            ' if the default ID is not used it means that the DB has supplied an object and the info needs to be updated
            Rental.Data.RentalAgreementCollection.UpdateQuery(Me._RentalAgreement)
            MessageBox.Show("The agreement change has been saved.")
            Me.Close()
        End If
        Me._sender.Controls.Item("DataGridView1").Refresh()
    End Sub
    '---------------------------------------------------
    ' Property Address ComboBox                         
    '---------------------------------------------------
    Private Sub ComboBoxPropertyAddress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPropertyAddress.SelectedIndexChanged
        '-----------------------------------------------------------------------------------------------------
        '       This is long version the non-commented version is the short version both are the same thing
        '       ----------------------------------------------------------------------------------------------
        ' Dim obj As Object
        ' obj = ComboBoxPropertyAddress.SelectedItem
        ' If obj IsNot Nothing Then
        '     If TypeOf obj Is Rental.Data.RentalProperty Then
        '         Dim tempProperty As Rental.Data.RentalProperty
        '         tempProperty = DirectCast(obj, Rental.Data.RentalProperty)
        '         Me.LabelDamageDepsoitAmountValue.Text = tempProperty.DamageDepositAmount.ToString
        '         Me.TextBoxLeaseAmountValue.Text = tempProperty.LeaseAmount.ToString
        '     End If
        ' End If
        '-----------------------------------------------------------------------------------------------------

        If Not ComboBoxPropertyAddress.SelectedItem Is Nothing Then
            If TypeOf ComboBoxPropertyAddress.SelectedItem Is Rental.Data.RentalProperty Then
                Dim tempProperty As Rental.Data.RentalProperty
                tempProperty = DirectCast(ComboBoxPropertyAddress.SelectedItem, Rental.Data.RentalProperty)
                Me.LabelDamageDepsoitAmountValue.Text = tempProperty.DamageDepositAmount.ToString
                Me.TextBoxLeaseAmountValue.Text = tempProperty.LeaseAmount.ToString
            End If
        End If
    End Sub
    '---------------------------------------------------
    ' Delete Button                          
    '---------------------------------------------------
    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim myAgreements As Rental.Data.RentalAgreementCollection

        If Not Me._RentalAgreement Is Nothing Then
            Dim yesNo As DialogResult = MessageBox.Show("Are you sure you want to delete this agreement?" & ControlChars.CrLf & _
                                                        "This will be a permanent change.", "Delete confirmation", _
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yesNo = DialogResult.Yes Then
                If TypeOf Me._RentalAgreement Is Rental.Data.RentalAgreement Then
                    Dim tempAgreement As Rental.Data.RentalAgreement
                    tempAgreement = DirectCast(Me._RentalAgreement, Rental.Data.RentalAgreement)
                    Rental.Data.RentalAgreementCollection.DeleteObject(tempAgreement)

                    myAgreements = Rental.Data.RentalAgreementCollection.QueryDatabase(Nothing)
                    Rental.Form1.DataGridView1.DataSource = Nothing
                    Rental.Form1.DataGridView1.DataSource = myAgreements
                    ClearResetValues()
                End If
            ElseIf yesNo = DialogResult.No Then
                Me.Close()
            End If
        End If
    End Sub
    '---------------------------------------------------
    ' Clear Button                          
    '---------------------------------------------------
    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        ClearResetValues()
    End Sub
    '---------------------------------------------------
    ' Clear Sub Routine                          
    '---------------------------------------------------
    Public Sub ClearResetValues()
        TextBoxAgreementID.Clear()
        ComboBoxPropertyAddress.SelectedItem = Nothing
        ComboBoxRenterName.SelectedItem = Nothing
        DateTimePickerAgreementDate.Value = Today
        TextBoxLeaseAmountValue.Clear()
        DateTimePickerLeaseStartDate.Value = Today
        DateTimePickerLeaseEndDate.Value = Today
        LabelDamageDepsoitAmountValue.Text = String.Empty
        CheckBoxDamageDepositPaid.CheckState = CheckState.Unchecked
    End Sub
End Class