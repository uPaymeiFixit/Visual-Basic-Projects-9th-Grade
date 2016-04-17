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
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radXXL = New System.Windows.Forms.RadioButton()
        Me.radXLarge = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.chkMonogram = New System.Windows.Forms.CheckBox()
        Me.chkShirtPocket = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClearItem = New System.Windows.Forms.Button()
        Me.btnCompleteOrder = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTotalOrderPrice = New System.Windows.Forms.Label()
        Me.lblShirtPrice = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(89, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.Location = New System.Drawing.Point(89, 76)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderNumber.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(89, 102)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radXXL)
        Me.GroupBox1.Controls.Add(Me.radXLarge)
        Me.GroupBox1.Controls.Add(Me.radLarge)
        Me.GroupBox1.Controls.Add(Me.radMedium)
        Me.GroupBox1.Controls.Add(Me.radSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(80, 138)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shirt Sizes"
        '
        'radXXL
        '
        Me.radXXL.AutoSize = True
        Me.radXXL.Location = New System.Drawing.Point(6, 112)
        Me.radXXL.Name = "radXXL"
        Me.radXXL.Size = New System.Drawing.Size(45, 17)
        Me.radXXL.TabIndex = 8
        Me.radXXL.Text = "XXL"
        Me.radXXL.UseVisualStyleBackColor = True
        '
        'radXLarge
        '
        Me.radXLarge.AutoSize = True
        Me.radXLarge.Location = New System.Drawing.Point(6, 89)
        Me.radXLarge.Name = "radXLarge"
        Me.radXLarge.Size = New System.Drawing.Size(62, 17)
        Me.radXLarge.TabIndex = 7
        Me.radXLarge.Text = "X Large"
        Me.radXLarge.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 66)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 6
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(6, 43)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 5
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(7, 20)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 4
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'chkMonogram
        '
        Me.chkMonogram.AutoSize = True
        Me.chkMonogram.Location = New System.Drawing.Point(6, 19)
        Me.chkMonogram.Name = "chkMonogram"
        Me.chkMonogram.Size = New System.Drawing.Size(76, 17)
        Me.chkMonogram.TabIndex = 9
        Me.chkMonogram.Text = "Monogram"
        Me.chkMonogram.UseVisualStyleBackColor = True
        '
        'chkShirtPocket
        '
        Me.chkShirtPocket.AutoSize = True
        Me.chkShirtPocket.Location = New System.Drawing.Point(6, 42)
        Me.chkShirtPocket.Name = "chkShirtPocket"
        Me.chkShirtPocket.Size = New System.Drawing.Size(84, 17)
        Me.chkShirtPocket.TabIndex = 10
        Me.chkShirtPocket.Text = "Shirt Pocket"
        Me.chkShirtPocket.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkShirtPocket)
        Me.GroupBox2.Controls.Add(Me.chkMonogram)
        Me.GroupBox2.Location = New System.Drawing.Point(303, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 68)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shirt Options"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(303, 144)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(42, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClearItem
        '
        Me.btnClearItem.Location = New System.Drawing.Point(351, 144)
        Me.btnClearItem.Name = "btnClearItem"
        Me.btnClearItem.Size = New System.Drawing.Size(65, 23)
        Me.btnClearItem.TabIndex = 12
        Me.btnClearItem.Text = "Clear Item"
        Me.btnClearItem.UseVisualStyleBackColor = True
        '
        'btnCompleteOrder
        '
        Me.btnCompleteOrder.Location = New System.Drawing.Point(303, 172)
        Me.btnCompleteOrder.Name = "btnCompleteOrder"
        Me.btnCompleteOrder.Size = New System.Drawing.Size(113, 23)
        Me.btnCompleteOrder.TabIndex = 13
        Me.btnCompleteOrder.Text = "Complete Order"
        Me.btnCompleteOrder.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Enabled = False
        Me.btnSummary.Location = New System.Drawing.Point(303, 201)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(113, 23)
        Me.btnSummary.TabIndex = 14
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 201)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Order Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quantity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblQuantity)
        Me.GroupBox3.Controls.Add(Me.lblTotalOrderPrice)
        Me.GroupBox3.Controls.Add(Me.lblShirtPrice)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 86)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Summary"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Current Total Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Quantity of Shirts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Selected Shirt Price"
        '
        'lblQuantity
        '
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuantity.Location = New System.Drawing.Point(113, 41)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(50, 15)
        Me.lblQuantity.TabIndex = 0
        '
        'lblTotalOrderPrice
        '
        Me.lblTotalOrderPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOrderPrice.Location = New System.Drawing.Point(113, 62)
        Me.lblTotalOrderPrice.Name = "lblTotalOrderPrice"
        Me.lblTotalOrderPrice.Size = New System.Drawing.Size(50, 15)
        Me.lblTotalOrderPrice.TabIndex = 0
        '
        'lblShirtPrice
        '
        Me.lblShirtPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShirtPrice.Location = New System.Drawing.Point(113, 20)
        Me.lblShirtPrice.Name = "lblShirtPrice"
        Me.lblShirtPrice.Size = New System.Drawing.Size(50, 15)
        Me.lblShirtPrice.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(107, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 33)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Very Very Boards"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Location = New System.Drawing.Point(-3, -2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Josh Gibbs"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 232)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnCompleteOrder)
        Me.Controls.Add(Me.btnClearItem)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.txtName)
        Me.Name = "frmMain"
        Me.Text = "T-Shirt Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtOrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radXLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents radXXL As System.Windows.Forms.RadioButton
    Friend WithEvents chkMonogram As System.Windows.Forms.CheckBox
    Friend WithEvents chkShirtPocket As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClearItem As System.Windows.Forms.Button
    Friend WithEvents btnCompleteOrder As System.Windows.Forms.Button
    Friend WithEvents btnSummary As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblTotalOrderPrice As System.Windows.Forms.Label
    Friend WithEvents lblShirtPrice As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
