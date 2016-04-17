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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.btnFrench = New System.Windows.Forms.Button()
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnPolish = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(3, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(50, 13)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Goodbye"
        '
        'btnSpanish
        '
        Me.btnSpanish.Location = New System.Drawing.Point(87, 4)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(75, 23)
        Me.btnSpanish.TabIndex = 1
        Me.btnSpanish.Text = "Español"
        Me.btnSpanish.UseVisualStyleBackColor = True
        '
        'btnFrench
        '
        Me.btnFrench.Location = New System.Drawing.Point(87, 33)
        Me.btnFrench.Name = "btnFrench"
        Me.btnFrench.Size = New System.Drawing.Size(75, 23)
        Me.btnFrench.TabIndex = 2
        Me.btnFrench.Text = "Français"
        Me.btnFrench.UseVisualStyleBackColor = True
        '
        'btnItalian
        '
        Me.btnItalian.Location = New System.Drawing.Point(87, 61)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Size = New System.Drawing.Size(75, 23)
        Me.btnItalian.TabIndex = 3
        Me.btnItalian.Text = "Italiano"
        Me.btnItalian.UseVisualStyleBackColor = True
        '
        'btnPolish
        '
        Me.btnPolish.Location = New System.Drawing.Point(87, 90)
        Me.btnPolish.Name = "btnPolish"
        Me.btnPolish.Size = New System.Drawing.Size(75, 23)
        Me.btnPolish.TabIndex = 4
        Me.btnPolish.Text = "Polski"
        Me.btnPolish.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(6, 33)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(6, 62)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(3, 100)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 13)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Josh Gibbs"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Goodbye.My.Resources.Resources.picHappy
        Me.PictureBox1.Location = New System.Drawing.Point(168, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 120)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPolish)
        Me.Controls.Add(Me.btnItalian)
        Me.Controls.Add(Me.btnFrench)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmMain"
        Me.Text = "Say Goodbye"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnSpanish As System.Windows.Forms.Button
    Friend WithEvents btnFrench As System.Windows.Forms.Button
    Friend WithEvents btnItalian As System.Windows.Forms.Button
    Friend WithEvents btnPolish As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
