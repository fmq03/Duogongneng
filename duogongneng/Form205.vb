Public Class Form205
    Dim cl As New CL
    Dim Ana As String, Anu As Integer 'A物名与腿数
    Dim Bna As String, Bnu As Integer 'B物名与腿数
    Dim ab As Integer, abab As Integer '总头与总腿数
    Private Sub Form205_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        na1.Text = "鸡" '初始化
        na2.Text = "兔"
        nu1.Text = "2"
        nu2.Text = "4"
    End Sub

    Private Sub na1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles na1.TextChanged
        If Len(na1.Text) <= 5 Then 'A物名合法判断
            Ana = na1.Text
        Else
            na1.Text = ""
        End If
    End Sub

    Private Sub na2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles na2.TextChanged
        If Len(na2.Text) <= 5 Then 'B物名合法判断
            Bna = na2.Text
        Else
            na2.Text = ""
        End If
    End Sub

    Private Sub nu1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nu1.TextChanged
        If cl.fisint(0, True, nu1, 3) = True Then 'A物腿数合法判断
        Else : nu1.Text = ""
        End If
    End Sub

    Private Sub nu2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nu2.TextChanged
        If cl.fisint(0, True, nu2, 3) = True Then 'B物腿数合法判断
        Else : nu2.Text = ""
        End If
    End Sub

    Private Sub zs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zs.TextChanged
        If cl.fisint(0, True, zs, 4) = True Then ' 总数合法判断
        Else : zs.Text = ""
        End If
    End Sub

    Private Sub zts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zts.TextChanged
        If cl.fisint(0, True, zts, 4) = True Then '总腿数合法判断
        Else : zts.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer, s As Integer, ok As Boolean = False
        If na1.Text = "" Or na2.Text = "" Then
            ok = False
        ElseIf nu1.Text = "" Or nu2.Text = "" Then
            ok = False
        ElseIf zs.Text = "" Or zts.Text = "" Then
            ok = False
        Else
            ok = True
        End If
        If ok = True Then
            For i = 0 To ab
                s = ab - i
                If i * Anu + s * Bnu = abab Then
                    MsgBox(Ana & "有" & i & "只，" & Bna & "有" & s & "只", MsgBoxStyle.Information, "计算完成")
                    zs.Text = ""
                    zts.Text = ""
                    Exit Sub
                End If
            Next i
            MsgBox("没有结果！", MsgBoxStyle.Information, "计算完成")
            zs.Text = ""
            zts.Text = ""
        Else
            MsgBox("请将上面的框全部填完再计算！", MsgBoxStyle.Information, "鸡兔同笼计算")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        zs.Text = ""
        zts.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class