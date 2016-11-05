Public Class Form203
    Dim cl As New CL
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close() '关闭窗体
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AB.Text = "请输入！" '加载窗体时提示
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer, s1 As Integer, s2 As Integer, z As Integer, zz As String '声明相关变量
        If cl.fisint(0, True, aa, 9) = True And cl.fisint(0, True, aa, 9) = True Then    '判断条件是否符合
            s1 = CInt(aa.Text)
            s2 = CInt(bb.Text)
            zz = ""      '给部分变量赋值
            For z = s1 To s1 * s2 Step s1
                If z Mod s1 = 0 And z Mod s2 = 0 Then
                    zz = zz & z & ","
                End If
            Next
            gbs.Text = zz '计算公倍数
            For i = s1 To s1 * s2 Step s1
                If i Mod s1 = 0 And i Mod s2 = 0 Then Exit For
            Next i
            AB.Text = CStr(i) '计算最大公倍数
            A.Text = s1 * 1 & "," & s1 * 2 & "," & s1 * 3 & "," & s1 * 4 & Chr(13) & "," & s1 * 5 & "," & s1 * 6 & "," & s1 * 7 & "..."
            B.Text = s2 * 1 & "," & s2 * 2 & "," & s2 * 3 & "," & s2 * 4 & Chr(13) & "," & s2 * 5 & "," & s2 * 6 & "," & s2 * 7 & "..."
            '显示数1和2的倍数
        Else
            MsgBox("无效数字！", MsgBoxStyle.Exclamation, "求公倍数及最小") '错误提示
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        aa.Text = ""
        bb.Text = ""
        A.Text = ""
        B.Text = ""
        AB.Text = ""
        gbs.Text = "" '清除屏幕
    End Sub
End Class