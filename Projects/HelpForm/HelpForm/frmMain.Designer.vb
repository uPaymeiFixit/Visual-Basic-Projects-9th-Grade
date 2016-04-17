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
        Me.picLogo1 = New System.Windows.Forms.PictureBox()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picLogo2 = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.btnFlash = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picLogo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo1
        '
        Me.picLogo1.Image = CType(resources.GetObject("picLogo1.Image"), System.Drawing.Image)
        Me.picLogo1.Location = New System.Drawing.Point(63, 12)
        Me.picLogo1.Name = "picLogo1"
        Me.picLogo1.Size = New System.Drawing.Size(150, 150)
        Me.picLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo1.TabIndex = 0
        Me.picLogo1.TabStop = False
        Me.picLogo1.Visible = False
        '
        'lblAbout
        '
        Me.lblAbout.AllowDrop = True
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Location = New System.Drawing.Point(25, 181)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(231, 26)
        Me.lblAbout.TabIndex = 1
        Me.lblAbout.Text = "This is an about page. It displays information " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "about the application you are us" & _
            "ing, and a logo."
        Me.lblAbout.Visible = False
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(300, 12)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picLogo2
        '
        Me.picLogo2.Image = CType(resources.GetObject("picLogo2.Image"), System.Drawing.Image)
        Me.picLogo2.Location = New System.Drawing.Point(63, 14)
        Me.picLogo2.Name = "picLogo2"
        Me.picLogo2.Size = New System.Drawing.Size(150, 150)
        Me.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo2.TabIndex = 4
        Me.picLogo2.TabStop = False
        Me.picLogo2.Visible = False
        '
        'FontDialog1
        '
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(300, 141)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(75, 23)
        Me.btnFont.TabIndex = 5
        Me.btnFont.Text = "Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(300, 170)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 23)
        Me.btnColor.TabIndex = 6
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.BackColor = System.Drawing.Color.Red
        Me.lblLine.Location = New System.Drawing.Point(13, 141)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(0, 13)
        Me.lblLine.TabIndex = 7
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.Black
        Me.lblColor.Location = New System.Drawing.Point(275, 9)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(10, 261)
        Me.lblColor.TabIndex = 8
        '
        'btnFlash
        '
        Me.btnFlash.Location = New System.Drawing.Point(300, 71)
        Me.btnFlash.Name = "btnFlash"
        Me.btnFlash.Size = New System.Drawing.Size(75, 23)
        Me.btnFlash.TabIndex = 9
        Me.btnFlash.Text = "Flash"
        Me.btnFlash.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Josh Gibbs"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(300, 100)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(387, 282)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFlash)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.picLogo2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.picLogo1)
        Me.Name = "frmMain"
        Me.Text = "Help"
        CType(Me.picLogo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLogo1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picLogo2 As System.Windows.Forms.PictureBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents btnFlash As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
