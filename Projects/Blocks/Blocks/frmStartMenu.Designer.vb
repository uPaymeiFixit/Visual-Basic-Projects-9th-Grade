<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartMenu
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
        Me.btnPlayHard = New System.Windows.Forms.PictureBox()
        Me.btnPlayEasy = New System.Windows.Forms.PictureBox()
        Me.btnPlayMedium = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        CType(Me.btnPlayHard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlayEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlayMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlayHard
        '
        Me.btnPlayHard.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayHard.Enabled = False
        Me.btnPlayHard.Image = Global.Blocks.My.Resources.Resources.btnHardDisabled
        Me.btnPlayHard.Location = New System.Drawing.Point(180, 328)
        Me.btnPlayHard.Name = "btnPlayHard"
        Me.btnPlayHard.Size = New System.Drawing.Size(140, 35)
        Me.btnPlayHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPlayHard.TabIndex = 40
        Me.btnPlayHard.TabStop = False
        '
        'btnPlayEasy
        '
        Me.btnPlayEasy.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayEasy.Image = Global.Blocks.My.Resources.Resources.btnEasy
        Me.btnPlayEasy.Location = New System.Drawing.Point(180, 248)
        Me.btnPlayEasy.Name = "btnPlayEasy"
        Me.btnPlayEasy.Size = New System.Drawing.Size(140, 35)
        Me.btnPlayEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPlayEasy.TabIndex = 42
        Me.btnPlayEasy.TabStop = False
        '
        'btnPlayMedium
        '
        Me.btnPlayMedium.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayMedium.Enabled = False
        Me.btnPlayMedium.Image = Global.Blocks.My.Resources.Resources.btnMediumDisabled
        Me.btnPlayMedium.Location = New System.Drawing.Point(180, 288)
        Me.btnPlayMedium.Name = "btnPlayMedium"
        Me.btnPlayMedium.Size = New System.Drawing.Size(140, 35)
        Me.btnPlayMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPlayMedium.TabIndex = 43
        Me.btnPlayMedium.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.Image = Global.Blocks.My.Resources.Resources.btnInstructions
        Me.btnInfo.Location = New System.Drawing.Point(180, 200)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(140, 35)
        Me.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnInfo.TabIndex = 41
        Me.btnInfo.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.Location = New System.Drawing.Point(449, -11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(26, 28)
        Me.btnMinimize.TabIndex = 38
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.DarkGray
        Me.btnExit.Location = New System.Drawing.Point(475, -4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 28)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "x"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmStartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blocks.My.Resources.Resources.frmStartBackground
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.btnPlayHard)
        Me.Controls.Add(Me.btnPlayEasy)
        Me.Controls.Add(Me.btnPlayMedium)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStartMenu"
        Me.Text = "frmSplash"
        CType(Me.btnPlayHard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlayEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlayMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlayHard As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlayEasy As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlayMedium As System.Windows.Forms.PictureBox
    Friend WithEvents btnInfo As System.Windows.Forms.PictureBox
    Friend WithEvents btnMinimize As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
End Class
