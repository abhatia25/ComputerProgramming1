<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMorningToDo
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
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.chkKissMom = New System.Windows.Forms.CheckBox()
        Me.chkSchoolWork = New System.Windows.Forms.CheckBox()
        Me.chkEatBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkMakeBed = New System.Windows.Forms.CheckBox()
        Me.grpPersonal = New System.Windows.Forms.GroupBox()
        Me.chkGetDressed = New System.Windows.Forms.CheckBox()
        Me.chkStyleHair = New System.Windows.Forms.CheckBox()
        Me.chkBrushTeeth = New System.Windows.Forms.CheckBox()
        Me.chkShower = New System.Windows.Forms.CheckBox()
        Me.btnAllDone = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpActions.SuspendLayout()
        Me.grpPersonal.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.chkKissMom)
        Me.grpActions.Controls.Add(Me.chkSchoolWork)
        Me.grpActions.Controls.Add(Me.chkEatBreakfast)
        Me.grpActions.Controls.Add(Me.chkMakeBed)
        Me.grpActions.Location = New System.Drawing.Point(345, 167)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(200, 275)
        Me.grpActions.TabIndex = 0
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "Actions"
        '
        'chkKissMom
        '
        Me.chkKissMom.AutoSize = True
        Me.chkKissMom.Location = New System.Drawing.Point(6, 252)
        Me.chkKissMom.Name = "chkKissMom"
        Me.chkKissMom.Size = New System.Drawing.Size(117, 17)
        Me.chkKissMom.TabIndex = 3
        Me.chkKissMom.Text = "Kiss Mom Goodbye"
        Me.chkKissMom.UseVisualStyleBackColor = True
        '
        'chkSchoolWork
        '
        Me.chkSchoolWork.AutoSize = True
        Me.chkSchoolWork.Location = New System.Drawing.Point(6, 171)
        Me.chkSchoolWork.Name = "chkSchoolWork"
        Me.chkSchoolWork.Size = New System.Drawing.Size(123, 17)
        Me.chkSchoolWork.TabIndex = 2
        Me.chkSchoolWork.Text = "Gather School Work"
        Me.chkSchoolWork.UseVisualStyleBackColor = True
        '
        'chkEatBreakfast
        '
        Me.chkEatBreakfast.AutoSize = True
        Me.chkEatBreakfast.Location = New System.Drawing.Point(6, 101)
        Me.chkEatBreakfast.Name = "chkEatBreakfast"
        Me.chkEatBreakfast.Size = New System.Drawing.Size(90, 17)
        Me.chkEatBreakfast.TabIndex = 1
        Me.chkEatBreakfast.Text = "Eat Breakfast"
        Me.chkEatBreakfast.UseVisualStyleBackColor = True
        '
        'chkMakeBed
        '
        Me.chkMakeBed.AutoSize = True
        Me.chkMakeBed.Location = New System.Drawing.Point(6, 19)
        Me.chkMakeBed.Name = "chkMakeBed"
        Me.chkMakeBed.Size = New System.Drawing.Size(75, 17)
        Me.chkMakeBed.TabIndex = 0
        Me.chkMakeBed.Text = "Make Bed"
        Me.chkMakeBed.UseVisualStyleBackColor = True
        '
        'grpPersonal
        '
        Me.grpPersonal.Controls.Add(Me.chkGetDressed)
        Me.grpPersonal.Controls.Add(Me.chkStyleHair)
        Me.grpPersonal.Controls.Add(Me.chkBrushTeeth)
        Me.grpPersonal.Controls.Add(Me.chkShower)
        Me.grpPersonal.Location = New System.Drawing.Point(12, 167)
        Me.grpPersonal.Name = "grpPersonal"
        Me.grpPersonal.Size = New System.Drawing.Size(200, 275)
        Me.grpPersonal.TabIndex = 0
        Me.grpPersonal.TabStop = False
        Me.grpPersonal.Text = "Personal"
        '
        'chkGetDressed
        '
        Me.chkGetDressed.AutoSize = True
        Me.chkGetDressed.Location = New System.Drawing.Point(6, 252)
        Me.chkGetDressed.Name = "chkGetDressed"
        Me.chkGetDressed.Size = New System.Drawing.Size(85, 17)
        Me.chkGetDressed.TabIndex = 3
        Me.chkGetDressed.Text = "Get Dressed"
        Me.chkGetDressed.UseVisualStyleBackColor = True
        '
        'chkStyleHair
        '
        Me.chkStyleHair.AutoSize = True
        Me.chkStyleHair.Location = New System.Drawing.Point(6, 171)
        Me.chkStyleHair.Name = "chkStyleHair"
        Me.chkStyleHair.Size = New System.Drawing.Size(71, 17)
        Me.chkStyleHair.TabIndex = 2
        Me.chkStyleHair.Text = "Style Hair"
        Me.chkStyleHair.UseVisualStyleBackColor = True
        '
        'chkBrushTeeth
        '
        Me.chkBrushTeeth.AutoSize = True
        Me.chkBrushTeeth.Location = New System.Drawing.Point(6, 101)
        Me.chkBrushTeeth.Name = "chkBrushTeeth"
        Me.chkBrushTeeth.Size = New System.Drawing.Size(84, 17)
        Me.chkBrushTeeth.TabIndex = 1
        Me.chkBrushTeeth.Text = "Brush Teeth"
        Me.chkBrushTeeth.UseVisualStyleBackColor = True
        '
        'chkShower
        '
        Me.chkShower.AutoSize = True
        Me.chkShower.Location = New System.Drawing.Point(6, 19)
        Me.chkShower.Name = "chkShower"
        Me.chkShower.Size = New System.Drawing.Size(62, 17)
        Me.chkShower.TabIndex = 0
        Me.chkShower.Text = "Shower"
        Me.chkShower.UseVisualStyleBackColor = True
        '
        'btnAllDone
        '
        Me.btnAllDone.Location = New System.Drawing.Point(616, 288)
        Me.btnAllDone.Name = "btnAllDone"
        Me.btnAllDone.Size = New System.Drawing.Size(75, 23)
        Me.btnAllDone.TabIndex = 1
        Me.btnAllDone.Text = "All Done"
        Me.btnAllDone.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(717, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmMorningToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 454)
        Me.Controls.Add(Me.btnAllDone)
        Me.Controls.Add(Me.grpPersonal)
        Me.Controls.Add(Me.grpActions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMorningToDo"
        Me.Text = "Morning To-Do List"
        Me.grpActions.ResumeLayout(False)
        Me.grpActions.PerformLayout()
        Me.grpPersonal.ResumeLayout(False)
        Me.grpPersonal.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents chkKissMom As System.Windows.Forms.CheckBox
    Friend WithEvents chkSchoolWork As System.Windows.Forms.CheckBox
    Friend WithEvents chkEatBreakfast As System.Windows.Forms.CheckBox
    Friend WithEvents chkMakeBed As System.Windows.Forms.CheckBox
    Friend WithEvents grpPersonal As System.Windows.Forms.GroupBox
    Friend WithEvents chkGetDressed As System.Windows.Forms.CheckBox
    Friend WithEvents chkStyleHair As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrushTeeth As System.Windows.Forms.CheckBox
    Friend WithEvents chkShower As System.Windows.Forms.CheckBox
    Friend WithEvents btnAllDone As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
