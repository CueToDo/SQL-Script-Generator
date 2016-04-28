Public Module Functions

    Public Sub FileWrite(FilenameAbsolute As String, Text As String)

        Dim oWrite As New System.IO.StreamWriter(FilenameAbsolute, False)

        oWrite.WriteLine(Text)

        oWrite.Flush()
        oWrite.Close()

    End Sub

End Module