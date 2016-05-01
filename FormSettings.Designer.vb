<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxScriptCollation = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptOwner = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptPermissions = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSchemaQualifyObjectNames = New System.Windows.Forms.CheckBox()
        Me.CheckBoxIncludeDescriptiveHeaders = New System.Windows.Forms.CheckBox()
        Me.CheckBoxScriptDROPAsWellAsCREATE = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(93, 209)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 1
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(183, 209)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxScriptCollation)
        Me.GroupBox1.Controls.Add(Me.CheckBoxScriptOwner)
        Me.GroupBox1.Controls.Add(Me.CheckBoxScriptPermissions)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSchemaQualifyObjectNames)
        Me.GroupBox1.Controls.Add(Me.CheckBoxIncludeDescriptiveHeaders)
        Me.GroupBox1.Controls.Add(Me.CheckBoxScriptDROPAsWellAsCREATE)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 191)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'CheckBoxScriptCollation
        '
        Me.CheckBoxScriptCollation.AutoSize = True
        Me.CheckBoxScriptCollation.Location = New System.Drawing.Point(6, 156)
        Me.CheckBoxScriptCollation.Name = "CheckBoxScriptCollation"
        Me.CheckBoxScriptCollation.Size = New System.Drawing.Size(122, 21)
        Me.CheckBoxScriptCollation.TabIndex = 16
        Me.CheckBoxScriptCollation.Text = "Script collation"
        Me.CheckBoxScriptCollation.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptOwner
        '
        Me.CheckBoxScriptOwner.AutoSize = True
        Me.CheckBoxScriptOwner.Location = New System.Drawing.Point(6, 129)
        Me.CheckBoxScriptOwner.Name = "CheckBoxScriptOwner"
        Me.CheckBoxScriptOwner.Size = New System.Drawing.Size(108, 21)
        Me.CheckBoxScriptOwner.TabIndex = 15
        Me.CheckBoxScriptOwner.Text = "Script owner"
        Me.CheckBoxScriptOwner.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptPermissions
        '
        Me.CheckBoxScriptPermissions.AutoSize = True
        Me.CheckBoxScriptPermissions.Location = New System.Drawing.Point(6, 102)
        Me.CheckBoxScriptPermissions.Name = "CheckBoxScriptPermissions"
        Me.CheckBoxScriptPermissions.Size = New System.Drawing.Size(145, 21)
        Me.CheckBoxScriptPermissions.TabIndex = 14
        Me.CheckBoxScriptPermissions.Text = "Script permissions"
        Me.CheckBoxScriptPermissions.UseVisualStyleBackColor = True
        '
        'CheckBoxSchemaQualifyObjectNames
        '
        Me.CheckBoxSchemaQualifyObjectNames.AutoSize = True
        Me.CheckBoxSchemaQualifyObjectNames.Location = New System.Drawing.Point(6, 75)
        Me.CheckBoxSchemaQualifyObjectNames.Name = "CheckBoxSchemaQualifyObjectNames"
        Me.CheckBoxSchemaQualifyObjectNames.Size = New System.Drawing.Size(214, 21)
        Me.CheckBoxSchemaQualifyObjectNames.TabIndex = 12
        Me.CheckBoxSchemaQualifyObjectNames.Text = "Schema qualify object names"
        Me.CheckBoxSchemaQualifyObjectNames.UseVisualStyleBackColor = True
        '
        'CheckBoxIncludeDescriptiveHeaders
        '
        Me.CheckBoxIncludeDescriptiveHeaders.AutoSize = True
        Me.CheckBoxIncludeDescriptiveHeaders.Location = New System.Drawing.Point(6, 21)
        Me.CheckBoxIncludeDescriptiveHeaders.Name = "CheckBoxIncludeDescriptiveHeaders"
        Me.CheckBoxIncludeDescriptiveHeaders.Size = New System.Drawing.Size(203, 21)
        Me.CheckBoxIncludeDescriptiveHeaders.TabIndex = 11
        Me.CheckBoxIncludeDescriptiveHeaders.Text = "Include descriptive headers"
        Me.CheckBoxIncludeDescriptiveHeaders.UseVisualStyleBackColor = True
        '
        'CheckBoxScriptDROPAsWellAsCREATE
        '
        Me.CheckBoxScriptDROPAsWellAsCREATE.AutoSize = True
        Me.CheckBoxScriptDROPAsWellAsCREATE.Location = New System.Drawing.Point(6, 48)
        Me.CheckBoxScriptDROPAsWellAsCREATE.Name = "CheckBoxScriptDROPAsWellAsCREATE"
        Me.CheckBoxScriptDROPAsWellAsCREATE.Size = New System.Drawing.Size(234, 21)
        Me.CheckBoxScriptDROPAsWellAsCREATE.TabIndex = 10
        Me.CheckBoxScriptDROPAsWellAsCREATE.Text = "Script DROP as well as CREATE"
        Me.CheckBoxScriptDROPAsWellAsCREATE.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 247)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Name = "FormSettings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxScriptCollation As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptOwner As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptPermissions As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSchemaQualifyObjectNames As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxIncludeDescriptiveHeaders As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScriptDROPAsWellAsCREATE As System.Windows.Forms.CheckBox
End Class
