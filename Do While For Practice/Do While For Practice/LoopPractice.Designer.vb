<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoopPractice
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
        Me.btnDoWhileLoop = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDoWhileLoop
        '
        Me.btnDoWhileLoop.Location = New System.Drawing.Point(12, 12)
        Me.btnDoWhileLoop.Name = "btnDoWhileLoop"
        Me.btnDoWhileLoop.Size = New System.Drawing.Size(394, 23)
        Me.btnDoWhileLoop.TabIndex = 0
        Me.btnDoWhileLoop.Text = "Beings walking into space that communicate if they would desire going to Prom"
        Me.btnDoWhileLoop.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 192)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(394, 23)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Number of beings who want to go to Prom"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(79, 101)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 2
        '
        'LoopPractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 238)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnDoWhileLoop)
        Me.Name = "LoopPractice"
        Me.Text = "Number of beings asked to the Prom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDoWhileLoop As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
