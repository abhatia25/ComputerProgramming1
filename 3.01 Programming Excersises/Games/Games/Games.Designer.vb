<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGames
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
        Me.btnGame1 = New System.Windows.Forms.Button()
        Me.btnGame2 = New System.Windows.Forms.Button()
        Me.btnGame3 = New System.Windows.Forms.Button()
        Me.btnGame4 = New System.Windows.Forms.Button()
        Me.lblGameInfo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGame1
        '
        Me.btnGame1.Location = New System.Drawing.Point(12, 54)
        Me.btnGame1.Name = "btnGame1"
        Me.btnGame1.Size = New System.Drawing.Size(88, 37)
        Me.btnGame1.TabIndex = 0
        Me.btnGame1.Text = "Minecraft"
        Me.btnGame1.UseVisualStyleBackColor = True
        '
        'btnGame2
        '
        Me.btnGame2.Location = New System.Drawing.Point(12, 126)
        Me.btnGame2.Name = "btnGame2"
        Me.btnGame2.Size = New System.Drawing.Size(88, 39)
        Me.btnGame2.TabIndex = 1
        Me.btnGame2.Text = "Grand Theft Auto"
        Me.btnGame2.UseVisualStyleBackColor = True
        '
        'btnGame3
        '
        Me.btnGame3.Location = New System.Drawing.Point(184, 54)
        Me.btnGame3.Name = "btnGame3"
        Me.btnGame3.Size = New System.Drawing.Size(88, 37)
        Me.btnGame3.TabIndex = 2
        Me.btnGame3.Text = "Tetris"
        Me.btnGame3.UseVisualStyleBackColor = True
        '
        'btnGame4
        '
        Me.btnGame4.Location = New System.Drawing.Point(184, 128)
        Me.btnGame4.Name = "btnGame4"
        Me.btnGame4.Size = New System.Drawing.Size(88, 37)
        Me.btnGame4.TabIndex = 3
        Me.btnGame4.Text = "Madden NFL"
        Me.btnGame4.UseVisualStyleBackColor = True
        '
        'lblGameInfo
        '
        Me.lblGameInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameInfo.Location = New System.Drawing.Point(29, 180)
        Me.lblGameInfo.Name = "lblGameInfo"
        Me.lblGameInfo.Size = New System.Drawing.Size(223, 195)
        Me.lblGameInfo.TabIndex = 4
        Me.lblGameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'frmGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 398)
        Me.Controls.Add(Me.lblGameInfo)
        Me.Controls.Add(Me.btnGame4)
        Me.Controls.Add(Me.btnGame3)
        Me.Controls.Add(Me.btnGame2)
        Me.Controls.Add(Me.btnGame1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGames"
        Me.Text = "Video Games"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGame1 As System.Windows.Forms.Button
    Friend WithEvents btnGame2 As System.Windows.Forms.Button
    Friend WithEvents btnGame3 As System.Windows.Forms.Button
    Friend WithEvents btnGame4 As System.Windows.Forms.Button
    Friend WithEvents lblGameInfo As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
