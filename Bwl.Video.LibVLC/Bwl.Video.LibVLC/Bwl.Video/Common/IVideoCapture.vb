﻿Public Interface IVideoCapture
    Sub Open()
    Sub Close()
    Sub Capture()
    Sub ShowSettings()
    Property Address() As String
    Property Parameters() As String
    Function GetBitmap() As Bitmap
    Function GetBitmapCopy() As Bitmap
    Function GetBitmapCopy(width As Integer, height As Integer) As Bitmap
    ReadOnly Property MaxFrameRate As Integer
    ReadOnly Property MaxFrameNumber As Integer
    ReadOnly Property ID As String
    ReadOnly Property CanCapture As Boolean
    Property FrameNumber As Integer
    ReadOnly Property CaptureTime As DateTime
    ReadOnly Property IsWorking As Boolean
    ReadOnly Property SyncObject As Object
    Event FrameCaptured(source As IVideoCapture)
End Interface
