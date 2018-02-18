<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElseIf
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
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumOf4NumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleDiceRollingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Items.AddRange(New Object() {"Cathy", "Kristy", "Carl"})
        Me.lstName.Location = New System.Drawing.Point(147, 52)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(120, 95)
        Me.lstName.TabIndex = 0
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(170, 188)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(75, 23)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(480, 24)
        Me.MenuStrip1.TabIndex = 2
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumOf4NumbersToolStripMenuItem, Me.SimpleDiceRollingToolStripMenuItem, Me.SimpleCalculatorToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'SumOf4NumbersToolStripMenuItem
        '
        Me.SumOf4NumbersToolStripMenuItem.Name = "SumOf4NumbersToolStripMenuItem"
        Me.SumOf4NumbersToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SumOf4NumbersToolStripMenuItem.Text = "&Sum of 4 Numbers"
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
        'frmElseIf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 446)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmElseIf"
        Me.Text = "Else If Statements"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents btnHello As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SumOf4NumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleDiceRollingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
