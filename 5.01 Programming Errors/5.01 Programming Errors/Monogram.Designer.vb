<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonogram
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
        Me.lblNamesPrompt = New System.Windows.Forms.Label()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.btnMonogram = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(305, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblNamesPrompt
        '
        Me.lblNamesPrompt.Location = New System.Drawing.Point(12, 60)
        Me.lblNamesPrompt.Name = "lblNamesPrompt"
        Me.lblNamesPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblNamesPrompt.TabIndex = 1
        Me.lblNamesPrompt.Text = "Names"
        Me.lblNamesPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(118, 60)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(100, 20)
        Me.txtNames.TabIndex = 2
        '
        'btnMonogram
        '
        Me.btnMonogram.Location = New System.Drawing.Point(106, 101)
        Me.btnMonogram.Name = "btnMonogram"
        Me.btnMonogram.Size = New System.Drawing.Size(75, 23)
        Me.btnMonogram.TabIndex = 3
        Me.btnMonogram.Text = "Monogram"
        Me.btnMonogram.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 127)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(281, 162)
        Me.lblAnswer.TabIndex = 4
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMonogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 298)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnMonogram)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.lblNamesPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMonogram"
        Me.Text = "Monogram"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNamesPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents btnMonogram As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
