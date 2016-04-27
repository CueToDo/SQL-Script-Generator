Imports DNSD.Functions
Imports System.Text

Imports System.Data.SqlClient

Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Sdk.Sfc
Imports System.Collections.Specialized



Public Class ScriptGenerator

    'http://www.sqlteam.com/article/scripting-database-objects-using-smo-updated

    Protected SQLConnection As SqlConnection
    Protected ServerConnection As ServerConnection
    Protected SQLServer As Server
    Protected Database As Database

    Public Event ItemCount(Count As Integer)
    Public Event Processing(ObjectName As String, ItemNumber As Integer)

    Public Sub New(RemoteServer As String, InstanceName As String, DatabaseName As String, Login As String, Password As String)

        SQLConnection = New SqlConnection("Data Source=" & RemoteServer & "; Initial Catalog=" & DatabaseName & "; User ID=" & Login & "; Password=" & Password & "; Pooling=True; Min Pool Size=10; Max Pool Size=200; Connect Timeout=60; Persist Security Info=True;")

        ServerConnection = New ServerConnection(SQLConnection)

        SQLServer = New Server(ServerConnection)

        Database = SQLServer.Databases(DatabaseName)

    End Sub

    Public Sub Disconnect()
        ServerConnection.Disconnect()
    End Sub

    Public Sub GenerateScriptsTables(Directory As String)

        Dim Script As StringCollection
        Dim ScriptBuilder As StringBuilder
        Dim TableName As String
        Dim Count As Integer = 0

        RaiseEvent ItemCount(Database.Tables.Count)

        For Each Table As Table In Database.Tables

            TableName = Table.Schema & "." & Table.Name & ".SQL"
            Count += 1
            RaiseEvent Processing(TableName, Count)

            If Not Table.IsSystemObject Then

                Script = ScriptTable(Table)
                ScriptBuilder = New StringBuilder

                For Each Line As String In Script
                    ScriptBuilder.Append(Line & vbCrLf)
                Next

                FileWrite(Directory & "\" & TableName, ScriptBuilder.ToString, False)

            End If
        Next



    End Sub

    Public Sub GenerateScriptsViews(Directory As String)

        Dim Script As StringCollection
        Dim ScriptBuilder As StringBuilder
        Dim ViewName As String
        Dim Count As Integer = 0

        RaiseEvent ItemCount(Database.Views.Count)

        For Each View As View In Database.Views

            ViewName = View.Schema & "." & View.Name & ".SQL"
            Count += 1

            RaiseEvent Processing(ViewName, Count)

            If Not View.IsSystemObject Then

                Script = ScriptView(View)
                ScriptBuilder = New StringBuilder

                For Each Line As String In Script
                    ScriptBuilder.Append(Line & vbCrLf)
                Next

                FileWrite(Directory & "\" & ViewName, ScriptBuilder.ToString, False)

            End If
        Next

    End Sub

    Public Sub GenerateScriptsFunctions(Directory As String)

        Dim Script As StringCollection
        Dim ScriptBuilder As StringBuilder
        Dim FunctionName As String
        Dim Count As Integer = 0

        RaiseEvent ItemCount(Database.UserDefinedFunctions.Count)

        For Each UserDefinedFunction As UserDefinedFunction In Database.UserDefinedFunctions

            FunctionName = UserDefinedFunction.Schema & "." & UserDefinedFunction.Name & ".SQL"
            Count += 1

            RaiseEvent Processing(FunctionName, Count)

            If Not UserDefinedFunction.IsSystemObject Then

                Script = ScriptFunction(UserDefinedFunction)
                ScriptBuilder = New StringBuilder

                For Each Line As String In Script
                    ScriptBuilder.Append(Line & vbCrLf)
                Next

                FileWrite(Directory & "\" & FunctionName, ScriptBuilder.ToString, False)

            End If
        Next

    End Sub

    Public Sub GenerateScriptsProcedures(Directory As String)

        Dim Script As StringCollection
        Dim ScriptBuilder As StringBuilder
        Dim ProcedureName As String
        Dim Count As Integer = 0

        'Iterate through the stored procedures in database and script each one. 
        RaiseEvent ItemCount(Database.StoredProcedures.Count)

        For Each Procedure As StoredProcedure In Database.StoredProcedures

            ProcedureName = Procedure.Schema & "." & Procedure.Name & ".SQL"
            Count += 1

            RaiseEvent Processing(ProcedureName, Count)

            If Not Procedure.IsSystemObject Then

                Script = ScriptProcedure(Procedure)
                ScriptBuilder = New StringBuilder

                For Each Line As String In Script
                    ScriptBuilder.Append(Line & vbCrLf)
                Next

                FileWrite(Directory & "\" & ProcedureName, ScriptBuilder.ToString, False)

            End If
        Next

    End Sub

    Public Function ScriptTable(Table As Table) As StringCollection

        Dim Script As New StringCollection

        Dim scrp As Scripter = New Scripter(SQLServer)

        scrp.PrefetchObjects = True 'some sources suggest this may speed things up

        With scrp.Options
            .ScriptDrops = False
            .WithDependencies = False
            .Indexes = True
            .DriAllConstraints = True 'to include referential constraints in the script
            .Triggers = True
            .FullTextIndexes = True
            .NoCollation = False
            .Bindings = True
            .IncludeIfNotExists = False
            .ScriptBatchTerminator = True
            .ExtendedProperties = True
        End With

        'Check if the Table is not a system object
        If Table IsNot Nothing AndAlso Not Table.IsSystemObject Then
            Dim urns As New List(Of Urn)
            urns.Add(Table.Urn)
            Script = scrp.Script(urns.ToArray())
        End If

        Return Script

    End Function

    Public Function ScriptView(View As View) As StringCollection

        Dim Script As New StringCollection

        Dim scrp As Scripter = New Scripter(SQLServer)

        scrp.PrefetchObjects = True 'some sources suggest this may speed things up

        With scrp.Options
            .ScriptDrops = False
            .WithDependencies = False
            .Indexes = True
            .DriAllConstraints = True 'to include referential constraints in the script
            .Triggers = True
            .FullTextIndexes = True
            .NoCollation = False
            .Bindings = True
            .IncludeIfNotExists = False
            .ScriptBatchTerminator = True
            .ExtendedProperties = True
        End With



        'Check if the Table is not a system object
        If View IsNot Nothing AndAlso Not View.IsSystemObject Then
            Dim urns As New List(Of Urn)
            urns.Add(View.Urn)
            Script = scrp.Script(urns.ToArray())
        End If

        Return Script

    End Function

    Public Function ScriptFunction(UserDefinedFunction As UserDefinedFunction) As StringCollection

        Dim Script As New StringCollection

        Dim scrp As Scripter = New Scripter(SQLServer)

        scrp.PrefetchObjects = True 'some sources suggest this may speed things up

        With scrp.Options
            .ScriptDrops = False
            .WithDependencies = False
            .Indexes = True
            .DriAllConstraints = True 'to include referential constraints in the script
            .Triggers = True
            .FullTextIndexes = True
            .NoCollation = False
            .Bindings = True
            .IncludeIfNotExists = False
            .ScriptBatchTerminator = True
            .ExtendedProperties = True
        End With

        'Check if the Table is not a system object
        If UserDefinedFunction IsNot Nothing AndAlso Not UserDefinedFunction.IsSystemObject Then
            Dim urns As New List(Of Urn)
            urns.Add(UserDefinedFunction.Urn)
            Script = scrp.Script(urns.ToArray())
        End If

        Return Script

    End Function

    Public Function ScriptProcedure(Procedure As StoredProcedure) As StringCollection

        Dim Script As New StringCollection

        Dim scrp As Scripter = New Scripter(SQLServer)

        scrp.PrefetchObjects = True 'some sources suggest this may speed things up

        With scrp.Options
            .ScriptDrops = False
            .WithDependencies = False
            .Indexes = False
            .DriAllConstraints = False 'to include referential constraints in the script
            .Triggers = False
            .FullTextIndexes = True
            .NoCollation = False
            .Bindings = True
            .IncludeIfNotExists = False
            .ScriptBatchTerminator = True
            .ExtendedProperties = True
        End With

        'check if the procedure is not a system object
        If Procedure IsNot Nothing AndAlso Not Procedure.IsSystemObject Then
            Dim urns As New List(Of Urn)
            urns.Add(Procedure.Urn)
            Script = scrp.Script(urns.ToArray())
        End If

        Return Script

    End Function



End Class
