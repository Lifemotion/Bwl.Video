<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoWriterTestTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoWriterTestTool))
        Me.states = New System.Windows.Forms.ListBox()
        Me.pictureboxFrameView = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboboxAddress = New System.Windows.Forms.ComboBox()
        Me.stateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboboxParameters = New System.Windows.Forms.ComboBox()
        Me.checkboxShowFrames = New System.Windows.Forms.CheckBox()
        CType(Me.pictureboxFrameView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'states
        '
        Me.states.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.states.FormattingEnabled = True
        Me.states.Location = New System.Drawing.Point(3, 64)
        Me.states.Name = "states"
        Me.states.Size = New System.Drawing.Size(185, 290)
        Me.states.TabIndex = 13
        '
        'pictureboxFrameView
        '
        Me.pictureboxFrameView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureboxFrameView.BackColor = System.Drawing.Color.Black
        Me.pictureboxFrameView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxFrameView.Location = New System.Drawing.Point(194, 65)
        Me.pictureboxFrameView.Name = "pictureboxFrameView"
        Me.pictureboxFrameView.Size = New System.Drawing.Size(300, 290)
        Me.pictureboxFrameView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxFrameView.TabIndex = 14
        Me.pictureboxFrameView.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Адрес"
        '
        'comboboxAddress
        '
        Me.comboboxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxAddress.FormattingEnabled = True
        Me.comboboxAddress.Location = New System.Drawing.Point(194, 10)
        Me.comboboxAddress.Name = "comboboxAddress"
        Me.comboboxAddress.Size = New System.Drawing.Size(300, 21)
        Me.comboboxAddress.TabIndex = 15
        '
        'stateTimer
        '
        Me.stateTimer.Enabled = True
        Me.stateTimer.Interval = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Параметры"
        '
        'comboboxParameters
        '
        Me.comboboxParameters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxParameters.FormattingEnabled = True
        Me.comboboxParameters.Location = New System.Drawing.Point(194, 38)
        Me.comboboxParameters.Name = "comboboxParameters"
        Me.comboboxParameters.Size = New System.Drawing.Size(300, 21)
        Me.comboboxParameters.TabIndex = 17
        '
        'CheckBox1
        '
        Me.checkboxShowFrames.AutoSize = True
        Me.checkboxShowFrames.Location = New System.Drawing.Point(99, 41)
        Me.checkboxShowFrames.Name = "CheckBox1"
        Me.checkboxShowFrames.Size = New System.Drawing.Size(89, 17)
        Me.checkboxShowFrames.TabIndex = 19
        Me.checkboxShowFrames.Text = "Показывать"
        Me.checkboxShowFrames.UseVisualStyleBackColor = True
        '
        'VideoWriterTestTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 358)
        Me.Controls.Add(Me.checkboxShowFrames)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboboxParameters)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboboxAddress)
        Me.Controls.Add(Me.pictureboxFrameView)
        Me.Controls.Add(Me.states)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(513, 397)
        Me.Name = "VideoWriterTestTool"
        Me.Text = "Тест записи видео"
        CType(Me.pictureboxFrameView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents states As System.Windows.Forms.ListBox
    Friend WithEvents pictureboxFrameView As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboboxAddress As System.Windows.Forms.ComboBox
    Friend WithEvents stateTimer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboboxParameters As System.Windows.Forms.ComboBox
    Friend WithEvents checkboxShowFrames As System.Windows.Forms.CheckBox
End Class
