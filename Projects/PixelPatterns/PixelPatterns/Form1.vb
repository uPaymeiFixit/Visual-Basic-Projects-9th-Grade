Public Class frmPixelPatterns

    Private o_blocksWide As Int16
    Private o_blocksDeep As Int16
    Private o_blockWidth As Int16
    Private o_blockHeight As Int16

    Private i_ammount As Int16
    Private i_Pixel(i_ammount) As Label
    Private m_a As Int16 = 100
    Private m_b As Int16
    Private i As Int16 = -1

    Private Sub doAdd()
        If i < i_ammount Then
            i += 1
        Else
            Timer1.Enabled = False
        End If

        i_Pixel(i) = New Label
        Me.Controls.Add(i_Pixel(i))
        i_Pixel(i).Height = o_blockHeight
        i_Pixel(i).Width = o_blockWidth

        i_Pixel(i).Top = m_b
        i_Pixel(i).Left = (i - m_a + o_blocksWide) * i_Pixel(i).Width

        If i = m_a Then
            i -= 1
            m_a += o_blocksWide
            m_b += o_blockHeight
        End If

        i_Pixel(i).BackColor = Color.Lime
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        doAdd()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        doAdd()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        doAdd()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        doAdd()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        'Try
        o_blockHeight = Integer.Parse(txtBlockHeight.Text)
        o_blockWidth = Integer.Parse(txtBlockWidth.Text)
        o_blocksWide = Integer.Parse(txtBlocksWide.Text)
        o_blocksDeep = Integer.Parse(txtBlocksTall.Text)
        i_ammount = o_blocksWide * o_blocksDeep
        ReDim Preserve i_Pixel(i_ammount)

        btnGo.Visible = False
        txtBlockHeight.Visible = False
        txtBlocksTall.Visible = False
        txtBlocksWide.Visible = False
        txtBlockWidth.Visible = False

        Me.Height = o_blocksDeep * o_blockHeight + 24
        Me.Width = o_blocksWide * o_blockWidth + 6

        Me.BackColor = Color.Black

        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        'Catch
        'End Try
    End Sub
End Class