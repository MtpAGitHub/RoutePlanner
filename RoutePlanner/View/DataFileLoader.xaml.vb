Public Class DataFileLoader

    Private _loadedData As FileDataBuffer
    Public Property LoadedData() As FileDataBuffer
        Get
            Return _loadedData
        End Get
        Set(ByVal value As FileDataBuffer)
            _loadedData = value
        End Set
    End Property

    Public Sub New(fileData As FileDataBuffer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._loadedData = fileData
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As RoutedEventArgs) Handles btnLoad.Click
        Dim selectFile = New FilePicker()
        Dim fl = New FileLoader(selectFile.FileName)
        Me._loadedData.LoadedData = fl.FileData
        Me._loadedData.DataType = FileType.TXT
        If Not String.IsNullOrEmpty(Me._loadedData.LoadedData) Then
            txtbxStatus.Text = "File loaded OK"
            txtbxFileData.Text = fl.FileData
        Else
            txtbxStatus.Text = "No data loaded"
        End If
    End Sub
End Class
