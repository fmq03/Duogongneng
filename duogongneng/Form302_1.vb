Public Class Form302_1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(lr1.Text) <= 310 Then
            Form302.ywnr = lr1.Text
            Form302.ok1 = True
            MsgBox("录入成功！", MsgBoxStyle.Information, "打字测试—录入")
            Me.Close()
        Else
            MsgBox("录入失败！文字太多！", MsgBoxStyle.Exclamation, "打字测试—录入")
        End If
    End Sub

    Private Sub Form302_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lr1.Focus()
    End Sub
End Class