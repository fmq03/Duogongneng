Public Class Form302
    Dim cl As New CL
    Public ywnr As String, ok1 As Boolean
    Dim ok2 As Boolean, tm As Integer, sj As Integer
    Private Sub Form302_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load '启动配置
        ywnr = ""
        ok1 = False
        ok2 = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrbu.Click '调出副窗口
        Form302_1.Show()
    End Sub

    Private Sub clobu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clobu.Click '关闭
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbu.Click '开始时判断数据是否准备好
        If ok1 = True And ok2 = True Then
            Call kaishi()
        ElseIf ok1 = False And ok2 = False Then
            MsgBox("请设置测试文本和时间！", MsgBoxStyle.Critical, "打字测试")
        ElseIf ok1 = False Then
            MsgBox("请设置测试文本！", MsgBoxStyle.Critical, "打字测试")
            Form302_1.Show()
        ElseIf ok2 = False Then
            If time.Text = "" Then
                MsgBox("请设置时间！", MsgBoxStyle.Critical, "打字测试")
                time.Focus()
            ElseIf Not IsNumeric(time.Text) Then
                MsgBox("时间不是数字！", MsgBoxStyle.Critical, "打字测试")
                Exit Sub
            ElseIf Not CInt(time.Text) Mod 1 = 0 Then
                MsgBox("时间不能是小数！", MsgBoxStyle.Critical, "打字测试")
            End If
        End If
    End Sub

    Private Sub ti_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti.Tick '计时过程
        tm = tm - 1
        time.Text = CStr(tm)
        If tm = 0 Then
            Call jieshu()
            MsgBox("时间到！稍后出结果！", MsgBoxStyle.Information, "打字测试")
            Call panduan()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stobu.Click '提前结束
        Call jieshu()
        MsgBox("已手动停止！稍后出结果！", MsgBoxStyle.Information, "打字测试")
        Call panduan()
    End Sub

    Private Sub time_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.TextChanged '输入时间判断合法
        If cl.fisint(0, True, time, 3) = True Then
            If CInt(time.Text) Mod 1 = 0 Then
                ok2 = True
            Else
                ok2 = False
            End If
        Else
            ok2 = False
        End If
    End Sub
    Private Sub qcbu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qcbu.Click '清理按钮
        Call qingchu()
    End Sub
    Private Sub kaishi()
        sr1.Enabled = True
        time.Enabled = False
        okbu.Enabled = False
        nrbu.Enabled = False
        clobu.Enabled = False
        stobu.Enabled = True
        tm = CInt(time.Text)
        sj = CInt(time.Text)
        ti.Enabled = True
        xs1.Text = ywnr
        sr1.Focus()
    End Sub '开始计时的过程
    Private Sub jieshu()
        ti.Enabled = False
        sr1.Enabled = False
        time.Enabled = True
        okbu.Enabled = True
        nrbu.Enabled = True
        clobu.Enabled = True
        stobu.Enabled = False
    End Sub '结束计时的过程
    Private Sub qingchu()
        time.Text = ""
        ywnr = ""
        ok1 = False
        ok2 = False
        xs1.Text = ""
        sr1.Text = ""
        sr1.Enabled = False
        time.Enabled = True
        okbu.Enabled = True
        nrbu.Enabled = True
        clobu.Enabled = True
        ti.Enabled = False
        stobu.Enabled = False
        MsgBox("已清除！", MsgBoxStyle.Information, "打字测试")
        qcbu.Visible = False
    End Sub '清除内容的过程
    Private Sub panduan()
        Dim bzsr As Integer, yhsr As Integer
        Dim lzs As Integer, zqzs As Integer, cwzs As Integer
        Dim bz() As String, yh() As String
        Dim i1 As Integer, i2 As Integer, i3 As Integer, i4 As Integer, i5 As Integer, i6 As Integer
        Dim ys As Integer
        bzsr = Len(ywnr)
        yhsr = Len(sr1.Text)
        ReDim bz(bzsr)
        ReDim yh(yhsr)
        For i1 = 1 To bzsr
            bz(i1) = Mid(ywnr, i1, 1)
        Next
        For i2 = 1 To yhsr
            yh(i2) = Mid(sr1.Text, i2, 1)
        Next
        For i3 = 1 To yhsr
            For i4 = 1 To bzsr
                If yh(i3) = bz(i4) Then
                    zqzs = zqzs + 1
                    bz(i4) = ""
                    yh(i3) = ""
                    Exit For
                End If
            Next
        Next
        For i5 = 1 To bzsr
            If bz(i5) <> "" Then
                lzs = lzs + 1
            End If
        Next
        For i6 = 1 To yhsr
            If yh(i6) <> "" Then
                cwzs = cwzs + 1
            End If
        Next
        ys = sj - tm
        If MsgBox("用时" & ys & "秒，剩余" & tm & "秒；" & Chr(13) & "原文" & bzsr & "字，输入了" & yhsr & "字；" _
& Chr(13) & "正确字数：" & zqzs & Chr(13) & "错误字数：" & cwzs & Chr(13) & "漏字数：" & lzs & Chr(13) _
 & "要清除内容吗？", MsgBoxStyle.YesNo, "结果") = MsgBoxResult.Yes Then
            Call qingchu()
        Else
            qcbu.Visible = True
        End If
    End Sub '判断输入正确的过程
End Class