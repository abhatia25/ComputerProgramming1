<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdditionPropertiesMenuStrip
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
        Me.btnAssociative = New System.Windows.Forms.Button()
        Me.btnCommutative = New System.Windows.Forms.Button()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssociativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommutativeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAssociative
        '
        Me.btnAssociative.Location = New System.Drawing.Point(25, 77)
        Me.btnAssociative.Name = "btnAssociative"
        Me.btnAssociative.Size = New System.Drawing.Size(75, 23)
        Me.btnAssociative.TabIndex = 0
        Me.btnAssociative.Text = "Associative"
        Me.btnAssociative.UseVisualStyleBackColor = True
        '
        'btnCommutative
        '
        Me.btnCommutative.Location = New System.Drawing.Point(198, 77)
        Me.btnCommutative.Name = "btnCommutative"
        Me.btnCommutative.Size = New System.Drawing.Size(81, 23)
        Me.btnCommutative.TabIndex = 1
        Me.btnCommutative.Text = "Commutative"
        Me.btnCommutative.UseVisualStyleBackColor = True
        '
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(112, 163)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(0, 13)
        Me.lblProperty.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(322, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssociativeToolStripMenuItem, Me.CommutativeToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'AssociativeToolStripMenuItem
        '
        Me.AssociativeToolStripMenuItem.Name = "AssociativeToolStripMenuItem"
        Me.AssociativeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AssociativeToolStripMenuItem.Text = "&Associative"
        '
        'CommutativeToolStripMenuItem
        '
        Me.CommutativeToolStripMenuItem.Name = "CommutativeToolStripMenuItem"
        Me.CommutativeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CommutativeToolStripMenuItem.Text = "&Commutative"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(75, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(169, 24)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Addition Properties"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(115, 226)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmAdditionPropertiesMenuStrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(322, 261)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblProperty)
        Me.Controls.Add(Me.btnCommutative)
        Me.Controls.Add(Me.btnAssociative)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdditionPropertiesMenuStrip"
        Me.Text = "Associative and Commutative Properties"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAssociative As System.Windows.Forms.Button
    Friend WithEvents btnCommutative As System.Windows.Forms.Button
    Friend WithEvents lblProperty As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents AssociativeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommutativeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
