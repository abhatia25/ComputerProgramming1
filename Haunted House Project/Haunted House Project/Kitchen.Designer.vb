<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKitchen
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
        Me.btnHint = New System.Windows.Forms.Button()
        Me.lblCandyCounter = New System.Windows.Forms.Label()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.picCandy = New System.Windows.Forms.PictureBox()
        Me.btnIncorrect1 = New System.Windows.Forms.Button()
        Me.btnIncorrect2 = New System.Windows.Forms.Button()
        Me.btnIncorrect3 = New System.Windows.Forms.Button()
        Me.btnIncorrect4 = New System.Windows.Forms.Button()
        Me.btnIncorrect5 = New System.Windows.Forms.Button()
        Me.btnIncorrect6 = New System.Windows.Forms.Button()
        Me.KitchenProgressBar = New System.Windows.Forms.ProgressBar()
        Me.KitchenTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCandy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHint
        '
        Me.btnHint.Location = New System.Drawing.Point(232, 431)
        Me.btnHint.Name = "btnHint"
        Me.btnHint.Size = New System.Drawing.Size(75, 23)
        Me.btnHint.TabIndex = 16
        Me.btnHint.Text = "Hint"
        Me.btnHint.UseVisualStyleBackColor = True
        '
        'lblCandyCounter
        '
        Me.lblCandyCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblCandyCounter.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandyCounter.ForeColor = System.Drawing.Color.Yellow
        Me.lblCandyCounter.Location = New System.Drawing.Point(10, 8)
        Me.lblCandyCounter.Name = "lblCandyCounter"
        Me.lblCandyCounter.Size = New System.Drawing.Size(117, 47)
        Me.lblCandyCounter.TabIndex = 14
        Me.lblCandyCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCorrect
        '
        Me.btnCorrect.BackColor = System.Drawing.Color.Transparent
        Me.btnCorrect.FlatAppearance.BorderSize = 0
        Me.btnCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorrect.Location = New System.Drawing.Point(349, 126)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(75, 241)
        Me.btnCorrect.TabIndex = 17
        Me.btnCorrect.UseVisualStyleBackColor = False
        '
        'picCandy
        '
        Me.picCandy.BackgroundImage = Global.Haunted_House_Project.My.Resources.Resources.KitKat
        Me.picCandy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCandy.Location = New System.Drawing.Point(332, 180)
        Me.picCandy.Name = "picCandy"
        Me.picCandy.Size = New System.Drawing.Size(121, 122)
        Me.picCandy.TabIndex = 18
        Me.picCandy.TabStop = False
        Me.picCandy.Visible = False
        '
        'btnIncorrect1
        '
        Me.btnIncorrect1.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect1.FlatAppearance.BorderSize = 0
        Me.btnIncorrect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect1.Location = New System.Drawing.Point(208, 12)
        Me.btnIncorrect1.Name = "btnIncorrect1"
        Me.btnIncorrect1.Size = New System.Drawing.Size(75, 67)
        Me.btnIncorrect1.TabIndex = 19
        Me.btnIncorrect1.UseVisualStyleBackColor = False
        '
        'btnIncorrect2
        '
        Me.btnIncorrect2.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect2.FlatAppearance.BorderSize = 0
        Me.btnIncorrect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect2.Location = New System.Drawing.Point(12, 89)
        Me.btnIncorrect2.Name = "btnIncorrect2"
        Me.btnIncorrect2.Size = New System.Drawing.Size(75, 67)
        Me.btnIncorrect2.TabIndex = 20
        Me.btnIncorrect2.UseVisualStyleBackColor = False
        '
        'btnIncorrect3
        '
        Me.btnIncorrect3.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect3.FlatAppearance.BorderSize = 0
        Me.btnIncorrect3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect3.Location = New System.Drawing.Point(208, 259)
        Me.btnIncorrect3.Name = "btnIncorrect3"
        Me.btnIncorrect3.Size = New System.Drawing.Size(75, 67)
        Me.btnIncorrect3.TabIndex = 21
        Me.btnIncorrect3.UseVisualStyleBackColor = False
        '
        'btnIncorrect4
        '
        Me.btnIncorrect4.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect4.FlatAppearance.BorderSize = 0
        Me.btnIncorrect4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect4.Location = New System.Drawing.Point(93, 126)
        Me.btnIncorrect4.Name = "btnIncorrect4"
        Me.btnIncorrect4.Size = New System.Drawing.Size(75, 67)
        Me.btnIncorrect4.TabIndex = 22
        Me.btnIncorrect4.UseVisualStyleBackColor = False
        '
        'btnIncorrect5
        '
        Me.btnIncorrect5.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect5.FlatAppearance.BorderSize = 0
        Me.btnIncorrect5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect5.Location = New System.Drawing.Point(13, 312)
        Me.btnIncorrect5.Name = "btnIncorrect5"
        Me.btnIncorrect5.Size = New System.Drawing.Size(75, 67)
        Me.btnIncorrect5.TabIndex = 23
        Me.btnIncorrect5.UseVisualStyleBackColor = False
        '
        'btnIncorrect6
        '
        Me.btnIncorrect6.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect6.FlatAppearance.BorderSize = 0
        Me.btnIncorrect6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect6.Location = New System.Drawing.Point(13, 204)
        Me.btnIncorrect6.Name = "btnIncorrect6"
        Me.btnIncorrect6.Size = New System.Drawing.Size(75, 67)
        Me.btnIncorrect6.TabIndex = 24
        Me.btnIncorrect6.UseVisualStyleBackColor = False
        '
        'KitchenProgressBar
        '
        Me.KitchenProgressBar.Location = New System.Drawing.Point(208, 8)
        Me.KitchenProgressBar.Name = "KitchenProgressBar"
        Me.KitchenProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.KitchenProgressBar.TabIndex = 25
        '
        'KitchenTimer
        '
        Me.KitchenTimer.Interval = 300
        '
        'frmKitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Haunted_House_Project.My.Resources.Resources.Haunted_Kitchen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 458)
        Me.Controls.Add(Me.KitchenProgressBar)
        Me.Controls.Add(Me.btnIncorrect6)
        Me.Controls.Add(Me.btnIncorrect5)
        Me.Controls.Add(Me.btnIncorrect4)
        Me.Controls.Add(Me.btnIncorrect3)
        Me.Controls.Add(Me.btnIncorrect2)
        Me.Controls.Add(Me.btnIncorrect1)
        Me.Controls.Add(Me.picCandy)
        Me.Controls.Add(Me.btnCorrect)
        Me.Controls.Add(Me.btnHint)
        Me.Controls.Add(Me.lblCandyCounter)
        Me.Name = "frmKitchen"
        Me.Text = "Kitchen"
        CType(Me.picCandy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHint As System.Windows.Forms.Button
    Friend WithEvents lblCandyCounter As System.Windows.Forms.Label
    Friend WithEvents btnCorrect As System.Windows.Forms.Button
    Friend WithEvents picCandy As System.Windows.Forms.PictureBox
    Friend WithEvents btnIncorrect1 As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect2 As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect3 As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect4 As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect5 As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect6 As System.Windows.Forms.Button
    Friend WithEvents KitchenProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents KitchenTimer As System.Windows.Forms.Timer
End Class
