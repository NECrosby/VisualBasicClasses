<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ButtonQueryRenter = New System.Windows.Forms.Button
        Me.ButtonQueryProperties = New System.Windows.Forms.Button
        Me.LabelCount = New System.Windows.Forms.Label
        Me.ButtonAddProperty = New System.Windows.Forms.Button
        Me.ButtonAddRenter = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ButtonAddAgreement = New System.Windows.Forms.Button
        Me.ButtonQueryAgreements = New System.Windows.Forms.Button
        Me.GroupBoxAgreementDetails = New System.Windows.Forms.GroupBox
        Me.LabelRenterInformationValue = New System.Windows.Forms.Label
        Me.LabelPropertyInformationValue = New System.Windows.Forms.Label
        Me.LabelRenterInformation = New System.Windows.Forms.Label
        Me.LabelPropertyInformation = New System.Windows.Forms.Label
        Me.ButtonSearchRenter = New System.Windows.Forms.Button
        Me.ButtonSearchProperty = New System.Windows.Forms.Button
        Me.ButtonSearchAgreements = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBoxAgreementDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(187, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1200, 800)
        Me.DataGridView1.TabIndex = 0
        '
        'ButtonQueryRenter
        '
        Me.ButtonQueryRenter.Location = New System.Drawing.Point(14, 26)
        Me.ButtonQueryRenter.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonQueryRenter.Name = "ButtonQueryRenter"
        Me.ButtonQueryRenter.Size = New System.Drawing.Size(120, 23)
        Me.ButtonQueryRenter.TabIndex = 1
        Me.ButtonQueryRenter.Text = "Renter Info"
        Me.ButtonQueryRenter.UseVisualStyleBackColor = True
        '
        'ButtonQueryProperties
        '
        Me.ButtonQueryProperties.Location = New System.Drawing.Point(14, 28)
        Me.ButtonQueryProperties.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonQueryProperties.Name = "ButtonQueryProperties"
        Me.ButtonQueryProperties.Size = New System.Drawing.Size(120, 23)
        Me.ButtonQueryProperties.TabIndex = 2
        Me.ButtonQueryProperties.Text = "Property Info"
        Me.ButtonQueryProperties.UseVisualStyleBackColor = True
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(18, 24)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(79, 13)
        Me.LabelCount.TabIndex = 3
        Me.LabelCount.Text = "Record Count: "
        '
        'ButtonAddProperty
        '
        Me.ButtonAddProperty.Location = New System.Drawing.Point(14, 65)
        Me.ButtonAddProperty.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonAddProperty.Name = "ButtonAddProperty"
        Me.ButtonAddProperty.Size = New System.Drawing.Size(120, 23)
        Me.ButtonAddProperty.TabIndex = 4
        Me.ButtonAddProperty.Text = "Add New Property"
        Me.ButtonAddProperty.UseVisualStyleBackColor = True
        '
        'ButtonAddRenter
        '
        Me.ButtonAddRenter.Location = New System.Drawing.Point(14, 63)
        Me.ButtonAddRenter.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonAddRenter.Name = "ButtonAddRenter"
        Me.ButtonAddRenter.Size = New System.Drawing.Size(120, 23)
        Me.ButtonAddRenter.TabIndex = 5
        Me.ButtonAddRenter.Text = "Add New Renter"
        Me.ButtonAddRenter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSearchRenter)
        Me.GroupBox1.Controls.Add(Me.ButtonQueryRenter)
        Me.GroupBox1.Controls.Add(Me.ButtonAddRenter)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 145)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Renter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonSearchProperty)
        Me.GroupBox2.Controls.Add(Me.ButtonAddProperty)
        Me.GroupBox2.Controls.Add(Me.ButtonQueryProperties)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 145)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Property"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonSearchAgreements)
        Me.GroupBox3.Controls.Add(Me.ButtonAddAgreement)
        Me.GroupBox3.Controls.Add(Me.ButtonQueryAgreements)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 413)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(155, 145)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agreements"
        '
        'ButtonAddAgreement
        '
        Me.ButtonAddAgreement.Location = New System.Drawing.Point(14, 65)
        Me.ButtonAddAgreement.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonAddAgreement.Name = "ButtonAddAgreement"
        Me.ButtonAddAgreement.Size = New System.Drawing.Size(120, 23)
        Me.ButtonAddAgreement.TabIndex = 4
        Me.ButtonAddAgreement.Text = "Add New Agreement"
        Me.ButtonAddAgreement.UseVisualStyleBackColor = True
        '
        'ButtonQueryAgreements
        '
        Me.ButtonQueryAgreements.Location = New System.Drawing.Point(14, 28)
        Me.ButtonQueryAgreements.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonQueryAgreements.Name = "ButtonQueryAgreements"
        Me.ButtonQueryAgreements.Size = New System.Drawing.Size(120, 23)
        Me.ButtonQueryAgreements.TabIndex = 2
        Me.ButtonQueryAgreements.Text = "Agreement Info"
        Me.ButtonQueryAgreements.UseVisualStyleBackColor = True
        '
        'GroupBoxAgreementDetails
        '
        Me.GroupBoxAgreementDetails.Controls.Add(Me.LabelRenterInformationValue)
        Me.GroupBoxAgreementDetails.Controls.Add(Me.LabelPropertyInformationValue)
        Me.GroupBoxAgreementDetails.Controls.Add(Me.LabelRenterInformation)
        Me.GroupBoxAgreementDetails.Controls.Add(Me.LabelPropertyInformation)
        Me.GroupBoxAgreementDetails.Location = New System.Drawing.Point(187, 825)
        Me.GroupBoxAgreementDetails.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBoxAgreementDetails.Name = "GroupBoxAgreementDetails"
        Me.GroupBoxAgreementDetails.Size = New System.Drawing.Size(709, 107)
        Me.GroupBoxAgreementDetails.TabIndex = 9
        Me.GroupBoxAgreementDetails.TabStop = False
        Me.GroupBoxAgreementDetails.Text = "Rental Agreement Details"
        Me.GroupBoxAgreementDetails.Visible = False
        '
        'LabelRenterInformationValue
        '
        Me.LabelRenterInformationValue.AutoSize = True
        Me.LabelRenterInformationValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRenterInformationValue.Location = New System.Drawing.Point(174, 64)
        Me.LabelRenterInformationValue.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelRenterInformationValue.MinimumSize = New System.Drawing.Size(500, 0)
        Me.LabelRenterInformationValue.Name = "LabelRenterInformationValue"
        Me.LabelRenterInformationValue.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelRenterInformationValue.Size = New System.Drawing.Size(500, 25)
        Me.LabelRenterInformationValue.TabIndex = 3
        '
        'LabelPropertyInformationValue
        '
        Me.LabelPropertyInformationValue.AutoSize = True
        Me.LabelPropertyInformationValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPropertyInformationValue.Location = New System.Drawing.Point(174, 29)
        Me.LabelPropertyInformationValue.Margin = New System.Windows.Forms.Padding(10)
        Me.LabelPropertyInformationValue.MinimumSize = New System.Drawing.Size(500, 0)
        Me.LabelPropertyInformationValue.Name = "LabelPropertyInformationValue"
        Me.LabelPropertyInformationValue.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelPropertyInformationValue.Size = New System.Drawing.Size(500, 25)
        Me.LabelPropertyInformationValue.TabIndex = 2
        '
        'LabelRenterInformation
        '
        Me.LabelRenterInformation.AutoSize = True
        Me.LabelRenterInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRenterInformation.Location = New System.Drawing.Point(35, 69)
        Me.LabelRenterInformation.Name = "LabelRenterInformation"
        Me.LabelRenterInformation.Size = New System.Drawing.Size(135, 15)
        Me.LabelRenterInformation.TabIndex = 1
        Me.LabelRenterInformation.Text = "Renter Information: "
        '
        'LabelPropertyInformation
        '
        Me.LabelPropertyInformation.AutoSize = True
        Me.LabelPropertyInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPropertyInformation.Location = New System.Drawing.Point(25, 34)
        Me.LabelPropertyInformation.Name = "LabelPropertyInformation"
        Me.LabelPropertyInformation.Size = New System.Drawing.Size(145, 15)
        Me.LabelPropertyInformation.TabIndex = 0
        Me.LabelPropertyInformation.Text = "Property Information: "
        '
        'ButtonSearchRenter
        '
        Me.ButtonSearchRenter.Location = New System.Drawing.Point(14, 100)
        Me.ButtonSearchRenter.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonSearchRenter.Name = "ButtonSearchRenter"
        Me.ButtonSearchRenter.Size = New System.Drawing.Size(120, 23)
        Me.ButtonSearchRenter.TabIndex = 6
        Me.ButtonSearchRenter.Text = "Search Renters"
        Me.ButtonSearchRenter.UseVisualStyleBackColor = True
        '
        'ButtonSearchProperty
        '
        Me.ButtonSearchProperty.Location = New System.Drawing.Point(14, 102)
        Me.ButtonSearchProperty.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonSearchProperty.Name = "ButtonSearchProperty"
        Me.ButtonSearchProperty.Size = New System.Drawing.Size(120, 23)
        Me.ButtonSearchProperty.TabIndex = 8
        Me.ButtonSearchProperty.Text = "Search Property"
        Me.ButtonSearchProperty.UseVisualStyleBackColor = True
        '
        'ButtonSearchAgreements
        '
        Me.ButtonSearchAgreements.Location = New System.Drawing.Point(14, 102)
        Me.ButtonSearchAgreements.Margin = New System.Windows.Forms.Padding(7)
        Me.ButtonSearchAgreements.Name = "ButtonSearchAgreements"
        Me.ButtonSearchAgreements.Size = New System.Drawing.Size(120, 23)
        Me.ButtonSearchAgreements.TabIndex = 9
        Me.ButtonSearchAgreements.Text = "Search Agreements"
        Me.ButtonSearchAgreements.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 951)
        Me.Controls.Add(Me.GroupBoxAgreementDetails)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelCount)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Rental Property Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBoxAgreementDetails.ResumeLayout(False)
        Me.GroupBoxAgreementDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonQueryRenter As System.Windows.Forms.Button
    Friend WithEvents ButtonQueryProperties As System.Windows.Forms.Button
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents ButtonAddProperty As System.Windows.Forms.Button
    Friend WithEvents ButtonAddRenter As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonAddAgreement As System.Windows.Forms.Button
    Friend WithEvents ButtonQueryAgreements As System.Windows.Forms.Button
    Friend WithEvents GroupBoxAgreementDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LabelPropertyInformationValue As System.Windows.Forms.Label
    Friend WithEvents LabelRenterInformation As System.Windows.Forms.Label
    Friend WithEvents LabelPropertyInformation As System.Windows.Forms.Label
    Friend WithEvents LabelRenterInformationValue As System.Windows.Forms.Label
    Friend WithEvents ButtonSearchRenter As System.Windows.Forms.Button
    Friend WithEvents ButtonSearchProperty As System.Windows.Forms.Button
    Friend WithEvents ButtonSearchAgreements As System.Windows.Forms.Button

End Class
