Module Module1
    Public sort1(12) As String
    Public sort2(12) As String
    Public sort3(12) As String
    Public sort4(12) As String
    Public sort5(12) As String
    Public sort6(12) As String
    Public names() As String = {"知觉辨别能力", "类同比较能力", "比较推理能力", "系列关系能力", "抽象推理能力", "综合运用能力"}
    Public res1() As String = {4, 5, 1, 2, 6, 3, 6, 2, 1, 3, 4, 5}
    Public res2() As String = {4, 5, 1, 6, 2, 1, 3, 4, 6, 3, 5, 2}
    Public res3() As String = {2, 6, 1, 2, 1, 3, 5, 6, 4, 3, 4, 5}
    Public res4() As String = {8, 2, 3, 8, 7, 4, 5, 1, 7, 6, 2, 1}
    Public res5() As String = {3, 4, 3, 7, 8, 6, 5, 4, 1, 2, 5, 6}
    Public res6() As String = {7, 6, 8, 2, 1, 5, 1, 6, 3, 2, 4, 5}
    Public nowChoice As String = ""
    Public root As Integer
    Public pNum As String = ""
    Public pBorn As String = ""
    Public pSex As String = ""
    Public allStart As Date = Nothing
    Public allEnd As Date = Nothing
    Public Function readData(ByVal path As String) As String
        Dim txtReader As IO.StreamReader = New  _
        IO.StreamReader(path, System.Text.Encoding.Default) '---待补充：检查文件完整性
        Dim data As String = txtReader.ReadToEnd
        txtReader.Close()
        txtReader.Dispose()
        Return data
    End Function

    Public Function getTime() As String
        Try
            'If My.Computer.Network.Ping("www.time.ac.cn") = True Then
            Dim buf(1000000) As Byte
            Dim url As String = "http://www.time.ac.cn/timeflash.asp?user=flash"
            ' MsgBox(My.Computer.Network.Ping("http://www.time.ac.cn/"))
            Dim helper As Net.HttpWebRequest = Net.HttpWebRequest.Create(url)
            Dim response As Net.HttpWebResponse = helper.GetResponse()
            Dim resStream As IO.Stream = response.GetResponseStream()
            Dim count As Integer = resStream.Read(buf, 0, buf.Length)
            Dim str As String = System.Text.Encoding.Default.GetString(buf, 0, count)
            resStream.Close()
            Dim time As String
            Dim Regex As Object = CreateObject("VBSCRIPT.REGEXP")
            Regex.IgnoreCase = True
            Regex.Pattern = "<year>(\d+)</year><month>(\d+)</month><day>(\d+)</day>"
            Dim MM As String = Regex.Execute(str).Item(0).SubMatches(1)
            Dim dd As String = Regex.Execute(str).Item(0).SubMatches(2)
            If MM.Length = 1 Then
                MM = "0" & MM
            End If
            If dd.Length = 1 Then
                dd = "0" & dd
            End If
            time = Regex.Execute(str).Item(0).SubMatches(0) & MM & dd
            ' time = str.Substring(str.IndexOf("<year>") + 6, 4)
            Return time
            'Else
            'Return "fs"
            'End If

        Catch ex As Exception
            Return "fs"
            MsgBox(ex.Message)
        End Try
    End Function
End Module
