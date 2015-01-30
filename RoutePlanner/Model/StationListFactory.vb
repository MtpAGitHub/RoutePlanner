Public Class StationListFactory

    Public Sub New()

    End Sub

    Public Shared Function getInstance(ByVal fileType As String) As IStationListBuilder
        Select Case fileType
            Case ".txt"
                Return New TXTStationBuilder()
            Case ".csv"
                Return New CSVStationBuilder()
            Case Else
                Return Nothing
        End Select
    End Function
End Class
