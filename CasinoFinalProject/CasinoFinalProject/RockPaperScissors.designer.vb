<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRockPaperScissors
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
        Me.grpPlayerChoice = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.grpPlayerChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPlayerChoice
        '
        Me.grpPlayerChoice.Controls.Add(Me.radScissors)
        Me.grpPlayerChoice.Controls.Add(Me.radPaper)
        Me.grpPlayerChoice.Controls.Add(Me.radRock)
        Me.grpPlayerChoice.Location = New System.Drawing.Point(12, 27)
        Me.grpPlayerChoice.Name = "grpPlayerChoice"
        Me.grpPlayerChoice.Size = New System.Drawing.Size(197, 107)
        Me.grpPlayerChoice.TabIndex = 1
        Me.grpPlayerChoice.TabStop = False
        Me.grpPlayerChoice.Text = "Please choose a move"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(122, 49)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(63, 49)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(6, 49)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(75, 140)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.Location = New System.Drawing.Point(9, 166)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(201, 87)
        Me.lblWinner.TabIndex = 3
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRockPaperScissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 262)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.grpPlayerChoice)
        Me.Name = "frmRockPaperScissors"
        Me.Text = "Rock Paper Scissors"
        Me.grpPlayerChoice.ResumeLayout(False)
        Me.grpPlayerChoice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPlayerChoice As System.Windows.Forms.GroupBox
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblWinner As System.Windows.Forms.Label
End Class
