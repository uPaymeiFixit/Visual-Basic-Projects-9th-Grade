Public Class frmEnd

    Private Sub btnMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGame.lbl25Score.Text = 0
        frmGame.lblScore.Text = 0
        frmGame.tmrDangerMove.Enabled = False
        frmGame.pgbScore.Value = 0
        If frmGame.picGet.Bounds.IntersectsWith(frmGame.picPlayerEXBounds.Bounds) Then
            frmGame.picGet.Left = Rnd() * 475 : frmGame.picGet.Top = Rnd() * 320 + 60
        End If
        frmGame.picXDanger1.Left = Rnd() * 475 : frmGame.picXDanger1.Top = Rnd() * 325 + 60
        If frmGame.picXDanger1.Top > 170 And frmGame.picXDanger1.Top < 270 Then
            frmGame.picXDanger1.Left = Rnd() * 475 : frmGame.picXDanger1.Top = Rnd() * 325 + 60
        End If
        frmGame.picXDanger2.Top = 403
        frmGame.picXDanger3.Top = 403
        frmGame.picXDanger4.Top = 403
        frmGame.picXDanger5.Top = 403
        frmGame.picXDanger6.Top = 403
        frmGame.picXDanger7.Top = 403
        frmGame.picXDanger8.Top = 403
        frmGame.picXDanger9.Top = 403
        frmGame.picXDanger10.Top = 403
        frmGame.picXDanger11.Top = 403
        frmGame.picXDanger12.Top = 403
        frmGame.picXDanger13.Top = 403
        frmGame.picYDanger1.Left = 506
        frmGame.picYDanger2.Left = 506
        frmGame.picYDanger3.Left = 506
        frmGame.picYDanger4.Left = 506
        frmGame.picYDanger5.Left = 506
        frmGame.picYDanger6.Left = 506
        frmGame.picYDanger7.Left = 506
        frmGame.picYDanger8.Left = 506
        frmGame.picYDanger9.Left = 506
        frmGame.picYDanger10.Left = 506
        frmGame.picYDanger11.Left = 506
        frmGame.picYDanger12.Left = 506
    End Sub

    Private Sub btnMainMenu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainMenu.Click
        frmGame.lbl25Score.Text = 0
        frmGame.lblScore.Text = 0
        frmGame.tmrDangerMove.Enabled = False
        frmGame.pgbScore.Value = 0
        If frmGame.picGet.Bounds.IntersectsWith(frmGame.picPlayerEXBounds.Bounds) Then
            frmGame.picGet.Left = Rnd() * 475 : frmGame.picGet.Top = Rnd() * 320 + 60
        End If
        frmGame.picXDanger1.Left = Rnd() * 475 : frmGame.picXDanger1.Top = Rnd() * 325 + 60
        If frmGame.picXDanger1.Top > 170 And frmGame.picXDanger1.Top < 270 Then
            frmGame.picXDanger1.Left = Rnd() * 475 : frmGame.picXDanger1.Top = Rnd() * 325 + 60
        End If
        frmGame.picXDanger2.Top = 403
        frmGame.picXDanger3.Top = 403
        frmGame.picXDanger4.Top = 403
        frmGame.picXDanger5.Top = 403
        frmGame.picXDanger6.Top = 403
        frmGame.picXDanger7.Top = 403
        frmGame.picXDanger8.Top = 403
        frmGame.picXDanger9.Top = 403
        frmGame.picXDanger10.Top = 403
        frmGame.picXDanger11.Top = 403
        frmGame.picXDanger12.Top = 403
        frmGame.picXDanger13.Top = 403
        frmGame.picYDanger1.Left = 506
        frmGame.picYDanger2.Left = 506
        frmGame.picYDanger3.Left = 506
        frmGame.picYDanger4.Left = 506
        frmGame.picYDanger5.Left = 506
        frmGame.picYDanger6.Left = 506
        frmGame.picYDanger7.Left = 506
        frmGame.picYDanger8.Left = 506
        frmGame.picYDanger9.Left = 506
        frmGame.picYDanger10.Left = 506
        frmGame.picYDanger11.Left = 506
        frmGame.picYDanger12.Left = 506

        Me.Visible = False
        frmTransparant.Visible = False
        frmGame.Visible = False
        frmPlayers.Visible = True
        frmPlayers.Location = frmGame.Location

    End Sub
End Class