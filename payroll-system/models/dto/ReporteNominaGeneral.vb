Public Class ReporteNominaGeneral
    Private _departamento As String
    Public Property Departamento() As String
        Get
            Return _departamento
        End Get
        Set(ByVal value As String)
            _departamento = value
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
    Private _empleado As String
    Public Property Empleado() As String
        Get
            Return _empleado
        End Get
        Set(ByVal value As String)
            _empleado = value
        End Set
    End Property
    Private _fechaIngreso As Date
    Public Property FechaIngreso() As Date
        Get
            Return _fechaIngreso
        End Get
        Set(ByVal value As Date)
            _fechaIngreso = value
        End Set
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
    Private _sueldoDiario As Double
    Public Property SueldoDiario() As Double
        Get
            Return _sueldoDiario
        End Get
        Set(ByVal value As Double)
            _sueldoDiario = value
        End Set
    End Property
End Class
