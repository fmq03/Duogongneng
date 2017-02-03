<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formopen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formopen))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.noti1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.link1 = New System.Windows.Forms.LinkLabel()
        Me.ti2 = New System.Windows.Forms.Timer(Me.components)
        Me.ti3 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "数学计算程序"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "辅助功能程序"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "娱乐程序"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 117)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "关于"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 146)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "退出"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 175)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "锁屏"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(64, 176)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(39, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "关机"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'noti1
        '
        Me.noti1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.noti1.Icon = CType(resources.GetObject("noti1.Icon"), System.Drawing.Icon)
        Me.noti1.Text = "多功能程序2.0(测试版)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "欢迎使用~"
        Me.noti1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockToolStripMenuItem, Me.ShowsToolStripMenuItem, Me.HideToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(100, 114)
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.LockToolStripMenuItem.Text = "锁屏"
        '
        'ShowsToolStripMenuItem
        '
        Me.ShowsToolStripMenuItem.Name = "ShowsToolStripMenuItem"
        Me.ShowsToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ShowsToolStripMenuItem.Text = "显示程序"
        Me.ShowsToolStripMenuItem.Visible = False
        '
        'HideToolStripMenuItem1
        '
        Me.HideToolStripMenuItem1.Name = "HideToolStripMenuItem1"
        Me.HideToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.HideToolStripMenuItem1.Text = "隐藏程序"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.AboutToolStripMenuItem.Text = "关于"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "退出程序"
        '
        'link1
        '
        Me.link1.AutoSize = True
        Me.link1.Location = New System.Drawing.Point(31, 202)
        Me.link1.Name = "link1"
        Me.link1.Size = New System.Drawing.Size(53, 12)
        Me.link1.TabIndex = 7
        Me.link1.TabStop = True
        Me.link1.Text = "BY FMQ03"
        '
        'ti2
        '
        Me.ti2.Interval = 10
        '
        'ti3
        '
        Me.ti3.Interval = 10
        '
        'Formopen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(128, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.link1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Formopen"
        Me.Text = "多功能程序"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents noti1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents link1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ti2 As System.Windows.Forms.Timer
    Friend WithEvents ti3 As System.Windows.Forms.Timer

End Class
