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
        Me.Player1 = New System.Windows.Forms.Label()
        Me.Player2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Ball = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.tmrBallMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayerMovement = New System.Windows.Forms.Timer(Me.components)
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.tmrDebug = New System.Windows.Forms.Timer(Me.components)
        Me.Player4 = New System.Windows.Forms.Label()
        Me.Player3 = New System.Windows.Forms.Label()
        Me.tmrAI = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer1Score = New System.Windows.Forms.Label()
        Me.lblPlayer2Score = New System.Windows.Forms.Label()
        Me.lblPlayer3Score = New System.Windows.Forms.Label()
        Me.lblPlayer4Score = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Player1
        '
        Me.Player1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Player1.Location = New System.Drawing.Point(2, 2)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(5, 5)
        Me.Player1.TabIndex = 0
        '
        'Player2
        '
        Me.Player2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Player2.Location = New System.Drawing.Point(9, 2)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(5, 5)
        Me.Player2.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Ball})
        Me.ShapeContainer1.Size = New System.Drawing.Size(50, 70)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.White
        Me.Ball.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Ball.Location = New System.Drawing.Point(2, 9)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(10, 10)
        '
        'tmrBallMovement
        '
        Me.tmrBallMovement.Enabled = True
        Me.tmrBallMovement.Interval = 1
        '
        'tmrPlayerMovement
        '
        Me.tmrPlayerMovement.Enabled = True
        Me.tmrPlayerMovement.Interval = 1
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebug.ForeColor = System.Drawing.Color.White
        Me.lblDebug.Location = New System.Drawing.Point(3, 56)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(41, 13)
        Me.lblDebug.TabIndex = 2
        Me.lblDebug.Text = "DEBUG"
        Me.lblDebug.Visible = False
        '
        'tmrDebug
        '
        Me.tmrDebug.Interval = 1
        '
        'Player4
        '
        Me.Player4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Player4.Location = New System.Drawing.Point(16, 2)
        Me.Player4.Name = "Player4"
        Me.Player4.Size = New System.Drawing.Size(5, 5)
        Me.Player4.TabIndex = 0
        '
        'Player3
        '
        Me.Player3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Player3.Location = New System.Drawing.Point(23, 2)
        Me.Player3.Name = "Player3"
        Me.Player3.Size = New System.Drawing.Size(5, 5)
        Me.Player3.TabIndex = 0
        '
        'tmrAI
        '
        Me.tmrAI.Enabled = True
        Me.tmrAI.Interval = 1
        '
        'lblPlayer1Score
        '
        Me.lblPlayer1Score.ForeColor = System.Drawing.Color.White
        Me.lblPlayer1Score.Location = New System.Drawing.Point(30, 0)
        Me.lblPlayer1Score.Name = "lblPlayer1Score"
        Me.lblPlayer1Score.Size = New System.Drawing.Size(24, 18)
        Me.lblPlayer1Score.TabIndex = 3
        Me.lblPlayer1Score.Text = "0"
        '
        'lblPlayer2Score
        '
        Me.lblPlayer2Score.ForeColor = System.Drawing.Color.White
        Me.lblPlayer2Score.Location = New System.Drawing.Point(30, 13)
        Me.lblPlayer2Score.Name = "lblPlayer2Score"
        Me.lblPlayer2Score.Size = New System.Drawing.Size(24, 18)
        Me.lblPlayer2Score.TabIndex = 3
        Me.lblPlayer2Score.Text = "0"
        '
        'lblPlayer3Score
        '
        Me.lblPlayer3Score.ForeColor = System.Drawing.Color.White
        Me.lblPlayer3Score.Location = New System.Drawing.Point(30, 26)
        Me.lblPlayer3Score.Name = "lblPlayer3Score"
        Me.lblPlayer3Score.Size = New System.Drawing.Size(24, 18)
        Me.lblPlayer3Score.TabIndex = 3
        Me.lblPlayer3Score.Text = "0"
        '
        'lblPlayer4Score
        '
        Me.lblPlayer4Score.ForeColor = System.Drawing.Color.White
        Me.lblPlayer4Score.Location = New System.Drawing.Point(30, 39)
        Me.lblPlayer4Score.Name = "lblPlayer4Score"
        Me.lblPlayer4Score.Size = New System.Drawing.Size(24, 18)
        Me.lblPlayer4Score.TabIndex = 3
        Me.lblPlayer4Score.Text = "0"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(50, 70)
        Me.Controls.Add(Me.lblPlayer4Score)
        Me.Controls.Add(Me.lblPlayer3Score)
        Me.Controls.Add(Me.lblPlayer2Score)
        Me.Controls.Add(Me.lblPlayer1Score)
        Me.Controls.Add(Me.Player3)
        Me.Controls.Add(Me.Player4)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Pong - Josh Gibbs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Player1 As System.Windows.Forms.Label
    Friend WithEvents Player2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Ball As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents tmrBallMovement As System.Windows.Forms.Timer
    Friend WithEvents tmrPlayerMovement As System.Windows.Forms.Timer
    Friend WithEvents lblDebug As System.Windows.Forms.Label
    Friend WithEvents tmrDebug As System.Windows.Forms.Timer
    Friend WithEvents Player4 As System.Windows.Forms.Label
    Friend WithEvents Player3 As System.Windows.Forms.Label
    Friend WithEvents tmrAI As System.Windows.Forms.Timer
    Friend WithEvents lblPlayer1Score As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2Score As System.Windows.Forms.Label
    Friend WithEvents lblPlayer3Score As System.Windows.Forms.Label
    Friend WithEvents lblPlayer4Score As System.Windows.Forms.Label

End Class
