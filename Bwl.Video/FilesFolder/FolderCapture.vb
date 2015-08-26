Public Class FolderCapture
    Implements IVideoCapture

    Private Class FileEntry
        Public filename As String
        Public filedate As DateTime
    End Class

    Private _fileList As String() = {}
    Private _position As Integer
    Private _currentFrame As Bitmap
    Private _id As String
    Private _path As String

    Public Sub New(id As String)
        _id = id
    End Sub

    Public Property Repeat As Boolean = True

    Public ReadOnly Property CanCapture As Boolean Implements IVideoCapture.CanCapture
        Get
            SyncLock Me
                If _fileList.Length > _position Then Return True Else Return False
            End SyncLock
        End Get
    End Property

    Public Property NextFrameAfrerCapture As Boolean = True

    Public Sub Capture() Implements IVideoCapture.Capture
        If Not CanCapture Then Throw New Exception("No more frames. Use Open to restart.")
        SyncLock Me
            _currentFrame = Bitmap.FromFile(_fileList(_position))
            If NextFrameAfrerCapture Then _position += 1
            If Repeat And _fileList.Length <= _position Then _position = 0
            RaiseEvent FrameCaptured(Me)
        End SyncLock
    End Sub

    Public Sub Close() Implements IVideoCapture.Close
        _fileList = {}
        _position = 0
    End Sub

    Public Property FrameNumber As Integer Implements IVideoCapture.FrameNumber
        Get
            Return _position
        End Get
        Set(value As Integer)
            If value < 0 Then value = 0
            If value > _fileList.Length - 1 Then value = _fileList.Length - 1
            _position = value
        End Set
    End Property

    Public Function GetBitmap() As Bitmap Implements IVideoCapture.GetBitmap
        Return _currentFrame
    End Function

    Public Function GetBitmapCopy() As Bitmap Implements IVideoCapture.GetBitmapCopy
        SyncLock Me
            Return New Bitmap(_currentFrame)
        End SyncLock
    End Function

    Public Function GetBitmapCopy(width As Integer, height As Integer) As Bitmap Implements IVideoCapture.GetBitmapCopy
        SyncLock Me
            Return If(_currentFrame IsNot Nothing, New Bitmap(_currentFrame, width, height), New Bitmap(width, height, Imaging.PixelFormat.Format24bppRgb))
        End SyncLock
    End Function

    Public ReadOnly Property ID As String Implements IVideoCapture.ID
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property MaxFrameRate As Integer Implements IVideoCapture.MaxFrameRate
        Get
            Return Integer.MaxValue
        End Get
    End Property

    Public Sub Open() Implements IVideoCapture.Open
        SyncLock Me
            If IO.Directory.Exists(Address) = False Then Throw New Exception("Path " + Address + " not exists")
            _path = Address
            Dim files1 = IO.Directory.GetFiles(_path, "*.jpg")
            Dim files2 = IO.Directory.GetFiles(_path, "*.png")
            Dim list As New List(Of String)
            list.AddRange(files1)
            list.AddRange(files2)

            _fileList = list.ToArray
            _position = 0
        End SyncLock
    End Sub

    Public Sub Restart()
        _position = 0
    End Sub

    Public ReadOnly Property FileList As String()
        Get
            Return _fileList
        End Get
    End Property

    Public Sub ShowSettings() Implements IVideoCapture.ShowSettings
    End Sub

    Public ReadOnly Property Working As Boolean Implements IVideoCapture.IsWorking
        Get
            Return CanCapture
        End Get
    End Property

    Public Property Address As String Implements IVideoCapture.Address

    Public Property Parameters As String Implements IVideoCapture.Parameters

    Public ReadOnly Property MaxFrameNumber As Integer Implements IVideoCapture.MaxFrameNumber
        Get
            Return _fileList.Length
        End Get
    End Property

    Public ReadOnly Property SyncObject As Object Implements IVideoCapture.SyncObject
        Get
            Return Me
        End Get
    End Property

    Public Event FrameCaptured(source As IVideoCapture) Implements IVideoCapture.FrameCaptured
End Class
