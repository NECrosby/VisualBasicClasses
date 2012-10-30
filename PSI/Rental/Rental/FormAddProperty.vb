Public Class FormAddProperty
    '---------------------------------------------------
    ' Class variables                         
    '---------------------------------------------------
    Dim _RentalProperty As Rental.Data.RentalProperty
    Dim _sender As System.Windows.Forms.Form

    '---------------------------------------------------
    ' Constructor                         
    '---------------------------------------------------
    Public Sub New(ByVal sender As System.Windows.Forms.Form, ByVal rentalPropertyValue As Rental.Data.RentalProperty)
        ' passing in 2 parameters now -- sender and rentalPropertyValue
        ' ByVal rentalProperties As Rental.Data.RentalPropertyCollection

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._RentalProperty = rentalPropertyValue    ' assigning the parameter passed in to the class variable 
        Me._sender = sender                         ' assigning the parameter passed in to the class variable

        ' filling the text boxes of the "Add Property" form if the Rental Property exists
        If Me._RentalProperty IsNot Nothing Then
            TextBoxID.Text = Me._RentalProperty.ID.ToString              ' must convert to a string if table property is not a string data type
            TextBoxUnitNumber.Text = Me._RentalProperty.UnitNumber
            TextBoxMaxCapacity.Text = Me._RentalProperty.MaxTenantCapacity.ToString
            TextBoxAddress.Text = Me._RentalProperty.Address
            TextBoxCity.Text = Me._RentalProperty.City
            TextBoxState.Text = Me._RentalProperty.State
            TextBoxZip.Text = Me._RentalProperty.Zip
            TextBoxLeaseAmount.Text = Me._RentalProperty.LeaseAmount.ToString
            CheckBoxIsVacant.Checked = Me._RentalProperty.isVacant       ' bringing in the true/false (yes/no) value from the DGV/DB
            TextBoxDamageDepositAmount.Text = Me._RentalProperty.DamageDepositAmount.ToString
            CheckBoxHasParking.Checked = Me._RentalProperty.hasParking   ' bringing in the true/false (yes/no) value from the DGV/DB
        End If
    End Sub
    '---------------------------------------------------
    ' Save Button                        
    '--------------------------------------------------- 
    Private Sub ButtonSaveInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveInsert.Click
        ' temp variable for TryParse methods
        Dim intMaxCapacity As Integer
        Dim decLeaseAmount As Decimal
        Dim decDamageDeposit As Decimal

        ' Validating to make sure that if we need numeric input that we are getting numeric
        If Integer.TryParse(TextBoxMaxCapacity.Text, intMaxCapacity) Then
            If Decimal.TryParse(TextBoxLeaseAmount.Text, decLeaseAmount) Then
                If Decimal.TryParse(TextBoxDamageDepositAmount.Text, decDamageDeposit) Then
                    '-----------------------------------------------------------------------------------------------------------------
                    ' if the rental property does not exist yet create a new rental property
                    If Me._RentalProperty Is Nothing Then
                        Me._RentalProperty = New Rental.Data.RentalProperty
                    End If
                    '-----------------------------------------------------------------------------------------------------------------
                    ' Now take VALUES FROM -- if creating a new property use the input from the textboxes & checkboxes on the add property form
                    Me._RentalProperty.UnitNumber = TextBoxUnitNumber.Text.ToUpper
                    Me._RentalProperty.MaxTenantCapacity = System.Convert.ToInt32(TextBoxMaxCapacity.Text)
                    Me._RentalProperty.Address = Microsoft.VisualBasic.StrConv(TextBoxAddress.Text, VbStrConv.ProperCase)
                    Me._RentalProperty.City = Microsoft.VisualBasic.StrConv(TextBoxCity.Text, VbStrConv.ProperCase)
                    Me._RentalProperty.State = TextBoxState.Text.ToUpper
                    Me._RentalProperty.Zip = TextBoxZip.Text
                    Me._RentalProperty.LeaseAmount = System.Convert.ToDecimal(TextBoxLeaseAmount.Text)
                    Me._RentalProperty.isVacant = CheckBoxIsVacant.Checked
                    Me._RentalProperty.DamageDepositAmount = System.Convert.ToDecimal(TextBoxDamageDepositAmount.Text)
                    Me._RentalProperty.hasParking = CheckBoxHasParking.Checked
                    '-----------------------------------------------------------------------------------------------------------------

                    '-----------------------------------------------------------------------------------------------------------------
                    ' if ID is -1 means that the default is used and it is a new rental property and needs to be inserted to the DB
                    If Me._RentalProperty.ID = -1 Then
                        ' calling the insert into DB function passing the newly created Rental property
                        Rental.Data.RentalPropertyCollection.InsertIntoDatabase(Me._RentalProperty)
                        ClearTextBoxes()
                        MessageBox.Show("New Property has been added.")

                        Rental.Form1.DataGridView1.DataSource = Nothing
                        Rental.Form1.DataGridView1.DataSource = Rental.Data.RentalPropertyCollection.QueryDatabase(Nothing)

                        '-----------------------------------------------------------------------------------------------------------------
                    Else
                        '-----------------------------------------------------------------------------------------------------------------
                        ' if the default ID is not used it means that the DB has supplied a Rental Property and the info needs to be updated
                        Rental.Data.RentalPropertyCollection.UpdateQuery(Me._RentalProperty)
                        Me._sender.Controls.Item("DataGridView1").Refresh()
                        '-----------------------------------------------------------------------------------------------------------------
                    End If
                Else
                    MessageBox.Show("Please enter an numeric amount into the Damage Deposit Amount box.")
                    TextBoxDamageDepositAmount.Clear()
                    TextBoxDamageDepositAmount.Focus()
                End If
            Else
                MessageBox.Show("Please enter an numeric amount into the Lease Amount box.")
                TextBoxLeaseAmount.Clear()
                TextBoxLeaseAmount.Focus()
            End If
        Else
            MessageBox.Show("Please enter an Integer into the Max Tenant Capacity text box.")
            TextBoxMaxCapacity.Clear()
            TextBoxMaxCapacity.Focus()
        End If

    End Sub
    '---------------------------------------------------
    ' Clear Button                          
    '---------------------------------------------------    
    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        ClearTextBoxes()
    End Sub
    '---------------------------------------------------
    ' Clear Sub Routine                         
    '--------------------------------------------------- 
    Public Sub ClearTextBoxes()
        ' Clear all text boxes and reset focus to the top box which is the Unit Number text box
        TextBoxID.Clear()
        TextBoxUnitNumber.Clear()
        TextBoxMaxCapacity.Clear()
        TextBoxAddress.Clear()
        TextBoxCity.Clear()
        TextBoxState.Clear()
        TextBoxZip.Clear()
        TextBoxLeaseAmount.Clear()
        CheckBoxIsVacant.CheckState = CheckState.Unchecked
        TextBoxDamageDepositAmount.Clear()
        CheckBoxHasParking.Checked = False
        TextBoxUnitNumber.Focus()
    End Sub
    '---------------------------------------------------
    ' Delete Button                          
    '--------------------------------------------------- 
    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            If Not Me._RentalProperty Is Nothing Then
                Dim yesNo As DialogResult = MessageBox.Show("Are you sure you want to delete this property?" & ControlChars.CrLf & _
                                                            "This will be a permanent change.", "Delete confirmation", _
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If yesNo = DialogResult.Yes Then
                    If TypeOf Me._RentalProperty Is Rental.Data.RentalProperty Then
                        Dim tempProperty As Rental.Data.RentalProperty
                        tempProperty = DirectCast(Me._RentalProperty, Rental.Data.RentalProperty)
                        Rental.Data.RentalPropertyCollection.DeleteObject(tempProperty)
                        Rental.Form1.DataGridView1.DataSource = Nothing
                        Rental.Form1.DataGridView1.DataSource = Rental.Data.RentalPropertyCollection.QueryDatabase(Nothing)
                        ClearTextBoxes()
                    End If
                ElseIf yesNo = DialogResult.No Then
                    Me.Close()
                End If
            End If
        Catch ex As ConstraintException 'OleDb.OleDbException
            MessageBox.Show("This Property cannot be deleted it is under agreement.")
        End Try

    End Sub
End Class