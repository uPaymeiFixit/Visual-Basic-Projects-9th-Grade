Public Class fmrStart
    'Josh Gibbs
    'Period 2
    '14 April 2011
    'Pong (frmStart)

    'To-Do
    'Ln93 Scores do not get set properly

    Private varSlideDirection As Integer
    Private varPlayers As Integer

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        If varPlayers < 2 Then
            MessageBox.Show("You need at least two players.")
        Else

            'finds desired aspect ratio of court
            Dim courtXRatio As Integer
            Dim courtYRatio As Integer
            If (cmbPlayer1.SelectedIndex < 2 Or cmbPlayer2.SelectedIndex < 2) And (cmbPlayer3.SelectedIndex < 2 Or cmbPlayer4.SelectedIndex < 2) Then
                courtXRatio = 3
                courtYRatio = 3
            ElseIf cmbPlayer1.SelectedIndex = 2 And cmbPlayer2.SelectedIndex = 2 Then
                courtXRatio = 2
                courtYRatio = 3
            ElseIf cmbPlayer3.SelectedIndex = 2 And cmbPlayer4.SelectedIndex = 2 Then
                courtXRatio = 3
                courtYRatio = 2
            End If

            'finds desired size of court
            Dim courtSize As Integer
            If cmbCourtSize.SelectedIndex = 0 Then
                courtSize = 200
            ElseIf cmbCourtSize.SelectedIndex = 1 Or cmbCourtSize.SelectedIndex = -1 Then
                courtSize = 100
            ElseIf cmbCourtSize.SelectedIndex = 2 Then
                courtSize = 50
            End If

            Dim paddlesize As Integer
            If cmbPaddleSizes.SelectedIndex = 0 Then
                paddlesize = 150
            ElseIf cmbPaddleSizes.SelectedIndex = 1 Or cmbPaddleSizes.SelectedIndex = -1 Then
                paddlesize = 85
            ElseIf cmbPaddleSizes.SelectedIndex = 2 Then
                paddlesize = 20
            End If

            'puts ball where it needs to go
            Randomize()
            Dim r As Integer = Rnd() * 3
            If r = 0 Then
                frmMain.Ball.Left = 20
                frmMain.Ball.Top = courtSize * courtYRatio / 2 - 2
                frmMain.varBallXDirection = -1
                frmMain.varBallYDirection = 1
            ElseIf r = 1 Then
                frmMain.Ball.Left = courtSize * courtXRatio - 20
                frmMain.Ball.Top = courtSize * courtYRatio / 2 - 2
                frmMain.varBallXDirection = 1
                frmMain.varBallYDirection = 1
            ElseIf r = 2 Then
                frmMain.Ball.Left = courtSize * courtXRatio / 2 - 2
                frmMain.Ball.Top = courtSize * courtYRatio - 55
                frmMain.varBallXDirection = 1
                frmMain.varBallYDirection = 1
            ElseIf r = 3 Then
                frmMain.Ball.Left = courtSize * courtXRatio / 2 - 2
                frmMain.Ball.Top = 20
                frmMain.varBallXDirection = 1
                frmMain.varBallYDirection = -1
            End If

            'sets up court (GOES BEFOR LOCATION PLACEMENTS)
            frmMain.Width = courtSize * courtXRatio
            frmMain.Height = courtSize * courtYRatio

            'puts scores where they need to go
            If varPlayers = 2 Then
                If cmbPlayer1.SelectedIndex < 2 And cmbPlayer2.SelectedIndex < 2 Then
                    frmMain.lblPlayer1Score.Top = 25
                    frmMain.lblPlayer2Score.Top = 25
                    frmMain.lblPlayer1Score.Left = frmMain.Width / 4
                    frmMain.lblPlayer2Score.Left = frmMain.Width - frmMain.Width / 4
                ElseIf cmbPlayer3.SelectedIndex < 2 And cmbPlayer4.SelectedIndex < 2 Then
                    frmMain.lblPlayer3Score.Left = 25
                    frmMain.lblPlayer4Score.Left = 25
                    frmMain.lblPlayer3Score.Top = frmMain.Height / 4
                    frmMain.lblPlayer4Score.Top = frmMain.Height - frmMain.Height / 4
                End If
            Else
                frmMain.lblPlayer1Score.Top = frmMain.Height / 2
                frmMain.lblPlayer2Score.Top = frmMain.Height / 2
                frmMain.lblPlayer1Score.Left = frmMain.Width / 4
                frmMain.lblPlayer2Score.Left = frmMain.Width / 4
                frmMain.lblPlayer3Score.Top = frmMain.Height / 4
                frmMain.lblPlayer4Score.Top = frmMain.Height / 4
                frmMain.lblPlayer3Score.Left = frmMain.Width / 2
                frmMain.lblPlayer4Score.Left = frmMain.Width / 2
            End If

            'Makes items invisible if they are not being used
            If cmbPlayer1.SelectedIndex = 2 Then
                frmMain.Player1.Visible = False
                frmMain.lblPlayer1Score.Visible = False
            End If
            If cmbPlayer2.SelectedIndex = 2 Then
                frmMain.Player2.Visible = False
                frmMain.lblPlayer2Score.Visible = False
            End If
            If cmbPlayer3.SelectedIndex = 2 Then
                frmMain.Player3.Visible = False
                frmMain.lblPlayer3Score.Visible = False
            End If
            If cmbPlayer4.SelectedIndex = 2 Then
                frmMain.Player4.Visible = False
                frmMain.lblPlayer4Score.Visible = False
            End If

            'sizes paddles
            frmMain.Player1.Height = paddlesize
            frmMain.Player2.Height = paddlesize
            frmMain.Player3.Width = paddlesize
            frmMain.Player4.Width = paddlesize

            'centers paddles
            frmMain.Player1.Top = courtSize * courtYRatio / 2 - frmMain.Player1.Height / 2
            frmMain.Player2.Top = courtSize * courtYRatio / 2 - frmMain.Player2.Height / 2
            frmMain.Player3.Left = courtSize * courtXRatio / 2 - frmMain.Player3.Width / 2
            frmMain.Player4.Left = courtSize * courtXRatio / 2 - frmMain.Player4.Width / 2

            'puts paddles where they need to go
            frmMain.Player1.Left = 1
            frmMain.Player2.Left = courtSize * courtXRatio - 10
            frmMain.Player3.Top = courtSize * courtYRatio - 28
            frmMain.Player4.Top = 1

            'exports variables
            frmMain.varBallSpeed = nudBallSpeed.Value

            frmMain.varPlayerSpeed = nudPlayerSpeed.Value

            frmMain.varPlayer1Score = nudScoreStart.Value
            frmMain.varPlayer2Score = nudScoreStart.Value
            frmMain.varPlayer3Score = nudScoreStart.Value
            frmMain.varPlayer4Score = nudScoreStart.Value

            frmMain.varPlayer1Status = cmbPlayer1.SelectedIndex
            frmMain.varPlayer2Status = cmbPlayer2.SelectedIndex
            frmMain.varPlayer3Status = cmbPlayer3.SelectedIndex
            frmMain.varPlayer4Status = cmbPlayer4.SelectedIndex

            If radMCNobody.Checked Then
                frmMain.varPlayerXHasMouse = 0
            ElseIf radMCPlayer1.Checked And cmbPlayer1.SelectedIndex = 0 Then
                frmMain.varPlayerXHasMouse = 1
            ElseIf radMCPlayer2.Checked And cmbPlayer2.SelectedIndex = 0 Then
                frmMain.varPlayerXHasMouse = 2
            ElseIf radMCPlayer3.Checked And cmbPlayer3.SelectedIndex = 0 Then
                frmMain.varPlayerXHasMouse = 3
            ElseIf radMCPlayer4.Checked And cmbPlayer4.SelectedIndex = 0 Then
                frmMain.varPlayerXHasMouse = 4
            End If

            If cmbScoreUPDown.SelectedIndex < 1 Then
                frmMain.varScoreCountsUp = False
            Else
                frmMain.varScoreCountsUp = True
            End If

            frmMain.varEndScore = nudScoreEnd.Value

            'switches forms
            frmMain.Enabled = True
            frmMain.Visible = True
            frmMain.Location = Me.Location
            Me.Visible = False
            End If


    End Sub

    'Sets ToolTips
    Private Sub fmrStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 165
        Me.Height = 197
        'ToolTip1.SetToolTip(radGM1vAI, "This is a game mode")
        'ToolTip1.SetToolTip(radGM1vAI, "Test")

            cmbPlayer1.SelectedIndex = 0
            cmbPlayer2.SelectedIndex = 1
            cmbPlayer3.SelectedIndex = 2
            cmbPlayer4.SelectedIndex = 2
    End Sub


    'Settings for different games
    Private Sub radGM1vAI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGM1vAI.CheckedChanged
        If radGM1vAI.Checked Then
            cmbPlayer1.SelectedIndex = 0
            cmbPlayer2.SelectedIndex = 1
            cmbPlayer3.SelectedIndex = 2
            cmbPlayer4.SelectedIndex = 2
            radMCPlayer1.Checked = True
            cmbScoreUPDown.SelectedIndex = 1
            nudScoreStart.Value = 0
            nudScoreEnd.Value = 10
            cmbPaddleSizes.SelectedIndex = 1
            cmbCourtSize.SelectedIndex = 1
            nudBallSpeed.Value = 3
            nudPlayerSpeed.Value = 2
        End If
    End Sub

    Private Sub radGMXPlayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGMXPlayer.CheckedChanged
        If radGMXPlayer.Checked Then
            If nudGMXPlayer.Value = 2 Then
                cmbPlayer1.SelectedIndex = 0
                cmbPlayer2.SelectedIndex = 0
                cmbPlayer3.SelectedIndex = 2
                cmbPlayer4.SelectedIndex = 2
                cmbScoreUPDown.SelectedIndex = 1
                nudScoreStart.Value = 0
                nudScoreEnd.Value = 10
            ElseIf nudGMXPlayer.Value = 3 Then
                cmbPlayer1.SelectedIndex = 0
                cmbPlayer2.SelectedIndex = 0
                cmbPlayer3.SelectedIndex = 0
                cmbPlayer4.SelectedIndex = 2
            ElseIf nudGMXPlayer.Value = 4 Then
                cmbPlayer1.SelectedIndex = 0
                cmbPlayer2.SelectedIndex = 0
                cmbPlayer3.SelectedIndex = 0
                cmbPlayer4.SelectedIndex = 0
            End If
            If nudGMXPlayer.Value > 2 Then
                cmbScoreUPDown.SelectedIndex = 0
                nudScoreStart.Value = 10
                nudScoreEnd.Value = 0
            End If
            cmbPaddleSizes.SelectedIndex = 1
            cmbCourtSize.SelectedIndex = 1
            nudBallSpeed.Value = 3
            nudPlayerSpeed.Value = 2
        End If
    End Sub

    Private Sub nudGMXPlayer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudGMXPlayer.ValueChanged
        If nudGMXPlayer.Value = 2 Then
            cmbPlayer1.SelectedIndex = 0
            cmbPlayer2.SelectedIndex = 0
            cmbPlayer3.SelectedIndex = 2
            cmbPlayer4.SelectedIndex = 2
        ElseIf nudGMXPlayer.Value = 3 Then
            cmbPlayer1.SelectedIndex = 0
            cmbPlayer2.SelectedIndex = 0
            cmbPlayer3.SelectedIndex = 0
            cmbPlayer4.SelectedIndex = 2
        ElseIf nudGMXPlayer.Value = 4 Then
            cmbPlayer1.SelectedIndex = 0
            cmbPlayer2.SelectedIndex = 0
            cmbPlayer3.SelectedIndex = 0
            cmbPlayer4.SelectedIndex = 0
        End If
    End Sub

    Private Sub radGMSuddenDeath_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGMSuddenDeath.CheckedChanged
        If radGMSuddenDeath.Checked Then
            cmbPlayer1.SelectedIndex = 0
            cmbPlayer2.SelectedIndex = 0
            cmbPlayer3.SelectedIndex = 2
            cmbPlayer4.SelectedIndex = 2
            radMCNobody.Checked = True
            cmbScoreUPDown.SelectedIndex = 0
            nudScoreStart.Value = 1
            nudScoreEnd.Value = 0
            cmbPaddleSizes.SelectedIndex = 1
            cmbCourtSize.SelectedIndex = 1
            nudBallSpeed.Value = 4
            nudPlayerSpeed.Value = 2
        End If
    End Sub

    Private Sub radGMCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGMCustom.CheckedChanged
        'Activates advanced settings
        If Me.Width < 453 Then
            Me.Width = 453
            Me.Height = 300
        ElseIf Me.Width > 165 Then
            Me.Width = 165
            Me.Height = 197
        End If
    End Sub


    Private Sub cmbScoreUPDown_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbScoreUPDown.SelectedIndexChanged
        If cmbScoreUPDown.SelectedIndex = 1 Then
            If varPlayers > 2 Then
                MessageBox.Show("The score can only count Up if you have two players.")
                cmbScoreUPDown.SelectedIndex = 0
            Else
                If nudScoreStart.Value > nudScoreEnd.Value Then
                    nudScoreStart.Maximum = nudScoreStart.Value
                    nudScoreEnd.Minimum = nudScoreEnd.Value
                    nudScoreEnd.Maximum = 99
                    Dim hold As Integer
                    hold = nudScoreStart.Value
                    nudScoreStart.Value = nudScoreEnd.Value
                    nudScoreEnd.Value = hold
                End If
            End If
        Else
            If nudScoreStart.Value < nudScoreEnd.Value Then
                nudScoreStart.Minimum = nudScoreStart.Value
                nudScoreEnd.Maximum = nudScoreEnd.Value
                nudScoreStart.Maximum = 99
                Dim hold As Integer
                hold = nudScoreStart.Value
                nudScoreStart.Value = nudScoreEnd.Value
                nudScoreEnd.Value = hold
            End If
        End If
    End Sub

    Private Sub cmbPlayer1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlayer1.SelectedIndexChanged
        enoughPlayers()
    End Sub

    Private Sub cmbPlayer2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlayer2.SelectedIndexChanged
        enoughPlayers()
    End Sub

    Private Sub cmbPlayer3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlayer3.SelectedIndexChanged
        enoughPlayers()
    End Sub

    Private Sub cmbPlayer4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlayer4.SelectedIndexChanged
        enoughPlayers()
    End Sub

    Private Function enoughPlayers()
        'chacks for ammount of players
        varPlayers = 0
        Dim cmbArray(3) As ComboBox
        cmbArray(0) = cmbPlayer1
        cmbArray(1) = cmbPlayer2
        cmbArray(2) = cmbPlayer3
        cmbArray(3) = cmbPlayer4
        For i = 0 To 3
            If cmbArray(i).SelectedIndex < 2 Then
                varPlayers += 1
            End If
        Next
        If varPlayers > 2 Then
            cmbScoreUPDown.SelectedItem = "Down"
        End If
    End Function
End Class