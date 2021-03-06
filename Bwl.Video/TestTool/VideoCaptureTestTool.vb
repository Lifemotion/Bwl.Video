﻿Imports System.Threading

Public Class VideoCaptureTestTool
    Private _source As IVideoCapture
    Private _id As String

    Public Sub New(capture As IVideoCapture)
        InitializeComponent()
        _source = capture
        Text += " " + capture.GetType.ToString + " " + capture.ID
    End Sub

    Public ReadOnly Property VideoSource As IVideoCapture
        Get
            Return _source
        End Get
    End Property

    Private Sub VideoSourceWindow_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            _source.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Delegate Sub TryThisDelegate()
    Public Sub TryThis(d As TryThisDelegate)
        Try
            d()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub bInternalParams_Click(sender As Object, e As EventArgs) Handles bInternalParams.Click
        _source.ShowSettings()
    End Sub

    Private Sub bStart_Click(sender As Object, e As EventArgs) Handles bStart.Click
        TryThis(Sub()
                    _source.Address = comboboxAddress.Text
                    _source.Parameters = comboboxParameters.Text
                    _source.Open()
                End Sub)
    End Sub

    Private Sub bStop_Click(sender As Object, e As EventArgs) Handles bStop.Click
        TryThis(Sub()
                    playCheckBox.Checked = False : Application.DoEvents()
                    _source.Close()
                End Sub)
    End Sub

    Private Sub bSnap_Click(sender As Object, e As EventArgs) Handles bSnap.Click
        TryThis(Sub()
                    _source.Capture()
                    pictureboxFrameView.Image = _source.GetBitmapCopy
                    pictureboxFrameView.Refresh()
                End Sub)
    End Sub

    Private Sub VideoSourceWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Shared Function Create(capture As IVideoCapture) As VideoCaptureTestTool
        Dim tt As New VideoCaptureTestTool(capture)
        Return tt
    End Function

    Private Sub stateTimer_Tick(sender As Object, e As EventArgs) Handles stateTimer.Tick
        Static lastAddress As String
        Static lastParameters As String
        If lastAddress <> _source.Address Then
            comboboxAddress.Text = _source.Address
            lastAddress = _source.Address
        End If
        If lastParameters <> _source.Parameters Then
            comboboxParameters.Text = _source.Parameters
            lastParameters = _source.Parameters
        End If
        Dim statesList As String() = {"CanCapture: " + _source.CanCapture.ToString,
                                  "Working:" + _source.IsWorking.ToString,
                                  "ID:" + _source.ID.ToString,
                                  "MaxFrameRate:" + _source.MaxFrameRate.ToString,
                                  "FrameNumber:" + _source.FrameNumber.ToString,
                                  "MaxFrameNumber:" + _source.MaxFrameNumber.ToString,
                                  "CaptureTime:" + _source.CaptureTime.ToShortDateString,
                                  "CaptureTime:" + _source.CaptureTime.ToLongTimeString}
        states.Items.Clear()
        states.Items.AddRange(statesList)
    End Sub

    Private Function TestFrameRate(source As IVideoCapture, timelimit As Single, picturebox As PictureBox) As Single
        Dim count As Integer
        Dim time = Now
        Do While (Now - time).TotalSeconds < timelimit And source.IsWorking
            Do While source.CanCapture = False
                Threading.Thread.Sleep(1)
            Loop
            source.Capture()
            If picturebox IsNot Nothing Then
                SyncLock _source.SyncObject
                    picturebox.Image = _source.GetBitmap
                    picturebox.Refresh()
                    'Application.DoEvents 
                End SyncLock
            End If
            count += 1
        Loop
        Dim secs = (Now - time).TotalSeconds
        Dim fps = count / secs
        Return fps
    End Function

    Private Function Play(source As IVideoCapture, picturebox As PictureBox) As Single
        Dim count As Integer
        Dim sleepTime = 1000 / fpsNumericUpDown.Value
        Dim time = Now
        Do While playCheckBox.Checked
            Do While source.IsWorking AndAlso source.CanCapture = False
                Threading.Thread.Sleep(1)
            Loop
            If source.CanCapture Then
                source.Capture()
                If picturebox IsNot Nothing Then
                    SyncLock _source.SyncObject
                        picturebox.Image = _source.GetBitmap
                        picturebox.Refresh()
                        Application.DoEvents()
                        Thread.Sleep(sleepTime)
                    End SyncLock
                End If
                count += 1
            End If
        Loop
        Dim secs = (Now - time).TotalSeconds
        Dim fps = count / secs
        Return fps
    End Function

    Private Sub buttonTestFramerate_Click(sender As Object, e As EventArgs) Handles buttonTestFramerate.Click
        Dim fps = TestFrameRate(_source, 2, Nothing)
        MsgBox("FPS: " + fps.ToString("0.0"))
    End Sub

    Private Sub buttonTestFramerateWithOutput_Click(sender As Object, e As EventArgs) Handles buttonTestFramerateWithOutput.Click
        Dim fps = TestFrameRate(_source, 2, pictureboxFrameView)
        MsgBox("FPS: " + fps.ToString("0.0"))
    End Sub

    Private Sub playCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles playCheckBox.CheckedChanged
        If playCheckBox.Checked Then
            bStart_Click(sender, e)
            Dim fps = Play(_source, pictureboxFrameView)
            MsgBox("FPS: " + fps.ToString("0.0"))
        End If
    End Sub
End Class