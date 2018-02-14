<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCookies
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
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.radPeanutButter = New System.Windows.Forms.RadioButton()
        Me.radOatmeal = New System.Windows.Forms.RadioButton()
        Me.radChocChip = New System.Windows.Forms.RadioButton()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.radPeanutButter)
        Me.grpChoices.Controls.Add(Me.radOatmeal)
        Me.grpChoices.Controls.Add(Me.radChocChip)
        Me.grpChoices.Location = New System.Drawing.Point(146, 12)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(138, 185)
        Me.grpChoices.TabIndex = 0
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Your Choices"
        '
        'radPeanutButter
        '
        Me.radPeanutButter.AutoSize = True
        Me.radPeanutButter.Location = New System.Drawing.Point(11, 145)
        Me.radPeanutButter.Name = "radPeanutButter"
        Me.radPeanutButter.Size = New System.Drawing.Size(90, 17)
        Me.radPeanutButter.TabIndex = 2
        Me.radPeanutButter.TabStop = True
        Me.radPeanutButter.Text = "Peanut Butter"
        Me.radPeanutButter.UseVisualStyleBackColor = True
        '
        'radOatmeal
        '
        Me.radOatmeal.AutoSize = True
        Me.radOatmeal.Location = New System.Drawing.Point(11, 90)
        Me.radOatmeal.Name = "radOatmeal"
        Me.radOatmeal.Size = New System.Drawing.Size(96, 17)
        Me.radOatmeal.TabIndex = 1
        Me.radOatmeal.TabStop = True
        Me.radOatmeal.Text = "Oatmeal Raisin"
        Me.radOatmeal.UseVisualStyleBackColor = True
        '
        'radChocChip
        '
        Me.radChocChip.AutoSize = True
        Me.radChocChip.Location = New System.Drawing.Point(11, 29)
        Me.radChocChip.Name = "radChocChip"
        Me.radChocChip.Size = New System.Drawing.Size(97, 17)
        Me.radChocChip.TabIndex = 0
        Me.radChocChip.TabStop = True
        Me.radChocChip.Text = "Chocolate Chip"
        Me.radChocChip.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(62, 215)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(305, 38)
        Me.btnOrder.TabIndex = 1
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblChoice
        '
        Me.lblChoice.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice.Location = New System.Drawing.Point(62, 269)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(305, 126)
        Me.lblChoice.TabIndex = 2
        Me.lblChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCookies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 430)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.grpChoices)
        Me.Name = "frmCookies"
        Me.Text = "Cookie Shop"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox
    Friend WithEvents radPeanutButter As System.Windows.Forms.RadioButton
    Friend WithEvents radOatmeal As System.Windows.Forms.RadioButton
    Friend WithEvents radChocChip As System.Windows.Forms.RadioButton
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblChoice As System.Windows.Forms.Label

End Class
