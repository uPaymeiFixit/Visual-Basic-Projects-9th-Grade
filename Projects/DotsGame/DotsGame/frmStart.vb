Public Class frmStart

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        MessageBox.Show("Instructions" & vbNewLine & vbNewLine & _
                        "Controlls" & vbNewLine & _
                        "Use WASD or the arrow keys to controll your character." & vbNewLine & _
                        "Hold down 'Shift' or 'Space' to use Slow Motion." & vbNewLine & _
                        "Press 'P' to pause the game." & vbNewLine & vbNewLine & _
                        "Rules" & vbNewLine & _
                        "Get the blue dots while avoiding the green ones." & _
                        "When you get five blue dots in a row you are invincible and your character will change color until the top progress bar runs out." & _
                        "The top progress bar shows how close you are to invinciblity. " & _
                        "Your slow motion time is represented by the bottom progress bar. " & vbNewLine & _
                        "Good luck!", "Dots v4.0 Code by Josh Gibbs")
    End Sub
    Private Sub btnInfo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseHover
        btnInfo.Width = 160 : btnInfo.Height = 45
        btnInfo.Left = 170 : btnInfo.Top = 195
    End Sub
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave
        btnInfo.Width = 140 : btnInfo.Height = 35
        btnInfo.Left = 180 : btnInfo.Top = 200
    End Sub

    Private Sub btnEasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEasy.Click
        frmGame.varDifficulty = "Easy"
        frmPlayers.Visible = True
        frmPlayers.Location = Me.Location
        Me.Visible = False
        frmGame.tmrDangerMove.Enabled = True
        frmGame.Location = Me.Location
        'My.Computer.Audio.Play(DotsGame.My.Resources.songBackgroundMusic, AudioPlayMode.Background)
    End Sub
    Private Sub btnEasy_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEasy.MouseHover
        btnEasy.Width = 160 : btnEasy.Height = 45
        btnEasy.Left = 170 : btnEasy.Top = 243
    End Sub
    Private Sub btnEasy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEasy.MouseLeave
        btnEasy.Width = 140 : btnEasy.Height = 35
        btnEasy.Left = 180 : btnEasy.Top = 248
    End Sub

    Private Sub btnMedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedium.Click
        frmGame.varDifficulty = "Medium"
        frmPlayers.Visible = True
        frmPlayers.Location = Me.Location
        Me.Visible = False
        frmGame.tmrDangerMove.Enabled = True
        frmGame.Location = Me.Location
        'My.Computer.Audio.Play(DotsGame.My.Resources.songBackgroundMusic, AudioPlayMode.Background)
    End Sub
    Private Sub btnMedium_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMedium.MouseHover
        btnMedium.Width = 160 : btnMedium.Height = 45
        btnMedium.Left = 170 : btnMedium.Top = 283
    End Sub
    Private Sub btnMedium_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMedium.MouseLeave
        btnMedium.Width = 140 : btnMedium.Height = 35
        btnMedium.Left = 180 : btnMedium.Top = 288
    End Sub

    Private Sub btnHard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHard.Click
        frmGame.varDifficulty = "Hard"
        frmPlayers.Visible = True
        frmPlayers.Location = Me.Location
        Me.Visible = False
        frmGame.tmrDangerMove.Enabled = True
        frmGame.Location = Me.Location
        'My.Computer.Audio.Play(DotsGame.My.Resources.songBackgroundMusic, AudioPlayMode.Background)
    End Sub
    Private Sub btnHard_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHard.MouseHover
        btnHard.Width = 160 : btnHard.Height = 45
        btnHard.Left = 170 : btnHard.Top = 323
    End Sub
    Private Sub btnHard_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHard.MouseLeave
        btnHard.Width = 140 : btnHard.Height = 35
        btnHard.Left = 180 : btnHard.Top = 328
    End Sub

    Private Sub lblEnableDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEnableDebug.Click
        If lblEnableDebug.Text = "Debug: Off" Then
            lblEnableDebug.Text = "Debug: On"
            frmGame.lblEnableDebug.Text = "Debug: On"
            Me.Width = 750 : Me.Height = 600
            frmGame.picPlayerEXBounds.Visible = True
            frmGame.Width = 750 : frmGame.Height = 600
            frmGame.tmrCollisionCheck.Enabled = False
            frmGame.tmrDebug.Enabled = True
            'needs to be reset
            btnMedium.Enabled = True
            btnHard.Enabled = True
        ElseIf lblEnableDebug.Text = "Debug: On" Then
            lblEnableDebug.Text = "Debug: Off"
            frmGame.lblEnableDebug.Text = "Debug: Off"
            Me.Width = 500 : Me.Height = 400
            frmGame.picPlayerEXBounds.Visible = False
            frmGame.Width = 500 : frmGame.Height = 400
            frmGame.tmrCollisionCheck.Enabled = True
            frmGame.tmrDebug.Enabled = False
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 500 : Me.Height = 400
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
End Class