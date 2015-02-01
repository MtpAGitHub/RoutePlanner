Public Class StationInventory

    Private _allStationList As List(Of Station)
    Public Property AllStationList() As List(Of Station)
        Get
            Return _allStationList
        End Get
        Set(ByVal value As List(Of Station))
            _allStationList = value
        End Set
    End Property

    Public Sub New()
        _allStationList = New List(Of Station)
    End Sub

End Class
