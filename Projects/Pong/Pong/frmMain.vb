Public Class frmMain
    'Josh Gibbs
    'Period 2
    '14 April 2011
    'Pong (frmMain)

    'To-Do

    'Scores
    Public varPlayer1Score As Integer
    Public varPlayer2Score As Integer
    Public varPlayer3Score As Integer
    Public varPlayer4Score As Integer

    Public varScoreCountsUp As Boolean
    Public varEndScore As Integer

    'Player Status Variables
    Public varPlayer1Status As String
    Public varPlayer2Status As String
    Public varPlayer3Status As String
    Public varPlayer4Status As String

    'Ball Variables
    Public varBallXDirection As Int16
    Public varBallYDirection As Int16
    Public varBallSpeed As Integer

    'Player Variables
    Public varPlayerSpeed As Integer
    Private varPlayer1Direction As Int16
    Private varPlayer2Direction As Int16
    Private varPlayer3Direction As Int16
    Private varPlayer4Direction As Int16

    'Player Pointer Variables
    Public varPlayerXHasMouse As Int16

    Private Sub tmrBallMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBallMovement.Tick

        'Moves ball
        Ball.Left += varBallXDirection * varBallSpeed
        Ball.Top += varBallYDirection * varBallSpeed
        Ball.SetBounds(Ball.Left, Ball.Top, Ball.Width, Ball.Height)

        'Bounces ball off walls (not paddles)
        If Ball.Left <= 0 Then
            varBallXDirection = varBallXDirection * -1
            If varPlayer1Status < 2 Then
                'updates scores
                If varScoreCountsUp = True Then
                    If varPlayer2Status < 2 Then
                        varPlayer2Score += 1
                        lblPlayer2Score.Text = varPlayer2Score
                    ElseIf varPlayer3Status < 2 Then
                        varPlayer3Score += 1
                        lblPlayer3Score.Text = varPlayer3Score
                    ElseIf varPlayer4Status < 2 Then
                        varPlayer4Score += 1
                        lblPlayer4Score.Text = varPlayer4Score
                    End If
                Else
                    varPlayer1Score -= 1
                    lblPlayer1Score.Text = varPlayer1Score
                End If
                If varPlayer1Score = varEndScore Then
                    varPlayer1Status = 2
                    Player1.Visible = False
                    lblPlayer1Score.Visible = False
                End If
            End If
        ElseIf Ball.Right >= Me.Width Then
            varBallXDirection = varBallXDirection * -1
            If varPlayer2Status < 2 Then
                'updates scores
                If varScoreCountsUp = True Then
                    If varPlayer1Status < 2 Then
                        varPlayer1Score += 1
                        lblPlayer1Score.Text = varPlayer1Score
                    ElseIf varPlayer3Status < 2 Then
                        varPlayer3Score += 1
                        lblPlayer3Score.Text = varPlayer3Score
                    ElseIf varPlayer4Status < 2 Then
                        varPlayer4Score += 1
                        lblPlayer4Score.Text = varPlayer4Score
                    End If
                Else
                    varPlayer2Score -= 1
                    lblPlayer2Score.Text = varPlayer2Score
                End If
                If varPlayer2Score = varEndScore Then
                    varPlayer2Status = 2
                    Player2.Visible = False
                    lblPlayer2Score.Visible = False
                End If
            End If
        End If
        If Ball.Bottom >= Me.Height - 20 Then
            varBallYDirection = varBallYDirection * -1
            If varPlayer3Status < 2 Then
                'updates scores
                If varScoreCountsUp = True Then
                    If varPlayer1Status < 2 Then
                        varPlayer1Score += 1
                        lblPlayer1Score.Text = varPlayer1Score
                    ElseIf varPlayer2Status < 2 Then
                        varPlayer2Score += 1
                        lblPlayer2Score.Text = varPlayer2Score
                    ElseIf varPlayer4Status < 2 Then
                        varPlayer4Score += 1
                        lblPlayer4Score.Text = varPlayer4Score
                    End If
                Else
                    varPlayer3Score -= 1
                    lblPlayer3Score.Text = varPlayer3Score
                End If
                If varPlayer3Score = varEndScore Then
                    varPlayer3Status = 2
                    Player3.Visible = False
                    lblPlayer3Score.Visible = False
                End If
            End If
        ElseIf Ball.Top <= 0 Then
            varBallYDirection = varBallYDirection * -1
            If varPlayer4Status < 2 Then
                'updates scores
                If varScoreCountsUp = True Then
                    If varPlayer1Status < 2 Then
                        varPlayer1Score += 1
                        lblPlayer1Score.Text = varPlayer1Score
                    ElseIf varPlayer2Status < 2 Then
                        varPlayer2Score += 1
                        lblPlayer2Score.Text = varPlayer2Score
                    ElseIf varPlayer4Status < 2 Then
                        varPlayer3Score += 1
                        lblPlayer3Score.Text = varPlayer3Score
                    End If
                Else
                    varPlayer4Score -= 1
                    lblPlayer4Score.Text = varPlayer4Score
                End If
                If varPlayer4Score = varEndScore Then
                    varPlayer4Status = 2
                    Player4.Visible = False
                    lblPlayer4Score.Visible = False
                End If
            End If
        End If

        'Makes ball bounce off paddles
        If Ball.Bounds.IntersectsWith(Player1.Bounds) And varPlayer1Status < 2 Then
            varBallXDirection = varBallXDirection * -1
        ElseIf Ball.Bounds.IntersectsWith(Player2.Bounds) And varPlayer2Status < 2 Then
            varBallXDirection = varBallXDirection * -1
        End If
        If Ball.Bounds.IntersectsWith(Player3.Bounds) And varPlayer2Status < 2 Then
            varBallYDirection = varBallYDirection * -1
        ElseIf Ball.Bounds.IntersectsWith(Player4.Bounds) And varPlayer4Status < 2 Then
            varBallYDirection = varBallYDirection * -1
        End If

    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '//If the player is enabled, the direction can be changed

        If varPlayer1Status = 0 Then
            If e.KeyCode = Keys.W Then
                varPlayer1Direction = -1
            End If
            If e.KeyCode = Keys.S Then
                varPlayer1Direction = 1
            End If
        End If

        If varPlayer2Status = 0 Then
            If e.KeyCode = Keys.I Then
                varPlayer2Direction = -1
            End If
            If e.KeyCode = Keys.K Then
                varPlayer2Direction = 1
            End If
        End If

        If varPlayer3Status = 0 Then
            If e.KeyCode = Keys.A Then
                varPlayer3Direction = -1
            End If
            If e.KeyCode = Keys.D Then
                varPlayer3Direction = 1
            End If
        End If

        If varPlayer4Status = 0 Then
            If e.KeyCode = Keys.J Then
                varPlayer4Direction = -1
            End If
            If e.KeyCode = Keys.L Then
                varPlayer4Direction = 1
            End If
        End If
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        '//If the player is enabled, the direction can be changed

        If varPlayer1Status = 0 Then
            If e.KeyCode = Keys.W And varPlayer1Direction = -1 Then
                varPlayer1Direction = 0
            End If
            If e.KeyCode = Keys.S And varPlayer1Direction = 1 Then
                varPlayer1Direction = 0
            End If
        End If

        If varPlayer2Status = 0 Then
            If e.KeyCode = Keys.I And varPlayer2Direction = -1 Then
                varPlayer2Direction = 0
            End If
            If e.KeyCode = Keys.K And varPlayer2Direction = 1 Then
                varPlayer2Direction = 0
            End If
        End If

        If varPlayer3Status = 0 Then
            If e.KeyCode = Keys.A And varPlayer3Direction = -1 Then
                varPlayer3Direction = 0
            End If
            If e.KeyCode = Keys.D And varPlayer3Direction = 1 Then
                varPlayer3Direction = 0
            End If
        End If

        If varPlayer4Status = 0 Then
            If e.KeyCode = Keys.J And varPlayer4Direction = -1 Then
                varPlayer4Direction = 0
            End If
            If e.KeyCode = Keys.L And varPlayer4Direction = 1 Then
                varPlayer4Direction = 0
            End If
        End If
    End Sub

    Private Sub tmrPlayerMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerMovement.Tick
        '//Lets players move only if they are in bounds

        With Player1
            If .Top >= 0 And varPlayer1Direction = -1 Then
                .Top += varPlayerSpeed * varPlayer1Direction
            ElseIf Player1.Bottom <= Me.Height - 25 And varPlayer1Direction = 1 Then
                .Top += varPlayerSpeed * varPlayer1Direction
            End If
            .SetBounds(.Left, .Top, .Width, .Height)
        End With

        With Player2
            If .Top >= 0 And varPlayer2Direction = -1 Then
                .Top += varPlayerSpeed * varPlayer2Direction
            ElseIf .Bottom <= Me.Height - 25 And varPlayer2Direction = 1 Then
                .Top += varPlayerSpeed * varPlayer2Direction
            End If
            .SetBounds(.Left, .Top, .Width, .Height)
        End With

        With Player3
            If .Left >= 0 And varPlayer3Direction = -1 Then
                .Left += varPlayerSpeed * varPlayer3Direction
            ElseIf .Right <= Me.Width And varPlayer3Direction = 1 Then
                .Left += varPlayerSpeed * varPlayer3Direction
            End If
            .SetBounds(.Left, .Top, .Width, .Height)
        End With

        With Player4
            If .Left >= 0 And varPlayer4Direction = -1 Then
                .Left += varPlayerSpeed * varPlayer4Direction
            ElseIf .Right <= Me.Width And varPlayer4Direction = 1 Then
                .Left += varPlayerSpeed * varPlayer4Direction
            End If
            .SetBounds(.Left, .Top, .Width, .Height)
        End With

    End Sub

    Private Sub tmrDebug_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDebug.Tick
        lblDebug.Text = "DEBUGGING STATS v1.3" & vbNewLine & _
            "varBallXDirection = " & varBallXDirection & vbNewLine & _
            "varBallYDirection = " & varBallYDirection & vbNewLine & vbNewLine & _
            "varPlayerSpeed = " & varPlayerSpeed & vbNewLine & _
            "varPlayer1Direction = " & varPlayer1Direction & vbNewLine & _
            "varPlayer2Direction = " & varPlayer2Direction & vbNewLine & vbNewLine & _
            "varPlayer1Status = " & varPlayer1Status & vbNewLine & _
            "varPlayer2Status = " & varPlayer2Status & vbNewLine & _
            "varPlayer3Status = " & varPlayer3Status & vbNewLine & _
            "varPlayer4Status = " & varPlayer4Status & vbNewLine & vbNewLine & _
            "Ball.Location = (" & Ball.Location.X & ", " & Ball.Location.Y & ")" & vbNewLine & _
            "Player1.Location = (" & Player1.Location.X & ", " & Player1.Location.Y & ")" & vbNewLine & _
            "Player2.Location = (" & Player2.Location.X & ", " & Player2.Location.Y & ")" & vbNewLine & _
            "Player3.Location = (" & Player3.Location.X & ", " & Player3.Location.Y & ")" & vbNewLine & _
            "Player4.Location = (" & Player4.Location.X & ", " & Player4.Location.Y & ")" & vbNewLine
    End Sub

    'Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    '   Player1.Top = MousePosition.Y - Player1.Height / 2 - 150
    'End Sub

    Private Sub tmrAI_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAI.Tick
        'If AI is enabled on a player, they follow the ball
        If varPlayer1Status = 1 Then
            If Ball.Top + Ball.Height / 2 > Player1.Top + Player1.Height / 2 Then
                varPlayer1Direction = 1
            ElseIf Ball.Top + Ball.Height / 2 < Player1.Top + Player1.Height / 2 Then
                varPlayer1Direction = -1
            End If
        End If

        If varPlayer2Status = 1 Then
            If Ball.Top + Ball.Height / 2 > Player2.Top + Player2.Height / 2 Then
                varPlayer2Direction = 1
            ElseIf Ball.Top + Ball.Height / 2 < Player2.Top + Player2.Height / 2 Then
                varPlayer2Direction = -1
            End If
        End If

        If varPlayer3Status = 1 Then
            If Ball.Left + Ball.Width / 2 > Player3.Left + Player3.Width / 2 Then
                varPlayer3Direction = 1
            ElseIf Ball.Left + Ball.Width / 2 < Player3.Left + Player3.Width / 2 Then
                varPlayer3Direction = -1
            End If
        End If

        If varPlayer4Status = 1 Then
            If Ball.Left + Ball.Width / 2 > Player4.Left + Player4.Width / 2 Then
                varPlayer4Direction = 1
            ElseIf Ball.Left + Ball.Width / 2 < Player4.Left + Player4.Width / 2 Then
                varPlayer4Direction = -1
            End If
        End If

    End Sub

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If varPlayerXHasMouse = 1 Then
            Player1.Top = MousePosition.Y - Me.Top - Player1.Height / 2
        ElseIf varPlayerXHasMouse = 2 Then
            Player2.Top = MousePosition.Y - Me.Top - Player2.Height / 2
        ElseIf varPlayerXHasMouse = 3 Then
            Player3.Left = MousePosition.X - Me.Left - Player3.Width / 2
        ElseIf varPlayerXHasMouse = 4 Then
            Player4.Left = MousePosition.X - Me.Top - Player4.Width / 2
        End If
    End Sub
End Class