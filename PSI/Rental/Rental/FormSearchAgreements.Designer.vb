<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearchAgreements
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
        Me.GroupBoxFirstFilter = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.ComboBoxQualifier = New System.Windows.Forms.ComboBox
        Me.TextBoxSearchValue = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBoxFilterBy = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ListBoxSearchResults = New System.Windows.Forms.ListBox
        Me.ButtonShowResults = New System.Windows.Forms.Button
        Me.ButtonResetSearch = New System.Windows.Forms.Button
        Me.GroupBoxFirstFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxFirstFilter
        '
        Me.GroupBoxFirstFilter.Controls.Add(Me.Label1)
        Me.GroupBoxFirstFilter.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxFirstFilter.Controls.Add(Me.ComboBoxQualifier)
        Me.GroupBoxFirstFilter.Controls.Add(Me.TextBoxSearchValue)
        Me.GroupBoxFirstFilter.Controls.Add(Me.Label4)
        Me.GroupBoxFirstFilter.Controls.Add(Me.ComboBoxFilterBy)
        Me.GroupBoxFirstFilter.Controls.Add(Me.Label5)
        Me.GroupBoxFirstFilter.Location = New System.Drawing.Point(24, 12)
        Me.GroupBoxFirstFilter.Name = "GroupBoxFirstFilter"
        Me.GroupBoxFirstFilter.Size = New System.Drawing.Size(299, 183)
        Me.GroupBoxFirstFilter.TabIndex = 18
        Me.GroupBoxFirstFilter.TabStop = False
        Me.GroupBoxFirstFilter.Text = "Search Criteria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "AND / OR: "
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(199, 135)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 35)
        Me.ButtonAdd.TabIndex = 3
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ComboBoxQualifier
        '
        Me.ComboBoxQualifier.FormattingEnabled = True
        Me.ComboBoxQualifier.Location = New System.Drawing.Point(77, 96)
        Me.ComboBoxQualifier.Name = "ComboBoxQualifier"
        Me.ComboBoxQualifier.Size = New System.Drawing.Size(197, 21)
        Me.ComboBoxQualifier.TabIndex = 2
        '
        'TextBoxSearchValue
        '
        Me.TextBoxSearchValue.Location = New System.Drawing.Point(77, 58)
        Me.TextBoxSearchValue.Name = "TextBoxSearchValue"
        Me.TextBoxSearchValue.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxSearchValue.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Value: "
        '
        'ComboBoxFilterBy
        '
        Me.ComboBoxFilterBy.FormattingEnabled = True
        Me.ComboBoxFilterBy.Location = New System.Drawing.Point(77, 23)
        Me.ComboBoxFilterBy.Name = "ComboBoxFilterBy"
        Me.ComboBoxFilterBy.Size = New System.Drawing.Size(197, 21)
        Me.ComboBoxFilterBy.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Filter By: "
        '
        'ListBoxSearchResults
        '
        Me.ListBoxSearchResults.FormattingEnabled = True
        Me.ListBoxSearchResults.Location = New System.Drawing.Point(24, 201)
        Me.ListBoxSearchResults.Name = "ListBoxSearchResults"
        Me.ListBoxSearchResults.Size = New System.Drawing.Size(299, 95)
        Me.ListBoxSearchResults.TabIndex = 19
        '
        'ButtonShowResults
        '
        Me.ButtonShowResults.Location = New System.Drawing.Point(248, 315)
        Me.ButtonShowResults.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonShowResults.Name = "ButtonShowResults"
        Me.ButtonShowResults.Size = New System.Drawing.Size(75, 35)
        Me.ButtonShowResults.TabIndex = 21
        Me.ButtonShowResults.Text = "Show Results"
        Me.ButtonShowResults.UseVisualStyleBackColor = True
        '
        'ButtonResetSearch
        '
        Me.ButtonResetSearch.Location = New System.Drawing.Point(153, 315)
        Me.ButtonResetSearch.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonResetSearch.Name = "ButtonResetSearch"
        Me.ButtonResetSearch.Size = New System.Drawing.Size(75, 35)
        Me.ButtonResetSearch.TabIndex = 22
        Me.ButtonResetSearch.Text = "Reset"
        Me.ButtonResetSearch.UseVisualStyleBackColor = True
        '
        'FormSearchAgreements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 369)
        Me.Controls.Add(Me.ButtonShowResults)
        Me.Controls.Add(Me.ButtonResetSearch)
        Me.Controls.Add(Me.ListBoxSearchResults)
        Me.Controls.Add(Me.GroupBoxFirstFilter)
        Me.Name = "FormSearchAgreements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Agreements"
        Me.GroupBoxFirstFilter.ResumeLayout(False)
        Me.GroupBoxFirstFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxFirstFilter As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ComboBoxQualifier As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxSearchValue As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxFilterBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBoxSearchResults As System.Windows.Forms.ListBox
    Friend WithEvents ButtonShowResults As System.Windows.Forms.Button
    Friend WithEvents ButtonResetSearch As System.Windows.Forms.Button
End Class
