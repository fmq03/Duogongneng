Public Class Form406
    Dim aad As Boolean
    Private Sub Form806_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        p1.Visible = False
        Form1400.Close()
        Formopen.Hide()
        ci = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If x2.Text = "mygame" Then
            Select Case x1.Text
                Case "你欠我钱！"
                    MsgBox("欠钱神马的太影响风度了，怎么能让你登录呢？", MsgBoxStyle.Critical, "无法登录")
                Case "快还钱来！"
                    If aad = False Then
                        MsgBox("既然你都是大帅哥了，还会这样催还钱吗？", MsgBoxStyle.Critical, "无法登录")
                    Else
                        MsgBox("不是帅哥还敢提这些！滚！", MsgBoxStyle.Critical, "无法登录")
                    End If
                Case "没啥事了。"
                    MsgBox("这才对嘛！别提那些事了！", MsgBoxStyle.Information, "登录成功！")
                    Formopen.Show()
                    Form1400.Show()
                    Me.Close()
            End Select
        ElseIf x2.Text = "sbsb" Then
            MsgBox("内部快速退出密码，被你发现了！", MsgBoxStyle.Information, "提示")
            Formopen.Show()
            Form1400.Show()
            Me.Close()
        Else
            MsgBox("密码错误了！", MsgBoxStyle.Critical, "无法登录")
        End If
    End Sub

    Private Sub aaa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aaa.CheckedChanged
        aad = False
    End Sub

    Private Sub bbb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbb.CheckedChanged
        aad = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call aaaa()
    End Sub

    Private Sub Form806_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        MsgBox("提示：" & Chr(13) & "请在用户名的下拉栏一个一个试！" & Chr(13) & "不要跳过一个！不然没意思！" & _
                 Chr(13) & "密码是mygame！", MsgBoxStyle.Information, "必看提示！")
    End Sub

    Private Sub x1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x1.SelectedIndexChanged
        If x1.Text = "快还钱来！" Then
            p1.Visible = True
        Else
            p1.Visible = False
        End If
    End Sub
    Private Sub aaaa()
        Dim i As Integer = 0
        MsgBox("你觉得我会让你轻松退出吗？", MsgBoxStyle.Exclamation, "提示")
        For i = 0 To 60
            MsgBox("我已显示" & i & "次," & Chr(13) & "狂点吧！少年！" & _
    Chr(13) & "加油！", MsgBoxStyle.Exclamation, "提示")
        Next
        MsgBox("即将退出！" & Chr(13) & "我已显示n次", MsgBoxStyle.Exclamation, "提示")
        MsgBox("即将退出！" & Chr(13) & "我已显示n次", MsgBoxStyle.Exclamation, "提示")
        MsgBox("即将退出！" & Chr(13) & "我已显示n次", MsgBoxStyle.Exclamation, "提示")
        MsgBox("现在你可以退出了。婆婆妈妈的人，886！", MsgBoxStyle.Exclamation, "哈哈")
        Formopen.Show()
        Form1400.Show()
        Me.Close()
    End Sub
End Class