<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form302
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form302))
        Me.qcbu = New System.Windows.Forms.Button
        Me.clobu = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.time = New System.Windows.Forms.TextBox
        Me.stobu = New System.Windows.Forms.Button
        Me.sr1 = New System.Windows.Forms.TextBox
        Me.xs1 = New System.Windows.Forms.Label
        Me.okbu = New System.Windows.Forms.Button
        Me.nrbu = New System.Windows.Forms.Button
        Me.ti = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'qcbu
        '
        Me.qcbu.Location = New System.Drawing.Point(647, 208)
        Me.qcbu.Name = "qcbu"
        Me.qcbu.Size = New System.Drawing.Size(75, 23)
        Me.qcbu.TabIndex = 17
        Me.qcbu.Text = "清除记录"
        Me.qcbu.UseVisualStyleBackColor = True
        Me.qcbu.Visible = False
        '
        'clobu
        '
        Me.clobu.Location = New System.Drawing.Point(566, 208)
        Me.clobu.Name = "clobu"
        Me.clobu.Size = New System.Drawing.Size(75, 23)
        Me.clobu.TabIndex = 16
        Me.clobu.Text = "退出"
        Me.clobu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "时间(秒)："
        '
        'time
        '
        Me.time.Location = New System.Drawing.Point(405, 208)
        Me.time.MaxLength = 10
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(74, 21)
        Me.time.TabIndex = 14
        '
        'stobu
        '
        Me.stobu.Enabled = False
        Me.stobu.Location = New System.Drawing.Point(485, 208)
        Me.stobu.Name = "stobu"
        Me.stobu.Size = New System.Drawing.Size(75, 23)
        Me.stobu.TabIndex = 13
        Me.stobu.Text = "提前停止"
        Me.stobu.UseVisualStyleBackColor = True
        '
        'sr1
        '
        Me.sr1.AcceptsReturn = True
        Me.sr1.Enabled = False
        Me.sr1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sr1.Location = New System.Drawing.Point(12, 237)
        Me.sr1.MaxLength = 350
        Me.sr1.Multiline = True
        Me.sr1.Name = "sr1"
        Me.sr1.Size = New System.Drawing.Size(817, 176)
        Me.sr1.TabIndex = 12
        '
        'xs1
        '
        Me.xs1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.xs1.Cursor = System.Windows.Forms.Cursors.Default
        Me.xs1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.xs1.Location = New System.Drawing.Point(12, 19)
        Me.xs1.Name = "xs1"
        Me.xs1.Size = New System.Drawing.Size(817, 176)
        Me.xs1.TabIndex = 11
        '
        'okbu
        '
        Me.okbu.Location = New System.Drawing.Point(251, 208)
        Me.okbu.Name = "okbu"
        Me.okbu.Size = New System.Drawing.Size(75, 23)
        Me.okbu.TabIndex = 10
        Me.okbu.Text = "开始"
        Me.okbu.UseVisualStyleBackColor = True
        '
        'nrbu
        '
        Me.nrbu.Location = New System.Drawing.Point(170, 208)
        Me.nrbu.Name = "nrbu"
        Me.nrbu.Size = New System.Drawing.Size(75, 23)
        Me.nrbu.TabIndex = 9
        Me.nrbu.Text = "设置内容"
        Me.nrbu.UseVisualStyleBackColor = True
        '
        'ti
        '
        Me.ti.Interval = 1000
        '
        'Form302
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 433)
        Me.Controls.Add(Me.qcbu)
        Me.Controls.Add(Me.clobu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.stobu)
        Me.Controls.Add(Me.sr1)
        Me.Controls.Add(Me.xs1)
        Me.Controls.Add(Me.okbu)
        Me.Controls.Add(Me.nrbu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form302"
        Me.Text = "打字测试"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents qcbu As System.Windows.Forms.Button
    Friend WithEvents clobu As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.TextBox
    Friend WithEvents stobu As System.Windows.Forms.Button
    Friend WithEvents sr1 As System.Windows.Forms.TextBox
    Friend WithEvents xs1 As System.Windows.Forms.Label
    Friend WithEvents okbu As System.Windows.Forms.Button
    Friend WithEvents nrbu As System.Windows.Forms.Button
    Friend WithEvents ti As System.Windows.Forms.Timer
End Class
