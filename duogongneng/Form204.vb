Public Class Form204
    Dim cl As New CL
    Dim mode As Byte '����ģʽѡ��
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        jg.Text = "��ѡ��Ҫ�����ͼ�����ͣ�������" '��������
        mode = 1
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = True
        la1.Text = "�ϵ�"
        la2.Text = "�µ�"
        la3.Text = "��"
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        mode = 1    '����
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = True
        la1.Text = "�ϵ�"
        la2.Text = "�µ�"
        la3.Text = "��"
        jg.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        mode = 2  '������
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = False
        la1.Text = "��"
        la2.Text = "��"
        la3.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        mode = 3 '������
        x1.Enabled = True
        x2.Enabled = False
        x3.Enabled = False
        la1.Text = "�߳�"
        la2.Text = ""
        la3.Text = ""
        x2.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        mode = 4  '������
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = False
        la1.Text = "��"
        la2.Text = "��"
        la3.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        mode = 5  'ƽ���ı���
        x1.Enabled = True
        x2.Enabled = True
        x3.Enabled = False
        la1.Text = "��"
        la2.Text = "��"
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
                            jg.Text = "�������"
                            Exit Sub
                        End If
                    End If
                Else
                    jg.Text = "�������"
                    Exit Sub
                End If
            End If
        Else
            jg.Text = "�������"
            Exit Sub
        End If
        bas()
    End Sub
    Private Sub bas()
        Const pi As Single = 3.1415
        Dim a As Single, b As Single, c As Single, f As Single
        a = CSng(x1.Text)       '����textbox�ֱ�������
        If x2.Enabled = True Then b = CSng(x2.Text)
        If x3.Enabled = True Then c = CSng(x3.Text)
        Select Case mode
            Case 1 '����
                f = (a + b) * c / 2
            Case 2 '������
                f = a * b
            Case 3 '������
                f = a * a
            Case 4 '������
                f = a * b / 2
            Case 5 '������
                f = a * b
            Case 6 'Բ��
                f = a * a * pi
        End Select
        jg.Text = CStr(Fix(f * 100 + 0.5) / 100)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        mode = 6 'Բ��
        x1.Enabled = True
        x2.Enabled = False
        x3.Enabled = False
        la1.Text = "�뾶"
        la2.Text = ""
        la3.Text = ""
        x2.Text = ""
        x3.Text = ""
        jg.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        jg.Text = "" '���
        x1.Text = ""
        x2.Text = ""
        x3.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close() '�رմ���
    End Sub
End Class