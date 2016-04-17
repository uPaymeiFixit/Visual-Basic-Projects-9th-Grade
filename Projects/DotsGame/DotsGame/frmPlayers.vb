Public Class frmPlayers
    Private Sub picPlayers01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers01.Click
        frmTransparant.Visible = True
        frmTransparant.Location = Me.Location
        frmPlayersInfo.Visible = True
        frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
        frmPlayersInfo.picPlayer.Image = My.Resources.player1
        frmPlayersInfo.picPlay.Visible = True
        frmPlayersInfo.picPlay.Enabled = True
        'frmPlayersInfo.picSpeed.Image = My.Resources.1/5
        'frmPlayersInfo.picSize.Image = My.Resources.4/5
        'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
    End Sub
    Private Sub picPlayers01_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers01.MouseHover
        picPlayers01.Image = My.Resources.players1over
    End Sub
    Private Sub picPlayers01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers01.MouseLeave
        picPlayers01.Image = My.Resources.players1
    End Sub

    Private Sub picPlayers02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers02.Click
        frmTransparant.Visible = True
        frmTransparant.Location = Me.Location
        frmPlayersInfo.Visible = True
        frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
        frmPlayersInfo.picPlayer.Image = My.Resources.player2
        If Integer.Parse(lblEasyHighscore.Text) >= 5 Then
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
        End If
        'frmPlayersInfo.picSpeed.Image = My.Resources.2/5
        'frmPlayersInfo.picSize.Image = My.Resources.3/5
        'frmPlayersInfo.picInvincibility.Image = My.Resources.1/5
    End Sub
    Private Sub picPlayers02_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers02.MouseHover
        If Integer.Parse(lblEasyHighscore.Text) < 5 Then
            picPlayers02.Image = My.Resources._5easyDown
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 5 Then
            picPlayers02.Image = My.Resources.players2over
        End If
    End Sub
    Private Sub picPlayers02_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers02.MouseLeave
        If Integer.Parse(lblEasyHighscore.Text) < 5 Then
            picPlayers02.Image = My.Resources._5easy
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 5 Then
            picPlayers02.Image = My.Resources.players2
        End If
    End Sub

    Private Sub picPlayers03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers03.Click
        frmTransparant.Visible = True
        frmTransparant.Location = Me.Location
        frmPlayersInfo.Visible = True
        frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
        frmPlayersInfo.picPlayer.Image = My.Resources.player3
        If Integer.Parse(lblEasyHighscore.Text) >= 10 Then
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
        End If
        'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
        'frmPlayersInfo.picSize.Image = My.Resources.2/5
        'frmPlayersInfo.picInvincibility.Image = My.Resources.1/5
    End Sub
    Private Sub picPlayers03_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers03.MouseHover
        If Integer.Parse(lblEasyHighscore.Text) < 10 Then
            picPlayers03.Image = My.Resources._10easyDown
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 10 Then
            picPlayers03.Image = My.Resources.players3over
        End If
    End Sub
    Private Sub picPlayers03_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers03.MouseLeave
        If Integer.Parse(lblEasyHighscore.Text) < 10 Then
            picPlayers03.Image = My.Resources._10easy
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 10 Then
            picPlayers03.Image = My.Resources.players3
        End If
    End Sub


    Private Sub picPlayers04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers04.Click
        frmTransparant.Visible = True
        frmTransparant.Location = Me.Location
        frmPlayersInfo.Visible = True
        frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
        frmPlayersInfo.picPlayer.Image = My.Resources.player4
        If Integer.Parse(lblEasyHighscore.Text) >= 15 Then
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
        End If
        'frmPlayersInfo.picSpeed.Image = My.Resources.2/5
        'frmPlayersInfo.picSize.Image = My.Resources.1/5
        'frmPlayersInfo.picInvincibility.Image = My.Resources.2/5
    End Sub
    Private Sub picPlayers04_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers04.MouseHover
        If Integer.Parse(lblEasyHighscore.Text) < 15 Then
            picPlayers04.Image = My.Resources._15easyDown
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 15 Then
            picPlayers04.Image = My.Resources.players4over
        End If
    End Sub
    Private Sub picPlayers04_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers04.MouseLeave
        If Integer.Parse(lblEasyHighscore.Text) < 15 Then
            picPlayers04.Image = My.Resources._15easy
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 15 Then
            picPlayers04.Image = My.Resources.players4
        End If
    End Sub

    Private Sub picPlayers05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers05.Click
        frmTransparant.Visible = True
        frmTransparant.Location = Me.Location
        frmPlayersInfo.Visible = True
        frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
        frmPlayersInfo.picPlayer.Image = My.Resources.player5
        If Integer.Parse(lblEasyHighscore.Text) >= 20 Then
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
        End If
        'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
        'frmPlayersInfo.picSize.Image = My.Resources.3/5
        'frmPlayersInfo.picInvincibility.Image = My.Resources.2/5
    End Sub
    Private Sub picPlayers05_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers05.MouseHover
        If Integer.Parse(lblEasyHighscore.Text) < 20 Then
            picPlayers05.Image = My.Resources._20easyDown
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 20 Then
            picPlayers05.Image = My.Resources.players5over
        End If
    End Sub
    Private Sub picPlayers05_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers05.MouseLeave
        If Integer.Parse(lblEasyHighscore.Text) < 20 Then
            picPlayers05.Image = My.Resources._20easy
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 20 Then
            picPlayers05.Image = My.Resources.players5
        End If
    End Sub

    Private Sub picPlayers06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers06.Click
        frmTransparant.Visible = True
        frmTransparant.Location = Me.Location
        frmPlayersInfo.Visible = True
        frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
        frmPlayersInfo.picPlayer.Image = My.Resources.player6
        If Integer.Parse(lblEasyHighscore.Text) >= 25 Then
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
        End If
        'frmPlayersInfo.picSpeed.Image = My.Resources.4/5
        'frmPlayersInfo.picSize.Image = My.Resources.2/5
        'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
    End Sub
    Private Sub picPlayers06_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers06.MouseHover
        If Integer.Parse(lblEasyHighscore.Text) < 25 Then
            picPlayers06.Image = My.Resources._25easyDown
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 25 Then
            picPlayers06.Image = My.Resources.players6over
        End If
    End Sub
    Private Sub picPlayers06_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers06.MouseLeave
        If Integer.Parse(lblEasyHighscore.Text) < 25 Then
            picPlayers06.Image = My.Resources._25easy
        ElseIf Integer.Parse(lblEasyHighscore.Text) >= 25 Then
            picPlayers06.Image = My.Resources.players6
        End If
    End Sub

    Private Sub picPlayers07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers07.Click
        If Integer.Parse(lblEasyHighscore.Text) = 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player7
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblEasyHighscore.Text) < 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers07_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers07.MouseHover
        picPlayers08.Image = My.Resources.players7over
    End Sub
    Private Sub picPlayers07_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers07.MouseLeave
        picPlayers08.Image = My.Resources.players7
    End Sub

    Private Sub picPlayers08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers08.Click
        If Integer.Parse(lblMediumHighscore.Text) >= 5 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player8
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblMediumHighscore.Text) < 5 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers08_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers08.MouseHover
        If Integer.Parse(lblMediumHighscore.Text) < 5 Then
            picPlayers08.Image = My.Resources._5mediumDown
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 5 Then
            picPlayers08.Image = My.Resources.players8over
        End If
    End Sub
    Private Sub picPlayers08_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers08.MouseLeave
        If Integer.Parse(lblMediumHighscore.Text) < 5 Then
            picPlayers08.Image = My.Resources._5medium
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 5 Then
            picPlayers08.Image = My.Resources.players8
        End If
    End Sub

    Private Sub picPlayers09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers09.Click
        If Integer.Parse(lblMediumHighscore.Text) >= 10 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player9
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblMediumHighscore.Text) < 10 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers09_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers09.MouseHover
        If Integer.Parse(lblMediumHighscore.Text) < 10 Then
            picPlayers09.Image = My.Resources._10mediumDown
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 10 Then
            picPlayers09.Image = My.Resources.players9over
        End If
    End Sub
    Private Sub picPlayers09_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers09.MouseLeave
        If Integer.Parse(lblMediumHighscore.Text) < 10 Then
            picPlayers09.Image = My.Resources._10medium
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 10 Then
            picPlayers09.Image = My.Resources.players9
        End If
    End Sub

    Private Sub picPlayers10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers10.Click
        If Integer.Parse(lblMediumHighscore.Text) >= 15 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player10
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblMediumHighscore.Text) < 15 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers10.MouseHover
        If Integer.Parse(lblMediumHighscore.Text) < 15 Then
            picPlayers10.Image = My.Resources._15mediumDown
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 15 Then
            picPlayers10.Image = My.Resources.players10over
        End If
    End Sub
    Private Sub picPlayers10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers10.MouseLeave
        If Integer.Parse(lblMediumHighscore.Text) < 15 Then
            picPlayers10.Image = My.Resources._15medium
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 15 Then
            picPlayers10.Image = My.Resources.players10
        End If
    End Sub

    Private Sub picPlayers11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers11.Click
        If Integer.Parse(lblMediumHighscore.Text) >= 20 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player11
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblMediumHighscore.Text) < 20 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers11.MouseHover
        If Integer.Parse(lblMediumHighscore.Text) < 20 Then
            picPlayers11.Image = My.Resources._20mediumDown
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 20 Then
            picPlayers11.Image = My.Resources.players11over
        End If
    End Sub
    Private Sub picPlayers11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers11.MouseLeave
        If Integer.Parse(lblMediumHighscore.Text) < 20 Then
            picPlayers11.Image = My.Resources._20medium
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 20 Then
            picPlayers11.Image = My.Resources.players11
        End If
    End Sub

    Private Sub picPlayers12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers12.Click
        If Integer.Parse(lblMediumHighscore.Text) = 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player12
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblMediumHighscore.Text) < 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers12.MouseHover
        If Integer.Parse(lblMediumHighscore.Text) < 25 Then
            picPlayers12.Image = My.Resources._25mediumDown
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 25 Then
            picPlayers12.Image = My.Resources.players12over
        End If
    End Sub
    Private Sub picPlayers12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers12.MouseLeave
        If Integer.Parse(lblMediumHighscore.Text) < 25 Then
            picPlayers12.Image = My.Resources._25medium
        ElseIf Integer.Parse(lblMediumHighscore.Text) >= 25 Then
            picPlayers12.Image = My.Resources.players12
        End If
    End Sub

    Private Sub picPlayers13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers13.Click
        If Integer.Parse(lblMediumHighscore.Text) = 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player13
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblMediumHighscore.Text) < 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers13.MouseHover
        picPlayers13.Image = My.Resources.players13over
    End Sub
    Private Sub picPlayers13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers13.MouseLeave
        picPlayers13.Image = My.Resources.players13
    End Sub

    Private Sub picPlayers14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers14.Click
        If Integer.Parse(lblHardHighscore.Text) >= 5 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player14
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblHardHighscore.Text) < 5 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers14.MouseHover
        If Integer.Parse(lblHardHighscore.Text) < 5 Then
            picPlayers14.Image = My.Resources._5hardDown
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 5 Then
            picPlayers14.Image = My.Resources.players14over
        End If
    End Sub
    Private Sub picPlayers14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers14.MouseLeave
        If Integer.Parse(lblHardHighscore.Text) < 5 Then
            picPlayers14.Image = My.Resources._5hard
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 5 Then
            picPlayers14.Image = My.Resources.players14
        End If
    End Sub

    Private Sub picPlayers15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers15.Click
        If Integer.Parse(lblHardHighscore.Text) >= 10 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player15
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblHardHighscore.Text) < 10 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers15.MouseHover
        If Integer.Parse(lblHardHighscore.Text) < 10 Then
            picPlayers15.Image = My.Resources._10hardDown
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 10 Then
            picPlayers15.Image = My.Resources.players15over
        End If
    End Sub
    Private Sub picPlayers15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers15.MouseLeave
        If Integer.Parse(lblHardHighscore.Text) < 10 Then
            picPlayers15.Image = My.Resources._10hard
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 10 Then
            picPlayers15.Image = My.Resources.players15
        End If
    End Sub

    Private Sub picPlayers16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers16.Click
        If Integer.Parse(lblHardHighscore.Text) >= 15 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player16
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblHardHighscore.Text) < 15 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers16.MouseHover
        If Integer.Parse(lblHardHighscore.Text) < 15 Then
            picPlayers16.Image = My.Resources._15hardDown
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 15 Then
            picPlayers16.Image = My.Resources.players16over
        End If
    End Sub
    Private Sub picPlayers16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers16.MouseLeave
        If Integer.Parse(lblHardHighscore.Text) < 15 Then
            picPlayers16.Image = My.Resources._15hard
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 15 Then
            picPlayers16.Image = My.Resources.players16
        End If
    End Sub

    Private Sub picPlayers17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers17.Click
        If Integer.Parse(lblHardHighscore.Text) >= 20 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player17
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblHardHighscore.Text) < 20 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers17.MouseHover
        If Integer.Parse(lblHardHighscore.Text) < 20 Then
            picPlayers17.Image = My.Resources._20hardDown
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 20 Then
            picPlayers17.Image = My.Resources.players17over
        End If
    End Sub
    Private Sub picPlayers17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers17.MouseLeave
        If Integer.Parse(lblHardHighscore.Text) < 20 Then
            picPlayers17.Image = My.Resources._20hard
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 20 Then
            picPlayers17.Image = My.Resources.players17
        End If
    End Sub

    Private Sub picPlayers18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers18.Click
        If Integer.Parse(lblHardHighscore.Text) = 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 60
            frmPlayersInfo.picPlayer.Image = My.Resources.player18
            frmPlayersInfo.picPlay.Visible = True
            frmPlayersInfo.picPlay.Enabled = True
            'frmPlayersInfo.picSpeed.Image = My.Resources.3/5
            'frmPlayersInfo.picSize.Image = My.Resources.3/5
            'frmPlayersInfo.picInvincibility.Image = My.Resources.3/5
        ElseIf Integer.Parse(lblHardHighscore.Text) < 25 Then
            frmTransparant.Visible = True
            frmTransparant.Location = Me.Location
            frmPlayersInfo.Visible = True
            frmPlayersInfo.picLockedBackground.Visible = True
            frmPlayersInfo.Height = 220
            frmPlayersInfo.Left = Me.Left + 110 : frmPlayersInfo.Top = Me.Top + 90
        End If
    End Sub
    Private Sub picPlayers18_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers18.MouseHover
        If Integer.Parse(lblHardHighscore.Text) < 25 Then
            picPlayers18.Image = My.Resources._25hardDown
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 25 Then
            picPlayers18.Image = My.Resources.players18over
        End If
    End Sub
    Private Sub picPlayers18_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers18.MouseLeave
        If Integer.Parse(lblHardHighscore.Text) < 25 Then
            picPlayers18.Image = My.Resources._25hard
        ElseIf Integer.Parse(lblHardHighscore.Text) >= 25 Then
            picPlayers18.Image = My.Resources.players18
        End If
    End Sub

    Private Sub picMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMainMenu.Click
        Me.Visible = False
        frmStart.Visible = True
        frmStart.Location = Me.Location
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class