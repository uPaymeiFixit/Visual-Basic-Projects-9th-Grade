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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblLetter1 = New System.Windows.Forms.Label()
        Me.lblLetter3 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.picGrade1 = New System.Windows.Forms.PictureBox()
        Me.picGrade2 = New System.Windows.Forms.PictureBox()
        Me.picGreater = New System.Windows.Forms.PictureBox()
        Me.picLesser = New System.Windows.Forms.PictureBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.lblLetter2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picGrade1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrade2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLesser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLetter1
        '
        Me.lblLetter1.AutoSize = True
        Me.lblLetter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter1.Location = New System.Drawing.Point(65, 10)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(29, 20)
        Me.lblLetter1.TabIndex = 0
        Me.lblLetter1.Text = "A+"
        '
        'lblLetter3
        '
        Me.lblLetter3.AutoSize = True
        Me.lblLetter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter3.Location = New System.Drawing.Point(65, 59)
        Me.lblLetter3.Name = "lblLetter3"
        Me.lblLetter3.Size = New System.Drawing.Size(19, 20)
        Me.lblLetter3.TabIndex = 1
        Me.lblLetter3.Text = "F"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(12, 12)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(50, 20)
        Me.txtNumber1.TabIndex = 1
        Me.txtNumber1.Text = "100.00"
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(12, 61)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(50, 20)
        Me.txtNumber2.TabIndex = 3
        Me.txtNumber2.Text = "50.00"
        '
        'picGrade1
        '
        Me.picGrade1.Image = CType(resources.GetObject("picGrade1.Image"), System.Drawing.Image)
        Me.picGrade1.Location = New System.Drawing.Point(98, 7)
        Me.picGrade1.Name = "picGrade1"
        Me.picGrade1.Size = New System.Drawing.Size(30, 30)
        Me.picGrade1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrade1.TabIndex = 4
        Me.picGrade1.TabStop = False
        '
        'picGrade2
        '
        Me.picGrade2.Image = CType(resources.GetObject("picGrade2.Image"), System.Drawing.Image)
        Me.picGrade2.Location = New System.Drawing.Point(98, 54)
        Me.picGrade2.Name = "picGrade2"
        Me.picGrade2.Size = New System.Drawing.Size(30, 30)
        Me.picGrade2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrade2.TabIndex = 4
        Me.picGrade2.TabStop = False
        '
        'picGreater
        '
        Me.picGreater.Image = CType(resources.GetObject("picGreater.Image"), System.Drawing.Image)
        Me.picGreater.Location = New System.Drawing.Point(97, 40)
        Me.picGreater.Name = "picGreater"
        Me.picGreater.Size = New System.Drawing.Size(10, 10)
        Me.picGreater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGreater.TabIndex = 4
        Me.picGreater.TabStop = False
        Me.picGreater.Visible = False
        '
        'picLesser
        '
        Me.picLesser.Image = CType(resources.GetObject("picLesser.Image"), System.Drawing.Image)
        Me.picLesser.Location = New System.Drawing.Point(118, 41)
        Me.picLesser.Name = "picLesser"
        Me.picLesser.Size = New System.Drawing.Size(10, 10)
        Me.picLesser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLesser.TabIndex = 4
        Me.picLesser.TabStop = False
        Me.picLesser.Visible = False
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(12, 36)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(50, 20)
        Me.txtAverage.TabIndex = 2
        Me.txtAverage.TabStop = False
        Me.txtAverage.Text = "75.00"
        '
        'lblLetter2
        '
        Me.lblLetter2.AutoSize = True
        Me.lblLetter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter2.Location = New System.Drawing.Point(65, 36)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(20, 20)
        Me.lblLetter2.TabIndex = 1
        Me.lblLetter2.Text = "C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(-2, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Josh Gibbs"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(141, 93)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picGrade2)
        Me.Controls.Add(Me.picLesser)
        Me.Controls.Add(Me.picGreater)
        Me.Controls.Add(Me.picGrade1)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblLetter2)
        Me.Controls.Add(Me.lblLetter3)
        Me.Controls.Add(Me.lblLetter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Grade Calculator"
        CType(Me.picGrade1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrade2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLesser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLetter1 As System.Windows.Forms.Label
    Friend WithEvents lblLetter3 As System.Windows.Forms.Label
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents picGrade1 As System.Windows.Forms.PictureBox
    Friend WithEvents picGrade2 As System.Windows.Forms.PictureBox
    Friend WithEvents picGreater As System.Windows.Forms.PictureBox
    Friend WithEvents picLesser As System.Windows.Forms.PictureBox
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents lblLetter2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
