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
    Private _fileData As FileDataBuffer
    Public Property FileData() As FileDataBuffer
        Get
            Return _fileData
        End Get
        Set(ByVal value As FileDataBuffer)
            _fileData = value
        End Set
    End Property

    Public Property isBtnEnabled = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AllStations = New StationInventory()
        FileData = New FileDataBuffer()
    End Sub

    Private Sub btnMapBuild_Click(sender As Object, e As RoutedEventArgs) Handles btnMapBuild.Click

    End Sub

    Private Sub btnViewStations_Click(sender As Object, e As RoutedEventArgs) Handles btnViewStations.Click
        Dim slb = StationListFactory.getInstance(FileData.DataType)
        Me._allStations.AllStationList = slb.buildStationList(FileData.LoadedData)
        Dim stationListView = New StationList(AllStations.AllStationList)
        stationListView.Show()
    End Sub

    Private Sub btnViewMap_Click(sender As Object, e As RoutedEventArgs) Handles btnViewMap.Click

    End Sub

    Private Sub btnLoadMap_Click(sender As Object, e As RoutedEventArgs) Handles btnLoadMap.Click
        Dim fileLoader = New DataFileLoader(Me._fileData)
        fileLoader.Show()
    End Sub

    Private Sub btnStationLoader_Click(sender As Object, e As RoutedEventArgs) Handles btnStationLoader.Click
        Dim fileLoader = New DataFileLoader(Me._fileData)
        fileLoader.Show()
    End Sub
End Class
