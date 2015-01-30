Public Class FileExtension

    Public Sub New()

    End Sub

    Public Shared Function getExtension(ByVal fileName As String) As String
        Dim extensionStop = fileName.IndexOf(".")
        If extensionStop > -1 Then
            Return fileName.Substring(extensionStop)
        Else
            Return Nothing
        End If
    End Function
End Class
