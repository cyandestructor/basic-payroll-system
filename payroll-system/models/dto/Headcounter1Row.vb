Public Class Headcounter1Row
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
    Private _puesto As String
    Public Property Puesto() As String
        Get
            Return _puesto
        End Get
        Set(ByVal value As String)
            _puesto = value
        End Set
    End Property
    Private _cantEmpleados As Integer
    Public Property CantidadEmpleados() As Integer
        Get
            Return _cantEmpleados
        End Get
        Set(ByVal value As Integer)
            _cantEmpleados = value
        End Set
    End Property
End Class
