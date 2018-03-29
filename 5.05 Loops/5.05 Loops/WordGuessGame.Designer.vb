<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWordGuessGame
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
        Me.lblSecretWord = New System.Windows.Forms.Label()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.lblNumPoints = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(553, 24)
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
        'lblSecretWord
        '
        Me.lblSecretWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretWord.Location = New System.Drawing.Point(12, 24)
        Me.lblSecretWord.Name = "lblSecretWord"
        Me.lblSecretWord.Size = New System.Drawing.Size(529, 229)
        Me.lblSecretWord.TabIndex = 1
        Me.lblSecretWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(240, 267)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGame.TabIndex = 2
        Me.btnPlayGame.Text = "Play Game"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'lblNumPoints
        '
        Me.lblNumPoints.AutoSize = True
        Me.lblNumPoints.Location = New System.Drawing.Point(12, 272)
        Me.lblNumPoints.Name = "lblNumPoints"
        Me.lblNumPoints.Size = New System.Drawing.Size(0, 13)
        Me.lblNumPoints.TabIndex = 3
        '
        'frmWordGuessGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 302)
        Me.Controls.Add(Me.lblNumPoints)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.lblSecretWord)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWordGuessGame"
        Me.Text = "Word Guess Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSecretWord As System.Windows.Forms.Label
    Friend WithEvents btnPlayGame As System.Windows.Forms.Button
    Friend WithEvents lblNumPoints As System.Windows.Forms.Label
End Class
