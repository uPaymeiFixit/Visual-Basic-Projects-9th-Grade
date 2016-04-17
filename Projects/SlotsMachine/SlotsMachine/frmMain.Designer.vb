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
        Me.tmrRoller = New System.Windows.Forms.Timer(Me.components)
        Me.lblWinnerPaid = New System.Windows.Forms.Label()
        Me.lblUserMoney = New System.Windows.Forms.Label()
        Me.lblBet = New System.Windows.Forms.Label()
        Me.lblWinRollCount = New System.Windows.Forms.Label()
        Me.picRSlot3 = New System.Windows.Forms.PictureBox()
        Me.picRSlot2 = New System.Windows.Forms.PictureBox()
        Me.picRSlot1 = New System.Windows.Forms.PictureBox()
        Me.btnAddMoney = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.btnIncreaseBet = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Label()
        CType(Me.picRSlot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRoller
        '
        Me.tmrRoller.Interval = 1
        '
        'lblWinnerPaid
        '
        Me.lblWinnerPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblWinnerPaid.Font = New System.Drawing.Font("Miriam Fixed", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblWinnerPaid.ForeColor = System.Drawing.Color.Red
        Me.lblWinnerPaid.Location = New System.Drawing.Point(346, 445)
        Me.lblWinnerPaid.Name = "lblWinnerPaid"
        Me.lblWinnerPaid.Size = New System.Drawing.Size(54, 11)
        Me.lblWinnerPaid.TabIndex = 4
        Me.lblWinnerPaid.Text = "0"
        Me.lblWinnerPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserMoney
        '
        Me.lblUserMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblUserMoney.Font = New System.Drawing.Font("Miriam Fixed", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblUserMoney.ForeColor = System.Drawing.Color.Red
        Me.lblUserMoney.Location = New System.Drawing.Point(84, 445)
        Me.lblUserMoney.Name = "lblUserMoney"
        Me.lblUserMoney.Size = New System.Drawing.Size(102, 11)
        Me.lblUserMoney.TabIndex = 6
        Me.lblUserMoney.Text = "0"
        Me.lblUserMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBet
        '
        Me.lblBet.AutoSize = True
        Me.lblBet.BackColor = System.Drawing.Color.Transparent
        Me.lblBet.Font = New System.Drawing.Font("Miriam Fixed", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblBet.ForeColor = System.Drawing.Color.Red
        Me.lblBet.Location = New System.Drawing.Point(250, 445)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(13, 11)
        Me.lblBet.TabIndex = 9
        Me.lblBet.Text = "0"
        '
        'lblWinRollCount
        '
        Me.lblWinRollCount.BackColor = System.Drawing.Color.Transparent
        Me.lblWinRollCount.Font = New System.Drawing.Font("Miriam Fixed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblWinRollCount.ForeColor = System.Drawing.Color.Red
        Me.lblWinRollCount.Location = New System.Drawing.Point(57, 247)
        Me.lblWinRollCount.Name = "lblWinRollCount"
        Me.lblWinRollCount.Size = New System.Drawing.Size(359, 27)
        Me.lblWinRollCount.TabIndex = 12
        Me.lblWinRollCount.Text = "WINS: 0   SPINS: 0"
        '
        'picRSlot3
        '
        Me.picRSlot3.BackColor = System.Drawing.Color.Transparent
        Me.picRSlot3.Image = Global.SlotsMachine.My.Resources.Resources.r2
        Me.picRSlot3.Location = New System.Drawing.Point(287, 326)
        Me.picRSlot3.Name = "picRSlot3"
        Me.picRSlot3.Size = New System.Drawing.Size(76, 98)
        Me.picRSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRSlot3.TabIndex = 0
        Me.picRSlot3.TabStop = False
        '
        'picRSlot2
        '
        Me.picRSlot2.BackColor = System.Drawing.Color.Transparent
        Me.picRSlot2.Image = Global.SlotsMachine.My.Resources.Resources.r2
        Me.picRSlot2.Location = New System.Drawing.Point(194, 326)
        Me.picRSlot2.Name = "picRSlot2"
        Me.picRSlot2.Size = New System.Drawing.Size(76, 98)
        Me.picRSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRSlot2.TabIndex = 0
        Me.picRSlot2.TabStop = False
        '
        'picRSlot1
        '
        Me.picRSlot1.BackColor = System.Drawing.Color.Transparent
        Me.picRSlot1.Image = Global.SlotsMachine.My.Resources.Resources.r2
        Me.picRSlot1.Location = New System.Drawing.Point(101, 326)
        Me.picRSlot1.Name = "picRSlot1"
        Me.picRSlot1.Size = New System.Drawing.Size(76, 98)
        Me.picRSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRSlot1.TabIndex = 0
        Me.picRSlot1.TabStop = False
        '
        'btnAddMoney
        '
        Me.btnAddMoney.BackColor = System.Drawing.Color.Transparent
        Me.btnAddMoney.Image = Global.SlotsMachine.My.Resources.Resources.addmoney_up
        Me.btnAddMoney.Location = New System.Drawing.Point(353, 466)
        Me.btnAddMoney.Name = "btnAddMoney"
        Me.btnAddMoney.Size = New System.Drawing.Size(63, 59)
        Me.btnAddMoney.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = Global.SlotsMachine.My.Resources.Resources.cashout_up
        Me.btnExit.Location = New System.Drawing.Point(69, 467)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 57)
        Me.btnExit.TabIndex = 4
        '
        'btnIncreaseBet
        '
        Me.btnIncreaseBet.BackColor = System.Drawing.Color.Transparent
        Me.btnIncreaseBet.Image = Global.SlotsMachine.My.Resources.Resources.betone_up
        Me.btnIncreaseBet.Location = New System.Drawing.Point(150, 470)
        Me.btnIncreaseBet.Name = "btnIncreaseBet"
        Me.btnIncreaseBet.Size = New System.Drawing.Size(70, 51)
        Me.btnIncreaseBet.TabIndex = 2
        Me.btnIncreaseBet.Visible = False
        '
        'btnRoll
        '
        Me.btnRoll.BackColor = System.Drawing.Color.Transparent
        Me.btnRoll.Image = Global.SlotsMachine.My.Resources.Resources.spin_up
        Me.btnRoll.Location = New System.Drawing.Point(220, 468)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(71, 56)
        Me.btnRoll.TabIndex = 3
        Me.btnRoll.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SlotsMachine.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(480, 526)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnIncreaseBet)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddMoney)
        Me.Controls.Add(Me.lblWinRollCount)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.lblUserMoney)
        Me.Controls.Add(Me.lblWinnerPaid)
        Me.Controls.Add(Me.picRSlot3)
        Me.Controls.Add(Me.picRSlot2)
        Me.Controls.Add(Me.picRSlot1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Slots"
        CType(Me.picRSlot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrRoller As System.Windows.Forms.Timer
    Friend WithEvents picRSlot1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRSlot2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRSlot3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWinnerPaid As System.Windows.Forms.Label
    Friend WithEvents lblUserMoney As System.Windows.Forms.Label
    Friend WithEvents lblBet As System.Windows.Forms.Label
    Friend WithEvents lblWinRollCount As System.Windows.Forms.Label
    Friend WithEvents btnAddMoney As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents btnIncreaseBet As System.Windows.Forms.Label
    Friend WithEvents btnRoll As System.Windows.Forms.Label

End Class
