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
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.radEur = New System.Windows.Forms.RadioButton()
        Me.radCad = New System.Windows.Forms.RadioButton()
        Me.radAus = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.radJpy = New System.Windows.Forms.RadioButton()
        Me.picJpy = New System.Windows.Forms.PictureBox()
        Me.picAus = New System.Windows.Forms.PictureBox()
        Me.picCad = New System.Windows.Forms.PictureBox()
        Me.picEur = New System.Windows.Forms.PictureBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picJpy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(12, 13)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(60, 20)
        Me.txtStart.TabIndex = 0
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(155, 13)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(60, 20)
        Me.txtEnd.TabIndex = 1
        '
        'radEur
        '
        Me.radEur.AutoSize = True
        Me.radEur.Checked = True
        Me.radEur.Location = New System.Drawing.Point(78, 14)
        Me.radEur.Name = "radEur"
        Me.radEur.Size = New System.Drawing.Size(71, 17)
        Me.radEur.TabIndex = 2
        Me.radEur.TabStop = True
        Me.radEur.Text = "European"
        Me.radEur.UseVisualStyleBackColor = True
        '
        'radCad
        '
        Me.radCad.AutoSize = True
        Me.radCad.Location = New System.Drawing.Point(79, 41)
        Me.radCad.Name = "radCad"
        Me.radCad.Size = New System.Drawing.Size(70, 17)
        Me.radCad.TabIndex = 3
        Me.radCad.TabStop = True
        Me.radCad.Text = "Canadian"
        Me.radCad.UseVisualStyleBackColor = True
        '
        'radAus
        '
        Me.radAus.AutoSize = True
        Me.radAus.Location = New System.Drawing.Point(79, 66)
        Me.radAus.Name = "radAus"
        Me.radAus.Size = New System.Drawing.Size(73, 17)
        Me.radAus.TabIndex = 4
        Me.radAus.TabStop = True
        Me.radAus.Text = "Austrailian"
        Me.radAus.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(155, 39)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 20)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 39)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 20)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'radJpy
        '
        Me.radJpy.AutoSize = True
        Me.radJpy.Location = New System.Drawing.Point(79, 90)
        Me.radJpy.Name = "radJpy"
        Me.radJpy.Size = New System.Drawing.Size(71, 17)
        Me.radJpy.TabIndex = 8
        Me.radJpy.TabStop = True
        Me.radJpy.Text = "Japanese"
        Me.radJpy.UseVisualStyleBackColor = True
        '
        'picJpy
        '
        Me.picJpy.Image = Global.CurrencyExchange.My.Resources.Resources.picJpy
        Me.picJpy.Location = New System.Drawing.Point(-2, 65)
        Me.picJpy.Name = "picJpy"
        Me.picJpy.Size = New System.Drawing.Size(10, 10)
        Me.picJpy.TabIndex = 12
        Me.picJpy.TabStop = False
        Me.picJpy.Visible = False
        '
        'picAus
        '
        Me.picAus.Image = Global.CurrencyExchange.My.Resources.Resources.picAus
        Me.picAus.Location = New System.Drawing.Point(-2, 53)
        Me.picAus.Name = "picAus"
        Me.picAus.Size = New System.Drawing.Size(10, 10)
        Me.picAus.TabIndex = 11
        Me.picAus.TabStop = False
        Me.picAus.Visible = False
        '
        'picCad
        '
        Me.picCad.Image = Global.CurrencyExchange.My.Resources.Resources.picCad
        Me.picCad.Location = New System.Drawing.Point(-2, 41)
        Me.picCad.Name = "picCad"
        Me.picCad.Size = New System.Drawing.Size(10, 10)
        Me.picCad.TabIndex = 10
        Me.picCad.TabStop = False
        Me.picCad.Visible = False
        '
        'picEur
        '
        Me.picEur.Image = Global.CurrencyExchange.My.Resources.Resources.picEur
        Me.picEur.Location = New System.Drawing.Point(-2, 29)
        Me.picEur.Name = "picEur"
        Me.picEur.Size = New System.Drawing.Size(10, 10)
        Me.picEur.TabIndex = 9
        Me.picEur.TabStop = False
        Me.picEur.Visible = False
        '
        'picMain
        '
        Me.picMain.Image = Global.CurrencyExchange.My.Resources.Resources.picEur
        Me.picMain.Location = New System.Drawing.Point(155, 65)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(60, 42)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMain.TabIndex = 7
        Me.picMain.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CurrencyExchange.My.Resources.Resources.picUS
        Me.PictureBox1.Location = New System.Drawing.Point(12, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 118)
        Me.Controls.Add(Me.picJpy)
        Me.Controls.Add(Me.picAus)
        Me.Controls.Add(Me.picCad)
        Me.Controls.Add(Me.picEur)
        Me.Controls.Add(Me.radJpy)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.radAus)
        Me.Controls.Add(Me.radCad)
        Me.Controls.Add(Me.radEur)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Name = "frmMain"
        Me.Text = "Currency Exchange"
        CType(Me.picJpy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents radEur As System.Windows.Forms.RadioButton
    Friend WithEvents radCad As System.Windows.Forms.RadioButton
    Friend WithEvents radAus As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents radJpy As System.Windows.Forms.RadioButton
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents picEur As System.Windows.Forms.PictureBox
    Friend WithEvents picCad As System.Windows.Forms.PictureBox
    Friend WithEvents picAus As System.Windows.Forms.PictureBox
    Friend WithEvents picJpy As System.Windows.Forms.PictureBox

End Class
