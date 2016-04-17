<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrStart
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbPlayer4 = New System.Windows.Forms.ComboBox()
        Me.cmbPlayer3 = New System.Windows.Forms.ComboBox()
        Me.cmbPlayer2 = New System.Windows.Forms.ComboBox()
        Me.cmbPlayer1 = New System.Windows.Forms.ComboBox()
        Me.nudBallSpeed = New System.Windows.Forms.NumericUpDown()
        Me.nudPlayerSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCourtSize = New System.Windows.Forms.ComboBox()
        Me.cmbPaddleSizes = New System.Windows.Forms.ComboBox()
        Me.grpAdvanced = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.nudScoreEnd = New System.Windows.Forms.NumericUpDown()
        Me.nudScoreStart = New System.Windows.Forms.NumericUpDown()
        Me.cmbScoreUPDown = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.radMCPlayer4 = New System.Windows.Forms.RadioButton()
        Me.radMCPlayer2 = New System.Windows.Forms.RadioButton()
        Me.radMCPlayer3 = New System.Windows.Forms.RadioButton()
        Me.radMCPlayer1 = New System.Windows.Forms.RadioButton()
        Me.radMCNobody = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.radGMCustom = New System.Windows.Forms.RadioButton()
        Me.radGMSuddenDeath = New System.Windows.Forms.RadioButton()
        Me.radGM1vAI = New System.Windows.Forms.RadioButton()
        Me.nudGMXPlayer = New System.Windows.Forms.NumericUpDown()
        Me.radGMXPlayer = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudBallSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlayerSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpAdvanced.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nudScoreEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudScoreStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudGMXPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(12, 132)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(133, 20)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer4)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer3)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer2)
        Me.GroupBox1.Controls.Add(Me.cmbPlayer1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(207, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Players"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(72, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Player 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(123, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Player 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(68, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Player 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Player 1"
        '
        'cmbPlayer4
        '
        Me.cmbPlayer4.BackColor = System.Drawing.Color.White
        Me.cmbPlayer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayer4.FormattingEnabled = True
        Me.cmbPlayer4.Items.AddRange(New Object() {"Enabled", "Computer", "Disabled"})
        Me.cmbPlayer4.Location = New System.Drawing.Point(71, 26)
        Me.cmbPlayer4.Name = "cmbPlayer4"
        Me.cmbPlayer4.Size = New System.Drawing.Size(110, 21)
        Me.cmbPlayer4.TabIndex = 4
        Me.cmbPlayer4.Text = "Disabled"
        '
        'cmbPlayer3
        '
        Me.cmbPlayer3.BackColor = System.Drawing.Color.White
        Me.cmbPlayer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayer3.FormattingEnabled = True
        Me.cmbPlayer3.Items.AddRange(New Object() {"Enabled", "Computer", "Disabled"})
        Me.cmbPlayer3.Location = New System.Drawing.Point(68, 104)
        Me.cmbPlayer3.Name = "cmbPlayer3"
        Me.cmbPlayer3.Size = New System.Drawing.Size(110, 21)
        Me.cmbPlayer3.TabIndex = 3
        Me.cmbPlayer3.Text = "Disabled"
        '
        'cmbPlayer2
        '
        Me.cmbPlayer2.BackColor = System.Drawing.Color.White
        Me.cmbPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayer2.FormattingEnabled = True
        Me.cmbPlayer2.Items.AddRange(New Object() {"Enabled", "Computer", "Disabled"})
        Me.cmbPlayer2.Location = New System.Drawing.Point(122, 65)
        Me.cmbPlayer2.Name = "cmbPlayer2"
        Me.cmbPlayer2.Size = New System.Drawing.Size(110, 21)
        Me.cmbPlayer2.TabIndex = 2
        Me.cmbPlayer2.Text = "Computer"
        '
        'cmbPlayer1
        '
        Me.cmbPlayer1.BackColor = System.Drawing.Color.White
        Me.cmbPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPlayer1.FormattingEnabled = True
        Me.cmbPlayer1.Items.AddRange(New Object() {"Enabled", "Computer", "Disabled"})
        Me.cmbPlayer1.Location = New System.Drawing.Point(8, 65)
        Me.cmbPlayer1.Name = "cmbPlayer1"
        Me.cmbPlayer1.Size = New System.Drawing.Size(110, 21)
        Me.cmbPlayer1.TabIndex = 1
        Me.cmbPlayer1.Text = "Enabled"
        '
        'nudBallSpeed
        '
        Me.nudBallSpeed.AutoSize = True
        Me.nudBallSpeed.BackColor = System.Drawing.Color.White
        Me.nudBallSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudBallSpeed.Location = New System.Drawing.Point(18, 30)
        Me.nudBallSpeed.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudBallSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBallSpeed.Name = "nudBallSpeed"
        Me.nudBallSpeed.Size = New System.Drawing.Size(43, 20)
        Me.nudBallSpeed.TabIndex = 7
        Me.nudBallSpeed.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'nudPlayerSpeed
        '
        Me.nudPlayerSpeed.AutoSize = True
        Me.nudPlayerSpeed.BackColor = System.Drawing.Color.White
        Me.nudPlayerSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPlayerSpeed.Location = New System.Drawing.Point(60, 30)
        Me.nudPlayerSpeed.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudPlayerSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPlayerSpeed.Name = "nudPlayerSpeed"
        Me.nudPlayerSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudPlayerSpeed.Size = New System.Drawing.Size(43, 20)
        Me.nudPlayerSpeed.TabIndex = 8
        Me.nudPlayerSpeed.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ball"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Player"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.nudBallSpeed)
        Me.GroupBox2.Controls.Add(Me.nudPlayerSpeed)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(331, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(117, 96)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game Speeds"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmbCourtSize)
        Me.GroupBox3.Controls.Add(Me.cmbPaddleSizes)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(163, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(170, 96)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sizes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Court Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Paddle Size"
        '
        'cmbCourtSize
        '
        Me.cmbCourtSize.BackColor = System.Drawing.Color.White
        Me.cmbCourtSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCourtSize.FormattingEnabled = True
        Me.cmbCourtSize.Items.AddRange(New Object() {"Big", "Medium", "Small"})
        Me.cmbCourtSize.Location = New System.Drawing.Point(24, 68)
        Me.cmbCourtSize.Name = "cmbCourtSize"
        Me.cmbCourtSize.Size = New System.Drawing.Size(122, 21)
        Me.cmbCourtSize.TabIndex = 6
        Me.cmbCourtSize.Text = "Medium (Default)"
        '
        'cmbPaddleSizes
        '
        Me.cmbPaddleSizes.BackColor = System.Drawing.Color.White
        Me.cmbPaddleSizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPaddleSizes.FormattingEnabled = True
        Me.cmbPaddleSizes.Items.AddRange(New Object() {"Long", "Medium", "Short"})
        Me.cmbPaddleSizes.Location = New System.Drawing.Point(24, 24)
        Me.cmbPaddleSizes.Name = "cmbPaddleSizes"
        Me.cmbPaddleSizes.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaddleSizes.TabIndex = 5
        Me.cmbPaddleSizes.Text = "Medium (Default)"
        '
        'grpAdvanced
        '
        Me.grpAdvanced.Controls.Add(Me.GroupBox2)
        Me.grpAdvanced.Controls.Add(Me.GroupBox6)
        Me.grpAdvanced.Controls.Add(Me.GroupBox3)
        Me.grpAdvanced.Controls.Add(Me.GroupBox1)
        Me.grpAdvanced.Controls.Add(Me.GroupBox7)
        Me.grpAdvanced.Location = New System.Drawing.Point(0, 0)
        Me.grpAdvanced.Name = "grpAdvanced"
        Me.grpAdvanced.Size = New System.Drawing.Size(448, 279)
        Me.grpAdvanced.TabIndex = 8
        Me.grpAdvanced.TabStop = False
        Me.grpAdvanced.Text = "GroupBox4"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.nudScoreEnd)
        Me.GroupBox6.Controls.Add(Me.nudScoreStart)
        Me.GroupBox6.Controls.Add(Me.cmbScoreUPDown)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(207, 138)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(241, 52)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Score"
        '
        'nudScoreEnd
        '
        Me.nudScoreEnd.BackColor = System.Drawing.Color.Black
        Me.nudScoreEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudScoreEnd.ForeColor = System.Drawing.Color.White
        Me.nudScoreEnd.Location = New System.Drawing.Point(191, 16)
        Me.nudScoreEnd.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudScoreEnd.Name = "nudScoreEnd"
        Me.nudScoreEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudScoreEnd.Size = New System.Drawing.Size(33, 20)
        Me.nudScoreEnd.TabIndex = 8
        Me.nudScoreEnd.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudScoreEnd.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudScoreStart
        '
        Me.nudScoreStart.BackColor = System.Drawing.Color.Black
        Me.nudScoreStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudScoreStart.ForeColor = System.Drawing.Color.White
        Me.nudScoreStart.Location = New System.Drawing.Point(149, 16)
        Me.nudScoreStart.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudScoreStart.Name = "nudScoreStart"
        Me.nudScoreStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudScoreStart.Size = New System.Drawing.Size(33, 20)
        Me.nudScoreStart.TabIndex = 8
        Me.nudScoreStart.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'cmbScoreUPDown
        '
        Me.cmbScoreUPDown.BackColor = System.Drawing.Color.Black
        Me.cmbScoreUPDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbScoreUPDown.ForeColor = System.Drawing.Color.White
        Me.cmbScoreUPDown.FormattingEnabled = True
        Me.cmbScoreUPDown.Items.AddRange(New Object() {"Down", "Up"})
        Me.cmbScoreUPDown.Location = New System.Drawing.Point(81, 16)
        Me.cmbScoreUPDown.Name = "cmbScoreUPDown"
        Me.cmbScoreUPDown.Size = New System.Drawing.Size(45, 21)
        Me.cmbScoreUPDown.TabIndex = 6
        Me.cmbScoreUPDown.Text = "Up"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Score counts                 from           to          ."
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.radMCPlayer4)
        Me.GroupBox7.Controls.Add(Me.radMCPlayer2)
        Me.GroupBox7.Controls.Add(Me.radMCPlayer3)
        Me.GroupBox7.Controls.Add(Me.radMCPlayer1)
        Me.GroupBox7.Controls.Add(Me.radMCNobody)
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(1, 183)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(163, 96)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Mouse Control"
        '
        'radMCPlayer4
        '
        Me.radMCPlayer4.AutoSize = True
        Me.radMCPlayer4.Location = New System.Drawing.Point(84, 65)
        Me.radMCPlayer4.Name = "radMCPlayer4"
        Me.radMCPlayer4.Size = New System.Drawing.Size(63, 17)
        Me.radMCPlayer4.TabIndex = 0
        Me.radMCPlayer4.Text = "Player 4"
        Me.radMCPlayer4.UseVisualStyleBackColor = True
        '
        'radMCPlayer2
        '
        Me.radMCPlayer2.AutoSize = True
        Me.radMCPlayer2.Location = New System.Drawing.Point(84, 42)
        Me.radMCPlayer2.Name = "radMCPlayer2"
        Me.radMCPlayer2.Size = New System.Drawing.Size(63, 17)
        Me.radMCPlayer2.TabIndex = 0
        Me.radMCPlayer2.Text = "Player 2"
        Me.radMCPlayer2.UseVisualStyleBackColor = True
        '
        'radMCPlayer3
        '
        Me.radMCPlayer3.AutoSize = True
        Me.radMCPlayer3.Location = New System.Drawing.Point(16, 65)
        Me.radMCPlayer3.Name = "radMCPlayer3"
        Me.radMCPlayer3.Size = New System.Drawing.Size(63, 17)
        Me.radMCPlayer3.TabIndex = 0
        Me.radMCPlayer3.Text = "Player 3"
        Me.radMCPlayer3.UseVisualStyleBackColor = True
        '
        'radMCPlayer1
        '
        Me.radMCPlayer1.AutoSize = True
        Me.radMCPlayer1.Checked = True
        Me.radMCPlayer1.Location = New System.Drawing.Point(16, 42)
        Me.radMCPlayer1.Name = "radMCPlayer1"
        Me.radMCPlayer1.Size = New System.Drawing.Size(63, 17)
        Me.radMCPlayer1.TabIndex = 0
        Me.radMCPlayer1.TabStop = True
        Me.radMCPlayer1.Text = "Player 1"
        Me.radMCPlayer1.UseVisualStyleBackColor = True
        '
        'radMCNobody
        '
        Me.radMCNobody.AutoSize = True
        Me.radMCNobody.Location = New System.Drawing.Point(53, 19)
        Me.radMCNobody.Name = "radMCNobody"
        Me.radMCNobody.Size = New System.Drawing.Size(62, 17)
        Me.radMCNobody.TabIndex = 0
        Me.radMCNobody.Text = "Nobody"
        Me.radMCNobody.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radGMCustom)
        Me.GroupBox5.Controls.Add(Me.radGMSuddenDeath)
        Me.GroupBox5.Controls.Add(Me.btnStart)
        Me.GroupBox5.Controls.Add(Me.radGM1vAI)
        Me.GroupBox5.Controls.Add(Me.nudGMXPlayer)
        Me.GroupBox5.Controls.Add(Me.radGMXPlayer)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 177)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pre Configured Game Modes"
        '
        'radGMCustom
        '
        Me.radGMCustom.AutoSize = True
        Me.radGMCustom.Location = New System.Drawing.Point(25, 98)
        Me.radGMCustom.Name = "radGMCustom"
        Me.radGMCustom.Size = New System.Drawing.Size(60, 17)
        Me.radGMCustom.TabIndex = 0
        Me.radGMCustom.Text = "Custom"
        Me.radGMCustom.UseVisualStyleBackColor = True
        '
        'radGMSuddenDeath
        '
        Me.radGMSuddenDeath.AutoSize = True
        Me.radGMSuddenDeath.Location = New System.Drawing.Point(25, 76)
        Me.radGMSuddenDeath.Name = "radGMSuddenDeath"
        Me.radGMSuddenDeath.Size = New System.Drawing.Size(94, 17)
        Me.radGMSuddenDeath.TabIndex = 0
        Me.radGMSuddenDeath.Text = "Sudden Death"
        Me.radGMSuddenDeath.UseVisualStyleBackColor = True
        '
        'radGM1vAI
        '
        Me.radGM1vAI.AutoSize = True
        Me.radGM1vAI.Checked = True
        Me.radGM1vAI.Location = New System.Drawing.Point(25, 31)
        Me.radGM1vAI.Name = "radGM1vAI"
        Me.radGM1vAI.Size = New System.Drawing.Size(77, 17)
        Me.radGM1vAI.TabIndex = 0
        Me.radGM1vAI.TabStop = True
        Me.radGM1vAI.Text = "You VS. AI"
        Me.radGM1vAI.UseVisualStyleBackColor = True
        '
        'nudGMXPlayer
        '
        Me.nudGMXPlayer.BackColor = System.Drawing.Color.Black
        Me.nudGMXPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudGMXPlayer.ForeColor = System.Drawing.Color.White
        Me.nudGMXPlayer.Location = New System.Drawing.Point(41, 53)
        Me.nudGMXPlayer.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudGMXPlayer.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudGMXPlayer.Name = "nudGMXPlayer"
        Me.nudGMXPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudGMXPlayer.Size = New System.Drawing.Size(29, 20)
        Me.nudGMXPlayer.TabIndex = 8
        Me.nudGMXPlayer.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'radGMXPlayer
        '
        Me.radGMXPlayer.AutoSize = True
        Me.radGMXPlayer.Location = New System.Drawing.Point(25, 54)
        Me.radGMXPlayer.Name = "radGMXPlayer"
        Me.radGMXPlayer.Size = New System.Drawing.Size(81, 17)
        Me.radGMXPlayer.TabIndex = 0
        Me.radGMXPlayer.Text = "         Player"
        Me.radGMXPlayer.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 700
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(177, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(297, 26)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Select grpAdvanced and change location to 0, 0 to get back." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Change location to -" & _
            "248 x -102 for start location"
        '
        'fmrStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(448, 278)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.grpAdvanced)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fmrStart"
        Me.Text = "Pong - Josh Gibbs"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudBallSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlayerSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpAdvanced.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nudScoreEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudScoreStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudGMXPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPlayer2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlayer1 As System.Windows.Forms.ComboBox
    Friend WithEvents nudBallSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPlayerSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPlayer4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlayer3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCourtSize As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPaddleSizes As System.Windows.Forms.ComboBox
    Friend WithEvents grpAdvanced As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents radGMSuddenDeath As System.Windows.Forms.RadioButton
    Friend WithEvents radGMXPlayer As System.Windows.Forms.RadioButton
    Friend WithEvents radGM1vAI As System.Windows.Forms.RadioButton
    Friend WithEvents nudGMXPlayer As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents nudScoreEnd As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudScoreStart As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbScoreUPDown As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents radMCPlayer4 As System.Windows.Forms.RadioButton
    Friend WithEvents radMCPlayer2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMCPlayer3 As System.Windows.Forms.RadioButton
    Friend WithEvents radMCPlayer1 As System.Windows.Forms.RadioButton
    Friend WithEvents radMCNobody As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents radGMCustom As System.Windows.Forms.RadioButton
End Class
