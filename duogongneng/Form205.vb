Public Class Form205
    Dim cl As New CL
    Dim Ana As String, Anu As Integer 'A����������
    Dim Bna As String, Bnu As Integer 'B����������
    Dim ab As Integer, abab As Integer '��ͷ��������
    Private Sub Form205_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        na1.Text = "��" '��ʼ��
        na2.Text = "��"
        nu1.Text = "2"
        nu2.Text = "4"
    End Sub

    Private Sub na1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles na1.TextChanged
        If Len(na1.Text) <= 5 Then 'A�����Ϸ��ж�
            Ana = na1.Text
        Else
            na1.Text = ""
        End If
    End Sub

    Private Sub na2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles na2.TextChanged
        If Len(na2.Text) <= 5 Then 'B�����Ϸ��ж�
            Bna = na2.Text
        Else
            na2.Text = ""
        End If
    End Sub

    Private Sub nu1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nu1.TextChanged
        If cl.fisint(0, True, nu1, 3) = True Then 'A�������Ϸ��ж�
        Else : nu1.Text = ""
        End If
    End Sub

    Private Sub nu2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nu2.TextChanged
        If cl.fisint(0, True, nu2, 3) = True Then 'B�������Ϸ��ж�
        Else : nu2.Text = ""
        End If
    End Sub

    Private Sub zs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zs.TextChanged
        If cl.fisint(0, True, zs, 4) = True Then ' �����Ϸ��ж�
        Else : zs.Text = ""
        End If
    End Sub

    Private Sub zts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zts.TextChanged
        If cl.fisint(0, True, zts, 4) = True Then '�������Ϸ��ж�
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
                    MsgBox(Ana & "��" & i & "ֻ��" & Bna & "��" & s & "ֻ", MsgBoxStyle.Information, "�������")
                    zs.Text = ""
                    zts.Text = ""
                    Exit Sub
                End If
            Next i
            MsgBox("û�н����", MsgBoxStyle.Information, "�������")
            zs.Text = ""
            zts.Text = ""
        Else
            MsgBox("�뽫����Ŀ�ȫ�������ټ��㣡", MsgBoxStyle.Information, "����ͬ������")
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