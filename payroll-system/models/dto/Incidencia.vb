Public Class Incidencia
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
    Private _inicio As Date
    Public Property Inicio() As Date
        Get
            Return _inicio
        End Get
        Set(ByVal value As Date)
            _inicio = value
        End Set
    End Property
    Private _fin As Date
    Public Property Fin() As Date
        Get
            Return _fin
        End Get
        Set(ByVal value As Date)
            _fin = value
        End Set
    End Property
    Private _idSolicitante As Integer
    Public Property IDSolicitante() As Integer
        Get
            Return _idSolicitante
        End Get
        Set(ByVal value As Integer)
            _idSolicitante = value
        End Set
    End Property
    Private _fechaSolicitud As Date
    Public Property FechaSolicitud() As Date
        Get
            Return _fechaSolicitud
        End Get
        Set(ByVal value As Date)
            _fechaSolicitud = value
        End Set
    End Property
    Private _motivoSolicitud As String
    Public Property MotivoSolicitud() As String
        Get
            Return _motivoSolicitud
        End Get
        Set(ByVal value As String)
            _motivoSolicitud = value
        End Set
    End Property
    Private _idGerente As Integer
    Public Property IDGerente() As Integer
        Get
            Return _idGerente
        End Get
        Set(ByVal value As Integer)
            _idGerente = value
        End Set
    End Property
    Private _fechaRevision As Date
    Public Property FechaRevision() As Date
        Get
            Return _fechaRevision
        End Get
        Set(ByVal value As Date)
            _fechaRevision = value
        End Set
    End Property
    Private _estado As Byte
    Public Property Estado() As Byte
        Get
            Return _estado
        End Get
        Set(ByVal value As Byte)
            _estado = value
        End Set
    End Property
    Private _goceSueldo As Boolean
    Public Property GoceSueldo() As Boolean
        Get
            Return _goceSueldo
        End Get
        Set(ByVal value As Boolean)
            _goceSueldo = value
        End Set
    End Property
End Class
