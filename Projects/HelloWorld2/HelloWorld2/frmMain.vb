
'Josh Gibbs
'Period 2
'27 September 2010
'Random practice

Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnText.Click
        'This changes the text
        lblMessage.Text = "Wazz up 2"
        'This changes the label color
        lblMessage.ForeColor = Color.Blue
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This exits the program
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSad.Click
        'This makes the sad picture invizible
        picSad.Visible = False
        'This makes the happy picture visible
        picHappy.Visible = True
    End Sub

    Private Sub picHappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHappy.Click
        'This makes the sad picture invizible
        picSad.Visible = True
        'This makes the happy picture visible
        picHappy.Visible = False
    End Sub

    Private Sub lblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName.Click
        'This shows period when clicked
        lblName.Text = "Period 2"
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        'This changes color of font
        With ColorDialog1
            .ShowDialog()
            lblMessage.ForeColor = .Color
        End With
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        'This changes font
        With FontDialog1
            .ShowDialog()
            lblMessage.Font = .Font
        End With
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        btnName.Text = txtName.Text & " " & txtLast.Text
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPush.Click
        'This starts the timer
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'This quickly changes color
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

    Private Sub chkPicture_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPicture.CheckedChanged
        'this tells the picture wether to hide or not
        If chkPicture.Checked = True Then
            picSad.Visible = True
            picHappy.Visible = False
        ElseIf chkPicture.Checked = False Then
            picHappy.Visible = True
            picSad.Visible = False
        End If
    End Sub

    Private Sub rbRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRed.CheckedChanged
        'this changes lblBar color to red
        lblbar.BackColor = Color.Red
    End Sub

    Private Sub rbBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBlue.CheckedChanged
        'this changes lblBar color to Blue
        lblbar.BackColor = Color.Blue
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Text = "This is my second project" Then
            Me.Text = " .........."
        ElseIf Me.Text = " .........." Then
            Me.Text = ". ........."
        ElseIf Me.Text = ". ........." Then
            Me.Text = ".. ........"
        ElseIf Me.Text = ".. ........" Then
            Me.Text = "... ......."
        ElseIf Me.Text = "... ......." Then
            Me.Text = ".... ......"
        ElseIf Me.Text = ".... ......" Then
            Me.Text = "..... ....."
        ElseIf Me.Text = "..... ....." Then
            Me.Text = "...... ...."
        ElseIf Me.Text = "...... ...." Then
            Me.Text = "....... ..."
        ElseIf Me.Text = "....... ..." Then
            Me.Text = "........ .."
        ElseIf Me.Text = "........ .." Then
            Me.Text = "......... ."
        ElseIf Me.Text = "......... ." Then
            Me.Text = " .........."

        End If
    End Sub
End Class