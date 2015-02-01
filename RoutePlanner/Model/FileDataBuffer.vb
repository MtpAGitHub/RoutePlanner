Public Class FileDataBuffer

    Private _loadedData As String
    Public Property LoadedData() As String
        Get
            Return _loadedData
        End Get
        Set(ByVal value As String)
            _loadedData = value
        End Set
    End Property
    Private _dataType As FileType
    Public Property DataType() As FileType
        Get
            Return _dataType
        End Get
        Set(ByVal value As FileType)
            _dataType = value
        End Set
    End Property


    Public Sub New()

    End Sub

End Class
