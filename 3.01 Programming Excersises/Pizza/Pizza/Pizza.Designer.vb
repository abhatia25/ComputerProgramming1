<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza
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
        Me.lblChoice1 = New System.Windows.Forms.Label()
        Me.lblChoice2 = New System.Windows.Forms.Label()
        Me.lblChoice3 = New System.Windows.Forms.Label()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChoice1
        '
        Me.lblChoice1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice1.Location = New System.Drawing.Point(8, 185)
        Me.lblChoice1.Name = "lblChoice1"
        Me.lblChoice1.Size = New System.Drawing.Size(271, 29)
        Me.lblChoice1.TabIndex = 0
        Me.lblChoice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChoice2
        '
        Me.lblChoice2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice2.Location = New System.Drawing.Point(8, 214)
        Me.lblChoice2.Name = "lblChoice2"
        Me.lblChoice2.Size = New System.Drawing.Size(271, 29)
        Me.lblChoice2.TabIndex = 1
        Me.lblChoice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChoice3
        '
        Me.lblChoice3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice3.Location = New System.Drawing.Point(8, 243)
        Me.lblChoice3.Name = "lblChoice3"
        Me.lblChoice3.Size = New System.Drawing.Size(271, 29)
        Me.lblChoice3.TabIndex = 2
        Me.lblChoice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.chkMushrooms)
        Me.grpChoices.Controls.Add(Me.chkCheese)
        Me.grpChoices.Controls.Add(Me.chkPepperoni)
        Me.grpChoices.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpChoices.Location = New System.Drawing.Point(92, 12)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(129, 161)
        Me.grpChoices.TabIndex = 3
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Your Choices"
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMushrooms.Location = New System.Drawing.Point(4, 131)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(119, 24)
        Me.chkMushrooms.TabIndex = 2
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheese.Location = New System.Drawing.Point(4, 83)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(83, 24)
        Me.chkCheese.TabIndex = 1
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPepperoni.Location = New System.Drawing.Point(4, 38)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(106, 24)
        Me.chkPepperoni.TabIndex = 0
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(227, 77)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(11, 77)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 293)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpChoices)
        Me.Controls.Add(Me.lblChoice3)
        Me.Controls.Add(Me.lblChoice2)
        Me.Controls.Add(Me.lblChoice1)
        Me.Name = "frmPizza"
        Me.Text = "Your Pizza"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblChoice1 As System.Windows.Forms.Label
    Friend WithEvents lblChoice2 As System.Windows.Forms.Label
    Friend WithEvents lblChoice3 As System.Windows.Forms.Label
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
