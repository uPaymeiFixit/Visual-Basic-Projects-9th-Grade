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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picGrade2 = New System.Windows.Forms.PictureBox()
        Me.picLesser = New System.Windows.Forms.PictureBox()
        Me.picGreater = New System.Windows.Forms.PictureBox()
        Me.picGrade1 = New System.Windows.Forms.PictureBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblLetter2 = New System.Windows.Forms.Label()
        Me.lblLetter1 = New System.Windows.Forms.Label()
        CType(Me.picGrade2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLesser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrade1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(-2, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Josh Gibbs"
        '
        'picGrade2
        '
        Me.picGrade2.Image = CType(resources.GetObject("picGrade2.Image"), System.Drawing.Image)
        Me.picGrade2.Location = New System.Drawing.Point(98, 49)
        Me.picGrade2.Name = "picGrade2"
        Me.picGrade2.Size = New System.Drawing.Size(30, 30)
        Me.picGrade2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrade2.TabIndex = 13
        Me.picGrade2.TabStop = False
        '
        'picLesser
        '
        Me.picLesser.Image = CType(resources.GetObject("picLesser.Image"), System.Drawing.Image)
        Me.picLesser.Location = New System.Drawing.Point(118, 36)
        Me.picLesser.Name = "picLesser"
        Me.picLesser.Size = New System.Drawing.Size(10, 10)
        Me.picLesser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLesser.TabIndex = 12
        Me.picLesser.TabStop = False
        Me.picLesser.Visible = False
        '
        'picGreater
        '
        Me.picGreater.Image = CType(resources.GetObject("picGreater.Image"), System.Drawing.Image)
        Me.picGreater.Location = New System.Drawing.Point(98, 36)
        Me.picGreater.Name = "picGreater"
        Me.picGreater.Size = New System.Drawing.Size(10, 10)
        Me.picGreater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGreater.TabIndex = 15
        Me.picGreater.TabStop = False
        Me.picGreater.Visible = False
        '
        'picGrade1
        '
        Me.picGrade1.Image = CType(resources.GetObject("picGrade1.Image"), System.Drawing.Image)
        Me.picGrade1.Location = New System.Drawing.Point(98, 2)
        Me.picGrade1.Name = "picGrade1"
        Me.picGrade1.Size = New System.Drawing.Size(30, 30)
        Me.picGrade1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrade1.TabIndex = 14
        Me.picGrade1.TabStop = False
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(12, 31)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.ReadOnly = True
        Me.txtAverage.Size = New System.Drawing.Size(50, 20)
        Me.txtAverage.TabIndex = 10
        Me.txtAverage.TabStop = False
        Me.txtAverage.Text = "75.00"
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(12, 56)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(50, 20)
        Me.txtNumber2.TabIndex = 11
        Me.txtNumber2.Text = "50.00"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(12, 7)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(50, 20)
        Me.txtNumber1.TabIndex = 7
        Me.txtNumber1.Text = "100.00"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(65, 31)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(20, 20)
        Me.lblAverage.TabIndex = 8
        Me.lblAverage.Text = "C"
        '
        'lblLetter2
        '
        Me.lblLetter2.AutoSize = True
        Me.lblLetter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter2.Location = New System.Drawing.Point(65, 54)
        Me.lblLetter2.Name = "lblLetter2"
        Me.lblLetter2.Size = New System.Drawing.Size(19, 20)
        Me.lblLetter2.TabIndex = 9
        Me.lblLetter2.Text = "F"
        '
        'lblLetter1
        '
        Me.lblLetter1.AutoSize = True
        Me.lblLetter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetter1.Location = New System.Drawing.Point(65, 5)
        Me.lblLetter1.Name = "lblLetter1"
        Me.lblLetter1.Size = New System.Drawing.Size(29, 20)
        Me.lblLetter1.TabIndex = 6
        Me.lblLetter1.Text = "A+"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(141, 91)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picGrade2)
        Me.Controls.Add(Me.picLesser)
        Me.Controls.Add(Me.picGreater)
        Me.Controls.Add(Me.picGrade1)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblLetter2)
        Me.Controls.Add(Me.lblLetter1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Grade Calculator With Functions"
        CType(Me.picGrade2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLesser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrade1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picGrade2 As System.Windows.Forms.PictureBox
    Friend WithEvents picLesser As System.Windows.Forms.PictureBox
    Friend WithEvents picGreater As System.Windows.Forms.PictureBox
    Friend WithEvents picGrade1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblLetter2 As System.Windows.Forms.Label
    Friend WithEvents lblLetter1 As System.Windows.Forms.Label

End Class
