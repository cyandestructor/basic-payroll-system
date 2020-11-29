Public Class AppController
    Private Shared _instance As AppController
    Private Sub New()

    End Sub
    Public Shared Function GetInstance() As AppController
        If (_instance Is Nothing) Then
            _instance = New AppController
        End If
        Return _instance
    End Function
    Private _currentUser As Usuario
    Public Property CurrentUser() As Usuario
        Get
            Return _currentUser
        End Get
        Set(ByVal value As Usuario)
            _currentUser = value
        End Set
    End Property
End Class
