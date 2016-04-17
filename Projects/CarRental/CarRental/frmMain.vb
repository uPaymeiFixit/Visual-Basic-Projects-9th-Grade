'Josh Gibbs
'30 September 2010
'Period 2
'Car Rental Calculator

Public Class frmMain

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

        Try

            'Says that these txt inputs are numbers, and connects them to text boxes
            endOdomiterReading = Decimal.Parse(txtEndingOdomiterReading.Text)
            beginningOdomiterReading = Decimal.Parse(txtBeginningOdomiterReading.Text)
            daysRented = Decimal.Parse(txtDaysRented.Text)

            'Calculates miles driven
            milesDriven = endOdomiterReading - beginningOdomiterReading

            'fixes user error if any
            If milesDriven < 0 Then
                milesDriven = beginningOdomiterReading - endOdomiterReading
            End If

            'Calculates ammount due
            totalCharge = ((daysRented * 15) + (milesDriven * 0.12))

            'says that 1 is added every time totalPeople is used
            totalPeople += 1

            'calculates average charge
            totalChargeSub += totalCharge
            averageCharge = totalChargeSub / totalPeople

            'Outputs information to Labels
            lblMilesDriven.Text = milesDriven
            lblTotalCharge.Text = totalCharge.ToString("C")
            lblAverageCharge.Text = averageCharge.ToString("N")
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
        txtFirstName.Focus()

    End Sub
End Class
