Imports System.Text.RegularExpressions '引入命名空间
Public Class CL
    ''' <summary>
    ''' 判断字符串是否为整数（可限定位数）
    ''' </summary>
    ''' <param name="text">所要判断的字符串</param>
    ''' <param name="a">数字的上限</param>
    ''' <param name="b">数字的下限</param>
    ''' <returns>返回是否为数字</returns>
    ''' <remarks></remarks>
    Public Function isint(ByVal text As String, ByVal a As Integer, Optional ByVal b As Integer = 1) As Boolean
        Dim re As Regex = New Regex("^\d{" & CStr(b) & "," & CStr(a) & "}$")
        If text = "" Then Return False
        If re.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' 判断字符串是否为整数（不可限定位数）
    ''' </summary>
    ''' <param name="text">所要判断的字符串</param>
    ''' <returns>返回是否为数字</returns>
    ''' <remarks></remarks>
    Public Function isintt(ByVal text As String) As Boolean
        Dim re As Regex = New Regex("^\d+$")
        If text = "" Then Return False
        If re.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' 判断字符串是否为小数（可限定位数）
    ''' </summary>
    ''' <param name="text">所要判断的字符串</param>
    ''' <param name="a">整数的上限</param>
    ''' <param name="b">整数的下限</param>
    ''' <param name="xa">小数的上限</param>
    ''' <param name="xb">小数的下限</param>
    ''' <returns>返回是否为小数</returns>
    ''' <remarks></remarks>
    Public Function issingle(ByVal text As String, ByVal a As Integer, ByVal xa As Integer, Optional ByVal xb As Integer = 1, Optional ByVal b As Integer = 1) As Boolean
        Dim re As Regex = New Regex("^\d{" & CStr(b) & "," & CStr(a) & "}[.]\d{1," & CStr(xa) & "}$")
        If text = "" Then Return False
        If re.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    '''  判断字符串是否为小数（不可限定位数）
    ''' </summary>
    ''' <param name="text">所要判断的字符串</param>
    ''' <returns>是否为小数</returns>
    ''' <remarks></remarks>
    Public Function issinglee(ByVal text As String) As Boolean
        Dim re As Regex = New Regex("^\d+[.]\d+$")
        If text = "" Then Return False
        If re.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' 判断输入框是否为整数
    ''' </summary>
    ''' <param name="gofalse">当要求不符合时执行什么操作（1提示2清除）</param>
    ''' <param name="canset">是否可以设置上限与下限</param>
    ''' <param name="textbox">所需判断的文本框</param>
    ''' <param name="a">整数的上限（当可设置为true时输入）</param>
    ''' <param name="b">整数的下限（当可设置为true时输入）</param>
    ''' <remarks></remarks>
    Public Function fisint(ByVal gofalse As Integer, ByVal canset As Boolean, ByVal textbox As TextBox, Optional ByVal a As Integer = 10, Optional ByVal b As Integer = 1) As Boolean
        Dim cl As New CL
        If canset = True Then
            If cl.isint(CStr(textbox.Text), a, b) = False Then
                GoTo gozhif
            End If
        Else
            If cl.isintt(CStr(textbox.Text)) = False Then
                GoTo gozhif
            End If
        End If
        Return True
        Exit Function
gozhif:
        Select Case gofalse
            Case 1
                MsgBox("内容不符合要求！(整数要求在" & CStr(b) & "-" & CStr(a) & "之间）", MsgBoxStyle.Critical)
            Case 2
                textbox.Text = ""
            Case 3
                MsgBox("内容不符合要求！(整数要求在" & CStr(b) & "-" & CStr(a) & "之间）", MsgBoxStyle.Critical)
                textbox.Text = ""
            Case 0

        End Select
        Return False
    End Function
    ''' <summary>
    ''' 判断输入框是否为小数
    ''' </summary>
    ''' <param name="gofalse">执行操作（当不符合要求时）（1提示2清除）</param>
    ''' <param name="canset">是否可以设置上限与下限</param>
    ''' <param name="textbox">所需判断的文本框</param>
    ''' <param name="a">整数的上限（当可设置为true时输入</param>
    ''' <param name="b">整数的下限（当可设置为true时输入</param>
    ''' <param name="xa">小数的上限（当可设置为true时输入</param>
    ''' <param name="xb">小数的下限（当可设置为true时输入</param>
    ''' <remarks></remarks>
    Public Function fissingle(ByVal gofalse As Integer, ByVal canset As Boolean, ByVal textbox As TextBox, Optional ByVal a As Integer = 10, Optional ByVal b As Integer = 1, Optional ByVal xa As Integer = 2, Optional ByVal xb As Integer = 1) As Boolean
        Dim cl As New CL
        If canset = True Then
            If cl.issingle(CStr(textbox.Text), a, xa, xb, b) = False Then
                GoTo godof
            End If
        Else
            If cl.issinglee(CStr(textbox.Text)) = False Then
                GoTo godof
            End If
        End If
        Return True
        Exit Function
godof:
        Select Case gofalse
            Case 1
                MsgBox("内容不符合要求！(整数要求在" & CStr(b) & "-" & CStr(a) & "之间，小数，要求在" & CStr(xa) & "位以内）", MsgBoxStyle.Critical)
            Case 2
                TextBox.Text = ""
            Case 3
                MsgBox("内容不符合要求！(整数要求在" & CStr(b) & "-" & CStr(a) & "之间，小数，要求在" & CStr(xa) & "位以内）", MsgBoxStyle.Critical)
                TextBox.Text = ""
            Case 0

        End Select
        Return False
    End Function
    ''' <summary>
    ''' 判断输入框是否为小数或整数
    ''' </summary>
    ''' <param name="gofalse">执行操作（当不符合要求时）（1提示2清除）</param>
    ''' <param name="textbox">所需判断的文本框</param>
    ''' <param name="a">整数的上限（当可设置为true时输入</param>
    ''' <param name="b">整数的下限（当可设置为true时输入</param>
    ''' <param name="xa">小数的上限（当可设置为true时输入</param>
    ''' <param name="xb">小数的下限（当可设置为true时输入</param>
    ''' <remarks></remarks>
    Public Function fsngint(ByVal gofalse As Integer, ByVal textbox As TextBox, Optional ByVal a As Integer = 10, Optional ByVal b As Integer = 1, Optional ByVal xa As Integer = 2, Optional ByVal xb As Integer = 0) As Boolean
        Dim cl As New CL
        If cl.isint(CStr(textbox.Text), a, b) = True Or cl.issingle(CStr(textbox.Text), a, xa, xb, b) = True Then
            Return True
            Exit Function
        End If

        Select Case gofalse
            Case 1
                MsgBox("内容不符合要求！(整数要求在" & CStr(b) & "-" & CStr(a) & "之间，如果有小数，要求在" & CStr(xa) & "位以内）", MsgBoxStyle.Critical)
            Case 2
                textbox.Text = ""
            Case 3
                MsgBox("内容不符合要求！(整数要求在" & CStr(b) & "-" & CStr(a) & "之间，如果有小数，要求在" & CStr(xa) & "位以内）", MsgBoxStyle.Critical)
                textbox.Text = ""
            Case 0
        End Select
        Return False
    End Function
End Class
