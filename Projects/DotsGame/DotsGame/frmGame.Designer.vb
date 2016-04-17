<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.tmrPGBAnimations = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.lblHighscore = New System.Windows.Forms.Label()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.pgbScore = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tmrDangerMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDebug = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCollisionCheck = New System.Windows.Forms.Timer(Me.components)
        Me.pgbInvincible = New System.Windows.Forms.ProgressBar()
        Me.tmrSloMo = New System.Windows.Forms.Timer(Me.components)
        Me.pgbSloMo = New System.Windows.Forms.ProgressBar()
        Me.picPlayerEXBounds = New System.Windows.Forms.Label()
        Me.lbl25Score = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmrRNDInterval = New System.Windows.Forms.Timer(Me.components)
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnPause = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picYDanger12 = New System.Windows.Forms.PictureBox()
        Me.picYDanger10 = New System.Windows.Forms.PictureBox()
        Me.picYDanger5 = New System.Windows.Forms.PictureBox()
        Me.picYDanger8 = New System.Windows.Forms.PictureBox()
        Me.picXDanger13 = New System.Windows.Forms.PictureBox()
        Me.picXDanger12 = New System.Windows.Forms.PictureBox()
        Me.picXDanger10 = New System.Windows.Forms.PictureBox()
        Me.picXDanger9 = New System.Windows.Forms.PictureBox()
        Me.picXDanger5 = New System.Windows.Forms.PictureBox()
        Me.picYDanger3 = New System.Windows.Forms.PictureBox()
        Me.picXDanger7 = New System.Windows.Forms.PictureBox()
        Me.picYDanger11 = New System.Windows.Forms.PictureBox()
        Me.picYDanger9 = New System.Windows.Forms.PictureBox()
        Me.picXDanger3 = New System.Windows.Forms.PictureBox()
        Me.picXDanger11 = New System.Windows.Forms.PictureBox()
        Me.picYDanger4 = New System.Windows.Forms.PictureBox()
        Me.picXDanger8 = New System.Windows.Forms.PictureBox()
        Me.picYDanger7 = New System.Windows.Forms.PictureBox()
        Me.picXDanger4 = New System.Windows.Forms.PictureBox()
        Me.picYDanger6 = New System.Windows.Forms.PictureBox()
        Me.picYDanger2 = New System.Windows.Forms.PictureBox()
        Me.picXDanger6 = New System.Windows.Forms.PictureBox()
        Me.picYDanger1 = New System.Windows.Forms.PictureBox()
        Me.picXDanger2 = New System.Windows.Forms.PictureBox()
        Me.picXDanger1 = New System.Windows.Forms.PictureBox()
        Me.picGet = New System.Windows.Forms.PictureBox()
        Me.lblEnableDebug = New System.Windows.Forms.Label()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYDanger1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picXDanger1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPGBAnimations
        '
        Me.tmrPGBAnimations.Enabled = True
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 1
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 1
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 1
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 1
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.DimGray
        Me.lblScore.Font = New System.Drawing.Font("Impact", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(253, 22)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(60, 30)
        Me.lblScore.TabIndex = 30
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.DimGray
        Me.btnMinimize.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.Location = New System.Drawing.Point(432, -7)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 34)
        Me.btnMinimize.TabIndex = 33
        Me.btnMinimize.Text = "-"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkGray
        Me.btnExit.Location = New System.Drawing.Point(466, -3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(37, 30)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "X"
        '
        'lblHighscore
        '
        Me.lblHighscore.BackColor = System.Drawing.Color.DimGray
        Me.lblHighscore.Font = New System.Drawing.Font("Impact", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighscore.Location = New System.Drawing.Point(348, 22)
        Me.lblHighscore.Name = "lblHighscore"
        Me.lblHighscore.Size = New System.Drawing.Size(81, 30)
        Me.lblHighscore.TabIndex = 31
        Me.lblHighscore.Text = "0"
        Me.lblHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDebug
        '
        Me.lblDebug.BackColor = System.Drawing.Color.Black
        Me.lblDebug.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebug.ForeColor = System.Drawing.Color.Lime
        Me.lblDebug.Location = New System.Drawing.Point(544, 9)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(228, 571)
        Me.lblDebug.TabIndex = 34
        Me.lblDebug.Text = "DEBUGGING STATS vX.X.X"
        '
        'pgbScore
        '
        Me.pgbScore.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgbScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgbScore.Location = New System.Drawing.Point(3, 3)
        Me.pgbScore.Name = "pgbScore"
        Me.pgbScore.Size = New System.Drawing.Size(250, 25)
        Me.pgbScore.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = " SCORE "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(351, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = " HIGH SCORE "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(500, 340)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = " "
        '
        'tmrDangerMove
        '
        Me.tmrDangerMove.Enabled = True
        Me.tmrDangerMove.Interval = 1
        '
        'tmrDebug
        '
        '
        'tmrCollisionCheck
        '
        Me.tmrCollisionCheck.Enabled = True
        Me.tmrCollisionCheck.Interval = 50
        '
        'pgbInvincible
        '
        Me.pgbInvincible.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgbInvincible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgbInvincible.Location = New System.Drawing.Point(3, 3)
        Me.pgbInvincible.Name = "pgbInvincible"
        Me.pgbInvincible.Size = New System.Drawing.Size(250, 25)
        Me.pgbInvincible.TabIndex = 35
        Me.pgbInvincible.Value = 100
        Me.pgbInvincible.Visible = False
        '
        'tmrSloMo
        '
        Me.tmrSloMo.Enabled = True
        Me.tmrSloMo.Interval = 1
        '
        'pgbSloMo
        '
        Me.pgbSloMo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pgbSloMo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgbSloMo.Location = New System.Drawing.Point(3, 32)
        Me.pgbSloMo.Name = "pgbSloMo"
        Me.pgbSloMo.Size = New System.Drawing.Size(250, 25)
        Me.pgbSloMo.TabIndex = 35
        Me.pgbSloMo.Value = 100
        '
        'picPlayerEXBounds
        '
        Me.picPlayerEXBounds.BackColor = System.Drawing.Color.Lime
        Me.picPlayerEXBounds.Location = New System.Drawing.Point(200, 170)
        Me.picPlayerEXBounds.Name = "picPlayerEXBounds"
        Me.picPlayerEXBounds.Size = New System.Drawing.Size(100, 100)
        Me.picPlayerEXBounds.TabIndex = 39
        Me.picPlayerEXBounds.Text = "EXTENDED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+25px      BOUNDS"
        Me.picPlayerEXBounds.Visible = False
        '
        'lbl25Score
        '
        Me.lbl25Score.BackColor = System.Drawing.Color.DimGray
        Me.lbl25Score.Font = New System.Drawing.Font("Impact", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl25Score.Location = New System.Drawing.Point(309, 6)
        Me.lbl25Score.Name = "lbl25Score"
        Me.lbl25Score.Size = New System.Drawing.Size(40, 21)
        Me.lbl25Score.TabIndex = 30
        Me.lbl25Score.Text = "0"
        Me.lbl25Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Font = New System.Drawing.Font("Impact", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 24)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "25"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrRNDInterval
        '
        Me.tmrRNDInterval.Interval = 500
        '
        'btnPlay
        '
        Me.btnPlay.Image = Global.DotsGame.My.Resources.Resources.picPlayDown
        Me.btnPlay.Location = New System.Drawing.Point(473, 32)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(20, 20)
        Me.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPlay.TabIndex = 38
        Me.btnPlay.TabStop = False
        '
        'btnPause
        '
        Me.btnPause.Image = Global.DotsGame.My.Resources.Resources.picPauseUp
        Me.btnPause.Location = New System.Drawing.Point(438, 32)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(20, 20)
        Me.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPause.TabIndex = 38
        Me.btnPause.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.DotsGame.My.Resources.Resources.picPlayerSQ
        Me.picPlayer.Location = New System.Drawing.Point(225, 195)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(50, 50)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 4
        Me.picPlayer.TabStop = False
        '
        'picYDanger12
        '
        Me.picYDanger12.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger12.Location = New System.Drawing.Point(506, 401)
        Me.picYDanger12.Name = "picYDanger12"
        Me.picYDanger12.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger12.TabIndex = 21
        Me.picYDanger12.TabStop = False
        '
        'picYDanger10
        '
        Me.picYDanger10.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger10.Location = New System.Drawing.Point(506, 339)
        Me.picYDanger10.Name = "picYDanger10"
        Me.picYDanger10.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger10.TabIndex = 22
        Me.picYDanger10.TabStop = False
        '
        'picYDanger5
        '
        Me.picYDanger5.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger5.Location = New System.Drawing.Point(506, 184)
        Me.picYDanger5.Name = "picYDanger5"
        Me.picYDanger5.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger5.TabIndex = 23
        Me.picYDanger5.TabStop = False
        '
        'picYDanger8
        '
        Me.picYDanger8.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger8.Location = New System.Drawing.Point(506, 277)
        Me.picYDanger8.Name = "picYDanger8"
        Me.picYDanger8.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger8.TabIndex = 18
        Me.picYDanger8.TabStop = False
        '
        'picXDanger13
        '
        Me.picXDanger13.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger13.Location = New System.Drawing.Point(345, 403)
        Me.picXDanger13.Name = "picXDanger13"
        Me.picXDanger13.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger13.TabIndex = 19
        Me.picXDanger13.TabStop = False
        '
        'picXDanger12
        '
        Me.picXDanger12.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger12.Location = New System.Drawing.Point(314, 403)
        Me.picXDanger12.Name = "picXDanger12"
        Me.picXDanger12.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger12.TabIndex = 20
        Me.picXDanger12.TabStop = False
        '
        'picXDanger10
        '
        Me.picXDanger10.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger10.Location = New System.Drawing.Point(252, 403)
        Me.picXDanger10.Name = "picXDanger10"
        Me.picXDanger10.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger10.TabIndex = 27
        Me.picXDanger10.TabStop = False
        '
        'picXDanger9
        '
        Me.picXDanger9.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger9.Location = New System.Drawing.Point(221, 403)
        Me.picXDanger9.Name = "picXDanger9"
        Me.picXDanger9.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger9.TabIndex = 28
        Me.picXDanger9.TabStop = False
        '
        'picXDanger5
        '
        Me.picXDanger5.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger5.Location = New System.Drawing.Point(95, 403)
        Me.picXDanger5.Name = "picXDanger5"
        Me.picXDanger5.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger5.TabIndex = 29
        Me.picXDanger5.TabStop = False
        '
        'picYDanger3
        '
        Me.picYDanger3.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger3.Location = New System.Drawing.Point(506, 122)
        Me.picYDanger3.Name = "picYDanger3"
        Me.picYDanger3.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger3.TabIndex = 24
        Me.picYDanger3.TabStop = False
        '
        'picXDanger7
        '
        Me.picXDanger7.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger7.Location = New System.Drawing.Point(159, 403)
        Me.picXDanger7.Name = "picXDanger7"
        Me.picXDanger7.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger7.TabIndex = 25
        Me.picXDanger7.TabStop = False
        '
        'picYDanger11
        '
        Me.picYDanger11.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger11.Location = New System.Drawing.Point(506, 370)
        Me.picYDanger11.Name = "picYDanger11"
        Me.picYDanger11.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger11.TabIndex = 26
        Me.picYDanger11.TabStop = False
        '
        'picYDanger9
        '
        Me.picYDanger9.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger9.Location = New System.Drawing.Point(506, 308)
        Me.picYDanger9.Name = "picYDanger9"
        Me.picYDanger9.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger9.TabIndex = 8
        Me.picYDanger9.TabStop = False
        '
        'picXDanger3
        '
        Me.picXDanger3.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger3.Location = New System.Drawing.Point(33, 403)
        Me.picXDanger3.Name = "picXDanger3"
        Me.picXDanger3.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger3.TabIndex = 9
        Me.picXDanger3.TabStop = False
        '
        'picXDanger11
        '
        Me.picXDanger11.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger11.Location = New System.Drawing.Point(283, 403)
        Me.picXDanger11.Name = "picXDanger11"
        Me.picXDanger11.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger11.TabIndex = 10
        Me.picXDanger11.TabStop = False
        '
        'picYDanger4
        '
        Me.picYDanger4.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger4.Location = New System.Drawing.Point(506, 153)
        Me.picYDanger4.Name = "picYDanger4"
        Me.picYDanger4.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger4.TabIndex = 5
        Me.picYDanger4.TabStop = False
        '
        'picXDanger8
        '
        Me.picXDanger8.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger8.Location = New System.Drawing.Point(190, 403)
        Me.picXDanger8.Name = "picXDanger8"
        Me.picXDanger8.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger8.TabIndex = 6
        Me.picXDanger8.TabStop = False
        '
        'picYDanger7
        '
        Me.picYDanger7.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger7.Location = New System.Drawing.Point(506, 246)
        Me.picYDanger7.Name = "picYDanger7"
        Me.picYDanger7.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger7.TabIndex = 7
        Me.picYDanger7.TabStop = False
        '
        'picXDanger4
        '
        Me.picXDanger4.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger4.Location = New System.Drawing.Point(64, 403)
        Me.picXDanger4.Name = "picXDanger4"
        Me.picXDanger4.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger4.TabIndex = 11
        Me.picXDanger4.TabStop = False
        '
        'picYDanger6
        '
        Me.picYDanger6.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger6.Location = New System.Drawing.Point(506, 215)
        Me.picYDanger6.Name = "picYDanger6"
        Me.picYDanger6.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger6.TabIndex = 15
        Me.picYDanger6.TabStop = False
        '
        'picYDanger2
        '
        Me.picYDanger2.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger2.Location = New System.Drawing.Point(506, 91)
        Me.picYDanger2.Name = "picYDanger2"
        Me.picYDanger2.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger2.TabIndex = 16
        Me.picYDanger2.TabStop = False
        '
        'picXDanger6
        '
        Me.picXDanger6.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger6.Location = New System.Drawing.Point(128, 403)
        Me.picXDanger6.Name = "picXDanger6"
        Me.picXDanger6.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger6.TabIndex = 17
        Me.picXDanger6.TabStop = False
        '
        'picYDanger1
        '
        Me.picYDanger1.BackColor = System.Drawing.Color.LimeGreen
        Me.picYDanger1.Location = New System.Drawing.Point(506, 60)
        Me.picYDanger1.Name = "picYDanger1"
        Me.picYDanger1.Size = New System.Drawing.Size(20, 20)
        Me.picYDanger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picYDanger1.TabIndex = 12
        Me.picYDanger1.TabStop = False
        '
        'picXDanger2
        '
        Me.picXDanger2.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger2.Location = New System.Drawing.Point(2, 403)
        Me.picXDanger2.Name = "picXDanger2"
        Me.picXDanger2.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger2.TabIndex = 13
        Me.picXDanger2.TabStop = False
        '
        'picXDanger1
        '
        Me.picXDanger1.BackColor = System.Drawing.Color.LimeGreen
        Me.picXDanger1.Location = New System.Drawing.Point(322, 283)
        Me.picXDanger1.Name = "picXDanger1"
        Me.picXDanger1.Size = New System.Drawing.Size(20, 20)
        Me.picXDanger1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picXDanger1.TabIndex = 14
        Me.picXDanger1.TabStop = False
        '
        'picGet
        '
        Me.picGet.BackColor = System.Drawing.Color.DodgerBlue
        Me.picGet.Location = New System.Drawing.Point(89, 180)
        Me.picGet.Name = "picGet"
        Me.picGet.Size = New System.Drawing.Size(15, 15)
        Me.picGet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGet.TabIndex = 30
        Me.picGet.TabStop = False
        '
        'lblEnableDebug
        '
        Me.lblEnableDebug.AutoSize = True
        Me.lblEnableDebug.BackColor = System.Drawing.Color.White
        Me.lblEnableDebug.Location = New System.Drawing.Point(440, 61)
        Me.lblEnableDebug.Name = "lblEnableDebug"
        Me.lblEnableDebug.Size = New System.Drawing.Size(59, 13)
        Me.lblEnableDebug.TabIndex = 40
        Me.lblEnableDebug.Text = "Debug: Off"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(785, 625)
        Me.Controls.Add(Me.lblEnableDebug)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.lbl25Score)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pgbSloMo)
        Me.Controls.Add(Me.pgbInvincible)
        Me.Controls.Add(Me.pgbScore)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.lblHighscore)
        Me.Controls.Add(Me.picYDanger12)
        Me.Controls.Add(Me.picYDanger10)
        Me.Controls.Add(Me.picYDanger5)
        Me.Controls.Add(Me.picYDanger8)
        Me.Controls.Add(Me.picXDanger13)
        Me.Controls.Add(Me.picXDanger12)
        Me.Controls.Add(Me.picXDanger10)
        Me.Controls.Add(Me.picXDanger9)
        Me.Controls.Add(Me.picXDanger5)
        Me.Controls.Add(Me.picYDanger3)
        Me.Controls.Add(Me.picXDanger7)
        Me.Controls.Add(Me.picYDanger11)
        Me.Controls.Add(Me.picYDanger9)
        Me.Controls.Add(Me.picXDanger3)
        Me.Controls.Add(Me.picXDanger11)
        Me.Controls.Add(Me.picYDanger4)
        Me.Controls.Add(Me.picXDanger8)
        Me.Controls.Add(Me.picYDanger7)
        Me.Controls.Add(Me.picXDanger4)
        Me.Controls.Add(Me.picYDanger6)
        Me.Controls.Add(Me.picYDanger2)
        Me.Controls.Add(Me.picXDanger6)
        Me.Controls.Add(Me.picYDanger1)
        Me.Controls.Add(Me.picXDanger2)
        Me.Controls.Add(Me.picXDanger1)
        Me.Controls.Add(Me.picGet)
        Me.Controls.Add(Me.picPlayerEXBounds)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Dots by Josh Gibbs"
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYDanger1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picXDanger1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrPGBAnimations As System.Windows.Forms.Timer
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrDown As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger1 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger2 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger1 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger6 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger2 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger6 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger4 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger7 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger8 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger4 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger11 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger3 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger9 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger11 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger7 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger3 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger5 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger9 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger10 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger12 As System.Windows.Forms.PictureBox
    Friend WithEvents picXDanger13 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger8 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger5 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger10 As System.Windows.Forms.PictureBox
    Friend WithEvents picYDanger12 As System.Windows.Forms.PictureBox
    Friend WithEvents picGet As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents lblHighscore As System.Windows.Forms.Label
    Friend WithEvents lblDebug As System.Windows.Forms.Label
    Friend WithEvents pgbScore As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tmrDangerMove As System.Windows.Forms.Timer
    Friend WithEvents tmrDebug As System.Windows.Forms.Timer
    Friend WithEvents tmrCollisionCheck As System.Windows.Forms.Timer
    Friend WithEvents pgbInvincible As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrSloMo As System.Windows.Forms.Timer
    Friend WithEvents btnPause As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlay As System.Windows.Forms.PictureBox
    Friend WithEvents pgbSloMo As System.Windows.Forms.ProgressBar
    Friend WithEvents picPlayerEXBounds As System.Windows.Forms.Label
    Friend WithEvents lbl25Score As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tmrRNDInterval As System.Windows.Forms.Timer
    Friend WithEvents lblEnableDebug As System.Windows.Forms.Label

End Class
