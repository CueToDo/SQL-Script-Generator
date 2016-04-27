Public Enum ObjectType
    Tables
    Views
    Functions
    Procedures
End Enum

Public Structure DatabaseObject
    Public ObjectName As String
    Public Script As String
End Structure
