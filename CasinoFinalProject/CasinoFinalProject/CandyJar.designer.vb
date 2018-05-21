<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandyJar
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
        Me.lblJellyBeansPrompt = New System.Windows.Forms.Label()
        Me.txtJellyBeansGuess = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblJellyBeansPrompt
        '
        Me.lblJellyBeansPrompt.Location = New System.Drawing.Point(12, 39)
        Me.lblJellyBeansPrompt.Name = "lblJellyBeansPrompt"
        Me.lblJellyBeansPrompt.Size = New System.Drawing.Size(211, 33)
        Me.lblJellyBeansPrompt.TabIndex = 1
        Me.lblJellyBeansPrompt.Text = "How many jellybeans are in the candy jar? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter a number between 0 and 300." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            ""
        Me.lblJellyBeansPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtJellyBeansGuess
        '
        Me.txtJellyBeansGuess.Location = New System.Drawing.Point(226, 43)
        Me.txtJellyBeansGuess.Name = "txtJellyBeansGuess"
        Me.txtJellyBeansGuess.Size = New System.Drawing.Size(87, 20)
        Me.txtJellyBeansGuess.TabIndex = 2
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(12, 93)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 3
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(107, 84)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(211, 35)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCandyJar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 128)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtJellyBeansGuess)
        Me.Controls.Add(Me.lblJellyBeansPrompt)
        Me.Name = "frmCandyJar"
        Me.Text = "Candy Jar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJellyBeansPrompt As System.Windows.Forms.Label
    Friend WithEvents txtJellyBeansGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
