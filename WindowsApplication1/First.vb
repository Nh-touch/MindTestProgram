Public Class First

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Welcome.Show()
        Me.Hide()
    End Sub

    Private Sub First_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub First_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Form1.IsHandleCreated Then
            Form1.Dispose()
        End If
        If Judge.IsHandleCreated Then
            Judge.Dispose()
        End If
        If TestMain.IsHandleCreated Then
            TestMain.Dispose()
        End If
        If Rules.IsHandleCreated Then
            Rules.Dispose()
        End If
        If Welcome.IsHandleCreated Then
            Welcome.Dispose()
        End If
    End Sub
End Class