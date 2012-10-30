Public Class FormAddRenter
    '---------------------------------------------------
    ' Class variables                         
    '---------------------------------------------------
    Dim _Renter As Rental.Data.Renter
    Dim _sender As System.Windows.Forms.Form

    '---------------------------------------------------
    ' Constructor                         
    '---------------------------------------------------
    Public Sub New(ByVal sender As System.Windows.Forms.Form, ByVal renterValue As Rental.Data.Renter)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me._Renter = renterValue
        Me._sender = sender

        If Me._Renter IsNot Nothing Then
            TextBoxID.Text = Me._Renter.ID.ToString
            TextBoxFirstName.Text = Me._Renter.FirstName
            TextBoxMI.Text = Me._Renter.MI
            TextBoxLastName.Text = Me._Renter.LastName
            TextBoxPermAddress.Text = Me._Renter.PermanentAddress
            TextBoxPermCity.Text = Me._Renter.PermanentCity
            TextBoxPermState.Text = Me._Renter.PermanentState.ToUpper
            TextBoxPermZip.Text = Me._Renter.PermanentZip
            TextBoxPhone.Text = Me._Renter.Phone
            TextBoxEmail.Text = Me._Renter.Email
            CheckBoxCurrentlyRenting.Checked = Me._Renter.isCurrentlyRenting
            TextBoxEmergencyName.Text = Me._Renter.EmergencyContactName
            TextBoxEmergencyPhone.Text = Me._Renter.EmergencyContactPhone
        End If
    End Sub
    '---------------------------------------------------
    ' Save Button                         
    '--------------------------------------------------- 
    Private Sub ButtonSaveInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveInsert.Click
        If Me._Renter Is Nothing Then
            Me._Renter = New Rental.Data.Renter
        End If
        Me._Renter.FirstName = Microsoft.VisualBasic.StrConv(TextBoxFirstName.Text, VbStrConv.ProperCase)
        Me._Renter.MI = TextBoxMI.Text.ToUpper
        Me._Renter.LastName = Microsoft.VisualBasic.StrConv(TextBoxLastName.Text, VbStrConv.ProperCase)
        Me._Renter.PermanentAddress = Microsoft.VisualBasic.StrConv(TextBoxPermAddress.Text, VbStrConv.ProperCase)
        Me._Renter.PermanentCity = Microsoft.VisualBasic.StrConv(TextBoxPermCity.Text, VbStrConv.ProperCase)
        Me._Renter.PermanentState = TextBoxPermState.Text.ToUpper
        Me._Renter.PermanentZip = TextBoxPermZip.Text
        Me._Renter.Phone = TextBoxPhone.Text
        Me._Renter.Email = TextBoxEmail.Text
        Me._Renter.isCurrentlyRenting = CheckBoxCurrentlyRenting.Checked
        Me._Renter.EmergencyContactName = Microsoft.VisualBasic.StrConv(TextBoxEmergencyName.Text, VbStrConv.ProperCase)
        Me._Renter.EmergencyContactPhone = TextBoxEmergencyPhone.Text
        If Me._Renter.ID = -1 Then
            Rental.Data.RenterCollection.InsertIntoDatabase(Me._Renter)
            ClearTextBoxes()
            MessageBox.Show("New Renter has been added.")
            Rental.Form1.DataGridView1.DataSource = Nothing
            Rental.Form1.DataGridView1.DataSource = Rental.Data.RenterCollection.QueryDatabase(Nothing)
        Else
            Rental.Data.RenterCollection.UpdateQuery(Me._Renter)
        End If
        Me._sender.Controls.Item("DataGridView1").Refresh()
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
        TextBoxID.Clear()
        TextBoxFirstName.Clear()
        TextBoxMI.Clear()
        TextBoxLastName.Clear()
        TextBoxPermAddress.Clear()
        TextBoxPermCity.Clear()
        TextBoxPermState.Clear()
        TextBoxPermZip.Clear()
        TextBoxPhone.Clear()
        TextBoxEmail.Clear()
        CheckBoxCurrentlyRenting.CheckState = CheckState.Unchecked
        TextBoxEmergencyName.Clear()
        TextBoxEmergencyPhone.Clear()
        TextBoxFirstName.Focus()
    End Sub
    '---------------------------------------------------
    ' Delete Button                         
    '--------------------------------------------------- 
    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Try
            If Not Me._Renter Is Nothing Then
                Dim yesNo As DialogResult = MessageBox.Show("Are you sure you want to delete this Renter?" & ControlChars.CrLf & _
                                                            "This will be a permanent change.", "Delete Confirmation", _
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If yesNo = DialogResult.Yes Then
                    If TypeOf Me._Renter Is Rental.Data.Renter Then
                        Dim tempRenter As Rental.Data.Renter
                        tempRenter = DirectCast(Me._Renter, Rental.Data.Renter)
                        Rental.Data.RenterCollection.DeleteObject(tempRenter)
                        Rental.Form1.DataGridView1.DataSource = Nothing
                        Rental.Form1.DataGridView1.DataSource = Rental.Data.RenterCollection.QueryDatabase(Nothing)
                        ClearTextBoxes()
                    End If
                ElseIf yesNo = DialogResult.No Then
                    Me.Close()
                End If
            End If
        Catch ex As ConstraintException
            MessageBox.Show("This Renter cannot be deleted. Currently renting.")
        End Try
    End Sub
End Class