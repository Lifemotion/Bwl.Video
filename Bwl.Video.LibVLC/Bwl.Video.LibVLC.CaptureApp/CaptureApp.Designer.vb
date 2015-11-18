<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaptureApp
 

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
        Me.SettingField1 = New Bwl.Framework.SettingField()
        Me.SettingField2 = New Bwl.Framework.SettingField()
        Me.SettingField3 = New Bwl.Framework.SettingField()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Size = New System.Drawing.Size(746, 322)
        '
        'SettingField1
        '
        Me.SettingField1.AssignedSetting = Nothing
        Me.SettingField1.DesignText = Nothing
        Me.SettingField1.Location = New System.Drawing.Point(2, 27)
        Me.SettingField1.Name = "SettingField1"
        Me.SettingField1.Size = New System.Drawing.Size(368, 45)
        Me.SettingField1.TabIndex = 2
        '
        'SettingField2
        '
        Me.SettingField2.AssignedSetting = Nothing
        Me.SettingField2.DesignText = Nothing
        Me.SettingField2.Location = New System.Drawing.Point(376, 27)
        Me.SettingField2.Name = "SettingField2"
        Me.SettingField2.Size = New System.Drawing.Size(368, 45)
        Me.SettingField2.TabIndex = 3
        '
        'SettingField3
        '
        Me.SettingField3.AssignedSetting = Nothing
        Me.SettingField3.DesignText = Nothing
        Me.SettingField3.Location = New System.Drawing.Point(2, 78)
        Me.SettingField3.Name = "SettingField3"
        Me.SettingField3.Size = New System.Drawing.Size(742, 43)
        Me.SettingField3.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 155)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Write"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 132)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Capture"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CaptureApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(749, 561)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.SettingField3)
        Me.Controls.Add(Me.SettingField2)
        Me.Controls.Add(Me.SettingField1)
        Me.Name = "CaptureApp"
        Me.Text = "CaptureApp VLC"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.SettingField1, 0)
        Me.Controls.SetChildIndex(Me.SettingField2, 0)
        Me.Controls.SetChildIndex(Me.SettingField3, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.CheckBox2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SettingField1 As Framework.SettingField
    Friend WithEvents SettingField2 As Framework.SettingField
    Friend WithEvents SettingField3 As Framework.SettingField
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
