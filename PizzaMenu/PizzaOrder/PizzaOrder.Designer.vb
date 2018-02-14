<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaOrder
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
        Me.grpSauce = New System.Windows.Forms.GroupBox()
        Me.radSpicy = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radOrderPizza = New System.Windows.Forms.Button()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkPeppers = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picPizza = New System.Windows.Forms.PictureBox()
        Me.grpSauce.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSauce
        '
        Me.grpSauce.Controls.Add(Me.radSpicy)
        Me.grpSauce.Controls.Add(Me.radRegular)
        Me.grpSauce.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSauce.Location = New System.Drawing.Point(12, 128)
        Me.grpSauce.Name = "grpSauce"
        Me.grpSauce.Size = New System.Drawing.Size(257, 84)
        Me.grpSauce.TabIndex = 0
        Me.grpSauce.TabStop = False
        Me.grpSauce.Text = "Type of Sauce"
        '
        'radSpicy
        '
        Me.radSpicy.AutoSize = True
        Me.radSpicy.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSpicy.Location = New System.Drawing.Point(166, 39)
        Me.radSpicy.Name = "radSpicy"
        Me.radSpicy.Size = New System.Drawing.Size(87, 19)
        Me.radSpicy.TabIndex = 1
        Me.radSpicy.Text = "Spicy Sauce"
        Me.radSpicy.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Checked = True
        Me.radRegular.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRegular.Location = New System.Drawing.Point(6, 39)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(99, 19)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular Sauce"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radOrderPizza
        '
        Me.radOrderPizza.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOrderPizza.Location = New System.Drawing.Point(250, 403)
        Me.radOrderPizza.Name = "radOrderPizza"
        Me.radOrderPizza.Size = New System.Drawing.Size(75, 23)
        Me.radOrderPizza.TabIndex = 1
        Me.radOrderPizza.Text = "Order Pizza"
        Me.radOrderPizza.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Controls.Add(Me.chkMushrooms)
        Me.grpToppings.Controls.Add(Me.chkPeppers)
        Me.grpToppings.Controls.Add(Me.chkCheese)
        Me.grpToppings.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpToppings.Location = New System.Drawing.Point(268, 263)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(301, 100)
        Me.grpToppings.TabIndex = 2
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Toppings"
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPepperoni.Location = New System.Drawing.Point(178, 59)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(80, 19)
        Me.chkPepperoni.TabIndex = 3
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMushrooms.Location = New System.Drawing.Point(178, 22)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(90, 19)
        Me.chkMushrooms.TabIndex = 2
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkPeppers
        '
        Me.chkPeppers.AutoSize = True
        Me.chkPeppers.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPeppers.Location = New System.Drawing.Point(6, 59)
        Me.chkPeppers.Name = "chkPeppers"
        Me.chkPeppers.Size = New System.Drawing.Size(68, 19)
        Me.chkPeppers.TabIndex = 1
        Me.chkPeppers.Text = "Peppers"
        Me.chkPeppers.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheese.Location = New System.Drawing.Point(6, 22)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(64, 19)
        Me.chkCheese.TabIndex = 0
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.radDelivery)
        Me.grpDelivery.Controls.Add(Me.radPickup)
        Me.grpDelivery.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDelivery.Location = New System.Drawing.Point(329, 128)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(242, 84)
        Me.grpDelivery.TabIndex = 0
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery or Pickup"
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDelivery.Location = New System.Drawing.Point(173, 39)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(67, 19)
        Me.radDelivery.TabIndex = 1
        Me.radDelivery.Text = "Delivery"
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Checked = True
        Me.radPickup.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPickup.Location = New System.Drawing.Point(6, 39)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(61, 19)
        Me.radPickup.TabIndex = 0
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(174, 76)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(250, 21)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Please make your selections below"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'picPizza
        '
        Me.picPizza.Image = Global.WindowsApplication1.My.Resources.Resources.clipart_pizza_pizza_clip_art_pizza_images_for_teachers_educators_classroom_model_coloring_pages
        Me.picPizza.Location = New System.Drawing.Point(33, 239)
        Me.picPizza.Name = "picPizza"
        Me.picPizza.Size = New System.Drawing.Size(195, 143)
        Me.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizza.TabIndex = 5
        Me.picPizza.TabStop = False
        '
        'frmPizzaOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 452)
        Me.Controls.Add(Me.picPizza)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.radOrderPizza)
        Me.Controls.Add(Me.grpSauce)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPizzaOrder"
        Me.Text = "Pizza Order"
        Me.grpSauce.ResumeLayout(False)
        Me.grpSauce.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSauce As System.Windows.Forms.GroupBox
    Friend WithEvents radSpicy As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents radOrderPizza As System.Windows.Forms.Button
    Friend WithEvents grpToppings As System.Windows.Forms.GroupBox
    Friend WithEvents grpDelivery As System.Windows.Forms.GroupBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeppers As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents radDelivery As System.Windows.Forms.RadioButton
    Friend WithEvents radPickup As System.Windows.Forms.RadioButton
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picPizza As System.Windows.Forms.PictureBox

End Class
