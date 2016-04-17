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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.btnShowCode = New System.Windows.Forms.Button()
        Me.lblYou = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpLineBad = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.shpLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.tmrCheckForCheat = New System.Windows.Forms.Timer(Me.components)
        Me.lblKeepAway = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AllowDrop = True
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.DarkGray
        Me.lblInstruction.Location = New System.Drawing.Point(8, 9)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(268, 183)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = resources.GetString("lblInstruction.Text")
        '
        'btnShowCode
        '
        Me.btnShowCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowCode.ForeColor = System.Drawing.Color.DarkGray
        Me.btnShowCode.Location = New System.Drawing.Point(12, 197)
        Me.btnShowCode.Name = "btnShowCode"
        Me.btnShowCode.Size = New System.Drawing.Size(178, 54)
        Me.btnShowCode.TabIndex = 1
        Me.btnShowCode.Text = "Show Code"
        Me.btnShowCode.UseVisualStyleBackColor = True
        '
        'lblYou
        '
        Me.lblYou.BackColor = System.Drawing.Color.Blue
        Me.lblYou.Location = New System.Drawing.Point(489, 209)
        Me.lblYou.Name = "lblYou"
        Me.lblYou.Size = New System.Drawing.Size(30, 30)
        Me.lblYou.TabIndex = 2
        '
        'lblTarget
        '
        Me.lblTarget.BackColor = System.Drawing.Color.Lime
        Me.lblTarget.Location = New System.Drawing.Point(525, 219)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(10, 10)
        Me.lblTarget.TabIndex = 2
        '
        'lblPoints
        '
        Me.lblPoints.AllowDrop = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPoints.Location = New System.Drawing.Point(200, 197)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(71, 37)
        Me.lblPoints.TabIndex = 0
        Me.lblPoints.Text = "Points:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        '
        'lblDivider
        '
        Me.lblDivider.AllowDrop = True
        Me.lblDivider.BackColor = System.Drawing.Color.Black
        Me.lblDivider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivider.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDivider.Location = New System.Drawing.Point(277, -5)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(3, 275)
        Me.lblDivider.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpLineBad, Me.shpLine})
        Me.ShapeContainer1.Size = New System.Drawing.Size(697, 262)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'shpLineBad
        '
        Me.shpLineBad.BorderColor = System.Drawing.Color.Red
        Me.shpLineBad.Cursor = System.Windows.Forms.Cursors.Default
        Me.shpLineBad.Name = "shpLineBad"
        Me.shpLineBad.SelectionColor = System.Drawing.Color.White
        Me.shpLineBad.X1 = 508
        Me.shpLineBad.X2 = 529
        Me.shpLineBad.Y1 = 222
        Me.shpLineBad.Y2 = 205
        '
        'shpLine
        '
        Me.shpLine.BorderColor = System.Drawing.Color.Lime
        Me.shpLine.Name = "shpLine"
        Me.shpLine.SelectionColor = System.Drawing.Color.White
        Me.shpLine.X1 = 504
        Me.shpLine.X2 = 530
        Me.shpLine.Y1 = 224
        Me.shpLine.Y2 = 224
        '
        'tmrCheckForCheat
        '
        Me.tmrCheckForCheat.Enabled = True
        Me.tmrCheckForCheat.Interval = 1000
        '
        'lblKeepAway
        '
        Me.lblKeepAway.BackColor = System.Drawing.Color.Red
        Me.lblKeepAway.Location = New System.Drawing.Point(525, 202)
        Me.lblKeepAway.Name = "lblKeepAway"
        Me.lblKeepAway.Size = New System.Drawing.Size(10, 10)
        Me.lblKeepAway.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 262)
        Me.Controls.Add(Me.lblKeepAway)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.lblYou)
        Me.Controls.Add(Me.btnShowCode)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.Text = "CHEAT - It's the only way..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents btnShowCode As System.Windows.Forms.Button
    Friend WithEvents lblYou As System.Windows.Forms.Label
    Friend WithEvents lblTarget As System.Windows.Forms.Label
    Friend WithEvents lblPoints As System.Windows.Forms.Label
    Friend WithEvents lblDivider As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shpLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tmrCheckForCheat As System.Windows.Forms.Timer
    Friend WithEvents shpLineBad As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblKeepAway As System.Windows.Forms.Label

End Class
