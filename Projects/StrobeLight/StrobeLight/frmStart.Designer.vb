<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.nudObjAmmount = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudObjSpacing = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudObjSize = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudObjSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        CType(Me.nudObjAmmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudObjSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudObjSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudObjSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudObjAmmount
        '
        Me.nudObjAmmount.Location = New System.Drawing.Point(132, 7)
        Me.nudObjAmmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudObjAmmount.Name = "nudObjAmmount"
        Me.nudObjAmmount.Size = New System.Drawing.Size(48, 20)
        Me.nudObjAmmount.TabIndex = 0
        Me.nudObjAmmount.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of drops:"
        '
        'nudObjSpacing
        '
        Me.nudObjSpacing.Location = New System.Drawing.Point(132, 33)
        Me.nudObjSpacing.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudObjSpacing.Name = "nudObjSpacing"
        Me.nudObjSpacing.Size = New System.Drawing.Size(48, 20)
        Me.nudObjSpacing.TabIndex = 1
        Me.nudObjSpacing.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Space between drops:"
        '
        'nudObjSize
        '
        Me.nudObjSize.Location = New System.Drawing.Point(132, 59)
        Me.nudObjSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudObjSize.Name = "nudObjSize"
        Me.nudObjSize.Size = New System.Drawing.Size(48, 20)
        Me.nudObjSize.TabIndex = 2
        Me.nudObjSize.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Size of drops:"
        '
        'nudObjSpeed
        '
        Me.nudObjSpeed.Location = New System.Drawing.Point(132, 85)
        Me.nudObjSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudObjSpeed.Name = "nudObjSpeed"
        Me.nudObjSpeed.Size = New System.Drawing.Size(48, 20)
        Me.nudObjSpeed.TabIndex = 3
        Me.nudObjSpeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Speed of drops:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 111)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(168, 20)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 142)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudObjSpeed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudObjSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudObjSpacing)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudObjAmmount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStart"
        Me.Text = "Start Page"
        CType(Me.nudObjAmmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudObjSpacing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudObjSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudObjSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudObjAmmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudObjSpacing As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudObjSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudObjSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
End Class
