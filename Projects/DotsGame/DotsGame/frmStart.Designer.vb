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
        Me.btnExit = New System.Windows.Forms.Label()
        Me.lblEnableDebug = New System.Windows.Forms.Label()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.btnMedium = New System.Windows.Forms.PictureBox()
        Me.btnHard = New System.Windows.Forms.PictureBox()
        Me.btnEasy = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Label()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.DarkGray
        Me.btnExit.Location = New System.Drawing.Point(475, -4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 28)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "x"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEnableDebug
        '
        Me.lblEnableDebug.AutoSize = True
        Me.lblEnableDebug.BackColor = System.Drawing.Color.Transparent
        Me.lblEnableDebug.Location = New System.Drawing.Point(439, 385)
        Me.lblEnableDebug.Name = "lblEnableDebug"
        Me.lblEnableDebug.Size = New System.Drawing.Size(59, 13)
        Me.lblEnableDebug.TabIndex = 6
        Me.lblEnableDebug.Text = "Debug: Off"
        '
        'lblDebug
        '
        Me.lblDebug.BackColor = System.Drawing.Color.Black
        Me.lblDebug.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebug.ForeColor = System.Drawing.Color.Lime
        Me.lblDebug.Location = New System.Drawing.Point(511, 7)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(228, 571)
        Me.lblDebug.TabIndex = 35
        Me.lblDebug.Text = "DEBUGGING STATS vX.X.X"
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.Image = Global.DotsGame.My.Resources.Resources.btnInstructions
        Me.btnInfo.Location = New System.Drawing.Point(180, 200)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(140, 35)
        Me.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnInfo.TabIndex = 37
        Me.btnInfo.TabStop = False
        '
        'btnMedium
        '
        Me.btnMedium.BackColor = System.Drawing.Color.Transparent
        Me.btnMedium.Enabled = False
        Me.btnMedium.Image = Global.DotsGame.My.Resources.Resources.btnMediumDisabled
        Me.btnMedium.Location = New System.Drawing.Point(180, 288)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(140, 35)
        Me.btnMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMedium.TabIndex = 37
        Me.btnMedium.TabStop = False
        '
        'btnHard
        '
        Me.btnHard.BackColor = System.Drawing.Color.Transparent
        Me.btnHard.Enabled = False
        Me.btnHard.Image = Global.DotsGame.My.Resources.Resources.btnHardDisabled
        Me.btnHard.Location = New System.Drawing.Point(180, 328)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(140, 35)
        Me.btnHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnHard.TabIndex = 37
        Me.btnHard.TabStop = False
        '
        'btnEasy
        '
        Me.btnEasy.BackColor = System.Drawing.Color.Transparent
        Me.btnEasy.Image = Global.DotsGame.My.Resources.Resources.btnEasy
        Me.btnEasy.Location = New System.Drawing.Point(180, 248)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(140, 35)
        Me.btnEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEasy.TabIndex = 37
        Me.btnEasy.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.Location = New System.Drawing.Point(449, -11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(26, 28)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DotsGame.My.Resources.Resources.frmStartBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(916, 582)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.btnEasy)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.lblEnableDebug)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStart"
        Me.Text = "Start Screen"
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEasy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents lblEnableDebug As System.Windows.Forms.Label
    Friend WithEvents lblDebug As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnMedium As System.Windows.Forms.PictureBox
    Friend WithEvents btnHard As System.Windows.Forms.PictureBox
    Friend WithEvents btnEasy As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.Label
End Class
