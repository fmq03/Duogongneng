Public Class Form401
    Dim mode As Integer, time As Integer, wj As Integer, js As Integer, sy As Integer, A As Integer
    Dim B As Integer
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mode = 0
        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
    End Sub

    Private Sub cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb.SelectedIndexChanged
        Select Case cmb.Text
            Case "一局一胜"
                mode = 1
                sy = 1
            Case "三局两胜"
                mode = 2
                sy = 3
            Case "五局三胜"
                mode = 3
                sy = 5
            Case "十一局六胜"
                mode = 4
                sy = 11
            Case Else
                mode = 0
        End Select

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If mode = 0 Or sy = 0 Then
            la3.Text = "请选择模式！"
            Exit Sub
        End If
        ti1.Enabled = True
        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        la3.Text = "开始了！"
        la4.Text = "剩余" & sy & "局！"
        time = 8
        la6.Text = "玩家胜" & wj & "局"
        la7.Text = "电脑胜" & js & "局"
    End Sub

    Private Sub ti1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti1.Tick
        time = time - 1
        If time = 0 Then
            la5.Text = "超时了，这局电脑获胜！"
            js = js + 1
            time = 8
            sy = sy - 1
            Exit Sub
        End If
        la3.Text = "剩余" & time & "秒!"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ti1.Enabled = False
        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        la1.Text = ""
        la2.Text = ""
        la3.Text = ""
        la4.Text = ""
        la5.Text = ""
        la6.Text = ""
        la7.Text = ""
        dn.Text = ""
        time = 0
        sy = 0
        wj = 0
        js = 0
        A = 0
        B = 0
        Select Case cmb.Text
            Case "一局一胜"
                mode = 1
                sy = 1
            Case "三局两胜"
                mode = 2
                sy = 3
            Case "五局三胜"
                mode = 3
                sy = 5
            Case "十一局六胜"
                mode = 4
                sy = 11
            Case Else
                MsgBox("出错啦！", MsgBoxStyle.Critical, "Error")
        End Select
        MsgBox("你已经手动退出该场比赛！", , "猜拳游戏")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub panduan()
        Randomize()
        B = CInt(Rnd() * 3 + 1)
        Select Case B
            Case 1
                dn.Text = "电脑出石头"
                la2.Text = "石头"
            Case 2
                dn.Text = "电脑出剪刀"
                la2.Text = "剪刀"
            Case 3
                dn.Text = "电脑出布"
                la2.Text = "布"
        End Select
        Select Case A
            Case 1
                la1.Text = "石头"
                If A = B Then
                    la5.Text = "这局都没赢！"
                ElseIf B = 2 Then
                    la5.Text = "这局玩家赢！"
                    wj = wj + 1
                    sy = sy - 1
                ElseIf B = 3 Then
                    la5.Text = "这局电脑赢！"
                    js = js + 1
                    sy = sy - 1
                End If
            Case 2
                la1.Text = "剪刀"
                If A = B Then
                    la5.Text = "这局都没赢！"
                ElseIf B = 3 Then
                    la5.Text = "这局玩家赢！"
                    wj = wj + 1
                    sy = sy - 1
                ElseIf B = 2 Then
                    la5.Text = "这局电脑赢！"
                    js = js + 1
                    sy = sy - 1
                End If
            Case 3
                la1.Text = "布"
                If A = B Then
                    la5.Text = "这局都没赢！"
                ElseIf B = 1 Then
                    la5.Text = "这局玩家赢！"
                    wj = wj + 1
                    sy = sy - 1
                ElseIf B = 2 Then
                    la5.Text = "这局电脑赢！"
                    js = js + 1
                    sy = sy - 1
                End If
        End Select
        la4.Text = "剩余" & sy & "局！"
        time = 8
        la6.Text = "玩家胜" & wj & "局"
        la7.Text = "电脑胜" & js & "局"
        If sy = 0 Then
            ti1.Enabled = False
            If js > wj Then
                MsgBox("因为电脑胜了" & js & "局，而玩家只胜了" & wj & "局，所以这场比赛电脑胜利！", MsgBoxStyle.OkOnly, "猜拳游戏")
            ElseIf js < wj Then
                MsgBox("因为玩家胜了" & wj & "局，而电脑只胜了" & js & "局，所以这场比赛玩家胜利！", MsgBoxStyle.OkOnly, "猜拳游戏")
            Else
                MsgBox("出错了！", MsgBoxStyle.Critical, "Error")
            End If
            ti1.Enabled = False
            b1.Enabled = False
            b2.Enabled = False
            b3.Enabled = False
            la1.Text = ""
            la2.Text = ""
            la3.Text = ""
            la4.Text = ""
            la5.Text = ""
            la6.Text = ""
            la7.Text = ""
            dn.Text = ""
            time = 0
            sy = 0
            wj = 0
            js = 0
            A = 0
            B = 0
            Select Case cmb.Text
                Case "一局一胜"
                    mode = 1
                    sy = 1
                Case "三局两胜"
                    mode = 2
                    sy = 3
                Case "五局三胜"
                    mode = 3
                    sy = 5
                Case "十一局六胜"
                    mode = 4
                    sy = 11
                Case Else
                    MsgBox("11111")
            End Select
        End If
    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        A = 1
        Call panduan()
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        A = 2
        Call panduan()
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        A = 3
        Call panduan()
    End Sub
End Class