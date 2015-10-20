Module App
    Sub main()
        Application.EnableVisualStyles()
        Dim ff As New VlcVideoSource("0")
        ff.Address = "rtsp://media.5.ua:8080/tv/5tv/5tv1"
        VideoCaptureTestTool.Create(ff).Show()
        Application.Run()
    End Sub
End Module
