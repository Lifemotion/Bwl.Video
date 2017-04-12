Imports System.Drawing
Imports System.Windows.Forms

Public Class TestApp
    Dim fw As New FolderWriter("Test")
    Private Sub TestApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VideoWriterTestTool.Create(fw).Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ff As New FolderCapture("0")
        ff.MemoryCacheLimit = 1000
        'ff.MemoryCacheUseClone = True
        ff.Address = "example"
        ff.Parameters = "testparam"
        VideoCaptureTestTool.Create(ff).Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fw.WriteFrame(New Bitmap(1024, 600))
        fw.WriteFrame(New Bitmap(1024, 600))
        fw.WriteFrame(New Bitmap(1024, 600))
        fw.WriteFrame(New Bitmap(1024, 600))
    End Sub
End Class