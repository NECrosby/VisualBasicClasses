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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembership = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipListall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipFindmember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipAddnewmember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipMemberdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsAllmembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsByOneMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMembership, Me.mnuPayments})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuMembership
        '
        Me.mnuMembership.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMembershipListall, Me.mnuMembershipFindmember, Me.mnuMembershipAddnewmember, Me.mnuMembershipMemberdates})
        Me.mnuMembership.Name = "mnuMembership"
        Me.mnuMembership.Size = New System.Drawing.Size(86, 20)
        Me.mnuMembership.Text = "&Membership"
        '
        'mnuMembershipListall
        '
        Me.mnuMembershipListall.Name = "mnuMembershipListall"
        Me.mnuMembershipListall.Size = New System.Drawing.Size(169, 22)
        Me.mnuMembershipListall.Text = "&List all"
        '
        'mnuMembershipFindmember
        '
        Me.mnuMembershipFindmember.Name = "mnuMembershipFindmember"
        Me.mnuMembershipFindmember.Size = New System.Drawing.Size(169, 22)
        Me.mnuMembershipFindmember.Text = "&Find member"
        '
        'mnuMembershipAddnewmember
        '
        Me.mnuMembershipAddnewmember.Name = "mnuMembershipAddnewmember"
        Me.mnuMembershipAddnewmember.Size = New System.Drawing.Size(169, 22)
        Me.mnuMembershipAddnewmember.Text = "&Add new member"
        '
        'mnuMembershipMemberdates
        '
        Me.mnuMembershipMemberdates.Name = "mnuMembershipMemberdates"
        Me.mnuMembershipMemberdates.Size = New System.Drawing.Size(169, 22)
        Me.mnuMembershipMemberdates.Text = "&Member Dates"
        '
        'mnuPayments
        '
        Me.mnuPayments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentsAllmembers, Me.PaymentsByOneMemberToolStripMenuItem})
        Me.mnuPayments.Name = "mnuPayments"
        Me.mnuPayments.Size = New System.Drawing.Size(71, 20)
        Me.mnuPayments.Text = "&Payments"
        '
        'mnuPaymentsAllmembers
        '
        Me.mnuPaymentsAllmembers.Name = "mnuPaymentsAllmembers"
        Me.mnuPaymentsAllmembers.Size = New System.Drawing.Size(213, 22)
        Me.mnuPaymentsAllmembers.Text = "&All members"
        '
        'PaymentsByOneMemberToolStripMenuItem
        '
        Me.PaymentsByOneMemberToolStripMenuItem.Name = "PaymentsByOneMemberToolStripMenuItem"
        Me.PaymentsByOneMemberToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PaymentsByOneMemberToolStripMenuItem.Text = "&Payments by one member"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(62, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 115)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(15, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 80)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kyoshi Karate School"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Management System 1.0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 282)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karate School Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembership As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembershipListall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembershipFindmember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembershipAddnewmember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPayments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaymentsAllmembers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PaymentsByOneMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembershipMemberdates As System.Windows.Forms.ToolStripMenuItem

End Class
