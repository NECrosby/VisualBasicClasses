<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneMemberPaymentForm
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
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OneMemberPaymentsDataSet = New Karate.OneMemberPaymentsDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersTableAdapter = New Karate.OneMemberPaymentsDataSetTableAdapters.MembersTableAdapter()
        Me.dgvOneMemberPayments = New System.Windows.Forms.DataGridView()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New Karate.OneMemberPaymentsDataSetTableAdapters.PaymentsTableAdapter()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OneMemberPaymentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvOneMemberPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstNames
        '
        Me.lstNames.DataSource = Me.MembersBindingSource
        Me.lstNames.DisplayMember = "FullName"
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(12, 40)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(152, 160)
        Me.lstNames.TabIndex = 0
        Me.lstNames.ValueMember = "ID"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuFileClose.Text = "&Close"
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'dgvOneMemberPayments
        '
        Me.dgvOneMemberPayments.AllowUserToAddRows = False
        Me.dgvOneMemberPayments.AllowUserToDeleteRows = False
        Me.dgvOneMemberPayments.AutoGenerateColumns = False
        Me.dgvOneMemberPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOneMemberPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dgvOneMemberPayments.DataSource = Me.PaymentsBindingSource
        Me.dgvOneMemberPayments.Location = New System.Drawing.Point(203, 40)
        Me.dgvOneMemberPayments.Name = "dgvOneMemberPayments"
        Me.dgvOneMemberPayments.ReadOnly = True
        Me.dgvOneMemberPayments.Size = New System.Drawing.Size(240, 160)
        Me.dgvOneMemberPayments.TabIndex = 2
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment Date"
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
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.OneMemberPaymentsDataSet
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'OneMemberPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 217)
        Me.Controls.Add(Me.dgvOneMemberPayments)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "OneMemberPaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payments by One Member"
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OneMemberPaymentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvOneMemberPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneMemberPaymentsDataSet As Karate.OneMemberPaymentsDataSet
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As Karate.OneMemberPaymentsDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents dgvOneMemberPayments As System.Windows.Forms.DataGridView
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentsTableAdapter As Karate.OneMemberPaymentsDataSetTableAdapters.PaymentsTableAdapter
End Class
