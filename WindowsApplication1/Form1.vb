Public Class Form1
    Private rule As Boolean = False
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If root <> 0 Then
            'If Not rule Then
            '    MsgBox(" 以下每个题目都有一定的主题，但是每张大的主题图中都缺少一部分，主题图以下有8张小图片，若填补在主题图的缺失部分，可以使整个图案合理与完整，请从每题下面所给出的小图片中找出适合大图案的一张。", , "规则说明")
            '    rule = True
            'End If
            TestMain.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            root = 1
            nowChoice = RadioButton1.Text
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            root = 4
            nowChoice = RadioButton4.Text
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            root = 3
            nowChoice = RadioButton3.Text
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            root = 5
            nowChoice = RadioButton5.Text
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            root = 2
            nowChoice = RadioButton2.Text
        End If
    End Sub

    Public Function checkV() As Boolean
        'For i = 0 To 11
        '    If sort3(i) Is Nothing Or sort4(i) Is Nothing Or sort5(i) Is Nothing Then
        '        Return False
        '    End If
        'Next
        If RadioButton1.Enabled = False And RadioButton2.Enabled = False And RadioButton3.Enabled = False And RadioButton4.Enabled = False And RadioButton5.Enabled = False And RadioButton6.Enabled = False Then
            Return True
        End If
        Return False
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetAll()
    End Sub

    Private Sub resetAll()
        sort1 = Nothing
        sort2 = Nothing
        sort3 = Nothing
        sort4 = Nothing
        sort5 = Nothing
        sort6 = Nothing
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        root = 0
        Button3.Enabled = False
        nowChoice = ""
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Judge.Show()
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        root = 6
        nowChoice = RadioButton6.Text
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If First.IsHandleCreated Then
            First.Dispose()
        End If
    End Sub
End Class
