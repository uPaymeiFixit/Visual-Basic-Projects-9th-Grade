'Josh Gibbs
'Period 2
'23 October 2010
'Random Dice Program

'NOTE TO SELF -- (Defined: and Needed:)
'I started using (Defined: and Needed:) in my remarks
'to help me with the order that things go in. It helps.
'If Defined or Needed is not in the remark then nothing
'is needed or defined, or it is not important.

Public Class frmMain

    'global variables for sum totals
    Private Sum2Integer As Integer
    Private Sum3Integer As Integer
    Private Sum4Integer As Integer
    Private Sum5Integer As Integer
    Private Sum6Integer As Integer
    Private Sum7Integer As Integer
    Private Sum8Integer As Integer
    Private Sum9Integer As Integer
    Private Sum10Integer As Integer
    Private Sum11Integer As Integer
    Private Sum12Integer As Integer

    'global variable for total times rolled
    Private rollCountInteger As Integer

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click

        'adds up roll count 
        '(Defined: rollCountInteger)
        rollCountInteger += 1

        'declares variables for dice 
        '(Defined: random1Integer - random2Integer)
        Randomize()
        Dim random1Integer As Integer = Rnd() * 5 + 1
        Dim random2Integer As Integer = Rnd() * 5 + 1

        'variable for greatest sum integer 
        '(Defined: greatestInteger)
        Dim greatestInteger As Integer


        'Finds largest SumInteger 
        '(Defined: greatestInteger) (Needed: Sum2Integer - Sum12Integer and greatestInteger)
        If Sum2Integer > greatestInteger Then
            greatestInteger = Sum2Integer
        End If
        If Sum3Integer > greatestInteger Then
            greatestInteger = Sum3Integer
        End If
        If Sum4Integer > greatestInteger Then
            greatestInteger = Sum4Integer
        End If
        If Sum5Integer > greatestInteger Then
            greatestInteger = Sum5Integer
        End If
        If Sum6Integer > greatestInteger Then
            greatestInteger = Sum6Integer
        End If
        If Sum7Integer > greatestInteger Then
            greatestInteger = Sum7Integer
        End If
        If Sum8Integer > greatestInteger Then
            greatestInteger = Sum8Integer
        End If
        If Sum9Integer > greatestInteger Then
            greatestInteger = Sum9Integer
        End If
        If Sum10Integer > greatestInteger Then
            greatestInteger = Sum10Integer
        End If
        If Sum11Integer > greatestInteger Then
            greatestInteger = Sum11Integer
        End If
        If Sum12Integer > greatestInteger Then
            greatestInteger = Sum12Integer
        End If

        'changes pictures of dice 
        '(Defined: picDiceI.Image - picDiceII.Image) (Needed: random1Integer - random2Integer)
        If random1Integer = 1 Then
            picDiceI.Image = picDice1.Image
        ElseIf random1Integer = 2 Then
            picDiceI.Image = picDice2.Image
        ElseIf random1Integer = 3 Then
            picDiceI.Image = picDice3.Image
        ElseIf random1Integer = 4 Then
            picDiceI.Image = picDice4.Image
        ElseIf random1Integer = 5 Then
            picDiceI.Image = picDice5.Image
        ElseIf random1Integer = 6 Then
            picDiceI.Image = picDice6.Image
        End If
        If random2Integer = 1 Then
            picDiceII.Image = picDice1.Image
        ElseIf random2Integer = 2 Then
            picDiceII.Image = picDice2.Image
        ElseIf random2Integer = 3 Then
            picDiceII.Image = picDice3.Image
        ElseIf random2Integer = 4 Then
            picDiceII.Image = picDice4.Image
        ElseIf random2Integer = 5 Then
            picDiceII.Image = picDice5.Image
        ElseIf random2Integer = 6 Then
            picDiceII.Image = picDice6.Image
        End If

        'adds up sums 
        '(Defined: Sum2Integer - Sum12Integer and lblSum2Per.Text - lblSum12Per.Text) (Needed: random1Integer - random2Integer and Sum2Integer - Sum12Integer)
        If random1Integer + random2Integer = 2 Then
            Sum2Integer += 1
            lblSum2Per.Text = (Sum2Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 3 Then
            Sum3Integer += 1
            lblSum3Per.Text = (Sum3Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 4 Then
            Sum4Integer += 1
            lblSum4Per.Text = (Sum4Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 5 Then
            Sum5Integer += 1
            lblSum5Per.Text = (Sum5Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 6 Then
            Sum6Integer += 1
            lblSum6Per.Text = (Sum6Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 7 Then
            Sum7Integer += 1
            lblSum7Per.Text = (Sum7Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 8 Then
            Sum8Integer += 1
            lblSum8Per.Text = (Sum8Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 9 Then
            Sum9Integer += 1
            lblSum9Per.Text = (Sum9Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 10 Then
            Sum10Integer += 1
            lblSum10Per.Text = (Sum10Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 11 Then
            Sum11Integer += 1
            lblSum11Per.Text = (Sum11Integer / rollCountInteger).ToString("P")
        ElseIf random1Integer + random2Integer = 12 Then
            Sum12Integer += 1
            lblSum12Per.Text = (Sum12Integer / rollCountInteger).ToString("P")
        End If


        'sets max value for pgbs 
        '(Defined: pgbSum2.Maximum - pgbSum12.Maximum) (Needed: greatestInteger)
        pgbSum2.Maximum = greatestInteger + 1
        pgbSum3.Maximum = greatestInteger + 1
        pgbSum4.Maximum = greatestInteger + 1
        pgbSum5.Maximum = greatestInteger + 1
        pgbSum6.Maximum = greatestInteger + 1
        pgbSum7.Maximum = greatestInteger + 1
        pgbSum8.Maximum = greatestInteger + 1
        pgbSum9.Maximum = greatestInteger + 1
        pgbSum10.Maximum = greatestInteger + 1
        pgbSum11.Maximum = greatestInteger + 1
        pgbSum12.Maximum = greatestInteger + 1

        'sets values for pgbs 
        '(Defined: pgbSum2.Value - pgbSum12.Value) (Needed: Sum2Integer - Sum12Integer and pgbSum2.Maximum - pgbSum12.Maximum))
        pgbSum2.Value = Sum2Integer
        pgbSum3.Value = Sum3Integer
        pgbSum4.Value = Sum4Integer
        pgbSum5.Value = Sum5Integer
        pgbSum6.Value = Sum6Integer
        pgbSum7.Value = Sum7Integer
        pgbSum8.Value = Sum8Integer
        pgbSum9.Value = Sum9Integer
        pgbSum10.Value = Sum10Integer
        pgbSum11.Value = Sum11Integer
        pgbSum12.Value = Sum12Integer

        'outputs sum counter info to labels 
        '(Defined: lblSum2.Text - lblSum12.Text) (Needed: Sum2Integer - Sum12Integer and rollCountInteger)
        lblSum2.Text = "Sum of 2 is " & Sum2Integer & " out of " & rollCountInteger & " rolls"
        lblSum3.Text = "Sum of 3 is " & Sum3Integer & " out of " & rollCountInteger & " rolls"
        lblSum4.Text = "Sum of 4 is " & Sum4Integer & " out of " & rollCountInteger & " rolls"
        lblSum5.Text = "Sum of 5 is " & Sum5Integer & " out of " & rollCountInteger & " rolls"
        lblSum6.Text = "Sum of 6 is " & Sum6Integer & " out of " & rollCountInteger & " rolls"
        lblSum7.Text = "Sum of 7 is " & Sum7Integer & " out of " & rollCountInteger & " rolls"
        lblSum8.Text = "Sum of 8 is " & Sum8Integer & " out of " & rollCountInteger & " rolls"
        lblSum9.Text = "Sum of 9 is " & Sum9Integer & " out of " & rollCountInteger & " rolls"
        lblSum10.Text = "Sum of 10 is " & Sum10Integer & " out of " & rollCountInteger & " rolls"
        lblSum11.Text = "Sum of 11 is " & Sum11Integer & " out of " & rollCountInteger & " rolls"
        lblSum12.Text = "Sum of 12 is " & Sum12Integer & " out of " & rollCountInteger & " rolls"

        'outputs sum of dice 
        '(Defined: lblSum.Text) (Needed: random1Integer - random2Integer)
        lblSum.Text = "=  " & random1Integer + random2Integer

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick
        'clicks button every tick
        btnRoll.PerformClick()
    End Sub

    Private Sub cbxRefresh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxRefresh.SelectedIndexChanged
        'sets speed of timer tick interval (Defined: tmrRefresh.Enables and tmrRefresh.Interval)
        If cbxRefresh.SelectedItem = "Do not automatically roll" Then
            tmrRefresh.Enabled = False
        ElseIf cbxRefresh.SelectedItem = "Roll 1 time per second" Then
            tmrRefresh.Interval = 1000
            tmrRefresh.Enabled = True
        ElseIf cbxRefresh.SelectedItem = "Roll 10 times per second" Then
            tmrRefresh.Interval = 100
            tmrRefresh.Enabled = True
        ElseIf cbxRefresh.SelectedItem = "Roll 100 times per second" Then
            tmrRefresh.Interval = 10
            tmrRefresh.Enabled = True
        ElseIf cbxRefresh.SelectedItem = "Roll 1000 times per second" Then
            tmrRefresh.Interval = 1
            tmrRefresh.Enabled = True
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'closes the form
        Me.Close()
    End Sub
End Class
