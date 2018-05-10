<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayGolf
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
        Me.lstList = New System.Windows.Forms.ListBox()
        Me.lblPlayer1Winnings = New System.Windows.Forms.Label()
        Me.lblPlayer2Winnings = New System.Windows.Forms.Label()
        Me.lblPlayer4Winnings = New System.Windows.Forms.Label()
        Me.lblPlayer3Winnings = New System.Windows.Forms.Label()
        Me.btnPlayGolf = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
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
        'lstList
        '
        Me.lstList.FormattingEnabled = True
        Me.lstList.HorizontalScrollbar = True
        Me.lstList.Location = New System.Drawing.Point(12, 27)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(326, 225)
        Me.lstList.TabIndex = 1
        '
        'lblPlayer1Winnings
        '
        Me.lblPlayer1Winnings.Location = New System.Drawing.Point(344, 27)
        Me.lblPlayer1Winnings.Name = "lblPlayer1Winnings"
        Me.lblPlayer1Winnings.Size = New System.Drawing.Size(193, 48)
        Me.lblPlayer1Winnings.TabIndex = 2
        Me.lblPlayer1Winnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2Winnings
        '
        Me.lblPlayer2Winnings.Location = New System.Drawing.Point(344, 75)
        Me.lblPlayer2Winnings.Name = "lblPlayer2Winnings"
        Me.lblPlayer2Winnings.Size = New System.Drawing.Size(193, 48)
        Me.lblPlayer2Winnings.TabIndex = 3
        Me.lblPlayer2Winnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer4Winnings
        '
        Me.lblPlayer4Winnings.Location = New System.Drawing.Point(344, 171)
        Me.lblPlayer4Winnings.Name = "lblPlayer4Winnings"
        Me.lblPlayer4Winnings.Size = New System.Drawing.Size(193, 48)
        Me.lblPlayer4Winnings.TabIndex = 4
        Me.lblPlayer4Winnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer3Winnings
        '
        Me.lblPlayer3Winnings.Location = New System.Drawing.Point(344, 123)
        Me.lblPlayer3Winnings.Name = "lblPlayer3Winnings"
        Me.lblPlayer3Winnings.Size = New System.Drawing.Size(193, 48)
        Me.lblPlayer3Winnings.TabIndex = 5
        Me.lblPlayer3Winnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayGolf
        '
        Me.btnPlayGolf.Location = New System.Drawing.Point(404, 226)
        Me.btnPlayGolf.Name = "btnPlayGolf"
        Me.btnPlayGolf.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGolf.TabIndex = 6
        Me.btnPlayGolf.Text = "Play Golf"
        Me.btnPlayGolf.UseVisualStyleBackColor = True
        '
        'PlayGolf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 261)
        Me.Controls.Add(Me.btnPlayGolf)
        Me.Controls.Add(Me.lblPlayer3Winnings)
        Me.Controls.Add(Me.lblPlayer4Winnings)
        Me.Controls.Add(Me.lblPlayer2Winnings)
        Me.Controls.Add(Me.lblPlayer1Winnings)
        Me.Controls.Add(Me.lstList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PlayGolf"
        Me.Text = "Play Golf"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstList As ListBox
    Friend WithEvents lblPlayer1Winnings As Label
    Friend WithEvents lblPlayer2Winnings As Label
    Friend WithEvents lblPlayer4Winnings As Label
    Friend WithEvents lblPlayer3Winnings As Label
    Friend WithEvents btnPlayGolf As Button
End Class
