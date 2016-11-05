Public Class Form202
    Dim cl As New CL
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close() '关闭窗体
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        aa.Text = "" '清除屏幕
        bb.Text = ""
        aaa.Text = ""
        bbb.Text = ""
        a.Text = ""
        b.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cl.fisint(0, True, aa, 9) = True And cl.fisint(0, True, bb, 9) = True Then '判断是否合格
            Dim s1 As Integer, s2 As Integer, i As Integer, z As Integer, str As String
            Dim ada As Integer, adb As Integer, aba As String, abb As String '定义相关变量
            s1 = CInt(aa.Text)
            s2 = CInt(bb.Text)
            str = ""
            aba = ""
            abb = "" '给变量赋值
            For ada = 1 To s1 '计算数一因数
                If s1 Mod ada = 0 Then
                    aba = aba & ada & ","
                End If
            Next
            a.Text = aba
            For adb = 1 To s2 '计算数二因数
                If s2 Mod adb = 0 Then
                    abb = abb & adb & ","
                End If
            Next
            b.Text = abb
            For i = s1 To 1 Step -1 '计算最大公因数
                If s1 Mod i = 0 And s2 Mod i = 0 Then Exit For
            Next
            bbb.Text = CStr(i)
            For z = i To 1 Step -1 '计算公因数
                If s1 Mod z = 0 And s2 Mod z = 0 Then
                    str = str & z & ","
                    aaa.Text = str
                End If
            Next
        Else
            MsgBox("无效数字！", MsgBoxStyle.Exclamation, "求公因数及最大")
        End If
    End Sub

End Class