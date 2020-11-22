Public Class Usuario
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property
    Private _nivel As Byte
    Public Property Nivel() As Byte
        Get
            Return _nivel
        End Get
        Set(ByVal value As Byte)
            _nivel = value
        End Set
    End Property
End Class
