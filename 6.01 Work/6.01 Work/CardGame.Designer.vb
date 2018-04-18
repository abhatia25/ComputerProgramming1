<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardGame
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
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.lblPlayerPoints = New System.Windows.Forms.Label()
        Me.lblComputerPoints = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picComputerCard3 = New System.Windows.Forms.PictureBox()
        Me.picComputerCard2 = New System.Windows.Forms.PictureBox()
        Me.picComputerCard1 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard3 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard2 = New System.Windows.Forms.PictureBox()
        Me.picPlayerCard1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picComputerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picComputerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
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
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(194, 254)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayGame.TabIndex = 4
        Me.btnPlayGame.Text = "Play Game"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'lblPlayerPoints
        '
        Me.lblPlayerPoints.Location = New System.Drawing.Point(12, 172)
        Me.lblPlayerPoints.Name = "lblPlayerPoints"
        Me.lblPlayerPoints.Size = New System.Drawing.Size(440, 23)
        Me.lblPlayerPoints.TabIndex = 8
        Me.lblPlayerPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerPoints
        '
        Me.lblComputerPoints.Location = New System.Drawing.Point(12, 329)
        Me.lblComputerPoints.Name = "lblComputerPoints"
        Me.lblComputerPoints.Size = New System.Drawing.Size(440, 23)
        Me.lblComputerPoints.TabIndex = 9
        Me.lblComputerPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWinner
        '
        Me.lblWinner.Location = New System.Drawing.Point(12, 229)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(147, 61)
        Me.lblWinner.TabIndex = 10
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.Location = New System.Drawing.Point(305, 229)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(147, 61)
        Me.lblScore.TabIndex = 11
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picComputerCard3
        '
        Me.picComputerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerCard3.Location = New System.Drawing.Point(338, 355)
        Me.picComputerCard3.Name = "picComputerCard3"
        Me.picComputerCard3.Size = New System.Drawing.Size(114, 142)
        Me.picComputerCard3.TabIndex = 7
        Me.picComputerCard3.TabStop = False
        '
        'picComputerCard2
        '
        Me.picComputerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerCard2.Location = New System.Drawing.Point(174, 355)
        Me.picComputerCard2.Name = "picComputerCard2"
        Me.picComputerCard2.Size = New System.Drawing.Size(114, 142)
        Me.picComputerCard2.TabIndex = 6
        Me.picComputerCard2.TabStop = False
        '
        'picComputerCard1
        '
        Me.picComputerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picComputerCard1.Location = New System.Drawing.Point(12, 355)
        Me.picComputerCard1.Name = "picComputerCard1"
        Me.picComputerCard1.Size = New System.Drawing.Size(114, 142)
        Me.picComputerCard1.TabIndex = 5
        Me.picComputerCard1.TabStop = False
        '
        'picPlayerCard3
        '
        Me.picPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerCard3.Location = New System.Drawing.Point(338, 27)
        Me.picPlayerCard3.Name = "picPlayerCard3"
        Me.picPlayerCard3.Size = New System.Drawing.Size(114, 142)
        Me.picPlayerCard3.TabIndex = 3
        Me.picPlayerCard3.TabStop = False
        '
        'picPlayerCard2
        '
        Me.picPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerCard2.Location = New System.Drawing.Point(174, 27)
        Me.picPlayerCard2.Name = "picPlayerCard2"
        Me.picPlayerCard2.Size = New System.Drawing.Size(114, 142)
        Me.picPlayerCard2.TabIndex = 2
        Me.picPlayerCard2.TabStop = False
        '
        'picPlayerCard1
        '
        Me.picPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayerCard1.Location = New System.Drawing.Point(12, 27)
        Me.picPlayerCard1.Name = "picPlayerCard1"
        Me.picPlayerCard1.Size = New System.Drawing.Size(114, 142)
        Me.picPlayerCard1.TabIndex = 1
        Me.picPlayerCard1.TabStop = False
        '
        'frmCardGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 509)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblComputerPoints)
        Me.Controls.Add(Me.lblPlayerPoints)
        Me.Controls.Add(Me.picComputerCard3)
        Me.Controls.Add(Me.picComputerCard2)
        Me.Controls.Add(Me.picComputerCard1)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.picPlayerCard3)
        Me.Controls.Add(Me.picPlayerCard2)
        Me.Controls.Add(Me.picPlayerCard1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCardGame"
        Me.Text = "Card Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picComputerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picComputerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picPlayerCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPlayGame As System.Windows.Forms.Button
    Friend WithEvents picComputerCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picComputerCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picComputerCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerPoints As System.Windows.Forms.Label
    Friend WithEvents lblComputerPoints As System.Windows.Forms.Label
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
End Class
