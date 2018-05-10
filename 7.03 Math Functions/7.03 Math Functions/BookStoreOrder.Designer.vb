<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookStoreOrder
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
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.cboQuantity = New System.Windows.Forms.ComboBox()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
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
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Items.AddRange(New Object() {"Geography Book", "Math Book", "AP Review Book", "SAT Prep Book", "Pencil", "Pen", "Mints", "Gum"})
        Me.lstItem.Location = New System.Drawing.Point(12, 27)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(133, 199)
        Me.lstItem.TabIndex = 1
        '
        'cboQuantity
        '
        Me.cboQuantity.FormattingEnabled = True
        Me.cboQuantity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboQuantity.Location = New System.Drawing.Point(151, 118)
        Me.cboQuantity.Name = "cboQuantity"
        Me.cboQuantity.Size = New System.Drawing.Size(121, 21)
        Me.cboQuantity.TabIndex = 2
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.Location = New System.Drawing.Point(277, 27)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(133, 199)
        Me.lstCart.TabIndex = 3
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(170, 244)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToCart.TabIndex = 4
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'frmBookStoreOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 275)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.cboQuantity)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBookStoreOrder"
        Me.Text = "Book Store Order"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstItem As System.Windows.Forms.ListBox
    Friend WithEvents cboQuantity As System.Windows.Forms.ComboBox
    Friend WithEvents lstCart As System.Windows.Forms.ListBox
    Friend WithEvents btnAddToCart As System.Windows.Forms.Button
End Class
