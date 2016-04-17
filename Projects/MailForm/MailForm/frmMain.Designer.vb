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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(6, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(146, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "First Name"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(3, 197)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(128, 39)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "Josh Gibbs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2813 Wagon Wheel Way" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Troy, Ohio 45373"
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(6, 171)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(72, 23)
        Me.btnPush.TabIndex = 2
        Me.btnPush.Text = "Make Label"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(6, 38)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(146, 20)
        Me.txtLast.TabIndex = 3
        Me.txtLast.Text = "Last Name"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(6, 65)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(146, 20)
        Me.txtStreet.TabIndex = 4
        Me.txtStreet.Text = "Street"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(6, 92)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(146, 20)
        Me.txtCity.TabIndex = 5
        Me.txtCity.Text = "City"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(6, 119)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(146, 20)
        Me.txtState.TabIndex = 6
        Me.txtState.Text = "State"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(6, 145)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(146, 20)
        Me.txtZip.TabIndex = 7
        Me.txtZip.Text = "Zip Code"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(152, 26)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(0, 13)
        Me.lblStreet.TabIndex = 8
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(152, 43)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblLocation.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(137, 171)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(15, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(85, 171)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(46, 23)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Clear"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(158, 241)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Mailing Label"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents btnPush As System.Windows.Forms.Button
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
