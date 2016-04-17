'Josh Gibbs
'Period 2
'May 31 2011 (Not Draft)
'Blocks (Final Project)
'frmGameplay v6.5.2035 r47

'This is my first time experimenting with Private Subs. 
'I am using them for almost every action, so this Class 
'is littered with them, but it makes it easier to code.
'
'       ____                            _ _____ _      _ _
' _   _|  _ \ __ _ _   _ _ __ ___   ___(_)  ___(_)_  _(_) |_
'| | | | |_) / _` | | | | '_ ` _ \ / _ \ | |_  | \ \/ / | __|
'| |_| |  __/ (_| | |_| | | | | | |  __/ |  _| | |>  <| | |_
' \__,_|_|   \__,_|\__, |_| |_| |_|\___|_|_|   |_/_/\_\_|\__|
'                  |___/
'
'To-Do
'Need better acceleration formula
'differend difficulties need different blue speeds

Public Class frmGameplay

'Array for player invincibility images
    Public aryCharacterInvincibilityImages(36) As Image

'KeyPress variables (True = Down)
Private varKeyUp As Boolean
Private varKeyDown As Boolean
Private varKeyLeft As Boolean
Private varKeyRight As Boolean

'Acceleration variables
Private varPlayerUpAcceleration As Decimal
Private varPlayerDownAcceleration As Decimal
Private varPlayerLeftAcceleration As Decimal
Private varPlayerRightAcceleration As Decimal
Private varPlayerAccelerationInterval As Decimal = 0.05

'Form boundries (Used mostly for adding items later)
Public varTopBounds As Int16 = 60
Public varBottomBounds As Int16 = 400
Public varLeftBounds As Int16 = 0
Public varRightBounds As Int16 = 500

    'Pause/Play variables
    Private varGameIsPaused As Boolean
    Private varInvincibilityTimerWasEnabled As Boolean

    'Incincibility Variables
    Private varInvincibilityImage As Int16

    'Debug variables
    Private varInDebug As Boolean

    'Unlock animation variables
    Private varUnlockAnimationWaitTime As Int16
    Private varUnlockAnimationDirection As Int16 = 1
    Private varUnlockAnimationWaiting As Boolean

'Player Properties
Public varPlayerSpeed As Int16
    Private varPlayerVerticalSafezone As Int16 = 100
    Private varPlayerHorizontalSafezone As Int16 = 100

'Blue block variables
    Public blueBlocks(0) As PictureBox
    Public varBlueBlocksOnScreen As Int32
Private blueBlocksVariables(0) As blueBlock
Private varBlueBlockEasySpeed As Integer = 1
Private varBlueBlockMediumMaxSpeed As Integer = 5
Private varBlueBlockMediumMinSpeed As Integer = 2
Private varBlueBlockHardMaxSpeed As Integer = 8
Private varBlueBlockHardMinSpeed As Integer = 5


    Public varGameDifficulty As String
    Private varGameCurrentScore As Int16

    'Used as blueBlockVariables
    Structure blueBlock
        Public Speed As Int16
        Public Direction As Int16
        Public MovingVertical As Boolean
    End Structure


    Dim imgThumb As Image = Nothing
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets up the first blue block
        blueBlocks(0) = picBlueBlock
        spawnBlueBlock()

        Randomize()

        'setting up background image
        Me.BackgroundImage = Nothing
        Dim image As Image = Nothing

        Try
            ' Check if textbox has a value

            'image has to be in the debug folder
            image = image.FromFile("picBackground.png")
            ' Check if image exists
            If Not image Is Nothing Then
                imgThumb = image.GetThumbnailImage(500, 400, Nothing, New IntPtr())
                Me.Refresh()
            End If
        Catch
            MessageBox.Show("An error occured. The picBackground.png image is missing.")
        End Try
    End Sub

    'sets background image
    Private Sub frmGameplay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        If Not imgThumb Is Nothing Then
            With e.Graphics
                'draws image at location 0, 0
                .DrawImage(imgThumb, 0, 0, imgThumb.Width, imgThumb.Height)
            End With
        End If
    End Sub


    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Debug key
        If e.KeyCode = Keys.F Then
            If varInDebug = False Then
                varInDebug = True
                tmrInvincibilityAnimation.Enabled = True
            Else
                varInDebug = False
                pgbInvincible.Value = 1
            End If
        End If

        'Standard form for UDLR movement start (Keys set variables for movement)
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            varKeyUp = True
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            varKeyDown = True
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            varKeyLeft = True
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            varKeyRight = True
        End If

    End Sub


    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        'Standard form for UDLR movement stop (Keys set variables for movement)
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            varKeyUp = False
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            varKeyDown = False
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            varKeyLeft = False
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            varKeyRight = False
        End If
    End Sub


    Private Sub tmrPlayerMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerMovement.Tick

        'Uses a modified version of standard UDLR movment for object bounds to incorperate acceleration and deceleration
        If picPlayer.Top > varTopBounds Then
            If varKeyUp Then
                If varPlayerUpAcceleration < 1 Then
                    varPlayerUpAcceleration += varPlayerAccelerationInterval
                End If
            Else
                If varPlayerUpAcceleration > 0 Then
                    varPlayerUpAcceleration -= varPlayerAccelerationInterval
                End If
            End If
            picPlayer.Top -= varPlayerUpAcceleration * varPlayerSpeed
        End If

        If picPlayer.Bottom < varBottomBounds Then
            If varKeyDown Then
                If varPlayerDownAcceleration < 1 Then
                    varPlayerDownAcceleration += varPlayerAccelerationInterval
                End If
            Else
                If varPlayerDownAcceleration > 0 Then
                    varPlayerDownAcceleration -= varPlayerAccelerationInterval
                End If
            End If
            picPlayer.Top += varPlayerDownAcceleration * varPlayerSpeed
        End If

        If picPlayer.Left > varLeftBounds Then
            If varKeyLeft Then
                If varPlayerLeftAcceleration < 1 Then
                    varPlayerLeftAcceleration += varPlayerAccelerationInterval
                End If
            Else
                If varPlayerLeftAcceleration > 0 Then
                    varPlayerLeftAcceleration -= varPlayerAccelerationInterval
                End If
            End If
            picPlayer.Left -= varPlayerLeftAcceleration * varPlayerSpeed
        End If

        If picPlayer.Right < varRightBounds Then
            If varKeyRight Then
                If varPlayerRightAcceleration < 1 Then
                    varPlayerRightAcceleration += varPlayerAccelerationInterval
                End If
            Else
                If varPlayerRightAcceleration > 0 Then
                    varPlayerRightAcceleration -= varPlayerAccelerationInterval
                End If
            End If
            picPlayer.Left += varPlayerRightAcceleration * varPlayerSpeed
        End If

    End Sub


    Private Sub setObjectBounds()
        'Sub for setting the bounds of all moving objects
        picPlayer.SetBounds(picPlayer.Left, picPlayer.Top, picPlayer.Width, picPlayer.Height)
        For i = 0 To varBlueBlocksOnScreen
            blueBlocks(i).SetBounds(blueBlocks(i).Left, blueBlocks(i).Top, blueBlocks(i).Width, blueBlocks(i).Height)
        Next
        picPlayerSafezone.SetBounds((picPlayer.Left - varPlayerHorizontalSafezone / 2), (picPlayer.Top - varPlayerVerticalSafezone / 2), (picPlayer.Width + varPlayerHorizontalSafezone), (picPlayer.Height + varPlayerVerticalSafezone))
    End Sub


    Private Sub tmrIntersectChecks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIntersectChecks.Tick
        'Needs to set object bounds before they can be checked
        setObjectBounds()

        'checks for intersections with the blue blocks
        For i = 0 To varBlueBlocksOnScreen
            If picPlayer.Bounds.IntersectsWith(blueBlocks(i).Bounds) Then
                If tmrInvincibilityAnimation.Enabled Then
                    'removes blue block
                    Me.Controls.Remove(blueBlocks(i))
                    blueBlocksVariables(i).Speed = 0
                    blueBlocks(i).Top = Me.Height + 100
                Else
                    gameOver()
                End If
            End If
        Next

        'checks for intersections with green blocs, gotGreenBlock is called if True
        If picPlayer.Bounds.IntersectsWith(picGreenBlock.Bounds) Then
            gotGreenBlock()
        End If

    End Sub


    'perpares the frmGameOver when called
    Private Sub gameOver()

        'disables timers except for tmrBlueBlockMovement
        tmrPlayerMovement.Enabled = False
        tmrIntersectChecks.Enabled = False
        tmrInvincibilityAnimation.Enabled = False

        'sets score
        frmGameOver.lblScore.Text = varGameCurrentScore

        'shows the game over form and the transparant layer
        frmTransparantLayer.Show()
        frmTransparantLayer.Location = Me.Location
        frmGameOver.Show()
        frmGameOver.Left = Me.Left + Me.Width / 2 - frmGameOver.Width / 2
        frmGameOver.Top = Me.Top + Me.Height / 2 - frmGameOver.Height / 2
    End Sub


    'Calls actions for getting the green block
    Private Sub gotGreenBlock()
        spawnBlueBlock()
        moveGreenBlock()
        addToScore()
        invincibilityCheck()
    End Sub


    'Adds up the score progress bar
    Private Sub invincibilityCheck()
        pgbScore.Value += 1
        If pgbScore.Value = pgbScore.Maximum Then
            pgbInvincible.Visible = True
            tmrInvincibilityAnimation.Enabled = True
            pgbScore.Value = 0
        End If
    End Sub


    'This is where all the invincibility animations happen
    Private Sub tmrInvincibilityAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInvincibilityAnimation.Tick
        picPlayer.Image = aryCharacterInvincibilityImages(varInvincibilityImage)

        varInvincibilityImage += 1
        If varInvincibilityImage >= 37 Then
            varInvincibilityImage = 0
        End If

        'animates the progress bad (if not in debug)
        If varInDebug = False Then
            pgbInvincible.Value -= 1
            If pgbInvincible.Value = 0 Then
                picPlayer.Image = frmCharactersList.player(frmCharactersList.varSelectedCharacter - 1)
                pgbInvincible.Visible = False
                tmrInvincibilityAnimation.Enabled = False
                pgbInvincible.Value = pgbInvincible.Maximum
            End If
        End If
    End Sub

    'This Sub adds a point to the score and checks if you have beat the highscore for that difficulty. Also checks for unlocks.
    Private Sub addToScore()
        varGameCurrentScore += 1
        If varGameDifficulty = "Easy" And varGameCurrentScore > frmStartMenu.varGameEasyHighScore Then
            'updates scores
            frmStartMenu.varGameEasyHighScore = varGameCurrentScore
            lblHighScore.Text = frmStartMenu.varGameEasyHighScore
            frmCharactersList.lblEasyHighscore.Text = frmStartMenu.varGameEasyHighScore

            'Checks for unlocks
            If varGameCurrentScore = 5 Then
                frmCharactersList.picPlayers02.Image = My.Resources.players2
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 10 Then
                frmCharactersList.picPlayers03.Image = My.Resources.players3
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 15 Then
                frmCharactersList.picPlayers04.Image = My.Resources.players4
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 20 Then
                frmCharactersList.picPlayers05.Image = My.Resources.players5
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 25 Then
                frmCharactersList.picPlayers06.Image = My.Resources.players6
                'tmrUnlockAnimation.Enabled = True
                frmStartMenu.btnPlayMedium.Enabled = True
                frmStartMenu.btnPlayMedium.Image = My.Resources.btnMedium
                'Shows next row of characters
                frmCharactersList.picPlayers07.Visible = True
                frmCharactersList.picPlayers08.Visible = True
                frmCharactersList.picPlayers09.Visible = True
                frmCharactersList.picPlayers10.Visible = True
                frmCharactersList.picPlayers11.Visible = True
                frmCharactersList.picPlayers12.Visible = True
            End If

        ElseIf varGameDifficulty = "Medium" And varGameCurrentScore > frmStartMenu.varGameMediumHighScore Then
            'updates scores
            frmStartMenu.varGameMediumHighScore = varGameCurrentScore
            lblHighScore.Text = frmStartMenu.varGameMediumHighScore
            frmCharactersList.lblMediumHighscore.Text = frmStartMenu.varGameMediumHighScore

            'Checks for unlocks
            If varGameCurrentScore = 5 Then
                frmCharactersList.picPlayers08.Image = My.Resources.players8
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 10 Then
                frmCharactersList.picPlayers09.Image = My.Resources.players9
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 15 Then
                frmCharactersList.picPlayers10.Image = My.Resources.players10
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 20 Then
                frmCharactersList.picPlayers11.Image = My.Resources.players11
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 25 Then
                frmCharactersList.picPlayers12.Image = My.Resources.players12
                'tmrUnlockAnimation.Enabled = True
                frmStartMenu.btnPlayHard.Enabled = True
                frmStartMenu.btnPlayHard.Image = My.Resources.btnHard
                'Shows next row of characters
                frmCharactersList.picPlayers13.Visible = True
                frmCharactersList.picPlayers14.Visible = True
                frmCharactersList.picPlayers15.Visible = True
                frmCharactersList.picPlayers16.Visible = True
                frmCharactersList.picPlayers17.Visible = True
                frmCharactersList.picPlayers18.Visible = True
            End If

        ElseIf varGameDifficulty = "Hard" And varGameCurrentScore > frmStartMenu.varGameHardHighScore Then
            'updates scores
            frmStartMenu.varGameHardHighScore = varGameCurrentScore
            lblHighScore.Text = frmStartMenu.varGameHardHighScore
            frmCharactersList.lblHardHighscore.Text = frmStartMenu.varGameHardHighScore

            'Checks for unlocks
            If varGameCurrentScore = 5 Then
                frmCharactersList.picPlayers14.Image = My.Resources.players14
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 10 Then
                frmCharactersList.picPlayers15.Image = My.Resources.players15
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 15 Then
                frmCharactersList.picPlayers16.Image = My.Resources.players16
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 20 Then
                frmCharactersList.picPlayers17.Image = My.Resources.players17
                'tmrUnlockAnimation.Enabled = True
            ElseIf varGameCurrentScore = 25 Then
                frmCharactersList.picPlayers18.Image = My.Resources.players18
                'tmrUnlockAnimation.Enabled = True
            End If

        End If
        lblCurrentScore.Text = varGameCurrentScore

    End Sub

    'This timer will never be called, didn't have enough time.
    Private Sub tmrUnlockAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUnlockAnimation.Tick
        If varUnlockAnimationWaiting = False Then
            lblUnlock.Top -= varUnlockAnimationDirection
            If lblUnlock.Top >= Me.Height - lblUnlock.Height Then
                varUnlockAnimationWaiting = True
            End If
        Else
            varUnlockAnimationWaitTime += 1
            If varUnlockAnimationWaitTime >= 100 Then
                varUnlockAnimationWaitTime = 0
                varUnlockAnimationWaiting = False
                lblUnlock.Top = Me.Height + lblUnlock.Height
                tmrUnlockAnimation.Enabled = False
            End If
        End If

    End Sub


    'This Sub moves the green block anywhere except the safezone
    Private Sub moveGreenBlock()
        'Sets the location of the cube to be anywhere except the safezone
        Dim check As Boolean
        Do Until check
            picGreenBlock.Top = (Rnd() * (varBottomBounds - blueBlocks(0).Height - varTopBounds)) + varTopBounds
            picGreenBlock.Left = (Rnd() * (varRightBounds - blueBlocks(0).Width - varLeftBounds)) + varLeftBounds

            'Checks if block spawned within player safezone
            setObjectBounds()
            If picGreenBlock.Bounds.IntersectsWith(picPlayerSafezone.Bounds) Then
                check = False
            Else
                check = True
            End If
        Loop
    End Sub


    'This Sub spawns a new blue block and sets the properties for it
    Private Sub spawnBlueBlock()
        'This sub spawn a new blue block when called
        varBlueBlocksOnScreen += 1
        ReDim Preserve blueBlocks(varBlueBlocksOnScreen)
        ReDim Preserve blueBlocksVariables(varBlueBlocksOnScreen)
        blueBlocks(varBlueBlocksOnScreen) = New PictureBox
        Me.Controls.Add(blueBlocks(varBlueBlocksOnScreen))

        blueBlocks(varBlueBlocksOnScreen).Width = blueBlocks(0).Width
        blueBlocks(varBlueBlocksOnScreen).Height = blueBlocks(0).Height
        blueBlocks(varBlueBlocksOnScreen).BackColor = blueBlocks(0).BackColor

        'Sets the location of the new cube to be anywhere except the safezone
        Dim check As Boolean
        Do Until check
            blueBlocks(varBlueBlocksOnScreen).Top = (Rnd() * (varBottomBounds - blueBlocks(0).Height)) + varTopBounds
            blueBlocks(varBlueBlocksOnScreen).Left = (Rnd() * (varRightBounds - blueBlocks(0).Width)) + varLeftBounds

            'Checks if block spawned within player safezone
            setObjectBounds()
            If blueBlocks(varBlueBlocksOnScreen).Bounds.IntersectsWith(picPlayerSafezone.Bounds) Then
                check = False
            Else
                check = True
            End If
        Loop

        'Sets direction (translates the rnd into -1 and 1s)
        Dim X As Int16 = Rnd() * 1
        If X = 0 Then : X = -1 : Else : X = 1 : End If
        blueBlocksVariables(varBlueBlocksOnScreen).Direction = X

        'Sets speed of blue blocks depending on the difficulty
        If varGameDifficulty = "Easy" Then
            blueBlocksVariables(varBlueBlocksOnScreen).Speed = varBlueBlockEasySpeed
        ElseIf varGameDifficulty = "Medium" Then
            blueBlocksVariables(varBlueBlocksOnScreen).Speed = (Rnd() * (varBlueBlockMediumMaxSpeed - varBlueBlockMediumMinSpeed) + varBlueBlockMediumMinSpeed)
        ElseIf varGameDifficulty = "Hard" Then
            blueBlocksVariables(varBlueBlocksOnScreen).Speed = (Rnd() * (varBlueBlockHardMaxSpeed - varBlueBlockHardMinSpeed) + varBlueBlockHardMinSpeed)
        End If

        'Sets the direction of the blue cubes (vertical or horizontal)
        Dim Y As Int16 = Rnd() * 1
        If Y = 0 Then
            blueBlocksVariables(varBlueBlocksOnScreen).MovingVertical = False
        Else
            blueBlocksVariables(varBlueBlocksOnScreen).MovingVertical = True
        End If

    End Sub


    'This Sub moves the blue blocks
    Private Sub tmrBlueBlockMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBlueBlockMovement.Tick

        For i = 0 To varBlueBlocksOnScreen

            'Moves the blocks vertical or horizontal. Uses Speed and Direction to move them
            If blueBlocksVariables(i).MovingVertical Then
                blueBlocks(i).Top += blueBlocksVariables(i).Speed * blueBlocksVariables(i).Direction
                'Changes the direction when past bounds

                If blueBlocks(i).Top <= varTopBounds Then
                    blueBlocksVariables(i).Direction = 1
                ElseIf blueBlocks(i).Bottom >= varBottomBounds Then
                    blueBlocksVariables(i).Direction = -1
                End If

            Else

                blueBlocks(i).Left += blueBlocksVariables(i).Speed * blueBlocksVariables(i).Direction

                If blueBlocks(i).Left <= varLeftBounds Then
                    blueBlocksVariables(i).Direction = 1
                ElseIf blueBlocks(i).Right >= varRightBounds Then
                    blueBlocksVariables(i).Direction = -1
                End If

            End If

        Next
        'After the objects have been moved the bounds are set
        setObjectBounds()
    End Sub

    'Disables timers if they were enabled, enables the timers if they were disabled (Play/Pause)
    Private Sub btnPlayPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayPause.Click
        If varGameIsPaused Then
            If varInvincibilityTimerWasEnabled Then
                tmrInvincibilityAnimation.Enabled = True
            End If
            tmrBlueBlockMovement.Enabled = True
            tmrIntersectChecks.Enabled = True
            tmrPlayerMovement.Enabled = True
            btnPlayPause.Image = My.Resources.picPauseUp
            varGameIsPaused = False
            frmTransparantLayer.Hide()
            frmTransparantLayer.SetBounds(Me.Left, Me.Top + varTopBounds, 400, 500)

        Else
            'Checks if the invincbility countdown was still moving
            If tmrInvincibilityAnimation.Enabled Then
                varInvincibilityTimerWasEnabled = True
                tmrInvincibilityAnimation.Enabled = False
            End If
            tmrBlueBlockMovement.Enabled = False
            tmrIntersectChecks.Enabled = False
            tmrPlayerMovement.Enabled = False
            btnPlayPause.Image = My.Resources.picPlayUp
            varGameIsPaused = True
            frmTransparantLayer.Show()
            frmTransparantLayer.SetBounds(Me.Left, Me.Top + varTopBounds, Me.Width, Me.Height - varTopBounds)
        End If
    End Sub

    'this animates the playpause button on mouse hover
    Private Sub btnPlayPause_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayPause.MouseHover
        If varGameIsPaused Then
            btnPlayPause.Image = My.Resources.picPlayDown
        Else
            btnPlayPause.Image = My.Resources.picPauseDown
        End If
    End Sub

    'this animates the playpause button on mouse leave
    Private Sub btnPlayPause_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayPause.MouseLeave
        If varGameIsPaused Then
            btnPlayPause.Image = My.Resources.picPlayUp
        Else
            btnPlayPause.Image = My.Resources.picPauseUp
        End If
    End Sub


    'kills the vshost
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    'animates the exit button on mouse hover
    Private Sub btnExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseHover
        btnExit.ForeColor = Color.DimGray
    End Sub

    'animates the exit button on mouse leave
    Private Sub btnExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave
        btnExit.ForeColor = Color.DarkGray
    End Sub


    'minimizes the window
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        If varGameIsPaused Then
            frmTransparantLayer.WindowState = FormWindowState.Minimized
        End If
    End Sub

    'animates the minimize button on mouse hover
    Private Sub btnMinimize_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseHover
        btnMinimize.ForeColor = Color.DimGray
    End Sub

    'animates the minimize button on mouse leave
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.ForeColor = Color.DarkGray
    End Sub


End Class