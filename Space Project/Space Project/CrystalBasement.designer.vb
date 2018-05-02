<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrystalBasement
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
        Me.picCrystal = New System.Windows.Forms.PictureBox()
        Me.picHello = New System.Windows.Forms.PictureBox()
        Me.btnInventory = New System.Windows.Forms.Button()
        CType(Me.picCrystal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHello, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCrystal
        '
        Me.picCrystal.BackgroundImage = Global.Space_Project.My.Resources.Resources.power_crystal
        Me.picCrystal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCrystal.Location = New System.Drawing.Point(628, 229)
        Me.picCrystal.Name = "picCrystal"
        Me.picCrystal.Size = New System.Drawing.Size(38, 54)
        Me.picCrystal.TabIndex = 0
        Me.picCrystal.TabStop = False
        Me.picCrystal.Visible = False
        '
        'picHello
        '
        Me.picHello.BackgroundImage = Global.Space_Project.My.Resources.Resources.Person
        Me.picHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHello.Location = New System.Drawing.Point(75, 100)
        Me.picHello.Name = "picHello"
        Me.picHello.Size = New System.Drawing.Size(245, 264)
        Me.picHello.TabIndex = 1
        Me.picHello.TabStop = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.White
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Location = New System.Drawing.Point(12, 12)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'frmCrystalBasement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Crystal_Room_for_power
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(821, 421)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.picHello)
        Me.Controls.Add(Me.picCrystal)
        Me.Name = "frmCrystalBasement"
        Me.Text = "Crystal Basement"
        CType(Me.picCrystal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHello, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCrystal As System.Windows.Forms.PictureBox
    Friend WithEvents picHello As System.Windows.Forms.PictureBox
    Friend WithEvents btnInventory As System.Windows.Forms.Button
End Class
