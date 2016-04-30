

Public Module Functions

    Public Server As String
    Public Database As String
    Public Login As String
    Public Password As String

    Public Sub FileWrite(FilenameAbsolute As String, Text As String)

        Dim oWrite As New System.IO.StreamWriter(FilenameAbsolute, False)

        oWrite.WriteLine(Text)

        oWrite.Flush()
        oWrite.Close()

    End Sub

End Module