<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrystalRoom
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
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.White
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Location = New System.Drawing.Point(12, 215)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(116, 43)
        Me.btnDown.TabIndex = 0
        Me.btnDown.Text = "Go down to the basement"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(12, 386)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'frmCrystalRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Main_Building__CRYSTAL_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(821, 421)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnDown)
        Me.Name = "frmCrystalRoom"
        Me.Text = "Crystal Room"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
End Class
