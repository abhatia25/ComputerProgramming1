<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBoxTuitionCalculator
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
        Me.lblCourseLevelList = New System.Windows.Forms.Label()
        Me.lstCourseLevels = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblCreditHours = New System.Windows.Forms.Label()
        Me.cboCreditHours = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(357, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'lblCourseLevelList
        '
        Me.lblCourseLevelList.AutoSize = True
        Me.lblCourseLevelList.Location = New System.Drawing.Point(12, 52)
        Me.lblCourseLevelList.Name = "lblCourseLevelList"
        Me.lblCourseLevelList.Size = New System.Drawing.Size(72, 13)
        Me.lblCourseLevelList.TabIndex = 1
        Me.lblCourseLevelList.Text = "Course Level:"
        '
        'lstCourseLevels
        '
        Me.lstCourseLevels.FormattingEnabled = True
        Me.lstCourseLevels.Items.AddRange(New Object() {"Undergraduate", "Graduate", "Thesis and Dissertation"})
        Me.lstCourseLevels.Location = New System.Drawing.Point(12, 68)
        Me.lstCourseLevels.Name = "lstCourseLevels"
        Me.lstCourseLevels.Size = New System.Drawing.Size(167, 69)
        Me.lstCourseLevels.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(163, 144)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 170)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(333, 83)
        Me.lblAnswer.TabIndex = 4
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCreditHours
        '
        Me.lblCreditHours.AutoSize = True
        Me.lblCreditHours.Location = New System.Drawing.Point(199, 52)
        Me.lblCreditHours.Name = "lblCreditHours"
        Me.lblCreditHours.Size = New System.Drawing.Size(68, 13)
        Me.lblCreditHours.TabIndex = 5
        Me.lblCreditHours.Text = "Credit Hours:"
        '
        'cboCreditHours
        '
        Me.cboCreditHours.FormattingEnabled = True
        Me.cboCreditHours.Items.AddRange(New Object() {"3", "6", "9", "12", "15"})
        Me.cboCreditHours.Location = New System.Drawing.Point(202, 68)
        Me.cboCreditHours.Name = "cboCreditHours"
        Me.cboCreditHours.Size = New System.Drawing.Size(121, 21)
        Me.cboCreditHours.TabIndex = 6
        '
        'frmListBoxTuitionCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 262)
        Me.Controls.Add(Me.cboCreditHours)
        Me.Controls.Add(Me.lblCreditHours)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstCourseLevels)
        Me.Controls.Add(Me.lblCourseLevelList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmListBoxTuitionCalculator"
        Me.Text = "Tuition Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCourseLevelList As System.Windows.Forms.Label
    Friend WithEvents lstCourseLevels As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblCreditHours As System.Windows.Forms.Label
    Friend WithEvents cboCreditHours As System.Windows.Forms.ComboBox

End Class
