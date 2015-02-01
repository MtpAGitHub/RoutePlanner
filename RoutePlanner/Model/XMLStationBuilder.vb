Imports System.Xml

Public Class XMLStationBuilder
    Implements IStationListBuilder

    Public Function buildStationList(fileData As String) As List(Of Station) Implements IStationListBuilder.buildStationList
        Try
            Dim stationList = New List(Of Station)
            Dim xmlDoc = New XmlDocument()
            xmlDoc.LoadXml(fileData)
            Dim stationNodes = xmlDoc.SelectNodes("/StationList/Station")
            For Each dataNode As XmlNode In stationNodes
                Dim stationCode = dataNode.ChildNodes.Item(0).InnerText
                Dim stationName = dataNode.ChildNodes.Item(1).InnerText
                Dim curStation = New Station(stationCode, stationName)
                stationList.Add(curStation)
            Next
            Return stationList
        Catch ex As Exception
            Console.WriteLine("XMLStationBuilder : Something wrong in the XML conversion")
            Return Nothing
        End Try
    End Function
End Class
