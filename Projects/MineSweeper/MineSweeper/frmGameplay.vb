'TO-DO
'If width is an odd number the pattern is striped
'Nothing is executed past (A)Next

Public Class frmGameplay

    Private blockSize As Int16 = 100
    Private blocksWide As Int16 = 5
    Private blocksHigh As Int16 = 5
    Private bombs As Int16 = 5
    Private block(blocksWide - 1, blocksHigh - 1) As Label

    Private x As Int16
    Private y As Int16

    'h and k are temporary until I figure out why .Load is not executing everything
    Private h As Int16
    Private k As Int16




    Private Sub frmGameplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = blocksHigh * blockSize + 30
        Me.Width = blocksWide * blockSize + 8


        'Puts blocks (labels) in the right spots and colors them
        Dim pattern As Boolean
        For a = 0 To blocksWide * blocksHigh
            block(x, y) = New Label
            Me.Controls.Add(block(x, y))

            If pattern Then
                pattern = False
                block(x, y).BackColor = Color.SteelBlue
            Else
                pattern = True
                block(x, y).BackColor = Color.CornflowerBlue
            End If

            block(x, y).SetBounds(x * blockSize, y * blockSize, blockSize, blockSize)
            x += 1
            If x = blocksWide Then
                x = 0
                y += 1

                If y <> 0 Then
                    If block(x, y - 1).BackColor = Color.SteelBlue Then
                        pattern = False
                    Else
                        pattern = True
                    End If
                End If

            End If
        Next
        block(0, 0).BackColor = Color.Red



        'Assigns bombs to random blocks
        x = 0
        y = 0
        For b = 1 To bombs
            Dim check As Boolean
            Do Until check
                x = Rnd() * blocksWide
                y = Rnd() * blocksHigh
                If block(x, y).Tag <> "Bomb" Then
                    block(x, y).Tag = "Bomb"
                    check = True
                End If
            Loop
        Next



        'Assigns numbers to other blocks
        x = 0
        y = 0
        For c = 0 To blocksWide * blocksHigh
            If block(x, y).Tag <> "Bomb" Then
                If y <> 0 Then
                    If x <> 0 Then
                        If block(x - 1, y - 1).Tag = "Bomb" Then
                            block(x, y).Tag += 1
                        End If
                    End If
                    If block(x, y - 1).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                    If x <> blocksWide Then
                        If block(x + 1, y - 1).Tag = "Bomb" Then
                            block(x, y).Tag += 1
                        End If
                    End If
                End If
                If x <> blocksWide Then
                    If block(x + 1, y).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                End If
                If y <> blocksHigh Then
                    If x <> blocksWide Then
                        If block(x + 1, y + 1).Tag = "Bomb" Then
                            block(x, y).Tag += 1
                        End If
                    End If
                    If block(x, y + 1).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                    If x <> 0 Then
                        If block(x - 1, y + 1).Tag = "Bomb" Then
                            block(x, y).Tag += 1
                        End If
                    End If
                End If
                If x <> 0 Then
                    If block(x - 1, y).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                End If
            End If

            x += 1
            If x = blocksWide Then
                x = 0
                y += 1
            End If
        Next
        x = 0
        y = 0


    End Sub


    Private Sub frmGameplay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            If h <> 0 Then
                h -= 1
                DoColorChange()
            End If
        End If
        If e.KeyCode = Keys.Right Then
            If h <> blocksWide - 1 Then
                h += 1
                DoColorChange()
            End If
        End If
        If e.KeyCode = Keys.Up Then
            If k <> 0 Then
                k -= 1
                DoColorChange()
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If k <> blocksHigh - 1 Then
                k += 1
                DoColorChange()
            End If
        End If

        If e.KeyCode = Keys.V Then
            If block(h, k).Tag = "Bomb" Then
                'GameOver
            Else
                If prev_color = Color.SteelBlue Then
                    block(h, k).BackColor = Color.LightGray
                    prev_color = Color.LightGray
                ElseIf prev_color = Color.CornflowerBlue Then
                    block(h, k).BackColor = Color.White
                    prev_color = Color.White
                End If
                block(h, k).Text = block(h, k).Tag

                '(0, 0) (1, 0) (2, 0) (3, 0) (4, 0) (5, 0) (6, 0) (7, 0) (8, 0) (9, 0)
                '(0, 1) (1, 1) (2, 1) (3, 1) (4, 1) (5, 1) (6, 1) (7, 1) (8, 1) (9, 1)
                '(0, 2) (1, 2) (2, 2) (3, 2) (4, 2) (5, 2) (6, 2) (7, 2) (8, 2) (9, 2)
                '(0, 3) (1, 3) (2, 3) (3, 3) (4, 3) (5, 3) (6, 3) (7, 3) (8, 3) (9, 3)
                '(0, 4) (1, 4) (2, 4) (3, 4) (4, 4) (5, 4) (6, 4) (7, 4) (8, 4) (9, 4)
                '(0, 5) (1, 5) (2, 5) (3, 5) (4, 5) (5, 5) (6, 5) (7, 5) (8, 5) (9, 5)
                '(0, 6) (1, 6) (2, 6) (3, 6) (4, 6) (5, 6) (6, 6) (7, 6) (8, 6) (9, 6)
                '(0, 7) (1, 7) (2, 7) (3, 7) (4, 7) (5, 7) (6, 7) (7, 7) (8, 7) (9, 7)
                '(0, 8) (1, 8) (2, 8) (3, 8) (4, 8) (5, 8) (6, 8) (7, 8) (8, 8) (9, 8)
                '(0, 9) (1, 9) (2, 9) (3, 9) (4, 9) (5, 9) (6, 9) (7, 9) (8, 9) (9, 9)

                If y <> 0 Then
                    If x <> 0 Then
                        If block(x - 1, y - 1).Tag <> "Bomb" Then

                        End If
                    End If
                    If block(x, y - 1).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                    If x <> blocksWide Then
                        If block(x + 1, y - 1).Tag = "Bomb" Then
                            block(x, y).Tag += 1
                        End If
                    End If
                End If
                If x <> blocksWide Then
                    If block(x + 1, y).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                End If
                If y <> blocksHigh Then
                    If x <> blocksWide Then
                        If block(x + 1, y + 1).Tag = "Bomb" Then
                            block(x, y).Tag += 1
                        End If
                    End If
                    If block(x, y + 1).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                    If x <> 0 Then
                        If block(x - 1, y + 1).Tag = "Bomb" Then
                            block(x, y).Tag += 1
                        End If
                    End If
                End If
                If x <> 0 Then
                    If block(x - 1, y).Tag = "Bomb" Then
                        block(x, y).Tag += 1
                    End If
                End If
            End If

        End If

        If e.KeyCode = Keys.Space Then
            block(h, k).BackColor = Color.Red
            prev_color = Color.Red
        End If

    End Sub


    Private Sub frmGameplay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space Then
            block(h, k).BackColor = Color.Lime
        End If
    End Sub


    Private prev_locX As Int16
    Private prev_locY As Int16
    Private prev_color As Color = Color.CornflowerBlue
    Private Sub DoColorChange()
        block(prev_locX, prev_locY).BackColor = prev_color
        prev_locX = h
        prev_locY = k
        prev_color = block(h, k).BackColor
        block(h, k).BackColor = Color.Lime
    End Sub
End Class

'When digging a block up, we need to check for .Tag = "" touching x, y
'Then block(x + h, y + k).BackColor = "White Scale Blue"

'When a block is uncovered, if it is "" then all blocks touching it that <> "Bomb" (we will call these safes) are uncovered
'If any of the safes = "" then all the blocks around it must be investigated in the same way