<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneMemberPaymentsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lstFullNames = New System.Windows.Forms.ListBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OneMemberPaymentsDataSet = New KarateSchoolManager.OneMemberPaymentsDataSet()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        Me.MemberIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersTableAdapter = New KarateSchoolManager.OneMemberPaymentsDataSetTableAdapters.MembersTableAdapter()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New KarateSchoolManager.OneMemberPaymentsDataSetTableAdapters.PaymentsTableAdapter()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneMemberPaymentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstFullNames
        '
        Me.lstFullNames.DataSource = Me.MembersBindingSource
        Me.lstFullNames.DisplayMember = "FullName"
        Me.lstFullNames.FormattingEnabled = True
        Me.lstFullNames.Location = New System.Drawing.Point(17, 13)
        Me.lstFullNames.Name = "lstFullNames"
        Me.lstFullNames.Size = New System.Drawing.Size(157, 238)
        Me.lstFullNames.TabIndex = 0
        Me.lstFullNames.ValueMember = "ID"
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.OneMemberPaymentsDataSet
        '
        'OneMemberPaymentsDataSet
        '
        Me.OneMemberPaymentsDataSet.DataSetName = "OneMemberPaymentsDataSet"
        Me.OneMemberPaymentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvPayments
        '
        Me.dgvPayments.AllowUserToAddRows = False
        Me.dgvPayments.AllowUserToDeleteRows = False
        Me.dgvPayments.AutoGenerateColumns = False
        Me.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dgvPayments.DataSource = Me.PaymentsBindingSource
        Me.dgvPayments.Location = New System.Drawing.Point(206, 13)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.ReadOnly = True
        Me.dgvPayments.Size = New System.Drawing.Size(243, 238)
        Me.dgvPayments.TabIndex = 1
        '
        'MemberIdDataGridViewTextBoxColumn1
        '
        Me.MemberIdDataGridViewTextBoxColumn1.DataPropertyName = "Member_Id"
        Me.MemberIdDataGridViewTextBoxColumn1.HeaderText = "Member_Id"
        Me.MemberIdDataGridViewTextBoxColumn1.Name = "MemberIdDataGridViewTextBoxColumn1"
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.OneMemberPaymentsDataSet
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OneMemberPaymentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 274)
        Me.Controls.Add(Me.dgvPayments)
        Me.Controls.Add(Me.lstFullNames)
        Me.Name = "OneMemberPaymentsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OneMemberPaymentsForm"
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneMemberPaymentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstFullNames As System.Windows.Forms.ListBox
    Friend WithEvents dgvPayments As System.Windows.Forms.DataGridView
    Friend WithEvents MemberIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OneMemberPaymentsDataSet As KarateSchoolManager.OneMemberPaymentsDataSet
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As KarateSchoolManager.OneMemberPaymentsDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentsTableAdapter As KarateSchoolManager.OneMemberPaymentsDataSetTableAdapters.PaymentsTableAdapter
End Class
