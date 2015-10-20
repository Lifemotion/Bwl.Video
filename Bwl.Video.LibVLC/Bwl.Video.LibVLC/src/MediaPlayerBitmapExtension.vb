Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices
Imports LibVLC.NET

Public Module MediaPlayerBitmapExtension
    <Extension()>
    Public Function GetBitmap(player As MediaPlayer)
        If player.VideoBuffer Is Nothing Then Return Nothing
        If player.VideoBuffer.FrameBuffer Is Nothing Then Return Nothing

        Try
            Dim bytes = player.VideoBuffer.FrameBuffer
            Dim tmpBitmap As New Bitmap(player.VideoBuffer.Width, player.VideoBuffer.Height, Imaging.PixelFormat.Format32bppRgb)
            Dim tmpBD As BitmapData
            Dim tmpRect = Rectangle.FromLTRB(0, 0, tmpBitmap.Width, tmpBitmap.Height)
            tmpBD = tmpBitmap.LockBits(tmpRect, ImageLockMode.ReadWrite, tmpBitmap.PixelFormat)
            System.Runtime.InteropServices.Marshal.Copy(bytes, 0, tmpBD.Scan0, bytes.Length)
            tmpBitmap.UnlockBits(tmpBD)

            Return tmpBitmap
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Module