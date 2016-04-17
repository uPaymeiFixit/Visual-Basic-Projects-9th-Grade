<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayersInfo
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
        Me.picSpeed = New System.Windows.Forms.PictureBox()
        Me.lblPointsNeeded = New System.Windows.Forms.Label()
        Me.lblDifficultyNeeded = New System.Windows.Forms.Label()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picSize = New System.Windows.Forms.PictureBox()
        Me.picInvincibility = New System.Windows.Forms.PictureBox()
        Me.picLockedBackground = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvincibility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLockedBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSpeed
        '
        Me.picSpeed.Location = New System.Drawing.Point(142, 128)
        Me.picSpeed.Name = "picSpeed"
        Me.picSpeed.Size = New System.Drawing.Size(114, 28)
        Me.picSpeed.TabIndex = 0
        Me.picSpeed.TabStop = False
        '
        'lblPointsNeeded
        '
        Me.lblPointsNeeded.AutoSize = True
        Me.lblPointsNeeded.BackColor = System.Drawing.Color.White
        Me.lblPointsNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsNeeded.Location = New System.Drawing.Point(212, 28)
        Me.lblPointsNeeded.Name = "lblPointsNeeded"
        Me.lblPointsNeeded.Size = New System.Drawing.Size(21, 24)
        Me.lblPointsNeeded.TabIndex = 1
        Me.lblPointsNeeded.Text = "0"
        '
        'lblDifficultyNeeded
        '
        Me.lblDifficultyNeeded.AutoSize = True
        Me.lblDifficultyNeeded.BackColor = System.Drawing.Color.White
        Me.lblDifficultyNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyNeeded.Location = New System.Drawing.Point(176, 82)
        Me.lblDifficultyNeeded.Name = "lblDifficultyNeeded"
        Me.lblDifficultyNeeded.Size = New System.Drawing.Size(55, 24)
        Me.lblDifficultyNeeded.TabIndex = 1
        Me.lblDifficultyNeeded.Text = "Easy"
        '
        'picPlay
        '
        Me.picPlay.BackColor = System.Drawing.Color.Transparent
        Me.picPlay.Image = Global.DotsGame.My.Resources.Resources.btnPlay
        Me.picPlay.Location = New System.Drawing.Point(146, 15)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(115, 105)
        Me.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlay.TabIndex = 0
        Me.picPlay.TabStop = False
        Me.picPlay.Visible = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.DotsGame.My.Resources.Resources.player1
        Me.picPlayer.Location = New System.Drawing.Point(25, 16)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(111, 100)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picSize
        '
        Me.picSize.Location = New System.Drawing.Point(144, 162)
        Me.picSize.Name = "picSize"
        Me.picSize.Size = New System.Drawing.Size(114, 28)
        Me.picSize.TabIndex = 0
        Me.picSize.TabStop = False
        '
        'picInvincibility
        '
        Me.picInvincibility.Location = New System.Drawing.Point(142, 196)
        Me.picInvincibility.Name = "picInvincibility"
        Me.picInvincibility.Size = New System.Drawing.Size(114, 28)
        Me.picInvincibility.TabIndex = 0
        Me.picInvincibility.TabStop = False
        '
        'picLockedBackground
        '
        Me.picLockedBackground.Image = Global.DotsGame.My.Resources.Resources.frmLockedPlayerInfoBackground1
        Me.picLockedBackground.Location = New System.Drawing.Point(0, 0)
        Me.picLockedBackground.Name = "picLockedBackground"
        Me.picLockedBackground.Size = New System.Drawing.Size(280, 220)
        Me.picLockedBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLockedBackground.TabIndex = 0
        Me.picLockedBackground.TabStop = False
        Me.picLockedBackground.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Image = Global.DotsGame.My.Resources.Resources.btnBack
        Me.btnBack.Location = New System.Drawing.Point(19, 233)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(247, 34)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 0
        Me.btnBack.TabStop = False
        '
        'frmPlayersInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DotsGame.My.Resources.Resources.frmPlayerInfoBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(279, 280)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.lblDifficultyNeeded)
        Me.Controls.Add(Me.lblPointsNeeded)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picInvincibility)
        Me.Controls.Add(Me.picSize)
        Me.Controls.Add(Me.picSpeed)
        Me.Controls.Add(Me.picLockedBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlayersInfo"
        Me.Text = "frmPlayersInfo"
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvincibility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLockedBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picSpeed As System.Windows.Forms.PictureBox
    Friend WithEvents lblPointsNeeded As System.Windows.Forms.Label
    Friend WithEvents lblDifficultyNeeded As System.Windows.Forms.Label
    Friend WithEvents picPlay As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picSize As System.Windows.Forms.PictureBox
    Friend WithEvents picInvincibility As System.Windows.Forms.PictureBox
    Friend WithEvents picLockedBackground As System.Windows.Forms.PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
End Class
