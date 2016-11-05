Public Class Form402
    Dim wjy As Integer, dny As Integer, A As Integer, B As Integer, aa As Integer, bb As Integer
    Private Sub Form802_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        aa = 0
        wjys.Text = "玩家赢了" & wjy & "局"
        dnys.Text = "电脑赢了" & dny & "局"
    End Sub
    Private Sub dncq()
        Randomize()
        B = CInt((5 - 0 + 1) * Rnd() + 0)
        Do
            A = CInt((10 - 0 + 1) * Rnd() + 0)
        Loop Until B <= A
        dncs.Text = CStr(A)
        dnchs.Text = CStr(B)
    End Sub
    Private Sub panduan()
        If (B + bb) = aa And (B + bb) = A Then
            MsgBox("无语了！都赢！", , "兄弟哥俩好")
        ElseIf (B + bb) = aa Then
            MsgBox("恭喜玩家获胜！", , "兄弟哥俩好")
            wjy = wjy + 1
        ElseIf (B + bb) = A Then
            MsgBox("恭喜电脑获胜！", , "兄弟哥俩好")
            dny = dny + 1
        Else
            MsgBox("都没赢！", , "兄弟哥俩好")
        End If
        wjys.Text = "玩家赢了" & wjy & "局"
        dnys.Text = "电脑赢了" & dny & "局"
    End Sub

    Private Sub bb0_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb0.CheckedChanged
        aa = 0
    End Sub

    Private Sub bb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb1.CheckedChanged
        aa = 1
    End Sub

    Private Sub bb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb2.CheckedChanged
        aa = 2
    End Sub

    Private Sub bb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb3.CheckedChanged
        aa = 3
    End Sub

    Private Sub bb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb4.CheckedChanged
        aa = 4
    End Sub

    Private Sub bb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb5.CheckedChanged
        aa = 5
    End Sub

    Private Sub bb6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb6.CheckedChanged
        aa = 6
    End Sub

    Private Sub bb7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb7.CheckedChanged
        aa = 7
    End Sub

    Private Sub bb8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb8.CheckedChanged
        aa = 8
    End Sub

    Private Sub bb9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb9.CheckedChanged
        aa = 9
    End Sub

    Private Sub bb10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bb10.CheckedChanged
        aa = 10
    End Sub

    Private Sub b0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b0.Click
        bb = 0
        Call dncq()
        Call panduan()
    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        bb = 1
        Call dncq()
        Call panduan()
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        bb = 2
        Call dncq()
        Call panduan()
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        bb = 3
        Call dncq()
        Call panduan()
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        bb = 4
        Call dncq()
        Call panduan()
    End Sub

    Private Sub b5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b5.Click
        bb = 5
        Call dncq()
        Call panduan()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        aa = 0
        bb0.Checked = True
        wjy = 0
        dny = 0
        dncs.Text = ""
        dnchs.Text = ""
        wjys.Text = "玩家赢了" & wjy & "局"
        dnys.Text = "电脑赢了" & dny & "局"
        MsgBox("重置成功！", , "兄弟哥俩好")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class