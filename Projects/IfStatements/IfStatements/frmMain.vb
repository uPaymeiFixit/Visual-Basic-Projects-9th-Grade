Public Class frmMain

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'display a message box with services
        Dim CountInteger As Integer
        Dim messageString As String

        If chkShampoo.Checked Then
            CountInteger += 1
        End If
        If chkManacure.Checked Then
            CountInteger += 1
        End If
        If chkPedicure.Checked Then
            CountInteger += 1
        End If
        If chkHaircut.Checked Then
            CountInteger += 1
        End If

        'always do radio buttons display
        If radMale.Checked Then
            messageString = "You selected Male"
        ElseIf radFemale.Checked Then
            messageString = "You selected Female"
        Else
            messageString = "Not Specified"
        End If

        MessageBox.Show(messageString & ControlChars.NewLine & _
                        "Number of Services " & CountInteger.ToString)

    End Sub

    Private Sub btnHappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHappy.Click
        'this makes the happy image go to the blank picture box
        picBlank.Image = picHappy.Image
    End Sub

    Private Sub btnSad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSad.Click
        'this makes the sad image go to the blank picture box
        picBlank.Image = picSad.Image
    End Sub
End Class
