Public Class Headcounter2Row
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
    Private _numEmpleados As Integer
    Public Property CantidadEmpleados() As Integer
        Get
            Return _numEmpleados
        End Get
        Set(ByVal value As Integer)
            _numEmpleados = value
        End Set
    End Property
    Private _ultimaNomina As Date
    Public Property UltimaNomina() As Date
        Get
            Return _ultimaNomina
        End Get
        Set(ByVal value As Date)
            _ultimaNomina = value
        End Set
    End Property
End Class
