'Josh Gibbs
'Period 2
'2 Fabuary 2011
'1D fish project using arrays

Public Class frmMain

    Private varFishPlace As Integer
    Private varArray(7) As PictureBox
    Private varRightBump As Integer
    Private varLeftBump As Integer
    Private varTotalMoves As Integer

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Randomize()
        Dim varRandom As Integer = Rnd() * 1
        Dim varLeft As Boolean

        varArray(0) = pic0
        varArray(1) = pic1
        varArray(2) = pic2
        varArray(3) = pic3
        varArray(4) = pic4
        varArray(5) = pic5
        varArray(6) = pic6
        varArray(7) = pic7

        varArray(varFishPlace).Image = My.Resources.picBackground

        If varFishPlace = 0 Then
            varLeftBump += 1
            varFishPlace += 1
        ElseIf varFishPlace = 7 Then
            varRightBump += 1
            varFishPlace -= 1
            varLeft = True
        Else
            If varRandom = 0 Then
                varFishPlace -= 1
                varLeft = True
            ElseIf varRandom = 1 Then
                varFishPlace += 1
            End If
        End If

        If varLeft Then
            varArray(varFishPlace).Image = My.Resources.picFishLeft
        Else
            varArray(varFishPlace).Image = My.Resources.picFishRight
        End If

        varTotalMoves += 1

        lblBumps.Text = "  Left Bumps: " & varLeftBump & vbNewLine & "Right Bumps: " & varRightBump & vbNewLine & "Total Moves: " & varTotalMoves

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        varFishPlace = Rnd() * 7
        btnMove.PerformClick()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        btnMove_Click(sender, e)
    End Sub

    Private Sub btnTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimer.Click
        If btnTimer.Text = "Turn Timer On" Then
            Timer1.Enabled = True
            btnTimer.Text = "Turn Timer Off"
        Else
            Timer1.Enabled = False
            btnTimer.Text = "Turn Timer On"
        End If
    End Sub
End Class