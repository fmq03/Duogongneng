<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form203
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form203))
        Me.gbs = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.B = New System.Windows.Forms.Label
        Me.A = New System.Windows.Forms.Label
        Me.AB = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bb = New System.Windows.Forms.TextBox
        Me.aa = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'gbs
        '
        Me.gbs.AutoSize = True
        Me.gbs.Location = New System.Drawing.Point(78, 156)
        Me.gbs.Name = "gbs"
        Me.gbs.Size = New System.Drawing.Size(0, 12)
        Me.gbs.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "公倍数："
        '
        'B
        '
        Me.B.AutoSize = True
        Me.B.Location = New System.Drawing.Point(91, 127)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(0, 12)
        Me.B.TabIndex = 27
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Location = New System.Drawing.Point(90, 97)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(0, 12)
        Me.A.TabIndex = 26
        '
        'AB
        '
        Me.AB.AutoSize = True
        Me.AB.Location = New System.Drawing.Point(97, 180)
        Me.AB.Name = "AB"
        Me.AB.Size = New System.Drawing.Size(0, 12)
        Me.AB.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "最小公倍数："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "数2倍数："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "数1倍数："
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(224, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "返回"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(122, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "清除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "计算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 12)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "请输入数字2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "请输入数字1"
        '
        'bb
        '
        Me.bb.Location = New System.Drawing.Point(224, 35)
        Me.bb.Name = "bb"
        Me.bb.Size = New System.Drawing.Size(100, 21)
        Me.bb.TabIndex = 16
        '
        'aa
        '
        Me.aa.Location = New System.Drawing.Point(16, 35)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(100, 21)
        Me.aa.TabIndex = 15
        '
        'Form203
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 256)
        Me.Controls.Add(Me.gbs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.AB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bb)
        Me.Controls.Add(Me.aa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form203"
        Me.Text = "求公倍数及最小"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbs As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents B As System.Windows.Forms.Label
    Friend WithEvents A As System.Windows.Forms.Label
    Friend WithEvents AB As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bb As System.Windows.Forms.TextBox
    Friend WithEvents aa As System.Windows.Forms.TextBox
End Class
