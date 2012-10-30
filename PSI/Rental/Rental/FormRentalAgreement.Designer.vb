<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRentalAgreement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBoxRenterName = New System.Windows.Forms.ComboBox
        Me.ComboBoxPropertyAddress = New System.Windows.Forms.ComboBox
        Me.TextBoxAgreementID = New System.Windows.Forms.TextBox
        Me.LabelRenterName = New System.Windows.Forms.Label
        Me.LabelPropertyAdress = New System.Windows.Forms.Label
        Me.LabelAgreementID = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBoxLeaseAmountValue = New System.Windows.Forms.TextBox
        Me.CheckBoxDamageDepositPaid = New System.Windows.Forms.CheckBox
        Me.LabelDamageDepsoitAmountValue = New System.Windows.Forms.Label
        Me.DateTimePickerLeaseEndDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerLeaseStartDate = New System.Windows.Forms.DateTimePicker
        Me.DateTimePickerAgreementDate = New System.Windows.Forms.DateTimePicker
        Me.LabelDamageDepositPaid = New System.Windows.Forms.Label
        Me.LabelDamageDepositAmount = New System.Windows.Forms.Label
        Me.LabelLeaseEndDate = New System.Windows.Forms.Label
        Me.LabelStartDate = New System.Windows.Forms.Label
        Me.LabelLeaseAmount = New System.Windows.Forms.Label
        Me.LabelAgreementDate = New System.Windows.Forms.Label
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonSaveInsert = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxRenterName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPropertyAddress)
        Me.GroupBox1.Controls.Add(Me.TextBoxAgreementID)
        Me.GroupBox1.Controls.Add(Me.LabelRenterName)
        Me.GroupBox1.Controls.Add(Me.LabelPropertyAdress)
        Me.GroupBox1.Controls.Add(Me.LabelAgreementID)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Name and Location"
        '
        'ComboBoxRenterName
        '
        Me.ComboBoxRenterName.FormattingEnabled = True
        Me.ComboBoxRenterName.Location = New System.Drawing.Point(119, 71)
        Me.ComboBoxRenterName.Name = "ComboBoxRenterName"
        Me.ComboBoxRenterName.Size = New System.Drawing.Size(230, 21)
        Me.ComboBoxRenterName.Sorted = True
        Me.ComboBoxRenterName.TabIndex = 3
        '
        'ComboBoxPropertyAddress
        '
        Me.ComboBoxPropertyAddress.FormattingEnabled = True
        Me.ComboBoxPropertyAddress.Location = New System.Drawing.Point(119, 44)
        Me.ComboBoxPropertyAddress.Name = "ComboBoxPropertyAddress"
        Me.ComboBoxPropertyAddress.Size = New System.Drawing.Size(230, 21)
        Me.ComboBoxPropertyAddress.Sorted = True
        Me.ComboBoxPropertyAddress.TabIndex = 1
        '
        'TextBoxAgreementID
        '
        Me.TextBoxAgreementID.Location = New System.Drawing.Point(119, 18)
        Me.TextBoxAgreementID.Name = "TextBoxAgreementID"
        Me.TextBoxAgreementID.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxAgreementID.TabIndex = 0
        Me.TextBoxAgreementID.Visible = False
        '
        'LabelRenterName
        '
        Me.LabelRenterName.AutoSize = True
        Me.LabelRenterName.Location = New System.Drawing.Point(43, 74)
        Me.LabelRenterName.Name = "LabelRenterName"
        Me.LabelRenterName.Size = New System.Drawing.Size(70, 13)
        Me.LabelRenterName.TabIndex = 2
        Me.LabelRenterName.Text = "Renter Name"
        '
        'LabelPropertyAdress
        '
        Me.LabelPropertyAdress.AutoSize = True
        Me.LabelPropertyAdress.Location = New System.Drawing.Point(26, 47)
        Me.LabelPropertyAdress.Name = "LabelPropertyAdress"
        Me.LabelPropertyAdress.Size = New System.Drawing.Size(87, 13)
        Me.LabelPropertyAdress.TabIndex = 1
        Me.LabelPropertyAdress.Text = "Property Address"
        '
        'LabelAgreementID
        '
        Me.LabelAgreementID.AutoSize = True
        Me.LabelAgreementID.Location = New System.Drawing.Point(41, 21)
        Me.LabelAgreementID.Name = "LabelAgreementID"
        Me.LabelAgreementID.Size = New System.Drawing.Size(72, 13)
        Me.LabelAgreementID.TabIndex = 0
        Me.LabelAgreementID.Text = "Agreement ID"
        Me.LabelAgreementID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxLeaseAmountValue)
        Me.GroupBox2.Controls.Add(Me.CheckBoxDamageDepositPaid)
        Me.GroupBox2.Controls.Add(Me.LabelDamageDepsoitAmountValue)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerLeaseEndDate)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerLeaseStartDate)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerAgreementDate)
        Me.GroupBox2.Controls.Add(Me.LabelDamageDepositPaid)
        Me.GroupBox2.Controls.Add(Me.LabelDamageDepositAmount)
        Me.GroupBox2.Controls.Add(Me.LabelLeaseEndDate)
        Me.GroupBox2.Controls.Add(Me.LabelStartDate)
        Me.GroupBox2.Controls.Add(Me.LabelLeaseAmount)
        Me.GroupBox2.Controls.Add(Me.LabelAgreementDate)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 190)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agreement Details"
        '
        'TextBoxLeaseAmountValue
        '
        Me.TextBoxLeaseAmountValue.Location = New System.Drawing.Point(149, 51)
        Me.TextBoxLeaseAmountValue.Name = "TextBoxLeaseAmountValue"
        Me.TextBoxLeaseAmountValue.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxLeaseAmountValue.TabIndex = 4
        '
        'CheckBoxDamageDepositPaid
        '
        Me.CheckBoxDamageDepositPaid.AutoSize = True
        Me.CheckBoxDamageDepositPaid.Location = New System.Drawing.Point(151, 164)
        Me.CheckBoxDamageDepositPaid.Name = "CheckBoxDamageDepositPaid"
        Me.CheckBoxDamageDepositPaid.Size = New System.Drawing.Size(44, 17)
        Me.CheckBoxDamageDepositPaid.TabIndex = 5
        Me.CheckBoxDamageDepositPaid.Text = "Yes"
        Me.CheckBoxDamageDepositPaid.UseVisualStyleBackColor = True
        '
        'LabelDamageDepsoitAmountValue
        '
        Me.LabelDamageDepsoitAmountValue.AutoSize = True
        Me.LabelDamageDepsoitAmountValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelDamageDepsoitAmountValue.Location = New System.Drawing.Point(149, 135)
        Me.LabelDamageDepsoitAmountValue.MinimumSize = New System.Drawing.Size(200, 0)
        Me.LabelDamageDepsoitAmountValue.Name = "LabelDamageDepsoitAmountValue"
        Me.LabelDamageDepsoitAmountValue.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelDamageDepsoitAmountValue.Size = New System.Drawing.Size(200, 21)
        Me.LabelDamageDepsoitAmountValue.TabIndex = 4
        Me.LabelDamageDepsoitAmountValue.Text = "          "
        Me.LabelDamageDepsoitAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePickerLeaseEndDate
        '
        Me.DateTimePickerLeaseEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerLeaseEndDate.Location = New System.Drawing.Point(149, 106)
        Me.DateTimePickerLeaseEndDate.Name = "DateTimePickerLeaseEndDate"
        Me.DateTimePickerLeaseEndDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerLeaseEndDate.TabIndex = 3
        '
        'DateTimePickerLeaseStartDate
        '
        Me.DateTimePickerLeaseStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerLeaseStartDate.Location = New System.Drawing.Point(149, 78)
        Me.DateTimePickerLeaseStartDate.Name = "DateTimePickerLeaseStartDate"
        Me.DateTimePickerLeaseStartDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerLeaseStartDate.TabIndex = 2
        '
        'DateTimePickerAgreementDate
        '
        Me.DateTimePickerAgreementDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerAgreementDate.Location = New System.Drawing.Point(149, 23)
        Me.DateTimePickerAgreementDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerAgreementDate.Name = "DateTimePickerAgreementDate"
        Me.DateTimePickerAgreementDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerAgreementDate.TabIndex = 1
        '
        'LabelDamageDepositPaid
        '
        Me.LabelDamageDepositPaid.AutoSize = True
        Me.LabelDamageDepositPaid.Location = New System.Drawing.Point(33, 166)
        Me.LabelDamageDepositPaid.Name = "LabelDamageDepositPaid"
        Me.LabelDamageDepositPaid.Size = New System.Drawing.Size(110, 13)
        Me.LabelDamageDepositPaid.TabIndex = 5
        Me.LabelDamageDepositPaid.Text = "Damage Deposit Paid"
        '
        'LabelDamageDepositAmount
        '
        Me.LabelDamageDepositAmount.AutoSize = True
        Me.LabelDamageDepositAmount.Location = New System.Drawing.Point(18, 138)
        Me.LabelDamageDepositAmount.Name = "LabelDamageDepositAmount"
        Me.LabelDamageDepositAmount.Size = New System.Drawing.Size(125, 13)
        Me.LabelDamageDepositAmount.TabIndex = 4
        Me.LabelDamageDepositAmount.Text = "Damage Deposit Amount"
        '
        'LabelLeaseEndDate
        '
        Me.LabelLeaseEndDate.AutoSize = True
        Me.LabelLeaseEndDate.Location = New System.Drawing.Point(59, 110)
        Me.LabelLeaseEndDate.Name = "LabelLeaseEndDate"
        Me.LabelLeaseEndDate.Size = New System.Drawing.Size(84, 13)
        Me.LabelLeaseEndDate.TabIndex = 3
        Me.LabelLeaseEndDate.Text = "Lease End Date"
        '
        'LabelStartDate
        '
        Me.LabelStartDate.AutoSize = True
        Me.LabelStartDate.Location = New System.Drawing.Point(56, 82)
        Me.LabelStartDate.Name = "LabelStartDate"
        Me.LabelStartDate.Size = New System.Drawing.Size(87, 13)
        Me.LabelStartDate.TabIndex = 2
        Me.LabelStartDate.Text = "Lease Start Date"
        '
        'LabelLeaseAmount
        '
        Me.LabelLeaseAmount.AutoSize = True
        Me.LabelLeaseAmount.Location = New System.Drawing.Point(28, 54)
        Me.LabelLeaseAmount.Name = "LabelLeaseAmount"
        Me.LabelLeaseAmount.Size = New System.Drawing.Size(115, 13)
        Me.LabelLeaseAmount.TabIndex = 1
        Me.LabelLeaseAmount.Text = "Monthly Lease Amount"
        '
        'LabelAgreementDate
        '
        Me.LabelAgreementDate.AutoSize = True
        Me.LabelAgreementDate.Location = New System.Drawing.Point(59, 27)
        Me.LabelAgreementDate.Name = "LabelAgreementDate"
        Me.LabelAgreementDate.Size = New System.Drawing.Size(84, 13)
        Me.LabelAgreementDate.TabIndex = 0
        Me.LabelAgreementDate.Text = "Agreement Date"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(195, 345)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 35)
        Me.ButtonClear.TabIndex = 27
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonSaveInsert
        '
        Me.ButtonSaveInsert.Location = New System.Drawing.Point(287, 345)
        Me.ButtonSaveInsert.Name = "ButtonSaveInsert"
        Me.ButtonSaveInsert.Size = New System.Drawing.Size(75, 35)
        Me.ButtonSaveInsert.TabIndex = 0
        Me.ButtonSaveInsert.Text = "Save"
        Me.ButtonSaveInsert.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(104, 345)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 35)
        Me.ButtonDelete.TabIndex = 29
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'FormRentalAgreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 396)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSaveInsert)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormRentalAgreement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental Agreement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxPropertyAddress As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxAgreementID As System.Windows.Forms.TextBox
    Friend WithEvents LabelRenterName As System.Windows.Forms.Label
    Friend WithEvents LabelPropertyAdress As System.Windows.Forms.Label
    Friend WithEvents LabelAgreementID As System.Windows.Forms.Label
    Friend WithEvents ComboBoxRenterName As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelLeaseEndDate As System.Windows.Forms.Label
    Friend WithEvents LabelStartDate As System.Windows.Forms.Label
    Friend WithEvents LabelLeaseAmount As System.Windows.Forms.Label
    Friend WithEvents LabelAgreementDate As System.Windows.Forms.Label
    Friend WithEvents LabelDamageDepositPaid As System.Windows.Forms.Label
    Friend WithEvents LabelDamageDepositAmount As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerLeaseEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerLeaseStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerAgreementDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelDamageDepsoitAmountValue As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDamageDepositPaid As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveInsert As System.Windows.Forms.Button
    Friend WithEvents TextBoxLeaseAmountValue As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
End Class
