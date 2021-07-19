Imports System.Text
Public Class frmChange_Password
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private moClsEncrypt As ClsEncrypt
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private _update_ok As Boolean = False
    '//
    Private Sub frmDong_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub frmChange_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moClsEncrypt = New ClsEncrypt
        dtControler = New ListMenuDAL()
    End Sub

    <Obsolete>
    Private Sub btcapnhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btcapnhat.Click
        Dim _Check As Integer = String.Compare(txtmatkhaumoi.Text, txtmatkhaumoi_1.Text, True)
        If _Check <> 0 Then
            MsgBox("Mật Khẩu mới lặp lại không giống nhau. Vui lòng nhập lại.", MsgBoxStyle.Exclamation, "Thông Báo!")
            txtmatkhaumoi.Text = String.Empty
            txtmatkhaumoi_1.Text = String.Empty
            txtmatkhaumoi.Focus()
            Exit Sub
        End If
        '//
        Dim newHash As String = moClsEncrypt.EncryptHD(txtmatkhaucu.Text)
        _Check = String.Compare(strpass, newHash, True)
        If _Check <> 0 Then
            MsgBox("Mật Khẩu cũ không đúng. Vui lòng nhập lại.", MsgBoxStyle.Exclamation, "Thông Báo!")
            txtmatkhaucu.Text = String.Empty
            txtmatkhaucu.Focus()
            Exit Sub
        End If
        If Len(txtmatkhaumoi.Text) < 6 Then
            MsgBox("Mật Khẩu phải hơn 5 ký tự. Vui lòng nhập lại.", MsgBoxStyle.Exclamation, "Thông Báo!")
            txtmatkhaucu.Text = String.Empty
            txtmatkhaucu.Focus()
            Exit Sub
        End If
        '//
        If MsgBox("Bạn có muốn Đổi mật khẩu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            '//
            Dim _matkhaumoi As String = moClsEncrypt.EncryptHD(txtmatkhaumoi.Text)
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("tentruycap='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append("matkhau='" + ReplaceTextXML(_matkhaumoi) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("VpsXmlList_User_UpSet", sbXMLString.ToString, "update_matkhaumoi")
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                Me.Close()
            End If

        End If
        '----
        txtmatkhaucu.Text = String.Empty
        txtmatkhaumoi.Text = String.Empty
        txtmatkhaumoi_1.Text = String.Empty
        '//
        Me.Close()
    End Sub

    Private Sub btThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThoat.Click
        Me.Close()
    End Sub

    Private Sub txtmatkhaumoi_TextChanged(sender As Object, e As EventArgs) Handles txtmatkhaumoi.TextChanged
        Try
            Dim txtbox As TextBox = CType(sender, TextBox)
            Dim theText As String = txtbox.Text
            Dim Letter As String
            Dim SelectionIndex As Integer = txtbox.SelectionStart
            Dim Change As Integer
            For x As Integer = 0 To txtbox.Text.Length - 1
                Letter = txtbox.Text.Substring(x, 1)
                If moClsEncrypt.acceptedChars_Pass.Contains(Letter) = False Then
                    theText = theText.Replace(Letter, String.Empty)
                    Change = 1
                    Beep()
                End If
            Next
            txtbox.Text = theText
            txtbox.Select(SelectionIndex - Change, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtmatkhaumoi_1_TextChanged(sender As Object, e As EventArgs) Handles txtmatkhaumoi_1.TextChanged
        Try
            Dim txtbox As TextBox = CType(sender, TextBox)
            Dim theText As String = txtbox.Text
            Dim Letter As String
            Dim SelectionIndex As Integer = txtbox.SelectionStart
            Dim Change As Integer
            For x As Integer = 0 To txtbox.Text.Length - 1
                Letter = txtbox.Text.Substring(x, 1)
                If moClsEncrypt.acceptedChars_Pass.Contains(Letter) = False Then
                    theText = theText.Replace(Letter, String.Empty)
                    Change = 1
                    Beep()
                End If
            Next
            txtbox.Text = theText
            txtbox.Select(SelectionIndex - Change, 0)
        Catch ex As Exception

        End Try
    End Sub



End Class