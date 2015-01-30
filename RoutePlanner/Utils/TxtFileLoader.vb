Imports System.IO
Imports System.Text

Public Class TxtFileLoader
    Implements IFileLoader

    Public Sub New()

    End Sub

    Public Function loadDataFile(fileName As String) As String Implements IFileLoader.loadDataFile
        Dim txtStreamReader = New StreamReader(fileName)
        Dim fileData = New StringBuilder()
        fileData.Append(txtStreamReader.ReadLine)
        Do While Not fileData Is Nothing
            fileData.Append(txtStreamReader.ReadLine)
        Loop
        txtStreamReader.Close()
        Return fileData.ToString
    End Function
End Class
