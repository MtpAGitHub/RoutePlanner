Public Class CSVStationBuilder
    Implements IStationListBuilder

    Public Function buildStationList(fileData As String) As List(Of Station) Implements IStationListBuilder.buildStationList
        Dim stationList = New List(Of Station)
        Return stationList
    End Function
End Class
