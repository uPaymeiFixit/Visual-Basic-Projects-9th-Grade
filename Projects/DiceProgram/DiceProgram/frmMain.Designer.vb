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
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.picDiceI = New System.Windows.Forms.PictureBox()
        Me.picDiceII = New System.Windows.Forms.PictureBox()
        Me.picDice1 = New System.Windows.Forms.PictureBox()
        Me.picDice2 = New System.Windows.Forms.PictureBox()
        Me.picDice3 = New System.Windows.Forms.PictureBox()
        Me.picDice4 = New System.Windows.Forms.PictureBox()
        Me.picDice5 = New System.Windows.Forms.PictureBox()
        Me.picDice6 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.pgbSum12 = New System.Windows.Forms.ProgressBar()
        Me.pgbSum11 = New System.Windows.Forms.ProgressBar()
        Me.lblSum3 = New System.Windows.Forms.Label()
        Me.pgbSum10 = New System.Windows.Forms.ProgressBar()
        Me.lblSum4 = New System.Windows.Forms.Label()
        Me.pgbSum9 = New System.Windows.Forms.ProgressBar()
        Me.lblSum5 = New System.Windows.Forms.Label()
        Me.pgbSum8 = New System.Windows.Forms.ProgressBar()
        Me.lblSum6 = New System.Windows.Forms.Label()
        Me.pgbSum7 = New System.Windows.Forms.ProgressBar()
        Me.lblSum7 = New System.Windows.Forms.Label()
        Me.pgbSum6 = New System.Windows.Forms.ProgressBar()
        Me.lblSum8 = New System.Windows.Forms.Label()
        Me.pgbSum5 = New System.Windows.Forms.ProgressBar()
        Me.lblSum9 = New System.Windows.Forms.Label()
        Me.pgbSum4 = New System.Windows.Forms.ProgressBar()
        Me.lblSum10 = New System.Windows.Forms.Label()
        Me.pgbSum3 = New System.Windows.Forms.ProgressBar()
        Me.lblSum11 = New System.Windows.Forms.Label()
        Me.pgbSum2 = New System.Windows.Forms.ProgressBar()
        Me.lblSum12 = New System.Windows.Forms.Label()
        Me.lblSum2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSum12Per = New System.Windows.Forms.Label()
        Me.lblSum11Per = New System.Windows.Forms.Label()
        Me.lblSum10Per = New System.Windows.Forms.Label()
        Me.lblSum9Per = New System.Windows.Forms.Label()
        Me.lblSum8Per = New System.Windows.Forms.Label()
        Me.lblSum7Per = New System.Windows.Forms.Label()
        Me.lblSum6Per = New System.Windows.Forms.Label()
        Me.lblSum5Per = New System.Windows.Forms.Label()
        Me.lblSum4Per = New System.Windows.Forms.Label()
        Me.lblSum3Per = New System.Windows.Forms.Label()
        Me.lblSum2Per = New System.Windows.Forms.Label()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.cbxRefresh = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picDiceI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiceII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(300, 12)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(71, 23)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "&Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'picDiceI
        '
        Me.picDiceI.Image = Global.DiceProgram.My.Resources.Resources.picDice1
        Me.picDiceI.Location = New System.Drawing.Point(12, 12)
        Me.picDiceI.Name = "picDiceI"
        Me.picDiceI.Size = New System.Drawing.Size(100, 80)
        Me.picDiceI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceI.TabIndex = 1
        Me.picDiceI.TabStop = False
        '
        'picDiceII
        '
        Me.picDiceII.Image = Global.DiceProgram.My.Resources.Resources.picDice2
        Me.picDiceII.Location = New System.Drawing.Point(118, 12)
        Me.picDiceII.Name = "picDiceII"
        Me.picDiceII.Size = New System.Drawing.Size(100, 80)
        Me.picDiceII.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceII.TabIndex = 1
        Me.picDiceII.TabStop = False
        '
        'picDice1
        '
        Me.picDice1.Image = Global.DiceProgram.My.Resources.Resources.picDice1
        Me.picDice1.Location = New System.Drawing.Point(572, 31)
        Me.picDice1.Name = "picDice1"
        Me.picDice1.Size = New System.Drawing.Size(20, 20)
        Me.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice1.TabIndex = 2
        Me.picDice1.TabStop = False
        Me.picDice1.Visible = False
        '
        'picDice2
        '
        Me.picDice2.Image = Global.DiceProgram.My.Resources.Resources.picDice2
        Me.picDice2.Location = New System.Drawing.Point(598, 31)
        Me.picDice2.Name = "picDice2"
        Me.picDice2.Size = New System.Drawing.Size(20, 20)
        Me.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice2.TabIndex = 2
        Me.picDice2.TabStop = False
        Me.picDice2.Visible = False
        '
        'picDice3
        '
        Me.picDice3.Image = Global.DiceProgram.My.Resources.Resources.picDice3
        Me.picDice3.Location = New System.Drawing.Point(624, 31)
        Me.picDice3.Name = "picDice3"
        Me.picDice3.Size = New System.Drawing.Size(20, 20)
        Me.picDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice3.TabIndex = 2
        Me.picDice3.TabStop = False
        Me.picDice3.Visible = False
        '
        'picDice4
        '
        Me.picDice4.Image = Global.DiceProgram.My.Resources.Resources.picDice4
        Me.picDice4.Location = New System.Drawing.Point(650, 31)
        Me.picDice4.Name = "picDice4"
        Me.picDice4.Size = New System.Drawing.Size(20, 20)
        Me.picDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice4.TabIndex = 2
        Me.picDice4.TabStop = False
        Me.picDice4.Visible = False
        '
        'picDice5
        '
        Me.picDice5.Image = Global.DiceProgram.My.Resources.Resources.picDice5
        Me.picDice5.Location = New System.Drawing.Point(676, 31)
        Me.picDice5.Name = "picDice5"
        Me.picDice5.Size = New System.Drawing.Size(20, 20)
        Me.picDice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice5.TabIndex = 2
        Me.picDice5.TabStop = False
        Me.picDice5.Visible = False
        '
        'picDice6
        '
        Me.picDice6.Image = Global.DiceProgram.My.Resources.Resources.picDice6
        Me.picDice6.Location = New System.Drawing.Point(702, 31)
        Me.picDice6.Name = "picDice6"
        Me.picDice6.Size = New System.Drawing.Size(20, 20)
        Me.picDice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice6.TabIndex = 2
        Me.picDice6.TabStop = False
        Me.picDice6.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "+"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(208, 36)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(64, 33)
        Me.lblSum.TabIndex = 3
        Me.lblSum.Text = "=  3"
        '
        'pgbSum12
        '
        Me.pgbSum12.ForeColor = System.Drawing.Color.Black
        Me.pgbSum12.Location = New System.Drawing.Point(170, 178)
        Me.pgbSum12.Name = "pgbSum12"
        Me.pgbSum12.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum12.TabIndex = 4
        '
        'pgbSum11
        '
        Me.pgbSum11.ForeColor = System.Drawing.Color.Black
        Me.pgbSum11.Location = New System.Drawing.Point(170, 162)
        Me.pgbSum11.Name = "pgbSum11"
        Me.pgbSum11.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum11.TabIndex = 4
        '
        'lblSum3
        '
        Me.lblSum3.AutoSize = True
        Me.lblSum3.Location = New System.Drawing.Point(12, 32)
        Me.lblSum3.Name = "lblSum3"
        Me.lblSum3.Size = New System.Drawing.Size(128, 13)
        Me.lblSum3.TabIndex = 6
        Me.lblSum3.Text = "Sum of 3 is 0 out of 0 rolls"
        '
        'pgbSum10
        '
        Me.pgbSum10.ForeColor = System.Drawing.Color.Black
        Me.pgbSum10.Location = New System.Drawing.Point(170, 146)
        Me.pgbSum10.Name = "pgbSum10"
        Me.pgbSum10.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum10.TabIndex = 4
        '
        'lblSum4
        '
        Me.lblSum4.AutoSize = True
        Me.lblSum4.Location = New System.Drawing.Point(12, 48)
        Me.lblSum4.Name = "lblSum4"
        Me.lblSum4.Size = New System.Drawing.Size(128, 13)
        Me.lblSum4.TabIndex = 7
        Me.lblSum4.Text = "Sum of 4 is 0 out of 0 rolls"
        '
        'pgbSum9
        '
        Me.pgbSum9.ForeColor = System.Drawing.Color.Black
        Me.pgbSum9.Location = New System.Drawing.Point(170, 130)
        Me.pgbSum9.Name = "pgbSum9"
        Me.pgbSum9.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum9.TabIndex = 4
        '
        'lblSum5
        '
        Me.lblSum5.AutoSize = True
        Me.lblSum5.Location = New System.Drawing.Point(12, 64)
        Me.lblSum5.Name = "lblSum5"
        Me.lblSum5.Size = New System.Drawing.Size(128, 13)
        Me.lblSum5.TabIndex = 8
        Me.lblSum5.Text = "Sum of 5 is 0 out of 0 rolls"
        '
        'pgbSum8
        '
        Me.pgbSum8.ForeColor = System.Drawing.Color.Black
        Me.pgbSum8.Location = New System.Drawing.Point(170, 114)
        Me.pgbSum8.Name = "pgbSum8"
        Me.pgbSum8.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum8.TabIndex = 4
        '
        'lblSum6
        '
        Me.lblSum6.AutoSize = True
        Me.lblSum6.Location = New System.Drawing.Point(12, 80)
        Me.lblSum6.Name = "lblSum6"
        Me.lblSum6.Size = New System.Drawing.Size(128, 13)
        Me.lblSum6.TabIndex = 9
        Me.lblSum6.Text = "Sum of 6 is 0 out of 0 rolls"
        '
        'pgbSum7
        '
        Me.pgbSum7.ForeColor = System.Drawing.Color.Black
        Me.pgbSum7.Location = New System.Drawing.Point(170, 98)
        Me.pgbSum7.Name = "pgbSum7"
        Me.pgbSum7.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum7.TabIndex = 4
        '
        'lblSum7
        '
        Me.lblSum7.AutoSize = True
        Me.lblSum7.Location = New System.Drawing.Point(12, 96)
        Me.lblSum7.Name = "lblSum7"
        Me.lblSum7.Size = New System.Drawing.Size(128, 13)
        Me.lblSum7.TabIndex = 10
        Me.lblSum7.Text = "Sum of 7 is 0 out of 0 rolls"
        '
        'pgbSum6
        '
        Me.pgbSum6.ForeColor = System.Drawing.Color.Black
        Me.pgbSum6.Location = New System.Drawing.Point(170, 82)
        Me.pgbSum6.Name = "pgbSum6"
        Me.pgbSum6.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum6.TabIndex = 4
        '
        'lblSum8
        '
        Me.lblSum8.AutoSize = True
        Me.lblSum8.Location = New System.Drawing.Point(12, 111)
        Me.lblSum8.Name = "lblSum8"
        Me.lblSum8.Size = New System.Drawing.Size(128, 13)
        Me.lblSum8.TabIndex = 11
        Me.lblSum8.Text = "Sum of 8 is 0 out of 0 rolls"
        '
        'pgbSum5
        '
        Me.pgbSum5.ForeColor = System.Drawing.Color.Black
        Me.pgbSum5.Location = New System.Drawing.Point(170, 66)
        Me.pgbSum5.Name = "pgbSum5"
        Me.pgbSum5.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum5.TabIndex = 4
        '
        'lblSum9
        '
        Me.lblSum9.AutoSize = True
        Me.lblSum9.Location = New System.Drawing.Point(12, 127)
        Me.lblSum9.Name = "lblSum9"
        Me.lblSum9.Size = New System.Drawing.Size(128, 13)
        Me.lblSum9.TabIndex = 12
        Me.lblSum9.Text = "Sum of 9 is 0 out of 0 rolls"
        '
        'pgbSum4
        '
        Me.pgbSum4.ForeColor = System.Drawing.Color.Black
        Me.pgbSum4.Location = New System.Drawing.Point(170, 50)
        Me.pgbSum4.Name = "pgbSum4"
        Me.pgbSum4.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum4.TabIndex = 4
        '
        'lblSum10
        '
        Me.lblSum10.AutoSize = True
        Me.lblSum10.Location = New System.Drawing.Point(6, 144)
        Me.lblSum10.Name = "lblSum10"
        Me.lblSum10.Size = New System.Drawing.Size(134, 13)
        Me.lblSum10.TabIndex = 13
        Me.lblSum10.Text = "Sum of 10 is 0 out of 0 rolls"
        '
        'pgbSum3
        '
        Me.pgbSum3.ForeColor = System.Drawing.Color.Black
        Me.pgbSum3.Location = New System.Drawing.Point(170, 34)
        Me.pgbSum3.Name = "pgbSum3"
        Me.pgbSum3.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum3.TabIndex = 4
        '
        'lblSum11
        '
        Me.lblSum11.AutoSize = True
        Me.lblSum11.Location = New System.Drawing.Point(6, 160)
        Me.lblSum11.Name = "lblSum11"
        Me.lblSum11.Size = New System.Drawing.Size(134, 13)
        Me.lblSum11.TabIndex = 14
        Me.lblSum11.Text = "Sum of 11 is 0 out of 0 rolls"
        '
        'pgbSum2
        '
        Me.pgbSum2.BackColor = System.Drawing.Color.White
        Me.pgbSum2.ForeColor = System.Drawing.Color.Black
        Me.pgbSum2.Location = New System.Drawing.Point(170, 18)
        Me.pgbSum2.Name = "pgbSum2"
        Me.pgbSum2.Size = New System.Drawing.Size(125, 10)
        Me.pgbSum2.TabIndex = 4
        '
        'lblSum12
        '
        Me.lblSum12.AutoSize = True
        Me.lblSum12.Location = New System.Drawing.Point(6, 176)
        Me.lblSum12.Name = "lblSum12"
        Me.lblSum12.Size = New System.Drawing.Size(134, 13)
        Me.lblSum12.TabIndex = 15
        Me.lblSum12.Text = "Sum of 12 is 0 out of 0 rolls"
        '
        'lblSum2
        '
        Me.lblSum2.AutoSize = True
        Me.lblSum2.Location = New System.Drawing.Point(12, 16)
        Me.lblSum2.Name = "lblSum2"
        Me.lblSum2.Size = New System.Drawing.Size(128, 13)
        Me.lblSum2.TabIndex = 5
        Me.lblSum2.Text = "Sum of 2 is 0 out of 0 rolls"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblSum12Per)
        Me.GroupBox1.Controls.Add(Me.lblSum11Per)
        Me.GroupBox1.Controls.Add(Me.lblSum10Per)
        Me.GroupBox1.Controls.Add(Me.lblSum9Per)
        Me.GroupBox1.Controls.Add(Me.lblSum8Per)
        Me.GroupBox1.Controls.Add(Me.lblSum7Per)
        Me.GroupBox1.Controls.Add(Me.lblSum6Per)
        Me.GroupBox1.Controls.Add(Me.lblSum5Per)
        Me.GroupBox1.Controls.Add(Me.lblSum4Per)
        Me.GroupBox1.Controls.Add(Me.lblSum3Per)
        Me.GroupBox1.Controls.Add(Me.lblSum2Per)
        Me.GroupBox1.Controls.Add(Me.lblSum2)
        Me.GroupBox1.Controls.Add(Me.lblSum12)
        Me.GroupBox1.Controls.Add(Me.pgbSum2)
        Me.GroupBox1.Controls.Add(Me.lblSum11)
        Me.GroupBox1.Controls.Add(Me.pgbSum3)
        Me.GroupBox1.Controls.Add(Me.lblSum10)
        Me.GroupBox1.Controls.Add(Me.pgbSum4)
        Me.GroupBox1.Controls.Add(Me.lblSum9)
        Me.GroupBox1.Controls.Add(Me.pgbSum5)
        Me.GroupBox1.Controls.Add(Me.lblSum8)
        Me.GroupBox1.Controls.Add(Me.pgbSum6)
        Me.GroupBox1.Controls.Add(Me.lblSum7)
        Me.GroupBox1.Controls.Add(Me.pgbSum7)
        Me.GroupBox1.Controls.Add(Me.lblSum6)
        Me.GroupBox1.Controls.Add(Me.pgbSum8)
        Me.GroupBox1.Controls.Add(Me.lblSum5)
        Me.GroupBox1.Controls.Add(Me.pgbSum9)
        Me.GroupBox1.Controls.Add(Me.lblSum4)
        Me.GroupBox1.Controls.Add(Me.pgbSum10)
        Me.GroupBox1.Controls.Add(Me.lblSum3)
        Me.GroupBox1.Controls.Add(Me.pgbSum11)
        Me.GroupBox1.Controls.Add(Me.pgbSum12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 199)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Roll Sum Counter"
        '
        'lblSum12Per
        '
        Me.lblSum12Per.AutoSize = True
        Me.lblSum12Per.Location = New System.Drawing.Point(301, 173)
        Me.lblSum12Per.Name = "lblSum12Per"
        Me.lblSum12Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum12Per.TabIndex = 16
        Me.lblSum12Per.Text = "0%"
        '
        'lblSum11Per
        '
        Me.lblSum11Per.AutoSize = True
        Me.lblSum11Per.Location = New System.Drawing.Point(301, 159)
        Me.lblSum11Per.Name = "lblSum11Per"
        Me.lblSum11Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum11Per.TabIndex = 16
        Me.lblSum11Per.Text = "0%"
        '
        'lblSum10Per
        '
        Me.lblSum10Per.AutoSize = True
        Me.lblSum10Per.Location = New System.Drawing.Point(301, 144)
        Me.lblSum10Per.Name = "lblSum10Per"
        Me.lblSum10Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum10Per.TabIndex = 16
        Me.lblSum10Per.Text = "0%"
        '
        'lblSum9Per
        '
        Me.lblSum9Per.AutoSize = True
        Me.lblSum9Per.Location = New System.Drawing.Point(301, 128)
        Me.lblSum9Per.Name = "lblSum9Per"
        Me.lblSum9Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum9Per.TabIndex = 16
        Me.lblSum9Per.Text = "0%"
        '
        'lblSum8Per
        '
        Me.lblSum8Per.AutoSize = True
        Me.lblSum8Per.Location = New System.Drawing.Point(301, 112)
        Me.lblSum8Per.Name = "lblSum8Per"
        Me.lblSum8Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum8Per.TabIndex = 16
        Me.lblSum8Per.Text = "0%"
        '
        'lblSum7Per
        '
        Me.lblSum7Per.AutoSize = True
        Me.lblSum7Per.Location = New System.Drawing.Point(301, 96)
        Me.lblSum7Per.Name = "lblSum7Per"
        Me.lblSum7Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum7Per.TabIndex = 16
        Me.lblSum7Per.Text = "0%"
        '
        'lblSum6Per
        '
        Me.lblSum6Per.AutoSize = True
        Me.lblSum6Per.Location = New System.Drawing.Point(301, 80)
        Me.lblSum6Per.Name = "lblSum6Per"
        Me.lblSum6Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum6Per.TabIndex = 16
        Me.lblSum6Per.Text = "0%"
        '
        'lblSum5Per
        '
        Me.lblSum5Per.AutoSize = True
        Me.lblSum5Per.Location = New System.Drawing.Point(301, 64)
        Me.lblSum5Per.Name = "lblSum5Per"
        Me.lblSum5Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum5Per.TabIndex = 16
        Me.lblSum5Per.Text = "0%"
        '
        'lblSum4Per
        '
        Me.lblSum4Per.AutoSize = True
        Me.lblSum4Per.Location = New System.Drawing.Point(301, 48)
        Me.lblSum4Per.Name = "lblSum4Per"
        Me.lblSum4Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum4Per.TabIndex = 16
        Me.lblSum4Per.Text = "0%"
        '
        'lblSum3Per
        '
        Me.lblSum3Per.AutoSize = True
        Me.lblSum3Per.Location = New System.Drawing.Point(301, 32)
        Me.lblSum3Per.Name = "lblSum3Per"
        Me.lblSum3Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum3Per.TabIndex = 16
        Me.lblSum3Per.Text = "0%"
        '
        'lblSum2Per
        '
        Me.lblSum2Per.AutoSize = True
        Me.lblSum2Per.Location = New System.Drawing.Point(301, 16)
        Me.lblSum2Per.Name = "lblSum2Per"
        Me.lblSum2Per.Size = New System.Drawing.Size(21, 13)
        Me.lblSum2Per.TabIndex = 16
        Me.lblSum2Per.Text = "0%"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 1000
        '
        'cbxRefresh
        '
        Me.cbxRefresh.FormattingEnabled = True
        Me.cbxRefresh.Items.AddRange(New Object() {"Do not automatically roll", "Roll 1 time per second", "Roll 10 times per second", "Roll 100 times per second", "Roll 1000 times per second"})
        Me.cbxRefresh.Location = New System.Drawing.Point(12, 105)
        Me.cbxRefresh.Name = "cbxRefresh"
        Me.cbxRefresh.Size = New System.Drawing.Size(359, 21)
        Me.cbxRefresh.TabIndex = 17
        Me.cbxRefresh.Text = "Do not automatically refresh"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 69)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(-1, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Josh Gibbs"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(389, 346)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cbxRefresh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picDice6)
        Me.Controls.Add(Me.picDice5)
        Me.Controls.Add(Me.picDice4)
        Me.Controls.Add(Me.picDice3)
        Me.Controls.Add(Me.picDice2)
        Me.Controls.Add(Me.picDice1)
        Me.Controls.Add(Me.picDiceII)
        Me.Controls.Add(Me.picDiceI)
        Me.Controls.Add(Me.btnRoll)
        Me.Name = "frmMain"
        Me.Text = "Random Dice"
        CType(Me.picDiceI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiceII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents picDiceI As System.Windows.Forms.PictureBox
    Friend WithEvents picDiceII As System.Windows.Forms.PictureBox
    Friend WithEvents picDice1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice3 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice4 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice5 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents pgbSum12 As System.Windows.Forms.ProgressBar
    Friend WithEvents pgbSum11 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum3 As System.Windows.Forms.Label
    Friend WithEvents pgbSum10 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum4 As System.Windows.Forms.Label
    Friend WithEvents pgbSum9 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum5 As System.Windows.Forms.Label
    Friend WithEvents pgbSum8 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum6 As System.Windows.Forms.Label
    Friend WithEvents pgbSum7 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum7 As System.Windows.Forms.Label
    Friend WithEvents pgbSum6 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum8 As System.Windows.Forms.Label
    Friend WithEvents pgbSum5 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum9 As System.Windows.Forms.Label
    Friend WithEvents pgbSum4 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum10 As System.Windows.Forms.Label
    Friend WithEvents pgbSum3 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum11 As System.Windows.Forms.Label
    Friend WithEvents pgbSum2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblSum12 As System.Windows.Forms.Label
    Friend WithEvents lblSum2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents cbxRefresh As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSum12Per As System.Windows.Forms.Label
    Friend WithEvents lblSum11Per As System.Windows.Forms.Label
    Friend WithEvents lblSum10Per As System.Windows.Forms.Label
    Friend WithEvents lblSum9Per As System.Windows.Forms.Label
    Friend WithEvents lblSum8Per As System.Windows.Forms.Label
    Friend WithEvents lblSum7Per As System.Windows.Forms.Label
    Friend WithEvents lblSum6Per As System.Windows.Forms.Label
    Friend WithEvents lblSum5Per As System.Windows.Forms.Label
    Friend WithEvents lblSum4Per As System.Windows.Forms.Label
    Friend WithEvents lblSum3Per As System.Windows.Forms.Label
    Friend WithEvents lblSum2Per As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
