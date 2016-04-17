'Josh Gibbs
'Period 2
'4 Fabuary 2011
'2D fish project using arrays

Public Class frmMain

    Private varFishPlaceH As Integer
    Private varFishPlaceV As Integer
    Private varEFishPlaceH As Integer
    Private varEFishPlaceV As Integer
    Private varArray(7, 2) As PictureBox
    Private varRightBump As Integer
    Private varLeftBump As Integer
    Private varUpBump As Integer
    Private varDownBump As Integer
    Private varTotalMoves As Integer

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Randomize()
        Dim varRandomH As Integer = Rnd() * 1
        Dim varRandomV As Integer = Rnd() * 1
        Dim varLeft As Boolean

        Dim varERandomH As Integer = Rnd() * 1
        Dim varERandomV As Integer = Rnd() * 1
        Dim varELeft As Boolean

        varArray(0, 0) = pic0a
        varArray(1, 0) = pic1a
        varArray(2, 0) = pic2a
        varArray(3, 0) = pic3a
        varArray(4, 0) = pic4a
        varArray(5, 0) = pic5a
        varArray(6, 0) = pic6a
        varArray(7, 0) = pic7a
        varArray(0, 1) = pic0b
        varArray(1, 1) = pic1b
        varArray(2, 1) = pic2b
        varArray(3, 1) = pic3b
        varArray(4, 1) = pic4b
        varArray(5, 1) = pic5b
        varArray(6, 1) = pic6b
        varArray(7, 1) = pic7b
        varArray(0, 2) = pic0c
        varArray(1, 2) = pic1c
        varArray(2, 2) = pic2c
        varArray(3, 2) = pic3c
        varArray(4, 2) = pic4c
        varArray(5, 2) = pic5c
        varArray(6, 2) = pic6c
        varArray(7, 2) = pic7c

        varArray(varFishPlaceH, varFishPlaceV).Image = My.Resources.picBackground
        varArray(varEFishPlaceH, varEFishPlaceV).Image = My.Resources.picBackground

        If varFishPlaceH = 0 Then
            varLeftBump += 1
            varFishPlaceH += 1
        ElseIf varFishPlaceH = 7 Then
            varRightBump += 1
            varFishPlaceH -= 1
            varLeft = True
        Else
            If varRandomH = 0 Then
                varFishPlaceH -= 1
                varLeft = True
            ElseIf varRandomH = 1 Then
                varFishPlaceH += 1
            End If
        End If

        If varEFishPlaceH = 0 Then
            varEFishPlaceH += 1
        ElseIf varEFishPlaceH = 7 Then
            varEFishPlaceH -= 1
            varELeft = True
        Else
            If varERandomH = 0 Then
                varEFishPlaceH -= 1
                varELeft = True
            ElseIf varERandomH = 1 Then
                varEFishPlaceH += 1
            End If
        End If


        If varFishPlaceV = 0 Then
            varUpBump += 1
            varFishPlaceV += 1
        ElseIf varFishPlaceV = 2 Then
            varDownBump += 1
            varFishPlaceV -= 1
        Else
            If varRandomV = 0 Then
                varFishPlaceV -= 1
            ElseIf varRandomV = 1 Then
                varFishPlaceV += 1
            End If
        End If

        If varEFishPlaceV = 0 Then
            varEFishPlaceV += 1
        ElseIf varEFishPlaceV = 2 Then
            varEFishPlaceV -= 1
        Else
            If varERandomV = 0 Then
                varEFishPlaceV -= 1
            ElseIf varERandomV = 1 Then
                varEFishPlaceV += 1
            End If
        End If


        If varLeft Then
            varArray(varFishPlaceH, varFishPlaceV).Image = My.Resources.picFishLeft
        Else
            varArray(varFishPlaceH, varFishPlaceV).Image = My.Resources.picFishRight
        End If

        If varELeft Then
            varArray(varEFishPlaceH, varEFishPlaceV).Image = My.Resources.picSharkLeft
        Else
            varArray(varEFishPlaceH, varEFishPlaceV).Image = My.Resources.picSharkRight
        End If

        varTotalMoves += 1

        lblBumps.Text = "  Left Bumps: " & varLeftBump & vbNewLine & "Right Bumps: " & varRightBump & vbNewLine & "Total Moves: " & varTotalMoves
        lblVBumps.Text = "     Up Bumps: " & varUpBump & vbNewLine & "Down Bumps: " & varDownBump

        If varEFishPlaceH = varFishPlaceH And varEFishPlaceV = varFishPlaceV Then
            Timer1.Enabled = False
            btnTimer.Text = "Turn Timer On"
            MessageBox.Show("Your fish was eaten!")
            varArray(varFishPlaceH, varFishPlaceV).Image = My.Resources.picBackground
            varArray(varEFishPlaceH, varEFishPlaceV).Image = My.Resources.picBackground
            varLeftBump = 0
            varRightBump = 0
            varUpBump = 0
            varDownBump = 0
            varTotalMoves = 0
            varFishPlaceH = Rnd() * 7
            varFishPlaceV = Rnd() * 2
            varEFishPlaceH = Rnd() * 7
            varEFishPlaceV = Rnd() * 2
            btnMove.PerformClick()
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        varFishPlaceH = Rnd() * 7
        varFishPlaceV = Rnd() * 2
        varEFishPlaceH = Rnd() * 7
        varEFishPlaceV = Rnd() * 2
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

    Private Sub cboSpeed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSpeed.SelectedIndexChanged
        If cboSpeed.SelectedIndex = 0 Then
            Timer1.Interval = 1
        ElseIf cboSpeed.SelectedIndex = 1 Then
            Timer1.Interval = 50
        ElseIf cboSpeed.SelectedIndex = 2 Then
            Timer1.Interval = 150
        ElseIf cboSpeed.SelectedIndex = 3 Then
            Timer1.Interval = 250
        ElseIf cboSpeed.SelectedIndex = 4 Then
            Timer1.Interval = 400
        End If
    End Sub
End Class