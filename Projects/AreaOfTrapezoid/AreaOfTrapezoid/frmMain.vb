Public Class frmMain



    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Try
            'gets input and stores it
            Dim Trapbase1Decimal As Decimal = Decimal.Parse(txtBase1.Text)
            Dim Trapbase2Decimal As Decimal = Decimal.Parse(txtBase2.Text)
            Dim TrapHeightDecimal As Decimal = Decimal.Parse(txtHeight.Text)

            'answer
            Dim TrapAreaDecimal As Decimal

            'this sends the information to the function and returns the answer
            TrapAreaDecimal = AreaOfTrap(Trapbase1Decimal, Trapbase2Decimal, TrapHeightDecimal)


            'Outputs answers
            lblArea.Text = TrapAreaDecimal.ToString("N")

        Catch ex As Exception

        End Try

    End Sub

    Private Function AreaOfTrap(ByVal Base1 As Decimal, ByVal Base2 As Decimal, ByVal Height As Decimal)

        Dim AreaOfTrapezoid

        AreaOfTrapezoid = 0.5D * (Base1 + Base2) * Height

        Return AreaOfTrapezoid

    End Function


End Class
