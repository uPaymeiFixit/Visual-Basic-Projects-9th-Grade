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
        Me.tmrMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrNotification = New System.Windows.Forms.Timer(Me.components)
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.lblBumps = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFullscreen = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrMovement
        '
        Me.tmrMovement.Interval = 1
        '
        'tmrNotification
        '
        Me.tmrNotification.Interval = 1
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.BackColor = System.Drawing.Color.Black
        Me.lblNotification.ForeColor = System.Drawing.Color.White
        Me.lblNotification.Location = New System.Drawing.Point(74, -26)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(177, 26)
        Me.lblNotification.TabIndex = 4
        Me.lblNotification.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Press F11 or F to enter Fullscreen  "
        '
        'lblBumps
        '
        Me.lblBumps.AutoSize = True
        Me.lblBumps.BackColor = System.Drawing.Color.Cyan
        Me.lblBumps.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBumps.ForeColor = System.Drawing.Color.Black
        Me.lblBumps.Location = New System.Drawing.Point(0, 0)
        Me.lblBumps.Name = "lblBumps"
        Me.lblBumps.Size = New System.Drawing.Size(127, 126)
        Me.lblBumps.TabIndex = 3
        Me.lblBumps.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Bump Counts  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Left: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Right: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Top: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Bottom: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Cyan
        Me.btnAdd.Location = New System.Drawing.Point(3, 102)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(20, 20)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnFullscreen
        '
        Me.btnFullscreen.BackColor = System.Drawing.Color.Cyan
        Me.btnFullscreen.Location = New System.Drawing.Point(55, 102)
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(63, 20)
        Me.btnFullscreen.TabIndex = 5
        Me.btnFullscreen.Text = "Fullscreen"
        Me.btnFullscreen.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Cyan
        Me.btnRemove.Location = New System.Drawing.Point(29, 102)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(20, 20)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "-"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(304, 229)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnFullscreen)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblNotification)
        Me.Controls.Add(Me.lblBumps)
        Me.Name = "frmMain"
        Me.Text = "Fishrageous - Josh Gibbs"
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrMovement As System.Windows.Forms.Timer
    Friend WithEvents tmrNotification As System.Windows.Forms.Timer
    Friend WithEvents lblNotification As System.Windows.Forms.Label
    Friend WithEvents lblBumps As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnFullscreen As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button

End Class
