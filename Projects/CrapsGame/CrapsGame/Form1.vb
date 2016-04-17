'Josh Gibbs
'Period 2
'31 October 2010
'Craps game

Public Class frmMain

    'variables
    Private varRollCountInteger As Integer
    Private varWinStateInteger As Integer 'Nothing=0 Win=1 Loose=2
    Private varPlayerPointInteger As Integer
    Private varWinCountInteger As Integer
    Private varLooseCountInteger As Integer

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click

        'variables
        Randomize()
        Dim Dice1 As Integer = Rnd() * 5 + 1
        Dim Dice2 As Integer = Rnd() * 5 + 1
        'Dim Dice1 + Dice2 As Integer = Dice1 + Dice2

        'Displays dice images
        lblRoll.Visible = False
        lblDice.Visible = False
        If Dice1 = 1 Then
            picDiceI.Image = picDice1.Image
        ElseIf Dice1 = 2 Then
            picDiceI.Image = picDice2.Image
        ElseIf Dice1 = 3 Then
            picDiceI.Image = picDice3.Image
        ElseIf Dice1 = 4 Then
            picDiceI.Image = picDice4.Image
        ElseIf Dice1 = 5 Then
            picDiceI.Image = picDice5.Image
        ElseIf Dice1 = 6 Then
            picDiceI.Image = picDice6.Image
        End If
        If Dice2 = 1 Then
            picDiceII.Image = picDice1.Image
        ElseIf Dice2 = 2 Then
            picDiceII.Image = picDice2.Image
        ElseIf Dice2 = 3 Then
            picDiceII.Image = picDice3.Image
        ElseIf Dice2 = 4 Then
            picDiceII.Image = picDice4.Image
        ElseIf Dice2 = 5 Then
            picDiceII.Image = picDice5.Image
        ElseIf Dice2 = 6 Then
            picDiceII.Image = picDice6.Image
        End If

        'adds roll count up
        varRollCountInteger += 1

        'Checks/applys not first roll rules
        If Dice1 + Dice2 = varPlayerPointInteger Then
            varWinStateInteger = 1
        End If
        If varRollCountInteger > 1 And Dice1 + Dice2 = 7 Then
            varWinStateInteger = 2
        End If

        'Checks/applys first roll rules
        If varRollCountInteger = 1 And Dice1 + Dice2 = 7 Or Dice1 + Dice2 = 11 Then
            varWinStateInteger = 1
        ElseIf varRollCountInteger = 1 And Dice1 + Dice2 = 2 Or varRollCountInteger = 1 And _
            Dice1 + Dice2 = 3 Or varRollCountInteger = 1 And Dice1 + Dice2 = 12 Then
            varWinStateInteger = 2
        ElseIf varRollCountInteger = 1 And Dice1 + Dice2 = 4 Or varRollCountInteger = 1 And _
            Dice1 + Dice2 = 5 Or varRollCountInteger = 1 And Dice1 + Dice2 = 6 Or _
            varRollCountInteger = 1 And Dice1 + Dice2 = 8 Or varRollCountInteger = 1 And _
            Dice1 + Dice2 = 9 Or varRollCountInteger = 1 And Dice1 + Dice2 = 10 Or _
            varRollCountInteger = 1 And Dice1 + Dice2 = 12 Then
            varPlayerPointInteger = Dice1 + Dice2
        End If

        'shows msgbox if you win/loose
        If varWinStateInteger = 1 Then
            MessageBox.Show("You won by rolling a(n) " & Dice1 + Dice2 & ". Nice...")
            varRollCountInteger = 0
            varWinStateInteger = 0
            varPlayerPointInteger = 0
            picDiceI.Image = Nothing
            picDiceII.Image = Nothing
            lblRoll.Visible = True
            lblDice.Visible = True
            varWinCountInteger += 1
        ElseIf varWinStateInteger = 2 Then
            MessageBox.Show("Ooh... Sorry, you lost by rolling a(n) " & Dice1 + Dice2 & ".")
            varRollCountInteger = 0
            varWinStateInteger = 0
            varPlayerPointInteger = 0
            picDiceI.Image = Nothing
            picDiceII.Image = Nothing
            lblRoll.Visible = True
            lblDice.Visible = True
            varLooseCountInteger += 1
        End If

        'displays piont
        lblPoint.Text = "Your point: " & varPlayerPointInteger
        lblWins.Text = "Wins: " & varWinCountInteger
        lblLosses.Text = "Losses: " & varLooseCountInteger
        lblWinProbability.Text = "Win Probability: " & (varWinCountInteger / (varWinCountInteger + varLooseCountInteger)).ToString("P")
    End Sub

    Private Sub btnRedundentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedundentButton.Click
        'Closes the form (Just like the button right above it)
        Me.Close()
    End Sub
End Class