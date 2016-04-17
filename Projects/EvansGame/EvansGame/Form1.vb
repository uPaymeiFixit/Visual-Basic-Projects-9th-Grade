
Public Class Form1
    Private civ_count As Int16 = 30
    Private civ(civ_count) As Label
    Private civ_Speed As Int16 = 3
    Private civ_Size As Int16 = 10
    Private civ_destX(civ_count) As Int16
    Private civ_destY(civ_count) As Int16

    Private you_Speed As Int16 = 1

    Private bdr_gap As Int16 = 10
    Private bdr_Right As Int16 = 7
    Private bdr_Bottom As Int16 = 30
    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        For i = 0 To civ_count
            civ(i) = New Label
            Me.Controls.Add(civ(i))
            civ(i).SetBounds((Rnd() * (Me.Width - civ_Size - bdr_Right - bdr_gap)) + bdr_gap, (Rnd() * (Me.Height - civ_Size - bdr_Bottom - bdr_gap)) + bdr_gap, civ_Size, civ_Size)
            civ(i).BackColor = Color.Red
        Next
    End Sub

    Private Sub tmrMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMovement.Tick

       
        'Moves civ to dest
        For a = 1 To civ_Speed
            For u = 0 To civ_count
                If civ(u).Left + civ(u).Width / 2 > civ_destX(u) Then 'If civ is right of x dest
                    If civ(u).Right < Me.Width - bdr_Right - bdr_gap Then 'If civ is left of right wall
                        civ(u).Left += 1
                    End If
                ElseIf civ(u).Left + civ(u).Width / 2 < civ_destX(u) Then 'If civ is left of x dest
                    If civ(u).Left > 0 + bdr_gap Then 'If civ is right of left wall
                        civ(u).Left -= 1
                    End If
                End If

                If civ(u).Top + civ(u).Height / 2 > civ_destY(u) Then 'If civ is below y dest
                    If civ(u).Bottom < Me.Height - bdr_Bottom - bdr_gap Then 'If civ is above bottom wall
                        civ(u).Top += 1
                    End If
                ElseIf civ(u).Top + civ(u).Height < civ_destY(u) Then 'If civ is above y dest
                    If civ(u).Top > 0 + bdr_gap Then 'If civ is below top wall
                        civ(u).Top -= 1
                    End If
                End If
            Next
        Next

        'Moves you to mouse position
        For b = 1 To you_Speed
            If lblYou.Left + lblYou.Width / 2 > MousePosition.X - Me.Left Then
                lblYou.Left -= 1
            ElseIf lblYou.Left + lblYou.Width / 2 < MousePosition.X - Me.Left Then
                lblYou.Left += 1
            End If

            If lblYou.Top + lblYou.Height / 2 > MousePosition.Y - Me.Top Then
                lblYou.Top -= 1
            ElseIf lblYou.Top + lblYou.Height / 2 < MousePosition.Y - Me.Top Then
                lblYou.Top += 1
            End If
        Next
    End Sub

    Private Sub tmrCounter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCounter.Tick
        'Sets destinations away from you
        For i = 0 To civ_count
            If civ(i).Left + civ(i).Width / 2 > lblYou.Left + lblYou.Width / 2 Then 'If civ is right of you
                civ_destX(i) = (Rnd() * (Me.Width - bdr_Right - lblYou.Left + lblYou.Width / 2)) + lblYou.Left + lblYou.Width / 2 'destX = rnd (you to right wall)
            ElseIf civ(i).Left + civ(i).Width / 2 < lblYou.Left + lblYou.Width / 2 Then 'If civ is left of you
                civ_destX(i) = Rnd() * (lblYou.Left + lblYou.Width / 2) 'destX = rnd (left wall to you)
            End If
            If civ(i).Top + civ(i).Height / 2 > lblYou.Top + lblYou.Height / 2 Then 'If civ is below you
                civ_destY(i) = (Rnd() * (Me.Height - bdr_Bottom - lblYou.Top + lblYou.Height / 2)) + bdr_Bottom + lblYou.Top + lblYou.Height / 2 'destY = rnd (you to bottom)
            ElseIf civ(i).Top + civ(i).Height / 2 < lblYou.Top + lblYou.Height / 2 Then 'If civ is above you
                civ_destY(i) = Rnd() * (lblYou.Top + lblYou.Height / 2) 'destY = rnd (top wall to you)
            End If
        Next
    End Sub
End Class
