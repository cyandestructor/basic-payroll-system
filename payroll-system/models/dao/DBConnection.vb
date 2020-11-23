Imports System.Data
Imports System.Data.SqlClient
Public Class DBConnection
    Protected connection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("dbConnection").ConnectionString)
End Class
