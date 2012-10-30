Public Class Form1

    Private Sub TimerGameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGameTimer.Tick
        Dim random As New Random
        Dim newLeft, newTop As Integer

        newLeft = random.Next(Me.Width - ButtonCatchMe.Width)
        newTop = random.Next(Me.Height - ButtonCatchMe.Height)

        ButtonCatchMe.Left = newLeft
        ButtonCatchMe.Top = newTop
    End Sub

    Private Sub ButtonCatchMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCatchMe.Click
        TimerGameTimer.Enabled = False
        MessageBox.Show("You Win!")
        Me.Close()
    End Sub
End Class
