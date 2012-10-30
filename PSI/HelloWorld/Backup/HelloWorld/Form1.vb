Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim greeting As String = String.Empty
        greeting = "Hello World"

        'MessageBox.Show("Hello World")
        'Me.LabelHelloWorld.Text = "Hello World"
        Me.LabelHelloWorld.ForeColor = Color.Azure

        Me.LabelHelloWorld.Text = greeting



    End Sub
End Class
