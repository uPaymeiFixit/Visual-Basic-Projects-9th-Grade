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
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblProblemType = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.nudAnswer = New System.Windows.Forms.NumericUpDown()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnShowSettings = New System.Windows.Forms.Button()
        CType(Me.nudAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(18, 18)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(109, 76)
        Me.lblNum1.TabIndex = 0
        Me.lblNum1.Text = "00"
        '
        'lblProblemType
        '
        Me.lblProblemType.AutoSize = True
        Me.lblProblemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProblemType.Location = New System.Drawing.Point(133, 18)
        Me.lblProblemType.Name = "lblProblemType"
        Me.lblProblemType.Size = New System.Drawing.Size(73, 76)
        Me.lblProblemType.TabIndex = 0
        Me.lblProblemType.Text = "+"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(212, 18)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(109, 76)
        Me.lblNum2.TabIndex = 0
        Me.lblNum2.Text = "00"
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquals.Location = New System.Drawing.Point(327, 18)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(73, 76)
        Me.lblEquals.TabIndex = 0
        Me.lblEquals.Text = "="
        '
        'nudAnswer
        '
        Me.nudAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAnswer.Location = New System.Drawing.Point(406, 16)
        Me.nudAnswer.Name = "nudAnswer"
        Me.nudAnswer.Size = New System.Drawing.Size(125, 83)
        Me.nudAnswer.TabIndex = 1
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(31, 105)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(500, 61)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Done"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnShowSettings
        '
        Me.btnShowSettings.Location = New System.Drawing.Point(465, 252)
        Me.btnShowSettings.Name = "btnShowSettings"
        Me.btnShowSettings.Size = New System.Drawing.Size(75, 23)
        Me.btnShowSettings.TabIndex = 3
        Me.btnShowSettings.Text = "Settings"
        Me.btnShowSettings.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 287)
        Me.Controls.Add(Me.btnShowSettings)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.nudAnswer)
        Me.Controls.Add(Me.lblEquals)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblProblemType)
        Me.Controls.Add(Me.lblNum1)
        Me.Name = "frmMain"
        Me.Text = "Jon's Math Game"
        CType(Me.nudAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblProblemType As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblEquals As System.Windows.Forms.Label
    Friend WithEvents nudAnswer As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnShowSettings As System.Windows.Forms.Button

End Class
