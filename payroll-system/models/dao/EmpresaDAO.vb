Imports System.Data
Imports System.Data.SqlClient
Public Class EmpresaDAO
    Inherits DBConnection
    Public Function Registrar(ByVal empresa As Empresa) As Boolean
        Dim command As New SqlCommand("RegistrarEmpresa", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@RFC_Empresa", empresa.RFC)
        command.Parameters.AddWithValue("@Nom_Empresa", empresa.Nombre)
        command.Parameters.AddWithValue("@Reg_Patronal", empresa.RegistroPatronal)
        command.Parameters.AddWithValue("@Razon_Social", empresa.RazonSocial)
        command.Parameters.AddWithValue("@Tel_Empresa", empresa.Telefono)
        command.Parameters.AddWithValue("@Correo_Empresa", empresa.Correo)
        command.Parameters.AddWithValue("@Frec_Pago", empresa.FrecuenciaPago)
        command.Parameters.AddWithValue("@Inicio_Ops", empresa.InicioOperaciones)

        command.Parameters.AddWithValue("@Calle", empresa.DomicilioFiscal.Calle)
        command.Parameters.AddWithValue("@Numero", empresa.DomicilioFiscal.Numero)
        command.Parameters.AddWithValue("@Colonia", empresa.DomicilioFiscal.Colonia)
        command.Parameters.AddWithValue("@Cod_Post", empresa.DomicilioFiscal.CodigoPostal)
        command.Parameters.AddWithValue("@Ciudad", empresa.DomicilioFiscal.Ciudad)
        command.Parameters.AddWithValue("@Estado", empresa.DomicilioFiscal.Estado)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function Editar(ByVal empresa As Empresa) As Boolean
        Dim command As New SqlCommand("EditarEmpresa", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@RFC_Empresa", empresa.RFC)
        command.Parameters.AddWithValue("@Nom_Empresa", empresa.Nombre)
        command.Parameters.AddWithValue("@Reg_Patronal", empresa.RegistroPatronal)
        command.Parameters.AddWithValue("@Razon_Social", empresa.RazonSocial)
        command.Parameters.AddWithValue("@Tel_Empresa", empresa.Telefono)
        command.Parameters.AddWithValue("@Correo_Empresa", empresa.Correo)
        command.Parameters.AddWithValue("@Frec_Pago", empresa.FrecuenciaPago)
        command.Parameters.AddWithValue("@Inicio_Ops", empresa.InicioOperaciones)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function VerEmpresas() As List(Of Empresa)
        Dim command As New SqlCommand("VerEmpresas", connection)
        command.CommandType = CommandType.StoredProcedure

        Dim empresas As New List(Of Empresa)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        While (reader.Read())
            Dim empresa As New Empresa With {
                .RFC = reader.GetString(0),
                .Nombre = reader.GetString(1),
                .RegistroPatronal = reader.GetString(2),
                .RazonSocial = reader.GetString(3),
                .DomicilioFiscal = New DomicilioDAO().ObtenerDomicilio(reader.GetInt32(4)),
                .Telefono = reader.GetInt64(5),
                .Correo = reader.GetString(6),
                .FrecuenciaPago = reader.GetByte(7),
                .InicioOperaciones = reader.GetDateTime(8),
                .Gerente = New EmpleadoDAO().ObtenerEmpleado(reader.GetInt32(9)),
                .InicioGestion = reader.GetDateTime(10),
                .Activo = reader.GetBoolean(11)
            }
            empresas.Add(empresa)
        End While

        reader.Close()
        connection.Close()

        Return empresas
    End Function
    Public Function ObtenerEmpresa(ByVal idEmpresa As String) As Empresa
        Dim empresa As New Empresa

        Dim command As New SqlCommand("VerEmpresas", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)

        connection.Open()

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        If (reader.Read()) Then
            empresa.RFC = reader.GetString(0)
            empresa.Nombre = reader.GetString(1)
            empresa.RegistroPatronal = reader.GetString(2)
            empresa.RazonSocial = reader.GetString(3)
            empresa.DomicilioFiscal = New DomicilioDAO().ObtenerDomicilio(reader.GetInt32(4))
            empresa.Telefono = reader.GetInt64(5)
            empresa.Correo = reader.GetString(6)
            empresa.FrecuenciaPago = reader.GetByte(7)
            empresa.InicioOperaciones = reader.GetDateTime(8)
            empresa.Gerente = New EmpleadoDAO().ObtenerEmpleado(reader.GetInt32(9))
            empresa.InicioGestion = reader.GetDateTime(10)
            empresa.Activo = reader.GetBoolean(11)
        End If

        reader.Close()
        connection.Close()

        Return empresa
    End Function
    Public Function AsignarGerente(ByVal rfc As String, ByVal idGerente As Integer) As Boolean
        Dim command As New SqlCommand("AsignarGerenteEmpresa", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@RFC_Empresa", rfc)
        command.Parameters.AddWithValue("@ID_Gerente", idGerente)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function AgregarDepartamento(ByVal idEmpresa As String, ByVal idDpto As Integer, ByVal sueldoBase As Double) As Boolean
        Dim command As New SqlCommand("AgregarDptoEmpresa", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@Sueldo_Base", sueldoBase)
        command.Parameters.AddWithValue("@Mode", 1)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function EditarDptoSueldo(ByVal idEmpresa As String, ByVal idDpto As Integer, ByVal sueldoBase As Double) As Boolean
        Dim command As New SqlCommand("AgregarDptoEmpresa", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@ID_Dpto", idDpto)
        command.Parameters.AddWithValue("@Sueldo_Base", sueldoBase)
        command.Parameters.AddWithValue("@Mode", 2)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
    Public Function AgregarPuesto(ByVal idEmpresa As String, ByVal idPuesto As Integer) As Boolean
        Dim command As New SqlCommand("AgregarPuestoEmpresa", connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@ID_Empresa", idEmpresa)
        command.Parameters.AddWithValue("@ID_Puesto", idPuesto)
        command.Parameters.AddWithValue("@Mode", 1)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()

        Return True
    End Function
End Class
