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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter2 = New System.Diagnostics.PerformanceCounter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.lblCPUUsage = New System.Windows.Forms.Label()
        Me.lblCPUTemp = New System.Windows.Forms.Label()
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.lblPing = New System.Windows.Forms.Label()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total CPU Usage"
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Thread"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "Idle/0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(99, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(200, 10)
        Me.ProgressBar1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PerformanceCounter2
        '
        Me.PerformanceCounter2.CategoryName = "Memory"
        Me.PerformanceCounter2.CounterName = "Available MBytes"
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CPU Core Temp"
        '
        'ProgressBar3
        '
        Me.ProgressBar3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProgressBar3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar3.Location = New System.Drawing.Point(99, 33)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(200, 10)
        Me.ProgressBar3.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Available RAM"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProgressBar2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar2.Location = New System.Drawing.Point(99, 50)
        Me.ProgressBar2.Maximum = 2000
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(200, 10)
        Me.ProgressBar2.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(347, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(337, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(65, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ping"
        '
        'ProgressBar4
        '
        Me.ProgressBar4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProgressBar4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar4.Location = New System.Drawing.Point(99, 67)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(200, 10)
        Me.ProgressBar4.TabIndex = 16
        '
        'lblCPUUsage
        '
        Me.lblCPUUsage.AutoSize = True
        Me.lblCPUUsage.ForeColor = System.Drawing.Color.White
        Me.lblCPUUsage.Location = New System.Drawing.Point(306, 13)
        Me.lblCPUUsage.Name = "lblCPUUsage"
        Me.lblCPUUsage.Size = New System.Drawing.Size(33, 13)
        Me.lblCPUUsage.TabIndex = 17
        Me.lblCPUUsage.Text = "100%"
        '
        'lblCPUTemp
        '
        Me.lblCPUTemp.AutoSize = True
        Me.lblCPUTemp.ForeColor = System.Drawing.Color.White
        Me.lblCPUTemp.Location = New System.Drawing.Point(306, 30)
        Me.lblCPUTemp.Name = "lblCPUTemp"
        Me.lblCPUTemp.Size = New System.Drawing.Size(36, 13)
        Me.lblCPUTemp.TabIndex = 18
        Me.lblCPUTemp.Text = "100*C"
        '
        'lblRAM
        '
        Me.lblRAM.AutoSize = True
        Me.lblRAM.ForeColor = System.Drawing.Color.White
        Me.lblRAM.Location = New System.Drawing.Point(306, 47)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(47, 13)
        Me.lblRAM.TabIndex = 19
        Me.lblRAM.Text = "2000MB"
        '
        'lblPing
        '
        Me.lblPing.AutoSize = True
        Me.lblPing.ForeColor = System.Drawing.Color.White
        Me.lblPing.Location = New System.Drawing.Point(306, 63)
        Me.lblPing.Name = "lblPing"
        Me.lblPing.Size = New System.Drawing.Size(38, 13)
        Me.lblPing.TabIndex = 20
        Me.lblPing.Text = "100ms"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(358, 87)
        Me.Controls.Add(Me.lblPing)
        Me.Controls.Add(Me.lblRAM)
        Me.Controls.Add(Me.lblCPUTemp)
        Me.Controls.Add(Me.lblCPUUsage)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ProgressBar3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PerformanceCounter2 As System.Diagnostics.PerformanceCounter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCPUUsage As System.Windows.Forms.Label
    Friend WithEvents lblCPUTemp As System.Windows.Forms.Label
    Friend WithEvents lblRAM As System.Windows.Forms.Label
    Friend WithEvents lblPing As System.Windows.Forms.Label

End Class
