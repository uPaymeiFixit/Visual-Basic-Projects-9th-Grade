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
        Me.tmrMoveFireball = New System.Windows.Forms.Timer(Me.components)
        Me.picDanger3 = New System.Windows.Forms.PictureBox()
        Me.picDanger4 = New System.Windows.Forms.PictureBox()
        Me.picDanger5 = New System.Windows.Forms.PictureBox()
        Me.picDanger0 = New System.Windows.Forms.PictureBox()
        Me.picDanger2 = New System.Windows.Forms.PictureBox()
        Me.picDanger1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.tmrPlayerMovement = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picDanger3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDanger4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDanger5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDanger0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDanger2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDanger1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMoveFireball
        '
        Me.tmrMoveFireball.Enabled = True
        Me.tmrMoveFireball.Interval = 1
        '
        'picDanger3
        '
        Me.picDanger3.BackColor = System.Drawing.Color.Red
        Me.picDanger3.Location = New System.Drawing.Point(684, 192)
        Me.picDanger3.Name = "picDanger3"
        Me.picDanger3.Size = New System.Drawing.Size(100, 50)
        Me.picDanger3.TabIndex = 0
        Me.picDanger3.TabStop = False
        '
        'picDanger4
        '
        Me.picDanger4.BackColor = System.Drawing.Color.Red
        Me.picDanger4.Location = New System.Drawing.Point(684, 248)
        Me.picDanger4.Name = "picDanger4"
        Me.picDanger4.Size = New System.Drawing.Size(100, 50)
        Me.picDanger4.TabIndex = 0
        Me.picDanger4.TabStop = False
        '
        'picDanger5
        '
        Me.picDanger5.BackColor = System.Drawing.Color.Red
        Me.picDanger5.Location = New System.Drawing.Point(684, 304)
        Me.picDanger5.Name = "picDanger5"
        Me.picDanger5.Size = New System.Drawing.Size(100, 50)
        Me.picDanger5.TabIndex = 0
        Me.picDanger5.TabStop = False
        '
        'picDanger0
        '
        Me.picDanger0.BackColor = System.Drawing.Color.Red
        Me.picDanger0.Location = New System.Drawing.Point(684, 24)
        Me.picDanger0.Name = "picDanger0"
        Me.picDanger0.Size = New System.Drawing.Size(100, 50)
        Me.picDanger0.TabIndex = 0
        Me.picDanger0.TabStop = False
        '
        'picDanger2
        '
        Me.picDanger2.BackColor = System.Drawing.Color.Red
        Me.picDanger2.Location = New System.Drawing.Point(684, 136)
        Me.picDanger2.Name = "picDanger2"
        Me.picDanger2.Size = New System.Drawing.Size(100, 50)
        Me.picDanger2.TabIndex = 0
        Me.picDanger2.TabStop = False
        '
        'picDanger1
        '
        Me.picDanger1.BackColor = System.Drawing.Color.Red
        Me.picDanger1.Location = New System.Drawing.Point(684, 80)
        Me.picDanger1.Name = "picDanger1"
        Me.picDanger1.Size = New System.Drawing.Size(100, 50)
        Me.picDanger1.TabIndex = 0
        Me.picDanger1.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Yellow
        Me.picPlayer.Location = New System.Drawing.Point(41, 164)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(30, 30)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'tmrPlayerMovement
        '
        Me.tmrPlayerMovement.Enabled = True
        Me.tmrPlayerMovement.Interval = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 390)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picDanger1)
        Me.Controls.Add(Me.picDanger2)
        Me.Controls.Add(Me.picDanger0)
        Me.Controls.Add(Me.picDanger5)
        Me.Controls.Add(Me.picDanger4)
        Me.Controls.Add(Me.picDanger3)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picDanger3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDanger4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDanger5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDanger0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDanger2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDanger1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrMoveFireball As System.Windows.Forms.Timer
    Friend WithEvents picDanger3 As System.Windows.Forms.PictureBox
    Friend WithEvents picDanger4 As System.Windows.Forms.PictureBox
    Friend WithEvents picDanger5 As System.Windows.Forms.PictureBox
    Friend WithEvents picDanger0 As System.Windows.Forms.PictureBox
    Friend WithEvents picDanger2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDanger1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPlayerMovement As System.Windows.Forms.Timer

End Class
