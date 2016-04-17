'Josh Gibbs
'Period 2
'18 February 2011
'Tic-Tac-Toe

Public Class frmMain
    Private varWhosTurn As String = "O"
    Private varBorderColor As Color
    Private myArray(2, 2) As Label
    Private varX As Integer
    Private varY As Integer
    Private varMoveCounter As Integer
    Private varEnd As Boolean
    Private XWins As Integer
    Private OWins As Integer
    Private CWins As Integer

    Private Sub lblZeroZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblZeroZero.Click
        varX = 0
        varY = 0
        Turn(lblZeroZero)
    End Sub

    Private Sub lblOneZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOneZero.Click
        varX = 1
        varY = 0
        Turn(lblOneZero)
    End Sub

    Private Sub lblTwoZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTwoZero.Click
        varX = 2
        varY = 0
        Turn(lblTwoZero)
    End Sub

    Private Sub lblZeroOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblZeroOne.Click
        varX = 0
        varY = 1
        Turn(lblZeroOne)
    End Sub

    Private Sub lblOneOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOneOne.Click
        varX = 1
        varY = 1
        Turn(lblOneOne)
    End Sub

    Private Sub lblTwoOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTwoOne.Click
        varX = 2
        varY = 1
        Turn(lblTwoOne)
    End Sub

    Private Sub lblZeroTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblZeroTwo.Click
        varX = 0
        varY = 2
        Turn(lblZeroTwo)
    End Sub

    Private Sub lblOneTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOneTwo.Click
        varX = 1
        varY = 2
        Turn(lblOneTwo)
    End Sub

    Private Sub lblTwoTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTwoTwo.Click
        varX = 2
        varY = 2
        Turn(lblTwoTwo)
    End Sub

    Private Function Turn(ByVal varObject)
        varMoveCounter += 1

        myArray(0, 0) = lblZeroZero
        myArray(1, 0) = lblOneZero
        myArray(2, 0) = lblTwoZero
        myArray(0, 1) = lblZeroOne
        myArray(1, 1) = lblOneOne
        myArray(2, 1) = lblTwoOne
        myArray(0, 2) = lblZeroTwo
        myArray(1, 2) = lblOneTwo
        myArray(2, 2) = lblTwoTwo



        If varObject.Text = "" And varEnd = False Then
            If varWhosTurn = "X" Then
                varWhosTurn = "O"
                varBorderColor = Color.Blue
                With lblTurn
                    .ForeColor = Color.Red
                    .Text = "X's"
                End With
            Else
                varWhosTurn = "X"
                varBorderColor = Color.Red
                With lblTurn
                    .ForeColor = Color.Blue
                    .Text = "O's"
                End With
            End If

            varObject.ForeColor = varBorderColor
            myArray(varX, varY).Text = varWhosTurn

            If varMoveCounter > 4 Then
                'X's Horizontal Wins
                If lblZeroZero.Text = "X" And lblOneZero.Text = "X" And lblTwoZero.Text = "X" Then
                    lblZeroZero.Text = "W" : lblOneZero.Text = "I" : lblTwoZero.Text = "N"
                    varEnd = True
                    XWins += 1
                ElseIf lblZeroOne.Text = "X" And lblOneOne.Text = "X" And lblTwoOne.Text = "X" Then
                    lblZeroOne.Text = "W" : lblOneOne.Text = "I" : lblTwoOne.Text = "N"
                    varEnd = True
                    XWins += 1
                ElseIf lblZeroTwo.Text = "X" And lblOneTwo.Text = "X" And lblTwoTwo.Text = "X" Then
                    lblZeroTwo.Text = "W" : lblOneTwo.Text = "I" : lblTwoTwo.Text = "N"
                    varEnd = True
                    XWins += 1
                    'X's Vertical Wins
                ElseIf lblZeroZero.Text = "X" And lblZeroOne.Text = "X" And lblZeroTwo.Text = "X" Then
                    lblZeroZero.Text = "W" : lblZeroOne.Text = "I" : lblZeroTwo.Text = "N"
                    varEnd = True
                    XWins += 1
                ElseIf lblOneZero.Text = "X" And lblOneOne.Text = "X" And lblOneTwo.Text = "X" Then
                    lblOneZero.Text = "W" : lblOneOne.Text = "I" : lblOneTwo.Text = "N"
                    varEnd = True
                    XWins += 1
                ElseIf lblTwoZero.Text = "X" And lblTwoOne.Text = "X" And lblTwoTwo.Text = "X" Then
                    lblTwoZero.Text = "W" : lblTwoOne.Text = "I" : lblTwoTwo.Text = "N"
                    varEnd = True
                    XWins += 1
                    'X's Diagnal Wins
                ElseIf lblZeroZero.Text = "X" And lblOneOne.Text = "X" And lblTwoTwo.Text = "X" Then
                    lblZeroZero.Text = "W" : lblOneOne.Text = "I" : lblTwoTwo.Text = "N"
                    varEnd = True
                    XWins += 1
                ElseIf lblZeroTwo.Text = "X" And lblOneOne.Text = "X" And lblTwoZero.Text = "X" Then
                    lblZeroTwo.Text = "W" : lblOneOne.Text = "I" : lblTwoZero.Text = "N"
                    varEnd = True
                    XWins += 1
                    'O's Horizontal Wins
                ElseIf lblZeroZero.Text = "O" And lblOneZero.Text = "O" And lblTwoZero.Text = "O" Then
                    lblZeroZero.Text = "W" : lblOneZero.Text = "I" : lblTwoZero.Text = "N"
                    varEnd = True
                    OWins += 1
                ElseIf lblZeroOne.Text = "O" And lblOneOne.Text = "O" And lblTwoOne.Text = "O" Then
                    lblZeroOne.Text = "W" : lblOneOne.Text = "I" : lblTwoOne.Text = "N"
                    varEnd = True
                    OWins += 1
                ElseIf lblZeroTwo.Text = "O" And lblOneTwo.Text = "O" And lblTwoTwo.Text = "O" Then
                    lblZeroTwo.Text = "W" : lblOneTwo.Text = "I" : lblTwoTwo.Text = "N"
                    varEnd = True
                    OWins += 1
                    'O's Vertical Wins
                ElseIf lblZeroZero.Text = "O" And lblZeroOne.Text = "O" And lblZeroTwo.Text = "O" Then
                    lblZeroZero.Text = "W" : lblZeroOne.Text = "I" : lblZeroTwo.Text = "N"
                    varEnd = True
                    OWins += 1
                ElseIf lblOneZero.Text = "O" And lblOneOne.Text = "O" And lblOneTwo.Text = "O" Then
                    lblOneZero.Text = "W" : lblOneOne.Text = "I" : lblOneTwo.Text = "N"
                    varEnd = True
                    OWins += 1
                ElseIf lblTwoZero.Text = "O" And lblTwoOne.Text = "O" And lblTwoTwo.Text = "O" Then
                    lblTwoZero.Text = "W" : lblTwoOne.Text = "I" : lblTwoTwo.Text = "N"
                    varEnd = True
                    OWins += 1
                    'O's Diagnal Wins
                ElseIf lblZeroZero.Text = "O" And lblOneOne.Text = "O" And lblTwoTwo.Text = "O" Then
                    lblZeroZero.Text = "W" : lblOneOne.Text = "I" : lblTwoTwo.Text = "N"
                    varEnd = True
                    OWins += 1
                ElseIf lblZeroTwo.Text = "O" And lblOneOne.Text = "O" And lblTwoZero.Text = "O" Then
                    lblZeroTwo.Text = "W" : lblOneOne.Text = "I" : lblTwoZero.Text = "N"
                    varEnd = True
                    OWins += 1
                    'Cats Game
                ElseIf varMoveCounter = 9 Then
                    lblZeroZero.Text = "C" : lblOneZero.Text = "A" : lblTwoZero.Text = "T"
                    lblZeroOne.Text = "C" : lblOneOne.Text = "A" : lblTwoOne.Text = "T"
                    lblZeroTwo.Text = "C" : lblOneTwo.Text = "A" : lblTwoTwo.Text = "T"
                    CWins += 1
                End If

                lblXWins.Text = "X's Wins: " & XWins
                lblOWins.Text = "O's Wins: " & OWins
                lblCWins.Text = "Cats Games: " & CWins
            End If
        End If
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        varWhosTurn = "O"
        varMoveCounter = 0
        varEnd = False
        With lblTurn
            .ForeColor = Color.Red
            .Text = "X's"
        End With
        lblZeroZero.Text = ""
        lblOneZero.Text = ""
        lblTwoZero.Text = ""
        lblZeroOne.Text = ""
        lblOneOne.Text = ""
        lblTwoOne.Text = ""
        lblZeroTwo.Text = ""
        lblOneTwo.Text = ""
        lblTwoTwo.Text = ""
    End Sub
End Class