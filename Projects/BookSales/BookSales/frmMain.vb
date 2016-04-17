'Josh Gibbs
'27 September 2010
'Period 2
'How to do calculations

Public Class frmMain

    'global variables
    'they keep running totals
    Private quantitySumInteger As Integer
    Private discountSumDecimal As Decimal
    Private discountPriceSumDecimal As Decimal
    Private totalPeople As Integer

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'this closes the program
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'This calculates the values

        'First we declare our variables that we need to store information
        Dim priceDecimal As Decimal
        Dim quantityDecimal As Decimal

        'This stores the answer
        Dim extendedPriceDecimal As Decimal
        Dim discountDecimal As Decimal
        Dim discountPriceDecimal As Decimal

        Dim averageDecimal As Decimal

        'step 2 is getting the information and storing it

        Try

            priceDecimal = Decimal.Parse(txtPrice.Text)
            quantityDecimal = Decimal.Parse(txtQuantity.Text)

            'step 3 is doing the calculations
            'for the customer
            extendedPriceDecimal = priceDecimal * quantityDecimal
            discountDecimal = 0.15 * extendedPriceDecimal
            discountPriceDecimal = extendedPriceDecimal - discountDecimal

            'this is for the store manager
            quantitySumInteger += quantityDecimal
            discountDecimal += discountDecimal
            discountPriceSumDecimal += discountPriceDecimal
            totalPeople += 1
            averageDecimal = discountPriceSumDecimal / totalPeople

            'step 4 is outputing the answer
            lblExtendedPrice.Text = extendedPriceDecimal.ToString("C")
            lblDiscount.Text = discountDecimal.ToString("C")
            lblDiscountedPrice.Text = discountPriceDecimal.ToString("C")

            lblTotalBooks.Text = quantitySumInteger
            lblTotalDiscounts.Text = discountDecimal.ToString("C")
            lblTotalDiscountAmmounts.Text = discountPriceSumDecimal.ToString("C")
            lblAverageSales.Text = averageDecimal.ToString("N")

            'clears out the text areas
            txtTitle.Clear()
            txtPrice.Clear()
            txtQuantity.Clear()
            txtTitle.Focus()


        Catch ex As Exception
            MessageBox.Show("You need to enter data!", "Input Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'allow user to decide to clear
        'declare variable to hold users answer
        Dim resultDialogAnswer As DialogResult
        resultDialogAnswer = MessageBox.Show("Are you sure", _
                                             "Clear Form?", MessageBoxButtons.YesNo, _
                                             MessageBoxIcon.Question)

        If resultDialogAnswer = Windows.Forms.DialogResult.Yes Then



            'clears out the text areas
            With txtTitle
                .Text = ""
                .Focus()

            End With
            txtPrice.Clear()
            txtQuantity.Clear()
            lblExtendedPrice.Text = ""
            lblDiscount.Text = ""
            lblDiscountedPrice.Text = ""

        End If
    End Sub
End Class
