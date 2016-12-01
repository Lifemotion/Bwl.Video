Imports System.IO

Public Class VideoCaptureTool
    Private _videoSource As IVideoCaptureSimple

    Private _folderWriter As FolderWriter = Nothing
    Private _writePath As String = ""
    Private _writeName As String = ""
    Private _dataPath As String = ""
    Private _tempPath As String = ""
    Private _framesCounter As Integer = 0
    Private _numberFrame As New Rectangle
    Private _frameGraphics As Graphics

    Public Sub New(videoSource As IVideoCaptureSimple, dataPath As String)
        _videoSource = videoSource
        Me.InitializeComponent()
        _dataPath = dataPath
        _tempPath = Path.Combine(_dataPath, "temp")
        Try
            MkDir(_tempPath)
        Catch ex As Exception
        End Try
        AddHandler _videoSource.FrameCaptured, AddressOf FrameCapturedHandler
        _frameGraphics = pbFrame.CreateGraphics()
    End Sub

    Private Sub FrameCapturedHandler(from As IVideoCapture, frame As Bitmap)
        SyncLock pbFrame
            'Capture
            If frame IsNot Nothing And Not cbPauseDisplay.Checked Then
                _framesCounter += 1
                If _folderWriter IsNot Nothing Then _folderWriter.WriteFrame(frame)

                If _numberFrame.Width > 0 Then
                End If

                Dim correctionX = frame.Width / pbFrame.Width
                Dim correctionY = frame.Height / pbFrame.Height
                Dim frameGraphics = Graphics.FromImage(frame)
                Dim correctedNumberFrame = New Rectangle(_numberFrame.Left * correctionX, _numberFrame.Top * correctionY, _numberFrame.Width, _numberFrame.Height)
                frameGraphics.DrawRectangle(Pens.Lime, correctedNumberFrame)

                'Zoom Area
                Dim zoom = tbZoom.Value
                Dim centerX = frame.Width / 2
                Dim centerY = frame.Height / 2
                Dim focusAreaWidth = frame.Width / zoom
                Dim focusAreaHeight = frame.Height / zoom
                Dim X = centerX - focusAreaWidth / 2
                Dim Y = centerY - focusAreaWidth / 2

                Dim zoomArea = New Rectangle(X, Y, focusAreaWidth, focusAreaHeight)
                If zoom > 1 Then
                    If Not My.Computer.Keyboard.ShiftKeyDown Then

                        Dim bmp As New Bitmap(zoomArea.Width, zoomArea.Height)
                        Dim g As Graphics = Graphics.FromImage(bmp)
                        g.DrawImage(frame, 0, 0, zoomArea, GraphicsUnit.Pixel)
                        pbFrame.Image = bmp
                    Else
                        frameGraphics.DrawRectangle(Pens.Red, zoomArea)
                        pbFrame.Image = frame
                    End If
                Else
                    pbFrame.Image = frame
                End If
            End If
        End SyncLock
    End Sub

    Private Sub GetCapturedFrameAndOut()

    End Sub

    Private Sub OpenCurrentWritePath() Handles tbRecordingPath.DoubleClick
        Shell("explorer " + _writePath, AppWinStyle.NormalFocus, False)
    End Sub

    Private Sub recCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles cbRecording.CheckedChanged
        If cbRecording.Checked Then
            If _folderWriter Is Nothing Then
                Dim time = Now
                _writeName = time.ToString("dd.MM.yyyy_HH.mm.ss.f")
                _writePath = Path.Combine(_dataPath, _writeName)
                tbRecordingPath.Text = _writePath
                Directory.CreateDirectory(_writePath)
                _folderWriter = New FolderWriter(_writePath, 90)
                lbRecords.Items.Insert(0, _writeName)
            End If
        Else
            If _folderWriter IsNot Nothing Then _folderWriter.Close()
            _folderWriter = Nothing
        End If
    End Sub

    Private Sub pbFrame_DoubleClick(sender As Object, e As EventArgs) Handles bOpenFrameInEditor.Click
        Dim bitmap As Bitmap = pbFrame.Image
        If bitmap IsNot Nothing Then
            Dim file = Path.Combine(_tempPath, Now.Ticks.ToString + ".bmp")
            bitmap.Save(file)
            Shell("mspaint """ + file + """", AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub stateTimer_Tick(sender As Object, e As EventArgs) Handles stateTimer.Tick
        If _videoSource.Started Then
            cbSourceOpen.Checked = True
            lbSourceStates.Items.Clear()
            lbSourceStates.Items.Add("Видеоисточник работает")
            lbSourceStates.Items.Add("Кадров: " + _framesCounter.ToString)

        Else
            lbSourceStates.Items.Add("Видеоисточник закрыт")
            cbSourceOpen.Checked = False
            lbSourceStates.Items.Clear()
        End If

        If _folderWriter Is Nothing Then
            lbRecordStates.Items.Clear()
            lbRecordStates.Items.Add("Запись отключена")
            lRecordState.Text = "Запись отключена"
            lRecordState.ForeColor = Color.DarkGray
        Else
            lbRecordStates.Items.Clear()
            lbRecordStates.Items.Add("Запись включена")
            lbRecordStates.Items.Add("Кадров записано: " + _folderWriter.FramesWritten.ToString)
            lbRecordStates.Items.Add("Частота кадров: " + _folderWriter.FrameWriteRate.ToString)
            lbRecordStates.Items.Add("Параметры: " + _folderWriter.Parameters)
            Static lastFrames As Integer
            If lastFrames <> _folderWriter.FramesWritten Then
                lbRecords.Items(0) = _writeName + ", " + _folderWriter.FramesWritten.ToString
                lRecordState.Text = "Запись идет: " + _folderWriter.FramesWritten.ToString
                lRecordState.ForeColor = Color.DarkGreen
            Else
                lRecordState.Text = "Запись не работает!"
                lRecordState.ForeColor = Color.Red
            End If
            lastFrames = _folderWriter.FramesWritten

        End If
    End Sub

    Private Sub VideoCaptureTool_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.R Then cbRecording.Checked = Not cbRecording.Checked
        If e.KeyCode = Keys.Space Then cbPauseDisplay.Checked = Not cbPauseDisplay.Checked
        If e.KeyCode = Keys.O Then cbSourceOpen.Checked = Not cbPauseDisplay.Checked
        If e.KeyCode = Keys.E Then pbFrame_DoubleClick(Nothing, Nothing)
    End Sub

    Private Sub lbRecords_DoubleClick(sender As Object, e As EventArgs) Handles lbRecords.DoubleClick
        Dim text = lbRecords.Text.Split(",")(0).Trim
        If text > "" Then
            Dim folder = Path.Combine(_dataPath, text)
            Shell("explorer """ + folder + """", AppWinStyle.NormalFocus, False)
        End If
    End Sub

    Private Sub VideoCaptureTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pbFrame.MouseDown, pbFrame.MouseMove
        If e.Button = MouseButtons.Left Then _numberFrame = New Rectangle(e.Location, New Size(100, 22))
    End Sub

    Private Sub VideoCaptureTool_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveHandler _videoSource.FrameCaptured, AddressOf FrameCapturedHandler
    End Sub
End Class