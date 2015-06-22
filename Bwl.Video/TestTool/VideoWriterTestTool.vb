Public Class VideoWriterTestTool
    Private WithEvents _writer As IVideoWriter
    Private _id As String
    Private _showFrames As Boolean = False

    Public Sub New(writer As IVideoWriter)
        InitializeComponent()
        _writer = writer
        Text += " " + writer.GetType.ToString
    End Sub

    Public ReadOnly Property VideoWriter As IVideoWriter
        Get
            Return _writer
        End Get
    End Property

    Private Sub stateTimer_Tick(sender As Object, e As EventArgs) Handles stateTimer.Tick
        Dim statesList As String() = {
                                 "CanCapture: " + _
                                 "FrameRate:" + _writer.FrameRate.ToString,
                                 "FrameWriteRate:" + _writer.FrameWriteRate.ToString,
                                 "FramesWritten:" + _writer.FramesWritten.ToString}
        states.Items.Clear()
        states.Items.AddRange(statesList)
        comboboxAddress.Text = _writer.Address
        comboboxParameters.Text = _writer.Parameters
    End Sub

    Public Shared Function Create(writer As IVideoWriter) As VideoWriterTestTool
        Dim tt As New VideoWriterTestTool(writer)
        Return tt
    End Function

    Private Sub comboboxAddress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxAddress.SelectedIndexChanged

    End Sub

    Private Sub VideoWriterTestTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub _writer_FrameWritten(source As IVideoWriter, frame As Bitmap) Handles _writer.FrameWritten

        If _showFrames Then Me.Invoke(Sub()
                                          pictureboxFrameView.Image = frame
                                          pictureboxFrameView.Refresh()
                                      End Sub)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxShowFrames.CheckedChanged
        _showFrames = checkboxShowFrames.Checked
        pictureboxFrameView.Image = Nothing
        pictureboxFrameView.Refresh()
    End Sub
End Class