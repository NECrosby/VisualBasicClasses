<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddProperty
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
        Me.ButtonSaveInsert = New System.Windows.Forms.Button
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.GroupBoxPPropertyInformation = New System.Windows.Forms.GroupBox
        Me.CheckBoxIsVacant = New System.Windows.Forms.CheckBox
        Me.CheckBoxHasParking = New System.Windows.Forms.CheckBox
        Me.LabelParking = New System.Windows.Forms.Label
        Me.TextBoxDamageDepositAmount = New System.Windows.Forms.TextBox
        Me.LabelDamageDepositAmount = New System.Windows.Forms.Label
        Me.LabelisVacant = New System.Windows.Forms.Label
        Me.TextBoxLeaseAmount = New System.Windows.Forms.TextBox
        Me.LabelLeaseAmount = New System.Windows.Forms.Label
        Me.TextBoxZip = New System.Windows.Forms.TextBox
        Me.LabelZip = New System.Windows.Forms.Label
        Me.TextBoxState = New System.Windows.Forms.TextBox
        Me.LabelState = New System.Windows.Forms.Label
        Me.TextBoxCity = New System.Windows.Forms.TextBox
        Me.LabelCity = New System.Windows.Forms.Label
        Me.TextBoxAddress = New System.Windows.Forms.TextBox
        Me.LabelAddress = New System.Windows.Forms.Label
        Me.TextBoxMaxCapacity = New System.Windows.Forms.TextBox
        Me.LabelMaxCapacity = New System.Windows.Forms.Label
        Me.TextBoxUnitNumber = New System.Windows.Forms.TextBox
        Me.LabelUnitNumber = New System.Windows.Forms.Label
        Me.TextBoxID = New System.Windows.Forms.TextBox
        Me.LabelPropertyID = New System.Windows.Forms.Label
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.GroupBoxPPropertyInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonSaveInsert
        '
        Me.ButtonSaveInsert.Location = New System.Drawing.Point(246, 334)
        Me.ButtonSaveInsert.Name = "ButtonSaveInsert"
        Me.ButtonSaveInsert.Size = New System.Drawing.Size(75, 35)
        Me.ButtonSaveInsert.TabIndex = 1
        Me.ButtonSaveInsert.Text = "Save"
        Me.ButtonSaveInsert.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(154, 334)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 35)
        Me.ButtonClear.TabIndex = 25
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'GroupBoxPPropertyInformation
        '
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.CheckBoxIsVacant)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.CheckBoxHasParking)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelParking)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxDamageDepositAmount)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelDamageDepositAmount)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelisVacant)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxLeaseAmount)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelLeaseAmount)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxZip)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelZip)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxState)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelState)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxCity)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelCity)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxAddress)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelAddress)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxMaxCapacity)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelMaxCapacity)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxUnitNumber)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelUnitNumber)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.TextBoxID)
        Me.GroupBoxPPropertyInformation.Controls.Add(Me.LabelPropertyID)
        Me.GroupBoxPPropertyInformation.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxPPropertyInformation.Name = "GroupBoxPPropertyInformation"
        Me.GroupBoxPPropertyInformation.Size = New System.Drawing.Size(334, 308)
        Me.GroupBoxPPropertyInformation.TabIndex = 0
        Me.GroupBoxPPropertyInformation.TabStop = False
        Me.GroupBoxPPropertyInformation.Text = "Property Information"
        '
        'CheckBoxIsVacant
        '
        Me.CheckBoxIsVacant.AutoSize = True
        Me.CheckBoxIsVacant.Location = New System.Drawing.Point(144, 226)
        Me.CheckBoxIsVacant.Name = "CheckBoxIsVacant"
        Me.CheckBoxIsVacant.Size = New System.Drawing.Size(44, 17)
        Me.CheckBoxIsVacant.TabIndex = 8
        Me.CheckBoxIsVacant.Text = "Yes"
        Me.CheckBoxIsVacant.UseVisualStyleBackColor = True
        '
        'CheckBoxHasParking
        '
        Me.CheckBoxHasParking.AutoSize = True
        Me.CheckBoxHasParking.Location = New System.Drawing.Point(144, 279)
        Me.CheckBoxHasParking.Name = "CheckBoxHasParking"
        Me.CheckBoxHasParking.Size = New System.Drawing.Size(44, 17)
        Me.CheckBoxHasParking.TabIndex = 10
        Me.CheckBoxHasParking.Text = "Yes"
        Me.CheckBoxHasParking.UseVisualStyleBackColor = True
        '
        'LabelParking
        '
        Me.LabelParking.AutoSize = True
        Me.LabelParking.Location = New System.Drawing.Point(48, 279)
        Me.LabelParking.Name = "LabelParking"
        Me.LabelParking.Size = New System.Drawing.Size(89, 13)
        Me.LabelParking.TabIndex = 42
        Me.LabelParking.Text = "Parking Available"
        '
        'TextBoxDamageDepositAmount
        '
        Me.TextBoxDamageDepositAmount.Location = New System.Drawing.Point(142, 250)
        Me.TextBoxDamageDepositAmount.Name = "TextBoxDamageDepositAmount"
        Me.TextBoxDamageDepositAmount.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDamageDepositAmount.TabIndex = 9
        '
        'LabelDamageDepositAmount
        '
        Me.LabelDamageDepositAmount.AutoSize = True
        Me.LabelDamageDepositAmount.Location = New System.Drawing.Point(14, 253)
        Me.LabelDamageDepositAmount.Name = "LabelDamageDepositAmount"
        Me.LabelDamageDepositAmount.Size = New System.Drawing.Size(123, 13)
        Me.LabelDamageDepositAmount.TabIndex = 41
        Me.LabelDamageDepositAmount.Text = "Damage Depost Amount"
        '
        'LabelisVacant
        '
        Me.LabelisVacant.AutoSize = True
        Me.LabelisVacant.Location = New System.Drawing.Point(52, 226)
        Me.LabelisVacant.Name = "LabelisVacant"
        Me.LabelisVacant.Size = New System.Drawing.Size(85, 13)
        Me.LabelisVacant.TabIndex = 40
        Me.LabelisVacant.Text = "Currently Vacant"
        '
        'TextBoxLeaseAmount
        '
        Me.TextBoxLeaseAmount.Location = New System.Drawing.Point(142, 198)
        Me.TextBoxLeaseAmount.Name = "TextBoxLeaseAmount"
        Me.TextBoxLeaseAmount.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLeaseAmount.TabIndex = 7
        '
        'LabelLeaseAmount
        '
        Me.LabelLeaseAmount.AutoSize = True
        Me.LabelLeaseAmount.Location = New System.Drawing.Point(61, 201)
        Me.LabelLeaseAmount.Name = "LabelLeaseAmount"
        Me.LabelLeaseAmount.Size = New System.Drawing.Size(75, 13)
        Me.LabelLeaseAmount.TabIndex = 39
        Me.LabelLeaseAmount.Text = "Lease Amount"
        '
        'TextBoxZip
        '
        Me.TextBoxZip.Location = New System.Drawing.Point(142, 147)
        Me.TextBoxZip.Name = "TextBoxZip"
        Me.TextBoxZip.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxZip.TabIndex = 5
        '
        'LabelZip
        '
        Me.LabelZip.AutoSize = True
        Me.LabelZip.Location = New System.Drawing.Point(114, 150)
        Me.LabelZip.Name = "LabelZip"
        Me.LabelZip.Size = New System.Drawing.Size(22, 13)
        Me.LabelZip.TabIndex = 38
        Me.LabelZip.Text = "Zip"
        '
        'TextBoxState
        '
        Me.TextBoxState.Location = New System.Drawing.Point(142, 121)
        Me.TextBoxState.Name = "TextBoxState"
        Me.TextBoxState.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxState.TabIndex = 4
        '
        'LabelState
        '
        Me.LabelState.AutoSize = True
        Me.LabelState.Location = New System.Drawing.Point(105, 124)
        Me.LabelState.Name = "LabelState"
        Me.LabelState.Size = New System.Drawing.Size(32, 13)
        Me.LabelState.TabIndex = 37
        Me.LabelState.Text = "State"
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Location = New System.Drawing.Point(142, 95)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxCity.TabIndex = 3
        '
        'LabelCity
        '
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Location = New System.Drawing.Point(112, 98)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(24, 13)
        Me.LabelCity.TabIndex = 34
        Me.LabelCity.Text = "City"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(142, 42)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxAddress.TabIndex = 1
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(60, 45)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(76, 13)
        Me.LabelAddress.TabIndex = 31
        Me.LabelAddress.Text = "Street Address"
        '
        'TextBoxMaxCapacity
        '
        Me.TextBoxMaxCapacity.Location = New System.Drawing.Point(142, 172)
        Me.TextBoxMaxCapacity.Name = "TextBoxMaxCapacity"
        Me.TextBoxMaxCapacity.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxMaxCapacity.TabIndex = 6
        '
        'LabelMaxCapacity
        '
        Me.LabelMaxCapacity.AutoSize = True
        Me.LabelMaxCapacity.Location = New System.Drawing.Point(65, 175)
        Me.LabelMaxCapacity.Name = "LabelMaxCapacity"
        Me.LabelMaxCapacity.Size = New System.Drawing.Size(71, 13)
        Me.LabelMaxCapacity.TabIndex = 28
        Me.LabelMaxCapacity.Text = "Max Capacity"
        '
        'TextBoxUnitNumber
        '
        Me.TextBoxUnitNumber.Location = New System.Drawing.Point(142, 68)
        Me.TextBoxUnitNumber.Name = "TextBoxUnitNumber"
        Me.TextBoxUnitNumber.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxUnitNumber.TabIndex = 2
        '
        'LabelUnitNumber
        '
        Me.LabelUnitNumber.AutoSize = True
        Me.LabelUnitNumber.Location = New System.Drawing.Point(100, 71)
        Me.LabelUnitNumber.Name = "LabelUnitNumber"
        Me.LabelUnitNumber.Size = New System.Drawing.Size(36, 13)
        Me.LabelUnitNumber.TabIndex = 25
        Me.LabelUnitNumber.Text = "Unit #"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(142, 16)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxID.TabIndex = 0
        Me.TextBoxID.Visible = False
        '
        'LabelPropertyID
        '
        Me.LabelPropertyID.AutoSize = True
        Me.LabelPropertyID.Location = New System.Drawing.Point(119, 19)
        Me.LabelPropertyID.Name = "LabelPropertyID"
        Me.LabelPropertyID.Size = New System.Drawing.Size(18, 13)
        Me.LabelPropertyID.TabIndex = 22
        Me.LabelPropertyID.Text = "ID"
        Me.LabelPropertyID.Visible = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(59, 334)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 35)
        Me.ButtonDelete.TabIndex = 26
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'FormAddProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 383)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.GroupBoxPPropertyInformation)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonSaveInsert)
        Me.Name = "FormAddProperty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Property Information"
        Me.GroupBoxPPropertyInformation.ResumeLayout(False)
        Me.GroupBoxPPropertyInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonSaveInsert As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents GroupBoxPPropertyInformation As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxIsVacant As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHasParking As System.Windows.Forms.CheckBox
    Friend WithEvents LabelParking As System.Windows.Forms.Label
    Friend WithEvents TextBoxDamageDepositAmount As System.Windows.Forms.TextBox
    Friend WithEvents LabelDamageDepositAmount As System.Windows.Forms.Label
    Friend WithEvents LabelisVacant As System.Windows.Forms.Label
    Friend WithEvents TextBoxLeaseAmount As System.Windows.Forms.TextBox
    Friend WithEvents LabelLeaseAmount As System.Windows.Forms.Label
    Friend WithEvents TextBoxZip As System.Windows.Forms.TextBox
    Friend WithEvents LabelZip As System.Windows.Forms.Label
    Friend WithEvents TextBoxState As System.Windows.Forms.TextBox
    Friend WithEvents LabelState As System.Windows.Forms.Label
    Friend WithEvents TextBoxCity As System.Windows.Forms.TextBox
    Friend WithEvents LabelCity As System.Windows.Forms.Label
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents LabelAddress As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaxCapacity As System.Windows.Forms.TextBox
    Friend WithEvents LabelMaxCapacity As System.Windows.Forms.Label
    Friend WithEvents TextBoxUnitNumber As System.Windows.Forms.TextBox
    Friend WithEvents LabelUnitNumber As System.Windows.Forms.Label
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents LabelPropertyID As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
End Class
