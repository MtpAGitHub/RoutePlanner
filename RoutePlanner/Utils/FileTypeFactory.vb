Public Class FileTypeFactory

    Public Sub New()
    End Sub

    Public Shared Function getInstance(ByVal fileType As FileType) As IFileLoader
        Dim loaderClass As IFileLoader
        Select Case fileType
            Case RoutePlanner.FileType.TXT
                loaderClass = New TxtFileLoader()
            Case RoutePlanner.FileType.CSV
                loaderClass = New CSVFileLoader()
            Case RoutePlanner.FileType.XML
                loaderClass = New TxtFileLoader()
            Case Else
                loaderClass = Nothing
        End Select
        Return loaderClass
    End Function
End Class
