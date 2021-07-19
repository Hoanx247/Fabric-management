Public Class ClsReadFile
    Public readwrtie As Integer
    Public strdata As New System.Text.StringBuilder(255)
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" _
    (ByVal IpApplication As String, ByVal Ipkeyname As String,
    ByVal IpString As String, ByVal IpFileName As String) As Integer

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" _
    (ByVal IpApplicationName As String, ByVal IpKeyName As String,
    ByVal IpDefault As String, ByVal IPReturnedString As System.Text.StringBuilder,
    ByVal nsize As Integer, ByVal IpFileName As String) As Integer
    '--

#Region "FILE INI"

    Public Sub WriteINIFile(ByVal _tTopic As String, ByVal _tName As String, ByVal _tValue As String, ByVal _tFileName As String)
        If _tTopic.Length = 0 AndAlso _tName.Length = 0 AndAlso _tValue.Length = 0 Then
            Exit Sub
        End If
        Dim arr As String() = _tValue.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim compressedSpaces As String = String.Join(" ", arr)
        WritePrivateProfileString(_tTopic, _tName, compressedSpaces, _tFileName)
    End Sub

    Public Function readIniFile(ByVal _tTopic As String, ByVal _tName As String, ByVal _tFileName As String) As String
        Dim stReturn As String
        GetPrivateProfileString(_tTopic, _tName, "", strdata, 100, _tFileName)
        stReturn = strdata.ToString.Trim
        Dim arr As String() = stReturn.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim compressedSpaces As String = String.Join(" ", arr)
        Return compressedSpaces
    End Function

#End Region

End Class