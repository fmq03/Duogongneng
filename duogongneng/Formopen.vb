Public Class Formopen
    Dim kk As Boolean = True
    Dim ii(20) As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1100.Show() '打开数学计算程序
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1300.Show() '打开辅助功能程序
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1400.Show() '打开娱乐程序
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        About1.Show() '打开关于框
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call clos() '关闭程序（判定要引用过程）
    End Sub
    ''' <summary>
    ''' 关闭程序
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clos()
        If kk = False Then Exit Sub '调用kk(是否在锁屏状态，否则不能关)
        If MsgBox("要关闭程序吗？", MsgBoxStyle.YesNo, "T_T") = MsgBoxResult.Yes Then
            Call closs()
            ti3.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If kk = False Then Exit Sub '打开锁屏设置框（如果已锁屏则不能用）
        Form100.Show()

    End Sub

    Private Sub SjowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form101.Show() '打开锁屏框（如果已锁屏则不能用）
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MsgBox("真的要关闭计算机吗？(真的)", MsgBoxStyle.YesNo, "确定哦") = MsgBoxResult.Yes Then
            Shell("Shutdown.exe -s -t 0") '关机指令
        End If
    End Sub
    Public Sub butt(ByVal yn As Boolean)
        If yn = False Then '判断是否在锁屏，否则不能执行某些操作
            kk = False
        Else
            kk = True
        End If
    End Sub


    Private Sub 退出程序ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出程序ToolStripMenuItem.Click
        Call clos() '退出程序
    End Sub

    Private Sub link1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link1.LinkClicked
        System.Diagnostics.Process.Start("www.fmq03.icoc.cc") '前往我的个人主页
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        About1.Show() '打开关于框
    End Sub

    Private Sub 隐藏程序ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 隐藏程序ToolStripMenuItem1.Click
        Call pand() '隐藏程序
        Call aass(True)
    End Sub

    Private Sub 显示程序ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 显示程序ToolStripMenuItem.Click
        Call huifu() '显示程序
        Call aass(False)
    End Sub
    ''' <summary>
    ''' 判断并关闭以到达隐藏效果
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pand() '暴力的隐藏，目前没有想到其他办法，还无法恢复隐藏前所在窗体上写的内容

        If My.Application.OpenForms.Item("About1") IsNot Nothing Then ii(0) = True Else ii(0) = False '判断窗体是否已被打开
        If kk = False Then
            ii(1) = False
        Else
            If My.Application.OpenForms.Item("Form100") IsNot Nothing Then ii(1) = True Else ii(1) = False
        End If
        If My.Application.OpenForms.Item("Form1100") IsNot Nothing Then ii(3) = True Else ii(3) = False
        If My.Application.OpenForms.Item("Form1300") IsNot Nothing Then ii(4) = True Else ii(4) = False
        If My.Application.OpenForms.Item("Form1400") IsNot Nothing Then ii(5) = True Else ii(5) = False
        If My.Application.OpenForms.Item("Form201") IsNot Nothing Then ii(16) = True Else ii(16) = False
        If My.Application.OpenForms.Item("Form202") IsNot Nothing Then ii(6) = True Else ii(6) = False
        If My.Application.OpenForms.Item("Form203") IsNot Nothing Then ii(7) = True Else ii(7) = False
        If My.Application.OpenForms.Item("Form204") IsNot Nothing Then ii(8) = True Else ii(8) = False
        If My.Application.OpenForms.Item("Form205") IsNot Nothing Then ii(9) = True Else ii(9) = False
        If My.Application.OpenForms.Item("Form301") IsNot Nothing Then ii(10) = True Else ii(10) = False
        If My.Application.OpenForms.Item("Form302") IsNot Nothing Then ii(11) = True Else ii(11) = False
        If My.Application.OpenForms.Item("Form302_1") IsNot Nothing Then ii(12) = True Else ii(12) = False
        If My.Application.OpenForms.Item("Form401") IsNot Nothing Then ii(13) = True Else ii(13) = False
        If My.Application.OpenForms.Item("Form402") IsNot Nothing Then ii(14) = True Else ii(14) = False
        If My.Application.OpenForms.Item("Form406") IsNot Nothing Then ii(15) = True Else ii(15) = False
        Call closs()
    End Sub
    ''' <summary>
    ''' 恢复隐藏的窗体
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub huifu()
        If ii(0) = True Then About1.Show() '按照之前存储的已打开窗体来恢复
        If ii(1) = True Then Form100.Show()
        If ii(3) = True Then Form1100.Show()
        If ii(4) = True Then Form1300.Show()
        If ii(5) = True Then Form1400.Show()
        If ii(6) = True Then Form202.Show()
        If ii(7) = True Then Form203.Show()
        If ii(8) = True Then Form204.Show()
        If ii(9) = True Then Form205.Show()
        If ii(10) = True Then Form301.Show()
        If ii(11) = True Then Form302.Show()
        If ii(12) = True Then Form302_1.Show()
        If ii(13) = True Then Form401.Show()
        If ii(14) = True Then Form402.Show()
        If ii(15) = True Then Form406.Show()
        If ii(16) = True Then Form201.Show()
    End Sub
    ''' <summary>
    ''' 强行关闭所有窗体
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub closs()
        On Error GoTo 0 '真·暴力
        If kk = True Then Form100.Close() '强行关闭每个窗体，防出错用on error go to 0
        Form1100.Close()
        Form1300.Close()
        Form1400.Close()
        Form201.Close()
        Form202.Close()
        Form203.Close()
        Form204.Close()
        Form205.Close()
        Form301.Close()
        Form302_1.Close()
        Form302.Close()
        Form401.Close()
        Form402.Close()
        Form406.Close()
        About1.Close()
    End Sub
    ''' <summary>
    ''' 在隐藏时不能重复隐藏
    ''' </summary>
    ''' <param name="a">是否正在隐藏</param>
    ''' <remarks></remarks>
    Private Sub aass(ByVal a As Boolean)
        If a = True Then
            Me.Visible = False
            隐藏程序ToolStripMenuItem1.Visible = False
            显示程序ToolStripMenuItem.Visible = True
        Else
            Me.Visible = True
            隐藏程序ToolStripMenuItem1.Visible = True
            显示程序ToolStripMenuItem.Visible = False
        End If

    End Sub
    ''' <summary>图标内容控制</summary> 
    ''' <param name="mode ">选择模式1编辑方框字2清除字3特殊</param>
    ''' <param name="text">编辑图标上方框里的字</param>

    Public Sub noti(ByVal mode As Integer, Optional ByVal text As String = "") '控制右下角任务栏的图标
        Select Case mode
            Case 1
                noti1.Text = "多功能程序2.0(测试版)" & Chr(13) & "欢迎使用~" & Chr(13) & text
            Case 2
                noti1.Text = "多功能程序2.0(测试版)" & Chr(13) & "欢迎使用~"
            Case 3
                noti1.Text = noti1.Text & Chr(13) & text
        End Select
    End Sub

    Private Sub 隐藏程序ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 隐藏程序ToolStripMenuItem.Click
        If kk = False Then Exit Sub
        Form100.Show() '打开锁屏设置（此处id变成了隐藏程序ToolStripMenuItem请无视）
    End Sub

    Private Sub noti1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles noti1.MouseDoubleClick
        Form201.Show() '测试时双击可快捷打开某个窗体
    End Sub

    Private Sub ti3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti3.Tick
        Static i As Integer '在关闭程序时渐隐
        i = i + 1
        Me.Opacity = (100 - i) / 100
        If Me.Opacity = 0.01 Then
            ti3.Enabled = False
            End
        End If
    End Sub
    Private Sub ti2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti2.Tick
        Static i As Integer '在打开程序时渐现
        i = i + 1
        Me.Opacity = i / 100
        If i = 100 Then
            Call enn()
        End If
    End Sub
    Private Sub enn()
        ti2.Enabled = False '关闭计时器ti2（不能在ti2里关闭）
    End Sub

    Private Sub Formopen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.01 '窗体启动时做某些操作
        ti2.Enabled = True
        '    Form201.Show()
    End Sub
End Class
