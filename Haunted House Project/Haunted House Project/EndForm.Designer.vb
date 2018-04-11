<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnd
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
        Me.lblCandyCounter = New System.Windows.Forms.Label()
        Me.lblMainMessage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.lblFinalCandyCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCandyCounter
        '
        Me.lblCandyCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblCandyCounter.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandyCounter.ForeColor = System.Drawing.Color.Yellow
        Me.lblCandyCounter.Location = New System.Drawing.Point(12, 9)
        Me.lblCandyCounter.Name = "lblCandyCounter"
        Me.lblCandyCounter.Size = New System.Drawing.Size(117, 47)
        Me.lblCandyCounter.TabIndex = 15
        Me.lblCandyCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainMessage
        '
        Me.lblMainMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMainMessage.Font = New System.Drawing.Font("Century", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMessage.ForeColor = System.Drawing.Color.Yellow
        Me.lblMainMessage.Location = New System.Drawing.Point(12, 67)
        Me.lblMainMessage.Name = "lblMainMessage"
        Me.lblMainMessage.Size = New System.Drawing.Size(516, 158)
        Me.lblMainMessage.TabIndex = 16
        Me.lblMainMessage.Text = "Congratulations, you found all the candy and completed the game!"
        Me.lblMainMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 423)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(241, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(287, 423)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(241, 23)
        Me.btnPlayAgain.TabIndex = 18
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'lblFinalCandyCount
        '
        Me.lblFinalCandyCount.BackColor = System.Drawing.Color.Transparent
        Me.lblFinalCandyCount.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCandyCount.ForeColor = System.Drawing.Color.Yellow
        Me.lblFinalCandyCount.Location = New System.Drawing.Point(12, 274)
        Me.lblFinalCandyCount.Name = "lblFinalCandyCount"
        Me.lblFinalCandyCount.Size = New System.Drawing.Size(516, 70)
        Me.lblFinalCandyCount.TabIndex = 19
        Me.lblFinalCandyCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Haunted_House_Project.My.Resources.Resources.Haunted_House
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 458)
        Me.Controls.Add(Me.lblFinalCandyCount)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMainMessage)
        Me.Controls.Add(Me.lblCandyCounter)
        Me.Name = "frmEnd"
        Me.Text = "Game Complete"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCandyCounter As System.Windows.Forms.Label
    Friend WithEvents lblMainMessage As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents lblFinalCandyCount As System.Windows.Forms.Label
End Class
