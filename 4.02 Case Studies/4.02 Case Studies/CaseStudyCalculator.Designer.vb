<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaseStudyCalculator
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
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumberOfDigitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblOp1Prompt = New System.Windows.Forms.Label()
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.lblOp2Prompt = New System.Windows.Forms.Label()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.grpOperators = New System.Windows.Forms.GroupBox()
        Me.radExponentiation = New System.Windows.Forms.RadioButton()
        Me.radMultiplication = New System.Windows.Forms.RadioButton()
        Me.radDivision = New System.Windows.Forms.RadioButton()
        Me.radIntDivision = New System.Windows.Forms.RadioButton()
        Me.radModDivision = New System.Windows.Forms.RadioButton()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblExpressionValue = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OtherProgramsToolStripMenuItem
        '
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumberOfDigitsToolStripMenuItem, Me.ShellGameToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'NumberOfDigitsToolStripMenuItem
        '
        Me.NumberOfDigitsToolStripMenuItem.Name = "NumberOfDigitsToolStripMenuItem"
        Me.NumberOfDigitsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.NumberOfDigitsToolStripMenuItem.Text = "&Number of Digits"
        '
        'ShellGameToolStripMenuItem
        '
        Me.ShellGameToolStripMenuItem.Name = "ShellGameToolStripMenuItem"
        Me.ShellGameToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ShellGameToolStripMenuItem.Text = "&Shell Game"
        '
        'lblOp1Prompt
        '
        Me.lblOp1Prompt.Location = New System.Drawing.Point(12, 68)
        Me.lblOp1Prompt.Name = "lblOp1Prompt"
        Me.lblOp1Prompt.Size = New System.Drawing.Size(84, 20)
        Me.lblOp1Prompt.TabIndex = 1
        Me.lblOp1Prompt.Text = "First Operand:"
        Me.lblOp1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOperand1
        '
        Me.txtOperand1.Location = New System.Drawing.Point(102, 68)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(100, 20)
        Me.txtOperand1.TabIndex = 2
        '
        'lblOp2Prompt
        '
        Me.lblOp2Prompt.Location = New System.Drawing.Point(208, 68)
        Me.lblOp2Prompt.Name = "lblOp2Prompt"
        Me.lblOp2Prompt.Size = New System.Drawing.Size(94, 20)
        Me.lblOp2Prompt.TabIndex = 3
        Me.lblOp2Prompt.Text = "Second Operand:"
        Me.lblOp2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOperand2
        '
        Me.txtOperand2.Location = New System.Drawing.Point(308, 69)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(100, 20)
        Me.txtOperand2.TabIndex = 4
        '
        'grpOperators
        '
        Me.grpOperators.Controls.Add(Me.radSubtraction)
        Me.grpOperators.Controls.Add(Me.radAddition)
        Me.grpOperators.Controls.Add(Me.radModDivision)
        Me.grpOperators.Controls.Add(Me.radIntDivision)
        Me.grpOperators.Controls.Add(Me.radDivision)
        Me.grpOperators.Controls.Add(Me.radMultiplication)
        Me.grpOperators.Controls.Add(Me.radExponentiation)
        Me.grpOperators.Location = New System.Drawing.Point(15, 112)
        Me.grpOperators.Name = "grpOperators"
        Me.grpOperators.Size = New System.Drawing.Size(426, 208)
        Me.grpOperators.TabIndex = 5
        Me.grpOperators.TabStop = False
        Me.grpOperators.Text = "Select an Operator"
        '
        'radExponentiation
        '
        Me.radExponentiation.AutoSize = True
        Me.radExponentiation.Location = New System.Drawing.Point(6, 19)
        Me.radExponentiation.Name = "radExponentiation"
        Me.radExponentiation.Size = New System.Drawing.Size(31, 17)
        Me.radExponentiation.TabIndex = 0
        Me.radExponentiation.TabStop = True
        Me.radExponentiation.Text = "^"
        Me.radExponentiation.UseVisualStyleBackColor = True
        '
        'radMultiplication
        '
        Me.radMultiplication.AutoSize = True
        Me.radMultiplication.Location = New System.Drawing.Point(6, 71)
        Me.radMultiplication.Name = "radMultiplication"
        Me.radMultiplication.Size = New System.Drawing.Size(29, 17)
        Me.radMultiplication.TabIndex = 1
        Me.radMultiplication.TabStop = True
        Me.radMultiplication.Text = "*"
        Me.radMultiplication.UseVisualStyleBackColor = True
        '
        'radDivision
        '
        Me.radDivision.AutoSize = True
        Me.radDivision.Location = New System.Drawing.Point(6, 133)
        Me.radDivision.Name = "radDivision"
        Me.radDivision.Size = New System.Drawing.Size(30, 17)
        Me.radDivision.TabIndex = 2
        Me.radDivision.TabStop = True
        Me.radDivision.Text = "/"
        Me.radDivision.UseVisualStyleBackColor = True
        '
        'radIntDivision
        '
        Me.radIntDivision.AutoSize = True
        Me.radIntDivision.Location = New System.Drawing.Point(6, 185)
        Me.radIntDivision.Name = "radIntDivision"
        Me.radIntDivision.Size = New System.Drawing.Size(30, 17)
        Me.radIntDivision.TabIndex = 3
        Me.radIntDivision.TabStop = True
        Me.radIntDivision.Text = "\"
        Me.radIntDivision.UseVisualStyleBackColor = True
        '
        'radModDivision
        '
        Me.radModDivision.AutoSize = True
        Me.radModDivision.Location = New System.Drawing.Point(330, 19)
        Me.radModDivision.Name = "radModDivision"
        Me.radModDivision.Size = New System.Drawing.Size(46, 17)
        Me.radModDivision.TabIndex = 4
        Me.radModDivision.TabStop = True
        Me.radModDivision.Text = "Mod"
        Me.radModDivision.UseVisualStyleBackColor = True
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Location = New System.Drawing.Point(330, 71)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(31, 17)
        Me.radAddition.TabIndex = 5
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "+"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Location = New System.Drawing.Point(330, 133)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(28, 17)
        Me.radSubtraction.TabIndex = 6
        Me.radSubtraction.TabStop = True
        Me.radSubtraction.Text = "-"
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(0, 323)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(462, 25)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "Result:"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpressionValue
        '
        Me.lblExpressionValue.Location = New System.Drawing.Point(0, 348)
        Me.lblExpressionValue.Name = "lblExpressionValue"
        Me.lblExpressionValue.Size = New System.Drawing.Size(462, 87)
        Me.lblExpressionValue.TabIndex = 7
        Me.lblExpressionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCaseStudyCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 444)
        Me.Controls.Add(Me.lblExpressionValue)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.grpOperators)
        Me.Controls.Add(Me.txtOperand2)
        Me.Controls.Add(Me.lblOp2Prompt)
        Me.Controls.Add(Me.txtOperand1)
        Me.Controls.Add(Me.lblOp1Prompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCaseStudyCalculator"
        Me.Text = "Case Study Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpOperators.ResumeLayout(False)
        Me.grpOperators.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumberOfDigitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShellGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblOp1Prompt As System.Windows.Forms.Label
    Friend WithEvents txtOperand1 As System.Windows.Forms.TextBox
    Friend WithEvents lblOp2Prompt As System.Windows.Forms.Label
    Friend WithEvents txtOperand2 As System.Windows.Forms.TextBox
    Friend WithEvents grpOperators As System.Windows.Forms.GroupBox
    Friend WithEvents radSubtraction As System.Windows.Forms.RadioButton
    Friend WithEvents radAddition As System.Windows.Forms.RadioButton
    Friend WithEvents radModDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radIntDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents radExponentiation As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblExpressionValue As System.Windows.Forms.Label

End Class
