<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPixelPatterns
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtBlockHeight = New System.Windows.Forms.TextBox()
        Me.txtBlockWidth = New System.Windows.Forms.TextBox()
        Me.txtBlocksWide = New System.Windows.Forms.TextBox()
        Me.txtBlocksTall = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(12, 116)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(100, 20)
        Me.btnGo.TabIndex = 5
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtBlockHeight
        '
        Me.txtBlockHeight.Location = New System.Drawing.Point(12, 12)
        Me.txtBlockHeight.Name = "txtBlockHeight"
        Me.txtBlockHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtBlockHeight.TabIndex = 1
        Me.txtBlockHeight.Text = "Block Height"
        '
        'txtBlockWidth
        '
        Me.txtBlockWidth.Location = New System.Drawing.Point(12, 38)
        Me.txtBlockWidth.Name = "txtBlockWidth"
        Me.txtBlockWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtBlockWidth.TabIndex = 2
        Me.txtBlockWidth.Text = "Block Width"
        '
        'txtBlocksWide
        '
        Me.txtBlocksWide.Location = New System.Drawing.Point(12, 64)
        Me.txtBlocksWide.Name = "txtBlocksWide"
        Me.txtBlocksWide.Size = New System.Drawing.Size(100, 20)
        Me.txtBlocksWide.TabIndex = 3
        Me.txtBlocksWide.Text = "Blocks Wide"
        '
        'txtBlocksTall
        '
        Me.txtBlocksTall.Location = New System.Drawing.Point(12, 90)
        Me.txtBlocksTall.Name = "txtBlocksTall"
        Me.txtBlocksTall.Size = New System.Drawing.Size(100, 20)
        Me.txtBlocksTall.TabIndex = 4
        Me.txtBlocksTall.Text = "Blocks Tall"
        '
        'frmPixelPatterns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(124, 146)
        Me.Controls.Add(Me.txtBlocksTall)
        Me.Controls.Add(Me.txtBlocksWide)
        Me.Controls.Add(Me.txtBlockWidth)
        Me.Controls.Add(Me.txtBlockHeight)
        Me.Controls.Add(Me.btnGo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPixelPatterns"
        Me.Text = "Pixel Patterns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtBlockHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtBlockWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtBlocksWide As System.Windows.Forms.TextBox
    Friend WithEvents txtBlocksTall As System.Windows.Forms.TextBox

End Class
