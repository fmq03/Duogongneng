'Ŀǰ����
'�����η��Ż��Զ�ȥ�����ţ�ԭ����
'��ʱ�������һ������Ī��������޷�����С��������
Public Class Form201
    'hasd�Ƿ���С����,can0�Ƿ������0,hasnum�Ƿ����κ�һ������(PS:����Ҷ�����QAQ)
    Dim hasd As Boolean, can0 As Boolean, hasnum As Boolean
    Dim fhnum As Integer, fh(9) As Integer   'fhnum ���ŵ����� fh()������ŵ�����
    Dim nums As Integer, numjt(9) As Single  'nums���ֵ����� numjt()�������ֵ�����
    Dim lastnum As Integer, lastfh As Integer 'lastnum��һ������ lastfh��һ������
    Dim innum(9) As Integer, innnum As Integer
    Dim znum As Integer = 0, dnum As Integer = 0
    Enum mat As Integer
        zero
        one
        two
        three
        four
        five
        six
        seven
        eight
        nine
        point
        dpoint 'zero point
        dzero 'double zero
        null ' empty while load
    End Enum
    Enum met As Integer
        add
        subtract
        mutiply
        divide
    End Enum

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button12.Click, Button11.Click, Button10.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click
        Dim num As Integer
        Select Case CType(sender, Control).TabIndex
            Case 10 '0
                If can0 = True Then
                    num = mat.zero
                    t1.Text += "0"
                    If hasnum = True Then
                        can0 = True
                    Else
                        can0 = False
                    End If
                Else
                    Exit Sub
                End If
            Case 11 '00
                If can0 = True Then
                    If hasnum = True Then
                        num = mat.dzero
                        t1.Text = "00"
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            Case 12  '.
                If hasnum = False Then
                    If can0 = True Then
                        num = mat.dpoint
                        t1.Text += "0."
                    Else
                        num = mat.point
                        t1.Text = "."
                    End If
                    can0 = True
                    hasnum = True
                    hasd = True
                Else
                    If hasd = False Then
                        num = mat.point
                        t1.Text += "."
                        hasd = True
                        can0 = True
                        hasnum = True
                    Else
                        Exit Sub
                    End If
                End If
                dnum = 0
            Case 17 To 20 '�Ӽ��˳�
                znum = 0
                If (lastnum = mat.point) Or (lastnum = mat.dpoint) Then t1.Text += "0"
                If fhnum > 8 Then Exit Sub
                If hasnum = True Then
                    Select Case CType(sender, Control).TabIndex
                        Case 17
                            t1.Text = t1.Text + "+"
                            fh(fhnum) = met.add
                        Case 18
                            t1.Text = t1.Text + "-"
                            fh(fhnum) = met.subtract
                        Case 19
                            t1.Text = t1.Text + "��"
                            fh(fhnum) = met.mutiply
                        Case 20
                            If lastnum = mat.zero Then Exit Sub
                            t1.Text = t1.Text + "��"
                            fh(fhnum) = met.divide
                    End Select
                    's
                    Dim s As String = "", ss As String = ""
                    For i As Integer = 1 To znum
                        s += CStr(innum(i))
                    Next
                    ss += CStr(innum(innnum - znum))
                    ss += CStr(innum(innnum - znum) + 1)
                    numjt(nums) = CInt(s + ss)
                    nums += 1
                    innnum = 0
                    innum = {0}
                    MsgBox(numjt(nums))
                    's
                    fhnum += 1
                    num = mat.null
                    hasnum = False
                    hasd = False
                    znum = 0
                    dnum = 0
                    can0 = True
                End If
            Case 1 To 12 '����1-9����
                If (lastnum = mat.zero) And hasnum = False Then
                    t1.Text = t1.Text.Substring(0, t1.Text.Length - 1)
                End If
                If znum > 7 Then Exit Sub
                If dnum > 2 Then Exit Sub
                If hasd = True Then
                    dnum += 1
                Else
                    znum += 1
                End If
                innnum += 1
                can0 = True
                hasnum = True
                num = (CType(sender, Control).TabIndex)
                innum(innnum) = num
                t1.Text += CStr(num)
        End Select
        lastnum = num
    End Sub
    '����
    Private Sub Form201_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hasnum = False
        hasd = False
        can0 = True
        t1.Text = ""
        lastnum = mat.null
    End Sub
    '�˸�(������)�Ѿ�����
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If t1.Text <> "" Then
            t1.Text = t1.Text.Substring(0, t1.Text.Length - 1)
        End If
        If t1.Text = "" Then
            lastnum = 0
            hasnum = False
            hasd = False
            need0 = True
        End If
    End Sub
    '����

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        innnum = 0
        innum = {0}
        znum = 0
        dnum = 0
        fhnum = 0
        nums = 0
        fh = {0}
        numjt = {0}
        lastnum = mat.null
        hasnum = False
        hasd = False
        need0 = True
        t1.Text = ""
        lastnum = 1
    End Sub
    'ON/OFF
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Static i As Integer
        i = i + 1
        Select Case i
            Case 10
                MsgBox("����������ť��ʲô����")
            Case 20
                MsgBox("�𰸻�����ʧ���ġ�")
            Case 50
                MsgBox("С�������������")
            Case 70
                MsgBox("���������û��ʲô�õ�")
            Case 100
                MsgBox("�Բ��㻹�ڰ���")
            Case 150
                MsgBox("����ţ��")
            Case 200
                MsgBox("�������������Ϊ���ã�")
            Case 300
                MsgBox("����1000��ʱ������׵�")
            Case 400
                MsgBox("400")
            Case 500
                MsgBox("500")
            Case 600
                MsgBox("600")
            Case 700
                MsgBox("700")
            Case 800
                MsgBox("800")
            Case 1000
                MsgBox("��ϲ�������������˳ɾͣ���Ҫ�����°��ˣ�")
            Case 1001
                MsgBox("you're side!!!!!!!!!!!!")
                MsgBox("����������������ص�����")
                Shell("Shutdown.exe -s -t 0")
        End Select
    End Sub

End Class