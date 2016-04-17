Public Class frmMemoryGame
    'Game variables
    Private g_Level As Int16 = 1
    Private g_Stage As Int16 = 1

    'Logic variables
    Private l_RandomOne As Int16
    Private l_RandomTwo As Int16
    Private l_LandedNumber As Int16

    'Time variables
    Private t_OnWait As Int16 = 7
    Private t_OffWait As Int16 = 3
    Private t_Time As Int16

    'Color variables
    Private c_isLit As Boolean

    'Input variables
    Private i_button(10) As Int16
    Private i_Stage As Int16


    Private Sub doRandom()
        l_RandomOne = Rnd() * 1
        l_RandomTwo = Rnd() * 1

        If l_RandomOne = 0 And l_RandomTwo = 0 Then
            l_LandedNumber = 1
        ElseIf l_RandomOne = 0 And l_RandomTwo = 1 Then
            l_LandedNumber = 2
        ElseIf l_RandomOne = 1 And l_RandomTwo = 0 Then
            l_LandedNumber = 3
        ElseIf l_RandomOne = 1 And l_RandomTwo = 1 Then
            l_LandedNumber = 4
        End If

    End Sub

    Private Sub doColor()
        If l_LandedNumber = 0 Then
            btnOne.BackColor = Color.Red
            btnTwo.BackColor = Color.Yellow
            btnThree.BackColor = Color.Blue
            btnFour.BackColor = Color.Lime
        ElseIf l_LandedNumber = 1 Then
            btnOne.BackColor = Color.DarkRed
        ElseIf l_LandedNumber = 2 Then
            btnTwo.BackColor = Color.Olive
        ElseIf l_LandedNumber = 3 Then
            btnThree.BackColor = Color.Navy
        ElseIf l_LandedNumber = 4 Then
            btnFour.BackColor = Color.Green
        End If
    End Sub

    Private Sub doLevelComplete()
        If i_Stage = g_Level Then
            i_Stage = 0
            g_Level += 1
            Me.Text = "Memory Game -- Level " & g_Level
            tmrAIO.Enabled = True
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Randomize()
        btnStart.Visible = False

        Me.Text = "Memory Game -- Level 1"

        tmrAIO.Enabled = True

    End Sub

    Private Sub tmrAIO_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAIO.Tick

        t_Time += 1

        If c_isLit Then
            If t_Time = t_OnWait Then
                l_LandedNumber = 0
                doColor()
                c_isLit = False
                t_Time = 0

                If g_Stage = g_Level Then
                    tmrAIO.Enabled = False
                    btnOne.Enabled = True
                    btnTwo.Enabled = True
                    btnThree.Enabled = True
                    btnFour.Enabled = True
                Else
                    g_Stage += 1
                End If
            End If
        Else
            If t_Time = t_OffWait Then
                doRandom()
                doColor()
                c_isLit = True
                t_Time = 0
                i_button(g_Stage) = l_LandedNumber
            End If
        End If

    End Sub

    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        i_Stage += 1
        If i_button(i_Stage) <> 1 Then
            btnStart.Visible = True
        End If
        doLevelComplete()
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        i_Stage += 1
        If i_button(i_Stage) <> 2 Then
            btnStart.Visible = True
        End If
        doLevelComplete()
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        i_Stage += 1
        If i_button(i_Stage) <> 3 Then
            btnStart.Visible = True
        End If
        doLevelComplete()
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        i_Stage += 1
        If i_button(i_Stage) <> 4 Then
            btnStart.Visible = True
        End If
        doLevelComplete()
    End Sub
End Class