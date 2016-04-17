Public Class frmMain

    Private varXSpeed As Integer = 10
    Private varYSpeed As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'this makes the object move
        'this gets the left coordnate of the graphic
        Dim varXcoor As Integer = picBlank.Left
        'this get the y coordinate of the graphic
        Dim varYcoor As Integer = picBlank.Top

        If picBlank.Right > Me.Width Then
            varXSpeed = -10
        ElseIf picBlank.Left < 0 Then
            varXSpeed = 10
        End If

        varXcoor += varXSpeed

        picBlank.SetBounds(varXcoor, varYcoor, picBlank.Width, picBlank.Height)
    End Sub
End Class
