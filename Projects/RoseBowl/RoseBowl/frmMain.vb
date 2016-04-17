'Josh Gibbs
'Period 2
'16 December 2010
'Shows rosebowl team stats

Public Class frmMain
    Private Sub radOhioSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTCUSize.CheckedChanged
        If radTCUSize.Checked Then
            picTCU.Width = 200 : picTCU.Height = 200
            picWisconsin.Width = 75 : picWisconsin.Height = 75
            picTCU.Top = 49 : picTCU.Left = 23
            picWisconsin.Top = 110 : picWisconsin.Left = 358
        Else
            picTCU.Width = 75 : picTCU.Height = 75
            picWisconsin.Width = 200 : picWisconsin.Height = 200
            picTCU.Top = 110 : picTCU.Left = 86
            picWisconsin.Top = 49 : picWisconsin.Left = 292
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cmbWisconsin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWisconsin.SelectedIndexChanged
        If cboWisconsin.SelectedIndex = 0 Then
            lblWisconsin.Text = "Rose Bowl" & vbNewLine & "TCU 4:00 p.m."
        ElseIf cboWisconsin.SelectedIndex = 1 Then
            lblWisconsin.Text = "Champs Sports Bowl" & vbNewLine & "Miami W, 20-14"
        ElseIf cboWisconsin.SelectedIndex = 2 Then
            lblWisconsin.Text = "Champs Sports Bowl" & vbNewLine & "Florida L, 13-42"
        ElseIf cboWisconsin.SelectedIndex = 3 Then
            lblWisconsin.Text = "Outback Bowl" & vbNewLine & "Tennessee L, 17-21"
        ElseIf cboWisconsin.SelectedIndex = 4 Then
            lblWisconsin.Text = "Capital One Bowl" & vbNewLine & "Arkansas W, 17-14"
        ElseIf cboWisconsin.SelectedIndex = 5 Then
            lblWisconsin.Text = "Capital One Bowl" & vbNewLine & "Auburn W, 24-10"
        End If
    End Sub

    Private Sub cboTCU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTCU.SelectedIndexChanged
        If cboTCU.SelectedIndex = 0 Then
            lblTCU.Text = "Rose Bowl" & vbNewLine & "TCU 4:00 p.m."
        ElseIf cboTCU.SelectedIndex = 1 Then
            lblTCU.Text = "Fiesta Bowl" & vbNewLine & "Boise State L, 10-17"
        ElseIf cboTCU.SelectedIndex = 2 Then
            lblTCU.Text = "Poinsettia Bowl" & vbNewLine & "Boise State W, 17-16"
        ElseIf cboTCU.SelectedIndex = 3 Then
            lblTCU.Text = "Texas Bowl" & vbNewLine & "Houston W, 20-13"
        ElseIf cboTCU.SelectedIndex = 4 Then
            lblTCU.Text = "Poinsettia Bowl" & vbNewLine & "Northern Illinois W, 37-7"
        ElseIf cboTCU.SelectedIndex = 5 Then
            lblTCU.Text = "Houston Bowl" & vbNewLine & "Iowa State W, 27-24"
        End If
    End Sub

    Private Sub TCUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCUToolStripMenuItem.Click
        MessageBox.Show("I think TCU will win because thay have won more games.", "TCU Will Win")
    End Sub

    Private Sub WisconsinToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WisconsinToolStripMenuItem1.Click
        frmWisconsinHistory.Show()
    End Sub

    Private Sub TCUToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCUToolStripMenuItem1.Click
        frmTCUHistory.Show()
    End Sub
End Class
