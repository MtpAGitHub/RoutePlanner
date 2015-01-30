Public Class Station

    Private _stationCode As String
    Public Property StationCode() As String
        Get
            Return _stationCode
        End Get
        Set(ByVal value As String)
            _stationCode = value
        End Set
    End Property
    Private _stationName As String
    Public Property StationName() As String
        Get
            Return _stationName
        End Get
        Set(ByVal value As String)
            _stationName = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal codeVal As String, ByVal nameVal As String)
        Me._stationCode = codeVal
        Me._stationName = nameVal
    End Sub
End Class
