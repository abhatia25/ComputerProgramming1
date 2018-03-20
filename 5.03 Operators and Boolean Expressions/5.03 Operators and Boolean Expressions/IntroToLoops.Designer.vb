<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroToLoops
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
        Me.txtMaxValue = New System.Windows.Forms.TextBox()
        Me.lblMaxValuePrompt = New System.Windows.Forms.Label()
        Me.btnSumOddNumbers = New System.Windows.Forms.Button()
        Me.lblSumMessage = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(314, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'txtMaxValue
        '
        Me.txtMaxValue.Location = New System.Drawing.Point(153, 27)
        Me.txtMaxValue.Name = "txtMaxValue"
        Me.txtMaxValue.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxValue.TabIndex = 1
        '
        'lblMaxValuePrompt
        '
        Me.lblMaxValuePrompt.Location = New System.Drawing.Point(12, 27)
        Me.lblMaxValuePrompt.Name = "lblMaxValuePrompt"
        Me.lblMaxValuePrompt.Size = New System.Drawing.Size(135, 20)
        Me.lblMaxValuePrompt.TabIndex = 2
        Me.lblMaxValuePrompt.Text = "Please enter a max value:"
        Me.lblMaxValuePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSumOddNumbers
        '
        Me.btnSumOddNumbers.Location = New System.Drawing.Point(107, 62)
        Me.btnSumOddNumbers.Name = "btnSumOddNumbers"
        Me.btnSumOddNumbers.Size = New System.Drawing.Size(107, 23)
        Me.btnSumOddNumbers.TabIndex = 3
        Me.btnSumOddNumbers.Text = "Sum Odd Numbers"
        Me.btnSumOddNumbers.UseVisualStyleBackColor = True
        '
        'lblSumMessage
        '
        Me.lblSumMessage.Location = New System.Drawing.Point(12, 88)
        Me.lblSumMessage.Name = "lblSumMessage"
        Me.lblSumMessage.Size = New System.Drawing.Size(135, 95)
        Me.lblSumMessage.TabIndex = 4
        Me.lblSumMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSum
        '
        Me.lblSum.Location = New System.Drawing.Point(150, 88)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(135, 95)
        Me.lblSum.TabIndex = 5
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmIntroToLoops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 215)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.lblSumMessage)
        Me.Controls.Add(Me.btnSumOddNumbers)
        Me.Controls.Add(Me.lblMaxValuePrompt)
        Me.Controls.Add(Me.txtMaxValue)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIntroToLoops"
        Me.Text = "Intro To Loops"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMaxValue As System.Windows.Forms.TextBox
    Friend WithEvents lblMaxValuePrompt As System.Windows.Forms.Label
    Friend WithEvents btnSumOddNumbers As System.Windows.Forms.Button
    Friend WithEvents lblSumMessage As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
End Class
