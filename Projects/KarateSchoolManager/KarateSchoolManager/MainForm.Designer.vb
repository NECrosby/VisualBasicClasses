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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembership = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipListall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipFindMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMembershipAddmember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentsAllmembers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByOneMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.mnuMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(62, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 115)
        Me.Panel1.TabIndex = 0
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
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kyoshi Karate School"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Management System 1.0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMembership, Me.mnuPayments})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(514, 24)
        Me.mnuMainMenu.TabIndex = 2
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(133, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuMembership
        '
        Me.mnuMembership.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMembershipListall, Me.mnuMembershipFindMember, Me.mnuMembershipAddmember})
        Me.mnuMembership.Name = "mnuMembership"
        Me.mnuMembership.Size = New System.Drawing.Size(86, 20)
        Me.mnuMembership.Text = "&Membership"
        '
        'mnuMembershipListall
        '
        Me.mnuMembershipListall.Name = "mnuMembershipListall"
        Me.mnuMembershipListall.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuMembershipListall.Size = New System.Drawing.Size(213, 22)
        Me.mnuMembershipListall.Text = "&List All"
        '
        'mnuMembershipFindMember
        '
        Me.mnuMembershipFindMember.Name = "mnuMembershipFindMember"
        Me.mnuMembershipFindMember.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuMembershipFindMember.Size = New System.Drawing.Size(213, 22)
        Me.mnuMembershipFindMember.Text = "&Find Member"
        '
        'mnuMembershipAddmember
        '
        Me.mnuMembershipAddmember.Name = "mnuMembershipAddmember"
        Me.mnuMembershipAddmember.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuMembershipAddmember.Size = New System.Drawing.Size(213, 22)
        Me.mnuMembershipAddmember.Text = "&Add New Member"
        '
        'mnuPayments
        '
        Me.mnuPayments.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentsAllmembers, Me.ByOneMemberToolStripMenuItem})
        Me.mnuPayments.Name = "mnuPayments"
        Me.mnuPayments.Size = New System.Drawing.Size(71, 20)
        Me.mnuPayments.Text = "&Payments"
        '
        'mnuPaymentsAllmembers
        '
        Me.mnuPaymentsAllmembers.Name = "mnuPaymentsAllmembers"
        Me.mnuPaymentsAllmembers.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuPaymentsAllmembers.Size = New System.Drawing.Size(182, 22)
        Me.mnuPaymentsAllmembers.Text = "&All Members"
        '
        'ByOneMemberToolStripMenuItem
        '
        Me.ByOneMemberToolStripMenuItem.Name = "ByOneMemberToolStripMenuItem"
        Me.ByOneMemberToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ByOneMemberToolStripMenuItem.Text = "By one member"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 282)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karate School Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembership As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembershipListall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembershipFindMember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMembershipAddmember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPayments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaymentsAllmembers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByOneMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
