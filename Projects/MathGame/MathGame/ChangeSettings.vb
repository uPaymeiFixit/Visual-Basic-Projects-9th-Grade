Public Class ChangeSettings

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If frmMain.on_add Then
            btnAdd.BackColor = Color.LightCoral
            frmMain.on_add = False
            frmMain.type_quantity -= 1
        Else
            btnAdd.BackColor = Color.LightGreen
            frmMain.on_add = True
            frmMain.type_quantity += 1
        End If
    End Sub

    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click
        If frmMain.on_sub Then
            btnSub.BackColor = Color.LightCoral
            frmMain.on_sub = False
            frmMain.type_quantity -= 1
        Else
            btnSub.BackColor = Color.LightGreen
            frmMain.on_sub = True
            frmMain.type_quantity += 1
        End If
    End Sub

    Private Sub btnMul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMul.Click
        If frmMain.on_mul Then
            btnMul.BackColor = Color.LightCoral
            frmMain.on_mul = False
            frmMain.type_quantity -= 1
        Else
            btnMul.BackColor = Color.LightGreen
            frmMain.on_mul = True
            frmMain.type_quantity += 1
        End If
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        If frmMain.on_div Then
            btnDiv.BackColor = Color.LightCoral
            frmMain.on_div = False
            frmMain.type_quantity -= 1
        Else
            btnDiv.BackColor = Color.LightGreen
            frmMain.on_div = True
            frmMain.type_quantity += 1
        End If
    End Sub

End Class