<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleDiceRolling
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
        Me.SumOf4NumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblDiceOutput = New System.Windows.Forms.Label()
        Me.cmbDieSize = New System.Windows.Forms.ComboBox()
        Me.lstDiceRolls = New System.Windows.Forms.ListBox()
        Me.lblDiceRolls = New System.Windows.Forms.Label()
        Me.lblDieSize = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(405, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElseIfToolStripMenuItem, Me.SumOf4NumbersToolStripMenuItem, Me.SimpleCalculatorToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'ElseIfToolStripMenuItem
        '
        Me.ElseIfToolStripMenuItem.Name = "ElseIfToolStripMenuItem"
        Me.ElseIfToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ElseIfToolStripMenuItem.Text = "&Else If"
        '
        'SumOf4NumbersToolStripMenuItem
        '
        Me.SumOf4NumbersToolStripMenuItem.Name = "SumOf4NumbersToolStripMenuItem"
        Me.SumOf4NumbersToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SumOf4NumbersToolStripMenuItem.Text = "&Sum of 4 Numbers"
        '
        'SimpleCalculatorToolStripMenuItem
        '
        Me.SimpleCalculatorToolStripMenuItem.Name = "SimpleCalculatorToolStripMenuItem"
        Me.SimpleCalculatorToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SimpleCalculatorToolStripMenuItem.Text = "Simple &Calculator"
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(286, 299)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "Roll the Die"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblDiceOutput
        '
        Me.lblDiceOutput.Location = New System.Drawing.Point(38, 89)
        Me.lblDiceOutput.Name = "lblDiceOutput"
        Me.lblDiceOutput.Size = New System.Drawing.Size(78, 23)
        Me.lblDiceOutput.TabIndex = 2
        Me.lblDiceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbDieSize
        '
        Me.cmbDieSize.FormattingEnabled = True
        Me.cmbDieSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "20"})
        Me.cmbDieSize.Location = New System.Drawing.Point(257, 63)
        Me.cmbDieSize.Name = "cmbDieSize"
        Me.cmbDieSize.Size = New System.Drawing.Size(121, 21)
        Me.cmbDieSize.TabIndex = 3
        '
        'lstDiceRolls
        '
        Me.lstDiceRolls.FormattingEnabled = True
        Me.lstDiceRolls.Location = New System.Drawing.Point(12, 63)
        Me.lstDiceRolls.Name = "lstDiceRolls"
        Me.lstDiceRolls.Size = New System.Drawing.Size(171, 251)
        Me.lstDiceRolls.TabIndex = 4
        '
        'lblDiceRolls
        '
        Me.lblDiceRolls.AutoSize = True
        Me.lblDiceRolls.Location = New System.Drawing.Point(12, 47)
        Me.lblDiceRolls.Name = "lblDiceRolls"
        Me.lblDiceRolls.Size = New System.Drawing.Size(55, 13)
        Me.lblDiceRolls.TabIndex = 5
        Me.lblDiceRolls.Text = "Dice Rolls"
        '
        'lblDieSize
        '
        Me.lblDieSize.AutoSize = True
        Me.lblDieSize.Location = New System.Drawing.Point(254, 47)
        Me.lblDieSize.Name = "lblDieSize"
        Me.lblDieSize.Size = New System.Drawing.Size(46, 13)
        Me.lblDieSize.TabIndex = 6
        Me.lblDieSize.Text = "Die Size"
        '
        'frmSimpleDiceRolling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 345)
        Me.Controls.Add(Me.lblDieSize)
        Me.Controls.Add(Me.lblDiceRolls)
        Me.Controls.Add(Me.lstDiceRolls)
        Me.Controls.Add(Me.cmbDieSize)
        Me.Controls.Add(Me.lblDiceOutput)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSimpleDiceRolling"
        Me.Text = "Simple Dice Rolling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElseIfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SumOf4NumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lblDiceOutput As System.Windows.Forms.Label
    Friend WithEvents cmbDieSize As System.Windows.Forms.ComboBox
    Friend WithEvents lstDiceRolls As System.Windows.Forms.ListBox
    Friend WithEvents lblDiceRolls As System.Windows.Forms.Label
    Friend WithEvents lblDieSize As System.Windows.Forms.Label
End Class
