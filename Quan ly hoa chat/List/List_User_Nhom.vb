
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Text

Public Class List_User_Nhom
    Private sbXMLString As StringBuilder = New StringBuilder()
    Private clsDev As ClsDevcomponent
    Private moClsExcel As ClsExportExcel
    '//
    Private dtControler As ListMenuDAL
    Private _dt As ListMenuDTO
    Dim dt_local As New DataTable
    '--
    Dim _Load_Ok As Boolean = False
    Dim _Local_ColumnWidth_Changed As Boolean = False
    Dim _Column_Forzen_pos As Byte = 0
    Dim _saveRowIndex As Integer = 0
    Dim _LL1_local As Boolean = False, _LL2_local As Boolean = False, _LL3_local As Boolean = False
    Dim dr2 As DataRow()
    Private _List_group As String() = {}
    Private strList_group As List(Of String) = _List_group.ToList()
    Private _List_Column_Locked As String() = {"ghichu", "dongia", "lvs", "loaimay", "khovai_3", "khovai_4", "khovai_5", "khovai_6", "stt"}
    Private strColumn_Locked As List(Of String) = _List_Column_Locked.ToList()
    Private IsBusy As Boolean = False
    Private _update_ok As Boolean = False
    Private Ischanged As Boolean = False
    Private _Lbln_action_btn As Integer = 0
    Private _Lst_ID As String = String.Empty

