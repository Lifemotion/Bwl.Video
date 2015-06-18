Imports System.Drawing
Imports System.Windows.Forms

Public Class TestApp

    Private Sub TestApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ff As New FolderCapture("0")
        Dim test As New VideoSourceWindow(ff)
        test.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fw As New FolderWriter("Test")
        fw.WriteFrame(New Bitmap(1024, 600))
        fw.WriteFrame(New Bitmap(1024, 600))
        fw.WriteFrame(New Bitmap(1024, 600))
        fw.WriteFrame(New Bitmap(1024, 600))
        fw.Close()
    End Sub
End Class