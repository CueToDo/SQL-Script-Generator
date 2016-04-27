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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDatabase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxRemoteServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonScriptProcedures = New System.Windows.Forms.RadioButton()
        Me.RadioButtonScriptFunctions = New System.Windows.Forms.RadioButton()
        Me.RadioButtonScriptViews = New System.Windows.Forms.RadioButton()
        Me.RadioButtonScriptTables = New System.Windows.Forms.RadioButton()
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
        Me.ToolStripStatusLabelProgress = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBarScripting = New System.Windows.Forms.ProgressBar()
        Me.ToolStripStatusLabelPerCentComplete = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelElapsed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxLogin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxDatabase)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxRemoteServer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connect"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(139, 119)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(125, 22)
        Me.TextBoxPassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.Location = New System.Drawing.Point(139, 91)
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(125, 22)
        Me.TextBoxLogin.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Login"
        '
        'TextBoxDatabase
        '
        Me.TextBoxDatabase.Location = New System.Drawing.Point(139, 63)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.Size = New System.Drawing.Size(125, 22)
        Me.TextBoxDatabase.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Database"
        '
        'TextBoxRemoteServer
        '
        Me.TextBoxRemoteServer.Location = New System.Drawing.Point(139, 35)
        Me.TextBoxRemoteServer.Name = "TextBoxRemoteServer"
        Me.TextBoxRemoteServer.Size = New System.Drawing.Size(125, 22)
        Me.TextBoxRemoteServer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server"
        '
        'ButtonExit
        '
        Me.ButtonExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExit.Location = New System.Drawing.Point(1043, 191)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 9
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGenerate.Location = New System.Drawing.Point(956, 191)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(81, 23)
        Me.ButtonGenerate.TabIndex = 0
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonScriptProcedures)
        Me.GroupBox3.Controls.Add(Me.RadioButtonScriptFunctions)
        Me.GroupBox3.Controls.Add(Me.RadioButtonScriptViews)
        Me.GroupBox3.Controls.Add(Me.RadioButtonScriptTables)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationProcedures)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationFunctions)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationViews)
        Me.GroupBox3.Controls.Add(Me.ButtonScriptLocationTables)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationProcedures)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationFunctions)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationViews)
        Me.GroupBox3.Controls.Add(Me.TextBoxScriptLocationTables)
        Me.GroupBox3.Location = New System.Drawing.Point(330, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(788, 161)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Script"
        '
        'RadioButtonScriptProcedures
        '
        Me.RadioButtonScriptProcedures.AutoSize = True
        Me.RadioButtonScriptProcedures.Checked = True
        Me.RadioButtonScriptProcedures.Location = New System.Drawing.Point(21, 124)
        Me.RadioButtonScriptProcedures.Name = "RadioButtonScriptProcedures"
        Me.RadioButtonScriptProcedures.Size = New System.Drawing.Size(102, 21)
        Me.RadioButtonScriptProcedures.TabIndex = 15
        Me.RadioButtonScriptProcedures.TabStop = True
        Me.RadioButtonScriptProcedures.Text = "Procedures"
        Me.RadioButtonScriptProcedures.UseVisualStyleBackColor = True
        '
        'RadioButtonScriptFunctions
        '
        Me.RadioButtonScriptFunctions.AutoSize = True
        Me.RadioButtonScriptFunctions.Location = New System.Drawing.Point(21, 94)
        Me.RadioButtonScriptFunctions.Name = "RadioButtonScriptFunctions"
        Me.RadioButtonScriptFunctions.Size = New System.Drawing.Size(90, 21)
        Me.RadioButtonScriptFunctions.TabIndex = 14
        Me.RadioButtonScriptFunctions.Text = "Functions"
        Me.RadioButtonScriptFunctions.UseVisualStyleBackColor = True
        '
        'RadioButtonScriptViews
        '
        Me.RadioButtonScriptViews.AutoSize = True
        Me.RadioButtonScriptViews.Location = New System.Drawing.Point(21, 67)
        Me.RadioButtonScriptViews.Name = "RadioButtonScriptViews"
        Me.RadioButtonScriptViews.Size = New System.Drawing.Size(65, 21)
        Me.RadioButtonScriptViews.TabIndex = 13
        Me.RadioButtonScriptViews.Text = "Views"
        Me.RadioButtonScriptViews.UseVisualStyleBackColor = True
        '
        'RadioButtonScriptTables
        '
        Me.RadioButtonScriptTables.AutoSize = True
        Me.RadioButtonScriptTables.Location = New System.Drawing.Point(21, 36)
        Me.RadioButtonScriptTables.Name = "RadioButtonScriptTables"
        Me.RadioButtonScriptTables.Size = New System.Drawing.Size(72, 21)
        Me.RadioButtonScriptTables.TabIndex = 12
        Me.RadioButtonScriptTables.Text = "Tables"
        Me.RadioButtonScriptTables.UseVisualStyleBackColor = True
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelPerCentComplete, Me.ToolStripStatusLabelElapsed, Me.ToolStripStatusLabelProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 218)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1138, 25)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelProgress
        '
        Me.ToolStripStatusLabelProgress.Name = "ToolStripStatusLabelProgress"
        Me.ToolStripStatusLabelProgress.Size = New System.Drawing.Size(65, 20)
        Me.ToolStripStatusLabelProgress.Text = "Progress"
        '
        'ProgressBarScripting
        '
        Me.ProgressBarScripting.Location = New System.Drawing.Point(330, 191)
        Me.ProgressBarScripting.Name = "ProgressBarScripting"
        Me.ProgressBarScripting.Size = New System.Drawing.Size(620, 23)
        Me.ProgressBarScripting.TabIndex = 11
        '
        'ToolStripStatusLabelPerCentComplete
        '
        Me.ToolStripStatusLabelPerCentComplete.Name = "ToolStripStatusLabelPerCentComplete"
        Me.ToolStripStatusLabelPerCentComplete.Size = New System.Drawing.Size(128, 20)
        Me.ToolStripStatusLabelPerCentComplete.Text = "PerCent Complete"
        '
        'ToolStripStatusLabelElapsed
        '
        Me.ToolStripStatusLabelElapsed.Name = "ToolStripStatusLabelElapsed"
        Me.ToolStripStatusLabelElapsed.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripStatusLabelElapsed.Text = "Elapsed"
        '
        'FormGenerateSQLScripts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 243)
        Me.Controls.Add(Me.ProgressBarScripting)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormGenerateSQLScripts"
        Me.Text = "SQL Server Scripting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRemoteServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents RadioButtonScriptProcedures As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonScriptFunctions As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonScriptViews As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonScriptTables As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelProgress As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBarScripting As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolStripStatusLabelPerCentComplete As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelElapsed As System.Windows.Forms.ToolStripStatusLabel

End Class
