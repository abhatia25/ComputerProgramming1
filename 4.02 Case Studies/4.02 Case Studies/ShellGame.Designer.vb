<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShellGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShellGame))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseStudyCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumberOfDigitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picPearl1 = New System.Windows.Forms.PictureBox()
        Me.picPearl2 = New System.Windows.Forms.PictureBox()
        Me.picPearl3 = New System.Windows.Forms.PictureBox()
        Me.picShell1 = New System.Windows.Forms.PictureBox()
        Me.picShell2 = New System.Windows.Forms.PictureBox()
        Me.picShell3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picPearl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPearl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShell1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShell2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShell3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(438, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseStudyCalculatorToolStripMenuItem, Me.NumberOfDigitsToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'CaseStudyCalculatorToolStripMenuItem
        '
        Me.CaseStudyCalculatorToolStripMenuItem.Name = "CaseStudyCalculatorToolStripMenuItem"
        Me.CaseStudyCalculatorToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CaseStudyCalculatorToolStripMenuItem.Text = "&Case Study Calculator"
        '
        'NumberOfDigitsToolStripMenuItem
        '
        Me.NumberOfDigitsToolStripMenuItem.Name = "NumberOfDigitsToolStripMenuItem"
        Me.NumberOfDigitsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NumberOfDigitsToolStripMenuItem.Text = "&Number of Digits"
        '
        'picPearl1
        '
        Me.picPearl1.Image = CType(resources.GetObject("picPearl1.Image"), System.Drawing.Image)
        Me.picPearl1.Location = New System.Drawing.Point(44, 207)
        Me.picPearl1.Name = "picPearl1"
        Me.picPearl1.Size = New System.Drawing.Size(32, 32)
        Me.picPearl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPearl1.TabIndex = 2
        Me.picPearl1.TabStop = False
        Me.picPearl1.Tag = "1"
        Me.picPearl1.Visible = False
        '
        'picPearl2
        '
        Me.picPearl2.Image = CType(resources.GetObject("picPearl2.Image"), System.Drawing.Image)
        Me.picPearl2.Location = New System.Drawing.Point(201, 207)
        Me.picPearl2.Name = "picPearl2"
        Me.picPearl2.Size = New System.Drawing.Size(32, 32)
        Me.picPearl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPearl2.TabIndex = 5
        Me.picPearl2.TabStop = False
        Me.picPearl2.Tag = "2"
        Me.picPearl2.Visible = False
        '
        'picPearl3
        '
        Me.picPearl3.Image = CType(resources.GetObject("picPearl3.Image"), System.Drawing.Image)
        Me.picPearl3.Location = New System.Drawing.Point(354, 207)
        Me.picPearl3.Name = "picPearl3"
        Me.picPearl3.Size = New System.Drawing.Size(32, 32)
        Me.picPearl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPearl3.TabIndex = 6
        Me.picPearl3.TabStop = False
        Me.picPearl3.Tag = "3"
        Me.picPearl3.Visible = False
        '
        'picShell1
        '
        Me.picShell1.Image = CType(resources.GetObject("picShell1.Image"), System.Drawing.Image)
        Me.picShell1.Location = New System.Drawing.Point(12, 63)
        Me.picShell1.Name = "picShell1"
        Me.picShell1.Size = New System.Drawing.Size(110, 110)
        Me.picShell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell1.TabIndex = 7
        Me.picShell1.TabStop = False
        Me.picShell1.Tag = "1"
        '
        'picShell2
        '
        Me.picShell2.Image = CType(resources.GetObject("picShell2.Image"), System.Drawing.Image)
        Me.picShell2.Location = New System.Drawing.Point(157, 63)
        Me.picShell2.Name = "picShell2"
        Me.picShell2.Size = New System.Drawing.Size(110, 110)
        Me.picShell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell2.TabIndex = 8
        Me.picShell2.TabStop = False
        Me.picShell2.Tag = "2"
        '
        'picShell3
        '
        Me.picShell3.Image = CType(resources.GetObject("picShell3.Image"), System.Drawing.Image)
        Me.picShell3.Location = New System.Drawing.Point(316, 63)
        Me.picShell3.Name = "picShell3"
        Me.picShell3.Size = New System.Drawing.Size(110, 110)
        Me.picShell3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShell3.TabIndex = 9
        Me.picShell3.TabStop = False
        Me.picShell3.Tag = "3"
        '
        'frmShellGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 416)
        Me.Controls.Add(Me.picShell3)
        Me.Controls.Add(Me.picShell2)
        Me.Controls.Add(Me.picShell1)
        Me.Controls.Add(Me.picPearl3)
        Me.Controls.Add(Me.picPearl2)
        Me.Controls.Add(Me.picPearl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmShellGame"
        Me.Text = "The Shell Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picPearl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPearl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShell1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShell2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShell3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaseStudyCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumberOfDigitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picPearl1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPearl2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPearl3 As System.Windows.Forms.PictureBox
    Friend WithEvents picShell1 As System.Windows.Forms.PictureBox
    Friend WithEvents picShell2 As System.Windows.Forms.PictureBox
    Friend WithEvents picShell3 As System.Windows.Forms.PictureBox
End Class
