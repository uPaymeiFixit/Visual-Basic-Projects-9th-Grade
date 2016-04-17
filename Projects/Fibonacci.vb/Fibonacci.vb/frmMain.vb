'Josh Gibbs
'Period 2
'10 January 2011
'Uses "For To" to display the fibonacci sequence

'To-Do
'Find maxout
'Make integers smallest bitsize possible

Public Class frmMain

    Private Sub btnForLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForLoop.Click
        'fibonacci variables
        Dim varF1 As UInt64 = 1
        Dim varF2 As UInt64 = 1
        Dim varF3 As UInt64
        Dim varFibonacciSum As UInt64
        Dim varFibonacciOutput As String = ""
        Dim varFibonacciError As String = ""

        'N! variables
        Dim varN1 As UInt64
        Dim varNSum As UInt64 = 1
        Dim varNOutput As String = ""
        Dim varNError As String = ""

        'Number variables
        Dim varU As UInt64
        Dim varUSum As UInt64
        Dim varUOutput As String = ""
        Dim varUError As String = ""

        'odd variables
        Dim varO As Int64 = -1
        Dim varOddSum As UInt64
        Dim varOddOutput As String = ""
        Dim varOddError As String = ""

        'even variables
        Dim varE As UInt64
        Dim varEvenSum As UInt64
        Dim varEvenOutput As String = ""
        Dim varEvenError As String = ""

        'other variables
        Dim varWhatTheHeckDoesThisDo As UInt64
        Dim varNumberCount As Int64 = Int64.Parse(nudInput.Value)
        Dim varAnswer As DialogResult = DialogResult.Yes

        'TMP
        Dim counter As Integer
        '/TMP

        If varNumberCount > 199 Then
            varAnswer = MessageBox.Show("WARNING: Your value of " & varNumberCount & " actions is estimated to take " & (varNumberCount / 1200).ToString("N") & " minutes. During this time your computer may run slowly. You can force quit this program at any time. Are you sure you want to continue?", "WARNING!", MessageBoxButtons.YesNo)
        End If
        If varAnswer = DialogResult.Yes Then

            'calculates fibonacci numbers to number count
            For varWhatTheHeckDoesThisDo = 1 To varNumberCount
                Try
                    'fibonacci work
                    varF1 = varF2
                    varF2 = varF3
                    varF3 = varF1 + varF2
                    varFibonacciSum += varF3
                    varFibonacciOutput = varFibonacciOutput & varF3 & vbNewLine
                Catch ex As Exception
                    varFibonacciError = "SYSTEM OVERFLOW" & vbNewLine
                End Try

                Try
                    'N! work
                    varN1 += 1
                    varNSum = varNSum * varN1
                    varNOutput = varNOutput & varN1 & vbNewLine
                Catch ex As Exception
                    varNError = "SYSTEM OVERFLOW" & vbNewLine
                End Try

                Try
                    'number work
                    varU += 1
                    varUSum += varU
                    varUOutput = varUOutput & varU & vbNewLine
                Catch ex As Exception
                    varUError = "SYSTEM OVERFLOW" & vbNewLine
                End Try

                Try
                    'odd work
                    'TMP
                    counter += 1
                    '/TMP
                    varO += 2
                    varOddSum += varO
                    varOddOutput = varOddOutput & varO & vbNewLine
                Catch ex As Exception
                    varOddError = "SYSTEM OVERFLOW" & vbNewLine
                    'TMP
                    MessageBox.Show(counter)
                    '/TMP
                End Try

                Try
                    'even work
                    varE += 2
                    varEvenSum += varE
                    varEvenOutput = varEvenOutput & varE & vbNewLine
                Catch ex As Exception
                    varEvenError = "SYSTEM OVERFLOW" & vbNewLine
                End Try
            Next

            'outputs text and changes form size
            lblFibonacciOutput.Text = varFibonacciError & "Fibonacci Sequence" & vbNewLine & "Sum: " & varFibonacciSum & vbNewLine & varFibonacciOutput & vbNewLine & "SYSTEM OVERFLOW"
            lblNOutput.Text = varNError & "N! Factorial" & vbNewLine & "Product: " & varNSum & vbNewLine & varNOutput & vbNewLine & "SYSTEM" & vbNewLine & "OVERFLOW"
            lblNumber.Text = varUError & "Number Sequence" & vbNewLine & "Sum: " & varUSum & vbNewLine & varUOutput & vbNewLine & "SYSTEM" & vbNewLine & "OVERFLOW"
            lblOddOutput.Text = varOddError & "Odd Sequence" & vbNewLine & "Sum: " & varOddSum & vbNewLine & varOddOutput & vbNewLine & "SYSTEM OVERFLOW"
            lblEvenOutput.Text = varEvenError & "Even Sequence" & vbNewLine & "Sum: " & varEvenSum & vbNewLine & varEvenOutput & vbNewLine & "SYSTEM OVERFLOW"
            Me.Height = varNumberCount * 13 + 90

        End If
    End Sub

    Private Sub nudInput_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudInput.ValueChanged
        btnForLoop.PerformClick()
    End Sub
End Class