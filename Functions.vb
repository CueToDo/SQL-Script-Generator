Public Module Functions

    Public Sub FileWrite(FilenameAbsolute As String, WriteTime As Boolean, Text As String)

        Dim oWrite As New System.IO.StreamWriter(FilenameAbsolute, False)

        oWrite.WriteLine(If(WriteTime, Now.ToString("dd/MM/yyyy HH:mm:ss:fff "), "") & Text)

        oWrite.Flush()
        oWrite.Close()

    End Sub

End Module