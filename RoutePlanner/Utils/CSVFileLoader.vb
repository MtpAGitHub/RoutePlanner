Public Class CSVFileLoader
    Implements IFileLoader

    Public Sub New()

    End Sub

    Public Function loadDataFile(fileName As String) As String Implements IFileLoader.loadDataFile
        Return "CSV File"
    End Function
End Class
