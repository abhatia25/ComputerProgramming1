﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayNameBackwards
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnDisplayBackwards = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.picCheckMark = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picCheckMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
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
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(86, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'btnDisplayBackwards
        '
        Me.btnDisplayBackwards.Location = New System.Drawing.Point(97, 63)
        Me.btnDisplayBackwards.Name = "btnDisplayBackwards"
        Me.btnDisplayBackwards.Size = New System.Drawing.Size(75, 43)
        Me.btnDisplayBackwards.TabIndex = 2
        Me.btnDisplayBackwards.Text = "Display Backwards"
        Me.btnDisplayBackwards.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(34, 109)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(207, 113)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCheckMark
        '
        Me.picCheckMark.BackgroundImage = Global._5._04_Work.My.Resources.Resources.checkmark
        Me.picCheckMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCheckMark.Location = New System.Drawing.Point(12, 27)
        Me.picCheckMark.Name = "picCheckMark"
        Me.picCheckMark.Size = New System.Drawing.Size(67, 46)
        Me.picCheckMark.TabIndex = 4
        Me.picCheckMark.TabStop = False
        Me.picCheckMark.Visible = False
        '
        'frmDisplayNameBackwards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.picCheckMark)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnDisplayBackwards)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDisplayNameBackwards"
        Me.Text = "Display Name Backwards"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picCheckMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayBackwards As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents picCheckMark As System.Windows.Forms.PictureBox
End Class
