Public Class Formopen
    Dim kk As Boolean = True
    Dim ii(20) As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1100.Show() '����ѧ�������
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1300.Show() '�򿪸������ܳ���
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1400.Show() '�����ֳ���
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        About1.Show() '�򿪹��ڿ�
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call clos() '�رճ����ж�Ҫ���ù��̣�
    End Sub
    ''' <summary>
    ''' �رճ���
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clos()
        If kk = False Then Exit Sub '����kk(�Ƿ�������״̬�������ܹ�)
        If MsgBox("Ҫ�رճ�����", MsgBoxStyle.YesNo, "T_T") = MsgBoxResult.Yes Then
            Call closs()
            ti3.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If kk = False Then Exit Sub '���������ÿ���������������ã�
        Form100.Show()

    End Sub

    Private Sub SjowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form101.Show() '����������������������ã�
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MsgBox("���Ҫ�رռ������(���)", MsgBoxStyle.YesNo, "ȷ��Ŷ") = MsgBoxResult.Yes Then
            Shell("Shutdown.exe -s -t 0") '�ػ�ָ��
        End If
    End Sub
    Public Sub butt(ByVal yn As Boolean)
        If yn = False Then '�ж��Ƿ���������������ִ��ĳЩ����
            kk = False
        Else
            kk = True
        End If
    End Sub


    Private Sub �˳�����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �˳�����ToolStripMenuItem.Click
        Call clos() '�˳�����
    End Sub

    Private Sub link1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link1.LinkClicked
        System.Diagnostics.Process.Start("www.fmq03.icoc.cc") 'ǰ���ҵĸ�����ҳ
    End Sub

    Private Sub ����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����ToolStripMenuItem.Click
        About1.Show() '�򿪹��ڿ�
    End Sub

    Private Sub ���س���ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���س���ToolStripMenuItem1.Click
        Call pand() '���س���
        Call aass(True)
    End Sub

    Private Sub ��ʾ����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ��ʾ����ToolStripMenuItem.Click
        Call huifu() '��ʾ����
        Call aass(False)
    End Sub
    ''' <summary>
    ''' �жϲ��ر��Ե�������Ч��
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub pand() '���������أ�Ŀǰû���뵽�����취�����޷��ָ�����ǰ���ڴ�����д������

        If My.Application.OpenForms.Item("About1") IsNot Nothing Then ii(0) = True Else ii(0) = False '�жϴ����Ƿ��ѱ���
        If kk = False Then
            ii(1) = False
        Else
            If My.Application.OpenForms.Item("Form100") IsNot Nothing Then ii(1) = True Else ii(1) = False
        End If
        If My.Application.OpenForms.Item("Form1100") IsNot Nothing Then ii(3) = True Else ii(3) = False
        If My.Application.OpenForms.Item("Form1300") IsNot Nothing Then ii(4) = True Else ii(4) = False
        If My.Application.OpenForms.Item("Form1400") IsNot Nothing Then ii(5) = True Else ii(5) = False
        If My.Application.OpenForms.Item("Form201") IsNot Nothing Then ii(16) = True Else ii(16) = False
        If My.Application.OpenForms.Item("Form202") IsNot Nothing Then ii(6) = True Else ii(6) = False
        If My.Application.OpenForms.Item("Form203") IsNot Nothing Then ii(7) = True Else ii(7) = False
        If My.Application.OpenForms.Item("Form204") IsNot Nothing Then ii(8) = True Else ii(8) = False
        If My.Application.OpenForms.Item("Form205") IsNot Nothing Then ii(9) = True Else ii(9) = False
        If My.Application.OpenForms.Item("Form301") IsNot Nothing Then ii(10) = True Else ii(10) = False
        If My.Application.OpenForms.Item("Form302") IsNot Nothing Then ii(11) = True Else ii(11) = False
        If My.Application.OpenForms.Item("Form302_1") IsNot Nothing Then ii(12) = True Else ii(12) = False
        If My.Application.OpenForms.Item("Form401") IsNot Nothing Then ii(13) = True Else ii(13) = False
        If My.Application.OpenForms.Item("Form402") IsNot Nothing Then ii(14) = True Else ii(14) = False
        If My.Application.OpenForms.Item("Form406") IsNot Nothing Then ii(15) = True Else ii(15) = False
        Call closs()
    End Sub
    ''' <summary>
    ''' �ָ����صĴ���
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub huifu()
        If ii(0) = True Then About1.Show() '����֮ǰ�洢���Ѵ򿪴������ָ�
        If ii(1) = True Then Form100.Show()
        If ii(3) = True Then Form1100.Show()
        If ii(4) = True Then Form1300.Show()
        If ii(5) = True Then Form1400.Show()
        If ii(6) = True Then Form202.Show()
        If ii(7) = True Then Form203.Show()
        If ii(8) = True Then Form204.Show()
        If ii(9) = True Then Form205.Show()
        If ii(10) = True Then Form301.Show()
        If ii(11) = True Then Form302.Show()
        If ii(12) = True Then Form302_1.Show()
        If ii(13) = True Then Form401.Show()
        If ii(14) = True Then Form402.Show()
        If ii(15) = True Then Form406.Show()
        If ii(16) = True Then Form201.Show()
    End Sub
    ''' <summary>
    ''' ǿ�йر����д���
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub closs()
        On Error GoTo 0 '�桤����
        If kk = True Then Form100.Close() 'ǿ�йر�ÿ�����壬��������on error go to 0
        Form1100.Close()
        Form1300.Close()
        Form1400.Close()
        Form201.Close()
        Form202.Close()
        Form203.Close()
        Form204.Close()
        Form205.Close()
        Form301.Close()
        Form302_1.Close()
        Form302.Close()
        Form401.Close()
        Form402.Close()
        Form406.Close()
        About1.Close()
    End Sub
    ''' <summary>
    ''' ������ʱ�����ظ�����
    ''' </summary>
    ''' <param name="a">�Ƿ���������</param>
    ''' <remarks></remarks>
    Private Sub aass(ByVal a As Boolean)
        If a = True Then
            Me.Visible = False
            ���س���ToolStripMenuItem1.Visible = False
            ��ʾ����ToolStripMenuItem.Visible = True
        Else
            Me.Visible = True
            ���س���ToolStripMenuItem1.Visible = True
            ��ʾ����ToolStripMenuItem.Visible = False
        End If

    End Sub
    ''' <summary>ͼ�����ݿ���</summary> 
    ''' <param name="mode ">ѡ��ģʽ1�༭������2�����3����</param>
    ''' <param name="text">�༭ͼ���Ϸ��������</param>

    Public Sub noti(ByVal mode As Integer, Optional ByVal text As String = "") '�������½���������ͼ��
        Select Case mode
            Case 1
                noti1.Text = "�๦�ܳ���2.0(���԰�)" & Chr(13) & "��ӭʹ��~" & Chr(13) & text
            Case 2
                noti1.Text = "�๦�ܳ���2.0(���԰�)" & Chr(13) & "��ӭʹ��~"
            Case 3
                noti1.Text = noti1.Text & Chr(13) & text
        End Select
    End Sub

    Private Sub ���س���ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���س���ToolStripMenuItem.Click
        If kk = False Then Exit Sub
        Form100.Show() '���������ã��˴�id��������س���ToolStripMenuItem�����ӣ�
    End Sub

    Private Sub noti1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles noti1.MouseDoubleClick
        Form201.Show() '����ʱ˫���ɿ�ݴ�ĳ������
    End Sub

    Private Sub ti3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti3.Tick
        Static i As Integer '�ڹرճ���ʱ����
        i = i + 1
        Me.Opacity = (100 - i) / 100
        If Me.Opacity = 0.01 Then
            ti3.Enabled = False
            End
        End If
    End Sub
    Private Sub ti2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti2.Tick
        Static i As Integer '�ڴ򿪳���ʱ����
        i = i + 1
        Me.Opacity = i / 100
        If i = 100 Then
            Call enn()
        End If
    End Sub
    Private Sub enn()
        ti2.Enabled = False '�رռ�ʱ��ti2��������ti2��رգ�
    End Sub

    Private Sub Formopen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0.01 '��������ʱ��ĳЩ����
        ti2.Enabled = True
        '    Form201.Show()
    End Sub
End Class
