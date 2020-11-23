Imports System.Data
Imports System.Data.SqlClient
Public Class EmpleadoDAO
    Inherits DBConnection
    Public Function Registrar(ByVal empleado As Empleado) As Boolean
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

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
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
