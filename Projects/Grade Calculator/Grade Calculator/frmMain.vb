'Josh Gibbs
'Period 2
'26 October 2010
'Grade Program

Public Class frmMain

    Private Sub txtNumber1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber1.TextChanged

        Try
            'changes pictures
            '(Declared: picGrade1.Image - picGrade2.Image) (Needed: picGreater.Image and picLesser.Image and txtNumber1.Text - txtNumber2.Text)
            If Decimal.Parse(txtNumber1.Text) > Decimal.Parse(txtNumber2.Text) Then
                picGrade1.Image = picGreater.Image
                picGrade2.Image = picLesser.Image
            ElseIf Decimal.Parse(txtNumber2.Text) > Decimal.Parse(txtNumber1.Text) Then
                picGrade1.Image = picLesser.Image
                picGrade2.Image = picGreater.Image
            End If

            'outputs average of two grades
            '(Declared: lblAverage.Text) (Needed: txtNumber1.Text - txtNumber2.Text)
            txtAverage.Text = ((Decimal.Parse(txtNumber1.Text) + txtNumber2.Text) / 2)

            'letter grades are assigned
            '(Declared: lblLetter1.Text) (Needed: txtNumber1.Text)
            If Decimal.Parse(txtNumber1.Text) < 60 Then
                lblLetter1.Text = "F"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 60 And Decimal.Parse(txtNumber1.Text) < 63 Then
                lblLetter1.Text = "D-"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 63 And Decimal.Parse(txtNumber1.Text) < 66 Then
                lblLetter1.Text = "D"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 66 And Decimal.Parse(txtNumber1.Text) < 70 Then
                lblLetter1.Text = "D+"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 70 And Decimal.Parse(txtNumber1.Text) < 73 Then
                lblLetter1.Text = "C-"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 73 And Decimal.Parse(txtNumber1.Text) < 76 Then
                lblLetter1.Text = "C"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 76 And Decimal.Parse(txtNumber1.Text) < 80 Then
                lblLetter1.Text = "C+"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 80 And Decimal.Parse(txtNumber1.Text) < 83 Then
                lblLetter1.Text = "B-"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 83 And Decimal.Parse(txtNumber1.Text) < 86 Then
                lblLetter1.Text = "B"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 86 And Decimal.Parse(txtNumber1.Text) < 90 Then
                lblLetter1.Text = "B+"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 90 And Decimal.Parse(txtNumber1.Text) < 93 Then
                lblLetter1.Text = "A-"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 93 And Decimal.Parse(txtNumber1.Text) < 96 Then
                lblLetter1.Text = "A"
            ElseIf Decimal.Parse(txtNumber1.Text) >= 96 Then
                lblLetter1.Text = "A+"
            End If

            'letter grades are assigned to average
            '(Declared: lblLetter2.Text) (Needed: txtAverage.Text)
            If Decimal.Parse(txtAverage.Text) < 60 Then
                lblLetter2.Text = "F"
            ElseIf Decimal.Parse(txtAverage.Text) >= 60 And Decimal.Parse(txtAverage.Text) < 63 Then
                lblLetter2.Text = "D-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 63 And Decimal.Parse(txtAverage.Text) < 66 Then
                lblLetter2.Text = "D"
            ElseIf Decimal.Parse(txtAverage.Text) >= 66 And Decimal.Parse(txtAverage.Text) < 70 Then
                lblLetter2.Text = "D+"
            ElseIf Decimal.Parse(txtAverage.Text) >= 70 And Decimal.Parse(txtAverage.Text) < 73 Then
                lblLetter2.Text = "C-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 73 And Decimal.Parse(txtAverage.Text) < 76 Then
                lblLetter2.Text = "C"
            ElseIf Decimal.Parse(txtAverage.Text) >= 76 And Decimal.Parse(txtAverage.Text) < 80 Then
                lblLetter2.Text = "C+"
            ElseIf Decimal.Parse(txtAverage.Text) >= 80 And Decimal.Parse(txtAverage.Text) < 83 Then
                lblLetter2.Text = "B-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 83 And Decimal.Parse(txtAverage.Text) < 86 Then
                lblLetter2.Text = "B"
            ElseIf Decimal.Parse(txtAverage.Text) >= 86 And Decimal.Parse(txtAverage.Text) < 90 Then
                lblLetter2.Text = "B+"
            ElseIf Decimal.Parse(txtAverage.Text) >= 90 And Decimal.Parse(txtAverage.Text) < 93 Then
                lblLetter2.Text = "A-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 93 And Decimal.Parse(txtAverage.Text) < 96 Then
                lblLetter2.Text = "A"
            ElseIf Decimal.Parse(txtAverage.Text) >= 96 Then
                lblLetter2.Text = "A+"
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNumber2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber2.TextChanged, txtAverage.TextChanged

        Try
            'changes pictures
            '(Declared: picGrade1.Image - picGrade2.Image) (Needed: picGreater.Image and picLesser.Image and txtNumber1.Text - txtNumber2.Text)
            If Decimal.Parse(txtNumber1.Text) > Decimal.Parse(txtNumber2.Text) Then
                picGrade1.Image = picGreater.Image
                picGrade2.Image = picLesser.Image
            ElseIf Decimal.Parse(txtNumber2.Text) > Decimal.Parse(txtNumber1.Text) Then
                picGrade1.Image = picLesser.Image
                picGrade2.Image = picGreater.Image
            End If

            'outputs average of two grades
            '(Declared: txtAverage.Text) (Needed: txtNumber1.Text - txtNumber2.Text)
            txtAverage.Text = ((Decimal.Parse(txtNumber1.Text) + txtNumber2.Text) / 2)

            'letter grades are assigned
            '(Declared: lblLetter2.Text) (Needed: txtNumber2.Text)
            If Decimal.Parse(txtNumber2.Text) < 60 Then
                lblLetter3.Text = "F"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 60 And Decimal.Parse(txtNumber2.Text) < 63 Then
                lblLetter3.Text = "D-"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 63 And Decimal.Parse(txtNumber2.Text) < 66 Then
                lblLetter3.Text = "D"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 66 And Decimal.Parse(txtNumber2.Text) < 70 Then
                lblLetter3.Text = "D+"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 70 And Decimal.Parse(txtNumber2.Text) < 73 Then
                lblLetter3.Text = "C-"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 73 And Decimal.Parse(txtNumber2.Text) < 76 Then
                lblLetter3.Text = "C"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 76 And Decimal.Parse(txtNumber2.Text) < 80 Then
                lblLetter3.Text = "C+"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 80 And Decimal.Parse(txtNumber2.Text) < 83 Then
                lblLetter3.Text = "B-"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 83 And Decimal.Parse(txtNumber2.Text) < 86 Then
                lblLetter3.Text = "B"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 86 And Decimal.Parse(txtNumber2.Text) < 90 Then
                lblLetter3.Text = "B+"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 90 And Decimal.Parse(txtNumber2.Text) < 93 Then
                lblLetter3.Text = "A-"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 93 And Decimal.Parse(txtNumber2.Text) < 96 Then
                lblLetter3.Text = "A"
            ElseIf Decimal.Parse(txtNumber2.Text) >= 96 Then
                lblLetter3.Text = "A+"
            End If

            'letter grades are assigned to average
            '(Declared: lblLetter2.Text) (Needed: txtAverage.Text)
            If Decimal.Parse(txtAverage.Text) < 60 Then
                lblLetter2.Text = "F"
            ElseIf Decimal.Parse(txtAverage.Text) >= 60 And Decimal.Parse(txtAverage.Text) < 63 Then
                lblLetter2.Text = "D-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 63 And Decimal.Parse(txtAverage.Text) < 66 Then
                lblLetter2.Text = "D"
            ElseIf Decimal.Parse(txtAverage.Text) >= 66 And Decimal.Parse(txtAverage.Text) < 70 Then
                lblLetter2.Text = "D+"
            ElseIf Decimal.Parse(txtAverage.Text) >= 70 And Decimal.Parse(txtAverage.Text) < 73 Then
                lblLetter2.Text = "C-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 73 And Decimal.Parse(txtAverage.Text) < 76 Then
                lblLetter2.Text = "C"
            ElseIf Decimal.Parse(txtAverage.Text) >= 76 And Decimal.Parse(txtAverage.Text) < 80 Then
                lblLetter2.Text = "C+"
            ElseIf Decimal.Parse(txtAverage.Text) >= 80 And Decimal.Parse(txtAverage.Text) < 83 Then
                lblLetter2.Text = "B-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 83 And Decimal.Parse(txtAverage.Text) < 86 Then
                lblLetter2.Text = "B"
            ElseIf Decimal.Parse(txtAverage.Text) >= 86 And Decimal.Parse(txtAverage.Text) < 90 Then
                lblLetter2.Text = "B+"
            ElseIf Decimal.Parse(txtAverage.Text) >= 90 And Decimal.Parse(txtAverage.Text) < 93 Then
                lblLetter2.Text = "A-"
            ElseIf Decimal.Parse(txtAverage.Text) >= 93 And Decimal.Parse(txtAverage.Text) < 96 Then
                lblLetter2.Text = "A"
            ElseIf Decimal.Parse(txtAverage.Text) >= 96 Then
                lblLetter2.Text = "A+"
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class
