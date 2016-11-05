<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form401
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form401))
        Me.la7 = New System.Windows.Forms.Label
        Me.la6 = New System.Windows.Forms.Label
        Me.la5 = New System.Windows.Forms.Label
        Me.la4 = New System.Windows.Forms.Label
        Me.la3 = New System.Windows.Forms.Label
        Me.la2 = New System.Windows.Forms.Label
        Me.la1 = New System.Windows.Forms.Label
        Me.cmb = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dn = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.b3 = New System.Windows.Forms.Button
        Me.b2 = New System.Windows.Forms.Button
        Me.b1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ti1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'la7
        '
        Me.la7.AutoSize = True
        Me.la7.Location = New System.Drawing.Point(325, 108)
        Me.la7.Name = "la7"
        Me.la7.Size = New System.Drawing.Size(0, 12)
        Me.la7.TabIndex = 25
        '
        'la6
        '
        Me.la6.AutoSize = True
        Me.la6.Location = New System.Drawing.Point(155, 109)
        Me.la6.Name = "la6"
        Me.la6.Size = New System.Drawing.Size(0, 12)
        Me.la6.TabIndex = 24
        '
        'la5
        '
        Me.la5.AutoSize = True
        Me.la5.Location = New System.Drawing.Point(225, 114)
        Me.la5.Name = "la5"
        Me.la5.Size = New System.Drawing.Size(0, 12)
        Me.la5.TabIndex = 23
        '
        'la4
        '
        Me.la4.AutoSize = True
        Me.la4.Location = New System.Drawing.Point(225, 147)
        Me.la4.Name = "la4"
        Me.la4.Size = New System.Drawing.Size(0, 12)
        Me.la4.TabIndex = 22
        '
        'la3
        '
        Me.la3.AutoSize = True
        Me.la3.Location = New System.Drawing.Point(225, 189)
        Me.la3.Name = "la3"
        Me.la3.Size = New System.Drawing.Size(0, 12)
        Me.la3.TabIndex = 21
        '
        'la2
        '
        Me.la2.AutoSize = True
        Me.la2.Location = New System.Drawing.Point(323, 77)
        Me.la2.Name = "la2"
        Me.la2.Size = New System.Drawing.Size(0, 12)
        Me.la2.TabIndex = 20
        '
        'la1
        '
        Me.la1.AutoSize = True
        Me.la1.Location = New System.Drawing.Point(153, 77)
        Me.la1.Name = "la1"
        Me.la1.Size = New System.Drawing.Size(0, 12)
        Me.la1.TabIndex = 19
        '
        'cmb
        '
        Me.cmb.FormattingEnabled = True
        Me.cmb.Items.AddRange(New Object() {"一局一胜", "三局两胜", "五局三胜", "十一局六胜"})
        Me.cmb.Location = New System.Drawing.Point(191, 12)
        Me.cmb.Name = "cmb"
        Me.cmb.Size = New System.Drawing.Size(121, 20)
        Me.cmb.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dn)
        Me.GroupBox2.Location = New System.Drawing.Point(373, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 219)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "电脑"
        '
        'dn
        '
        Me.dn.AutoSize = True
        Me.dn.Location = New System.Drawing.Point(28, 108)
        Me.dn.Name = "dn"
        Me.dn.Size = New System.Drawing.Size(0, 12)
        Me.dn.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.b3)
        Me.GroupBox1.Controls.Add(Me.b2)
        Me.GroupBox1.Controls.Add(Me.b1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 219)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "玩家"
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(22, 172)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(75, 23)
        Me.b3.TabIndex = 2
        Me.b3.Text = "出布"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(22, 97)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(75, 23)
        Me.b2.TabIndex = 1
        Me.b2.Text = "出剪刀"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(22, 34)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(75, 23)
        Me.b1.TabIndex = 0
        Me.b1.Text = "出石头"
        Me.b1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(403, 254)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "退出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "结束"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "开始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ti1
        '
        Me.ti1.Interval = 1000
        '
        'Form401
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 303)
        Me.Controls.Add(Me.la7)
        Me.Controls.Add(Me.la6)
        Me.Controls.Add(Me.la5)
        Me.Controls.Add(Me.la4)
        Me.Controls.Add(Me.la3)
        Me.Controls.Add(Me.la2)
        Me.Controls.Add(Me.la1)
        Me.Controls.Add(Me.cmb)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form401"
        Me.Text = "猜拳游戏"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents la7 As System.Windows.Forms.Label
    Friend WithEvents la6 As System.Windows.Forms.Label
    Friend WithEvents la5 As System.Windows.Forms.Label
    Friend WithEvents la4 As System.Windows.Forms.Label
    Friend WithEvents la3 As System.Windows.Forms.Label
    Friend WithEvents la2 As System.Windows.Forms.Label
    Friend WithEvents la1 As System.Windows.Forms.Label
    Friend WithEvents cmb As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dn As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents b3 As System.Windows.Forms.Button
    Friend WithEvents b2 As System.Windows.Forms.Button
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ti1 As System.Windows.Forms.Timer
End Class
