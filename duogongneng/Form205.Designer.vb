<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form205
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form205))
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.zts = New System.Windows.Forms.TextBox
        Me.zs = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.nu2 = New System.Windows.Forms.TextBox
        Me.na2 = New System.Windows.Forms.TextBox
        Me.nu1 = New System.Windows.Forms.TextBox
        Me.na1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(343, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "返回"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(182, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "清除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "计算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'zts
        '
        Me.zts.Location = New System.Drawing.Point(456, 70)
        Me.zts.Name = "zts"
        Me.zts.Size = New System.Drawing.Size(100, 21)
        Me.zts.TabIndex = 26
        '
        'zs
        '
        Me.zs.Location = New System.Drawing.Point(76, 70)
        Me.zs.Name = "zs"
        Me.zs.Size = New System.Drawing.Size(100, 21)
        Me.zs.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "总""腿""数"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "总""头""数"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "B物名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "B物""腿""数"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "A物名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "A物""腿""数"
        '
        'nu2
        '
        Me.nu2.Location = New System.Drawing.Point(491, 12)
        Me.nu2.Name = "nu2"
        Me.nu2.Size = New System.Drawing.Size(65, 21)
        Me.nu2.TabIndex = 18
        '
        'na2
        '
        Me.na2.Location = New System.Drawing.Point(343, 12)
        Me.na2.Name = "na2"
        Me.na2.Size = New System.Drawing.Size(65, 21)
        Me.na2.TabIndex = 17
        '
        'nu1
        '
        Me.nu1.Location = New System.Drawing.Point(206, 12)
        Me.nu1.Name = "nu1"
        Me.nu1.Size = New System.Drawing.Size(65, 21)
        Me.nu1.TabIndex = 16
        '
        'na1
        '
        Me.na1.Location = New System.Drawing.Point(58, 12)
        Me.na1.Name = "na1"
        Me.na1.Size = New System.Drawing.Size(65, 21)
        Me.na1.TabIndex = 15
        '
        'Form205
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 105)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.zts)
        Me.Controls.Add(Me.zs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nu2)
        Me.Controls.Add(Me.na2)
        Me.Controls.Add(Me.nu1)
        Me.Controls.Add(Me.na1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form205"
        Me.Text = "鸡兔同笼计算"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents zts As System.Windows.Forms.TextBox
    Friend WithEvents zs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nu2 As System.Windows.Forms.TextBox
    Friend WithEvents na2 As System.Windows.Forms.TextBox
    Friend WithEvents nu1 As System.Windows.Forms.TextBox
    Friend WithEvents na1 As System.Windows.Forms.TextBox
End Class
