<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form301
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form301))
        Me.la = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rr2 = New System.Windows.Forms.RadioButton()
        Me.rr1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.s1 = New System.Windows.Forms.TextBox()
        Me.Ti1 = New System.Windows.Forms.Timer(Me.components)
        Me.ti2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(12, 9)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(89, 12)
        Me.la.TabIndex = 13
        Me.la.Text = "设置时间（秒）"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "退出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "停止"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rr2
        '
        Me.rr2.AutoSize = True
        Me.rr2.Location = New System.Drawing.Point(139, 56)
        Me.rr2.Name = "rr2"
        Me.rr2.Size = New System.Drawing.Size(71, 16)
        Me.rr2.TabIndex = 10
        Me.rr2.Text = "计时模式"
        Me.rr2.UseVisualStyleBackColor = True
        '
        'rr1
        '
        Me.rr1.AutoSize = True
        Me.rr1.Checked = True
        Me.rr1.Location = New System.Drawing.Point(139, 34)
        Me.rr1.Name = "rr1"
        Me.rr1.Size = New System.Drawing.Size(83, 16)
        Me.rr1.TabIndex = 9
        Me.rr1.TabStop = True
        Me.rr1.Text = "倒计时模式"
        Me.rr1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "开始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        's1
        '
        Me.s1.Location = New System.Drawing.Point(5, 34)
        Me.s1.MaxLength = 100000
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(100, 21)
        Me.s1.TabIndex = 7
        '
        'Ti1
        '
        Me.Ti1.Interval = 1000
        '
        'ti2
        '
        Me.ti2.Interval = 1000
        '
        'Form301
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 191)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.rr2)
        Me.Controls.Add(Me.rr1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.s1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form301"
        Me.Text = "计时器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents la As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rr2 As System.Windows.Forms.RadioButton
    Friend WithEvents rr1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents s1 As System.Windows.Forms.TextBox
    Friend WithEvents Ti1 As System.Windows.Forms.Timer
    Friend WithEvents ti2 As System.Windows.Forms.Timer
End Class
