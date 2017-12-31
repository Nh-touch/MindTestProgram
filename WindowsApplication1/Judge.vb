Public Class Judge

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Judge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "编号：" & pNum
        Dim s(5) As Integer
        Dim time As String = 0
        Dim allseconds As Integer = 0
        allseconds += CInt(sort1(12).Split(":")(2)) + CInt(sort1(12).Split(":")(1)) * 60 + CInt(sort1(12).Split(":")(0)) * 3600
        allseconds += CInt(sort2(12).Split(":")(2)) + CInt(sort2(12).Split(":")(1)) * 60 + CInt(sort2(12).Split(":")(0)) * 3600
        allseconds += CInt(sort3(12).Split(":")(2)) + CInt(sort3(12).Split(":")(1)) * 60 + CInt(sort3(12).Split(":")(0)) * 3600
        allseconds += CInt(sort4(12).Split(":")(2)) + CInt(sort4(12).Split(":")(1)) * 60 + CInt(sort4(12).Split(":")(0)) * 3600
        allseconds += CInt(sort5(12).Split(":")(2)) + CInt(sort5(12).Split(":")(1)) * 60 + CInt(sort5(12).Split(":")(0)) * 3600
        allseconds += CInt(sort6(12).Split(":")(2)) + CInt(sort6(12).Split(":")(1)) * 60 + CInt(sort6(12).Split(":")(0)) * 3600
        Dim st As TimeSpan = allEnd - allStart
        time = st.Hours.ToString("D2") & ":" & st.Minutes.ToString("D2") & ":" & st.Seconds.ToString("D2")
        Dim results As String = ""
        If IO.File.Exists(Application.StartupPath & "\TESTS\5\cfg.txt") Then
            Dim str As String = readData(Application.StartupPath & "\TESTS\5\cfg.txt")
            If str.Trim <> "" Then
                results = str
            End If
        End If
        For i = 0 To 11
            If sort1(i).Trim = res1(i) Then
                s(0) += 1
            End If
            If sort2(i).Trim = res2(i) Then
                s(1) += 1
            End If
            If sort3(i).Trim = res3(i) Then
                s(2) += 1
            End If
            If sort4(i).Trim = res4(i) Then
                s(2) += 1
            End If
            If sort5(i).Trim = res5(i) Then
                s(2) += 1
            End If
            If sort6(i).Trim = res6(i) Then
                s(2) += 1
            End If
        Next
        Dim totalScore As Integer = s(0) + s(1) + s(2) + s(3) + s(4) + s(5)
        If results = "" Then
            If totalScore > 48 Then
                results = "中下"
            ElseIf totalScore > 24 Then
                results = "低能"
            Else
                results = "缺陷"
            End If
        End If
        Label1.Text = "答题正确数：" & "   " & totalScore & "/72" & vbCrLf & vbCrLf & "所用时间:" & "   " & time & vbCrLf & vbCrLf & "根据您的反应时长和答题正确率得出您的创造能力及思维能力："
        Label4.Text = results
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Judge_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If First.IsHandleCreated Then
            First.Dispose()
        End If
    End Sub
End Class