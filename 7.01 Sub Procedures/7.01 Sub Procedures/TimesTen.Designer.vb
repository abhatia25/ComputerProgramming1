﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimesTen
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNumPrompt = New System.Windows.Forms.Label()
        Me.txtNumEntered = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(185, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'lblNumPrompt
        '
        Me.lblNumPrompt.Location = New System.Drawing.Point(12, 34)
        Me.lblNumPrompt.Name = "lblNumPrompt"
        Me.lblNumPrompt.Size = New System.Drawing.Size(89, 23)
        Me.lblNumPrompt.TabIndex = 1
        Me.lblNumPrompt.Text = "Enter a number"
        Me.lblNumPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumEntered
        '
        Me.txtNumEntered.Location = New System.Drawing.Point(107, 37)
        Me.txtNumEntered.Name = "txtNumEntered"
        Me.txtNumEntered.Size = New System.Drawing.Size(53, 20)
        Me.txtNumEntered.TabIndex = 2
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 67)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(161, 102)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(53, 182)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmTimesTen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(185, 218)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtNumEntered)
        Me.Controls.Add(Me.lblNumPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTimesTen"
        Me.Text = "Times Ten"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNumPrompt As Label
    Friend WithEvents txtNumEntered As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnShow As Button
End Class
