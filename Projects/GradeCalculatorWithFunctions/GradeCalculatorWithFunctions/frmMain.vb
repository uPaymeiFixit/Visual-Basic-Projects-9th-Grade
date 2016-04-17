'Josh Gibbs
'Period 2
'10 December 2010
'Grade Program Using Functions

Public Class frmMain

    Private Sub txtNumber1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber1.TextChanged
        Try
            'changes picture
            funPic()

            'changes lables
            lblLetter1.Text = makeletter(mygrade:=Decimal.Parse(txtNumber1.Text))
            lblAverage.Text = makeletter(mygrade:=Decimal.Parse((Decimal.Parse(txtNumber1.Text) + Decimal.Parse(txtNumber2.Text)) / 2))

            'changes average
            txtAverage.Text = ((Decimal.Parse(txtNumber1.Text) + txtNumber2.Text) / 2)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtNumber2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber2.TextChanged, txtAverage.TextChanged
        Try
            'changes picture
            funPic()

            'changes labels
            lblLetter2.Text = makeletter(mygrade:=Decimal.Parse(txtNumber2.Text))
            lblAverage.Text = makeletter(mygrade:=Decimal.Parse((Decimal.Parse(txtNumber1.Text) + Decimal.Parse(txtNumber2.Text)) / 2))

            'changes average
            txtAverage.Text = ((Decimal.Parse(txtNumber1.Text) + txtNumber2.Text) / 2)
        Catch ex As Exception

        End Try
    End Sub

    Private Function makeletter(ByVal mygrade)
        Try
            Dim gradeletter As String = "Error"
            'letter grades are assigned
            If mygrade < 60 Then
                gradeletter = "F"
            ElseIf mygrade >= 60 And mygrade < 63 Then
                gradeletter = "D-"
            ElseIf mygrade >= 63 And mygrade < 66 Then
                gradeletter = "D"
            ElseIf mygrade >= 66 And mygrade < 70 Then
                gradeletter = "D+"
            ElseIf mygrade >= 70 And mygrade < 73 Then
                gradeletter = "C-"
            ElseIf mygrade >= 73 And mygrade < 76 Then
                gradeletter = "C"
            ElseIf mygrade >= 76 And mygrade < 80 Then
                gradeletter = "C+"
            ElseIf mygrade >= 80 And mygrade < 83 Then
                gradeletter = "B-"
            ElseIf mygrade >= 83 And mygrade < 86 Then
                gradeletter = "B"
            ElseIf mygrade >= 86 And mygrade < 90 Then
                gradeletter = "B+"
            ElseIf mygrade >= 90 And mygrade < 93 Then
                gradeletter = "A-"
            ElseIf mygrade >= 93 And mygrade < 96 Then
                gradeletter = "A"
            ElseIf mygrade >= 96 Then
                gradeletter = "A+"
            End If
            Return gradeletter
        Catch ex As Exception
        End Try
    End Function

    Private Function funPic()
        Try
            'changes pictures
            If Decimal.Parse(txtNumber1.Text) > Decimal.Parse(txtNumber2.Text) Then
                picGrade1.Image = picGreater.Image
                picGrade2.Image = picLesser.Image
            ElseIf Decimal.Parse(txtNumber2.Text) > Decimal.Parse(txtNumber1.Text) Then
                picGrade1.Image = picLesser.Image
                picGrade2.Image = picGreater.Image
            End If

            Return (vbNull)
        Catch ex As Exception
        End Try
    End Function

    End Class
