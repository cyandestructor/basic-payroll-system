Imports System.Data
Imports System.Data.SqlClient
Public Class EmpleadoDAO
    Inherits DBConnection
    Public Function Registrar(ByVal empleado As Empleado) As Integer
        Dim idEmpleado As Integer = 0

        Dim command As New SqlCommand("RegistrarEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@Nom_Empleado", empleado.Nombre)
        command.Parameters.AddWithValue("@Apellido_Pat", empleado.ApellidoPaterno)
        command.Parameters.AddWithValue("@Apellido_Mat", empleado.ApellidoMaterno)
        command.Parameters.AddWithValue("@Fecha_Nac", empleado.FechaNacimiento)
        command.Parameters.AddWithValue("@CURP_Empleado", empleado.CURP)
        command.Parameters.AddWithValue("@RFC_Empleado", empleado.RFC)
        command.Parameters.AddWithValue("@NSS_Empleado", empleado.NSS)
        command.Parameters.AddWithValue("@Tel_Empleado", empleado.Telefono)
        command.Parameters.AddWithValue("@Correo_Empleado", empleado.Correo)
        command.Parameters.AddWithValue("@Banco_Empleado", empleado.Banco.ID)
        command.Parameters.AddWithValue("@Num_Cuenta", empleado.CuentaBancaria)

        command.Parameters.AddWithValue("@Calle", empleado.Domicilio.Calle)
        command.Parameters.AddWithValue("@Numero", empleado.Domicilio.Numero)
        command.Parameters.AddWithValue("@Colonia", empleado.Domicilio.Colonia)
        command.Parameters.AddWithValue("@Cod_Post", empleado.Domicilio.CodigoPostal)
        command.Parameters.AddWithValue("@Ciudad", empleado.Domicilio.Ciudad)
        command.Parameters.AddWithValue("@Estado", empleado.Domicilio.Estado)

        ' ADD RETURN VALUE
        Dim parameter As New SqlParameter
        parameter = command.Parameters.Add("@UsuarioRegistrado", SqlDbType.Int)
        parameter.Direction = ParameterDirection.ReturnValue

        connection.Open()
        command.ExecuteNonQuery()

        If parameter.Value <> -1 Then
            idEmpleado = parameter.Value
        End If

        connection.Close()

        Return idEmpleado
    End Function
    Public Function Editar(ByVal empleado As Empleado) As Boolean
        Dim command As New SqlCommand("EditarEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", empleado.ID)
        command.Parameters.AddWithValue("@Nom_Empleado", empleado.Nombre)
        command.Parameters.AddWithValue("@Apellido_Pat", empleado.ApellidoPaterno)
        command.Parameters.AddWithValue("@Apellido_Mat", empleado.ApellidoMaterno)
        command.Parameters.AddWithValue("@Fecha_Nac", empleado.FechaNacimiento)
        command.Parameters.AddWithValue("@CURP_Empleado", empleado.CURP)
        command.Parameters.AddWithValue("@RFC_Empleado", empleado.RFC)
        command.Parameters.AddWithValue("@NSS_Empleado", empleado.NSS)
        command.Parameters.AddWithValue("@Tel_Empleado", empleado.Telefono)
        command.Parameters.AddWithValue("@Correo_Empleado", empleado.Correo)
        command.Parameters.AddWithValue("@Banco_Empleado", empleado.Banco.ID)
        command.Parameters.AddWithValue("@Num_Cuenta", empleado.CuentaBancaria)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerEmpleados(Optional ByVal idEmpleado As Integer = Nothing) As List(Of Empleado)
        Dim command As New SqlCommand("VerEmpleados", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim empleados As New List(Of Empleado)

        If (idEmpleado <> Nothing) Then
            command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        End If

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim empleado As New Empleado With {
                .ID = reader.GetInt32(0),
                .Nombre = reader.GetString(1),
                .ApellidoPaterno = reader.GetString(2),
                .ApellidoMaterno = reader.GetString(3),
                .FechaNacimiento = reader.GetDateTime(4),
                .CURP = reader.GetString(5),
                .RFC = reader.GetString(6),
                .NSS = reader.GetInt64(7),
                .Domicilio = New Domicilio,
                .Telefono = reader.GetInt64(9),
                .Correo = reader.GetString(10),
                .Banco = New Banco,
                .CuentaBancaria = reader.GetInt64(12),
                .EmpresaContratante = New Empresa,
                .FechaContrato = GetDateSafe(reader, 14),
                .DepartamentoActual = New Departamento,
                .FechaIncorporacion = GetDateSafe(reader, 16),
                .PuestoActual = New Puesto,
                .FechaObtencion = GetDateSafe(reader, 18),
                .Activo = reader.GetBoolean(20)
            }
            empleado.Domicilio.ID = reader.GetInt32(8)
            empleado.Banco.ID = reader.GetInt32(11)
            empleado.EmpresaContratante.RFC = GetStringSafe(reader, 13)
            empleado.DepartamentoActual.ID = GetIntSafe(reader, 15)
            empleado.PuestoActual.ID = GetIntSafe(reader, 17)

            empleados.Add(empleado)
        End While

        reader.Close()
        connection.Close()

        Return empleados
    End Function
    Public Function ObtenerEmpleado(ByVal idEmpleado As Integer) As Empleado
        Dim empleado As New Empleado

        Dim command As New SqlCommand("VerEmpleados", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            empleado.ID = reader.GetInt32(0)
            empleado.Nombre = reader.GetString(1)
            empleado.ApellidoPaterno = reader.GetString(2)
            empleado.ApellidoMaterno = reader.GetString(3)
            empleado.FechaNacimiento = reader.GetDateTime(4)
            empleado.CURP = reader.GetString(5)
            empleado.RFC = reader.GetString(6)
            empleado.NSS = reader.GetInt64(7)
            empleado.Domicilio = New Domicilio With {
                .ID = reader.GetInt32(8)
            }
            empleado.Telefono = reader.GetInt64(9)
            empleado.Correo = reader.GetString(10)
            empleado.Banco = New Banco With {
                .ID = reader.GetInt32(11)
            }
            empleado.CuentaBancaria = reader.GetInt64(12)
            empleado.EmpresaContratante = New Empresa With {
                .RFC = GetStringSafe(reader, 13)
            }
            empleado.FechaContrato = GetDateSafe(reader, 14)
            empleado.DepartamentoActual = New Departamento With {
                .ID = GetIntSafe(reader, 15)
            }
            empleado.FechaIncorporacion = GetDateSafe(reader, 16)
            empleado.PuestoActual = New Puesto With {
                .ID = GetIntSafe(reader, 17)
            }
            empleado.FechaObtencion = GetDateSafe(reader, 18)
            empleado.Activo = reader.GetBoolean(20)
        End If

        reader.Close()
        connection.Close()

        Return empleado
    End Function
    Public Function AgregarEmpresa(ByVal idEmpleado As Integer, ByVal rfcEmpresa As String, ByVal fechaContrato As Date) As Boolean
        Dim command As New SqlCommand("AgregarEmpresaEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@RFC_Empresa", rfcEmpresa)
        command.Parameters.AddWithValue("@Fecha_Contrato", fechaContrato)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function AsignarDepartamento(ByVal idEmpleado As Integer, ByVal idDpto As Integer) As Boolean
        Dim command As New SqlCommand("AsignarDptoEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("ID_Dpto", idDpto)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function AsignarPuesto(ByVal idEmpleado As Integer, ByVal idPuesto As Integer) As Boolean
        Dim command As New SqlCommand("AsignarPuestoEmpleado", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        command.Parameters.AddWithValue("@ID_Puesto", idPuesto)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
End Class
