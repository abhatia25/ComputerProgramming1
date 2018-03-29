<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnDoor = New System.Windows.Forms.Button()
        Me.lblCandyCounter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Jokerman", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(516, 44)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Haunted House Game"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(12, 56)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(516, 284)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(197, 370)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(148, 76)
        Me.btnDone.TabIndex = 3
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnDoor
        '
        Me.btnDoor.BackColor = System.Drawing.Color.Transparent
        Me.btnDoor.FlatAppearance.BorderSize = 0
        Me.btnDoor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoor.Location = New System.Drawing.Point(182, 217)
        Me.btnDoor.Name = "btnDoor"
        Me.btnDoor.Size = New System.Drawing.Size(167, 123)
        Me.btnDoor.TabIndex = 4
        Me.btnDoor.UseVisualStyleBackColor = False
        Me.btnDoor.Visible = False
        '
        'lblCandyCounter
        '
        Me.lblCandyCounter.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandyCounter.Location = New System.Drawing.Point(12, 9)
        Me.lblCandyCounter.Name = "lblCandyCounter"
        Me.lblCandyCounter.Size = New System.Drawing.Size(117, 47)
        Me.lblCandyCounter.TabIndex = 5
        Me.lblCandyCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCandyCounter.Visible = False
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 458)
        Me.Controls.Add(Me.lblCandyCounter)
        Me.Controls.Add(Me.btnDoor)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmInstructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnDoor As System.Windows.Forms.Button
    Friend WithEvents lblCandyCounter As System.Windows.Forms.Label

End Class
