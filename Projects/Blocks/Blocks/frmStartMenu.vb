'Josh Gibbs
'Period 2
'June 2 2011 (Not Draft)
'Blocks (Final Project) 
'frmStartMenu v6.4.1716 r28)

'To-Do
'Check to make sure "End" ends the vshost process.

Public Class frmStartMenu

    Private varRequiredMediumScore As Int16 = 7
    Private varRequiredHardScore As Int16 = 15

    Public varGameEasyHighScore As Int16
    Public varGameMediumHighScore As Int16
    Public varGameHardHighscore As Int16

    '[.Click]

    'When the minimize button is pushed the form is minimized
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'When the exit button is pushed the vshost is killed
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    'When the Instructions button is pushed, a message box containing instructions and info pop up.
    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        MessageBox.Show("Use the arrow keys to move. Select your character. Avoid the blue blocks, get the green ones." & vbNewLine & vbNewLine & "Game version 6.8.2306 r314")
    End Sub

    'When the Easy button is pushed, the difficulty is set and the showfrmCharacters is called
    Private Sub btnPlayEasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayEasy.Click
        frmGameplay.varGameDifficulty = "Easy"
        frmCharactersList.BackgroundImage = My.Resources.frmPlayersEasyBackground
        showfrmCharacters()
    End Sub

    'When the Medium button is pushed, if the button is enabled, the difficulty is set and the showfrmCharacters is called
    Private Sub btnPlayMedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayMedium.Click
        frmGameplay.varGameDifficulty = "Medium"
        frmCharactersList.BackgroundImage = My.Resources.frmPlayersMediumBackground
        showfrmCharacters()
    End Sub

    'When the Hard button is pushed, if the button is enabled, the difficulty is set and the showfrmCharacters is called
    Private Sub btnPlayHard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayHard.Click
        frmGameplay.varGameDifficulty = "Hard"
        frmCharactersList.BackgroundImage = My.Resources.frmPlayersHardBackground
        showfrmCharacters()
    End Sub

    '[/.Click]

    '[.MouseHover]

    'Animates the minimize button on mouse hover
    Private Sub btnMinimize_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseHover
        btnMinimize.ForeColor = Color.DimGray
    End Sub


    'Animates the exit button on mouse hover
    Private Sub btnExit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseHover
        btnExit.ForeColor = Color.DimGray
    End Sub


    Private Sub btnInfo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseHover
        btnInfo.SetBounds(175, 197, 150, 38)
        'PLAY BASE SOUND
    End Sub


    'Animates the Easy button on mouse hover
    Private Sub btnPlayEasy_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayEasy.MouseHover
        btnPlayEasy.SetBounds(175, 245, 150, 38)
        'PLAY BASE SOUND
    End Sub


    'Animates the Medium button on mouse hover
    Private Sub btnPlayMedium_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayMedium.MouseHover
        btnPlayMedium.SetBounds(175, 285, 150, 38)
        'PLAY BASE SOUND
    End Sub


    'Animates the Hard button on house hover
    Private Sub btnPlayHard_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayHard.MouseHover
        btnPlayHard.SetBounds(175, 325, 150, 38)
        'PLAY BASE SOUND
    End Sub

    '[/.MouseHover]

    '[.MouseLeave]

    'Animates the minimize button on mouse leave
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.ForeColor = Color.DarkGray
    End Sub

    'Animates the exit button on mouse leave
    Private Sub btnExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave
        btnExit.ForeColor = Color.DarkGray
    End Sub

    'Animates the Instructions when the mouse leaves
    Private Sub btnInfo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave
        btnInfo.SetBounds(180, 200, 140, 35)
    End Sub

    'Animates Easy button when the mouse leaves
    Private Sub btnPlayEasy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayEasy.MouseLeave
        btnPlayEasy.SetBounds(180, 248, 140, 35)
    End Sub

    'Animates the Medium button when the mouse leaves
    Private Sub btnPlayMedium_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayMedium.MouseLeave
        btnPlayMedium.SetBounds(180, 288, 140, 35)
    End Sub

    'Animates the Hard button when the mouse leaves
    Private Sub btnPlayHard_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayHard.MouseLeave
        btnPlayHard.SetBounds(180, 328, 140, 35)
    End Sub

    '[/.MouseLeave]


    'This Sub switches to the next form
    Private Sub showfrmCharacters()
        frmCharactersList.Show()
        frmCharactersList.Location = Me.Location
        Me.Hide()
    End Sub

    
End Class