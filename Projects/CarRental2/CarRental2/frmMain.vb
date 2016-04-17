'Josh Gibbs
'13 October 2010
'Period 2
'Car Rental Calculator 2 (three cars)

Public Class frmMain

    'declares private variables (add up)
    Private totalPeople As Integer
    Private totalChargeSub As Decimal

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        'Make variables and declare them as Decimals or Intergers (Storing the Information)
        Dim milesDriven As Decimal
        Dim beginningOdomiterReading As Decimal
        Dim endOdomiterReading As Decimal
        Dim daysRented As Integer
        Dim averageCharge As Decimal
        Dim totalCharge As Decimal
        Dim dayRate As Integer
        Dim mileRate As Decimal

        Try

            'Says that these txt inputs are numbers, and connects them to text boxes
            endOdomiterReading = Decimal.Parse(txtEndingOdomiterReading.Text)
            beginningOdomiterReading = Decimal.Parse(txtBeginningOdomiterReading.Text)
            daysRented = Decimal.Parse(txtDaysRented.Text)

            'declares day and mile Rate depending on radio button
            If radPrius.Checked Then
                dayRate = 15
                mileRate = 0.12
            ElseIf rad350Z.Checked Then
                dayRate = 20
                mileRate = 0.15
            ElseIf radRescue1.Checked Then
                dayRate = 25
                mileRate = 0.2
            End If

            'adds optinal things if selected
            If chkLeather.Checked = True Then
                dayRate = dayRate + 2
            End If
            If chkBose.Checked Then
                dayRate = dayRate + 3
            End If

            'Calculates miles driven
            milesDriven = endOdomiterReading - beginningOdomiterReading

            'fixes user error if any
            If milesDriven < 0 Then
                milesDriven = beginningOdomiterReading - endOdomiterReading
            End If

            'Calculates ammount due
            If milesDriven > 100 Then
                totalCharge = ((daysRented * dayRate) + (milesDriven * mileRate))
            ElseIf totalCharge <= 100 Then
                totalCharge = (daysRented * dayRate)
            End If

            'says that 1 is added every time totalPeople is used
            totalPeople += 1

            'calculates average charge
            totalChargeSub += totalCharge
            averageCharge = totalChargeSub / totalPeople

            'Outputs information to Labels
            lblMilesDriven.Text = milesDriven
            lblTotalCharge.Text = totalCharge.ToString("C")
            lblAverageCharge.Text = averageCharge.ToString("C")
            lblTotalAmmountReceived.Text = totalChargeSub.ToString("C")
            lblCarsReturned.Text = totalPeople

            'This will get customer information
            lblCustomerInformation.Text = txtFirstName.Text & " " & txtLastName.Text & ControlChars.NewLine & txtAddress.Text & ControlChars.NewLine & txtCity.Text & ", " & txtState.Text & " " & txtZipCode.Text

        Catch ex As Exception
            MessageBox.Show("You need to enter data!", "Input Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'this exits the program
        Me.Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'this resets all the items
        txtFirstName.Text = "First Name"
        txtLastName.Text = "Last Name"
        txtAddress.Text = "Street Address"
        txtCity.Text = "City"
        txtState.Text = "State"
        txtZipCode.Text = "Zip Code"
        txtDaysRented.Text = "Days Rented"
        txtBeginningOdomiterReading.Text = "Beginning Odomiter Reading"
        txtEndingOdomiterReading.Text = "Ending Odomiter Reading"
        lblMilesDriven.Text = ""
        lblTotalCharge.Text = ""
        lblCustomerInformation.Text = ""
        lblAverageCharge.Text = ""
        lblTotalAmmountReceived.Text = ""
        lblCarsReturned.Text = ""
        radPrius.Checked = True
        chkBose.Checked = False
        chkLeather.Checked = False
        txtFirstName.Focus()

    End Sub

    Private Sub radPrius_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPrius.CheckedChanged
        'this displays prius image when checked
        picMain.Image = picPrius.Image
    End Sub

    Private Sub rad350Z_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad350Z.CheckedChanged
        'this displays 350Z image when checked
        picMain.Image = pic350Z.Image
    End Sub

    Private Sub radRescue1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRescue1.CheckedChanged
        'this displays Rescue1 image when checked
        picMain.Image = picRescue1.Image
    End Sub

    Private Sub chkLeather_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLeather.CheckedChanged
        'displays check on leather when checked
        If chkLeather.Checked Then
            picCheckLeather.Visible = True
        ElseIf chkLeather.Checked = False Then
            picCheckLeather.Visible = False
        End If

    End Sub

    Private Sub chkBose_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBose.CheckedChanged
        'displays check on bose when checked
        If chkBose.Checked Then
            picCheckBose.Visible = True
        ElseIf chkBose.Checked = False Then
            picCheckBose.Visible = False
        End If
    End Sub
End Class
