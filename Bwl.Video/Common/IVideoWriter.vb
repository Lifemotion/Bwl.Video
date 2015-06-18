Public Interface IVideoWriter
    Sub WriteFrame(frame As Bitmap)
    Sub Close()
    Property FrameRate As Integer
End Interface

