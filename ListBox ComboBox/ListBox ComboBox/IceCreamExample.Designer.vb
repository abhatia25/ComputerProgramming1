<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIceCream
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
        Me.lstFlavors = New System.Windows.Forms.ListBox()
        Me.lblFlavors = New System.Windows.Forms.Label()
        Me.cboCone = New System.Windows.Forms.ComboBox()
        Me.lblCone = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstFlavors
        '
        Me.lstFlavors.FormattingEnabled = True
        Me.lstFlavors.Items.AddRange(New Object() {"Chocolate", "Strawberry", "Vanilla"})
        Me.lstFlavors.Location = New System.Drawing.Point(12, 51)
        Me.lstFlavors.Name = "lstFlavors"
        Me.lstFlavors.Size = New System.Drawing.Size(120, 95)
        Me.lstFlavors.TabIndex = 0
        '
        'lblFlavors
        '
        Me.lblFlavors.AutoSize = True
        Me.lblFlavors.Location = New System.Drawing.Point(12, 35)
        Me.lblFlavors.Name = "lblFlavors"
        Me.lblFlavors.Size = New System.Drawing.Size(41, 13)
        Me.lblFlavors.TabIndex = 1
        Me.lblFlavors.Text = "Flavors"
        '
        'cboCone
        '
        Me.cboCone.FormattingEnabled = True
        Me.cboCone.Items.AddRange(New Object() {"Cup", "Sugar Cone", "Waffle Cone"})
        Me.cboCone.Location = New System.Drawing.Point(151, 51)
        Me.cboCone.Name = "cboCone"
        Me.cboCone.Size = New System.Drawing.Size(121, 21)
        Me.cboCone.TabIndex = 2
        '
        'lblCone
        '
        Me.lblCone.AutoSize = True
        Me.lblCone.Location = New System.Drawing.Point(148, 35)
        Me.lblCone.Name = "lblCone"
        Me.lblCone.Size = New System.Drawing.Size(56, 13)
        Me.lblCone.TabIndex = 3
        Me.lblCone.Text = "Cone/Cup"
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(151, 123)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(121, 23)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.Location = New System.Drawing.Point(14, 172)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(258, 81)
        Me.lblOrder.TabIndex = 5
        Me.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmIceCream
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblCone)
        Me.Controls.Add(Me.cboCone)
        Me.Controls.Add(Me.lblFlavors)
        Me.Controls.Add(Me.lstFlavors)
        Me.Name = "frmIceCream"
        Me.Text = "Ice Cream"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFlavors As System.Windows.Forms.ListBox
    Friend WithEvents lblFlavors As System.Windows.Forms.Label
    Friend WithEvents cboCone As System.Windows.Forms.ComboBox
    Friend WithEvents lblCone As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblOrder As System.Windows.Forms.Label

End Class
