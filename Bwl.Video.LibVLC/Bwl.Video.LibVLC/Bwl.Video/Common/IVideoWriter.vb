Public Interface IVideoWriter
    Sub WriteFrame(frame As Bitmap)
    Sub Close()
    Property FrameRate As Integer
    ReadOnly Property FramesWritten As Integer
    ReadOnly Property FrameWriteRate As Single
    Property Address As String
    Property Parameters As String
    Event FrameWritten(source As IVideoWriter, frame As Bitmap)
End Interface

