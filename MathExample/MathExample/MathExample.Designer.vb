<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathExample
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnAbs = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(119, 35)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number:"
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(137, 18)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnAbs
        '
        Me.btnAbs.Location = New System.Drawing.Point(67, 44)
        Me.btnAbs.Name = "btnAbs"
        Me.btnAbs.Size = New System.Drawing.Size(121, 37)
        Me.btnAbs.TabIndex = 2
        Me.btnAbs.Text = "Absolute Value"
        Me.btnAbs.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(67, 87)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(121, 37)
        Me.btnSqrt.TabIndex = 3
        Me.btnSqrt.Text = "Square Root"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(67, 130)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(121, 37)
        Me.btnSign.TabIndex = 4
        Me.btnSign.Text = "Sign"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnRound
        '
        Me.btnRound.Location = New System.Drawing.Point(66, 174)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(121, 37)
        Me.btnRound.TabIndex = 5
        Me.btnRound.Text = "Round It"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(12, 214)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(229, 162)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMathExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 385)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnAbs)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "frmMathExample"
        Me.Text = "Math Class Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnAbs As System.Windows.Forms.Button
    Friend WithEvents btnSqrt As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnRound As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
