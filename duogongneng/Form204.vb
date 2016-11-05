Public Class Form204
    Dim cl As New CL
    Dim mode As Byte '用于模式选择
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        jg.Text = "请选择要计算的图形类型，并输入" '启动设置
        mode = 1
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = True
        la1.Text = "上底"
        la2.Text = "下底"
        la3.Text = "高"
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        mode = 1    '梯形
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = True
        la1.Text = "上底"
        la2.Text = "下底"
        la3.Text = "高"
        jg.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        mode = 2  '长方形
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = False
        la1.Text = "长"
        la2.Text = "宽"
        la3.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        mode = 3 '正方形
        x1.Enabled = True
        x2.Enabled = False
        x3.Enabled = False
        la1.Text = "边长"
        la2.Text = ""
        la3.Text = ""
        x2.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        mode = 4  '三角形
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = False
        la1.Text = "底"
        la2.Text = "高"
        la3.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        mode = 5  '平行四边形
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = False
        la1.Text = "底"
        la2.Text = "高"
        la3.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cl.fsngint(0, x1, 9, 1, 2, 0) = True Then
            If x2.Enabled = True Then
                If cl.fsngint(0, x2, 9, 1, 2, 0) = True Then
                    If x3.Enabled = True Then
                        If cl.fsngint(0, x3, 9, 1, 2, 0) = True Then
                        Else
                            jg.Text = "输入错误！"
                            Exit Sub
                        End If
                    End If
                Else
                    jg.Text = "输入错误！"
                    Exit Sub
                End If
            End If
        Else
            jg.Text = "输入错误！"
            Exit Sub
        End If
        bas()
    End Sub
    Private Sub bas()
        Const pi As Single = 3.1415
        Dim a As Single, b As Single, c As Single, f As Single
        a = CSng(x1.Text)       '三个textbox分别存入变量
        If x2.Enabled = True Then b = CSng(x2.Text)
        If x3.Enabled = True Then c = CSng(x3.Text)
        Select Case mode
            Case 1 '梯形
                f = (a + b) * c / 2
            Case 2 '长方形
                f = a * b
            Case 3 '正方形
                f = a * a
            Case 4 '三角形
                f = a * b / 2
            Case 5 '三角形
                f = a * b
            Case 6 '圆形
                f = a * a * pi
        End Select
        jg.Text = CStr(Fix(f * 100 + 0.5) / 100)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        mode = 6 '圆形
        x1.Enabled = True
        x2.Enabled = False
        x3.Enabled = False
        la1.Text = "半径"
        la2.Text = ""
        la3.Text = ""
        x2.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        jg.Text = "" '清空
        x1.Text = ""
        x2.Text = ""
        x3.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close() '关闭窗体
    End Sub
End Class