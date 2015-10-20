Public Interface IVideoCaptureSimple
    Event FrameCaptured(from As IVideoCapture, frame As Bitmap)
    Function CaptureFrame() As Bitmap
    ReadOnly Property ControlWindow As VideoCaptureTestTool
    ReadOnly Property Source As IVideoCapture
    Property Started As Boolean
End Interface