'Josh Gibbs
'Period 2
'15 March 2011
'Space Invaders

'To-Do
'Sounds sound weird
'Rows shift at different intervals
'What happens when you die? Win?

Public Class frmMain
    Private Array(54) As PictureBox
    Private EnemyBullet(2) As PictureBox
    Private TimeCounter(2) As Integer
    Private RandomEnemyBulletTime(2) As Integer
    Private EnemyBulletGo(2) As Boolean
    Private varInvaderDirection As Integer = 7
    Private varPlayerGoLeft As Boolean
    Private varInvadersLeft As Integer = 55
    Private varScore As Integer
    Private varEnemyBulletGo1 As Boolean
    Private varEnemyBulletGo2 As Boolean
    Private varEnemyBulletGo3 As Boolean
    Private varTimeCounter1 As Integer
    Private varTimeCounter2 As Integer
    Private varTimeCounter3 As Integer
    Private varRandomEnemyBulletTime1 As Integer
    Private varRandomEnemyBulletTime2 As Integer
    Private varRandomEnemyBulletTime3 As Integer
    Private Lives(6) As PictureBox
    Private varLives As Integer = 3
    Private varIsPaused As Boolean
    Private varMusicBeat As Integer = 1
    Private varOnRowCounter As Decimal
    Private varWinCounter As Integer

    'Variables for "Still Alive" checks
    Private varRowIsAlive As Boolean
    Dim varRowStart As Integer = 44
    Dim varRowStop As Integer = 54
    Private varColumnIsDead As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()

        For x = 0 To 2
            RandomEnemyBulletTime(x) = Rnd() * 50 + 25
        Next

        Lives(1) = picLife1
        Lives(2) = picLife2
        Lives(3) = picLife3
        Lives(4) = picLife4
        Lives(5) = picLife5
        Lives(6) = picLife6

        EnemyBulletGo(0) = varEnemyBulletGo1
        EnemyBulletGo(1) = varEnemyBulletGo2
        EnemyBulletGo(2) = varEnemyBulletGo3

        TimeCounter(0) = varTimeCounter1
        TimeCounter(1) = varTimeCounter2
        TimeCounter(2) = varTimeCounter3

        RandomEnemyBulletTime(0) = varRandomEnemyBulletTime1
        RandomEnemyBulletTime(1) = varRandomEnemyBulletTime2
        RandomEnemyBulletTime(2) = varRandomEnemyBulletTime3

        EnemyBullet(0) = EnemyBullet1
        EnemyBullet(1) = EnemyBullet2
        EnemyBullet(2) = EnemyBullet3

        Array(0) = InvaderZero0
        Array(1) = InvaderZero1
        Array(2) = InvaderZero2
        Array(3) = InvaderZero3
        Array(4) = InvaderZero4
        Array(5) = InvaderZero5
        Array(6) = InvaderZero6
        Array(7) = InvaderZero7
        Array(8) = InvaderZero8
        Array(9) = InvaderZero9
        Array(10) = InvaderZero10
        Array(11) = InvaderOne0
        Array(12) = InvaderOne1
        Array(13) = InvaderOne2
        Array(14) = InvaderOne3
        Array(15) = InvaderOne4
        Array(16) = InvaderOne5
        Array(17) = InvaderOne6
        Array(18) = InvaderOne7
        Array(19) = InvaderOne8
        Array(20) = InvaderOne9
        Array(21) = InvaderOne10
        Array(22) = InvaderTwo0
        Array(23) = InvaderTwo1
        Array(24) = InvaderTwo2
        Array(25) = InvaderTwo3
        Array(26) = InvaderTwo4
        Array(27) = InvaderTwo5
        Array(28) = InvaderTwo6
        Array(29) = InvaderTwo7
        Array(30) = InvaderTwo8
        Array(31) = InvaderTwo9
        Array(32) = InvaderTwo10
        Array(33) = InvaderThree0
        Array(34) = InvaderThree1
        Array(35) = InvaderThree2
        Array(36) = InvaderThree3
        Array(37) = InvaderThree4
        Array(38) = InvaderThree5
        Array(39) = InvaderThree6
        Array(40) = InvaderThree7
        Array(41) = InvaderThree8
        Array(42) = InvaderThree9
        Array(43) = InvaderThree10
        Array(44) = InvaderFour0
        Array(45) = InvaderFour1
        Array(46) = InvaderFour2
        Array(47) = InvaderFour3
        Array(48) = InvaderFour4
        Array(49) = InvaderFour5
        Array(50) = InvaderFour6
        Array(51) = InvaderFour7
        Array(52) = InvaderFour8
        Array(53) = InvaderFour9
        Array(54) = InvaderFour10
    End Sub

    Private Sub tmrInvaderMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInvaderMovement.Tick
        'Controlls invasion heartbeat sound
        varMusicBeat += 1
        If varMusicBeat = 5 Then
            varMusicBeat = 1
        End If
        If varMusicBeat = 4 Then
            My.Computer.Audio.Play(SpaceInvaders.My.Resources.fastinvader4, AudioPlayMode.Background)
        ElseIf varMusicBeat = 3 Then
            My.Computer.Audio.Play(SpaceInvaders.My.Resources.fastinvader3, AudioPlayMode.Background)
        ElseIf varMusicBeat = 2 Then
            My.Computer.Audio.Play(SpaceInvaders.My.Resources.fastinvader2, AudioPlayMode.Background)
        ElseIf varMusicBeat = 1 Then
            My.Computer.Audio.Play(SpaceInvaders.My.Resources.fastinvader1, AudioPlayMode.Background)
        End If



        'Moves invasion array left/right
        For n = 0 To 54
            If Array(n).Width <> 0 Then

                'moves invaders
                Array(n).Left += varInvaderDirection

                'checks if they hit a wall
                If Array(n).Right > Me.Width - 10 Then
                    varInvaderDirection = -7
                    For v = 0 To 54
                        Array(v).Top += 30
                        varOnRowCounter += (1 / 55)
                    Next
                ElseIf Array(n).Left < 10 Then
                    varInvaderDirection = 7
                    For v = 0 To 54
                        Array(v).Top += 30
                        varOnRowCounter += (1 / 55)
                    Next
                End If

                'checks for loss by being crushed
                If varOnRowCounter.ToString("n") > 7 Then
                    lblGameOver.Visible = True
                End If
                Array(n).SetBounds(Array(n).Left, Array(n).Top, Array(n).Width, Array(n).Height)
            End If
        Next

    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Z Then
            varPlayerGoLeft = True
            tmrPlayerMovement.Enabled = True
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.X Then
            varPlayerGoLeft = False
            tmrPlayerMovement.Enabled = True
        End If


        If e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Space Then
            If varIsPaused = False And tmrBullet.Enabled = False Then
                tmrBullet.Enabled = True
                My.Computer.Audio.Play(SpaceInvaders.My.Resources.shoot, AudioPlayMode.Background)
            End If
        End If
        If e.KeyCode = Keys.P Then
            If varIsPaused = False Then
                varIsPaused = True
                tmrBullet.Enabled = False
                tmrEnemyBullet.Enabled = False
                tmrInvaderMovement.Enabled = False
                tmrPlayerMovement.Enabled = False
                tmrTimerTick.Enabled = False
            ElseIf varIsPaused = True Then
                tmrBullet.Enabled = True
                tmrEnemyBullet.Enabled = True
                tmrInvaderMovement.Enabled = True
                tmrPlayerMovement.Enabled = True
                tmrTimerTick.Enabled = True
                varIsPaused = False
            End If
        End If
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Z Then
            tmrPlayerMovement.Enabled = False
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.X Then
            tmrPlayerMovement.Enabled = False
        End If
    End Sub

    Private Sub tmrPlayerMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerMovement.Tick
        If varPlayerGoLeft = True And varIsPaused = False And Player1.Left > 10 Then
            Player1.Left -= 7
        ElseIf varPlayerGoLeft = False And varIsPaused = False And Player1.Right < Me.Width - 10 Then
            Player1.Left += 7
        End If
        If tmrBullet.Enabled = False Then
            Bullet.Left = Player1.Left + 28
        End If
    End Sub

    Private Sub tmrBullet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBullet.Tick
        With Bullet
            If .Top > 0 Then
                .Top -= 7
            Else
                .SetBounds(Player1.Left + 20, Player1.Top, .Width, .Height)
                tmrBullet.Enabled = False
            End If

            For n = 0 To 54
                If .Bounds.IntersectsWith(Array(n).Bounds) Then
                    varRowIsAlive = False
                    Array(n).Width = 0
                    Array(n).Top = 800

                    My.Computer.Audio.Play(SpaceInvaders.My.Resources.invaderkilled, AudioPlayMode.Background)

                    varInvadersLeft -= 1
                    tmrInvaderMovement.Interval = (varInvadersLeft * 5 + 175) + (6 - varOnRowCounter) * 10

                    'This is what happens when you win
                    If varInvadersLeft = 0 Then
                        varLives += 1

                        'Updates lives when you gain a life
                        For o = 2 To 6
                            If varLives = o Then
                                Lives(o).Visible = True
                            End If
                        Next
                        If varLives > 6 Then
                            For o = 1 To 6
                                Lives(o).Visible = False
                            Next
                            lblLives.Text = varLives
                            lblLives.Visible = True
                        End If

                        varWinCounter += 1
                        If varWinCounter = 5 Then
                            varWinCounter = 0
                        End If
                        varScore += 500
                        resetInvaders()
                    End If

                    If n < 11 Then
                        varScore += 50
                    ElseIf n > 10 And n < 33 Then
                        varScore += 20
                    ElseIf n > 32 And n < 55 Then
                        varScore += 10
                    End If
                    lblScore.Text = varScore
                    If varScore > Integer.Parse(lblHighScore.Text) Then
                        lblHighScore.Text = varScore
                    End If
                    .SetBounds(Player1.Left + 20, Player1.Top, .Width, .Height)
                    tmrBullet.Enabled = False
                End If
            Next

        End With
    End Sub

    Private Sub tmrEnemyBullet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyBullet.Tick
        For P = 0 To 2
            If EnemyBulletGo(P) = True Then
                With EnemyBullet(P)
                    .Top += 10
                    .SetBounds(.Left, .Top, .Width, .Height)
                    Player1.SetBounds(Player1.Left, Player1.Top, Player1.Width, Player1.Height)
                    If .Bounds.IntersectsWith(Player1.Bounds) Then
                        varLives -= 1
                        My.Computer.Audio.Play(SpaceInvaders.My.Resources.explosion, AudioPlayMode.Background)

                        'Updates lives when you loose a life
                        For n = 0 To 5
                            If varLives = n Then
                                Lives(n + 1).Visible = False
                            End If
                        Next
                        If varLives = 0 Then
                            lblGameOver.Visible = True
                        ElseIf varLives = 6 Then
                            lblLives.Visible = False
                            For o = 1 To 6
                                Lives(o).Visible = True
                            Next
                        End If
                        lblLives.Text = varLives


                        .Top = Me.Height + 1
                    End If

                    If .Top > Me.Height Then
                        .Visible = False
                        .Top = 100
                        TimeCounter(P) = 0
                        RandomEnemyBulletTime(P) = Rnd() * 50 + 25
                        TimeCounter(P) = 0
                        EnemyBulletGo(P) = False
                    End If
                End With
            End If
        Next
    End Sub

    Private Sub tmrTimerTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimerTick.Tick
        For P = 0 To 2
            If TimeCounter(P) >= 0 Then
                TimeCounter(P) += 1
            End If
            If TimeCounter(P) > RandomEnemyBulletTime(P) Then

                'Checks find the lowest row
                Do Until varRowIsAlive = True
                    For n = varRowStart To varRowStop
                        If Array(n).Width <> 0 Then
                            varRowIsAlive = True
                        End If
                    Next
                    If varRowIsAlive = False Then
                        varRowStart -= 11
                        varRowStop -= 11
                    End If
                Loop

                Dim varR As Integer = Rnd() * 10 + varRowStart
                varColumnIsDead = False
                Do Until Array(varR).Width <> 0 Or varColumnIsDead = True
                    varR -= 11
                    If varR < 0 Then
                        varR = 0
                        varColumnIsDead = True
                    End If
                Loop
                If varColumnIsDead = False Then
                    EnemyBullet(P).SetBounds(Array(varR).Left + 14, Array(varR).Top + 15, EnemyBullet(P).Width, EnemyBullet(P).Height)
                    EnemyBulletGo(P) = True
                    EnemyBullet(P).Visible = True
                    TimeCounter(P) = -1
                End If
            End If
        Next
    End Sub

    Private Sub lblGameOver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGameOver.Click
        resetInvaders()
    End Sub

    Private Function resetInvaders()
        For r = 0 To 54
            If r < 11 Then
                Array(r).SetBounds(((r * 46) + 152), 1 * 40 + 40 * varWinCounter, 36, 26)
            ElseIf r > 10 And r < 22 Then
                Array(r).SetBounds((((r - 11) * 46) + 152), 2 * 40 + 40 * varWinCounter, 36, 26)
            ElseIf r > 21 And r < 33 Then
                Array(r).SetBounds((((r - 22) * 46) + 152), 3 * 40 + 40 * varWinCounter, 36, 26)
            ElseIf r > 32 And r < 44 Then
                Array(r).SetBounds((((r - 33) * 46) + 152), 4 * 40 + 40 * varWinCounter, 36, 26)
            ElseIf r > 43 Then
                Array(r).SetBounds((((r - 44) * 46) + 152), 5 * 40 + 40 * varWinCounter, 36, 26)
            End If
        Next
        'End If
        Player1.Left = 377
        For n = 0 To 2
            EnemyBullet(n).Visible = False
            EnemyBulletGo(n) = False
            TimeCounter(n) = -1
        Next
        Bullet.Left = 397
        Bullet.Top = 465
        tmrInvaderMovement.Interval = 450
        tmrBullet.Enabled = False
        varInvadersLeft = 55
        varInvaderDirection = 7
        varOnRowCounter = varWinCounter
        lblGameOver.Visible = False

    End Function

    Private Sub tmrDebug_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDebug.Tick
        lblDebug.Text = ""
    End Sub
End Class