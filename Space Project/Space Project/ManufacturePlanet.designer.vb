﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManufacturePlanet
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
        Me.btnManufacturingPlant = New System.Windows.Forms.Button()
        Me.btnSupermarket = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManufacturingPlant
        '
        Me.btnManufacturingPlant.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnManufacturingPlant.Location = New System.Drawing.Point(656, 266)
        Me.btnManufacturingPlant.Name = "btnManufacturingPlant"
        Me.btnManufacturingPlant.Size = New System.Drawing.Size(83, 48)
        Me.btnManufacturingPlant.TabIndex = 0
        Me.btnManufacturingPlant.Text = "Go to Manufacturing Plant"
        Me.btnManufacturingPlant.UseVisualStyleBackColor = True
        '
        'btnSupermarket
        '
        Me.btnSupermarket.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupermarket.Location = New System.Drawing.Point(311, 351)
        Me.btnSupermarket.Name = "btnSupermarket"
        Me.btnSupermarket.Size = New System.Drawing.Size(81, 35)
        Me.btnSupermarket.TabIndex = 1
        Me.btnSupermarket.Text = "Go to Supermarket"
        Me.btnSupermarket.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(12, 12)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'frmManufacturePlanet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Manufacturing_Buildings
        Me.ClientSize = New System.Drawing.Size(821, 421)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnSupermarket)
        Me.Controls.Add(Me.btnManufacturingPlant)
        Me.Name = "frmManufacturePlanet"
        Me.Text = "Manufacture Planet"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnManufacturingPlant As System.Windows.Forms.Button
    Friend WithEvents btnSupermarket As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
End Class