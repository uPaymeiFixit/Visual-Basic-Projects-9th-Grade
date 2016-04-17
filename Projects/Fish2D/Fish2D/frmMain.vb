Public Class frmMain
    'declare an array to hold the picture box
    'determining the size of the tank
    Dim myAquarium(2, 3) As PictureBox
    '2 refers to number of rows and 3 refers to number of colums
    Dim row As Integer
    Dim col As Integer
    Dim onOff As Boolean
    'boolean true or false

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        'this moves the fish randomly to any square
        myAquarium(row, col).Image = My.Resources.picBkg
        row = Rnd() * 2
        col = Rnd() * 3
        myAquarium(row, col).Image = My.Resources.picFishRight
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'this runs one time when the program starts up
        'set up the tank
        myAquarium(0, 0) = PictureBox1
        myAquarium(0, 1) = PictureBox2
        myAquarium(0, 2) = PictureBox3
        myAquarium(0, 3) = PictureBox4
        myAquarium(1, 0) = PictureBox5
        myAquarium(1, 1) = PictureBox6
        myAquarium(1, 2) = PictureBox7
        myAquarium(1, 3) = PictureBox8
        myAquarium(2, 0) = PictureBox9
        myAquarium(2, 1) = PictureBox10
        myAquarium(2, 2) = PictureBox11
        myAquarium(2, 3) = PictureBox12
        'randomly placing fish in tank
        Randomize()
        row = Rnd() * 2
        col = Rnd() * 3
        myAquarium(row, col).Image = My.Resources.picFishRight
        onOff = False
    End Sub

    Private Sub btnAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuto.Click
        'this is a switch to turn the timer off
        If onOff = False Then
            Timer1.Enabled = True
            onOff = True
        ElseIf onOff = True Then
            Timer1.Enabled = False
            onOff = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        btnMove_Click(sender, e)
    End Sub
End Class
