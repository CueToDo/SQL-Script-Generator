Imports System.Text

Imports System.Data.SqlClient

Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Sdk.Sfc
Imports System.Collections.Specialized



Public Class ScriptGenerator

    'http://www.sqlteam.com/article/scripting-database-objects-using-smo-updated

    Public Property ContinueScripting As Boolean = True

    Protected SQLConnection As SqlConnection
    Protected ServerConnection As ServerConnection
    Protected SQLServer As Server
    Protected Database As Database
    Protected Directory As String

    Public Event ItemCount(Count As Integer)
    Public Event Processing(ObjectName As String, ItemNumber As Integer)

    Public Sub New(RemoteServer As String, DatabaseName As String, Login As String, Password As String)

        SQLConnection = New SqlConnection("Data Source=" & RemoteServer & "; Initial Catalog=" & DatabaseName & "; User ID=" & Login & "; Password=" & Password & "; Pooling=True; Min Pool Size=10; Max Pool Size=200; Connect Timeout=60; Persist Security Info=True;")

        ServerConnection = New ServerConnection(SQLConnection)

        SQLServer = New Server(ServerConnection)

        Database = SQLServer.Databases(DatabaseName)

    End Sub

    Public Sub Disconnect()
        ServerConnection.Disconnect()
    End Sub

    Public Sub GenerateScriptsTables(Directory As String)

        Me.Directory = Directory

        Dim TableName As String
        Dim Count As Integer = 0

        RaiseEvent ItemCount(Database.Tables.Count)

        For Each Table As Table In Database.Tables

            If Not ContinueScripting Then Exit For

            TableName = Table.Schema & "." & Table.Name & ".SQL"
            Count += 1

            RaiseEvent Processing(TableName, Count)
            ScriptDatabaseObject(Table, TableName, Count)

        Next

    End Sub

    Public Sub GenerateScriptsViews(Directory As String)

        Me.Directory = Directory

        Dim ViewName As String
        Dim Count As Integer = 0

        RaiseEvent ItemCount(Database.Views.Count)

        For Each View As View In Database.Views

            If Not ContinueScripting Then Exit For

            ViewName = View.Schema & "." & View.Name & ".SQL"
            Count += 1

            RaiseEvent Processing(ViewName, Count)

            ScriptDatabaseObject(View, ViewName, Count)

        Next

    End Sub

    Public Sub GenerateScriptsFunctions(Directory As String)

        Me.Directory = Directory

        Dim FunctionName As String
        Dim Count As Integer = 0

        RaiseEvent ItemCount(Database.UserDefinedFunctions.Count)

        For Each UserDefinedFunction As UserDefinedFunction In Database.UserDefinedFunctions

            If Not ContinueScripting Then Exit For

            FunctionName = UserDefinedFunction.Schema & "." & UserDefinedFunction.Name & ".SQL"
            Count += 1

            RaiseEvent Processing(FunctionName, Count)

            ScriptDatabaseObject(UserDefinedFunction, FunctionName, Count)

        Next

    End Sub

    Public Sub GenerateScriptsProcedures(Directory As String)

        Me.Directory = Directory

        Dim ProcedureName As String
        Dim Count As Integer = 0

        RaiseEvent ItemCount(Database.StoredProcedures.Count)

        'Iterate through the stored procedures in database and script each one. 
        For Each Procedure As StoredProcedure In Database.StoredProcedures

            If Not ContinueScripting Then Exit For

            ProcedureName = Procedure.Schema & "." & Procedure.Name & ".SQL"
            Count += 1

            RaiseEvent Processing(ProcedureName, Count)

            ScriptDatabaseObject(Procedure, ProcedureName, Count)

        Next

    End Sub

    Public Sub ScriptDatabaseObject(DatabaseObject As Object, ProcedureName As String, Count As Integer)

        Dim Script As New StringCollection
        Dim ScriptCreate As New StringCollection

        Dim scrp As Scripter = New Scripter(SQLServer)

        scrp.PrefetchObjects = True 'some sources suggest this may speed things up

        SetGeneralOptions(scrp.Options)

        If TypeOf (DatabaseObject) Is Table OrElse TypeOf (DatabaseObject) Is View Then
            SetTableAndViewOptions(scrp.Options)
        End If

        'Check if the Table is not a system object
        If DatabaseObject IsNot Nothing AndAlso Not DatabaseObject.IsSystemObject Then

            Dim urns As New List(Of Urn)
            urns.Add(DatabaseObject.Urn)

            'OPTIONAL Drop
            If scrp.Options.ScriptDrops Then
                scrp.Options.IncludeIfNotExists = True
                Script = scrp.Script(urns.ToArray())
                Script.Add(vbNewLine)
            End If

            'ALWAYS Create
            scrp.Options.ScriptDrops = False
            scrp.Options.IncludeIfNotExists = False

            ScriptCreate = scrp.Script(urns.ToArray())

            For Each line As String In ScriptCreate
                Script.Add(line)
            Next

        End If

        Dim ScriptBuilder As New StringBuilder

        For Each Line As String In Script
            ScriptBuilder.Append(Line & vbCrLf)
        Next

        FileWrite(Directory & "\" & ProcedureName, ScriptBuilder.ToString)

    End Sub

    Protected Sub SetGeneralOptions(Options As ScriptingOptions)

        With Options

            'No user setting
            '.IncludeIfNotExists = True for Drop, False for Create
            .WithDependencies = False 'ALL objects are scripted
            .ExtendedProperties = True 'If added, you get them
            .AnsiPadding = True 'http://stackoverflow.com/questions/3566948/sql-server-ansi-padding
            'In a future version of MicrosoftSQL Server ANSI_PADDING will always be ON 
            'and any applications that explicitly set the option to OFF will produce an error. 
            'Avoid using this feature in new development work, and plan to modify applications that currently use this feature.

            'User Settings
            .IncludeHeaders = My.Settings.GeneralScriptDescriptiveHeaders
            .ScriptDrops = My.Settings.GeneralScriptDROPAsWellAsCREATE
            .SchemaQualify = My.Settings.GeneralSchemaQualifyObjectNames
            .Permissions = My.Settings.GeneralScriptPermissions
            .ScriptOwner = My.Settings.GeneralScriptOwner

        End With

    End Sub

    Protected Sub SetTableAndViewOptions(Options As ScriptingOptions)

        With Options
            .NoCollation = Not My.Settings.TableScriptCollation
            .DriPrimaryKey = True
            .DriForeignKeys = True
            .DriUniqueKeys = True
            .Indexes = True
            .FullTextIndexes = True
            .Default = True
            .DriChecks = True
            .DriAllConstraints = True
            .Triggers = True
        End With

    End Sub

End Class
