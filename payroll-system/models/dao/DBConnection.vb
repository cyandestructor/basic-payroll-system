﻿Imports System.Data
Imports System.Data.SqlClient
Public Class DBConnection
    Protected connection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("dbConnection").ConnectionString)
    Protected Function GetIntSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As Integer
        If Not reader.IsDBNull(index) Then
            Return reader.GetInt32(index)
        End If
        Return -1
    End Function
    Protected Function GetDateSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As Date
        If Not reader.IsDBNull(index) Then
            Return reader.GetDateTime(index)
        End If
        Return Nothing
    End Function
    Protected Function GetStringSafe(ByVal reader As SqlDataReader, ByVal index As Integer) As String
        If Not reader.IsDBNull(index) Then
            Return reader.GetString(index)
        End If
        Return ""
    End Function
End Class
