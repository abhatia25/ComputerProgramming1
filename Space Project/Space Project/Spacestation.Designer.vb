<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaceStation
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
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnPlanet1 = New System.Windows.Forms.Button()
        Me.btnPlanet2 = New System.Windows.Forms.Button()
        Me.btnPlanet3 = New System.Windows.Forms.Button()
        Me.btnPlanet4 = New System.Windows.Forms.Button()
        Me.btnSpaceship = New System.Windows.Forms.Button()
        Me.btnAliens = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(12, 382)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 0
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnPlanet1
        '
        Me.btnPlanet1.BackColor = System.Drawing.Color.Transparent
        Me.btnPlanet1.FlatAppearance.BorderSize = 0
        Me.btnPlanet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanet1.Location = New System.Drawing.Point(110, 83)
        Me.btnPlanet1.Name = "btnPlanet1"
        Me.btnPlanet1.Size = New System.Drawing.Size(58, 91)
        Me.btnPlanet1.TabIndex = 1
        Me.btnPlanet1.UseVisualStyleBackColor = False
        '
        'btnPlanet2
        '
        Me.btnPlanet2.BackColor = System.Drawing.Color.Transparent
        Me.btnPlanet2.FlatAppearance.BorderSize = 0
        Me.btnPlanet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanet2.Location = New System.Drawing.Point(191, 83)
        Me.btnPlanet2.Name = "btnPlanet2"
        Me.btnPlanet2.Size = New System.Drawing.Size(58, 91)
        Me.btnPlanet2.TabIndex = 2
        Me.btnPlanet2.UseVisualStyleBackColor = False
        '
        'btnPlanet3
        '
        Me.btnPlanet3.BackColor = System.Drawing.Color.Transparent
        Me.btnPlanet3.FlatAppearance.BorderSize = 0
        Me.btnPlanet3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanet3.Location = New System.Drawing.Point(452, 83)
        Me.btnPlanet3.Name = "btnPlanet3"
        Me.btnPlanet3.Size = New System.Drawing.Size(58, 91)
        Me.btnPlanet3.TabIndex = 3
        Me.btnPlanet3.UseVisualStyleBackColor = False
        '
        'btnPlanet4
        '
        Me.btnPlanet4.BackColor = System.Drawing.Color.Transparent
        Me.btnPlanet4.FlatAppearance.BorderSize = 0
        Me.btnPlanet4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanet4.Location = New System.Drawing.Point(12, 83)
        Me.btnPlanet4.Name = "btnPlanet4"
        Me.btnPlanet4.Size = New System.Drawing.Size(58, 91)
        Me.btnPlanet4.TabIndex = 4
        Me.btnPlanet4.UseVisualStyleBackColor = False
        '
        'btnSpaceship
        '
        Me.btnSpaceship.Location = New System.Drawing.Point(421, 382)
        Me.btnSpaceship.Name = "btnSpaceship"
        Me.btnSpaceship.Size = New System.Drawing.Size(108, 23)
        Me.btnSpaceship.TabIndex = 5
        Me.btnSpaceship.Text = "Back to spaceship"
        Me.btnSpaceship.UseVisualStyleBackColor = True
        '
        'btnAliens
        '
        Me.btnAliens.BackColor = System.Drawing.Color.Transparent
        Me.btnAliens.FlatAppearance.BorderSize = 0
        Me.btnAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAliens.Location = New System.Drawing.Point(326, 122)
        Me.btnAliens.Name = "btnAliens"
        Me.btnAliens.Size = New System.Drawing.Size(81, 52)
        Me.btnAliens.TabIndex = 6
        Me.btnAliens.UseVisualStyleBackColor = False
        '
        'frmSpaceStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.home_station
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 417)
        Me.Controls.Add(Me.btnAliens)
        Me.Controls.Add(Me.btnSpaceship)
        Me.Controls.Add(Me.btnPlanet4)
        Me.Controls.Add(Me.btnPlanet3)
        Me.Controls.Add(Me.btnPlanet2)
        Me.Controls.Add(Me.btnPlanet1)
        Me.Controls.Add(Me.btnInventory)
        Me.Name = "frmSpaceStation"
        Me.Text = "Space Station"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnPlanet1 As System.Windows.Forms.Button
    Friend WithEvents btnPlanet2 As System.Windows.Forms.Button
    Friend WithEvents btnPlanet3 As System.Windows.Forms.Button
    Friend WithEvents btnPlanet4 As System.Windows.Forms.Button
    Friend WithEvents btnSpaceship As System.Windows.Forms.Button
    Friend WithEvents btnAliens As System.Windows.Forms.Button

End Class
