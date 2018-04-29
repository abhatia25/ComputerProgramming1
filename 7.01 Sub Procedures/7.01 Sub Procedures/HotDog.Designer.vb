<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotDog
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
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkKraut = New System.Windows.Forms.CheckBox()
        Me.chkRelish = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblCurrentPrice = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(144, 24)
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
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkCheese)
        Me.grpToppings.Controls.Add(Me.chkKraut)
        Me.grpToppings.Controls.Add(Me.chkRelish)
        Me.grpToppings.Location = New System.Drawing.Point(12, 27)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(121, 124)
        Me.grpToppings.TabIndex = 1
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Toppings"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(6, 101)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 2
        Me.chkCheese.Tag = "Cheese"
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkKraut
        '
        Me.chkKraut.AutoSize = True
        Me.chkKraut.Location = New System.Drawing.Point(6, 58)
        Me.chkKraut.Name = "chkKraut"
        Me.chkKraut.Size = New System.Drawing.Size(51, 17)
        Me.chkKraut.TabIndex = 1
        Me.chkKraut.Tag = "Kraut"
        Me.chkKraut.Text = "Kraut"
        Me.chkKraut.UseVisualStyleBackColor = True
        '
        'chkRelish
        '
        Me.chkRelish.AutoSize = True
        Me.chkRelish.Location = New System.Drawing.Point(6, 19)
        Me.chkRelish.Name = "chkRelish"
        Me.chkRelish.Size = New System.Drawing.Size(55, 17)
        Me.chkRelish.TabIndex = 0
        Me.chkRelish.Tag = "Relish"
        Me.chkRelish.Text = "Relish"
        Me.chkRelish.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(12, 169)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(46, 23)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrentPrice
        '
        Me.lblCurrentPrice.Location = New System.Drawing.Point(64, 169)
        Me.lblCurrentPrice.Name = "lblCurrentPrice"
        Me.lblCurrentPrice.Size = New System.Drawing.Size(46, 23)
        Me.lblCurrentPrice.TabIndex = 4
        Me.lblCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmHotDog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(144, 211)
        Me.Controls.Add(Me.lblCurrentPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHotDog"
        Me.Text = "Hot Dog II"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpToppings As GroupBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents chkKraut As CheckBox
    Friend WithEvents chkRelish As CheckBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblCurrentPrice As Label
End Class
