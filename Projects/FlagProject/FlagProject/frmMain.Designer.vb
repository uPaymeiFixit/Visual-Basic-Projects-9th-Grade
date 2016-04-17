'Josh Gibbs
'30 September 2010
'Period 2
'Your Choice Project

'[I didn't do this*******************************************]
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
        Me.picUS = New System.Windows.Forms.PictureBox()
        Me.picCanada = New System.Windows.Forms.PictureBox()
        Me.picMexico = New System.Windows.Forms.PictureBox()
        Me.picChina = New System.Windows.Forms.PictureBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.radUS = New System.Windows.Forms.RadioButton()
        Me.radCanada = New System.Windows.Forms.RadioButton()
        Me.radMexico = New System.Windows.Forms.RadioButton()
        Me.radChina = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.chkTitle = New System.Windows.Forms.CheckBox()
        Me.chkFlag = New System.Windows.Forms.CheckBox()
        Me.chkCountry = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.picUS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMexico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'picUS
        '
        Me.picUS.Image = Global.FlagProject.My.Resources.Resources.picUS
        Me.picUS.Location = New System.Drawing.Point(379, 144)
        Me.picUS.Name = "picUS"
        Me.picUS.Size = New System.Drawing.Size(10, 10)
        Me.picUS.TabIndex = 0
        Me.picUS.TabStop = False
        Me.picUS.Visible = False
        '
        'picCanada
        '
        Me.picCanada.Image = Global.FlagProject.My.Resources.Resources.picCanada
        Me.picCanada.Location = New System.Drawing.Point(379, 157)
        Me.picCanada.Name = "picCanada"
        Me.picCanada.Size = New System.Drawing.Size(10, 10)
        Me.picCanada.TabIndex = 1
        Me.picCanada.TabStop = False
        Me.picCanada.Visible = False
        '
        'picMexico
        '
        Me.picMexico.Image = Global.FlagProject.My.Resources.Resources.picMexico
        Me.picMexico.Location = New System.Drawing.Point(379, 170)
        Me.picMexico.Name = "picMexico"
        Me.picMexico.Size = New System.Drawing.Size(10, 10)
        Me.picMexico.TabIndex = 2
        Me.picMexico.TabStop = False
        Me.picMexico.Visible = False
        '
        'picChina
        '
        Me.picChina.Image = Global.FlagProject.My.Resources.Resources.picChina
        Me.picChina.Location = New System.Drawing.Point(379, 181)
        Me.picChina.Name = "picChina"
        Me.picChina.Size = New System.Drawing.Size(10, 10)
        Me.picChina.TabIndex = 3
        Me.picChina.TabStop = False
        Me.picChina.Visible = False
        '
        'picMain
        '
        Me.picMain.Image = Global.FlagProject.My.Resources.Resources.picUS
        Me.picMain.Location = New System.Drawing.Point(122, 47)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(245, 147)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMain.TabIndex = 4
        Me.picMain.TabStop = False
        '
        'radUS
        '
        Me.radUS.AutoSize = True
        Me.radUS.Checked = True
        Me.radUS.Location = New System.Drawing.Point(6, 19)
        Me.radUS.Name = "radUS"
        Me.radUS.Size = New System.Drawing.Size(89, 17)
        Me.radUS.TabIndex = 5
        Me.radUS.TabStop = True
        Me.radUS.Text = "United States"
        Me.radUS.UseVisualStyleBackColor = True
        '
        'radCanada
        '
        Me.radCanada.AutoSize = True
        Me.radCanada.Location = New System.Drawing.Point(6, 42)
        Me.radCanada.Name = "radCanada"
        Me.radCanada.Size = New System.Drawing.Size(62, 17)
        Me.radCanada.TabIndex = 6
        Me.radCanada.Text = "Canada"
        Me.radCanada.UseVisualStyleBackColor = True
        '
        'radMexico
        '
        Me.radMexico.AutoSize = True
        Me.radMexico.Location = New System.Drawing.Point(6, 65)
        Me.radMexico.Name = "radMexico"
        Me.radMexico.Size = New System.Drawing.Size(59, 17)
        Me.radMexico.TabIndex = 7
        Me.radMexico.Text = "Mexico"
        Me.radMexico.UseVisualStyleBackColor = True
        '
        'radChina
        '
        Me.radChina.AutoSize = True
        Me.radChina.Location = New System.Drawing.Point(6, 88)
        Me.radChina.Name = "radChina"
        Me.radChina.Size = New System.Drawing.Size(52, 17)
        Me.radChina.TabIndex = 8
        Me.radChina.Text = "China"
        Me.radChina.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(172, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(167, 25)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Countrie's Flags"
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(177, 197)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(126, 27)
        Me.lblCountry.TabIndex = 10
        Me.lblCountry.Text = "United States"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkTitle
        '
        Me.chkTitle.AutoSize = True
        Me.chkTitle.Location = New System.Drawing.Point(6, 19)
        Me.chkTitle.Name = "chkTitle"
        Me.chkTitle.Size = New System.Drawing.Size(71, 17)
        Me.chkTitle.TabIndex = 11
        Me.chkTitle.Text = "Hide Title"
        Me.chkTitle.UseVisualStyleBackColor = True
        '
        'chkFlag
        '
        Me.chkFlag.AutoSize = True
        Me.chkFlag.Location = New System.Drawing.Point(6, 42)
        Me.chkFlag.Name = "chkFlag"
        Me.chkFlag.Size = New System.Drawing.Size(71, 17)
        Me.chkFlag.TabIndex = 12
        Me.chkFlag.Text = "Hide Flag"
        Me.chkFlag.UseVisualStyleBackColor = True
        '
        'chkCountry
        '
        Me.chkCountry.AutoSize = True
        Me.chkCountry.Location = New System.Drawing.Point(6, 65)
        Me.chkCountry.Name = "chkCountry"
        Me.chkCountry.Size = New System.Drawing.Size(118, 17)
        Me.chkCountry.TabIndex = 13
        Me.chkCountry.Text = "Hide Country Name"
        Me.chkCountry.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(425, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Josh Gibbs"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUS)
        Me.GroupBox1.Controls.Add(Me.radCanada)
        Me.GroupBox1.Controls.Add(Me.radMexico)
        Me.GroupBox1.Controls.Add(Me.radChina)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 109)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flags"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTitle)
        Me.GroupBox2.Controls.Add(Me.chkFlag)
        Me.GroupBox2.Controls.Add(Me.chkCountry)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 86)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visibility"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 231)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.picChina)
        Me.Controls.Add(Me.picMexico)
        Me.Controls.Add(Me.picCanada)
        Me.Controls.Add(Me.picUS)
        Me.Name = "frmMain"
        Me.Text = "Countries Flags"
        CType(Me.picUS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCanada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMexico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picUS As System.Windows.Forms.PictureBox
    Friend WithEvents picCanada As System.Windows.Forms.PictureBox
    Friend WithEvents picMexico As System.Windows.Forms.PictureBox
    Friend WithEvents picChina As System.Windows.Forms.PictureBox
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents radUS As System.Windows.Forms.RadioButton
    Friend WithEvents radCanada As System.Windows.Forms.RadioButton
    Friend WithEvents radMexico As System.Windows.Forms.RadioButton
    Friend WithEvents radChina As System.Windows.Forms.RadioButton
    '[/I didn't do this*******************************************]

    Private Sub radUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUS.CheckedChanged
        'this changes the information to United States'
        picMain.Image = picUS.Image
        lblCountry.Text = "United States"
    End Sub

    Private Sub radCanada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCanada.CheckedChanged
        'this changes the information to Chanada's
        picMain.Image = picCanada.Image
        lblCountry.Text = "Canada"
    End Sub

    Private Sub radMexico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMexico.CheckedChanged
        'this changes the information to Mexico's
        picMain.Image = picMexico.Image
        lblCountry.Text = "Mexico"
    End Sub

    Private Sub radChina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radChina.CheckedChanged
        'this changes the information to China's
        picMain.Image = picChina.Image
        lblCountry.Text = "China"
    End Sub

    '[I didn't do this*******************************************]
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents chkTitle As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlag As System.Windows.Forms.CheckBox
    Friend WithEvents chkCountry As System.Windows.Forms.CheckBox
    '[/I didn't do this*******************************************]

    Private Sub chkTitle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTitle.CheckedChanged
        'this hides and shows the title
        If chkTitle.Checked = True Then
            lblTitle.Visible = False
        ElseIf chkTitle.Checked = False Then
            lblTitle.Visible = True
        End If
    End Sub

    Private Sub chkFlag_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFlag.CheckedChanged
        'this hides and shows the flag
        If chkFlag.Checked = True Then
            picMain.Visible = False
        ElseIf chkFlag.Checked = False Then
            picMain.Visible = True
        End If
    End Sub

    Private Sub chkCountry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCountry.CheckedChanged
        'this hides and shows country name
        If chkCountry.Checked = True Then
            lblCountry.Visible = False
        ElseIf chkCountry.Checked = False Then
            lblCountry.Visible = True
        End If
    End Sub

    '[I didn't do this*******************************************]
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    '[/I didn't do this*******************************************]

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'this closes the program
        Me.Close()
    End Sub

    '[I didn't do this*******************************************]
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    '[/I didn't do this*******************************************]

End Class
