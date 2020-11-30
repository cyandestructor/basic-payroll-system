Imports System.Data
Imports System.Data.SqlClient
Public Class DBConnection
    Protected connection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("dbConnection").ConnectionString)
    Protected Function GetIntSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As Integer
        If Not reader.IsDBNull(index) Then
            Return reader.GetInt32(index)
        End If
        Return 0
    End Function
    Protected Function GetDoubleSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As Double
        If Not reader.IsDBNull(index) Then
            Return reader.GetDouble(index)
        End If
        Return 0
    End Function
    Protected Function GetDateSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As Date
        If Not reader.IsDBNull(index) Then
            Return reader.GetDateTime(index)
        End If
        Return New Date
    End Function
    Protected Function GetStringSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As String
        If Not reader.IsDBNull(index) Then
            Return reader.GetString(index)
        End If
        Return ""
    End Function
    Protected Function GetBooleanSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As Boolean
        If Not reader.IsDBNull(index) Then
            Return reader.GetBoolean(index)
        End If
        Return False
    End Function
End Class
