<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOf21
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
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPlayerCards = New System.Windows.Forms.Label()
        Me.lblComputerCards = New System.Windows.Forms.Label()
        Me.lblPlayerCard1 = New System.Windows.Forms.Label()
        Me.lblPlayerCard2 = New System.Windows.Forms.Label()
        Me.lblPlayerDrewCard = New System.Windows.Forms.Label()
        Me.lblComputerCard1 = New System.Windows.Forms.Label()
        Me.lblComputerCard2 = New System.Windows.Forms.Label()
        Me.lblComputerCard3 = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblPlayersScore = New System.Windows.Forms.Label()
        Me.lblComputerScore = New System.Windows.Forms.Label()
        Me.lblComputersScore = New System.Windows.Forms.Label()
        Me.btnDrawCard = New System.Windows.Forms.Button()
        Me.btnCheckScores = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem, Me.PlayGameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(368, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OtherProgramsToolStripMenuItem
        '
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayrollToolStripMenuItem, Me.PricesToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PayrollToolStripMenuItem.Text = "&Payroll"
        '
        'PricesToolStripMenuItem
        '
        Me.PricesToolStripMenuItem.Name = "PricesToolStripMenuItem"
        Me.PricesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PricesToolStripMenuItem.Text = "P&rices"
        '
        'PlayGameToolStripMenuItem
        '
        Me.PlayGameToolStripMenuItem.Name = "PlayGameToolStripMenuItem"
        Me.PlayGameToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.PlayGameToolStripMenuItem.Text = "Play &Game"
        '
        'lblPlayerCards
        '
        Me.lblPlayerCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerCards.Location = New System.Drawing.Point(12, 66)
        Me.lblPlayerCards.Name = "lblPlayerCards"
        Me.lblPlayerCards.Size = New System.Drawing.Size(113, 56)
        Me.lblPlayerCards.TabIndex = 3
        Me.lblPlayerCards.Text = "Player Cards"
        Me.lblPlayerCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerCards
        '
        Me.lblComputerCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerCards.Location = New System.Drawing.Point(243, 66)
        Me.lblComputerCards.Name = "lblComputerCards"
        Me.lblComputerCards.Size = New System.Drawing.Size(113, 56)
        Me.lblComputerCards.TabIndex = 4
        Me.lblComputerCards.Text = "Computer Cards"
        Me.lblComputerCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerCard1
        '
        Me.lblPlayerCard1.Location = New System.Drawing.Point(13, 134)
        Me.lblPlayerCard1.Name = "lblPlayerCard1"
        Me.lblPlayerCard1.Size = New System.Drawing.Size(112, 23)
        Me.lblPlayerCard1.TabIndex = 5
        Me.lblPlayerCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerCard2
        '
        Me.lblPlayerCard2.Location = New System.Drawing.Point(13, 157)
        Me.lblPlayerCard2.Name = "lblPlayerCard2"
        Me.lblPlayerCard2.Size = New System.Drawing.Size(112, 23)
        Me.lblPlayerCard2.TabIndex = 6
        Me.lblPlayerCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerDrewCard
        '
        Me.lblPlayerDrewCard.Location = New System.Drawing.Point(13, 180)
        Me.lblPlayerDrewCard.Name = "lblPlayerDrewCard"
        Me.lblPlayerDrewCard.Size = New System.Drawing.Size(112, 23)
        Me.lblPlayerDrewCard.TabIndex = 7
        Me.lblPlayerDrewCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerCard1
        '
        Me.lblComputerCard1.Location = New System.Drawing.Point(244, 134)
        Me.lblComputerCard1.Name = "lblComputerCard1"
        Me.lblComputerCard1.Size = New System.Drawing.Size(112, 23)
        Me.lblComputerCard1.TabIndex = 8
        Me.lblComputerCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerCard2
        '
        Me.lblComputerCard2.Location = New System.Drawing.Point(244, 157)
        Me.lblComputerCard2.Name = "lblComputerCard2"
        Me.lblComputerCard2.Size = New System.Drawing.Size(112, 23)
        Me.lblComputerCard2.TabIndex = 9
        Me.lblComputerCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerCard3
        '
        Me.lblComputerCard3.Location = New System.Drawing.Point(244, 180)
        Me.lblComputerCard3.Name = "lblComputerCard3"
        Me.lblComputerCard3.Size = New System.Drawing.Size(112, 23)
        Me.lblComputerCard3.TabIndex = 10
        Me.lblComputerCard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.Location = New System.Drawing.Point(12, 213)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(113, 39)
        Me.lblPlayerScore.TabIndex = 11
        Me.lblPlayerScore.Text = "Score"
        Me.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayersScore
        '
        Me.lblPlayersScore.Location = New System.Drawing.Point(13, 252)
        Me.lblPlayersScore.Name = "lblPlayersScore"
        Me.lblPlayersScore.Size = New System.Drawing.Size(112, 23)
        Me.lblPlayersScore.TabIndex = 12
        Me.lblPlayersScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerScore
        '
        Me.lblComputerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerScore.Location = New System.Drawing.Point(243, 213)
        Me.lblComputerScore.Name = "lblComputerScore"
        Me.lblComputerScore.Size = New System.Drawing.Size(113, 39)
        Me.lblComputerScore.TabIndex = 13
        Me.lblComputerScore.Text = "Score"
        Me.lblComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputersScore
        '
        Me.lblComputersScore.Location = New System.Drawing.Point(244, 252)
        Me.lblComputersScore.Name = "lblComputersScore"
        Me.lblComputersScore.Size = New System.Drawing.Size(112, 23)
        Me.lblComputersScore.TabIndex = 14
        Me.lblComputersScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDrawCard
        '
        Me.btnDrawCard.Location = New System.Drawing.Point(194, 287)
        Me.btnDrawCard.Name = "btnDrawCard"
        Me.btnDrawCard.Size = New System.Drawing.Size(83, 23)
        Me.btnDrawCard.TabIndex = 15
        Me.btnDrawCard.Text = "Draw Card"
        Me.btnDrawCard.UseVisualStyleBackColor = True
        '
        'btnCheckScores
        '
        Me.btnCheckScores.Location = New System.Drawing.Point(105, 287)
        Me.btnCheckScores.Name = "btnCheckScores"
        Me.btnCheckScores.Size = New System.Drawing.Size(83, 23)
        Me.btnCheckScores.TabIndex = 16
        Me.btnCheckScores.Text = "Check Scores"
        Me.btnCheckScores.UseVisualStyleBackColor = True
        '
        'frmGameOf21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 322)
        Me.Controls.Add(Me.btnCheckScores)
        Me.Controls.Add(Me.btnDrawCard)
        Me.Controls.Add(Me.lblComputersScore)
        Me.Controls.Add(Me.lblComputerScore)
        Me.Controls.Add(Me.lblPlayersScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblComputerCard3)
        Me.Controls.Add(Me.lblComputerCard2)
        Me.Controls.Add(Me.lblComputerCard1)
        Me.Controls.Add(Me.lblPlayerDrewCard)
        Me.Controls.Add(Me.lblPlayerCard2)
        Me.Controls.Add(Me.lblPlayerCard1)
        Me.Controls.Add(Me.lblComputerCards)
        Me.Controls.Add(Me.lblPlayerCards)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGameOf21"
        Me.Text = "Game of 21"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PricesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPlayerCards As Label
    Friend WithEvents lblComputerCards As Label
    Friend WithEvents lblPlayerCard1 As Label
    Friend WithEvents lblPlayerCard2 As Label
    Friend WithEvents lblPlayerDrewCard As Label
    Friend WithEvents lblComputerCard1 As Label
    Friend WithEvents lblComputerCard2 As Label
    Friend WithEvents lblComputerCard3 As Label
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblPlayersScore As Label
    Friend WithEvents lblComputerScore As Label
    Friend WithEvents lblComputersScore As Label
    Friend WithEvents btnDrawCard As Button
    Friend WithEvents btnCheckScores As Button
End Class
