Public Class Form302
    Dim cl As New CL
    Public ywnr As String, ok1 As Boolean
    Dim ok2 As Boolean, tm As Integer, sj As Integer
    Private Sub Form302_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load '��������
        ywnr = ""
        ok1 = False
        ok2 = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nrbu.Click '����������
        Form302_1.Show()
    End Sub

    Private Sub clobu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clobu.Click '�ر�
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbu.Click '��ʼʱ�ж������Ƿ�׼����
        If ok1 = True And ok2 = True Then
            Call kaishi()
        ElseIf ok1 = False And ok2 = False Then
            MsgBox("�����ò����ı���ʱ�䣡", MsgBoxStyle.Critical, "���ֲ���")
        ElseIf ok1 = False Then
            MsgBox("�����ò����ı���", MsgBoxStyle.Critical, "���ֲ���")
            Form302_1.Show()
        ElseIf ok2 = False Then
            If time.Text = "" Then
                MsgBox("������ʱ�䣡", MsgBoxStyle.Critical, "���ֲ���")
                time.Focus()
            ElseIf Not IsNumeric(time.Text) Then
                MsgBox("ʱ�䲻�����֣�", MsgBoxStyle.Critical, "���ֲ���")
                Exit Sub
            ElseIf Not CInt(time.Text) Mod 1 = 0 Then
                MsgBox("ʱ�䲻����С����", MsgBoxStyle.Critical, "���ֲ���")
            End If
        End If
    End Sub

    Private Sub ti_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti.Tick '��ʱ����
        tm = tm - 1
        time.Text = CStr(tm)
        If tm = 0 Then
            Call jieshu()
            MsgBox("ʱ�䵽���Ժ�������", MsgBoxStyle.Information, "���ֲ���")
            Call panduan()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stobu.Click '��ǰ����
        Call jieshu()
        MsgBox("���ֶ�ֹͣ���Ժ�������", MsgBoxStyle.Information, "���ֲ���")
        Call panduan()
    End Sub

    Private Sub time_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.TextChanged '����ʱ���жϺϷ�
        If cl.fisint(0, True, time, 3) = True Then
            If CInt(time.Text) Mod 1 = 0 Then
                ok2 = True
            Else
                ok2 = False
            End If
        Else
            ok2 = False
        End If
    End Sub
    Private Sub qcbu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qcbu.Click '����ť
        Call qingchu()
    End Sub
    Private Sub kaishi()
        sr1.Enabled = True
        time.Enabled = False
        okbu.Enabled = False
        nrbu.Enabled = False
        clobu.Enabled = False
        stobu.Enabled = True
        tm = CInt(time.Text)
        sj = CInt(time.Text)
        ti.Enabled = True
        xs1.Text = ywnr
        sr1.Focus()
    End Sub '��ʼ��ʱ�Ĺ���
    Private Sub jieshu()
        ti.Enabled = False
        sr1.Enabled = False
        time.Enabled = True
        okbu.Enabled = True
        nrbu.Enabled = True
        clobu.Enabled = True
        stobu.Enabled = False
    End Sub '������ʱ�Ĺ���
    Private Sub qingchu()
        time.Text = ""
        ywnr = ""
        ok1 = False
        ok2 = False
        xs1.Text = ""
        sr1.Text = ""
        sr1.Enabled = False
        time.Enabled = True
        okbu.Enabled = True
        nrbu.Enabled = True
        clobu.Enabled = True
        ti.Enabled = False
        stobu.Enabled = False
        MsgBox("�������", MsgBoxStyle.Information, "���ֲ���")
        qcbu.Visible = False
    End Sub '������ݵĹ���
    Private Sub panduan()
        Dim bzsr As Integer, yhsr As Integer
        Dim lzs As Integer, zqzs As Integer, cwzs As Integer
        Dim bz() As String, yh() As String
        Dim i1 As Integer, i2 As Integer, i3 As Integer, i4 As Integer, i5 As Integer, i6 As Integer
        Dim ys As Integer
        bzsr = Len(ywnr)
        yhsr = Len(sr1.Text)
        ReDim bz(bzsr)
        ReDim yh(yhsr)
        For i1 = 1 To bzsr
            bz(i1) = Mid(ywnr, i1, 1)
        Next
        For i2 = 1 To yhsr
            yh(i2) = Mid(sr1.Text, i2, 1)
        Next
        For i3 = 1 To yhsr
            For i4 = 1 To bzsr
                If yh(i3) = bz(i4) Then
                    zqzs = zqzs + 1
                    bz(i4) = ""
                    yh(i3) = ""
                    Exit For
                End If
            Next
        Next
        For i5 = 1 To bzsr
            If bz(i5) <> "" Then
                lzs = lzs + 1
            End If
        Next
        For i6 = 1 To yhsr
            If yh(i6) <> "" Then
                cwzs = cwzs + 1
            End If
        Next
        ys = sj - tm
        If MsgBox("��ʱ" & ys & "�룬ʣ��" & tm & "�룻" & Chr(13) & "ԭ��" & bzsr & "�֣�������" & yhsr & "�֣�" _
& Chr(13) & "��ȷ������" & zqzs & Chr(13) & "����������" & cwzs & Chr(13) & "©������" & lzs & Chr(13) _
 & "Ҫ���������", MsgBoxStyle.YesNo, "���") = MsgBoxResult.Yes Then
            Call qingchu()
        Else
            qcbu.Visible = True
        End If
    End Sub '�ж�������ȷ�Ĺ���
End Class