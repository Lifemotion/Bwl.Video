Imports Bwl.Video

Module App
    Sub main()
        Application.EnableVisualStyles()
        Dim ff As New VlcVideoSource("0")
        ff.Address = "rtsp://media.5.ua:8080/tv/5tv/5tv1"
        VideoCaptureTestTool.Create(ff).Show()
        AddHandler ff.FrameCaptured, AddressOf FrameCapturedHandler
        Dim fw As New FolderWriter(AppDomain.CurrentDomain.BaseDirectory + "\..\video\")

        Application.Run()
    End Sub

    Private Sub FrameCapturedHandler(source As IVideoCapture)

    End Sub
End Module
