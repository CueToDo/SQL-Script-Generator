<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageTables = New System.Windows.Forms.TabPage()
        Me.TabPageViews = New System.Windows.Forms.TabPage()
        Me.TabPageFunctions = New System.Windows.Forms.TabPage()
        Me.TabPageProcedures = New System.Windows.Forms.TabPage()
        Me.CheckBoxIncludeSystemConstraintNames = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptDefaults = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptCollation = New System.Windows.Forms.CheckBox()
        Me.TabPageGeneral = New System.Windows.Forms.TabPage()
        Me.CheckBoxANSIPadding = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptDROPAsWellAsCREATE = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIncludeDescriptiveHeaders = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSchemaQualifyObjectNames = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptExtendedProperties = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptPermissions = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptOwner = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptCheckConstraints = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptForeignKeys = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptFullTextIndexes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptIndexes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptPrimaryKeys = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptTriggers = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptUniqueKeys = New System.Windows.Forms.CheckBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPageTables.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageGeneral)
        Me.TabControl1.Controls.Add(Me.TabPageTables)
        Me.TabControl1.Controls.Add(Me.TabPageViews)
        Me.TabControl1.Controls.Add(Me.TabPageFunctions)
        Me.TabControl1.Controls.Add(Me.TabPageProcedures)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(323, 316)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageTables
        '
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptUniqueKeys)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptTriggers)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptPrimaryKeys)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptIndexes)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptFullTextIndexes)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptForeignKeys)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptCheckConstraints)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptDefaults)
        Me.TabPageTables.Controls.Add(Me.CheckBoxScriptCollation)
        Me.TabPageTables.Controls.Add(Me.CheckBoxIncludeSystemConstraintNames)
        Me.TabPageTables.Location = New System.Drawing.Point(4, 25)
        Me.TabPageTables.Name = "TabPageTables"
        Me.TabPageTables.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTables.Size = New System.Drawing.Size(315, 287)
        Me.TabPageTables.TabIndex = 0
        Me.TabPageTables.Text = "Tables"
        Me.TabPageTables.UseVisualStyleBackColor = True
        '
        'TabPageViews
        '
        Me.TabPageViews.Location = New System.Drawing.Point(4, 25)
        Me.TabPageViews.Name = "TabPageViews"
        Me.TabPageViews.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageViews.Size = New System.Drawing.Size(315, 287)
        Me.TabPageViews.TabIndex = 1
        Me.TabPageViews.Text = "Views"
        Me.TabPageViews.UseVisualStyleBackColor = True
        '
        'TabPageFunctions
        '
        Me.TabPageFunctions.Location = New System.Drawing.Point(4, 25)
        Me.TabPageFunctions.Name = "TabPageFunctions"
        Me.TabPageFunctions.Size = New System.Drawing.Size(315, 287)
        Me.TabPageFunctions.TabIndex = 2
        Me.TabPageFunctions.Text = "Functions"
        Me.TabPageFunctions.UseVisualStyleBackColor = True
        '
        'TabPageProcedures
        '
        Me.TabPageProcedures.Location = New System.Drawing.Point(4, 25)
        Me.TabPageProcedures.Name = "TabPageProcedures"
        Me.TabPageProcedures.Size = New System.Drawing.Size(315, 287)
        Me.TabPageProcedures.TabIndex = 3
        Me.TabPageProcedures.Text = "Procedures"
        Me.TabPageProcedures.UseVisualStyleBackColor = True
        '
        'CheckBoxIncludeSystemConstraintNames
        '
        Me.CheckBoxIncludeSystemConstraintNames.AutoSize = True
        Me.CheckBoxIncludeSystemConstraintNames.Location = New System.Drawing.Point(6, 222)
        Me.CheckBoxIncludeSystemConstraintNames.Name = "CheckBoxIncludeSystemConstraintNames"
        Me.CheckBoxIncludeSystemConstraintNames.Size = New System.Drawing.Size(235, 21)
        Me.CheckBoxIncludeSystemConstraintNames.TabIndex = 1
        Me.CheckBoxIncludeSystemConstraintNames.Text = "Include system constraint names"
        Me.CheckBoxIncludeSystemConstraintNames.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptDefaults
        '
        Me.CheckBoxScriptDefaults.AutoSize = True
        Me.CheckBoxScriptDefaults.Location = New System.Drawing.Point(6, 168)
        Me.CheckBoxScriptDefaults.Name = "CheckBoxScriptDefaults"
        Me.CheckBoxScriptDefaults.Size = New System.Drawing.Size(120, 21)
        Me.CheckBoxScriptDefaults.TabIndex = 3
        Me.CheckBoxScriptDefaults.Text = "Script defaults"
        Me.CheckBoxScriptDefaults.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptCollation
        '
        Me.CheckBoxScriptCollation.AutoSize = True
        Me.CheckBoxScriptCollation.Location = New System.Drawing.Point(6, 6)
        Me.CheckBoxScriptCollation.Name = "CheckBoxScriptCollation"
        Me.CheckBoxScriptCollation.Size = New System.Drawing.Size(122, 21)
        Me.CheckBoxScriptCollation.TabIndex = 2
        Me.CheckBoxScriptCollation.Text = "Script collation"
        Me.CheckBoxScriptCollation.UseVisualStyleBackColor = True
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.CheckBoxScriptOwner)
        Me.TabPageGeneral.Controls.Add(Me.CheckBoxScriptPermissions)
        Me.TabPageGeneral.Controls.Add(Me.CheckBoxScriptExtendedProperties)
        Me.TabPageGeneral.Controls.Add(Me.CheckBoxSchemaQualifyObjectNames)
        Me.TabPageGeneral.Controls.Add(Me.CheckBoxIncludeDescriptiveHeaders)
        Me.TabPageGeneral.Controls.Add(Me.CheckBoxScriptDROPAsWellAsCREATE)
        Me.TabPageGeneral.Controls.Add(Me.CheckBoxANSIPadding)
        Me.TabPageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.Size = New System.Drawing.Size(315, 287)
        Me.TabPageGeneral.TabIndex = 4
        Me.TabPageGeneral.Text = "General"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'CheckBoxANSIPadding
        '
        Me.CheckBoxANSIPadding.AutoSize = True
        Me.CheckBoxANSIPadding.Location = New System.Drawing.Point(3, 3)
        Me.CheckBoxANSIPadding.Name = "CheckBoxANSIPadding"
        Me.CheckBoxANSIPadding.Size = New System.Drawing.Size(116, 21)
        Me.CheckBoxANSIPadding.TabIndex = 1
        Me.CheckBoxANSIPadding.Text = "ANSI padding"
        Me.CheckBoxANSIPadding.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptDROPAsWellAsCREATE
        '
        Me.CheckBoxScriptDROPAsWellAsCREATE.AutoSize = True
        Me.CheckBoxScriptDROPAsWellAsCREATE.Location = New System.Drawing.Point(3, 57)
        Me.CheckBoxScriptDROPAsWellAsCREATE.Name = "CheckBoxScriptDROPAsWellAsCREATE"
        Me.CheckBoxScriptDROPAsWellAsCREATE.Size = New System.Drawing.Size(234, 21)
        Me.CheckBoxScriptDROPAsWellAsCREATE.TabIndex = 2
        Me.CheckBoxScriptDROPAsWellAsCREATE.Text = "Script DROP as well as CREATE"
        Me.CheckBoxScriptDROPAsWellAsCREATE.UseVisualStyleBackColor = True
        '
        'CheckBoxIncludeDescriptiveHeaders
        '
        Me.CheckBoxIncludeDescriptiveHeaders.AutoSize = True
        Me.CheckBoxIncludeDescriptiveHeaders.Location = New System.Drawing.Point(3, 30)
        Me.CheckBoxIncludeDescriptiveHeaders.Name = "CheckBoxIncludeDescriptiveHeaders"
        Me.CheckBoxIncludeDescriptiveHeaders.Size = New System.Drawing.Size(203, 21)
        Me.CheckBoxIncludeDescriptiveHeaders.TabIndex = 3
        Me.CheckBoxIncludeDescriptiveHeaders.Text = "Include descriptive headers"
        Me.CheckBoxIncludeDescriptiveHeaders.UseVisualStyleBackColor = True
        '
        'CheckBoxSchemaQualifyObjectNames
        '
        Me.CheckBoxSchemaQualifyObjectNames.AutoSize = True
        Me.CheckBoxSchemaQualifyObjectNames.Location = New System.Drawing.Point(3, 84)
        Me.CheckBoxSchemaQualifyObjectNames.Name = "CheckBoxSchemaQualifyObjectNames"
        Me.CheckBoxSchemaQualifyObjectNames.Size = New System.Drawing.Size(214, 21)
        Me.CheckBoxSchemaQualifyObjectNames.TabIndex = 4
        Me.CheckBoxSchemaQualifyObjectNames.Text = "Schema qualify object names"
        Me.CheckBoxSchemaQualifyObjectNames.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptExtendedProperties
        '
        Me.CheckBoxScriptExtendedProperties.AutoSize = True
        Me.CheckBoxScriptExtendedProperties.Location = New System.Drawing.Point(3, 111)
        Me.CheckBoxScriptExtendedProperties.Name = "CheckBoxScriptExtendedProperties"
        Me.CheckBoxScriptExtendedProperties.Size = New System.Drawing.Size(196, 21)
        Me.CheckBoxScriptExtendedProperties.TabIndex = 5
        Me.CheckBoxScriptExtendedProperties.Text = "Script extended properties"
        Me.CheckBoxScriptExtendedProperties.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptPermissions
        '
        Me.CheckBoxScriptPermissions.AutoSize = True
        Me.CheckBoxScriptPermissions.Location = New System.Drawing.Point(3, 138)
        Me.CheckBoxScriptPermissions.Name = "CheckBoxScriptPermissions"
        Me.CheckBoxScriptPermissions.Size = New System.Drawing.Size(145, 21)
        Me.CheckBoxScriptPermissions.TabIndex = 6
        Me.CheckBoxScriptPermissions.Text = "Script permissions"
        Me.CheckBoxScriptPermissions.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptOwner
        '
        Me.CheckBoxScriptOwner.AutoSize = True
        Me.CheckBoxScriptOwner.Location = New System.Drawing.Point(3, 165)
        Me.CheckBoxScriptOwner.Name = "CheckBoxScriptOwner"
        Me.CheckBoxScriptOwner.Size = New System.Drawing.Size(108, 21)
        Me.CheckBoxScriptOwner.TabIndex = 7
        Me.CheckBoxScriptOwner.Text = "Script owner"
        Me.CheckBoxScriptOwner.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptCheckConstraints
        '
        Me.CheckBoxScriptCheckConstraints.AutoSize = True
        Me.CheckBoxScriptCheckConstraints.Location = New System.Drawing.Point(6, 195)
        Me.CheckBoxScriptCheckConstraints.Name = "CheckBoxScriptCheckConstraints"
        Me.CheckBoxScriptCheckConstraints.Size = New System.Drawing.Size(180, 21)
        Me.CheckBoxScriptCheckConstraints.TabIndex = 4
        Me.CheckBoxScriptCheckConstraints.Text = "Script check constraints"
        Me.CheckBoxScriptCheckConstraints.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptForeignKeys
        '
        Me.CheckBoxScriptForeignKeys.AutoSize = True
        Me.CheckBoxScriptForeignKeys.Location = New System.Drawing.Point(6, 60)
        Me.CheckBoxScriptForeignKeys.Name = "CheckBoxScriptForeignKeys"
        Me.CheckBoxScriptForeignKeys.Size = New System.Drawing.Size(147, 21)
        Me.CheckBoxScriptForeignKeys.TabIndex = 5
        Me.CheckBoxScriptForeignKeys.Text = "Script foreign keys"
        Me.CheckBoxScriptForeignKeys.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptFullTextIndexes
        '
        Me.CheckBoxScriptFullTextIndexes.AutoSize = True
        Me.CheckBoxScriptFullTextIndexes.Location = New System.Drawing.Point(6, 141)
        Me.CheckBoxScriptFullTextIndexes.Name = "CheckBoxScriptFullTextIndexes"
        Me.CheckBoxScriptFullTextIndexes.Size = New System.Drawing.Size(166, 21)
        Me.CheckBoxScriptFullTextIndexes.TabIndex = 6
        Me.CheckBoxScriptFullTextIndexes.Text = "Script full text indexes"
        Me.CheckBoxScriptFullTextIndexes.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptIndexes
        '
        Me.CheckBoxScriptIndexes.AutoSize = True
        Me.CheckBoxScriptIndexes.Location = New System.Drawing.Point(6, 114)
        Me.CheckBoxScriptIndexes.Name = "CheckBoxScriptIndexes"
        Me.CheckBoxScriptIndexes.Size = New System.Drawing.Size(118, 21)
        Me.CheckBoxScriptIndexes.TabIndex = 7
        Me.CheckBoxScriptIndexes.Text = "Script indexes"
        Me.CheckBoxScriptIndexes.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptPrimaryKeys
        '
        Me.CheckBoxScriptPrimaryKeys.AutoSize = True
        Me.CheckBoxScriptPrimaryKeys.Location = New System.Drawing.Point(6, 33)
        Me.CheckBoxScriptPrimaryKeys.Name = "CheckBoxScriptPrimaryKeys"
        Me.CheckBoxScriptPrimaryKeys.Size = New System.Drawing.Size(150, 21)
        Me.CheckBoxScriptPrimaryKeys.TabIndex = 8
        Me.CheckBoxScriptPrimaryKeys.Text = "Script primary keys"
        Me.CheckBoxScriptPrimaryKeys.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptTriggers
        '
        Me.CheckBoxScriptTriggers.AutoSize = True
        Me.CheckBoxScriptTriggers.Location = New System.Drawing.Point(6, 249)
        Me.CheckBoxScriptTriggers.Name = "CheckBoxScriptTriggers"
        Me.CheckBoxScriptTriggers.Size = New System.Drawing.Size(118, 21)
        Me.CheckBoxScriptTriggers.TabIndex = 9
        Me.CheckBoxScriptTriggers.Text = "Script triggers"
        Me.CheckBoxScriptTriggers.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptUniqueKeys
        '
        Me.CheckBoxScriptUniqueKeys.AutoSize = True
        Me.CheckBoxScriptUniqueKeys.Location = New System.Drawing.Point(6, 87)
        Me.CheckBoxScriptUniqueKeys.Name = "CheckBoxScriptUniqueKeys"
        Me.CheckBoxScriptUniqueKeys.Size = New System.Drawing.Size(146, 21)
        Me.CheckBoxScriptUniqueKeys.TabIndex = 10
        Me.CheckBoxScriptUniqueKeys.Text = "Script unique keys"
        Me.CheckBoxScriptUniqueKeys.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(256, 334)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 1
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 370)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageTables.ResumeLayout(False)
        Me.TabPageTables.PerformLayout()
        Me.TabPageGeneral.ResumeLayout(False)
        Me.TabPageGeneral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageTables As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxScriptDefaults As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptCollation As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxIncludeSystemConstraintNames As System.Windows.Forms.CheckBox
    Friend WithEvents TabPageViews As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFunctions As System.Windows.Forms.TabPage
    Friend WithEvents TabPageProcedures As System.Windows.Forms.TabPage
    Friend WithEvents TabPageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents CheckBoxScriptDROPAsWellAsCREATE As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxANSIPadding As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxIncludeDescriptiveHeaders As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSchemaQualifyObjectNames As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptOwner As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptPermissions As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptExtendedProperties As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptUniqueKeys As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptTriggers As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptPrimaryKeys As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptIndexes As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptFullTextIndexes As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptForeignKeys As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptCheckConstraints As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
End Class
