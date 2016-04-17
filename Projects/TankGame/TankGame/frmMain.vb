Public Class frmMain

    Private IwantTobeDone As Int16

    'Sub tmrPlayerMovement
    Private varPlayerDirection As String
    Private varPlayerHeading As String

    Private keyLeftDown As Int16
    Private keyRightDown As Int16
    Private keyUpDown As Int16
    Private keyDownDown As Int16

    'Constants
    Public varPlayerSpeed As Integer = 10
    Public varEnemySpeed As Integer = 1

    Public varPlayerBulletSpeed As Integer = 5

    'Game over
    Dim varGameWinState As Boolean
    Dim varGameOverString As String

    'Sub tmrBullet
    Private varPlayerFireBullet As Boolean
    Private varPlayerBulletHasMomentum As Boolean
    Private varPlayerBulletDirection As String

    Private varEnemyFireBullet As Boolean
    Private varEnemyBulletHasMomentum As Boolean

    'Sub tmrEnemyMovement
    Dim Xdistance As Integer
    Dim Ydistance As Integer
    Dim Xdirection As Integer
    Dim Ydirection As Integer

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Sets player movement direction
        If e.KeyCode = Keys.Up Then
            keyUpDown = 1
        End If
        If e.KeyCode = Keys.Right Then
            keyRightDown = 1
        End If
        If e.KeyCode = Keys.Down Then
            keyDownDown = 1
        End If
        If e.KeyCode = Keys.Left Then
            keyLeftDown = 1
        End If

        'Fires bullet
        If e.KeyCode = Keys.Space And varPlayerBulletHasMomentum = False Then
            varPlayerFireBullet = True
        End If
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Up Then
            keyUpDown = 0
        End If
        If e.KeyCode = Keys.Right Then
            keyRightDown = 0
        End If

        If e.KeyCode = Keys.Down Then
            keyDownDown = 0
        End If

        If e.KeyCode = Keys.Left Then
            keyLeftDown = 0
        End If
    End Sub

    Private Sub tmrPlayerMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerMovement.Tick

        'Moves player, sets picture, and sets heading based on PlayerDirection
        If varPlayerDirection = "Left" And picPlayer.Left >= 0 Then
            picPlayer.Image = My.Resources.picPlayerWest
            picPlayer.Left -= varPlayerSpeed
            varPlayerHeading = varPlayerDirection
        ElseIf varPlayerDirection = "UpLeft" And picPlayer.Left >= 0 And picPlayer.Top >= 0 Then
            picPlayer.Image = My.Resources.picPlayerNorthWest
            picPlayer.Left -= varPlayerSpeed
            picPlayer.Top -= varPlayerSpeed
        ElseIf varPlayerDirection = "Right" And picPlayer.Right <= Me.Width Then
            picPlayer.Image = My.Resources.picPlayerEast
            picPlayer.Left += varPlayerSpeed
            varPlayerHeading = varPlayerDirection
        ElseIf varPlayerDirection = "UpRight" And picPlayer.Right <= Me.Width And picPlayer.Top >= 0 Then
            picPlayer.Image = My.Resources.picPlayerNorthEast
            picPlayer.Left += varPlayerSpeed
            picPlayer.Top -= varPlayerSpeed
            varPlayerHeading = varPlayerDirection
        ElseIf varPlayerDirection = "Down" And picPlayer.Bottom <= Me.Height Then
            picPlayer.Image = My.Resources.picPlayerSouth
            picPlayer.Top += varPlayerSpeed
            varPlayerHeading = varPlayerDirection
        ElseIf varPlayerDirection = "DownLeft" And picPlayer.Left >= 0 And picPlayer.Top <= Me.Height Then
            picPlayer.Image = My.Resources.picPlayerSouthWest
            picPlayer.Left -= varPlayerSpeed
            picPlayer.Top += varPlayerSpeed
            varPlayerHeading = varPlayerDirection
        ElseIf varPlayerDirection = "Up" And picPlayer.Top >= 0 Then
            picPlayer.Image = My.Resources.picPlayerNorth
            picPlayer.Top -= varPlayerSpeed
            varPlayerHeading = varPlayerDirection
        ElseIf varPlayerDirection = "DownRight" And picPlayer.Right <= Me.Width And picPlayer.Top <= Me.Height Then
            picPlayer.Image = My.Resources.picPlayerSouthEast
            picPlayer.Left += varPlayerSpeed
            picPlayer.Top += varPlayerSpeed
            varPlayerHeading = varPlayerDirection
        End If

        picPlayer.SetBounds(picPlayer.Left, picPlayer.Top, picPlayer.Width, picPlayer.Height)

    End Sub

    Private Sub tmrBullet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBullet.Tick

        If varPlayerFireBullet = True Then
            'Declares the bullet is moving
            varPlayerBulletHasMomentum = True
            'sets which direction the bullet will be moving
            varPlayerBulletDirection = varPlayerHeading
            'sets bullet launch from position
            picPlayerBullet.Left = picPlayer.Left + 48
            picPlayerBullet.Top = picPlayer.Top + 48
            'dosn't allow these variables to be set until True
            varPlayerFireBullet = False
        End If

        'Moves PlayerBullet based on BulletDirection
        If varPlayerBulletDirection = "Up" Then
            picPlayerBullet.Top -= varPlayerBulletSpeed
            IwantTobeDone += 1
        ElseIf varPlayerBulletDirection = "Right" Then
            picPlayerBullet.Left += varPlayerBulletSpeed
            IwantTobeDone += 1
        ElseIf varPlayerBulletDirection = "Down" Then
            picPlayerBullet.Top += varPlayerBulletSpeed
            IwantTobeDone += 1
        ElseIf varPlayerBulletDirection = "Left" Then
            picPlayerBullet.Left -= varPlayerBulletSpeed
            IwantTobeDone += 1
        End If

        picPlayerBullet.SetBounds(picPlayerBullet.Left, picPlayerBullet.Top, picPlayerBullet.Width, picPlayerBullet.Height)

        'Checks for game over
        If picPlayerBullet.Bounds.IntersectsWith(picPlayer.Bounds) Then
            varGameOverString = "Nice... You kiled yourself"
            gameOver()
        ElseIf picPlayerBullet.Bounds.IntersectsWith(picEnemy.Bounds) Then
            varGameOverString = "You killed all the enemy tanks, go to the next level"
            varGameWinState = True
            gameOver()
        End If

        'Checks for other bullet collision and allows another shot if collision
        If picPlayerBullet.Top <= 0 Or picPlayerBullet.Right >= Me.Width Or picPlayerBullet.Bottom >= Me.Height Or _
            picPlayerBullet.Left <= 0 Or picEnemyBullet.Bounds.IntersectsWith(picPlayer.Bounds) Or _
            picEnemyBullet.Bounds.IntersectsWith(picEnemy.Bounds) Then
            varPlayerBulletHasMomentum = False
        End If



    End Sub

    Private Sub gameOver()
        If IwantTobeDone > 16 Then
            'THis is my KILL CODE, I don't know what I should do for a kill, I just want to go to snack now... sorry it's lame, pong will be cool
            MessageBox.Show(varGameOverString)
        End If
    End Sub

    Private Sub tmrDebug_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDebug.Tick
        'DEBUGGING STATS
        lblDebug.Text = "varPlayerDirection = " & varPlayerDirection & vbNewLine & _
            "varPlayerHeading = " & varPlayerHeading & vbNewLine & vbNewLine & _
            "XDistance = " & Xdistance & vbNewLine & _
            "YDistance = " & Ydistance & vbNewLine & _
            "Xdirection = " & Xdirection & vbNewLine & _
            "YDirection = " & Ydirection & vbNewLine & vbNewLine & _
            "varPlayerBulletDirection = " & varPlayerBulletDirection & vbNewLine & _
            keyLeftDown + 1
    End Sub

    Private Sub tmrEnemyMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyMovement.Tick
        'Calculates 8 distances
        Dim distLeft As Integer = picPlayer.Left - picEnemy.Right
        Dim distRight As Integer = picEnemy.Left - picPlayer.Right
        Dim distUp As Integer = picPlayer.Top - picEnemy.Bottom
        Dim distDown As Integer = picEnemy.Bottom - picPlayer.Top
        Dim distUpLeft As Integer = ((distLeft ^ 2) + (distUp ^ 2)) ^ 0.5
        Dim distUpRight As Integer = ((distRight ^ 2) + (distUp ^ 2)) ^ 0.5
        Dim distDownLeft As Integer = ((distLeft ^ 2) + (distDown)) ^ 0.5
        Dim distDownRight As Integer = ((distRight ^ 2) + (distDown)) ^ 0.5

        'moves player and sets picture depending on greatest distance
        If distLeft > distRight And distLeft > distUp And distLeft > distDown And distLeft > distUpLeft And distLeft > distUpRight And distLeft > distDownLeft And distLeft > distDownRight Then
            picEnemy.Left -= varEnemySpeed
            picEnemy.Image = My.Resources.picEnemyWest
        ElseIf distRight > distLeft And distRight > distUp And distRight > distDown And distRight > distUpLeft And distRight > distUpRight And distRight > distDownLeft And distRight > distDownRight Then
            picEnemy.Left += varEnemySpeed
            picEnemy.Image = My.Resources.picEnemyEast
        ElseIf distUp > distRight And distUp > distLeft And distUp > distDown And distUp > distUpLeft And distUp > distUpRight And distUp > distDownLeft And distUp > distDownRight Then
            picEnemy.Top -= varEnemySpeed
            picEnemy.Image = My.Resources.picEnemyNorth
        ElseIf distDown > distRight And distDown > distUp And distDown > distLeft And distDown > distUpLeft And distDown > distUpRight And distDown > distDownLeft And distDown > distDownRight Then
            picEnemy.Top += varEnemySpeed
            picEnemy.Image = My.Resources.picEnemySouth
        ElseIf distUpLeft > distRight And distUpLeft > distUp And distUpLeft > distDown And distUpLeft > distLeft And distUpLeft > distUpRight And distUpLeft > distDownLeft And distUpLeft > distDownRight Then
            picEnemy.Left -= varEnemySpeed
            picEnemy.Top -= varEnemySpeed
            picEnemy.Image = My.Resources.picEnemyNorthWest
        ElseIf distUpRight > distRight And distUpRight > distUp And distUpRight > distDown And distUpRight > distUpLeft And distUpRight > distLeft And distUpRight > distDownLeft And distUpRight > distDownRight Then
            picEnemy.Left += varEnemySpeed
            picEnemy.Top -= varEnemySpeed
            picEnemy.Image = My.Resources.picEnemyNorthEast
        ElseIf distDownLeft > distRight And distDownLeft > distUp And distDownLeft > distDown And distDownLeft > distUpLeft And distDownLeft > distUpRight And distDownLeft > distLeft And distDownLeft > distDownRight Then
            picEnemy.Left -= varEnemySpeed
            picEnemy.Top += varEnemySpeed
            picEnemy.Image = My.Resources.picEnemySouthWest
        ElseIf distDownRight > distRight And distDownRight > distUp And distDownRight > distDown And distDownRight > distUpLeft And distDownRight > distUpRight And distDownRight > distDownLeft And distDownRight > distLeft Then
            picEnemy.Left += varEnemySpeed
            picEnemy.Top += varEnemySpeed
            picEnemy.Image = My.Resources.picEnemySouthEast
        End If

        picEnemy.SetBounds(picEnemy.Left, picEnemy.Top, picEnemy.Width, picEnemy.Height)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picEnemy.Left = Rnd() * (Me.Width - picEnemy.Width)
        picEnemy.Top = Rnd() * (Me.Height - picEnemy.Height)
    End Sub
End Class
