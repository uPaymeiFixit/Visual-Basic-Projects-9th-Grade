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
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.picDiceI = New System.Windows.Forms.PictureBox()
        Me.picDiceII = New System.Windows.Forms.PictureBox()
        Me.picDice1 = New System.Windows.Forms.PictureBox()
        Me.picDice2 = New System.Windows.Forms.PictureBox()
        Me.picDice3 = New System.Windows.Forms.PictureBox()
        Me.picDice4 = New System.Windows.Forms.PictureBox()
        Me.picDice5 = New System.Windows.Forms.PictureBox()
        Me.picDice6 = New System.Windows.Forms.PictureBox()
        Me.lblDice = New System.Windows.Forms.Label()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.lblWinProbability = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRedundentButton = New System.Windows.Forms.Button()
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
        Me.btnRoll.BackColor = System.Drawing.Color.Black
        Me.btnRoll.Font = New System.Drawing.Font("Marlett", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.ForeColor = System.Drawing.Color.Coral
        Me.btnRoll.Location = New System.Drawing.Point(42, 100)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = False
        '
        'picDiceI
        '
        Me.picDiceI.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picDiceI.Location = New System.Drawing.Point(14, 24)
        Me.picDiceI.Name = "picDiceI"
        Me.picDiceI.Size = New System.Drawing.Size(50, 50)
        Me.picDiceI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceI.TabIndex = 1
        Me.picDiceI.TabStop = False
        '
        'picDiceII
        '
        Me.picDiceII.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picDiceII.Location = New System.Drawing.Point(95, 24)
        Me.picDiceII.Name = "picDiceII"
        Me.picDiceII.Size = New System.Drawing.Size(50, 50)
        Me.picDiceII.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiceII.TabIndex = 1
        Me.picDiceII.TabStop = False
        '
        'picDice1
        '
        Me.picDice1.Image = Global.CrapsGame.My.Resources.Resources._200px_Dice_1_svg
        Me.picDice1.Location = New System.Drawing.Point(37, 146)
        Me.picDice1.Name = "picDice1"
        Me.picDice1.Size = New System.Drawing.Size(15, 15)
        Me.picDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice1.TabIndex = 1
        Me.picDice1.TabStop = False
        Me.picDice1.Visible = False
        '
        'picDice2
        '
        Me.picDice2.Image = Global.CrapsGame.My.Resources.Resources._200px_Dice_2_svg
        Me.picDice2.Location = New System.Drawing.Point(58, 146)
        Me.picDice2.Name = "picDice2"
        Me.picDice2.Size = New System.Drawing.Size(15, 15)
        Me.picDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice2.TabIndex = 1
        Me.picDice2.TabStop = False
        Me.picDice2.Visible = False
        '
        'picDice3
        '
        Me.picDice3.Image = Global.CrapsGame.My.Resources.Resources._200px_Dice_3_svg
        Me.picDice3.Location = New System.Drawing.Point(71, 146)
        Me.picDice3.Name = "picDice3"
        Me.picDice3.Size = New System.Drawing.Size(15, 15)
        Me.picDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice3.TabIndex = 1
        Me.picDice3.TabStop = False
        Me.picDice3.Visible = False
        '
        'picDice4
        '
        Me.picDice4.Image = Global.CrapsGame.My.Resources.Resources._200px_Dice_4_svg
        Me.picDice4.Location = New System.Drawing.Point(92, 146)
        Me.picDice4.Name = "picDice4"
        Me.picDice4.Size = New System.Drawing.Size(15, 15)
        Me.picDice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice4.TabIndex = 1
        Me.picDice4.TabStop = False
        Me.picDice4.Visible = False
        '
        'picDice5
        '
        Me.picDice5.Image = Global.CrapsGame.My.Resources.Resources._200px_Dice_5_svg
        Me.picDice5.Location = New System.Drawing.Point(113, 146)
        Me.picDice5.Name = "picDice5"
        Me.picDice5.Size = New System.Drawing.Size(15, 15)
        Me.picDice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice5.TabIndex = 1
        Me.picDice5.TabStop = False
        Me.picDice5.Visible = False
        '
        'picDice6
        '
        Me.picDice6.Image = Global.CrapsGame.My.Resources.Resources._200px_Dice_6_svg
        Me.picDice6.Location = New System.Drawing.Point(134, 146)
        Me.picDice6.Name = "picDice6"
        Me.picDice6.Size = New System.Drawing.Size(15, 15)
        Me.picDice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDice6.TabIndex = 1
        Me.picDice6.TabStop = False
        Me.picDice6.Visible = False
        '
        'lblDice
        '
        Me.lblDice.AutoSize = True
        Me.lblDice.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDice.Font = New System.Drawing.Font("Aharoni", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDice.ForeColor = System.Drawing.Color.Coral
        Me.lblDice.Location = New System.Drawing.Point(101, 41)
        Me.lblDice.Name = "lblDice"
        Me.lblDice.Size = New System.Drawing.Size(39, 16)
        Me.lblDice.TabIndex = 2
        Me.lblDice.Text = "Dice"
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblRoll.Font = New System.Drawing.Font("Aharoni", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoll.ForeColor = System.Drawing.Color.Coral
        Me.lblRoll.Location = New System.Drawing.Point(22, 41)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(35, 16)
        Me.lblRoll.TabIndex = 2
        Me.lblRoll.Text = "Roll"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "+"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Controls.Add(Me.btnRoll)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblRoll)
        Me.GroupBox1.Controls.Add(Me.lblDice)
        Me.GroupBox1.Controls.Add(Me.picDiceII)
        Me.GroupBox1.Controls.Add(Me.picDiceI)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 137)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                    ||||||||                     '''''''''''''''''''''''''       " & _
            "   '''''''''''''''''''''''''"
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPoint.Location = New System.Drawing.Point(197, 17)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(80, 13)
        Me.lblPoint.TabIndex = 6
        Me.lblPoint.Text = "Your point: 0"
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblWins.Location = New System.Drawing.Point(221, 52)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(50, 13)
        Me.lblWins.TabIndex = 7
        Me.lblWins.Text = "Wins: 0"
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLosses.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblLosses.Location = New System.Drawing.Point(212, 82)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(61, 13)
        Me.lblLosses.TabIndex = 8
        Me.lblLosses.Text = "Losses: 0"
        '
        'lblWinProbability
        '
        Me.lblWinProbability.AutoSize = True
        Me.lblWinProbability.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinProbability.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblWinProbability.Location = New System.Drawing.Point(175, 112)
        Me.lblWinProbability.Name = "lblWinProbability"
        Me.lblWinProbability.Size = New System.Drawing.Size(125, 13)
        Me.lblWinProbability.TabIndex = 9
        Me.lblWinProbability.Text = "Win Probability: NaN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkSalmon
        Me.Label2.Location = New System.Drawing.Point(260, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Josh Gibbs"
        '
        'btnRedundentButton
        '
        Me.btnRedundentButton.BackColor = System.Drawing.Color.Silver
        Me.btnRedundentButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRedundentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedundentButton.Location = New System.Drawing.Point(302, 2)
        Me.btnRedundentButton.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRedundentButton.Name = "btnRedundentButton"
        Me.btnRedundentButton.Size = New System.Drawing.Size(13, 13)
        Me.btnRedundentButton.TabIndex = 11
        Me.btnRedundentButton.Text = "X"
        Me.btnRedundentButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRedundentButton.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.ClientSize = New System.Drawing.Size(317, 161)
        Me.Controls.Add(Me.btnRedundentButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWinProbability)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picDice6)
        Me.Controls.Add(Me.picDice4)
        Me.Controls.Add(Me.picDice2)
        Me.Controls.Add(Me.picDice5)
        Me.Controls.Add(Me.picDice3)
        Me.Controls.Add(Me.picDice1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Craps: Haloween Edition"
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
    Friend WithEvents lblDice As System.Windows.Forms.Label
    Friend WithEvents lblRoll As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPoint As System.Windows.Forms.Label
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents lblLosses As System.Windows.Forms.Label
    Friend WithEvents lblWinProbability As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRedundentButton As System.Windows.Forms.Button

End Class
