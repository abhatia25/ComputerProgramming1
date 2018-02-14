<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovieSelector
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpMovieType = New System.Windows.Forms.GroupBox()
        Me.radMovieType6 = New System.Windows.Forms.RadioButton()
        Me.radMovieType5 = New System.Windows.Forms.RadioButton()
        Me.radMovieType4 = New System.Windows.Forms.RadioButton()
        Me.radMovieType3 = New System.Windows.Forms.RadioButton()
        Me.radMovieType2 = New System.Windows.Forms.RadioButton()
        Me.radMovieType1 = New System.Windows.Forms.RadioButton()
        Me.lblMovieTitle = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnQuantity1 = New System.Windows.Forms.Button()
        Me.btnQuantity2 = New System.Windows.Forms.Button()
        Me.btnQuantity3 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDone = New System.Windows.Forms.Label()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMovieType.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(282, 55)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(121, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Movie Selector"
        '
        'grpMovieType
        '
        Me.grpMovieType.Controls.Add(Me.radMovieType6)
        Me.grpMovieType.Controls.Add(Me.radMovieType5)
        Me.grpMovieType.Controls.Add(Me.radMovieType4)
        Me.grpMovieType.Controls.Add(Me.radMovieType3)
        Me.grpMovieType.Controls.Add(Me.radMovieType2)
        Me.grpMovieType.Controls.Add(Me.radMovieType1)
        Me.grpMovieType.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMovieType.Location = New System.Drawing.Point(12, 121)
        Me.grpMovieType.Name = "grpMovieType"
        Me.grpMovieType.Size = New System.Drawing.Size(689, 135)
        Me.grpMovieType.TabIndex = 1
        Me.grpMovieType.TabStop = False
        Me.grpMovieType.Text = "Select the type of movie you wish to see"
        '
        'radMovieType6
        '
        Me.radMovieType6.AutoSize = True
        Me.radMovieType6.Cursor = System.Windows.Forms.Cursors.No
        Me.radMovieType6.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMovieType6.Location = New System.Drawing.Point(551, 103)
        Me.radMovieType6.Name = "radMovieType6"
        Me.radMovieType6.Size = New System.Drawing.Size(72, 28)
        Me.radMovieType6.TabIndex = 5
        Me.radMovieType6.Text = "Adventure"
        Me.radMovieType6.UseVisualStyleBackColor = True
        '
        'radMovieType5
        '
        Me.radMovieType5.AutoSize = True
        Me.radMovieType5.Cursor = System.Windows.Forms.Cursors.No
        Me.radMovieType5.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMovieType5.Location = New System.Drawing.Point(277, 103)
        Me.radMovieType5.Name = "radMovieType5"
        Me.radMovieType5.Size = New System.Drawing.Size(56, 28)
        Me.radMovieType5.TabIndex = 4
        Me.radMovieType5.Text = "Family"
        Me.radMovieType5.UseVisualStyleBackColor = True
        '
        'radMovieType4
        '
        Me.radMovieType4.AutoSize = True
        Me.radMovieType4.Cursor = System.Windows.Forms.Cursors.No
        Me.radMovieType4.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMovieType4.Location = New System.Drawing.Point(19, 103)
        Me.radMovieType4.Name = "radMovieType4"
        Me.radMovieType4.Size = New System.Drawing.Size(56, 28)
        Me.radMovieType4.TabIndex = 3
        Me.radMovieType4.Text = "Drama"
        Me.radMovieType4.UseVisualStyleBackColor = True
        '
        'radMovieType3
        '
        Me.radMovieType3.AutoSize = True
        Me.radMovieType3.Cursor = System.Windows.Forms.Cursors.No
        Me.radMovieType3.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMovieType3.Location = New System.Drawing.Point(551, 37)
        Me.radMovieType3.Name = "radMovieType3"
        Me.radMovieType3.Size = New System.Drawing.Size(84, 28)
        Me.radMovieType3.TabIndex = 2
        Me.radMovieType3.Text = "Documentary"
        Me.radMovieType3.UseVisualStyleBackColor = True
        '
        'radMovieType2
        '
        Me.radMovieType2.AutoSize = True
        Me.radMovieType2.Cursor = System.Windows.Forms.Cursors.No
        Me.radMovieType2.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMovieType2.Location = New System.Drawing.Point(277, 37)
        Me.radMovieType2.Name = "radMovieType2"
        Me.radMovieType2.Size = New System.Drawing.Size(55, 28)
        Me.radMovieType2.TabIndex = 1
        Me.radMovieType2.Text = "Action"
        Me.radMovieType2.UseVisualStyleBackColor = True
        '
        'radMovieType1
        '
        Me.radMovieType1.AutoSize = True
        Me.radMovieType1.Cursor = System.Windows.Forms.Cursors.No
        Me.radMovieType1.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMovieType1.Location = New System.Drawing.Point(19, 37)
        Me.radMovieType1.Name = "radMovieType1"
        Me.radMovieType1.Size = New System.Drawing.Size(61, 28)
        Me.radMovieType1.TabIndex = 0
        Me.radMovieType1.Text = "Comedy"
        Me.radMovieType1.UseVisualStyleBackColor = True
        '
        'lblMovieTitle
        '
        Me.lblMovieTitle.AutoSize = True
        Me.lblMovieTitle.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieTitle.Location = New System.Drawing.Point(28, 279)
        Me.lblMovieTitle.Name = "lblMovieTitle"
        Me.lblMovieTitle.Size = New System.Drawing.Size(0, 24)
        Me.lblMovieTitle.TabIndex = 2
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(27, 307)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(149, 21)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "How many movies will you be renting?"
        '
        'btnQuantity1
        '
        Me.btnQuantity1.Cursor = System.Windows.Forms.Cursors.PanSE
        Me.btnQuantity1.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuantity1.Location = New System.Drawing.Point(31, 349)
        Me.btnQuantity1.Name = "btnQuantity1"
        Me.btnQuantity1.Size = New System.Drawing.Size(39, 27)
        Me.btnQuantity1.TabIndex = 4
        Me.btnQuantity1.Text = "1"
        Me.btnQuantity1.UseVisualStyleBackColor = True
        '
        'btnQuantity2
        '
        Me.btnQuantity2.Cursor = System.Windows.Forms.Cursors.PanSE
        Me.btnQuantity2.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuantity2.Location = New System.Drawing.Point(103, 349)
        Me.btnQuantity2.Name = "btnQuantity2"
        Me.btnQuantity2.Size = New System.Drawing.Size(39, 27)
        Me.btnQuantity2.TabIndex = 5
        Me.btnQuantity2.Text = "2"
        Me.btnQuantity2.UseVisualStyleBackColor = True
        '
        'btnQuantity3
        '
        Me.btnQuantity3.Cursor = System.Windows.Forms.Cursors.PanSE
        Me.btnQuantity3.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuantity3.Location = New System.Drawing.Point(175, 349)
        Me.btnQuantity3.Name = "btnQuantity3"
        Me.btnQuantity3.Size = New System.Drawing.Size(39, 27)
        Me.btnQuantity3.TabIndex = 6
        Me.btnQuantity3.Text = "3"
        Me.btnQuantity3.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(31, 404)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 21)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total: $"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(71, 404)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 21)
        Me.lblTotalCost.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 32)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 28)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblDone
        '
        Me.lblDone.AutoSize = True
        Me.lblDone.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDone.Location = New System.Drawing.Point(589, 355)
        Me.lblDone.Name = "lblDone"
        Me.lblDone.Size = New System.Drawing.Size(0, 21)
        Me.lblDone.TabIndex = 10
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(44, 28)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'frmMovieSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 448)
        Me.Controls.Add(Me.lblDone)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnQuantity3)
        Me.Controls.Add(Me.btnQuantity2)
        Me.Controls.Add(Me.btnQuantity1)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblMovieTitle)
        Me.Controls.Add(Me.grpMovieType)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMovieSelector"
        Me.Text = "Movie Selector"
        Me.grpMovieType.ResumeLayout(False)
        Me.grpMovieType.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpMovieType As System.Windows.Forms.GroupBox
    Friend WithEvents radMovieType6 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType5 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType4 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType3 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType2 As System.Windows.Forms.RadioButton
    Friend WithEvents radMovieType1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblMovieTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnQuantity1 As System.Windows.Forms.Button
    Friend WithEvents btnQuantity2 As System.Windows.Forms.Button
    Friend WithEvents btnQuantity3 As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDone As System.Windows.Forms.Label
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
