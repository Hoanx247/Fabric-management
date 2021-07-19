Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Text

Public Class List_nhanvien_input
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Private dt_nhom As DataTable

    Private Ischanged As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _update_Ok As Boolean = False
    Private _Lst_ID As String = String.Empty
    Private _nhom_ID As String = String.Empty
#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        If Ischanged = True Then
            Me.DialogResult = DialogResult.OK
        End If
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_nhom = New DataTable
        '/
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--

        'AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        'AddHandler Super_Dgv.CellClick, AddressOf Super_Dgv_CellClick
        '--
        '//
        Call Load_Nhom()
    End Sub
    Private Sub Load_Nhom()
        dt_nhom = VpsXmlList_Load("", "", "nhom_nhanvien")
        LoadDataToCombox(dt_nhom, cboNhom, "nhom", False)
    End Sub
    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        If _Nhanvien_status = 1 Then
            _Lbln_action_btn = 1
            Call Clear_textbox()
            cmdSave.Text = "Lưu Lại"
            txtmaso.Focus()
        ElseIf _Nhanvien_status = 2 Then
            _Lbln_action_btn = 2
            Call Load_textbox()
            cmdSave.Text = "Cập Nhật"
            txtmaso.Focus()
        End If
    End Sub
    Private Sub Load_textbox()
        Dim panel As GridPanel = List_nhanvien.Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = panel.ActiveRow
        With dgvr
            _Lst_ID = .Cells(_colNV_ID).Value
            txtmaso.Text = .Cells(_colmasonhanvien).Value
            txttennhanvien.Text = .Cells(_coltennhanvien).Value
            cboNhom.Text = .Cells("nhom").Value
            txtdienthoai.Text = .Cells(_coldienthoai).Value
            txtghichu.Text = .Cells(_colghichu).Value
        End With
    End Sub

    Private Sub Clear_textbox()
        'txtmaso.Text = String.Empty
        txttennhanvien.Text = String.Empty
        'txtbophan.Text = String.Empty
        'txtdienthoai.Text = String.Empty
        txtghichu.Text = String.Empty
    End Sub
#End Region

    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub

    Private Sub Taophieumoi()
        Dim _Nam As String
        _Nam = Mid$(Now.Year.ToString, 3, 2)
        Dim str_sophieu As String = "NV" & _Nam
        _Lst_ID = VpsXmlList_CreateID(str_sophieu, "nhanvien")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If _Lbln_action_btn = 1 Then
            Taophieumoi()
            '//
            Call Update_Data("", "insert")
            If _update_Ok = True Then
                _update_Ok = False
                Call Clear_textbox()
                txtmaso.Focus()
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
        Dim firstRow As DataRow = dt_nhom.Select("nhom = '" & cboNhom.Text & "'", "").FirstOrDefault()

        If Not firstRow Is Nothing Then
            _nhom_ID = firstRow.Item("nhom_id")
        Else
            _nhom_ID = String.Empty
            MsgBox("Vui lòng chọn Nhóm.", MsgBoxStyle.Information, "Thông Báo")
            Exit Function
        End If
        '//
        Dim txt As TextBox = CType(txtmaso, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mã Nhân Viên.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        txt = CType(txttennhanvien, TextBox)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Tên Nhân Viên.", "Thông báo")
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
            sbXMLString.Append("nv_id='" + ReplaceTextXML(_Lst_ID) + "' ")
            sbXMLString.Append("masonhanvien='" + ReplaceTextXML(txtmaso.Text) + "' ")
            sbXMLString.Append("tennhanvien='" + ReplaceTextXML(txttennhanvien.Text) + "' ")
            sbXMLString.Append("nhom_id='" + ReplaceTextXML(_nhom_ID) + "' ")
            sbXMLString.Append("bophanlamviec='" + ReplaceTextXML("") + "' ")
            sbXMLString.Append("dienthoai='" + ReplaceTextXML(txtdienthoai.Text) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_NhanVien_UpSet]", sbXMLString.ToString, command)
            _update_Ok = dtControler.UPSET_XML(_dt)
            If _update_Ok = True Then
                Ischanged = True
                '//
            End If

        End If
    End Sub


End Class