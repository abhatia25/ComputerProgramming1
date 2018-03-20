<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuperSize
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radSuperSize = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.grpFoodChoice = New System.Windows.Forms.GroupBox()
        Me.chkOnionRings = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkCheeseburger = New System.Windows.Forms.CheckBox()
        Me.chkHamburger = New System.Windows.Forms.CheckBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpSize.SuspendLayout()
        Me.grpFoodChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(224, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radSuperSize)
        Me.grpSize.Controls.Add(Me.radRegular)
        Me.grpSize.Location = New System.Drawing.Point(12, 46)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(200, 100)
        Me.grpSize.TabIndex = 1
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Choose"
        '
        'radSuperSize
        '
        Me.radSuperSize.AutoSize = True
        Me.radSuperSize.Location = New System.Drawing.Point(55, 67)
        Me.radSuperSize.Name = "radSuperSize"
        Me.radSuperSize.Size = New System.Drawing.Size(73, 17)
        Me.radSuperSize.TabIndex = 1
        Me.radSuperSize.TabStop = True
        Me.radSuperSize.Text = "SuperSize"
        Me.radSuperSize.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(55, 19)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(62, 17)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'grpFoodChoice
        '
        Me.grpFoodChoice.Controls.Add(Me.chkOnionRings)
        Me.grpFoodChoice.Controls.Add(Me.chkFries)
        Me.grpFoodChoice.Controls.Add(Me.chkCheeseburger)
        Me.grpFoodChoice.Controls.Add(Me.chkHamburger)
        Me.grpFoodChoice.Location = New System.Drawing.Point(12, 152)
        Me.grpFoodChoice.Name = "grpFoodChoice"
        Me.grpFoodChoice.Size = New System.Drawing.Size(200, 100)
        Me.grpFoodChoice.TabIndex = 2
        Me.grpFoodChoice.TabStop = False
        Me.grpFoodChoice.Text = "Choose"
        '
        'chkOnionRings
        '
        Me.chkOnionRings.AutoSize = True
        Me.chkOnionRings.Location = New System.Drawing.Point(113, 77)
        Me.chkOnionRings.Name = "chkOnionRings"
        Me.chkOnionRings.Size = New System.Drawing.Size(84, 17)
        Me.chkOnionRings.TabIndex = 3
        Me.chkOnionRings.Text = "Onion Rings"
        Me.chkOnionRings.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(113, 16)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(48, 17)
        Me.chkFries.TabIndex = 2
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkCheeseburger
        '
        Me.chkCheeseburger.AutoSize = True
        Me.chkCheeseburger.Location = New System.Drawing.Point(6, 77)
        Me.chkCheeseburger.Name = "chkCheeseburger"
        Me.chkCheeseburger.Size = New System.Drawing.Size(92, 17)
        Me.chkCheeseburger.TabIndex = 1
        Me.chkCheeseburger.Text = "Cheeseburger"
        Me.chkCheeseburger.UseVisualStyleBackColor = True
        '
        'chkHamburger
        '
        Me.chkHamburger.AutoSize = True
        Me.chkHamburger.Location = New System.Drawing.Point(6, 16)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(78, 17)
        Me.chkHamburger.TabIndex = 0
        Me.chkHamburger.Text = "Hamburger"
        Me.chkHamburger.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(12, 258)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 3
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(28, 294)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCost.TabIndex = 4
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(134, 263)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblOrderNumber.TabIndex = 5
        '
        'frmSuperSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 316)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.grpFoodChoice)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSuperSize"
        Me.Text = "SuperSize"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpFoodChoice.ResumeLayout(False)
        Me.grpFoodChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents radSuperSize As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents grpFoodChoice As GroupBox
    Friend WithEvents chkOnionRings As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkCheeseburger As CheckBox
    Friend WithEvents chkHamburger As CheckBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblOrderNumber As Label
End Class
