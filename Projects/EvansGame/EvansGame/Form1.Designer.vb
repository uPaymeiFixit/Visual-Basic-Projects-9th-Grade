<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblYou = New System.Windows.Forms.Label()
        Me.tmrMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCounter = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblYou
        '
        Me.lblYou.BackColor = System.Drawing.Color.Lime
        Me.lblYou.Location = New System.Drawing.Point(100, 115)
        Me.lblYou.Name = "lblYou"
        Me.lblYou.Size = New System.Drawing.Size(20, 20)
        Me.lblYou.TabIndex = 0
        '
        'tmrMovement
        '
        Me.tmrMovement.Enabled = True
        '
        'tmrCounter
        '
        Me.tmrCounter.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 270)
        Me.Controls.Add(Me.lblYou)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblYou As System.Windows.Forms.Label
    Friend WithEvents tmrMovement As System.Windows.Forms.Timer
    Friend WithEvents tmrCounter As System.Windows.Forms.Timer

End Class
