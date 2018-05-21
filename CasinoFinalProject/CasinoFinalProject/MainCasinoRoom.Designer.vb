<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainCasinoRoom
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
        Me.GAME1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAME2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAME3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAME4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAME5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DONEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picPayCoins = New System.Windows.Forms.PictureBox()
        Me.picBauld = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picPayCoins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBauld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GAME1ToolStripMenuItem, Me.GAME2ToolStripMenuItem, Me.GAME3ToolStripMenuItem, Me.GAME4ToolStripMenuItem, Me.GAME5ToolStripMenuItem, Me.DONEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(428, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GAME1ToolStripMenuItem
        '
        Me.GAME1ToolStripMenuItem.Name = "GAME1ToolStripMenuItem"
        Me.GAME1ToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GAME1ToolStripMenuItem.Text = "GAME 1"
        '
        'GAME2ToolStripMenuItem
        '
        Me.GAME2ToolStripMenuItem.Name = "GAME2ToolStripMenuItem"
        Me.GAME2ToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GAME2ToolStripMenuItem.Text = "GAME 2"
        '
        'GAME3ToolStripMenuItem
        '
        Me.GAME3ToolStripMenuItem.Name = "GAME3ToolStripMenuItem"
        Me.GAME3ToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GAME3ToolStripMenuItem.Text = "GAME 3"
        '
        'GAME4ToolStripMenuItem
        '
        Me.GAME4ToolStripMenuItem.Name = "GAME4ToolStripMenuItem"
        Me.GAME4ToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GAME4ToolStripMenuItem.Text = "GAME 4"
        '
        'GAME5ToolStripMenuItem
        '
        Me.GAME5ToolStripMenuItem.Name = "GAME5ToolStripMenuItem"
        Me.GAME5ToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GAME5ToolStripMenuItem.Text = "GAME 5"
        '
        'DONEToolStripMenuItem
        '
        Me.DONEToolStripMenuItem.Name = "DONEToolStripMenuItem"
        Me.DONEToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DONEToolStripMenuItem.Text = "DONE"
        '
        'picPayCoins
        '
        Me.picPayCoins.Image = Global.CasinoFinalProject.My.Resources.Resources.PayCoins
        Me.picPayCoins.Location = New System.Drawing.Point(203, 27)
        Me.picPayCoins.Name = "picPayCoins"
        Me.picPayCoins.Size = New System.Drawing.Size(213, 223)
        Me.picPayCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayCoins.TabIndex = 2
        Me.picPayCoins.TabStop = False
        '
        'picBauld
        '
        Me.picBauld.Image = Global.CasinoFinalProject.My.Resources.Resources.bauld
        Me.picBauld.Location = New System.Drawing.Point(12, 27)
        Me.picBauld.Name = "picBauld"
        Me.picBauld.Size = New System.Drawing.Size(185, 223)
        Me.picBauld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBauld.TabIndex = 1
        Me.picBauld.TabStop = False
        '
        'MainCasinoRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 262)
        Me.Controls.Add(Me.picPayCoins)
        Me.Controls.Add(Me.picBauld)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainCasinoRoom"
        Me.Text = "Main Casino Room"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picPayCoins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBauld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GAME1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAME2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAME3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAME4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAME5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DONEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picBauld As System.Windows.Forms.PictureBox
    Friend WithEvents picPayCoins As PictureBox
End Class
