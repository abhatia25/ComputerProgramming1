<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.picInventory1 = New System.Windows.Forms.PictureBox()
        Me.picInventory2 = New System.Windows.Forms.PictureBox()
        Me.picInventory3 = New System.Windows.Forms.PictureBox()
        Me.picInventory4 = New System.Windows.Forms.PictureBox()
        Me.picInventory6 = New System.Windows.Forms.PictureBox()
        Me.picInventory5 = New System.Windows.Forms.PictureBox()
        Me.lblInventory1 = New System.Windows.Forms.Label()
        Me.lblInventory2 = New System.Windows.Forms.Label()
        Me.lblInventory3 = New System.Windows.Forms.Label()
        Me.lblInventory4 = New System.Windows.Forms.Label()
        Me.lblInventory6 = New System.Windows.Forms.Label()
        Me.lblInventory5 = New System.Windows.Forms.Label()
        CType(Me.picInventory1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInventory5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(12, 264)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(425, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'picInventory1
        '
        Me.picInventory1.Location = New System.Drawing.Point(12, 12)
        Me.picInventory1.Name = "picInventory1"
        Me.picInventory1.Size = New System.Drawing.Size(69, 59)
        Me.picInventory1.TabIndex = 1
        Me.picInventory1.TabStop = False
        '
        'picInventory2
        '
        Me.picInventory2.Location = New System.Drawing.Point(12, 104)
        Me.picInventory2.Name = "picInventory2"
        Me.picInventory2.Size = New System.Drawing.Size(69, 59)
        Me.picInventory2.TabIndex = 2
        Me.picInventory2.TabStop = False
        '
        'picInventory3
        '
        Me.picInventory3.Location = New System.Drawing.Point(12, 199)
        Me.picInventory3.Name = "picInventory3"
        Me.picInventory3.Size = New System.Drawing.Size(69, 59)
        Me.picInventory3.TabIndex = 3
        Me.picInventory3.TabStop = False
        '
        'picInventory4
        '
        Me.picInventory4.Location = New System.Drawing.Point(232, 12)
        Me.picInventory4.Name = "picInventory4"
        Me.picInventory4.Size = New System.Drawing.Size(69, 59)
        Me.picInventory4.TabIndex = 4
        Me.picInventory4.TabStop = False
        '
        'picInventory6
        '
        Me.picInventory6.Location = New System.Drawing.Point(232, 199)
        Me.picInventory6.Name = "picInventory6"
        Me.picInventory6.Size = New System.Drawing.Size(69, 59)
        Me.picInventory6.TabIndex = 5
        Me.picInventory6.TabStop = False
        '
        'picInventory5
        '
        Me.picInventory5.Location = New System.Drawing.Point(232, 104)
        Me.picInventory5.Name = "picInventory5"
        Me.picInventory5.Size = New System.Drawing.Size(69, 59)
        Me.picInventory5.TabIndex = 6
        Me.picInventory5.TabStop = False
        '
        'lblInventory1
        '
        Me.lblInventory1.Location = New System.Drawing.Point(87, 12)
        Me.lblInventory1.Name = "lblInventory1"
        Me.lblInventory1.Size = New System.Drawing.Size(84, 59)
        Me.lblInventory1.TabIndex = 7
        Me.lblInventory1.Text = "Quantity: 0"
        Me.lblInventory1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInventory2
        '
        Me.lblInventory2.Location = New System.Drawing.Point(87, 104)
        Me.lblInventory2.Name = "lblInventory2"
        Me.lblInventory2.Size = New System.Drawing.Size(84, 59)
        Me.lblInventory2.TabIndex = 8
        Me.lblInventory2.Text = "Quantity: 0"
        Me.lblInventory2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInventory3
        '
        Me.lblInventory3.Location = New System.Drawing.Point(87, 199)
        Me.lblInventory3.Name = "lblInventory3"
        Me.lblInventory3.Size = New System.Drawing.Size(84, 59)
        Me.lblInventory3.TabIndex = 9
        Me.lblInventory3.Text = "Quantity: 0"
        Me.lblInventory3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInventory4
        '
        Me.lblInventory4.Location = New System.Drawing.Point(307, 12)
        Me.lblInventory4.Name = "lblInventory4"
        Me.lblInventory4.Size = New System.Drawing.Size(84, 59)
        Me.lblInventory4.TabIndex = 10
        Me.lblInventory4.Text = "Quantity: 0"
        Me.lblInventory4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInventory6
        '
        Me.lblInventory6.Location = New System.Drawing.Point(307, 199)
        Me.lblInventory6.Name = "lblInventory6"
        Me.lblInventory6.Size = New System.Drawing.Size(84, 59)
        Me.lblInventory6.TabIndex = 11
        Me.lblInventory6.Text = "Quantity: 0"
        Me.lblInventory6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInventory5
        '
        Me.lblInventory5.Location = New System.Drawing.Point(307, 104)
        Me.lblInventory5.Name = "lblInventory5"
        Me.lblInventory5.Size = New System.Drawing.Size(84, 59)
        Me.lblInventory5.TabIndex = 12
        Me.lblInventory5.Text = "Quantity: 0"
        Me.lblInventory5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 303)
        Me.Controls.Add(Me.lblInventory5)
        Me.Controls.Add(Me.lblInventory6)
        Me.Controls.Add(Me.lblInventory4)
        Me.Controls.Add(Me.lblInventory3)
        Me.Controls.Add(Me.lblInventory2)
        Me.Controls.Add(Me.lblInventory1)
        Me.Controls.Add(Me.picInventory5)
        Me.Controls.Add(Me.picInventory6)
        Me.Controls.Add(Me.picInventory4)
        Me.Controls.Add(Me.picInventory3)
        Me.Controls.Add(Me.picInventory2)
        Me.Controls.Add(Me.picInventory1)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.picInventory1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInventory5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents picInventory1 As System.Windows.Forms.PictureBox
    Friend WithEvents picInventory2 As System.Windows.Forms.PictureBox
    Friend WithEvents picInventory3 As System.Windows.Forms.PictureBox
    Friend WithEvents picInventory4 As System.Windows.Forms.PictureBox
    Friend WithEvents picInventory6 As System.Windows.Forms.PictureBox
    Friend WithEvents picInventory5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblInventory1 As System.Windows.Forms.Label
    Friend WithEvents lblInventory2 As System.Windows.Forms.Label
    Friend WithEvents lblInventory3 As System.Windows.Forms.Label
    Friend WithEvents lblInventory4 As System.Windows.Forms.Label
    Friend WithEvents lblInventory6 As System.Windows.Forms.Label
    Friend WithEvents lblInventory5 As System.Windows.Forms.Label
End Class
