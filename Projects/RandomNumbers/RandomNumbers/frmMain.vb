Public Class frmMain

    'global level variable "Private"
    Private messageString As String

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        'generates random number
        'declares local variable
        Dim RandomInteger As Integer
        'create the random number
        'you only need to do one time per program
        Randomize()
        RandomInteger = Rnd() * 9 + 1

        MessageString = MessageString & RandomInteger & ControlChars.NewLine
        lblOutput.Text = MessageString

    End Sub

    Private Sub btnForLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForLoop.Click
        'this will generate user determined random numbers
        Dim HowManyNumbers As Integer
        Dim myCounter As Integer
        Dim randomInteger As Integer
        Dim sum As Integer
        messageString = ""
        lblOutput.Text = ""
        Randomize()
        HowManyNumbers = Integer.Parse(txtHowMany.Text)

        'for loop for repetitive statements
        For myCounter = 1 To HowManyNumbers
            randomInteger = Rnd() * 9 + 1
            sum += randomInteger
            messageString = messageString & randomInteger & ControlChars.NewLine
        Next
        lblOutput.Text = "Sum = " & sum & ControlChars.NewLine & messageString

    End Sub

    Private Sub btnDoLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoLoop.Click
        Dim myNumber = 4
        Dim myRandom As Integer
        myRandom = 0
        lblOutput.Text = ""
        messageString = ""

        Do Until myRandom = myNumber
            myRandom = Rnd() * 9 + 1
            messageString = messageString & myRandom & ControlChars.NewLine
        Loop
        lblOutput.Text = messageString

    End Sub
End Class
