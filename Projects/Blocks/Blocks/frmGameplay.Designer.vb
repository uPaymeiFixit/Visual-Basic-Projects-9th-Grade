<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameplay
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
        Me.tmrPlayerMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrIntersectChecks = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBlueBlockMovement = New System.Windows.Forms.Timer(Me.components)
        Me.picPlayerSafezone = New System.Windows.Forms.Label()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picGreenBlock = New System.Windows.Forms.PictureBox()
        Me.picBlueBlock = New System.Windows.Forms.PictureBox()
        Me.btnPlayPause = New System.Windows.Forms.PictureBox()
        Me.lblCurrentScore = New System.Windows.Forms.Label()
        Me.pgbInvincible = New System.Windows.Forms.ProgressBar()
        Me.pgbScore = New System.Windows.Forms.ProgressBar()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.tmrInvincibilityAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUnlockAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.lblUnlock = New System.Windows.Forms.Label()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreenBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlueBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPlayerMovement
        '
        Me.tmrPlayerMovement.Interval = 1
        '
        'tmrIntersectChecks
        '
        '
        'tmrBlueBlockMovement
        '
        Me.tmrBlueBlockMovement.Interval = 1
        '
        'picPlayerSafezone
        '
        Me.picPlayerSafezone.BackColor = System.Drawing.Color.Chartreuse
        Me.picPlayerSafezone.Location = New System.Drawing.Point(11, 71)
        Me.picPlayerSafezone.Name = "picPlayerSafezone"
        Me.picPlayerSafezone.Size = New System.Drawing.Size(10, 10)
        Me.picPlayerSafezone.TabIndex = 1
        Me.picPlayerSafezone.Visible = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.White
        Me.picPlayer.Image = Global.Blocks.My.Resources.Resources.player1
        Me.picPlayer.Location = New System.Drawing.Point(231, 256)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(65, 65)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picGreenBlock
        '
        Me.picGreenBlock.BackColor = System.Drawing.Color.LimeGreen
        Me.picGreenBlock.Location = New System.Drawing.Point(104, 200)
        Me.picGreenBlock.Name = "picGreenBlock"
        Me.picGreenBlock.Size = New System.Drawing.Size(20, 20)
        Me.picGreenBlock.TabIndex = 0
        Me.picGreenBlock.TabStop = False
        '
        'picBlueBlock
        '
        Me.picBlueBlock.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.picBlueBlock.Location = New System.Drawing.Point(508, 368)
        Me.picBlueBlock.Name = "picBlueBlock"
        Me.picBlueBlock.Size = New System.Drawing.Size(20, 20)
        Me.picBlueBlock.TabIndex = 0
        Me.picBlueBlock.TabStop = False
        '
        'btnPlayPause
        '
        Me.btnPlayPause.BackColor = System.Drawing.Color.White
        Me.btnPlayPause.Image = Global.Blocks.My.Resources.Resources.picPauseUp
        Me.btnPlayPause.Location = New System.Drawing.Point(465, 25)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(25, 25)
        Me.btnPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPlayPause.TabIndex = 53
        Me.btnPlayPause.TabStop = False
        '
        'lblCurrentScore
        '
        Me.lblCurrentScore.BackColor = System.Drawing.Color.White
        Me.lblCurrentScore.Font = New System.Drawing.Font("Impact", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentScore.Location = New System.Drawing.Point(287, 27)
        Me.lblCurrentScore.Name = "lblCurrentScore"
        Me.lblCurrentScore.Size = New System.Drawing.Size(60, 24)
        Me.lblCurrentScore.TabIndex = 42
        Me.lblCurrentScore.Text = "0"
        Me.lblCurrentScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgbInvincible
        '
        Me.pgbInvincible.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgbInvincible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgbInvincible.Location = New System.Drawing.Point(14, 9)
        Me.pgbInvincible.Maximum = 36
        Me.pgbInvincible.Name = "pgbInvincible"
        Me.pgbInvincible.Size = New System.Drawing.Size(250, 40)
        Me.pgbInvincible.TabIndex = 51
        Me.pgbInvincible.Value = 36
        Me.pgbInvincible.Visible = False
        '
        'pgbScore
        '
        Me.pgbScore.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgbScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgbScore.Location = New System.Drawing.Point(14, 9)
        Me.pgbScore.Maximum = 5
        Me.pgbScore.Name = "pgbScore"
        Me.pgbScore.Size = New System.Drawing.Size(250, 40)
        Me.pgbScore.TabIndex = 49
        '
        'lblHighScore
        '
        Me.lblHighScore.BackColor = System.Drawing.Color.White
        Me.lblHighScore.Font = New System.Drawing.Font("Impact", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(382, 27)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(56, 25)
        Me.lblHighScore.TabIndex = 45
        Me.lblHighScore.Text = "0"
        Me.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.Location = New System.Drawing.Point(456, -11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(26, 28)
        Me.btnMinimize.TabIndex = 54
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.DarkGray
        Me.btnExit.Location = New System.Drawing.Point(478, -5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 28)
        Me.btnExit.TabIndex = 55
        Me.btnExit.Text = "x"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrInvincibilityAnimation
        '
        Me.tmrInvincibilityAnimation.Interval = 1
        '
        'tmrUnlockAnimation
        '
        '
        'lblUnlock
        '
        Me.lblUnlock.BackColor = System.Drawing.Color.PowderBlue
        Me.lblUnlock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnlock.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnlock.Location = New System.Drawing.Point(135, 400)
        Me.lblUnlock.Name = "lblUnlock"
        Me.lblUnlock.Size = New System.Drawing.Size(230, 25)
        Me.lblUnlock.TabIndex = 56
        Me.lblUnlock.Text = "You have unlocked a new character!"
        Me.lblUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGameplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Blocks.My.Resources.Resources.picBackground
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.lblUnlock)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picPlayerSafezone)
        Me.Controls.Add(Me.picGreenBlock)
        Me.Controls.Add(Me.picBlueBlock)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.lblCurrentScore)
        Me.Controls.Add(Me.pgbInvincible)
        Me.Controls.Add(Me.pgbScore)
        Me.Controls.Add(Me.lblHighScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGameplay"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreenBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlueBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picBlueBlock As System.Windows.Forms.PictureBox
    Friend WithEvents picGreenBlock As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPlayerMovement As System.Windows.Forms.Timer
    Friend WithEvents tmrIntersectChecks As System.Windows.Forms.Timer
    Friend WithEvents tmrBlueBlockMovement As System.Windows.Forms.Timer
    Friend WithEvents picPlayerSafezone As System.Windows.Forms.Label
    Friend WithEvents btnPlayPause As System.Windows.Forms.PictureBox
    Friend WithEvents lblCurrentScore As System.Windows.Forms.Label
    Friend WithEvents pgbInvincible As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbScore As System.Windows.Forms.ProgressBar
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents tmrInvincibilityAnimation As System.Windows.Forms.Timer
    Friend WithEvents tmrUnlockAnimation As System.Windows.Forms.Timer
    Friend WithEvents lblUnlock As System.Windows.Forms.Label

End Class