#Region " Load du liệu lên bảng khi mở Form"

    Private Sub Me_FormClosing(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                      Handles Me.FormClosing
        Call clsDev.SaveColumn(Super_Dgv.PrimaryGrid, Me.Name.ToString)
        '-------------------
        dt_local.Dispose()
        Super_Dgv.PrimaryGrid.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '//
        clsDev = New ClsDevcomponent
        dtControler = New ListMenuDAL()
        dt_local = New DataTable
        Call clsDev.Format_Super_Dgv(Super_Dgv, _MyFont_GridView - 1)
        '--

        AddHandler Super_Dgv.DataBindingComplete, AddressOf Super_Dgv_DataBindingComplete
        AddHandler Super_Dgv.CellClick, AddressOf Super_Dgv_CellClick
        '--
        AddHandler btnAdd.Click, AddressOf ThemMoi

        AddHandler btnModify.Click, AddressOf ChinhSua
        AddHandler btnDelete.Click, AddressOf Xoa
        '--

    End Sub

    Private Sub Me_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Call Check_administrator(Me.Name.ToString)
        If True = True Then
            'BtnAdd.Enabled = CBool(IIf(_btAdd = True, True, False))
            'BtnModify.Enabled = CBool(IIf(_btModify = True, True, False))
            'BtnDelete.Enabled = CBool(IIf(_btDelete = True, True, False))
            Call Filterdata_Stored()
            '----------------
            _Lbln_action_btn = 1
        Else
            Me.Close()
        End If
    End Sub


#End Region

#Region " Hien thi len tung trang cua Datagrid"


    Private Sub Filterdata_Stored()
        If IsBusy = True Then Exit Sub
        IsBusy = True
        Me.SuspendLayout()
        '//
        sbXMLString = New StringBuilder()
        sbXMLString.Append("<Root>")
        sbXMLString.Append("<DATA ")
        sbXMLString.Append("code='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append("codename='" + ReplaceTextXML("") + "' ")
        sbXMLString.Append(" />")
        sbXMLString.Append("</Root>")
        _dt = New ListMenuDTO("[VpsXmlList_User_Nhom_UpSet]", sbXMLString.ToString, "select")
        dtControler.SELECT_XML(_dt, Super_Dgv.PrimaryGrid)
        IsBusy = False
        Me.ResumeLayout()
    End Sub


    Private Sub Super_Dgv_DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        dtControler.SuperDgv_DataBindingComplete(sender, e, Me.Name.ToString)
        '//
        Dim panel As GridPanel = e.GridPanel
        Dim columns As GridColumnCollection = panel.Columns
        'panel.AddGroup(panel.Columns(_colnhomhc))

        'AddHandler tpress.Tick, AddressOf MyTickHandler
        'tpress.Enabled = True
    End Sub

#End Region


#Region "EXECUTE-DELETE"

    Private Sub ThemMoi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtnhom.Text = String.Empty
            txtghichu.Text = String.Empty
            txtnhom.Focus()
            txtnhom.ReadOnly = False
            txtghichu.ReadOnly = False
            _Lbln_action_btn = 1
            BtnSave.Text = "Lưu Lại"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChinhSua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Try
            If dgvr Is Nothing Then
                Exit Sub
            End If
            txtnhom.ReadOnly = False
            txtghichu.ReadOnly = False
            _Lbln_action_btn = 2
            BtnSave.Text = "Cập Nhật"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Dim st As String = String.Empty
        'Dim stuser As String
        If dgvr Is Nothing Or dgvr.IsDetailRow = True Then
            Exit Sub
        End If
        Dim EmpID As String = dgvr.Cells("nhom_id").Value.ToString
        Dim Code As String = dgvr.Cells("nhom").Value.ToString
        Dim CodeName As String = dgvr.Cells("nhom").Value.ToString
        Dim qs = MsgBox("Bạn chắc chắn muốn xóa tất cả thông tin về:" _
                        & vbCrLf & vbCrLf & " - Nhóm: " & Code,
                        vbInformation + vbYesNo, "Thông báo")
        If qs = vbYes Then
            '//
            sbXMLString = New StringBuilder()
            sbXMLString.Append("<Root>")
            sbXMLString.Append("<DATA ")
            sbXMLString.Append("nhom_id='" + ReplaceTextXML(EmpID) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_User_Nhom_UpSet]", sbXMLString.ToString, "delete")
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                'ISChanged = True
                '//
                Call Filterdata_Stored()
            End If
        Else
            MsgBox("Đã hủy thao tác xóa!", vbExclamation, "Thông báo")
        End If
    End Sub

#End Region

    Private Sub Super_Dgv_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        Dim panel As GridPanel = Super_Dgv.PrimaryGrid
        Dim dgvr As GridRow = CType(panel.ActiveRow, GridRow)
        Try
            If dgvr Is Nothing Then
                txtnhom.Text = String.Empty
                txtghichu.Text = String.Empty
                Exit Sub
            Else
                _Lst_ID = dgvr.Cells("nhom_id").Value.ToString
                txtnhom.Text = dgvr.Cells("nhom").Value.ToString
                txtghichu.Text = dgvr.Cells(_colghichu).Value.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If _Lbln_action_btn = 1 Then
            _Lst_ID = TaoMa_NgauNhien(4)
            Call Update_Data("", "insert")
            If _update_ok = True Then
                _update_ok = False
                txtnhom.Focus()
            End If
        ElseIf _Lbln_action_btn = 2 Then
            If MsgBox("Bạn có muốn sửa nội dung không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
                Call Update_Data("", "update")
            End If
        End If

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        _Lbln_action_btn = 1
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        _Lbln_action_btn = 2
    End Sub

    Private Function CheckData() As Boolean
        CheckData = True

        Dim txt As TextBoxX = CType(txtnhom, TextBoxX)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Mã Công Đoạn.", "Thông báo")
            txt.Focus()
            Exit Function
        End If
        txt = CType(txtnhom, TextBoxX)
        If txt.Text.Trim.Length = 0 Then
            CheckData = False
            MessageBox.Show("Xin vui lòng nhập Công Đoạn.", "Thông báo")
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
            sbXMLString.Append("nhom_id='" + ReplaceTextXML(_Lst_ID) + "' ")
            sbXMLString.Append("makytu='" + ReplaceTextXML("") + "' ")
            sbXMLString.Append("nhom='" + ReplaceTextXML(txtnhom.Text) + "' ")
            sbXMLString.Append("ghichu='" + ReplaceTextXML(txtghichu.Text) + "' ")
            sbXMLString.Append("nguoitao='" + ReplaceTextXML(_stUser_Save) + "' ")
            sbXMLString.Append(" />")
            sbXMLString.Append("</Root>")
            '//
            _dt = New ListMenuDTO("[VpsXmlList_User_Nhom_UpSet]", sbXMLString.ToString, command)
            _update_ok = dtControler.UPSET_XML(_dt)
            If _update_ok = True Then
                Ischanged = True
                '//
                Call Filterdata_Stored()
                '//
            End If

        End If
    End Sub

End Class