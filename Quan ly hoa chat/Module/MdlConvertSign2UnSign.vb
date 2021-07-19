Imports System
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Text
Imports System.Reflection
Imports Microsoft.VisualBasic

Module MdlConvertSign2UnSign
    Dim VietnameseSigns As String() = New String() {"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", _
                                                                           "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ", _
                                                                           "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"}

    Public Function RemoveSign2Unsign(ByVal str As String) As String
        str = str.Trim
        For i As Integer = 1 To VietnameseSigns.Length - 1
            For j As Integer = 0 To VietnameseSigns(i).Length - 1
                str = str.Replace(VietnameseSigns(i)(j), VietnameseSigns(0)(i - 1))
            Next
        Next
        str = str.Replace(" ", "")
        str = str.ToUpper
        Return str
    End Function

    Public Function Replace_GiaTien(ByVal str As String) As String
        Dim Replace_Scale_1 As String() = New String() {" ", ".,"}
        Dim stGet As String = String.Empty
        'stGet = str
        For i As Integer = 1 To Replace_Scale_1.Length - 1
            For j As Integer = 0 To Replace_Scale_1(i).Length - 1
                str = str.Replace(Replace_Scale_1(i)(j), Replace_Scale_1(0)(i - 1))
            Next
        Next
        stGet = str.Replace(" ", "")
        Return stGet
    End Function
End Module

