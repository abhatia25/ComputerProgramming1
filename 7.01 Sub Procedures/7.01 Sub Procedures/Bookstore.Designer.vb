<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookstore
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
        Me.lblItemsPrompt = New System.Windows.Forms.Label()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.lblQuantityPrompt = New System.Windows.Forms.Label()
        Me.cboQuantity = New System.Windows.Forms.ComboBox()
        Me.picShoppingCart = New System.Windows.Forms.PictureBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picShoppingCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(379, 24)
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
        'lblItemsPrompt
        '
        Me.lblItemsPrompt.AutoSize = True
        Me.lblItemsPrompt.Location = New System.Drawing.Point(12, 37)
        Me.lblItemsPrompt.Name = "lblItemsPrompt"
        Me.lblItemsPrompt.Size = New System.Drawing.Size(27, 13)
        Me.lblItemsPrompt.TabIndex = 1
        Me.lblItemsPrompt.Text = "Item"
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Items.AddRange(New Object() {"pencil", "t-shirt", "pen", "colored pencil", "marker", "crayon"})
        Me.lstItems.Location = New System.Drawing.Point(45, 35)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(86, 17)
        Me.lstItems.TabIndex = 2
        '
        'lblQuantityPrompt
        '
        Me.lblQuantityPrompt.AutoSize = True
        Me.lblQuantityPrompt.Location = New System.Drawing.Point(12, 76)
        Me.lblQuantityPrompt.Name = "lblQuantityPrompt"
        Me.lblQuantityPrompt.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantityPrompt.TabIndex = 3
        Me.lblQuantityPrompt.Text = "Quantity"
        '
        'cboQuantity
        '
        Me.cboQuantity.FormattingEnabled = True
        Me.cboQuantity.Location = New System.Drawing.Point(64, 73)
        Me.cboQuantity.Name = "cboQuantity"
        Me.cboQuantity.Size = New System.Drawing.Size(67, 21)
        Me.cboQuantity.TabIndex = 4
        '
        'picShoppingCart
        '
        Me.picShoppingCart.BackgroundImage = Global._7._01_Sub_Procedures.My.Resources.Resources.shopping_cart
        Me.picShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShoppingCart.Location = New System.Drawing.Point(176, 27)
        Me.picShoppingCart.Name = "picShoppingCart"
        Me.picShoppingCart.Size = New System.Drawing.Size(191, 108)
        Me.picShoppingCart.TabIndex = 5
        Me.picShoppingCart.TabStop = False
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(34, 109)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToCart.TabIndex = 6
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.Location = New System.Drawing.Point(237, 37)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(96, 82)
        Me.lstShoppingCart.TabIndex = 7
        '
        'frmBookstore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 144)
        Me.Controls.Add(Me.lstShoppingCart)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.picShoppingCart)
        Me.Controls.Add(Me.cboQuantity)
        Me.Controls.Add(Me.lblQuantityPrompt)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.lblItemsPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBookstore"
        Me.Text = "Bookstore"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picShoppingCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblItemsPrompt As System.Windows.Forms.Label
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents lblQuantityPrompt As System.Windows.Forms.Label
    Friend WithEvents cboQuantity As System.Windows.Forms.ComboBox
    Friend WithEvents picShoppingCart As System.Windows.Forms.PictureBox
    Friend WithEvents btnAddToCart As System.Windows.Forms.Button
    Friend WithEvents lstShoppingCart As System.Windows.Forms.ListBox
End Class
