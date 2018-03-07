<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerimeter
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
        Me.lblSide1Prompt = New System.Windows.Forms.Label()
        Me.lblSide2Prompt = New System.Windows.Forms.Label()
        Me.lblSide3Prompt = New System.Windows.Forms.Label()
        Me.lblSide4Prompt = New System.Windows.Forms.Label()
        Me.txtSide1 = New System.Windows.Forms.TextBox()
        Me.txtSide2 = New System.Windows.Forms.TextBox()
        Me.txtSide3 = New System.Windows.Forms.TextBox()
        Me.txtSide4 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblSide1Prompt
        '
        Me.lblSide1Prompt.Location = New System.Drawing.Point(12, 40)
        Me.lblSide1Prompt.Name = "lblSide1Prompt"
        Me.lblSide1Prompt.Size = New System.Drawing.Size(136, 20)
        Me.lblSide1Prompt.TabIndex = 1
        Me.lblSide1Prompt.Text = "Enter the length of side 1:"
        Me.lblSide1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSide2Prompt
        '
        Me.lblSide2Prompt.Location = New System.Drawing.Point(12, 73)
        Me.lblSide2Prompt.Name = "lblSide2Prompt"
        Me.lblSide2Prompt.Size = New System.Drawing.Size(136, 20)
        Me.lblSide2Prompt.TabIndex = 2
        Me.lblSide2Prompt.Text = "Enter the length of side 2:"
        Me.lblSide2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSide3Prompt
        '
        Me.lblSide3Prompt.Location = New System.Drawing.Point(12, 112)
        Me.lblSide3Prompt.Name = "lblSide3Prompt"
        Me.lblSide3Prompt.Size = New System.Drawing.Size(136, 17)
        Me.lblSide3Prompt.TabIndex = 3
        Me.lblSide3Prompt.Text = "Enter the length of side 3:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSide3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSide4Prompt
        '
        Me.lblSide4Prompt.Location = New System.Drawing.Point(12, 146)
        Me.lblSide4Prompt.Name = "lblSide4Prompt"
        Me.lblSide4Prompt.Size = New System.Drawing.Size(136, 20)
        Me.lblSide4Prompt.TabIndex = 4
        Me.lblSide4Prompt.Text = "Enter the length of side 4:"
        Me.lblSide4Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSide1
        '
        Me.txtSide1.Location = New System.Drawing.Point(154, 40)
        Me.txtSide1.Name = "txtSide1"
        Me.txtSide1.Size = New System.Drawing.Size(100, 20)
        Me.txtSide1.TabIndex = 5
        '
        'txtSide2
        '
        Me.txtSide2.Location = New System.Drawing.Point(154, 73)
        Me.txtSide2.Name = "txtSide2"
        Me.txtSide2.Size = New System.Drawing.Size(100, 20)
        Me.txtSide2.TabIndex = 6
        '
        'txtSide3
        '
        Me.txtSide3.Location = New System.Drawing.Point(154, 109)
        Me.txtSide3.Name = "txtSide3"
        Me.txtSide3.Size = New System.Drawing.Size(100, 20)
        Me.txtSide3.TabIndex = 7
        '
        'txtSide4
        '
        Me.txtSide4.Location = New System.Drawing.Point(154, 146)
        Me.txtSide4.Name = "txtSide4"
        Me.txtSide4.Size = New System.Drawing.Size(100, 20)
        Me.txtSide4.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(49, 190)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(130, 180)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(136, 33)
        Me.lblAnswer.TabIndex = 10
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'frmPerimeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 255)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSide4)
        Me.Controls.Add(Me.txtSide3)
        Me.Controls.Add(Me.txtSide2)
        Me.Controls.Add(Me.txtSide1)
        Me.Controls.Add(Me.lblSide4Prompt)
        Me.Controls.Add(Me.lblSide3Prompt)
        Me.Controls.Add(Me.lblSide2Prompt)
        Me.Controls.Add(Me.lblSide1Prompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPerimeter"
        Me.Text = "Perimeter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSide1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblSide2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblSide3Prompt As System.Windows.Forms.Label
    Friend WithEvents lblSide4Prompt As System.Windows.Forms.Label
    Friend WithEvents txtSide1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSide2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSide3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSide4 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
