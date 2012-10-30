Public Class Form1
    Dim seconds As Integer
    Dim startTime As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        seconds += 1
        LabelSecondsCount.Text = seconds.ToString
    End Sub

    Private Sub ButtonToggleTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonToggleTimer.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
            ButtonToggleTimer.Text = "&Start Timer"
        Else
            Timer1.Enabled = True
            ButtonToggleTimer.Text = "&Stop Timer"
        End If
    End Sub

    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click
        startTime = 0
        LabelSecondsCount.Text = startTime.ToString
        seconds = 0
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class
