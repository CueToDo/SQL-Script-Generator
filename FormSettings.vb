Public Class FormSettings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        'General Settings
        CheckBoxIncludeDescriptiveHeaders.Checked = My.Settings.GeneralScriptDescriptiveHeaders
        CheckBoxScriptDROPAsWellAsCREATE.Checked = My.Settings.GeneralScriptDROPAsWellAsCREATE
        CheckBoxSchemaQualifyObjectNames.Checked = My.Settings.GeneralSchemaQualifyObjectNames
        CheckBoxScriptPermissions.Checked = My.Settings.GeneralScriptPermissions
        CheckBoxScriptOwner.Checked = My.Settings.GeneralScriptOwner

        'Table/View Settings
        CheckBoxScriptCollation.Checked = My.Settings.TableScriptCollation

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        'General Settings
        My.Settings.GeneralScriptDescriptiveHeaders = CheckBoxIncludeDescriptiveHeaders.Checked
        My.Settings.GeneralScriptDROPAsWellAsCREATE = CheckBoxScriptDROPAsWellAsCREATE.Checked
        My.Settings.GeneralSchemaQualifyObjectNames = CheckBoxSchemaQualifyObjectNames.Checked
        My.Settings.GeneralScriptPermissions = CheckBoxScriptPermissions.Checked
        My.Settings.GeneralScriptOwner = CheckBoxScriptOwner.Checked

        'Table/View Settings
        My.Settings.TableScriptCollation = CheckBoxScriptCollation.Checked

        Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

End Class