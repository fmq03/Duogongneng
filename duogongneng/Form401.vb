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
            Case "һ��һʤ"
                mode = 1
                sy = 1
            Case "������ʤ"
                mode = 2
                sy = 3
            Case "�����ʤ"
                mode = 3
                sy = 5
            Case "ʮһ����ʤ"
                mode = 4
                sy = 11
            Case Else
                mode = 0
        End Select

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If mode = 0 Or sy = 0 Then
            la3.Text = "��ѡ��ģʽ��"
            Exit Sub
        End If
        ti1.Enabled = True
        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        la3.Text = "��ʼ�ˣ�"
        la4.Text = "ʣ��" & sy & "�֣�"
        time = 8
        la6.Text = "���ʤ" & wj & "��"
        la7.Text = "����ʤ" & js & "��"
    End Sub

    Private Sub ti1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti1.Tick
        time = time - 1
        If time = 0 Then
            la5.Text = "��ʱ�ˣ���ֵ��Ի�ʤ��"
            js = js + 1
            time = 8
            sy = sy - 1
            Exit Sub
        End If
        la3.Text = "ʣ��" & time & "��!"
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
            Case "һ��һʤ"
                mode = 1
                sy = 1
            Case "������ʤ"
                mode = 2
                sy = 3
            Case "�����ʤ"
                mode = 3
                sy = 5
            Case "ʮһ����ʤ"
                mode = 4
                sy = 11
            Case Else
                MsgBox("��������", MsgBoxStyle.Critical, "Error")
        End Select
        MsgBox("���Ѿ��ֶ��˳��ó�������", , "��ȭ��Ϸ")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub panduan()
        Randomize()
        B = CInt(Rnd() * 3 + 1)
        Select Case B
            Case 1
                dn.Text = "���Գ�ʯͷ"
                la2.Text = "ʯͷ"
            Case 2
                dn.Text = "���Գ�����"
                la2.Text = "����"
            Case 3
                dn.Text = "���Գ���"
                la2.Text = "��"
        End Select
        Select Case A
            Case 1
                la1.Text = "ʯͷ"
                If A = B Then
                    la5.Text = "��ֶ�ûӮ��"
                ElseIf B = 2 Then
                    la5.Text = "������Ӯ��"
                    wj = wj + 1
                    sy = sy - 1
                ElseIf B = 3 Then
                    la5.Text = "��ֵ���Ӯ��"
                    js = js + 1
                    sy = sy - 1
                End If
            Case 2
                la1.Text = "����"
                If A = B Then
                    la5.Text = "��ֶ�ûӮ��"
                ElseIf B = 3 Then
                    la5.Text = "������Ӯ��"
                    wj = wj + 1
                    sy = sy - 1
                ElseIf B = 2 Then
                    la5.Text = "��ֵ���Ӯ��"
                    js = js + 1
                    sy = sy - 1
                End If
            Case 3
                la1.Text = "��"
                If A = B Then
                    la5.Text = "��ֶ�ûӮ��"
                ElseIf B = 1 Then
                    la5.Text = "������Ӯ��"
                    wj = wj + 1
                    sy = sy - 1
                ElseIf B = 2 Then
                    la5.Text = "��ֵ���Ӯ��"
                    js = js + 1
                    sy = sy - 1
                End If
        End Select
        la4.Text = "ʣ��" & sy & "�֣�"
        time = 8
        la6.Text = "���ʤ" & wj & "��"
        la7.Text = "����ʤ" & js & "��"
        If sy = 0 Then
            ti1.Enabled = False
            If js > wj Then
                MsgBox("��Ϊ����ʤ��" & js & "�֣������ֻʤ��" & wj & "�֣������ⳡ��������ʤ����", MsgBoxStyle.OkOnly, "��ȭ��Ϸ")
            ElseIf js < wj Then
                MsgBox("��Ϊ���ʤ��" & wj & "�֣�������ֻʤ��" & js & "�֣������ⳡ�������ʤ����", MsgBoxStyle.OkOnly, "��ȭ��Ϸ")
            Else
                MsgBox("�����ˣ�", MsgBoxStyle.Critical, "Error")
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
                Case "һ��һʤ"
                    mode = 1
                    sy = 1
                Case "������ʤ"
                    mode = 2
                    sy = 3
                Case "�����ʤ"
                    mode = 3
                    sy = 5
                Case "ʮһ����ʤ"
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