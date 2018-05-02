<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManufacureGuy
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
        Me.cboTalk = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnAsk = New System.Windows.Forms.Button()
        Me.btnThankyou = New System.Windows.Forms.Button()
        Me.btnSoo = New System.Windows.Forms.Button()
        Me.btnJK = New System.Windows.Forms.Button()
        Me.btnNoForeal = New System.Windows.Forms.Button()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.btnNoThankYou = New System.Windows.Forms.Button()
        Me.btnLive = New System.Windows.Forms.Button()
        Me.btnDie = New System.Windows.Forms.Button()
        Me.lstPlaceItems = New System.Windows.Forms.ListBox()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.picShield = New System.Windows.Forms.PictureBox()
        Me.btnMake = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShield, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTalk
        '
        Me.cboTalk.FormattingEnabled = True
        Me.cboTalk.Items.AddRange(New Object() {"Can you help us fix these resources?", "Hello, I want to take over this company!", "What is this place?", "Where is the Manufacture?"})
        Me.cboTalk.Location = New System.Drawing.Point(374, 245)
        Me.cboTalk.Name = "cboTalk"
        Me.cboTalk.Size = New System.Drawing.Size(214, 21)
        Me.cboTalk.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(630, 223)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 21)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Mr.Harold"
        Me.lblName.Visible = False
        '
        'btnAsk
        '
        Me.btnAsk.BackColor = System.Drawing.Color.White
        Me.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAsk.Location = New System.Drawing.Point(374, 272)
        Me.btnAsk.Name = "btnAsk"
        Me.btnAsk.Size = New System.Drawing.Size(214, 23)
        Me.btnAsk.TabIndex = 2
        Me.btnAsk.Text = "Talk"
        Me.btnAsk.UseVisualStyleBackColor = False
        Me.btnAsk.Visible = False
        '
        'btnThankyou
        '
        Me.btnThankyou.BackColor = System.Drawing.Color.White
        Me.btnThankyou.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThankyou.Location = New System.Drawing.Point(513, 184)
        Me.btnThankyou.Name = "btnThankyou"
        Me.btnThankyou.Size = New System.Drawing.Size(88, 21)
        Me.btnThankyou.TabIndex = 3
        Me.btnThankyou.Text = "Uhhh Please?"
        Me.btnThankyou.UseVisualStyleBackColor = False
        Me.btnThankyou.Visible = False
        '
        'btnSoo
        '
        Me.btnSoo.BackColor = System.Drawing.Color.White
        Me.btnSoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSoo.Location = New System.Drawing.Point(513, 155)
        Me.btnSoo.Name = "btnSoo"
        Me.btnSoo.Size = New System.Drawing.Size(75, 23)
        Me.btnSoo.TabIndex = 4
        Me.btnSoo.Text = "Soooo..."
        Me.btnSoo.UseVisualStyleBackColor = False
        Me.btnSoo.Visible = False
        '
        'btnJK
        '
        Me.btnJK.BackColor = System.Drawing.Color.White
        Me.btnJK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJK.Location = New System.Drawing.Point(403, 155)
        Me.btnJK.Name = "btnJK"
        Me.btnJK.Size = New System.Drawing.Size(104, 23)
        Me.btnJK.TabIndex = 5
        Me.btnJK.Text = "Oh, I was kidding"
        Me.btnJK.UseVisualStyleBackColor = False
        Me.btnJK.Visible = False
        '
        'btnNoForeal
        '
        Me.btnNoForeal.BackColor = System.Drawing.Color.White
        Me.btnNoForeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoForeal.Location = New System.Drawing.Point(594, 155)
        Me.btnNoForeal.Name = "btnNoForeal"
        Me.btnNoForeal.Size = New System.Drawing.Size(97, 23)
        Me.btnNoForeal.TabIndex = 6
        Me.btnNoForeal.Text = "No, I'm serious"
        Me.btnNoForeal.UseVisualStyleBackColor = False
        Me.btnNoForeal.Visible = False
        '
        'picBox
        '
        Me.picBox.BackgroundImage = Global.Space_Project.My.Resources.Resources.Box
        Me.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBox.Location = New System.Drawing.Point(0, 307)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(153, 115)
        Me.picBox.TabIndex = 7
        Me.picBox.TabStop = False
        Me.picBox.Visible = False
        '
        'btnNoThankYou
        '
        Me.btnNoThankYou.BackColor = System.Drawing.Color.White
        Me.btnNoThankYou.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoThankYou.Location = New System.Drawing.Point(513, 211)
        Me.btnNoThankYou.Name = "btnNoThankYou"
        Me.btnNoThankYou.Size = New System.Drawing.Size(88, 23)
        Me.btnNoThankYou.TabIndex = 8
        Me.btnNoThankYou.Text = "No Thanks"
        Me.btnNoThankYou.UseVisualStyleBackColor = False
        Me.btnNoThankYou.Visible = False
        '
        'btnLive
        '
        Me.btnLive.BackColor = System.Drawing.Color.White
        Me.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLive.Location = New System.Drawing.Point(403, 184)
        Me.btnLive.Name = "btnLive"
        Me.btnLive.Size = New System.Drawing.Size(104, 23)
        Me.btnLive.TabIndex = 9
        Me.btnLive.Text = "Fixing this ship"
        Me.btnLive.UseVisualStyleBackColor = False
        Me.btnLive.Visible = False
        '
        'btnDie
        '
        Me.btnDie.BackColor = System.Drawing.Color.White
        Me.btnDie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDie.Location = New System.Drawing.Point(607, 184)
        Me.btnDie.Name = "btnDie"
        Me.btnDie.Size = New System.Drawing.Size(84, 23)
        Me.btnDie.TabIndex = 10
        Me.btnDie.Text = "Nothing bye"
        Me.btnDie.UseVisualStyleBackColor = False
        Me.btnDie.Visible = False
        '
        'lstPlaceItems
        '
        Me.lstPlaceItems.FormattingEnabled = True
        Me.lstPlaceItems.Location = New System.Drawing.Point(12, 327)
        Me.lstPlaceItems.Name = "lstPlaceItems"
        Me.lstPlaceItems.Size = New System.Drawing.Size(121, 69)
        Me.lstPlaceItems.TabIndex = 11
        Me.lstPlaceItems.Visible = False
        '
        'btnPlace
        '
        Me.btnPlace.BackColor = System.Drawing.Color.White
        Me.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlace.Location = New System.Drawing.Point(0, 278)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(153, 23)
        Me.btnPlace.TabIndex = 12
        Me.btnPlace.Text = "Place your inventory"
        Me.btnPlace.UseVisualStyleBackColor = False
        Me.btnPlace.Visible = False
        '
        'picShield
        '
        Me.picShield.BackgroundImage = Global.Space_Project.My.Resources.Resources.Shield_Protective_Device
        Me.picShield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShield.Location = New System.Drawing.Point(0, -2)
        Me.picShield.Name = "picShield"
        Me.picShield.Size = New System.Drawing.Size(368, 268)
        Me.picShield.TabIndex = 13
        Me.picShield.TabStop = False
        Me.picShield.Visible = False
        '
        'btnMake
        '
        Me.btnMake.BackColor = System.Drawing.Color.White
        Me.btnMake.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMake.Location = New System.Drawing.Point(159, 352)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(75, 23)
        Me.btnMake.TabIndex = 14
        Me.btnMake.Text = "Make"
        Me.btnMake.UseVisualStyleBackColor = False
        Me.btnMake.Visible = False
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(734, 12)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 15
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'frmManufacureGuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Manufacture_Guy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(821, 421)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnMake)
        Me.Controls.Add(Me.picShield)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.lstPlaceItems)
        Me.Controls.Add(Me.btnDie)
        Me.Controls.Add(Me.btnLive)
        Me.Controls.Add(Me.btnNoThankYou)
        Me.Controls.Add(Me.btnNoForeal)
        Me.Controls.Add(Me.btnJK)
        Me.Controls.Add(Me.btnSoo)
        Me.Controls.Add(Me.btnThankyou)
        Me.Controls.Add(Me.btnAsk)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cboTalk)
        Me.Controls.Add(Me.picBox)
        Me.Name = "frmManufacureGuy"
        Me.Text = "Manufacture Guy"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShield, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboTalk As System.Windows.Forms.ComboBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnAsk As System.Windows.Forms.Button
    Friend WithEvents btnThankyou As System.Windows.Forms.Button
    Friend WithEvents btnSoo As System.Windows.Forms.Button
    Friend WithEvents btnJK As System.Windows.Forms.Button
    Friend WithEvents btnNoForeal As System.Windows.Forms.Button
    Friend WithEvents picBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnNoThankYou As System.Windows.Forms.Button
    Friend WithEvents btnLive As System.Windows.Forms.Button
    Friend WithEvents btnDie As System.Windows.Forms.Button
    Friend WithEvents lstPlaceItems As System.Windows.Forms.ListBox
    Friend WithEvents btnPlace As System.Windows.Forms.Button
    Friend WithEvents picShield As System.Windows.Forms.PictureBox
    Friend WithEvents btnMake As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
End Class
