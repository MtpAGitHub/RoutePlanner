Public Class StationListFactory

    Public Sub New()

    End Sub

    Public Shared Function getInstance(ByVal fileType As FileType) As IStationListBuilder
        Select Case fileType
            Case RoutePlanner.FileType.TXT
                Return New TXTStationBuilder()
            Case RoutePlanner.FileType.CSV
                Return New CSVStationBuilder()
            Case RoutePlanner.FileType.XML
                Return New TXTStationBuilder()
            Case Else
                Return Nothing
        End Select
    End Function
End Class
