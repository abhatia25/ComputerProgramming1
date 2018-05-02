<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaceship
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
        Me.picHandgun = New System.Windows.Forms.PictureBox()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnSpaceStation = New System.Windows.Forms.Button()
        Me.btnAliens = New System.Windows.Forms.Button()
        CType(Me.picHandgun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHandgun
        '
        Me.picHandgun.BackgroundImage = Global.Space_Project.My.Resources.Resources.handgun
        Me.picHandgun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHandgun.Location = New System.Drawing.Point(133, 296)
        Me.picHandgun.Name = "picHandgun"
        Me.picHandgun.Size = New System.Drawing.Size(52, 36)
        Me.picHandgun.TabIndex = 0
        Me.picHandgun.TabStop = False
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(12, 433)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnSpaceStation
        '
        Me.btnSpaceStation.Location = New System.Drawing.Point(593, 433)
        Me.btnSpaceStation.Name = "btnSpaceStation"
        Me.btnSpaceStation.Size = New System.Drawing.Size(133, 23)
        Me.btnSpaceStation.TabIndex = 2
        Me.btnSpaceStation.Text = "Enter the space station"
        Me.btnSpaceStation.UseVisualStyleBackColor = True
        '
        'btnAliens
        '
        Me.btnAliens.BackColor = System.Drawing.Color.Transparent
        Me.btnAliens.FlatAppearance.BorderSize = 0
        Me.btnAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAliens.Location = New System.Drawing.Point(510, 176)
        Me.btnAliens.Name = "btnAliens"
        Me.btnAliens.Size = New System.Drawing.Size(125, 156)
        Me.btnAliens.TabIndex = 3
        Me.btnAliens.UseVisualStyleBackColor = False
        '
        'frmSpaceship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.spaceship_interior
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 468)
        Me.Controls.Add(Me.btnAliens)
        Me.Controls.Add(Me.btnSpaceStation)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.picHandgun)
        Me.Name = "frmSpaceship"
        Me.Text = "Spaceship"
        CType(Me.picHandgun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picHandgun As System.Windows.Forms.PictureBox
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnSpaceStation As System.Windows.Forms.Button
    Friend WithEvents btnAliens As System.Windows.Forms.Button
End Class
