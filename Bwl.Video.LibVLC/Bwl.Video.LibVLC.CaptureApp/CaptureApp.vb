Imports Bwl.Framework
Imports Bwl.Video

Public Class CaptureApp
    Inherits FormAppBase
    Private _captureAddress As New StringSetting(AppBase.RootStorage, "CaptureAddress", "")
    Private _captureParameters As New StringSetting(AppBase.RootStorage, "CaptureParameters", "")

    Private _writerPath As New StringSetting(AppBase.RootStorage, "FrameWriterPath", "video0")

    Private _capture As New VlcVideoSource("0")
    Private _writer As FolderWriter

    Private _ct As VideoCaptureTestTool
    Private _wt As VideoWriterTestTool

    Private Sub CaptureApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SettingField1.AssignedSetting = _captureAddress
        SettingField2.AssignedSetting = _captureParameters

        SettingField3.AssignedSetting = _writerPath
        AddHandler _capture.FrameCaptured, AddressOf Captured
    End Sub

    Private Sub Captured(source As IVideoCapture)
        If _writer IsNot Nothing Then
            Try
                Dim Bitmap = _capture.GetBitmap()
                _writer.WriteFrame(Bitmap)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            _capture.Address = _captureAddress.Value
            _capture.Parameters = _captureParameters.Value
            _capture.Open()
            _ct = VideoCaptureTestTool.Create(_capture)
            _ct.Show()
        Else
            _ct.Close()
            _ct = Nothing
            _capture.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            _writer = New FolderWriter(AppBase.DataFolder + "\" + _writerPath.Value)
            _wt = VideoWriterTestTool.Create(_writer)
            _wt.Show()

        Else
            _wt.Close()
            _wt = Nothing
            _writer.Close()
            _writer = Nothing
        End If
    End Sub
End Class
