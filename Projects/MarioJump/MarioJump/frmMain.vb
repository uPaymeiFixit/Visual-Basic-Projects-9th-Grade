Public Class frmMain

    Private dangers(5) As PictureBox
    Private speeds(5) As Int16

    Private speed0 As Int16
    Private speed1 As Int16
    Private speed2 As Int16
    Private speed3 As Int16
    Private speed4 As Int16
    Private speed5 As Int16

    Private varKeyUp As Boolean
    Private varKeyDown As Boolean

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            varKeyUp = True
        End If
        If e.KeyCode = Keys.Down Then
            varKeyDown = True
        End If
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            varKeyUp = False
        End If
        If e.KeyCode = Keys.Down Then
            varKeyDown = False
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dangers(0) = picDanger0
        dangers(1) = picDanger1
        dangers(2) = picDanger2
        dangers(3) = picDanger3
        dangers(4) = picDanger4
        dangers(5) = picDanger5

        speed0 = Rnd() * 3 + 2
        speed1 = Rnd() * 3 + 2
        speed2 = Rnd() * 3 + 2
        speed3 = Rnd() * 3 + 2
        speed4 = Rnd() * 3 + 2
        speed5 = Rnd() * 3 + 2

        speeds(0) = speed0
        speeds(1) = speed1
        speeds(2) = speed2
        speeds(3) = speed3
        speeds(4) = speed4
        speeds(5) = speed5

       

        For i = 0 To 5
            dangers(i).Top = Rnd() * (Me.Height - picDanger0.Height)
            dangers(i).Left = (Rnd() * Me.Width - Me.Width / 4) + (Me.Width / 4) * 3
        Next

    End Sub

    Private Sub tmrMoveFireball_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMoveFireball.Tick
        For i = 0 To 5
            dangers(i).SetBounds(dangers(i).Left - speeds(i), dangers(i).Top, dangers(i).Width, dangers(i).Height)
            If dangers(i).Left <= 0 Then
                dangers(i).Left = (Me.Width - picDanger0.Width)
                dangers(i).Top = Rnd() * (Me.Height - picDanger0.Height)
                speeds(i) = Rnd() * 3 + 2
            End If

            If dangers(i).Bounds.IntersectsWith(picPlayer.Bounds) Then
                tmrMoveFireball.Enabled = False
                tmrPlayerMovement.Enabled = False
                MessageBox.Show("GAME OVER")
            End If

        Next

    End Sub

    Private Sub tmrPlayerMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerMovement.Tick
        If varKeyUp And picPlayer.Top > 0 Then
            picPlayer.SetBounds(picPlayer.Left, picPlayer.Top - 5, picPlayer.Width, picPlayer.Height)
        End If
        If varKeyDown And picPlayer.Bottom < Me.Height Then
            picPlayer.SetBounds(picPlayer.Left, picPlayer.Top + 5, picPlayer.Width, picPlayer.Height)
        End If
    End Sub
End Class
