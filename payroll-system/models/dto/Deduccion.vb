Public Class Deduccion
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Private _cantidadFija As Double
    Public Property CantidadFija() As Double
        Get
            Return _cantidadFija
        End Get
        Set(ByVal value As Double)
            _cantidadFija = value
        End Set
    End Property
    Private _cantidadPorcentual As Double
    Public Property CantidadPorcentual() As Double
        Get
            Return _cantidadPorcentual
        End Get
        Set(ByVal value As Double)
            _cantidadPorcentual = value
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
    Private _idEmpleado As Integer
    Public Property IDEmpleado() As Integer
        Get
            Return _idEmpleado
        End Get
        Set(ByVal value As Integer)
            _idEmpleado = value
        End Set
    End Property
End Class
