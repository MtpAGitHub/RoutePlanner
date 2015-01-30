Public Class FileTypeFactory

    Public Sub New()
    End Sub

    Public Shared Function getInstance(ByVal fileType As String) As IFileLoader
        Dim loaderClass As IFileLoader
        Select Case FileType
            Case ".txt"
                loaderClass = New TxtFileLoader()
            Case ".csv"
                loaderClass = New CSVFileLoader()
            Case Else
                loaderClass = Nothing
        End Select
        Return loaderClass
    End Function
End Class
