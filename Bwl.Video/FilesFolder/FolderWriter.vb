Imports System.Drawing.Imaging

Public Class FolderWriter
    Implements IVideoWriter

    Private _path As String
    Private _jpegSaver As New JpegSaver
    Private _frames As Integer
    Private _lastFrames As Integer
    Private _lastTime As DateTime = Now
    Private _lastFPS As Single = 0.0

    Public Sub New(path As String)
        Me.New(path, 80)
    End Sub

    Public Sub New(path As String, quality As Integer)
        If Not IO.Directory.Exists(path) Then IO.Directory.CreateDirectory(path)
        _path = path
        _jpegSaver.Quality = quality
        Address = _path
        Parameters = "Quality=" + quality.ToString
    End Sub

    Public Sub Close() Implements IVideoWriter.Close
        IO.File.WriteAllText(IO.Path.Combine(_path, ".framerate"), FrameRate)
        _path = Nothing
    End Sub

    Public Property FrameRate As Integer Implements IVideoWriter.FrameRate

    Public Sub WriteFrame(frame As Bitmap) Implements IVideoWriter.WriteFrame
        If _path Is Nothing Then Throw New Exception("Writer is closed")
        Dim name = Now.Ticks.ToString("0000000000000000000") + ".jpg"
        _jpegSaver.Save(IO.Path.Combine(_path, name), frame)
        _frames += 1
        _lastFrames += 1
        RaiseEvent FrameWritten(Me, frame)
    End Sub

    Public ReadOnly Property FramesWritten As Integer Implements IVideoWriter.FramesWritten
        Get
            Return _frames
        End Get
    End Property

    Public ReadOnly Property FrameWriteRate As Single Implements IVideoWriter.FrameWriteRate
        Get
            If (Now - _lastTime).TotalSeconds > 3.0 Then
                _lastTime = Now
                _lastFPS = _lastFrames / 3.0
                _lastFrames = 0
            End If
            Return _lastFPS
        End Get
    End Property

    Public Property Address As String = "" Implements IVideoWriter.Address

    Public Property Parameters As String = "" Implements IVideoWriter.Parameters

    Public Event FrameWritten(source As IVideoWriter, frame As Bitmap) Implements IVideoWriter.FrameWritten
End Class
