Imports Microsoft.Win32

Public Class FilePicker
    Private fileDialog As OpenFileDialog
    Private _fileName As String
    Public Property FileName() As String
        Get
            Return _fileName
        End Get
        Set(ByVal value As String)
            _fileName = value
        End Set
    End Property

    Public Sub New()
        fileDialog = New OpenFileDialog()
        fileDialog.Title = "File Loader"
        fileDialog.InitialDirectory = "C:\"
        fileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fileDialog.FilterIndex = 2
        fileDialog.RestoreDirectory = True
        If fileDialog.ShowDialog() = True Then
            Me._fileName = fileDialog.FileName
        End If
    End Sub

    Public Sub New(ByVal dialogTitle As String, ByVal startDir As String, ByVal fileFilter As String, ByVal filterIndex As Integer, ByVal restoreDir As Boolean)
        fileDialog = New OpenFileDialog()
        fileDialog.Title = dialogTitle
        fileDialog.InitialDirectory = startDir
        fileDialog.Filter = fileFilter
        fileDialog.FilterIndex = filterIndex
        fileDialog.RestoreDirectory = restoreDir
        If fileDialog.ShowDialog() = True Then
            Me._fileName = fileDialog.FileName
        End If
    End Sub
End Class
