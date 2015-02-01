Imports System.IO
Imports System.Text

''' <summary>
''' Class TxtFileLoader
''' Is used to load in data from a given path\filename using a StreamReader and returning the data as a String
''' </summary>
''' <remarks>This is a remark</remarks>
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
