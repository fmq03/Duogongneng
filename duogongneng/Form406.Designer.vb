<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form406
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
        Me.x1 = New System.Windows.Forms.ComboBox
        Me.p1 = New System.Windows.Forms.Panel
        Me.bbb = New System.Windows.Forms.RadioButton
        Me.aaa = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.x2 = New System.Windows.Forms.TextBox
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'x1
        '
        Me.x1.FormattingEnabled = True
        Me.x1.Items.AddRange(New Object() {"你欠我钱！", "快还钱来！", "没啥事了。"})
        Me.x1.Location = New System.Drawing.Point(57, 16)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(100, 20)
        Me.x1.TabIndex = 17
        '
        'p1
        '
        Me.p1.Controls.Add(Me.bbb)
        Me.p1.Controls.Add(Me.aaa)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Location = New System.Drawing.Point(12, 81)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(198, 82)
        Me.p1.TabIndex = 16
        '
        'bbb
        '
        Me.bbb.AutoSize = True
        Me.bbb.Location = New System.Drawing.Point(98, 48)
        Me.bbb.Name = "bbb"
        Me.bbb.Size = New System.Drawing.Size(47, 16)
        Me.bbb.TabIndex = 9
        Me.bbb.TabStop = True
        Me.bbb.Text = "不是"
        Me.bbb.UseVisualStyleBackColor = True
        '
        'aaa
        '
        Me.aaa.AutoSize = True
        Me.aaa.Location = New System.Drawing.Point(48, 48)
        Me.aaa.Name = "aaa"
        Me.aaa.Size = New System.Drawing.Size(35, 16)
        Me.aaa.TabIndex = 8
        Me.aaa.TabStop = True
        Me.aaa.Text = "是"
        Me.aaa.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "验证问题：  你是帅哥吗？"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "退出"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "登录"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "密码"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "用户名"
        '
        'x2
        '
        Me.x2.Location = New System.Drawing.Point(57, 54)
        Me.x2.Name = "x2"
        Me.x2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.x2.Size = New System.Drawing.Size(100, 21)
        Me.x2.TabIndex = 11
        '
        'Form406
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.x1)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.x2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form406"
        Me.Text = "登录到多功能程序"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents x1 As System.Windows.Forms.ComboBox
    Friend WithEvents p1 As System.Windows.Forms.Panel
    Friend WithEvents bbb As System.Windows.Forms.RadioButton
    Friend WithEvents aaa As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents x2 As System.Windows.Forms.TextBox
End Class
