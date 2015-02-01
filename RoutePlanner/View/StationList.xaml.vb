Imports System.Collections.ObjectModel

Public Class StationList

    Public Property dispStationList As New ObservableCollection(Of Station)

    Public Sub New(stationList As List(Of Station))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each curStation As Station In stationList
            dispStationList.Add(curStation)
        Next

    End Sub

End Class
