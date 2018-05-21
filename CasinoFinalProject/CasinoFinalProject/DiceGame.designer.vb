<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceGame
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
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.lblRiskPrompt = New System.Windows.Forms.Label()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.picDie2 = New System.Windows.Forms.PictureBox()
        Me.picDie1 = New System.Windows.Forms.PictureBox()
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRisk
        '
        Me.txtRisk.Location = New System.Drawing.Point(267, 41)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.Size = New System.Drawing.Size(100, 20)
        Me.txtRisk.TabIndex = 3
        '
        'lblRiskPrompt
        '
        Me.lblRiskPrompt.Location = New System.Drawing.Point(161, 41)
        Me.lblRiskPrompt.Name = "lblRiskPrompt"
        Me.lblRiskPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblRiskPrompt.TabIndex = 4
        Me.lblRiskPrompt.Text = "Risk:"
        Me.lblRiskPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(48, 40)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(75, 23)
        Me.btnRollDice.TabIndex = 5
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'lblPoints
        '
        Me.lblPoints.Location = New System.Drawing.Point(12, 254)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(373, 68)
        Me.lblPoints.TabIndex = 6
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picDie2
        '
        Me.picDie2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDie2.Location = New System.Drawing.Point(239, 102)
        Me.picDie2.Name = "picDie2"
        Me.picDie2.Size = New System.Drawing.Size(146, 138)
        Me.picDie2.TabIndex = 2
        Me.picDie2.TabStop = False
        '
        'picDie1
        '
        Me.picDie1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDie1.Location = New System.Drawing.Point(12, 102)
        Me.picDie1.Name = "picDie1"
        Me.picDie1.Size = New System.Drawing.Size(146, 138)
        Me.picDie1.TabIndex = 1
        Me.picDie1.TabStop = False
        '
        'frmDiceGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 333)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.lblRiskPrompt)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.picDie2)
        Me.Controls.Add(Me.picDie1)
        Me.Name = "frmDiceGame"
        Me.Text = "Dice Game"
        CType(Me.picDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDie1 As System.Windows.Forms.PictureBox
    Friend WithEvents picDie2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRisk As System.Windows.Forms.TextBox
    Friend WithEvents lblRiskPrompt As System.Windows.Forms.Label
    Friend WithEvents btnRollDice As System.Windows.Forms.Button
    Friend WithEvents lblPoints As System.Windows.Forms.Label
End Class
