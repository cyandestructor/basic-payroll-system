Public Class Nomina
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _sueldoBruto As Double
    Public Property SueldoBruto() As Double
        Get
            Return _sueldoBruto
        End Get
        Set(ByVal value As Double)
            _sueldoBruto = value
        End Set
    End Property
    Private _sueldoNeto As Double
    Public Property SueldoNeto() As Double
        Get
            Return _sueldoNeto
        End Get
        Set(ByVal value As Double)
            _sueldoNeto = value
        End Set
    End Property
    Private _idEmpleado As Integer
    Public Property IDEmpleado() As Integer
        Get
            Return _idEmpleado
        End Get
        Set(ByVal value As Integer)
            _idEmpleado = value
        End Set
    End Property
    Private _inicioPeriodo As Date
    Public Property InicioPeriodo() As Date
        Get
            Return _inicioPeriodo
        End Get
        Set(ByVal value As Date)
            _inicioPeriodo = value
        End Set
    End Property
    Private _finPeriodo As Date
    Public Property FinPeriodo() As Date
        Get
            Return _finPeriodo
        End Get
        Set(ByVal value As Date)
            _finPeriodo = value
        End Set
    End Property
    Private _fechaGeneracion As Date
    Public Property FechaGeneracion() As Date
        Get
            Return _fechaGeneracion
        End Get
        Set(ByVal value As Date)
            _fechaGeneracion = value
        End Set
    End Property
End Class
