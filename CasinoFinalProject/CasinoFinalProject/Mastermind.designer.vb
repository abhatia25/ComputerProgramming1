<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMastermind
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
        Me.grpPeg1 = New System.Windows.Forms.GroupBox()
        Me.radPeg1White = New System.Windows.Forms.RadioButton()
        Me.radPeg1Green = New System.Windows.Forms.RadioButton()
        Me.radPeg1Red = New System.Windows.Forms.RadioButton()
        Me.radPeg1Blue = New System.Windows.Forms.RadioButton()
        Me.radPeg1Yellow = New System.Windows.Forms.RadioButton()
        Me.grpPeg2 = New System.Windows.Forms.GroupBox()
        Me.radPeg2White = New System.Windows.Forms.RadioButton()
        Me.radPeg2Green = New System.Windows.Forms.RadioButton()
        Me.radPeg2Red = New System.Windows.Forms.RadioButton()
        Me.radPeg2Blue = New System.Windows.Forms.RadioButton()
        Me.radPeg2Yellow = New System.Windows.Forms.RadioButton()
        Me.grpPeg3 = New System.Windows.Forms.GroupBox()
        Me.radPeg3White = New System.Windows.Forms.RadioButton()
        Me.radPeg3Green = New System.Windows.Forms.RadioButton()
        Me.radPeg3Red = New System.Windows.Forms.RadioButton()
        Me.radPeg3Blue = New System.Windows.Forms.RadioButton()
        Me.radPeg3Yellow = New System.Windows.Forms.RadioButton()
        Me.rad = New System.Windows.Forms.RadioButton()
        Me.btnCheckGuess = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpPeg1.SuspendLayout()
        Me.grpPeg2.SuspendLayout()
        Me.grpPeg3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPeg1
        '
        Me.grpPeg1.Controls.Add(Me.radPeg1White)
        Me.grpPeg1.Controls.Add(Me.radPeg1Green)
        Me.grpPeg1.Controls.Add(Me.radPeg1Red)
        Me.grpPeg1.Controls.Add(Me.radPeg1Blue)
        Me.grpPeg1.Controls.Add(Me.radPeg1Yellow)
        Me.grpPeg1.Location = New System.Drawing.Point(12, 27)
        Me.grpPeg1.Name = "grpPeg1"
        Me.grpPeg1.Size = New System.Drawing.Size(160, 164)
        Me.grpPeg1.TabIndex = 1
        Me.grpPeg1.TabStop = False
        Me.grpPeg1.Text = "Peg 1 Guess"
        '
        'radPeg1White
        '
        Me.radPeg1White.AutoSize = True
        Me.radPeg1White.Location = New System.Drawing.Point(6, 141)
        Me.radPeg1White.Name = "radPeg1White"
        Me.radPeg1White.Size = New System.Drawing.Size(53, 17)
        Me.radPeg1White.TabIndex = 4
        Me.radPeg1White.Text = "White"
        Me.radPeg1White.UseVisualStyleBackColor = True
        '
        'radPeg1Green
        '
        Me.radPeg1Green.AutoSize = True
        Me.radPeg1Green.Location = New System.Drawing.Point(6, 110)
        Me.radPeg1Green.Name = "radPeg1Green"
        Me.radPeg1Green.Size = New System.Drawing.Size(54, 17)
        Me.radPeg1Green.TabIndex = 3
        Me.radPeg1Green.Text = "Green"
        Me.radPeg1Green.UseVisualStyleBackColor = True
        '
        'radPeg1Red
        '
        Me.radPeg1Red.AutoSize = True
        Me.radPeg1Red.Location = New System.Drawing.Point(6, 80)
        Me.radPeg1Red.Name = "radPeg1Red"
        Me.radPeg1Red.Size = New System.Drawing.Size(45, 17)
        Me.radPeg1Red.TabIndex = 2
        Me.radPeg1Red.Text = "Red"
        Me.radPeg1Red.UseVisualStyleBackColor = True
        '
        'radPeg1Blue
        '
        Me.radPeg1Blue.AutoSize = True
        Me.radPeg1Blue.Location = New System.Drawing.Point(6, 51)
        Me.radPeg1Blue.Name = "radPeg1Blue"
        Me.radPeg1Blue.Size = New System.Drawing.Size(46, 17)
        Me.radPeg1Blue.TabIndex = 1
        Me.radPeg1Blue.Text = "Blue"
        Me.radPeg1Blue.UseVisualStyleBackColor = True
        '
        'radPeg1Yellow
        '
        Me.radPeg1Yellow.AutoSize = True
        Me.radPeg1Yellow.Location = New System.Drawing.Point(6, 19)
        Me.radPeg1Yellow.Name = "radPeg1Yellow"
        Me.radPeg1Yellow.Size = New System.Drawing.Size(56, 17)
        Me.radPeg1Yellow.TabIndex = 0
        Me.radPeg1Yellow.Text = "Yellow"
        Me.radPeg1Yellow.UseVisualStyleBackColor = True
        '
        'grpPeg2
        '
        Me.grpPeg2.Controls.Add(Me.radPeg2White)
        Me.grpPeg2.Controls.Add(Me.radPeg2Green)
        Me.grpPeg2.Controls.Add(Me.radPeg2Red)
        Me.grpPeg2.Controls.Add(Me.radPeg2Blue)
        Me.grpPeg2.Controls.Add(Me.radPeg2Yellow)
        Me.grpPeg2.Location = New System.Drawing.Point(178, 27)
        Me.grpPeg2.Name = "grpPeg2"
        Me.grpPeg2.Size = New System.Drawing.Size(160, 164)
        Me.grpPeg2.TabIndex = 0
        Me.grpPeg2.TabStop = False
        Me.grpPeg2.Text = "Peg 2 Guess"
        '
        'radPeg2White
        '
        Me.radPeg2White.AutoSize = True
        Me.radPeg2White.Location = New System.Drawing.Point(6, 141)
        Me.radPeg2White.Name = "radPeg2White"
        Me.radPeg2White.Size = New System.Drawing.Size(53, 17)
        Me.radPeg2White.TabIndex = 4
        Me.radPeg2White.Text = "White"
        Me.radPeg2White.UseVisualStyleBackColor = True
        '
        'radPeg2Green
        '
        Me.radPeg2Green.AutoSize = True
        Me.radPeg2Green.Location = New System.Drawing.Point(6, 110)
        Me.radPeg2Green.Name = "radPeg2Green"
        Me.radPeg2Green.Size = New System.Drawing.Size(54, 17)
        Me.radPeg2Green.TabIndex = 3
        Me.radPeg2Green.Text = "Green"
        Me.radPeg2Green.UseVisualStyleBackColor = True
        '
        'radPeg2Red
        '
        Me.radPeg2Red.AutoSize = True
        Me.radPeg2Red.Location = New System.Drawing.Point(6, 80)
        Me.radPeg2Red.Name = "radPeg2Red"
        Me.radPeg2Red.Size = New System.Drawing.Size(45, 17)
        Me.radPeg2Red.TabIndex = 2
        Me.radPeg2Red.Text = "Red"
        Me.radPeg2Red.UseVisualStyleBackColor = True
        '
        'radPeg2Blue
        '
        Me.radPeg2Blue.AutoSize = True
        Me.radPeg2Blue.Location = New System.Drawing.Point(6, 51)
        Me.radPeg2Blue.Name = "radPeg2Blue"
        Me.radPeg2Blue.Size = New System.Drawing.Size(46, 17)
        Me.radPeg2Blue.TabIndex = 1
        Me.radPeg2Blue.Text = "Blue"
        Me.radPeg2Blue.UseVisualStyleBackColor = True
        '
        'radPeg2Yellow
        '
        Me.radPeg2Yellow.AutoSize = True
        Me.radPeg2Yellow.Location = New System.Drawing.Point(6, 19)
        Me.radPeg2Yellow.Name = "radPeg2Yellow"
        Me.radPeg2Yellow.Size = New System.Drawing.Size(56, 17)
        Me.radPeg2Yellow.TabIndex = 0
        Me.radPeg2Yellow.Text = "Yellow"
        Me.radPeg2Yellow.UseVisualStyleBackColor = True
        '
        'grpPeg3
        '
        Me.grpPeg3.Controls.Add(Me.radPeg3White)
        Me.grpPeg3.Controls.Add(Me.radPeg3Green)
        Me.grpPeg3.Controls.Add(Me.radPeg3Red)
        Me.grpPeg3.Controls.Add(Me.radPeg3Blue)
        Me.grpPeg3.Controls.Add(Me.radPeg3Yellow)
        Me.grpPeg3.Location = New System.Drawing.Point(348, 27)
        Me.grpPeg3.Name = "grpPeg3"
        Me.grpPeg3.Size = New System.Drawing.Size(160, 164)
        Me.grpPeg3.TabIndex = 0
        Me.grpPeg3.TabStop = False
        Me.grpPeg3.Text = "Peg 3 Guess"
        '
        'radPeg3White
        '
        Me.radPeg3White.AutoSize = True
        Me.radPeg3White.Location = New System.Drawing.Point(6, 141)
        Me.radPeg3White.Name = "radPeg3White"
        Me.radPeg3White.Size = New System.Drawing.Size(53, 17)
        Me.radPeg3White.TabIndex = 4
        Me.radPeg3White.Text = "White"
        Me.radPeg3White.UseVisualStyleBackColor = True
        '
        'radPeg3Green
        '
        Me.radPeg3Green.AutoSize = True
        Me.radPeg3Green.Location = New System.Drawing.Point(6, 110)
        Me.radPeg3Green.Name = "radPeg3Green"
        Me.radPeg3Green.Size = New System.Drawing.Size(54, 17)
        Me.radPeg3Green.TabIndex = 3
        Me.radPeg3Green.Text = "Green"
        Me.radPeg3Green.UseVisualStyleBackColor = True
        '
        'radPeg3Red
        '
        Me.radPeg3Red.AutoSize = True
        Me.radPeg3Red.Location = New System.Drawing.Point(6, 80)
        Me.radPeg3Red.Name = "radPeg3Red"
        Me.radPeg3Red.Size = New System.Drawing.Size(45, 17)
        Me.radPeg3Red.TabIndex = 2
        Me.radPeg3Red.Text = "Red"
        Me.radPeg3Red.UseVisualStyleBackColor = True
        '
        'radPeg3Blue
        '
        Me.radPeg3Blue.AutoSize = True
        Me.radPeg3Blue.Location = New System.Drawing.Point(6, 51)
        Me.radPeg3Blue.Name = "radPeg3Blue"
        Me.radPeg3Blue.Size = New System.Drawing.Size(46, 17)
        Me.radPeg3Blue.TabIndex = 1
        Me.radPeg3Blue.Text = "Blue"
        Me.radPeg3Blue.UseVisualStyleBackColor = True
        '
        'radPeg3Yellow
        '
        Me.radPeg3Yellow.AutoSize = True
        Me.radPeg3Yellow.Location = New System.Drawing.Point(6, 19)
        Me.radPeg3Yellow.Name = "radPeg3Yellow"
        Me.radPeg3Yellow.Size = New System.Drawing.Size(56, 17)
        Me.radPeg3Yellow.TabIndex = 0
        Me.radPeg3Yellow.Text = "Yellow"
        Me.radPeg3Yellow.UseVisualStyleBackColor = True
        '
        'rad
        '
        Me.rad.AutoSize = True
        Me.rad.Location = New System.Drawing.Point(6, 19)
        Me.rad.Name = "rad"
        Me.rad.Size = New System.Drawing.Size(90, 17)
        Me.rad.TabIndex = 0
        Me.rad.TabStop = True
        Me.rad.Text = "RadioButton1"
        Me.rad.UseVisualStyleBackColor = True
        '
        'btnCheckGuess
        '
        Me.btnCheckGuess.Location = New System.Drawing.Point(12, 197)
        Me.btnCheckGuess.Name = "btnCheckGuess"
        Me.btnCheckGuess.Size = New System.Drawing.Size(496, 23)
        Me.btnCheckGuess.TabIndex = 5
        Me.btnCheckGuess.Text = "Check Guess"
        Me.btnCheckGuess.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.Location = New System.Drawing.Point(12, 223)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(496, 87)
        Me.lblResults.TabIndex = 6
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(433, 287)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'frmMastermind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 320)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnCheckGuess)
        Me.Controls.Add(Me.grpPeg2)
        Me.Controls.Add(Me.grpPeg3)
        Me.Controls.Add(Me.grpPeg1)
        Me.Name = "frmMastermind"
        Me.Text = "Mastermind"
        Me.grpPeg1.ResumeLayout(False)
        Me.grpPeg1.PerformLayout()
        Me.grpPeg2.ResumeLayout(False)
        Me.grpPeg2.PerformLayout()
        Me.grpPeg3.ResumeLayout(False)
        Me.grpPeg3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPeg1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpPeg2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpPeg3 As System.Windows.Forms.GroupBox
    Friend WithEvents radPeg1White As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg1Green As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg1Red As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg1Blue As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg1Yellow As System.Windows.Forms.RadioButton
    Friend WithEvents rad As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg2White As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg2Green As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg2Red As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg2Blue As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg2Yellow As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg3White As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg3Green As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg3Red As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg3Blue As System.Windows.Forms.RadioButton
    Friend WithEvents radPeg3Yellow As System.Windows.Forms.RadioButton
    Friend WithEvents btnCheckGuess As System.Windows.Forms.Button
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
