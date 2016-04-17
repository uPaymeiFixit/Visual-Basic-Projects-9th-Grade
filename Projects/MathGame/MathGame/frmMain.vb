Public Class frmMain
    Public on_add As Boolean = True
    Public on_sub As Boolean
    Public on_mul As Boolean
    Public on_div As Boolean

    Private num_min As Int16 = 0
    Private num_max As Int16 = 20
    Private num_one As Int16
    Private num_two As Int16

    Public type_quantity As Int16

    Private problem_type As String = "+"

    Private Sub newProblem()
            num_one = (Rnd() * num_max + num_min) - num_min
            num_two = (Rnd() * num_max + num_min) - num_min

            Dim rand As Int16 = Rnd() * type_quantity
            Dim check As Boolean
            Do Until check
                If rand = 0 Then
                    If on_add Then
                        problem_type = "+"
                        check = True
                    Else
                        rand = Rnd() * type_quantity
                    End If
                ElseIf rand = 1 Then
                    If on_sub Then
                        problem_type = "-"
                        check = True
                    Else
                        rand = Rnd() * type_quantity
                    End If
                ElseIf rand = 2 Then
                    If on_mul Then
                        problem_type = "x"
                        check = True
                    Else
                        rand = Rnd() * type_quantity
                    End If
                ElseIf rand = 3 Then
                    If on_div Then
                        problem_type = "÷"
                        check = True
                    Else
                        rand = Rnd() * type_quantity
                    End If
                End If
            Loop

            lblProblemType.Text = problem_type
            lblNum1.Text = num_one
            lblNum2.Text = num_two
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        newProblem()
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        If problem_type = "+" Then
            If num_one + num_two = nudAnswer.Value Then
                newProblem()
                display(True)
            Else : display(False)
            End If
        End If
        If problem_type = "-" Then
            If num_one - num_two = nudAnswer.Value Then
                newProblem()
                display(True)
            Else : display(False)
            End If
        End If
        If problem_type = "x" Then
            If num_one * num_two = nudAnswer.Value Then
                newProblem()
                display(True)
            Else : display(False)
            End If
        End If
        If problem_type = "÷" Then
            If num_one / num_two = nudAnswer.Value Then
                newProblem()
                display(True)
            Else : display(False)
            End If
        End If
    End Sub

    Private Sub display(ByVal correct As Boolean)
        If correct Then

        End If
    End Sub

    Private Sub btnShowSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSettings.Click
        ChangeSettings.Visible = True
    End Sub
End Class
