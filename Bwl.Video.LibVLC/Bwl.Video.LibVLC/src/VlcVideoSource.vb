Imports LibVLC.NET

Public Class VlcVideoSource
    Implements IVideoCapture
    Private _player As MediaPlayer
    Private _id As String = "0"
    Private _currentFrame As Bitmap
    Private _position As Integer
    Private _captureTime As DateTime = DateTime.MinValue

    Public Event FrameCaptured As IVideoCapture.FrameCapturedEventHandler Implements IVideoCapture.FrameCaptured
    Public Property Parameters As String Implements IVideoCapture.Parameters
    Public Property Address As String Implements IVideoCapture.Address

    Public Sub New(id As String)
        _id = id
        _player = New MediaPlayer
    End Sub

    Public ReadOnly Property CanCapture As Boolean Implements IVideoCapture.CanCapture
        Get
            If _player.State <> MediaPlayerState.Playing Then Return False
            If _player.VideoBuffer Is Nothing Then Return False
            If _player.VideoBuffer.FrameBuffer Is Nothing Then Return False
            Return True
        End Get
    End Property

    Public ReadOnly Property CaptureTime As Date Implements IVideoCapture.CaptureTime
        Get
            Return _captureTime
        End Get
    End Property

    Public Property FrameNumber As Integer Implements IVideoCapture.FrameNumber
        Get
            Return _player.FPS
        End Get
        Set(value As Integer)
        End Set
    End Property

    Public ReadOnly Property ID As String Implements IVideoCapture.ID
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property IsWorking As Boolean Implements IVideoCapture.IsWorking
        Get
            Return _player.State = MediaPlayerState.Playing
        End Get
    End Property

    Public ReadOnly Property MaxFrameNumber As Integer Implements IVideoCapture.MaxFrameNumber
        Get
            Return Int32.MaxValue
        End Get
    End Property

    Public ReadOnly Property MaxFrameRate As Integer Implements IVideoCapture.MaxFrameRate
        Get
            Return _player.FPS
        End Get
    End Property


    Public ReadOnly Property SyncObject As Object Implements IVideoCapture.SyncObject
        Get
            Return Me
        End Get
    End Property


    Public Sub Capture() Implements IVideoCapture.Capture
        SyncLock Me
            If _currentFrame IsNot Nothing Then
                Try
                    _currentFrame.Dispose()
                    _currentFrame = Nothing
                Catch ex As Exception

                End Try
            End If
            _currentFrame = _player.GetBitmap
            _captureTime = Now
            _position += 1
        End SyncLock
        RaiseEvent FrameCaptured(Me)
    End Sub

    Public Sub Close() Implements IVideoCapture.Close
        SyncLock Me
            _position = 0
            _player.Stop()
        End SyncLock
    End Sub

    Public Sub Open() Implements IVideoCapture.Open
        Close()
        SyncLock Me
            _position = 0
            _player.Location = New Uri(Address)
            _player.Play()
        End SyncLock
    End Sub

    Public Sub ShowSettings() Implements IVideoCapture.ShowSettings
    End Sub

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
End Class
