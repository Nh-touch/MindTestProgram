Public Class TestMain
    Private Num As Integer = 1
    Private score(12) As String
    Private isBack As Boolean = False
    Private startTime As Date = System.DateTime.Now
    Private Sub TestMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If root = 0 Then
            MsgBox("没有选择类别")
            Exit Sub
        End If
        'Select Case root
        '    Case 1
        '        score = sort1
        '    Case 2
        '        score = sort2
        '    Case 3
        '        score = sort3
        '    Case 4
        '        score = sort4
        '    Case 5
        '        score = sort5
        'End Select
        Timer2.Start()
        If root <= 3 Then
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton4.Visible = True
            RadioButton5.Visible = True
            RadioButton6.Visible = True
            RadioButton10.Checked = True
        Else
            RadioButton1.Checked = True
            RadioButton7.Visible = True
            RadioButton8.Visible = True
            RadioButton9.Visible = True
            RadioButton10.Visible = True
            RadioButton11.Visible = True
            RadioButton12.Visible = True
            RadioButton13.Visible = True
            RadioButton14.Visible = True
        End If
        Label1.Text = nowChoice
        Label2.Text = "第" & Num & "题"
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\TESTS\" & root & "\" & Num & ".jpg")
        If Not setChoice() Then
            releaseAllButton()
        End If
    End Sub

    Private Function setChoice() As Boolean
        Dim b As Boolean = False
        'If root = 1 Or root = 2 Then
        '    Select Case score(Num - 1)
        '        Case 1
        '            RadioButton1.Checked = True
        '            b = True
        '            isBack = True
        '        Case 2
        '            RadioButton2.Checked = True
        '            b = True
        '            isBack = True
        '        Case 3
        '            RadioButton3.Checked = True
        '            b = True
        '            isBack = True
        '        Case 4
        '            RadioButton4.Checked = True
        '            b = True
        '            isBack = True
        '        Case 5
        '            RadioButton5.Checked = True
        '            b = True
        '            isBack = True
        '        Case 6
        '            RadioButton6.Checked = True
        '            b = True
        '            isBack = True
        '    End Select
        'Else
        '    Select Case score(Num - 1)
        '        Case 1
        '            RadioButton7.Checked = True
        '            b = True
        '            isBack = True
        '        Case 2
        '            RadioButton8.Checked = True
        '            b = True
        '            isBack = True
        '        Case 3
        '            RadioButton9.Checked = True
        '            b = True
        '            isBack = True
        '        Case 4
        '            RadioButton10.Checked = True
        '            b = True
        '            isBack = True
        '        Case 5
        '            RadioButton11.Checked = True
        '            b = True
        '            isBack = True
        '        Case 6
        '            RadioButton12.Checked = True
        '            b = True
        '            isBack = True
        '        Case 7
        '            RadioButton13.Checked = True
        '            b = True
        '            isBack = True
        '        Case 8
        '            RadioButton14.Checked = True
        '            b = True
        '            isBack = True
        '    End Select
        'End If
        Return b
    End Function


    Private Function getScore() As Boolean
        Dim a As Boolean = False
        If Me.RadioButton1.Checked = True Then
            score(Num - 1) = 1
            a = True
        End If
        If Me.RadioButton2.Checked = True Then
            score(Num - 1) = 2
            a = True
        End If
        If Me.RadioButton3.Checked = True Then
            score(Num - 1) = 3
            a = True
        End If
        If Me.RadioButton4.Checked = True Then
            score(Num - 1) = 4
            a = True
        End If
        If Me.RadioButton5.Checked = True Then
            score(Num - 1) = 5
            a = True
        End If
        If Me.RadioButton6.Checked = True Then
            score(Num - 1) = 6
            a = True
        End If
        If Me.RadioButton7.Checked = True Then
            score(Num - 1) = 1
            a = True
        End If
        If Me.RadioButton8.Checked = True Then
            score(Num - 1) = 2
            a = True
        End If
        If Me.RadioButton9.Checked = True Then
            score(Num - 1) = 3
            a = True
        End If
        If Me.RadioButton10.Checked = True Then
            score(Num - 1) = 4
            a = True
        End If
        If Me.RadioButton11.Checked = True Then
            score(Num - 1) = 5
            a = True
        End If
        If Me.RadioButton12.Checked = True Then
            score(Num - 1) = 6
            a = True
        End If
        If Me.RadioButton13.Checked = True Then
            score(Num - 1) = 7
            a = True
        End If
        If Me.RadioButton14.Checked = True Then
            score(Num - 1) = 8
            a = True
        End If
        Return a
    End Function

    Private Sub releaseAllButton()
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.RadioButton3.Checked = False
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.RadioButton6.Checked = False
        Me.RadioButton7.Checked = False
        Me.RadioButton8.Checked = False
        Me.RadioButton9.Checked = False
        Me.RadioButton10.Checked = False
        Me.RadioButton11.Checked = False
        Me.RadioButton12.Checked = False
        Me.RadioButton13.Checked = False
        Me.RadioButton14.Checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not getScore() Then
            MsgBox("请先选择一项")
            Exit Sub
        End If
        If Num = 12 And Button1.Text = "完成提交" Then
            score(12) = Me.Label3.Text.Replace("计时：", "").Trim
            Select Case root
                Case 1
                    sort1 = score
                    Form1.Label6.Visible = True
                    Form1.RadioButton1.Enabled = False
                    Form1.RadioButton1.Checked = False
                Case 2
                    sort2 = score
                    Form1.Label7.Visible = True
                    Form1.RadioButton2.Enabled = False
                    Form1.RadioButton2.Checked = False
                Case 3
                    sort3 = score
                    Form1.Label3.Visible = True
                    Form1.RadioButton3.Enabled = False
                    Form1.RadioButton3.Checked = False
                Case 4
                    sort4 = score
                    Form1.Label4.Visible = True
                    Form1.RadioButton4.Enabled = False
                    Form1.RadioButton4.Checked = False
                Case 5
                    sort5 = score
                    Form1.Label5.Visible = True
                    Form1.RadioButton5.Enabled = False
                    Form1.RadioButton5.Checked = False
                Case 6
                    sort6 = score
                    Form1.Label8.Visible = True
                    Form1.RadioButton6.Enabled = False
                    Form1.RadioButton6.Checked = False
            End Select
            Form1.Show()
            Me.Close()
        End If
        newNext()
    End Sub

    Private Sub newNext()
        'If Button1.Text = "完成提交" Then
        '    Exit Sub
        'End If
        If allStart = Nothing Then
            allStart = System.DateTime.Now
        End If
        getScore()
        If Num < 12 Then
            Num += 1
            If Not setChoice() Then
                releaseAllButton()
            End If
            'If Num = 12 Then
            '    Button1.Text = "完成提交"
            '    Button1.Visible = True
            'End If
        ElseIf Num = 12 Then
            Button1.Text = "完成提交"
            Button1.Visible = True
            Exit Sub
        Else
            Exit Sub
        End If
        Label2.Text = "第" & Num & "题"
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\TESTS\" & root & "\" & Num & ".jpg")
        'If Num < 12 Then
        '    getScore()
        '    Num += 1
        '    If Num = 12 Then
        '        Button1.Text = "完成提交"
        '    End If
        'ElseIf Num = 12 Then
        '    Select Case root
        '        Case 1
        '            sort1 = score
        '        Case 2
        '            sort2 = score
        '        Case 3
        '            sort3 = score
        '        Case 4
        '            sort4 = score
        '        Case 5
        '            sort5 = score
        '    End Select
        '    Form1.Show()
        '    Me.Close()
        'Else
        '    Exit Sub
        'End If
        'Label2.Text = "第" & Num & "题"

        'releaseAllButton()
        'PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\TESTS\" & root & "\" & Num & ".jpg")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Num > 1 Then
            Num -= 1
            isBack = True
            setChoice()
        Else
            Exit Sub
        End If
        If Num < 12 Then
            Button1.Text = "下一题"
        End If
        Label2.Text = "第" & Num & "题"
        PictureBox1.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\TESTS\" & root & "\" & Num & ".jpg")
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True And root < 4 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True And root < 4 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True And root < 4 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True And root < 4 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True And root < 4 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True And root < 4 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True And root > 3 Then
            Timer1.Start()
            isBack = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If isBack Then
            isBack = False
            Timer1.Stop()
            Exit Sub
        End If
        newNext()
        Timer1.Stop()
    End Sub

    Private Sub TestMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        If Form1.checkV() Then
            Form1.Button3.Enabled = True
            Form1.Button1.Enabled = False
            allEnd = System.DateTime.Now
            MsgBox("已完成所有试题，请点击测试结果按钮查看结果。")
        End If
        PictureBox1.Dispose()
        Form1.Show()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim timespan As TimeSpan = System.DateTime.Now - startTime
        Label3.Text = "计时：" & timespan.Hours.ToString("D2") & ":" & timespan.Minutes.ToString("D2") & ":" & timespan.Seconds.ToString("D2")
    End Sub

End Class