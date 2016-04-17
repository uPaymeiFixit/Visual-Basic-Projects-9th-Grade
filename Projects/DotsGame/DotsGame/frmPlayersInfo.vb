Public Class frmPlayersInfo

    Private Sub picPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlay.Click

        If lblPointsNeeded.Text = 5 And lblDifficultyNeeded.Text = "Easy" Then

        ElseIf lblPointsNeeded.Text = 10 And lblDifficultyNeeded.Text = "Easy" Then

        ElseIf lblPointsNeeded.Text = 15 And lblDifficultyNeeded.Text = "Easy" Then

        ElseIf lblPointsNeeded.Text = 20 And lblDifficultyNeeded.Text = "Easy" Then

        ElseIf lblPointsNeeded.Text = 25 And lblDifficultyNeeded.Text = "Easy" Then

        ElseIf lblPointsNeeded.Text = 5 And lblDifficultyNeeded.Text = "Medium" Then

        ElseIf lblPointsNeeded.Text = 10 And lblDifficultyNeeded.Text = "Medium" Then

        ElseIf lblPointsNeeded.Text = 15 And lblDifficultyNeeded.Text = "Medium" Then

        ElseIf lblPointsNeeded.Text = 20 And lblDifficultyNeeded.Text = "Medium" Then

        ElseIf lblPointsNeeded.Text = 25 And lblDifficultyNeeded.Text = "Medium" Then

        ElseIf lblPointsNeeded.Text = 5 And lblDifficultyNeeded.Text = "Hard" Then

        ElseIf lblPointsNeeded.Text = 10 And lblDifficultyNeeded.Text = "Hard" Then

        ElseIf lblPointsNeeded.Text = 15 And lblDifficultyNeeded.Text = "Hard" Then

        ElseIf lblPointsNeeded.Text = 20 And lblDifficultyNeeded.Text = "Hard" Then

        ElseIf lblPointsNeeded.Text = 25 And lblDifficultyNeeded.Text = "Hard" Then

        End If

        frmTransparant.Visible = False
        Me.Visible = False
        frmPlayers.Visible = False
        frmGame.Visible = True
        frmGame.Location = frmPlayers.Location

    End Sub

    Private Sub picPlay_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlay.MouseHover
        'picPlay.Image = My.Resources.btnPlayOver 
        '///////THIS IMAGE IS CORRUPT AND NEEDS TO BE RECREATED\\\\\\\
    End Sub
    Private Sub picPlay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlay.MouseLeave
        picPlay.Image = My.Resources.btnPlay
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Visible = False
        frmTransparant.Visible = False
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.MouseHover
        btnBack.Image = My.Resources.btnBackOver
    End Sub
    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.MouseLeave
        btnBack.Image = My.Resources.btnBack
    End Sub
End Class