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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnForLoop = New System.Windows.Forms.Button()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.txtHowMany = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(114, 9)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(69, 462)
        Me.lblOutput.TabIndex = 0
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(12, 12)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(75, 23)
        Me.btnRandom.TabIndex = 1
        Me.btnRandom.Text = "Random"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'btnForLoop
        '
        Me.btnForLoop.Location = New System.Drawing.Point(13, 42)
        Me.btnForLoop.Name = "btnForLoop"
        Me.btnForLoop.Size = New System.Drawing.Size(75, 23)
        Me.btnForLoop.TabIndex = 2
        Me.btnForLoop.Text = "For Loop"
        Me.btnForLoop.UseVisualStyleBackColor = True
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(12, 97)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(75, 23)
        Me.btnDoLoop.TabIndex = 3
        Me.btnDoLoop.Text = "Do Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'txtHowMany
        '
        Me.txtHowMany.Location = New System.Drawing.Point(14, 71)
        Me.txtHowMany.Name = "txtHowMany"
        Me.txtHowMany.Size = New System.Drawing.Size(74, 20)
        Me.txtHowMany.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 480)
        Me.Controls.Add(Me.txtHowMany)
        Me.Controls.Add(Me.btnDoLoop)
        Me.Controls.Add(Me.btnForLoop)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "frmMain"
        Me.Text = "How to generate random numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents btnForLoop As System.Windows.Forms.Button
    Friend WithEvents btnDoLoop As System.Windows.Forms.Button
    Friend WithEvents txtHowMany As System.Windows.Forms.TextBox

End Class
