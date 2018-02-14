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
        Me.grpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkPineapple = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.grpSides = New System.Windows.Forms.GroupBox()
        Me.chkBreadSticks = New System.Windows.Forms.CheckBox()
        Me.chkCheeseFries = New System.Windows.Forms.CheckBox()
        Me.chkCoke = New System.Windows.Forms.CheckBox()
        Me.chkCookie = New System.Windows.Forms.CheckBox()
        Me.grpSandwiches = New System.Windows.Forms.GroupBox()
        Me.chkItalianSub = New System.Windows.Forms.CheckBox()
        Me.chkTunaSub = New System.Windows.Forms.CheckBox()
        Me.chkChickenParm = New System.Windows.Forms.CheckBox()
        Me.chkMeatBallParm = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPizzaPrice = New System.Windows.Forms.Label()
        Me.grpPizzaSize.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.grpSides.SuspendLayout()
        Me.grpSandwiches.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPizzaSize
        '
        Me.grpPizzaSize.Controls.Add(Me.radLarge)
        Me.grpPizzaSize.Controls.Add(Me.radRegular)
        Me.grpPizzaSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPizzaSize.Location = New System.Drawing.Point(57, 57)
        Me.grpPizzaSize.Name = "grpPizzaSize"
        Me.grpPizzaSize.Size = New System.Drawing.Size(209, 100)
        Me.grpPizzaSize.TabIndex = 0
        Me.grpPizzaSize.TabStop = False
        Me.grpPizzaSize.Text = "Select Pizza Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLarge.Location = New System.Drawing.Point(129, 41)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 1
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Checked = True
        Me.radRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRegular.Location = New System.Drawing.Point(18, 41)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(62, 17)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkPineapple)
        Me.grpToppings.Controls.Add(Me.chkOnions)
        Me.grpToppings.Controls.Add(Me.chkMushrooms)
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpToppings.Location = New System.Drawing.Point(57, 187)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(209, 100)
        Me.grpToppings.TabIndex = 0
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Select Toppings"
        '
        'chkPineapple
        '
        Me.chkPineapple.AutoSize = True
        Me.chkPineapple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPineapple.Location = New System.Drawing.Point(122, 68)
        Me.chkPineapple.Name = "chkPineapple"
        Me.chkPineapple.Size = New System.Drawing.Size(73, 17)
        Me.chkPineapple.TabIndex = 3
        Me.chkPineapple.Text = "Pineapple"
        Me.chkPineapple.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnions.Location = New System.Drawing.Point(122, 19)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(59, 17)
        Me.chkOnions.TabIndex = 2
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMushrooms.Location = New System.Drawing.Point(6, 68)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(80, 17)
        Me.chkMushrooms.TabIndex = 1
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPepperoni.Location = New System.Drawing.Point(6, 19)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chkPepperoni.TabIndex = 0
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'grpSides
        '
        Me.grpSides.Controls.Add(Me.chkBreadSticks)
        Me.grpSides.Controls.Add(Me.chkCheeseFries)
        Me.grpSides.Controls.Add(Me.chkCoke)
        Me.grpSides.Controls.Add(Me.chkCookie)
        Me.grpSides.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSides.Location = New System.Drawing.Point(57, 328)
        Me.grpSides.Name = "grpSides"
        Me.grpSides.Size = New System.Drawing.Size(209, 100)
        Me.grpSides.TabIndex = 0
        Me.grpSides.TabStop = False
        Me.grpSides.Text = "Select Sides"
        '
        'chkBreadSticks
        '
        Me.chkBreadSticks.AutoSize = True
        Me.chkBreadSticks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBreadSticks.Location = New System.Drawing.Point(117, 77)
        Me.chkBreadSticks.Name = "chkBreadSticks"
        Me.chkBreadSticks.Size = New System.Drawing.Size(86, 17)
        Me.chkBreadSticks.TabIndex = 3
        Me.chkBreadSticks.Text = "Bread Sticks"
        Me.chkBreadSticks.UseVisualStyleBackColor = True
        '
        'chkCheeseFries
        '
        Me.chkCheeseFries.AutoSize = True
        Me.chkCheeseFries.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheeseFries.Location = New System.Drawing.Point(116, 16)
        Me.chkCheeseFries.Name = "chkCheeseFries"
        Me.chkCheeseFries.Size = New System.Drawing.Size(87, 17)
        Me.chkCheeseFries.TabIndex = 2
        Me.chkCheeseFries.Text = "Cheese Fries"
        Me.chkCheeseFries.UseVisualStyleBackColor = True
        '
        'chkCoke
        '
        Me.chkCoke.AutoSize = True
        Me.chkCoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCoke.Location = New System.Drawing.Point(6, 77)
        Me.chkCoke.Name = "chkCoke"
        Me.chkCoke.Size = New System.Drawing.Size(51, 17)
        Me.chkCoke.TabIndex = 1
        Me.chkCoke.Text = "Coke"
        Me.chkCoke.UseVisualStyleBackColor = True
        '
        'chkCookie
        '
        Me.chkCookie.AutoSize = True
        Me.chkCookie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCookie.Location = New System.Drawing.Point(6, 16)
        Me.chkCookie.Name = "chkCookie"
        Me.chkCookie.Size = New System.Drawing.Size(59, 17)
        Me.chkCookie.TabIndex = 0
        Me.chkCookie.Text = "Cookie"
        Me.chkCookie.UseVisualStyleBackColor = True
        '
        'grpSandwiches
        '
        Me.grpSandwiches.Controls.Add(Me.chkItalianSub)
        Me.grpSandwiches.Controls.Add(Me.chkTunaSub)
        Me.grpSandwiches.Controls.Add(Me.chkChickenParm)
        Me.grpSandwiches.Controls.Add(Me.chkMeatBallParm)
        Me.grpSandwiches.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSandwiches.Location = New System.Drawing.Point(57, 465)
        Me.grpSandwiches.Name = "grpSandwiches"
        Me.grpSandwiches.Size = New System.Drawing.Size(209, 100)
        Me.grpSandwiches.TabIndex = 0
        Me.grpSandwiches.TabStop = False
        Me.grpSandwiches.Text = "Select Sandwiches"
        '
        'chkItalianSub
        '
        Me.chkItalianSub.AutoSize = True
        Me.chkItalianSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalianSub.Location = New System.Drawing.Point(122, 77)
        Me.chkItalianSub.Name = "chkItalianSub"
        Me.chkItalianSub.Size = New System.Drawing.Size(76, 17)
        Me.chkItalianSub.TabIndex = 3
        Me.chkItalianSub.Text = "Italian Sub"
        Me.chkItalianSub.UseVisualStyleBackColor = True
        '
        'chkTunaSub
        '
        Me.chkTunaSub.AutoSize = True
        Me.chkTunaSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTunaSub.Location = New System.Drawing.Point(122, 19)
        Me.chkTunaSub.Name = "chkTunaSub"
        Me.chkTunaSub.Size = New System.Drawing.Size(73, 17)
        Me.chkTunaSub.TabIndex = 2
        Me.chkTunaSub.Text = "Tuna Sub"
        Me.chkTunaSub.UseVisualStyleBackColor = True
        '
        'chkChickenParm
        '
        Me.chkChickenParm.AutoSize = True
        Me.chkChickenParm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChickenParm.Location = New System.Drawing.Point(6, 77)
        Me.chkChickenParm.Name = "chkChickenParm"
        Me.chkChickenParm.Size = New System.Drawing.Size(92, 17)
        Me.chkChickenParm.TabIndex = 1
        Me.chkChickenParm.Text = "Chicken Parm"
        Me.chkChickenParm.UseVisualStyleBackColor = True
        '
        'chkMeatBallParm
        '
        Me.chkMeatBallParm.AutoSize = True
        Me.chkMeatBallParm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMeatBallParm.Location = New System.Drawing.Point(6, 19)
        Me.chkMeatBallParm.Name = "chkMeatBallParm"
        Me.chkMeatBallParm.Size = New System.Drawing.Size(93, 17)
        Me.chkMeatBallParm.TabIndex = 0
        Me.chkMeatBallParm.Text = "Meatball Parm"
        Me.chkMeatBallParm.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(65, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(196, 24)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Pizza Order Form"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(68, 597)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 2
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewOrder.Location = New System.Drawing.Point(179, 597)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnNewOrder.TabIndex = 3
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(83, 640)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(0, 13)
        Me.lblOrder.TabIndex = 4
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNumber.Location = New System.Drawing.Point(83, 688)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblOrderNumber.TabIndex = 5
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(199, 640)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 6
        '
        'lblPizzaPrice
        '
        Me.lblPizzaPrice.AutoSize = True
        Me.lblPizzaPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaPrice.Location = New System.Drawing.Point(199, 688)
        Me.lblPizzaPrice.Name = "lblPizzaPrice"
        Me.lblPizzaPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPizzaPrice.TabIndex = 7
        '
        'frmPizzaOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(343, 719)
        Me.Controls.Add(Me.lblPizzaPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.grpSandwiches)
        Me.Controls.Add(Me.grpSides)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpPizzaSize)
        Me.Name = "frmPizzaOrder"
        Me.Text = "Pizza Order"
        Me.grpPizzaSize.ResumeLayout(False)
        Me.grpPizzaSize.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.grpSides.ResumeLayout(False)
        Me.grpSides.PerformLayout()
        Me.grpSandwiches.ResumeLayout(False)
        Me.grpSandwiches.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPizzaSize As System.Windows.Forms.GroupBox
    Friend WithEvents grpToppings As System.Windows.Forms.GroupBox
    Friend WithEvents grpSides As System.Windows.Forms.GroupBox
    Friend WithEvents grpSandwiches As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents chkPineapple As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkCookie As System.Windows.Forms.CheckBox
    Friend WithEvents chkCoke As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheeseFries As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreadSticks As System.Windows.Forms.CheckBox
    Friend WithEvents chkMeatBallParm As System.Windows.Forms.CheckBox
    Friend WithEvents chkChickenParm As System.Windows.Forms.CheckBox
    Friend WithEvents chkTunaSub As System.Windows.Forms.CheckBox
    Friend WithEvents chkItalianSub As System.Windows.Forms.CheckBox
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblPizzaPrice As System.Windows.Forms.Label

End Class
