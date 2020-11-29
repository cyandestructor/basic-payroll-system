Public Class Empleado
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _apellidoPaterno As String
    Public Property ApellidoPaterno() As String
        Get
            Return _apellidoPaterno
        End Get
        Set(ByVal value As String)
            _apellidoPaterno = value
        End Set
    End Property
    Private _apellidoMaterno As String
    Public Property ApellidoMaterno() As String
        Get
            Return _apellidoMaterno
        End Get
        Set(ByVal value As String)
            _apellidoMaterno = value
        End Set
    End Property
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return _nombre + " " + _apellidoPaterno + " " + _apellidoMaterno
        End Get
    End Property
    Private _fechaNacimiento As Date
    Public Property FechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property
    Private _curp As String
    Public Property CURP() As String
        Get
            Return _curp
        End Get
        Set(ByVal value As String)
            _curp = value
        End Set
    End Property
    Private _rfc As String
    Public Property RFC() As String
        Get
            Return _rfc
        End Get
        Set(ByVal value As String)
            _rfc = value
        End Set
    End Property
    Private _nss As Long
    Public Property NSS() As Long
        Get
            Return _nss
        End Get
        Set(ByVal value As Long)
            _nss = value
        End Set
    End Property
    Private _domicilio As Domicilio
    Public Property Domicilio() As Domicilio
        Get
            Return _domicilio
        End Get
        Set(ByVal value As Domicilio)
            _domicilio = value
        End Set
    End Property
    Private _telefono As Long
    Public Property Telefono() As Long
        Get
            Return _telefono
        End Get
        Set(ByVal value As Long)
            _telefono = value
        End Set
    End Property
    Private _correo As String
    Public Property Correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property
    Private _banco As Banco
    Public Property Banco() As Banco
        Get
            Return _banco
        End Get
        Set(ByVal value As Banco)
            _banco = value
        End Set
    End Property
    Private _cuentaBancaria As Long
    Public Property CuentaBancaria() As Long
        Get
            Return _cuentaBancaria
        End Get
        Set(ByVal value As Long)
            _cuentaBancaria = value
        End Set
    End Property
    Private _empresa As Empresa
    Public Property EmpresaContratante() As Empresa
        Get
            Return _empresa
        End Get
        Set(ByVal value As Empresa)
            _empresa = value
        End Set
    End Property
    Private _fechaContrato As Date
    Public Property FechaContrato() As Date
        Get
            Return _fechaContrato
        End Get
        Set(ByVal value As Date)
            _fechaContrato = value
        End Set
    End Property
    Private _departamento As Departamento
    Public Property DepartamentoActual() As Departamento
        Get
            Return _departamento
        End Get
        Set(ByVal value As Departamento)
            _departamento = value
        End Set
    End Property
    Private _fechaIncorporacion As Date
    Public Property FechaIncorporacion() As Date
        Get
            Return _fechaIncorporacion
        End Get
        Set(ByVal value As Date)
            _fechaIncorporacion = value
        End Set
    End Property
    Private _puesto As Puesto
    Public Property PuestoActual() As Puesto
        Get
            Return _puesto
        End Get
        Set(ByVal value As Puesto)
            _puesto = value
        End Set
    End Property
    Private _fechaObtencion As Date
    Public Property FechaObtencion() As Date
        Get
            Return _fechaObtencion
        End Get
        Set(ByVal value As Date)
            _fechaObtencion = value
        End Set
    End Property
    Private _activo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property
End Class
