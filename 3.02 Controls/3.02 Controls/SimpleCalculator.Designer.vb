<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleCalculator
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
        Me.ElseIfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumOf4NumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleDiceRollingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpNumbers = New System.Windows.Forms.GroupBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAddTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblMultTitle = New System.Windows.Forms.Label()
        Me.lblDivTitle = New System.Windows.Forms.Label()
        Me.lblResultsHeader = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblMult = New System.Windows.Forms.Label()
        Me.lblDiv = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(524, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElseIfToolStripMenuItem, Me.SumOf4NumbersToolStripMenuItem, Me.SimpleDiceRollingToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'ElseIfToolStripMenuItem
        '
        Me.ElseIfToolStripMenuItem.Name = "ElseIfToolStripMenuItem"
        Me.ElseIfToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ElseIfToolStripMenuItem.Text = "&Else If"
        '
        'SumOf4NumbersToolStripMenuItem
        '
        Me.SumOf4NumbersToolStripMenuItem.Name = "SumOf4NumbersToolStripMenuItem"
        Me.SumOf4NumbersToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SumOf4NumbersToolStripMenuItem.Text = "&Sum of 4 Numbers"
        '
        'SimpleDiceRollingToolStripMenuItem
        '
        Me.SimpleDiceRollingToolStripMenuItem.Name = "SimpleDiceRollingToolStripMenuItem"
        Me.SimpleDiceRollingToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SimpleDiceRollingToolStripMenuItem.Text = "Simple &Dice Rolling"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(218, 236)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpNumbers
        '
        Me.grpNumbers.Controls.Add(Me.txtNum2)
        Me.grpNumbers.Controls.Add(Me.txtNum1)
        Me.grpNumbers.Location = New System.Drawing.Point(152, 102)
        Me.grpNumbers.Name = "grpNumbers"
        Me.grpNumbers.Size = New System.Drawing.Size(210, 128)
        Me.grpNumbers.TabIndex = 2
        Me.grpNumbers.TabStop = False
        Me.grpNumbers.Text = "Please enter two numbers"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(54, 88)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(54, 29)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 54)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Simple Calculator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddTitle
        '
        Me.lblAddTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddTitle.Location = New System.Drawing.Point(4, 344)
        Me.lblAddTitle.Name = "lblAddTitle"
        Me.lblAddTitle.Size = New System.Drawing.Size(60, 23)
        Me.lblAddTitle.TabIndex = 4
        Me.lblAddTitle.Text = "Add"
        Me.lblAddTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTitle
        '
        Me.lblSubTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(139, 344)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(60, 23)
        Me.lblSubTitle.TabIndex = 5
        Me.lblSubTitle.Text = "Subtract"
        Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMultTitle
        '
        Me.lblMultTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultTitle.Location = New System.Drawing.Point(302, 344)
        Me.lblMultTitle.Name = "lblMultTitle"
        Me.lblMultTitle.Size = New System.Drawing.Size(60, 23)
        Me.lblMultTitle.TabIndex = 6
        Me.lblMultTitle.Text = "Multiply"
        Me.lblMultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDivTitle
        '
        Me.lblDivTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivTitle.Location = New System.Drawing.Point(461, 344)
        Me.lblDivTitle.Name = "lblDivTitle"
        Me.lblDivTitle.Size = New System.Drawing.Size(60, 23)
        Me.lblDivTitle.TabIndex = 7
        Me.lblDivTitle.Text = "Divide"
        Me.lblDivTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResultsHeader
        '
        Me.lblResultsHeader.AutoSize = True
        Me.lblResultsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsHeader.Location = New System.Drawing.Point(214, 293)
        Me.lblResultsHeader.Name = "lblResultsHeader"
        Me.lblResultsHeader.Size = New System.Drawing.Size(78, 24)
        Me.lblResultsHeader.TabIndex = 8
        Me.lblResultsHeader.Text = "Results"
        '
        'lblSub
        '
        Me.lblSub.Location = New System.Drawing.Point(139, 397)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(60, 23)
        Me.lblSub.TabIndex = 9
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdd
        '
        Me.lblAdd.Location = New System.Drawing.Point(4, 397)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(60, 23)
        Me.lblAdd.TabIndex = 10
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMult
        '
        Me.lblMult.Location = New System.Drawing.Point(302, 397)
        Me.lblMult.Name = "lblMult"
        Me.lblMult.Size = New System.Drawing.Size(60, 23)
        Me.lblMult.TabIndex = 11
        Me.lblMult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiv
        '
        Me.lblDiv.Location = New System.Drawing.Point(461, 397)
        Me.lblDiv.Name = "lblDiv"
        Me.lblDiv.Size = New System.Drawing.Size(60, 23)
        Me.lblDiv.TabIndex = 12
        Me.lblDiv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSimpleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 479)
        Me.Controls.Add(Me.lblDiv)
        Me.Controls.Add(Me.lblMult)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.lblResultsHeader)
        Me.Controls.Add(Me.lblDivTitle)
        Me.Controls.Add(Me.lblMultTitle)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblAddTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpNumbers)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSimpleCalculator"
        Me.Text = "Simple Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpNumbers.ResumeLayout(False)
        Me.grpNumbers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElseIfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SumOf4NumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleDiceRollingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents grpNumbers As System.Windows.Forms.GroupBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAddTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblMultTitle As System.Windows.Forms.Label
    Friend WithEvents lblDivTitle As System.Windows.Forms.Label
    Friend WithEvents lblResultsHeader As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblMult As System.Windows.Forms.Label
    Friend WithEvents lblDiv As System.Windows.Forms.Label
End Class
