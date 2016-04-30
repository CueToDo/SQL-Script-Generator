Public Class FormLogin

    Private Sub ButtonLogon_Click(sender As Object, e As EventArgs) Handles ButtonLogon.Click

        Try
            Cursor = Cursors.WaitCursor
            Application.DoEvents()

            Server = TextBoxRemoteServer.Text
            Database = TextBoxDatabase.Text
            Login = TextBoxLogin.Text
            Password = TextBoxPassword.Text

            Dim Scriptgenerator As New ScriptGenerator(Server, Database, Login, Password)

            DialogResult = Windows.Forms.DialogResult.OK

            Cursor = Cursors.Arrow '(for any re-load)
            Close()

        Catch ex As Exception

            Cursor = Cursors.Arrow
            Application.DoEvents()

            MessageBox.Show("Login Failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub

    Private Sub FormLogon_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Server = "" Then TextBoxRemoteServer.Text = My.Settings.Server Else TextBoxRemoteServer.Text = Server
        If Database = "" Then TextBoxDatabase.Text = My.Settings.DatabaseName Else TextBoxDatabase.Text = Database
        TextBoxLogin.Text = Login
        TextBoxPassword.Text = Password

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

End Class