<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloAgain
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
        Me.GradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pizza2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadyForSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.frmInstructions = New System.Windows.Forms.Label()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(320, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradesToolStripMenuItem, Me.Pizza2ToolStripMenuItem, Me.CircleAreaToolStripMenuItem, Me.ReadyForSchoolToolStripMenuItem, Me.ScopeToolStripMenuItem, Me.CountingToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.GradesToolStripMenuItem.Text = "&Grades"
        '
        'Pizza2ToolStripMenuItem
        '
        Me.Pizza2ToolStripMenuItem.Name = "Pizza2ToolStripMenuItem"
        Me.Pizza2ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.Pizza2ToolStripMenuItem.Text = "&Pizza2"
        '
        'CircleAreaToolStripMenuItem
        '
        Me.CircleAreaToolStripMenuItem.Name = "CircleAreaToolStripMenuItem"
        Me.CircleAreaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CircleAreaToolStripMenuItem.Text = "&Circle Area"
        '
        'ReadyForSchoolToolStripMenuItem
        '
        Me.ReadyForSchoolToolStripMenuItem.Name = "ReadyForSchoolToolStripMenuItem"
        Me.ReadyForSchoolToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ReadyForSchoolToolStripMenuItem.Text = "&Ready For School"
        '
        'ScopeToolStripMenuItem
        '
        Me.ScopeToolStripMenuItem.Name = "ScopeToolStripMenuItem"
        Me.ScopeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ScopeToolStripMenuItem.Text = "&Scope"
        '
        'CountingToolStripMenuItem
        '
        Me.CountingToolStripMenuItem.Name = "CountingToolStripMenuItem"
        Me.CountingToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CountingToolStripMenuItem.Text = "Countin&g"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(187, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'frmInstructions
        '
        Me.frmInstructions.Location = New System.Drawing.Point(29, 72)
        Me.frmInstructions.Name = "frmInstructions"
        Me.frmInstructions.Size = New System.Drawing.Size(152, 20)
        Me.frmInstructions.TabIndex = 2
        Me.frmInstructions.Text = "Enter your name:"
        Me.frmInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHello
        '
        Me.lblHello.Location = New System.Drawing.Point(12, 103)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(296, 91)
        Me.lblHello.TabIndex = 3
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(125, 247)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(75, 23)
        Me.btnHello.TabIndex = 4
        Me.btnHello.Text = "Say Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'frmHelloAgain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 282)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.frmInstructions)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHelloAgain"
        Me.Text = "Hello Again"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pizza2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircleAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadyForSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScopeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents frmInstructions As System.Windows.Forms.Label
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents btnHello As System.Windows.Forms.Button

End Class
