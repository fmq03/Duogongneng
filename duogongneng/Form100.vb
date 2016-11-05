Public Class Form100
    Public pass As String = ""
    Dim ttu As Boolean = False
    Dim tuu As Boolean = False
    Public te1 As Boolean, na As String, te2 As Boolean, yinc As Boolean
    Dim mode As Integer, tim As Integer, tis As Integer, times As Integer
    Private Sub Form100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        pa1.Enabled = False
        mode = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        pa1.Enabled = True
        mode = 2
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t3.TextChanged
        If IsNumeric(t3.Text) = True Then
            If Len(t3.Text) <= 10 Then
                If Int(Val(t3.Text) Mod 1) = 0 Then
                Else : t3.Text = ""
                End If
            Else : t3.Text = ""
            End If
        Else : t3.Text = ""
        End If
    End Sub

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged
        If Len(t1.Text) <= 20 Then
            If Len(t1.Text) >= 4 Then
                ttu = True
            Else
                ttu = False
            End If
        Else : t1.Text = ""
        End If

    End Sub

    Private Sub t2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.TextChanged
        If t1.Text = t2.Text Then
            tuu = True
        Else
            tuu = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t4.TextChanged
        If IsNumeric(t4.Text) = True Then
            If Val(t4.Text) < 60 Then
                If Val(t4.Text) Mod 1 = 0 Then
                Else : t4.Text = ""
                End If
            Else : t4.Text = ""
            End If
        Else : t4.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ttu = False Then
            MsgBox("密码小于四位！", MsgBoxStyle.Critical)
            t1.Text = ""
            t2.Text = ""
            t1.Focus()
            Exit Sub
        End If
        If tuu = False Then
            MsgBox("两次密码不一致！", MsgBoxStyle.Critical)
            t1.Text = ""
            t2.Text = ""
            t1.Focus()
            Exit Sub
        End If

        Select Case mode
            Case 1
                Call Formopen.butt(False)
                Call suo()
                Me.Visible = False
            Case 2
                If t3.Text = "" Then t3.Text = "0"
                If t4.Text = "" Then t4.Text = "1"
                tim = CInt(t3.Text)
                tis = CInt(t4.Text)
                times = tis + tim * 60
                time1.Enabled = True
                Call Formopen.butt(False)
                Me.Visible = False
                If cb3.Checked = True Then
                    Formopen.noti1.Visible = False
                    Formopen.Visible = False
                    Formopen.closs()
                    yinc = True
                Else
                    yinc = False
                End If
        End Select
    End Sub
    Private Sub suo()
        pass = t1.Text
        Form101.Show()
        Call Formopen.butt(True)
        Me.Hide()
    End Sub

    Private Sub time1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time1.Tick
        times = times - 1
        Call Formopen.noti(1, Str(times))
        If times = 0 Then Call endd()
    End Sub
    Private Sub endd()
        time1.Enabled = False
        Call suo()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            te1 = True
        Else
            te1 = False
        End If
    End Sub

    Private Sub cb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            te2 = True
            t5.Enabled = True
        Else
            te2 = False
            t5.Enabled = False
        End If
    End Sub

    Private Sub t5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t5.TextChanged
        na = t5.Text
    End Sub
End Class