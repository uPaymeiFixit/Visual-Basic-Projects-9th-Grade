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
        Me.tmrPlayerMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.picPlayerBullet = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.tmrDebug = New System.Windows.Forms.Timer(Me.components)
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.tmrEnemyMovement = New System.Windows.Forms.Timer(Me.components)
        Me.picEnemy = New System.Windows.Forms.PictureBox()
        Me.picEnemyBullet = New System.Windows.Forms.PictureBox()
        CType(Me.picPlayerBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemyBullet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPlayerMovement
        '
        Me.tmrPlayerMovement.Enabled = True
        Me.tmrPlayerMovement.Interval = 1
        '
        'tmrBullet
        '
        Me.tmrBullet.Enabled = True
        '
        'picPlayerBullet
        '
        Me.picPlayerBullet.BackColor = System.Drawing.Color.Black
        Me.picPlayerBullet.Location = New System.Drawing.Point(197, 140)
        Me.picPlayerBullet.Name = "picPlayerBullet"
        Me.picPlayerBullet.Size = New System.Drawing.Size(4, 4)
        Me.picPlayerBullet.TabIndex = 1
        Me.picPlayerBullet.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.TankGame.My.Resources.Resources.picPlayerWest
        Me.picPlayer.Location = New System.Drawing.Point(91, 117)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(100, 100)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'tmrDebug
        '
        Me.tmrDebug.Enabled = True
        Me.tmrDebug.Interval = 1
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDebug.ForeColor = System.Drawing.Color.Black
        Me.lblDebug.Location = New System.Drawing.Point(224, 34)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(39, 13)
        Me.lblDebug.TabIndex = 2
        Me.lblDebug.Text = "Label1"
        '
        'tmrEnemyMovement
        '
        Me.tmrEnemyMovement.Enabled = True
        Me.tmrEnemyMovement.Interval = 50
        '
        'picEnemy
        '
        Me.picEnemy.Image = Global.TankGame.My.Resources.Resources.picEnemyNorth
        Me.picEnemy.Location = New System.Drawing.Point(62, 11)
        Me.picEnemy.Name = "picEnemy"
        Me.picEnemy.Size = New System.Drawing.Size(100, 100)
        Me.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEnemy.TabIndex = 3
        Me.picEnemy.TabStop = False
        '
        'picEnemyBullet
        '
        Me.picEnemyBullet.BackColor = System.Drawing.Color.Black
        Me.picEnemyBullet.Location = New System.Drawing.Point(227, 176)
        Me.picEnemyBullet.Name = "picEnemyBullet"
        Me.picEnemyBullet.Size = New System.Drawing.Size(4, 4)
        Me.picEnemyBullet.TabIndex = 4
        Me.picEnemyBullet.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 235)
        Me.Controls.Add(Me.picEnemyBullet)
        Me.Controls.Add(Me.picEnemy)
        Me.Controls.Add(Me.picPlayerBullet)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.lblDebug)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picPlayerBullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemyBullet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPlayerMovement As System.Windows.Forms.Timer
    Friend WithEvents picPlayerBullet As System.Windows.Forms.PictureBox
    Friend WithEvents tmrBullet As System.Windows.Forms.Timer
    Friend WithEvents tmrDebug As System.Windows.Forms.Timer
    Friend WithEvents lblDebug As System.Windows.Forms.Label
    Friend WithEvents tmrEnemyMovement As System.Windows.Forms.Timer
    Friend WithEvents picEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemyBullet As System.Windows.Forms.PictureBox

End Class
