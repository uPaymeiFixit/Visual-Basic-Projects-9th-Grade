Public Class Form1
    Private t_time As Boolean
    Private l_X1 As Int16
    Private l_Y1 As Int16
    Private l_X2 As Int16
    Private l_Y2 As Int16
    Private s_X As Int16
    Private s_Y As Int16
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If t_time Then
            l_X1 = Control.MousePosition.X
            l_Y1 = Control.MousePosition.Y
            t_time = False
        Else
            l_X2 = Control.MousePosition.X
            l_Y2 = Control.MousePosition.Y
            t_time = True

            s_X = l_X2 - l_X1
            s_Y = l_Y2 - l_Y1
            If s_X < 0 Then
                s_X = s_X * -1
            End If
            If s_Y < 0 Then
                s_Y = s_Y * -1
            End If

            Label1.Text = "X: " & s_X & vbNewLine & "Y: " & s_Y
        End If

    End Sub
End Class
