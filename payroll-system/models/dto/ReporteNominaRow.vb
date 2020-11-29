Public Class ReporteNominaRow
    Private _empresa As String
    Public Property Empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property
    Private _departamento As String
    Public Property Departamento() As String
        Get
            Return _departamento
        End Get
        Set(ByVal value As String)
            _departamento = value
        End Set
    End Property
    Private _gerente As String
    Public Property Gerente() As String
        Get
            Return _gerente
        End Get
        Set(ByVal value As String)
            _gerente = value
        End Set
    End Property
    Private _year As Integer
    Public Property Year() As Integer
        Get
            Return _year
        End Get
        Set(ByVal value As Integer)
            _year = value
        End Set
    End Property
    Private _mes As Integer
    Public Property Mes() As Integer
        Get
            Return _mes
        End Get
        Set(ByVal value As Integer)
            _mes = value
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
    Private _totalISR As Double
    Public Property ISR() As Double
        Get
            Return _totalISR
        End Get
        Set(ByVal value As Double)
            _totalISR = value
        End Set
    End Property
    Private _totalIMSS As Double
    Public Property IMSS() As Double
        Get
            Return _totalIMSS
        End Get
        Set(ByVal value As Double)
            _totalIMSS = value
        End Set
    End Property
End Class
