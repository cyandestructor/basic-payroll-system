Public Class ReciboNomina
    Private _datosEmpresa As New Empresa
    Public Property DatosEmpresa() As Empresa
        Get
            Return _datosEmpresa
        End Get
        Set(ByVal value As Empresa)
            _datosEmpresa = value
        End Set
    End Property
    Private _datosEmpleado As New Empleado
    Public Property DatosEmpleado() As Empleado
        Get
            Return _datosEmpleado
        End Get
        Set(ByVal value As Empleado)
            _datosEmpleado = value
        End Set
    End Property
    Private _datosNomina As New Nomina
    Public Property DatosNomina() As Nomina
        Get
            Return _datosNomina
        End Get
        Set(ByVal value As Nomina)
            _datosNomina = value
        End Set
    End Property
    Private _idDepartamento As Integer
    Public Property Departamento() As Integer
        Get
            Return _idDepartamento
        End Get
        Set(ByVal value As Integer)
            _idDepartamento = value
        End Set
    End Property
    Private _puesto As String
    Public Property Puesto() As String
        Get
            Return _puesto
        End Get
        Set(ByVal value As String)
            _puesto = value
        End Set
    End Property
    Private _sueldoDiario As Double
    Public Property SueldoDiario() As Double
        Get
            Return _sueldoDiario
        End Get
        Set(ByVal value As Double)
            _sueldoDiario = value
        End Set
    End Property
    Private _diasPeriodo As Integer
    Public Property DiasPeriodo() As Integer
        Get
            Return _diasPeriodo
        End Get
        Set(ByVal value As Integer)
            _diasPeriodo = value
        End Set
    End Property
    Private _sueldoEscrito As String
    Public Property SueldoEscrito() As String
        Get
            Return _sueldoEscrito
        End Get
        Set(ByVal value As String)
            _sueldoEscrito = value
        End Set
    End Property
End Class
