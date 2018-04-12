<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoyer
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCandyCounter = New System.Windows.Forms.Label()
        Me.btnWindow = New System.Windows.Forms.Button()
        Me.btnCandles = New System.Windows.Forms.Button()
        Me.btnStatue = New System.Windows.Forms.Button()
        Me.btnStatue2 = New System.Windows.Forms.Button()
        Me.picCandy = New System.Windows.Forms.PictureBox()
        Me.btnKitchen = New System.Windows.Forms.Button()
        Me.btnHint = New System.Windows.Forms.Button()
        Me.FoyerProgressBar = New System.Windows.Forms.ProgressBar()
        Me.FoyerTimer8 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCandy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCandyCounter
        '
        Me.lblCandyCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblCandyCounter.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandyCounter.ForeColor = System.Drawing.Color.Yellow
        Me.lblCandyCounter.Location = New System.Drawing.Point(8, 9)
        Me.lblCandyCounter.Name = "lblCandyCounter"
        Me.lblCandyCounter.Size = New System.Drawing.Size(117, 47)
        Me.lblCandyCounter.TabIndex = 6
        Me.lblCandyCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnWindow
        '
        Me.btnWindow.BackColor = System.Drawing.Color.Transparent
        Me.btnWindow.FlatAppearance.BorderSize = 0
        Me.btnWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWindow.Location = New System.Drawing.Point(396, 83)
        Me.btnWindow.Name = "btnWindow"
        Me.btnWindow.Size = New System.Drawing.Size(75, 94)
        Me.btnWindow.TabIndex = 7
        Me.btnWindow.UseVisualStyleBackColor = False
        '
        'btnCandles
        '
        Me.btnCandles.BackColor = System.Drawing.Color.Transparent
        Me.btnCandles.FlatAppearance.BorderSize = 0
        Me.btnCandles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCandles.Location = New System.Drawing.Point(360, 219)
        Me.btnCandles.Name = "btnCandles"
        Me.btnCandles.Size = New System.Drawing.Size(45, 94)
        Me.btnCandles.TabIndex = 8
        Me.btnCandles.UseVisualStyleBackColor = False
        '
        'btnStatue
        '
        Me.btnStatue.BackColor = System.Drawing.Color.Transparent
        Me.btnStatue.FlatAppearance.BorderSize = 0
        Me.btnStatue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatue.Location = New System.Drawing.Point(249, 119)
        Me.btnStatue.Name = "btnStatue"
        Me.btnStatue.Size = New System.Drawing.Size(45, 94)
        Me.btnStatue.TabIndex = 9
        Me.btnStatue.UseVisualStyleBackColor = False
        '
        'btnStatue2
        '
        Me.btnStatue2.BackColor = System.Drawing.Color.Transparent
        Me.btnStatue2.FlatAppearance.BorderSize = 0
        Me.btnStatue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatue2.Location = New System.Drawing.Point(323, 20)
        Me.btnStatue2.Name = "btnStatue2"
        Me.btnStatue2.Size = New System.Drawing.Size(45, 193)
        Me.btnStatue2.TabIndex = 10
        Me.btnStatue2.UseVisualStyleBackColor = False
        '
        'picCandy
        '
        Me.picCandy.BackgroundImage = Global.Haunted_House_Project.My.Resources.Resources.snickers
        Me.picCandy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCandy.Location = New System.Drawing.Point(227, 119)
        Me.picCandy.Name = "picCandy"
        Me.picCandy.Size = New System.Drawing.Size(90, 94)
        Me.picCandy.TabIndex = 11
        Me.picCandy.TabStop = False
        Me.picCandy.Visible = False
        '
        'btnKitchen
        '
        Me.btnKitchen.BackColor = System.Drawing.Color.Transparent
        Me.btnKitchen.FlatAppearance.BorderSize = 0
        Me.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitchen.Location = New System.Drawing.Point(229, 236)
        Me.btnKitchen.Name = "btnKitchen"
        Me.btnKitchen.Size = New System.Drawing.Size(90, 166)
        Me.btnKitchen.TabIndex = 12
        Me.btnKitchen.UseVisualStyleBackColor = False
        '
        'btnHint
        '
        Me.btnHint.Location = New System.Drawing.Point(239, 432)
        Me.btnHint.Name = "btnHint"
        Me.btnHint.Size = New System.Drawing.Size(75, 23)
        Me.btnHint.TabIndex = 13
        Me.btnHint.Text = "Hint"
        Me.btnHint.UseVisualStyleBackColor = True
        '
        'FoyerProgressBar
        '
        Me.FoyerProgressBar.Location = New System.Drawing.Point(227, 12)
        Me.FoyerProgressBar.Name = "FoyerProgressBar"
        Me.FoyerProgressBar.Size = New System.Drawing.Size(92, 23)
        Me.FoyerProgressBar.TabIndex = 14
        '
        'FoyerTimer8
        '
        Me.FoyerTimer8.Interval = 300
        '
        'frmFoyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Haunted_House_Project.My.Resources.Resources.haunted_foyer
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 458)
        Me.Controls.Add(Me.FoyerProgressBar)
        Me.Controls.Add(Me.btnHint)
        Me.Controls.Add(Me.btnKitchen)
        Me.Controls.Add(Me.picCandy)
        Me.Controls.Add(Me.btnStatue2)
        Me.Controls.Add(Me.btnStatue)
        Me.Controls.Add(Me.btnCandles)
        Me.Controls.Add(Me.btnWindow)
        Me.Controls.Add(Me.lblCandyCounter)
        Me.Name = "frmFoyer"
        Me.Text = "Foyer"
        CType(Me.picCandy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCandyCounter As System.Windows.Forms.Label
    Friend WithEvents btnWindow As System.Windows.Forms.Button
    Friend WithEvents btnCandles As System.Windows.Forms.Button
    Friend WithEvents btnStatue As System.Windows.Forms.Button
    Friend WithEvents btnStatue2 As System.Windows.Forms.Button
    Friend WithEvents picCandy As System.Windows.Forms.PictureBox
    Friend WithEvents btnKitchen As System.Windows.Forms.Button
    Friend WithEvents btnHint As System.Windows.Forms.Button
    Friend WithEvents FoyerProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents FoyerTimer8 As System.Windows.Forms.Timer
End Class
