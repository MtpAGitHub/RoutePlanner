Imports System.IO

Public Class TXTStationBuilder
    Implements IStationListBuilder

    Public Sub New()

    End Sub

    Public Function buildStationList(fileData As String) As List(Of Station) Implements IStationListBuilder.buildStationList
        Dim stationList = New List(Of Station)
        Dim sr = New StringReader(fileData)
        Dim curLine = sr.ReadLine
        Do While Not curLine Is Nothing
            Dim code = curLine.Substring(0, 3)
            Dim name = curLine.Substring(4)
            Dim curStation = New Station(code, name)
            stationList.Add(curStation)
        Loop
        Return stationList
    End Function
End Class
