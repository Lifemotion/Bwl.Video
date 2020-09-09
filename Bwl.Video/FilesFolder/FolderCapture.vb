Imports System.IO

Public Class FolderCapture
    Implements IVideoCapture

    Private Class FileEntry
        Public filename As String
        Public filedate As DateTime
    End Class

    Private _fileList As String() = {}
    Private _position As Integer
    Private _currentFrame As Tuple(Of Bitmap, Byte())
    Private _captureTime As DateTime = DateTime.MinValue
    Private _id As String
    Private _path As String
    Private _fileCache As New Dictionary(Of String, Tuple(Of Bitmap, Byte()))

    Public Property MemoryCacheLimit As Integer = 0
    Public Property MemoryCacheUseClone As Boolean = False
    Public Property JpegOnlyOutput As Boolean = False

    Public Sub New(id As String)
        _id = id
    End Sub

    Public Property Repeat As Boolean = True

    Public ReadOnly Property CanCapture As Boolean Implements IVideoCapture.CanCapture
        Get
            SyncLock Me
                If FrameNumber <= _fileList.Length Then Return True Else Return False
            End SyncLock
        End Get
    End Property

    Public Property NextFrameAfterCapture As Boolean = True
    Private _prevFrameDuration As TimeSpan

    Public Sub Capture() Implements IVideoCapture.Capture
        If Not CanCapture Then Throw New Exception("No more frames. Use Open to restart.")
        SyncLock Me
            Dim getFrame = Function(fileName As String) As Tuple(Of Bitmap, Byte())
                               Dim fileData = IO.File.ReadAllBytes(fileName)
                               Dim jpegData = If(fileData(0) = &HFF AndAlso fileData(1) = &HD8 AndAlso fileData(2) = &HFF AndAlso fileData(3) = &HE0, fileData, Nothing)
                               Dim res As Tuple(Of Bitmap, Byte()) = Nothing
                               If JpegOnlyOutput Then
                                   res = New Tuple(Of Bitmap, Byte())(Nothing, jpegData)
                               Else
                                   res = New Tuple(Of Bitmap, Byte())(New Bitmap(New MemoryStream(fileData)), jpegData)
                               End If
                               Return res
                           End Function
            Dim file = _fileList(_position)
            If MemoryCacheLimit > 0 Then
                If _fileCache.ContainsKey(file) Then
                    If MemoryCacheUseClone Then
                        _currentFrame = New Tuple(Of Bitmap, Byte())(New Bitmap(_fileCache(file).Item1), _fileCache(file).Item2.ToArray())
                    Else
                        _currentFrame = _fileCache(file)
                    End If
                Else
                    _currentFrame = getFrame(file)
                    If _fileCache.Count < MemoryCacheLimit Then
                        _fileCache.Add(file, _currentFrame)
                    End If
                End If
            Else
                _currentFrame = getFrame(file)
            End If

            If NextFrameAfterCapture Then _position += 1
            If _position >= _fileList.Length Then
                If Repeat Then
                    _position = 0
                Else
                    Throw New Exception("No available frames")
                End If
            End If

            Dim captureTime As DateTime = New DateTime
            Try
                Dim name = IO.Path.GetFileNameWithoutExtension(file)
                Dim nameNumeric = New String(name.Where(Function(c) Char.IsNumber(c)).ToArray())
                captureTime = New DateTime(Convert.ToInt64(nameNumeric))
            Catch ex As Exception
                _captureTime = New DateTime
            End Try

            _prevFrameDuration = captureTime - _captureTime
            _captureTime = captureTime

            RaiseEvent FrameCaptured(Me)
        End SyncLock
    End Sub

    ' Public Property AllowNamesWithoutTime As Boolean = False

    Public Sub Close() Implements IVideoCapture.Close
        Restart()
        _fileList = {}
    End Sub

    Public Property FrameNumber As Integer Implements IVideoCapture.FrameNumber
        Get
            Return _position + 1
        End Get
        Set(value As Integer)
            If value < 1 Then value = 1
            If value > _fileList.Length Then value = _fileList.Length
            _position = value - 1
        End Set
    End Property

    Public Function GetBitmap() As Bitmap Implements IVideoCapture.GetBitmap
        Return _currentFrame.Item1
    End Function

    Public Function GetBitmapCopy() As Bitmap Implements IVideoCapture.GetBitmapCopy
        SyncLock Me
            Return New Bitmap(_currentFrame.Item1)
        End SyncLock
    End Function

    Public Function GetBitmapCopy(width As Integer, height As Integer) As Bitmap Implements IVideoCapture.GetBitmapCopy
        SyncLock Me
            Return If(_currentFrame IsNot Nothing, New Bitmap(_currentFrame.Item1, width, height), New Bitmap(width, height, Imaging.PixelFormat.Format24bppRgb))
        End SyncLock
    End Function

    Public Function GetJpeg() As Byte()
        Return _currentFrame.Item2
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
            Restart()
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

    Public ReadOnly Property CaptureTime As DateTime Implements IVideoCapture.CaptureTime
        Get
            Return _captureTime
        End Get
    End Property

    Public ReadOnly Property SyncObject As Object Implements IVideoCapture.SyncObject
        Get
            Return Me
        End Get
    End Property

    Public Event FrameCaptured(source As IVideoCapture) Implements IVideoCapture.FrameCaptured
End Class
