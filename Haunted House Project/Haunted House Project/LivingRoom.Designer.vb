<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLivingRoom
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
        Me.btnIncorrect1 = New System.Windows.Forms.Button()
        Me.btnHint = New System.Windows.Forms.Button()
        Me.lblCandyCounter = New System.Windows.Forms.Label()
        Me.btnIncorrect2 = New System.Windows.Forms.Button()
        Me.btnIncorrect3 = New System.Windows.Forms.Button()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.picCandy = New System.Windows.Forms.PictureBox()
        Me.btnIncorrect4 = New System.Windows.Forms.Button()
        CType(Me.picCandy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIncorrect1
        '
        Me.btnIncorrect1.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect1.FlatAppearance.BorderSize = 0
        Me.btnIncorrect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect1.Location = New System.Drawing.Point(183, 238)
        Me.btnIncorrect1.Name = "btnIncorrect1"
        Me.btnIncorrect1.Size = New System.Drawing.Size(97, 130)
        Me.btnIncorrect1.TabIndex = 28
        Me.btnIncorrect1.UseVisualStyleBackColor = False
        '
        'btnHint
        '
        Me.btnHint.Location = New System.Drawing.Point(234, 432)
        Me.btnHint.Name = "btnHint"
        Me.btnHint.Size = New System.Drawing.Size(75, 23)
        Me.btnHint.TabIndex = 26
        Me.btnHint.Text = "Hint"
        Me.btnHint.UseVisualStyleBackColor = True
        '
        'lblCandyCounter
        '
        Me.lblCandyCounter.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandyCounter.Location = New System.Drawing.Point(12, 9)
        Me.lblCandyCounter.Name = "lblCandyCounter"
        Me.lblCandyCounter.Size = New System.Drawing.Size(117, 47)
        Me.lblCandyCounter.TabIndex = 25
        Me.lblCandyCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIncorrect2
        '
        Me.btnIncorrect2.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect2.FlatAppearance.BorderSize = 0
        Me.btnIncorrect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect2.Location = New System.Drawing.Point(183, 23)
        Me.btnIncorrect2.Name = "btnIncorrect2"
        Me.btnIncorrect2.Size = New System.Drawing.Size(97, 130)
        Me.btnIncorrect2.TabIndex = 29
        Me.btnIncorrect2.UseVisualStyleBackColor = False
        '
        'btnIncorrect3
        '
        Me.btnIncorrect3.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect3.FlatAppearance.BorderSize = 0
        Me.btnIncorrect3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect3.Location = New System.Drawing.Point(396, 305)
        Me.btnIncorrect3.Name = "btnIncorrect3"
        Me.btnIncorrect3.Size = New System.Drawing.Size(97, 83)
        Me.btnIncorrect3.TabIndex = 30
        Me.btnIncorrect3.UseVisualStyleBackColor = False
        '
        'btnCorrect
        '
        Me.btnCorrect.BackColor = System.Drawing.Color.Transparent
        Me.btnCorrect.FlatAppearance.BorderSize = 0
        Me.btnCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorrect.Location = New System.Drawing.Point(348, 60)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(97, 83)
        Me.btnCorrect.TabIndex = 31
        Me.btnCorrect.UseVisualStyleBackColor = False
        '
        'picCandy
        '
        Me.picCandy.BackgroundImage = Global.Haunted_House_Project.My.Resources.Resources.M_M_s
        Me.picCandy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCandy.Location = New System.Drawing.Point(316, 41)
        Me.picCandy.Name = "picCandy"
        Me.picCandy.Size = New System.Drawing.Size(129, 112)
        Me.picCandy.TabIndex = 32
        Me.picCandy.TabStop = False
        Me.picCandy.Visible = False
        '
        'btnIncorrect4
        '
        Me.btnIncorrect4.BackColor = System.Drawing.Color.Transparent
        Me.btnIncorrect4.FlatAppearance.BorderSize = 0
        Me.btnIncorrect4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncorrect4.Location = New System.Drawing.Point(12, 238)
        Me.btnIncorrect4.Name = "btnIncorrect4"
        Me.btnIncorrect4.Size = New System.Drawing.Size(97, 179)
        Me.btnIncorrect4.TabIndex = 33
        Me.btnIncorrect4.UseVisualStyleBackColor = False
        '
        'frmLivingRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Haunted_House_Project.My.Resources.Resources.Haunted_Living_Room
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 458)
        Me.Controls.Add(Me.btnIncorrect4)
        Me.Controls.Add(Me.picCandy)
        Me.Controls.Add(Me.btnCorrect)
        Me.Controls.Add(Me.btnIncorrect3)
        Me.Controls.Add(Me.btnIncorrect2)
        Me.Controls.Add(Me.btnIncorrect1)
        Me.Controls.Add(Me.btnHint)
        Me.Controls.Add(Me.lblCandyCounter)
        Me.Name = "frmLivingRoom"
        Me.Text = "Living Room"
        CType(Me.picCandy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIncorrect1 As System.Windows.Forms.Button
    Friend WithEvents btnHint As System.Windows.Forms.Button
    Friend WithEvents lblCandyCounter As System.Windows.Forms.Label
    Friend WithEvents btnIncorrect2 As System.Windows.Forms.Button
    Friend WithEvents btnIncorrect3 As System.Windows.Forms.Button
    Friend WithEvents btnCorrect As System.Windows.Forms.Button
    Friend WithEvents picCandy As System.Windows.Forms.PictureBox
    Friend WithEvents btnIncorrect4 As System.Windows.Forms.Button
End Class
