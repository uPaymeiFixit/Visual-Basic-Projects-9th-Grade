'Josh Gibbs
'Period 2
'9 September 2010
'Goodbye project (Goodbye in miltiple languages)

Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This closes the program
        Me.Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'Changes lblMessage to English (Default) But I still need to learn to reset lblMessage
        lblMessage.Text = "Goodbye"
    End Sub

    Private Sub btnSpanish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpanish.Click
        'Changes lblMessage to Spanish
        lblMessage.Text = "Adiós"
    End Sub

    Private Sub btnFrench_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrench.Click
        'Changes lblMessage to French
        lblMessage.Text = "Au revoir"
    End Sub

    Private Sub btnRussian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItalian.Click
        'Changes lblMessage to Italian
        lblMessage.Text = "Addio"
    End Sub

    Private Sub btnIndonesian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPolish.Click
        'Changes lblMessage to Polish
        lblMessage.Text = "Pożegnanie"
    End Sub
End Class
