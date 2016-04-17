'Josh Gibbs
'Period 2
'27 April 2011
'Fishrageous

'To-Do
'can't use keypress

Public Class frmMain

    Public aryFish(0) As PictureBox

    Private topHits As Integer
    Private bottomHits As Integer
    Private leftHits As Integer
    Private rightHits As Integer

    Public varSpeed As Integer = 1

    Public winXLocation As Integer
    Public winYLocation As Integer
    Public winWidth As Integer
    Public winHeight As Integer

    Public winFullscreen As Boolean

    Public varNotificationLengthCounter As Integer
    Public varNotificationsGoingUp As Boolean

    Public varNumberOfFish As Integer = -1

    Private Sub frmMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'makes program run in a "Fullscreen" mode when F11 is pressed
        btnFullscreen.PerformClick()
    End Sub

    Private Sub btnFullscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFullscreen.Click
        If winFullscreen = False Then
            winXLocation = Me.Left
            winYLocation = Me.Top
            winHeight = Me.Height
            winWidth = Me.Width
            Me.WindowState = FormWindowState.Maximized
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.BackColor = Color.Lime

            lblNotification.Top = lblNotification.Height * -1
            lblNotification.Left = Me.Width / 2 - lblNotification.Width / 2
            lblNotification.Text = " " & vbNewLine & "Press F11 or F to disable fullscreen"
            varNotificationLengthCounter = 0
            varNotificationsGoingUp = False
            tmrNotification.Enabled = True

            winFullscreen = True
        ElseIf winFullscreen = True Then
            Me.WindowState = FormWindowState.Normal
            FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.SetBounds(winXLocation, winYLocation, winWidth, winHeight)
            Me.BackColor = Color.LightBlue
            Me.Width = winWidth
            Me.Height = winHeight
            Me.Left = winXLocation
            Me.Top = winYLocation

            lblNotification.Top = lblNotification.Height * -1
            lblNotification.Left = Me.Width / 2 - lblNotification.Width / 2
            lblNotification.Text = " " & vbNewLine & "Press F11 or F to enable fullscreen"
            varNotificationLengthCounter = 0
            varNotificationsGoingUp = False
            tmrNotification.Enabled = True

            winFullscreen = False
        End If
    End Sub

    Private Sub trmNotification_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrNotification.Tick
        'animates the notification slide
        'tries to move notification
        If lblNotification.Top < 0 And varNotificationsGoingUp = False Then
            lblNotification.Top += 1
        ElseIf lblNotification.Bottom > 0 And varNotificationsGoingUp = True Then
            lblNotification.Top -= 1
        End If
        'counts time notification is up
        varNotificationLengthCounter += 1
        If varNotificationLengthCounter >= lblNotification.Height + 35 And varNotificationLengthCounter < lblNotification.Height * 2 + 35 Then
            varNotificationsGoingUp = True
        ElseIf varNotificationLengthCounter >= 86 Then
            tmrNotification.Enabled = False
        End If
    End Sub

    Private Sub tmrMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMovement.Tick
        'moves each fish
        Randomize()
        For i = 0 To varNumberOfFish

            '//Random numbers in visual basic do not work well because the max and min number occur much less often then other numbers.
            '//This is because the nubers generated are any number on a number line rounded to the first whole number, but since the
            'only the numbers between maximum and minimum are generated, the end numbers have only a 50% chance of a number in between
            'max and min. 
            '//These numbers are the numbers that can be generated and what they are assigned to with rnd()*2: 
            '0.00 through 0.44 is rounded to 0 \\ 0.45 through 1.44 is rounded to 1 \\ 1.45 to 2.00 is rounded to 2
            '//Notice the difference between these numbers, 0.44 - 0.00 = 0.44 \\ 1.44 - 0.45 = 0.99 \\ 2.00 - 1.45 = 0.55
            'Based on the above numbers, the chances of these numbers being picked are  22%  50%  and 27%
            '//A slightly inefficient workaround for this is generating two more numbers than needed and just use the
            'numbers that are not the max and min -- (uPaymeiFixit This is just a guess on yy part)

            Dim r As Int16 = Rnd() * 5
            If r = 4 Then
                'tries moves fish left
                If aryFish(i).Left >= varSpeed Then
                    aryFish(i).Image = My.Resources.picFishLeft
                    aryFish(i).Left -= varSpeed
                Else
                    aryFish(i).Image = My.Resources.picFishRight
                    aryFish(i).Top += varSpeed
                    leftHits += 1
                End If
            ElseIf r = 1 Then
                'tries to move fish up
                If aryFish(i).Top >= varSpeed Then
                    aryFish(i).Top -= varSpeed
                Else
                    aryFish(i).Top += varSpeed
                    topHits += 1
                End If
            ElseIf r = 2 Then
                'tries to move fish right
                If aryFish(i).Right <= Me.Width - varSpeed Then
                    aryFish(i).Image = My.Resources.picFishRight
                    aryFish(i).Left += varSpeed
                Else
                    aryFish(i).Image = My.Resources.picFishLeft
                    aryFish(i).Left -= varSpeed
                    rightHits += 1
                End If
            ElseIf r = 3 Then
                'tries to move fish down
                If aryFish(i).Bottom <= Me.Height - varSpeed - 20 Then
                    aryFish(i).Top += varSpeed
                Else
                    aryFish(i).Top -= varSpeed
                    bottomHits += 1
                End If
            End If
        Next

        'Outputs bumps
        lblBumps.Text = vbNewLine & "  Bump Counts  " & vbNewLine & vbNewLine & _
            "    Left: " & leftHits & vbNewLine & _
            "   Right: " & rightHits & vbNewLine & _
            "     Top: " & topHits & vbNewLine & _
            "  Bottom: " & bottomHits & vbNewLine & vbNewLine & " "
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'creates a new fish and adds it to the array
        varNumberOfFish += 1
        ReDim Preserve aryFish(varNumberOfFish)
        aryFish(varNumberOfFish) = New PictureBox
        Me.Controls.Add(aryFish(varNumberOfFish))

        'sets the fish properties
        aryFish(varNumberOfFish).Height = 50
        aryFish(varNumberOfFish).Width = 100
        aryFish(varNumberOfFish).Location = New Point((Rnd() * (Me.Width - 100)), (Rnd() * (Me.Height - 50)))
        aryFish(varNumberOfFish).SizeMode = PictureBoxSizeMode.StretchImage
        aryFish(varNumberOfFish).Image = My.Resources.picFishRight

        'starts the game if it isn't already
        tmrMovement.Enabled = True

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        'removes fish from the array
        If varNumberOfFish > -1 Then
            Me.Controls.Remove(aryFish(varNumberOfFish))
            varNumberOfFish -= 1
        End If
    End Sub
End Class