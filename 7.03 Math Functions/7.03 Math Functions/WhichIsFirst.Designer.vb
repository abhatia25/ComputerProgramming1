<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWhichIsFirst
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
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.txtWord1 = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtWord2 = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 27)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(260, 46)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Which word comes first?"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblPrompt1
        '
        Me.lblPrompt1.Location = New System.Drawing.Point(12, 76)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(123, 46)
        Me.lblPrompt1.TabIndex = 2
        Me.lblPrompt1.Text = "Enter a word:"
        Me.lblPrompt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWord1
        '
        Me.txtWord1.Location = New System.Drawing.Point(141, 90)
        Me.txtWord1.Name = "txtWord1"
        Me.txtWord1.Size = New System.Drawing.Size(131, 20)
        Me.txtWord1.TabIndex = 3
        '
        'lblPrompt2
        '
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 132)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(123, 46)
        Me.lblPrompt2.TabIndex = 4
        Me.lblPrompt2.Text = "Enter a word:"
        Me.lblPrompt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWord2
        '
        Me.txtWord2.Location = New System.Drawing.Point(141, 146)
        Me.txtWord2.Name = "txtWord2"
        Me.txtWord2.Size = New System.Drawing.Size(131, 20)
        Me.txtWord2.TabIndex = 5
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 195)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 58)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWhichIsFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtWord2)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtWord1)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWhichIsFirst"
        Me.Text = "Which Is First?"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblPrompt1 As System.Windows.Forms.Label
    Friend WithEvents txtWord1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents txtWord2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
