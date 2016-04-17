'Cheat Practice rt1805
'By uPaymeiFixit

Public Class frmMain

    Private points As UInt64
    Private time As UInt64

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim mousePositionX As Int16 = MousePosition.X - Me.Left - 2
        If mousePositionX >= lblDivider.Right Then
            lblYou.SetBounds(mousePositionX, MousePosition.Y - Me.Top - 19, lblYou.Width, lblYou.Height)
            shpLine.X1 = lblYou.Left + lblYou.Width / 2
            shpLine.Y1 = lblYou.Top + lblYou.Height / 2
            shpLineBad.X1 = lblYou.Left + lblYou.Width / 2
            shpLineBad.Y1 = lblYou.Top + lblYou.Height / 2

            If lblYou.Bounds.IntersectsWith(lblTarget.Bounds) Then
                Randomize()
                lblTarget.SetBounds((Rnd() * (Me.Width - lblDivider.Right - lblYou.Width)) + lblDivider.Right, (Rnd() * (Me.Height - 20 - lblYou.Height)), lblTarget.Width, lblTarget.Height)
                shpLine.X2 = lblTarget.Left + lblTarget.Width / 2
                shpLine.Y2 = lblTarget.Top + lblTarget.Height / 2
                points += 1
                lblPoints.Text = "Points:" & vbNewLine & points
            End If

            If lblYou.Bounds.IntersectsWith(lblKeepAway.Bounds) Then
                Randomize()
                lblKeepAway.SetBounds((Rnd() * (Me.Width - lblDivider.Right - lblYou.Width)) + lblDivider.Right, (Rnd() * (Me.Height - 20 - lblYou.Height)), lblKeepAway.Width, lblKeepAway.Height)
                shpLineBad.X2 = lblKeepAway.Left + lblKeepAway.Width / 2
                shpLineBad.Y2 = lblKeepAway.Top + lblKeepAway.Height / 2
                If points >= 5 Then
                    points -= 5
                Else
                    points = 0
                End If
                lblPoints.Text = "Points:" & vbNewLine & points
            End If

        End If
    End Sub

    Private Sub tmrCheckForCheat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckForCheat.Tick
        time += 1
        lblPoints.Text = "Points:" & vbNewLine & points
        If points >= 1000000 Then
            tmrCheckForCheat.Enabled = False
            MessageBox.Show("It took you " & time & " seconds to achieve 1000000 points. The code is " & time * 42 + 1337)
        End If
    End Sub

    Private Sub btnShowCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowCode.Click
        frmShowCode.Visible = True
    End Sub

End Class