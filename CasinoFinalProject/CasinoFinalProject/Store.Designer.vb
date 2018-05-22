<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStore
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
        Me.btnMoney = New System.Windows.Forms.Button()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.cstItems = New System.Windows.Forms.CheckedListBox()
        Me.cboQuantity = New System.Windows.Forms.ComboBox()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMoney
        '
        Me.btnMoney.Location = New System.Drawing.Point(12, 12)
        Me.btnMoney.Name = "btnMoney"
        Me.btnMoney.Size = New System.Drawing.Size(456, 23)
        Me.btnMoney.TabIndex = 0
        Me.btnMoney.Text = "Money"
        Me.btnMoney.UseVisualStyleBackColor = True
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(322, 129)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(120, 95)
        Me.lstItems.TabIndex = 2
        '
        'cstItems
        '
        Me.cstItems.FormattingEnabled = True
        Me.cstItems.Items.AddRange(New Object() {"Candy", "$200 Gift Card", "$300 Gift Card"})
        Me.cstItems.Location = New System.Drawing.Point(12, 80)
        Me.cstItems.Name = "cstItems"
        Me.cstItems.Size = New System.Drawing.Size(236, 124)
        Me.cstItems.TabIndex = 3
        '
        'cboQuantity
        '
        Me.cboQuantity.FormattingEnabled = True
        Me.cboQuantity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboQuantity.Location = New System.Drawing.Point(12, 230)
        Me.cboQuantity.Name = "cboQuantity"
        Me.cboQuantity.Size = New System.Drawing.Size(236, 21)
        Me.cboQuantity.TabIndex = 4
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(9, 64)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(27, 13)
        Me.lblPrompt1.TabIndex = 5
        Me.lblPrompt1.Text = "Item"
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 214)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(46, 13)
        Me.lblPrompt2.TabIndex = 6
        Me.lblPrompt2.Text = "Quantity"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(15, 336)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(453, 23)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CasinoFinalProject.My.Resources.Resources.shopping_cart
        Me.PictureBox1.Location = New System.Drawing.Point(254, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(90, 257)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToCart.TabIndex = 8
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'frmStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 371)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Controls.Add(Me.cboQuantity)
        Me.Controls.Add(Me.cstItems)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMoney)
        Me.Name = "frmStore"
        Me.Text = "Store"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMoney As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents cstItems As System.Windows.Forms.CheckedListBox
    Friend WithEvents cboQuantity As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrompt1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnAddToCart As Button
End Class
