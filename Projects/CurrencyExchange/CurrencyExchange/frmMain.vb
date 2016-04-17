'Josh Gibbs
'Period 2
'19 October 2010
'Currency Exchange Program

Public Class frmMain
    'currency variable
    Private varCurrency As Decimal
    Private varSymbol As Object

    Private Sub txtStart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStart.TextChanged
        'calculates when txtStart is changed
        Try
            txtStart.Focus()
            If radEur.Checked Then
                varCurrency = 0.717108
                picMain.Image = picEur.Image
                varSymbol = "€"
            ElseIf radCad.Checked Then
                varCurrency = 1.02
                picMain.Image = picCad.Image
                varSymbol = "$"
            ElseIf radAus.Checked Then
                varCurrency = 1.01
                picMain.Image = picAus.Image
                varSymbol = "$"
            ElseIf radJpy.Checked Then
                varCurrency = 81.37
                picMain.Image = picJpy.Image
                varSymbol = "¥"
            End If
            txtEnd.Text = varSymbol & Decimal.Parse(txtStart.Text) * varCurrency.ToString("N")
        Catch ex As Exception
            txtEnd.Clear()
        End Try
    End Sub

    Private Sub radEur_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEur.CheckedChanged
        'calculates when radEur is changed
        Try
            txtStart.Focus()
            If radEur.Checked Then
                varCurrency = 0.717108
                picMain.Image = picEur.Image
                varSymbol = "€"
            ElseIf radCad.Checked Then
                varCurrency = 1.02
                picMain.Image = picCad.Image
                varSymbol = "$"
            ElseIf radAus.Checked Then
                varCurrency = 1.01
                picMain.Image = picAus.Image
                varSymbol = "$"
            ElseIf radJpy.Checked Then
                varCurrency = 81.37
                picMain.Image = picJpy.Image
                varSymbol = "¥"
            End If
            txtEnd.Text = varSymbol & Decimal.Parse(txtStart.Text) * varCurrency.ToString("N")
        Catch ex As Exception
            txtEnd.Clear()
        End Try
    End Sub

    Private Sub radCad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCad.CheckedChanged
        'calculates when radCad is changed
        Try
            txtStart.Focus()
            If radEur.Checked Then
                varCurrency = 0.717108
                picMain.Image = picEur.Image
                varSymbol = "€"
            ElseIf radCad.Checked Then
                varCurrency = 1.02
                picMain.Image = picCad.Image
                varSymbol = "$"
            ElseIf radAus.Checked Then
                varCurrency = 1.01
                picMain.Image = picAus.Image
                varSymbol = "$"
            ElseIf radJpy.Checked Then
                varCurrency = 81.37
                picMain.Image = picJpy.Image
                varSymbol = "¥"
            End If
            txtEnd.Text = varSymbol & Decimal.Parse(txtStart.Text) * varCurrency.ToString("N")
        Catch ex As Exception
            txtEnd.Clear()
        End Try
    End Sub

    Private Sub radAus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAus.CheckedChanged
        'calculates when radAus is changed
        Try
            txtStart.Focus()
            If radEur.Checked Then
                varCurrency = 0.717108
                picMain.Image = picEur.Image
                varSymbol = "€"
            ElseIf radCad.Checked Then
                varCurrency = 1.02
                picMain.Image = picCad.Image
                varSymbol = "$"
            ElseIf radAus.Checked Then
                varCurrency = 1.01
                picMain.Image = picAus.Image
                varSymbol = "$"
            ElseIf radJpy.Checked Then
                varCurrency = 81.37
                picMain.Image = picJpy.Image
                varSymbol = "¥"
            End If
            txtEnd.Text = varSymbol & Decimal.Parse(txtStart.Text) * varCurrency.ToString("N")
        Catch ex As Exception
            txtEnd.Clear()
        End Try
    End Sub


    Private Sub radJpy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radJpy.CheckedChanged
        'calculates when radJpy is changed
        Try
            txtStart.Focus()
            If radEur.Checked Then
                varCurrency = 0.717108
                picMain.Image = picEur.Image
                varSymbol = "€"
            ElseIf radCad.Checked Then
                varCurrency = 1.02
                picMain.Image = picCad.Image
                varSymbol = "$"
            ElseIf radAus.Checked Then
                varCurrency = 1.01
                picMain.Image = picAus.Image
                varSymbol = "$"
            ElseIf radJpy.Checked Then
                varCurrency = 81.37
                picMain.Image = picJpy.Image
                varSymbol = "¥"
            End If
            txtEnd.Text = varSymbol & Decimal.Parse(txtStart.Text) * varCurrency.ToString("N")
        Catch ex As Exception
            txtEnd.Clear()
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'closes form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'resets and refocuses items
        txtStart.Clear()
        txtEnd.Clear()
        txtStart.Focus()
    End Sub
End Class
