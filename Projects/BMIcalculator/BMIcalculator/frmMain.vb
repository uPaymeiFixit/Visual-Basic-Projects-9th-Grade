'Josh Gibbs
'4 October 2010
'Period 2
'BMI Calculator

Public Class frmMain

    'declares global variables
    Private totalPeopleInteger As Integer
    Private totalBMIDecimal As Decimal

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        'this declares temporary variable. The only tmp one...
        Dim BMIDecimal As Decimal

        'this tests the calculation
        Try

            'this calculates the BMI... IN ONE LINE
            BMIDecimal = ((Decimal.Parse(txtPounds.Text) * 0.454) / (((Decimal.Parse(txtFeet.Text) * 0.3048) + (Decimal.Parse(txtInch.Text) * 0.0254)) ^ 2))

            'this adds stuff up
            totalPeopleInteger += 1
            totalBMIDecimal += BMIDecimal

            'this displays information in labels
            lblAverageBMI.Text = (totalBMIDecimal / totalPeopleInteger).ToString("N")
            lblTotalPeople.Text = totalPeopleInteger
            lblBMI.Text = BMIDecimal.ToString("N")

            'this resets the text boxes and sets focus
            txtFeet.Text = "Feet"
            txtPounds.Text = "Pounds"
            txtInch.Text = "Inches"
            txtFeet.Focus()

            'this displays info about your BMI *****"Healthy" doesn't work if it's first!*****
            If BMIDecimal > 25 Then
                lblInfo.Text = "Overfed"
            ElseIf BMIDecimal < 18.5 Then
                lblInfo.Text = "Hungry"
            ElseIf BMIDecimal > 25 < 18.5 Then
                lblInfo.Text = "Healthy"
            End If

            'this displays a dialog box if there is a problem
        Catch ex As Exception
            MessageBox.Show("You need to enter information.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim resultDialogAnswer = MessageBox.Show("Are you sure", _
                                             "Clear Form?", MessageBoxButtons.YesNo, _
                                             MessageBoxIcon.Question)

        If resultDialogAnswer = Windows.Forms.DialogResult.Yes Then

            'this resets the whole form
            txtFeet.Text = "Feet"
            txtPounds.Text = "Pounds"
            txtInch.Text = "Inches"
            txtFeet.Focus()
            lblBMI.Text = ""
            lblAverageBMI.Text = ""
            lblTotalPeople.Text = ""
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'this exits the program
        Me.Close()
    End Sub
End Class
