Public Class EmpresaDpto
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _empresa As Empresa
    Public Property Empresa() As Empresa
        Get
            Return _empresa
        End Get
        Set(ByVal value As Empresa)
            _empresa = value
        End Set
    End Property
    Private _departamento As Departamento
    Public Property Departamento() As Departamento
        Get
            Return _departamento
        End Get
        Set(ByVal value As Departamento)
            _departamento = value
        End Set
    End Property
    Private _sueldoBase As Double
    Public Property SueldoBase() As Double
        Get
            Return _sueldoBase
        End Get
        Set(ByVal value As Double)
            _sueldoBase = value
        End Set
    End Property
    Private _gerenteDepartamento As Empleado
    Public Property GerenteDepartamento() As Empleado
        Get
            Return _gerenteDepartamento
        End Get
        Set(ByVal value As Empleado)
            _gerenteDepartamento = value
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
    Private _bonoGerente As Double
    Public Property BonoGerente() As Double
        Get
            Return _bonoGerente
        End Get
        Set(ByVal value As Double)
            _bonoGerente = value
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
