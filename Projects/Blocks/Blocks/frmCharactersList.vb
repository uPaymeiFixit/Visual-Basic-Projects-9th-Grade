'Josh Gibbs
'Period 2
'June 3 2011
'Blocks (Final Project)
'frmCharacterslist v6.5.1846 r98


'To-Do
'DeepLocked characters need to be written. This will not be done tonight.


Public Class frmCharactersList

    'Array for players, almost useless in this form, but it will be called again during invincibility and frmGameplay setup
    Public player(17) As Image
    Private Sub frmCharactersList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        player(0) = My.Resources.player1
        player(1) = My.Resources.player2
        player(2) = My.Resources.player3
        player(3) = My.Resources.player4
        player(4) = My.Resources.player5
        player(5) = My.Resources.player6
        player(6) = My.Resources.player7
        player(7) = My.Resources.player8
        player(8) = My.Resources.player9
        player(9) = My.Resources.player10
        player(10) = My.Resources.player11
        player(11) = My.Resources.player12
        player(12) = My.Resources.player13
        player(13) = My.Resources.player14
        player(14) = My.Resources.player15
        player(15) = My.Resources.player16
        player(16) = My.Resources.player17
        player(17) = My.Resources.player18
    End Sub

    'Selected character stats
    Public varSelectedCharacter As Int16
    Public varSelectedInvincibility As Int16
    Public varSelectedSpeed As Int16
    Public varSelectedSize As Int16

    'Selected character info
    Public varSelectedDifficulty As String
    Public varSelectedScoreNeeded As Int16

    'I have split the next section into three groups. I am not going to add remarks for the next three groups directly, because
    'they each item in a group has only a slightly modified code. Instead I will make the remarks for each group as the beggining of the group.

    'The ".Click" group sets all of the above variables for the character that is clicked on. Each character has it's own unique properties,
    'so each .Click sets different values. Then the setupfrmSelectedCharacterInfo sub is called with the result of the unlockCheck function.
    'Then the showfrmSelectedCharacterInfo sub is called to switch forms.

    '[.Click]
    Private Sub picPlayers01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers01.Click

        varSelectedDifficulty = "Easy"
        varSelectedScoreNeeded = 0

        varSelectedCharacter = 1
        varSelectedInvincibility = 200
        varSelectedSize = 60
        varSelectedSpeed = 2

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers02.Click

        varSelectedDifficulty = "Easy"
        varSelectedScoreNeeded = 5

        varSelectedCharacter = 2
        varSelectedInvincibility = 100
        varSelectedSize = 50
        varSelectedSpeed = 3

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers03.Click

        varSelectedDifficulty = "Easy"
        varSelectedScoreNeeded = 10

        varSelectedCharacter = 3
        varSelectedInvincibility = 100
        varSelectedSize = 40
        varSelectedSpeed = 4

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers04.Click

        varSelectedDifficulty = "Easy"
        varSelectedScoreNeeded = 15

        varSelectedCharacter = 4
        varSelectedInvincibility = 150
        varSelectedSize = 30
        varSelectedSpeed = 3

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers05.Click

        varSelectedDifficulty = "Easy"
        varSelectedScoreNeeded = 20

        varSelectedCharacter = 5
        varSelectedInvincibility = 150
        varSelectedSize = 50
        varSelectedSpeed = 4

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers06.Click

        varSelectedDifficulty = "Easy"
        varSelectedScoreNeeded = 25

        varSelectedCharacter = 6
        varSelectedInvincibility = 200
        varSelectedSize = 40
        varSelectedSpeed = 5

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers07.Click

        varSelectedDifficulty = "Medium"
        varSelectedScoreNeeded = 0

        varSelectedCharacter = 7
        varSelectedInvincibility = 200
        varSelectedSize = 50
        varSelectedSpeed = 4

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers08.Click

        varSelectedDifficulty = "Medium"
        varSelectedScoreNeeded = 5

        varSelectedCharacter = 8
        varSelectedInvincibility = 200
        varSelectedSize = 70
        varSelectedSpeed = 4

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers09.Click

        varSelectedDifficulty = "Medium"
        varSelectedScoreNeeded = 10

        varSelectedCharacter = 9
        varSelectedInvincibility = 200
        varSelectedSize = 50
        varSelectedSpeed = 5

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers10.Click

        varSelectedDifficulty = "Medium"
        varSelectedScoreNeeded = 15

        varSelectedCharacter = 10
        varSelectedInvincibility = 250
        varSelectedSize = 30
        varSelectedSpeed = 4

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers11.Click

        varSelectedDifficulty = "Medium"
        varSelectedScoreNeeded = 20

        varSelectedCharacter = 11
        varSelectedInvincibility = 200
        varSelectedSize = 40
        varSelectedSpeed = 5

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers12.Click

        varSelectedDifficulty = "Medium"
        varSelectedScoreNeeded = 25

        varSelectedCharacter = 12
        varSelectedInvincibility = 300
        varSelectedSize = 40
        varSelectedSpeed = 3

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers13.Click

        varSelectedDifficulty = "Hard"
        varSelectedScoreNeeded = 0

        varSelectedCharacter = 13
        varSelectedInvincibility = 150
        varSelectedSize = 50
        varSelectedSpeed = 5

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers14.Click

        varSelectedDifficulty = "Hard"
        varSelectedScoreNeeded = 5

        varSelectedCharacter = 14
        varSelectedInvincibility = 200
        varSelectedSize = 60
        varSelectedSpeed = 4

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers15.Click

        varSelectedDifficulty = "Hard"
        varSelectedScoreNeeded = 10

        varSelectedCharacter = 15
        varSelectedInvincibility = 300
        varSelectedSize = 30
        varSelectedSpeed = 3

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers16.Click

        varSelectedDifficulty = "Hard"
        varSelectedScoreNeeded = 15

        varSelectedCharacter = 16
        varSelectedInvincibility = 300
        varSelectedSize = 50
        varSelectedSpeed = 4

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers17.Click

        varSelectedDifficulty = "Hard"
        varSelectedScoreNeeded = 20

        varSelectedCharacter = 17
        varSelectedInvincibility = 150
        varSelectedSize = 60
        varSelectedSpeed = 6

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub

    Private Sub picPlayers18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayers18.Click

        varSelectedDifficulty = "Hard"
        varSelectedScoreNeeded = 25

        varSelectedCharacter = 18
        varSelectedInvincibility = 300
        varSelectedSize = 40
        varSelectedSpeed = 6

        setupfrmSelectedCharacterInfo(varUnlocked:=unlockCheck(varScoreNeeded:=varSelectedScoreNeeded, varDifficulty:=varSelectedDifficulty))
        showfrmSelectedCharacterInfo()

    End Sub
    '[/.Click]

    'The ".MouseHover" group animates the characters on mousehover. It checks to see if they are unlocked first to check which image will be used.

    '[.MouseHover]
    Private Sub picPlayers01_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers01.MouseHover
            picPlayers01.Image = My.Resources.players1over
    End Sub

    Private Sub picPlayers02_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers02.MouseHover
        If unlockCheck(varScoreNeeded:=5, varDifficulty:="Easy") Then
            picPlayers02.Image = My.Resources.players2over
        Else
            picPlayers02.Image = My.Resources._5easyDown
        End If
    End Sub

    Private Sub picPlayers03_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers03.MouseHover
        If unlockCheck(varScoreNeeded:=10, varDifficulty:="Easy") Then
            picPlayers03.Image = My.Resources.players3over
        Else
            picPlayers03.Image = My.Resources._10easyDown
        End If
    End Sub

    Private Sub picPlayers04_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers04.MouseHover
        If unlockCheck(varScoreNeeded:=15, varDifficulty:="Easy") Then
            picPlayers04.Image = My.Resources.players4over
        Else
            picPlayers04.Image = My.Resources._15easyDown
        End If
    End Sub

    Private Sub picPlayers05_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers05.MouseHover
        If unlockCheck(varScoreNeeded:=20, varDifficulty:="Easy") Then
            picPlayers05.Image = My.Resources.players5over
        Else
            picPlayers05.Image = My.Resources._20easyDown
        End If
    End Sub

    Private Sub picPlayers06_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers06.MouseHover
        If unlockCheck(varScoreNeeded:=25, varDifficulty:="Easy") Then
            picPlayers06.Image = My.Resources.players6over
        Else
            picPlayers06.Image = My.Resources._25easyDown
        End If
    End Sub

    Private Sub picPlayers07_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers07.MouseHover
            picPlayers07.Image = My.Resources.players7over
    End Sub

    Private Sub picPlayers08_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers08.MouseHover
        If unlockCheck(varScoreNeeded:=5, varDifficulty:="Medium") Then
            picPlayers08.Image = My.Resources.players8over
        Else
            picPlayers08.Image = My.Resources._5mediumDown
        End If
    End Sub

    Private Sub picPlayers09_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers09.MouseHover
        If unlockCheck(varScoreNeeded:=10, varDifficulty:="Medium") Then
            picPlayers09.Image = My.Resources.players9over
        Else
            picPlayers09.Image = My.Resources._10mediumDown
        End If
    End Sub

    Private Sub picPlayers10_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers10.MouseHover
        If unlockCheck(varScoreNeeded:=15, varDifficulty:="Medium") Then
            picPlayers10.Image = My.Resources.players10over
        Else
            picPlayers10.Image = My.Resources._15mediumDown
        End If
    End Sub

    Private Sub picPlayers11_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers11.MouseHover
        If unlockCheck(varScoreNeeded:=20, varDifficulty:="Medium") Then
            picPlayers11.Image = My.Resources.players11over
        Else
            picPlayers11.Image = My.Resources._20mediumDown
        End If
    End Sub

    Private Sub picPlayers12_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers12.MouseHover
        If unlockCheck(varScoreNeeded:=25, varDifficulty:="Medium") Then
            picPlayers12.Image = My.Resources.players12over
        Else
            picPlayers12.Image = My.Resources._25mediumDown
        End If
    End Sub

    Private Sub picPlayers13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers13.MouseHover
            picPlayers13.Image = My.Resources.players13over
    End Sub

    Private Sub picPlayers14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers14.MouseHover
        If unlockCheck(varScoreNeeded:=5, varDifficulty:="Hard") Then
            picPlayers14.Image = My.Resources.players14over
        Else
            picPlayers14.Image = My.Resources._5hardDown
        End If
    End Sub

    Private Sub picPlayers15_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers15.MouseHover
        If unlockCheck(varScoreNeeded:=10, varDifficulty:="Hard") Then
            picPlayers15.Image = My.Resources.players15over
        Else
            picPlayers15.Image = My.Resources._10hardDown
        End If
    End Sub

    Private Sub picPlayers16_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers16.MouseHover
        If unlockCheck(varScoreNeeded:=15, varDifficulty:="Hard") Then
            picPlayers16.Image = My.Resources.players16over
        Else
            picPlayers16.Image = My.Resources._15hardDown
        End If
    End Sub

    Private Sub picPlayers17_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers17.MouseHover
        If unlockCheck(varScoreNeeded:=20, varDifficulty:="Hard") Then
            picPlayers17.Image = My.Resources.players17over
        Else
            picPlayers17.Image = My.Resources._20hardDown
        End If
    End Sub

    Private Sub picPlayers18_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers18.MouseHover
        If unlockCheck(varScoreNeeded:=25, varDifficulty:="Hard") Then
            picPlayers18.Image = My.Resources.players18over
        Else
            picPlayers18.Image = My.Resources._25hardDown
        End If
    End Sub
    '[/.MouseHover]

    'The ".MouseLeave" group animates the characters on mouseleave. It checks to see if they are unlocked first to check which image will be used.

    '[.MouseLeave]
    Private Sub picPlayers01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers01.MouseLeave
        picPlayers01.Image = My.Resources.players1
    End Sub

    Private Sub picPlayers02_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers02.MouseLeave
        If unlockCheck(varScoreNeeded:=5, varDifficulty:="Easy") Then
            picPlayers02.Image = My.Resources.players2
        Else
            picPlayers02.Image = My.Resources._5easy
        End If
    End Sub

    Private Sub picPlayers03_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers03.MouseLeave
        If unlockCheck(varScoreNeeded:=10, varDifficulty:="Easy") Then
            picPlayers03.Image = My.Resources.players3
        Else
            picPlayers03.Image = My.Resources._10easy
        End If
    End Sub

    Private Sub picPlayers04_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers04.MouseLeave
        If unlockCheck(varScoreNeeded:=15, varDifficulty:="Easy") Then
            picPlayers04.Image = My.Resources.players4
        Else
            picPlayers04.Image = My.Resources._15easy
        End If
    End Sub

    Private Sub picPlayers05_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers05.MouseLeave
        If unlockCheck(varScoreNeeded:=20, varDifficulty:="Easy") Then
            picPlayers05.Image = My.Resources.players5
        Else
            picPlayers05.Image = My.Resources._20easy
        End If
    End Sub

    Private Sub picPlayers06_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers06.MouseLeave
        If unlockCheck(varScoreNeeded:=25, varDifficulty:="Easy") Then
            picPlayers06.Image = My.Resources.players6
        Else
            picPlayers06.Image = My.Resources._25easy
        End If
    End Sub

    Private Sub picPlayers07_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers07.MouseLeave
        picPlayers07.Image = My.Resources.players7
    End Sub

    Private Sub picPlayers08_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers08.MouseLeave
        If unlockCheck(varScoreNeeded:=5, varDifficulty:="Medium") Then
            picPlayers08.Image = My.Resources.players8
        Else
            picPlayers08.Image = My.Resources._5medium
        End If
    End Sub

    Private Sub picPlayers09_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers09.MouseLeave
        If unlockCheck(varScoreNeeded:=10, varDifficulty:="Medium") Then
            picPlayers09.Image = My.Resources.players9
        Else
            picPlayers09.Image = My.Resources._10medium
        End If
    End Sub

    Private Sub picPlayers10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers10.MouseLeave
        If unlockCheck(varScoreNeeded:=15, varDifficulty:="Medium") Then
            picPlayers10.Image = My.Resources.players10
        Else
            picPlayers10.Image = My.Resources._15medium
        End If
    End Sub

    Private Sub picPlayers11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers11.MouseLeave
        If unlockCheck(varScoreNeeded:=20, varDifficulty:="Medium") Then
            picPlayers11.Image = My.Resources.players11
        Else
            picPlayers11.Image = My.Resources._20medium
        End If
    End Sub

    Private Sub picPlayers12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers12.MouseLeave
        If unlockCheck(varScoreNeeded:=25, varDifficulty:="Medium") Then
            picPlayers12.Image = My.Resources.players12
        Else
            picPlayers12.Image = My.Resources._25medium
        End If
    End Sub

    Private Sub picPlayers13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers13.MouseLeave
        picPlayers13.Image = My.Resources.players13
    End Sub

    Private Sub picPlayers14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers14.MouseLeave
        If unlockCheck(varScoreNeeded:=5, varDifficulty:="Hard") Then
            picPlayers14.Image = My.Resources.players14
        Else
            picPlayers14.Image = My.Resources._5hard
        End If
    End Sub

    Private Sub picPlayers15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers15.MouseLeave
        If unlockCheck(varScoreNeeded:=10, varDifficulty:="Hard") Then
            picPlayers15.Image = My.Resources.players15
        Else
            picPlayers15.Image = My.Resources._10hard
        End If
    End Sub

    Private Sub picPlayers16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers16.MouseLeave
        If unlockCheck(varScoreNeeded:=15, varDifficulty:="Hard") Then
            picPlayers16.Image = My.Resources.players16
        Else
            picPlayers16.Image = My.Resources._15hard
        End If
    End Sub

    Private Sub picPlayers17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers17.MouseLeave
        If unlockCheck(varScoreNeeded:=20, varDifficulty:="Hard") Then
            picPlayers17.Image = My.Resources.players17
        Else
            picPlayers17.Image = My.Resources._20hard
        End If
    End Sub

    Private Sub picPlayers18_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picPlayers18.MouseLeave
        If unlockCheck(varScoreNeeded:=25, varDifficulty:="Hard") Then
            picPlayers18.Image = My.Resources.players18
        Else
            picPlayers18.Image = My.Resources._25hard
        End If
    End Sub
    '[/.MouseLeave]



    'This function gets the score needed to unlock a character, and the difficulty that score needs to be on.
    'It checks to make sure that the score on that difficulty is >= what is needed to be unlocked, then it returns a boolean
    Private Function unlockCheck(ByVal varScoreNeeded As Integer, ByVal varDifficulty As String)
        Dim varUnlocked As Boolean
        If varDifficulty = "Easy" And frmStartMenu.varGameEasyHighScore >= varScoreNeeded Then
            varUnlocked = True
        ElseIf varDifficulty = "Medium" And frmStartMenu.varGameMediumHighScore >= varScoreNeeded Then
            varUnlocked = True
        ElseIf varDifficulty = "Hard" And frmStartMenu.varGameHardHighscore >= varScoreNeeded Then
            varUnlocked = True
        End If

        Return varUnlocked
    End Function


    'This Sub gets the result of the unlockCheck function. If it is true, it starts setting up the next form for
    'the player info, if false, it sets up the locked screen.
    Private Sub setupfrmSelectedCharacterInfo(ByVal varUnlocked As Boolean)
        frmSelectedCharacterInfo.picPlayer.Image = player(varSelectedCharacter - 1)

        'Translates the integers into pictures
        If varSelectedInvincibility = 100 Then
            frmSelectedCharacterInfo.picInvincibility1.Visible = True
            frmSelectedCharacterInfo.picInvincibility2.Visible = False
            frmSelectedCharacterInfo.picInvincibility3.Visible = False
            frmSelectedCharacterInfo.picInvincibility4.Visible = False
            frmSelectedCharacterInfo.picInvincibility5.Visible = False
        ElseIf varSelectedInvincibility = 150 Then
            frmSelectedCharacterInfo.picInvincibility1.Visible = True
            frmSelectedCharacterInfo.picInvincibility2.Visible = True
            frmSelectedCharacterInfo.picInvincibility3.Visible = False
            frmSelectedCharacterInfo.picInvincibility4.Visible = False
            frmSelectedCharacterInfo.picInvincibility5.Visible = False
        ElseIf varSelectedInvincibility = 200 Then
            frmSelectedCharacterInfo.picInvincibility1.Visible = True
            frmSelectedCharacterInfo.picInvincibility2.Visible = True
            frmSelectedCharacterInfo.picInvincibility3.Visible = True
            frmSelectedCharacterInfo.picInvincibility4.Visible = False
            frmSelectedCharacterInfo.picInvincibility5.Visible = False
        ElseIf varSelectedInvincibility = 250 Then
            frmSelectedCharacterInfo.picInvincibility1.Visible = True
            frmSelectedCharacterInfo.picInvincibility2.Visible = True
            frmSelectedCharacterInfo.picInvincibility3.Visible = True
            frmSelectedCharacterInfo.picInvincibility4.Visible = True
            frmSelectedCharacterInfo.picInvincibility5.Visible = False
        ElseIf varSelectedInvincibility = 300 Then
            frmSelectedCharacterInfo.picInvincibility1.Visible = True
            frmSelectedCharacterInfo.picInvincibility2.Visible = True
            frmSelectedCharacterInfo.picInvincibility3.Visible = True
            frmSelectedCharacterInfo.picInvincibility4.Visible = True
            frmSelectedCharacterInfo.picInvincibility5.Visible = True
        End If

        If varSelectedSpeed = 2 Then
            frmSelectedCharacterInfo.picSpeed1.Visible = True
            frmSelectedCharacterInfo.picSpeed2.Visible = False
            frmSelectedCharacterInfo.picSpeed3.Visible = False
            frmSelectedCharacterInfo.picSpeed4.Visible = False
            frmSelectedCharacterInfo.picSpeed5.Visible = False
        ElseIf varSelectedSpeed = 3 Then
            frmSelectedCharacterInfo.picSpeed1.Visible = True
            frmSelectedCharacterInfo.picSpeed2.Visible = True
            frmSelectedCharacterInfo.picSpeed3.Visible = False
            frmSelectedCharacterInfo.picSpeed4.Visible = False
            frmSelectedCharacterInfo.picSpeed5.Visible = False
        ElseIf varSelectedSpeed = 4 Then
            frmSelectedCharacterInfo.picSpeed1.Visible = True
            frmSelectedCharacterInfo.picSpeed2.Visible = True
            frmSelectedCharacterInfo.picSpeed3.Visible = True
            frmSelectedCharacterInfo.picSpeed4.Visible = False
            frmSelectedCharacterInfo.picSpeed5.Visible = False
        ElseIf varSelectedSpeed = 5 Then
            frmSelectedCharacterInfo.picSpeed1.Visible = True
            frmSelectedCharacterInfo.picSpeed2.Visible = True
            frmSelectedCharacterInfo.picSpeed3.Visible = True
            frmSelectedCharacterInfo.picSpeed4.Visible = True
            frmSelectedCharacterInfo.picSpeed5.Visible = False
        ElseIf varSelectedSpeed = 6 Then
            frmSelectedCharacterInfo.picSpeed1.Visible = True
            frmSelectedCharacterInfo.picSpeed2.Visible = True
            frmSelectedCharacterInfo.picSpeed3.Visible = True
            frmSelectedCharacterInfo.picSpeed4.Visible = True
            frmSelectedCharacterInfo.picSpeed5.Visible = True
        End If

        If varSelectedSize = 30 Then
            frmSelectedCharacterInfo.picSize1.Visible = True
            frmSelectedCharacterInfo.picSize2.Visible = False
            frmSelectedCharacterInfo.picSize3.Visible = False
            frmSelectedCharacterInfo.picSize4.Visible = False
            frmSelectedCharacterInfo.picSize5.Visible = False
        ElseIf varSelectedSize = 40 Then
            frmSelectedCharacterInfo.picSize1.Visible = True
            frmSelectedCharacterInfo.picSize2.Visible = True
            frmSelectedCharacterInfo.picSize3.Visible = False
            frmSelectedCharacterInfo.picSize4.Visible = False
            frmSelectedCharacterInfo.picSize5.Visible = False
        ElseIf varSelectedSize = 50 Then
            frmSelectedCharacterInfo.picSize1.Visible = True
            frmSelectedCharacterInfo.picSize2.Visible = True
            frmSelectedCharacterInfo.picSize3.Visible = True
            frmSelectedCharacterInfo.picSize4.Visible = False
            frmSelectedCharacterInfo.picSize5.Visible = False
        ElseIf varSelectedSize = 60 Then
            frmSelectedCharacterInfo.picSize1.Visible = True
            frmSelectedCharacterInfo.picSize2.Visible = True
            frmSelectedCharacterInfo.picSize3.Visible = True
            frmSelectedCharacterInfo.picSize4.Visible = True
            frmSelectedCharacterInfo.picSize5.Visible = False
        ElseIf varSelectedSize = 70 Then
            frmSelectedCharacterInfo.picSize1.Visible = True
            frmSelectedCharacterInfo.picSize2.Visible = True
            frmSelectedCharacterInfo.picSize3.Visible = True
            frmSelectedCharacterInfo.picSize4.Visible = True
            frmSelectedCharacterInfo.picSize5.Visible = True
        End If

        frmSelectedCharacterInfo.lblDifficultyNeeded.Text = varSelectedDifficulty
        frmSelectedCharacterInfo.lblPointsNeeded.Text = varSelectedScoreNeeded

        If varUnlocked Then
            frmSelectedCharacterInfo.picPlay.Visible = True
        Else
            frmSelectedCharacterInfo.picPlay.Visible = False
        End If
    End Sub

    'This Sub shows the next form and the overlay for this form
    Private Sub showfrmSelectedCharacterInfo()
        frmTransparantLayer.Show()
        frmTransparantLayer.Location = Me.Location
        frmSelectedCharacterInfo.Show()
        frmSelectedCharacterInfo.Left = Me.Left + Me.Width / 2 - frmSelectedCharacterInfo.Width / 2
        frmSelectedCharacterInfo.Top = Me.Top + Me.Height / 2 - frmSelectedCharacterInfo.Height / 2
    End Sub



    'picMainMenu
    'Switches to the start form when clicked
    Private Sub picMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMainMenu.Click
        frmStartMenu.Show()
        frmStartMenu.Location = Me.Location
        Me.Hide()
    End Sub

    'animates the main menu button on mouse hover
    Private Sub picMainMenu_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMainMenu.MouseHover
        picMainMenu.SetBounds(23, 12, 167, 43)
        'PLAY BASE SOUND
    End Sub

    'animates the main manu button on mouse leave
    Private Sub picMainMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMainMenu.MouseLeave
        picMainMenu.SetBounds(28, 15, 157, 37)
    End Sub


    'btnMinimize
    'Minimizes the window on click
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'animates the minimize button on mouse hover
    Private Sub btnMinimize_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseHover
        btnMinimize.ForeColor = Color.DimGray
    End Sub

    'animates the minimize button on mouse leave
    Private Sub btnMinimize_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.ForeColor = Color.DarkGray
    End Sub


    'btnExit
    'Kills the svhost on click
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
End Class