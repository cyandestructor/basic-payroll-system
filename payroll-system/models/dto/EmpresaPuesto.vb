Public Class EmpresaPuesto
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
    Private _puesto As Puesto
    Public Property Puesto() As Puesto
        Get
            Return _puesto
        End Get
        Set(ByVal value As Puesto)
            _puesto = value
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
