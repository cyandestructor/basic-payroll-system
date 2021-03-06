﻿Imports System.Data.SqlClient
Public Class ReciboNominaDAO
    Inherits DBConnection
    Public Function GenerarRecibo(ByVal idEmpleado As Integer, ByVal fechaPago As Date) As ReciboNomina
        Dim command As New SqlCommand("GenReciboNomina", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@Fecha_Pago", fechaPago)

        Dim recibo As New ReciboNomina

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            recibo.DatosEmpresa.RFC = reader.GetString(0)
            recibo.DatosEmpresa.RazonSocial = reader.GetString(1)
            recibo.DatosEmpresa.RegistroPatronal = reader.GetString(2)
            recibo.DatosEmpleado.ID = reader.GetInt32(3)
            recibo.DatosEmpleado.Nombre = reader.GetString(4)
            recibo.DatosEmpleado.NSS = reader.GetInt64(5)
            recibo.DatosEmpleado.RFC = reader.GetString(6)
            recibo.DatosEmpleado.CURP = reader.GetString(7)
            recibo.DatosEmpleado.FechaContrato = GetDateSafe(reader, 8)
            recibo.Departamento = GetIntSafe(reader, 9)
            recibo.Puesto = GetStringSafe(reader, 10)
            recibo.DatosNomina.ID = reader.GetInt32(11)
            recibo.DatosNomina.FechaGeneracion = reader.GetDateTime(12)
            recibo.DatosNomina.InicioPeriodo = reader.GetDateTime(13)
            recibo.DatosNomina.FinPeriodo = reader.GetDateTime(14)
            recibo.DiasPeriodo = reader.GetInt32(15)
            recibo.SueldoDiario = reader.GetDouble(16)
            recibo.DatosNomina.SueldoBruto = GetDoubleSafe(reader, 17)
            recibo.DatosNomina.SueldoNeto = GetDoubleSafe(reader, 18)
            recibo.SueldoEscrito = GetStringSafe(reader, 19)
        Else
            Return Nothing
        End If

        reader.Close()
        connection.Close()

        Return recibo
    End Function
End Class
