<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathFun
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
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsoluteValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareRootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MathToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "&Main"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'MathToolStripMenuItem
        '
        Me.MathToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbsoluteValueToolStripMenuItem, Me.SquareRootToolStripMenuItem, Me.SignToolStripMenuItem, Me.RoundToolStripMenuItem})
        Me.MathToolStripMenuItem.Name = "MathToolStripMenuItem"
        Me.MathToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MathToolStripMenuItem.Text = "Ma&th"
        '
        'AbsoluteValueToolStripMenuItem
        '
        Me.AbsoluteValueToolStripMenuItem.Name = "AbsoluteValueToolStripMenuItem"
        Me.AbsoluteValueToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AbsoluteValueToolStripMenuItem.Text = "&Absolute Value"
        '
        'SquareRootToolStripMenuItem
        '
        Me.SquareRootToolStripMenuItem.Name = "SquareRootToolStripMenuItem"
        Me.SquareRootToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SquareRootToolStripMenuItem.Text = "Square &Root"
        '
        'SignToolStripMenuItem
        '
        Me.SignToolStripMenuItem.Name = "SignToolStripMenuItem"
        Me.SignToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SignToolStripMenuItem.Text = "&Sign"
        '
        'RoundToolStripMenuItem
        '
        Me.RoundToolStripMenuItem.Name = "RoundToolStripMenuItem"
        Me.RoundToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RoundToolStripMenuItem.Text = "Roun&d"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 25)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(106, 33)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter a number:"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(124, 32)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(148, 20)
        Me.txtInput.TabIndex = 2
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 58)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 88)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMathFun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 155)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMathFun"
        Me.Text = "Math Fun"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsoluteValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SquareRootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
