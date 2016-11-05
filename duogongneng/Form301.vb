Public Class Form301
    Dim cl As New CL
    Dim shi As Integer, S As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If S = True Then
            If cl.fisint(0, True, s1, 9) = True Then
                shi = CInt(s1.Text)
                Ti1.Enabled = True
                rr1.Enabled = False
                rr2.Enabled = False
                Button2.Enabled = True
                la.Text = "已开始计时！"
            Else
                la.Text = "不是整数！"
            End If
        Else
            shi = 0
            ti2.Enabled = True
            la.Text = "已开始！"
            rr1.Enabled = False
            rr2.Enabled = False
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If S = True Then
            Ti1.Enabled = False
            la.Text = "设置时间(秒)"
            rr1.Enabled = True
            rr2.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = False
        Else
            ti2.Enabled = False
            rr1.Enabled = True
            rr2.Enabled = True
            la.Text = "总共" & shi & "秒"
            Button1.Enabled = True
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Ti1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ti1.Tick
        shi = shi - 1
        s1.Text = CStr(shi)
        Button1.Enabled = False
        If shi = 0 Then
            Ti1.Enabled = False
            rr1.Enabled = True
            rr2.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = False
            MsgBox("时间到！", MsgBoxStyle.Information, "计时器")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rr2.CheckedChanged
        S = False
        s1.Enabled = False
        la.Text = "请按开始键开始！"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rr1.CheckedChanged
        S = True
        s1.Enabled = True
        la.Text = "设置时间(秒)"
    End Sub

    Private Sub ti2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti2.Tick
        shi = shi + 1
        s1.Text = CStr(shi)
        Button1.Enabled = False
    End Sub

    Private Sub s1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.TextChanged
        Button1.Enabled = True
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = False
    End Sub
End Class