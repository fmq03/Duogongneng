Public Class Form101
    Dim pass As String, tt As Integer
    ' Dim fs As System.IO.FileStream = New System.IO.FileStream(Environment.ExpandEnvironmentVariables("%windir%\system32\taskmgr.exe"), System.IO.FileMode.Open)
    Private Sub Form101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pass = Form100.pass
        If Form100.te2 = True Then
            l2.Text = Form100.na
        End If
        Me.KeyPreview = True
        ti2.Enabled = True

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static aa As Integer
        If Form100.te1 = False Then
            If t1.Text = pass Then
                Call clos()
            Else
                l3.Text = "密码错误！"
            End If
        Else
            If t1.Text = pass Then
                Call clos()
            Else
                aa = aa + 1
                If aa = 3 Then
                    l3.Text = "倒霉了....."
                    '  Shell("shutdown -s -t 0")
                    Exit Sub
                End If
                l3.Text = "密码错误！ 这是第" & aa & "次错了，再错" & 3 - aa & "次关机！"
            End If
        End If
    End Sub
    Private Sub clos()
        l3.Text = "即将退出！"
        If Form100.yinc = True Then
            Formopen.noti1.Visible = True
            Formopen.Visible = True
        End If
        ti3.Enabled = True
        time2.Enabled = False
        Form100.Close()
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If time1.Enabled = False Then time1.Enabled = True
        tt = tt + 1
    End Sub

    Private Sub time1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time1.Tick
        Static aa As Integer
        aa = aa + 1
        If aa = 10 Then
            aa = 0
            Call aa1()
        Else
            l4.Text = "在" & CStr((10 - aa) / 2) & "秒内，再按一次关机"
            If tt = 2 Then Call aa2()
        End If
    End Sub
    Private Sub aa1()
        time1.Enabled = False
        tt = 0
        l4.Text = ""
    End Sub
    Private Sub aa2()
        time1.Enabled = False
        l4.Text = "保重......"
        ' Shell("Shutdown.exe -s -t 3")
    End Sub

    Private Sub Form101_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt = True Then
            If e.KeyCode = Keys.F4 Then
                e.Handled = True
            End If
        End If
        If e.Shift = True Then
            e.Handled = True
        End If
        Select Case e.KeyCode
            Case Keys.Alt

            Case Keys.Shift

            Case Keys.Control

        End Select
    End Sub

    Private Sub ti2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti2.Tick
        Static i As Integer
        i = i + 1
        Me.Opacity = i / 100
        If i = 85 Then
            Call enn()
        End If
    End Sub
    Private Sub enn()
        ti2.Enabled = False
        time2.Enabled = True
    End Sub

    Private Sub ti3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti3.Tick
        Static i As Integer
        i = i + 1
        Me.Opacity = (85 - i) / 100
        If Me.Opacity = 0.01 Then
            ti3.Enabled = False
            Me.Close()

        End If
    End Sub
    
    Private Sub time2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time2.Tick
        Shell("cmd /c taskkill /f /im taskmgr.exe", vbHide)
    End Sub
End Class