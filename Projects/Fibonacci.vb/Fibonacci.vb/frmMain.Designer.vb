<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFibonacciOutput = New System.Windows.Forms.Label()
        Me.btnForLoop = New System.Windows.Forms.Button()
        Me.lblOddOutput = New System.Windows.Forms.Label()
        Me.lblEvenOutput = New System.Windows.Forms.Label()
        Me.lblNOutput = New System.Windows.Forms.Label()
        Me.nudInput = New System.Windows.Forms.NumericUpDown()
        Me.lblNumber = New System.Windows.Forms.Label()
        CType(Me.nudInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFibonacciOutput
        '
        Me.lblFibonacciOutput.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblFibonacciOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFibonacciOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFibonacciOutput.Location = New System.Drawing.Point(0, 38)
        Me.lblFibonacciOutput.Name = "lblFibonacciOutput"
        Me.lblFibonacciOutput.Size = New System.Drawing.Size(160, 1000)
        Me.lblFibonacciOutput.TabIndex = 0
        Me.lblFibonacciOutput.Text = "Fibonacci Sequence"
        Me.lblFibonacciOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnForLoop
        '
        Me.btnForLoop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnForLoop.Location = New System.Drawing.Point(0, -1)
        Me.btnForLoop.Name = "btnForLoop"
        Me.btnForLoop.Size = New System.Drawing.Size(592, 21)
        Me.btnForLoop.TabIndex = 2
        Me.btnForLoop.Text = "Calculate"
        Me.btnForLoop.UseVisualStyleBackColor = False
        '
        'lblOddOutput
        '
        Me.lblOddOutput.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblOddOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOddOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOddOutput.Location = New System.Drawing.Point(160, 38)
        Me.lblOddOutput.Name = "lblOddOutput"
        Me.lblOddOutput.Size = New System.Drawing.Size(81, 1000)
        Me.lblOddOutput.TabIndex = 0
        Me.lblOddOutput.Text = "Odd Sequence"
        Me.lblOddOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEvenOutput
        '
        Me.lblEvenOutput.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblEvenOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEvenOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvenOutput.Location = New System.Drawing.Point(241, 38)
        Me.lblEvenOutput.Name = "lblEvenOutput"
        Me.lblEvenOutput.Size = New System.Drawing.Size(86, 1000)
        Me.lblEvenOutput.TabIndex = 0
        Me.lblEvenOutput.Text = "Even Sequence"
        Me.lblEvenOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNOutput
        '
        Me.lblNOutput.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblNOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOutput.Location = New System.Drawing.Point(425, 38)
        Me.lblNOutput.Name = "lblNOutput"
        Me.lblNOutput.Size = New System.Drawing.Size(167, 1000)
        Me.lblNOutput.TabIndex = 0
        Me.lblNOutput.Text = "N! Factorial Sequence"
        Me.lblNOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nudInput
        '
        Me.nudInput.BackColor = System.Drawing.SystemColors.Info
        Me.nudInput.Location = New System.Drawing.Point(0, 18)
        Me.nudInput.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudInput.Name = "nudInput"
        Me.nudInput.Size = New System.Drawing.Size(592, 20)
        Me.nudInput.TabIndex = 3
        '
        'lblNumber
        '
        Me.lblNumber.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(327, 38)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(98, 1000)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Number Sequence"
        Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(591, 57)
        Me.Controls.Add(Me.nudInput)
        Me.Controls.Add(Me.lblNOutput)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblEvenOutput)
        Me.Controls.Add(Me.lblOddOutput)
        Me.Controls.Add(Me.lblFibonacciOutput)
        Me.Controls.Add(Me.btnForLoop)
        Me.Name = "frmMain"
        Me.Text = "Number Sequences                                                                 " & _
            "    Josh Gibbs"
        CType(Me.nudInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFibonacciOutput As System.Windows.Forms.Label
    Friend WithEvents btnForLoop As System.Windows.Forms.Button
    Friend WithEvents lblOddOutput As System.Windows.Forms.Label
    Friend WithEvents lblEvenOutput As System.Windows.Forms.Label
    Friend WithEvents lblNOutput As System.Windows.Forms.Label
    Friend WithEvents nudInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNumber As System.Windows.Forms.Label

End Class
