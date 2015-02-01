Public Class FileExtension

    Public Sub New()

    End Sub

    Public Shared Function getExtension(ByVal fileName As String) As FileType
        Dim filenameArr() = fileName.Split(".")
        If filenameArr.Length > 1 Then
            Select Case filenameArr(1)
                Case ".txt"
                    Return FileType.TXT
                Case ".csv"
                    Return FileType.CSV
                Case ".xml"
                    Return FileType.XML
                Case Else
                    Return FileType.TXT
            End Select
        Else
            Return Nothing
        End If
    End Function
End Class
