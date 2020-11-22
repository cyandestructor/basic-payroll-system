Public Class DptoPuesto
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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
    Private _puesto As Puesto
    Public Property Puesto() As Puesto
        Get
            Return _puesto
        End Get
        Set(ByVal value As Puesto)
            _puesto = value
        End Set
    End Property
    Private _porcentajeSueldo As Double
    Public Property PorcentajeSueldo() As Double
        Get
            Return _porcentajeSueldo
        End Get
        Set(ByVal value As Double)
            _porcentajeSueldo = value
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
