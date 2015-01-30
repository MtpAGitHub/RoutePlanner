Imports System.IO
Imports System.Text

Public Class TxtFileLoader
    Implements IFileLoader

    Public Sub New()

    End Sub

    Public Function loadDataFile(fileName As String) As String Implements IFileLoader.loadDataFile
        Dim txtStreamReader = New StreamReader(fileName)
        Dim fileData = New StringBuilder()
        Dim curLine As String
        curLine = txtStreamReader.ReadLine
        Do While Not curLine Is Nothing
            fileData.Append(curLine)
            fileData.Append(vbCr)
            curLine = txtStreamReader.ReadLine
        Loop
        txtStreamReader.Close()
        Return fileData.ToString
    End Function
End Class
