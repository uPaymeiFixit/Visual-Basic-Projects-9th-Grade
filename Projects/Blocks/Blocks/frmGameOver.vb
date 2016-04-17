'Josh Gibbs
'Period 2
'June 5 2011 (Not Draft)
'Blocks (Final Project)
'frmGameplay v6.5.2042 r3

'To-Do
'Reset the frmGameplay variables

Public Class frmGameOver

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        'Disables tmrBlueBlockMovement
        frmGameplay.tmrBlueBlockMovement.Enabled = False

        'removes blue blocks for next game
        For i = 1 To frmGameplay.varBlueBlocksOnScreen
            Me.Controls.Remove(frmGameplay.blueBlocks(i))
        Next
        frmGameplay.varBlueBlocksOnScreen = 0

        'Switches forms
        frmStartMenu.Show()
        frmStartMenu.Location = frmGameplay.Location
        frmTransparantLayer.Hide()
        frmGameplay.Close()
        Me.Hide()
    End Sub

    'animates the main menu button on mouse hover
    Private Sub btnMainMenu_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMainMenu.MouseHover
        'btnMainMenu.Image = My.Resources.NEED MAIN MENU BUTTON DOWN
        'PLAY BASE SOUND
    End Sub

    'animates the main menu button on mouse leave
    Private Sub btnMainMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMainMenu.MouseLeave
        btnMainMenu.Image = My.Resources.btnMainMenu
    End Sub
End Class