﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadyForSchool
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
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloAgainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pizza2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMorningTasks = New System.Windows.Forms.GroupBox()
        Me.chkHomework = New System.Windows.Forms.CheckBox()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkBrush = New System.Windows.Forms.CheckBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpMorningTasks.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(271, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OtherProgramsToolStripMenuItem
        '
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloAgainToolStripMenuItem, Me.GradesToolStripMenuItem, Me.Pizza2ToolStripMenuItem, Me.CircleAreaToolStripMenuItem, Me.ScopeToolStripMenuItem, Me.CountingToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'HelloAgainToolStripMenuItem
        '
        Me.HelloAgainToolStripMenuItem.Name = "HelloAgainToolStripMenuItem"
        Me.HelloAgainToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelloAgainToolStripMenuItem.Text = "&Hello Again"
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GradesToolStripMenuItem.Text = "&Grades"
        '
        'Pizza2ToolStripMenuItem
        '
        Me.Pizza2ToolStripMenuItem.Name = "Pizza2ToolStripMenuItem"
        Me.Pizza2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Pizza2ToolStripMenuItem.Text = "&Pizza2"
        '
        'CircleAreaToolStripMenuItem
        '
        Me.CircleAreaToolStripMenuItem.Name = "CircleAreaToolStripMenuItem"
        Me.CircleAreaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CircleAreaToolStripMenuItem.Text = "&Circle Area"
        '
        'ScopeToolStripMenuItem
        '
        Me.ScopeToolStripMenuItem.Name = "ScopeToolStripMenuItem"
        Me.ScopeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ScopeToolStripMenuItem.Text = "&Scope"
        '
        'CountingToolStripMenuItem
        '
        Me.CountingToolStripMenuItem.Name = "CountingToolStripMenuItem"
        Me.CountingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CountingToolStripMenuItem.Text = "Countin&g"
        '
        'grpMorningTasks
        '
        Me.grpMorningTasks.Controls.Add(Me.chkBrush)
        Me.grpMorningTasks.Controls.Add(Me.chkBreakfast)
        Me.grpMorningTasks.Controls.Add(Me.chkHomework)
        Me.grpMorningTasks.Location = New System.Drawing.Point(77, 27)
        Me.grpMorningTasks.Name = "grpMorningTasks"
        Me.grpMorningTasks.Size = New System.Drawing.Size(114, 150)
        Me.grpMorningTasks.TabIndex = 1
        Me.grpMorningTasks.TabStop = False
        Me.grpMorningTasks.Text = "Morning Tasks"
        '
        'chkHomework
        '
        Me.chkHomework.AutoSize = True
        Me.chkHomework.Location = New System.Drawing.Point(6, 29)
        Me.chkHomework.Name = "chkHomework"
        Me.chkHomework.Size = New System.Drawing.Size(106, 17)
        Me.chkHomework.TabIndex = 0
        Me.chkHomework.Text = "Homework Done"
        Me.chkHomework.UseVisualStyleBackColor = True
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Location = New System.Drawing.Point(6, 72)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(90, 17)
        Me.chkBreakfast.TabIndex = 1
        Me.chkBreakfast.Text = "Eat Breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'chkBrush
        '
        Me.chkBrush.AutoSize = True
        Me.chkBrush.Location = New System.Drawing.Point(6, 114)
        Me.chkBrush.Name = "chkBrush"
        Me.chkBrush.Size = New System.Drawing.Size(84, 17)
        Me.chkBrush.TabIndex = 2
        Me.chkBrush.Text = "Brush Teeth"
        Me.chkBrush.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 180)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(247, 139)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReady
        '
        Me.btnReady.Location = New System.Drawing.Point(98, 350)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(75, 23)
        Me.btnReady.TabIndex = 3
        Me.btnReady.Text = "Ready"
        Me.btnReady.UseVisualStyleBackColor = True
        '
        'frmReadyForSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 385)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.grpMorningTasks)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReadyForSchool"
        Me.Text = "ReadyForSchool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpMorningTasks.ResumeLayout(False)
        Me.grpMorningTasks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloAgainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pizza2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircleAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScopeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpMorningTasks As System.Windows.Forms.GroupBox
    Friend WithEvents chkBrush As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreakfast As System.Windows.Forms.CheckBox
    Friend WithEvents chkHomework As System.Windows.Forms.CheckBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnReady As System.Windows.Forms.Button
End Class
