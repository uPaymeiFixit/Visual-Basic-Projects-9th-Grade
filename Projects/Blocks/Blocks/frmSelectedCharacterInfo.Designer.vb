<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectedCharacterInfo
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
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picPlay = New System.Windows.Forms.PictureBox()
        Me.lblDifficultyNeeded = New System.Windows.Forms.Label()
        Me.lblPointsNeeded = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.picInvincibility = New System.Windows.Forms.PictureBox()
        Me.picSize = New System.Windows.Forms.PictureBox()
        Me.picSpeed = New System.Windows.Forms.PictureBox()
        Me.picLockedBackground = New System.Windows.Forms.PictureBox()
        Me.picSpeed1 = New System.Windows.Forms.Label()
        Me.picSpeed2 = New System.Windows.Forms.Label()
        Me.picSpeed3 = New System.Windows.Forms.Label()
        Me.picSpeed4 = New System.Windows.Forms.Label()
        Me.picSpeed5 = New System.Windows.Forms.Label()
        Me.picSize1 = New System.Windows.Forms.Label()
        Me.picSize2 = New System.Windows.Forms.Label()
        Me.picSize3 = New System.Windows.Forms.Label()
        Me.picSize4 = New System.Windows.Forms.Label()
        Me.picSize5 = New System.Windows.Forms.Label()
        Me.picInvincibility1 = New System.Windows.Forms.Label()
        Me.picInvincibility2 = New System.Windows.Forms.Label()
        Me.picInvincibility3 = New System.Windows.Forms.Label()
        Me.picInvincibility4 = New System.Windows.Forms.Label()
        Me.picInvincibility5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInvincibility, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLockedBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.Blocks.My.Resources.Resources.player1
        Me.picPlayer.Location = New System.Drawing.Point(25, 17)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(111, 100)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 8
        Me.picPlayer.TabStop = False
        '
        'picPlay
        '
        Me.picPlay.BackColor = System.Drawing.Color.Transparent
        Me.picPlay.Image = Global.Blocks.My.Resources.Resources.btnPlay
        Me.picPlay.Location = New System.Drawing.Point(146, 16)
        Me.picPlay.Name = "picPlay"
        Me.picPlay.Size = New System.Drawing.Size(115, 105)
        Me.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlay.TabIndex = 7
        Me.picPlay.TabStop = False
        '
        'lblDifficultyNeeded
        '
        Me.lblDifficultyNeeded.AutoSize = True
        Me.lblDifficultyNeeded.BackColor = System.Drawing.Color.White
        Me.lblDifficultyNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyNeeded.Location = New System.Drawing.Point(176, 83)
        Me.lblDifficultyNeeded.Name = "lblDifficultyNeeded"
        Me.lblDifficultyNeeded.Size = New System.Drawing.Size(55, 24)
        Me.lblDifficultyNeeded.TabIndex = 10
        Me.lblDifficultyNeeded.Text = "Easy"
        '
        'lblPointsNeeded
        '
        Me.lblPointsNeeded.AutoSize = True
        Me.lblPointsNeeded.BackColor = System.Drawing.Color.White
        Me.lblPointsNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsNeeded.Location = New System.Drawing.Point(212, 29)
        Me.lblPointsNeeded.Name = "lblPointsNeeded"
        Me.lblPointsNeeded.Size = New System.Drawing.Size(21, 24)
        Me.lblPointsNeeded.TabIndex = 9
        Me.lblPointsNeeded.Text = "0"
        '
        'btnBack
        '
        Me.btnBack.Image = Global.Blocks.My.Resources.Resources.btnBack
        Me.btnBack.Location = New System.Drawing.Point(19, 234)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(247, 34)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        '
        'picInvincibility
        '
        Me.picInvincibility.Location = New System.Drawing.Point(142, 197)
        Me.picInvincibility.Name = "picInvincibility"
        Me.picInvincibility.Size = New System.Drawing.Size(114, 28)
        Me.picInvincibility.TabIndex = 3
        Me.picInvincibility.TabStop = False
        Me.picInvincibility.Visible = False
        '
        'picSize
        '
        Me.picSize.Location = New System.Drawing.Point(144, 163)
        Me.picSize.Name = "picSize"
        Me.picSize.Size = New System.Drawing.Size(20, 20)
        Me.picSize.TabIndex = 2
        Me.picSize.TabStop = False
        Me.picSize.Visible = False
        '
        'picSpeed
        '
        Me.picSpeed.Location = New System.Drawing.Point(142, 129)
        Me.picSpeed.Name = "picSpeed"
        Me.picSpeed.Size = New System.Drawing.Size(114, 28)
        Me.picSpeed.TabIndex = 5
        Me.picSpeed.TabStop = False
        Me.picSpeed.Visible = False
        '
        'picLockedBackground
        '
        Me.picLockedBackground.Image = Global.Blocks.My.Resources.Resources.frmLockedPlayerInfoBackground
        Me.picLockedBackground.Location = New System.Drawing.Point(0, 1)
        Me.picLockedBackground.Name = "picLockedBackground"
        Me.picLockedBackground.Size = New System.Drawing.Size(280, 220)
        Me.picLockedBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLockedBackground.TabIndex = 4
        Me.picLockedBackground.TabStop = False
        Me.picLockedBackground.Visible = False
        '
        'picSpeed1
        '
        Me.picSpeed1.BackColor = System.Drawing.Color.Red
        Me.picSpeed1.Location = New System.Drawing.Point(147, 135)
        Me.picSpeed1.Name = "picSpeed1"
        Me.picSpeed1.Size = New System.Drawing.Size(16, 16)
        Me.picSpeed1.TabIndex = 11
        '
        'picSpeed2
        '
        Me.picSpeed2.BackColor = System.Drawing.Color.Red
        Me.picSpeed2.Location = New System.Drawing.Point(169, 135)
        Me.picSpeed2.Name = "picSpeed2"
        Me.picSpeed2.Size = New System.Drawing.Size(16, 16)
        Me.picSpeed2.TabIndex = 11
        '
        'picSpeed3
        '
        Me.picSpeed3.BackColor = System.Drawing.Color.Red
        Me.picSpeed3.Location = New System.Drawing.Point(191, 135)
        Me.picSpeed3.Name = "picSpeed3"
        Me.picSpeed3.Size = New System.Drawing.Size(16, 16)
        Me.picSpeed3.TabIndex = 11
        '
        'picSpeed4
        '
        Me.picSpeed4.BackColor = System.Drawing.Color.Red
        Me.picSpeed4.Location = New System.Drawing.Point(213, 135)
        Me.picSpeed4.Name = "picSpeed4"
        Me.picSpeed4.Size = New System.Drawing.Size(16, 16)
        Me.picSpeed4.TabIndex = 11
        '
        'picSpeed5
        '
        Me.picSpeed5.BackColor = System.Drawing.Color.Red
        Me.picSpeed5.Location = New System.Drawing.Point(235, 135)
        Me.picSpeed5.Name = "picSpeed5"
        Me.picSpeed5.Size = New System.Drawing.Size(16, 16)
        Me.picSpeed5.TabIndex = 11
        '
        'picSize1
        '
        Me.picSize1.BackColor = System.Drawing.Color.Red
        Me.picSize1.Location = New System.Drawing.Point(147, 169)
        Me.picSize1.Name = "picSize1"
        Me.picSize1.Size = New System.Drawing.Size(16, 16)
        Me.picSize1.TabIndex = 11
        '
        'picSize2
        '
        Me.picSize2.BackColor = System.Drawing.Color.Red
        Me.picSize2.Location = New System.Drawing.Point(169, 169)
        Me.picSize2.Name = "picSize2"
        Me.picSize2.Size = New System.Drawing.Size(16, 16)
        Me.picSize2.TabIndex = 11
        '
        'picSize3
        '
        Me.picSize3.BackColor = System.Drawing.Color.Red
        Me.picSize3.Location = New System.Drawing.Point(191, 169)
        Me.picSize3.Name = "picSize3"
        Me.picSize3.Size = New System.Drawing.Size(16, 16)
        Me.picSize3.TabIndex = 11
        '
        'picSize4
        '
        Me.picSize4.BackColor = System.Drawing.Color.Red
        Me.picSize4.Location = New System.Drawing.Point(213, 169)
        Me.picSize4.Name = "picSize4"
        Me.picSize4.Size = New System.Drawing.Size(16, 16)
        Me.picSize4.TabIndex = 11
        '
        'picSize5
        '
        Me.picSize5.BackColor = System.Drawing.Color.Red
        Me.picSize5.Location = New System.Drawing.Point(235, 169)
        Me.picSize5.Name = "picSize5"
        Me.picSize5.Size = New System.Drawing.Size(16, 16)
        Me.picSize5.TabIndex = 11
        '
        'picInvincibility1
        '
        Me.picInvincibility1.BackColor = System.Drawing.Color.Red
        Me.picInvincibility1.Location = New System.Drawing.Point(143, 200)
        Me.picInvincibility1.Name = "picInvincibility1"
        Me.picInvincibility1.Size = New System.Drawing.Size(23, 23)
        Me.picInvincibility1.TabIndex = 11
        '
        'picInvincibility2
        '
        Me.picInvincibility2.BackColor = System.Drawing.Color.DarkOrange
        Me.picInvincibility2.Location = New System.Drawing.Point(166, 200)
        Me.picInvincibility2.Name = "picInvincibility2"
        Me.picInvincibility2.Size = New System.Drawing.Size(23, 23)
        Me.picInvincibility2.TabIndex = 11
        '
        'picInvincibility3
        '
        Me.picInvincibility3.BackColor = System.Drawing.Color.Yellow
        Me.picInvincibility3.Location = New System.Drawing.Point(188, 200)
        Me.picInvincibility3.Name = "picInvincibility3"
        Me.picInvincibility3.Size = New System.Drawing.Size(23, 23)
        Me.picInvincibility3.TabIndex = 11
        '
        'picInvincibility4
        '
        Me.picInvincibility4.BackColor = System.Drawing.Color.Chartreuse
        Me.picInvincibility4.Location = New System.Drawing.Point(210, 200)
        Me.picInvincibility4.Name = "picInvincibility4"
        Me.picInvincibility4.Size = New System.Drawing.Size(23, 23)
        Me.picInvincibility4.TabIndex = 11
        '
        'picInvincibility5
        '
        Me.picInvincibility5.BackColor = System.Drawing.Color.Cyan
        Me.picInvincibility5.Location = New System.Drawing.Point(232, 200)
        Me.picInvincibility5.Name = "picInvincibility5"
        Me.picInvincibility5.Size = New System.Drawing.Size(23, 23)
        Me.picInvincibility5.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(143, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 23)
        Me.Label1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(143, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 23)
        Me.Label2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(166, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 23)
        Me.Label3.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(166, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 23)
        Me.Label4.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(188, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 23)
        Me.Label5.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(188, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 23)
        Me.Label6.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(210, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 23)
        Me.Label7.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Chartreuse
        Me.Label8.Location = New System.Drawing.Point(210, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 23)
        Me.Label8.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Cyan
        Me.Label9.Location = New System.Drawing.Point(232, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 23)
        Me.Label9.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Cyan
        Me.Label10.Location = New System.Drawing.Point(232, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 23)
        Me.Label10.TabIndex = 11
        '
        'frmSelectedCharacterInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Blocks.My.Resources.Resources.frmPlayerInfoBackground
        Me.ClientSize = New System.Drawing.Size(279, 280)
        Me.Controls.Add(Me.picInvincibility5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.picSize5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.picSpeed5)
        Me.Controls.Add(Me.picInvincibility4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.picSize4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picSpeed4)
        Me.Controls.Add(Me.picInvincibility3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.picSize3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picSpeed3)
        Me.Controls.Add(Me.picInvincibility2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.picSize2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picSpeed2)
        Me.Controls.Add(Me.picInvincibility1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picSize1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picSpeed1)
        Me.Controls.Add(Me.picPlay)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.lblDifficultyNeeded)
        Me.Controls.Add(Me.lblPointsNeeded)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picInvincibility)
        Me.Controls.Add(Me.picSize)
        Me.Controls.Add(Me.picSpeed)
        Me.Controls.Add(Me.picLockedBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSelectedCharacterInfo"
        Me.Text = "frmSelectedCharacterInfo"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInvincibility, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLockedBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picPlay As System.Windows.Forms.PictureBox
    Friend WithEvents lblDifficultyNeeded As System.Windows.Forms.Label
    Friend WithEvents lblPointsNeeded As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents picInvincibility As System.Windows.Forms.PictureBox
    Friend WithEvents picSize As System.Windows.Forms.PictureBox
    Friend WithEvents picSpeed As System.Windows.Forms.PictureBox
    Friend WithEvents picLockedBackground As System.Windows.Forms.PictureBox
    Friend WithEvents picSpeed1 As System.Windows.Forms.Label
    Friend WithEvents picSpeed2 As System.Windows.Forms.Label
    Friend WithEvents picSpeed3 As System.Windows.Forms.Label
    Friend WithEvents picSpeed4 As System.Windows.Forms.Label
    Friend WithEvents picSpeed5 As System.Windows.Forms.Label
    Friend WithEvents picSize1 As System.Windows.Forms.Label
    Friend WithEvents picSize2 As System.Windows.Forms.Label
    Friend WithEvents picSize3 As System.Windows.Forms.Label
    Friend WithEvents picSize4 As System.Windows.Forms.Label
    Friend WithEvents picSize5 As System.Windows.Forms.Label
    Friend WithEvents picInvincibility1 As System.Windows.Forms.Label
    Friend WithEvents picInvincibility2 As System.Windows.Forms.Label
    Friend WithEvents picInvincibility3 As System.Windows.Forms.Label
    Friend WithEvents picInvincibility4 As System.Windows.Forms.Label
    Friend WithEvents picInvincibility5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
