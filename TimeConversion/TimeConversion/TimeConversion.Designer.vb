<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeConversion
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
        Me.lblTimePrompt = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.grpTimeConversion = New System.Windows.Forms.GroupBox()
        Me.radHourMinFormat = New System.Windows.Forms.RadioButton()
        Me.radMinToSec = New System.Windows.Forms.RadioButton()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.grpTimeConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTimePrompt
        '
        Me.lblTimePrompt.AutoSize = True
        Me.lblTimePrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblTimePrompt.Name = "lblTimePrompt"
        Me.lblTimePrompt.Size = New System.Drawing.Size(125, 13)
        Me.lblTimePrompt.TabIndex = 0
        Me.lblTimePrompt.Text = "Enter the time in minutes:"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(143, 6)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(116, 20)
        Me.txtTime.TabIndex = 1
        '
        'grpTimeConversion
        '
        Me.grpTimeConversion.Controls.Add(Me.radHourMinFormat)
        Me.grpTimeConversion.Controls.Add(Me.radMinToSec)
        Me.grpTimeConversion.Location = New System.Drawing.Point(12, 32)
        Me.grpTimeConversion.Name = "grpTimeConversion"
        Me.grpTimeConversion.Size = New System.Drawing.Size(251, 110)
        Me.grpTimeConversion.TabIndex = 2
        Me.grpTimeConversion.TabStop = False
        Me.grpTimeConversion.Text = "Select Time Conversion"
        '
        'radHourMinFormat
        '
        Me.radHourMinFormat.AutoSize = True
        Me.radHourMinFormat.Location = New System.Drawing.Point(135, 48)
        Me.radHourMinFormat.Name = "radHourMinFormat"
        Me.radHourMinFormat.Size = New System.Drawing.Size(112, 30)
        Me.radHourMinFormat.TabIndex = 1
        Me.radHourMinFormat.TabStop = True
        Me.radHourMinFormat.Text = "Minutes to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hour minute format"
        Me.radHourMinFormat.UseVisualStyleBackColor = True
        '
        'radMinToSec
        '
        Me.radMinToSec.AutoSize = True
        Me.radMinToSec.Location = New System.Drawing.Point(6, 48)
        Me.radMinToSec.Name = "radMinToSec"
        Me.radMinToSec.Size = New System.Drawing.Size(117, 17)
        Me.radMinToSec.TabIndex = 0
        Me.radMinToSec.TabStop = True
        Me.radMinToSec.Text = "Minutes to seconds"
        Me.radMinToSec.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 145)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(251, 23)
        Me.lblAnswer.TabIndex = 3
        '
        'frmTimeConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 247)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.grpTimeConversion)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblTimePrompt)
        Me.Name = "frmTimeConversion"
        Me.Text = "Time Conversion"
        Me.grpTimeConversion.ResumeLayout(False)
        Me.grpTimeConversion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimePrompt As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents grpTimeConversion As System.Windows.Forms.GroupBox
    Friend WithEvents radHourMinFormat As System.Windows.Forms.RadioButton
    Friend WithEvents radMinToSec As System.Windows.Forms.RadioButton
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
