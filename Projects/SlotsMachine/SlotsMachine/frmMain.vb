'Josh Gibbs

'Period 2
'4 November 2010
'Slots Machine Project

Public Class frmMain

    'lets slot actions know when to take place
    Private varSlotTickCounter As Integer
    Private varRollTickCounter As Integer = 2

    'for 3 random pictures
    Private varRandom1 As Integer
    Private varRandom2 As Integer
    Private varRandom3 As Integer

    'User's money and pay
    Private varWinnerPaid As Integer
    Private varUserMoney As Integer

    'Ammount bet
    Private varBet As Integer
    Private varBetWin As Integer

    'Wins & Losses counters
    Private varRollCounter As Integer
    Private varWinCounter As Integer

    Private Sub tmrRoller_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRoller.Tick

        'Makes images "roll" until a certain tick
        If varSlotTickCounter < 100 Then
            If varRollTickCounter = 0 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r0
            ElseIf varRollTickCounter = 1 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r1
            ElseIf varRollTickCounter = 2 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r2
            ElseIf varRollTickCounter = 3 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r3
            ElseIf varRollTickCounter = 4 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r4
            ElseIf varRollTickCounter = 5 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r5
            ElseIf varRollTickCounter = 6 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r6
            ElseIf varRollTickCounter = 7 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r7
            ElseIf varRollTickCounter = 8 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r8
            ElseIf varRollTickCounter = 9 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r9
            ElseIf varRollTickCounter = 10 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r10
            ElseIf varRollTickCounter = 11 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r11
            ElseIf varRollTickCounter = 12 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r12
            ElseIf varRollTickCounter = 13 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r13
            ElseIf varRollTickCounter = 14 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r14
            ElseIf varRollTickCounter = 15 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r15
            ElseIf varRollTickCounter = 16 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r16
            ElseIf varRollTickCounter = 17 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r17
            ElseIf varRollTickCounter = 18 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r18
            ElseIf varRollTickCounter = 19 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r19
            ElseIf varRollTickCounter = 20 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r20
            ElseIf varRollTickCounter = 21 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r21
            ElseIf varRollTickCounter = 22 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r22
            ElseIf varRollTickCounter = 23 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r23
            End If
        End If
        If varSlotTickCounter < 150 Then
            If varRollTickCounter = 0 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r0
            ElseIf varRollTickCounter = 1 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r1
            ElseIf varRollTickCounter = 2 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r2
            ElseIf varRollTickCounter = 3 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r3
            ElseIf varRollTickCounter = 4 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r4
            ElseIf varRollTickCounter = 5 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r5
            ElseIf varRollTickCounter = 6 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r6
            ElseIf varRollTickCounter = 7 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r7
            ElseIf varRollTickCounter = 8 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r8
            ElseIf varRollTickCounter = 9 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r9
            ElseIf varRollTickCounter = 10 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r10
            ElseIf varRollTickCounter = 11 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r11
            ElseIf varRollTickCounter = 12 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r12
            ElseIf varRollTickCounter = 13 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r13
            ElseIf varRollTickCounter = 14 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r14
            ElseIf varRollTickCounter = 15 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r15
            ElseIf varRollTickCounter = 16 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r16
            ElseIf varRollTickCounter = 17 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r17
            ElseIf varRollTickCounter = 18 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r18
            ElseIf varRollTickCounter = 19 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r19
            ElseIf varRollTickCounter = 20 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r20
            ElseIf varRollTickCounter = 21 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r21
            ElseIf varRollTickCounter = 22 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r22
            ElseIf varRollTickCounter = 23 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r23
            End If
        End If
        If varSlotTickCounter < 200 Then
            If varRollTickCounter = 0 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r0
            ElseIf varRollTickCounter = 1 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r1
            ElseIf varRollTickCounter = 2 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r2
            ElseIf varRollTickCounter = 3 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r3
            ElseIf varRollTickCounter = 4 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r4
            ElseIf varRollTickCounter = 5 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r5
            ElseIf varRollTickCounter = 6 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r6
            ElseIf varRollTickCounter = 7 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r7
            ElseIf varRollTickCounter = 8 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r8
            ElseIf varRollTickCounter = 9 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r9
            ElseIf varRollTickCounter = 10 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r10
            ElseIf varRollTickCounter = 11 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r11
            ElseIf varRollTickCounter = 12 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r12
            ElseIf varRollTickCounter = 13 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r13
            ElseIf varRollTickCounter = 14 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r14
            ElseIf varRollTickCounter = 15 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r15
            ElseIf varRollTickCounter = 16 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r16
            ElseIf varRollTickCounter = 17 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r17
            ElseIf varRollTickCounter = 18 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r18
            ElseIf varRollTickCounter = 19 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r19
            ElseIf varRollTickCounter = 20 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r20
            ElseIf varRollTickCounter = 21 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r21
            ElseIf varRollTickCounter = 22 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r22
            ElseIf varRollTickCounter = 23 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r23
            End If
        End If

        'keeps track of what the images should be displayed
        varRollTickCounter += 1
        If varRollTickCounter >= 23 Then
            varRollTickCounter = 0
        End If

        'Counts ticks for slot actions
        varSlotTickCounter += 1

        'Sets random pictures according to random variables at appropriate tick
        If varSlotTickCounter >= 100 Then
            If varRandom1 = 0 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r10
            ElseIf varRandom1 = 1 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r14
            ElseIf varRandom1 = 2 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r6
            ElseIf varRandom1 = 3 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r22
            ElseIf varRandom1 = 4 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r18
            ElseIf varRandom1 = 5 Then
                picRSlot1.Image = SlotsMachine.My.Resources.r2
            End If
        End If
        If varSlotTickCounter >= 150 Then
            If varRandom2 = 0 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r10
            ElseIf varRandom2 = 1 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r14
            ElseIf varRandom2 = 2 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r6
            ElseIf varRandom2 = 3 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r22
            ElseIf varRandom2 = 4 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r18
            ElseIf varRandom2 = 5 Then
                picRSlot2.Image = SlotsMachine.My.Resources.r2
            End If
        End If
        If varSlotTickCounter >= 200 Then
            tmrRoller.Enabled = False
            If varRandom3 = 0 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r10
            ElseIf varRandom3 = 1 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r14
            ElseIf varRandom3 = 2 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r6
            ElseIf varRandom3 = 3 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r22
            ElseIf varRandom3 = 4 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r18
            ElseIf varRandom3 = 5 Then
                picRSlot3.Image = SlotsMachine.My.Resources.r2
            End If

            'Gives you money if you win (Three in a row)
            If varRandom1 = 0 And varRandom2 = 0 And varRandom3 = 0 Then
                varUserMoney += varBetWin * 2
                varWinnerPaid += varBetWin * 2
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 1 And varRandom2 = 1 And varRandom3 = 1 Then
                varUserMoney += varBetWin * 10
                varWinnerPaid += varBetWin * 10
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 2 And varRandom2 = 2 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 20
                varWinnerPaid += varBetWin * 20
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 3 And varRandom2 = 3 And varRandom3 = 3 Then
                varUserMoney += varBetWin * 40
                varWinnerPaid += varBetWin * 40
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 4 And varRandom2 = 4 And varRandom3 = 4 Then
                varUserMoney += varBetWin * 60
                varWinnerPaid += varBetWin * 60
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 5 And varRandom2 = 5 And varRandom3 = 5 Then
                varUserMoney += varBetWin * 5000
                varWinnerPaid += varBetWin * 5000
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)

                'Gives you money if you win (ANY BAR)
            ElseIf varRandom1 = 1 And varRandom2 = 1 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 1 And varRandom2 = 1 And varRandom3 = 3 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 1 And varRandom2 = 2 And varRandom3 = 1 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 1 And varRandom2 = 3 And varRandom3 = 1 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 2 And varRandom2 = 1 And varRandom3 = 1 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)

            ElseIf varRandom1 = 3 And varRandom2 = 1 And varRandom3 = 1 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 2 And varRandom2 = 2 And varRandom3 = 1 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 2 And varRandom2 = 2 And varRandom3 = 3 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 2 And varRandom2 = 1 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 2 And varRandom2 = 3 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 1 And varRandom2 = 2 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 3 And varRandom2 = 2 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 3 And varRandom2 = 3 And varRandom3 = 1 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 3 And varRandom2 = 3 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 3 And varRandom2 = 1 And varRandom3 = 3 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 3 And varRandom2 = 2 And varRandom3 = 3 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 1 And varRandom2 = 3 And varRandom3 = 3 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 2 And varRandom2 = 3 And varRandom3 = 3 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            ElseIf varRandom1 = 3 And varRandom2 = 1 And varRandom3 = 2 Then
                varUserMoney += varBetWin * 5
                varWinnerPaid += varBetWin * 5
                varWinCounter += 1
                My.Computer.Audio.Play(SlotsMachine.My.Resources.payout, AudioPlayMode.Background)
            End If

            'total rolls
            varRollCounter += 1

            'Outpts
            lblUserMoney.Text = varUserMoney
            lblWinnerPaid.Text = varWinnerPaid
            lblWinRollCount.Text = "WINS: " & varWinCounter & "   SPINS: " & varRollCounter

            'resets varBetWin for next roll
            varBetWin = 0

            'enables the rollButton
            If varBet > 0 Then
                btnRoll.Visible = True
            End If
        End If
    End Sub

    Private Sub btnRoll_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRoll.MouseDown
        btnRoll.Image = SlotsMachine.My.Resources.spin_down
    End Sub

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.MouseUp
        btnRoll.Image = SlotsMachine.My.Resources.spin_up
        Randomize()
        If tmrRoller.Enabled = False Then

            'resets the tick counter and winnerPaid
            varWinnerPaid = 0
            lblWinnerPaid.Text = varWinnerPaid
            varSlotTickCounter = 0

            'displays and updates the bet
            varBetWin = varBet
            varBet = 0
            lblBet.Text = varBet

            'declares random variables for random pictures
            varRandom1 = Rnd() * 5
            varRandom2 = Rnd() * 5
            varRandom3 = Rnd() * 5

            'disables roll button
            btnRoll.Visible = False

            'starts the roll timer
            tmrRoller.Enabled = True
            My.Computer.Audio.Play(SlotsMachine.My.Resources.spin_real, AudioPlayMode.Background)

        End If
    End Sub

    Private Sub btnAddMoney_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAddMoney.MouseDown
        btnAddMoney.Image = SlotsMachine.My.Resources.addmoney_down
    End Sub

    Private Sub btnAddMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMoney.MouseUp
        btnAddMoney.Image = SlotsMachine.My.Resources.addmoney_up
        Try
            Dim varAddedMoney As Integer = Integer.Parse(InputBox("How many dollars would you like to add to your money?"))

            'shows error if you input negative number
            If varAddedMoney <= -1 Then
                MessageBox.Show("You must enter a value greater than or equal to zero.")
            End If

            'enables bet button if you have money
            If varAddedMoney > 0 Then
                btnIncreaseBet.Visible = True
            End If

            'adds money to user's money
            varUserMoney += varAddedMoney
            lblUserMoney.Text = varUserMoney

            'shows error #####If there is an error, it is havdled my TryParse...won't do
        Catch ext As Exception
        End Try
    End Sub

    Private Sub btnIncreaseBet_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnIncreaseBet.MouseDown
        btnIncreaseBet.Image = SlotsMachine.My.Resources.betone_down
    End Sub

    Private Sub btnIncreaseBet_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncreaseBet.MouseUp
        btnIncreaseBet.Image = SlotsMachine.My.Resources.betone_up

        'disables the bet button if you only have one dollar
        If varUserMoney = 1 Then
            btnIncreaseBet.Visible = False
        End If

        'resets the bet back to $1 after $3
        If varBet = 3 Then
            varBet = 1
            varUserMoney += 2

            'adds and displays bet money
        Else
            varBet += 1
            varUserMoney -= 1
        End If
        lblBet.Text = varBet
        lblUserMoney.Text = varUserMoney

        'enables the roll button when you have money and the roll timer is not enabled
        If varBet > 0 Then
            If tmrRoller.Enabled = False Then
                btnRoll.Visible = True
            End If
        End If
    End Sub

    Private Sub btnExit_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnExit.MouseDown
        btnExit.Image = SlotsMachine.My.Resources.cashout_down
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseUp
        btnExit.Image = SlotsMachine.My.Resources.cashout_up
        'Asks you if you want to exit
        Dim varAnswer As DialogResult = MessageBox.Show("   Wins: " & varWinCounter & vbNewLine _
                                                        & "Spins: " & varRollCounter & vbNewLine _
                                                        & "Your money: " & varUserMoney & vbNewLine _
                                                        & vbNewLine & "Credits:" & vbNewLine _
                                                        & "Code by Josh Gibbs" & vbNewLine _
                                                        & "Graphics by Chris Miles", "Would you like to exit?", MessageBoxButtons.YesNo)
        If varAnswer = Windows.Forms.DialogResult.Yes Then : Me.Close() : End If
    End Sub
End Class