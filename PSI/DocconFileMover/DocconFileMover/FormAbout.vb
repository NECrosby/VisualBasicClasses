Public Class FormAbout

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "About " & My.Application.Info.Title
        Me.lblApplicationTitle.Text = My.Application.Info.Title
        Me.lblVersion.Text = "Version: " & My.Application.Info.Version.ToString
        Me.lblDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class