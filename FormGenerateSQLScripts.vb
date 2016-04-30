Imports System.Collections.Specialized

Imports System.Text

Public Class FormGenerateSQLScripts

    Protected WithEvents ScriptGenerator As ScriptGenerator
    Protected TimeStart As Date
    Protected TimeSpan As TimeSpan
    Protected ElapsedLabel As Label

    Private Sub FormGenerateSQLScripts_Load(sender As Object, e As EventArgs) Handles Me.Load

        TextBoxScriptLocationTables.Text = My.Settings.ScriptLocationTables
        TextBoxScriptLocationViews.Text = My.Settings.ScriptLocationViews
        TextBoxScriptLocationFunctions.Text = My.Settings.ScriptLocationFunctions
        TextBoxScriptLocationProcedures.Text = My.Settings.ScriptLocationProcedures

        CheckBoxTables.Checked = My.Settings.ScriptTables
        CheckBoxViews.Checked = My.Settings.ScriptViews
        CheckBoxFunctions.Checked = My.Settings.ScriptFunctions
        CheckBoxProcedures.Checked = My.Settings.ScriptProcedures

    End Sub


    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click

        Try
            Cursor = Cursors.WaitCursor

            Dim Generate As Boolean = FormLogin.ShowDialog() = Windows.Forms.DialogResult.OK

            If Generate Then

                ProgressBarScripting.Value = 0

                LabelTimeTables.Text = ""
                LabelTimeViews.Text = ""
                LabelTimeFunctions.Text = ""
                LabelTimeProcedures.Text = ""

                Application.DoEvents()

                ScriptGenerator = New ScriptGenerator(Server, Database, Login, Password)

                Dim Directory As String = ""

                If CheckBoxTables.Checked Then
                    TimeStart = Now
                    ElapsedLabel = LabelTimeTables
                    Directory = TextBoxScriptLocationTables.Text
                    ScriptGenerator.GenerateScriptsTables(Directory)
                Else
                    LabelTimeTables.Text = ""
                End If

                If CheckBoxViews.Checked Then
                    TimeStart = Now
                    ElapsedLabel = LabelTimeViews
                    Directory = TextBoxScriptLocationViews.Text
                    ScriptGenerator.GenerateScriptsViews(Directory)
                Else
                    LabelTimeViews.Text = ""
                End If

                If CheckBoxFunctions.Checked Then
                    TimeStart = Now
                    ElapsedLabel = LabelTimeFunctions
                    Directory = TextBoxScriptLocationFunctions.Text
                    ScriptGenerator.GenerateScriptsFunctions(Directory)
                Else
                    LabelTimeFunctions.Text = ""
                End If

                If CheckBoxProcedures.Checked Then
                    TimeStart = Now
                    ElapsedLabel = LabelTimeProcedures
                    Directory = TextBoxScriptLocationProcedures.Text
                    ScriptGenerator.GenerateScriptsProcedures(Directory)
                Else
                    LabelTimeProcedures.Text = ""
                End If

                ToolStripStatusLabelProgress.Text = ""
                ToolStripStatusLabelPerCentComplete.Text = ""
                ProgressBarScripting.Value = 0

            End If

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

        My.Settings.Server = Server
        My.Settings.DatabaseName = Database

        My.Settings.ScriptLocationTables = TextBoxScriptLocationTables.Text
        My.Settings.ScriptLocationViews = TextBoxScriptLocationViews.Text
        My.Settings.ScriptLocationFunctions = TextBoxScriptLocationFunctions.Text
        My.Settings.ScriptLocationProcedures = TextBoxScriptLocationProcedures.Text

        My.Settings.ScriptTables = CheckBoxTables.Checked
        My.Settings.ScriptViews = CheckBoxViews.Checked
        My.Settings.ScriptFunctions = CheckBoxFunctions.Checked
        My.Settings.ScriptProcedures = CheckBoxProcedures.Checked

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
        ElapsedLabel.Text = TimeSpan.Minutes & "m " & TimeSpan.Seconds & "s"

        Application.DoEvents()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ScriptGenerator.ContinueScripting = False
    End Sub

End Class
