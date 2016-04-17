'Josh Gibbs
'23 December 2010
'Version 5.2

'TO-Fix
'try to put things in functions
'review all code
'new debugging stats
'on hard negative ones don't wrap
'left and right keys when pressed at same time don't work well

'To-Add
'Music/Sounds
'Diferent characters with speed, size, and invincibility
'Different highscores for every difficulty
'When you loose a form shoudld pop up tellingg you your score, then to frmStart
'Better gameplay GUI
'Better menu GUI/UI

'       ____                            _ _____ _      _ _
' _   _|  _ \ __ _ _   _ _ __ ___   ___(_)  ___(_)_  _(_) |_
'| | | | |_) / _` | | | | '_ ` _ \ / _ \ | |_  | \ \/ / | __|
'| |_| |  __/ (_| | |_| | | | | | |  __/ |  _| | |>  <| | |_
' \__,_|_|   \__,_|\__, |_| |_| |_|\___|_|_|   |_/_/\_\_|\__|
'                  |___/

Public Class frmGame

    'speed variables
    Private varXSpeed1 As Integer = 1
    Private varXSpeed2 As Integer = 1
    Private varXSpeed3 As Integer = 1
    Private varXSpeed4 As Integer = 1
    Private varXSpeed5 As Integer = 1
    Private varXSpeed6 As Integer = 1
    Private varXSpeed7 As Integer = 1
    Private varXSpeed8 As Integer = 1
    Private varXSpeed9 As Integer = 1
    Private varXSpeed10 As Integer = 1
    Private varXSpeed11 As Integer = 1
    Private varXSpeed12 As Integer = 1
    Private varXSpeed13 As Integer = 1
    Private varYSpeed1 As Integer = 1
    Private varYSpeed2 As Integer = 1
    Private varYSpeed3 As Integer = 1
    Private varYSpeed4 As Integer = 1
    Private varYSpeed5 As Integer = 1
    Private varYSpeed6 As Integer = 1
    Private varYSpeed7 As Integer = 1
    Private varYSpeed8 As Integer = 1
    Private varYSpeed9 As Integer = 1
    Private varYSpeed10 As Integer = 1
    Private varYSpeed11 As Integer = 1
    Private varYSpeed12 As Integer = 1

    Private varXSpeed1Neg As Boolean
    Private varXSpeed2Neg As Boolean = False
    Private varXSpeed3Neg As Boolean
    Private varXSpeed4Neg As Boolean = False
    Private varXSpeed5Neg As Boolean
    Private varXSpeed6Neg As Boolean = False
    Private varXSpeed7Neg As Boolean
    Private varXSpeed8Neg As Boolean = False
    Private varXSpeed9Neg As Boolean
    Private varXSpeed10Neg As Boolean = False
    Private varXSpeed11Neg As Boolean
    Private varXSpeed12Neg As Boolean = False
    Private varXSpeed13Neg As Boolean
    Private varYSpeed1Neg As Boolean = False
    Private varYSpeed2Neg As Boolean
    Private varYSpeed3Neg As Boolean = False
    Private varYSpeed4Neg As Boolean
    Private varYSpeed5Neg As Boolean = False
    Private varYSpeed6Neg As Boolean
    Private varYSpeed7Neg As Boolean = False
    Private varYSpeed8Neg As Boolean
    Private varYSpeed9Neg As Boolean = False
    Private varYSpeed10Neg As Boolean
    Private varYSpeed11Neg As Boolean = False
    Private varYSpeed12Neg As Boolean

    Private varUpStartMomentum As Boolean
    Private varDownStartMomentum As Boolean
    Private varLeftStartMomentum As Boolean
    Private varRightStartMomentum As Boolean
    Private varUpEndMomentum As Boolean
    Private varDownEndMomentum As Boolean
    Private varLeftEndMomentum As Boolean
    Private varRightEndMomentum As Boolean
    Private varUpSpeed As Decimal
    Private varDownSpeed As Decimal
    Private varLeftSpeed As Decimal
    Private varRightSpeed As Decimal


    'other variables
    Private varScore As Integer
    Private varInvincibele As Boolean
    Private varScoreAnimationStart As Boolean
    Private varPGBValue As Integer
    Private varPause As Boolean
    Private varSloMo As Boolean
    Public varTmrInterval As Integer = 1
    Private varTmrTickCounter As Integer
    Private varTotalScore As Integer
    Public varDifficulty As String = "Easy"

    Private Sub tmrTMP_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSloMo.Tick
        'Lets you slow down time
        If varSloMo = True And pgbSloMo.Value > 0 Then
            If pgbSloMo.Value >= 30 Then
                If varTmrInterval = 40 Then
                    tmrDangerMove.Interval = 100
                ElseIf varTmrInterval = 20 Then
                    tmrDangerMove.Interval = 50
                ElseIf varTmrInterval = 1 Then
                    tmrDangerMove.Interval = 20
                End If
            End If
            pgbSloMo.Value -= 1
        ElseIf varSloMo = False And pgbSloMo.Value < 100 Then
            tmrDangerMove.Interval = varTmrInterval
            pgbSloMo.Value += 1
        End If
        If pgbSloMo.Value = 100 Then
            tmrSloMo.Enabled = False
        End If
        If pgbSloMo.Value = 0 Then
            varSloMo = False
        End If
    End Sub

    Private Sub tmrMain_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPGBAnimations.Tick
        'Animates PGBInvincible
        If varInvincibele Then
            tmrPGBAnimations.Interval = 1
            pgbInvincible.Visible = True
            If pgbInvincible.Value > 0 Then
                pgbInvincible.Value -= 1

                varTmrTickCounter += 1

                If varTmrTickCounter = 1 Then
                    picPlayer.Image = My.Resources.picPlayerHue10
                ElseIf varTmrTickCounter = 2 Then
                    picPlayer.Image = My.Resources.picPlayerHue20
                ElseIf varTmrTickCounter = 3 Then
                    picPlayer.Image = My.Resources.picPlayerHue30
                ElseIf varTmrTickCounter = 4 Then
                    picPlayer.Image = My.Resources.picPlayerHue40
                ElseIf varTmrTickCounter = 5 Then
                    picPlayer.Image = My.Resources.picPlayerHue50
                ElseIf varTmrTickCounter = 6 Then
                    picPlayer.Image = My.Resources.picPlayerHue60
                ElseIf varTmrTickCounter = 7 Then
                    picPlayer.Image = My.Resources.picPlayerHue70
                ElseIf varTmrTickCounter = 8 Then
                    picPlayer.Image = My.Resources.picPlayerHue80
                ElseIf varTmrTickCounter = 9 Then
                    picPlayer.Image = My.Resources.picPlayerHue90
                ElseIf varTmrTickCounter = 10 Then
                    picPlayer.Image = My.Resources.picPlayerHue100
                ElseIf varTmrTickCounter = 11 Then
                    picPlayer.Image = My.Resources.picPlayerHue110
                ElseIf varTmrTickCounter = 12 Then
                    picPlayer.Image = My.Resources.picPlayerHue120
                ElseIf varTmrTickCounter = 13 Then
                    picPlayer.Image = My.Resources.picPlayerHue130
                ElseIf varTmrTickCounter = 14 Then
                    picPlayer.Image = My.Resources.picPlayerHue140
                ElseIf varTmrTickCounter = 15 Then
                    picPlayer.Image = My.Resources.picPlayerHue150
                ElseIf varTmrTickCounter = 16 Then
                    picPlayer.Image = My.Resources.picPlayerHue260
                ElseIf varTmrTickCounter = 17 Then
                    picPlayer.Image = My.Resources.picPlayerHue170
                ElseIf varTmrTickCounter = 18 Then
                    picPlayer.Image = My.Resources.picPlayerHue180
                ElseIf varTmrTickCounter = 19 Then
                    picPlayer.Image = My.Resources.picPlayerHue190
                ElseIf varTmrTickCounter = 21 Then
                    picPlayer.Image = My.Resources.picPlayerHue200
                ElseIf varTmrTickCounter = 22 Then
                    picPlayer.Image = My.Resources.picPlayerHue210
                ElseIf varTmrTickCounter = 23 Then
                    picPlayer.Image = My.Resources.picPlayerHue220
                ElseIf varTmrTickCounter = 24 Then
                    picPlayer.Image = My.Resources.picPlayerHue230
                ElseIf varTmrTickCounter = 25 Then
                    picPlayer.Image = My.Resources.picPlayerHue240
                ElseIf varTmrTickCounter = 26 Then
                    picPlayer.Image = My.Resources.picPlayerHue250
                ElseIf varTmrTickCounter = 27 Then
                    picPlayer.Image = My.Resources.picPlayerHue260
                ElseIf varTmrTickCounter = 28 Then
                    picPlayer.Image = My.Resources.picPlayerHue270
                ElseIf varTmrTickCounter = 29 Then
                    picPlayer.Image = My.Resources.picPlayerHue280
                ElseIf varTmrTickCounter = 30 Then
                    picPlayer.Image = My.Resources.picPlayerHue290
                ElseIf varTmrTickCounter = 31 Then
                    picPlayer.Image = My.Resources.picPlayerHue300
                ElseIf varTmrTickCounter = 32 Then
                    picPlayer.Image = My.Resources.picPlayerHue310
                ElseIf varTmrTickCounter = 33 Then
                    picPlayer.Image = My.Resources.picPlayerHue320
                ElseIf varTmrTickCounter = 34 Then
                    picPlayer.Image = My.Resources.picPlayerHue330
                ElseIf varTmrTickCounter = 35 Then
                    picPlayer.Image = My.Resources.picPlayerHue340
                ElseIf varTmrTickCounter = 36 Then
                    picPlayer.Image = My.Resources.picPlayerHue350
                ElseIf varTmrTickCounter = 37 Then
                    picPlayer.Image = My.Resources.picPlayerHue360
                ElseIf varTmrTickCounter = 38 Then
                    picPlayer.Image = My.Resources.picPlayerSQ
                    varTmrTickCounter = 0
                End If

            ElseIf pgbInvincible.Value = 0 Then
                pgbInvincible.Visible = False
                pgbInvincible.Value = 100
                varInvincibele = False
                picPlayer.Image = My.Resources.picPlayerSQ
                tmrPGBAnimations.Interval = 100
                varTmrTickCounter = 0
            End If
        End If

        'animates PGBScore
        If varScoreAnimationStart Then
            tmrPGBAnimations.Interval = 1
            pgbScore.Value += 1
            If pgbScore.Value >= varPGBValue Then
                varScoreAnimationStart = False
                tmrPGBAnimations.Interval = 100
                pgbScore.Value = varPGBValue
            End If
        End If

    End Sub

    Private Sub tmrCollisionCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCollisionCheck.Tick
        'Checks for collisions if invincible is false
        If varInvincibele = False Then
            If picPlayer.Bounds.IntersectsWith(picXDanger1.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger2.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger3.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger4.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger5.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger6.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger7.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger8.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger9.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger10.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger11.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger12.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picXDanger13.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger1.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger2.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger3.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger4.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger4.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger5.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger6.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger7.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger8.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger9.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger10.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger11.Bounds) Or _
                picPlayer.Bounds.IntersectsWith(picYDanger12.Bounds) Then

                frmTransparant.Visible = True
                frmTransparant.Location = Me.Location
                frmEnd.Visible = True
                frmEnd.Left = Me.Left + 148 : frmEnd.Top = Me.Top + 119

                If varDifficulty = "Easy" And Integer.Parse(frmPlayers.lblEasyHighscore.Text) < varScore Then
                    frmPlayers.lblEasyHighscore.Text = varScore
                ElseIf varDifficulty = "Medium" And Integer.Parse(frmPlayers.lblMediumHighscore.Text) < varScore Then
                    frmPlayers.lblMediumHighscore.Text = varScore
                ElseIf varDifficulty = "Hard" And Integer.Parse(frmPlayers.lblHardHighscore.Text) < varScore Then
                    frmPlayers.lblHardHighscore.Text = varScore
                End If

                frmEnd.lblScore.Text = varScore
                tmrCollisionCheck.Enabled = False
                tmrUp.Enabled = False
                tmrDown.Enabled = False
                tmrLeft.Enabled = False
                tmrRight.Enabled = False
                picPlayer.Left = 225 : picPlayer.Top = 195
                varTotalScore = 0
                varPGBValue = 0
            End If

            'makes you able to get dangers while invincible
        ElseIf varInvincibele Then
            If picPlayer.Bounds.IntersectsWith(picXDanger1.Bounds) Then
                picXDanger1.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger2.Bounds) Then
                picXDanger2.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger3.Bounds) Then
                picXDanger3.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger4.Bounds) Then
                picXDanger4.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger5.Bounds) Then
                picXDanger5.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger6.Bounds) Then
                picXDanger6.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger7.Bounds) Then
                picXDanger7.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger8.Bounds) Then
                picXDanger8.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger9.Bounds) Then
                picXDanger9.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger10.Bounds) Then
                picXDanger10.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger11.Bounds) Then
                picXDanger11.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger12.Bounds) Then
                picXDanger12.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picXDanger13.Bounds) Then
                picXDanger13.Top = 410
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger1.Bounds) Then
                picYDanger1.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger2.Bounds) Then
                picYDanger2.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger3.Bounds) Then
                picYDanger3.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger4.Bounds) Then
                picYDanger4.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger5.Bounds) Then
                picYDanger5.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger6.Bounds) Then
                picYDanger6.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger7.Bounds) Then
                picYDanger7.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger8.Bounds) Then
                picYDanger8.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger9.Bounds) Then
                picYDanger9.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger10.Bounds) Then
                picYDanger10.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger11.Bounds) Then
                picYDanger11.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picYDanger12.Bounds) Then
                picYDanger12.Left = 510
                If varTmrInterval = 40 Then
                    varTotalScore += 50
                ElseIf varTmrInterval = 20 Then
                    varTotalScore += 100
                ElseIf varTmrInterval = 1 Then
                    varTotalScore += 150
                End If
                lblScore.Text = varTotalScore
                If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                    lblHighscore.Text = varTotalScore
                End If
            End If
        End If
    End Sub

    Private Sub picPlayer_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayer.Move
        picPlayerEXBounds.Top = picPlayer.Top - 25 : picPlayerEXBounds.Left = picPlayer.Left - 25

        'sets bounds
        picPlayer.SetBounds(picPlayer.Left, picPlayer.Top, picPlayer.Width, picPlayer.Height)
        picGet.SetBounds(picGet.Left, picGet.Top, picGet.Width, picGet.Height)
        picPlayerEXBounds.SetBounds(picPlayerEXBounds.Left, picPlayerEXBounds.Top, picPlayerEXBounds.Width, picPlayerEXBounds.Height)

        Randomize()
        'when get is got then:
        If picPlayer.Bounds.IntersectsWith(picGet.Bounds) Then

            'sets new location for picGet
            picGet.Top = Rnd() * 325 + 60 : picGet.Left = Rnd() * 475
            If picGet.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                picGet.Left = Rnd() * 475 : picGet.Top = Rnd() * 320 + 60
            End If

            'animates PGBScore
            varScoreAnimationStart = True
            varPGBValue += 20

            'updates scores
            varScore += 1
            lbl25Score.Text = varScore
            If varTmrInterval = 40 Then
                varTotalScore += 100
            ElseIf varTmrInterval = 20 Then
                varTotalScore += 200
            ElseIf varTmrInterval = 1 Then
                varTotalScore += 300
            End If
            lblScore.Text = varTotalScore
            If varTotalScore > Integer.Parse(lblHighscore.Text) Then
                lblHighscore.Text = varTotalScore
            End If

            'Makes random danger when get is got :D
            If varScore = 1 Then
                picYDanger1.Left = Rnd() * 475 : picYDanger1.Top = Rnd() * 320 + 60
                If picYDanger1.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger1.Left = Rnd() * 475 : picYDanger1.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 2 Then
                picXDanger2.Left = Rnd() * 475 : picXDanger2.Top = Rnd() * 320 + 60
                If picXDanger2.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger2.Left = Rnd() * 475 : picXDanger2.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 3 Then
                picYDanger2.Left = Rnd() * 475 : picYDanger2.Top = Rnd() * 320 + 60
                If picYDanger2.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger2.Left = Rnd() * 475 : picYDanger2.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 4 Then
                picXDanger3.Left = Rnd() * 475 : picXDanger3.Top = Rnd() * 320 + 60
                If picXDanger3.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger3.Left = Rnd() * 475 : picXDanger3.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 5 Then
                varInvincibele = True
                pgbScore.Value = 0
                varPGBValue = 0
                picYDanger3.Left = Rnd() * 475 : picYDanger3.Top = Rnd() * 320 + 60
                If picYDanger3.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger3.Left = Rnd() * 475 : picYDanger3.Top = Rnd() * 320 + 60
                End If
                If varDifficulty = "Easy" Then
                    frmPlayers.picPlayers02.Image = My.Resources.players2
                ElseIf varDifficulty = "Medium" Then
                    frmPlayers.picPlayers08.Image = My.Resources.players8
                ElseIf varDifficulty = "Hard" Then
                    frmPlayers.picPlayers14.Image = My.Resources.players14
                End If

            ElseIf varScore = 6 Then
                picXDanger4.Left = Rnd() * 475 : picXDanger4.Top = Rnd() * 320 + 60
                If picXDanger6.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger6.Left = Rnd() * 475 : picXDanger6.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 7 Then
                picYDanger4.Left = Rnd() * 475 : picYDanger4.Top = Rnd() * 320 + 60
                If picYDanger4.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger4.Left = Rnd() * 475 : picYDanger4.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 8 Then
                picXDanger5.Left = Rnd() * 475 : picXDanger5.Top = Rnd() * 320 + 60
                If picXDanger5.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger5.Left = Rnd() * 475 : picXDanger5.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 9 Then
                picYDanger5.Left = Rnd() * 475 : picYDanger5.Top = Rnd() * 320 + 60
                If picYDanger5.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger5.Left = Rnd() * 475 : picYDanger5.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 10 Then
                varInvincibele = True
                pgbScore.Value = 0
                varPGBValue = 0
                picXDanger6.Left = Rnd() * 475 : picXDanger6.Top = Rnd() * 320 + 60
                If picXDanger6.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger6.Left = Rnd() * 475 : picXDanger6.Top = Rnd() * 320 + 60
                End If
                If varDifficulty = "Easy" Then
                    frmPlayers.picPlayers03.Image = My.Resources.players3
                ElseIf varDifficulty = "Medium" Then
                    frmPlayers.picPlayers09.Image = My.Resources.players9
                ElseIf varDifficulty = "Hard" Then
                    frmPlayers.picPlayers15.Image = My.Resources.players15
                End If

            ElseIf varScore = 11 Then
                picYDanger6.Left = Rnd() * 475 : picYDanger6.Top = Rnd() * 320 + 60
                If picYDanger6.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger6.Left = Rnd() * 475 : picYDanger6.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 12 Then
                picXDanger7.Left = Rnd() * 475 : picXDanger7.Top = Rnd() * 320 + 60
                If picXDanger7.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger7.Left = Rnd() * 475 : picXDanger7.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 13 Then
                picYDanger7.Left = Rnd() * 475 : picYDanger7.Top = Rnd() * 320 + 60
                If picYDanger7.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger7.Left = Rnd() * 475 : picYDanger7.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 14 Then
                picXDanger8.Left = Rnd() * 475 : picXDanger8.Top = Rnd() * 320 + 60
                If picXDanger8.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger8.Left = Rnd() * 475 : picXDanger8.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 15 Then
                varInvincibele = True
                pgbScore.Value = 0
                varPGBValue = 0
                picYDanger8.Left = Rnd() * 475 : picYDanger8.Top = Rnd() * 320 + 60
                If picYDanger8.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger8.Left = Rnd() * 475 : picYDanger8.Top = Rnd() * 320 + 60
                End If
                If varDifficulty = "Easy" Then
                    frmPlayers.picPlayers04.Image = My.Resources.players4
                ElseIf varDifficulty = "Medium" Then
                    frmPlayers.picPlayers10.Image = My.Resources.players10
                ElseIf varDifficulty = "Hard" Then
                    frmPlayers.picPlayers16.Image = My.Resources.players16
                End If

            ElseIf varScore = 16 Then
                picXDanger9.Left = Rnd() * 475 : picXDanger9.Top = Rnd() * 320 + 60
                If picXDanger9.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger9.Left = Rnd() * 475 : picXDanger9.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 17 Then
                picYDanger9.Left = Rnd() * 475 : picYDanger9.Top = Rnd() * 320 + 60
                If picYDanger9.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger9.Left = Rnd() * 475 : picYDanger9.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 18 Then
                picXDanger10.Left = Rnd() * 475 : picXDanger10.Top = Rnd() * 320 + 60
                If picXDanger10.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger10.Left = Rnd() * 475 : picXDanger10.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 19 Then
                picYDanger10.Left = Rnd() * 475 : picYDanger10.Top = Rnd() * 320 + 60
                If picYDanger10.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger10.Left = Rnd() * 475 : picYDanger10.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 20 Then
                varInvincibele = True
                pgbScore.Value = 0
                varPGBValue = 0
                picXDanger11.Left = Rnd() * 475 : picXDanger11.Top = Rnd() * 320 + 60
                If picXDanger11.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger11.Left = Rnd() * 475 : picXDanger11.Top = Rnd() * 320 + 60
                End If
                If varDifficulty = "Easy" Then
                    frmPlayers.picPlayers05.Image = My.Resources.players5
                ElseIf varDifficulty = "Medium" Then
                    frmPlayers.picPlayers11.Image = My.Resources.players11
                ElseIf varDifficulty = "Hard" Then
                    frmPlayers.picPlayers17.Image = My.Resources.players17
                End If

            ElseIf varScore = 21 Then
                picYDanger11.Left = Rnd() * 475 : picYDanger11.Top = Rnd() * 320 + 60
                If picYDanger11.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger11.Left = Rnd() * 475 : picYDanger11.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 22 Then
                picXDanger12.Left = Rnd() * 475 : picXDanger12.Top = Rnd() * 320 + 60
                If picXDanger12.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger12.Left = Rnd() * 475 : picXDanger12.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 23 Then
                picYDanger12.Left = Rnd() * 475 : picYDanger12.Top = Rnd() * 320 + 60
                If picYDanger12.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picYDanger12.Left = Rnd() * 475 : picYDanger12.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 24 Then
                picXDanger13.Left = Rnd() * 475 : picXDanger13.Top = Rnd() * 320 + 60
                If picXDanger13.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picXDanger13.Left = Rnd() * 475 : picXDanger13.Top = Rnd() * 320 + 60
                End If

            ElseIf varScore = 25 Then
                If varDifficulty = "Easy" Then
                    frmPlayers.picPlayers06.Image = My.Resources.players6
                ElseIf varDifficulty = "Medium" Then
                    frmPlayers.picPlayers12.Image = My.Resources.players12
                ElseIf varDifficulty = "Hard" Then
                    frmPlayers.picPlayers18.Image = My.Resources.players18
                End If

                'resets everything
                If varDifficulty = "Easy" Then
                    frmStart.btnMedium.Enabled = True
                    frmStart.btnMedium.Image = My.Resources.btnMedium
                ElseIf varDifficulty = "Medium" Then
                    frmStart.btnHard.Enabled = True
                    frmStart.btnHard.Image = My.Resources.btnHard
                End If
                varPGBValue = 0
                varScore = 0
                lbl25Score.Text = varScore
                varTotalScore = 0
                lblScore.Text = varTotalScore
                Me.Visible = False
                frmStart.Visible = True
                tmrDangerMove.Enabled = False
                tmrUp.Enabled = False
                tmrDown.Enabled = False
                tmrLeft.Enabled = False
                tmrRight.Enabled = False
                picPlayer.Left = 225 : picPlayer.Top = 195
                pgbScore.Value = 0
                picGet.Left = Rnd() * 475 : picGet.Top = Rnd() * 325 + 60
                If picGet.Bounds.IntersectsWith(picPlayerEXBounds.Bounds) Then
                    picGet.Left = Rnd() * 475 : picGet.Top = Rnd() * 320 + 60
                End If
                picXDanger1.Left = Rnd() * 475 : picXDanger1.Top = Rnd() * 325 + 60
                If picXDanger1.Top > 170 And picXDanger1.Top < 270 Then
                    picXDanger1.Left = Rnd() * 475 : picXDanger1.Top = Rnd() * 325 + 60
                End If
                picXDanger2.Top = 403
                picXDanger3.Top = 403
                picXDanger4.Top = 403
                picXDanger5.Top = 403
                picXDanger6.Top = 403
                picXDanger7.Top = 403
                picXDanger8.Top = 403
                picXDanger9.Top = 403
                picXDanger10.Top = 403
                picXDanger11.Top = 403
                picXDanger12.Top = 403
                picXDanger13.Top = 403
                picYDanger1.Left = 506
                picYDanger2.Left = 506
                picYDanger3.Left = 506
                picYDanger4.Left = 506
                picYDanger5.Left = 506
                picYDanger6.Left = 506
                picYDanger7.Left = 506
                picYDanger8.Left = 506
                picYDanger9.Left = 506
                picYDanger10.Left = 506
                picYDanger11.Left = 506
                picYDanger12.Left = 506
            End If
        End If
    End Sub

    'Debugging output
    Private Sub tmrDebug_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDebug.Tick
        '[DEBUGGING OUTPUT]
        lblDebug.Text = "DEBUGGING STATS v4.7.0" & vbNewLine & vbNewLine & _
        "MOMENTUM VARIABLES" & vbNewLine & _
            "varUpStartMomentum: " & varUpStartMomentum & vbNewLine & _
            "varDownStartMomentum: " & varDownStartMomentum & vbNewLine & _
            "varLeftStartMomentum: " & varLeftStartMomentum & vbNewLine & _
            "varRightStartMomentum: " & varRightStartMomentum & vbNewLine & _
            "varUpSpeed: " & varUpSpeed & vbNewLine & _
            "varDownSpeed: " & varDownSpeed & vbNewLine & _
            "varLeftSpeed: " & varLeftSpeed & vbNewLine & _
            "varRightSpeed: " & varRightSpeed & vbNewLine & vbNewLine & _
        "VARIABLES" & vbNewLine & _
            "varTmrTickCounter: " & vbNewLine & _
            "varTmrInterval: " & varTmrInterval & vbNewLine & _
            "varScore: " & varScore & vbNewLine & _
            "varPGBValue: " & varPGBValue & vbNewLine & _
            "varPause: " & varPause & vbNewLine & _
            "varScoreAnimationStart: " & varScoreAnimationStart & vbNewLine & _
            "varInvincible: " & varInvincibele & vbNewLine & vbNewLine & _
        "LOCATIONS" & vbNewLine & _
        "frmMain XL,YT" & "(" & Me.Left & ", " & Me.Top & ")" & vbNewLine & _
            "picXDanger1 XL,YT: " & picXDanger1.Left & ", " & picXDanger1.Top & vbNewLine & _
            "picPlayer XL,YT XR,YL: " & "(" & picPlayer.Left & ", " & picPlayer.Top & ")" & " (" & picPlayer.Right & ", " & picPlayer.Bottom & ")" & vbNewLine & _
            "picGet XL,YT: " & "(" & picGet.Left & ", " & picGet.Top & ")" & vbNewLine & vbNewLine & _
        "PGB VALUES" & vbNewLine & _
            "pgbSloMo Value: " & pgbSloMo.Value & vbNewLine & _
            "pgbInvincible Value: " & pgbInvincible.Value & vbNewLine & _
            "pgbScore Value: " & pgbScore.Value & vbNewLine & vbNewLine & _
        "TIMERS" & vbNewLine & _
            "tmrSloMo: " & tmrSloMo.Enabled & " " & tmrSloMo.Interval & vbNewLine & _
            "tmrPGBAnimations: " & tmrPGBAnimations.Enabled & " " & tmrPGBAnimations.Interval & vbNewLine & _
            "tmrDangerMove: " & tmrDangerMove.Enabled & " " & tmrDangerMove.Interval & vbNewLine & _
            "tmrCollisionCheck: " & tmrCollisionCheck.Enabled & " " & tmrCollisionCheck.Interval & vbNewLine & _
            "tmrDebug: " & tmrDebug.Enabled & " " & tmrDebug.Interval & vbNewLine & _
            "tmrUp: " & tmrUp.Enabled & " " & tmrUp.Interval & vbNewLine & _
            "tmrDown: " & tmrDown.Enabled & " " & tmrDown.Interval & vbNewLine & _
            "tmrLeft: " & tmrLeft.Enabled & " " & tmrLeft.Interval & vbNewLine & _
            "tmrRight: " & tmrRight.Enabled & " " & tmrRight.Interval & vbNewLine

        frmStart.lblDebug.Text = lblDebug.Text
        '[/DEBUGGING OUTPUT]
    End Sub

    Private Sub tmrRNDInterval_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRNDInterval.Tick
        Randomize()
        varXSpeed1 = Rnd() * 3 + 2
        varXSpeed2 = Rnd() * 3 + 2
        varXSpeed3 = Rnd() * 3 + 2
        varXSpeed4 = Rnd() * 3 + 2
        varXSpeed5 = Rnd() * 3 + 2
        varXSpeed6 = Rnd() * 3 + 2
        varXSpeed7 = Rnd() * 3 + 2
        varXSpeed8 = Rnd() * 3 + 2
        varXSpeed9 = Rnd() * 3 + 2
        varXSpeed10 = Rnd() * 3 + 2
        varXSpeed11 = Rnd() * 3 + 2
        varXSpeed12 = Rnd() * 3 + 2
        varXSpeed13 = Rnd() * 3 + 2
        varYSpeed1 = Rnd() * 3 + 2
        varYSpeed2 = Rnd() * 3 + 2
        varYSpeed3 = Rnd() * 3 + 2
        varYSpeed4 = Rnd() * 3 + 2
        varYSpeed5 = Rnd() * 3 + 2
        varYSpeed6 = Rnd() * 3 + 2
        varYSpeed7 = Rnd() * 3 + 2
        varYSpeed8 = Rnd() * 3 + 2
        varYSpeed9 = Rnd() * 3 + 2
        varYSpeed10 = Rnd() * 3 + 2
        varYSpeed11 = Rnd() * 3 + 2
        varYSpeed12 = Rnd() * 3 + 2
    End Sub

    'Moves dangers
    Private Sub tmrDangerMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDangerMove.Tick
        'moves XDanger1 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger1.Right > 500 Then
                varXSpeed1Neg = True
            ElseIf picXDanger1.Left < 0 Then
                varXSpeed1Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger1.Right > 500 Then
                picXDanger1.Left = 0
            End If
        End If
        If varXSpeed1Neg = True Then
            picXDanger1.Left -= varXSpeed1
        Else
            picXDanger1.Left += varXSpeed1
        End If
        picXDanger1.SetBounds(picXDanger1.Left, picXDanger1.Top, picXDanger1.Width, picXDanger1.Height)
        'moves XDanger2 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger2.Right > 500 Then
                varXSpeed2Neg = True
            ElseIf picXDanger2.Left < 0 Then
                varXSpeed2Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger2.Right > 500 Then
                picXDanger2.Left = 0
            End If
        End If
        If varXSpeed2Neg = True Then
            picXDanger2.Left -= varXSpeed2
        Else
            picXDanger2.Left += varXSpeed2
        End If
        picXDanger2.SetBounds(picXDanger2.Left, picXDanger2.Top, picXDanger2.Width, picXDanger2.Height)
        'moves XDanger3 back And forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger3.Right > 500 Then
                varXSpeed3Neg = True
            ElseIf picXDanger3.Left < 0 Then
                varXSpeed3Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger3.Right > 500 Then
                picXDanger3.Left = 0
            End If
        End If
        If varXSpeed3Neg = True Then
            picXDanger3.Left -= varXSpeed3
        Else
            picXDanger3.Left += varXSpeed3
        End If
        picXDanger3.SetBounds(picXDanger3.Left, picXDanger3.Top, picXDanger3.Width, picXDanger3.Height)
        'moves XDanger4 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger4.Right > 500 Then
                varXSpeed4Neg = True
            ElseIf picXDanger4.Left < 0 Then
                varXSpeed4Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger4.Right > 500 Then
                picXDanger4.Left = 0
            End If
        End If
        If varXSpeed4Neg = True Then
            picXDanger4.Left -= varXSpeed4
        Else
            picXDanger4.Left += varXSpeed4
        End If
        picXDanger4.SetBounds(picXDanger4.Left, picXDanger4.Top, picXDanger4.Width, picXDanger4.Height)
        'moves XDanger5 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger5.Right > 500 Then
                varXSpeed5Neg = True
            ElseIf picXDanger5.Left < 0 Then
                varXSpeed5Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger5.Right > 500 Then
                picXDanger5.Left = 0
            End If
        End If
        If varXSpeed5Neg = True Then
            picXDanger5.Left -= varXSpeed5
        Else
            picXDanger5.Left += varXSpeed5
        End If
        picXDanger5.SetBounds(picXDanger5.Left, picXDanger5.Top, picXDanger5.Width, picXDanger5.Height)
        'moves XDanger6 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger6.Right > 500 Then
                varXSpeed6Neg = True
            ElseIf picXDanger6.Left < 0 Then
                varXSpeed6Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger6.Right > 500 Then
                picXDanger6.Left = 0
            End If
        End If
        If varXSpeed6Neg = True Then
            picXDanger6.Left -= varXSpeed6
        Else
            picXDanger6.Left += varXSpeed6
        End If
        picXDanger6.SetBounds(picXDanger6.Left, picXDanger6.Top, picXDanger6.Width, picXDanger6.Height)
        'moves XDanger7 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger7.Right > 500 Then
                varXSpeed7Neg = True
            ElseIf picXDanger7.Left < 0 Then
                varXSpeed7Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger7.Right > 500 Then
                picXDanger7.Left = 0
            End If
        End If
        If varXSpeed7Neg = True Then
            picXDanger7.Left -= varXSpeed7
        Else
            picXDanger7.Left += varXSpeed7
        End If
        picXDanger7.SetBounds(picXDanger7.Left, picXDanger7.Top, picXDanger7.Width, picXDanger7.Height)
        'moves XDanger8 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger8.Right > 500 Then
                varXSpeed8Neg = True
            ElseIf picXDanger8.Left < 0 Then
                varXSpeed8Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger8.Right > 500 Then
                picXDanger8.Left = 0
            End If
        End If
        If varXSpeed8Neg = True Then
            picXDanger8.Left -= varXSpeed8
        Else
            picXDanger8.Left += varXSpeed8
        End If
        picXDanger8.SetBounds(picXDanger8.Left, picXDanger8.Top, picXDanger8.Width, picXDanger8.Height)
        'moves XDanger9 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger9.Right > 500 Then
                varXSpeed9Neg = True
            ElseIf picXDanger9.Left < 0 Then
                varXSpeed9Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger9.Right > 500 Then
                picXDanger9.Left = 0
            End If
        End If
        If varXSpeed9Neg = True Then
            picXDanger9.Left -= varXSpeed9
        Else
            picXDanger9.Left += varXSpeed9
        End If
        picXDanger9.SetBounds(picXDanger9.Left, picXDanger9.Top, picXDanger9.Width, picXDanger9.Height)
        'moves XDanger10 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger10.Right > 500 Then
                varXSpeed10Neg = True
            ElseIf picXDanger10.Left < 0 Then
                varXSpeed10Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger10.Right > 500 Then
                picXDanger10.Left = 0
            End If
        End If
        If varXSpeed10Neg = True Then
            picXDanger10.Left -= varXSpeed10
        Else
            picXDanger10.Left += varXSpeed10
        End If
        picXDanger10.SetBounds(picXDanger10.Left, picXDanger10.Top, picXDanger10.Width, picXDanger10.Height)
        'moves XDanger11 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger11.Right > 500 Then
                varXSpeed11Neg = True
            ElseIf picXDanger11.Left < 0 Then
                varXSpeed11Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger11.Right > 500 Then
                picXDanger11.Left = 0
            End If
        End If
        If varXSpeed11Neg = True Then
            picXDanger11.Left -= varXSpeed11
        Else
            picXDanger11.Left += varXSpeed11
        End If
        picXDanger11.SetBounds(picXDanger11.Left, picXDanger11.Top, picXDanger11.Width, picXDanger11.Height)
        'moves XDanger12 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger12.Right > 500 Then
                varXSpeed12Neg = True
            ElseIf picXDanger12.Left < 0 Then
                varXSpeed12Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger12.Right > 500 Then
                picXDanger12.Left = 0
            End If
        End If
        If varXSpeed12Neg = True Then
            picXDanger12.Left -= varXSpeed12
        Else
            picXDanger12.Left += varXSpeed12
        End If
        picXDanger12.SetBounds(picXDanger12.Left, picXDanger12.Top, picXDanger12.Width, picXDanger12.Height)
        'moves XDanger13 back and forth
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picXDanger13.Right > 500 Then
                varXSpeed13Neg = True
            ElseIf picXDanger13.Left < 0 Then
                varXSpeed13Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picXDanger13.Right > 500 Then
                picXDanger13.Left = 0
            End If
        End If
        If varXSpeed13Neg = True Then
            picXDanger13.Left -= varXSpeed13
        Else
            picXDanger13.Left += varXSpeed13
        End If
        picXDanger13.SetBounds(picXDanger13.Left, picXDanger13.Top, picXDanger13.Width, picXDanger13.Height)
        'moves YDanger1 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger1.Bottom > 400 Then
                varYSpeed1Neg = True
            ElseIf picYDanger1.Top < 60 Then
                varYSpeed1Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger1.Bottom > 400 Then
                picYDanger1.Top = 60
            End If
        End If
        If varYSpeed1Neg = True Then
            picYDanger1.Top -= varYSpeed1
        Else
            picYDanger1.Top += varYSpeed1
        End If
        picYDanger1.SetBounds(picYDanger1.Left, picYDanger1.Top, picYDanger1.Width, picYDanger1.Height)
        'moves YDanger2 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger2.Bottom > 400 Then
                varYSpeed2Neg = True
            ElseIf picYDanger2.Top < 60 Then
                varYSpeed2Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger2.Bottom > 400 Then
                picYDanger2.Top = 60
            End If
        End If
        If varYSpeed2Neg = True Then
            picYDanger2.Top -= varYSpeed2
        Else
            picYDanger2.Top += varYSpeed2
        End If
        picYDanger2.SetBounds(picYDanger2.Left, picYDanger2.Top, picYDanger2.Width, picYDanger2.Height)
        'moves YDanger3 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger3.Bottom > 400 Then
                varYSpeed3Neg = True
            ElseIf picYDanger3.Top < 60 Then
                varYSpeed3Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger3.Bottom > 400 Then
                picYDanger3.Top = 60
            End If
        End If
        If varYSpeed3Neg = True Then
            picYDanger3.Top -= varYSpeed3
        Else
            picYDanger3.Top += varYSpeed3
        End If
        picYDanger3.SetBounds(picYDanger3.Left, picYDanger3.Top, picYDanger3.Width, picYDanger3.Height)
        'moves YDanger4 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger4.Bottom > 400 Then
                varYSpeed4Neg = True
            ElseIf picYDanger4.Top < 60 Then
                varYSpeed4Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger4.Bottom > 400 Then
                picYDanger4.Top = 60
            End If
        End If
        If varYSpeed4Neg = True Then
            picYDanger4.Top -= varYSpeed4
        Else
            picYDanger4.Top += varYSpeed4
        End If
        picYDanger4.SetBounds(picYDanger4.Left, picYDanger4.Top, picYDanger4.Width, picYDanger4.Height)
        'moves YDanger5 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger5.Bottom > 400 Then
                varYSpeed5Neg = True
            ElseIf picYDanger5.Top < 60 Then
                varYSpeed5Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger5.Bottom > 400 Then
                picYDanger5.Top = 60
            End If
        End If
        If varYSpeed5Neg = True Then
            picYDanger5.Top -= varYSpeed5
        Else
            picYDanger5.Top += varYSpeed5
        End If
        picYDanger5.SetBounds(picYDanger5.Left, picYDanger5.Top, picYDanger5.Width, picYDanger5.Height)
        'moves YDanger6 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger6.Bottom > 400 Then
                varYSpeed6Neg = True
            ElseIf picYDanger6.Top < 60 Then
                varYSpeed6Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger6.Bottom > 400 Then
                picYDanger6.Top = 60
            End If
        End If
        If varYSpeed6Neg = True Then
            picYDanger6.Top -= varYSpeed6
        Else
            picYDanger6.Top += varYSpeed6
        End If
        picYDanger6.SetBounds(picYDanger6.Left, picYDanger6.Top, picYDanger6.Width, picYDanger6.Height)
        'moves YDanger7 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger7.Bottom > 400 Then
                varYSpeed7Neg = True
            ElseIf picYDanger7.Top < 60 Then
                varYSpeed7Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger7.Bottom > 400 Then
                picYDanger7.Top = 60
            End If
        End If
        If varYSpeed7Neg = True Then
            picYDanger7.Top -= varYSpeed7
        Else
            picYDanger7.Top += varYSpeed7
        End If
        picYDanger7.SetBounds(picYDanger7.Left, picYDanger7.Top, picYDanger7.Width, picYDanger7.Height)
        'moves YDanger8 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger8.Bottom > 400 Then
                varYSpeed8Neg = True
            ElseIf picYDanger8.Top < 60 Then
                varYSpeed8Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger8.Bottom > 400 Then
                picYDanger8.Top = 60
            End If
        End If
        If varYSpeed8Neg = True Then
            picYDanger8.Top -= varYSpeed8
        Else
            picYDanger8.Top += varYSpeed8
        End If
        picYDanger8.SetBounds(picYDanger8.Left, picYDanger8.Top, picYDanger8.Width, picYDanger8.Height)
        'moves YDanger9 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger9.Bottom > 400 Then
                varYSpeed9Neg = True
            ElseIf picYDanger9.Top < 60 Then
                varYSpeed9Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger9.Bottom > 400 Then
                picYDanger9.Top = 60
            End If
        End If
        If varYSpeed9Neg = True Then
            picYDanger9.Top -= varYSpeed9
        Else
            picYDanger9.Top += varYSpeed9
        End If
        picYDanger9.SetBounds(picYDanger9.Left, picYDanger9.Top, picYDanger9.Width, picYDanger9.Height)
        'moves YDanger10 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger10.Bottom > 400 Then
                varYSpeed10Neg = True
            ElseIf picYDanger10.Top < 60 Then
                varYSpeed10Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger10.Bottom > 400 Then
                picYDanger10.Top = 60
            End If
        End If
        If varYSpeed10Neg = True Then
            picYDanger10.Top -= varYSpeed10
        Else
            picYDanger10.Top += varYSpeed10
        End If
        picYDanger10.SetBounds(picYDanger10.Left, picYDanger10.Top, picYDanger10.Width, picYDanger10.Height)
        'moves YDanger11 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger11.Bottom > 400 Then
                varYSpeed11Neg = True
            ElseIf picYDanger11.Top < 60 Then
                varYSpeed11Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger11.Bottom > 400 Then
                picYDanger11.Top = 60
            End If
        End If
        If varYSpeed11Neg = True Then
            picYDanger11.Top -= varYSpeed11
        Else
            picYDanger11.Top += varYSpeed11
        End If
        picYDanger11.SetBounds(picYDanger11.Left, picYDanger11.Top, picYDanger11.Width, picYDanger11.Height)
        'moves YDanger12 up and down
        If varDifficulty = "Easy" Or varDifficulty = "Medium" Then
            If picYDanger12.Bottom > 400 Then
                varYSpeed12Neg = True
            ElseIf picYDanger12.Top < 60 Then
                varYSpeed12Neg = False
            End If
        ElseIf varDifficulty = "Hard" Then
            If picYDanger12.Bottom > 400 Then
                picYDanger12.Top = 60
            End If
        End If
        If varYSpeed12Neg = True Then
            picYDanger12.Top -= varYSpeed12
        Else
            picYDanger12.Top += varYSpeed12
        End If
        picYDanger12.SetBounds(picYDanger12.Left, picYDanger12.Top, picYDanger12.Width, picYDanger12.Height)
    End Sub

    'activates/deactivates movement timers
    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'turns timers on depending on what keys are pressed
        If varPause = False Then
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
                tmrUp.Enabled = True
                varUpEndMomentum = False
                varUpStartMomentum = True
            End If
            If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
                tmrDown.Enabled = True
                varDownEndMomentum = False
                varDownStartMomentum = True
            End If
            If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
                tmrLeft.Enabled = True
                varLeftEndMomentum = False
                varLeftStartMomentum = True
            End If
            If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
                tmrRight.Enabled = True
                varRightEndMomentum = False
                varRightStartMomentum = True
            End If
            If e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Space Then
                If pgbSloMo.Value >= 30 Then
                    tmrSloMo.Enabled = True
                    varSloMo = True
                End If
            End If
        End If
        If e.KeyCode = Keys.P Then
            If varPause = True Then
                btnPause.Image = My.Resources.picPauseUp
                btnPlay.Image = My.Resources.picPlayDown
                varPause = False
                tmrDangerMove.Enabled = True
                tmrPGBAnimations.Enabled = True
            ElseIf varPause = False Then
                btnPause.Image = My.Resources.picPauseDown
                btnPlay.Image = My.Resources.picPlayUp
                varPause = True
                tmrDangerMove.Enabled = False
                tmrPGBAnimations.Enabled = False
                tmrUp.Enabled = False
                tmrDown.Enabled = False
                tmrLeft.Enabled = False
                tmrRight.Enabled = False
            End If
        End If
    End Sub
    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'turns timers off depending on what keys are pressed
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            varUpStartMomentum = False
            varUpEndMomentum = True
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            varDownStartMomentum = False
            varDownEndMomentum = True
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            varLeftStartMomentum = False
            varLeftEndMomentum = True
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            varRightStartMomentum = False
            varRightEndMomentum = True
        End If
        If e.KeyCode = Keys.ShiftKey Or e.KeyCode = Keys.Space Then
            varSloMo = False
        End If
    End Sub

    'timers move picPlayer
    Private Sub tmrUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUp.Tick
        If picPlayer.Top >= 65 Then
            If varUpStartMomentum = True Then
                varUpSpeed += ((varUpSpeed ^ 2) * 0.1) + 0.2
                If varUpSpeed >= 5 Then
                    varUpStartMomentum = False
                    varUpSpeed = 5
                End If
            End If
            If varUpEndMomentum = True Then
                varUpSpeed -= (varUpSpeed ^ 2) * 0.07
                If varUpSpeed < 0 Then
                    tmrUp.Enabled = False
                End If
            End If
            picPlayer.Location = New Point(picPlayer.Location.X, picPlayer.Location.Y - varUpSpeed)
        End If
    End Sub
    Private Sub tmrDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDown.Tick
        If picPlayer.Bottom <= 395 Then
            If varDownStartMomentum = True Then
                varDownSpeed += ((varDownSpeed ^ 2) * 0.1) + 0.2
                If varDownSpeed >= 5 Then
                    varDownStartMomentum = False
                    varDownSpeed = 5
                End If
            End If
            If varDownEndMomentum = True Then
                varDownSpeed -= (varDownSpeed ^ 2) * 0.07
                If varDownSpeed < 0 Then
                    tmrDown.Enabled = False
                End If
            End If

            picPlayer.Location = New Point(picPlayer.Location.X, picPlayer.Location.Y + varDownSpeed)
        End If
    End Sub
    Private Sub tmrLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLeft.Tick
        If picPlayer.Left >= 3 Then
            If varLeftStartMomentum = True Then
                varLeftSpeed += ((varLeftSpeed ^ 2) * 0.1) + 0.2
                If varLeftSpeed >= 5 Then
                    varLeftStartMomentum = False
                    varLeftSpeed = 5
                End If
            End If
            If varLeftEndMomentum = True Then
                varLeftSpeed -= (varLeftSpeed ^ 2) * 0.07
                If varLeftSpeed < 0 Then
                    tmrLeft.Enabled = False
                End If
            End If
            picPlayer.Location = New Point(picPlayer.Location.X - varLeftSpeed, picPlayer.Location.Y)
        End If
    End Sub
    Private Sub tmrRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRight.Tick
        If picPlayer.Right <= 496 Then
            If varRightStartMomentum = True Then
                varRightSpeed += ((varRightSpeed ^ 2) * 0.1) + 0.2
                If varRightSpeed >= 5 Then
                    varRightStartMomentum = False
                    varRightSpeed = 5
                End If
            End If
            If varRightEndMomentum = True Then
                varRightSpeed -= (varRightSpeed ^ 2) * 0.07
                If varRightSpeed < 0.3 Then
                    tmrRight.Enabled = False
                End If
            End If
            picPlayer.Location = New Point(picPlayer.Location.X + varRightSpeed, picPlayer.Location.Y)
        End If
    End Sub

    'btnExit
    Private Sub btnExit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnExit.MouseDown
        btnExit.ForeColor = Color.DarkSlateGray
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    'btnMinimize
    Private Sub btnMinimize_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMinimize.MouseDown
        btnMinimize.ForeColor = Color.DarkSlateGray
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        btnMinimize.ForeColor = Color.DarkGray
    End Sub

    'Lets you move the window by dragging the form
    Dim varNewPos As New System.Drawing.Point()
    Dim varX As Integer
    Dim varY As Integer
    Private Sub Label4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        varX = Control.MousePosition.X - Me.Location.X
        varY = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Label4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            varNewPos = Control.MousePosition
            varNewPos.X = varNewPos.X - (varX)
            varNewPos.Y = varNewPos.Y - (varY)
            Me.Location = varNewPos
        End If
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        If varPause = False Then
            btnPause.Image = My.Resources.picPauseDown
            btnPlay.Image = My.Resources.picPlayUp
            varPause = True
            tmrDangerMove.Enabled = False
            tmrPGBAnimations.Enabled = False
            tmrUp.Enabled = False
            tmrDown.Enabled = False
            tmrLeft.Enabled = False
            tmrRight.Enabled = False
        End If
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        If varPause = True Then
            btnPause.Image = My.Resources.picPauseUp
            btnPlay.Image = My.Resources.picPlayDown
            varPause = False
            tmrDangerMove.Enabled = True
            tmrPGBAnimations.Enabled = True
        End If
    End Sub

    Private Sub lblEnableDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnableDebug.Click
        If lblEnableDebug.Text = "Debug: Off" Then
            lblEnableDebug.Text = "Debug: On"
            frmStart.lblEnableDebug.Text = "Debug: On"
            frmStart.Width = 750 : frmStart.Height = 600
            picPlayerEXBounds.Visible = True
            Me.Width = 750 : Me.Height = 600
            tmrCollisionCheck.Enabled = False
            tmrDebug.Enabled = True
        ElseIf lblEnableDebug.Text = "Debug: On" Then
            lblEnableDebug.Text = "Debug: Off"
            frmStart.lblEnableDebug.Text = "Debug: Off"
            frmStart.Width = 500 : frmStart.Height = 400
            picPlayerEXBounds.Visible = False
            Me.Width = 500 : Me.Height = 400
            tmrCollisionCheck.Enabled = True
            tmrDebug.Enabled = False
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 500 : Me.Height = 400
    End Sub
End Class