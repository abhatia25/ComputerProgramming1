<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckedListBox
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
        Me.btnWhatIsChecked = New System.Windows.Forms.Button()
        Me.clbCheckedListBox1Example = New System.Windows.Forms.CheckedListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWhatIsChecked
        '
        Me.btnWhatIsChecked.Location = New System.Drawing.Point(79, 37)
        Me.btnWhatIsChecked.Name = "btnWhatIsChecked"
        Me.btnWhatIsChecked.Size = New System.Drawing.Size(98, 38)
        Me.btnWhatIsChecked.TabIndex = 0
        Me.btnWhatIsChecked.Text = "What Is Checked"
        Me.btnWhatIsChecked.UseVisualStyleBackColor = True
        '
        'clbCheckedListBox1Example
        '
        Me.clbCheckedListBox1Example.CheckOnClick = True
        Me.clbCheckedListBox1Example.FormattingEnabled = True
        Me.clbCheckedListBox1Example.Items.AddRange(New Object() {"Red", "Yellow", "Blue", "White", "Black"})
        Me.clbCheckedListBox1Example.Location = New System.Drawing.Point(68, 100)
        Me.clbCheckedListBox1Example.Name = "clbCheckedListBox1Example"
        Me.clbCheckedListBox1Example.Size = New System.Drawing.Size(120, 94)
        Me.clbCheckedListBox1Example.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CheckedListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.clbCheckedListBox1Example)
        Me.Controls.Add(Me.btnWhatIsChecked)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CheckedListBox"
        Me.Text = "Checked List Box Example"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWhatIsChecked As System.Windows.Forms.Button
    Friend WithEvents clbCheckedListBox1Example As System.Windows.Forms.CheckedListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
