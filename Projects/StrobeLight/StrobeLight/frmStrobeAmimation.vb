'Strobe + Water drops
'uPaymeiFixit

Public Class frmMain
    Public obj_ammount As Int16
    Public obj_Spacing As Int16
    Public obj_size As Int16
    Public obj_speed As Int16
    Public obj(obj_ammount) As Label

    Dim stb_LightIsOn As Boolean

    Dim bdr_bottom As Int16 = 26

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = (obj_ammount + 1) * (obj_size + obj_Spacing) + bdr_bottom
        Me.Width = tbStbSpeed.Width + 15 + obj_size + 20
        tbStbSpeed.Height = Me.Height - tbStbSpeed.Top - bdr_bottom
        For i = 0 To obj_ammount
            obj(i) = New Label
            Me.Controls.Add(obj(i))
            obj(i).BackColor = Color.Black
            obj(i).SetBounds(tbStbSpeed.Width + 15, i * (obj_size + obj_Spacing), obj_size, obj_size)
        Next
    End Sub

    Private Sub tmrObjMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrObjMovement.Tick
        For i = 0 To obj_ammount
            obj(i).Top += obj_speed
            If obj(i).Top = Me.Height - bdr_bottom Then
                obj(i).Top = 0
            End If
        Next
    End Sub

    Private Sub tmrStrobeLight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStrobeLight.Tick

        If stb_LightIsOn = True Then
            stb_LightIsOn = False
            For i = 0 To obj_ammount
                obj(i).BackColor = Color.Lime
            Next
            tmrStrobeLight.Interval = 1
        ElseIf stb_LightIsOn = False Then
            stb_LightIsOn = True
            For i = 0 To obj_ammount
                obj(i).BackColor = Color.Black
            Next
            tmrStrobeLight.Interval = tbStbSpeed.Value
        End If
    End Sub

    Private Sub tbStbSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbStbSpeed.Scroll
        tmrStrobeLight.Interval = tbStbSpeed.Value
        nudStbSpeed.Value = tbStbSpeed.Value
    End Sub

    Private Sub nudStbSpeed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudStbSpeed.ValueChanged
        tmrStrobeLight.Interval = nudStbSpeed.Value
        tbStbSpeed.Value = nudStbSpeed.Value
    End Sub

    Private Sub frmMain_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If tmrStrobeLight.Enabled = True Then
            tmrStrobeLight.Enabled = False
            For i = 0 To obj_ammount
                obj(i).BackColor = Color.Blue
            Next
            Me.BackColor = Color.White
            nudStbSpeed.BackColor = Color.White
            nudStbSpeed.ForeColor = Color.Black
        Else
            tmrStrobeLight.Enabled = True
            For i = 0 To obj_ammount
                obj(i).BackColor = Color.Black
            Next
            Me.BackColor = Color.Black
            nudStbSpeed.BackColor = Color.Black
            nudStbSpeed.ForeColor = Color.White
        End If
    End Sub

End Class