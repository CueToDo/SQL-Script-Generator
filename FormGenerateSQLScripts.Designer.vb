<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerateSQLScripts
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
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonScriptLocationProcedures = New System.Windows.Forms.Button()
        Me.ButtonScriptLocationFunctions = New System.Windows.Forms.Button()
        Me.ButtonScriptLocationViews = New System.Windows.Forms.Button()
        Me.ButtonScriptLocationTables = New System.Windows.Forms.Button()
        Me.TextBoxScriptLocationProcedures = New System.Windows.Forms.TextBox()
        Me.TextBoxScriptLocationFunctions = New System.Windows.Forms.TextBox()
        Me.TextBoxScriptLocationViews = New System.Windows.Forms.TextBox()
        Me.TextBoxScriptLocationTables = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelPerCentComplete = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelProgress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBarScripting = New System.Windows.Forms.ProgressBar()
        Me.CheckBoxTables = New System.Windows.Forms.CheckBox()
        Me.CheckBoxViews = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFunctions = New System.Windows.Forms.CheckBox()
        Me.CheckBoxProcedures = New System.Windows.Forms.CheckBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.LabelTimeTables = New System.Windows.Forms.Label()
        Me.LabelTimeViews = New System.Windows.Forms.Label()
        Me.LabelTimeFunctions = New System.Windows.Forms.Label()
        Me.LabelTimeProcedures = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(801, 179)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 9
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(627, 179)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(81, 23)
        Me.ButtonGenerate.TabIndex = 0
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelTimeProcedures)
        Me.GroupBox3.Controls.Add(Me.LabelTimeFunctions)
        Me.GroupBox3.Controls.Add(Me.LabelTimeViews)
        Me.GroupBox3.Controls.Add(Me.LabelTimeTables)
        Me.GroupBox3.Controls.Add(Me.CheckBoxProcedures)
        Me.GroupBox3.Controls.Add(Me.CheckBoxFunctions)
        Me.GroupBox3.Controls.Add(Me.CheckBoxViews)
        Me.GroupBox3.Controls.Add(Me.CheckBoxTables)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationProcedures)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationFunctions)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationViews)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationTables)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationProcedures)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationFunctions)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationViews)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationTables)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(864, 161)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Script"
        '
        'ButtonScriptLocationProcedures
        '
        Me.ButtonScriptLocationProcedures.Location = New System.Drawing.Point(727, 122)
        Me.ButtonScriptLocationProcedures.Name = "ButtonScriptLocationProcedures"
        Me.ButtonScriptLocationProcedures.Size = New System.Drawing.Size(33, 23)
        Me.ButtonScriptLocationProcedures.TabIndex = 11
        Me.ButtonScriptLocationProcedures.Text = "..."
        Me.ButtonScriptLocationProcedures.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonScriptLocationProcedures.UseVisualStyleBackColor = True
        '
        'ButtonScriptLocationFunctions
        '
        Me.ButtonScriptLocationFunctions.Location = New System.Drawing.Point(727, 92)
        Me.ButtonScriptLocationFunctions.Name = "ButtonScriptLocationFunctions"
        Me.ButtonScriptLocationFunctions.Size = New System.Drawing.Size(33, 23)
        Me.ButtonScriptLocationFunctions.TabIndex = 10
        Me.ButtonScriptLocationFunctions.Text = "..."
        Me.ButtonScriptLocationFunctions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonScriptLocationFunctions.UseVisualStyleBackColor = True
        '
        'ButtonScriptLocationViews
        '
        Me.ButtonScriptLocationViews.Location = New System.Drawing.Point(727, 65)
        Me.ButtonScriptLocationViews.Name = "ButtonScriptLocationViews"
        Me.ButtonScriptLocationViews.Size = New System.Drawing.Size(33, 23)
        Me.ButtonScriptLocationViews.TabIndex = 9
        Me.ButtonScriptLocationViews.Text = "..."
        Me.ButtonScriptLocationViews.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonScriptLocationViews.UseVisualStyleBackColor = True
        '
        'ButtonScriptLocationTables
        '
        Me.ButtonScriptLocationTables.Location = New System.Drawing.Point(727, 35)
        Me.ButtonScriptLocationTables.Name = "ButtonScriptLocationTables"
        Me.ButtonScriptLocationTables.Size = New System.Drawing.Size(33, 23)
        Me.ButtonScriptLocationTables.TabIndex = 8
        Me.ButtonScriptLocationTables.Text = "..."
        Me.ButtonScriptLocationTables.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonScriptLocationTables.UseVisualStyleBackColor = True
        '
        'TextBoxScriptLocationProcedures
        '
        Me.TextBoxScriptLocationProcedures.Location = New System.Drawing.Point(135, 122)
        Me.TextBoxScriptLocationProcedures.Name = "TextBoxScriptLocationProcedures"
        Me.TextBoxScriptLocationProcedures.Size = New System.Drawing.Size(586, 22)
        Me.TextBoxScriptLocationProcedures.TabIndex = 7
        '
        'TextBoxScriptLocationFunctions
        '
        Me.TextBoxScriptLocationFunctions.Location = New System.Drawing.Point(135, 94)
        Me.TextBoxScriptLocationFunctions.Name = "TextBoxScriptLocationFunctions"
        Me.TextBoxScriptLocationFunctions.Size = New System.Drawing.Size(586, 22)
        Me.TextBoxScriptLocationFunctions.TabIndex = 5
        '
        'TextBoxScriptLocationViews
        '
        Me.TextBoxScriptLocationViews.Location = New System.Drawing.Point(135, 66)
        Me.TextBoxScriptLocationViews.Name = "TextBoxScriptLocationViews"
        Me.TextBoxScriptLocationViews.Size = New System.Drawing.Size(586, 22)
        Me.TextBoxScriptLocationViews.TabIndex = 3
        '
        'TextBoxScriptLocationTables
        '
        Me.TextBoxScriptLocationTables.Location = New System.Drawing.Point(135, 35)
        Me.TextBoxScriptLocationTables.Name = "TextBoxScriptLocationTables"
        Me.TextBoxScriptLocationTables.Size = New System.Drawing.Size(586, 22)
        Me.TextBoxScriptLocationTables.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelPerCentComplete, Me.ToolStripStatusLabelProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 213)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(894, 25)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelPerCentComplete
        '
        Me.ToolStripStatusLabelPerCentComplete.Name = "ToolStripStatusLabelPerCentComplete"
        Me.ToolStripStatusLabelPerCentComplete.Size = New System.Drawing.Size(128, 20)
        Me.ToolStripStatusLabelPerCentComplete.Text = "PerCent Complete"
        '
        'ToolStripStatusLabelProgress
        '
        Me.ToolStripStatusLabelProgress.Name = "ToolStripStatusLabelProgress"
        Me.ToolStripStatusLabelProgress.Size = New System.Drawing.Size(65, 20)
        Me.ToolStripStatusLabelProgress.Text = "Progress"
        '
        'ProgressBarScripting
        '
        Me.ProgressBarScripting.Location = New System.Drawing.Point(12, 179)
        Me.ProgressBarScripting.Name = "ProgressBarScripting"
        Me.ProgressBarScripting.Size = New System.Drawing.Size(609, 23)
        Me.ProgressBarScripting.TabIndex = 11
        '
        'CheckBoxTables
        '
        Me.CheckBoxTables.AutoSize = True
        Me.CheckBoxTables.Location = New System.Drawing.Point(17, 38)
        Me.CheckBoxTables.Name = "CheckBoxTables"
        Me.CheckBoxTables.Size = New System.Drawing.Size(73, 21)
        Me.CheckBoxTables.TabIndex = 12
        Me.CheckBoxTables.Text = "Tables"
        Me.CheckBoxTables.UseVisualStyleBackColor = True
        '
        'CheckBoxViews
        '
        Me.CheckBoxViews.AutoSize = True
        Me.CheckBoxViews.Location = New System.Drawing.Point(17, 68)
        Me.CheckBoxViews.Name = "CheckBoxViews"
        Me.CheckBoxViews.Size = New System.Drawing.Size(66, 21)
        Me.CheckBoxViews.TabIndex = 13
        Me.CheckBoxViews.Text = "Views"
        Me.CheckBoxViews.UseVisualStyleBackColor = True
        '
        'CheckBoxFunctions
        '
        Me.CheckBoxFunctions.AutoSize = True
        Me.CheckBoxFunctions.Location = New System.Drawing.Point(17, 96)
        Me.CheckBoxFunctions.Name = "CheckBoxFunctions"
        Me.CheckBoxFunctions.Size = New System.Drawing.Size(91, 21)
        Me.CheckBoxFunctions.TabIndex = 14
        Me.CheckBoxFunctions.Text = "Functions"
        Me.CheckBoxFunctions.UseVisualStyleBackColor = True
        '
        'CheckBoxProcedures
        '
        Me.CheckBoxProcedures.AutoSize = True
        Me.CheckBoxProcedures.Location = New System.Drawing.Point(17, 124)
        Me.CheckBoxProcedures.Name = "CheckBoxProcedures"
        Me.CheckBoxProcedures.Size = New System.Drawing.Size(103, 21)
        Me.CheckBoxProcedures.TabIndex = 15
        Me.CheckBoxProcedures.Text = "Procedures"
        Me.CheckBoxProcedures.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(714, 179)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(81, 23)
        Me.ButtonCancel.TabIndex = 12
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'LabelTimeTables
        '
        Me.LabelTimeTables.AutoSize = True
        Me.LabelTimeTables.Location = New System.Drawing.Point(766, 38)
        Me.LabelTimeTables.Name = "LabelTimeTables"
        Me.LabelTimeTables.Size = New System.Drawing.Size(46, 17)
        Me.LabelTimeTables.TabIndex = 16
        Me.LabelTimeTables.Text = "0m 0s"
        '
        'LabelTimeViews
        '
        Me.LabelTimeViews.AutoSize = True
        Me.LabelTimeViews.Location = New System.Drawing.Point(766, 69)
        Me.LabelTimeViews.Name = "LabelTimeViews"
        Me.LabelTimeViews.Size = New System.Drawing.Size(46, 17)
        Me.LabelTimeViews.TabIndex = 17
        Me.LabelTimeViews.Text = "0m 0s"
        '
        'LabelTimeFunctions
        '
        Me.LabelTimeFunctions.AutoSize = True
        Me.LabelTimeFunctions.Location = New System.Drawing.Point(766, 96)
        Me.LabelTimeFunctions.Name = "LabelTimeFunctions"
        Me.LabelTimeFunctions.Size = New System.Drawing.Size(46, 17)
        Me.LabelTimeFunctions.TabIndex = 18
        Me.LabelTimeFunctions.Text = "0m 0s"
        '
        'LabelTimeProcedures
        '
        Me.LabelTimeProcedures.AutoSize = True
        Me.LabelTimeProcedures.Location = New System.Drawing.Point(766, 126)
        Me.LabelTimeProcedures.Name = "LabelTimeProcedures"
        Me.LabelTimeProcedures.Size = New System.Drawing.Size(46, 17)
        Me.LabelTimeProcedures.TabIndex = 19
        Me.LabelTimeProcedures.Text = "0m 0s"
        '
        'FormGenerateSQLScripts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 238)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ProgressBarScripting)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FormGenerateSQLScripts"
        Me.Text = "SQL Server Scripting"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonScriptLocationProcedures As System.Windows.Forms.Button
    Friend WithEvents ButtonScriptLocationFunctions As System.Windows.Forms.Button
    Friend WithEvents ButtonScriptLocationViews As System.Windows.Forms.Button
    Friend WithEvents ButtonScriptLocationTables As System.Windows.Forms.Button
    Friend WithEvents TextBoxScriptLocationProcedures As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScriptLocationFunctions As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScriptLocationViews As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxScriptLocationTables As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelProgress As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBarScripting As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolStripStatusLabelPerCentComplete As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CheckBoxProcedures As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFunctions As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxViews As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTables As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents LabelTimeProcedures As System.Windows.Forms.Label
    Friend WithEvents LabelTimeFunctions As System.Windows.Forms.Label
    Friend WithEvents LabelTimeViews As System.Windows.Forms.Label
    Friend WithEvents LabelTimeTables As System.Windows.Forms.Label

End Class
