<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoCaptureTool
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoCaptureTool))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbRecords = New System.Windows.Forms.ListBox()
        Me.lbRecordStates = New System.Windows.Forms.ListBox()
        Me.lRecordState = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbRecording = New System.Windows.Forms.CheckBox()
        Me.tbRecordingPath = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbSourceStates = New System.Windows.Forms.ListBox()
        Me.cbSourceOpen = New System.Windows.Forms.CheckBox()
        Me.cbPauseDisplay = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bOpenFrameInEditor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbZoom = New System.Windows.Forms.TrackBar()
        Me.stateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pbFrame = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tbZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbRecords)
        Me.GroupBox1.Controls.Add(Me.lbRecordStates)
        Me.GroupBox1.Controls.Add(Me.lRecordState)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbRecording)
        Me.GroupBox1.Controls.Add(Me.tbRecordingPath)
        Me.GroupBox1.Location = New System.Drawing.Point(627, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 374)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Запись"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Список записей:"
        '
        'lbRecords
        '
        Me.lbRecords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbRecords.FormattingEnabled = True
        Me.lbRecords.Location = New System.Drawing.Point(6, 232)
        Me.lbRecords.Name = "lbRecords"
        Me.lbRecords.Size = New System.Drawing.Size(248, 134)
        Me.lbRecords.TabIndex = 5
        '
        'lbRecordStates
        '
        Me.lbRecordStates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbRecordStates.FormattingEnabled = True
        Me.lbRecordStates.Location = New System.Drawing.Point(6, 131)
        Me.lbRecordStates.Name = "lbRecordStates"
        Me.lbRecordStates.Size = New System.Drawing.Size(248, 82)
        Me.lbRecordStates.TabIndex = 4
        '
        'lRecordState
        '
        Me.lRecordState.AutoSize = True
        Me.lRecordState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lRecordState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lRecordState.Location = New System.Drawing.Point(6, 61)
        Me.lRecordState.Name = "lRecordState"
        Me.lRecordState.Size = New System.Drawing.Size(166, 24)
        Me.lRecordState.TabIndex = 3
        Me.lRecordState.Text = "Запись не идет"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Текущая папка с кадрами:"
        '
        'cbRecording
        '
        Me.cbRecording.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRecording.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbRecording.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbRecording.Location = New System.Drawing.Point(6, 20)
        Me.cbRecording.Name = "cbRecording"
        Me.cbRecording.Size = New System.Drawing.Size(248, 27)
        Me.cbRecording.TabIndex = 1
        Me.cbRecording.Text = "Вести запись (R)"
        Me.cbRecording.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbRecording.UseVisualStyleBackColor = True
        '
        'tbRecordingPath
        '
        Me.tbRecordingPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRecordingPath.Location = New System.Drawing.Point(6, 105)
        Me.tbRecordingPath.Name = "tbRecordingPath"
        Me.tbRecordingPath.Size = New System.Drawing.Size(248, 20)
        Me.tbRecordingPath.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbSourceStates)
        Me.GroupBox2.Controls.Add(Me.cbSourceOpen)
        Me.GroupBox2.Location = New System.Drawing.Point(627, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 140)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Источник видео"
        '
        'lbSourceStates
        '
        Me.lbSourceStates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSourceStates.FormattingEnabled = True
        Me.lbSourceStates.Location = New System.Drawing.Point(6, 52)
        Me.lbSourceStates.Name = "lbSourceStates"
        Me.lbSourceStates.Size = New System.Drawing.Size(248, 82)
        Me.lbSourceStates.TabIndex = 2
        '
        'cbSourceOpen
        '
        Me.cbSourceOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSourceOpen.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbSourceOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbSourceOpen.Location = New System.Drawing.Point(6, 19)
        Me.cbSourceOpen.Name = "cbSourceOpen"
        Me.cbSourceOpen.Size = New System.Drawing.Size(248, 27)
        Me.cbSourceOpen.TabIndex = 1
        Me.cbSourceOpen.Text = "Включить видеоисточник (O)"
        Me.cbSourceOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbSourceOpen.UseVisualStyleBackColor = True
        '
        'cbPauseDisplay
        '
        Me.cbPauseDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPauseDisplay.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbPauseDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cbPauseDisplay.Location = New System.Drawing.Point(6, 19)
        Me.cbPauseDisplay.Name = "cbPauseDisplay"
        Me.cbPauseDisplay.Size = New System.Drawing.Size(248, 27)
        Me.cbPauseDisplay.TabIndex = 3
        Me.cbPauseDisplay.Text = "Пауза отображения (Space)"
        Me.cbPauseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbPauseDisplay.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.bOpenFrameInEditor)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbZoom)
        Me.GroupBox3.Controls.Add(Me.cbPauseDisplay)
        Me.GroupBox3.Location = New System.Drawing.Point(627, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 140)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Отображение"
        '
        'bOpenFrameInEditor
        '
        Me.bOpenFrameInEditor.Location = New System.Drawing.Point(6, 83)
        Me.bOpenFrameInEditor.Name = "bOpenFrameInEditor"
        Me.bOpenFrameInEditor.Size = New System.Drawing.Size(248, 23)
        Me.bOpenFrameInEditor.TabIndex = 6
        Me.bOpenFrameInEditor.Text = "Открыть кадр в редакторе (E)"
        Me.bOpenFrameInEditor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Увеличение:"
        '
        'tbZoom
        '
        Me.tbZoom.Location = New System.Drawing.Point(91, 49)
        Me.tbZoom.Minimum = 1
        Me.tbZoom.Name = "tbZoom"
        Me.tbZoom.Size = New System.Drawing.Size(163, 45)
        Me.tbZoom.TabIndex = 4
        Me.tbZoom.Value = 1
        '
        'stateTimer
        '
        Me.stateTimer.Enabled = True
        Me.stateTimer.Interval = 1000
        '
        'pbFrame
        '
        Me.pbFrame.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbFrame.BackColor = System.Drawing.Color.White
        Me.pbFrame.Location = New System.Drawing.Point(12, 12)
        Me.pbFrame.Name = "pbFrame"
        Me.pbFrame.Size = New System.Drawing.Size(602, 666)
        Me.pbFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFrame.TabIndex = 5
        Me.pbFrame.TabStop = False
        '
        'VideoCaptureTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 690)
        Me.Controls.Add(Me.pbFrame)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "VideoCaptureTool"
        Me.Text = "Video Capture Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tbZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbRecording As CheckBox
    Friend WithEvents tbRecordingPath As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbSourceStates As ListBox
    Friend WithEvents cbSourceOpen As CheckBox
    Friend WithEvents cbPauseDisplay As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbZoom As TrackBar
    Friend WithEvents bOpenFrameInEditor As Button
    Friend WithEvents lRecordState As Label
    Friend WithEvents stateTimer As Timer
    Friend WithEvents lbRecordStates As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbRecords As ListBox
    Friend WithEvents pbFrame As PictureBox
End Class
