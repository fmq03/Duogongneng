<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form100
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t5 = New System.Windows.Forms.TextBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.pa1 = New System.Windows.Forms.Panel()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.time1 = New System.Windows.Forms.Timer(Me.components)
        Me.pa1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "设置密码"
        '
        't5
        '
        Me.t5.Enabled = False
        Me.t5.Location = New System.Drawing.Point(7, 266)
        Me.t5.MaxLength = 20
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(161, 21)
        Me.t5.TabIndex = 26
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(7, 244)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(84, 16)
        Me.cb2.TabIndex = 25
        Me.cb2.Text = "自定义标语"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(6, 222)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(108, 16)
        Me.cb1.TabIndex = 24
        Me.cb1.Text = "错误三次后关机"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(7, 200)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(143, 16)
        Me.RadioButton3.TabIndex = 23
        Me.RadioButton3.Text = "定时锁屏（暂不支持）"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'pa1
        '
        Me.pa1.Controls.Add(Me.cb3)
        Me.pa1.Controls.Add(Me.Label4)
        Me.pa1.Controls.Add(Me.t4)
        Me.pa1.Controls.Add(Me.Label3)
        Me.pa1.Controls.Add(Me.t3)
        Me.pa1.Enabled = False
        Me.pa1.Location = New System.Drawing.Point(7, 137)
        Me.pa1.Name = "pa1"
        Me.pa1.Size = New System.Drawing.Size(186, 57)
        Me.pa1.TabIndex = 22
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Checked = True
        Me.cb3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb3.Location = New System.Drawing.Point(3, 36)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(180, 16)
        Me.cb3.TabIndex = 29
        Me.cb3.Text = "在计时后隐藏程序(不再使用)"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "秒后锁"
        '
        't4
        '
        Me.t4.Location = New System.Drawing.Point(81, 9)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(46, 21)
        Me.t4.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "分"
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(6, 9)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(46, 21)
        Me.t3.TabIndex = 12
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 115)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.Text = "稍后锁屏"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 93)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "立即锁屏"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "再次输入"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "解锁密码"
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(68, 56)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(100, 21)
        Me.t2.TabIndex = 17
        Me.t2.UseSystemPasswordChar = True
        Me.t2.WordWrap = False
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(68, 29)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(100, 21)
        Me.t1.TabIndex = 16
        Me.t1.UseSystemPasswordChar = True
        Me.t1.WordWrap = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 293)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'time1
        '
        Me.time1.Interval = 1000
        '
        'Form100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 348)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.t5)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.pa1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form100"
        Me.ShowIcon = False
        Me.Text = "锁屏设置"
        Me.pa1.ResumeLayout(False)
        Me.pa1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents t5 As System.Windows.Forms.TextBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents pa1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents time1 As System.Windows.Forms.Timer
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
End Class
