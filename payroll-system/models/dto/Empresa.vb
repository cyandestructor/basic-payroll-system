Public Class Empresa
    Private _rfc As String
    Public Property RFC() As String
        Get
            Return _rfc
        End Get
        Set(ByVal value As String)
            _rfc = value
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
    Private _registroPatronal As Long
    Public Property RegistroPatronal() As Long
        Get
            Return _registroPatronal
        End Get
        Set(ByVal value As Long)
            _registroPatronal = value
        End Set
    End Property
    Private _razonSocial As String
    Public Property RazonSocial() As String
        Get
            Return _razonSocial
        End Get
        Set(ByVal value As String)
            _razonSocial = value
        End Set
    End Property
    Private _domicilioFiscal As Domicilio
    Public Property DomicilioFiscal() As Domicilio
        Get
            Return _domicilioFiscal
        End Get
        Set(ByVal value As Domicilio)
            _domicilioFiscal = value
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
    Private _frecuenciaPago As Byte
    Public Property FrecuenciaPago() As Byte
        Get
            Return _frecuenciaPago
        End Get
        Set(ByVal value As Byte)
            _frecuenciaPago = value
        End Set
    End Property
    Private _inicioOperaciones As Date
    Public Property InicioOperaciones() As Date
        Get
            Return _inicioOperaciones
        End Get
        Set(ByVal value As Date)
            _inicioOperaciones = value
        End Set
    End Property
    Private _gerente As Empleado
    Public Property Gerente() As Empleado
        Get
            Return _gerente
        End Get
        Set(ByVal value As Empleado)
            _gerente = value
        End Set
    End Property
    Private _inicioGestion As Date
    Public Property InicioGestion() As Date
        Get
            Return _inicioGestion
        End Get
        Set(ByVal value As Date)
            _inicioGestion = value
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
