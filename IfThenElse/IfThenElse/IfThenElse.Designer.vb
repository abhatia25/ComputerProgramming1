<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIfThenElse
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
        Me.CloseProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.chkCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnCheckifStatement = New System.Windows.Forms.Button()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseProgramToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(448, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseProgramToolStripMenuItem
        '
        Me.CloseProgramToolStripMenuItem.Name = "CloseProgramToolStripMenuItem"
        Me.CloseProgramToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.CloseProgramToolStripMenuItem.Text = "&Close Program"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(156, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(156, 125)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(100, 35)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCheckBox1
        '
        Me.chkCheckBox1.AutoSize = True
        Me.chkCheckBox1.Location = New System.Drawing.Point(170, 182)
        Me.chkCheckBox1.Name = "chkCheckBox1"
        Me.chkCheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.chkCheckBox1.TabIndex = 3
        Me.chkCheckBox1.UseVisualStyleBackColor = True
        '
        'btnCheckifStatement
        '
        Me.btnCheckifStatement.Location = New System.Drawing.Point(170, 225)
        Me.btnCheckifStatement.Name = "btnCheckifStatement"
        Me.btnCheckifStatement.Size = New System.Drawing.Size(75, 41)
        Me.btnCheckifStatement.TabIndex = 4
        Me.btnCheckifStatement.Text = "Check if Statement"
        Me.btnCheckifStatement.UseVisualStyleBackColor = True
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'frmIfThenElse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 457)
        Me.Controls.Add(Me.btnCheckifStatement)
        Me.Controls.Add(Me.chkCheckBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIfThenElse"
        Me.Text = "If Then Else"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CloseProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents chkCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnCheckifStatement As System.Windows.Forms.Button
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
