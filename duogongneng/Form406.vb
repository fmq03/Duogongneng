Public Class Form406
    Dim aad As Boolean
    Private Sub Form806_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        p1.Visible = False
        Form1400.Close()
        Formopen.Hide()
        ci = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If x2.Text = "mygame" Then
            Select Case x1.Text
                Case "��Ƿ��Ǯ��"
                    MsgBox("ǷǮ�����̫Ӱ�����ˣ���ô�������¼�أ�", MsgBoxStyle.Critical, "�޷���¼")
                Case "�컹Ǯ����"
                    If aad = False Then
                        MsgBox("��Ȼ�㶼�Ǵ�˧���ˣ����������߻�Ǯ��", MsgBoxStyle.Critical, "�޷���¼")
                    Else
                        MsgBox("����˧�绹������Щ������", MsgBoxStyle.Critical, "�޷���¼")
                    End If
                Case "ûɶ���ˡ�"
                    MsgBox("��Ŷ��������Щ���ˣ�", MsgBoxStyle.Information, "��¼�ɹ���")
                    Formopen.Show()
                    Form1400.Show()
                    Me.Close()
            End Select
        ElseIf x2.Text = "sbsb" Then
            MsgBox("�ڲ������˳����룬���㷢���ˣ�", MsgBoxStyle.Information, "��ʾ")
            Formopen.Show()
            Form1400.Show()
            Me.Close()
        Else
            MsgBox("��������ˣ�", MsgBoxStyle.Critical, "�޷���¼")
        End If
    End Sub

    Private Sub aaa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aaa.CheckedChanged
        aad = False
    End Sub

    Private Sub bbb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbb.CheckedChanged
        aad = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call aaaa()
    End Sub

    Private Sub Form806_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        MsgBox("��ʾ��" & Chr(13) & "�����û�����������һ��һ���ԣ�" & Chr(13) & "��Ҫ����һ������Ȼû��˼��" & _
                 Chr(13) & "������mygame��", MsgBoxStyle.Information, "�ؿ���ʾ��")
    End Sub

    Private Sub x1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x1.SelectedIndexChanged
        If x1.Text = "�컹Ǯ����" Then
            p1.Visible = True
        Else
            p1.Visible = False
        End If
    End Sub
    Private Sub aaaa()
        Dim i As Integer = 0
        MsgBox("������һ����������˳���", MsgBoxStyle.Exclamation, "��ʾ")
        For i = 0 To 60
            MsgBox("������ʾ" & i & "��," & Chr(13) & "���ɣ����꣡" & _
    Chr(13) & "���ͣ�", MsgBoxStyle.Exclamation, "��ʾ")
        Next
        MsgBox("�����˳���" & Chr(13) & "������ʾn��", MsgBoxStyle.Exclamation, "��ʾ")
        MsgBox("�����˳���" & Chr(13) & "������ʾn��", MsgBoxStyle.Exclamation, "��ʾ")
        MsgBox("�����˳���" & Chr(13) & "������ʾn��", MsgBoxStyle.Exclamation, "��ʾ")
        MsgBox("����������˳��ˡ�����������ˣ�886��", MsgBoxStyle.Exclamation, "����")
        Formopen.Show()
        Form1400.Show()
        Me.Close()
    End Sub
End Class