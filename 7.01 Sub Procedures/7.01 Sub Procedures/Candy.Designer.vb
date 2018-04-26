<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandy
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
        Me.lblFavoriteCandyPrompt = New System.Windows.Forms.Label()
        Me.txtFavoriteCandy = New System.Windows.Forms.TextBox()
        Me.lblNumOuncesPrompt = New System.Windows.Forms.Label()
        Me.lblPerOuncePricePrompt = New System.Windows.Forms.Label()
        Me.txtNumOunces = New System.Windows.Forms.TextBox()
        Me.txtPricePerOunce = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
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
        'lblFavoriteCandyPrompt
        '
        Me.lblFavoriteCandyPrompt.Location = New System.Drawing.Point(12, 33)
        Me.lblFavoriteCandyPrompt.Name = "lblFavoriteCandyPrompt"
        Me.lblFavoriteCandyPrompt.Size = New System.Drawing.Size(171, 23)
        Me.lblFavoriteCandyPrompt.TabIndex = 1
        Me.lblFavoriteCandyPrompt.Text = "Enter your favorite candy"
        Me.lblFavoriteCandyPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFavoriteCandy
        '
        Me.txtFavoriteCandy.Location = New System.Drawing.Point(189, 35)
        Me.txtFavoriteCandy.Name = "txtFavoriteCandy"
        Me.txtFavoriteCandy.Size = New System.Drawing.Size(83, 20)
        Me.txtFavoriteCandy.TabIndex = 2
        '
        'lblNumOuncesPrompt
        '
        Me.lblNumOuncesPrompt.Location = New System.Drawing.Point(12, 70)
        Me.lblNumOuncesPrompt.Name = "lblNumOuncesPrompt"
        Me.lblNumOuncesPrompt.Size = New System.Drawing.Size(171, 23)
        Me.lblNumOuncesPrompt.TabIndex = 3
        Me.lblNumOuncesPrompt.Text = "Enter number of ounces to buy"
        Me.lblNumOuncesPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPerOuncePricePrompt
        '
        Me.lblPerOuncePricePrompt.Location = New System.Drawing.Point(12, 106)
        Me.lblPerOuncePricePrompt.Name = "lblPerOuncePricePrompt"
        Me.lblPerOuncePricePrompt.Size = New System.Drawing.Size(171, 23)
        Me.lblPerOuncePricePrompt.TabIndex = 4
        Me.lblPerOuncePricePrompt.Text = "Enter the price per ounce"
        Me.lblPerOuncePricePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumOunces
        '
        Me.txtNumOunces.Location = New System.Drawing.Point(189, 73)
        Me.txtNumOunces.Name = "txtNumOunces"
        Me.txtNumOunces.Size = New System.Drawing.Size(83, 20)
        Me.txtNumOunces.TabIndex = 5
        '
        'txtPricePerOunce
        '
        Me.txtPricePerOunce.Location = New System.Drawing.Point(189, 109)
        Me.txtPricePerOunce.Name = "txtPricePerOunce"
        Me.txtPricePerOunce.Size = New System.Drawing.Size(83, 20)
        Me.txtPricePerOunce.TabIndex = 6
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(12, 135)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(260, 23)
        Me.btnCost.TabIndex = 7
        Me.btnCost.Text = "Calculate Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 161)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 91)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCandy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtPricePerOunce)
        Me.Controls.Add(Me.txtNumOunces)
        Me.Controls.Add(Me.lblPerOuncePricePrompt)
        Me.Controls.Add(Me.lblNumOuncesPrompt)
        Me.Controls.Add(Me.txtFavoriteCandy)
        Me.Controls.Add(Me.lblFavoriteCandyPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCandy"
        Me.Text = "Candy"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFavoriteCandyPrompt As System.Windows.Forms.Label
    Friend WithEvents txtFavoriteCandy As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOuncesPrompt As System.Windows.Forms.Label
    Friend WithEvents lblPerOuncePricePrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumOunces As System.Windows.Forms.TextBox
    Friend WithEvents txtPricePerOunce As System.Windows.Forms.TextBox
    Friend WithEvents btnCost As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
