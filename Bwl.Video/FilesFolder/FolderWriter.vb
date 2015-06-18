Imports System.Drawing.Imaging

Public Class FolderWriter
    Implements IVideoWriter
    Private _path As String
    Private _jpegSaver As New JpegSaver

    Public Sub New(path As String)
        Me.New(path, 80)
    End Sub

    Public Sub New(path As String, quality As Integer)
        If Not IO.Directory.Exists(path) Then IO.Directory.CreateDirectory(path)
        _path = path
        _jpegSaver.Quality = quality
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
    End Sub
End Class
