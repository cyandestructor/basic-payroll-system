Public Class Domicilio
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _calle As String
    Public Property Calle() As String
        Get
            Return _calle
        End Get
        Set(ByVal value As String)
            _calle = value
        End Set
    End Property
    Private _numero As Integer
    Public Property Numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property
    Private _colonia As String
    Public Property Colonia() As String
        Get
            Return _colonia
        End Get
        Set(ByVal value As String)
            _colonia = value
        End Set
    End Property
    Private _codigoPostal As Integer
    Public Property CodigoPostal() As Integer
        Get
            Return _codigoPostal
        End Get
        Set(ByVal value As Integer)
            _codigoPostal = value
        End Set
    End Property
    Private _ciudad As String
    Public Property Ciudad() As String
        Get
            Return _ciudad
        End Get
        Set(ByVal value As String)
            _ciudad = value
        End Set
    End Property
    Private _estado As String
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
End Class
