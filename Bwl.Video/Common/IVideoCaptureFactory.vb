Public Interface IVideoCaptureFactory
    ReadOnly Property Name() As String
    ReadOnly Property Description() As String
    ReadOnly Property Version() As String
    Function CreateSource(id As String) As IVideoCapture
End Interface
