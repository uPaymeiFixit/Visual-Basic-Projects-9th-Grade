Public Class frmMain
    'how to make starfeild
    'declare array to hold the stars
    Private arStars(49) As Object

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'assign each star possition
        arStars(0) = OvalShape0
        arStars(1) = OvalShape1
        arStars(2) = OvalShape2
        arStars(3) = OvalShape3
        arStars(4) = OvalShape4
        arStars(5) = OvalShape5
        arStars(6) = OvalShape6
        arStars(7) = OvalShape7
        arStars(8) = OvalShape8
        arStars(9) = OvalShape9
        arStars(10) = OvalShape10
        arStars(11) = OvalShape11
        arStars(12) = OvalShape12
        arStars(13) = OvalShape13
        arStars(14) = OvalShape14
        arStars(15) = OvalShape15
        arStars(16) = OvalShape16
        arStars(17) = OvalShape17
        arStars(18) = OvalShape18
        arStars(19) = OvalShape19
        arStars(20) = OvalShape20
        arStars(21) = OvalShape21
        arStars(22) = OvalShape22
        arStars(23) = OvalShape23
        arStars(24) = OvalShape24
        arStars(25) = OvalShape25
        arStars(26) = OvalShape26
        arStars(27) = OvalShape27
        arStars(28) = OvalShape28
        arStars(29) = OvalShape29
        arStars(30) = OvalShape30
        arStars(31) = OvalShape31
        arStars(32) = OvalShape32
        arStars(33) = OvalShape33
        arStars(34) = OvalShape34
        arStars(35) = OvalShape35
        arStars(36) = OvalShape36
        arStars(37) = OvalShape37
        arStars(38) = OvalShape38
        arStars(39) = OvalShape39
        arStars(40) = OvalShape40
        arStars(41) = OvalShape41
        arStars(42) = OvalShape42
        arStars(43) = OvalShape43
        arStars(44) = OvalShape44
        arStars(45) = OvalShape45
        arStars(46) = OvalShape46
        arStars(47) = OvalShape47
        arStars(48) = OvalShape48
        arStars(49) = OvalShape49

        Randomize()
        Dim N As Integer
        For N = 0 To 49 Step 1
            'random coordinants
            Dim randomX As Integer = Rnd() * Me.Width
            Dim randomY As Integer = Rnd() * Me.Height
            'random size
            Dim size As Integer = Rnd() * 20 + 10

            'redraw stars
            arStars(N).setbounds(randomX, randomY, size, size)

        Next
    End Sub

    Private Sub tmrStarMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStarMovement.Tick
        'increase size of stars
        Dim M As Integer
        Dim changesize As Integer

        For M = 0 To 49 Step 1
            changesize = arStars(M).width + 1
            'reset size of the stars
            If changesize >= 30 Then
                Dim randomX As Integer = Rnd() * Me.Width
                Dim randomY As Integer = Rnd() * Me.Height
                arStars(M).setbounds(randomX, randomY, 1, 1)
            Else
                arStars(M).setbounds(arStars(M).left, arStars(M).top, changesize, changesize)
            End If



            If arStars(M).left <= Me.Width / 2 Then
                arStars(M).left -= 5
            Else
                arStars(M).left += 5
            End If
            If arStars(M).top <= Me.Height / 2 Then
                arStars(M).top -= 5
            Else
                arStars(M).top += 5
            End If

        Next

    End Sub
End Class
