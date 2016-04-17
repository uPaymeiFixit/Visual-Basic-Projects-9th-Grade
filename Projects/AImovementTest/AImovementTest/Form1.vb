Public Class frmAImovementTest

    Private ai_ammount As Int16 = 29
    Private ai(ai_ammount) As Label

    'Destination variabels
    Private d_X(ai_ammount) As Int16
    Private d_Y(ai_ammount) As Int16


    'Properties variables
    Private p_speed As Int16 = 5

    Private Sub doNewDestination(ByVal i)
        d_X(i) = Rnd() * (Me.Width - ai(0).Width)
        d_Y(i) = Rnd() * (Me.Height - ai(0).Height)
    End Sub

    Private tmp As Int16

    Private Sub tmraiMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmraiMovement.Tick
        For i = 0 To ai_ammount
            If ai(i).Left < d_X(i) Then
                ai(i).Left += p_speed
            ElseIf ai(i).Left > d_X(i) Then
                ai(i).Left -= p_speed
            End If
            If ai(i).Top < d_Y(i) Then
                ai(i).Top += p_speed
            ElseIf ai(i).Top > d_Y(i) Then
                ai(i).Top -= p_speed
            End If

            If ai(i).Left < d_X(i) + p_speed And ai(i).Left > d_X(i) - p_speed And ai(i).Top < d_Y(i) + p_speed And ai(i).Top > d_Y(i) - p_speed Then
                doNewDestination(i)
            End If

            ai(i).SetBounds(ai(i).Left, ai(i).Top, ai(i).Width, ai(i).Height)

            For n = 0 To ai_ammount

                If ai(i).BackColor = Color.Blue And ai(i).Bounds.IntersectsWith(ai(n).Bounds) Then
                    ai(n).BackColor = Color.Blue
                ElseIf ai(i).BackColor = Color.Red And ai(i).Bounds.IntersectsWith(ai(n).Bounds) Then
                    ai(n).BackColor = Color.Red
                End If
            Next

        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Me.WindowState = FormWindowState.Maximized
        

        For i = 0 To ai_ammount

            ai(i) = New Label
            Me.Controls.Add(ai(i))




            ai(i).Width = 30
            ai(i).Height = 30
            ai(i).Text = "ai(" & i & ")"

            If i = 0 Then
                ai(i).BackColor = Color.Red
            ElseIf i = 1 Then
                ai(i).BackColor = Color.Blue
            Else
                ai(i).BackColor = Color.Lime
            End If


            doNewDestination(i)
            ai(i).Left = d_X(i)
            ai(i).Top = d_Y(i)
            doNewDestination(i)



        Next
    End Sub
End Class
