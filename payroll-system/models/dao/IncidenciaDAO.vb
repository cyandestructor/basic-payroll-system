﻿Imports System.Data.SqlClient
Public Class IncidenciaDAO
    Inherits DBConnection
    Public Function Generar(ByVal incidencia As Incidencia) As Boolean
        Dim command As New SqlCommand("GenerarIncidencia", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Desc_Inciden", incidencia.Descripcion)
        command.Parameters.AddWithValue("@Inicio_Inciden", incidencia.Inicio)
        command.Parameters.AddWithValue("@Fin_Inciden", incidencia.Fin)
        command.Parameters.AddWithValue("@ID_Solicitante", incidencia.IDSolicitante)
        command.Parameters.AddWithValue("@Fecha_Solicitud", incidencia.FechaSolicitud)
        command.Parameters.AddWithValue("@Motiv_Solicitud", incidencia.MotivoSolicitud)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function Revisar(ByVal incidencia As Incidencia) As Boolean
        Dim command As New SqlCommand("RevisarIncidencia", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Incidencia", incidencia.ID)
        command.Parameters.AddWithValue("@ID_Gerente", incidencia.IDGerente)
        command.Parameters.AddWithValue("@Fecha_Revision", incidencia.FechaRevision)
        command.Parameters.AddWithValue("@Est_Autoriza", incidencia.Estado)
        command.Parameters.AddWithValue("@Goce_Sueldo", incidencia.GoceSueldo)

        connection.Open()
        Command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerIncidencias(ByVal unauthorizedOnly As Boolean) As List(Of Incidencia)
        Dim command As New SqlCommand("VerIncidencias", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@UnauthorizedOnly", unauthorizedOnly)

        Dim incidencias As New List(Of Incidencia)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim incidencia As New Incidencia With {
                .ID = reader.GetInt32(0),
                .Descripcion = reader.GetString(1),
                .Inicio = reader.GetDateTime(2),
                .Fin = reader.GetDateTime(3),
                .IDSolicitante = reader.GetInt32(4),
                .FechaSolicitud = reader.GetDateTime(5),
                .MotivoSolicitud = reader.GetString(6),
                .IDGerente = reader.GetInt32(7),
                .FechaRevision = reader.GetDateTime(8),
                .Estado = reader.GetByte(9),
                .GoceSueldo = reader.GetBoolean(10)
            }
            incidencias.Add(incidencia)
        End While

        reader.Close()
        connection.Close()

        Return incidencias
    End Function
End Class