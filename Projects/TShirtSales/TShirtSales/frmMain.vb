'Josh Gibbs
'Period 2
'10 December 2010
'T-Shirt Sales Program

Public Class frmMain

    'user's summary variables (Reset on new)
    Private varUsrTotalOrderPrice As Integer
    Private varUsrShirtsBought As Integer

    'manager's summary variables (Do not get reset)
    Private varMgrTotalShirtsSold As Integer
    Private varMgrTotalMoneyMade As Integer
    Private varMgrTotalMoneyMadeUnknown As Integer
    Private varMgrTotalCompletedOrders As Integer

    'Shirt variables (reset on clear)
    Private varTmpShirtPrice As Integer = 10
    Private varTmpOrderPrice As Integer

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Checks for an error
        If txtName.Text <> "" And txtOrderNumber.Text <> "" And txtQuantity.Text <> "" Then
            Try
                'takes options into account
                If radSmall.Checked Then
                    varTmpShirtPrice = 10
                ElseIf radMedium.Checked Then
                    varTmpShirtPrice = 10
                ElseIf radLarge.Checked Then
                    varTmpShirtPrice = 10
                ElseIf radXLarge.Checked Then
                    varTmpShirtPrice = 11
                ElseIf radXXL.Checked Then
                    varTmpShirtPrice = 12
                End If
                If chkMonogram.Checked = True Then
                    varTmpShirtPrice += 2
                ElseIf chkShirtPocket.Checked = True Then
                    varTmpShirtPrice += 1
                End If

                'gets current order price
                varTmpOrderPrice += Integer.Parse(txtQuantity.Text) * varTmpShirtPrice
                varUsrTotalOrderPrice += Integer.Parse(txtQuantity.Text) * varTmpShirtPrice

                'outputs current shirt information into lables
                lblShirtPrice.Text = varTmpShirtPrice
                lblQuantity.Text = txtQuantity.Text
                lblTotalOrderPrice.Text = varTmpOrderPrice

                'counters
                varMgrTotalShirtsSold += Integer.Parse(txtQuantity.Text)
                varUsrShirtsBought += Integer.Parse(txtQuantity.Text)
                varMgrTotalMoneyMade += Integer.Parse(txtQuantity.Text) * varTmpShirtPrice
                varMgrTotalMoneyMadeUnknown += Integer.Parse(txtQuantity.Text) * varTmpShirtPrice

                'disables text boxes
                txtName.Enabled = False
                txtOrderNumber.Enabled = False

                'shows different errors
            Catch ex As Exception
                MessageBox.Show("Make sure you have input all data corectly!")
            End Try
        ElseIf txtName.Text = "" Then
            MessageBox.Show("Make sure you have input your name corectly!")
            txtName.Focus()
        ElseIf txtOrderNumber.Text = "" Then
            MessageBox.Show("Make sure you have input the order number corectly!")
            txtOrderNumber.Focus()
        ElseIf txtQuantity.Text = "" Then
            MessageBox.Show("Make sure you have input the quantity corectly!")
            txtQuantity.Focus()
        End If
    End Sub

    Private Sub btnCompleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompleteOrder.Click
        'Checks for an error
        If txtName.Text <> "" And txtOrderNumber.Text <> "" And txtQuantity.Text <> "" Then
            Try
                'If the input is correct, this will ask if you are sure if you would like to complete the order. Then it will show you the Order then reset if you want.
                Dim resultCompleteDialogAnswer As DialogResult = MessageBox.Show("Are you sure you would like to complete the order?", "Complete Order?", MessageBoxButtons.YesNo)
                If resultCompleteDialogAnswer = Windows.Forms.DialogResult.Yes Then

                    'Shows a user summary if you complete order
                    MessageBox.Show("Name: " & txtName.Text & ControlChars.NewLine & "Order Number: " & txtOrderNumber.Text & ControlChars.NewLine & "Total Shirts: " & varUsrShirtsBought & ControlChars.NewLine & "Total Cost: " & varUsrTotalOrderPrice)
                    Dim resultNewDialogAnswer As DialogResult = MessageBox.Show("Would you like to start a new order?", "New Order", MessageBoxButtons.YesNo)

                    'Clears items that btnClear doesn't
                    If resultNewDialogAnswer = Windows.Forms.DialogResult.Yes Then
                        btnClearItem.PerformClick()
                        txtName.Clear()
                        txtOrderNumber.Clear()
                        txtName.Enabled = True
                        txtOrderNumber.Enabled = True
                    End If

                    btnSummary.Enabled = True
                    varMgrTotalCompletedOrders += 1

                    'Resets user variables
                    varUsrShirtsBought = 0
                    varUsrTotalOrderPrice = 0

                End If

                'shows different errors
            Catch ex As Exception
                MessageBox.Show("Make sure you have input all data corectly!")
            End Try
        ElseIf txtName.Text = "" Then
            MessageBox.Show("Make sure you have input your name corectly!")
            txtName.Focus()
        ElseIf txtOrderNumber.Text = "" Then
            MessageBox.Show("Make sure you have input the order number corectly!")
            txtOrderNumber.Focus()
        ElseIf txtQuantity.Text = "" Then
            MessageBox.Show("Make sure you have input the quantity corectly!")
            txtQuantity.Focus()
        End If
    End Sub

    Private Sub btnSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSummary.Click
        'shows summary information in a Message Box
        MessageBox.Show("Total Shirts Sold: " & varMgrTotalShirtsSold & ControlChars.NewLine & "Total Money Made: " & varMgrTotalMoneyMade & ControlChars.NewLine & "Completed Orders: " & varMgrTotalCompletedOrders)
    End Sub

    Private Sub btnClearItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearItem.Click
        'Resets most veriables and objects
        txtQuantity.Clear()
        lblShirtPrice.Text = ""
        lblQuantity.Text = ""
        lblTotalOrderPrice.Text = ""
        radSmall.Checked = True
        chkMonogram.Checked = False
        chkShirtPocket.Checked = False
        txtName.Focus()
        varTmpShirtPrice = 0
        varTmpOrderPrice = 0
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This closes the form
        Me.Close()
    End Sub
End Class