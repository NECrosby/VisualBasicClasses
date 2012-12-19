<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCustomerNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkMailingList = New System.Windows.Forms.CheckBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPreferredStatusInfo = New System.Windows.Forms.Label()
        Me.txtDiscountLevel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCurrentPurchase = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalPurchases = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveCustomer = New System.Windows.Forms.Button()
        Me.btnRemoveCustomer = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFindCustomer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtComments)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCustomerNumber)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chkMailingList)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStreetAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 384)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'txtComments
        '
        Me.txtComments.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtComments.Location = New System.Drawing.Point(35, 284)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(230, 83)
        Me.txtComments.TabIndex = 8
        Me.txtComments.Text = "Please enter comments here "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Comments: "
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCustomerNumber.Enabled = False
        Me.txtCustomerNumber.Location = New System.Drawing.Point(129, 33)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.ReadOnly = True
        Me.txtCustomerNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerNumber.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Customer Number"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkMailingList
        '
        Me.chkMailingList.AutoSize = True
        Me.chkMailingList.Location = New System.Drawing.Point(88, 241)
        Me.chkMailingList.Name = "chkMailingList"
        Me.chkMailingList.Size = New System.Drawing.Size(141, 17)
        Me.chkMailingList.TabIndex = 7
        Me.chkMailingList.Text = "Please add to mailing list"
        Me.chkMailingList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMailingList.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(129, 215)
        Me.txtPhone.MaxLength = 13
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(75, 20)
        Me.txtPhone.TabIndex = 6
        Me.txtPhone.Text = "(   )   -   "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Phone"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(129, 189)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(50, 20)
        Me.txtZip.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Zip"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtState
        '
        Me.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtState.Location = New System.Drawing.Point(129, 163)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(25, 20)
        Me.txtState.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "State"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(129, 137)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "City"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(129, 111)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtStreetAddress.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Street Address"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(129, 85)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Last Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(129, 59)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblPreferredStatusInfo)
        Me.GroupBox2.Controls.Add(Me.txtDiscountLevel)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCurrentPurchase)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTotalPurchases)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 279)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preferred Customers"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Discount Details: "
        '
        'lblPreferredStatusInfo
        '
        Me.lblPreferredStatusInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPreferredStatusInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPreferredStatusInfo.Location = New System.Drawing.Point(31, 138)
        Me.lblPreferredStatusInfo.MinimumSize = New System.Drawing.Size(225, 115)
        Me.lblPreferredStatusInfo.Name = "lblPreferredStatusInfo"
        Me.lblPreferredStatusInfo.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPreferredStatusInfo.Size = New System.Drawing.Size(230, 115)
        Me.lblPreferredStatusInfo.TabIndex = 36
        Me.lblPreferredStatusInfo.Text = "Current discount level discription." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount needed to get to next discount leve" & _
    "l."
        '
        'txtDiscountLevel
        '
        Me.txtDiscountLevel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDiscountLevel.Enabled = False
        Me.txtDiscountLevel.Location = New System.Drawing.Point(146, 86)
        Me.txtDiscountLevel.Name = "txtDiscountLevel"
        Me.txtDiscountLevel.ReadOnly = True
        Me.txtDiscountLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountLevel.TabIndex = 33
        Me.txtDiscountLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Discount Level"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCurrentPurchase
        '
        Me.txtCurrentPurchase.Location = New System.Drawing.Point(146, 34)
        Me.txtCurrentPurchase.Name = "txtCurrentPurchase"
        Me.txtCurrentPurchase.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentPurchase.TabIndex = 0
        Me.txtCurrentPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Purchase Amount"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalPurchases
        '
        Me.txtTotalPurchases.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotalPurchases.Enabled = False
        Me.txtTotalPurchases.Location = New System.Drawing.Point(146, 60)
        Me.txtTotalPurchases.Name = "txtTotalPurchases"
        Me.txtTotalPurchases.ReadOnly = True
        Me.txtTotalPurchases.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPurchases.TabIndex = 29
        Me.txtTotalPurchases.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Total Purchases"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Location = New System.Drawing.Point(333, 304)
        Me.btnSaveCustomer.Margin = New System.Windows.Forms.Padding(10)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(140, 39)
        Me.btnSaveCustomer.TabIndex = 0
        Me.btnSaveCustomer.Text = "&Save Customer"
        Me.btnSaveCustomer.UseVisualStyleBackColor = True
        '
        'btnRemoveCustomer
        '
        Me.btnRemoveCustomer.Location = New System.Drawing.Point(333, 358)
        Me.btnRemoveCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRemoveCustomer.Name = "btnRemoveCustomer"
        Me.btnRemoveCustomer.Size = New System.Drawing.Size(140, 39)
        Me.btnRemoveCustomer.TabIndex = 1
        Me.btnRemoveCustomer.Text = "&Remove Customer"
        Me.btnRemoveCustomer.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(488, 358)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(61, 39)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFindCustomer
        '
        Me.btnFindCustomer.Location = New System.Drawing.Point(488, 304)
        Me.btnFindCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFindCustomer.Name = "btnFindCustomer"
        Me.btnFindCustomer.Size = New System.Drawing.Size(133, 39)
        Me.btnFindCustomer.TabIndex = 2
        Me.btnFindCustomer.Text = "&Find Customer"
        Me.btnFindCustomer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(560, 358)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 39)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 416)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFindCustomer)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemoveCustomer)
        Me.Controls.Add(Me.btnSaveCustomer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "MainForm"
        Me.Text = "Customer Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkMailingList As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiscountLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPurchase As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPurchases As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblPreferredStatusInfo As System.Windows.Forms.Label
    Friend WithEvents btnSaveCustomer As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCustomer As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFindCustomer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
