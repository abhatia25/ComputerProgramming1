﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourceNum3
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
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.picReflector = New System.Windows.Forms.PictureBox()
        CType(Me.picReflector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(12, 12)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 0
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'picReflector
        '
        Me.picReflector.BackgroundImage = Global.Space_Project.My.Resources.Resources.radiation_reflector
        Me.picReflector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picReflector.Location = New System.Drawing.Point(267, 24)
        Me.picReflector.Name = "picReflector"
        Me.picReflector.Size = New System.Drawing.Size(104, 96)
        Me.picReflector.TabIndex = 1
        Me.picReflector.TabStop = False
        '
        'frmResourceNum3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Shape_Shifting_Planet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(821, 420)
        Me.Controls.Add(Me.picReflector)
        Me.Controls.Add(Me.btnInventory)
        Me.Name = "frmResourceNum3"
        Me.Text = "Shape Shifting Planet"
        CType(Me.picReflector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents picReflector As PictureBox
End Class