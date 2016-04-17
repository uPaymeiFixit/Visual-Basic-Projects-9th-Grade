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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnText = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.picSad = New System.Windows.Forms.PictureBox()
        Me.lblbar = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.btnName = New System.Windows.Forms.Button()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkPicture = New System.Windows.Forms.CheckBox()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(74, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(137, 14)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Hello World I'm back"
        '
        'btnText
        '
        Me.btnText.Location = New System.Drawing.Point(77, 238)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(75, 23)
        Me.btnText.TabIndex = 1
        Me.btnText.Text = "Push Me"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(158, 238)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(-3, 259)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Josh Gibbs"
        '
        'picHappy
        '
        Me.picHappy.Image = CType(resources.GetObject("picHappy.Image"), System.Drawing.Image)
        Me.picHappy.Location = New System.Drawing.Point(36, 51)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(150, 150)
        Me.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHappy.TabIndex = 4
        Me.picHappy.TabStop = False
        '
        'picSad
        '
        Me.picSad.Image = CType(resources.GetObject("picSad.Image"), System.Drawing.Image)
        Me.picSad.Location = New System.Drawing.Point(36, 51)
        Me.picSad.Name = "picSad"
        Me.picSad.Size = New System.Drawing.Size(150, 150)
        Me.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSad.TabIndex = 5
        Me.picSad.TabStop = False
        '
        'lblbar
        '
        Me.lblbar.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblbar.Location = New System.Drawing.Point(3, 23)
        Me.lblbar.Name = "lblbar"
        Me.lblbar.Size = New System.Drawing.Size(251, 10)
        Me.lblbar.TabIndex = 6
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(77, 312)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 23)
        Me.btnColor.TabIndex = 7
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(182, 312)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(75, 23)
        Me.btnFont.TabIndex = 8
        Me.btnFont.Text = "Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(293, 23)
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 9
        Me.txtName.Text = "First Name"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(399, 23)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 10
        Me.txtLast.Text = "Last Name"
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(293, 49)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(206, 23)
        Me.btnName.TabIndex = 11
        Me.btnName.Text = "Your Name"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BackColor = System.Drawing.Color.Black
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.Black
        Me.lblColor.Location = New System.Drawing.Point(201, 103)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(252, 25)
        Me.lblColor.TabIndex = 12
        Me.lblColor.Text = "00101011110101001010"
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(304, 131)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(75, 23)
        Me.btnPush.TabIndex = 13
        Me.btnPush.Text = "Flash"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Font"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkPicture
        '
        Me.chkPicture.AutoSize = True
        Me.chkPicture.Location = New System.Drawing.Point(417, 220)
        Me.chkPicture.Name = "chkPicture"
        Me.chkPicture.Size = New System.Drawing.Size(91, 17)
        Me.chkPicture.TabIndex = 15
        Me.chkPicture.Text = "Picture visible"
        Me.chkPicture.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(6, 19)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(45, 17)
        Me.rbRed.TabIndex = 16
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(5, 42)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(46, 17)
        Me.rbBlue.TabIndex = 17
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbBlue)
        Me.GroupBox1.Controls.Add(Me.rbRed)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(72, 68)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "barColor"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 50
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkPicture)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.lblbar)
        Me.Controls.Add(Me.picSad)
        Me.Controls.Add(Me.picHappy)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmMain"
        Me.Text = "This is my second project"
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnText As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents picHappy As System.Windows.Forms.PictureBox
    Friend WithEvents picSad As System.Windows.Forms.PictureBox
    Friend WithEvents lblbar As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents btnName As System.Windows.Forms.Button
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents btnPush As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkPicture As System.Windows.Forms.CheckBox
    Friend WithEvents rbRed As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlue As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
