Public Class ResumenPagosRow
    Private _idEmpleado As Integer
    Public Property IDEmpleado() As Integer
        Get
            Return _idEmpleado
        End Get
        Set(ByVal value As Integer)
            _idEmpleado = value
        End Set
    End Property
    Private _RFCEmpleado As String
    Public Property RFCEmpleado() As String
        Get
            Return _RFCEmpleado
        End Get
        Set(ByVal value As String)
            _RFCEmpleado = value
        End Set
    End Property
    Private _NSSEmpleado As Long
    Public Property NSSEmpleado() As Long
        Get
            Return _NSSEmpleado
        End Get
        Set(ByVal value As Long)
            _NSSEmpleado = value
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
    Private _mes As String
    Public Property Mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
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
End Class
