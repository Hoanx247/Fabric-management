Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Text
Public Class List_khachhang_input
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent

    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_local As DataTable
    Private dt_khachhang As DataTable
    Private dt_nhom As DataTable
    Dim stCommand As String = String.Empty
    Dim _update_Ok As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _makh_id As String = String.Empty
    Private _nhomkh_id As String = String.Empty
    Private dr0 As DataRow()
    Private Ischanged As Boolean = False
    Private _Lst_ID As String = String.Empty
    Private IsBusy As Boolean = False
    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        'Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        If Ischanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
        Me.Dispose()
    End Sub

#Region " Load du liệu lên bảng khi mở Form"
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        dt_khachhang = New DataTable
        dt_nhom = New DataTable
        '//
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '//
        Load_Nhom()
    End Sub
    Private Sub Load_Nhom()
        dt_nhom = VpsXmlList_Load("", "", "nhom_khachhang")
        LoadDataToCombox(dt_nhom, cbonhom, "nhomkh", False)
    End Sub
    Private Sub Me_input_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If _Khachhang_status = 1 Then
            Call ClearTextBox_chung()
            cmdSave.Text = "Lưu Lại"
            txtmakhach.Focus()
            _Lbln_action_btn = 1
        ElseIf _Khachhang_status = 2 Then
            Call LoadTextBox_chung()
            txtmakhach.Focus()
            _Lbln_action_btn = 2
            cmdSave.Text = "Cập Nhật"
        ElseIf _Khachhang_status = 3 Then
            Call ClearTextBox_chung()
            cmdSave.Text = "Lưu Lại"
            txtmakhach.Focus()
            _Lbln_action_btn = 1
        End If
    End Sub

    Private Sub LoadTextBox_chung()
        Dim panel As GridPanel = List_Khachhang.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow

        With dgvr
                _makh_id = .Cells("makh_id").Value
                txtmakhach.Text = .Item("makhach").Value
                txtkhachhang.Text = .Item("khachhang").Value
                _nhomkh_id = .Item("nhomkh_id").Value
                cbonhom.Text = .Item("nhomkh").Value
                txtnganhghe.Text = .Item("nganhnghe").Value
                txtdiachi.Text = .Item("diachi").Value
                txtmasothue.Text = .Item("masothue").Value
                txtpeople1.Text = .Item("people_1").Value
                cbochucvu_1.Text = .Item("chucvu_1").Value
                txtTel_1.Text = .Item("tel_1").Value
                txtEmail.Text = .Item("email").Value
                txtWeb.Text = .Item("website").Value
                txtghichu.Text = .Item("ghichu").Value
                dtgiaodich.Value = .Item("ngaygiaodich").Value
            End With

    End Sub

#End Region


    Private Sub ClearTextBox_chung()
        Try
            _makh_id = String.Empty
            txtkhachhang.Text = String.Empty
            txtpeople1.Text = String.Empty
            cbochucvu_1.Text = String.Empty
            txtTel_1.Text = String.Empty
            txtmasothue.Text = String.Empty
            txtnganhghe.Text = String.Empty
            txtdiachi.Text = String.Empty
            txtEmail.Text = String.Empty
            txtWeb.Text = String.Empty
            txtghichu.Text = String.Empty
            _nhomkh_id = String.Empty
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Taophieumoi()
        Dim _Nam As String
        _Nam = Mid$(Now.Year.ToString, 3, 2)
        Dim str_sophieu As String = "KH" & _Nam
        _makh_id = VpsXmlList_CreateID(str_sophieu, "makhach")
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If _Lbln_action_btn = 1 Then
            Taophieumoi()
            '//
            Call Update_Data("", "insert")
            If _update_Ok = True Then
                _update_Ok = False
                If _Khachhang_status = 3 Then
                    Me.Close()
                End If
                'Call Clear_TextBox()
                txtmakhach.Focus()
            End If
        ElseIf _Lbln_action_btn = 2 Then
            If MsgBox("Bạn có muốn sửa nội dung không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
            Me.Close()
        End If
    End Sub


    Private Function CheckData() As Boolean
        CheckData = True
        '//
        Dim _value As String = String.Empty
        Dim firstRow As DataRow = dt_nhom.Select("nhomkh = '" & cbonhom.Text & "'", "").FirstOrDefault()

        If Not firstRow Is Nothing Then
            _nhomkh_id = firstRow.Item("nhomkh_id")
        Else
            _nhomkh_id = String.Empty
            MsgBox("Vui lòng chọn Nhóm Khách Hàng.", MsgBoxStyle.Information, "Thông Báo")
            Exit Function
        End If
        '//

        Dim txt As TextBox = CType(txtmakhach, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mã Hàng.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        '//
        txt = CType(txtkhachhang, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Loại Hàng.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
    End Function

    Private Sub Update_Data(ByVal sqlcommand As String, ByVal command As String)
        If CheckData() = True Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("makh_id='" + ReplaceTextXML(_makh_id) + "' ")
            sbXMLString.Append("makhach='" + ReplaceTextXML(txtmakhach.Text) + "' ")
            sbXMLString.Append("khachhang='" + ReplaceTextXML(txtkhachhang.Text) + "' ")
            sbXMLString.Append("nhomkh_id='" + ReplaceTextXML(_nhomkh_id) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML("") + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_Khachhang_UpSet]", sbXMLString.ToString, command)
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                Ischanged = True
                '//
            End If

        End If
    End Sub


    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub

    Protected Overloads Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            Return MyBase.ProcessDialogKey(Keys.Tab)
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If

    End Function

End Class