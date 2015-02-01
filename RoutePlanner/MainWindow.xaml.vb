Class MainWindow 

    Private _allStations As StationInventory
    Public Property AllStations() As StationInventory
        Get
            Return _allStations
        End Get
        Set(ByVal value As StationInventory)
            _allStations = value
        End Set
    End Property
    Public Property isBtnEnabled = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        allStations = New StationInventory()
    End Sub

    Private Sub btnMapBuild_Click(sender As Object, e As RoutedEventArgs) Handles btnMapBuild.Click

    End Sub

    Private Sub btnLoader_Click(sender As Object, e As RoutedEventArgs) Handles btnLoader.Click
        Dim stationLoader As Loader = New Loader(Me._allStations)
        stationLoader.Show()
    End Sub

    Private Sub btnViewStations_Click(sender As Object, e As RoutedEventArgs) Handles btnViewStations.Click
        Dim stationListView = New StationList(Me._allStations.AllStationList)
        stationListView.Show()
    End Sub

End Class
