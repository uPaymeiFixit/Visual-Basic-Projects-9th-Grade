'Josh Gibbs
'Period 2
'20 September 2010
'Mailing Label 

Public Class frmMain

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPush.Click
        'Changes puts txts' Text in lblMain
        lblMain.Text = txtName.Text & " " & txtLast.Text & ControlChars.NewLine & txtStreet.Text & ControlChars.NewLine & txtCity.Text & ", " & txtState.Text & " " & txtZip.Text
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Exits the program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'Resets form
        txtName.Text = "First Name"
        txtLast.Text = "Last Name"
        txtStreet.Text = "Street"
        txtCity.Text = "City"
        txtState.Text = "State"
        txtZip.Text = "Zip Code"
        lblMain.Text = "Josh Gibbs" & ControlChars.NewLine & "2813 Wagon Wheel Way" & ControlChars.NewLine & "Troy, Ohio 45373"
    End Sub
End Class
