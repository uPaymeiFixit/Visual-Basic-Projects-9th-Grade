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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cboVeggiesComboBox = New System.Windows.Forms.ComboBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnIndex = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(12, 9)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(121, 25)
        Me.lblOutput.TabIndex = 0
        '
        'cboVeggiesComboBox
        '
        Me.cboVeggiesComboBox.FormattingEnabled = True
        Me.cboVeggiesComboBox.Items.AddRange(New Object() {"Carrots", "Beans", "Spinich"})
        Me.cboVeggiesComboBox.Location = New System.Drawing.Point(12, 37)
        Me.cboVeggiesComboBox.Name = "cboVeggiesComboBox"
        Me.cboVeggiesComboBox.Size = New System.Drawing.Size(121, 21)
        Me.cboVeggiesComboBox.TabIndex = 1
        Me.cboVeggiesComboBox.Text = "My Veggies"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(12, 64)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(121, 23)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 93)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(121, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnIndex
        '
        Me.btnIndex.Location = New System.Drawing.Point(155, 9)
        Me.btnIndex.Name = "btnIndex"
        Me.btnIndex.Size = New System.Drawing.Size(75, 23)
        Me.btnIndex.TabIndex = 4
        Me.btnIndex.Text = "Index"
        Me.btnIndex.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 167)
        Me.Controls.Add(Me.btnIndex)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.cboVeggiesComboBox)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "frmMain"
        Me.Text = "How to do a combo box"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents cboVeggiesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnIndex As System.Windows.Forms.Button

End Class
