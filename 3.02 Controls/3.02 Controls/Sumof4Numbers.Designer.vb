<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSumof4Numbers
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
        Me.ElseIfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleDiceRollingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.grpNumbers = New System.Windows.Forms.GroupBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElseIfToolStripMenuItem, Me.SimpleDiceRollingToolStripMenuItem, Me.SimpleCalculatorToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'ElseIfToolStripMenuItem
        '
        Me.ElseIfToolStripMenuItem.Name = "ElseIfToolStripMenuItem"
        Me.ElseIfToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ElseIfToolStripMenuItem.Text = "&Else If"
        '
        'SimpleDiceRollingToolStripMenuItem
        '
        Me.SimpleDiceRollingToolStripMenuItem.Name = "SimpleDiceRollingToolStripMenuItem"
        Me.SimpleDiceRollingToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SimpleDiceRollingToolStripMenuItem.Text = "Simple &Dice Rolling"
        '
        'SimpleCalculatorToolStripMenuItem
        '
        Me.SimpleCalculatorToolStripMenuItem.Name = "SimpleCalculatorToolStripMenuItem"
        Me.SimpleCalculatorToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SimpleCalculatorToolStripMenuItem.Text = "Simple &Calculator"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(425, 57)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Sum of 4 Numbers"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(258, 319)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(80, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblAns
        '
        Me.lblAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns.Location = New System.Drawing.Point(149, 379)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(129, 38)
        Me.lblAns.TabIndex = 3
        Me.lblAns.Text = "?"
        Me.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNumbers
        '
        Me.grpNumbers.Controls.Add(Me.txtNum1)
        Me.grpNumbers.Controls.Add(Me.txtNum3)
        Me.grpNumbers.Controls.Add(Me.txtNum4)
        Me.grpNumbers.Controls.Add(Me.txtNum2)
        Me.grpNumbers.Location = New System.Drawing.Point(69, 101)
        Me.grpNumbers.Name = "grpNumbers"
        Me.grpNumbers.Size = New System.Drawing.Size(296, 212)
        Me.grpNumbers.TabIndex = 8
        Me.grpNumbers.TabStop = False
        Me.grpNumbers.Text = "Please enter 4 numbers"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(189, 24)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(80, 20)
        Me.txtNum2.TabIndex = 0
        '
        'txtNum4
        '
        Me.txtNum4.Location = New System.Drawing.Point(189, 166)
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(80, 20)
        Me.txtNum4.TabIndex = 1
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(22, 166)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(80, 20)
        Me.txtNum3.TabIndex = 2
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(22, 24)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(80, 20)
        Me.txtNum1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(91, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSumof4Numbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 439)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpNumbers)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSumof4Numbers"
        Me.Text = "Sum of 4 Numbers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpNumbers.ResumeLayout(False)
        Me.grpNumbers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElseIfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleDiceRollingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents grpNumbers As System.Windows.Forms.GroupBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
