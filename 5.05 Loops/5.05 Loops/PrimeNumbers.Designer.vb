<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrimeNumbers
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
        Me.lblIntegerPrompt = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtInteger = New System.Windows.Forms.TextBox()
        Me.lblPrimeResult = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(222, 24)
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
        'lblIntegerPrompt
        '
        Me.lblIntegerPrompt.AutoSize = True
        Me.lblIntegerPrompt.Location = New System.Drawing.Point(12, 38)
        Me.lblIntegerPrompt.Name = "lblIntegerPrompt"
        Me.lblIntegerPrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblIntegerPrompt.TabIndex = 1
        Me.lblIntegerPrompt.Text = "Enter an integer"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(65, 64)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 2
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtInteger
        '
        Me.txtInteger.Location = New System.Drawing.Point(100, 35)
        Me.txtInteger.Name = "txtInteger"
        Me.txtInteger.Size = New System.Drawing.Size(100, 20)
        Me.txtInteger.TabIndex = 3
        '
        'lblPrimeResult
        '
        Me.lblPrimeResult.Location = New System.Drawing.Point(12, 104)
        Me.lblPrimeResult.Name = "lblPrimeResult"
        Me.lblPrimeResult.Size = New System.Drawing.Size(198, 98)
        Me.lblPrimeResult.TabIndex = 4
        Me.lblPrimeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPrimeNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 226)
        Me.Controls.Add(Me.lblPrimeResult)
        Me.Controls.Add(Me.txtInteger)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblIntegerPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrimeNumbers"
        Me.Text = "Prime Numbers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblIntegerPrompt As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents txtInteger As System.Windows.Forms.TextBox
    Friend WithEvents lblPrimeResult As System.Windows.Forms.Label

End Class
