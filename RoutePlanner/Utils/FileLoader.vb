Imports Microsoft.Win32

Public Class FileLoader

    Private fileDialog As OpenFileDialog
    Private _fileType As FileType
    Public Property FileType() As FileType
        Get
            Return _fileType
        End Get
        Set(ByVal value As FileType)
            _fileType = value
        End Set
    End Property
    Private _loadFileType As IFileLoader
    Public Property LoadFileType() As IFileLoader
        Get
            Return _loadFileType
        End Get
        Set(ByVal value As IFileLoader)
            _loadFileType = value
        End Set
    End Property
    Private _fileData As String
    Public Property FileData() As String
        Get
            Return _fileData
        End Get
        Set(ByVal value As String)
            _fileData = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(loadFile As String)
        Me._fileType = FileExtension.getExtension(loadFile)
        Me._loadFileType = FileTypeFactory.getInstance(_fileType)
        Me._fileData = Me._loadFileType.loadDataFile(loadFile)
    End Sub

End Class
