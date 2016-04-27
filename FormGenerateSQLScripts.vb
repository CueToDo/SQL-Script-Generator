Imports System.Collections.Specialized

Imports DNSD.Functions
Imports System.Text

Public Class FormGenerateSQLScripts

    Protected WithEvents ScriptGenerator As ScriptGenerator
    Protected TimeStart As Date
    Protected TimeSpan As TimeSpan

    Private Sub FormGenerateSQLScripts_Load(sender As Object, e As EventArgs) Handles Me.Load

        TextBoxRemoteServer.Text = My.Settings.Server
        TextBoxDatabase.Text = My.Settings.DatabaseName

        TextBoxScriptLocationTables.Text = My.Settings.ScriptLocationTables
        TextBoxScriptLocationViews.Text = My.Settings.ScriptLocationViews
        TextBoxScriptLocationFunctions.Text = My.Settings.ScriptLocationFunctions
        TextBoxScriptLocationProcedures.Text = My.Settings.ScriptLocationProcedures
    End Sub

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click

        Try
            Cursor = Cursors.WaitCursor

            TimeStart = Now
            ProgressBarScripting.Value = 0

            Application.DoEvents()

            ScriptGenerator = New ScriptGenerator(TextBoxRemoteServer.Text, "", TextBoxDatabase.Text, TextBoxLogin.Text, TextBoxPassword.Text)

            Dim Directory As String = ""

            If RadioButtonScriptTables.Checked Then
                Directory = TextBoxScriptLocationTables.Text
                ScriptGenerator.GenerateScriptsTables(Directory)
            ElseIf RadioButtonScriptViews.Checked Then
                Directory = TextBoxScriptLocationViews.Text
                ScriptGenerator.GenerateScriptsViews(Directory)
            ElseIf RadioButtonScriptFunctions.Checked Then
                Directory = TextBoxScriptLocationFunctions.Text
                ScriptGenerator.GenerateScriptsFunctions(Directory)
            ElseIf RadioButtonScriptProcedures.Checked Then
                Directory = TextBoxScriptLocationProcedures.Text
                ScriptGenerator.GenerateScriptsProcedures(Directory)
            End If

            ToolStripStatusLabelProgress.Text = ""
            ToolStripStatusLabelPerCentComplete.Text = ""
            ProgressBarScripting.Value = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Script Objects", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            If ScriptGenerator IsNot Nothing Then
                ScriptGenerator.Disconnect()
            End If
            Cursor = Cursors.Arrow
        End Try

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        SaveSettings()
        End
    End Sub

    Private Sub FormGenerateSQLScripts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

    Private Sub SaveSettings()

        My.Settings.Server = TextBoxRemoteServer.Text
        My.Settings.DatabaseName = TextBoxDatabase.Text

        My.Settings.ScriptLocationTables = TextBoxScriptLocationTables.Text
        My.Settings.ScriptLocationViews = TextBoxScriptLocationViews.Text
        My.Settings.ScriptLocationFunctions = TextBoxScriptLocationFunctions.Text
        My.Settings.ScriptLocationProcedures = TextBoxScriptLocationProcedures.Text

        My.Settings.Save()

    End Sub

    Private Sub ButtonScriptLocationTables_Click(sender As Object, e As EventArgs) Handles ButtonScriptLocationTables.Click
        FolderBrowserDialog1.SelectedPath = TextBoxScriptLocationTables.Text
        FolderBrowserDialog1.ShowDialog()
        TextBoxScriptLocationTables.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub ButtonScriptLocationViews_Click(sender As Object, e As EventArgs) Handles ButtonScriptLocationViews.Click
        FolderBrowserDialog1.SelectedPath = TextBoxScriptLocationViews.Text
        FolderBrowserDialog1.ShowDialog()
        TextBoxScriptLocationViews.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub ButtonScriptLocationFunctions_Click(sender As Object, e As EventArgs) Handles ButtonScriptLocationFunctions.Click
        FolderBrowserDialog1.SelectedPath = TextBoxScriptLocationFunctions.Text
        FolderBrowserDialog1.ShowDialog()
        TextBoxScriptLocationFunctions.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub ButtonScriptLocationProcedures_Click(sender As Object, e As EventArgs) Handles ButtonScriptLocationProcedures.Click
        FolderBrowserDialog1.SelectedPath = TextBoxScriptLocationProcedures.Text
        FolderBrowserDialog1.ShowDialog()
        TextBoxScriptLocationProcedures.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub ScriptGenerator_ItemCount(Count As Integer) Handles ScriptGenerator.ItemCount
        ProgressBarScripting.Maximum = Count
    End Sub

    Private Sub ScriptGenerator_Processing(ObjectName As String, Count As Integer) Handles ScriptGenerator.Processing

        ToolStripStatusLabelProgress.Text = ObjectName
        ProgressBarScripting.Value = Count

        If ProgressBarScripting.Maximum > 0 Then
            ToolStripStatusLabelPerCentComplete.Text = CStr(CInt(100 * ProgressBarScripting.Value / ProgressBarScripting.Maximum)) & "%"
        Else
            ToolStripStatusLabelPerCentComplete.Text = "0%"
        End If

        TimeSpan = Now - TimeStart
        ToolStripStatusLabelElapsed.Text = TimeSpan.Minutes & "m " & TimeSpan.Seconds & "s"

        Application.DoEvents()

    End Sub

End Class
