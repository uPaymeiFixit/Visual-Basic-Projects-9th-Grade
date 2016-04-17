'Josh Gibbs
'Period 2
'23 September 2010
'Help page

Public Class frmMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'this shows the picture and text
        picLogo1.Visible = True
        lblAbout.Visible = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'this exits the program
        Me.Close()
    End Sub

    Private Sub picLogo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogo1.Click
        'this changes to picture 2
        picLogo1.Visible = False
        picLogo2.Visible = True
    End Sub

    Private Sub picLogo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogo2.Click
        'this changes to picture 1
        picLogo2.Visible = False
        picLogo1.Visible = True
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        'this changes label font
        With FontDialog1
            .ShowDialog()
            lblAbout.Font = .Font
        End With
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        'this changes label color
        With ColorDialog1
            .ShowDialog()
            lblAbout.ForeColor = .Color
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'This flashes the lblBar
        If lblColor.BackColor = Color.Black Then
            lblColor.BackColor = Color.Red
        ElseIf lblColor.BackColor = Color.Red Then
            lblColor.BackColor = Color.Yellow
        ElseIf lblColor.BackColor = Color.Yellow Then
            lblColor.BackColor = Color.Green
        ElseIf lblColor.BackColor = Color.Green Then
            lblColor.BackColor = Color.Pink
        ElseIf lblColor.BackColor = Color.Pink Then
            lblColor.BackColor = Color.Black
        End If
    End Sub

    Private Sub btnFlash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlash.Click
        'This starts the timer
        picLogo1.Visible = True
        picLogo2.Visible = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'this flashes the pictures
        If picLogo1.Visible = True Then
            picLogo1.Visible = False
            picLogo2.Visible = True
        ElseIf picLogo1.Visible = False Then
            picLogo1.Visible = True
            picLogo2.Visible = False
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        'this flashes frmMain
        If Me.BackColor = Color.LightGray Then
            Me.BackColor = Color.Red
        ElseIf Me.BackColor = Color.Red Then
            Me.BackColor = Color.Orange
        ElseIf Me.BackColor = Color.Orange Then
            Me.BackColor = Color.Yellow
        ElseIf Me.BackColor = Color.Yellow Then
            Me.BackColor = Color.Green
        ElseIf Me.BackColor = Color.Green Then
            Me.BackColor = Color.Blue
        ElseIf Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Purple
        ElseIf Me.BackColor = Color.Purple Then
            Me.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'this resets everything
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Me.BackColor = Color.LightGray
        picLogo1.Visible = False
        picLogo2.Visible = False
        lblColor.BackColor = Color.Black
        lblAbout.Visible = False
    End Sub
End Class
