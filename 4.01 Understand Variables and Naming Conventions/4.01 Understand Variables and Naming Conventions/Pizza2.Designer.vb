<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizza2
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
        Me.HelloAgainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadyForSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCrustPrompt = New System.Windows.Forms.Label()
        Me.lblTopping1Prompt = New System.Windows.Forms.Label()
        Me.lblTopping2Prompt = New System.Windows.Forms.Label()
        Me.txtCrust = New System.Windows.Forms.TextBox()
        Me.txtTopping1 = New System.Windows.Forms.TextBox()
        Me.txtTopping2 = New System.Windows.Forms.TextBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(419, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloAgainToolStripMenuItem, Me.GradesToolStripMenuItem, Me.CircleAreaToolStripMenuItem, Me.ReadyForSchoolToolStripMenuItem, Me.ScopeToolStripMenuItem, Me.CountingToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'HelloAgainToolStripMenuItem
        '
        Me.HelloAgainToolStripMenuItem.Name = "HelloAgainToolStripMenuItem"
        Me.HelloAgainToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.HelloAgainToolStripMenuItem.Text = "&Hello Again"
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.GradesToolStripMenuItem.Text = "&Grades"
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
        'CountingToolStripMenuItem
        '
        Me.CountingToolStripMenuItem.Name = "CountingToolStripMenuItem"
        Me.CountingToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CountingToolStripMenuItem.Text = "Countin&g"
        '
        'ScopeToolStripMenuItem
        '
        Me.ScopeToolStripMenuItem.Name = "ScopeToolStripMenuItem"
        Me.ScopeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ScopeToolStripMenuItem.Text = "&Scope"
        '
        'lblCrustPrompt
        '
        Me.lblCrustPrompt.Location = New System.Drawing.Point(12, 40)
        Me.lblCrustPrompt.Name = "lblCrustPrompt"
        Me.lblCrustPrompt.Size = New System.Drawing.Size(212, 36)
        Me.lblCrustPrompt.TabIndex = 1
        Me.lblCrustPrompt.Text = "Enter your choice of crust (thin, thick, regular)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblCrustPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopping1Prompt
        '
        Me.lblTopping1Prompt.Location = New System.Drawing.Point(12, 94)
        Me.lblTopping1Prompt.Name = "lblTopping1Prompt"
        Me.lblTopping1Prompt.Size = New System.Drawing.Size(212, 36)
        Me.lblTopping1Prompt.TabIndex = 2
        Me.lblTopping1Prompt.Text = "Enter your choice of topping" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTopping1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTopping2Prompt
        '
        Me.lblTopping2Prompt.Location = New System.Drawing.Point(12, 148)
        Me.lblTopping2Prompt.Name = "lblTopping2Prompt"
        Me.lblTopping2Prompt.Size = New System.Drawing.Size(212, 36)
        Me.lblTopping2Prompt.TabIndex = 3
        Me.lblTopping2Prompt.Text = "Enter your choice of topping" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTopping2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCrust
        '
        Me.txtCrust.Location = New System.Drawing.Point(230, 49)
        Me.txtCrust.Name = "txtCrust"
        Me.txtCrust.Size = New System.Drawing.Size(159, 20)
        Me.txtCrust.TabIndex = 4
        '
        'txtTopping1
        '
        Me.txtTopping1.Location = New System.Drawing.Point(230, 94)
        Me.txtTopping1.Name = "txtTopping1"
        Me.txtTopping1.Size = New System.Drawing.Size(159, 20)
        Me.txtTopping1.TabIndex = 5
        '
        'txtTopping2
        '
        Me.txtTopping2.Location = New System.Drawing.Point(230, 148)
        Me.txtTopping2.Name = "txtTopping2"
        Me.txtTopping2.Size = New System.Drawing.Size(159, 20)
        Me.txtTopping2.TabIndex = 6
        '
        'lblOrder
        '
        Me.lblOrder.Location = New System.Drawing.Point(12, 184)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(395, 89)
        Me.lblOrder.TabIndex = 7
        Me.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(171, 302)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 8
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'frmPizza2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 337)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.txtTopping2)
        Me.Controls.Add(Me.txtTopping1)
        Me.Controls.Add(Me.txtCrust)
        Me.Controls.Add(Me.lblTopping2Prompt)
        Me.Controls.Add(Me.lblTopping1Prompt)
        Me.Controls.Add(Me.lblCrustPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPizza2"
        Me.Text = "Pizza2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloAgainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircleAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadyForSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScopeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCrustPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTopping1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblTopping2Prompt As System.Windows.Forms.Label
    Friend WithEvents txtCrust As System.Windows.Forms.TextBox
    Friend WithEvents txtTopping1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTopping2 As System.Windows.Forms.TextBox
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
End Class
