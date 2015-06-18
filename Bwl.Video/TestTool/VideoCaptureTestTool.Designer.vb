<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoCaptureTestTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoCaptureTestTool))
        Me.pictureboxFrameView = New System.Windows.Forms.PictureBox()
        Me.bStart = New System.Windows.Forms.Button()
        Me.bStop = New System.Windows.Forms.Button()
        Me.bInternalParams = New System.Windows.Forms.Button()
        Me.bSnap = New System.Windows.Forms.Button()
        Me.comboboxAddress = New System.Windows.Forms.ComboBox()
        Me.buttonTestFramerate = New System.Windows.Forms.Button()
        Me.comboboxParameters = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.states = New System.Windows.Forms.ListBox()
        Me.stateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.buttonTestFramerateWithOutput = New System.Windows.Forms.Button()
        CType(Me.pictureboxFrameView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureboxFrameView
        '
        Me.pictureboxFrameView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureboxFrameView.BackColor = System.Drawing.Color.Black
        Me.pictureboxFrameView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxFrameView.Location = New System.Drawing.Point(139, 69)
        Me.pictureboxFrameView.Name = "pictureboxFrameView"
        Me.pictureboxFrameView.Size = New System.Drawing.Size(431, 360)
        Me.pictureboxFrameView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxFrameView.TabIndex = 0
        Me.pictureboxFrameView.TabStop = False
        '
        'bStart
        '
        Me.bStart.Location = New System.Drawing.Point(6, 69)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(127, 30)
        Me.bStart.TabIndex = 2
        Me.bStart.Text = "Старт"
        Me.bStart.UseVisualStyleBackColor = True
        '
        'bStop
        '
        Me.bStop.Location = New System.Drawing.Point(6, 105)
        Me.bStop.Name = "bStop"
        Me.bStop.Size = New System.Drawing.Size(127, 30)
        Me.bStop.TabIndex = 3
        Me.bStop.Text = "Стоп"
        Me.bStop.UseVisualStyleBackColor = True
        '
        'bInternalParams
        '
        Me.bInternalParams.Location = New System.Drawing.Point(6, 177)
        Me.bInternalParams.Name = "bInternalParams"
        Me.bInternalParams.Size = New System.Drawing.Size(127, 30)
        Me.bInternalParams.TabIndex = 4
        Me.bInternalParams.Text = "Настройки"
        Me.bInternalParams.UseVisualStyleBackColor = True
        '
        'bSnap
        '
        Me.bSnap.Location = New System.Drawing.Point(6, 141)
        Me.bSnap.Name = "bSnap"
        Me.bSnap.Size = New System.Drawing.Size(127, 30)
        Me.bSnap.TabIndex = 6
        Me.bSnap.Text = "Снять кадр"
        Me.bSnap.UseVisualStyleBackColor = True
        '
        'comboboxAddress
        '
        Me.comboboxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxAddress.FormattingEnabled = True
        Me.comboboxAddress.Location = New System.Drawing.Point(139, 12)
        Me.comboboxAddress.Name = "comboboxAddress"
        Me.comboboxAddress.Size = New System.Drawing.Size(431, 21)
        Me.comboboxAddress.TabIndex = 7
        '
        'buttonTestFramerate
        '
        Me.buttonTestFramerate.Location = New System.Drawing.Point(6, 329)
        Me.buttonTestFramerate.Name = "buttonTestFramerate"
        Me.buttonTestFramerate.Size = New System.Drawing.Size(127, 47)
        Me.buttonTestFramerate.TabIndex = 8
        Me.buttonTestFramerate.Text = "Тест частоты кадров"
        Me.buttonTestFramerate.UseVisualStyleBackColor = True
        '
        'comboboxParameters
        '
        Me.comboboxParameters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxParameters.FormattingEnabled = True
        Me.comboboxParameters.Location = New System.Drawing.Point(139, 42)
        Me.comboboxParameters.Name = "comboboxParameters"
        Me.comboboxParameters.Size = New System.Drawing.Size(431, 21)
        Me.comboboxParameters.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Адрес"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Параметры"
        '
        'states
        '
        Me.states.FormattingEnabled = True
        Me.states.Location = New System.Drawing.Point(6, 213)
        Me.states.Name = "states"
        Me.states.Size = New System.Drawing.Size(127, 95)
        Me.states.TabIndex = 12
        '
        'stateTimer
        '
        Me.stateTimer.Enabled = True
        Me.stateTimer.Interval = 500
        '
        'buttonTestFramerateWithOutput
        '
        Me.buttonTestFramerateWithOutput.Location = New System.Drawing.Point(6, 382)
        Me.buttonTestFramerateWithOutput.Name = "buttonTestFramerateWithOutput"
        Me.buttonTestFramerateWithOutput.Size = New System.Drawing.Size(127, 47)
        Me.buttonTestFramerateWithOutput.TabIndex = 13
        Me.buttonTestFramerateWithOutput.Text = "Тест частоты кадров c отображением"
        Me.buttonTestFramerateWithOutput.UseVisualStyleBackColor = True
        '
        'VideoSourceWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 434)
        Me.Controls.Add(Me.buttonTestFramerateWithOutput)
        Me.Controls.Add(Me.states)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboboxParameters)
        Me.Controls.Add(Me.buttonTestFramerate)
        Me.Controls.Add(Me.comboboxAddress)
        Me.Controls.Add(Me.bSnap)
        Me.Controls.Add(Me.bInternalParams)
        Me.Controls.Add(Me.bStop)
        Me.Controls.Add(Me.bStart)
        Me.Controls.Add(Me.pictureboxFrameView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VideoSourceWindow"
        Me.Text = "Тест видеозахвата"
        CType(Me.pictureboxFrameView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictureboxFrameView As System.Windows.Forms.PictureBox
    Friend WithEvents bStart As System.Windows.Forms.Button
    Friend WithEvents bStop As System.Windows.Forms.Button
    Friend WithEvents bInternalParams As System.Windows.Forms.Button
    Friend WithEvents bSnap As System.Windows.Forms.Button
    Friend WithEvents comboboxAddress As System.Windows.Forms.ComboBox
    Friend WithEvents buttonTestFramerate As System.Windows.Forms.Button
    Friend WithEvents comboboxParameters As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents states As System.Windows.Forms.ListBox
    Friend WithEvents stateTimer As System.Windows.Forms.Timer
    Friend WithEvents buttonTestFramerateWithOutput As System.Windows.Forms.Button
End Class
