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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.chkShampoo = New System.Windows.Forms.CheckBox()
        Me.chkHaircut = New System.Windows.Forms.CheckBox()
        Me.chkManacure = New System.Windows.Forms.CheckBox()
        Me.chkPedicure = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.picSad = New System.Windows.Forms.PictureBox()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.picBlank = New System.Windows.Forms.PictureBox()
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(59, 48)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 0
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(59, 72)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 1
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPedicure)
        Me.GroupBox2.Controls.Add(Me.chkManacure)
        Me.GroupBox2.Controls.Add(Me.chkHaircut)
        Me.GroupBox2.Controls.Add(Me.chkShampoo)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Location = New System.Drawing.Point(210, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Service"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Checked = True
        Me.radOther.Location = New System.Drawing.Point(59, 96)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 2
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'chkShampoo
        '
        Me.chkShampoo.AutoSize = True
        Me.chkShampoo.Location = New System.Drawing.Point(34, 35)
        Me.chkShampoo.Name = "chkShampoo"
        Me.chkShampoo.Size = New System.Drawing.Size(71, 17)
        Me.chkShampoo.TabIndex = 0
        Me.chkShampoo.Text = "Shampoo"
        Me.chkShampoo.UseVisualStyleBackColor = True
        '
        'chkHaircut
        '
        Me.chkHaircut.AutoSize = True
        Me.chkHaircut.Location = New System.Drawing.Point(34, 59)
        Me.chkHaircut.Name = "chkHaircut"
        Me.chkHaircut.Size = New System.Drawing.Size(64, 17)
        Me.chkHaircut.TabIndex = 1
        Me.chkHaircut.Text = "Hair Cut"
        Me.chkHaircut.UseVisualStyleBackColor = True
        '
        'chkManacure
        '
        Me.chkManacure.AutoSize = True
        Me.chkManacure.Location = New System.Drawing.Point(34, 83)
        Me.chkManacure.Name = "chkManacure"
        Me.chkManacure.Size = New System.Drawing.Size(74, 17)
        Me.chkManacure.TabIndex = 2
        Me.chkManacure.Text = "Manacure"
        Me.chkManacure.UseVisualStyleBackColor = True
        '
        'chkPedicure
        '
        Me.chkPedicure.AutoSize = True
        Me.chkPedicure.Location = New System.Drawing.Point(34, 107)
        Me.chkPedicure.Name = "chkPedicure"
        Me.chkPedicure.Size = New System.Drawing.Size(68, 17)
        Me.chkPedicure.TabIndex = 3
        Me.chkPedicure.Text = "Pedicure"
        Me.chkPedicure.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(44, 269)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'picSad
        '
        Me.picSad.Image = Global.IfStatements.My.Resources.Resources.picSad
        Me.picSad.Location = New System.Drawing.Point(351, 324)
        Me.picSad.Name = "picSad"
        Me.picSad.Size = New System.Drawing.Size(59, 50)
        Me.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSad.TabIndex = 4
        Me.picSad.TabStop = False
        '
        'picHappy
        '
        Me.picHappy.Image = Global.IfStatements.My.Resources.Resources.picHappy
        Me.picHappy.Location = New System.Drawing.Point(277, 324)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(59, 50)
        Me.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHappy.TabIndex = 3
        Me.picHappy.TabStop = False
        '
        'picBlank
        '
        Me.picBlank.Location = New System.Drawing.Point(286, 12)
        Me.picBlank.Name = "picBlank"
        Me.picBlank.Size = New System.Drawing.Size(77, 72)
        Me.picBlank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlank.TabIndex = 5
        Me.picBlank.TabStop = False
        '
        'btnHappy
        '
        Me.btnHappy.Location = New System.Drawing.Point(86, 343)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(75, 23)
        Me.btnHappy.TabIndex = 6
        Me.btnHappy.Text = "Happy"
        Me.btnHappy.UseVisualStyleBackColor = True
        '
        'btnSad
        '
        Me.btnSad.Location = New System.Drawing.Point(167, 343)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(75, 23)
        Me.btnSad.TabIndex = 7
        Me.btnSad.Text = "Sad"
        Me.btnSad.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 526)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.btnHappy)
        Me.Controls.Add(Me.picBlank)
        Me.Controls.Add(Me.picSad)
        Me.Controls.Add(Me.picHappy)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "How to use If statements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPedicure As System.Windows.Forms.CheckBox
    Friend WithEvents chkManacure As System.Windows.Forms.CheckBox
    Friend WithEvents chkHaircut As System.Windows.Forms.CheckBox
    Friend WithEvents chkShampoo As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents picHappy As System.Windows.Forms.PictureBox
    Friend WithEvents picSad As System.Windows.Forms.PictureBox
    Friend WithEvents picBlank As System.Windows.Forms.PictureBox
    Friend WithEvents btnHappy As System.Windows.Forms.Button
    Friend WithEvents btnSad As System.Windows.Forms.Button

End Class
