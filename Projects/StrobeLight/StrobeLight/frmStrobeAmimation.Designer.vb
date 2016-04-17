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
        Me.components = New System.ComponentModel.Container()
        Me.tmrObjMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStrobeLight = New System.Windows.Forms.Timer(Me.components)
        Me.tbStbSpeed = New System.Windows.Forms.TrackBar()
        Me.nudStbSpeed = New System.Windows.Forms.NumericUpDown()
        CType(Me.tbStbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrObjMovement
        '
        Me.tmrObjMovement.Interval = 1
        '
        'tmrStrobeLight
        '
        Me.tmrStrobeLight.Interval = 1
        '
        'tbStbSpeed
        '
        Me.tbStbSpeed.Location = New System.Drawing.Point(0, 22)
        Me.tbStbSpeed.Maximum = 400
        Me.tbStbSpeed.Minimum = 1
        Me.tbStbSpeed.Name = "tbStbSpeed"
        Me.tbStbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbStbSpeed.Size = New System.Drawing.Size(45, 35)
        Me.tbStbSpeed.TabIndex = 0
        Me.tbStbSpeed.Value = 1
        '
        'nudStbSpeed
        '
        Me.nudStbSpeed.BackColor = System.Drawing.Color.Black
        Me.nudStbSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudStbSpeed.ForeColor = System.Drawing.Color.White
        Me.nudStbSpeed.Location = New System.Drawing.Point(0, 0)
        Me.nudStbSpeed.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudStbSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStbSpeed.Name = "nudStbSpeed"
        Me.nudStbSpeed.Size = New System.Drawing.Size(45, 20)
        Me.nudStbSpeed.TabIndex = 2
        Me.nudStbSpeed.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(52, 54)
        Me.Controls.Add(Me.nudStbSpeed)
        Me.Controls.Add(Me.tbStbSpeed)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.Text = "Strobe"
        CType(Me.tbStbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrObjMovement As System.Windows.Forms.Timer
    Friend WithEvents tmrStrobeLight As System.Windows.Forms.Timer
    Friend WithEvents tbStbSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents nudStbSpeed As System.Windows.Forms.NumericUpDown

End Class
