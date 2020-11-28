Public Class ReporteCalculoNomina
    Private _idNomina As Integer
    Public Property IDNomina() As Integer
        Get
            Return _idNomina
        End Get
        Set(ByVal value As Integer)
            _idNomina = value
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
    Private _nombreEmpleado As String
    Public Property NombreEmpleado() As String
        Get
            Return _nombreEmpleado
        End Get
        Set(ByVal value As String)
            _nombreEmpleado = value
        End Set
    End Property
    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Private _cantidadDeposito As Double
    Public Property CantidadDeposito() As Double
        Get
            Return _cantidadDeposito
        End Get
        Set(ByVal value As Double)
            _cantidadDeposito = value
        End Set
    End Property
    Private _banco As String
    Public Property Banco() As String
        Get
            Return _banco
        End Get
        Set(ByVal value As String)
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
End Class
